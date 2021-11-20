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
    public partial class FormCetakNota : Form
    {
        public Pelanggan pelanggan;
        string nilai;
        List<Order> listOrder = new List<Order>();

        public FormCetakNota()
        {
            InitializeComponent();
        }

        private void buttonKeluar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonCetak_Click(object sender, EventArgs e)
        {
            try
            {
                nilai = "pe.id";
                if (comboBoxCetak.Text == "PDF")
                {
                    Order.CetakNota(nilai, pelanggan.Id.ToString(), "daftarnota.txt", new Font("Courier New", 10));
                    MessageBox.Show("Print successful");
                }
                else if (comboBoxCetak.Text == "PRINT HARDCOPY")
                {
                    Order.CetakNota(nilai, pelanggan.Id.ToString(), "daftarnota.txt", new Font("Courier New", 10));
                    MessageBox.Show("Print successful");
                }
                else
                {
                    MessageBox.Show("Please Select Type File");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Print failed, Failure message : " + ex.Message);
            }
        }
        public void FormatDataGrid()
        {
            dataGridViewCetakNota.DataSource = null;
            dataGridViewCetakNota.Columns.Clear();

            //Atur Tabel
            dataGridViewCetakNota.Columns.Add("Id", "Id");
            dataGridViewCetakNota.Columns.Add("Tanggal", "Tanggal");
            dataGridViewCetakNota.Columns.Add("Alamat", "Alamat");
            dataGridViewCetakNota.Columns.Add("Ongkos Kirim", "Ongkos Kirim");
            dataGridViewCetakNota.Columns.Add("Total Bayar", "Total Bayar");
            dataGridViewCetakNota.Columns.Add("Cara Bayar", "Cara Bayar");
            dataGridViewCetakNota.Columns.Add("Cabang Id", "Cabang Id");
            dataGridViewCetakNota.Columns.Add("Driver Id", "Driver Id");
            dataGridViewCetakNota.Columns.Add("Pelanggan Id", "Pelanggan Id");
            dataGridViewCetakNota.Columns.Add("Promo Id", "Promo Id");
            dataGridViewCetakNota.Columns.Add("Status Id", "Status Id");
            dataGridViewCetakNota.Columns.Add("Metode Pembayaran Id", "Metode Pembayaran Id");
            dataGridViewCetakNota.Columns.Add("Status Kirim", "Status Kirim");

            //Atur Ukuran Cell
            dataGridViewCetakNota.Columns["Id"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCetakNota.Columns["Tanggal"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCetakNota.Columns["Alamat"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCetakNota.Columns["Ongkos Kirim"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCetakNota.Columns["Total Bayar"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCetakNota.Columns["Cara Bayar"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCetakNota.Columns["Cabang Id"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCetakNota.Columns["Driver Id"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCetakNota.Columns["Pelanggan Id"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCetakNota.Columns["Promo Id"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCetakNota.Columns["Status Id"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCetakNota.Columns["Metode Pembayaran Id"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCetakNota.Columns["Status Kirim"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            //Buat Button Aksi
            DataGridViewButtonColumn bcol = new DataGridViewButtonColumn();
            bcol.HeaderText = "Aksi";
            bcol.Text = "Cetak";
            bcol.Name = "btnCetakGrid";
            bcol.UseColumnTextForButtonValue = true;
            dataGridViewCetakNota.Columns.Add(bcol);

            //Batasi Aktivitas User
            dataGridViewCetakNota.AllowUserToAddRows = false;
            dataGridViewCetakNota.ReadOnly = true;
        }
        public void TampilDataGrid()
        {
            dataGridViewCetakNota.Rows.Clear();

            if (listOrder.Count > 0)
            {
                foreach (Order o in listOrder)
                {
                    dataGridViewCetakNota.Rows.Add(o.Id, o.TanggalWaktu.ToShortDateString(), o.AlamatTujuan, o.OngkosKirim, o.TotalBayar, o.CaraBayar, o.Cabang.Id, o.Driver.Id, o.Pelanggan.Id, o.Promo.Id, o.Status, o.MetodePembayaran, o.StatusKirim);
                }
            }
            else
            {
                dataGridViewCetakNota.DataSource = null;
            }
        }
        private void FormCetakNota_Load(object sender, EventArgs e)
        {
            FormatDataGrid();
            FormCekPesanan form = (FormCekPesanan)this.Owner;
            pelanggan = form.pelanggan;
            listOrder = Order.BacaData("pe.Nama", pelanggan.Nama);
            //listBarangOrder = BarangOrder.BacaData("", "");
            TampilDataGrid();
        }

        private void dataGridViewCetakNota_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string id = dataGridViewCetakNota.CurrentRow.Cells["Id"].Value.ToString();
            nilai = "o.id";

            if (e.ColumnIndex == dataGridViewCetakNota.Columns["btnCetakGrid"].Index && e.RowIndex >= 0)
            {
                Order.CetakNota(nilai, id, "Nota " + id + ".txt", new Font("Courier New", 10));
                MessageBox.Show("Print successful");
            }
        }
    }
}
