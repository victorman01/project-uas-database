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
    public partial class FormKeranjang : Form
    {
        public FormKeranjang()
        {
            InitializeComponent();
        }

        private void buttonKeluar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonCheckout_Click(object sender, EventArgs e)
        {
            FormCheckout form = new FormCheckout();
            form.Owner = this;
            form.ShowDialog();
        }
        private void textBoxKeranjang_Enter(object sender, EventArgs e)
        {
            if (textBoxKeranjang.Text == "Type Here...")
            {
                textBoxKeranjang.Text = "";
                textBoxKeranjang.ForeColor = Color.Black;
                textBoxKeranjang.Font = new Font("Tahoma", 11, FontStyle.Regular);
            }
        }
        private void textBoxKeranjang_Leave(object sender, EventArgs e)
        {
            if (textBoxKeranjang.Text == "")
            {
                textBoxKeranjang.Text = "Type Here...";
                textBoxKeranjang.ForeColor = Color.Silver;
                textBoxKeranjang.Font = new Font("Tahoma", 11, FontStyle.Italic);
            }
        }
    }
}
