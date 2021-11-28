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
    public partial class FormDashboard : Form
    {
        public FormDashboard()
        {
            InitializeComponent();
        }

        private void FormUtama_Load(object sender, EventArgs e)
        {
            try
            {
                Connection conDB = new Connection();
                this.WindowState = FormWindowState.Maximized;
                FormChat frm = new FormChat();
                frm.Owner = this;
                MessageBox.Show("Connection success", "Information");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Connection failed, failure message : " + ex.Message);
            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonPegawai_Click(object sender, EventArgs e)
        {
            FormLogin form = new FormLogin();
            form.Owner = this;
            form.labelNamaLogin.Text = "LOGIN PEGAWAI";
            form.labelSignUp.Enabled = false;
            form.labelPertanyaanLogin.Visible = false;
            form.labelForgetPassword.Enabled = false;
            form.labelForgetPassword.Visible = false;
            form.labelSignUp.Visible = false;
            form.ShowDialog();
        }

        private void buttonDriver_Click(object sender, EventArgs e)
        {
            FormLogin form = new FormLogin();
            form.Owner = this;
            form.labelNamaLogin.Text = "LOGIN DRIVER";
            form.ShowDialog();
        }

        private void buttonPelanggan_Click(object sender, EventArgs e)
        {
            FormLogin form = new FormLogin();
            form.Owner = this;
            form.labelNamaLogin.Text = "LOGIN PELANGGAN";
            form.ShowDialog();
        }
    }
}
