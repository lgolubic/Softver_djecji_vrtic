namespace Tiny_Explorers
{
    partial class FrmIzbrisiZaposlenika
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
            this.lblIzbrisiZaposlenika = new System.Windows.Forms.Label();
            this.btnIzbrisiZaposlenika = new System.Windows.Forms.Button();
            this.btnOdustaniBrisanjeZaposlenika = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblIzbrisiZaposlenika
            // 
            this.lblIzbrisiZaposlenika.AutoSize = true;
            this.lblIzbrisiZaposlenika.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblIzbrisiZaposlenika.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(62)))), ((int)(((byte)(4)))));
            this.lblIzbrisiZaposlenika.Location = new System.Drawing.Point(12, 9);
            this.lblIzbrisiZaposlenika.Name = "lblIzbrisiZaposlenika";
            this.lblIzbrisiZaposlenika.Size = new System.Drawing.Size(601, 30);
            this.lblIzbrisiZaposlenika.TabIndex = 25;
            this.lblIzbrisiZaposlenika.Text = "Jeste li sigurni da želite izbrisati zaposlenika iz sustava?";
            // 
            // btnIzbrisiZaposlenika
            // 
            this.btnIzbrisiZaposlenika.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnIzbrisiZaposlenika.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnIzbrisiZaposlenika.ForeColor = System.Drawing.Color.White;
            this.btnIzbrisiZaposlenika.Location = new System.Drawing.Point(488, 85);
            this.btnIzbrisiZaposlenika.Name = "btnIzbrisiZaposlenika";
            this.btnIzbrisiZaposlenika.Size = new System.Drawing.Size(98, 35);
            this.btnIzbrisiZaposlenika.TabIndex = 65;
            this.btnIzbrisiZaposlenika.Text = "Izbriši";
            this.btnIzbrisiZaposlenika.UseVisualStyleBackColor = false;
            this.btnIzbrisiZaposlenika.Click += new System.EventHandler(this.btnIzbrisiZaposlenika_Click);
            // 
            // btnOdustaniBrisanjeZaposlenika
            // 
            this.btnOdustaniBrisanjeZaposlenika.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnOdustaniBrisanjeZaposlenika.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnOdustaniBrisanjeZaposlenika.ForeColor = System.Drawing.Color.White;
            this.btnOdustaniBrisanjeZaposlenika.Location = new System.Drawing.Point(369, 85);
            this.btnOdustaniBrisanjeZaposlenika.Name = "btnOdustaniBrisanjeZaposlenika";
            this.btnOdustaniBrisanjeZaposlenika.Size = new System.Drawing.Size(98, 35);
            this.btnOdustaniBrisanjeZaposlenika.TabIndex = 64;
            this.btnOdustaniBrisanjeZaposlenika.Text = "Odustani";
            this.btnOdustaniBrisanjeZaposlenika.UseVisualStyleBackColor = false;
            this.btnOdustaniBrisanjeZaposlenika.Click += new System.EventHandler(this.btnOdustaniBrisanjeZaposlenika_Click);
            // 
            // FrmIzbrisiZaposlenika
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 144);
            this.Controls.Add(this.btnIzbrisiZaposlenika);
            this.Controls.Add(this.btnOdustaniBrisanjeZaposlenika);
            this.Controls.Add(this.lblIzbrisiZaposlenika);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmIzbrisiZaposlenika";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmIzbrisiZaposlenika";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIzbrisiZaposlenika;
        private System.Windows.Forms.Button btnIzbrisiZaposlenika;
        private System.Windows.Forms.Button btnOdustaniBrisanjeZaposlenika;
    }
}