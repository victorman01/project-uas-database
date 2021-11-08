
namespace OnlineMart_SubrataSquad
{
    partial class FormPengaturanCabang
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
            this.dataGridViewPengaturanCabang = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBoxCBPengaturanCabang = new System.Windows.Forms.ComboBox();
            this.textBoxCBPengaturanCabang = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonKeluar = new System.Windows.Forms.Button();
            this.buttonTambah = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPengaturanCabang)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewPengaturanCabang
            // 
            this.dataGridViewPengaturanCabang.BackgroundColor = System.Drawing.Color.Tan;
            this.dataGridViewPengaturanCabang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPengaturanCabang.Location = new System.Drawing.Point(11, 188);
            this.dataGridViewPengaturanCabang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewPengaturanCabang.Name = "dataGridViewPengaturanCabang";
            this.dataGridViewPengaturanCabang.RowHeadersWidth = 51;
            this.dataGridViewPengaturanCabang.RowTemplate.Height = 24;
            this.dataGridViewPengaturanCabang.Size = new System.Drawing.Size(560, 294);
            this.dataGridViewPengaturanCabang.TabIndex = 16;
            this.dataGridViewPengaturanCabang.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPengaturanCabang_CellContentClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PapayaWhip;
            this.panel1.Controls.Add(this.comboBoxCBPengaturanCabang);
            this.panel1.Controls.Add(this.textBoxCBPengaturanCabang);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Location = new System.Drawing.Point(11, 84);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(560, 98);
            this.panel1.TabIndex = 14;
            // 
            // comboBoxCBPengaturanCabang
            // 
            this.comboBoxCBPengaturanCabang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCBPengaturanCabang.FormattingEnabled = true;
            this.comboBoxCBPengaturanCabang.Items.AddRange(new object[] {
            "ID Cabang",
            "Nama Cabang",
            "Alamat Cabang",
            "Pegawai"});
            this.comboBoxCBPengaturanCabang.Location = new System.Drawing.Point(205, 18);
            this.comboBoxCBPengaturanCabang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxCBPengaturanCabang.Name = "comboBoxCBPengaturanCabang";
            this.comboBoxCBPengaturanCabang.Size = new System.Drawing.Size(327, 24);
            this.comboBoxCBPengaturanCabang.TabIndex = 7;
            // 
            // textBoxCBPengaturanCabang
            // 
            this.textBoxCBPengaturanCabang.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCBPengaturanCabang.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBoxCBPengaturanCabang.Location = new System.Drawing.Point(205, 49);
            this.textBoxCBPengaturanCabang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxCBPengaturanCabang.Name = "textBoxCBPengaturanCabang";
            this.textBoxCBPengaturanCabang.Size = new System.Drawing.Size(327, 28);
            this.textBoxCBPengaturanCabang.TabIndex = 6;
            this.textBoxCBPengaturanCabang.Text = "Type Here...";
            this.textBoxCBPengaturanCabang.TextChanged += new System.EventHandler(this.textBoxCBPengaturanCabang_TextChanged);
            this.textBoxCBPengaturanCabang.Enter += new System.EventHandler(this.textBoxCBPengaturanCabang_Enter);
            this.textBoxCBPengaturanCabang.Leave += new System.EventHandler(this.textBoxCBPengaturanCabang_Leave);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(41, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(147, 21);
            this.label6.TabIndex = 5;
            this.label6.Text = "Cari Berdasarkan :";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Orange;
            this.label1.Font = new System.Drawing.Font("Tahoma", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(11, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(560, 60);
            this.label1.TabIndex = 13;
            this.label1.Text = "PENGATURAN CABANG";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonKeluar
            // 
            this.buttonKeluar.BackColor = System.Drawing.Color.Orange;
            this.buttonKeluar.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonKeluar.ForeColor = System.Drawing.Color.White;
            this.buttonKeluar.Location = new System.Drawing.Point(451, 487);
            this.buttonKeluar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonKeluar.Name = "buttonKeluar";
            this.buttonKeluar.Size = new System.Drawing.Size(120, 50);
            this.buttonKeluar.TabIndex = 15;
            this.buttonKeluar.Text = "&KELUAR";
            this.buttonKeluar.UseVisualStyleBackColor = false;
            this.buttonKeluar.Click += new System.EventHandler(this.buttonKeluar_Click);
            // 
            // buttonTambah
            // 
            this.buttonTambah.BackColor = System.Drawing.Color.Orange;
            this.buttonTambah.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTambah.ForeColor = System.Drawing.Color.White;
            this.buttonTambah.Location = new System.Drawing.Point(325, 486);
            this.buttonTambah.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonTambah.Name = "buttonTambah";
            this.buttonTambah.Size = new System.Drawing.Size(120, 50);
            this.buttonTambah.TabIndex = 29;
            this.buttonTambah.Text = "&TAMBAH";
            this.buttonTambah.UseVisualStyleBackColor = false;
            this.buttonTambah.Click += new System.EventHandler(this.buttonTambah_Click);
            // 
            // FormPengaturanCabang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 546);
            this.ControlBox = false;
            this.Controls.Add(this.buttonTambah);
            this.Controls.Add(this.dataGridViewPengaturanCabang);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonKeluar);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormPengaturanCabang";
            this.Load += new System.EventHandler(this.FormPengaturanCabang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPengaturanCabang)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewPengaturanCabang;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboBoxCBPengaturanCabang;
        private System.Windows.Forms.TextBox textBoxCBPengaturanCabang;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonKeluar;
        private System.Windows.Forms.Button buttonTambah;
    }
}