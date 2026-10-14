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
    public partial class FrmIzvjestajZaposlenik : Form
    {
        public FrmIzvjestajZaposlenik()
        {
            InitializeComponent();
        }

        private void btnNatrag_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmIzvjestajZaposlenik_Load(object sender, EventArgs e)
        {
            var results = GenerateZaposlenikIzvjestaj();
            dgvIzvjestajZaposlenik.DataSource = results;
        }

        private List<ZaposlenikIzvjestaj> GenerateZaposlenikIzvjestaj()
        {
            var repo = new ZaposleniciRepository();
            var sviZaposlenici = repo.DohvatiSveZaposlenike();
            var zaposlenikIzvjestaj = new List<ZaposlenikIzvjestaj>();

            foreach (var zaposlenik in sviZaposlenici)
            {
                var item = new ZaposlenikIzvjestaj(zaposlenik);
                zaposlenikIzvjestaj.Add(item);
            }

            return zaposlenikIzvjestaj;
        }
    }
}
