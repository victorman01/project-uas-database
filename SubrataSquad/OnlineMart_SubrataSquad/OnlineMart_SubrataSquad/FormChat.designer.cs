﻿
namespace OnlineMart_SubrataSquad
{
    partial class FormChat
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
            this.buttonKirimChat = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonKeluar = new System.Windows.Forms.Button();
            this.listBoxChat = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBoxChat = new System.Windows.Forms.TextBox();
            this.labelSeen = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonKirimChat
            // 
            this.buttonKirimChat.BackColor = System.Drawing.Color.Orange;
            this.buttonKirimChat.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonKirimChat.ForeColor = System.Drawing.Color.White;
            this.buttonKirimChat.Location = new System.Drawing.Point(539, 6);
            this.buttonKirimChat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonKirimChat.Name = "buttonKirimChat";
            this.buttonKirimChat.Size = new System.Drawing.Size(93, 33);
            this.buttonKirimChat.TabIndex = 36;
            this.buttonKirimChat.Text = "Kirim";
            this.buttonKirimChat.UseVisualStyleBackColor = false;
            this.buttonKirimChat.Click += new System.EventHandler(this.buttonKirimChat_Click);
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
            this.label1.Text = "CHAT";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonKeluar
            // 
            this.buttonKeluar.BackColor = System.Drawing.Color.Orange;
            this.buttonKeluar.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonKeluar.ForeColor = System.Drawing.Color.White;
            this.buttonKeluar.Location = new System.Drawing.Point(532, 303);
            this.buttonKeluar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonKeluar.Name = "buttonKeluar";
            this.buttonKeluar.Size = new System.Drawing.Size(115, 39);
            this.buttonKeluar.TabIndex = 34;
            this.buttonKeluar.Text = "&KELUAR";
            this.buttonKeluar.UseVisualStyleBackColor = false;
            this.buttonKeluar.Click += new System.EventHandler(this.buttonKeluar_Click);
            // 
            // listBoxChat
            // 
            this.listBoxChat.BackColor = System.Drawing.Color.White;
            this.listBoxChat.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxChat.FormattingEnabled = true;
            this.listBoxChat.ItemHeight = 21;
            this.listBoxChat.Location = new System.Drawing.Point(11, 75);
            this.listBoxChat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBoxChat.Name = "listBoxChat";
            this.listBoxChat.Size = new System.Drawing.Size(636, 172);
            this.listBoxChat.TabIndex = 37;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PeachPuff;
            this.panel1.Controls.Add(this.textBoxChat);
            this.panel1.Controls.Add(this.buttonKirimChat);
            this.panel1.Location = new System.Drawing.Point(11, 254);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(636, 43);
            this.panel1.TabIndex = 38;
            // 
            // textBoxChat
            // 
            this.textBoxChat.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxChat.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBoxChat.Location = new System.Drawing.Point(7, 10);
            this.textBoxChat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxChat.Name = "textBoxChat";
            this.textBoxChat.Size = new System.Drawing.Size(527, 24);
            this.textBoxChat.TabIndex = 0;
            this.textBoxChat.Text = "Type Here...";
            this.textBoxChat.Enter += new System.EventHandler(this.textBoxChat_Enter);
            this.textBoxChat.Leave += new System.EventHandler(this.textBoxChat_Leave);
            // 
            // labelSeen
            // 
            this.labelSeen.AutoSize = true;
            this.labelSeen.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSeen.Location = new System.Drawing.Point(8, 314);
            this.labelSeen.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSeen.Name = "labelSeen";
            this.labelSeen.Size = new System.Drawing.Size(126, 18);
            this.labelSeen.TabIndex = 39;
            this.labelSeen.Text = "Unvailable Chat";
            // 
            // FormChat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 345);
            this.ControlBox = false;
            this.Controls.Add(this.labelSeen);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.listBoxChat);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonKeluar);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormChat";
            this.Load += new System.EventHandler(this.FormChat_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonKirimChat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonKeluar;
        private System.Windows.Forms.ListBox listBoxChat;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBoxChat;
        private System.Windows.Forms.Label labelSeen;
    }
}