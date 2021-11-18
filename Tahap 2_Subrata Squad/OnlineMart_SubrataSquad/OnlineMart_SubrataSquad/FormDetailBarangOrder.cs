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
    public partial class FormDetailBarangOrder : Form
    {
        public string id;
        List<BarangOrder> listBarangOrder = new List<BarangOrder>();
        public FormDetailBarangOrder()
        {
            InitializeComponent();
        }

        private void FormDetailBarangOrder_Load(object sender, EventArgs e)
        {
            FormHistory frm = new FormHistory();
            listBarangOrder = BarangOrder.BacaData("o.Id", id);
            FormatDataGrid();
        }

        public void FormatDataGrid()
        {
            dataGridViewHistory.DataSource = null;
            dataGridViewHistory.Columns.Clear();

            //Atur Tabel
            dataGridViewHistory.Columns.Add("Id", "Id");
            dataGridViewHistory.Columns.Add("Jumlah", "Jumlah");
            dataGridViewHistory.Columns.Add("Harga", "Harga");

            //Atur Ukuran Cell
            dataGridViewHistory.Columns["Id"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewHistory.Columns["Jumlah"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewHistory.Columns["Harga"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            //Batasi Aktivitas User
            dataGridViewHistory.AllowUserToAddRows = false;
            dataGridViewHistory.ReadOnly = true;

            TampilDataGrid();
        }
        public void TampilDataGrid()
        {
            dataGridViewHistory.Rows.Clear();

            if (listBarangOrder.Count > 0)
            {
                foreach (BarangOrder bo in listBarangOrder)
                {
                    dataGridViewHistory.Rows.Add(bo.Barang.Nama, bo.Jumlah, bo.Harga);
                }
            }
            else
            {
                dataGridViewHistory.DataSource = null;
            }
        }

        private void buttonKeluar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
