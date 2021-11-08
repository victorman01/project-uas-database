
namespace OnlineMart_SubrataSquad
{
    partial class FormCheckout
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
            this.buttonBayar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonBatal = new System.Windows.Forms.Button();
            this.dataGridViewDeals = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxPromo = new System.Windows.Forms.ComboBox();
            this.comboBoxPembayaran = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxPengantaran = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.labelTotalHarga = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDeals)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonBayar
            // 
            this.buttonBayar.BackColor = System.Drawing.Color.Orange;
            this.buttonBayar.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBayar.ForeColor = System.Drawing.Color.White;
            this.buttonBayar.Location = new System.Drawing.Point(327, 534);
            this.buttonBayar.Margin = new System.Windows.Forms.Padding(2);
            this.buttonBayar.Name = "buttonBayar";
            this.buttonBayar.Size = new System.Drawing.Size(91, 32);
            this.buttonBayar.TabIndex = 23;
            this.buttonBayar.Text = "&BAYAR";
            this.buttonBayar.UseVisualStyleBackColor = false;
            this.buttonBayar.Click += new System.EventHandler(this.buttonBayar_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Orange;
            this.label1.Font = new System.Drawing.Font("Tahoma", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(9, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(500, 49);
            this.label1.TabIndex = 19;
            this.label1.Text = "HALAMAN CHECKOUT";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonBatal
            // 
            this.buttonBatal.BackColor = System.Drawing.Color.Orange;
            this.buttonBatal.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBatal.ForeColor = System.Drawing.Color.White;
            this.buttonBatal.Location = new System.Drawing.Point(422, 534);
            this.buttonBatal.Margin = new System.Windows.Forms.Padding(2);
            this.buttonBatal.Name = "buttonBatal";
            this.buttonBatal.Size = new System.Drawing.Size(86, 32);
            this.buttonBatal.TabIndex = 21;
            this.buttonBatal.Text = "&BATAL";
            this.buttonBatal.UseVisualStyleBackColor = false;
            this.buttonBatal.Click += new System.EventHandler(this.buttonBatal_Click);
            // 
            // dataGridViewDeals
            // 
            this.dataGridViewDeals.BackgroundColor = System.Drawing.Color.Tan;
            this.dataGridViewDeals.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDeals.Location = new System.Drawing.Point(2, 2);
            this.dataGridViewDeals.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewDeals.Name = "dataGridViewDeals";
            this.dataGridViewDeals.RowHeadersWidth = 51;
            this.dataGridViewDeals.RowTemplate.Height = 24;
            this.dataGridViewDeals.Size = new System.Drawing.Size(476, 453);
            this.dataGridViewDeals.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(2, 457);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 22);
            this.label2.TabIndex = 24;
            this.label2.Text = "Kode Promo :";
            // 
            // comboBoxPromo
            // 
            this.comboBoxPromo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPromo.FormattingEnabled = true;
            this.comboBoxPromo.Location = new System.Drawing.Point(136, 459);
            this.comboBoxPromo.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxPromo.Name = "comboBoxPromo";
            this.comboBoxPromo.Size = new System.Drawing.Size(344, 21);
            this.comboBoxPromo.TabIndex = 26;
            // 
            // comboBoxPembayaran
            // 
            this.comboBoxPembayaran.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPembayaran.FormattingEnabled = true;
            this.comboBoxPembayaran.Location = new System.Drawing.Point(136, 484);
            this.comboBoxPembayaran.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxPembayaran.Name = "comboBoxPembayaran";
            this.comboBoxPembayaran.Size = new System.Drawing.Size(344, 21);
            this.comboBoxPembayaran.TabIndex = 28;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(2, 482);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 24);
            this.label4.TabIndex = 27;
            this.label4.Text = "Metode Pembayaran :";
            // 
            // comboBoxPengantaran
            // 
            this.comboBoxPengantaran.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPengantaran.FormattingEnabled = true;
            this.comboBoxPengantaran.Location = new System.Drawing.Point(136, 509);
            this.comboBoxPengantaran.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxPengantaran.Name = "comboBoxPengantaran";
            this.comboBoxPengantaran.Size = new System.Drawing.Size(344, 21);
            this.comboBoxPengantaran.TabIndex = 30;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(2, 507);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 24);
            this.label3.TabIndex = 29;
            this.label3.Text = "Kurir Pengantaran :";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Controls.Add(this.dataGridViewDeals);
            this.flowLayoutPanel1.Controls.Add(this.label2);
            this.flowLayoutPanel1.Controls.Add(this.comboBoxPromo);
            this.flowLayoutPanel1.Controls.Add(this.label4);
            this.flowLayoutPanel1.Controls.Add(this.comboBoxPembayaran);
            this.flowLayoutPanel1.Controls.Add(this.label3);
            this.flowLayoutPanel1.Controls.Add(this.comboBoxPengantaran);
            this.flowLayoutPanel1.Controls.Add(this.label5);
            this.flowLayoutPanel1.Controls.Add(this.labelTotalHarga);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(8, 58);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(501, 470);
            this.flowLayoutPanel1.TabIndex = 31;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(2, 532);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 22);
            this.label5.TabIndex = 31;
            this.label5.Text = "Total Harga :";
            // 
            // labelTotalHarga
            // 
            this.labelTotalHarga.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalHarga.Location = new System.Drawing.Point(136, 532);
            this.labelTotalHarga.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTotalHarga.Name = "labelTotalHarga";
            this.labelTotalHarga.Size = new System.Drawing.Size(130, 22);
            this.labelTotalHarga.TabIndex = 32;
            this.labelTotalHarga.Text = "xxxxxxxxxxxxxxxxxxx";
            // 
            // FormCheckout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 578);
            this.ControlBox = false;
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.buttonBayar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonBatal);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormCheckout";
            this.Load += new System.EventHandler(this.FormCheckout_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDeals)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonBayar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonBatal;
        private System.Windows.Forms.DataGridView dataGridViewDeals;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxPromo;
        private System.Windows.Forms.ComboBox comboBoxPembayaran;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxPengantaran;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelTotalHarga;
    }
}