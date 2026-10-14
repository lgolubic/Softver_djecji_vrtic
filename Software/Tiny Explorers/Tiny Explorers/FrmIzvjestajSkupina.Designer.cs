namespace Tiny_Explorers
{
    partial class FrmIzvjestajSkupina
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
            this.dgvIzvjestajSkupina = new System.Windows.Forms.DataGridView();
            this.btnNatrag = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIzvjestajSkupina)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvIzvjestajSkupina
            // 
            this.dgvIzvjestajSkupina.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIzvjestajSkupina.Location = new System.Drawing.Point(12, 22);
            this.dgvIzvjestajSkupina.Name = "dgvIzvjestajSkupina";
            this.dgvIzvjestajSkupina.RowHeadersWidth = 51;
            this.dgvIzvjestajSkupina.RowTemplate.Height = 24;
            this.dgvIzvjestajSkupina.Size = new System.Drawing.Size(1124, 559);
            this.dgvIzvjestajSkupina.TabIndex = 0;
            // 
            // btnNatrag
            // 
            this.btnNatrag.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnNatrag.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNatrag.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNatrag.ForeColor = System.Drawing.Color.White;
            this.btnNatrag.Location = new System.Drawing.Point(990, 587);
            this.btnNatrag.Name = "btnNatrag";
            this.btnNatrag.Size = new System.Drawing.Size(146, 46);
            this.btnNatrag.TabIndex = 1;
            this.btnNatrag.Text = "Natrag";
            this.btnNatrag.UseVisualStyleBackColor = false;
            this.btnNatrag.Click += new System.EventHandler(this.btnNatrag_Click);
            // 
            // FrmIzvjestajSkupina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1148, 642);
            this.Controls.Add(this.btnNatrag);
            this.Controls.Add(this.dgvIzvjestajSkupina);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmIzvjestajSkupina";
            this.Text = "FrmIzvjestajSkupina";
            this.Load += new System.EventHandler(this.FrmIzvjestajSkupina_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvIzvjestajSkupina)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvIzvjestajSkupina;
        private System.Windows.Forms.Button btnNatrag;
    }
}