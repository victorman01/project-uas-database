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
    public partial class FormHubungi : Form
    {
        public FormHubungi()
        {
            InitializeComponent();
        }

        private void buttonKeluar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBoxChat_Enter(object sender, EventArgs e)
        {
            if (textBoxChat.Text == "Type Here...")
            {
                textBoxChat.Text = "";
                textBoxChat.ForeColor = Color.Black;
                textBoxChat.Font = new Font("Tahoma", 8, FontStyle.Regular);
            }
        }

        private void textBoxChat_Leave(object sender, EventArgs e)
        {
            if (textBoxChat.Text == "")
            {
                textBoxChat.Text = "Type Here...";
                textBoxChat.ForeColor = Color.Silver;
                textBoxChat.Font = new Font("Tahoma", 8, FontStyle.Regular);
            }
        }
    }
}
