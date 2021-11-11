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
