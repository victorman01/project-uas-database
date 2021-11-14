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
    public partial class FormTambahBarangKeKeranjang : Form
    {
        public List<CabangBarang> listCabangBarang = new List<CabangBarang>();
        public Pelanggan pelanggan;
        public FormTambahBarangKeKeranjang()
        {
            InitializeComponent();
        }

        private void FormTambahBarangKeKeranjang_Load(object sender, EventArgs e)
        {
            listCabangBarang = CabangBarang.BacaData("", "");

            foreach (CabangBarang cb in listCabangBarang)
            {
                if (cb.Barang.Id == int.Parse(labelIdBarang.Text))
                {
                    comboBoxCabang.Items.Add(cb.Cabang.ToString());
                }
            }
            numericUpDownJumlahBarang.Minimum = 0;
        }

        private void buttonKeluar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonTambah_Click(object sender, EventArgs e)
        {
            Cabang c = new Cabang();
            Barang b = new Barang();
            int pelangganId = pelanggan.Id;
            int jumlah = int.Parse(numericUpDownJumlahBarang.Value.ToString());
            try
            {
                foreach (CabangBarang cb in listCabangBarang)
                {
                    if (cb.Cabang.Nama == comboBoxCabang.Text && cb.Barang.Id == int.Parse(labelIdBarang.Text))
                    {
                        c = new Cabang(cb.Cabang.Id, cb.Cabang.Nama, cb.Cabang.Alamat, cb.Cabang.Pegawai);
                        b = new Barang(cb.Barang.Id, cb.Barang.Nama, cb.Barang.Harga, cb.Barang.Kategori);
                    }
                }
                Keranjang k = new Keranjang(pelanggan, b, c, int.Parse(numericUpDownJumlahBarang.Value.ToString()));
                Keranjang.TambahData(k);

                MessageBox.Show("The Items is added to The basket");               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void comboBoxCabang_SelectedIndexChanged(object sender, EventArgs e)
        {
            listCabangBarang = CabangBarang.BacaData("", "");
            foreach (CabangBarang cb in listCabangBarang)
            {
                if (cb.Barang.Id == int.Parse(labelIdBarang.Text) && cb.Cabang.Nama == comboBoxCabang.Text)
                {
                    numericUpDownJumlahBarang.Maximum = cb.Stok;
                }
            }
        }
    }
}
