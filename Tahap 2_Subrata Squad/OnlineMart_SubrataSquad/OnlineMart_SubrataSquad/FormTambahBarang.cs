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
    public partial class FormTambahBarang : Form
    {
        public List<Barang> listBarang = new List<Barang>();
        public List<Kategori> listKategori = new List<Kategori>();

        public FormTambahBarang()
        {
            InitializeComponent();
        }

        private void buttonKeluar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBoxHargaBarang_Enter(object sender, EventArgs e)
        {
            if (textBoxHargaBarang.Text == "Type Here...")
            {
                textBoxHargaBarang.Text = "";
                textBoxHargaBarang.ForeColor = Color.Black;
                textBoxHargaBarang.Font = new Font("Tahoma", 10, FontStyle.Regular);
            }
        }

        private void textBoxHargaBarang_Leave(object sender, EventArgs e)
        {
            if (textBoxHargaBarang.Text == "")
            {
                textBoxHargaBarang.Text = "Type Here...";
                textBoxHargaBarang.ForeColor = Color.Silver;
                textBoxHargaBarang.Font = new Font("Tahoma", 10, FontStyle.Italic);
            }
        }

        private void textBoxNamaBarang_Enter(object sender, EventArgs e)
        {
            if (textBoxNamaBarang.Text == "Type Here...")
            {
                textBoxNamaBarang.Text = "";
                textBoxNamaBarang.ForeColor = Color.Black;
                textBoxNamaBarang.Font = new Font("Tahoma", 10, FontStyle.Regular);
            }
        }

        private void textBoxNamaBarang_Leave(object sender, EventArgs e)
        {
            if (textBoxNamaBarang.Text == "")
            {
                textBoxNamaBarang.Text = "Type Here...";
                textBoxNamaBarang.ForeColor = Color.Silver;
                textBoxNamaBarang.Font = new Font("Tahoma", 10, FontStyle.Italic);
            }
        }

        private void FormPengaturanBarang_Load(object sender, EventArgs e)
        {

        }

        private void buttonKosongi_Click(object sender, EventArgs e)
        {
            textBoxNamaBarang.Text = "";
            textBoxHargaBarang.Text = "";
            textBoxNamaBarang.Focus();
        }

        private void buttonTambah_Click(object sender, EventArgs e)
        {
            try
            {
                Kategori kategoriDipilih = (Kategori)comboBoxKategoriBarang.SelectedItem;

                Barang b = new Barang(textBoxNamaBarang.Text, textBoxHargaBarang.Text, kategoriDipilih);

                Barang.TambahData(b);

                MessageBox.Show("Data Barang berhasil ditambahkan", "Informasi");

                //FormPengaturanBarang frm = (FormPengaturanBarang)this.Owner;
                FormTambahBarang_Load(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Data barang gagal ditambahkan. Pesan kesalahan : " + ex.Message,
                    "Kesalahan");
            }
        }

        public void FormTambahBarang_Load(object sender, EventArgs e)
        {
            //Kategori
            listKategori = Kategori.BacaData("", "");

            comboBoxKategoriBarang.DataSource = listKategori;
            comboBoxKategoriBarang.DisplayMember = "Nama";

            comboBoxKategoriBarang.DropDownStyle = ComboBoxStyle.DropDownList;

            //Barang
            listBarang = Barang.BacaData("", "");
            if (listBarang.Count > 0)
            {
                dataGridViewBarang.DataSource = listBarang;

                if (!dataGridViewBarang.Columns.Contains("btnUbahGrid"))
                {
                    DataGridViewButtonColumn bcol = new DataGridViewButtonColumn();
                    bcol.HeaderText = "Aksi";
                    bcol.Text = "Ubah";
                    bcol.Name = "btnUbahGrid";
                    bcol.UseColumnTextForButtonValue = true;
                    dataGridViewBarang.Columns.Add(bcol);

                    DataGridViewButtonColumn bcol2 = new DataGridViewButtonColumn();
                    bcol2.HeaderText = "Aksi";
                    bcol2.Text = "Hapus";
                    bcol2.Name = "btnHapusGrid";
                    bcol2.UseColumnTextForButtonValue = true;
                    dataGridViewBarang.Columns.Add(bcol2);
                }
            }
            else
            {
                dataGridViewBarang.DataSource = null;
            }
        }

        private void dataGridViewBarang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string idBarang = dataGridViewBarang.CurrentRow.Cells["id"].Value.ToString();
            string namaBarang = dataGridViewBarang.CurrentRow.Cells["nama"].Value.ToString();
            string hargaBarang = dataGridViewBarang.CurrentRow.Cells["harga"].Value.ToString();

            if (e.ColumnIndex == dataGridViewBarang.Columns["btnHapusGrid"].Index && e.RowIndex >= 0)
            {
                DialogResult hasil = MessageBox.Show(this, "Are you sure? " + idBarang +
                    " - " + namaBarang + " ?", "HAPUS", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (hasil == DialogResult.Yes)
                {
                    Boolean hapus = Barang.HapusData(idBarang);
                    if (hapus == true)
                    {
                        MessageBox.Show("Delete success");
                        FormTambahBarang_Load(sender, e);
                    }
                    else
                    {
                        MessageBox.Show("Delete failed");
                    }
                }
            }
            else
            {
                FormUbahBarang frm = new FormUbahBarang();
                frm.Owner = this;
                frm.textBoxIDBarang.Text = idBarang;
                frm.textBoxNamaBarang.Text = namaBarang;
                frm.textBoxHargaBarang.Text = hargaBarang;
                frm.Show();
            }
        }
    }
}
