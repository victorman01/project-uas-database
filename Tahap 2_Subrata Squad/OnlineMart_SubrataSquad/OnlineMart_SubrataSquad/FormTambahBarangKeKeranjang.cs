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
        }

        private void buttonKeluar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
