namespace Tiny_Explorers
{
    partial class FrmMeniRavnateljice
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMeniRavnateljice));
            this.sidebar = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.menuButton = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnHome = new System.Windows.Forms.Button();
            this.homeContainer = new System.Windows.Forms.Panel();
            this.FiltrirajDjecu = new System.Windows.Forms.Button();
            this.btnPrikaziSvuDjecu = new System.Windows.Forms.Button();
            this.btnKids = new System.Windows.Forms.Button();
            this.btnGroup = new System.Windows.Forms.Button();
            this.attendanceContainer = new System.Windows.Forms.Panel();
            this.btnDodajNovuEvidenciju = new System.Windows.Forms.Button();
            this.btnPrikaziSveEvidencije = new System.Windows.Forms.Button();
            this.btnAttendance = new System.Windows.Forms.Button();
            this.billsContainer = new System.Windows.Forms.Panel();
            this.btnGenerirajRacun = new System.Windows.Forms.Button();
            this.btnPrikazSvihRacuna = new System.Windows.Forms.Button();
            this.btnBills = new System.Windows.Forms.Button();
            this.employeesContainer = new System.Windows.Forms.Panel();
            this.btnEmployees = new System.Windows.Forms.Button();
            this.btnRasporedZaposlenika = new System.Windows.Forms.Button();
            this.btnPrikazZaposlenika = new System.Windows.Forms.Button();
            this.btnActivities = new System.Windows.Forms.Button();
            this.newsConntainer = new System.Windows.Forms.Panel();
            this.btnDodajNovuObavijestRavnateljica = new System.Windows.Forms.Button();
            this.btnPrikaziSveObavijestiRavnateljica = new System.Windows.Forms.Button();
            this.btnNotifications = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.sidebarTimer = new System.Windows.Forms.Timer(this.components);
            this.homeTimer = new System.Windows.Forms.Timer(this.components);
            this.billsTimer = new System.Windows.Forms.Timer(this.components);
            this.panelMain = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblDobrodošli = new System.Windows.Forms.Label();
            this.attendanceTimer = new System.Windows.Forms.Timer(this.components);
            this.newsTimer = new System.Windows.Forms.Timer(this.components);
            this.sidebar.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.menuButton)).BeginInit();
            this.homeContainer.SuspendLayout();
            this.attendanceContainer.SuspendLayout();
            this.billsContainer.SuspendLayout();
            this.employeesContainer.SuspendLayout();
            this.newsConntainer.SuspendLayout();
            this.panelMain.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // sidebar
            // 
            this.sidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.sidebar.Controls.Add(this.panel2);
            this.sidebar.Controls.Add(this.btnHome);
            this.sidebar.Controls.Add(this.homeContainer);
            this.sidebar.Controls.Add(this.btnGroup);
            this.sidebar.Controls.Add(this.attendanceContainer);
            this.sidebar.Controls.Add(this.billsContainer);
            this.sidebar.Controls.Add(this.employeesContainer);
            this.sidebar.Controls.Add(this.btnActivities);
            this.sidebar.Controls.Add(this.newsConntainer);
            this.sidebar.Controls.Add(this.btnLogout);
            this.sidebar.Location = new System.Drawing.Point(0, 1);
            this.sidebar.MaximumSize = new System.Drawing.Size(195, 561);
            this.sidebar.MinimumSize = new System.Drawing.Size(46, 561);
            this.sidebar.Name = "sidebar";
            this.sidebar.Size = new System.Drawing.Size(195, 561);
            this.sidebar.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.menuButton);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 57);
            this.panel2.TabIndex = 1;
            // 
            // menuButton
            // 
            this.menuButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.menuButton.Image = ((System.Drawing.Image)(resources.GetObject("menuButton.Image")));
            this.menuButton.Location = new System.Drawing.Point(3, 3);
            this.menuButton.Name = "menuButton";
            this.menuButton.Size = new System.Drawing.Size(37, 35);
            this.menuButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.menuButton.TabIndex = 1;
            this.menuButton.TabStop = false;
            this.menuButton.Click += new System.EventHandler(this.menuButton_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(3, 106);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(192, 47);
            this.panel1.TabIndex = 0;
            // 
            // btnHome
            // 
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnHome.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnHome.Image = ((System.Drawing.Image)(resources.GetObject("btnHome.Image")));
            this.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.Location = new System.Drawing.Point(3, 66);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(192, 47);
            this.btnHome.TabIndex = 1;
            this.btnHome.Text = "          Početna";
            this.btnHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // homeContainer
            // 
            this.homeContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(55)))), ((int)(((byte)(60)))));
            this.homeContainer.Controls.Add(this.FiltrirajDjecu);
            this.homeContainer.Controls.Add(this.btnPrikaziSvuDjecu);
            this.homeContainer.Controls.Add(this.btnKids);
            this.homeContainer.Location = new System.Drawing.Point(3, 119);
            this.homeContainer.MaximumSize = new System.Drawing.Size(194, 117);
            this.homeContainer.MinimumSize = new System.Drawing.Size(194, 47);
            this.homeContainer.Name = "homeContainer";
            this.homeContainer.Size = new System.Drawing.Size(194, 47);
            this.homeContainer.TabIndex = 1;
            // 
            // FiltrirajDjecu
            // 
            this.FiltrirajDjecu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(62)))), ((int)(((byte)(4)))));
            this.FiltrirajDjecu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FiltrirajDjecu.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.FiltrirajDjecu.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.FiltrirajDjecu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.FiltrirajDjecu.Location = new System.Drawing.Point(-5, 81);
            this.FiltrirajDjecu.Name = "FiltrirajDjecu";
            this.FiltrirajDjecu.Size = new System.Drawing.Size(207, 35);
            this.FiltrirajDjecu.TabIndex = 4;
            this.FiltrirajDjecu.Text = "  Filtriraj";
            this.FiltrirajDjecu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.FiltrirajDjecu.UseVisualStyleBackColor = false;
            this.FiltrirajDjecu.Click += new System.EventHandler(this.FiltrirajDjecu_Click);
            // 
            // btnPrikaziSvuDjecu
            // 
            this.btnPrikaziSvuDjecu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(62)))), ((int)(((byte)(4)))));
            this.btnPrikaziSvuDjecu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrikaziSvuDjecu.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnPrikaziSvuDjecu.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnPrikaziSvuDjecu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrikaziSvuDjecu.Location = new System.Drawing.Point(-5, 46);
            this.btnPrikaziSvuDjecu.Name = "btnPrikaziSvuDjecu";
            this.btnPrikaziSvuDjecu.Size = new System.Drawing.Size(207, 36);
            this.btnPrikaziSvuDjecu.TabIndex = 3;
            this.btnPrikaziSvuDjecu.Text = "  Prikaži sve";
            this.btnPrikaziSvuDjecu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrikaziSvuDjecu.UseVisualStyleBackColor = false;
            this.btnPrikaziSvuDjecu.Click += new System.EventHandler(this.btnPrikaziSvuDjecu_Click);
            // 
            // btnKids
            // 
            this.btnKids.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.btnKids.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKids.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnKids.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnKids.Image = ((System.Drawing.Image)(resources.GetObject("btnKids.Image")));
            this.btnKids.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKids.Location = new System.Drawing.Point(0, 0);
            this.btnKids.Name = "btnKids";
            this.btnKids.Size = new System.Drawing.Size(207, 47);
            this.btnKids.TabIndex = 2;
            this.btnKids.Text = "          Djeca";
            this.btnKids.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKids.UseVisualStyleBackColor = false;
            this.btnKids.Click += new System.EventHandler(this.btnKids_Click);
            // 
            // btnGroup
            // 
            this.btnGroup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGroup.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnGroup.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnGroup.Image = ((System.Drawing.Image)(resources.GetObject("btnGroup.Image")));
            this.btnGroup.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGroup.Location = new System.Drawing.Point(3, 172);
            this.btnGroup.Name = "btnGroup";
            this.btnGroup.Size = new System.Drawing.Size(195, 47);
            this.btnGroup.TabIndex = 3;
            this.btnGroup.Text = "          Skupine";
            this.btnGroup.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGroup.UseVisualStyleBackColor = true;
            this.btnGroup.Click += new System.EventHandler(this.btnGroup_Click);
            // 
            // attendanceContainer
            // 
            this.attendanceContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(55)))), ((int)(((byte)(60)))));
            this.attendanceContainer.Controls.Add(this.btnDodajNovuEvidenciju);
            this.attendanceContainer.Controls.Add(this.btnPrikaziSveEvidencije);
            this.attendanceContainer.Controls.Add(this.btnAttendance);
            this.attendanceContainer.Location = new System.Drawing.Point(3, 225);
            this.attendanceContainer.MaximumSize = new System.Drawing.Size(192, 114);
            this.attendanceContainer.MinimumSize = new System.Drawing.Size(192, 42);
            this.attendanceContainer.Name = "attendanceContainer";
            this.attendanceContainer.Size = new System.Drawing.Size(192, 42);
            this.attendanceContainer.TabIndex = 10;
            // 
            // btnDodajNovuEvidenciju
            // 
            this.btnDodajNovuEvidenciju.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(62)))), ((int)(((byte)(4)))));
            this.btnDodajNovuEvidenciju.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDodajNovuEvidenciju.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnDodajNovuEvidenciju.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnDodajNovuEvidenciju.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDodajNovuEvidenciju.Location = new System.Drawing.Point(0, 75);
            this.btnDodajNovuEvidenciju.Name = "btnDodajNovuEvidenciju";
            this.btnDodajNovuEvidenciju.Size = new System.Drawing.Size(192, 39);
            this.btnDodajNovuEvidenciju.TabIndex = 9;
            this.btnDodajNovuEvidenciju.Text = "  Dodaj novu";
            this.btnDodajNovuEvidenciju.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDodajNovuEvidenciju.UseVisualStyleBackColor = false;
            this.btnDodajNovuEvidenciju.Click += new System.EventHandler(this.btnDodajNovuEvidenciju_Click);
            // 
            // btnPrikaziSveEvidencije
            // 
            this.btnPrikaziSveEvidencije.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(62)))), ((int)(((byte)(4)))));
            this.btnPrikaziSveEvidencije.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrikaziSveEvidencije.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnPrikaziSveEvidencije.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnPrikaziSveEvidencije.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrikaziSveEvidencije.Location = new System.Drawing.Point(0, 41);
            this.btnPrikaziSveEvidencije.Name = "btnPrikaziSveEvidencije";
            this.btnPrikaziSveEvidencije.Size = new System.Drawing.Size(192, 37);
            this.btnPrikaziSveEvidencije.TabIndex = 8;
            this.btnPrikaziSveEvidencije.Text = "  Prikaži sve";
            this.btnPrikaziSveEvidencije.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrikaziSveEvidencije.UseVisualStyleBackColor = false;
            this.btnPrikaziSveEvidencije.Click += new System.EventHandler(this.btnPrikaziSveEvidencije_Click);
            // 
            // btnAttendance
            // 
            this.btnAttendance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.btnAttendance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAttendance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnAttendance.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnAttendance.Image = ((System.Drawing.Image)(resources.GetObject("btnAttendance.Image")));
            this.btnAttendance.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAttendance.Location = new System.Drawing.Point(0, 0);
            this.btnAttendance.Name = "btnAttendance";
            this.btnAttendance.Size = new System.Drawing.Size(192, 47);
            this.btnAttendance.TabIndex = 7;
            this.btnAttendance.Text = "          Evidencija dolazaka";
            this.btnAttendance.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAttendance.UseVisualStyleBackColor = false;
            this.btnAttendance.Click += new System.EventHandler(this.btnAttendance_Click);
            // 
            // billsContainer
            // 
            this.billsContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(55)))), ((int)(((byte)(60)))));
            this.billsContainer.Controls.Add(this.btnGenerirajRacun);
            this.billsContainer.Controls.Add(this.btnPrikazSvihRacuna);
            this.billsContainer.Controls.Add(this.btnBills);
            this.billsContainer.Location = new System.Drawing.Point(3, 273);
            this.billsContainer.MaximumSize = new System.Drawing.Size(192, 114);
            this.billsContainer.MinimumSize = new System.Drawing.Size(192, 42);
            this.billsContainer.Name = "billsContainer";
            this.billsContainer.Size = new System.Drawing.Size(192, 42);
            this.billsContainer.TabIndex = 9;
            // 
            // btnGenerirajRacun
            // 
            this.btnGenerirajRacun.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(62)))), ((int)(((byte)(4)))));
            this.btnGenerirajRacun.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerirajRacun.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnGenerirajRacun.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnGenerirajRacun.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGenerirajRacun.Location = new System.Drawing.Point(0, 75);
            this.btnGenerirajRacun.Name = "btnGenerirajRacun";
            this.btnGenerirajRacun.Size = new System.Drawing.Size(192, 39);
            this.btnGenerirajRacun.TabIndex = 9;
            this.btnGenerirajRacun.Text = "  Generiraj račun";
            this.btnGenerirajRacun.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGenerirajRacun.UseVisualStyleBackColor = false;
            this.btnGenerirajRacun.Click += new System.EventHandler(this.btnGenerirajRacun_Click);
            // 
            // btnPrikazSvihRacuna
            // 
            this.btnPrikazSvihRacuna.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(62)))), ((int)(((byte)(4)))));
            this.btnPrikazSvihRacuna.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrikazSvihRacuna.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnPrikazSvihRacuna.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnPrikazSvihRacuna.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrikazSvihRacuna.Location = new System.Drawing.Point(0, 41);
            this.btnPrikazSvihRacuna.Name = "btnPrikazSvihRacuna";
            this.btnPrikazSvihRacuna.Size = new System.Drawing.Size(192, 37);
            this.btnPrikazSvihRacuna.TabIndex = 8;
            this.btnPrikazSvihRacuna.Text = "  Prikaži sve";
            this.btnPrikazSvihRacuna.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrikazSvihRacuna.UseVisualStyleBackColor = false;
            this.btnPrikazSvihRacuna.Click += new System.EventHandler(this.btnPrikazSvihRacuna_Click);
            // 
            // btnBills
            // 
            this.btnBills.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.btnBills.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBills.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnBills.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnBills.Image = ((System.Drawing.Image)(resources.GetObject("btnBills.Image")));
            this.btnBills.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBills.Location = new System.Drawing.Point(0, 0);
            this.btnBills.Name = "btnBills";
            this.btnBills.Size = new System.Drawing.Size(192, 47);
            this.btnBills.TabIndex = 7;
            this.btnBills.Text = "          Računi";
            this.btnBills.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBills.UseVisualStyleBackColor = false;
            this.btnBills.Click += new System.EventHandler(this.btnBills_Click);
            // 
            // employeesContainer
            // 
            this.employeesContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(55)))), ((int)(((byte)(60)))));
            this.employeesContainer.Controls.Add(this.btnEmployees);
            this.employeesContainer.Controls.Add(this.btnRasporedZaposlenika);
            this.employeesContainer.Controls.Add(this.btnPrikazZaposlenika);
            this.employeesContainer.Location = new System.Drawing.Point(3, 321);
            this.employeesContainer.MaximumSize = new System.Drawing.Size(256, 140);
            this.employeesContainer.MinimumSize = new System.Drawing.Size(256, 52);
            this.employeesContainer.Name = "employeesContainer";
            this.employeesContainer.Size = new System.Drawing.Size(256, 52);
            this.employeesContainer.TabIndex = 0;
            // 
            // btnEmployees
            // 
            this.btnEmployees.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmployees.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnEmployees.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnEmployees.Image = ((System.Drawing.Image)(resources.GetObject("btnEmployees.Image")));
            this.btnEmployees.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEmployees.Location = new System.Drawing.Point(0, 0);
            this.btnEmployees.Name = "btnEmployees";
            this.btnEmployees.Size = new System.Drawing.Size(192, 47);
            this.btnEmployees.TabIndex = 6;
            this.btnEmployees.Text = "          Zaposlenici";
            this.btnEmployees.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEmployees.UseVisualStyleBackColor = true;
            this.btnEmployees.Click += new System.EventHandler(this.btnEmployees_Click);
            // 
            // btnRasporedZaposlenika
            // 
            this.btnRasporedZaposlenika.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(62)))), ((int)(((byte)(4)))));
            this.btnRasporedZaposlenika.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRasporedZaposlenika.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnRasporedZaposlenika.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnRasporedZaposlenika.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRasporedZaposlenika.Location = new System.Drawing.Point(0, 92);
            this.btnRasporedZaposlenika.Name = "btnRasporedZaposlenika";
            this.btnRasporedZaposlenika.Size = new System.Drawing.Size(256, 48);
            this.btnRasporedZaposlenika.TabIndex = 9;
            this.btnRasporedZaposlenika.Text = "  Raspored rada";
            this.btnRasporedZaposlenika.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRasporedZaposlenika.UseVisualStyleBackColor = false;
            this.btnRasporedZaposlenika.Click += new System.EventHandler(this.btnRasporedZaposlenika_Click);
            // 
            // btnPrikazZaposlenika
            // 
            this.btnPrikazZaposlenika.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(62)))), ((int)(((byte)(4)))));
            this.btnPrikazZaposlenika.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrikazZaposlenika.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnPrikazZaposlenika.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnPrikazZaposlenika.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrikazZaposlenika.Location = new System.Drawing.Point(0, 50);
            this.btnPrikazZaposlenika.Name = "btnPrikazZaposlenika";
            this.btnPrikazZaposlenika.Size = new System.Drawing.Size(256, 46);
            this.btnPrikazZaposlenika.TabIndex = 8;
            this.btnPrikazZaposlenika.Text = "  Pregled zaposlenika";
            this.btnPrikazZaposlenika.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrikazZaposlenika.UseVisualStyleBackColor = false;
            this.btnPrikazZaposlenika.Click += new System.EventHandler(this.btnPrikazZaposlenika_Click);
            // 
            // btnActivities
            // 
            this.btnActivities.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActivities.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnActivities.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnActivities.Image = ((System.Drawing.Image)(resources.GetObject("btnActivities.Image")));
            this.btnActivities.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnActivities.Location = new System.Drawing.Point(3, 379);
            this.btnActivities.Name = "btnActivities";
            this.btnActivities.Size = new System.Drawing.Size(192, 47);
            this.btnActivities.TabIndex = 4;
            this.btnActivities.Text = "          Aktivnosti";
            this.btnActivities.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnActivities.UseVisualStyleBackColor = true;
            this.btnActivities.Click += new System.EventHandler(this.btnActivities_Click);
            // 
            // newsConntainer
            // 
            this.newsConntainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(55)))), ((int)(((byte)(60)))));
            this.newsConntainer.Controls.Add(this.btnDodajNovuObavijestRavnateljica);
            this.newsConntainer.Controls.Add(this.btnPrikaziSveObavijestiRavnateljica);
            this.newsConntainer.Controls.Add(this.btnNotifications);
            this.newsConntainer.Location = new System.Drawing.Point(3, 432);
            this.newsConntainer.MaximumSize = new System.Drawing.Size(192, 114);
            this.newsConntainer.MinimumSize = new System.Drawing.Size(192, 42);
            this.newsConntainer.Name = "newsConntainer";
            this.newsConntainer.Size = new System.Drawing.Size(192, 42);
            this.newsConntainer.TabIndex = 10;
            // 
            // btnDodajNovuObavijestRavnateljica
            // 
            this.btnDodajNovuObavijestRavnateljica.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(62)))), ((int)(((byte)(4)))));
            this.btnDodajNovuObavijestRavnateljica.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDodajNovuObavijestRavnateljica.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnDodajNovuObavijestRavnateljica.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnDodajNovuObavijestRavnateljica.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDodajNovuObavijestRavnateljica.Location = new System.Drawing.Point(0, 75);
            this.btnDodajNovuObavijestRavnateljica.Name = "btnDodajNovuObavijestRavnateljica";
            this.btnDodajNovuObavijestRavnateljica.Size = new System.Drawing.Size(192, 39);
            this.btnDodajNovuObavijestRavnateljica.TabIndex = 9;
            this.btnDodajNovuObavijestRavnateljica.Text = "  Dodaj obavijest";
            this.btnDodajNovuObavijestRavnateljica.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDodajNovuObavijestRavnateljica.UseVisualStyleBackColor = false;
            this.btnDodajNovuObavijestRavnateljica.Click += new System.EventHandler(this.btnDodajNovuObavijestRavnateljica_Click);
            // 
            // btnPrikaziSveObavijestiRavnateljica
            // 
            this.btnPrikaziSveObavijestiRavnateljica.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(62)))), ((int)(((byte)(4)))));
            this.btnPrikaziSveObavijestiRavnateljica.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrikaziSveObavijestiRavnateljica.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnPrikaziSveObavijestiRavnateljica.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnPrikaziSveObavijestiRavnateljica.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrikaziSveObavijestiRavnateljica.Location = new System.Drawing.Point(0, 41);
            this.btnPrikaziSveObavijestiRavnateljica.Name = "btnPrikaziSveObavijestiRavnateljica";
            this.btnPrikaziSveObavijestiRavnateljica.Size = new System.Drawing.Size(192, 37);
            this.btnPrikaziSveObavijestiRavnateljica.TabIndex = 8;
            this.btnPrikaziSveObavijestiRavnateljica.Text = "  Prikaži sve";
            this.btnPrikaziSveObavijestiRavnateljica.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrikaziSveObavijestiRavnateljica.UseVisualStyleBackColor = false;
            this.btnPrikaziSveObavijestiRavnateljica.Click += new System.EventHandler(this.btnPrikaziSveObavijestiRavnateljica_Click);
            // 
            // btnNotifications
            // 
            this.btnNotifications.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.btnNotifications.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNotifications.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnNotifications.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnNotifications.Image = ((System.Drawing.Image)(resources.GetObject("btnNotifications.Image")));
            this.btnNotifications.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNotifications.Location = new System.Drawing.Point(0, 0);
            this.btnNotifications.Name = "btnNotifications";
            this.btnNotifications.Size = new System.Drawing.Size(192, 47);
            this.btnNotifications.TabIndex = 7;
            this.btnNotifications.Text = "          Obavijesti";
            this.btnNotifications.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNotifications.UseVisualStyleBackColor = false;
            this.btnNotifications.Click += new System.EventHandler(this.btnNotifications_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnLogout.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnLogout.Image = ((System.Drawing.Image)(resources.GetObject("btnLogout.Image")));
            this.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.Location = new System.Drawing.Point(3, 480);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(192, 47);
            this.btnLogout.TabIndex = 8;
            this.btnLogout.Text = "          Log out";
            this.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // sidebarTimer
            // 
            this.sidebarTimer.Interval = 10;
            this.sidebarTimer.Tick += new System.EventHandler(this.sidebarTimer_Tick);
            // 
            // homeTimer
            // 
            this.homeTimer.Interval = 10;
            this.homeTimer.Tick += new System.EventHandler(this.homeTimer_Tick);
            // 
            // billsTimer
            // 
            this.billsTimer.Interval = 10;
            this.billsTimer.Tick += new System.EventHandler(this.billsTimer_Tick);
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.panel3);
            this.panelMain.Location = new System.Drawing.Point(201, 4);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(853, 534);
            this.panelMain.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Controls.Add(this.lblDobrodošli);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(853, 534);
            this.panel3.TabIndex = 7;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Tiny_Explorers.Properties.Resources.teddy_bear;
            this.pictureBox1.Location = new System.Drawing.Point(178, 117);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(425, 341);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // lblDobrodošli
            // 
            this.lblDobrodošli.AutoSize = true;
            this.lblDobrodošli.Font = new System.Drawing.Font("Comic Sans MS", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblDobrodošli.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblDobrodošli.Location = new System.Drawing.Point(22, 21);
            this.lblDobrodošli.Name = "lblDobrodošli";
            this.lblDobrodošli.Size = new System.Drawing.Size(816, 51);
            this.lblDobrodošli.TabIndex = 0;
            this.lblDobrodošli.Text = "Dobrodošli u aplikaciju Dječjeg vrtića Medo!";
            // 
            // attendanceTimer
            // 
            this.attendanceTimer.Interval = 10;
            this.attendanceTimer.Tick += new System.EventHandler(this.attendanceTimer_Tick);
            // 
            // newsTimer
            // 
            this.newsTimer.Interval = 10;
            this.newsTimer.Tick += new System.EventHandler(this.newsTimer_Tick);
            // 
            // FrmMeniRavnateljice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1057, 558);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.sidebar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmMeniRavnateljice";
            this.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmMeniRavnateljice";
            this.Load += new System.EventHandler(this.FrmMeniRavnateljice_Load);
            this.sidebar.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.menuButton)).EndInit();
            this.homeContainer.ResumeLayout(false);
            this.attendanceContainer.ResumeLayout(false);
            this.billsContainer.ResumeLayout(false);
            this.employeesContainer.ResumeLayout(false);
            this.newsConntainer.ResumeLayout(false);
            this.panelMain.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel sidebar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnKids;
        private System.Windows.Forms.Button btnGroup;
        private System.Windows.Forms.Button btnActivities;
        private System.Windows.Forms.Button btnEmployees;
        private System.Windows.Forms.Button btnBills;
        private System.Windows.Forms.PictureBox menuButton;
        private System.Windows.Forms.Timer sidebarTimer;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Panel homeContainer;
        private System.Windows.Forms.Button FiltrirajDjecu;
        private System.Windows.Forms.Button btnPrikaziSvuDjecu;
        private System.Windows.Forms.Timer homeTimer;
        private System.Windows.Forms.Panel billsContainer;
        private System.Windows.Forms.Button btnGenerirajRacun;
        private System.Windows.Forms.Button btnPrikazSvihRacuna;
        private System.Windows.Forms.Timer billsTimer;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Label lblDobrodošli;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel attendanceContainer;
        private System.Windows.Forms.Button btnDodajNovuEvidenciju;
        private System.Windows.Forms.Button btnPrikaziSveEvidencije;
        private System.Windows.Forms.Button btnAttendance;
        private System.Windows.Forms.Panel newsConntainer;
        private System.Windows.Forms.Button btnDodajNovuObavijestRavnateljica;
        private System.Windows.Forms.Button btnPrikaziSveObavijestiRavnateljica;
        private System.Windows.Forms.Button btnNotifications;
        private System.Windows.Forms.Timer attendanceTimer;
        private System.Windows.Forms.Timer newsTimer;
        private System.Windows.Forms.Panel employeesContainer;
        private System.Windows.Forms.Button btnPrikazZaposlenika;
        private System.Windows.Forms.Button btnRasporedZaposlenika;
    }
}