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
                if (textBoxNama.Text != "" && textBoxNama.Text != null && textBoxEmail.Text != "" && textBoxEmail.Text != null && textBoxTelepon.Text != "" && textBoxTelepon.Text != null && textBoxPassword.Text != "" && textBoxPassword.Text != null && textBoxUlangPassword.Text != "" && textBoxUlangPassword.Text != null)
                {
                    if (textBoxPassword.Text == textBoxUlangPassword.Text)
                    {
                        FormProfile formProfile = (FormProfile)Owner;
                        Pelanggan pel = new Pelanggan(formProfile.pelanggan.Id, textBoxNama.Text, textBoxEmail.Text, textBoxUlangPassword.Text, textBoxTelepon.Text, formProfile.pelanggan.Saldo, formProfile.pelanggan.Poin);
                        Pelanggan.UbahData(pel);
                        MessageBox.Show("Profile data has been successfully changed.", "Information");
                        formProfile.FormProfile_Load(sender, e);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Inccorect password");
                    }
                }
                else
                {
                    MessageBox.Show("Profile data can't be empty.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Profile data failed to change. Error Message : " + ex.Message,
                    "Failure");
            }
        }

        private void buttonKeluar_Click(object sender, EventArgs e)
        {
            FormProfile frm = (FormProfile)this.Owner;
            frm.FormProfile_Load(sender, e);
            this.Close();
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
