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
    public partial class FormTambahMetodePembayaran : Form
    {
        public List<MetodePembayaran> listMetodePembayaran = new List<MetodePembayaran>();
        public FormTambahMetodePembayaran()
        {
            InitializeComponent();
        }

        private void buttonKeluar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonSimpan_Click(object sender, EventArgs e)
        {
            try
            {
                MetodePembayaran mp = new MetodePembayaran(textBoxNamaMP.Text);
                MetodePembayaran.TambahData(mp);
                MessageBox.Show("Data metode pembayaran success to be added", "Info");

                FormPengaturanMetodePembayaran form = (FormPengaturanMetodePembayaran)this.Owner;
                form.FormPengaturanMetodePembayaran_Load(sender, e);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("There's error added data metode pembayaran. Error Message : " + ex.Message,
                    "Failure");
            }
        }

        private void textBoxNamaMP_Enter(object sender, EventArgs e)
        {
            if (textBoxNamaMP.Text == "Type Here...")
            {
                textBoxNamaMP.Text = "";
                textBoxNamaMP.ForeColor = Color.Black;
                textBoxNamaMP.Font = new Font("Tahoma", 10, FontStyle.Regular);
            }
        }

        private void textBoxNamaMP_Leave(object sender, EventArgs e)
        {
            if (textBoxNamaMP.Text == "")
            {
                textBoxNamaMP.Text = "Type Here...";
                textBoxNamaMP.ForeColor = Color.Silver;
                textBoxNamaMP.Font = new Font("Tahoma", 10, FontStyle.Italic);
            }
        }

        private void buttonKosongi_Click(object sender, EventArgs e)
        {
            textBoxNamaMP.Text = "";
            textBoxNamaMP.Focus();
        }
    }
}
