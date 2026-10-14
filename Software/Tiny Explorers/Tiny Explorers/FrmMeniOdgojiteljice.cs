using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tiny_Explorers
{
    public partial class FrmMeniOdgojiteljice : Form
    {
        private Form activeForm = null;
        bool sidebarEducatorExpand;
        bool noteCollapse;
        bool newsCollapse;
        bool attendanceCollapse;
        public FrmMeniOdgojiteljice()
        {
            InitializeComponent();
        }


        private void sidebarEducatorTimer_Tick(object sender, EventArgs e)
        {
            {
                if (sidebarEducatorExpand)
                {
                    sidebarEducator.Width -= 10;
                    if (sidebarEducator.Width == sidebarEducator.MinimumSize.Width)
                    {
                        sidebarEducatorExpand = false;
                        sidebarEducatorTimer.Stop();
                    }

                }
                else
                {
                    sidebarEducator.Width += 10;
                    if (sidebarEducator.Width == sidebarEducator.MaximumSize.Width)
                    {
                        sidebarEducatorExpand = true;
                        sidebarEducatorTimer.Stop();
                    }


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

        private void menuButtonEducator_Click(object sender, EventArgs e)
        {
            sidebarEducatorTimer.Start();
        }

        private void NoteTimer_Tick(object sender, EventArgs e)
        {
            if (noteCollapse)
            {
                NoteContainer.Height += 10;

                if (NoteContainer.Height == NoteContainer.MaximumSize.Height)
                {
                    noteCollapse = false;
                    NoteTimer.Stop();
                }
            }
            else
            {
                NoteContainer.Height -= 10;
                if (NoteContainer.Height == NoteContainer.MinimumSize.Height)
                {
                    noteCollapse = true;
                    NoteTimer.Stop();
                }
            }

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

        private void btnNotes_Click(object sender, EventArgs e)
        {
            NoteTimer.Start();
        }

        private void btnLogoutEducator_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnHomeEducator_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmPocetna());

        }

        private void btnActivitiesEducator_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmAktivnostiOdgojiteljica(this));
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

        private void btnAttendanceEducator_Click(object sender, EventArgs e)
        {
            attendanceTimer.Start();   
        }

        private void btnPrikaziSveEvidencije_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmEvidencijaDolaska());
        }

        private void btnDodajNovuEvidenciju_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmDodajEvidencijaDolaska());
        }

        public void OpenFrmAktivnostiOdgojiteljica()
        {
            OpenChildForm(new FrmAktivnostiOdgojiteljica(this));
        }
    }

}
