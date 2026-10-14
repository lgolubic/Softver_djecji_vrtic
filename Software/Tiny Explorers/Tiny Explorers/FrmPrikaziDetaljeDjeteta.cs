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
    public partial class FrmPrikaziDetaljeDjeteta : Form
    {
        private Dijete _dijete;
        private FrmMeniRavnateljice _meniForma;

        public FrmPrikaziDetaljeDjeteta(FrmMeniRavnateljice meniForma, Dijete dijete)
        {
            InitializeComponent();
            _meniForma = meniForma;
            _dijete = dijete;
        }

    

        private void FrmPrikaziDetaljeDjeteta_Load(object sender, EventArgs e)
        {
            PrikaziDetalje();
        }

        private void PrikaziDetalje()
        {
            var detalji = new List<KeyValuePair<string, string>>()
                {
                    new KeyValuePair<string, string>("ID", _dijete.Id_dijete.ToString()),
                    new KeyValuePair<string, string>("Ime", _dijete.Ime),
                    new KeyValuePair<string, string>("Prezime", _dijete.Prezime),
                    new KeyValuePair<string, string>("OIB", _dijete.Oib),
                    new KeyValuePair<string, string>("Datum rođenja", _dijete.Datum_rodenja.ToString("dd.MM.yyyy")),
                    new KeyValuePair<string, string>("Alergije", _dijete.Alergije),
                    new KeyValuePair<string, string>("Dijete s teškoćama", _dijete.Dijete_s_teskocama == "True" ? "Da" : "Ne"),
                    new KeyValuePair<string, string>("Napomena", _dijete.Napomena ?? "Nema"),
                    new KeyValuePair<string, string>("Roditelj", _dijete.ImeRoditelja ?? "N/A"),
                    new KeyValuePair<string, string>("Email roditelja", _dijete.EmailRoditelja ?? "N/A"),
                    new KeyValuePair<string, string>("Telefon roditelja", _dijete.TelefonRoditelja ?? "N/A"),
                    new KeyValuePair<string, string>("Skupina", _dijete.NazivSkupine ?? "N/A")
                };

            dgvDetaljiDjeteta.DataSource = null;
            dgvDetaljiDjeteta.AutoGenerateColumns = true;
            dgvDetaljiDjeteta.DataSource = detalji;

            dgvDetaljiDjeteta.Columns[0].HeaderText = "Polje";
            dgvDetaljiDjeteta.Columns[1].HeaderText = "Vrijednost";

            dgvDetaljiDjeteta.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDetaljiDjeteta.AllowUserToAddRows = false;
            dgvDetaljiDjeteta.AllowUserToDeleteRows = false;
            dgvDetaljiDjeteta.ReadOnly = true;
            dgvDetaljiDjeteta.RowHeadersVisible = false;

            dgvDetaljiDjeteta.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvDetaljiDjeteta.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

        }

        private void btnZatvoriDetaljeODjetetu_Click(object sender, EventArgs e)
        {
            
            this.Close();
            _meniForma.OpenChildForm(new FrmDjeca(_meniForma));
        }

        
    }
}
