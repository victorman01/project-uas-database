
namespace OnlineMart_SubrataSquad
{
    partial class FormListPengiriman
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
            this.comboBoxCBListPengiriman = new System.Windows.Forms.ComboBox();
            this.textBoxCBListPengiriman = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonKeluar = new System.Windows.Forms.Button();
            this.dataGridViewListPengiriman = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListPengiriman)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PapayaWhip;
            this.panel1.Controls.Add(this.comboBoxCBListPengiriman);
            this.panel1.Controls.Add(this.textBoxCBListPengiriman);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Location = new System.Drawing.Point(14, 108);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(630, 146);
            this.panel1.TabIndex = 6;
            // 
            // comboBoxCBListPengiriman
            // 
            this.comboBoxCBListPengiriman.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCBListPengiriman.FormattingEnabled = true;
            this.comboBoxCBListPengiriman.Items.AddRange(new object[] {
            "ID Order"});
            this.comboBoxCBListPengiriman.Location = new System.Drawing.Point(231, 35);
            this.comboBoxCBListPengiriman.Name = "comboBoxCBListPengiriman";
            this.comboBoxCBListPengiriman.Size = new System.Drawing.Size(367, 28);
            this.comboBoxCBListPengiriman.TabIndex = 7;
            // 
            // textBoxCBListPengiriman
            // 
            this.textBoxCBListPengiriman.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCBListPengiriman.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBoxCBListPengiriman.Location = new System.Drawing.Point(231, 72);
            this.textBoxCBListPengiriman.Name = "textBoxCBListPengiriman";
            this.textBoxCBListPengiriman.Size = new System.Drawing.Size(367, 32);
            this.textBoxCBListPengiriman.TabIndex = 6;
            this.textBoxCBListPengiriman.Text = "Type Here...";
            this.textBoxCBListPengiriman.TextChanged += new System.EventHandler(this.textBoxCBListPengiriman_TextChanged);
            this.textBoxCBListPengiriman.Enter += new System.EventHandler(this.textBoxCBListPengiriman_Enter);
            this.textBoxCBListPengiriman.Leave += new System.EventHandler(this.textBoxCBListPengiriman_Leave);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(26, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(186, 25);
            this.label6.TabIndex = 5;
            this.label6.Text = "Cari Berdasarkan :";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Orange;
            this.label1.Font = new System.Drawing.Font("Tahoma", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(14, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(630, 75);
            this.label1.TabIndex = 5;
            this.label1.Text = "LIST PENGIRIMAN";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonKeluar
            // 
            this.buttonKeluar.BackColor = System.Drawing.Color.Orange;
            this.buttonKeluar.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonKeluar.ForeColor = System.Drawing.Color.White;
            this.buttonKeluar.Location = new System.Drawing.Point(508, 612);
            this.buttonKeluar.Name = "buttonKeluar";
            this.buttonKeluar.Size = new System.Drawing.Size(135, 63);
            this.buttonKeluar.TabIndex = 7;
            this.buttonKeluar.Text = "&KELUAR";
            this.buttonKeluar.UseVisualStyleBackColor = false;
            this.buttonKeluar.Click += new System.EventHandler(this.buttonKeluar_Click);
            // 
            // dataGridViewListPengiriman
            // 
            this.dataGridViewListPengiriman.BackgroundColor = System.Drawing.Color.Tan;
            this.dataGridViewListPengiriman.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewListPengiriman.Location = new System.Drawing.Point(14, 263);
            this.dataGridViewListPengiriman.Name = "dataGridViewListPengiriman";
            this.dataGridViewListPengiriman.RowHeadersWidth = 51;
            this.dataGridViewListPengiriman.RowTemplate.Height = 24;
            this.dataGridViewListPengiriman.Size = new System.Drawing.Size(630, 343);
            this.dataGridViewListPengiriman.TabIndex = 8;
            this.dataGridViewListPengiriman.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewListPengiriman_CellContentClick);
            // 
            // FormListPengiriman
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 689);
            this.ControlBox = false;
            this.Controls.Add(this.dataGridViewListPengiriman);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonKeluar);
            this.Name = "FormListPengiriman";
            this.Load += new System.EventHandler(this.FormListPengiriman_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListPengiriman)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboBoxCBListPengiriman;
        private System.Windows.Forms.TextBox textBoxCBListPengiriman;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonKeluar;
        private System.Windows.Forms.DataGridView dataGridViewListPengiriman;
    }
}