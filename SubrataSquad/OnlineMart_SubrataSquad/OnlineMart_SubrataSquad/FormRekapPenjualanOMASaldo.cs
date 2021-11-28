using System;
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
    public partial class FormRekapPenjualanOMASaldo : Form
    {
        public List<RiwayatIsiSaldo> listPenjualanOMASaldo = new List<RiwayatIsiSaldo>();
        public FormRekapPenjualanOMASaldo()
        {
            InitializeComponent();
        }

        private void buttonKeluar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void FormatDataGrid()
        {
            dataGridViewRekapPenjualanOMA.DataSource = null;
            dataGridViewRekapPenjualanOMA.Columns.Clear();

            //Atur Tabel
            dataGridViewRekapPenjualanOMA.Columns.Add("WaktuPembelian", "Waktu Pembelian");
            dataGridViewRekapPenjualanOMA.Columns.Add("JumlahIsi", "Jumlah Isi");
            dataGridViewRekapPenjualanOMA.Columns.Add("Pelanggan", "Pelanggan");

            //Atur Ukuran Cell
            dataGridViewRekapPenjualanOMA.Columns["WaktuPembelian"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewRekapPenjualanOMA.Columns["JumlahIsi"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewRekapPenjualanOMA.Columns["Pelanggan"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            //Buat Button Aksi
            DataGridViewButtonColumn bcol = new DataGridViewButtonColumn();
            bcol.HeaderText = "Aksi";
            bcol.Text = "Detail";
            bcol.Name = "btnDetailGrid";
            bcol.UseColumnTextForButtonValue = true;
            dataGridViewRekapPenjualanOMA.Columns.Add(bcol);

            //Batasi Aktivitas User
            dataGridViewRekapPenjualanOMA.AllowUserToAddRows = false;
            dataGridViewRekapPenjualanOMA.ReadOnly = true;
        }
        public void TampilDataGrid()
        {
            dataGridViewRekapPenjualanOMA.Rows.Clear();

            if (listPenjualanOMASaldo.Count > 0)
            {
                foreach (RiwayatIsiSaldo ris in listPenjualanOMASaldo)
                {
                    dataGridViewRekapPenjualanOMA.Rows.Add(ris.Waktu, ris.IsiSaldo, ris.Pelanggan.Nama);
                }
            }
            else
            {
                dataGridViewRekapPenjualanOMA.DataSource = null;
            }
        }
        private void FormRekapPenjualanOMASaldo_Load(object sender, EventArgs e)
        {
            FormatDataGrid();
            listPenjualanOMASaldo = RiwayatIsiSaldo.BacaData("", "");
            TampilDataGrid();
        }

        private void dataGridViewRekapPenjualanOMA_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string tanggal = dataGridViewRekapPenjualanOMA.CurrentRow.Cells["WaktuPembelian"].Value.ToString();
            int jumlahIsi = (int)dataGridViewRekapPenjualanOMA.CurrentRow.Cells["JumlahIsi"].Value;
            string pelanggan = dataGridViewRekapPenjualanOMA.CurrentRow.Cells["Pelanggan"].Value.ToString();

            if (e.ColumnIndex == dataGridViewRekapPenjualanOMA.Columns["btnDetailGrid"].Index && e.RowIndex >= 0)
            {
                FormRekapPenjualanOMASaldoDetail frm = new FormRekapPenjualanOMASaldoDetail();
                frm.Owner = this;
                frm.labelTanggal.Text = tanggal;
                frm.labelJumlahIsi.Text = jumlahIsi.ToString("C0", new CultureInfo("id"));
                frm.labelPelanggan.Text = pelanggan;
                frm.Show();
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
            listPenjualanOMASaldo = RiwayatIsiSaldo.BacaData(numericUpDownTahun.Value.ToString(), bulan);
            TampilDataGrid();
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
