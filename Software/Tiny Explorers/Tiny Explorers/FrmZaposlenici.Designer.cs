namespace Tiny_Explorers
{
    partial class FrmZaposlenici
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmZaposlenici));
            this.dgvZaposlenici = new System.Windows.Forms.DataGridView();
            this.btnGenerirajIzvjestajZaposlenika = new System.Windows.Forms.Button();
            this.btnEvidentirajZaposlenika = new System.Windows.Forms.Button();
            this.btnDodajZaposlenika = new System.Windows.Forms.Button();
            this.btnIzbrisiZaposlenika = new System.Windows.Forms.Button();
            this.btnUrediZaposlenika = new System.Windows.Forms.Button();
            this.lblNaslovZaposlenici = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvZaposlenici)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvZaposlenici
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.MistyRose;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.Control;
            this.dgvZaposlenici.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvZaposlenici.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvZaposlenici.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvZaposlenici.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvZaposlenici.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvZaposlenici.Location = new System.Drawing.Point(25, 67);
            this.dgvZaposlenici.Name = "dgvZaposlenici";
            this.dgvZaposlenici.RowHeadersWidth = 51;
            this.dgvZaposlenici.Size = new System.Drawing.Size(824, 369);
            this.dgvZaposlenici.TabIndex = 0;
            // 
            // btnGenerirajIzvjestajZaposlenika
            // 
            this.btnGenerirajIzvjestajZaposlenika.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnGenerirajIzvjestajZaposlenika.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btnGenerirajIzvjestajZaposlenika.ForeColor = System.Drawing.Color.White;
            this.btnGenerirajIzvjestajZaposlenika.Location = new System.Drawing.Point(213, 462);
            this.btnGenerirajIzvjestajZaposlenika.Name = "btnGenerirajIzvjestajZaposlenika";
            this.btnGenerirajIzvjestajZaposlenika.Size = new System.Drawing.Size(159, 48);
            this.btnGenerirajIzvjestajZaposlenika.TabIndex = 1;
            this.btnGenerirajIzvjestajZaposlenika.Text = "Generiraj izvještaj";
            this.btnGenerirajIzvjestajZaposlenika.UseVisualStyleBackColor = false;
            this.btnGenerirajIzvjestajZaposlenika.Click += new System.EventHandler(this.btnGenerirajIzvjestajZaposlenika_Click);
            // 
            // btnEvidentirajZaposlenika
            // 
            this.btnEvidentirajZaposlenika.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnEvidentirajZaposlenika.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btnEvidentirajZaposlenika.ForeColor = System.Drawing.Color.White;
            this.btnEvidentirajZaposlenika.Location = new System.Drawing.Point(378, 462);
            this.btnEvidentirajZaposlenika.Name = "btnEvidentirajZaposlenika";
            this.btnEvidentirajZaposlenika.Size = new System.Drawing.Size(118, 48);
            this.btnEvidentirajZaposlenika.TabIndex = 2;
            this.btnEvidentirajZaposlenika.Text = "Evidentiraj";
            this.btnEvidentirajZaposlenika.UseVisualStyleBackColor = false;
            // 
            // btnDodajZaposlenika
            // 
            this.btnDodajZaposlenika.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnDodajZaposlenika.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btnDodajZaposlenika.ForeColor = System.Drawing.Color.White;
            this.btnDodajZaposlenika.Location = new System.Drawing.Point(502, 462);
            this.btnDodajZaposlenika.Name = "btnDodajZaposlenika";
            this.btnDodajZaposlenika.Size = new System.Drawing.Size(108, 46);
            this.btnDodajZaposlenika.TabIndex = 3;
            this.btnDodajZaposlenika.Text = "Dodaj";
            this.btnDodajZaposlenika.UseVisualStyleBackColor = false;
            this.btnDodajZaposlenika.Click += new System.EventHandler(this.btnDodajZaposlenika_Click);
            // 
            // btnIzbrisiZaposlenika
            // 
            this.btnIzbrisiZaposlenika.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnIzbrisiZaposlenika.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btnIzbrisiZaposlenika.ForeColor = System.Drawing.Color.White;
            this.btnIzbrisiZaposlenika.Location = new System.Drawing.Point(616, 463);
            this.btnIzbrisiZaposlenika.Name = "btnIzbrisiZaposlenika";
            this.btnIzbrisiZaposlenika.Size = new System.Drawing.Size(110, 46);
            this.btnIzbrisiZaposlenika.TabIndex = 4;
            this.btnIzbrisiZaposlenika.Text = "Izbriši";
            this.btnIzbrisiZaposlenika.UseVisualStyleBackColor = false;
            this.btnIzbrisiZaposlenika.Click += new System.EventHandler(this.btnIzbrisiZaposlenika_Click);
            // 
            // btnUrediZaposlenika
            // 
            this.btnUrediZaposlenika.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnUrediZaposlenika.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btnUrediZaposlenika.ForeColor = System.Drawing.Color.White;
            this.btnUrediZaposlenika.Location = new System.Drawing.Point(732, 464);
            this.btnUrediZaposlenika.Name = "btnUrediZaposlenika";
            this.btnUrediZaposlenika.Size = new System.Drawing.Size(117, 46);
            this.btnUrediZaposlenika.TabIndex = 5;
            this.btnUrediZaposlenika.Text = "Uredi";
            this.btnUrediZaposlenika.UseVisualStyleBackColor = false;
            this.btnUrediZaposlenika.Click += new System.EventHandler(this.btnUrediZaposlenika_Click);
            // 
            // lblNaslovZaposlenici
            // 
            this.lblNaslovZaposlenici.AutoSize = true;
            this.lblNaslovZaposlenici.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Bold);
            this.lblNaslovZaposlenici.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblNaslovZaposlenici.Location = new System.Drawing.Point(12, 9);
            this.lblNaslovZaposlenici.Name = "lblNaslovZaposlenici";
            this.lblNaslovZaposlenici.Size = new System.Drawing.Size(158, 38);
            this.lblNaslovZaposlenici.TabIndex = 6;
            this.lblNaslovZaposlenici.Text = "Zaposlenici";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(175, 11);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(75, 41);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 29;
            this.pictureBox2.TabStop = false;
            // 
            // FrmZaposlenici
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 522);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.lblNaslovZaposlenici);
            this.Controls.Add(this.btnUrediZaposlenika);
            this.Controls.Add(this.btnIzbrisiZaposlenika);
            this.Controls.Add(this.btnDodajZaposlenika);
            this.Controls.Add(this.btnEvidentirajZaposlenika);
            this.Controls.Add(this.btnGenerirajIzvjestajZaposlenika);
            this.Controls.Add(this.dgvZaposlenici);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmZaposlenici";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmZaposlenici";
            this.Load += new System.EventHandler(this.FrmZaposlenici_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvZaposlenici)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.DataGridView dgvZaposlenici;
        private System.Windows.Forms.Button btnGenerirajIzvjestajZaposlenika;
        private System.Windows.Forms.Button btnEvidentirajZaposlenika;
        private System.Windows.Forms.Button btnDodajZaposlenika;
        private System.Windows.Forms.Button btnIzbrisiZaposlenika;
        private System.Windows.Forms.Button btnUrediZaposlenika;
        private System.Windows.Forms.Label lblNaslovZaposlenici;


        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
    }
}