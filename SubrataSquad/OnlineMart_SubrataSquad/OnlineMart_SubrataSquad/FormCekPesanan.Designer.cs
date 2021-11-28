
namespace OnlineMart_SubrataSquad
{
    partial class FormCekPesanan
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
            this.dataGridViewCekPesanan = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonKeluar = new System.Windows.Forms.Button();
            this.buttonCetakNota = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCekPesanan)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewCekPesanan
            // 
            this.dataGridViewCekPesanan.BackgroundColor = System.Drawing.Color.Tan;
            this.dataGridViewCekPesanan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCekPesanan.Location = new System.Drawing.Point(11, 82);
            this.dataGridViewCekPesanan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewCekPesanan.Name = "dataGridViewCekPesanan";
            this.dataGridViewCekPesanan.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridViewCekPesanan.RowTemplate.Height = 24;
            this.dataGridViewCekPesanan.Size = new System.Drawing.Size(636, 354);
            this.dataGridViewCekPesanan.TabIndex = 35;
            this.dataGridViewCekPesanan.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCekPesanan_CellContentClick);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Orange;
            this.label1.Font = new System.Drawing.Font("Tahoma", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(635, 60);
            this.label1.TabIndex = 33;
            this.label1.Text = "HALAMAN CEK PESANAN";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonKeluar
            // 
            this.buttonKeluar.BackColor = System.Drawing.Color.Orange;
            this.buttonKeluar.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonKeluar.ForeColor = System.Drawing.Color.White;
            this.buttonKeluar.Location = new System.Drawing.Point(533, 442);
            this.buttonKeluar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonKeluar.Name = "buttonKeluar";
            this.buttonKeluar.Size = new System.Drawing.Size(115, 39);
            this.buttonKeluar.TabIndex = 34;
            this.buttonKeluar.Text = "&KELUAR";
            this.buttonKeluar.UseVisualStyleBackColor = false;
            this.buttonKeluar.Click += new System.EventHandler(this.buttonKeluar_Click);
            // 
            // buttonCetakNota
            // 
            this.buttonCetakNota.BackColor = System.Drawing.Color.Orange;
            this.buttonCetakNota.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCetakNota.ForeColor = System.Drawing.Color.White;
            this.buttonCetakNota.Location = new System.Drawing.Point(354, 442);
            this.buttonCetakNota.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonCetakNota.Name = "buttonCetakNota";
            this.buttonCetakNota.Size = new System.Drawing.Size(164, 39);
            this.buttonCetakNota.TabIndex = 36;
            this.buttonCetakNota.Text = "&CETAK NOTA";
            this.buttonCetakNota.UseVisualStyleBackColor = false;
            this.buttonCetakNota.Click += new System.EventHandler(this.buttonCetakNota_Click);
            // 
            // FormCekPesanan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(657, 492);
            this.ControlBox = false;
            this.Controls.Add(this.buttonCetakNota);
            this.Controls.Add(this.dataGridViewCekPesanan);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonKeluar);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormCekPesanan";
            this.Load += new System.EventHandler(this.FormCekPesanan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCekPesanan)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridViewCekPesanan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonKeluar;
        private System.Windows.Forms.Button buttonCetakNota;
    }
}