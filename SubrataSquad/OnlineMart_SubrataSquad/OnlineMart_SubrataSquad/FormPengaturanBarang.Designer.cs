
namespace OnlineMart_SubrataSquad
{
    partial class FormPengaturanBarang
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
            this.dataGridViewPengaturanBarang = new System.Windows.Forms.DataGridView();
            this.buttonTambah = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonKeluar = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBoxCBPengaturanBarang = new System.Windows.Forms.TextBox();
            this.comboBoxCBPengaturanBarang = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonTambahBarangCabang = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPengaturanBarang)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewPengaturanBarang
            // 
            this.dataGridViewPengaturanBarang.BackgroundColor = System.Drawing.Color.Tan;
            this.dataGridViewPengaturanBarang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPengaturanBarang.Location = new System.Drawing.Point(15, 192);
            this.dataGridViewPengaturanBarang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewPengaturanBarang.Name = "dataGridViewPengaturanBarang";
            this.dataGridViewPengaturanBarang.RowHeadersWidth = 51;
            this.dataGridViewPengaturanBarang.RowTemplate.Height = 24;
            this.dataGridViewPengaturanBarang.Size = new System.Drawing.Size(560, 294);
            this.dataGridViewPengaturanBarang.TabIndex = 33;
            this.dataGridViewPengaturanBarang.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPengaturanBarang_CellContentClick);
            // 
            // buttonTambah
            // 
            this.buttonTambah.BackColor = System.Drawing.Color.Orange;
            this.buttonTambah.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTambah.ForeColor = System.Drawing.Color.White;
            this.buttonTambah.Location = new System.Drawing.Point(282, 490);
            this.buttonTambah.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonTambah.Name = "buttonTambah";
            this.buttonTambah.Size = new System.Drawing.Size(167, 50);
            this.buttonTambah.TabIndex = 34;
            this.buttonTambah.Text = "&SET BARANG";
            this.buttonTambah.UseVisualStyleBackColor = false;
            this.buttonTambah.Click += new System.EventHandler(this.buttonTambah_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Orange;
            this.label1.Font = new System.Drawing.Font("Tahoma", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(15, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(560, 60);
            this.label1.TabIndex = 30;
            this.label1.Text = "PENGATURAN BARANG";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonKeluar
            // 
            this.buttonKeluar.BackColor = System.Drawing.Color.Orange;
            this.buttonKeluar.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonKeluar.ForeColor = System.Drawing.Color.White;
            this.buttonKeluar.Location = new System.Drawing.Point(455, 491);
            this.buttonKeluar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonKeluar.Name = "buttonKeluar";
            this.buttonKeluar.Size = new System.Drawing.Size(120, 50);
            this.buttonKeluar.TabIndex = 32;
            this.buttonKeluar.Text = "&KELUAR";
            this.buttonKeluar.UseVisualStyleBackColor = false;
            this.buttonKeluar.Click += new System.EventHandler(this.buttonKeluar_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.PapayaWhip;
            this.panel2.Controls.Add(this.textBoxCBPengaturanBarang);
            this.panel2.Controls.Add(this.comboBoxCBPengaturanBarang);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Location = new System.Drawing.Point(15, 89);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(560, 98);
            this.panel2.TabIndex = 32;
            // 
            // textBoxCBPengaturanBarang
            // 
            this.textBoxCBPengaturanBarang.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCBPengaturanBarang.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBoxCBPengaturanBarang.Location = new System.Drawing.Point(205, 46);
            this.textBoxCBPengaturanBarang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxCBPengaturanBarang.Name = "textBoxCBPengaturanBarang";
            this.textBoxCBPengaturanBarang.Size = new System.Drawing.Size(308, 28);
            this.textBoxCBPengaturanBarang.TabIndex = 35;
            this.textBoxCBPengaturanBarang.Text = "Type Here...";
            this.textBoxCBPengaturanBarang.TextChanged += new System.EventHandler(this.textBoxCBPengaturanBarang_TextChanged);
            this.textBoxCBPengaturanBarang.Enter += new System.EventHandler(this.textBoxCBPengaturanBarang_Enter);
            this.textBoxCBPengaturanBarang.Leave += new System.EventHandler(this.textBoxCBPengaturanBarang_Leave);
            // 
            // comboBoxCBPengaturanBarang
            // 
            this.comboBoxCBPengaturanBarang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCBPengaturanBarang.FormattingEnabled = true;
            this.comboBoxCBPengaturanBarang.Items.AddRange(new object[] {
            "Nama Cabang",
            "Nama Barang"});
            this.comboBoxCBPengaturanBarang.Location = new System.Drawing.Point(205, 15);
            this.comboBoxCBPengaturanBarang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxCBPengaturanBarang.Name = "comboBoxCBPengaturanBarang";
            this.comboBoxCBPengaturanBarang.Size = new System.Drawing.Size(308, 24);
            this.comboBoxCBPengaturanBarang.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(41, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(147, 21);
            this.label6.TabIndex = 5;
            this.label6.Text = "Cari Berdasarkan :";
            // 
            // buttonTambahBarangCabang
            // 
            this.buttonTambahBarangCabang.BackColor = System.Drawing.Color.Orange;
            this.buttonTambahBarangCabang.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTambahBarangCabang.ForeColor = System.Drawing.Color.White;
            this.buttonTambahBarangCabang.Location = new System.Drawing.Point(15, 490);
            this.buttonTambahBarangCabang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonTambahBarangCabang.Name = "buttonTambahBarangCabang";
            this.buttonTambahBarangCabang.Size = new System.Drawing.Size(261, 53);
            this.buttonTambahBarangCabang.TabIndex = 35;
            this.buttonTambahBarangCabang.Text = "&SET CABANG BRG";
            this.buttonTambahBarangCabang.UseVisualStyleBackColor = false;
            this.buttonTambahBarangCabang.Click += new System.EventHandler(this.buttonTambahBarangCabang_Click);
            // 
            // FormPengaturanBarang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 554);
            this.ControlBox = false;
            this.Controls.Add(this.buttonTambahBarangCabang);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dataGridViewPengaturanBarang);
            this.Controls.Add(this.buttonTambah);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonKeluar);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormPengaturanBarang";
            this.Load += new System.EventHandler(this.FormPengaturanBarang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPengaturanBarang)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewPengaturanBarang;
        private System.Windows.Forms.Button buttonTambah;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonKeluar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox comboBoxCBPengaturanBarang;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxCBPengaturanBarang;
        private System.Windows.Forms.Button buttonTambahBarangCabang;
    }
}