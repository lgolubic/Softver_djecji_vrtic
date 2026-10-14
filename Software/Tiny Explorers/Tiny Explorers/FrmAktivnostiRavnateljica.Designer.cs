namespace Tiny_Explorers
{
    partial class FrmAktivnostiRavnateljica
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAktivnostiRavnateljica));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtPretraziAktivnostiRavnateljica = new System.Windows.Forms.TextBox();
            this.lblPretragaAktivnostiRavnateljica = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblNaslovAktivnostiRavnateljica = new System.Windows.Forms.Label();
            this.dgvAktivnosti = new System.Windows.Forms.DataGridView();
            this.btnDetaljiAktivnostiRavnateljica = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAktivnosti)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SaddleBrown;
            this.panel1.Location = new System.Drawing.Point(599, 51);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(236, 1);
            this.panel1.TabIndex = 23;
            // 
            // txtPretraziAktivnostiRavnateljica
            // 
            this.txtPretraziAktivnostiRavnateljica.BackColor = System.Drawing.SystemColors.Control;
            this.txtPretraziAktivnostiRavnateljica.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPretraziAktivnostiRavnateljica.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtPretraziAktivnostiRavnateljica.Location = new System.Drawing.Point(599, 27);
            this.txtPretraziAktivnostiRavnateljica.Name = "txtPretraziAktivnostiRavnateljica";
            this.txtPretraziAktivnostiRavnateljica.Size = new System.Drawing.Size(236, 23);
            this.txtPretraziAktivnostiRavnateljica.TabIndex = 22;
            this.txtPretraziAktivnostiRavnateljica.TextChanged += new System.EventHandler(this.txtPretraziAktivnostiRavnateljica_TextChanged);
            // 
            // lblPretragaAktivnostiRavnateljica
            // 
            this.lblPretragaAktivnostiRavnateljica.AutoSize = true;
            this.lblPretragaAktivnostiRavnateljica.Font = new System.Drawing.Font("Comic Sans MS", 14F, System.Drawing.FontStyle.Bold);
            this.lblPretragaAktivnostiRavnateljica.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblPretragaAktivnostiRavnateljica.Location = new System.Drawing.Point(507, 32);
            this.lblPretragaAktivnostiRavnateljica.Name = "lblPretragaAktivnostiRavnateljica";
            this.lblPretragaAktivnostiRavnateljica.Size = new System.Drawing.Size(86, 27);
            this.lblPretragaAktivnostiRavnateljica.TabIndex = 21;
            this.lblPretragaAktivnostiRavnateljica.Text = "Pretraži";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(166, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(70, 38);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // lblNaslovAktivnostiRavnateljica
            // 
            this.lblNaslovAktivnostiRavnateljica.AutoSize = true;
            this.lblNaslovAktivnostiRavnateljica.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNaslovAktivnostiRavnateljica.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblNaslovAktivnostiRavnateljica.Location = new System.Drawing.Point(12, 9);
            this.lblNaslovAktivnostiRavnateljica.Name = "lblNaslovAktivnostiRavnateljica";
            this.lblNaslovAktivnostiRavnateljica.Size = new System.Drawing.Size(148, 38);
            this.lblNaslovAktivnostiRavnateljica.TabIndex = 19;
            this.lblNaslovAktivnostiRavnateljica.Text = "Aktivnosti";
            // 
            // dgvAktivnosti
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.MistyRose;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.Control;
            this.dgvAktivnosti.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvAktivnosti.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAktivnosti.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvAktivnosti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAktivnosti.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvAktivnosti.Location = new System.Drawing.Point(25, 74);
            this.dgvAktivnosti.Name = "dgvAktivnosti";
            this.dgvAktivnosti.Size = new System.Drawing.Size(811, 386);
            this.dgvAktivnosti.TabIndex = 24;
          
            // 
            // btnDetaljiAktivnostiRavnateljica
            // 
            this.btnDetaljiAktivnostiRavnateljica.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnDetaljiAktivnostiRavnateljica.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDetaljiAktivnostiRavnateljica.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btnDetaljiAktivnostiRavnateljica.ForeColor = System.Drawing.Color.White;
            this.btnDetaljiAktivnostiRavnateljica.Location = new System.Drawing.Point(700, 473);
            this.btnDetaljiAktivnostiRavnateljica.Name = "btnDetaljiAktivnostiRavnateljica";
            this.btnDetaljiAktivnostiRavnateljica.Size = new System.Drawing.Size(136, 37);
            this.btnDetaljiAktivnostiRavnateljica.TabIndex = 25;
            this.btnDetaljiAktivnostiRavnateljica.Text = "Prikaži detalje";
            this.btnDetaljiAktivnostiRavnateljica.UseVisualStyleBackColor = false;
            this.btnDetaljiAktivnostiRavnateljica.Click += new System.EventHandler(this.btnDetaljiAktivnostiRavnateljica_Click);
            // 
            // FrmAktivnostiRavnateljica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 522);
            this.Controls.Add(this.btnDetaljiAktivnostiRavnateljica);
            this.Controls.Add(this.dgvAktivnosti);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtPretraziAktivnostiRavnateljica);
            this.Controls.Add(this.lblPretragaAktivnostiRavnateljica);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblNaslovAktivnostiRavnateljica);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmAktivnostiRavnateljica";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FrmAktivnostiRavnateljica_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAktivnosti)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtPretraziAktivnostiRavnateljica;
        private System.Windows.Forms.Label lblPretragaAktivnostiRavnateljica;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblNaslovAktivnostiRavnateljica;
        private System.Windows.Forms.DataGridView dgvAktivnosti;
        private System.Windows.Forms.Button btnDetaljiAktivnostiRavnateljica;
    }
}