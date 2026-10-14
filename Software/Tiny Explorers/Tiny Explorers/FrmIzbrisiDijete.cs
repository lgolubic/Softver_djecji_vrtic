using System;
using System.Windows.Forms;
using Tiny_Explorers.Models;
using Tiny_Explorers.Repositories;

namespace Tiny_Explorers
{
    public partial class FrmIzbrisiDijete : Form
    {
        private readonly Dijete _dijete;
        private readonly DjecaRepository _djecaRepo = new DjecaRepository();

        public FrmIzbrisiDijete(Dijete dijete)
        {
            InitializeComponent();
            _dijete = dijete;
            
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnIzbrisiDijete_Click(object sender, EventArgs e)
        {
            try
            {
                DjecaRepository.ObrisiDijete(_dijete.Id_dijete);
                MessageBox.Show("Dijete je uspješno obrisano.", "Informacija", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greška prilikom brisanja djeteta: " + ex.Message, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnOdustaniBrisanjeDjeteta_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
