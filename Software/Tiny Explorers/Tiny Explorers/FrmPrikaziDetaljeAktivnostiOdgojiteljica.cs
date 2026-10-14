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
    public partial class FrmPrikaziDetaljeAktivnostiOdgojiteljica : Form
    {
        private Plan_aktivnosti _aktivnost;
        private FrmMeniOdgojiteljice _meniForma;

        public FrmPrikaziDetaljeAktivnostiOdgojiteljica(FrmMeniOdgojiteljice meniForma, Plan_aktivnosti aktivnost)
        {
            InitializeComponent();
            _meniForma = meniForma;
            _aktivnost = aktivnost;
        }

       

        private void FrmPrikaziDetaljeAktivnostiOdgojiteljica_Load(object sender, EventArgs e)
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

            dgvDetaljiAktivnostiOdgojiteljica.DataSource = null;
            dgvDetaljiAktivnostiOdgojiteljica.AutoGenerateColumns = true;
            dgvDetaljiAktivnostiOdgojiteljica.DataSource = detalji;

            dgvDetaljiAktivnostiOdgojiteljica.Columns[0].HeaderText = "Polje";
            dgvDetaljiAktivnostiOdgojiteljica.Columns[1].HeaderText = "Vrijednost";

            dgvDetaljiAktivnostiOdgojiteljica.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDetaljiAktivnostiOdgojiteljica.AllowUserToAddRows = false;
            dgvDetaljiAktivnostiOdgojiteljica.AllowUserToDeleteRows = false;
            dgvDetaljiAktivnostiOdgojiteljica.ReadOnly = true;
            dgvDetaljiAktivnostiOdgojiteljica.RowHeadersVisible = false;

            dgvDetaljiAktivnostiOdgojiteljica.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvDetaljiAktivnostiOdgojiteljica.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
        }

        private void btnZatvoriDetaljeAktivnostiOdgojiteljica_Click(object sender, EventArgs e)
        {
            this.Close();
            _meniForma.OpenChildForm(new FrmAktivnostiOdgojiteljica(_meniForma));
        }
    }
}
