using System;
using System.Windows.Forms;
using Tiny_Explorers.Models;
using Tiny_Explorers.Repositories;

namespace Tiny_Explorers
{
    public partial class FrmUrediSkupinu : Form
    {
        private SkupineRepository _skupineRepository = new SkupineRepository();
        private Skupina _trenutnaSkupina;

        public FrmUrediSkupinu(Skupina skupinaZaUređivanje)
        {
            InitializeComponent();
            _trenutnaSkupina = skupinaZaUređivanje;

            PopuniDobneRaspon();
            PostaviPodatkeUSučelje();
        }

        private void PopuniDobneRaspon()
        {
            cbUrediSkupinuDobniRaspon.Items.Add("jaslička (1-3 godine)");
            cbUrediSkupinuDobniRaspon.Items.Add("mlađa (3-4 godine)");
            cbUrediSkupinuDobniRaspon.Items.Add("srednja (4-5 godina)");
            cbUrediSkupinuDobniRaspon.Items.Add("starija (6-7 godina)");
        }

        private void PostaviPodatkeUSučelje()
        {
            txtUrediSkupinuID.Text = _trenutnaSkupina.Id_skupina.ToString();
            txtUrediSkupinuNaziv.Text = _trenutnaSkupina.Naziv;
            cbUrediSkupinuDobniRaspon.SelectedItem = _trenutnaSkupina.DobniRaspon;
            txtUrediSkupinuMaksimalniKapacitet.Text = _trenutnaSkupina.MaxKapacitet.ToString();
            txtUrediSkupinuBrojUpisanih.Text = _trenutnaSkupina.BrojUpisanih.ToString();

            txtUrediSkupinuID.ReadOnly = true;
            txtUrediSkupinuBrojUpisanih.ReadOnly = true;
        }

        private void btnUrediSkupinu_Click(object sender, EventArgs e)
        {
            // Validacija
            if (string.IsNullOrWhiteSpace(txtUrediSkupinuNaziv.Text))
            {
                MessageBox.Show("Molimo unesite naziv skupine.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cbUrediSkupinuDobniRaspon.SelectedIndex == -1)
            {
                MessageBox.Show("Molimo odaberite dobni raspon.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(txtUrediSkupinuMaksimalniKapacitet.Text, out int maxKapacitet) || maxKapacitet <= 0)
            {
                MessageBox.Show("Unesite ispravan maksimalni kapacitet (broj veći od 0).", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Ažuriraj objekt
            _trenutnaSkupina.Naziv = txtUrediSkupinuNaziv.Text.Trim();
            _trenutnaSkupina.DobniRaspon = cbUrediSkupinuDobniRaspon.SelectedItem.ToString();
            _trenutnaSkupina.MaxKapacitet = maxKapacitet;

            try
            {
                _skupineRepository.AzurirajSkupinu(_trenutnaSkupina);
                MessageBox.Show("Skupina je uspješno ažurirana!", "Informacija", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.DialogResult = DialogResult.OK;  // Signaliziraj uspjeh
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Došlo je do pogreške prilikom spremanja: " + ex.Message, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnOdustaniUredivanjeSkupine_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void FrmUrediSkupinu_Load(object sender, EventArgs e)
        {

        }
    }
}
