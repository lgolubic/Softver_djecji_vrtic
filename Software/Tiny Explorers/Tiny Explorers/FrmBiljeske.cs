using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Tiny_Explorers.Models;
using Tiny_Explorers.Repositories;

namespace Tiny_Explorers
{
    public partial class FrmBiljeske : Form
    {
        private FrmMeniRavnateljice _meniForma;
        private BiljeskaRepository _repository = new BiljeskaRepository();

        private int? _dijeteId;

        public FrmBiljeske(FrmMeniRavnateljice meniForma, int? dijeteId = null)
        {
            InitializeComponent();
            _dijeteId = dijeteId;
            _meniForma = meniForma;

            LoadNazivi();

            if (_dijeteId.HasValue)
            {
                txtDijeteId.Text = _dijeteId.Value.ToString();
                dgvBiljeske.DataSource = _repository.GetByDijeteId(_dijeteId.Value);
            }
            else
            {
                RefreshGrid();
            }
        }


        private void LoadNazivi()
        {
            // Ideally fetch distinct naziv values from DB if necessary
            var biljeske = _repository.GetAll();
            var nazivi = biljeske.Select(b => b.Naziv).Distinct().ToList();
            cmbNaziv.DataSource = nazivi;
        }

        private void RefreshGrid()
        {
            dgvBiljeske.DataSource = null;
            dgvBiljeske.DataSource = _repository.GetAll();
        }

        private void ClearFields()
        {
            cmbNaziv.SelectedIndex = -1;
            txtOpisBiljeske.Clear();
            txtDodatneNapomene.Clear();
            txtDijeteId.Clear();
            txtZaposlenikId.Clear();
            dtpDatum.Value = DateTime.Today;
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtDijeteId.Text, out int dijeteId) ||
                !int.TryParse(txtZaposlenikId.Text, out int zaposlenikId))
            {
                MessageBox.Show("Dijete ID i Zaposlenik ID moraju biti brojevi.");
                return;
            }

            var novaBiljeska = new Biljeska
            {
                Naziv = cmbNaziv.Text,
                Datum = dtpDatum.Value,
                OpisBiljeske = txtOpisBiljeske.Text,
                DodatneNapomene = txtDodatneNapomene.Text,
                DijeteId = dijeteId,
                ZaposlenikId = zaposlenikId
            };

            _repository.Add(novaBiljeska);
            RefreshGrid();
            ClearFields();
        }

        private void btnPrikazPoNazivu_Click(object sender, EventArgs e)
        {
            string naziv = cmbNaziv.Text;
            if (string.IsNullOrWhiteSpace(naziv)) return;
            dgvBiljeske.DataSource = _repository.GetByNaziv(naziv);
        }

        private void btnPrikazPoDjetetu_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtDijeteId.Text, out int dijeteId))
            {
                MessageBox.Show("Unesite ispravan ID djeteta.");
                return;
            }
            dgvBiljeske.DataSource = _repository.GetByDijeteId(dijeteId);
        }

        private void btnNatrag_Click(object sender, EventArgs e)
        {
            this.Close();
            _meniForma.OpenChildForm(new FrmDjeca(_meniForma));
        }
    }
}
