using System;
using System.Windows.Forms;
using Tiny_Explorers.Models;
using Tiny_Explorers.Repositories;

namespace Tiny_Explorers
{
    public partial class FrmUrediZaposlenika : Form
    {
        private Zaposlenik _zaposlenik;
        private ZaposleniciRepository _repo = new ZaposleniciRepository();

        public FrmUrediZaposlenika(Zaposlenik zaposlenik)
        {
            InitializeComponent();
            _zaposlenik = zaposlenik;
            PostaviPodatke();
        }

        private void PostaviPodatke()
        {
            txtUrediZaposlenikaID.Text = _zaposlenik.Id_zaposlenik.ToString();
            txtUrediZaposlenikaIme.Text = _zaposlenik.Ime;
            txtUrediZaposlenikaPrezime.Text = _zaposlenik.Prezime;
            cbUrediZaposlenikaUloga.Items.AddRange(new[] { "Odgojitelj", "Ravnateljica", "Kuharica", "Administrator" });
            cbUrediZaposlenikaUloga.SelectedItem = _zaposlenik.Uloga;
            txtUrediZaposlenikaEmail.Text = _zaposlenik.Email;
            txtUrediZaposlenikaKorisnickoIme.Text = _zaposlenik.Korisnicko_ime;
            txtUrediZaposlenikaLozinka.Text = _zaposlenik.Lozinka;

            txtUrediZaposlenikaID.ReadOnly = true;
        }

        private void btnUrediZaposlenika_Click(object sender, EventArgs e)
        {
            MessageBox.Show("DELA");
            if (string.IsNullOrWhiteSpace(txtUrediZaposlenikaIme.Text) ||
                string.IsNullOrWhiteSpace(txtUrediZaposlenikaPrezime.Text) ||
                string.IsNullOrWhiteSpace(txtUrediZaposlenikaKorisnickoIme.Text))
            {
                MessageBox.Show("Molimo ispunite sva obavezna polja.", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            _zaposlenik.Ime = txtUrediZaposlenikaIme.Text.Trim();
            _zaposlenik.Prezime = txtUrediZaposlenikaPrezime.Text.Trim();
            _zaposlenik.Uloga = cbUrediZaposlenikaUloga.SelectedItem?.ToString();
            _zaposlenik.Email = txtUrediZaposlenikaEmail.Text.Trim();
            _zaposlenik.Korisnicko_ime = txtUrediZaposlenikaKorisnickoIme.Text.Trim();
            _zaposlenik.Lozinka = txtUrediZaposlenikaLozinka.Text.Trim();

            try
            {
                _repo.UrediZaposlenika(_zaposlenik);
                MessageBox.Show("Zaposlenik je uspješno ažuriran.", "Informacija", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greška prilikom spremanja: " + ex.Message, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnOdustaniUrediZaposlenika_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
