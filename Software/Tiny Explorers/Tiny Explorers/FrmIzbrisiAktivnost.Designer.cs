namespace Tiny_Explorers
{
    partial class FrmIzbrisiAktivnost
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
            this.lblIzbrisiAktivnost = new System.Windows.Forms.Label();
            this.btnIzbrisiAktivnost = new System.Windows.Forms.Button();
            this.btnOdustaniBrisanjeAktivnosti = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblIzbrisiAktivnost
            // 
            this.lblIzbrisiAktivnost.AutoSize = true;
            this.lblIzbrisiAktivnost.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblIzbrisiAktivnost.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(62)))), ((int)(((byte)(4)))));
            this.lblIzbrisiAktivnost.Location = new System.Drawing.Point(12, 19);
            this.lblIzbrisiAktivnost.Name = "lblIzbrisiAktivnost";
            this.lblIzbrisiAktivnost.Size = new System.Drawing.Size(579, 30);
            this.lblIzbrisiAktivnost.TabIndex = 25;
            this.lblIzbrisiAktivnost.Text = "Jeste li sigurni da želite izbrisati aktivnost iz sustava?";
            // 
            // btnIzbrisiAktivnost
            // 
            this.btnIzbrisiAktivnost.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnIzbrisiAktivnost.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnIzbrisiAktivnost.ForeColor = System.Drawing.Color.White;
            this.btnIzbrisiAktivnost.Location = new System.Drawing.Point(477, 97);
            this.btnIzbrisiAktivnost.Name = "btnIzbrisiAktivnost";
            this.btnIzbrisiAktivnost.Size = new System.Drawing.Size(98, 35);
            this.btnIzbrisiAktivnost.TabIndex = 65;
            this.btnIzbrisiAktivnost.Text = "Izbriši";
            this.btnIzbrisiAktivnost.UseVisualStyleBackColor = false;
            this.btnIzbrisiAktivnost.Click += new System.EventHandler(this.btnIzbrisiAktivnost_Click);
            // 
            // btnOdustaniBrisanjeAktivnosti
            // 
            this.btnOdustaniBrisanjeAktivnosti.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnOdustaniBrisanjeAktivnosti.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnOdustaniBrisanjeAktivnosti.ForeColor = System.Drawing.Color.White;
            this.btnOdustaniBrisanjeAktivnosti.Location = new System.Drawing.Point(358, 97);
            this.btnOdustaniBrisanjeAktivnosti.Name = "btnOdustaniBrisanjeAktivnosti";
            this.btnOdustaniBrisanjeAktivnosti.Size = new System.Drawing.Size(98, 35);
            this.btnOdustaniBrisanjeAktivnosti.TabIndex = 64;
            this.btnOdustaniBrisanjeAktivnosti.Text = "Odustani";
            this.btnOdustaniBrisanjeAktivnosti.UseVisualStyleBackColor = false;
            this.btnOdustaniBrisanjeAktivnosti.Click += new System.EventHandler(this.btnOdustaniBrisanjeAktivnosti_Click);
            // 
            // FrmIzbrisiAktivnost
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 144);
            this.Controls.Add(this.btnIzbrisiAktivnost);
            this.Controls.Add(this.btnOdustaniBrisanjeAktivnosti);
            this.Controls.Add(this.lblIzbrisiAktivnost);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmIzbrisiAktivnost";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmIzbrisiAktivnost";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIzbrisiAktivnost;
        private System.Windows.Forms.Button btnIzbrisiAktivnost;
        private System.Windows.Forms.Button btnOdustaniBrisanjeAktivnosti;
    }
}