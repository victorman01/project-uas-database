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
    public partial class FormRegistrasiDriver : Form
    {
        public FormRegistrasiDriver()
        {
            InitializeComponent();
        }

        private void buttonKeluar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonDaftar_Click(object sender, EventArgs e)
        {
            try
            {
                Driver driv = new Driver(0, textBoxNama.Text, textBoxEmail.Text,
                    textBoxPassword.Text, textBoxNoTelepon.Text);
                Driver.TambahData(driv);
                MessageBox.Show("Registration success.", "Information");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Registraion failed. Error Message : " + ex.Message, "Failure");
            }            
        }

        private void textBoxNama_Enter(object sender, EventArgs e)
        {
            if (textBoxNama.Text == "Enter Here...")
            {
                textBoxNama.Text = "";
                textBoxNama.ForeColor = Color.Black;
                textBoxNama.Font = new Font("Tahoma", 11, FontStyle.Regular);
            }
        }
        private void textBoxNama_Leave(object sender, EventArgs e)
        {
            if (textBoxNama.Text == "")
            {
                textBoxNama.Text = "Enter Here...";
                textBoxNama.ForeColor = Color.Silver;
                textBoxNama.Font = new Font("Tahoma", 11, FontStyle.Italic);
            }
        }
        private void textBoxEmail_Enter(object sender, EventArgs e)
        {
            if (textBoxEmail.Text == "Enter Here...")
            {
                textBoxEmail.Text = "";
                textBoxEmail.ForeColor = Color.Black;
                textBoxEmail.Font = new Font("Tahoma", 11, FontStyle.Regular);
            }
        }
        private void textBoxEmail_Leave(object sender, EventArgs e)
        {
            if (textBoxEmail.Text == "")
            {
                textBoxEmail.Text = "Enter Here...";
                textBoxEmail.ForeColor = Color.Silver;
                textBoxEmail.Font = new Font("Tahoma", 11, FontStyle.Italic);
            }
        }
        private void textBoxPassword_Enter(object sender, EventArgs e)
        {
            if (textBoxPassword.Text == "Enter Here...")
            {
                textBoxPassword.Text = "";
                textBoxPassword.ForeColor = Color.Black;
                textBoxPassword.Font = new Font("Tahoma", 11, FontStyle.Regular);
            }
        }
        private void textBoxPassword_Leave(object sender, EventArgs e)
        {
            if (textBoxPassword.Text == "")
            {
                textBoxPassword.Text = "Enter Here...";
                textBoxPassword.ForeColor = Color.Silver;
                textBoxPassword.Font = new Font("Tahoma", 11, FontStyle.Italic);
            }
        }

        private void textBoxNoTelepon_Enter(object sender, EventArgs e)
        {
            if (textBoxNoTelepon.Text == "Enter Here...")
            {
                textBoxNoTelepon.Text = "";
                textBoxNoTelepon.ForeColor = Color.Black;
                textBoxNoTelepon.Font = new Font("Tahoma", 11, FontStyle.Regular);
            }
        }

        private void textBoxNoTelepon_Leave(object sender, EventArgs e)
        {
            if (textBoxNoTelepon.Text == "")
            {
                textBoxNoTelepon.Text = "Enter Here...";
                textBoxNoTelepon.ForeColor = Color.Silver;
                textBoxNoTelepon.Font = new Font("Tahoma", 11, FontStyle.Italic);
            }
        }
    }
}
