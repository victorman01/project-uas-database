
namespace OnlineMart_SubrataSquad
{
    partial class FormRekapPendapatan
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
            this.dataGridViewRekapPendapatan = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.numericUpDownTahun = new System.Windows.Forms.NumericUpDown();
            this.comboBoxBulan = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonKeluar = new System.Windows.Forms.Button();
            this.labelTotalKomisi = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRekapPendapatan)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTahun)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewRekapPendapatan
            // 
            this.dataGridViewRekapPendapatan.BackgroundColor = System.Drawing.Color.Tan;
            this.dataGridViewRekapPendapatan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRekapPendapatan.Location = new System.Drawing.Point(11, 164);
            this.dataGridViewRekapPendapatan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewRekapPendapatan.Name = "dataGridViewRekapPendapatan";
            this.dataGridViewRekapPendapatan.RowHeadersWidth = 51;
            this.dataGridViewRekapPendapatan.RowTemplate.Height = 24;
            this.dataGridViewRekapPendapatan.Size = new System.Drawing.Size(560, 320);
            this.dataGridViewRekapPendapatan.TabIndex = 12;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PapayaWhip;
            this.panel1.Controls.Add(this.numericUpDownTahun);
            this.panel1.Controls.Add(this.comboBoxBulan);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(11, 86);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(560, 73);
            this.panel1.TabIndex = 10;
            // 
            // numericUpDownTahun
            // 
            this.numericUpDownTahun.Location = new System.Drawing.Point(152, 14);
            this.numericUpDownTahun.Margin = new System.Windows.Forms.Padding(4);
            this.numericUpDownTahun.Maximum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.numericUpDownTahun.Minimum = new decimal(new int[] {
            1999,
            0,
            0,
            0});
            this.numericUpDownTahun.Name = "numericUpDownTahun";
            this.numericUpDownTahun.Size = new System.Drawing.Size(325, 22);
            this.numericUpDownTahun.TabIndex = 14;
            this.numericUpDownTahun.Value = new decimal(new int[] {
            2021,
            0,
            0,
            0});
            this.numericUpDownTahun.ValueChanged += new System.EventHandler(this.numericUpDownTahun_ValueChanged);
            // 
            // comboBoxBulan
            // 
            this.comboBoxBulan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxBulan.FormattingEnabled = true;
            this.comboBoxBulan.Items.AddRange(new object[] {
            "Semua Bulan",
            "Januari",
            "Februari",
            "Maret",
            "April",
            "Mei",
            "Juni",
            "Juli",
            "Agustus",
            "September",
            "Oktober",
            "November",
            "Desember"});
            this.comboBoxBulan.Location = new System.Drawing.Point(152, 44);
            this.comboBoxBulan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxBulan.Name = "comboBoxBulan";
            this.comboBoxBulan.Size = new System.Drawing.Size(324, 24);
            this.comboBoxBulan.TabIndex = 12;
            this.comboBoxBulan.SelectedIndexChanged += new System.EventHandler(this.comboBoxBulan_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(77, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 21);
            this.label3.TabIndex = 9;
            this.label3.Text = "Bulan :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(69, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 21);
            this.label2.TabIndex = 10;
            this.label2.Text = "Tahun :";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Orange;
            this.label1.Font = new System.Drawing.Font("Tahoma", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(11, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(560, 60);
            this.label1.TabIndex = 9;
            this.label1.Text = "REKAP PENDAPATAN";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonKeluar
            // 
            this.buttonKeluar.BackColor = System.Drawing.Color.Orange;
            this.buttonKeluar.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonKeluar.ForeColor = System.Drawing.Color.White;
            this.buttonKeluar.Location = new System.Drawing.Point(451, 490);
            this.buttonKeluar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonKeluar.Name = "buttonKeluar";
            this.buttonKeluar.Size = new System.Drawing.Size(120, 50);
            this.buttonKeluar.TabIndex = 11;
            this.buttonKeluar.Text = "&KELUAR";
            this.buttonKeluar.UseVisualStyleBackColor = false;
            this.buttonKeluar.Click += new System.EventHandler(this.buttonKeluar_Click);
            // 
            // labelTotalKomisi
            // 
            this.labelTotalKomisi.AutoSize = true;
            this.labelTotalKomisi.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalKomisi.Location = new System.Drawing.Point(12, 500);
            this.labelTotalKomisi.Name = "labelTotalKomisi";
            this.labelTotalKomisi.Size = new System.Drawing.Size(55, 18);
            this.labelTotalKomisi.TabIndex = 13;
            this.labelTotalKomisi.Text = "label4";
            // 
            // FormRekapPendapatan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 548);
            this.ControlBox = false;
            this.Controls.Add(this.labelTotalKomisi);
            this.Controls.Add(this.dataGridViewRekapPendapatan);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonKeluar);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormRekapPendapatan";
            this.Load += new System.EventHandler(this.FormRekapPendapatan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRekapPendapatan)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTahun)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewRekapPendapatan;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonKeluar;
        private System.Windows.Forms.NumericUpDown numericUpDownTahun;
        private System.Windows.Forms.ComboBox comboBoxBulan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelTotalKomisi;
    }
}