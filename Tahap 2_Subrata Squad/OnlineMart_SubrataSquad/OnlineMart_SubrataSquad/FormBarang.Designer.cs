﻿
namespace OnlineMart_SubrataSquad
{
    partial class FormBarang
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBoxCabang = new System.Windows.Forms.ComboBox();
            this.textBoxBarang = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonKeluar = new System.Windows.Forms.Button();
            this.dataGridViewBarang = new System.Windows.Forms.DataGridView();
            this.buttonKeranjang = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBarang)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PapayaWhip;
            this.panel1.Controls.Add(this.comboBoxCabang);
            this.panel1.Controls.Add(this.textBoxBarang);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(11, 82);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(636, 110);
            this.panel1.TabIndex = 1;
            // 
            // comboBoxCabang
            // 
            this.comboBoxCabang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCabang.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxCabang.ForeColor = System.Drawing.SystemColors.WindowText;
            this.comboBoxCabang.FormattingEnabled = true;
            this.comboBoxCabang.Items.AddRange(new object[] {
            "Nama Barang",
            "Harga Barang",
            "Kategori Barang"});
            this.comboBoxCabang.Location = new System.Drawing.Point(165, 21);
            this.comboBoxCabang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxCabang.Name = "comboBoxCabang";
            this.comboBoxCabang.Size = new System.Drawing.Size(359, 29);
            this.comboBoxCabang.TabIndex = 1;
            this.comboBoxCabang.SelectedIndexChanged += new System.EventHandler(this.comboBoxBarang_SelectedIndexChanged);
            // 
            // textBoxBarang
            // 
            this.textBoxBarang.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxBarang.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBoxBarang.Location = new System.Drawing.Point(165, 62);
            this.textBoxBarang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxBarang.Name = "textBoxBarang";
            this.textBoxBarang.Size = new System.Drawing.Size(359, 30);
            this.textBoxBarang.TabIndex = 2;
            this.textBoxBarang.Text = "Search Here...";
            this.textBoxBarang.TextChanged += new System.EventHandler(this.textBoxBarang_TextChanged);
            this.textBoxBarang.Enter += new System.EventHandler(this.textBoxBarang_Enter);
            this.textBoxBarang.Leave += new System.EventHandler(this.textBoxBarang_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "Cari Berdasarkan :";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Orange;
            this.label1.Font = new System.Drawing.Font("Tahoma", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(635, 60);
            this.label1.TabIndex = 0;
            this.label1.Text = "HALAMAN BARANG";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonKeluar
            // 
            this.buttonKeluar.BackColor = System.Drawing.Color.Orange;
            this.buttonKeluar.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonKeluar.ForeColor = System.Drawing.Color.White;
            this.buttonKeluar.Location = new System.Drawing.Point(547, 482);
            this.buttonKeluar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonKeluar.Name = "buttonKeluar";
            this.buttonKeluar.Size = new System.Drawing.Size(100, 39);
            this.buttonKeluar.TabIndex = 6;
            this.buttonKeluar.Text = "&KELUAR";
            this.buttonKeluar.UseVisualStyleBackColor = false;
            this.buttonKeluar.Click += new System.EventHandler(this.buttonKeluar_Click);
            // 
            // dataGridViewBarang
            // 
            this.dataGridViewBarang.BackgroundColor = System.Drawing.Color.Tan;
            this.dataGridViewBarang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBarang.Location = new System.Drawing.Point(11, 199);
            this.dataGridViewBarang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewBarang.Name = "dataGridViewBarang";
            this.dataGridViewBarang.RowHeadersWidth = 51;
            this.dataGridViewBarang.RowTemplate.Height = 24;
            this.dataGridViewBarang.Size = new System.Drawing.Size(636, 278);
            this.dataGridViewBarang.TabIndex = 2;
            this.dataGridViewBarang.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewBarang_CellContentClick);
            // 
            // buttonKeranjang
            // 
            this.buttonKeranjang.BackColor = System.Drawing.Color.Orange;
            this.buttonKeranjang.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonKeranjang.ForeColor = System.Drawing.Color.White;
            this.buttonKeranjang.Location = new System.Drawing.Point(393, 482);
            this.buttonKeranjang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonKeranjang.Name = "buttonKeranjang";
            this.buttonKeranjang.Size = new System.Drawing.Size(148, 39);
            this.buttonKeranjang.TabIndex = 5;
            this.buttonKeranjang.Text = "&KERANJANG";
            this.buttonKeranjang.UseVisualStyleBackColor = false;
            this.buttonKeranjang.Click += new System.EventHandler(this.buttonKeranjang_Click);
            // 
            // FormBarang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(659, 537);
            this.ControlBox = false;
            this.Controls.Add(this.buttonKeranjang);
            this.Controls.Add(this.dataGridViewBarang);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonKeluar);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormBarang";
            this.Load += new System.EventHandler(this.FormBarang_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBarang)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBoxBarang;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonKeluar;
        private System.Windows.Forms.DataGridView dataGridViewBarang;
        private System.Windows.Forms.Button buttonKeranjang;
        public System.Windows.Forms.ComboBox comboBoxCabang;
    }
}