namespace Tiny_Explorers
{
    partial class FrmObavijesti
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblObavijesti = new System.Windows.Forms.Label();
            this.lblNaslov = new System.Windows.Forms.Label();
            this.lblPrimatelj = new System.Windows.Forms.Label();
            this.lblDatum = new System.Windows.Forms.Label();
            this.lblOpis = new System.Windows.Forms.Label();
            this.btnPosalji = new System.Windows.Forms.Button();
            this.txtNaslov = new System.Windows.Forms.TextBox();
            this.txtOpis = new System.Windows.Forms.TextBox();
            this.cmbPrimatelj = new System.Windows.Forms.ComboBox();
            this.dtpDatum = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Tiny_Explorers.Properties.Resources.kids;
            this.pictureBox1.Location = new System.Drawing.Point(981, 13);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(123, 67);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // lblObavijesti
            // 
            this.lblObavijesti.AutoSize = true;
            this.lblObavijesti.Font = new System.Drawing.Font("Comic Sans MS", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblObavijesti.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblObavijesti.Location = new System.Drawing.Point(29, 25);
            this.lblObavijesti.Name = "lblObavijesti";
            this.lblObavijesti.Size = new System.Drawing.Size(219, 55);
            this.lblObavijesti.TabIndex = 15;
            this.lblObavijesti.Text = "Obavijesti";
            // 
            // lblNaslov
            // 
            this.lblNaslov.AutoSize = true;
            this.lblNaslov.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNaslov.Location = new System.Drawing.Point(33, 134);
            this.lblNaslov.Name = "lblNaslov";
            this.lblNaslov.Size = new System.Drawing.Size(86, 32);
            this.lblNaslov.TabIndex = 16;
            this.lblNaslov.Text = "Naslov";
            // 
            // lblPrimatelj
            // 
            this.lblPrimatelj.AutoSize = true;
            this.lblPrimatelj.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Bold);
            this.lblPrimatelj.Location = new System.Drawing.Point(33, 191);
            this.lblPrimatelj.Name = "lblPrimatelj";
            this.lblPrimatelj.Size = new System.Drawing.Size(113, 32);
            this.lblPrimatelj.TabIndex = 17;
            this.lblPrimatelj.Text = "Primatelj";
            // 
            // lblDatum
            // 
            this.lblDatum.AutoSize = true;
            this.lblDatum.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Bold);
            this.lblDatum.Location = new System.Drawing.Point(612, 134);
            this.lblDatum.Name = "lblDatum";
            this.lblDatum.Size = new System.Drawing.Size(85, 32);
            this.lblDatum.TabIndex = 18;
            this.lblDatum.Text = "Datum";
            // 
            // lblOpis
            // 
            this.lblOpis.AutoSize = true;
            this.lblOpis.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Bold);
            this.lblOpis.Location = new System.Drawing.Point(33, 251);
            this.lblOpis.Name = "lblOpis";
            this.lblOpis.Size = new System.Drawing.Size(61, 32);
            this.lblOpis.TabIndex = 19;
            this.lblOpis.Text = "Opis";
            // 
            // btnPosalji
            // 
            this.btnPosalji.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnPosalji.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPosalji.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btnPosalji.ForeColor = System.Drawing.Color.White;
            this.btnPosalji.Location = new System.Drawing.Point(997, 584);
            this.btnPosalji.Name = "btnPosalji";
            this.btnPosalji.Size = new System.Drawing.Size(107, 46);
            this.btnPosalji.TabIndex = 21;
            this.btnPosalji.Text = "Pošalji";
            this.btnPosalji.UseVisualStyleBackColor = false;
            this.btnPosalji.Click += new System.EventHandler(this.btnPosalji_Click);
            // 
            // txtNaslov
            // 
            this.txtNaslov.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNaslov.Location = new System.Drawing.Point(165, 131);
            this.txtNaslov.Name = "txtNaslov";
            this.txtNaslov.Size = new System.Drawing.Size(351, 35);
            this.txtNaslov.TabIndex = 22;
            // 
            // txtOpis
            // 
            this.txtOpis.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOpis.Location = new System.Drawing.Point(165, 251);
            this.txtOpis.Multiline = true;
            this.txtOpis.Name = "txtOpis";
            this.txtOpis.Size = new System.Drawing.Size(909, 311);
            this.txtOpis.TabIndex = 25;
            // 
            // cmbPrimatelj
            // 
            this.cmbPrimatelj.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPrimatelj.FormattingEnabled = true;
            this.cmbPrimatelj.Location = new System.Drawing.Point(165, 191);
            this.cmbPrimatelj.Name = "cmbPrimatelj";
            this.cmbPrimatelj.Size = new System.Drawing.Size(351, 36);
            this.cmbPrimatelj.TabIndex = 26;
            this.cmbPrimatelj.SelectedIndexChanged += new System.EventHandler(this.cmbPrimatelj_SelectedIndexChanged);
            // 
            // dtpDatum
            // 
            this.dtpDatum.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDatum.Location = new System.Drawing.Point(723, 134);
            this.dtpDatum.Name = "dtpDatum";
            this.dtpDatum.Size = new System.Drawing.Size(351, 35);
            this.dtpDatum.TabIndex = 27;
            // 
            // FrmObavijesti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1148, 642);
            this.Controls.Add(this.dtpDatum);
            this.Controls.Add(this.cmbPrimatelj);
            this.Controls.Add(this.txtOpis);
            this.Controls.Add(this.txtNaslov);
            this.Controls.Add(this.btnPosalji);
            this.Controls.Add(this.lblOpis);
            this.Controls.Add(this.lblDatum);
            this.Controls.Add(this.lblPrimatelj);
            this.Controls.Add(this.lblNaslov);
            this.Controls.Add(this.lblObavijesti);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmObavijesti";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmObavijesti";
            this.Load += new System.EventHandler(this.FrmObavijesti_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblObavijesti;
        private System.Windows.Forms.Label lblNaslov;
        private System.Windows.Forms.Label lblPrimatelj;
        private System.Windows.Forms.Label lblDatum;
        private System.Windows.Forms.Label lblOpis;
        private System.Windows.Forms.Button btnPosalji;
        private System.Windows.Forms.TextBox txtNaslov;
        private System.Windows.Forms.TextBox txtOpis;
        private System.Windows.Forms.ComboBox cmbPrimatelj;
        private System.Windows.Forms.DateTimePicker dtpDatum;
    }
}