using System;
using System.Windows.Forms;
using Tiny_Explorers.Models;
using Tiny_Explorers.Repositories;

namespace Tiny_Explorers
{
    public partial class FrmDodajSkupinu : Form
    {
        private SkupineRepository _skupineRepository = new SkupineRepository();

        public FrmDodajSkupinu()
        {
            InitializeComponent();
            PopuniDobneRaspon();
        }

        private void PopuniDobneRaspon()
        {
            // Dodajemo 4 osnovne dobne skupine prema zahtjevu
            cbDodajSkupinuDobniRaspon.Items.Add("jaslička (1-3 godine)");
            cbDodajSkupinuDobniRaspon.Items.Add("mlađa (3-4 godine)");
            cbDodajSkupinuDobniRaspon.Items.Add("srednja (4-5 godina)");
            cbDodajSkupinuDobniRaspon.Items.Add("starija (6-7 godina)");
            cbDodajSkupinuDobniRaspon.SelectedIndex = 0; // default selekcija
        }

        private void btnDodajSkupinu_Click(object sender, EventArgs e)
        {
            // Validacija
            if (string.IsNullOrWhiteSpace(txtDodajSkupinuNaziv.Text))
            {
                MessageBox.Show("Molimo unesite naziv skupine.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cbDodajSkupinuDobniRaspon.SelectedIndex == -1)
            {
                MessageBox.Show("Molimo odaberite dobni raspon.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int maxKapacitet = (int)numMaxKapacitet.Value;
            if (maxKapacitet <= 0)
            {
                MessageBox.Show("Maksimalni kapacitet mora biti veći od nula.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kreiraj novi objekt skupine
            Skupina novaSkupina = new Skupina
            {
                Naziv = txtDodajSkupinuNaziv.Text.Trim(),
                DobniRaspon = cbDodajSkupinuDobniRaspon.SelectedItem.ToString(),
                MaxKapacitet = maxKapacitet,
                BrojUpisanih = 0 // nova skupina na početku bez djece
            };

            // Dodaj u repozitorij
            try
            {
                _skupineRepository.DodajSkupinu(novaSkupina);
                MessageBox.Show("Skupina uspješno dodana!", "Informacija", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Došlo je do pogreške prilikom dodavanja skupine: " + ex.Message, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
