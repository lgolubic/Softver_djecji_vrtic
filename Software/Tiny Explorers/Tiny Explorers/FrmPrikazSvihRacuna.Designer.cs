namespace Tiny_Explorers
{
    partial class FrmPrikazSvihRacuna
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrikazSvihRacuna));
            this.lblNaslovRacuni = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtPretraziRacune = new System.Windows.Forms.TextBox();
            this.lblPretragaRacuna = new System.Windows.Forms.Label();
            this.dgvRacuni = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnDetaljiRacuna = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRacuni)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNaslovRacuni
            // 
            this.lblNaslovRacuni.AutoSize = true;
            this.lblNaslovRacuni.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNaslovRacuni.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblNaslovRacuni.Location = new System.Drawing.Point(24, 23);
            this.lblNaslovRacuni.Name = "lblNaslovRacuni";
            this.lblNaslovRacuni.Size = new System.Drawing.Size(99, 38);
            this.lblNaslovRacuni.TabIndex = 12;
            this.lblNaslovRacuni.Text = "Računi";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SaddleBrown;
            this.panel1.Location = new System.Drawing.Point(602, 42);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(236, 1);
            this.panel1.TabIndex = 17;
            // 
            // txtPretraziRacune
            // 
            this.txtPretraziRacune.BackColor = System.Drawing.SystemColors.Control;
            this.txtPretraziRacune.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPretraziRacune.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtPretraziRacune.Location = new System.Drawing.Point(602, 17);
            this.txtPretraziRacune.Name = "txtPretraziRacune";
            this.txtPretraziRacune.Size = new System.Drawing.Size(236, 23);
            this.txtPretraziRacune.TabIndex = 16;
            this.txtPretraziRacune.TextChanged += new System.EventHandler(this.txtPretraziRacune_TextChanged);
            // 
            // lblPretragaRacuna
            // 
            this.lblPretragaRacuna.AutoSize = true;
            this.lblPretragaRacuna.Font = new System.Drawing.Font("Comic Sans MS", 14F, System.Drawing.FontStyle.Bold);
            this.lblPretragaRacuna.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblPretragaRacuna.Location = new System.Drawing.Point(510, 23);
            this.lblPretragaRacuna.Name = "lblPretragaRacuna";
            this.lblPretragaRacuna.Size = new System.Drawing.Size(86, 27);
            this.lblPretragaRacuna.TabIndex = 15;
            this.lblPretragaRacuna.Text = "Pretraži";
            // 
            // dgvRacuni
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.MistyRose;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.Control;
            this.dgvRacuni.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvRacuni.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRacuni.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvRacuni.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvRacuni.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvRacuni.Location = new System.Drawing.Point(11, 79);
            this.dgvRacuni.Name = "dgvRacuni";
            this.dgvRacuni.Size = new System.Drawing.Size(838, 371);
            this.dgvRacuni.TabIndex = 18;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(129, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(118, 73);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // btnDetaljiRacuna
            // 
            this.btnDetaljiRacuna.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnDetaljiRacuna.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDetaljiRacuna.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btnDetaljiRacuna.ForeColor = System.Drawing.Color.White;
            this.btnDetaljiRacuna.Location = new System.Drawing.Point(713, 473);
            this.btnDetaljiRacuna.Name = "btnDetaljiRacuna";
            this.btnDetaljiRacuna.Size = new System.Drawing.Size(136, 37);
            this.btnDetaljiRacuna.TabIndex = 19;
            this.btnDetaljiRacuna.Text = "Prikaži detalje";
            this.btnDetaljiRacuna.UseVisualStyleBackColor = false;
            this.btnDetaljiRacuna.Click += new System.EventHandler(this.btnDetaljiRacuna_Click);
            // 
            // FrmPrikazSvihRacuna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 522);
            this.Controls.Add(this.btnDetaljiRacuna);
            this.Controls.Add(this.dgvRacuni);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtPretraziRacune);
            this.Controls.Add(this.lblPretragaRacuna);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblNaslovRacuni);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmPrikazSvihRacuna";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmPrikazSvihRacuna";
            this.Load += new System.EventHandler(this.FrmPrikazSvihRacuna_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRacuni)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNaslovRacuni;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtPretraziRacune;
        private System.Windows.Forms.Label lblPretragaRacuna;
        private System.Windows.Forms.DataGridView dgvRacuni;
        private System.Windows.Forms.Button btnDetaljiRacuna;
    }
}