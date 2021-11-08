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
                Pelanggan pel = new Pelanggan(0, textBoxNama.Text, textBoxEmail.Text,
                    textBoxPassword.Text, textBoxTelepon.Text, 0, 0);
                Pelanggan.TambahData(pel);
                MessageBox.Show("Registration success.", "Information");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Registraion failed. Error Message : " + ex.Message, "Failure");
            }

        }

        private void textBoxTelepon_Enter(object sender, EventArgs e)
        {
            if (textBoxTelepon.Text == "Type Here...")
            {
                textBoxTelepon.Text = "";
                textBoxTelepon.ForeColor = Color.Black;
                textBoxTelepon.Font = new Font("Tahoma", 10, FontStyle.Regular);
            }
        }

        private void textBoxTelepon_Leave(object sender, EventArgs e)
        {
            if (textBoxTelepon.Text == "")
            {
                textBoxTelepon.Text = "Type Here...";
                textBoxTelepon.ForeColor = Color.Silver;
                textBoxTelepon.Font = new Font("Tahoma", 10, FontStyle.Italic);
            }
        }

        private void textBoxPassword_Enter(object sender, EventArgs e)
        {
            if (textBoxPassword.Text == "Type Here...")
            {
                textBoxPassword.Text = "";
                textBoxPassword.ForeColor = Color.Black;
                textBoxPassword.Font = new Font("Tahoma", 10, FontStyle.Regular);
            }
        }

        private void textBoxPassword_Leave(object sender, EventArgs e)
        {
            if (textBoxPassword.Text == "")
            {
                textBoxPassword.Text = "Type Here...";
                textBoxPassword.ForeColor = Color.Silver;
                textBoxPassword.Font = new Font("Tahoma", 10, FontStyle.Italic);
            }
        }

        private void textBoxEmail_Enter(object sender, EventArgs e)
        {
            if (textBoxEmail.Text == "Type Here...")
            {
                textBoxEmail.Text = "";
                textBoxEmail.ForeColor = Color.Black;
                textBoxEmail.Font = new Font("Tahoma", 10, FontStyle.Regular);
            }
        }

        private void textBoxEmail_Leave(object sender, EventArgs e)
        {
            if (textBoxEmail.Text == "")
            {
                textBoxEmail.Text = "Type Here...";
                textBoxEmail.ForeColor = Color.Silver;
                textBoxEmail.Font = new Font("Tahoma", 10, FontStyle.Italic);
            }
        }

        private void textBoxNama_Enter(object sender, EventArgs e)
        {
            if (textBoxNama.Text == "Type Here...")
            {
                textBoxNama.Text = "";
                textBoxNama.ForeColor = Color.Black;
                textBoxNama.Font = new Font("Tahoma", 10, FontStyle.Regular);
            }
        }

        private void textBoxNama_Leave(object sender, EventArgs e)
        {
            if (textBoxNama.Text == "")
            {
                textBoxNama.Text = "Type Here...";
                textBoxNama.ForeColor = Color.Silver;
                textBoxNama.Font = new Font("Tahoma", 10, FontStyle.Italic);
            }
        }
    }
}
