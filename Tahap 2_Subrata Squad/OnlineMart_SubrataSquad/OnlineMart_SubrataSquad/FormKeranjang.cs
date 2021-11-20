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
    public partial class FormKeranjang : Form
    {
        public Pelanggan pelanggan;
        public List<Barang> listBarang = new List<Barang>();
        public List<Cabang> listCabang = new List<Cabang>();
        public List<Keranjang> listKeranjang = new List<Keranjang>();

        public FormKeranjang()
        {
            InitializeComponent();
        }

        private void buttonKeluar_Click(object sender, EventArgs e)
            {
            this.Close();
        }

        private void buttonCheckout_Click(object sender, EventArgs e)
        {
            FormCheckout form = new FormCheckout();
            form.Owner = this;
            form.ShowDialog();
        }

        public void FormKeranjang_Load(object sender, EventArgs e)
        {
            FormatDataGrid();
            listKeranjang = Keranjang.BacaData(pelanggan.Id);

            listBarang = Barang.BacaData("", "");
            listCabang = Cabang.BacaData("", "");

            TampilDataGrid();
        }

        public void FormatDataGrid()
        {
            dataGridViewKeranjang.DataSource = null;
            dataGridViewKeranjang.Columns.Clear();

            //Atur Tabel
            dataGridViewKeranjang.Columns.Add("Barang", "Barang");
            dataGridViewKeranjang.Columns.Add("Cabang", "Cabang");
            dataGridViewKeranjang.Columns.Add("Jumlah", "Jumlah");

            //Atur Ukuran Cell
            dataGridViewKeranjang.Columns["Barang"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewKeranjang.Columns["Cabang"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewKeranjang.Columns["Jumlah"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            //Buat Button Aksi
            DataGridViewButtonColumn bcol = new DataGridViewButtonColumn();
            bcol.HeaderText = "Aksi";
            bcol.Text = "Hapus";
            bcol.Name = "btnHapus";
            bcol.UseColumnTextForButtonValue = true;
            dataGridViewKeranjang.Columns.Add(bcol);

            DataGridViewButtonColumn bcol2 = new DataGridViewButtonColumn();
            bcol2.HeaderText = "Aksi";
            bcol2.Text = "Ubah";
            bcol2.Name = "btnUbah";
            bcol2.UseColumnTextForButtonValue = true;
            dataGridViewKeranjang.Columns.Add(bcol2);

            //Batasi Aktivitas User
            dataGridViewKeranjang.AllowUserToAddRows = false;
            dataGridViewKeranjang.ReadOnly = true;
        }
        public void TampilDataGrid()
        {
            dataGridViewKeranjang.Rows.Clear();

            if (listKeranjang.Count > 0)
            {
                foreach (Keranjang k in listKeranjang)
                {
                    dataGridViewKeranjang.Rows.Add(k.Barang.Nama, k.Cabang.Nama, k.Jumlah);
                }
            }
            else
            {
                dataGridViewKeranjang.DataSource = null;
            }
        }

        private void dataGridViewKeranjang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string namaBarang = dataGridViewKeranjang.CurrentRow.Cells["Barang"].Value.ToString();
            string namaCabang = dataGridViewKeranjang.CurrentRow.Cells["Cabang"].Value.ToString();
            string jumlah = dataGridViewKeranjang.CurrentRow.Cells["Jumlah"].Value.ToString();
            Keranjang ker = new Keranjang();

            if (e.ColumnIndex == dataGridViewKeranjang.Columns["btnHapus"].Index && e.RowIndex >= 0)
            {
                DialogResult hasil = MessageBox.Show(this, "Are you sure? ", "HAPUS", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (hasil == DialogResult.Yes)
                {

                    foreach (Barang b in listBarang)
                    {
                        foreach (Cabang c in listCabang)
                        {
                            if (b.Nama == namaBarang && c.Nama == namaCabang)
                            {
                                ker = new Keranjang(pelanggan, b, c, int.Parse(jumlah));
                            }
                        }
                    }
                    Boolean hapus = Keranjang.HapusKeranjang(ker);
                    if (hapus == true)
                    {
                        MessageBox.Show("Deletion success");

                        FormKeranjang_Load(sender, e);
                    }
                    else
                    {
                        MessageBox.Show("Deletion failed");
                    }
                }
            }
            else if (e.ColumnIndex == dataGridViewKeranjang.Columns["btnUbah"].Index && e.RowIndex >= 0)
            {
                FormUbahJumlahBarang formUbahJumlahBarang = new FormUbahJumlahBarang();
                formUbahJumlahBarang.Owner = this;
                formUbahJumlahBarang.textBoxBarang.Text = namaBarang;
                formUbahJumlahBarang.textBoxCabang.Text = namaCabang;
                formUbahJumlahBarang.textBoxJumlah.Text = jumlah;
                formUbahJumlahBarang.ShowDialog();
            }
        }
    }
}
