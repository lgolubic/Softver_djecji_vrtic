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
    public partial class FrmObavijesti : Form
    {
        public FrmObavijesti()
        {
            InitializeComponent();
            Load += FrmObavijesti_Load;
        }

        private void btnPosalji_Click(object sender, EventArgs e)
        {
            if (cmbPrimatelj.SelectedItem is Roditelj odabraniRoditelj)
            {
                var novaObavijest = new Obavijest
                {
                    Naziv = txtNaslov.Text,
                    Opis = txtOpis.Text,
                    Datum = DateTime.Now,
                    Primatelj = $"{odabraniRoditelj.Ime} {odabraniRoditelj.Prezime}",
                    Roditelj_id = odabraniRoditelj.Id_roditelj,
                    Zaposlenik_id = FrmLogin.PrijavljeniZaposlenik.Id_zaposlenik
                };

                ObavijestiRepository.DodajObavijest(novaObavijest);
                MessageBox.Show("Obavijest uspješno poslana.");
            }
            else
            {
                MessageBox.Show("Molimo odaberite roditelja.");
            }
        }

        private void cmbPrimatelj_SelectedIndexChanged(object sender, EventArgs e)
        {
            var roditelj = cmbPrimatelj.SelectedItem as Roditelj;
        }

        private void FrmObavijesti_Load(object sender, EventArgs e)
        {
            var roditelji = RoditeljRepository.GetRoditelji();
            cmbPrimatelj.DataSource = roditelji;
            cmbPrimatelj.DisplayMember = "ImePrezime";
            cmbPrimatelj.ValueMember = "Id_roditelj";
        }
    }
}
