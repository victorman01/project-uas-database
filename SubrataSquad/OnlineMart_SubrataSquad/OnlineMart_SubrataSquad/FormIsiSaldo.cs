﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OnlineMart_LIB;

namespace OnlineMart_SubrataSquad
{
    public partial class FormIsiSaldo : Form
    {
        public Pelanggan pelanggan;
        public List<MetodePembayaran> listMetodePembayaran = new List<MetodePembayaran>();

        public FormIsiSaldo()
        {
            InitializeComponent();
        }

        private void buttonIsi_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dR = MessageBox.Show("Are You Sure?", "Confirmation", MessageBoxButtons.YesNo);
                if (dR == DialogResult.Yes)
                {
                    FormUtama frm = (FormUtama)this.MdiParent;
                    float topUpAmount = float.Parse(textBoxJumlahPengisianSaldo.Text);
                    MetodePembayaran metodePembayaranDipilih = (MetodePembayaran)comboBoxAlatIsiSaldo.SelectedItem;
                    Pelanggan.UpdateSaldo(topUpAmount, pelanggan.Id);
                    pelanggan = Pelanggan.AmbilPelangganById(pelanggan.Id);

                    listBoxSaldo.Items.Clear();
                    listBoxSaldo.Items.Add("Name: " + pelanggan.Nama);
                    listBoxSaldo.Items.Add("Amount of Top up: " + topUpAmount.ToString("C0",new CultureInfo("id")));
                    listBoxSaldo.Items.Add("Payment Method: " + metodePembayaranDipilih);
                    listBoxSaldo.Items.Add("Saldo: " + pelanggan.Saldo.ToString("C0",new CultureInfo("id")));
                    RiwayatIsiSaldo ris = new RiwayatIsiSaldo(DateTime.Now, (int)topUpAmount, pelanggan);
                    RiwayatIsiSaldo.TambahData(ris);
                    frm.FormUtamaKonsumen_Load(sender, e);
                    MessageBox.Show("Top up success.", "Information");
                }
                else
                {
                    MessageBox.Show("Top up fail.", "Information");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Top up fail. Error message : " + ex.Message,
                     "Error");
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

        private void FormIsiSaldo_Load(object sender, EventArgs e)
        {
            pelanggan = Pelanggan.AmbilPelangganById(pelanggan.Id);
            listBoxSaldo.Items.Add("Name: " + pelanggan.Nama);
            listBoxSaldo.Items.Add("Saldo: " + pelanggan.Saldo.ToString("C0", new CultureInfo("id")));

            listMetodePembayaran = MetodePembayaran.BacaData("", "");

            foreach(MetodePembayaran mp in listMetodePembayaran)
            {
                if(mp.Nama != "OMA Saldo" && mp.Nama != "Cash")
                {
                    comboBoxAlatIsiSaldo.Items.Add(mp);
                }
            }
            comboBoxAlatIsiSaldo.DisplayMember = "Nama";
        }
    }
}
