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
    public partial class FormUbahProfile : Form
    {
        public FormUbahProfile()
        {
            InitializeComponent();
        }

        private void buttonSimpan_Click(object sender, EventArgs e)
        {
            try
            {
                FormProfile formProfile = (FormProfile)Owner;
                Pelanggan pel = new Pelanggan(formProfile.pelanggan.Id, textBoxNama.Text, textBoxEmail.Text, textBoxUlangPassword.Text, textBoxTelepon.Text,  formProfile.pelanggan.Saldo, formProfile.pelanggan.Poin) ;
                Pelanggan.UbahData(pel);
                MessageBox.Show("Data Changed.");
                formProfile.FormProfile_Load(sender, e);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("There's error when changing data. Error message : " + ex.Message,
                    "Failure");
            }
        }

        private void buttonKeluar_Click(object sender, EventArgs e)
        {
            FormProfile frm = (FormProfile)this.Owner;
            frm.FormProfile_Load(sender, e);
            this.Close();
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

        private void textBoxUlangPassword_Enter(object sender, EventArgs e)
        {
            if (textBoxUlangPassword.Text == "Type Here...")
            {
                textBoxUlangPassword.Text = "";
                textBoxUlangPassword.ForeColor = Color.Black;
                textBoxUlangPassword.Font = new Font("Tahoma", 10, FontStyle.Regular);
            }
        }

        private void textBoxUlangPassword_Leave(object sender, EventArgs e)
        {
            if (textBoxUlangPassword.Text == "")
            {
                textBoxUlangPassword.Text = "Type Here...";
                textBoxUlangPassword.ForeColor = Color.Silver;
                textBoxUlangPassword.Font = new Font("Tahoma", 10, FontStyle.Italic);
            }
        }

        private void checkBoxShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxShowPassword.Checked)
            {
                textBoxPassword.PasswordChar = '\0';
                textBoxUlangPassword.PasswordChar = '\0';
            }
            else
            {
                textBoxPassword.PasswordChar = '*';
                textBoxUlangPassword.PasswordChar = '*';
            }
        }
    }
}
