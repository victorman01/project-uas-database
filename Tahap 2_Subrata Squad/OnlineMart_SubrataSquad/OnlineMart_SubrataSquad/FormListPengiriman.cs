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
        public Driver driver;
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
            dataGridViewListPengiriman.Columns.Add("id", "Order ID");
            dataGridViewListPengiriman.Columns.Add("tanggal_waktu", "Tanggal");
            dataGridViewListPengiriman.Columns.Add("pelanggans_id", "Nama Pelanggan");
            dataGridViewListPengiriman.Columns.Add("alamat_tujuan", "Alamat Tujuan");
            dataGridViewListPengiriman.Columns.Add("ongkos_kirim", "Ongkos Kirim");
            dataGridViewListPengiriman.Columns.Add("status_kirim", "Status Kirim");


            //Atur Ukuran Cell
            dataGridViewListPengiriman.Columns["id"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewListPengiriman.Columns["tanggal_waktu"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewListPengiriman.Columns["pelanggans_id"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewListPengiriman.Columns["alamat_tujuan"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewListPengiriman.Columns["ongkos_kirim"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewListPengiriman.Columns["status_kirim"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            //Agar rata kanan
            dataGridViewListPengiriman.Columns["ongkos_kirim"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            //Agar komisi ditampilkan dengan format pemisah ribuan (1000 delimiter)
            dataGridViewListPengiriman.Columns["ongkos_kirim"].DefaultCellStyle.Format = "#,###";

            //Buat Button Aksi
            DataGridViewButtonColumn bcol = new DataGridViewButtonColumn();
            bcol.HeaderText = "Aksi";
            bcol.Text = "Detail";
            bcol.Name = "btnDetailGrid";
            bcol.UseColumnTextForButtonValue = true;
            dataGridViewListPengiriman.Columns.Add(bcol);

            DataGridViewButtonColumn bcol2 = new DataGridViewButtonColumn();
            bcol2.HeaderText = "Aksi";
            bcol2.Text = "Chat";
            bcol2.Name = "btnChat";
            bcol2.UseColumnTextForButtonValue = true;
            dataGridViewListPengiriman.Columns.Add(bcol2);

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
                    dataGridViewListPengiriman.Rows.Add(o.Id, o.TanggalWaktu.ToString("yyyy-MM-dd"), 
                        o.Pelanggan.Nama, o.AlamatTujuan, o.OngkosKirim, o.StatusKirim);
                }
            }
            else
            {
                dataGridViewListPengiriman.DataSource = null;
            }
        }

        public void FormListPengiriman_Load(object sender, EventArgs e)
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
            string idOrder = dataGridViewListPengiriman.CurrentRow.Cells["id"].Value.ToString();
            string tanggal = dataGridViewListPengiriman.CurrentRow.Cells["tanggal_waktu"].Value.ToString();
            string namaKonsumen = dataGridViewListPengiriman.CurrentRow.Cells["pelanggans_id"].Value.ToString();
            string alamatKonsumen = dataGridViewListPengiriman.CurrentRow.Cells["alamat_tujuan"].Value.ToString();
            float ongkoskirim = float.Parse(dataGridViewListPengiriman.CurrentRow.Cells["ongkos_kirim"].Value.ToString());
            string statusKirim = dataGridViewListPengiriman.CurrentRow.Cells["status_kirim"].Value.ToString();
            if (e.ColumnIndex == dataGridViewListPengiriman.Columns["btnDetailGrid"].Index && e.RowIndex >= 0)
            {
                if(statusKirim == "Accepted" || statusKirim == "Declined")
                {
                    MessageBox.Show("You've been chosen this section");
                }
                else if(statusKirim == "Waiting")
                {
                    FormListPengirimanDetail frm = new FormListPengirimanDetail();
                    frm.Owner = this;
                    frm.textBoxIDOrder.Text = idOrder;
                    frm.textBoxNamaKonsumen.Text = namaKonsumen;
                    frm.textBoxAlamatTujuan.Text = alamatKonsumen;
                    frm.textBoxKomisi.Text = Order.KomisiDriver(ongkoskirim).ToString();
                    frm.ShowDialog();
                }
                
            }
            else if (e.ColumnIndex == dataGridViewListPengiriman.Columns["btnChat"].Index && e.RowIndex >= 0)
            {
                FormChat frm = new FormChat();
                foreach (Order o in listOrder)
                {
                    if (o.Id == int.Parse(idOrder))
                    {
                        frm.order = o;
                        frm.driver = driver;
                        frm.pelanggan = null;
                    }
                }
                frm.Show();
            }
        }
    }
}
