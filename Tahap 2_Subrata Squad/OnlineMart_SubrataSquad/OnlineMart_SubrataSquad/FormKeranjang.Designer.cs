
namespace OnlineMart_SubrataSquad
{
    partial class FormKeranjang
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBoxKeranjang = new System.Windows.Forms.ComboBox();
            this.textBoxKeranjang = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonKeluar = new System.Windows.Forms.Button();
            this.dataGridViewKeranjang = new System.Windows.Forms.DataGridView();
            this.buttonCheckout = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKeranjang)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PapayaWhip;
            this.panel1.Controls.Add(this.comboBoxKeranjang);
            this.panel1.Controls.Add(this.textBoxKeranjang);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(8, 67);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(477, 88);
            this.panel1.TabIndex = 15;
            // 
            // comboBoxKeranjang
            // 
            this.comboBoxKeranjang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxKeranjang.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxKeranjang.ForeColor = System.Drawing.SystemColors.WindowText;
            this.comboBoxKeranjang.FormattingEnabled = true;
            this.comboBoxKeranjang.Items.AddRange(new object[] {
            "Kode Deals",
            "Tipe Deals",
            "Nama Deals",
            "Diskon",
            "Diskon Max",
            "Minimal Belanja"});
            this.comboBoxKeranjang.Location = new System.Drawing.Point(129, 17);
            this.comboBoxKeranjang.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxKeranjang.Name = "comboBoxKeranjang";
            this.comboBoxKeranjang.Size = new System.Drawing.Size(270, 25);
            this.comboBoxKeranjang.TabIndex = 7;
            // 
            // textBoxKeranjang
            // 
            this.textBoxKeranjang.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxKeranjang.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBoxKeranjang.Location = new System.Drawing.Point(129, 46);
            this.textBoxKeranjang.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxKeranjang.Name = "textBoxKeranjang";
            this.textBoxKeranjang.Size = new System.Drawing.Size(270, 26);
            this.textBoxKeranjang.TabIndex = 6;
            this.textBoxKeranjang.Text = "Type Here...";
            this.textBoxKeranjang.Enter += new System.EventHandler(this.textBoxKeranjang_Enter);
            this.textBoxKeranjang.Leave += new System.EventHandler(this.textBoxKeranjang_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 20);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Cari Berdasarkan :";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Orange;
            this.label1.Font = new System.Drawing.Font("Tahoma", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(9, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(476, 49);
            this.label1.TabIndex = 14;
            this.label1.Text = "HALAMAN KERANJANG";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonKeluar
            // 
            this.buttonKeluar.BackColor = System.Drawing.Color.Orange;
            this.buttonKeluar.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonKeluar.ForeColor = System.Drawing.Color.White;
            this.buttonKeluar.Location = new System.Drawing.Point(399, 392);
            this.buttonKeluar.Margin = new System.Windows.Forms.Padding(2);
            this.buttonKeluar.Name = "buttonKeluar";
            this.buttonKeluar.Size = new System.Drawing.Size(86, 32);
            this.buttonKeluar.TabIndex = 16;
            this.buttonKeluar.Text = "&KELUAR";
            this.buttonKeluar.UseVisualStyleBackColor = false;
            this.buttonKeluar.Click += new System.EventHandler(this.buttonKeluar_Click);
            // 
            // dataGridViewKeranjang
            // 
            this.dataGridViewKeranjang.BackgroundColor = System.Drawing.Color.Tan;
            this.dataGridViewKeranjang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewKeranjang.Location = new System.Drawing.Point(8, 163);
            this.dataGridViewKeranjang.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewKeranjang.Name = "dataGridViewKeranjang";
            this.dataGridViewKeranjang.RowHeadersWidth = 51;
            this.dataGridViewKeranjang.RowTemplate.Height = 24;
            this.dataGridViewKeranjang.Size = new System.Drawing.Size(477, 224);
            this.dataGridViewKeranjang.TabIndex = 17;
            // 
            // buttonCheckout
            // 
            this.buttonCheckout.BackColor = System.Drawing.Color.Orange;
            this.buttonCheckout.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCheckout.ForeColor = System.Drawing.Color.White;
            this.buttonCheckout.Location = new System.Drawing.Point(295, 392);
            this.buttonCheckout.Margin = new System.Windows.Forms.Padding(2);
            this.buttonCheckout.Name = "buttonCheckout";
            this.buttonCheckout.Size = new System.Drawing.Size(100, 32);
            this.buttonCheckout.TabIndex = 18;
            this.buttonCheckout.Text = "&CHECKOUT";
            this.buttonCheckout.UseVisualStyleBackColor = false;
            this.buttonCheckout.Click += new System.EventHandler(this.buttonCheckout_Click);
            // 
            // FormKeranjang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 431);
            this.ControlBox = false;
            this.Controls.Add(this.buttonCheckout);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonKeluar);
            this.Controls.Add(this.dataGridViewKeranjang);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormKeranjang";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKeranjang)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboBoxKeranjang;
        private System.Windows.Forms.TextBox textBoxKeranjang;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonKeluar;
        private System.Windows.Forms.DataGridView dataGridViewKeranjang;
        private System.Windows.Forms.Button buttonCheckout;
    }
}