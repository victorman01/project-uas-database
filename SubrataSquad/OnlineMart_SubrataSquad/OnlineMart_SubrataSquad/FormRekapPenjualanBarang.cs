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
    public partial class FormRekapPenjualanBarang : Form
    {
        List<BarangOrder> listBarangOrder = new List<BarangOrder>();
        List<Order> listOrder = new List<Order>();
        List<Cabang> listCabang = new List<Cabang>();

        public FormRekapPenjualanBarang()
        {
            InitializeComponent();
        }

        private void buttonKeluar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormRekapPenjualanBarang_Load(object sender, EventArgs e)
        {
            FormatDataGrid();
            listBarangOrder = BarangOrder.BacaData("", "");
            listOrder = Order.BacaData("", "");
            listCabang = Cabang.BacaData("", "");
            comboBoxCabang.DataSource = listCabang;
            comboBoxCabang.DisplayMember = "Nama";

            comboBoxBulan.SelectedIndex = 0;

            TampilDataGrid();
        }

        private void FormatDataGrid()
        {
            dataGridViewRekapPenjualanBarang.DataSource = null;
            dataGridViewRekapPenjualanBarang.Columns.Clear();

            //Atur Tabel
            dataGridViewRekapPenjualanBarang.Columns.Add("tanggal", "Tanggal");
            dataGridViewRekapPenjualanBarang.Columns.Add("cabang", "Cabang");
            dataGridViewRekapPenjualanBarang.Columns.Add("barang", "Barang");
            dataGridViewRekapPenjualanBarang.Columns.Add("jumlah", "Jumlah");
            dataGridViewRekapPenjualanBarang.Columns.Add("subTotal", "Sub Total");


            //Atur Ukuran Cell
            dataGridViewRekapPenjualanBarang.Columns["tanggal"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewRekapPenjualanBarang.Columns["cabang"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewRekapPenjualanBarang.Columns["barang"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewRekapPenjualanBarang.Columns["jumlah"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewRekapPenjualanBarang.Columns["subTotal"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            //Batasi Aktivitas User
            dataGridViewRekapPenjualanBarang.AllowUserToAddRows = false;
            dataGridViewRekapPenjualanBarang.ReadOnly = true;
        }

        private void TampilDataGrid()
        {
            dataGridViewRekapPenjualanBarang.Rows.Clear();

            if (listOrder.Count > 0)
            {
                foreach (Order order in listOrder)
                {
                    foreach (BarangOrder barangOrder in listBarangOrder)
                    {
                        dataGridViewRekapPenjualanBarang.Rows.Add(order.TanggalWaktu, order.Cabang.Nama, barangOrder.Barang.Nama, barangOrder.Jumlah, barangOrder.Jumlah*int.Parse(barangOrder.Harga));
                    }
                }
            }
            else
            {
                dataGridViewRekapPenjualanBarang.DataSource = null;
            }
        }

        private void Filter()
        {
            int bulan = 0;
            switch (comboBoxBulan.Text)
            {
                case "Semua Bulan":
                    bulan = 0;
                    break;
                case "Januari":
                    bulan = 1;
                    break;
                case "Februari":
                    bulan = 2;
                    break;
                case "Maret":
                    bulan = 3;
                    break;
                case "April":
                    bulan = 4;
                    break;
                case "Mei":
                    bulan = 5;
                    break;
                case "Juni":
                    bulan = 6;
                    break;
                case "Juli":
                    bulan = 7;
                    break;
                case "Agustus":
                    bulan = 8;
                    break;
                case "September":
                    bulan = 9;
                    break;
                case "Oktober":
                    bulan = 10;
                    break;
                case "November":
                    bulan = 11;
                    break;
                case "Desember":
                    bulan = 12;
                    break;
            }
            listOrder = Order.BacaData(comboBoxCabang.Text, "", bulan, numericUpDownTahun.Value.ToString());
            TampilDataGrid();
        }

        private void comboBoxCabang_SelectedIndexChanged(object sender, EventArgs e)
        {
            Filter();
        }

        private void comboBoxBulan_SelectedIndexChanged(object sender, EventArgs e)
        {
            Filter();
        }

        private void numericUpDownTahun_ValueChanged(object sender, EventArgs e)
        {
            Filter();
        }
    }
}
