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
    public partial class FrmAktivnostiRavnateljica : Form
    {
        private List<Plan_aktivnosti> _sveAktivnosti = new List<Plan_aktivnosti>();
        private FrmMeniRavnateljice _meniForma;

        public FrmAktivnostiRavnateljica(FrmMeniRavnateljice meniForma)
        {
            InitializeComponent();
            _meniForma = meniForma;
        }

  

        private void FrmAktivnostiRavnateljica_Load(object sender, EventArgs e)
        {
            _sveAktivnosti = AktivnostiRepository.GetAktivnosti();
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

        private void txtPretraziAktivnostiRavnateljica_TextChanged(object sender, EventArgs e)
        {
            string unos = txtPretraziAktivnostiRavnateljica.Text.Trim().ToLower();

            if (string.IsNullOrWhiteSpace(unos))
            {
                ShowAktivnosti(_sveAktivnosti);
                return;
            }

            var filtrirano = _sveAktivnosti.Where(a =>
                a.Naziv.ToLower().Contains(unos) ||
                a.Opis.ToLower().Contains(unos) ||
                a.Komentar.ToLower().Contains(unos) ||
                a.Materijal.ToLower().Contains(unos) ||
                a.Datum.ToString("dd.MM.yyyy").Contains(unos)
            ).ToList();

            ShowAktivnosti(filtrirano);
        }



        private void btnDetaljiAktivnostiRavnateljica_Click(object sender, EventArgs e)
        {

            if (dgvAktivnosti.SelectedRows.Count > 0)
            {
                Plan_aktivnosti selected = (Plan_aktivnosti)dgvAktivnosti.SelectedRows[0].DataBoundItem;
                _meniForma.OpenChildForm(new FrmPrikaziDetaljeAktivnosti(_meniForma, selected));
            }
            else
            {
                MessageBox.Show("Molimo odaberite aktivnost za prikaz detalja.", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
    }
}
