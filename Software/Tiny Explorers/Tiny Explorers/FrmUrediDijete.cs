using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;
using Tiny_Explorers.Models;
using Tiny_Explorers.Repositories;

namespace Tiny_Explorers
{
    public partial class FrmUrediDijete : Form
    {
        private Dijete _dijete;
        private FrmMeniRavnateljice _meniForma;

        public FrmUrediDijete(FrmMeniRavnateljice meniForma, Dijete dijete)
        {
            InitializeComponent();
            _meniForma = meniForma;
            _dijete = dijete;
        }

        private void FrmUrediDijete_Load(object sender, EventArgs e)
        {
            var roditelji = RoditeljRepository.GetRoditelji()
                                     .OrderBy(r => r.Prezime)
                                     .ToList();
            cbUrediDijeteRoditelj.DataSource = roditelji;
            cbUrediDijeteRoditelj.DisplayMember = "ImePrezime";
            cbUrediDijeteRoditelj.ValueMember = "Id_roditelj";

            var repoSkupine = new SkupineRepository();
            var skupine = repoSkupine.DohvatiSveSkupine()
                                     .OrderBy(s => s.Naziv)
                                     .ToList();
            cbUrediDijeteSkupina.DataSource = skupine;
            cbUrediDijeteSkupina.DisplayMember = "Naziv";
            cbUrediDijeteSkupina.ValueMember = "Id_skupina";


            txtUrediDijeteIme.Text = _dijete.Ime;
            txtUrediDijetePrezime.Text = _dijete.Prezime;
            txtUrediDijeteOIB.Text = _dijete.Oib;
            dtpUrediDatumRodenja.Value = _dijete.Datum_rodenja;
            txtUrediDijeteAlergije.Text = _dijete.Alergije;
            txtUrediDijeteNapomena.Text = _dijete.Napomena;

            if (_dijete.Dijete_s_teskocama == "Da")
                chkUrediDijeteSTeskocamaDA.Checked = true;
            else
                chkUrediDijeteSTeskocamaNE.Checked = true;

            cbUrediDijeteRoditelj.SelectedValue = _dijete.Roditelj_id;
            cbUrediDijeteSkupina.SelectedValue = _dijete.Skupina_id;
        }

        private void btnUrediDijete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUrediDijeteIme.Text) ||
                string.IsNullOrWhiteSpace(txtUrediDijetePrezime.Text) ||
                string.IsNullOrWhiteSpace(txtUrediDijeteOIB.Text))
            {
                MessageBox.Show("Molimo unesite ime, prezime i OIB.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!txtUrediDijeteOIB.Text.All(char.IsDigit))
            {
                MessageBox.Show("OIB smije sadržavati samo brojeve.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string noviOib = txtUrediDijeteOIB.Text.Trim();
            bool oibPostoji = DjecaRepository.GetDjeca()
                .Any(d => d.Oib == noviOib && d.Id_dijete != _dijete.Id_dijete);

            if (oibPostoji)
            {
                MessageBox.Show("Uneseni OIB već postoji za drugo dijete. Provjerite podatke.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            if (!chkUrediDijeteSTeskocamaDA.Checked && !chkUrediDijeteSTeskocamaNE.Checked)
            {
                MessageBox.Show("Molimo označite ima li dijete teškoće.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cbUrediDijeteRoditelj.SelectedValue == null)
            {
                MessageBox.Show("Odaberite roditelja.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            _dijete.Ime = FormatirajImeIPrezime(txtUrediDijeteIme.Text);
            _dijete.Prezime = FormatirajImeIPrezime(txtUrediDijetePrezime.Text);
            _dijete.Oib = txtUrediDijeteOIB.Text.Trim();
            _dijete.Datum_rodenja = dtpUrediDatumRodenja.Value;
            _dijete.Alergije = FormatirajRecenicu(txtUrediDijeteAlergije.Text);
            _dijete.Napomena = FormatirajRecenicu(txtUrediDijeteNapomena.Text);
            _dijete.Dijete_s_teskocama = chkUrediDijeteSTeskocamaDA.Checked ? "Da" : "Ne";
            _dijete.Roditelj_id = (int)cbUrediDijeteRoditelj.SelectedValue;
            _dijete.Skupina_id = (int)cbUrediDijeteSkupina.SelectedValue;

            try
            {
                DjecaRepository.AzurirajDijete(_dijete);
                MessageBox.Show("Dijete uspješno ažurirano.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _meniForma.OpenFrmDjeca();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Greška pri spremanju: {ex.Message}", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnOdustaniUredivanjeDjeteta_Click(object sender, EventArgs e)
        {
            _meniForma.OpenFrmDjeca();
            this.Close();
        }

        private void chkUrediDijeteSTeskocamaDA_CheckedChanged(object sender, EventArgs e)
        {
            if (chkUrediDijeteSTeskocamaDA.Checked)
            {
                chkUrediDijeteSTeskocamaNE.Checked = false;
            }
            else if (!chkUrediDijeteSTeskocamaNE.Checked)
            {
                chkUrediDijeteSTeskocamaNE.Checked = true;
            }
        }

        private void chkUrediDijeteSTeskocamaNE_CheckedChanged(object sender, EventArgs e)
        {
            if (chkUrediDijeteSTeskocamaNE.Checked)
            {
                chkUrediDijeteSTeskocamaDA.Checked = false;
            }
            else if (!chkUrediDijeteSTeskocamaDA.Checked)
            {
                chkUrediDijeteSTeskocamaDA.Checked = true;
            }
        }

        private string FormatirajImeIPrezime(string tekst)
        {
            if (string.IsNullOrWhiteSpace(tekst))
                return tekst;

            tekst = tekst.Trim().ToLowerInvariant();
            var rezultat = new StringBuilder();
            bool novaRijec = true;

            foreach (char c in tekst)
            {
                if (char.IsWhiteSpace(c))
                {
                    rezultat.Append(c);
                    novaRijec = true;
                }
                else if (c == '-' || c == '\'')
                {
                    rezultat.Append(c);
                    novaRijec = true;
                }
                else if (novaRijec)
                {
                    rezultat.Append(char.ToUpper(c));
                    novaRijec = false;
                }
                else
                {
                    rezultat.Append(c);
                }
            }

            return rezultat.ToString();
        }

        private string FormatirajRecenicu(string tekst)
        {
            if (string.IsNullOrWhiteSpace(tekst))
                return tekst;

            tekst = tekst.Trim().ToLowerInvariant();
            return char.ToUpper(tekst[0]) + tekst.Substring(1);
        }

    }

       
}

    

