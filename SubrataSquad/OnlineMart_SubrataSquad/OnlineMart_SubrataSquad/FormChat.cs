using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OnlineMart_LIB;

namespace OnlineMart_SubrataSquad
{
    public partial class FormChat : Form
    {
        public Pelanggan pelanggan;
        public Driver driver;
        Chat c;
        string pengirim, penerima;
        public FormChat()
        {
            InitializeComponent();
        }

        private void buttonKeluar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void TampilChat()
        {
            listBoxChat.Items.Clear();
            c = new Chat(pelanggan, driver);
            c.BacaPesan();
            foreach (string c in c.ListChat)
            {
                listBoxChat.Items.Add(c);                
            }
        }
        private void TampilSeen()
        {
            foreach (string c in c.ListStatus)
            {
                labelSeen.Text = c;
            }
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

        private void FormChat_Load(object sender, EventArgs e)
        {
            Form from1 = Application.OpenForms["FormCekPesanan"];
            Form form2 = Application.OpenForms["FormListPengiriman"];
            if (from1 == null && form2 != null)
            {
                FormListPengiriman form = (FormListPengiriman)Owner;
                driver = form.driver;
                pengirim = "Driver";
                penerima = "Pelanggan";
            }
            else
            {
                FormCekPesanan frm = (FormCekPesanan)Owner;
                pelanggan = frm.pelanggan;
                pengirim = "Pelanggan";
                penerima = "Driver";
            }
            TampilChat();
            c.UpdateData(penerima);
            c.BacaStatus(pengirim);
            TampilSeen();
        }

        private void buttonKirimChat_Click(object sender, EventArgs e)
        {
            int hasil = c.TambahPesan(textBoxChat.Text,pengirim);
            if (hasil <=0)
            {
                MessageBox.Show("Chat is missing");
            }
            FormChat_Load(sender, e);
            TampilChat();
            textBoxChat.Clear();
            textBoxChat.Focus();
        }
    }
}
