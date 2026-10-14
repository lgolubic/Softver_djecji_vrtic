namespace Tiny_Explorers
{
    partial class FrmIzbrisiSkupinu
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
            this.lblIzbrisiSkupinu = new System.Windows.Forms.Label();
            this.btnIzbrisiSkupinu = new System.Windows.Forms.Button();
            this.btnOdustaniBrisanjeSkupine = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblIzbrisiSkupinu
            // 
            this.lblIzbrisiSkupinu.AutoSize = true;
            this.lblIzbrisiSkupinu.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblIzbrisiSkupinu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(62)))), ((int)(((byte)(4)))));
            this.lblIzbrisiSkupinu.Location = new System.Drawing.Point(12, 24);
            this.lblIzbrisiSkupinu.Name = "lblIzbrisiSkupinu";
            this.lblIzbrisiSkupinu.Size = new System.Drawing.Size(559, 30);
            this.lblIzbrisiSkupinu.TabIndex = 25;
            this.lblIzbrisiSkupinu.Text = "Jeste li sigurni da želite izbrisati skupinu iz sustava?";
            // 
            // btnIzbrisiSkupinu
            // 
            this.btnIzbrisiSkupinu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnIzbrisiSkupinu.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnIzbrisiSkupinu.ForeColor = System.Drawing.Color.White;
            this.btnIzbrisiSkupinu.Location = new System.Drawing.Point(473, 97);
            this.btnIzbrisiSkupinu.Name = "btnIzbrisiSkupinu";
            this.btnIzbrisiSkupinu.Size = new System.Drawing.Size(98, 35);
            this.btnIzbrisiSkupinu.TabIndex = 65;
            this.btnIzbrisiSkupinu.Text = "Izbriši";
            this.btnIzbrisiSkupinu.UseVisualStyleBackColor = false;
            this.btnIzbrisiSkupinu.Click += new System.EventHandler(this.btnIzbrisi_Click);
            // 
            // btnOdustaniBrisanjeSkupine
            // 
            this.btnOdustaniBrisanjeSkupine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnOdustaniBrisanjeSkupine.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnOdustaniBrisanjeSkupine.ForeColor = System.Drawing.Color.White;
            this.btnOdustaniBrisanjeSkupine.Location = new System.Drawing.Point(354, 97);
            this.btnOdustaniBrisanjeSkupine.Name = "btnOdustaniBrisanjeSkupine";
            this.btnOdustaniBrisanjeSkupine.Size = new System.Drawing.Size(98, 35);
            this.btnOdustaniBrisanjeSkupine.TabIndex = 64;
            this.btnOdustaniBrisanjeSkupine.Text = "Odustani";
            this.btnOdustaniBrisanjeSkupine.UseVisualStyleBackColor = false;
            this.btnOdustaniBrisanjeSkupine.Click += new System.EventHandler(this.btnOdustaniBrisanjeSkupine_Click);
            // 
            // FrmIzbrisiSkupinu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 144);
            this.Controls.Add(this.btnIzbrisiSkupinu);
            this.Controls.Add(this.btnOdustaniBrisanjeSkupine);
            this.Controls.Add(this.lblIzbrisiSkupinu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmIzbrisiSkupinu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmIzbrisiSkupinu";
            this.Load += new System.EventHandler(this.FrmIzbrisiSkupinu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIzbrisiSkupinu;
        private System.Windows.Forms.Button btnIzbrisiSkupinu;
        private System.Windows.Forms.Button btnOdustaniBrisanjeSkupine;
    }
}