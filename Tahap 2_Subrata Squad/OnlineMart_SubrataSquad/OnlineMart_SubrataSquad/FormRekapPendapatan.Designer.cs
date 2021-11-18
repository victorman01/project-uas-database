
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
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.comboBoxCBListPendapatan = new System.Windows.Forms.ComboBox();
            this.textBoxCBListPendapatan = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonKeluar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRekapPendapatan)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewRekapPendapatan
            // 
            this.dataGridViewRekapPendapatan.BackgroundColor = System.Drawing.Color.Tan;
            this.dataGridViewRekapPendapatan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRekapPendapatan.Location = new System.Drawing.Point(11, 233);
            this.dataGridViewRekapPendapatan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewRekapPendapatan.Name = "dataGridViewRekapPendapatan";
            this.dataGridViewRekapPendapatan.RowHeadersWidth = 51;
            this.dataGridViewRekapPendapatan.RowTemplate.Height = 24;
            this.dataGridViewRekapPendapatan.Size = new System.Drawing.Size(560, 251);
            this.dataGridViewRekapPendapatan.TabIndex = 12;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PapayaWhip;
            this.panel1.Controls.Add(this.radioButton2);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.radioButton1);
            this.panel1.Controls.Add(this.comboBoxCBListPendapatan);
            this.panel1.Controls.Add(this.textBoxCBListPendapatan);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Location = new System.Drawing.Point(11, 86);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(560, 142);
            this.panel1.TabIndex = 10;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton2.Location = new System.Drawing.Point(309, 91);
            this.radioButton2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(77, 25);
            this.radioButton2.TabIndex = 15;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Tahun";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(109, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 21);
            this.label2.TabIndex = 14;
            this.label2.Text = "Filter :";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.Location = new System.Drawing.Point(205, 91);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(72, 25);
            this.radioButton1.TabIndex = 13;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Bulan";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // comboBoxCBListPendapatan
            // 
            this.comboBoxCBListPendapatan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCBListPendapatan.FormattingEnabled = true;
            this.comboBoxCBListPendapatan.Items.AddRange(new object[] {
            "ID Order",
            "Tanggal Order"});
            this.comboBoxCBListPendapatan.Location = new System.Drawing.Point(205, 17);
            this.comboBoxCBListPendapatan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxCBListPendapatan.Name = "comboBoxCBListPendapatan";
            this.comboBoxCBListPendapatan.Size = new System.Drawing.Size(327, 24);
            this.comboBoxCBListPendapatan.TabIndex = 7;
            // 
            // textBoxCBListPendapatan
            // 
            this.textBoxCBListPendapatan.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCBListPendapatan.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBoxCBListPendapatan.Location = new System.Drawing.Point(205, 47);
            this.textBoxCBListPendapatan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxCBListPendapatan.Name = "textBoxCBListPendapatan";
            this.textBoxCBListPendapatan.Size = new System.Drawing.Size(327, 28);
            this.textBoxCBListPendapatan.TabIndex = 6;
            this.textBoxCBListPendapatan.Text = "Type Here...";
            this.textBoxCBListPendapatan.TextChanged += new System.EventHandler(this.textBoxCBListPendapatan_TextChanged);
            this.textBoxCBListPendapatan.Enter += new System.EventHandler(this.textBoxCBListPendapatan_Enter);
            this.textBoxCBListPendapatan.Leave += new System.EventHandler(this.textBoxCBListPendapatan_Leave);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(21, 17);
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
            // FormRekapPendapatan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 548);
            this.ControlBox = false;
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewRekapPendapatan;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonKeluar;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.ComboBox comboBoxCBListPendapatan;
        private System.Windows.Forms.TextBox textBoxCBListPendapatan;
        private System.Windows.Forms.Label label6;
    }
}