
namespace OnlineMart_SubrataSquad
{
    partial class FormPengaturanMetodePembayaran
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
            this.dataGridViewPengaturanMP = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonKeluar = new System.Windows.Forms.Button();
            this.buttonTambah = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxCBPengaturanMP = new System.Windows.Forms.TextBox();
            this.comboBoxCBPengaturanMP = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPengaturanMP)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewPengaturanMP
            // 
            this.dataGridViewPengaturanMP.BackgroundColor = System.Drawing.Color.Tan;
            this.dataGridViewPengaturanMP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPengaturanMP.Location = new System.Drawing.Point(11, 226);
            this.dataGridViewPengaturanMP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewPengaturanMP.Name = "dataGridViewPengaturanMP";
            this.dataGridViewPengaturanMP.RowHeadersWidth = 51;
            this.dataGridViewPengaturanMP.RowTemplate.Height = 24;
            this.dataGridViewPengaturanMP.Size = new System.Drawing.Size(560, 256);
            this.dataGridViewPengaturanMP.TabIndex = 24;
            this.dataGridViewPengaturanMP.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPengaturanMP_CellContentClick);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Orange;
            this.label1.Font = new System.Drawing.Font("Tahoma", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(11, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(560, 98);
            this.label1.TabIndex = 21;
            this.label1.Text = "PENGATURAN METODE PEMBAYARAN";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonKeluar
            // 
            this.buttonKeluar.BackColor = System.Drawing.Color.Orange;
            this.buttonKeluar.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonKeluar.ForeColor = System.Drawing.Color.White;
            this.buttonKeluar.Location = new System.Drawing.Point(451, 489);
            this.buttonKeluar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonKeluar.Name = "buttonKeluar";
            this.buttonKeluar.Size = new System.Drawing.Size(120, 50);
            this.buttonKeluar.TabIndex = 23;
            this.buttonKeluar.Text = "&KELUAR";
            this.buttonKeluar.UseVisualStyleBackColor = false;
            this.buttonKeluar.Click += new System.EventHandler(this.buttonKeluar_Click);
            // 
            // buttonTambah
            // 
            this.buttonTambah.BackColor = System.Drawing.Color.Orange;
            this.buttonTambah.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTambah.ForeColor = System.Drawing.Color.White;
            this.buttonTambah.Location = new System.Drawing.Point(325, 489);
            this.buttonTambah.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonTambah.Name = "buttonTambah";
            this.buttonTambah.Size = new System.Drawing.Size(120, 50);
            this.buttonTambah.TabIndex = 25;
            this.buttonTambah.Text = "&TAMBAH";
            this.buttonTambah.UseVisualStyleBackColor = false;
            this.buttonTambah.Click += new System.EventHandler(this.buttonTambah_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(21, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(147, 21);
            this.label6.TabIndex = 5;
            this.label6.Text = "Cari Berdasarkan :";
            // 
            // textBoxCBPengaturanMP
            // 
            this.textBoxCBPengaturanMP.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCBPengaturanMP.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBoxCBPengaturanMP.Location = new System.Drawing.Point(205, 46);
            this.textBoxCBPengaturanMP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxCBPengaturanMP.Name = "textBoxCBPengaturanMP";
            this.textBoxCBPengaturanMP.Size = new System.Drawing.Size(327, 28);
            this.textBoxCBPengaturanMP.TabIndex = 6;
            this.textBoxCBPengaturanMP.Text = "Type Here...";
            this.textBoxCBPengaturanMP.TextChanged += new System.EventHandler(this.textBoxCBPengaturanMP_TextChanged);
            this.textBoxCBPengaturanMP.Enter += new System.EventHandler(this.textBoxCBPengaturanMP_Enter);
            this.textBoxCBPengaturanMP.Leave += new System.EventHandler(this.textBoxCBPengaturanMP_Leave);
            // 
            // comboBoxCBPengaturanMP
            // 
            this.comboBoxCBPengaturanMP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCBPengaturanMP.FormattingEnabled = true;
            this.comboBoxCBPengaturanMP.Items.AddRange(new object[] {
            "ID Metode Pembayaran",
            "Nama Metode Pembayaran"});
            this.comboBoxCBPengaturanMP.Location = new System.Drawing.Point(205, 18);
            this.comboBoxCBPengaturanMP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxCBPengaturanMP.Name = "comboBoxCBPengaturanMP";
            this.comboBoxCBPengaturanMP.Size = new System.Drawing.Size(327, 24);
            this.comboBoxCBPengaturanMP.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PapayaWhip;
            this.panel1.Controls.Add(this.comboBoxCBPengaturanMP);
            this.panel1.Controls.Add(this.textBoxCBPengaturanMP);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Location = new System.Drawing.Point(11, 123);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(560, 98);
            this.panel1.TabIndex = 22;
            // 
            // FormPengaturanMetodePembayaran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 546);
            this.ControlBox = false;
            this.Controls.Add(this.buttonTambah);
            this.Controls.Add(this.dataGridViewPengaturanMP);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonKeluar);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormPengaturanMetodePembayaran";
            this.Load += new System.EventHandler(this.FormPengaturanMetodePembayaran_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPengaturanMP)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewPengaturanMP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonKeluar;
        private System.Windows.Forms.Button buttonTambah;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxCBPengaturanMP;
        private System.Windows.Forms.ComboBox comboBoxCBPengaturanMP;
        private System.Windows.Forms.Panel panel1;
    }
}