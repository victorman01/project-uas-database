﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OnlineMart_LIB;
using System.Globalization;

namespace OnlineMart_SubrataSquad
{
    public partial class FormCheckout : Form
    {
        List<Keranjang> listKeranjang = new List<Keranjang>();
        List<Promo> listPromo = new List<Promo>();
        List<MetodePembayaran> listMetodePemabayaran = new List<MetodePembayaran>();
        List<Driver> listDriver = new List<Driver>();
        Cabang cabang;
        int ongkir = 15000;
        int totalHarga = 0;
        int diskon = 0;

        public FormCheckout()
        {
            InitializeComponent();
        }

        private void FormCheckout_Load(object sender, EventArgs e)
        {
            FormatDataGrid();
            FormKeranjang formKeranjang = (FormKeranjang)Owner;
            listKeranjang = formKeranjang.listKeranjang;
            listPromo = Promo.BacaData("", "");
            listMetodePemabayaran = MetodePembayaran.BacaData("", "");
            listDriver = Driver.BacaData("", "");

            TampilDataGrid();
            totalHarga = Order.HitungTotalHarga(totalHarga, ongkir, diskon);
            labelOngkir.Text = ongkir.ToString("C0", new CultureInfo("id"));
            labelDiskon.Text = diskon.ToString("C0", new CultureInfo("id"));
            labelTotalHarga.Text = totalHarga.ToString("C0", new CultureInfo("id"));
        }

        public void FormatDataGrid()
        {
            dataGridViewDeals.DataSource = null;
            dataGridViewDeals.Columns.Clear();

            //Atur Tabel
            dataGridViewDeals.Columns.Add("barang", "Barang");
            dataGridViewDeals.Columns.Add("cabang", "Cabang");
            dataGridViewDeals.Columns.Add("jumlah", "Jumlah");
            dataGridViewDeals.Columns.Add("harga", "Harga");
            dataGridViewDeals.Columns.Add("subTotal", "Sub Total");


            //Atur Ukuran Cell
            dataGridViewDeals.Columns["barang"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewDeals.Columns["cabang"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewDeals.Columns["jumlah"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewDeals.Columns["harga"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewDeals.Columns["subTotal"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            //Batasi Aktivitas User
            dataGridViewDeals.AllowUserToAddRows = false;
            dataGridViewDeals.ReadOnly = true;
        }

        public void TampilDataGrid()
        {
            dataGridViewDeals.Rows.Clear();

            if (listKeranjang.Count > 0)
            {
                foreach (Keranjang k in listKeranjang)
                {
                    dataGridViewDeals.Rows.Add(k.Barang.Nama, k.Cabang.Nama, k.Jumlah, k.Barang.Harga, k.Jumlah*int.Parse(k.Barang.Harga));
                    totalHarga += k.Jumlah * int.Parse(k.Barang.Harga);
                }

            }
            else
            {
                dataGridViewDeals.DataSource = null;
            }
        }

        private void buttonBatal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonBayar_Click(object sender, EventArgs e)
        {
            try
            {
                FormKeranjang formKeranjang = (FormKeranjang)Owner;
                Pelanggan pelanggan = formKeranjang.pelanggan;
                foreach (Keranjang keranjang in listKeranjang)
                {
                    if (keranjang.Pelanggan.Id == pelanggan.Id)
                    {
                        Keranjang.KurangiStok(keranjang);
                        cabang = keranjang.Cabang;
                    }
                }

                Promo promo = (Promo)comboBoxPromo.SelectedItem;
                MetodePembayaran metodePembayaran = (MetodePembayaran)comboBoxPembayaran.SelectedItem;
                Driver driver = (Driver)comboBoxKurir.SelectedItem;
                Order order = new Order(textBoxAlamat.Text, ongkir, totalHarga, comboBoxCaraPembayaran.Text, cabang, driver, pelanggan, promo, "Pesanan diproses", metodePembayaran, "Waiting");
                Order.TambahData(order);
            }
            catch (Exception ex)
            {

                MessageBox.Show("Checkout Failed, Error Message : " + ex.Message,"Failure");
            }
        }

        private void comboBoxPromo_SelectedIndexChanged(object sender, EventArgs e)
        {
            totalHarga = 0;
            TampilDataGrid();
            Promo promo = (Promo)comboBoxPromo.SelectedItem;
            diskon = Promo.HitungDiskon(promo, totalHarga, listKeranjang);
            totalHarga = Order.HitungTotalHarga(totalHarga, ongkir, diskon);
            labelOngkir.Text = ongkir.ToString("C0", new CultureInfo("id"));
            labelDiskon.Text = diskon.ToString("C0", new CultureInfo("id"));
            labelTotalHarga.Text = totalHarga.ToString("C0", new CultureInfo("id"));
        }

        private void comboBoxPromo_Enter(object sender, EventArgs e)
        {
            comboBoxPromo.DataSource = listPromo;
            comboBoxPromo.DisplayMember = "Nama";
        }

        private void comboBoxPembayaran_Enter(object sender, EventArgs e)
        {
            comboBoxPembayaran.DataSource = listMetodePemabayaran;
            comboBoxPembayaran.DisplayMember = "Nama";
        }

        private void comboBoxKurir_Enter(object sender, EventArgs e)
        {
            comboBoxKurir.DataSource = listDriver;
            comboBoxKurir.DisplayMember = "Nama";
        }

        private void CheckBayar()
        {
            if(comboBoxKurir.SelectedValue != null && comboBoxPembayaran.SelectedValue != null)
            {
                buttonBayar.Enabled = true;
            }
            else
            {
                buttonBayar.Enabled = false;
            }
        }

        private void comboBoxPembayaran_SelectedIndexChanged(object sender, EventArgs e)
        {
            CheckBayar();
        }

        private void comboBoxKurir_SelectedIndexChanged(object sender, EventArgs e)
        {
            CheckBayar();
        }

    }
}
