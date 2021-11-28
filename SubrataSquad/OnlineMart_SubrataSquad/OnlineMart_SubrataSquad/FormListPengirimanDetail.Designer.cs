
namespace OnlineMart_SubrataSquad
{
    partial class FormListPengirimanDetail
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBoxKomisi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxAlamatTujuan = new System.Windows.Forms.TextBox();
            this.textBoxNamaKonsumen = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxIDOrder = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonTolak = new System.Windows.Forms.Button();
            this.buttonTerima = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Orange;
            this.label1.Font = new System.Drawing.Font("Tahoma", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(11, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(560, 60);
            this.label1.TabIndex = 1;
            this.label1.Text = "DETAIL PENGIRIMAN";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PapayaWhip;
            this.panel1.Controls.Add(this.textBoxKomisi);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.textBoxAlamatTujuan);
            this.panel1.Controls.Add(this.textBoxNamaKonsumen);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.textBoxIDOrder);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(11, 86);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(560, 212);
            this.panel1.TabIndex = 2;
            // 
            // textBoxKomisi
            // 
            this.textBoxKomisi.Enabled = false;
            this.textBoxKomisi.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxKomisi.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBoxKomisi.Location = new System.Drawing.Point(199, 159);
            this.textBoxKomisi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxKomisi.Name = "textBoxKomisi";
            this.textBoxKomisi.Size = new System.Drawing.Size(327, 28);
            this.textBoxKomisi.TabIndex = 9;
            this.textBoxKomisi.Text = "Type Here...";
            this.textBoxKomisi.Enter += new System.EventHandler(this.textBoxKomisi_Enter);
            this.textBoxKomisi.Leave += new System.EventHandler(this.textBoxKomisi_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(24, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 21);
            this.label4.TabIndex = 8;
            this.label4.Text = "Nama Konsumen :";
            // 
            // textBoxAlamatTujuan
            // 
            this.textBoxAlamatTujuan.Enabled = false;
            this.textBoxAlamatTujuan.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAlamatTujuan.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBoxAlamatTujuan.Location = new System.Drawing.Point(199, 90);
            this.textBoxAlamatTujuan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxAlamatTujuan.Multiline = true;
            this.textBoxAlamatTujuan.Name = "textBoxAlamatTujuan";
            this.textBoxAlamatTujuan.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxAlamatTujuan.Size = new System.Drawing.Size(327, 62);
            this.textBoxAlamatTujuan.TabIndex = 7;
            this.textBoxAlamatTujuan.Text = "Type Here...";
            this.textBoxAlamatTujuan.Enter += new System.EventHandler(this.textBoxAlamatTujuan_Enter);
            this.textBoxAlamatTujuan.Leave += new System.EventHandler(this.textBoxAlamatTujuan_Leave);
            // 
            // textBoxNamaKonsumen
            // 
            this.textBoxNamaKonsumen.Enabled = false;
            this.textBoxNamaKonsumen.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNamaKonsumen.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBoxNamaKonsumen.Location = new System.Drawing.Point(199, 57);
            this.textBoxNamaKonsumen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxNamaKonsumen.Name = "textBoxNamaKonsumen";
            this.textBoxNamaKonsumen.Size = new System.Drawing.Size(327, 28);
            this.textBoxNamaKonsumen.TabIndex = 6;
            this.textBoxNamaKonsumen.Text = "Type Here...";
            this.textBoxNamaKonsumen.Enter += new System.EventHandler(this.textBoxNamaKonsumen_Enter);
            this.textBoxNamaKonsumen.Leave += new System.EventHandler(this.textBoxNamaKonsumen_Leave);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(84, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 21);
            this.label6.TabIndex = 5;
            this.label6.Text = "ID Order :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(69, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Komisi :";
            // 
            // textBoxIDOrder
            // 
            this.textBoxIDOrder.Enabled = false;
            this.textBoxIDOrder.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxIDOrder.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBoxIDOrder.Location = new System.Drawing.Point(199, 18);
            this.textBoxIDOrder.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxIDOrder.Name = "textBoxIDOrder";
            this.textBoxIDOrder.Size = new System.Drawing.Size(327, 28);
            this.textBoxIDOrder.TabIndex = 1;
            this.textBoxIDOrder.Text = "Type Here...";
            this.textBoxIDOrder.Enter += new System.EventHandler(this.textBoxIDOrder_Enter);
            this.textBoxIDOrder.Leave += new System.EventHandler(this.textBoxIDOrder_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(40, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "Alamat Tujuan :";
            // 
            // buttonTolak
            // 
            this.buttonTolak.BackColor = System.Drawing.Color.Orange;
            this.buttonTolak.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTolak.ForeColor = System.Drawing.Color.White;
            this.buttonTolak.Location = new System.Drawing.Point(451, 308);
            this.buttonTolak.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonTolak.Name = "buttonTolak";
            this.buttonTolak.Size = new System.Drawing.Size(120, 50);
            this.buttonTolak.TabIndex = 4;
            this.buttonTolak.Text = "&TOLAK";
            this.buttonTolak.UseVisualStyleBackColor = false;
            this.buttonTolak.Click += new System.EventHandler(this.buttonTolak_Click);
            // 
            // buttonTerima
            // 
            this.buttonTerima.BackColor = System.Drawing.Color.Orange;
            this.buttonTerima.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTerima.ForeColor = System.Drawing.Color.White;
            this.buttonTerima.Location = new System.Drawing.Point(324, 308);
            this.buttonTerima.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonTerima.Name = "buttonTerima";
            this.buttonTerima.Size = new System.Drawing.Size(120, 50);
            this.buttonTerima.TabIndex = 8;
            this.buttonTerima.Text = "&TERIMA";
            this.buttonTerima.UseVisualStyleBackColor = false;
            this.buttonTerima.Click += new System.EventHandler(this.buttonTerima_Click);
            // 
            // FormListPengirimanDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 370);
            this.ControlBox = false;
            this.Controls.Add(this.buttonTerima);
            this.Controls.Add(this.buttonTolak);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormListPengirimanDetail";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonTolak;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonTerima;
        public System.Windows.Forms.TextBox textBoxAlamatTujuan;
        public System.Windows.Forms.TextBox textBoxNamaKonsumen;
        public System.Windows.Forms.TextBox textBoxIDOrder;
        public System.Windows.Forms.TextBox textBoxKomisi;
    }
}