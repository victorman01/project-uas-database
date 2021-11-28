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
                if (textBoxNamaBarang.Text != "" && textBoxNamaBarang.Text != null && textBoxHargaBarang.Text != "" && textBoxHargaBarang.Text != null)
                {
                    Kategori kategoriDipilih = (Kategori)comboBoxKategoriBarang.SelectedItem;

                    Barang b = new Barang(textBoxNamaBarang.Text, textBoxHargaBarang.Text, kategoriDipilih);

                    Barang.TambahData(b);

                    MessageBox.Show("Item data added successfully.", "Information");

                    //FormPengaturanBarang frm = (FormPengaturanBarang)this.Owner;
                    FormTambahBarang_Load(sender, e);
                }
                else
                {
                    MessageBox.Show("Item data can't be empty.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Item data failed to add. Error Message : " + ex.Message,
                    "Failure");
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
