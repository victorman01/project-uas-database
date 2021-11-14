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
    public partial class FormRegistrasiPegawai : Form
    {
        public FormRegistrasiPegawai()
        {
            InitializeComponent();
        }

        private void buttonDaftar_Click(object sender, EventArgs e)
        {
            try
            {
                Pegawai p = new Pegawai(textBoxNama.Text, textBoxEmail.Text,
                    textBoxPassword.Text, textBoxTelepon.Text);
                Pegawai.TambahData(p);
                MessageBox.Show("Registration success.", "Information");
                FormPengaturanPegawai frm = new FormPengaturanPegawai();
                frm.FormPengaturan_Pegawai_Load(sender, e);
                this.Close();
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

        private void buttonKeluar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
