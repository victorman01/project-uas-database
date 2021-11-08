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
    public partial class FormListPengiriman : Form
    {
        public FormListPengiriman()
        {
            InitializeComponent();
        }

        private void buttonKeluar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonDetail_Click(object sender, EventArgs e)
        {
            FormListPengirimanDetail form = new FormListPengirimanDetail();
            form.Owner = this;
            form.ShowDialog();
        }

        private void textBoxCBListPengiriman_Enter(object sender, EventArgs e)
        {
            if (textBoxCBListPengiriman.Text == "Type Here...")
            {
                textBoxCBListPengiriman.Text = "";
                textBoxCBListPengiriman.ForeColor = Color.Black;
                textBoxCBListPengiriman.Font = new Font("Tahoma", 10, FontStyle.Regular);
            }
        }

        private void textBoxCBListPengiriman_Leave(object sender, EventArgs e)
        {
            if (textBoxCBListPengiriman.Text == "")
            {
                textBoxCBListPengiriman.Text = "Type Here...";
                textBoxCBListPengiriman.ForeColor = Color.Silver;
                textBoxCBListPengiriman.Font = new Font("Tahoma", 10, FontStyle.Italic);
            }
        }
    }
}
