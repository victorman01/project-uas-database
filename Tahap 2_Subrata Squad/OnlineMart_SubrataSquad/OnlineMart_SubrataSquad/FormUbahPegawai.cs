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
    public partial class FormUbahPegawai : Form
    {
        public FormUbahPegawai()
        {
            InitializeComponent();
        }

        private void buttonSimpan_Click(object sender, EventArgs e)
        {
            try
            {
                Pegawai p = new Pegawai(int.Parse(textBoxIdPegawai.Text), textBoxNamaPegawai.Text, 
                    textBoxEmailPegawai.Text, textBoxNoTeleponPegawai.Text);
                Pegawai.UbahData(p);
                MessageBox.Show("Data Changed.");

                FormPengaturanPegawai form = (FormPengaturanPegawai)this.Owner;
                form.FormPengaturan_Pegawai_Load(sender, e);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("There's error when changing data. Error message : " + ex.Message,
                    "Failure");
            }
        }

        private void buttonKosongi_Click(object sender, EventArgs e)
        {
            textBoxNamaPegawai.Text = "";
            textBoxEmailPegawai.Text = "";
            textBoxNoTeleponPegawai.Text = "";
            textBoxNamaPegawai.Focus();
        }

        private void buttonKeluar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBoxNamaPegawai_Enter(object sender, EventArgs e)
        {
            if (textBoxNamaPegawai.Text == "Type Here...")
            {
                textBoxNamaPegawai.Text = "";
                textBoxNamaPegawai.ForeColor = Color.Black;
                textBoxNamaPegawai.Font = new Font("Tahoma", 10, FontStyle.Regular);
            }
        }

        private void textBoxNamaPegawai_Leave(object sender, EventArgs e)
        {
            if (textBoxNamaPegawai.Text == "")
            {
                textBoxNamaPegawai.Text = "Type Here...";
                textBoxNamaPegawai.ForeColor = Color.Silver;
                textBoxNamaPegawai.Font = new Font("Tahoma", 10, FontStyle.Italic);
            }
        }

        private void textBoxEmailPegawai_Enter(object sender, EventArgs e)
        {
            if (textBoxEmailPegawai.Text == "Type Here...")
            {
                textBoxEmailPegawai.Text = "";
                textBoxEmailPegawai.ForeColor = Color.Black;
                textBoxEmailPegawai.Font = new Font("Tahoma", 10, FontStyle.Regular);
            }
        }

        private void textBoxEmailPegawai_Leave(object sender, EventArgs e)
        {
            if (textBoxEmailPegawai.Text == "")
            {
                textBoxEmailPegawai.Text = "Type Here...";
                textBoxEmailPegawai.ForeColor = Color.Silver;
                textBoxEmailPegawai.Font = new Font("Tahoma", 10, FontStyle.Italic);
            }
        }

        private void textBoxNoTeleponPegawai_Enter(object sender, EventArgs e)
        {
            if (textBoxNoTeleponPegawai.Text == "Type Here...")
            {
                textBoxNoTeleponPegawai.Text = "";
                textBoxNoTeleponPegawai.ForeColor = Color.Black;
                textBoxNoTeleponPegawai.Font = new Font("Tahoma", 10, FontStyle.Regular);
            }
        }

        private void textBoxNoTeleponPegawai_Leave(object sender, EventArgs e)
        {
            if (textBoxNoTeleponPegawai.Text == "")
            {
                textBoxNoTeleponPegawai.Text = "Type Here...";
                textBoxNoTeleponPegawai.ForeColor = Color.Silver;
                textBoxNoTeleponPegawai.Font = new Font("Tahoma", 10, FontStyle.Italic);
            }
        }
    }
}
