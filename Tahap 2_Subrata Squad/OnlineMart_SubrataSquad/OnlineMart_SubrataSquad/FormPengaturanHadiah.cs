using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnlineMart_SubrataSquad
{
    public partial class FormPengaturanHadiah : Form
    {
        public FormPengaturanHadiah()
        {
            InitializeComponent();
        }

        private void buttonKeluar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBoxIDCabang_Enter(object sender, EventArgs e)
        {
            if (textBoxIDCabang.Text == "Type Here...")
            {
                textBoxIDCabang.Text = "";
                textBoxIDCabang.ForeColor = Color.Black;
                textBoxIDCabang.Font = new Font("Tahoma", 10, FontStyle.Regular);
            }
        }

        private void textBoxIDCabang_Leave(object sender, EventArgs e)
        {
            if (textBoxIDCabang.Text == "")
            {
                textBoxIDCabang.Text = "Type Here...";
                textBoxIDCabang.ForeColor = Color.Silver;
                textBoxIDCabang.Font = new Font("Tahoma", 10, FontStyle.Italic);
            }
        }

        private void textBoxNamaCabang_Enter(object sender, EventArgs e)
        {
            if (textBoxNamaCabang.Text == "Type Here...")
            {
                textBoxNamaCabang.Text = "";
                textBoxNamaCabang.ForeColor = Color.Black;
                textBoxNamaCabang.Font = new Font("Tahoma", 10, FontStyle.Regular);
            }
        }

        private void textBoxNamaCabang_Leave(object sender, EventArgs e)
        {
            if (textBoxNamaCabang.Text == "")
            {
                textBoxNamaCabang.Text = "Type Here...";
                textBoxNamaCabang.ForeColor = Color.Silver;
                textBoxNamaCabang.Font = new Font("Tahoma", 10, FontStyle.Italic);
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

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
