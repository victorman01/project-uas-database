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
        public Order order;
        public Pelanggan pelanggan;
        public Driver driver;
        public FormChat()
        {
            InitializeComponent();
        }

        private void FormChat_Load(object sender, EventArgs e)
        {
            //FormUtama frm = (FormUtama)this.Owner;
            //if(frm.listChat.Count >= 0)
            //{
            //    foreach(Chat c in frm.listChat)
            //    {
            //        if(c.IdPelanggan == order.Pelanggan.Id && c.IdDriver == order.Driver.Id)
            //        {
            //            if (c.Chats.Contains(order.Pelanggan.Nama))
            //            {
            //                listBoxChat.Items.Add(c.Chats);
            //            }
            //            else if(c.Chats == order.Driver.Nama)
            //            {
            //                listBoxChat.Items.Add(c.Chats);
            //            }
            //        }
            //    }
            //}
        }

        private void buttonKirim_Click(object sender, EventArgs e)
        {
            //FormUtama frm = (FormUtama)this.Owner;
            //if (pelanggan != null)
            //{
            //    listBoxChat.Items.Add(pelanggan.Nama + ":" +  textBoxChat.Text);
            //    Chat chat = new Chat(order.Pelanggan.Id, order.Driver.Id, pelanggan.Nama + ":" + textBoxChat.Text);
            //    frm.listChat.Add(chat);
            //}
            //else if (driver != null)
            //{
            //    listBoxChat.Items.Add(driver.Nama + ": " + textBoxChat.Text);
            //    Chat chat = new Chat(order.Pelanggan.Id, order.Driver.Id, driver.Nama + ":" + textBoxChat.Text);
            //    frm.listChat.Add(chat);
            //}
        }

        private void buttonKeluar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
