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
    public partial class FormBarang : Form
    {
        List<CabangBarang> listCabangBarang = new List<CabangBarang>();
        List<Cabang> listCabang = new List<Cabang>();
        public Pelanggan pelanggan;

        public FormBarang()
        {
            InitializeComponent();
        }

        private void buttonKeluar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBoxBarang_Enter(object sender, EventArgs e)
        {
            if (textBoxBarang.Text == "Type Here...")
            {
                textBoxBarang.Text = "";
                textBoxBarang.ForeColor = Color.Black;
                textBoxBarang.Font = new Font("Tahoma", 11, FontStyle.Regular);
            }
        }

        private void textBoxBarang_Leave(object sender, EventArgs e)
        {
            if (textBoxBarang.Text == "")
            {
                textBoxBarang.Text = "Type Here...";
                textBoxBarang.ForeColor = Color.Silver;
                textBoxBarang.Font = new Font("Tahoma", 11, FontStyle.Italic);
            }
        }

        private void FormBarang_Load(object sender, EventArgs e)
        {
            listCabangBarang = CabangBarang.BacaData("", "");
            listCabang = Cabang.BacaData("", "");

            comboBoxCabang.DataSource = listCabang;
            comboBoxCabang.DisplayMember = "Nama";

            if (listCabangBarang.Count > 0)
            {
                if (!dataGridViewBarang.Columns.Contains("btnTambahGrid"))
                {
                    DataGridViewButtonColumn bcol = new DataGridViewButtonColumn();
                    bcol.HeaderText = "Aksi";
                    bcol.Text = "Tambah";
                    bcol.Name = "btnTambahGrid";
                    bcol.UseColumnTextForButtonValue = true;
                    dataGridViewBarang.Columns.Add(bcol);
                }
            }
            else
            {
                dataGridViewBarang.DataSource = null;
            }
        }

        private void textBoxBarang_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonKeranjang_Click(object sender, EventArgs e)
        {
            FormKeranjang frm = new FormKeranjang();
            frm.Owner = this;
            frm.ShowDialog();
        }
        public void FormatDataGrid()
        {
            dataGridViewBarang.DataSource = null;
            dataGridViewBarang.Columns.Clear();

            //Atur Tabel
            dataGridViewBarang.Columns.Add("Id", "Id");
            dataGridViewBarang.Columns.Add("Nama", "Nama");
            dataGridViewBarang.Columns.Add("Harga", "Harga");
            dataGridViewBarang.Columns.Add("Kategori", "Kategori");

            //Atur Ukuran Cell
            dataGridViewBarang.Columns["id"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewBarang.Columns["Nama"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewBarang.Columns["Harga"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewBarang.Columns["Kategori"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            //Buat Button Aksi
            DataGridViewButtonColumn bcol = new DataGridViewButtonColumn();
            bcol.HeaderText = "Aksi";
            bcol.Text = "Tambah";
            bcol.Name = "btnTambahGrid";
            bcol.UseColumnTextForButtonValue = true;
            dataGridViewBarang.Columns.Add(bcol);

            //Batasi Aktivitas User
            dataGridViewBarang.AllowUserToAddRows = false;
            dataGridViewBarang.ReadOnly = true;
        }
        public void TampilDataGrid()
        {
            dataGridViewBarang.Rows.Clear();

            if (listCabangBarang.Count > 0)
            {
                foreach (CabangBarang cb in listCabangBarang)
                {
                    if(cb.Cabang.Nama == comboBoxCabang.SelectedValue.ToString())
                    {
                        dataGridViewBarang.Rows.Add(cb.Barang.Id, cb.Barang.Nama, cb.Barang.Harga, cb.Barang.Kategori.Nama);
                    }
                }
            }
            else
            {
                dataGridViewBarang.DataSource = null;
            }
        }

        private void dataGridViewBarang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string id = dataGridViewBarang.CurrentRow.Cells["Id"].Value.ToString();
            string nama = dataGridViewBarang.CurrentRow.Cells["Nama"].Value.ToString();
            string harga = dataGridViewBarang.CurrentRow.Cells["Harga"].Value.ToString();
            string kategori = dataGridViewBarang.CurrentRow.Cells["Kategori"].Value.ToString();

            if (e.ColumnIndex == dataGridViewBarang.Columns["btnTambahGrid"].Index && e.RowIndex >= 0)
            {
                FormTambahBarangKeKeranjang frm = new FormTambahBarangKeKeranjang();
                frm.labelIdBarang.Text = id;
                frm.labelNamaBarang.Text = nama;
                frm.labelHargaBarang.Text = harga;
                frm.labelKategoriBarang.Text = kategori;
                frm.pelanggan = pelanggan;

                frm.Owner = this;
                frm.ShowDialog();
            }
        }

        private void comboBoxBarang_SelectedIndexChanged(object sender, EventArgs e)
        {
            FormatDataGrid();
            foreach(Cabang c in listCabang)
            {
                if (comboBoxCabang.SelectedValue.ToString() == c.Nama)
                {
                    CabangBarang.BacaData("C.Id", c.Id.ToString());
                }
            }
            TampilDataGrid();
        }
    }
}
