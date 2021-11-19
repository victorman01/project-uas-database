
namespace OnlineMart_SubrataSquad
{
    partial class FormRekapPenjualanOMASaldo
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
            this.dataGridViewRekapPenjualanOMA = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radioButtonTahun = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.radioButtonBulan = new System.Windows.Forms.RadioButton();
            this.comboBoxCBRekapPenjualanOMA = new System.Windows.Forms.ComboBox();
            this.textBoxCBRekapPenjualanOMA = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonKeluar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRekapPenjualanOMA)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Orange;
            this.label1.Font = new System.Drawing.Font("Tahoma", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(9, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(420, 80);
            this.label1.TabIndex = 14;
            this.label1.Text = "REKAP PENJUALAN OMA SALDO";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridViewRekapPenjualanOMA
            // 
            this.dataGridViewRekapPenjualanOMA.BackgroundColor = System.Drawing.Color.Tan;
            this.dataGridViewRekapPenjualanOMA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRekapPenjualanOMA.Location = new System.Drawing.Point(9, 220);
            this.dataGridViewRekapPenjualanOMA.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewRekapPenjualanOMA.Name = "dataGridViewRekapPenjualanOMA";
            this.dataGridViewRekapPenjualanOMA.RowHeadersWidth = 51;
            this.dataGridViewRekapPenjualanOMA.RowTemplate.Height = 24;
            this.dataGridViewRekapPenjualanOMA.Size = new System.Drawing.Size(420, 204);
            this.dataGridViewRekapPenjualanOMA.TabIndex = 19;
            this.dataGridViewRekapPenjualanOMA.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewRekapPenjualanOMA_CellContentClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PapayaWhip;
            this.panel1.Controls.Add(this.radioButtonTahun);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.radioButtonBulan);
            this.panel1.Controls.Add(this.comboBoxCBRekapPenjualanOMA);
            this.panel1.Controls.Add(this.textBoxCBRekapPenjualanOMA);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Location = new System.Drawing.Point(9, 101);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(420, 115);
            this.panel1.TabIndex = 17;
            // 
            // radioButtonTahun
            // 
            this.radioButtonTahun.AutoSize = true;
            this.radioButtonTahun.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonTahun.Location = new System.Drawing.Point(232, 74);
            this.radioButtonTahun.Margin = new System.Windows.Forms.Padding(2);
            this.radioButtonTahun.Name = "radioButtonTahun";
            this.radioButtonTahun.Size = new System.Drawing.Size(65, 21);
            this.radioButtonTahun.TabIndex = 15;
            this.radioButtonTahun.TabStop = true;
            this.radioButtonTahun.Text = "Tahun";
            this.radioButtonTahun.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(82, 76);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 14;
            this.label2.Text = "Filter :";
            // 
            // radioButtonBulan
            // 
            this.radioButtonBulan.AutoSize = true;
            this.radioButtonBulan.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonBulan.Location = new System.Drawing.Point(154, 74);
            this.radioButtonBulan.Margin = new System.Windows.Forms.Padding(2);
            this.radioButtonBulan.Name = "radioButtonBulan";
            this.radioButtonBulan.Size = new System.Drawing.Size(59, 21);
            this.radioButtonBulan.TabIndex = 13;
            this.radioButtonBulan.TabStop = true;
            this.radioButtonBulan.Text = "Bulan";
            this.radioButtonBulan.UseVisualStyleBackColor = true;
            // 
            // comboBoxCBRekapPenjualanOMA
            // 
            this.comboBoxCBRekapPenjualanOMA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCBRekapPenjualanOMA.FormattingEnabled = true;
            this.comboBoxCBRekapPenjualanOMA.Items.AddRange(new object[] {
            "Tanggal",
            "Jumlah Isi",
            "Pelanggan"});
            this.comboBoxCBRekapPenjualanOMA.Location = new System.Drawing.Point(154, 14);
            this.comboBoxCBRekapPenjualanOMA.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxCBRekapPenjualanOMA.Name = "comboBoxCBRekapPenjualanOMA";
            this.comboBoxCBRekapPenjualanOMA.Size = new System.Drawing.Size(246, 21);
            this.comboBoxCBRekapPenjualanOMA.TabIndex = 7;
            // 
            // textBoxCBRekapPenjualanOMA
            // 
            this.textBoxCBRekapPenjualanOMA.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCBRekapPenjualanOMA.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBoxCBRekapPenjualanOMA.Location = new System.Drawing.Point(154, 38);
            this.textBoxCBRekapPenjualanOMA.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxCBRekapPenjualanOMA.Name = "textBoxCBRekapPenjualanOMA";
            this.textBoxCBRekapPenjualanOMA.Size = new System.Drawing.Size(246, 24);
            this.textBoxCBRekapPenjualanOMA.TabIndex = 6;
            this.textBoxCBRekapPenjualanOMA.Text = "Type Here...";
            this.textBoxCBRekapPenjualanOMA.TextChanged += new System.EventHandler(this.textBoxCBRekapPenjualanOMA_TextChanged);
            this.textBoxCBRekapPenjualanOMA.Enter += new System.EventHandler(this.textBoxCBRekapPenjualanOMA_Enter);
            this.textBoxCBRekapPenjualanOMA.Leave += new System.EventHandler(this.textBoxCBRekapPenjualanOMA_Leave);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(16, 14);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Cari Berdasarkan :";
            // 
            // buttonKeluar
            // 
            this.buttonKeluar.BackColor = System.Drawing.Color.Orange;
            this.buttonKeluar.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonKeluar.ForeColor = System.Drawing.Color.White;
            this.buttonKeluar.Location = new System.Drawing.Point(339, 429);
            this.buttonKeluar.Margin = new System.Windows.Forms.Padding(2);
            this.buttonKeluar.Name = "buttonKeluar";
            this.buttonKeluar.Size = new System.Drawing.Size(90, 41);
            this.buttonKeluar.TabIndex = 18;
            this.buttonKeluar.Text = "&KELUAR";
            this.buttonKeluar.UseVisualStyleBackColor = false;
            this.buttonKeluar.Click += new System.EventHandler(this.buttonKeluar_Click);
            // 
            // FormRekapPenjualanOMASaldo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 473);
            this.ControlBox = false;
            this.Controls.Add(this.dataGridViewRekapPenjualanOMA);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonKeluar);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormRekapPenjualanOMASaldo";
            this.Load += new System.EventHandler(this.FormRekapPenjualanOMASaldo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRekapPenjualanOMA)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewRekapPenjualanOMA;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton radioButtonTahun;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton radioButtonBulan;
        private System.Windows.Forms.ComboBox comboBoxCBRekapPenjualanOMA;
        private System.Windows.Forms.TextBox textBoxCBRekapPenjualanOMA;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonKeluar;
    }
}