using System;
using System.Windows.Forms;
using Tiny_Explorers.Models;
using Tiny_Explorers.Repositories;

namespace Tiny_Explorers
{
    public partial class FrmIzbrisiSkupinu : Form
    {
        private readonly SkupineRepository _skupineRepo = new SkupineRepository();
        private readonly Skupina _skupina;

        public FrmIzbrisiSkupinu(Skupina skupina)
        {
            InitializeComponent();
            _skupina = skupina;
            // Više ne prikazujemo detalje
        }

        private void btnOdustaniBrisanjeSkupine_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnIzbrisi_Click(object sender, EventArgs e)
        {
            try
            {
                _skupineRepo.ObrisiSkupinu(_skupina.Id_skupina);
                MessageBox.Show("Skupina je uspješno obrisana.", "Informacija", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greška prilikom brisanja skupine: " + ex.Message, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmIzbrisiSkupinu_Load(object sender, EventArgs e)
        {

        }
    }
}
