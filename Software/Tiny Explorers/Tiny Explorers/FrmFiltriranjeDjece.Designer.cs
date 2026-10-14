namespace Tiny_Explorers
{
    partial class FrmFiltriranjeDjece
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
            this.lblFiltracija = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtPrezime = new System.Windows.Forms.TextBox();
            this.txtIme = new System.Windows.Forms.TextBox();
            this.btnFiltrirajDjecu = new System.Windows.Forms.Button();
            this.cbxIme = new System.Windows.Forms.CheckBox();
            this.cbxPrezime = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblFiltracija
            // 
            this.lblFiltracija.AutoSize = true;
            this.lblFiltracija.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblFiltracija.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(62)))), ((int)(((byte)(4)))));
            this.lblFiltracija.Location = new System.Drawing.Point(29, 23);
            this.lblFiltracija.Name = "lblFiltracija";
            this.lblFiltracija.Size = new System.Drawing.Size(197, 30);
            this.lblFiltracija.TabIndex = 0;
            this.lblFiltracija.Text = "Filtriraj djecu po:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbxPrezime);
            this.groupBox1.Controls.Add(this.cbxIme);
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.txtPrezime);
            this.groupBox1.Controls.Add(this.txtIme);
            this.groupBox1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(62)))), ((int)(((byte)(4)))));
            this.groupBox1.Location = new System.Drawing.Point(34, 81);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(374, 129);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "kriteriju";
          
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(62)))), ((int)(((byte)(4)))));
            this.panel2.Location = new System.Drawing.Point(131, 113);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(236, 1);
            this.panel2.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(62)))), ((int)(((byte)(4)))));
            this.panel1.Location = new System.Drawing.Point(131, 64);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(236, 1);
            this.panel1.TabIndex = 4;
            // 
            // txtPrezime
            // 
            this.txtPrezime.BackColor = System.Drawing.SystemColors.Control;
            this.txtPrezime.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPrezime.Location = new System.Drawing.Point(131, 77);
            this.txtPrezime.Name = "txtPrezime";
            this.txtPrezime.Size = new System.Drawing.Size(236, 23);
            this.txtPrezime.TabIndex = 3;
            // 
            // txtIme
            // 
            this.txtIme.BackColor = System.Drawing.SystemColors.Control;
            this.txtIme.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtIme.Location = new System.Drawing.Point(131, 28);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(236, 23);
            this.txtIme.TabIndex = 2;
            // 
            // btnFiltrirajDjecu
            // 
            this.btnFiltrirajDjecu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnFiltrirajDjecu.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnFiltrirajDjecu.ForeColor = System.Drawing.Color.White;
            this.btnFiltrirajDjecu.Location = new System.Drawing.Point(289, 216);
            this.btnFiltrirajDjecu.Name = "btnFiltrirajDjecu";
            this.btnFiltrirajDjecu.Size = new System.Drawing.Size(98, 35);
            this.btnFiltrirajDjecu.TabIndex = 2;
            this.btnFiltrirajDjecu.Text = "Filtriraj";
            this.btnFiltrirajDjecu.UseVisualStyleBackColor = false;
            this.btnFiltrirajDjecu.Click += new System.EventHandler(this.btnFiltrirajDjecu_Click);
            // 
            // cbxIme
            // 
            this.cbxIme.AutoSize = true;
            this.cbxIme.Location = new System.Drawing.Point(6, 38);
            this.cbxIme.Name = "cbxIme";
            this.cbxIme.Size = new System.Drawing.Size(59, 27);
            this.cbxIme.TabIndex = 6;
            this.cbxIme.Text = "Ime";
            this.cbxIme.UseVisualStyleBackColor = true;
            // 
            // cbxPrezime
            // 
            this.cbxPrezime.AutoSize = true;
            this.cbxPrezime.Location = new System.Drawing.Point(6, 87);
            this.cbxPrezime.Name = "cbxPrezime";
            this.cbxPrezime.Size = new System.Drawing.Size(89, 27);
            this.cbxPrezime.TabIndex = 7;
            this.cbxPrezime.Text = "Prezime";
            this.cbxPrezime.UseVisualStyleBackColor = true;
            // 
            // FrmFiltriranjeDjece
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 263);
            this.Controls.Add(this.btnFiltrirajDjecu);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblFiltracija);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmFiltriranjeDjece";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmFiltriranjeDjece";
            this.TopMost = true;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFiltracija;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnFiltrirajDjecu;
        public System.Windows.Forms.TextBox txtIme;
        public System.Windows.Forms.TextBox txtPrezime;
        private System.Windows.Forms.CheckBox cbxIme;
        private System.Windows.Forms.CheckBox cbxPrezime;
    }
}