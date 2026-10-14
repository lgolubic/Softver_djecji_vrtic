using System;

namespace Tiny_Explorers
{
    partial class FrmSkupine
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
            this.dgvSkupine = new System.Windows.Forms.DataGridView();
            this.btnGenerirajIzvjestaj = new System.Windows.Forms.Button();
            this.btnEvidentiraj = new System.Windows.Forms.Button();
            this.btnDodajSkupinu = new System.Windows.Forms.Button();
            this.btnIzbriši = new System.Windows.Forms.Button();
            this.btnUredi = new System.Windows.Forms.Button();
            this.lblNaslovSkupine = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSkupine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSkupine
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.MistyRose;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.Control;
            this.dgvSkupine.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSkupine.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvSkupine.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSkupine.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvSkupine.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSkupine.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvSkupine.Location = new System.Drawing.Point(12, 67);
            this.dgvSkupine.Name = "dgvSkupine";
            this.dgvSkupine.RowHeadersWidth = 51;
            this.dgvSkupine.Size = new System.Drawing.Size(821, 358);
            this.dgvSkupine.TabIndex = 0;
            // 
            // btnGenerirajIzvjestaj
            // 
            this.btnGenerirajIzvjestaj.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnGenerirajIzvjestaj.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnGenerirajIzvjestaj.ForeColor = System.Drawing.Color.White;
            this.btnGenerirajIzvjestaj.Location = new System.Drawing.Point(197, 451);
            this.btnGenerirajIzvjestaj.Name = "btnGenerirajIzvjestaj";
            this.btnGenerirajIzvjestaj.Size = new System.Drawing.Size(159, 48);
            this.btnGenerirajIzvjestaj.TabIndex = 2;
            this.btnGenerirajIzvjestaj.Text = "Generiraj izvještaj";
            this.btnGenerirajIzvjestaj.UseVisualStyleBackColor = false;
            this.btnGenerirajIzvjestaj.Click += new System.EventHandler(this.btnGenerirajIzvjestaj_Click);
            // 
            // btnEvidentiraj
            // 
            this.btnEvidentiraj.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnEvidentiraj.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnEvidentiraj.ForeColor = System.Drawing.Color.White;
            this.btnEvidentiraj.Location = new System.Drawing.Point(362, 451);
            this.btnEvidentiraj.Name = "btnEvidentiraj";
            this.btnEvidentiraj.Size = new System.Drawing.Size(118, 48);
            this.btnEvidentiraj.TabIndex = 3;
            this.btnEvidentiraj.Text = "Evidentiraj";
            this.btnEvidentiraj.UseVisualStyleBackColor = false;
            // 
            // btnDodajSkupinu
            // 
            this.btnDodajSkupinu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnDodajSkupinu.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDodajSkupinu.ForeColor = System.Drawing.Color.White;
            this.btnDodajSkupinu.Location = new System.Drawing.Point(486, 451);
            this.btnDodajSkupinu.Name = "btnDodajSkupinu";
            this.btnDodajSkupinu.Size = new System.Drawing.Size(108, 46);
            this.btnDodajSkupinu.TabIndex = 4;
            this.btnDodajSkupinu.Text = "Dodaj";
            this.btnDodajSkupinu.UseVisualStyleBackColor = false;
            this.btnDodajSkupinu.Click += new System.EventHandler(this.btnDodajSkupinu_Click);
            // 
            // btnIzbriši
            // 
            this.btnIzbriši.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnIzbriši.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnIzbriši.ForeColor = System.Drawing.Color.White;
            this.btnIzbriši.Location = new System.Drawing.Point(600, 452);
            this.btnIzbriši.Name = "btnIzbriši";
            this.btnIzbriši.Size = new System.Drawing.Size(110, 46);
            this.btnIzbriši.TabIndex = 5;
            this.btnIzbriši.Text = "Izbriši";
            this.btnIzbriši.UseVisualStyleBackColor = false;
            this.btnIzbriši.Click += new System.EventHandler(this.btnIzbriši_Click);
            // 
            // btnUredi
            // 
            this.btnUredi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnUredi.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnUredi.ForeColor = System.Drawing.Color.White;
            this.btnUredi.Location = new System.Drawing.Point(716, 453);
            this.btnUredi.Name = "btnUredi";
            this.btnUredi.Size = new System.Drawing.Size(117, 46);
            this.btnUredi.TabIndex = 6;
            this.btnUredi.Text = "Uredi";
            this.btnUredi.UseVisualStyleBackColor = false;
            this.btnUredi.Click += new System.EventHandler(this.btnUredi_Click);
            // 
            // lblNaslovSkupine
            // 
            this.lblNaslovSkupine.AutoSize = true;
            this.lblNaslovSkupine.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblNaslovSkupine.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblNaslovSkupine.Location = new System.Drawing.Point(12, 9);
            this.lblNaslovSkupine.Name = "lblNaslovSkupine";
            this.lblNaslovSkupine.Size = new System.Drawing.Size(116, 38);
            this.lblNaslovSkupine.TabIndex = 7;
            this.lblNaslovSkupine.Text = "Skupine";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Tiny_Explorers.Properties.Resources.group_of_people;
            this.pictureBox1.Location = new System.Drawing.Point(122, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(71, 38);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // FrmSkupine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 511);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblNaslovSkupine);
            this.Controls.Add(this.btnUredi);
            this.Controls.Add(this.btnIzbriši);
            this.Controls.Add(this.btnDodajSkupinu);
            this.Controls.Add(this.btnEvidentiraj);
            this.Controls.Add(this.btnGenerirajIzvjestaj);
            this.Controls.Add(this.dgvSkupine);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmSkupine";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmSkupine";
            this.Load += new System.EventHandler(this.FrmSkupine_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSkupine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSkupine;
        private System.Windows.Forms.Button btnGenerirajIzvjestaj;
        private System.Windows.Forms.Button btnEvidentiraj;
        private System.Windows.Forms.Button btnDodajSkupinu;
        private System.Windows.Forms.Button btnIzbriši;
        private System.Windows.Forms.Button btnUredi;
        private System.Windows.Forms.Label lblNaslovSkupine;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}