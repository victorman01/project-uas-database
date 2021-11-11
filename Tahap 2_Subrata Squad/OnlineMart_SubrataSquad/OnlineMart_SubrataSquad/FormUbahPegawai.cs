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
    }
}
