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
    public partial class FormPengaturanMetodePembayaran : Form
    {
        public FormPengaturanMetodePembayaran()
        {
            InitializeComponent();
        }

        private void buttonKeluar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonTambah_Click(object sender, EventArgs e)
        {
            FormTambahMetodePembayaran form = new FormTambahMetodePembayaran();
            form.Owner = this;
            form.ShowDialog();
        }

        private void buttonUBAH_Click(object sender, EventArgs e)
        {
            FormUbahMetodePembayaran form = new FormUbahMetodePembayaran();
            form.Owner = this;
            form.ShowDialog();
        }

        private void textBoxCBPengaturanMP_Enter(object sender, EventArgs e)
        {
            if (textBoxCBPengaturanMP.Text == "Type Here...")
            {
                textBoxCBPengaturanMP.Text = "";
                textBoxCBPengaturanMP.ForeColor = Color.Black;
                textBoxCBPengaturanMP.Font = new Font("Tahoma", 10, FontStyle.Regular);
            }
        }

        private void textBoxCBPengaturanMP_Leave(object sender, EventArgs e)
        {
            if (textBoxCBPengaturanMP.Text == "")
            {
                textBoxCBPengaturanMP.Text = "Type Here...";
                textBoxCBPengaturanMP.ForeColor = Color.Silver;
                textBoxCBPengaturanMP.Font = new Font("Tahoma", 10, FontStyle.Italic);
            }
        }
    }
}
