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
    public partial class FormRekapPendapatan : Form
    {
        public List<Order> listOrder = new List<Order>();
        public FormRekapPendapatan()
        {
            InitializeComponent();
        }

        private void buttonKeluar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBoxCBListPendapatan_Enter(object sender, EventArgs e)
        {
            if (textBoxCBListPendapatan.Text == "Type Here...")
            {
                textBoxCBListPendapatan.Text = "";
                textBoxCBListPendapatan.ForeColor = Color.Black;
                textBoxCBListPendapatan.Font = new Font("Tahoma", 10, FontStyle.Regular);
            }
        }

        private void textBoxCBListPendapatan_Leave(object sender, EventArgs e)
        {
            if (textBoxCBListPendapatan.Text == "")
            {
                textBoxCBListPendapatan.Text = "Type Here...";
                textBoxCBListPendapatan.ForeColor = Color.Silver;
                textBoxCBListPendapatan.Font = new Font("Tahoma", 10, FontStyle.Italic);
            }
        }

        private void FormRekapPendapatan_Load(object sender, EventArgs e)
        {
            FormatDataGrid();
            listOrder = Order.BacaData("", "");
            TampilDataGrid();
        }

        public void TampilDataGrid()
        {
            dataGridViewRekapPendapatan.Rows.Clear();

            if (listOrder.Count > 0)
            {
                foreach (Order o in listOrder)
                {
                    dataGridViewRekapPendapatan.Rows.Add(o.Id, o.TanggalWaktu.ToString("yyyy-MM-dd"),
                        o.Pelanggan.Nama, o.AlamatTujuan, (o.OngkosKirim * 0.8));
                }
            }
            else
            {
                dataGridViewRekapPendapatan.DataSource = null;
            }
        }

        public void FormatDataGrid()
        {
            dataGridViewRekapPendapatan.DataSource = null;
            dataGridViewRekapPendapatan.Columns.Clear();

            //Atur Tabel
            dataGridViewRekapPendapatan.Columns.Add("id", "Order ID");
            dataGridViewRekapPendapatan.Columns.Add("tanggal_waktu", "Tanggal");
            dataGridViewRekapPendapatan.Columns.Add("pelanggans_id", "Nama Pelanggan");
            dataGridViewRekapPendapatan.Columns.Add("alamat_tujuan", "Alamat Tujuan");
            dataGridViewRekapPendapatan.Columns.Add("komisi", "Komisi");


            //Atur Ukuran Cell
            dataGridViewRekapPendapatan.Columns["id"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewRekapPendapatan.Columns["tanggal_waktu"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewRekapPendapatan.Columns["pelanggans_id"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewRekapPendapatan.Columns["alamat_tujuan"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewRekapPendapatan.Columns["komisi"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            //Agar rata kanan
            dataGridViewRekapPendapatan.Columns["komisi"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            //Agar komisi ditampilkan dengan format pemisah ribuan (1000 delimiter)
            dataGridViewRekapPendapatan.Columns["komisi"].DefaultCellStyle.Format = "#,###";

            //Batasi Aktivitas User
            dataGridViewRekapPendapatan.AllowUserToAddRows = false;
            dataGridViewRekapPendapatan.ReadOnly = true;
        }

        private void textBoxCBListPendapatan_TextChanged(object sender, EventArgs e)
        {
            FormatDataGrid();
            if (comboBoxCBListPendapatan.Text == "ID Order")
            {
                listOrder = Order.BacaData("o.Id", textBoxCBListPendapatan.Text);
            }
            TampilDataGrid();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            listOrder = Order.BacaData("o.Id", textBoxCBListPendapatan.Text);
        }
    }
}
