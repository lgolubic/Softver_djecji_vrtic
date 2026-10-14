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
    public partial class FrmLogin : Form
    {
        public static Zaposlenik PrijavljeniZaposlenik { get; set; }

        public FrmLogin()
        {
            InitializeComponent();
        }
        private void lblExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void FrmLogin_Load(object sender, EventArgs e)
        {

            txtKorisnickoIme.Focus();
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtKorisnickoIme.Text == "")
            {
                MessageBox.Show("Korisničko ime nije uneseno!", "Problem", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtLozinka.Text == "")
            {
                MessageBox.Show("Lozinka nije unesena!", "Problem", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                PrijavljeniZaposlenik = ZaposleniciRepository.GetZaposlenik(txtKorisnickoIme.Text);
                if (PrijavljeniZaposlenik != null && PrijavljeniZaposlenik.ProvjeriLozinku(txtLozinka.Text) && PrijavljeniZaposlenik.Uloga == "ravnateljica")
                {
                    FrmMeniRavnateljice frmMeniRavnateljice = new FrmMeniRavnateljice();
                    Hide();
                    frmMeniRavnateljice.ShowDialog();
                    Close();
                }
                else if (PrijavljeniZaposlenik != null && PrijavljeniZaposlenik.ProvjeriLozinku(txtLozinka.Text) && PrijavljeniZaposlenik.Uloga == "odgojiteljica")
                {
                    FrmMeniOdgojiteljice frmMeniOdgojiteljice = new FrmMeniOdgojiteljice();
                    Hide();
                    frmMeniOdgojiteljice.ShowDialog();
                    Close();
                }
                else
                {
                    MessageBox.Show("Krivi podaci!", "Problem", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
