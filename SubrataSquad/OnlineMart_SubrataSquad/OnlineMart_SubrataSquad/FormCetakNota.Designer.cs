﻿
namespace OnlineMart_SubrataSquad
{
    partial class FormCetakNota
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
            this.buttonKeluar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewCetakNota = new System.Windows.Forms.DataGridView();
            this.buttonCetak = new System.Windows.Forms.Button();
            this.comboBoxCetak = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCetakNota)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonKeluar
            // 
            this.buttonKeluar.BackColor = System.Drawing.Color.Orange;
            this.buttonKeluar.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonKeluar.ForeColor = System.Drawing.Color.White;
            this.buttonKeluar.Location = new System.Drawing.Point(600, 588);
            this.buttonKeluar.Name = "buttonKeluar";
            this.buttonKeluar.Size = new System.Drawing.Size(129, 49);
            this.buttonKeluar.TabIndex = 24;
            this.buttonKeluar.Text = "&KELUAR";
            this.buttonKeluar.UseVisualStyleBackColor = false;
            this.buttonKeluar.Click += new System.EventHandler(this.buttonKeluar_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Orange;
            this.label1.Font = new System.Drawing.Font("Tahoma", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(14, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(714, 75);
            this.label1.TabIndex = 23;
            this.label1.Text = "HALAMAN CETAK NOTA";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridViewCetakNota
            // 
            this.dataGridViewCetakNota.BackgroundColor = System.Drawing.Color.Tan;
            this.dataGridViewCetakNota.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCetakNota.Location = new System.Drawing.Point(12, 103);
            this.dataGridViewCetakNota.Name = "dataGridViewCetakNota";
            this.dataGridViewCetakNota.RowHeadersWidth = 51;
            this.dataGridViewCetakNota.RowTemplate.Height = 24;
            this.dataGridViewCetakNota.Size = new System.Drawing.Size(716, 443);
            this.dataGridViewCetakNota.TabIndex = 25;
            this.dataGridViewCetakNota.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCetakNota_CellContentClick);
            // 
            // buttonCetak
            // 
            this.buttonCetak.BackColor = System.Drawing.Color.Orange;
            this.buttonCetak.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCetak.ForeColor = System.Drawing.Color.White;
            this.buttonCetak.Location = new System.Drawing.Point(464, 588);
            this.buttonCetak.Name = "buttonCetak";
            this.buttonCetak.Size = new System.Drawing.Size(129, 49);
            this.buttonCetak.TabIndex = 26;
            this.buttonCetak.Text = "&CETAK";
            this.buttonCetak.UseVisualStyleBackColor = false;
            this.buttonCetak.Click += new System.EventHandler(this.buttonCetak_Click);
            // 
            // comboBoxCetak
            // 
            this.comboBoxCetak.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCetak.FormattingEnabled = true;
            this.comboBoxCetak.Items.AddRange(new object[] {
            "PDF",
            "PRINT HARDCOPY"});
            this.comboBoxCetak.Location = new System.Drawing.Point(177, 551);
            this.comboBoxCetak.Name = "comboBoxCetak";
            this.comboBoxCetak.Size = new System.Drawing.Size(548, 28);
            this.comboBoxCetak.TabIndex = 28;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 551);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 34);
            this.label2.TabIndex = 27;
            this.label2.Text = "Cetak Dalam Bentuk :";
            // 
            // FormCetakNota
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(738, 643);
            this.ControlBox = false;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxCetak);
            this.Controls.Add(this.buttonCetak);
            this.Controls.Add(this.dataGridViewCetakNota);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonKeluar);
            this.Name = "FormCetakNota";
            this.Load += new System.EventHandler(this.FormCetakNota_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCetakNota)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonKeluar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewCetakNota;
        private System.Windows.Forms.Button buttonCetak;
        private System.Windows.Forms.ComboBox comboBoxCetak;
        private System.Windows.Forms.Label label2;
    }
}