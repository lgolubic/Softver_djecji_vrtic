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
    public partial class FrmPovijestObavijesti : Form
    {
        public FrmPovijestObavijesti()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void ShowObavijesti(List<Obavijest> obavijesti)
        {
            dgvObavijest.DataSource = obavijesti;

            dgvObavijest.Columns["Id_obavijest"].DisplayIndex = 0;
            dgvObavijest.Columns["Naziv"].DisplayIndex = 1;
            dgvObavijest.Columns["Opis"].DisplayIndex = 2;
            dgvObavijest.Columns["Datum"].DisplayIndex = 3;
            dgvObavijest.Columns["Primatelj"].DisplayIndex = 4;
            dgvObavijest.Columns["Zaposlenik_id"].DisplayIndex = 5;
            dgvObavijest.Columns["Roditelj_id"].DisplayIndex = 6;
        }
        private void FrmPovijestObavijesti_Load(object sender, EventArgs e)
        {
            List<Obavijest> obavijesti = ObavijestiRepository.GetObavijesti();
            ShowObavijesti(obavijesti);
        }
    }
}
