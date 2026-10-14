namespace Tiny_Explorers
{
    partial class FrmEvidencijaDolaska
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblPretragaDjece = new System.Windows.Forms.Label();
            this.lblEvidencijaDolaska = new System.Windows.Forms.Label();
            this.txtPretrazi = new System.Windows.Forms.TextBox();
            this.dgvEvidencijaDolaska = new System.Windows.Forms.DataGridView();
            this.btnGenerirajIzvjestaj = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEvidencijaDolaska)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Tiny_Explorers.Properties.Resources.kids;
            this.pictureBox1.Location = new System.Drawing.Point(271, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(70, 38);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // lblPretragaDjece
            // 
            this.lblPretragaDjece.AutoSize = true;
            this.lblPretragaDjece.Font = new System.Drawing.Font("Comic Sans MS", 14F, System.Drawing.FontStyle.Bold);
            this.lblPretragaDjece.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblPretragaDjece.Location = new System.Drawing.Point(508, 20);
            this.lblPretragaDjece.Name = "lblPretragaDjece";
            this.lblPretragaDjece.Size = new System.Drawing.Size(86, 27);
            this.lblPretragaDjece.TabIndex = 15;
            this.lblPretragaDjece.Text = "Pretraži";
            // 
            // lblEvidencijaDolaska
            // 
            this.lblEvidencijaDolaska.AutoSize = true;
            this.lblEvidencijaDolaska.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Bold);
            this.lblEvidencijaDolaska.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblEvidencijaDolaska.Location = new System.Drawing.Point(10, 7);
            this.lblEvidencijaDolaska.Name = "lblEvidencijaDolaska";
            this.lblEvidencijaDolaska.Size = new System.Drawing.Size(255, 38);
            this.lblEvidencijaDolaska.TabIndex = 16;
            this.lblEvidencijaDolaska.Text = "Evidencija dolaska";
            // 
            // txtPretrazi
            // 
            this.txtPretrazi.Font = new System.Drawing.Font("Comic Sans MS", 8.25F);
            this.txtPretrazi.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtPretrazi.Location = new System.Drawing.Point(622, 25);
            this.txtPretrazi.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPretrazi.Name = "txtPretrazi";
            this.txtPretrazi.Size = new System.Drawing.Size(219, 23);
            this.txtPretrazi.TabIndex = 17;
            this.txtPretrazi.TextChanged += new System.EventHandler(this.txtPretrazi_TextChanged);
            // 
            // dgvEvidencijaDolaska
            // 
            this.dgvEvidencijaDolaska.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.MistyRose;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Comic Sans MS", 11.25F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.Control;
            this.dgvEvidencijaDolaska.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvEvidencijaDolaska.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvEvidencijaDolaska.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEvidencijaDolaska.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvEvidencijaDolaska.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Comic Sans MS", 11.25F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvEvidencijaDolaska.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvEvidencijaDolaska.Location = new System.Drawing.Point(23, 78);
            this.dgvEvidencijaDolaska.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvEvidencijaDolaska.Name = "dgvEvidencijaDolaska";
            this.dgvEvidencijaDolaska.RowHeadersWidth = 51;
            this.dgvEvidencijaDolaska.RowTemplate.Height = 24;
            this.dgvEvidencijaDolaska.Size = new System.Drawing.Size(818, 384);
            this.dgvEvidencijaDolaska.TabIndex = 18;
            // 
            // btnGenerirajIzvjestaj
            // 
            this.btnGenerirajIzvjestaj.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnGenerirajIzvjestaj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerirajIzvjestaj.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btnGenerirajIzvjestaj.ForeColor = System.Drawing.Color.White;
            this.btnGenerirajIzvjestaj.Location = new System.Drawing.Point(676, 483);
            this.btnGenerirajIzvjestaj.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnGenerirajIzvjestaj.Name = "btnGenerirajIzvjestaj";
            this.btnGenerirajIzvjestaj.Size = new System.Drawing.Size(157, 37);
            this.btnGenerirajIzvjestaj.TabIndex = 20;
            this.btnGenerirajIzvjestaj.Text = "Generiraj izvještaj";
            this.btnGenerirajIzvjestaj.UseVisualStyleBackColor = false;
            this.btnGenerirajIzvjestaj.Click += new System.EventHandler(this.btnGenerirajIzvjestaj_Click);
            // 
            // FrmEvidencijaDolaska
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 526);
            this.Controls.Add(this.btnGenerirajIzvjestaj);
            this.Controls.Add(this.dgvEvidencijaDolaska);
            this.Controls.Add(this.txtPretrazi);
            this.Controls.Add(this.lblEvidencijaDolaska);
            this.Controls.Add(this.lblPretragaDjece);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrmEvidencijaDolaska";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmEvidencijaDolaska";
            this.Load += new System.EventHandler(this.FrmEvidencijaDolaska_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEvidencijaDolaska)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblPretragaDjece;
        private System.Windows.Forms.Label lblEvidencijaDolaska;
        private System.Windows.Forms.TextBox txtPretrazi;
        private System.Windows.Forms.DataGridView dgvEvidencijaDolaska;
        private System.Windows.Forms.Button btnGenerirajIzvjestaj;
    }
}