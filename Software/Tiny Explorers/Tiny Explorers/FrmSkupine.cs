    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;
    using Tiny_Explorers.Models;
    using Tiny_Explorers.Repositories;

    namespace Tiny_Explorers
    {
        public partial class FrmSkupine : Form
        {
            private readonly SkupineRepository skupineRepo = new SkupineRepository();

            public FrmSkupine()
            {
                InitializeComponent();
            }

            private void FrmSkupine_Load(object sender, EventArgs e)
            {
                LoadSkupine();
            }

            private void LoadSkupine()
            {
                List<Skupina> lista = skupineRepo.DohvatiSveSkupine();
                dgvSkupine.DataSource = null;
                dgvSkupine.DataSource = lista;
            }

            private void btnDodajSkupinu_Click(object sender, EventArgs e)
            {
                using (FrmDodajSkupinu frmDodaj = new FrmDodajSkupinu())
                {
                    if (frmDodaj.ShowDialog() == DialogResult.OK)
                    {
                        LoadSkupine();
                    }
                }
            }

        private void btnUredi_Click(object sender, EventArgs e)
        {
            if (dgvSkupine.SelectedRows.Count > 0)
            {
                Skupina selected = (Skupina)dgvSkupine.SelectedRows[0].DataBoundItem;

                using (FrmUrediSkupinu frmUredi = new FrmUrediSkupinu(selected))
                {
                    if (frmUredi.ShowDialog() == DialogResult.OK)
                    {
                        LoadSkupine();
                    }
                }
            }
            else
            {
                MessageBox.Show("Molimo odaberite skupinu za uređivanje.", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void btnIzbriši_Click(object sender, EventArgs e)
        {
            if (dgvSkupine.SelectedRows.Count > 0)
            {
                Skupina selected = (Skupina)dgvSkupine.SelectedRows[0].DataBoundItem;

                using (FrmIzbrisiSkupinu frmIzbrisi = new FrmIzbrisiSkupinu(selected))
                {
                    if (frmIzbrisi.ShowDialog() == DialogResult.OK)
                    {
                        // User confirmed deletion inside FrmIzbrisiSkupinu
                        LoadSkupine();
                    }
                }
            }
            else
            {
                MessageBox.Show("Molimo odaberite skupinu za brisanje.", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnGenerirajIzvjestaj_Click(object sender, EventArgs e)
        {
            var form = new FrmIzvjestajSkupina();
            form.ShowDialog();
        }
    }
        }

