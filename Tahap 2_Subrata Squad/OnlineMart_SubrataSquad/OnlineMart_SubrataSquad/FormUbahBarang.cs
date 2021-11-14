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
    public partial class FormUbahBarang : Form
    {
        public List<Kategori> listKategori = new List<Kategori>();
        public FormUbahBarang()
        {
            InitializeComponent();
        }

        private void buttonKeluar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonSimpan_Click(object sender, EventArgs e)
        {
            try
            {
                if(textBoxNamaBarang.Text != "" && textBoxNamaBarang.Text != null && textBoxHargaBarang.Text != "" && textBoxHargaBarang.Text != null)
                {
                    Kategori kategoriDipilih = (Kategori)comboBoxKategori.SelectedItem;

                    Barang b = new Barang(int.Parse(textBoxIDBarang.Text), textBoxNamaBarang.Text, textBoxHargaBarang.Text, kategoriDipilih);

                    Barang.UbahData(b);

                    MessageBox.Show("Item data has been successfully changed.", "Information");

                    FormTambahBarang frm = (FormTambahBarang)this.Owner;
                    frm.FormTambahBarang_Load(sender, e);
                }
                else
                {
                    MessageBox.Show("Item data can't be empty.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Item data failed to change. Error Message : " + ex.Message,
                    "Failure");
            }
        }

        private void FormUbahBarang_Load(object sender, EventArgs e)
        {
            listKategori = Kategori.BacaData("", "");

            comboBoxKategori.DataSource = listKategori;
            comboBoxKategori.DisplayMember = "Nama";

            comboBoxKategori.DropDownStyle = ComboBoxStyle.DropDownList;
        }
    }
}
