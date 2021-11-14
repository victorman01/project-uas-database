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
    public partial class FormPengaturanBarang : Form
    {
        public List<CabangBarang> listCabangBarang = new List<CabangBarang>();

        public FormPengaturanBarang()
        {
            InitializeComponent();
        }

        private void dataGridViewPengaturanBarang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            string namaBarang = dataGridViewPengaturanBarang.CurrentRow.Cells["Barang"].Value.ToString();
            string namaCabang = dataGridViewPengaturanBarang.CurrentRow.Cells["Cabang"].Value.ToString();
            string stok = dataGridViewPengaturanBarang.CurrentRow.Cells["Stok"].Value.ToString();

            CabangBarang cB = new CabangBarang();
            foreach (CabangBarang cb in listCabangBarang)
            {
                if (cb.Barang.Nama == dataGridViewPengaturanBarang.CurrentRow.Cells["Barang"].Value.ToString() && cb.Cabang.Nama == dataGridViewPengaturanBarang.CurrentRow.Cells["Cabang"].Value.ToString())
                {
                    cB = cb;
                }
            }

            if (e.ColumnIndex == dataGridViewPengaturanBarang.Columns["btnHapusGrid"].Index && e.RowIndex >= 0)
            {
                DialogResult hasil = MessageBox.Show(this, "Are you sure? ", "HAPUS", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (hasil == DialogResult.Yes)
                {
                    Boolean hapus = CabangBarang.HapusStok(cB);
                    if (hapus == true)
                    {
                        MessageBox.Show("Deletion success");

                        FormPengaturanBarang_Load(sender, e);
                    }
                    else
                    {
                        MessageBox.Show("Deletion failed");
                    }
                }
            }
            else if (e.ColumnIndex == dataGridViewPengaturanBarang.Columns["btnUbahGrid"].Index && e.RowIndex >= 0)
            {
                FormUbahStok formUbahStok = new FormUbahStok();
                formUbahStok.Owner = this;
                formUbahStok.textBoxBarang.Text = namaBarang;
                formUbahStok.textBoxCabang.Text = namaCabang;
                formUbahStok.textBoxStok.Text = stok;
                formUbahStok.ShowDialog();
            }
        }

        private void buttonTambah_Click(object sender, EventArgs e)
        {
            FormTambahBarang formTambahBarang = new FormTambahBarang();
            formTambahBarang.Owner = this;
            formTambahBarang.ShowDialog();
        }
        
        private void buttonKeluar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void FormPengaturanBarang_Load(object sender, EventArgs e)
        {
            FormatDataGrid();
            listCabangBarang = CabangBarang.BacaData("", "");
            TampilDataGrid();
        }

        private void textBoxCBPengaturanBarang_TextChanged(object sender, EventArgs e)
        {
            FormatDataGrid();

            string kriteria = "";
            switch (comboBoxCBPengaturanBarang.Text)
            {
                case "Nama Cabang":
                    kriteria = "C.Nama";
                    break;
                case "Nama Barang":
                    kriteria = "B.Nama";
                    break;
            }
            if (textBoxCBPengaturanBarang.Text == "Type Here...")
            {
                listCabangBarang = CabangBarang.BacaData(kriteria, "");
            }
            else
            {
                listCabangBarang = CabangBarang.BacaData(kriteria, textBoxCBPengaturanBarang.Text);
            }

            TampilDataGrid();

        }

        public void FormatDataGrid()
        {
            dataGridViewPengaturanBarang.DataSource = null;
            dataGridViewPengaturanBarang.Columns.Clear();

            dataGridViewPengaturanBarang.Columns.Add("Barang", "Nama Barang");
            dataGridViewPengaturanBarang.Columns.Add("Kategori", "Kategori");
            dataGridViewPengaturanBarang.Columns.Add("Cabang", "Nama Cabang");
            dataGridViewPengaturanBarang.Columns.Add("Stok", "Jumlah Stok");

            dataGridViewPengaturanBarang.Columns["Barang"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewPengaturanBarang.Columns["Kategori"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewPengaturanBarang.Columns["Cabang"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewPengaturanBarang.Columns["Stok"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            dataGridViewPengaturanBarang.AllowUserToAddRows = false;
            dataGridViewPengaturanBarang.ReadOnly = true;
        }
        public void TampilDataGrid()
        {
            dataGridViewPengaturanBarang.Rows.Clear();

            if (listCabangBarang.Count > 0)
            {
                foreach (CabangBarang c in listCabangBarang)
                {
                    dataGridViewPengaturanBarang.Rows.Add(c.Barang.Nama, c.Barang.Kategori.Nama, c.Cabang.Nama, c.Stok);
                }
                
                if (!dataGridViewPengaturanBarang.Columns.Contains("btnUbahGrid"))
                {
                    DataGridViewButtonColumn bcol = new DataGridViewButtonColumn();
                    bcol.HeaderText = "Aksi";
                    bcol.Text = "Ubah";
                    bcol.Name = "btnUbahGrid";
                    bcol.UseColumnTextForButtonValue = true;
                    dataGridViewPengaturanBarang.Columns.Add(bcol);

                    DataGridViewButtonColumn bcol2 = new DataGridViewButtonColumn();
                    bcol2.HeaderText = "Aksi";
                    bcol2.Text = "Hapus";
                    bcol2.Name = "btnHapusGrid";
                    bcol2.UseColumnTextForButtonValue = true;
                    dataGridViewPengaturanBarang.Columns.Add(bcol2);
                }
            }
            else
            {
                dataGridViewPengaturanBarang.DataSource = null;
            }
        }

        private void textBoxCBPengaturanBarang_Enter(object sender, EventArgs e)
        {
            if (textBoxCBPengaturanBarang.Text == "Type Here...")
            {
                textBoxCBPengaturanBarang.Text = "";
                textBoxCBPengaturanBarang.ForeColor = Color.Black;
                textBoxCBPengaturanBarang.Font = new Font("Tahoma", 10, FontStyle.Regular);
            }
        }

        private void textBoxCBPengaturanBarang_Leave(object sender, EventArgs e)
        {
            if (textBoxCBPengaturanBarang.Text == "")
            {
                textBoxCBPengaturanBarang.Text = "Type Here...";
                textBoxCBPengaturanBarang.ForeColor = Color.Silver;
                textBoxCBPengaturanBarang.Font = new Font("Tahoma", 10, FontStyle.Italic);
            }
        }

        private void buttonTambahBarangCabang_Click(object sender, EventArgs e)
        {
            FormTambahStok frm = new FormTambahStok();
            frm.Owner = this;
            frm.Show();
        }
    }
}
