
namespace OnlineMart_SubrataSquad
{
    partial class FormUbahJumlahBarang
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
            this.textBoxBarang = new System.Windows.Forms.TextBox();
            this.textBoxCabang = new System.Windows.Forms.TextBox();
            this.textBoxJumlah = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonSimpan = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Orange;
            this.label1.Font = new System.Drawing.Font("Tahoma", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(560, 60);
            this.label1.TabIndex = 32;
            this.label1.Text = "UBAH STOK";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonKeluar
            // 
            this.buttonKeluar.BackColor = System.Drawing.Color.Orange;
            this.buttonKeluar.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonKeluar.ForeColor = System.Drawing.Color.White;
            this.buttonKeluar.Location = new System.Drawing.Point(452, 219);
            this.buttonKeluar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonKeluar.Name = "buttonKeluar";
            this.buttonKeluar.Size = new System.Drawing.Size(120, 50);
            this.buttonKeluar.TabIndex = 34;
            this.buttonKeluar.Text = "&KELUAR";
            this.buttonKeluar.UseVisualStyleBackColor = false;
            this.buttonKeluar.Click += new System.EventHandler(this.buttonKeluar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(59, 17);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 21);
            this.label6.TabIndex = 5;
            this.label6.Text = "Barang :";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PapayaWhip;
            this.panel1.Controls.Add(this.textBoxBarang);
            this.panel1.Controls.Add(this.textBoxCabang);
            this.panel1.Controls.Add(this.textBoxJumlah);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Location = new System.Drawing.Point(12, 79);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(560, 129);
            this.panel1.TabIndex = 33;
            // 
            // textBoxBarang
            // 
            this.textBoxBarang.Enabled = false;
            this.textBoxBarang.Location = new System.Drawing.Point(144, 17);
            this.textBoxBarang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxBarang.Name = "textBoxBarang";
            this.textBoxBarang.Size = new System.Drawing.Size(391, 22);
            this.textBoxBarang.TabIndex = 17;
            // 
            // textBoxCabang
            // 
            this.textBoxCabang.Enabled = false;
            this.textBoxCabang.Location = new System.Drawing.Point(144, 53);
            this.textBoxCabang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxCabang.Name = "textBoxCabang";
            this.textBoxCabang.Size = new System.Drawing.Size(391, 22);
            this.textBoxCabang.TabIndex = 16;
            // 
            // textBoxJumlah
            // 
            this.textBoxJumlah.Location = new System.Drawing.Point(144, 87);
            this.textBoxJumlah.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxJumlah.Name = "textBoxJumlah";
            this.textBoxJumlah.Size = new System.Drawing.Size(392, 22);
            this.textBoxJumlah.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(56, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 21);
            this.label2.TabIndex = 13;
            this.label2.Text = "Cabang :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(59, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 21);
            this.label4.TabIndex = 11;
            this.label4.Text = "Jumlah :";
            // 
            // buttonSimpan
            // 
            this.buttonSimpan.BackColor = System.Drawing.Color.Orange;
            this.buttonSimpan.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSimpan.ForeColor = System.Drawing.Color.White;
            this.buttonSimpan.Location = new System.Drawing.Point(326, 219);
            this.buttonSimpan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonSimpan.Name = "buttonSimpan";
            this.buttonSimpan.Size = new System.Drawing.Size(120, 50);
            this.buttonSimpan.TabIndex = 35;
            this.buttonSimpan.Text = "&SIMPAN";
            this.buttonSimpan.UseVisualStyleBackColor = false;
            this.buttonSimpan.Click += new System.EventHandler(this.buttonSimpan_Click);
            // 
            // FormUbahJumlahBarang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(589, 283);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonKeluar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonSimpan);
            this.Name = "FormUbahJumlahBarang";
            this.Text = "FormUbahJumlahBarang";
            this.Load += new System.EventHandler(this.FormUbahJumlahBarang_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonKeluar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.TextBox textBoxBarang;
        public System.Windows.Forms.TextBox textBoxCabang;
        public System.Windows.Forms.TextBox textBoxJumlah;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonSimpan;
    }
}