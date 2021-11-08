
namespace OnlineMart_SubrataSquad
{
    partial class FormKontak
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
            this.dataGridViewKontak = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBoxKontak = new System.Windows.Forms.ComboBox();
            this.textBoxKontak = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonTambah = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonKeluar = new System.Windows.Forms.Button();
            this.buttonChat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKontak)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewKontak
            // 
            this.dataGridViewKontak.BackgroundColor = System.Drawing.Color.Tan;
            this.dataGridViewKontak.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewKontak.Location = new System.Drawing.Point(9, 198);
            this.dataGridViewKontak.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewKontak.Name = "dataGridViewKontak";
            this.dataGridViewKontak.RowHeadersWidth = 51;
            this.dataGridViewKontak.RowTemplate.Height = 24;
            this.dataGridViewKontak.Size = new System.Drawing.Size(636, 278);
            this.dataGridViewKontak.TabIndex = 13;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PapayaWhip;
            this.panel1.Controls.Add(this.comboBoxKontak);
            this.panel1.Controls.Add(this.textBoxKontak);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(9, 81);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(636, 110);
            this.panel1.TabIndex = 11;
            // 
            // comboBoxKontak
            // 
            this.comboBoxKontak.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxKontak.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxKontak.ForeColor = System.Drawing.SystemColors.WindowText;
            this.comboBoxKontak.FormattingEnabled = true;
            this.comboBoxKontak.Items.AddRange(new object[] {
            "Nama"});
            this.comboBoxKontak.Location = new System.Drawing.Point(221, 21);
            this.comboBoxKontak.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxKontak.Name = "comboBoxKontak";
            this.comboBoxKontak.Size = new System.Drawing.Size(359, 29);
            this.comboBoxKontak.TabIndex = 7;
            // 
            // textBoxKontak
            // 
            this.textBoxKontak.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxKontak.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBoxKontak.Location = new System.Drawing.Point(221, 62);
            this.textBoxKontak.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxKontak.Name = "textBoxKontak";
            this.textBoxKontak.Size = new System.Drawing.Size(359, 28);
            this.textBoxKontak.TabIndex = 6;
            this.textBoxKontak.Text = "Type Here...";
            this.textBoxKontak.Enter += new System.EventHandler(this.textBoxKontak_Enter);
            this.textBoxKontak.Leave += new System.EventHandler(this.textBoxKontak_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "Cari Berdasarkan :";
            // 
            // buttonTambah
            // 
            this.buttonTambah.BackColor = System.Drawing.Color.Orange;
            this.buttonTambah.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTambah.ForeColor = System.Drawing.Color.White;
            this.buttonTambah.Location = new System.Drawing.Point(430, 481);
            this.buttonTambah.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonTambah.Name = "buttonTambah";
            this.buttonTambah.Size = new System.Drawing.Size(109, 39);
            this.buttonTambah.TabIndex = 16;
            this.buttonTambah.Text = "&TAMBAH";
            this.buttonTambah.UseVisualStyleBackColor = false;
            this.buttonTambah.Click += new System.EventHandler(this.buttonTambah_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Orange;
            this.label1.Font = new System.Drawing.Font("Tahoma", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(11, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(635, 60);
            this.label1.TabIndex = 10;
            this.label1.Text = "HALAMAN KONTAK";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonKeluar
            // 
            this.buttonKeluar.BackColor = System.Drawing.Color.Orange;
            this.buttonKeluar.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonKeluar.ForeColor = System.Drawing.Color.White;
            this.buttonKeluar.Location = new System.Drawing.Point(545, 481);
            this.buttonKeluar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonKeluar.Name = "buttonKeluar";
            this.buttonKeluar.Size = new System.Drawing.Size(100, 39);
            this.buttonKeluar.TabIndex = 12;
            this.buttonKeluar.Text = "&KELUAR";
            this.buttonKeluar.UseVisualStyleBackColor = false;
            this.buttonKeluar.Click += new System.EventHandler(this.buttonKeluar_Click);
            // 
            // buttonChat
            // 
            this.buttonChat.BackColor = System.Drawing.Color.Orange;
            this.buttonChat.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonChat.ForeColor = System.Drawing.Color.White;
            this.buttonChat.Location = new System.Drawing.Point(9, 481);
            this.buttonChat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonChat.Name = "buttonChat";
            this.buttonChat.Size = new System.Drawing.Size(109, 39);
            this.buttonChat.TabIndex = 17;
            this.buttonChat.Text = "&CHAT";
            this.buttonChat.UseVisualStyleBackColor = false;
            this.buttonChat.Click += new System.EventHandler(this.buttonChat_Click);
            // 
            // FormKontak
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 528);
            this.ControlBox = false;
            this.Controls.Add(this.buttonChat);
            this.Controls.Add(this.dataGridViewKontak);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonTambah);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonKeluar);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormKontak";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKontak)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewKontak;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboBoxKontak;
        private System.Windows.Forms.TextBox textBoxKontak;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonTambah;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonKeluar;
        private System.Windows.Forms.Button buttonChat;
    }
}