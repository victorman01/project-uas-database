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
    public partial class FormPengaturanPromo : Form
    {
        public FormPengaturanPromo()
        {
            InitializeComponent();
        }

        private void buttonKeluar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBoxMinimalPembelian_Enter(object sender, EventArgs e)
        {
            if (textBoxMinimalPembelian.Text == "Type Here...")
            {
                textBoxMinimalPembelian.Text = "";
                textBoxMinimalPembelian.ForeColor = Color.Black;
                textBoxMinimalPembelian.Font = new Font("Tahoma", 10, FontStyle.Regular);
            }
        }

        private void textBoxMinimalPembelian_Leave(object sender, EventArgs e)
        {
            if (textBoxMinimalPembelian.Text == "")
            {
                textBoxMinimalPembelian.Text = "Type Here...";
                textBoxMinimalPembelian.ForeColor = Color.Silver;
                textBoxMinimalPembelian.Font = new Font("Tahoma", 10, FontStyle.Italic);
            }
        }

        private void textBoxMaksimalDiskon_Enter(object sender, EventArgs e)
        {
            if (textBoxMaksimalDiskon.Text == "Type Here...")
            {
                textBoxMaksimalDiskon.Text = "";
                textBoxMaksimalDiskon.ForeColor = Color.Black;
                textBoxMaksimalDiskon.Font = new Font("Tahoma", 10, FontStyle.Regular);
            }
        }

        private void textBoxMaksimalDiskon_Leave(object sender, EventArgs e)
        {
            if (textBoxMaksimalDiskon.Text == "")
            {
                textBoxMaksimalDiskon.Text = "Type Here...";
                textBoxMaksimalDiskon.ForeColor = Color.Silver;
                textBoxMaksimalDiskon.Font = new Font("Tahoma", 10, FontStyle.Italic);
            }
        }

        private void textBoxDiskon_Enter(object sender, EventArgs e)
        {
            if (textBoxDiskon.Text == "Type Here...")
            {
                textBoxDiskon.Text = "";
                textBoxDiskon.ForeColor = Color.Black;
                textBoxDiskon.Font = new Font("Tahoma", 10, FontStyle.Regular);
            }
        }

        private void textBoxDiskon_Leave(object sender, EventArgs e)
        {
            if (textBoxDiskon.Text == "")
            {
                textBoxDiskon.Text = "Type Here...";
                textBoxDiskon.ForeColor = Color.Silver;
                textBoxDiskon.Font = new Font("Tahoma", 10, FontStyle.Italic);
            }
        }

        private void textBoxTipePromo_Enter(object sender, EventArgs e)
        {
            if (textBoxTipePromo.Text == "Type Here...")
            {
                textBoxTipePromo.Text = "";
                textBoxTipePromo.ForeColor = Color.Black;
                textBoxTipePromo.Font = new Font("Tahoma", 10, FontStyle.Regular);
            }
        }

        private void textBoxTipePromo_Leave(object sender, EventArgs e)
        {
            if (textBoxTipePromo.Text == "")
            {
                textBoxTipePromo.Text = "Type Here...";
                textBoxTipePromo.ForeColor = Color.Silver;
                textBoxTipePromo.Font = new Font("Tahoma", 10, FontStyle.Italic);
            }
        }

        private void textBoxNamaPromo_Enter(object sender, EventArgs e)
        {
            if (textBoxNamaPromo.Text == "Type Here...")
            {
                textBoxNamaPromo.Text = "";
                textBoxNamaPromo.ForeColor = Color.Black;
                textBoxNamaPromo.Font = new Font("Tahoma", 10, FontStyle.Regular);
            }
        }

        private void textBoxNamaPromo_Leave(object sender, EventArgs e)
        {
            if (textBoxNamaPromo.Text == "")
            {
                textBoxNamaPromo.Text = "Type Here...";
                textBoxNamaPromo.ForeColor = Color.Silver;
                textBoxNamaPromo.Font = new Font("Tahoma", 10, FontStyle.Italic);
            }
        }

        private void textBoxKodePromo_Enter(object sender, EventArgs e)
        {
            if (textBoxKodePromo.Text == "Type Here...")
            {
                textBoxKodePromo.Text = "";
                textBoxKodePromo.ForeColor = Color.Black;
                textBoxKodePromo.Font = new Font("Tahoma", 10, FontStyle.Regular);
            }
        }

        private void textBoxKodePromo_Leave(object sender, EventArgs e)
        {
            if (textBoxKodePromo.Text == "")
            {
                textBoxKodePromo.Text = "Type Here...";
                textBoxKodePromo.ForeColor = Color.Silver;
                textBoxKodePromo.Font = new Font("Tahoma", 10, FontStyle.Italic);
            }
        }

        private void buttonKosongi_Click(object sender, EventArgs e)
        {
            textBoxKodePromo.Text = "";
            textBoxNamaPromo.Text = "";
            textBoxTipePromo.Text = "";
            textBoxDiskon.Text = "";
            textBoxMaksimalDiskon.Text = "";
            textBoxMinimalPembelian.Text = "";
            textBoxKodePromo.Focus();
        }

        private void FormPengaturanPromo_Load(object sender, EventArgs e)
        {

        }
    }
}
