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
    public partial class FormRekapPenjualanBarang : Form
    {
        public FormRekapPenjualanBarang()
        {
            InitializeComponent();
        }

        private void buttonKeluar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBoxCBRekapPenjualanBarang_Enter(object sender, EventArgs e)
        {
            if (textBoxCBRekapPenjualanBarang.Text == "Type Here...")
            {
                textBoxCBRekapPenjualanBarang.Text = "";
                textBoxCBRekapPenjualanBarang.ForeColor = Color.Black;
                textBoxCBRekapPenjualanBarang.Font = new Font("Tahoma", 10, FontStyle.Regular);
            }
        }

        private void textBoxCBRekapPenjualanBarang_Leave(object sender, EventArgs e)
        {
            if (textBoxCBRekapPenjualanBarang.Text == "")
            {
                textBoxCBRekapPenjualanBarang.Text = "Type Here...";
                textBoxCBRekapPenjualanBarang.ForeColor = Color.Silver;
                textBoxCBRekapPenjualanBarang.Font = new Font("Tahoma", 10, FontStyle.Italic);
            }
        }
    }
}
