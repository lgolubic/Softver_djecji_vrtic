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
    public partial class FrmIzvještajEvidencijaDolaska : Form
    {
        public FrmIzvještajEvidencijaDolaska()
        {
            InitializeComponent();
        }

        private void btnNatrag_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmIzvještajEvidencijaDolaska_Load(object sender, EventArgs e)
        {
            var results = GenerateEvidencijaIzvjestaj();
            dgvIzvjestaj.DataSource = results;
        }

        private List<EvidencijaDolaskaIzvjestaj> GenerateEvidencijaIzvjestaj()
        {
            var sveEvidencije = EvidencijeDolaskaRepository.GetEvidencije();
            var evidencijeIzvjestaj = new List<EvidencijaDolaskaIzvjestaj>();

            foreach (var evidencija in sveEvidencije)
            {
                var item = new EvidencijaDolaskaIzvjestaj(evidencija);
                evidencijeIzvjestaj.Add(item);
            }

            return evidencijeIzvjestaj;
        }

    }
}
