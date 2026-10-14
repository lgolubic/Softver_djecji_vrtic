namespace Tiny_Explorers
{
    partial class FrmDodajEvidencijaDolaska
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblEvidencijaDolaska = new System.Windows.Forms.Label();
            this.lblDatum = new System.Windows.Forms.Label();
            this.lblSkupina = new System.Windows.Forms.Label();
            this.cmbSkupina = new System.Windows.Forms.ComboBox();
            this.btnOdustani = new System.Windows.Forms.Button();
            this.btnSpremi = new System.Windows.Forms.Button();
            this.dtpDatum = new System.Windows.Forms.DateTimePicker();
            this.dgvDjeca = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDjeca)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Tiny_Explorers.Properties.Resources.kids;
            this.pictureBox1.Location = new System.Drawing.Point(980, 14);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(147, 67);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // lblEvidencijaDolaska
            // 
            this.lblEvidencijaDolaska.AutoSize = true;
            this.lblEvidencijaDolaska.Font = new System.Drawing.Font("Comic Sans MS", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEvidencijaDolaska.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblEvidencijaDolaska.Location = new System.Drawing.Point(21, 26);
            this.lblEvidencijaDolaska.Name = "lblEvidencijaDolaska";
            this.lblEvidencijaDolaska.Size = new System.Drawing.Size(374, 55);
            this.lblEvidencijaDolaska.TabIndex = 15;
            this.lblEvidencijaDolaska.Text = "Evidencija dolaska";
            // 
            // lblDatum
            // 
            this.lblDatum.AutoSize = true;
            this.lblDatum.Font = new System.Drawing.Font("Comic Sans MS", 14F, System.Drawing.FontStyle.Bold);
            this.lblDatum.Location = new System.Drawing.Point(56, 135);
            this.lblDatum.Name = "lblDatum";
            this.lblDatum.Size = new System.Drawing.Size(87, 35);
            this.lblDatum.TabIndex = 16;
            this.lblDatum.Text = "Datum";
            // 
            // lblSkupina
            // 
            this.lblSkupina.AutoSize = true;
            this.lblSkupina.Font = new System.Drawing.Font("Comic Sans MS", 14F, System.Drawing.FontStyle.Bold);
            this.lblSkupina.Location = new System.Drawing.Point(637, 135);
            this.lblSkupina.Name = "lblSkupina";
            this.lblSkupina.Size = new System.Drawing.Size(103, 35);
            this.lblSkupina.TabIndex = 17;
            this.lblSkupina.Text = "Skupina";
            // 
            // cmbSkupina
            // 
            this.cmbSkupina.Font = new System.Drawing.Font("Comic Sans MS", 10F);
            this.cmbSkupina.FormattingEnabled = true;
            this.cmbSkupina.Location = new System.Drawing.Point(746, 141);
            this.cmbSkupina.Name = "cmbSkupina";
            this.cmbSkupina.Size = new System.Drawing.Size(350, 32);
            this.cmbSkupina.TabIndex = 18;
            this.cmbSkupina.SelectedIndexChanged += new System.EventHandler(this.cmbSkupina_SelectedIndexChanged);
            // 
            // btnOdustani
            // 
            this.btnOdustani.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnOdustani.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnOdustani.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOdustani.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btnOdustani.ForeColor = System.Drawing.Color.White;
            this.btnOdustani.Location = new System.Drawing.Point(46, 584);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(123, 46);
            this.btnOdustani.TabIndex = 19;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = false;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // btnSpremi
            // 
            this.btnSpremi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnSpremi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSpremi.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btnSpremi.ForeColor = System.Drawing.Color.White;
            this.btnSpremi.Location = new System.Drawing.Point(1006, 584);
            this.btnSpremi.Name = "btnSpremi";
            this.btnSpremi.Size = new System.Drawing.Size(111, 46);
            this.btnSpremi.TabIndex = 20;
            this.btnSpremi.Text = "Spremi";
            this.btnSpremi.UseVisualStyleBackColor = false;
            this.btnSpremi.Click += new System.EventHandler(this.btnSpremi_Click);
            // 
            // dtpDatum
            // 
            this.dtpDatum.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDatum.Location = new System.Drawing.Point(149, 139);
            this.dtpDatum.Name = "dtpDatum";
            this.dtpDatum.Size = new System.Drawing.Size(350, 31);
            this.dtpDatum.TabIndex = 21;
            // 
            // dgvDjeca
            // 
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.MistyRose;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Comic Sans MS", 11.25F);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.Control;
            this.dgvDjeca.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvDjeca.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDjeca.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvDjeca.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Comic Sans MS", 11.25F);
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDjeca.DefaultCellStyle = dataGridViewCellStyle9;
            this.dgvDjeca.Location = new System.Drawing.Point(149, 203);
            this.dgvDjeca.Name = "dgvDjeca";
            this.dgvDjeca.RowHeadersWidth = 51;
            this.dgvDjeca.RowTemplate.Height = 24;
            this.dgvDjeca.Size = new System.Drawing.Size(853, 366);
            this.dgvDjeca.TabIndex = 22;
            // 
            // FrmDodajEvidencijaDolaska
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1148, 642);
            this.Controls.Add(this.dgvDjeca);
            this.Controls.Add(this.dtpDatum);
            this.Controls.Add(this.btnSpremi);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.cmbSkupina);
            this.Controls.Add(this.lblSkupina);
            this.Controls.Add(this.lblDatum);
            this.Controls.Add(this.lblEvidencijaDolaska);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmDodajEvidencijaDolaska";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmEvidencijaDolaska";
            this.Load += new System.EventHandler(this.FrmDodajEvidencijaDolaska_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDjeca)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblEvidencijaDolaska;
        private System.Windows.Forms.Label lblDatum;
        private System.Windows.Forms.Label lblSkupina;
        private System.Windows.Forms.ComboBox cmbSkupina;
        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.Button btnSpremi;
        private System.Windows.Forms.DateTimePicker dtpDatum;
        private System.Windows.Forms.DataGridView dgvDjeca;
    }
}