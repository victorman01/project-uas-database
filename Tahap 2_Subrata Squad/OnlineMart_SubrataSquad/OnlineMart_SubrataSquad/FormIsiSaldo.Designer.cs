
namespace OnlineMart_SubrataSquad
{
    partial class FormIsiSaldo
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
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxAlatIsiSaldo = new System.Windows.Forms.ComboBox();
            this.buttonIsi = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonKeluar = new System.Windows.Forms.Button();
            this.listBoxSaldo = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxJumlahPengisianSaldo = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(33, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(185, 25);
            this.label2.TabIndex = 33;
            this.label2.Text = "Isi Saldo Dengan :";
            // 
            // comboBoxAlatIsiSaldo
            // 
            this.comboBoxAlatIsiSaldo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAlatIsiSaldo.FormattingEnabled = true;
            this.comboBoxAlatIsiSaldo.Items.AddRange(new object[] {
            "Virtual Akun",
            "OVO",
            "Go-Pay"});
            this.comboBoxAlatIsiSaldo.Location = new System.Drawing.Point(204, 55);
            this.comboBoxAlatIsiSaldo.Name = "comboBoxAlatIsiSaldo";
            this.comboBoxAlatIsiSaldo.Size = new System.Drawing.Size(493, 28);
            this.comboBoxAlatIsiSaldo.TabIndex = 34;
            // 
            // buttonIsi
            // 
            this.buttonIsi.BackColor = System.Drawing.Color.Orange;
            this.buttonIsi.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonIsi.ForeColor = System.Drawing.Color.White;
            this.buttonIsi.Location = new System.Drawing.Point(462, 425);
            this.buttonIsi.Name = "buttonIsi";
            this.buttonIsi.Size = new System.Drawing.Size(129, 49);
            this.buttonIsi.TabIndex = 32;
            this.buttonIsi.Text = "&ISI";
            this.buttonIsi.UseVisualStyleBackColor = false;
            this.buttonIsi.Click += new System.EventHandler(this.buttonIsi_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Orange;
            this.label1.Font = new System.Drawing.Font("Tahoma", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(14, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(714, 75);
            this.label1.TabIndex = 29;
            this.label1.Text = "HALAMAN ISI SALDO";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonKeluar
            // 
            this.buttonKeluar.BackColor = System.Drawing.Color.Orange;
            this.buttonKeluar.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonKeluar.ForeColor = System.Drawing.Color.White;
            this.buttonKeluar.Location = new System.Drawing.Point(598, 425);
            this.buttonKeluar.Name = "buttonKeluar";
            this.buttonKeluar.Size = new System.Drawing.Size(129, 49);
            this.buttonKeluar.TabIndex = 30;
            this.buttonKeluar.Text = "&KELUAR";
            this.buttonKeluar.UseVisualStyleBackColor = false;
            this.buttonKeluar.Click += new System.EventHandler(this.buttonKeluar_Click);
            // 
            // listBoxSaldo
            // 
            this.listBoxSaldo.BackColor = System.Drawing.Color.Tan;
            this.listBoxSaldo.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxSaldo.FormattingEnabled = true;
            this.listBoxSaldo.ItemHeight = 29;
            this.listBoxSaldo.Location = new System.Drawing.Point(12, 89);
            this.listBoxSaldo.Name = "listBoxSaldo";
            this.listBoxSaldo.Size = new System.Drawing.Size(715, 207);
            this.listBoxSaldo.TabIndex = 35;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(32, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(189, 25);
            this.label3.TabIndex = 36;
            this.label3.Text = "Jumlah Pengisian :";
            // 
            // textBoxJumlahPengisianSaldo
            // 
            this.textBoxJumlahPengisianSaldo.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxJumlahPengisianSaldo.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBoxJumlahPengisianSaldo.Location = new System.Drawing.Point(204, 12);
            this.textBoxJumlahPengisianSaldo.Name = "textBoxJumlahPengisianSaldo";
            this.textBoxJumlahPengisianSaldo.Size = new System.Drawing.Size(493, 29);
            this.textBoxJumlahPengisianSaldo.TabIndex = 37;
            this.textBoxJumlahPengisianSaldo.Text = "Type Here...";
            this.textBoxJumlahPengisianSaldo.Enter += new System.EventHandler(this.textBoxJumlahPengisianSaldo_Enter);
            this.textBoxJumlahPengisianSaldo.Leave += new System.EventHandler(this.textBoxJumlahPengisianSaldo_Leave);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PeachPuff;
            this.panel1.Controls.Add(this.comboBoxAlatIsiSaldo);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.textBoxJumlahPengisianSaldo);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(14, 312);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(714, 102);
            this.panel1.TabIndex = 38;
            // 
            // FormIsiSaldo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(738, 489);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.listBoxSaldo);
            this.Controls.Add(this.buttonIsi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonKeluar);
            this.Name = "FormIsiSaldo";
            this.Load += new System.EventHandler(this.FormIsiSaldo_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxAlatIsiSaldo;
        private System.Windows.Forms.Button buttonIsi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonKeluar;
        private System.Windows.Forms.ListBox listBoxSaldo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxJumlahPengisianSaldo;
        private System.Windows.Forms.Panel panel1;
    }
}