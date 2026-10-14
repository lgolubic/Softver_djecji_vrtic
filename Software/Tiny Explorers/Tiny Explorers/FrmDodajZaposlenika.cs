using System;
using System.Windows.Forms;
using Tiny_Explorers.Models;
using Tiny_Explorers.Repositories;

namespace Tiny_Explorers
{
    public partial class FrmDodajZaposlenika : Form
    {
        private ZaposleniciRepository _repo = new ZaposleniciRepository();

        public FrmDodajZaposlenika()
        {
            InitializeComponent();
            // Populate Uloga dropdown immediately
            cbDodajZaposlenikaUloga.Items.AddRange(new[] { "odgojiteljica", "ravnateljica", "kuharica", "administrator" });
            cbDodajZaposlenikaUloga.SelectedIndex = 0; // default selection
        }

        private void btnDodajZaposlenika_Click(object sender, EventArgs e)
        {
            // Basic validation
            if (string.IsNullOrWhiteSpace(txtDodajZaposlenikaIme.Text) ||
                string.IsNullOrWhiteSpace(txtDodajZaposlenikaPrezime.Text) ||
                string.IsNullOrWhiteSpace(txtDodajZaposlenikaKorisnickoIme.Text) ||
                string.IsNullOrWhiteSpace(txtDodajZaposlenikaLozinka.Text))
            {
                MessageBox.Show("Molimo ispunite sva obavezna polja (Ime, Prezime, Korisničko ime, Lozinka).", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var noviZaposlenik = new Zaposlenik
            {
                // Id will be set in repository via GetNextIdZaposlenik
                Ime = txtDodajZaposlenikaIme.Text.Trim(),
                Prezime = txtDodajZaposlenikaPrezime.Text.Trim(),
                Korisnicko_ime = txtDodajZaposlenikaKorisnickoIme.Text.Trim(),
                Lozinka = txtDodajZaposlenikaLozinka.Text.Trim(),
                Uloga = cbDodajZaposlenikaUloga.SelectedItem?.ToString(),
                Email = txtDodajZaposlenikaEmail.Text.Trim()
            };

            try
            {
                _repo.DodajZaposlenika(noviZaposlenik);
                MessageBox.Show("Zaposlenik je uspješno dodan.", "Informacija", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greška prilikom dodavanja zaposlenika: " + ex.Message, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnOdustaniDodajZaposlenika_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
