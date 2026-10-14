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
    public partial class FrmDodajEvidencijaDolaska : Form
    {
        public FrmDodajEvidencijaDolaska()
        {
            InitializeComponent();
            this.Load += new System.EventHandler(this.FrmDodajEvidencijaDolaska_Load);

        }

        private void btnSpremi_Click(object sender, EventArgs e)
        {

            dgvDjeca.EndEdit();

            var odabranaSkupina = cmbSkupina.SelectedItem as Skupina;
            if (odabranaSkupina == null) return;

            foreach (DataGridViewRow row in dgvDjeca.Rows)
            {
                if (row.DataBoundItem is Dijete dijete)
                {

                    bool prisutan = false;
                    if (row.Cells["Prisutan"].Value != null)
                    {
                        prisutan = Convert.ToBoolean(row.Cells["Prisutan"].Value);
                    }

                    string razlog = row.Cells["Razlog_izostanka"].Value?.ToString() ?? "";

                    var evidencija = new EvidencijaDolaska
                    {
                        Datum = DateTime.Today,
                        Prisutan = prisutan ? "Da" : "Ne",
                        Razlog_izostanka = prisutan ? "" : razlog,
                        Skupina_id = odabranaSkupina.Id_skupina,
                        Dijete_id = dijete.Id_dijete
                    };

                    EvidencijeDolaskaRepository.SpremiEvidenciju(evidencija);
                }
            }

            MessageBox.Show("Evidencija spremljena!");
            Close();
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cmbSkupina_SelectedIndexChanged(object sender, EventArgs e)
        {

            var odabranaSkupina = cmbSkupina.SelectedItem as Skupina;
            if (odabranaSkupina != null)
            {
                if (odabranaSkupina != null)
                {
                    dgvDjeca.Columns.Clear();
                    dgvDjeca.AutoGenerateColumns = false;

                    var djeca = DjecaRepository.GetDjecaBySkupina(odabranaSkupina.Id_skupina);
                    dgvDjeca.DataSource = djeca;

                    dgvDjeca.Columns.Add(new DataGridViewTextBoxColumn
                    {
                        DataPropertyName = "Id_dijete",
                        HeaderText = "ID",
                        Name = "Id_dijete",
                        ReadOnly = true
                    });

                    dgvDjeca.Columns.Add(new DataGridViewTextBoxColumn
                    {
                        DataPropertyName = "Ime",
                        HeaderText = "Ime",
                        Name = "Ime",
                        ReadOnly = true
                    });

                    dgvDjeca.Columns.Add(new DataGridViewTextBoxColumn
                    {
                        DataPropertyName = "Prezime",
                        HeaderText = "Prezime",
                        Name = "Prezime",
                        ReadOnly = true
                    });

                    dgvDjeca.Columns.Add(new DataGridViewCheckBoxColumn
                    {
                        HeaderText = "Prisutan",
                        Name = "Prisutan"
                    });

                    dgvDjeca.Columns.Add(new DataGridViewTextBoxColumn
                    {
                        HeaderText = "Razlog izostanka",
                        Name = "Razlog_izostanka"
                    });
                }

            }
        }

        private void FrmDodajEvidencijaDolaska_Load(object sender, EventArgs e)
        {
            var skupine = new SkupineRepository();
            var sveSkupine = skupine.DohvatiSveSkupine();

            cmbSkupina.DataSource = sveSkupine;
            cmbSkupina.DisplayMember = "Naziv";
            cmbSkupina.ValueMember = "Id_skupina";
        }
    }
}