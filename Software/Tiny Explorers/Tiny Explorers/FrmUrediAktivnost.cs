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
    public partial class FrmUrediAktivnost : Form
    {
        private readonly SkupineRepository _skupineRepo = new SkupineRepository();

        private List<Skupina> _skupine;
        private readonly Plan_aktivnosti _aktivnost;
        private FrmMeniOdgojiteljice _meniForma;

        public FrmUrediAktivnost(Plan_aktivnosti aktivnost, FrmMeniOdgojiteljice meniForma)
        {
            InitializeComponent();
            _aktivnost = aktivnost;
            _meniForma = meniForma;
        }

        private void FrmUrediAktivnost_Load(object sender, EventArgs e)
        {
            _skupine = _skupineRepo.DohvatiSveSkupine();
            cbUrediAktivnostSkupina.DataSource = _skupine;
            cbUrediAktivnostSkupina.DisplayMember = "Naziv";
            cbUrediAktivnostSkupina.ValueMember = "Id_skupina";

            txtUrediAktivnostNaziv.Text = _aktivnost.Naziv;
            dtpUrediDatumAktivnosti.Value = _aktivnost.Datum;
            txtUrediAktivnostOpis.Text = _aktivnost.Opis;
            txtUrediAktivnostKomentar.Text = _aktivnost.Komentar;
            txtUrediAktivnostMaterijal.Text = _aktivnost.Materijal;
            cbUrediAktivnostSkupina.SelectedValue = _aktivnost.Skupina_id;

            
            chkUrediAktivnostRealiziranoDa.CheckedChanged -= chkUrediAktivnostRealiziranoDa_CheckedChanged;
            chkUrediAktivnostRealiziranoNe.CheckedChanged -= chkUrediAktivnostRealiziranoNe_CheckedChanged;

            
            if (_aktivnost.Realizirano == "Da")
                chkUrediAktivnostRealiziranoDa.Checked = true;
            else
                chkUrediAktivnostRealiziranoNe.Checked = true;

            
            chkUrediAktivnostRealiziranoDa.CheckedChanged += chkUrediAktivnostRealiziranoDa_CheckedChanged;
            chkUrediAktivnostRealiziranoNe.CheckedChanged += chkUrediAktivnostRealiziranoNe_CheckedChanged;


        }


        private void chkUrediAktivnostRealiziranoDa_CheckedChanged(object sender, EventArgs e)
        {
            if (chkUrediAktivnostRealiziranoDa.Checked)
            {
                chkUrediAktivnostRealiziranoNe.Checked = false;
            }
            else if (!chkUrediAktivnostRealiziranoNe.Checked)
            {
                chkUrediAktivnostRealiziranoNe.Checked = true;
            }

        }

        private void chkUrediAktivnostRealiziranoNe_CheckedChanged(object sender, EventArgs e)
        {
            if (chkUrediAktivnostRealiziranoNe.Checked)
            {
                chkUrediAktivnostRealiziranoDa.Checked = false;
            }
            else if (!chkUrediAktivnostRealiziranoDa.Checked)
            {
                chkUrediAktivnostRealiziranoDa.Checked = true;
            }
        }


        private void btnUrediAktivnost_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUrediAktivnostNaziv.Text))
            {
                MessageBox.Show("Unesite naziv aktivnosti.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtUrediAktivnostOpis.Text))
            {
                MessageBox.Show("Unesite opis aktivnosti.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtUrediAktivnostKomentar.Text))
            {
                MessageBox.Show("Unesite komentar.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtUrediAktivnostMaterijal.Text))
            {
                MessageBox.Show("Unesite materijal potreban za aktivnost.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!chkUrediAktivnostRealiziranoDa.Checked && !chkUrediAktivnostRealiziranoNe.Checked)
            {
                MessageBox.Show("Molimo označite je li aktivnost realizirana.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            if (cbUrediAktivnostSkupina.SelectedItem == null)
            {
                MessageBox.Show("Odaberite skupinu.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

         

            string realizirano = chkUrediAktivnostRealiziranoDa.Checked ? "Da" : "Ne";

     

            _aktivnost.Naziv = FormatirajRecenicu(txtUrediAktivnostNaziv.Text);
            _aktivnost.Opis = FormatirajRecenicu(txtUrediAktivnostOpis.Text);
            _aktivnost.Komentar = FormatirajRecenicu(txtUrediAktivnostKomentar.Text);
            _aktivnost.Materijal = FormatirajRecenicu(txtUrediAktivnostMaterijal.Text);
            _aktivnost.Datum = dtpUrediDatumAktivnosti.Value.Date;
            _aktivnost.Realizirano = realizirano;
            _aktivnost.Skupina_id = (int)cbUrediAktivnostSkupina.SelectedValue;

            try
            {
                AktivnostiRepository.AzurirajAktivnost(_aktivnost);
                MessageBox.Show("Aktivnost je uspješno ažurirana!", "Informacija", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _meniForma.OpenFrmAktivnostiOdgojiteljica();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greška prilikom spremanja: " + ex.Message, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
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


        private void btnOdustaniUredivanjeAktivnosti_Click(object sender, EventArgs e)
        {
            _meniForma.OpenFrmAktivnostiOdgojiteljica();
            this.Close();
        }
    }
}
