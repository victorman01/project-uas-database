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
    public partial class FormTambahStok : Form
    {
        public List<Barang> listBarang = new List<Barang>();
        public List<Cabang> listCabang = new List<Cabang>();

        public FormTambahStok()
        {
            InitializeComponent();
        }

        private void buttonSimpan_Click(object sender, EventArgs e)
        {
            try
            {
                Cabang cabangDipilih = (Cabang)comboBoxCabang.SelectedItem;
                Barang barangDipilih = (Barang)comboBoxBarang.SelectedItem;

                CabangBarang cb = new CabangBarang(barangDipilih, int.Parse(barangDipilih.Harga),
                    barangDipilih.Kategori, cabangDipilih, int.Parse(textBoxStok.Text));

                CabangBarang.TambahStok(cb);

                MessageBox.Show("Data stok berhasil ditambahkan", "Informasi");

                FormPengaturanBarang frm = (FormPengaturanBarang)this.Owner;
                frm.FormPengaturanBarang_Load(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Data stok gagal ditambahkan. Pesan kesalahan : " + ex.Message,
                    "Kesalahan");
            }
        }

        private void buttonKeluar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormTambahStok_Load(object sender, EventArgs e)
        {
            listBarang = Barang.BacaData("", "");
            listCabang = Cabang.BacaData("", "");

            comboBoxBarang.DataSource = listBarang;
            comboBoxBarang.SelectedItem = "Nama";
            comboBoxCabang.DataSource = listCabang;
            comboBoxCabang.SelectedItem = "Nama";

            comboBoxBarang.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxCabang.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void textBoxStok_Enter(object sender, EventArgs e)
        {
            if (textBoxStok.Text == "Type Here...")
            {
                textBoxStok.Text = "";
                textBoxStok.ForeColor = Color.Black;
                textBoxStok.Font = new Font("Tahoma", 10, FontStyle.Regular);
            }
        }

        private void textBoxStok_Leave(object sender, EventArgs e)
        {
            if (textBoxStok.Text == "")
            {
                textBoxStok.Text = "Type Here...";
                textBoxStok.ForeColor = Color.Silver;
                textBoxStok.Font = new Font("Tahoma", 10, FontStyle.Italic);
            }
        }
    }
}
