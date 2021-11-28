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
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            try
            {
                Connection koneksi = new Connection();

                FormUtama frm = new FormUtama();
                frm.Owner = this;
                if (labelNamaLogin.Text == "LOGIN PEGAWAI")
                {
                    Pegawai p = Pegawai.CekLogin(textBoxUsername.Text, textBoxPassword.Text);

                    if (!(p is null))
                    {
                        frm.pegawai = p;
                        frm.loginAs = "Pegawai";
                        MessageBox.Show("Connection Success. Welcome and enjoy the application.", "Information");

                        this.DialogResult = DialogResult.OK;

                        this.Hide();
                        frm.cabangToolStripMenuItem.Visible = true;
                        frm.kategoriToolStripMenuItem.Visible = true;
                        frm.barangToolStripMenuItem.Visible = true;
                        frm.metodePembayaranToolStripMenuItem.Visible = true;
                        frm.promoPegawaiToolStripMenuItem.Visible = true;
                        frm.hadiahToolStripMenuItem.Visible = true;
                        frm.pegawaiToolStripMenuItem.Visible = true;
                        frm.rekapPenjualanBarangToolStripMenuItem.Visible = true;
                        frm.rekapPenjualanOMASaldoToolStripMenuItem.Visible = true;
                        frm.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show(this, "Username or Password is wrong. Please try again!");
                    }
                }
                else if (labelNamaLogin.Text == "LOGIN PELANGGAN")
                {
                    Pelanggan pel = Pelanggan.CekLogin(textBoxUsername.Text, textBoxPassword.Text);

                    if (!(pel is null))
                    {
                        frm.pelanggan = pel;
                        frm.loginAs = "Pelanggan";
                        MessageBox.Show("Connection Success. Welcome and enjoy the application.", "Information");

                        this.DialogResult = DialogResult.OK;

                        this.Hide();
                        frm.cariBarangToolStripMenuItem.Visible = true;
                        frm.keranjangToolStripMenuItem.Visible = true;
                        frm.saldoToolStripMenuItem.Visible = true;
                        frm.pesananToolStripMenuItem.Visible = true;
                        frm.rekapPembelianToolStripMenuItem.Visible = true;
                        frm.accountToolStripMenuItem.Visible = true;
                        frm.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show(this, "Username or Password is wrong. Please try again!");
                    }

                }
                else if (labelNamaLogin.Text == "LOGIN DRIVER")
                {
                    Driver driv = Driver.CekLogin(textBoxUsername.Text, textBoxPassword.Text);

                    if (!(driv is null))
                    {
                        frm.driver = driv;
                        frm.loginAs = "Driver";
                        MessageBox.Show("Connection Success. Welcome and enjoy the application.", "Information");

                        this.DialogResult = DialogResult.OK;

                        this.Hide();
                        frm.daftarPengirimanToolStripMenuItem.Visible = true;
                        frm.rekapPendapatanToolStripMenuItem.Visible = true;
                        frm.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show(this, "Username or Password is wrong. Please try again!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Connection failed. Error Message : " + ex.Message, "Failed");
            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void labelSignUp_Click(object sender, EventArgs e)
        {
            if (labelNamaLogin.Text == "LOGIN PELANGGAN")
            {
                FormRegistrasiPelanggan form = new FormRegistrasiPelanggan();
                form.Owner = this;
                form.ShowDialog();
            }
            else
            {
                FormRegistrasiDriver form = new FormRegistrasiDriver();
                form.Owner = this;
                form.ShowDialog();
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

        private void labelForgetPassword_Click(object sender, EventArgs e)
        {
            FormLupaPassword frm = new FormLupaPassword();
            frm.userCek = labelNamaLogin.Text;
            frm.Owner = this;
            frm.ShowDialog();
        }
    }
}
