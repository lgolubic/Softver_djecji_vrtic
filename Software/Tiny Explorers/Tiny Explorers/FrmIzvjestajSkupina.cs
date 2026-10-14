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
    public partial class FrmIzvjestajSkupina : Form
    {
        public FrmIzvjestajSkupina()
        {
            InitializeComponent();
        }

        private void btnNatrag_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmIzvjestajSkupina_Load(object sender, EventArgs e)
        {
            var results = GenerateSkupinaIzvjestaj();
            dgvIzvjestajSkupina.DataSource = results;
        }

        private List<SkupinaIzvjestaj> GenerateSkupinaIzvjestaj()
        {
            var repo = new SkupineRepository();
            var sveSkupine = repo.DohvatiSveSkupine();
            var skupinaIzvjestaj = new List<SkupinaIzvjestaj>();

            foreach (var skupina in sveSkupine)
            {
                var item = new SkupinaIzvjestaj(skupina);
                skupinaIzvjestaj.Add(item);
            }

            return skupinaIzvjestaj;
        }
    }
}
