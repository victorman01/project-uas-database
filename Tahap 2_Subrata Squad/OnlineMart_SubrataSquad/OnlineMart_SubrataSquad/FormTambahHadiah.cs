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
    public partial class FormTambahHadiah : Form
    {
        public FormTambahHadiah()
        {
            InitializeComponent();
        }

        private void textBoxNamaHadiah_Enter(object sender, EventArgs e)
        {
            if (textBoxNamaHadiah.Text == "Type Here...")
            {
                textBoxNamaHadiah.Text = "";
                textBoxNamaHadiah.ForeColor = Color.Black;
                textBoxNamaHadiah.Font = new Font("Tahoma", 10, FontStyle.Regular);
            }
        }

        private void textBoxNamaHadiah_Leave(object sender, EventArgs e)
        {
            if (textBoxNamaHadiah.Text == "")
            {
                textBoxNamaHadiah.Text = "Type Here...";
                textBoxNamaHadiah.ForeColor = Color.Silver;
                textBoxNamaHadiah.Font = new Font("Tahoma", 10, FontStyle.Italic);
            }
        }

        private void textBoxJumlahPoin_Enter(object sender, EventArgs e)
        {
            if (textBoxJumlahPoin.Text == "Type Here...")
            {
                textBoxJumlahPoin.Text = "";
                textBoxJumlahPoin.ForeColor = Color.Black;
                textBoxJumlahPoin.Font = new Font("Tahoma", 10, FontStyle.Regular);
            }
        }

        private void textBoxJumlahPoin_Leave(object sender, EventArgs e)
        {
            if (textBoxJumlahPoin.Text == "")
            {
                textBoxJumlahPoin.Text = "Type Here...";
                textBoxJumlahPoin.ForeColor = Color.Silver;
                textBoxJumlahPoin.Font = new Font("Tahoma", 10, FontStyle.Italic);
            }
        }

        private void buttonSimpan_Click(object sender, EventArgs e)
        {
            try
            {
                Gift g = new Gift(textBoxNamaHadiah.Text, textBoxJumlahPoin.Text);
                Gift.TambahData(g);
                MessageBox.Show("Data gift success to be added", "Info");

                FormPengaturanHadiah form = (FormPengaturanHadiah)this.Owner;
                form.FormPengaturanHadiah_Load(sender, e);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("There's error added data gift. Error Message : " + ex.Message,
                    "Failure");
            }
        }

        private void buttonKosongi_Click(object sender, EventArgs e)
        {
            textBoxNamaHadiah.Text = "";
            textBoxJumlahPoin.Text = "";
            textBoxNamaHadiah.Focus();
        }

        private void buttonKeluar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
