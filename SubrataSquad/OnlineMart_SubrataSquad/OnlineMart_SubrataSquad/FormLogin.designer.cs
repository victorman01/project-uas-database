
namespace OnlineMart_SubrataSquad
{
    partial class FormLogin
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
            this.labelSignUp = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelPertanyaanLogin = new System.Windows.Forms.Label();
            this.checkBoxShowPassword = new System.Windows.Forms.CheckBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelNamaLogin = new System.Windows.Forms.Label();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.labelForgetPassword = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelSignUp
            // 
            this.labelSignUp.AutoSize = true;
            this.labelSignUp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelSignUp.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSignUp.Location = new System.Drawing.Point(352, 166);
            this.labelSignUp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSignUp.Name = "labelSignUp";
            this.labelSignUp.Size = new System.Drawing.Size(61, 17);
            this.labelSignUp.TabIndex = 6;
            this.labelSignUp.Text = "Sign Up";
            this.labelSignUp.Click += new System.EventHandler(this.labelSignUp_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PapayaWhip;
            this.panel1.Controls.Add(this.labelForgetPassword);
            this.panel1.Controls.Add(this.labelSignUp);
            this.panel1.Controls.Add(this.labelPertanyaanLogin);
            this.panel1.Controls.Add(this.checkBoxShowPassword);
            this.panel1.Controls.Add(this.textBoxPassword);
            this.panel1.Controls.Add(this.textBoxUsername);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(17, 98);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(745, 225);
            this.panel1.TabIndex = 1;
            // 
            // labelPertanyaanLogin
            // 
            this.labelPertanyaanLogin.AutoSize = true;
            this.labelPertanyaanLogin.BackColor = System.Drawing.Color.PapayaWhip;
            this.labelPertanyaanLogin.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPertanyaanLogin.Location = new System.Drawing.Point(196, 166);
            this.labelPertanyaanLogin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPertanyaanLogin.Name = "labelPertanyaanLogin";
            this.labelPertanyaanLogin.Size = new System.Drawing.Size(157, 17);
            this.labelPertanyaanLogin.TabIndex = 5;
            this.labelPertanyaanLogin.Text = "Don\'t have an Account?";
            // 
            // checkBoxShowPassword
            // 
            this.checkBoxShowPassword.AutoSize = true;
            this.checkBoxShowPassword.Location = new System.Drawing.Point(281, 117);
            this.checkBoxShowPassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBoxShowPassword.Name = "checkBoxShowPassword";
            this.checkBoxShowPassword.Size = new System.Drawing.Size(129, 21);
            this.checkBoxShowPassword.TabIndex = 4;
            this.checkBoxShowPassword.Text = "Show Password";
            this.checkBoxShowPassword.UseVisualStyleBackColor = true;
            this.checkBoxShowPassword.CheckedChanged += new System.EventHandler(this.checkBoxShowPassword_CheckedChanged);
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(281, 85);
            this.textBoxPassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.Size = new System.Drawing.Size(320, 22);
            this.textBoxPassword.TabIndex = 3;
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Location = new System.Drawing.Point(281, 53);
            this.textBoxUsername.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(320, 22);
            this.textBoxUsername.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(157, 82);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Password :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(152, 50);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "Username :";
            // 
            // labelNamaLogin
            // 
            this.labelNamaLogin.BackColor = System.Drawing.Color.Orange;
            this.labelNamaLogin.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNamaLogin.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelNamaLogin.Location = new System.Drawing.Point(16, 11);
            this.labelNamaLogin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNamaLogin.Name = "labelNamaLogin";
            this.labelNamaLogin.Size = new System.Drawing.Size(747, 74);
            this.labelNamaLogin.TabIndex = 0;
            this.labelNamaLogin.Text = "LOGIN PELANGGAN";
            this.labelNamaLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.Color.Orange;
            this.buttonExit.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExit.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonExit.Location = new System.Drawing.Point(629, 331);
            this.buttonExit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(133, 49);
            this.buttonExit.TabIndex = 3;
            this.buttonExit.Text = "&EXIT";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonLogin
            // 
            this.buttonLogin.BackColor = System.Drawing.Color.Orange;
            this.buttonLogin.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogin.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonLogin.Location = new System.Drawing.Point(487, 331);
            this.buttonLogin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(133, 49);
            this.buttonLogin.TabIndex = 2;
            this.buttonLogin.Text = "&LOGIN";
            this.buttonLogin.UseVisualStyleBackColor = false;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // labelForgetPassword
            // 
            this.labelForgetPassword.AutoSize = true;
            this.labelForgetPassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelForgetPassword.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelForgetPassword.Location = new System.Drawing.Point(477, 118);
            this.labelForgetPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelForgetPassword.Name = "labelForgetPassword";
            this.labelForgetPassword.Size = new System.Drawing.Size(118, 17);
            this.labelForgetPassword.TabIndex = 7;
            this.labelForgetPassword.Text = "Forgot Password?";
            this.labelForgetPassword.Click += new System.EventHandler(this.labelForgetPassword_Click);
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 390);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labelNamaLogin);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonLogin);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormLogin";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox checkBoxShowPassword;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonLogin;
        public System.Windows.Forms.Label labelNamaLogin;
        public System.Windows.Forms.Label labelSignUp;
        public System.Windows.Forms.Label labelPertanyaanLogin;
        public System.Windows.Forms.Label labelForgetPassword;
    }
}