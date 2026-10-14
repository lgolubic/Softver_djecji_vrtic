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

    public partial class FrmIzvjestajDijete : Form
    {
        private FrmMeniRavnateljice _meniForma;
        public FrmIzvjestajDijete(FrmMeniRavnateljice meniForma)
        {
            InitializeComponent();
            _meniForma = meniForma;
        }

        private void FrmIzvjestajDijete_Load(object sender, EventArgs e)
        {
            var results = GenerateDijeteIzvjestaj();
            dgvDijeteIzvjestaj.DataSource = results;
        }

        private List<DijeteIzvjestaj> GenerateDijeteIzvjestaj()
        {
            var svaDjeca = DjecaRepository.GetDjeca();
            var djecaIzvjestaj = new List<DijeteIzvjestaj>();

            foreach (var dijete in svaDjeca)
            {
                var item = new DijeteIzvjestaj(dijete);
                djecaIzvjestaj.Add(item);
            }

            return djecaIzvjestaj;
        }

        private void btnNatrag_Click(object sender, EventArgs e)
        {
            this.Close();
            _meniForma.OpenChildForm(new FrmDjeca(_meniForma));
        }
    }
}
