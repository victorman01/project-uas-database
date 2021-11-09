
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
            this.buttonDetail = new System.Windows.Forms.Button();
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
            this.panel1.Location = new System.Drawing.Point(9, 70);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(420, 95);
            this.panel1.TabIndex = 6;
            // 
            // comboBoxCBListPengiriman
            // 
            this.comboBoxCBListPengiriman.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCBListPengiriman.FormattingEnabled = true;
            this.comboBoxCBListPengiriman.Items.AddRange(new object[] {
            "ID Order"});
            this.comboBoxCBListPengiriman.Location = new System.Drawing.Point(154, 23);
            this.comboBoxCBListPengiriman.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBoxCBListPengiriman.Name = "comboBoxCBListPengiriman";
            this.comboBoxCBListPengiriman.Size = new System.Drawing.Size(246, 21);
            this.comboBoxCBListPengiriman.TabIndex = 7;
            // 
            // textBoxCBListPengiriman
            // 
            this.textBoxCBListPengiriman.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCBListPengiriman.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBoxCBListPengiriman.Location = new System.Drawing.Point(154, 47);
            this.textBoxCBListPengiriman.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxCBListPengiriman.Name = "textBoxCBListPengiriman";
            this.textBoxCBListPengiriman.Size = new System.Drawing.Size(246, 24);
            this.textBoxCBListPengiriman.TabIndex = 6;
            this.textBoxCBListPengiriman.Text = "Type Here...";
            this.textBoxCBListPengiriman.Enter += new System.EventHandler(this.textBoxCBListPengiriman_Enter);
            this.textBoxCBListPengiriman.Leave += new System.EventHandler(this.textBoxCBListPengiriman_Leave);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(17, 23);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Cari Berdasarkan :";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Orange;
            this.label1.Font = new System.Drawing.Font("Tahoma", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(9, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(420, 49);
            this.label1.TabIndex = 5;
            this.label1.Text = "LIST PENGIRIMAN";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonKeluar
            // 
            this.buttonKeluar.BackColor = System.Drawing.Color.Orange;
            this.buttonKeluar.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonKeluar.ForeColor = System.Drawing.Color.White;
            this.buttonKeluar.Location = new System.Drawing.Point(339, 398);
            this.buttonKeluar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonKeluar.Name = "buttonKeluar";
            this.buttonKeluar.Size = new System.Drawing.Size(90, 41);
            this.buttonKeluar.TabIndex = 7;
            this.buttonKeluar.Text = "&KELUAR";
            this.buttonKeluar.UseVisualStyleBackColor = false;
            this.buttonKeluar.Click += new System.EventHandler(this.buttonKeluar_Click);
            // 
            // dataGridViewListPengiriman
            // 
            this.dataGridViewListPengiriman.BackgroundColor = System.Drawing.Color.Tan;
            this.dataGridViewListPengiriman.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewListPengiriman.Location = new System.Drawing.Point(9, 171);
            this.dataGridViewListPengiriman.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridViewListPengiriman.Name = "dataGridViewListPengiriman";
            this.dataGridViewListPengiriman.RowHeadersWidth = 51;
            this.dataGridViewListPengiriman.RowTemplate.Height = 24;
            this.dataGridViewListPengiriman.Size = new System.Drawing.Size(420, 223);
            this.dataGridViewListPengiriman.TabIndex = 8;
            // 
            // buttonDetail
            // 
            this.buttonDetail.BackColor = System.Drawing.Color.Orange;
            this.buttonDetail.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDetail.ForeColor = System.Drawing.Color.White;
            this.buttonDetail.Location = new System.Drawing.Point(237, 398);
            this.buttonDetail.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonDetail.Name = "buttonDetail";
            this.buttonDetail.Size = new System.Drawing.Size(90, 41);
            this.buttonDetail.TabIndex = 9;
            this.buttonDetail.Text = "&DETAIL";
            this.buttonDetail.UseVisualStyleBackColor = false;
            this.buttonDetail.Click += new System.EventHandler(this.buttonDetail_Click);
            // 
            // FormListPengiriman
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 448);
            this.ControlBox = false;
            this.Controls.Add(this.buttonDetail);
            this.Controls.Add(this.dataGridViewListPengiriman);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonKeluar);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
        private System.Windows.Forms.Button buttonDetail;
    }
}