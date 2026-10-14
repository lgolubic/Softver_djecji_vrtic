namespace Tiny_Explorers
{
    partial class FrmIzbrisiDijete
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
            this.lblIzbrisiDijete = new System.Windows.Forms.Label();
            this.btnOdustaniBrisanjeDjeteta = new System.Windows.Forms.Button();
            this.btnIzbrisiDijete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblIzbrisiDijete
            // 
            this.lblIzbrisiDijete.AutoSize = true;
            this.lblIzbrisiDijete.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblIzbrisiDijete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(62)))), ((int)(((byte)(4)))));
            this.lblIzbrisiDijete.Location = new System.Drawing.Point(33, 33);
            this.lblIzbrisiDijete.Name = "lblIzbrisiDijete";
            this.lblIzbrisiDijete.Size = new System.Drawing.Size(548, 30);
            this.lblIzbrisiDijete.TabIndex = 24;
            this.lblIzbrisiDijete.Text = "Jeste li sigurni da želite izbrisati dijete iz sustava?";
            // 
            // btnOdustaniBrisanjeDjeteta
            // 
            this.btnOdustaniBrisanjeDjeteta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnOdustaniBrisanjeDjeteta.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnOdustaniBrisanjeDjeteta.ForeColor = System.Drawing.Color.White;
            this.btnOdustaniBrisanjeDjeteta.Location = new System.Drawing.Point(344, 97);
            this.btnOdustaniBrisanjeDjeteta.Name = "btnOdustaniBrisanjeDjeteta";
            this.btnOdustaniBrisanjeDjeteta.Size = new System.Drawing.Size(98, 35);
            this.btnOdustaniBrisanjeDjeteta.TabIndex = 62;
            this.btnOdustaniBrisanjeDjeteta.Text = "Odustani";
            this.btnOdustaniBrisanjeDjeteta.UseVisualStyleBackColor = false;
            this.btnOdustaniBrisanjeDjeteta.Click += new System.EventHandler(this.btnOdustaniBrisanjeDjeteta_Click);
            // 
            // btnIzbrisiDijete
            // 
            this.btnIzbrisiDijete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnIzbrisiDijete.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnIzbrisiDijete.ForeColor = System.Drawing.Color.White;
            this.btnIzbrisiDijete.Location = new System.Drawing.Point(463, 97);
            this.btnIzbrisiDijete.Name = "btnIzbrisiDijete";
            this.btnIzbrisiDijete.Size = new System.Drawing.Size(98, 35);
            this.btnIzbrisiDijete.TabIndex = 63;
            this.btnIzbrisiDijete.Text = "Izbriši";
            this.btnIzbrisiDijete.UseVisualStyleBackColor = false;
            this.btnIzbrisiDijete.Click += new System.EventHandler(this.btnIzbrisiDijete_Click);
            // 
            // FrmIzbrisiDijete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 144);
            this.Controls.Add(this.btnIzbrisiDijete);
            this.Controls.Add(this.btnOdustaniBrisanjeDjeteta);
            this.Controls.Add(this.lblIzbrisiDijete);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmIzbrisiDijete";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmIzbrisiDjecu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIzbrisiDijete;
        private System.Windows.Forms.Button btnOdustaniBrisanjeDjeteta;
        private System.Windows.Forms.Button btnIzbrisiDijete;
    }
}