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
    public partial class FrmPrikaziDetaljeAktivnosti : Form
    {
        private Plan_aktivnosti _aktivnost;
        private FrmMeniRavnateljice _meniForma;

        public FrmPrikaziDetaljeAktivnosti(FrmMeniRavnateljice meniForma, Plan_aktivnosti aktivnost)
        {
            InitializeComponent();
            _meniForma = meniForma;
            _aktivnost = aktivnost;
        }

      

        private void FrmPrikaziDetaljeAktivnosti_Load(object sender, EventArgs e)
        {
            PrikaziDetalje();
        }

        private void PrikaziDetalje()
        {
            var detalji = new List<KeyValuePair<string, string>>()
            {
                new KeyValuePair<string, string>("ID aktivnosti", _aktivnost.Id_plan.ToString()),
                new KeyValuePair<string, string>("Naziv", _aktivnost.Naziv),
                new KeyValuePair<string, string>("Datum", _aktivnost.Datum.ToString("dd.MM.yyyy")),
                new KeyValuePair<string, string>("Opis", _aktivnost.Opis),
                new KeyValuePair<string, string>("Komentar", _aktivnost.Komentar),
                new KeyValuePair<string, string>("Materijal", _aktivnost.Materijal),
                new KeyValuePair<string, string>("Realizirano", _aktivnost.Realizirano),
                 new KeyValuePair<string, string>("Skupina", _aktivnost.NazivSkupine ?? "N/A")
            };

            dgvDetaljiAktivnosti.DataSource = null;
            dgvDetaljiAktivnosti.AutoGenerateColumns = true;
            dgvDetaljiAktivnosti.DataSource = detalji;

            dgvDetaljiAktivnosti.Columns[0].HeaderText = "Polje";
            dgvDetaljiAktivnosti.Columns[1].HeaderText = "Vrijednost";

            dgvDetaljiAktivnosti.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDetaljiAktivnosti.AllowUserToAddRows = false;
            dgvDetaljiAktivnosti.AllowUserToDeleteRows = false;
            dgvDetaljiAktivnosti.ReadOnly = true;
            dgvDetaljiAktivnosti.RowHeadersVisible = false;

            dgvDetaljiAktivnosti.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvDetaljiAktivnosti.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
        }

        private void btnZatvoriDetaljeAktivnosti_Click(object sender, EventArgs e)
        {
            this.Close();
            _meniForma.OpenChildForm(new FrmAktivnostiRavnateljica(_meniForma));

        }

      
    }
}
