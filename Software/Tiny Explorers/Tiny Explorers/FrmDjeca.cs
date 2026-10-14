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
    public partial class FrmDjeca : Form
    {
        private List<Dijete> _filtriranaDjeca = null;
        private List<Dijete> _svaDjeca = new List<Dijete>();
        private FrmMeniRavnateljice _meniForma;



        public FrmDjeca(FrmMeniRavnateljice meniForma)
        {
            InitializeComponent();
            _meniForma = meniForma;
        }

        public FrmDjeca(FrmMeniRavnateljice meniForma, List<Dijete> filtriranaDjeca) : this(meniForma)
        {
            _filtriranaDjeca = filtriranaDjeca;
        }

        private void FrmDjeca_Load(object sender, EventArgs e)
        {
            if (_filtriranaDjeca != null)
            {
                _svaDjeca = _filtriranaDjeca;
                ShowDjeca(_filtriranaDjeca);
            }
            else
            {
                _svaDjeca = DjecaRepository.GetDjeca();
                ShowDjeca(_svaDjeca);
            }
        }


        private void ShowDjeca(List<Dijete> djeca)
        {
            dgvDjeca.DataSource = null;
            dgvDjeca.AutoGenerateColumns = true;

            var bindingList = new SortableBindingList<Dijete>(djeca);
            var source = new BindingSource(bindingList, null);
            dgvDjeca.DataSource = source;
            dgvDjeca.AllowUserToAddRows = false;

            dgvDjeca.Columns["Id_dijete"].DisplayIndex = 0;
            dgvDjeca.Columns["Ime"].DisplayIndex = 1;
            dgvDjeca.Columns["Prezime"].DisplayIndex = 2;
            dgvDjeca.Columns["Oib"].DisplayIndex = 3;
            dgvDjeca.Columns["Datum_rodenja"].DisplayIndex = 4;
            dgvDjeca.Columns["Alergije"].DisplayIndex = 5;
            dgvDjeca.Columns["Dijete_s_teskocama"].DisplayIndex = 6;

            
            dgvDjeca.Columns["Id_dijete"].HeaderText = "ID djeteta";
            dgvDjeca.Columns["Ime"].HeaderText = "Ime";
            dgvDjeca.Columns["Prezime"].HeaderText = "Prezime";
            dgvDjeca.Columns["Oib"].HeaderText = "OIB";
            dgvDjeca.Columns["Datum_rodenja"].HeaderText = "Datum rođenja";
            dgvDjeca.Columns["Alergije"].HeaderText = "Alergije";
            dgvDjeca.Columns["Dijete_s_teskocama"].HeaderText = "Dijete s teškoćama";

            if (dgvDjeca.Columns.Contains("ImeRoditelja"))
            {
                dgvDjeca.Columns["ImeRoditelja"].HeaderText = "Roditelj";
                dgvDjeca.Columns["ImeRoditelja"].DisplayIndex = 7;
            }

            if (dgvDjeca.Columns.Contains("NazivSkupine"))
            {
                dgvDjeca.Columns["NazivSkupine"].HeaderText = "Skupina";
                dgvDjeca.Columns["NazivSkupine"].DisplayIndex = 8;
            }

            if (dgvDjeca.Columns.Contains("EmailRoditelja"))
            {
                dgvDjeca.Columns["EmailRoditelja"].HeaderText = "Email roditelja";
                dgvDjeca.Columns["EmailRoditelja"].DisplayIndex = 9;
            }

            if (dgvDjeca.Columns.Contains("TelefonRoditelja"))
            {
                dgvDjeca.Columns["TelefonRoditelja"].HeaderText = "Telefon roditelja";
                dgvDjeca.Columns["TelefonRoditelja"].DisplayIndex = 10;
            }

            
            if (dgvDjeca.Columns.Contains("Roditelj_id"))
                dgvDjeca.Columns["Roditelj_id"].Visible = false;

            if (dgvDjeca.Columns.Contains("Skupina_id"))
                dgvDjeca.Columns["Skupina_id"].Visible = false;

            
            foreach (DataGridViewColumn column in dgvDjeca.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.Automatic;
            }
        }

      

        private void ShowDjeca()
        {
            try
            {
                List<Dijete> djeca = DjecaRepository.GetDjeca();
                ShowDjeca(djeca);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Došlo je do greške prilikom dohvaćanja podataka: " + ex.Message,
                                "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtPretraziDjecu_TextChanged(object sender, EventArgs e)
        {
            string unos = txtPretraziDjecu.Text.Trim().ToLower();

            if (string.IsNullOrWhiteSpace(unos))
            {
                ShowDjeca(_svaDjeca);
                return;
            }

            var filtrirano = _svaDjeca.Where(d =>
                d.Ime.ToLower().Contains(unos) ||
                d.Prezime.ToLower().Contains(unos) ||
                d.Oib.ToLower().Contains(unos) ||
                d.Datum_rodenja.ToString("dd.MM.yyyy").Contains(unos) ||
                (d.ImeRoditelja != null && d.ImeRoditelja.ToLower().Contains(unos)) ||
                (d.NazivSkupine != null && d.NazivSkupine.ToLower().Contains(unos)) 
            
            ).ToList();

            ShowDjeca(filtrirano);
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            _meniForma.OpenChildForm(new FrmDodajDijete(_meniForma));

        }


        private void btnGenerirajIzvjestaj_Click(object sender, EventArgs e)
        {
            _meniForma.OpenChildForm(new FrmIzvjestajDijete(_meniForma));
        }

        private void btnUrediDijete_Click(object sender, EventArgs e)
        {
            if (dgvDjeca.SelectedRows.Count > 0)
            {
                Dijete selected = (Dijete)dgvDjeca.SelectedRows[0].DataBoundItem;

                _meniForma.OpenChildForm(new FrmUrediDijete(_meniForma, selected));

            }
            else
            {
                MessageBox.Show("Molimo odaberite dijete za uređivanje.", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnIzbrisiDijete_Click(object sender, EventArgs e)
        {
            if (dgvDjeca.SelectedRows.Count > 0)
            {
                Dijete selected = (Dijete)dgvDjeca.SelectedRows[0].DataBoundItem;

                using (FrmIzbrisiDijete frmIzbrisi = new FrmIzbrisiDijete(selected))
                {
                    if (frmIzbrisi.ShowDialog() == DialogResult.OK)
                    {
                        ShowDjeca(); 
                    }
                }
            }
            else
            {
                MessageBox.Show("Molimo odaberite dijete za brisanje.", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void btnBiljeske_Click(object sender, EventArgs e)
        {
            if (dgvDjeca.CurrentRow?.DataBoundItem is Dijete selectedDijete)
            {
                int dijeteId = selectedDijete.Id_dijete;
                _meniForma.OpenChildForm(new FrmBiljeske(_meniForma));
            }
            else
            {
                MessageBox.Show("Odaberite dijete iz tablice prije otvaranja bilješki.", "Upozorenje");
            }
        }

        private void btnDetalji_Click(object sender, EventArgs e)
        {
            if (dgvDjeca.SelectedRows.Count > 0)
            {
                Dijete selected = (Dijete)dgvDjeca.SelectedRows[0].DataBoundItem;
                _meniForma.OpenChildForm(new FrmPrikaziDetaljeDjeteta(_meniForma, selected));

            }
            else
            {
                MessageBox.Show("Molimo odaberite dijete za prikaz detalja.", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}