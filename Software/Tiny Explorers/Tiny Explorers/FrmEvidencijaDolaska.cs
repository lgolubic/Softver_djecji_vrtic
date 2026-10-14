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
    public partial class FrmEvidencijaDolaska : Form
    {
        private List<EvidencijaDolaska> _evidencije = new List<EvidencijaDolaska>();
        public FrmEvidencijaDolaska()
        {
            InitializeComponent();
        }
        private void ShowEvidencije(List<EvidencijaDolaska> evidencije)
        {
            dgvEvidencijaDolaska.DataSource = evidencije    ;

            dgvEvidencijaDolaska.Columns["Id_evidencija"].DisplayIndex = 0;
            dgvEvidencijaDolaska.Columns["Datum"].DisplayIndex = 1;
            dgvEvidencijaDolaska.Columns["Prisutan"].DisplayIndex = 2;
            dgvEvidencijaDolaska.Columns["Razlog_izostanka"].DisplayIndex = 3;
            dgvEvidencijaDolaska.Columns["Skupina_id"].DisplayIndex = 4;
            dgvEvidencijaDolaska.Columns["Dijete_id"].DisplayIndex = 5;
        }

        private void FrmEvidencijaDolaska_Load(object sender, EventArgs e)
        {
            _evidencije = EvidencijeDolaskaRepository.GetEvidencije();
            ShowEvidencije(_evidencije);
        }

        private void txtPretrazi_TextChanged(object sender, EventArgs e)
        {
            string unos = txtPretrazi.Text.Trim().ToLower();

            if (string.IsNullOrWhiteSpace(unos))
            {
                ShowEvidencije(_evidencije);
                return;
            }

            var filtrirano = _evidencije.Where( d =>
                d.Datum.ToString("dd.MM.yyyy").Contains(unos) ||
                d.Prisutan.ToLower().Contains(unos) ||
                d.Razlog_izostanka.ToLower().Contains(unos)
            ).ToList();

            ShowEvidencije(filtrirano);
        }

        private void btnGenerirajIzvjestaj_Click(object sender, EventArgs e)
        {
            var form = new FrmIzvještajEvidencijaDolaska();
            form.ShowDialog();
        }
    }
}
