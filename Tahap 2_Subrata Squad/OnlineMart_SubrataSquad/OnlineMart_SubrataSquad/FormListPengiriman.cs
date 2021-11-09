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
    public partial class FormListPengiriman : Form
    {
        public List<Order> listOrder = new List<Order>();
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

        public void FormatDataGrid()
        {
            dataGridViewListPengiriman .DataSource = null;
            dataGridViewListPengiriman.Columns.Clear();

            //Atur Tabel
            dataGridViewListPengiriman.Columns.Add("id", "Id Order");
            dataGridViewListPengiriman.Columns.Add("tanggal_waktu", "Tanggal Order");
            dataGridViewListPengiriman.Columns.Add("alamat_tujuan", "Alamat Tujuan");
            dataGridViewListPengiriman.Columns.Add("ongkos_kirim", "Ongkos Kirim");
            dataGridViewListPengiriman.Columns.Add("total_bayar", "Total Bayar");
            dataGridViewListPengiriman.Columns.Add("cara_bayar", "Cara Bayar");
            dataGridViewListPengiriman.Columns.Add("cabangs_id", "Id Cabang");
            dataGridViewListPengiriman.Columns.Add("drivers_id", "Id Driver");
            dataGridViewListPengiriman.Columns.Add("pelanggans_id", "Id Pelanggan");
            dataGridViewListPengiriman.Columns.Add("promo_id", "Id Promo");
            dataGridViewListPengiriman.Columns.Add("status", "Status");
            dataGridViewListPengiriman.Columns.Add("metode_pembayaran", "Metode Pembayaran");


            //Atur Ukuran Cell
            dataGridViewListPengiriman.Columns["id"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewListPengiriman.Columns["tanggal_waktu"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewListPengiriman.Columns["alamat_tujuan"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewListPengiriman.Columns["ongkos_kirim"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewListPengiriman.Columns["total_bayar"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewListPengiriman.Columns["cara_bayar"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewListPengiriman.Columns["cabangs_id"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewListPengiriman.Columns["drivers_id"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewListPengiriman.Columns["pelanggans_id"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewListPengiriman.Columns["promo_id"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewListPengiriman.Columns["status"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewListPengiriman.Columns["metode_pembayaran"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            //Buat Button Aksi
            DataGridViewButtonColumn bcol = new DataGridViewButtonColumn();
            bcol.HeaderText = "Aksi";
            bcol.Text = "Detail";
            bcol.Name = "btnDetailGrid";
            bcol.UseColumnTextForButtonValue = true;
            dataGridViewListPengiriman.Columns.Add(bcol);

            //Batasi Aktivitas User
            dataGridViewListPengiriman.AllowUserToAddRows = false;
            dataGridViewListPengiriman.ReadOnly = true;
        }
        public void TampilDataGrid()
        {
            dataGridViewListPengiriman.Rows.Clear();

            if (listOrder.Count > 0)
            {
                foreach (Order o in listOrder)
                {
                    dataGridViewListPengiriman.Rows.Add(o.Id, o.TanggalWaktu, o.AlamatTujuan, o.OngkosKirim, o.TotalBayar,o.CaraBayar,o.Cabang.Id,o.Driver.Id,o.Pelanggan.Id,o.Promo.Id,o.Status,o.MetodePembayaran);
                }
            }
            else
            {
                dataGridViewListPengiriman.DataSource = null;
            }
        }

        private void FormListPengiriman_Load(object sender, EventArgs e)
        {
            FormatDataGrid();
            listOrder = Order.BacaData("", "");
            TampilDataGrid();
        }

        private void textBoxCBListPengiriman_TextChanged(object sender, EventArgs e)
        {
            FormatDataGrid();
            if (comboBoxCBListPengiriman.Text == "ID Order")
            {
                listOrder = Order.BacaData("o.Id", textBoxCBListPengiriman.Text);
            }
            TampilDataGrid();
        }

        private void dataGridViewListPengiriman_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridViewListPengiriman.Columns["btnDetailGrid"].Index && e.RowIndex >= 0)
            {
                FormListPengirimanDetail frm = new FormListPengirimanDetail();
                frm.Owner = this;
                frm.ShowDialog();
            }
        }
    }
}
