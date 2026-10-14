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
    public partial class FrmIzbrisiAktivnost : Form
    {
        private readonly Plan_aktivnosti _aktivnost;
        public FrmIzbrisiAktivnost(Plan_aktivnosti aktivnost)
        {
            InitializeComponent();
            _aktivnost = aktivnost;
        }


        private void btnIzbrisiAktivnost_Click(object sender, EventArgs e)
        {
            try
            {
                AktivnostiRepository.ObrisiAktivnost(_aktivnost.Id_plan);
                MessageBox.Show("Aktivnost je uspješno obrisana.", "Informacija", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greška prilikom brisanja aktivnosti: " + ex.Message, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnOdustaniBrisanjeAktivnosti_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();

        }
    }
}
