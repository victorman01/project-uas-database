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
        public List<Barang> listBarang = new List<Barang>();

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
            if (textBoxBarang.Text == "Search Here...")
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
                textBoxBarang.Text = "Search Here...";
                textBoxBarang.ForeColor = Color.Silver;
                textBoxBarang.Font = new Font("Tahoma", 11, FontStyle.Italic);
            }
        }

        private void FormBarang_Load(object sender, EventArgs e)
        {
            listBarang = Barang.BacaData("", "");

            if (listBarang.Count > 0)
            {
                dataGridViewBarang.DataSource = listBarang;

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
            if (comboBoxBarang.Text == "Nama Barang")
            {
                listBarang = Barang.BacaData("B.nama", textBoxBarang.Text);
            }
            else if (comboBoxBarang.Text == "Harga Barang")
            {
                listBarang = Barang.BacaData("B.harga", textBoxBarang.Text);
            }
            else if (comboBoxBarang.Text == "Kategori Barang")
            {
                listBarang = Barang.BacaData("K.nama", textBoxBarang.Text);
            }

            if (listBarang.Count > 0)
            {
                dataGridViewBarang.DataSource = listBarang;
            }
        }

        private void buttonKeranjang_Click(object sender, EventArgs e)
        {
            FormKeranjang frm = new FormKeranjang();
            frm.Owner = this;
            frm.ShowDialog();
        }
    }
}
