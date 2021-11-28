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
    public partial class FormRegistrasiPelanggan : Form
    {
        public FormRegistrasiPelanggan()
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
                if (textBoxNama.Text != "" && textBoxNama.Text != null && textBoxEmail.Text != "" && textBoxEmail.Text != null && textBoxTelepon.Text != "" && textBoxTelepon.Text != null && textBoxPassword.Text != "" && textBoxPassword.Text != null)
                {
                    Pelanggan pel = new Pelanggan(0, textBoxNama.Text, textBoxEmail.Text, textBoxPassword.Text, textBoxTelepon.Text, 0, 0);
                    Pelanggan.TambahData(pel);
                    MessageBox.Show("Registration success.", "Information");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Data can't empty.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Registraion failed. Error Message : " + ex.Message, "Failure");
            }

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
    }
}
