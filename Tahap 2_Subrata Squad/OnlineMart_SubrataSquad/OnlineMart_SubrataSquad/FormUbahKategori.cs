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
    public partial class FormUbahKategori : Form
    {
        public FormUbahKategori()
        {
            InitializeComponent();
        }

        private void buttonKeluar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBoxNamaKategori_Enter(object sender, EventArgs e)
        {
            if (textBoxNamaKategori.Text == "Type Here...")
            {
                textBoxNamaKategori.Text = "";
                textBoxNamaKategori.ForeColor = Color.Black;
                textBoxNamaKategori.Font = new Font("Tahoma", 10, FontStyle.Regular);
            }
        }

        private void textBoxNamaKategori_Leave(object sender, EventArgs e)
        {
            if (textBoxNamaKategori.Text == "")
            {
                textBoxNamaKategori.Text = "Type Here...";
                textBoxNamaKategori.ForeColor = Color.Silver;
                textBoxNamaKategori.Font = new Font("Tahoma", 10, FontStyle.Italic);
            }
        }

        private void textBoxIdKategori_Enter(object sender, EventArgs e)
        {
            if (textBoxIdKategori.Text == "Type Here...")
            {
                textBoxIdKategori.Text = "";
                textBoxIdKategori.ForeColor = Color.Black;
                textBoxIdKategori.Font = new Font("Tahoma", 10, FontStyle.Regular);
            }
        }

        private void textBoxIdKategori_Leave(object sender, EventArgs e)
        {
            if (textBoxIdKategori.Text == "")
            {
                textBoxIdKategori.Text = "Type Here...";
                textBoxIdKategori.ForeColor = Color.Silver;
                textBoxIdKategori.Font = new Font("Tahoma", 10, FontStyle.Italic);
            }
        }

        private void buttonKosongi_Click(object sender, EventArgs e)
        {
            textBoxNamaKategori.Text = "";
            textBoxIdKategori.Focus();
        }

        private void buttonSimpan_Click(object sender, EventArgs e)
        {
            try
            {
                Kategori k = new Kategori(int.Parse(textBoxIdKategori.Text), textBoxNamaKategori.Text);
                Kategori.UbahData(k);
                MessageBox.Show("Data Changed.");

                FormPengaturanKategori form = (FormPengaturanKategori)this.Owner;
                form.FormPengaturanKategori_Load(sender, e);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("There's error when changing data. Error message : " + ex.Message,
                    "Failure");
            }
        }
    }
}
