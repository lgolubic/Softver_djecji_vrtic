using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Tiny_Explorers.Models;

namespace Tiny_Explorers
{
    public partial class FrmRaspored : Form
    {
        private readonly RasporedRepository _repository = new RasporedRepository();

        public FrmRaspored()
        {
            InitializeComponent();
            dgvPrikazRasporeda.SelectionChanged += dgvPrikazRasporeda_SelectionChanged;
            dgvPrikazRasporeda.AutoGenerateColumns = false;

            // Configure DataGridView columns
            dgvPrikazRasporeda.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "ID",
                DataPropertyName = "Id"
            });
            dgvPrikazRasporeda.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Datum",
                DataPropertyName = "Datum"
            });
            dgvPrikazRasporeda.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Smjena",
                DataPropertyName = "Smjena"
            });
            dgvPrikazRasporeda.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Zamjena",
                DataPropertyName = "Zamjena"
            });
            dgvPrikazRasporeda.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Zaposlenik ID",
                DataPropertyName = "ZaposlenikId"
            });

            RefreshGrid();
        }

        private void RefreshGrid()
        {
            dgvPrikazRasporeda.DataSource = null;
            dgvPrikazRasporeda.DataSource = _repository.GetAll();

            dgvPrikazRasporeda.ClearSelection();
        }

        private void ClearFormFields()
        {
            txtUrediRasporedID.Clear();
            txtUrediRasporedSmjena.Clear();
            txtUrediRasporedZamjena.Clear();
            txtUrediRasporedZaposlenik.Clear();
            dtpUrediDatumRodenja.Value = DateTime.Today;
        }

        private void btnDodajRaspored_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtUrediRasporedZaposlenik.Text, out int zaposlenikId))
            {
                MessageBox.Show("Zaposlenik ID mora biti broj.");
                return;
            }

            var repository = new RasporedRepository();
            int newId = repository.GetNextId();  // 🔑 Get next ID

            var newRaspored = new Raspored
            {
                Id = newId,
                Datum = dtpUrediDatumRodenja.Value,
                Smjena = txtUrediRasporedSmjena.Text,
                Zamjena = txtUrediRasporedZamjena.Text,
                ZaposlenikId = zaposlenikId
            };

            repository.Add(newRaspored);
            RefreshGrid();
            ClearFormFields();
        }


        private void btnUrediRaspored_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtUrediRasporedID.Text, out int id) ||
                !int.TryParse(txtUrediRasporedZaposlenik.Text, out int zaposlenikId))
            {
                MessageBox.Show("Provjerite unose za ID i Zaposlenik ID.");
                return;
            }

            var updated = new Raspored
            {
                Id = id,
                Datum = dtpUrediDatumRodenja.Value,
                Smjena = txtUrediRasporedSmjena.Text,
                Zamjena = txtUrediRasporedZamjena.Text,
                ZaposlenikId = zaposlenikId
            };

            _repository.Update(updated);
            RefreshGrid();
            ClearFormFields();
        }

        private void btnIzbrisiRaspored_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtUrediRasporedID.Text, out int id))
            {
                MessageBox.Show("Odaberite raspored za brisanje.");
                return;
            }

            _repository.Delete(id);
            RefreshGrid();
            ClearFormFields();
        }

        private void btnOdustaniUredivanjeRasporeda_Click(object sender, EventArgs e)
        {
            ClearFormFields();
        }

        private void dgvPrikazRasporeda_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvPrikazRasporeda.CurrentRow?.DataBoundItem is Raspored selected)
            {
                txtUrediRasporedID.Text = selected.Id.ToString();
                dtpUrediDatumRodenja.Value = selected.Datum;
                txtUrediRasporedSmjena.Text = selected.Smjena;
                txtUrediRasporedZamjena.Text = selected.Zamjena;
                txtUrediRasporedZaposlenik.Text = selected.ZaposlenikId.ToString();
            }
        }

        // Designer event handlers
        private void panel1_Paint(object sender, PaintEventArgs e) { }
        private void panel2_Paint(object sender, PaintEventArgs e) { }
        private void panel3_Paint(object sender, PaintEventArgs e) { }
        private void panel4_Paint(object sender, PaintEventArgs e) { }
        private void txtUrediDijeteIme_TextChanged(object sender, EventArgs e) { }
        private void txtUrediDijetePrezime_TextChanged(object sender, EventArgs e) { }
        private void txtUrediDijeteOIB_TextChanged(object sender, EventArgs e) { }
        private void lblUrediDijeteIme_Click(object sender, EventArgs e) { }
        private void lblUrediDijetePrezime_Click(object sender, EventArgs e) { }
        private void lblUrediDijeteOIB_Click(object sender, EventArgs e) { }
    }
}
