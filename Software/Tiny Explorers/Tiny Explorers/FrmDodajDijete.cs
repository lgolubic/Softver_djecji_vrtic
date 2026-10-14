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
    public partial class FrmDodajDijete : Form
    {
        private FrmMeniRavnateljice _meniForma;
        public FrmDodajDijete(FrmMeniRavnateljice meniForma)
        {
            InitializeComponent();
            _meniForma = meniForma;
        }

    
        private void FrmDodajDjecu_Load(object sender, EventArgs e)
        {

            var repoSkupine = new SkupineRepository();
            var skupine = repoSkupine.DohvatiSveSkupine()
                                      .OrderBy(s => s.Naziv)
                                      .ToList();
            cbDodajDijeteSkupina.DataSource = skupine;
            cbDodajDijeteSkupina.DisplayMember = "Naziv";
            cbDodajDijeteSkupina.ValueMember = "Id_skupina";


            var roditelji = RoditeljRepository.GetRoditelji()
                                      .OrderBy(r => r.Prezime)
                                      .ToList();
            cbDodajDijeteRoditelj.DataSource = roditelji;
            cbDodajDijeteRoditelj.DisplayMember = "ImePrezime";
            cbDodajDijeteRoditelj.ValueMember = "Id_roditelj";

        }

  
        private void btnOdustaniDodavanjeDjeteta_Click(object sender, EventArgs e)
        {
            _meniForma.OpenFrmDjeca();
            this.Close();
        }


        private void btnDodajDijete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDodajDijeteIme.Text) ||
                string.IsNullOrWhiteSpace(txtDodajDijetePrezime.Text) ||
                string.IsNullOrWhiteSpace(txtDodajDijeteOIB.Text))
            {
                MessageBox.Show("Molimo unesite ime, prezime i OIB.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!txtDodajDijeteOIB.Text.All(char.IsDigit))
            {
                MessageBox.Show("OIB smije sadržavati samo brojeve.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string noviOib = txtDodajDijeteOIB.Text.Trim();
            bool oibPostoji = DjecaRepository.GetDjeca().Any(d => d.Oib == noviOib);

            if (oibPostoji)
            {
                MessageBox.Show("Uneseni OIB već postoji. Provjerite podatke.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!chkDodajDijeteSTeskocamaDA.Checked && !chkDodajDijeteSTeskocamaNE.Checked)
            {
                MessageBox.Show("Molimo označite ima li dijete teškoće.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cbDodajDijeteRoditelj.SelectedValue == null)
            {
                MessageBox.Show("Odaberite roditelja.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

           


            int nextId = DjecaRepository.GetNextDijeteId();
            var dijete = new Dijete
            {
                Id_dijete = nextId,
                Ime = FormatirajImeIPrezime(txtDodajDijeteIme.Text),
                Prezime = FormatirajImeIPrezime(txtDodajDijetePrezime.Text),
                Oib = txtDodajDijeteOIB.Text.Trim(),
                Datum_rodenja = dtpDodajDatumRodenjaDijete.Value,
                Alergije = FormatirajRecenicu(txtDodajDijeteAlergije.Text),
                Dijete_s_teskocama = chkDodajDijeteSTeskocamaDA.Checked ? "Da" : "Ne",
                Napomena = FormatirajRecenicu(txtDodajDijeteNapomena.Text),
                Roditelj_id = (int)cbDodajDijeteRoditelj.SelectedValue,
                Skupina_id = (int)cbDodajDijeteSkupina.SelectedValue
            };



            try
            {
                DjecaRepository.AddDijete(dijete);
                MessageBox.Show("Dijete uspješno dodano.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _meniForma.OpenFrmDjeca();
                this.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show($"Došlo je do pogreške pri spremanju: {ex.Message}", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void chkDodajDijeteSTeskocamaDA_CheckedChanged(object sender, EventArgs e)
        {
            if (chkDodajDijeteSTeskocamaDA.Checked)
            {
                chkDodajDijeteSTeskocamaNE.Checked = false;
            }
            else if (!chkDodajDijeteSTeskocamaNE.Checked)
            {
                chkDodajDijeteSTeskocamaNE.Checked = true;
            }
        }

        private void chkDodajDijeteSTeskocamaNE_CheckedChanged(object sender, EventArgs e)
        {
            if (chkDodajDijeteSTeskocamaNE.Checked)
            {
                chkDodajDijeteSTeskocamaDA.Checked = false;
            }
            else if (!chkDodajDijeteSTeskocamaDA.Checked)
            {
                chkDodajDijeteSTeskocamaDA.Checked = true;
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
