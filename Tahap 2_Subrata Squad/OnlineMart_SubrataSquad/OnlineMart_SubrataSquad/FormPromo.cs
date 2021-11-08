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
    public partial class FormPromo : Form
    {
        public FormPromo()
        {
            InitializeComponent();
        }

        private void buttonKeluar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBoxDeals_Enter(object sender, EventArgs e)
        {
            if (textBoxDeals.Text == "Type Here...")
            {
                textBoxDeals.Text = "";
                textBoxDeals.ForeColor = Color.Black;
                textBoxDeals.Font = new Font("Tahoma", 10, FontStyle.Regular);
            }
        }

        private void textBoxDeals_Leave(object sender, EventArgs e)
        {
            if (textBoxDeals.Text == "")
            {
                textBoxDeals.Text = "Type Here...";
                textBoxDeals.ForeColor = Color.Silver;
                textBoxDeals.Font = new Font("Tahoma", 10, FontStyle.Italic);
            }
        }
    }
}
