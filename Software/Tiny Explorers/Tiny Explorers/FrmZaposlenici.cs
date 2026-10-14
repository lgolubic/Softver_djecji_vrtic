using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Tiny_Explorers.Models;
using Tiny_Explorers.Repositories;

namespace Tiny_Explorers
{
    public partial class FrmZaposlenici : Form
    {
        private readonly ZaposleniciRepository zaposleniciRepo = new ZaposleniciRepository();

        public FrmZaposlenici()
        {
            InitializeComponent();
        }

        private void FrmZaposlenici_Load(object sender, EventArgs e)
        {
           

            LoadZaposlenici();
        }

        private void LoadZaposlenici()
        {
            List<Zaposlenik> lista = zaposleniciRepo.DohvatiSveZaposlenike();
           

            dgvZaposlenici.AutoGenerateColumns = true;
            dgvZaposlenici.DataSource = null;
            dgvZaposlenici.DataSource = lista;
        }

      private void btnDodajZaposlenika_Click(object sender, EventArgs e)
        {
            using (FrmDodajZaposlenika frmDodaj = new FrmDodajZaposlenika())
            {
                if (frmDodaj.ShowDialog() == DialogResult.OK)
                {
                    LoadZaposlenici();
                }
            }
        }
    
        private void btnUrediZaposlenika_Click(object sender, EventArgs e)
        {
            if (dgvZaposlenici.SelectedRows.Count > 0)
            {
                Zaposlenik selected = (Zaposlenik)dgvZaposlenici.SelectedRows[0].DataBoundItem;

               using (FrmUrediZaposlenika frmUredi = new FrmUrediZaposlenika(selected))
                {
                    if (frmUredi.ShowDialog() == DialogResult.OK)
                    {
                        LoadZaposlenici();
                    }
                }
            }
            else
            {
                MessageBox.Show("Molimo odaberite zaposlenika za uređivanje.", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

    private void btnIzbrisiZaposlenika_Click(object sender, EventArgs e)
        {
            if (dgvZaposlenici.SelectedRows.Count > 0)
            {
                Zaposlenik selected = (Zaposlenik)dgvZaposlenici.SelectedRows[0].DataBoundItem;

                using (FrmIzbrisiZaposlenika frmIzbrisi = new FrmIzbrisiZaposlenika(selected))
                {
                    if (frmIzbrisi.ShowDialog() == DialogResult.OK)
                    {
                        LoadZaposlenici();
                    }
                }
           }
            else
            {
                MessageBox.Show("Molimo odaberite zaposlenika za brisanje.", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
     }



        private void btnNatrag_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGenerirajIzvjestajZaposlenika_Click(object sender, EventArgs e)
        {
            var form = new FrmIzvjestajZaposlenik();
            form.ShowDialog();
        }
    }
}
