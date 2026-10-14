using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tiny_Explorers.Repositories;
using Tiny_Explorers.Models;
using Tiny_Explorers.Helpers;


namespace Tiny_Explorers
{
    public partial class FrmPrikazSvihRacuna : Form
    {
        private List<Racun> _sviRacuni = new List<Racun>();
        public FrmPrikazSvihRacuna()
        {
            InitializeComponent();
        }

        private void FrmPrikazSvihRacuna_Load(object sender, EventArgs e)
        {
            _sviRacuni = RacuniRepository.GetRacuni();
            ShowRacuni(_sviRacuni);
        }

        private void ShowRacuni(List<Racun> racuni)
        {
            dgvRacuni.DataSource = null;
            dgvRacuni.DataSource = racuni;

            var bindingList = new SortableBindingList<Racun>(racuni);
            var source = new BindingSource(bindingList, null);
            dgvRacuni.DataSource = source;
            dgvRacuni.AllowUserToAddRows = false;

            dgvRacuni.Columns["Id_racun"].DisplayIndex = 0;
            dgvRacuni.Columns["Mjesec"].DisplayIndex = 1;
            dgvRacuni.Columns["Skupina"].DisplayIndex = 2;
            dgvRacuni.Columns["ImePrezimeDjeteta"].DisplayIndex = 3;
            dgvRacuni.Columns["Dijete_s_teskocama"].DisplayIndex = 4;
            dgvRacuni.Columns["ImePrezimeRoditelja"].DisplayIndex = 5;
            dgvRacuni.Columns["Sati_boravka"].DisplayIndex = 6;
            dgvRacuni.Columns["Izostanci"].DisplayIndex = 7;
            dgvRacuni.Columns["Osnovna_cijena"].DisplayIndex = 8;
            dgvRacuni.Columns["Izostanci_cijena"].DisplayIndex = 9;
            dgvRacuni.Columns["Ukupna_cijena"].DisplayIndex = 10;

            dgvRacuni.Columns["Roditelj_id"].Visible = false;
            dgvRacuni.Columns["Dijete_id"].Visible = false;


            dgvRacuni.Columns["Id_racun"].HeaderText = "ID računa";
            dgvRacuni.Columns["Mjesec"].HeaderText = "Mjesec";
            dgvRacuni.Columns["Skupina"].HeaderText = "Naziv skupine";
            dgvRacuni.Columns["ImePrezimeDjeteta"].HeaderText = "Dijete";
            dgvRacuni.Columns["Dijete_s_teskocama"].HeaderText = "Dijete s teškoćama";
            dgvRacuni.Columns["ImePrezimeRoditelja"].HeaderText = "Roditelj";
            dgvRacuni.Columns["Sati_boravka"].HeaderText = "Sati boravka";
            dgvRacuni.Columns["Izostanci"].HeaderText = "Broj izostanaka";
            dgvRacuni.Columns["Osnovna_cijena"].HeaderText = "Osnovna cijena";
            dgvRacuni.Columns["Izostanci_cijena"].HeaderText = "Umanjenje zbog izostanaka";
            dgvRacuni.Columns["Ukupna_cijena"].HeaderText = "Ukupna cijena";

            foreach (DataGridViewColumn column in dgvRacuni.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.Automatic;
            }
        }

        private void txtPretraziRacune_TextChanged(object sender, EventArgs e)
        {
            string unos = txtPretraziRacune.Text.Trim().ToLower();

            if (string.IsNullOrWhiteSpace(unos))
            {
                ShowRacuni(_sviRacuni);
                return;
            }

            var filtrirani = _sviRacuni.Where(r =>
                r.Mjesec.ToLower().Contains(unos) ||
                r.Skupina.ToLower().Contains(unos) ||
                r.ImePrezimeDjeteta.ToLower().Contains(unos)
               
              
                
            ).ToList();

            ShowRacuni(filtrirani);
        }

        private void btnDetaljiRacuna_Click(object sender, EventArgs e)
        {
            if (dgvRacuni.SelectedRows.Count > 0)
            {
                Racun selected = (Racun)dgvRacuni.SelectedRows[0].DataBoundItem;

                
                FrmMeniRavnateljice meniForma = this.ParentForm as FrmMeniRavnateljice;
                if (meniForma != null)
                {
                    meniForma.OpenChildForm(new FrmPrikaziDetaljeRacuna(meniForma, selected));
                }
                else
                {
                    
                    FrmPrikaziDetaljeRacuna detaljiForma = new FrmPrikaziDetaljeRacuna(null, selected);
                    detaljiForma.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("Molimo odaberite račun za prikaz detalja.", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
    }
    
}
