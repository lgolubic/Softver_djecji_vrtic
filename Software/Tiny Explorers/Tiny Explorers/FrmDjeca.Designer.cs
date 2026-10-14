namespace Tiny_Explorers
{
    partial class FrmDjeca
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
            this.dgvDjeca = new System.Windows.Forms.DataGridView();
            this.btnBiljeska = new System.Windows.Forms.Button();
            this.btnGenerirajIzvjestaj = new System.Windows.Forms.Button();
            this.btnUrediDijete = new System.Windows.Forms.Button();
            this.btnIzbrisiDijete = new System.Windows.Forms.Button();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.lblPretragaDjece = new System.Windows.Forms.Label();
            this.txtPretraziDjecu = new System.Windows.Forms.TextBox();
            this.lblNaslovDjeca = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDetalji = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDjeca)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDjeca
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.MistyRose;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.Control;
            this.dgvDjeca.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDjeca.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvDjeca.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDjeca.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDjeca.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDjeca.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDjeca.Location = new System.Drawing.Point(9, 59);
            this.dgvDjeca.Name = "dgvDjeca";
            this.dgvDjeca.RowHeadersWidth = 51;
            this.dgvDjeca.Size = new System.Drawing.Size(838, 365);
            this.dgvDjeca.TabIndex = 1;
            // 
            // btnBiljeska
            // 
            this.btnBiljeska.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnBiljeska.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBiljeska.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btnBiljeska.ForeColor = System.Drawing.Color.White;
            this.btnBiljeska.Location = new System.Drawing.Point(272, 459);
            this.btnBiljeska.Name = "btnBiljeska";
            this.btnBiljeska.Size = new System.Drawing.Size(85, 37);
            this.btnBiljeska.TabIndex = 2;
            this.btnBiljeska.Text = "Bilješka";
            this.btnBiljeska.UseVisualStyleBackColor = false;
            this.btnBiljeska.Click += new System.EventHandler(this.btnBiljeske_Click);
            // 
            // btnGenerirajIzvjestaj
            // 
            this.btnGenerirajIzvjestaj.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnGenerirajIzvjestaj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerirajIzvjestaj.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btnGenerirajIzvjestaj.ForeColor = System.Drawing.Color.White;
            this.btnGenerirajIzvjestaj.Location = new System.Drawing.Point(678, 459);
            this.btnGenerirajIzvjestaj.Name = "btnGenerirajIzvjestaj";
            this.btnGenerirajIzvjestaj.Size = new System.Drawing.Size(172, 37);
            this.btnGenerirajIzvjestaj.TabIndex = 4;
            this.btnGenerirajIzvjestaj.Text = "Generiraj izvještaj";
            this.btnGenerirajIzvjestaj.UseVisualStyleBackColor = false;
            this.btnGenerirajIzvjestaj.Click += new System.EventHandler(this.btnGenerirajIzvjestaj_Click);
            // 
            // btnUrediDijete
            // 
            this.btnUrediDijete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnUrediDijete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUrediDijete.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btnUrediDijete.ForeColor = System.Drawing.Color.White;
            this.btnUrediDijete.Location = new System.Drawing.Point(566, 459);
            this.btnUrediDijete.Margin = new System.Windows.Forms.Padding(2);
            this.btnUrediDijete.Name = "btnUrediDijete";
            this.btnUrediDijete.Size = new System.Drawing.Size(107, 37);
            this.btnUrediDijete.TabIndex = 5;
            this.btnUrediDijete.Text = "Uredi";
            this.btnUrediDijete.UseVisualStyleBackColor = false;
            this.btnUrediDijete.Click += new System.EventHandler(this.btnUrediDijete_Click);
            // 
            // btnIzbrisiDijete
            // 
            this.btnIzbrisiDijete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnIzbrisiDijete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIzbrisiDijete.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btnIzbrisiDijete.ForeColor = System.Drawing.Color.White;
            this.btnIzbrisiDijete.Location = new System.Drawing.Point(464, 459);
            this.btnIzbrisiDijete.Margin = new System.Windows.Forms.Padding(2);
            this.btnIzbrisiDijete.Name = "btnIzbrisiDijete";
            this.btnIzbrisiDijete.Size = new System.Drawing.Size(98, 37);
            this.btnIzbrisiDijete.TabIndex = 6;
            this.btnIzbrisiDijete.Text = "Izbriši";
            this.btnIzbrisiDijete.UseVisualStyleBackColor = false;
            this.btnIzbrisiDijete.Click += new System.EventHandler(this.btnIzbrisiDijete_Click);
            // 
            // btnDodaj
            // 
            this.btnDodaj.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnDodaj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDodaj.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btnDodaj.ForeColor = System.Drawing.Color.White;
            this.btnDodaj.Location = new System.Drawing.Point(363, 459);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(96, 37);
            this.btnDodaj.TabIndex = 7;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = false;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // lblPretragaDjece
            // 
            this.lblPretragaDjece.AutoSize = true;
            this.lblPretragaDjece.Font = new System.Drawing.Font("Comic Sans MS", 14F, System.Drawing.FontStyle.Bold);
            this.lblPretragaDjece.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblPretragaDjece.Location = new System.Drawing.Point(511, 23);
            this.lblPretragaDjece.Name = "lblPretragaDjece";
            this.lblPretragaDjece.Size = new System.Drawing.Size(86, 27);
            this.lblPretragaDjece.TabIndex = 9;
            this.lblPretragaDjece.Text = "Pretraži";
            // 
            // txtPretraziDjecu
            // 
            this.txtPretraziDjecu.BackColor = System.Drawing.SystemColors.Control;
            this.txtPretraziDjecu.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPretraziDjecu.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtPretraziDjecu.Location = new System.Drawing.Point(603, 17);
            this.txtPretraziDjecu.Name = "txtPretraziDjecu";
            this.txtPretraziDjecu.Size = new System.Drawing.Size(236, 23);
            this.txtPretraziDjecu.TabIndex = 10;
            this.txtPretraziDjecu.TextChanged += new System.EventHandler(this.txtPretraziDjecu_TextChanged);
            // 
            // lblNaslovDjeca
            // 
            this.lblNaslovDjeca.AutoSize = true;
            this.lblNaslovDjeca.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNaslovDjeca.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblNaslovDjeca.Location = new System.Drawing.Point(12, 12);
            this.lblNaslovDjeca.Name = "lblNaslovDjeca";
            this.lblNaslovDjeca.Size = new System.Drawing.Size(91, 38);
            this.lblNaslovDjeca.TabIndex = 11;
            this.lblNaslovDjeca.Text = "Djeca";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SaddleBrown;
            this.panel1.Location = new System.Drawing.Point(603, 42);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(236, 1);
            this.panel1.TabIndex = 12;
            // 
            // btnDetalji
            // 
            this.btnDetalji.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnDetalji.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDetalji.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btnDetalji.ForeColor = System.Drawing.Color.White;
            this.btnDetalji.Location = new System.Drawing.Point(130, 459);
            this.btnDetalji.Name = "btnDetalji";
            this.btnDetalji.Size = new System.Drawing.Size(136, 37);
            this.btnDetalji.TabIndex = 14;
            this.btnDetalji.Text = "Prikaži detalje";
            this.btnDetalji.UseVisualStyleBackColor = false;
            this.btnDetalji.Click += new System.EventHandler(this.btnDetalji_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Tiny_Explorers.Properties.Resources.kids;
            this.pictureBox1.Location = new System.Drawing.Point(96, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(70, 38);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false; 
            // 
            // FrmDjeca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(861, 522);
            this.Controls.Add(this.btnDetalji);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblNaslovDjeca);
            this.Controls.Add(this.txtPretraziDjecu);
            this.Controls.Add(this.lblPretragaDjece);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.btnIzbrisiDijete);
            this.Controls.Add(this.btnUrediDijete);
            this.Controls.Add(this.btnGenerirajIzvjestaj);
            this.Controls.Add(this.btnBiljeska);
            this.Controls.Add(this.dgvDjeca);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmDjeca";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmDjeca";
            this.Load += new System.EventHandler(this.FrmDjeca_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDjeca)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvDjeca;
        private System.Windows.Forms.Button btnBiljeska;
        private System.Windows.Forms.Button btnGenerirajIzvjestaj;
        private System.Windows.Forms.Button btnUrediDijete;
        private System.Windows.Forms.Button btnIzbrisiDijete;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Label lblPretragaDjece;
        private System.Windows.Forms.TextBox txtPretraziDjecu;
        private System.Windows.Forms.Label lblNaslovDjeca;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnDetalji;
    }
}