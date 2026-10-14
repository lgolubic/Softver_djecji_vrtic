using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tiny_Explorers.Models;

namespace Tiny_Explorers
{
    public partial class FrmPrikaziDetaljeRacuna : Form
    {
        private Racun _racun;
        private FrmMeniRavnateljice _meniForma;
        public FrmPrikaziDetaljeRacuna(FrmMeniRavnateljice meniForma, Racun racun)
        {
            InitializeComponent();
            _meniForma = meniForma;
            _racun = racun;
        }


        private void btnZatvoriDetaljeRacuna_Click(object sender, EventArgs e)
        {
            this.Close();
            _meniForma.OpenChildForm(new FrmPrikazSvihRacuna());

        }

        private void FrmPrikaziDetaljeRacuna_Load(object sender, EventArgs e)
        {
            PrikaziDetalje();
        }

        private void PrikaziDetalje()
        {
            var detalji = new List<KeyValuePair<string, string>>()
            {
                new KeyValuePair<string, string>("ID računa", _racun.Id_racun.ToString()),
                new KeyValuePair<string, string>("Mjesec", _racun.Mjesec),
                new KeyValuePair<string, string>("Naziv skupine", _racun.Skupina),
                new KeyValuePair<string, string>("Dijete", _racun.ImePrezimeDjeteta),
                new KeyValuePair<string, string>("Dijete s teškoćama", _racun.Dijete_s_teskocama == "True" ? "Da" : "Ne"),
                new KeyValuePair<string, string>("Roditelj", _racun.ImePrezimeRoditelja),
                new KeyValuePair<string, string>("Sati boravka", _racun.Sati_boravka.ToString()),
                new KeyValuePair<string, string>("Broj izostanaka", _racun.Izostanci.ToString()),
                new KeyValuePair<string, string>("Osnovna cijena", _racun.Osnovna_cijena.ToString("F2") + " €"),
                new KeyValuePair<string, string>("Umanjenje zbog izostanaka", _racun.Izostanci_cijena.ToString("F2") + " €"),
                new KeyValuePair<string, string>("Ukupna cijena", _racun.Ukupna_cijena.ToString("F2") + " €"),
                
            };

            dgvDetaljiRacuna.DataSource = null;
            dgvDetaljiRacuna.AutoGenerateColumns = true;
            dgvDetaljiRacuna.DataSource = detalji;

            dgvDetaljiRacuna.Columns[0].HeaderText = "Polje";
            dgvDetaljiRacuna.Columns[1].HeaderText = "Vrijednost";

            dgvDetaljiRacuna.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDetaljiRacuna.AllowUserToAddRows = false;
            dgvDetaljiRacuna.AllowUserToDeleteRows = false;
            dgvDetaljiRacuna.ReadOnly = true;
            dgvDetaljiRacuna.RowHeadersVisible = false;

            dgvDetaljiRacuna.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvDetaljiRacuna.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
        }
    }
}
