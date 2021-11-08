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
    public partial class FormRekapPenjualanOMASaldo : Form
    {
        public FormRekapPenjualanOMASaldo()
        {
            InitializeComponent();
        }

        private void buttonKeluar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBoxCBRekapPenjualanOMA_Enter(object sender, EventArgs e)
        {
            if (textBoxCBRekapPenjualanOMA.Text == "Type Here...")
            {
                textBoxCBRekapPenjualanOMA.Text = "";
                textBoxCBRekapPenjualanOMA.ForeColor = Color.Black;
                textBoxCBRekapPenjualanOMA.Font = new Font("Tahoma", 10, FontStyle.Regular);
            }
        }

        private void textBoxCBRekapPenjualanOMA_Leave(object sender, EventArgs e)
        {
            if (textBoxCBRekapPenjualanOMA.Text == "")
            {
                textBoxCBRekapPenjualanOMA.Text = "Type Here...";
                textBoxCBRekapPenjualanOMA.ForeColor = Color.Silver;
                textBoxCBRekapPenjualanOMA.Font = new Font("Tahoma", 10, FontStyle.Italic);
            }
        }
    }
}
