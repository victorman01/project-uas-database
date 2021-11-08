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
    public partial class FormIsiSaldo : Form
    {
        public FormIsiSaldo()
        {
            InitializeComponent();
        }

        private void buttonIsi_Click(object sender, EventArgs e)
        {
            DialogResult dR = MessageBox.Show("Are You Sure?", "Confirmation", MessageBoxButtons.YesNo);
            if (dR == DialogResult.Yes)
            {
                MessageBox.Show("Top up success.", "Information");
            }
            else
            {
                MessageBox.Show("Top up fail.", "Information");
            }
        }

        private void buttonKeluar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void textBoxJumlahPengisianSaldo_Enter(object sender, EventArgs e)
        {
            if (textBoxJumlahPengisianSaldo.Text == "Type Here...")
            {
                textBoxJumlahPengisianSaldo.Text = "";
                textBoxJumlahPengisianSaldo.ForeColor = Color.Black;
                textBoxJumlahPengisianSaldo.Font = new Font("Tahoma", 9, FontStyle.Regular);
            }
        }

        private void textBoxJumlahPengisianSaldo_Leave(object sender, EventArgs e)
        {
            if (textBoxJumlahPengisianSaldo.Text == "")
            {
                textBoxJumlahPengisianSaldo.Text = "Type Here...";
                textBoxJumlahPengisianSaldo.ForeColor = Color.Silver;
                textBoxJumlahPengisianSaldo.Font = new Font("Tahoma", 9, FontStyle.Regular);
            }
        }

    }
}
