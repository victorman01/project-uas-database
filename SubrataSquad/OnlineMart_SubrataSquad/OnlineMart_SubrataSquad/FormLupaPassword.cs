using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OnlineMart_LIB;

namespace OnlineMart_SubrataSquad
{
    public partial class FormLupaPassword : Form
    {
        public string userCek;
        public FormLupaPassword()
        {
            InitializeComponent();
        }

        private void checkBoxShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxShowPassword.Checked)
            {
                textBoxPassword.PasswordChar = '\0';
            }
            else
            {
                textBoxPassword.PasswordChar = '*';
            }
        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                if (userCek == "LOGIN PELANGGAN")
                {
                    if(textBoxUsername.Text != null || textBoxUsername.Text != "")
                    {
                        Pelanggan pel = Pelanggan.AmbilPelangganByUsername(textBoxUsername.Text);
                        if (pel != null && textBoxPassword.Text.Length >= 8)
                        {
                            pel.Password = textBoxPassword.Text;
                            Pelanggan.UbahData(pel);
                            MessageBox.Show("Password has been changed");
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Username isn't registered or the password is less than 8 character");
                            return;
                        }
                    }
                }
                else if (userCek == "LOGIN DRIVER")
                {
                    if(textBoxUsername.Text != null || textBoxUsername.Text != "")
                    {
                        Driver driver = Driver.AmbilDriverByUsername(textBoxUsername.Text);
                        if (driver != null && textBoxPassword.Text.Length >= 8)
                        {
                            driver.Password = textBoxPassword.Text;
                            Driver.UbahData(driver);
                            MessageBox.Show("Password has been changed");
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Username isn't registered or the password is less than 8 character");
                            return;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Changing password failed. Error Message: " + ex.Message);
            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
