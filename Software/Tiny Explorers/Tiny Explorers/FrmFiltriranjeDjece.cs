using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tiny_Explorers.Repositories;

namespace Tiny_Explorers
{
    public partial class FrmFiltriranjeDjece : Form
    {
        
        private FrmMeniRavnateljice roditeljskaForma;

        public FrmFiltriranjeDjece(FrmMeniRavnateljice roditeljskaForma)
        {
            InitializeComponent();
            this.roditeljskaForma = roditeljskaForma;
        }

    

        private void btnFiltrirajDjecu_Click(object sender, EventArgs e)
        {
            string ime = null;
            string prezime = null;
            bool imaKriterij = false;

            if (cbxIme.Checked)
            {
                string uneseniTekst = txtIme.Text.Trim();
                if (!string.IsNullOrWhiteSpace(uneseniTekst))
                {
                    ime = uneseniTekst;
                    imaKriterij = true;
                }
            }

            if (cbxPrezime.Checked)
            {
                string uneseniTekst = txtPrezime.Text.Trim();
                if (!string.IsNullOrWhiteSpace(uneseniTekst))
                {
                    prezime = uneseniTekst;
                    imaKriterij = true;
                }
            }

            if (imaKriterij)
            {
                var filtriranaDjeca = DjecaRepository.GetDjecaWithParameters(ime, prezime);

                roditeljskaForma.OpenChildForm(new FrmDjeca(roditeljskaForma, filtriranaDjeca));
                this.Close();

            }
            else
            {
                MessageBox.Show("Odaberite barem jedno od: Ime ili Prezime.", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }


    }
}


