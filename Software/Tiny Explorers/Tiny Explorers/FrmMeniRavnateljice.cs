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

namespace Tiny_Explorers
{
    public partial class FrmMeniRavnateljice : Form
    {
        private Form activeForm = null;
        bool sidebarExpand;
        bool homeCollapse;
        bool billsCollapse;
        bool attendanceCollapse;
        bool newsCollapse;
        public FrmMeniRavnateljice()
        {
            InitializeComponent();
        }


        private void sidebarTimer_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                sidebar.Width -= 10;
                if (sidebar.Width == sidebar.MinimumSize.Width)
                {
                    sidebarExpand = false;
                    sidebarTimer.Stop();
                }

            }
            else
            {
                sidebar.Width += 10;
                if (sidebar.Width == sidebar.MaximumSize.Width)
                {
                    sidebarExpand = true;
                    sidebarTimer.Stop();
                }


            }
        }
        public void OpenChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();

            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelMain.Controls.Add(childForm);
            panelMain.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private void menuButton_Click(object sender, EventArgs e)
        {
            sidebarTimer.Start();
        }



        private void btnLogout_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void FrmMeniRavnateljice_Load(object sender, EventArgs e)
        {

        }

        private void homeTimer_Tick(object sender, EventArgs e)
        {
            if (homeCollapse) {
                homeContainer.Height += 10;

                if (homeContainer.Height == homeContainer.MaximumSize.Height) {
                    homeCollapse = false;
                    homeTimer.Stop();
                }
            } else
            {
                homeContainer.Height -= 10;
                if (homeContainer.Height == homeContainer.MinimumSize.Height)
                {
                    homeCollapse = true;
                    homeTimer.Stop();
                }
            }

        }

        private void btnKids_Click(object sender, EventArgs e)
        {
            homeTimer.Start();
            
        }



        private void billsTimer_Tick(object sender, EventArgs e)
        {
            if (billsCollapse)
            {
                billsContainer.Height += 10;

                if (billsContainer.Height == billsContainer.MaximumSize.Height)
                {
                    billsCollapse = false;
                    billsTimer.Stop();
                }
            }
            else
            {
                billsContainer.Height -= 10;
                if (billsContainer.Height == billsContainer.MinimumSize.Height)
                {
                    billsCollapse = true;
                    billsTimer.Stop();
                }
            }

        }

        private void btnBills_Click(object sender, EventArgs e)
        {
            billsTimer.Start();

        }

        private void btnPrikaziSvuDjecu_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmDjeca(this));


        }

        private void btnGroup_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmSkupine());
        }

        private void FiltrirajDjecu_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmFiltriranjeDjece(this));

        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmPocetna());

        }

        private void btnPrikazSvihRacuna_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmPrikazSvihRacuna());
        }

        private void btnGenerirajRacun_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmGenerirajRacun(this));
        }

        private void btnActivities_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmAktivnostiRavnateljica(this));
        }

        private void btnPrikaziSveEvidencije_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmEvidencijaDolaska());
        }

        private void btnDodajNovuEvidenciju_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmDodajEvidencijaDolaska());
        }

        private void attendanceTimer_Tick(object sender, EventArgs e)
        {
            if (attendanceCollapse)
            {
                attendanceContainer.Height += 10;

                if (attendanceContainer.Height == attendanceContainer.MaximumSize.Height)
                {
                    attendanceCollapse = false;
                    attendanceTimer.Stop();
                }
            }
            else
            {
                attendanceContainer.Height -= 10;
                if (attendanceContainer.Height == attendanceContainer.MinimumSize.Height)
                {
                    attendanceCollapse = true;
                    attendanceTimer.Stop();
                }
            }

        }

        private void btnAttendance_Click(object sender, EventArgs e)
        {
            attendanceTimer.Start();
        }

        private void newsTimer_Tick(object sender, EventArgs e)
        {
            if (newsCollapse)
            {
                newsConntainer.Height += 10;

                if (newsConntainer.Height == newsConntainer.MaximumSize.Height)
                {
                    newsCollapse = false;
                    newsTimer.Stop();
                }
            }
            else
            {
                newsConntainer.Height -= 10;
                if (newsConntainer.Height == newsConntainer.MinimumSize.Height)
                {
                    newsCollapse = true;
                    newsTimer.Stop();
                }
            }

        }

        private void btnNotifications_Click(object sender, EventArgs e)
        {
            newsTimer.Start();
        }

        private void btnPrikaziSveObavijestiRavnateljica_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmPovijestObavijesti());
        }

        private void btnDodajNovuObavijestRavnateljica_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmObavijesti());
        }

        private void btnEmployees_Click(object sender, EventArgs e)
        {
            
            if (employeesContainer.Height == employeesContainer.MinimumSize.Height)
            {
                employeesContainer.Height = employeesContainer.MaximumSize.Height;
            }
            else
            {
                employeesContainer.Height = employeesContainer.MinimumSize.Height;
            }
        }

        private void btnPrikazZaposlenika_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmZaposlenici());
        }

        private void btnRasporedZaposlenika_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmRaspored());
        }

        public void OpenFrmDjeca()
        {
            OpenChildForm(new FrmDjeca(this));
        }

    


    }
}