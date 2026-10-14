using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tiny_Explorers.Helpers;
using Tiny_Explorers.Models;
using Tiny_Explorers.Repositories;

namespace Tiny_Explorers
{
    public partial class FrmAktivnostiOdgojiteljica : Form
    {
        private FrmMeniOdgojiteljice _meniForma;
        private List<Plan_aktivnosti> _sveAktivnosti = new List<Plan_aktivnosti>();
        
        
        public FrmAktivnostiOdgojiteljica(FrmMeniOdgojiteljice meniForma)
        {
            InitializeComponent();
            _meniForma = meniForma;
        }

        private void FrmAktivnostiOdgojiteljica_Load(object sender, EventArgs e)
        {
            _sveAktivnosti = AktivnostiRepository.GetAktivnosti();

            if (_sveAktivnosti == null || !_sveAktivnosti.Any())
            {
                MessageBox.Show("Nema dostupnih aktivnosti za prikaz.", "Informacija", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            ShowAktivnosti(_sveAktivnosti);
        }
        private void ShowAktivnosti(List<Plan_aktivnosti> aktivnosti)
        {
            dgvAktivnosti.DataSource = null;
            dgvAktivnosti.DataSource = aktivnosti;

            var bindingList = new SortableBindingList<Plan_aktivnosti>(aktivnosti);
            var source = new BindingSource(bindingList, null);
            dgvAktivnosti.DataSource = source;
            dgvAktivnosti.AllowUserToAddRows = false;

            dgvAktivnosti.Columns["Id_plan"].DisplayIndex = 0;
            dgvAktivnosti.Columns["Datum"].DisplayIndex = 1;
            dgvAktivnosti.Columns["Naziv"].DisplayIndex = 2;
            dgvAktivnosti.Columns["Opis"].DisplayIndex = 3;
            dgvAktivnosti.Columns["Komentar"].DisplayIndex = 4;
            dgvAktivnosti.Columns["Materijal"].DisplayIndex = 5;
            dgvAktivnosti.Columns["Realizirano"].DisplayIndex = 6;

            
            if (dgvAktivnosti.Columns.Contains("Skupina_id"))
                dgvAktivnosti.Columns["Skupina_id"].Visible = false;

            
            if (dgvAktivnosti.Columns.Contains("NazivSkupine"))
                dgvAktivnosti.Columns["NazivSkupine"].DisplayIndex = 7;


            dgvAktivnosti.Columns["Id_plan"].HeaderText = "ID aktivnosti";
            dgvAktivnosti.Columns["Datum"].HeaderText = "Datum";
            dgvAktivnosti.Columns["Naziv"].HeaderText = "Naziv";
            dgvAktivnosti.Columns["Opis"].HeaderText = "Opis";
            dgvAktivnosti.Columns["Komentar"].HeaderText = "Komentar";
            dgvAktivnosti.Columns["Materijal"].HeaderText = "Materijal";
            dgvAktivnosti.Columns["Realizirano"].HeaderText = "Realizirano";
            if (dgvAktivnosti.Columns.Contains("NazivSkupine"))
                dgvAktivnosti.Columns["NazivSkupine"].HeaderText = "Naziv skupine";


            foreach (DataGridViewColumn column in dgvAktivnosti.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.Automatic;
            }
        }
        private void ShowAktivnosti()
        {
            var aktivnosti = AktivnostiRepository.GetAktivnosti();

            if (aktivnosti == null || !aktivnosti.Any())
            {
                MessageBox.Show("Nema dostupnih aktivnosti za prikaz.", "Informacija", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            dgvAktivnosti.DataSource = aktivnosti;
        }

        private void txtPretraziAktivnostiOdgojiteljica_TextChanged(object sender, EventArgs e)
        {
            {
                string unos = txtPretraziAktivnostiOdgojiteljica.Text.Trim().ToLower();

                if (string.IsNullOrWhiteSpace(unos))
                {
                    ShowAktivnosti(_sveAktivnosti);
                    return;
                }


                var filtrirano = _sveAktivnosti.Where(a =>
                    (a.Naziv?.ToLower().Contains(unos) ?? false) ||
                    (a.Opis?.ToLower().Contains(unos) ?? false) ||
                    (a.Komentar?.ToLower().Contains(unos) ?? false) ||
                    (a.Materijal?.ToLower().Contains(unos) ?? false) ||
                    (a.NazivSkupine?.ToLower().Contains(unos) ?? false) ||
                    a.Datum.ToString("dd.MM.yyyy").Contains(unos)
                ).ToList();

                ShowAktivnosti(filtrirano);
            }

        }

        private void btnDodajAktivnost_Click(object sender, EventArgs e)
        {
            _meniForma.OpenChildForm(new FrmDodajAktivnost(_meniForma));
        }

        private void btnUrediAktivnost_Click(object sender, EventArgs e)
        {
            if (dgvAktivnosti.SelectedRows.Count == 0 || dgvAktivnosti.SelectedRows[0].DataBoundItem == null)
            {
                MessageBox.Show("Odaberite aktivnost za uređivanje.", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var odabranaAktivnost = dgvAktivnosti.SelectedRows[0].DataBoundItem as Plan_aktivnosti;
            if (odabranaAktivnost == null)
            {
                MessageBox.Show("Dogodila se greška pri dohvaćanju aktivnosti.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _meniForma.OpenChildForm(new FrmUrediAktivnost(odabranaAktivnost, _meniForma));
        }

        private void btnIzbrisiAktivnost_Click(object sender, EventArgs e)
        {
            if (dgvAktivnosti.SelectedRows.Count == 0 || dgvAktivnosti.SelectedRows[0].DataBoundItem == null)
            {
                MessageBox.Show("Odaberite aktivnost za brisanje.", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var odabranaAktivnost = dgvAktivnosti.SelectedRows[0].DataBoundItem as Plan_aktivnosti;
            if (odabranaAktivnost == null)
            {
                MessageBox.Show("Dogodila se greška pri dohvaćanju aktivnosti.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (FrmIzbrisiAktivnost frm = new FrmIzbrisiAktivnost(odabranaAktivnost))
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    _sveAktivnosti = AktivnostiRepository.GetAktivnosti();
                    ShowAktivnosti(_sveAktivnosti);
                }
            }
        }

        private void btnDetaljiAktivnostiOdgojiteljica_Click(object sender, EventArgs e)
        {
            if (dgvAktivnosti.SelectedRows.Count == 0 || dgvAktivnosti.SelectedRows[0].DataBoundItem == null)
            {
                MessageBox.Show("Molimo odaberite aktivnost za prikaz detalja.", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var item = dgvAktivnosti.SelectedRows[0].DataBoundItem as Plan_aktivnosti;
            if (item == null)
            {
                MessageBox.Show("Dogodila se greška pri dohvaćanju aktivnosti.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _meniForma.OpenChildForm(new FrmPrikaziDetaljeAktivnostiOdgojiteljica(_meniForma, item));
        }
    }
    
}
