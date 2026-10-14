using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tiny_Explorers.Models;
using Tiny_Explorers.Repositories;

namespace Tiny_Explorers
{
    public partial class FrmDodajAktivnost : Form
    {
        private readonly SkupineRepository _skupineRepo = new SkupineRepository();
        private List<Skupina> _skupine;
        private FrmMeniOdgojiteljice _meniForma;
        public FrmDodajAktivnost(FrmMeniOdgojiteljice meniForma)
        {
            InitializeComponent();
            _meniForma = meniForma;
        }


        private void FrmDodajAktivnost_Load(object sender, EventArgs e)
        {
            _skupine = _skupineRepo.DohvatiSveSkupine();
            cbDodajAktivnostSkupina.DataSource = _skupine;
            cbDodajAktivnostSkupina.DisplayMember = "Naziv";
            cbDodajAktivnostSkupina.ValueMember = "Id_skupina";
        }

        private void btnDodajAktivnost_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDodajAktivnostNaziv.Text))
            {
                MessageBox.Show("Unesite naziv aktivnosti.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            if (string.IsNullOrWhiteSpace(txtDodajAktivnostOpis.Text))
            {
                MessageBox.Show("Unesite opis aktivnosti.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtDodajAktivnostKomentar.Text))
            {
                MessageBox.Show("Unesite komentar.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtDodajAktivnostMaterijal.Text))
            {
                MessageBox.Show("Unesite materijal potreban za aktivnost.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!chkDodajAktivnostRealiziranoDa.Checked && !chkDodajAktivnostRealiziranoNe.Checked)
            {
                MessageBox.Show("Odaberite je li aktivnost realizirana (Da ili Ne).", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            if (cbDodajAktivnostSkupina.SelectedItem == null)
            {
                MessageBox.Show("Odaberite skupinu.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


          
            string naziv = FormatirajRecenicu(txtDodajAktivnostNaziv.Text);
            string opis = FormatirajRecenicu(txtDodajAktivnostOpis.Text);
            string komentar = FormatirajRecenicu(txtDodajAktivnostKomentar.Text);
            string materijal = FormatirajRecenicu(txtDodajAktivnostMaterijal.Text);
            string realizirano = chkDodajAktivnostRealiziranoDa.Checked ? "Da" : "Ne";

            var novaAktivnost = new Plan_aktivnosti
            {
                Naziv = naziv,
                Datum = dtpDodajDatumAktivnosti.Value.Date,
                Opis = opis,
                Komentar = komentar,
                Materijal = materijal,
                Realizirano = realizirano,
                Skupina_id = (int)cbDodajAktivnostSkupina.SelectedValue
            };

            try
            {
                AktivnostiRepository.DodajAktivnost(novaAktivnost);
                MessageBox.Show("Aktivnost je uspješno dodana!", "Informacija", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _meniForma.OpenFrmAktivnostiOdgojiteljica();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Pogreška pri dodavanju aktivnosti: " + ex.Message, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void chkDodajAktivnostRealiziranoDa_CheckedChanged(object sender, EventArgs e)
        {
            if (chkDodajAktivnostRealiziranoDa.Checked)
            {
                chkDodajAktivnostRealiziranoNe.Checked = false;
            }
            else if (!chkDodajAktivnostRealiziranoNe.Checked)
            {
                chkDodajAktivnostRealiziranoNe.Checked = true;
            }

        }

        private void chkDodajAktivnostRealiziranoNe_CheckedChanged(object sender, EventArgs e)
        {
            if (chkDodajAktivnostRealiziranoNe.Checked)
            {
                chkDodajAktivnostRealiziranoDa.Checked = false;
            }
            else if (!chkDodajAktivnostRealiziranoDa.Checked)
            {
                chkDodajAktivnostRealiziranoDa.Checked = true;
            }
        }



        private string FormatirajRecenicu(string tekst)
        {
            if (string.IsNullOrWhiteSpace(tekst))
                return tekst;

            CultureInfo hrCulture = new CultureInfo("hr-HR");
            tekst = tekst.Trim().ToLower(hrCulture);

            
            return char.ToUpper(tekst[0], hrCulture) + tekst.Substring(1);
        }




        private void btnOdustaniDodavanjeAktivnosti_Click(object sender, EventArgs e)
        {
            _meniForma.OpenFrmAktivnostiOdgojiteljica();
            this.Close();
        }

      
    }

}


