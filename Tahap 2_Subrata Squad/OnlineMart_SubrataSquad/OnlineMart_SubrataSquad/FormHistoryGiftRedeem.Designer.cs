
namespace OnlineMart_SubrataSquad
{
    partial class FormHistoryGiftRedeem
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
            this.comboBoxHistoryGR = new System.Windows.Forms.ComboBox();
            this.textBoxHistoryGR = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridHistoryGR = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonKeluar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridHistoryGR)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PapayaWhip;
            this.panel1.Controls.Add(this.comboBoxHistoryGR);
            this.panel1.Controls.Add(this.textBoxHistoryGR);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(12, 84);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(636, 108);
            this.panel1.TabIndex = 15;
            // 
            // comboBoxHistoryGR
            // 
            this.comboBoxHistoryGR.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxHistoryGR.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxHistoryGR.ForeColor = System.Drawing.SystemColors.WindowText;
            this.comboBoxHistoryGR.FormattingEnabled = true;
            this.comboBoxHistoryGR.Items.AddRange(new object[] {
            "ID",
            "Waktu",
            "Poin Redeem",
            "Nama Gift",
            "Order ID"});
            this.comboBoxHistoryGR.Location = new System.Drawing.Point(172, 21);
            this.comboBoxHistoryGR.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxHistoryGR.Name = "comboBoxHistoryGR";
            this.comboBoxHistoryGR.Size = new System.Drawing.Size(359, 29);
            this.comboBoxHistoryGR.TabIndex = 7;
            // 
            // textBoxHistoryGR
            // 
            this.textBoxHistoryGR.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxHistoryGR.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBoxHistoryGR.Location = new System.Drawing.Point(172, 57);
            this.textBoxHistoryGR.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxHistoryGR.Name = "textBoxHistoryGR";
            this.textBoxHistoryGR.Size = new System.Drawing.Size(359, 28);
            this.textBoxHistoryGR.TabIndex = 6;
            this.textBoxHistoryGR.Text = "Type Here...";
            this.textBoxHistoryGR.TextChanged += new System.EventHandler(this.textBoxHistoryGR_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "Cari Berdasarkan :";
            // 
            // dataGridHistoryGR
            // 
            this.dataGridHistoryGR.BackgroundColor = System.Drawing.Color.Tan;
            this.dataGridHistoryGR.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridHistoryGR.Location = new System.Drawing.Point(12, 203);
            this.dataGridHistoryGR.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridHistoryGR.Name = "dataGridHistoryGR";
            this.dataGridHistoryGR.RowHeadersWidth = 51;
            this.dataGridHistoryGR.RowTemplate.Height = 24;
            this.dataGridHistoryGR.Size = new System.Drawing.Size(636, 276);
            this.dataGridHistoryGR.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Orange;
            this.label1.Font = new System.Drawing.Font("Tahoma", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(13, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(635, 60);
            this.label1.TabIndex = 14;
            this.label1.Text = "HISTORY GIFT REDEEM";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonKeluar
            // 
            this.buttonKeluar.BackColor = System.Drawing.Color.Orange;
            this.buttonKeluar.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonKeluar.ForeColor = System.Drawing.Color.White;
            this.buttonKeluar.Location = new System.Drawing.Point(548, 485);
            this.buttonKeluar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonKeluar.Name = "buttonKeluar";
            this.buttonKeluar.Size = new System.Drawing.Size(100, 39);
            this.buttonKeluar.TabIndex = 16;
            this.buttonKeluar.Text = "&KELUAR";
            this.buttonKeluar.UseVisualStyleBackColor = false;
            this.buttonKeluar.Click += new System.EventHandler(this.buttonKeluar_Click);
            // 
            // FormHistoryGiftRedeem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 535);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridHistoryGR);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonKeluar);
            this.Name = "FormHistoryGiftRedeem";
            this.Load += new System.EventHandler(this.FormHistoryGiftRedeem_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridHistoryGR)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboBoxHistoryGR;
        private System.Windows.Forms.TextBox textBoxHistoryGR;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridHistoryGR;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonKeluar;
    }
}