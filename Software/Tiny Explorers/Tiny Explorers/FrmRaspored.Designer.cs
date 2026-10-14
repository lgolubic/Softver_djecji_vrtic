namespace Tiny_Explorers
{
    partial class FrmRaspored
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRaspored));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblRaspored = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtUrediRasporedZaposlenik = new System.Windows.Forms.TextBox();
            this.txtUrediRasporedZamjena = new System.Windows.Forms.TextBox();
            this.txtUrediRasporedSmjena = new System.Windows.Forms.TextBox();
            this.lblUrediRasporedZaposlenik = new System.Windows.Forms.Label();
            this.lblUrediRasporedZamjena = new System.Windows.Forms.Label();
            this.lblUrediRasporedSmjena = new System.Windows.Forms.Label();
            this.lblUrediRasporedID = new System.Windows.Forms.Label();
            this.dtpUrediDatumRodenja = new System.Windows.Forms.DateTimePicker();
            this.lblUrediRasporedDatum = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtUrediRasporedID = new System.Windows.Forms.TextBox();
            this.btnUrediRaspored = new System.Windows.Forms.Button();
            this.dgvPrikazRasporeda = new System.Windows.Forms.DataGridView();
            this.btnDodajRaspored = new System.Windows.Forms.Button();
            this.btnIzbrisiRaspored = new System.Windows.Forms.Button();
            this.btnOdustaniUredivanjeRasporeda = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrikazRasporeda)).BeginInit();
            this.SuspendLayout();
            // 
            // lblRaspored
            // 
            this.lblRaspored.AutoSize = true;
            this.lblRaspored.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRaspored.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblRaspored.Location = new System.Drawing.Point(26, 19);
            this.lblRaspored.Name = "lblRaspored";
            this.lblRaspored.Size = new System.Drawing.Size(134, 38);
            this.lblRaspored.TabIndex = 20;
            this.lblRaspored.Text = "Raspored";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(190, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(70, 38);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(62)))), ((int)(((byte)(4)))));
            this.panel4.Location = new System.Drawing.Point(579, 400);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(236, 1);
            this.panel4.TabIndex = 56;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(62)))), ((int)(((byte)(4)))));
            this.panel3.Location = new System.Drawing.Point(579, 339);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(236, 1);
            this.panel3.TabIndex = 55;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(62)))), ((int)(((byte)(4)))));
            this.panel2.Location = new System.Drawing.Point(154, 455);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(236, 1);
            this.panel2.TabIndex = 54;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // txtUrediRasporedZaposlenik
            // 
            this.txtUrediRasporedZaposlenik.BackColor = System.Drawing.SystemColors.Control;
            this.txtUrediRasporedZaposlenik.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUrediRasporedZaposlenik.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtUrediRasporedZaposlenik.Location = new System.Drawing.Point(579, 374);
            this.txtUrediRasporedZaposlenik.MaxLength = 10;
            this.txtUrediRasporedZaposlenik.Name = "txtUrediRasporedZaposlenik";
            this.txtUrediRasporedZaposlenik.Size = new System.Drawing.Size(236, 19);
            this.txtUrediRasporedZaposlenik.TabIndex = 53;
            this.txtUrediRasporedZaposlenik.TextChanged += new System.EventHandler(this.txtUrediDijeteOIB_TextChanged);
            // 
            // txtUrediRasporedZamjena
            // 
            this.txtUrediRasporedZamjena.BackColor = System.Drawing.SystemColors.Control;
            this.txtUrediRasporedZamjena.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUrediRasporedZamjena.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtUrediRasporedZamjena.Location = new System.Drawing.Point(579, 310);
            this.txtUrediRasporedZamjena.MaxLength = 50;
            this.txtUrediRasporedZamjena.Name = "txtUrediRasporedZamjena";
            this.txtUrediRasporedZamjena.Size = new System.Drawing.Size(236, 19);
            this.txtUrediRasporedZamjena.TabIndex = 52;
            this.txtUrediRasporedZamjena.TextChanged += new System.EventHandler(this.txtUrediDijetePrezime_TextChanged);
            // 
            // txtUrediRasporedSmjena
            // 
            this.txtUrediRasporedSmjena.BackColor = System.Drawing.SystemColors.Control;
            this.txtUrediRasporedSmjena.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUrediRasporedSmjena.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtUrediRasporedSmjena.Location = new System.Drawing.Point(154, 430);
            this.txtUrediRasporedSmjena.MaxLength = 50;
            this.txtUrediRasporedSmjena.Name = "txtUrediRasporedSmjena";
            this.txtUrediRasporedSmjena.Size = new System.Drawing.Size(236, 19);
            this.txtUrediRasporedSmjena.TabIndex = 51;
            this.txtUrediRasporedSmjena.TextChanged += new System.EventHandler(this.txtUrediDijeteIme_TextChanged);
            // 
            // lblUrediRasporedZaposlenik
            // 
            this.lblUrediRasporedZaposlenik.AutoSize = true;
            this.lblUrediRasporedZaposlenik.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold);
            this.lblUrediRasporedZaposlenik.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(62)))), ((int)(((byte)(4)))));
            this.lblUrediRasporedZaposlenik.Location = new System.Drawing.Point(441, 378);
            this.lblUrediRasporedZaposlenik.Name = "lblUrediRasporedZaposlenik";
            this.lblUrediRasporedZaposlenik.Size = new System.Drawing.Size(117, 23);
            this.lblUrediRasporedZaposlenik.TabIndex = 50;
            this.lblUrediRasporedZaposlenik.Text = "Zaposlenik ID";
            this.lblUrediRasporedZaposlenik.Click += new System.EventHandler(this.lblUrediDijeteOIB_Click);
            // 
            // lblUrediRasporedZamjena
            // 
            this.lblUrediRasporedZamjena.AutoSize = true;
            this.lblUrediRasporedZamjena.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold);
            this.lblUrediRasporedZamjena.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(62)))), ((int)(((byte)(4)))));
            this.lblUrediRasporedZamjena.Location = new System.Drawing.Point(441, 319);
            this.lblUrediRasporedZamjena.Name = "lblUrediRasporedZamjena";
            this.lblUrediRasporedZamjena.Size = new System.Drawing.Size(74, 23);
            this.lblUrediRasporedZamjena.TabIndex = 49;
            this.lblUrediRasporedZamjena.Text = "Zamjena";
            this.lblUrediRasporedZamjena.Click += new System.EventHandler(this.lblUrediDijetePrezime_Click);
            // 
            // lblUrediRasporedSmjena
            // 
            this.lblUrediRasporedSmjena.AutoSize = true;
            this.lblUrediRasporedSmjena.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold);
            this.lblUrediRasporedSmjena.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(62)))), ((int)(((byte)(4)))));
            this.lblUrediRasporedSmjena.Location = new System.Drawing.Point(16, 430);
            this.lblUrediRasporedSmjena.Name = "lblUrediRasporedSmjena";
            this.lblUrediRasporedSmjena.Size = new System.Drawing.Size(65, 23);
            this.lblUrediRasporedSmjena.TabIndex = 48;
            this.lblUrediRasporedSmjena.Text = "Smjena";
            this.lblUrediRasporedSmjena.Click += new System.EventHandler(this.lblUrediDijeteIme_Click);
            // 
            // lblUrediRasporedID
            // 
            this.lblUrediRasporedID.AutoSize = true;
            this.lblUrediRasporedID.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblUrediRasporedID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(62)))), ((int)(((byte)(4)))));
            this.lblUrediRasporedID.Location = new System.Drawing.Point(20, 319);
            this.lblUrediRasporedID.Name = "lblUrediRasporedID";
            this.lblUrediRasporedID.Size = new System.Drawing.Size(31, 23);
            this.lblUrediRasporedID.TabIndex = 76;
            this.lblUrediRasporedID.Text = "ID";
            // 
            // dtpUrediDatumRodenja
            // 
            this.dtpUrediDatumRodenja.Location = new System.Drawing.Point(154, 374);
            this.dtpUrediDatumRodenja.Name = "dtpUrediDatumRodenja";
            this.dtpUrediDatumRodenja.Size = new System.Drawing.Size(241, 20);
            this.dtpUrediDatumRodenja.TabIndex = 78;
            // 
            // lblUrediRasporedDatum
            // 
            this.lblUrediRasporedDatum.AutoSize = true;
            this.lblUrediRasporedDatum.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold);
            this.lblUrediRasporedDatum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(62)))), ((int)(((byte)(4)))));
            this.lblUrediRasporedDatum.Location = new System.Drawing.Point(16, 374);
            this.lblUrediRasporedDatum.Name = "lblUrediRasporedDatum";
            this.lblUrediRasporedDatum.Size = new System.Drawing.Size(66, 23);
            this.lblUrediRasporedDatum.TabIndex = 77;
            this.lblUrediRasporedDatum.Text = "Datum ";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(62)))), ((int)(((byte)(4)))));
            this.panel1.Location = new System.Drawing.Point(154, 341);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(236, 1);
            this.panel1.TabIndex = 80;
            // 
            // txtUrediRasporedID
            // 
            this.txtUrediRasporedID.BackColor = System.Drawing.SystemColors.Control;
            this.txtUrediRasporedID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUrediRasporedID.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtUrediRasporedID.Location = new System.Drawing.Point(154, 319);
            this.txtUrediRasporedID.MaxLength = 50;
            this.txtUrediRasporedID.Name = "txtUrediRasporedID";
            this.txtUrediRasporedID.Size = new System.Drawing.Size(236, 19);
            this.txtUrediRasporedID.TabIndex = 79;
            // 
            // btnUrediRaspored
            // 
            this.btnUrediRaspored.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnUrediRaspored.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnUrediRaspored.ForeColor = System.Drawing.Color.White;
            this.btnUrediRaspored.Location = new System.Drawing.Point(632, 475);
            this.btnUrediRaspored.Name = "btnUrediRaspored";
            this.btnUrediRaspored.Size = new System.Drawing.Size(98, 35);
            this.btnUrediRaspored.TabIndex = 92;
            this.btnUrediRaspored.Text = "Uredi";
            this.btnUrediRaspored.UseVisualStyleBackColor = false;
            this.btnUrediRaspored.Click += new System.EventHandler(this.btnUrediRaspored_Click);
            // 
            // dgvPrikazRasporeda
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.MistyRose;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.Control;
            this.dgvPrikazRasporeda.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPrikazRasporeda.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvPrikazRasporeda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPrikazRasporeda.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPrikazRasporeda.Location = new System.Drawing.Point(32, 63);
            this.dgvPrikazRasporeda.Name = "dgvPrikazRasporeda";
            this.dgvPrikazRasporeda.Size = new System.Drawing.Size(559, 216);
            this.dgvPrikazRasporeda.TabIndex = 93;
            // 
            // btnDodajRaspored
            // 
            this.btnDodajRaspored.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnDodajRaspored.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDodajRaspored.ForeColor = System.Drawing.Color.White;
            this.btnDodajRaspored.Location = new System.Drawing.Point(528, 475);
            this.btnDodajRaspored.Name = "btnDodajRaspored";
            this.btnDodajRaspored.Size = new System.Drawing.Size(98, 35);
            this.btnDodajRaspored.TabIndex = 94;
            this.btnDodajRaspored.Text = "Dodaj";
            this.btnDodajRaspored.UseVisualStyleBackColor = false;
            this.btnDodajRaspored.Click += new System.EventHandler(this.btnDodajRaspored_Click);
            // 
            // btnIzbrisiRaspored
            // 
            this.btnIzbrisiRaspored.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnIzbrisiRaspored.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnIzbrisiRaspored.ForeColor = System.Drawing.Color.White;
            this.btnIzbrisiRaspored.Location = new System.Drawing.Point(736, 475);
            this.btnIzbrisiRaspored.Name = "btnIzbrisiRaspored";
            this.btnIzbrisiRaspored.Size = new System.Drawing.Size(98, 35);
            this.btnIzbrisiRaspored.TabIndex = 95;
            this.btnIzbrisiRaspored.Text = "Izbriši";
            this.btnIzbrisiRaspored.UseVisualStyleBackColor = false;
            this.btnIzbrisiRaspored.Click += new System.EventHandler(this.btnIzbrisiRaspored_Click);
            // 
            // btnOdustaniUredivanjeRasporeda
            // 
            this.btnOdustaniUredivanjeRasporeda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnOdustaniUredivanjeRasporeda.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnOdustaniUredivanjeRasporeda.ForeColor = System.Drawing.Color.White;
            this.btnOdustaniUredivanjeRasporeda.Location = new System.Drawing.Point(417, 475);
            this.btnOdustaniUredivanjeRasporeda.Name = "btnOdustaniUredivanjeRasporeda";
            this.btnOdustaniUredivanjeRasporeda.Size = new System.Drawing.Size(98, 35);
            this.btnOdustaniUredivanjeRasporeda.TabIndex = 96;
            this.btnOdustaniUredivanjeRasporeda.Text = "Odustani";
            this.btnOdustaniUredivanjeRasporeda.UseVisualStyleBackColor = false;
            this.btnOdustaniUredivanjeRasporeda.Click += new System.EventHandler(this.btnOdustaniUredivanjeRasporeda_Click);
            // 
            // FrmRaspored
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 522);
            this.Controls.Add(this.btnOdustaniUredivanjeRasporeda);
            this.Controls.Add(this.btnIzbrisiRaspored);
            this.Controls.Add(this.btnDodajRaspored);
            this.Controls.Add(this.dgvPrikazRasporeda);
            this.Controls.Add(this.btnUrediRaspored);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtUrediRasporedID);
            this.Controls.Add(this.dtpUrediDatumRodenja);
            this.Controls.Add(this.lblUrediRasporedDatum);
            this.Controls.Add(this.lblUrediRasporedID);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.txtUrediRasporedZaposlenik);
            this.Controls.Add(this.txtUrediRasporedZamjena);
            this.Controls.Add(this.txtUrediRasporedSmjena);
            this.Controls.Add(this.lblUrediRasporedZaposlenik);
            this.Controls.Add(this.lblUrediRasporedZamjena);
            this.Controls.Add(this.lblUrediRasporedSmjena);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblRaspored);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmRaspored";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmRaspored";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrikazRasporeda)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRaspored;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtUrediRasporedZaposlenik;
        private System.Windows.Forms.TextBox txtUrediRasporedZamjena;
        private System.Windows.Forms.TextBox txtUrediRasporedSmjena;
        private System.Windows.Forms.Label lblUrediRasporedZaposlenik;
        private System.Windows.Forms.Label lblUrediRasporedZamjena;
        private System.Windows.Forms.Label lblUrediRasporedSmjena;
        private System.Windows.Forms.Label lblUrediRasporedID;
        private System.Windows.Forms.DateTimePicker dtpUrediDatumRodenja;
        private System.Windows.Forms.Label lblUrediRasporedDatum;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtUrediRasporedID;
        private System.Windows.Forms.Button btnUrediRaspored;
        private System.Windows.Forms.DataGridView dgvPrikazRasporeda;
        private System.Windows.Forms.Button btnDodajRaspored;
        private System.Windows.Forms.Button btnIzbrisiRaspored;
        private System.Windows.Forms.Button btnOdustaniUredivanjeRasporeda;
    }
}