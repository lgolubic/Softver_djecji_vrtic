namespace Tiny_Explorers
{
    partial class FrmIzvjestajZaposlenik
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
            this.dgvIzvjestajZaposlenik = new System.Windows.Forms.DataGridView();
            this.btnNatrag = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIzvjestajZaposlenik)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvIzvjestajZaposlenik
            // 
            this.dgvIzvjestajZaposlenik.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIzvjestajZaposlenik.Location = new System.Drawing.Point(25, 30);
            this.dgvIzvjestajZaposlenik.Name = "dgvIzvjestajZaposlenik";
            this.dgvIzvjestajZaposlenik.RowHeadersWidth = 51;
            this.dgvIzvjestajZaposlenik.RowTemplate.Height = 24;
            this.dgvIzvjestajZaposlenik.Size = new System.Drawing.Size(1089, 549);
            this.dgvIzvjestajZaposlenik.TabIndex = 0;
            // 
            // btnNatrag
            // 
            this.btnNatrag.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnNatrag.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNatrag.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNatrag.ForeColor = System.Drawing.Color.White;
            this.btnNatrag.Location = new System.Drawing.Point(982, 585);
            this.btnNatrag.Name = "btnNatrag";
            this.btnNatrag.Size = new System.Drawing.Size(132, 46);
            this.btnNatrag.TabIndex = 1;
            this.btnNatrag.Text = "Natrag";
            this.btnNatrag.UseVisualStyleBackColor = false;
            this.btnNatrag.Click += new System.EventHandler(this.btnNatrag_Click);
            // 
            // FrmIzvjestajZaposlenik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1148, 642);
            this.Controls.Add(this.btnNatrag);
            this.Controls.Add(this.dgvIzvjestajZaposlenik);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmIzvjestajZaposlenik";
            this.Text = "FrmIzvjestajZaposlenik";
            this.Load += new System.EventHandler(this.FrmIzvjestajZaposlenik_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvIzvjestajZaposlenik)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvIzvjestajZaposlenik;
        private System.Windows.Forms.Button btnNatrag;
    }
}