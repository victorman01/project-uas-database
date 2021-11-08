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
    public partial class FormKontak : Form
    {
        public FormKontak()
        {
            InitializeComponent();
        }

        private void buttonKeluar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonTambah_Click(object sender, EventArgs e)
        {

        }

        private void buttonChat_Click(object sender, EventArgs e)
        {
            FormHubungi form = new FormHubungi();
            form.Owner = this;
            form.ShowDialog();
        }

        private void textBoxKontak_Enter(object sender, EventArgs e)
        {
            if (textBoxKontak.Text == "Type Here...")
            {
                textBoxKontak.Text = "";
                textBoxKontak.ForeColor = Color.Black;
                textBoxKontak.Font = new Font("Tahoma", 10, FontStyle.Regular);
            }
        }

        private void textBoxKontak_Leave(object sender, EventArgs e)
        {
            if (textBoxKontak.Text == "")
            {
                textBoxKontak.Text = "Type Here...";
                textBoxKontak.ForeColor = Color.Silver;
                textBoxKontak.Font = new Font("Tahoma", 10, FontStyle.Italic);
            }
        }
    }
}
