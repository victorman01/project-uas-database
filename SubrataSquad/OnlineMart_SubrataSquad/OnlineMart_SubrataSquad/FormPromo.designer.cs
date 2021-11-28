
namespace OnlineMart_SubrataSquad
{
    partial class FormPromo
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
            this.comboBoxDeals = new System.Windows.Forms.ComboBox();
            this.textBoxDeals = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonKeluar = new System.Windows.Forms.Button();
            this.dataGridViewDeals = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDeals)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PapayaWhip;
            this.panel1.Controls.Add(this.comboBoxDeals);
            this.panel1.Controls.Add(this.textBoxDeals);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(12, 84);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(636, 108);
            this.panel1.TabIndex = 10;
            // 
            // comboBoxDeals
            // 
            this.comboBoxDeals.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDeals.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxDeals.ForeColor = System.Drawing.SystemColors.WindowText;
            this.comboBoxDeals.FormattingEnabled = true;
            this.comboBoxDeals.Items.AddRange(new object[] {
            "Kode Deals",
            "Tipe Deals",
            "Nama Deals",
            "Diskon",
            "Diskon Max",
            "Minimal Belanja"});
            this.comboBoxDeals.Location = new System.Drawing.Point(172, 21);
            this.comboBoxDeals.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxDeals.Name = "comboBoxDeals";
            this.comboBoxDeals.Size = new System.Drawing.Size(359, 29);
            this.comboBoxDeals.TabIndex = 7;
            // 
            // textBoxDeals
            // 
            this.textBoxDeals.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDeals.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBoxDeals.Location = new System.Drawing.Point(172, 57);
            this.textBoxDeals.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxDeals.Name = "textBoxDeals";
            this.textBoxDeals.Size = new System.Drawing.Size(359, 28);
            this.textBoxDeals.TabIndex = 6;
            this.textBoxDeals.Text = "Type Here...";
            this.textBoxDeals.Enter += new System.EventHandler(this.textBoxDeals_Enter);
            this.textBoxDeals.Leave += new System.EventHandler(this.textBoxDeals_Leave);
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
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Orange;
            this.label1.Font = new System.Drawing.Font("Tahoma", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(13, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(635, 60);
            this.label1.TabIndex = 9;
            this.label1.Text = "HALAMAN PROMO";
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
            this.buttonKeluar.TabIndex = 12;
            this.buttonKeluar.Text = "&KELUAR";
            this.buttonKeluar.UseVisualStyleBackColor = false;
            this.buttonKeluar.Click += new System.EventHandler(this.buttonKeluar_Click);
            // 
            // dataGridViewDeals
            // 
            this.dataGridViewDeals.BackgroundColor = System.Drawing.Color.Tan;
            this.dataGridViewDeals.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDeals.Location = new System.Drawing.Point(12, 203);
            this.dataGridViewDeals.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewDeals.Name = "dataGridViewDeals";
            this.dataGridViewDeals.RowHeadersWidth = 51;
            this.dataGridViewDeals.RowTemplate.Height = 24;
            this.dataGridViewDeals.Size = new System.Drawing.Size(636, 276);
            this.dataGridViewDeals.TabIndex = 13;
            this.dataGridViewDeals.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDeals_CellContentClick);
            // 
            // FormPromo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(661, 535);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonKeluar);
            this.Controls.Add(this.dataGridViewDeals);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormPromo";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDeals)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboBoxDeals;
        private System.Windows.Forms.TextBox textBoxDeals;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonKeluar;
        private System.Windows.Forms.DataGridView dataGridViewDeals;
    }
}