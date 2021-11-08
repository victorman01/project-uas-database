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
    public partial class FormRekapPendapatan : Form
    {
        public FormRekapPendapatan()
        {
            InitializeComponent();
        }

        private void buttonKeluar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBoxCBListPendapatan_Enter(object sender, EventArgs e)
        {
            if (textBoxCBListPendapatan.Text == "Type Here...")
            {
                textBoxCBListPendapatan.Text = "";
                textBoxCBListPendapatan.ForeColor = Color.Black;
                textBoxCBListPendapatan.Font = new Font("Tahoma", 10, FontStyle.Regular);
            }
        }

        private void textBoxCBListPendapatan_Leave(object sender, EventArgs e)
        {
            if (textBoxCBListPendapatan.Text == "")
            {
                textBoxCBListPendapatan.Text = "Type Here...";
                textBoxCBListPendapatan.ForeColor = Color.Silver;
                textBoxCBListPendapatan.Font = new Font("Tahoma", 10, FontStyle.Italic);
            }
        }
    }
}
