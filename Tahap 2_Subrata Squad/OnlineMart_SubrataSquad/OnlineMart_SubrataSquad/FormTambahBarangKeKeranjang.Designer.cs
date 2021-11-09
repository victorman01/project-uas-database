
namespace OnlineMart_SubrataSquad
{
    partial class FormTambahBarangKeKeranjang
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
            this.label1 = new System.Windows.Forms.Label();
            this.buttonKeluar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.numericUpDownJumlahBarang = new System.Windows.Forms.NumericUpDown();
            this.comboBoxCabang = new System.Windows.Forms.ComboBox();
            this.labelKategoriBarang = new System.Windows.Forms.Label();
            this.labelHargaBarang = new System.Windows.Forms.Label();
            this.labelNamaBarang = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonTambah = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.labelIdBarang = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownJumlahBarang)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Orange;
            this.label1.Font = new System.Drawing.Font("Tahoma", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(560, 60);
            this.label1.TabIndex = 28;
            this.label1.Text = "TAMBAH KE KERANJANG";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonKeluar
            // 
            this.buttonKeluar.BackColor = System.Drawing.Color.Orange;
            this.buttonKeluar.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonKeluar.ForeColor = System.Drawing.Color.White;
            this.buttonKeluar.Location = new System.Drawing.Point(452, 315);
            this.buttonKeluar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonKeluar.Name = "buttonKeluar";
            this.buttonKeluar.Size = new System.Drawing.Size(120, 50);
            this.buttonKeluar.TabIndex = 30;
            this.buttonKeluar.Text = "&KELUAR";
            this.buttonKeluar.UseVisualStyleBackColor = false;
            this.buttonKeluar.Click += new System.EventHandler(this.buttonKeluar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(20, 106);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(140, 21);
            this.label6.TabIndex = 5;
            this.label6.Text = "Kategori Barang :";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PapayaWhip;
            this.panel1.Controls.Add(this.labelIdBarang);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.numericUpDownJumlahBarang);
            this.panel1.Controls.Add(this.comboBoxCabang);
            this.panel1.Controls.Add(this.labelKategoriBarang);
            this.panel1.Controls.Add(this.labelHargaBarang);
            this.panel1.Controls.Add(this.labelNamaBarang);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Location = new System.Drawing.Point(12, 92);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(560, 209);
            this.panel1.TabIndex = 29;
            // 
            // numericUpDownJumlahBarang
            // 
            this.numericUpDownJumlahBarang.Location = new System.Drawing.Point(169, 170);
            this.numericUpDownJumlahBarang.Name = "numericUpDownJumlahBarang";
            this.numericUpDownJumlahBarang.Size = new System.Drawing.Size(156, 22);
            this.numericUpDownJumlahBarang.TabIndex = 17;
            // 
            // comboBoxCabang
            // 
            this.comboBoxCabang.FormattingEnabled = true;
            this.comboBoxCabang.Location = new System.Drawing.Point(169, 139);
            this.comboBoxCabang.Name = "comboBoxCabang";
            this.comboBoxCabang.Size = new System.Drawing.Size(156, 24);
            this.comboBoxCabang.TabIndex = 16;
            // 
            // labelKategoriBarang
            // 
            this.labelKategoriBarang.AutoSize = true;
            this.labelKategoriBarang.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelKategoriBarang.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelKategoriBarang.Location = new System.Drawing.Point(166, 109);
            this.labelKategoriBarang.Name = "labelKategoriBarang";
            this.labelKategoriBarang.Size = new System.Drawing.Size(145, 18);
            this.labelKategoriBarang.TabIndex = 15;
            this.labelKategoriBarang.Text = "label Kategori Barang";
            // 
            // labelHargaBarang
            // 
            this.labelHargaBarang.AutoSize = true;
            this.labelHargaBarang.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHargaBarang.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelHargaBarang.Location = new System.Drawing.Point(166, 78);
            this.labelHargaBarang.Name = "labelHargaBarang";
            this.labelHargaBarang.Size = new System.Drawing.Size(131, 18);
            this.labelHargaBarang.TabIndex = 14;
            this.labelHargaBarang.Text = "label Harga Barang";
            // 
            // labelNamaBarang
            // 
            this.labelNamaBarang.AutoSize = true;
            this.labelNamaBarang.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNamaBarang.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelNamaBarang.Location = new System.Drawing.Point(166, 45);
            this.labelNamaBarang.Name = "labelNamaBarang";
            this.labelNamaBarang.Size = new System.Drawing.Size(131, 18);
            this.labelNamaBarang.TabIndex = 13;
            this.labelNamaBarang.Text = "label Nama Barang";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(84, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 21);
            this.label5.TabIndex = 12;
            this.label5.Text = "Jumlah :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(84, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 21);
            this.label4.TabIndex = 11;
            this.label4.Text = "Cabang :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(39, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 21);
            this.label3.TabIndex = 10;
            this.label3.Text = "Harga Barang :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(39, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 21);
            this.label2.TabIndex = 8;
            this.label2.Text = "Nama Barang :";
            // 
            // buttonTambah
            // 
            this.buttonTambah.BackColor = System.Drawing.Color.Orange;
            this.buttonTambah.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTambah.ForeColor = System.Drawing.Color.White;
            this.buttonTambah.Location = new System.Drawing.Point(326, 315);
            this.buttonTambah.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonTambah.Name = "buttonTambah";
            this.buttonTambah.Size = new System.Drawing.Size(120, 50);
            this.buttonTambah.TabIndex = 31;
            this.buttonTambah.Text = "&SIMPAN";
            this.buttonTambah.UseVisualStyleBackColor = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(64, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 21);
            this.label7.TabIndex = 18;
            this.label7.Text = "Id Barang :";
            // 
            // labelIdBarang
            // 
            this.labelIdBarang.AutoSize = true;
            this.labelIdBarang.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIdBarang.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelIdBarang.Location = new System.Drawing.Point(166, 15);
            this.labelIdBarang.Name = "labelIdBarang";
            this.labelIdBarang.Size = new System.Drawing.Size(106, 18);
            this.labelIdBarang.TabIndex = 19;
            this.labelIdBarang.Text = "label Id Barang";
            // 
            // FormTambahBarangKeKeranjang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(588, 375);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonKeluar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonTambah);
            this.Name = "FormTambahBarangKeKeranjang";
            this.Text = "FormTambahBarangKeKeranjang";
            this.Load += new System.EventHandler(this.FormTambahBarangKeKeranjang_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownJumlahBarang)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonKeluar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonTambah;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.NumericUpDown numericUpDownJumlahBarang;
        public System.Windows.Forms.ComboBox comboBoxCabang;
        public System.Windows.Forms.Label labelKategoriBarang;
        public System.Windows.Forms.Label labelHargaBarang;
        public System.Windows.Forms.Label labelNamaBarang;
        public System.Windows.Forms.Label labelIdBarang;
        private System.Windows.Forms.Label label7;
    }
}