using System;
using System.Windows.Forms;
using Tiny_Explorers.Models;
using Tiny_Explorers.Repositories;

namespace Tiny_Explorers
{
    public partial class FrmIzbrisiZaposlenika : Form
    {
        private readonly ZaposleniciRepository _repo = new ZaposleniciRepository();
        private readonly Zaposlenik _zaposlenik;

        public FrmIzbrisiZaposlenika(Zaposlenik zaposlenik)
        {
            InitializeComponent();
            _zaposlenik = zaposlenik;
            // Optionally, show a message or employee info here to confirm deletion
            lblIzbrisiZaposlenika.Text = $"Jeste li sigurni da želite obrisati zaposlenika {_zaposlenik.Ime} {_zaposlenik.Prezime}?";
        }

        private void btnOdustaniBrisanjeZaposlenika_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnIzbrisiZaposlenika_Click(object sender, EventArgs e)
        {
            try
            {
                _repo.ObrisiZaposlenika(_zaposlenik.Id_zaposlenik);
                MessageBox.Show("Zaposlenik je uspješno obrisan.", "Informacija", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greška prilikom brisanja zaposlenika: " + ex.Message, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
