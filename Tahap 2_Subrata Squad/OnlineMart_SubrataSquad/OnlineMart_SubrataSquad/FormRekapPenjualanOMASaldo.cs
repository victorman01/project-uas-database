using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OnlineMart_LIB;

namespace OnlineMart_SubrataSquad
{
    public partial class FormRekapPenjualanOMASaldo : Form
    {
        public List<RiwayatIsiSaldo> listPenjualanOMASaldo = new List<RiwayatIsiSaldo>();
        public FormRekapPenjualanOMASaldo()
        {
            InitializeComponent();
        }

        private void buttonKeluar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBoxCBRekapPenjualanOMA_Enter(object sender, EventArgs e)
        {
            if (textBoxCBRekapPenjualanOMA.Text == "Type Here...")
            {
                textBoxCBRekapPenjualanOMA.Text = "";
                textBoxCBRekapPenjualanOMA.ForeColor = Color.Black;
                textBoxCBRekapPenjualanOMA.Font = new Font("Tahoma", 10, FontStyle.Regular);
            }
        }

        private void textBoxCBRekapPenjualanOMA_Leave(object sender, EventArgs e)
        {
            if (textBoxCBRekapPenjualanOMA.Text == "")
            {
                textBoxCBRekapPenjualanOMA.Text = "Type Here...";
                textBoxCBRekapPenjualanOMA.ForeColor = Color.Silver;
                textBoxCBRekapPenjualanOMA.Font = new Font("Tahoma", 10, FontStyle.Italic);
            }
        }
        public void FormatDataGrid()
        {
            dataGridViewRekapPenjualanOMA.DataSource = null;
            dataGridViewRekapPenjualanOMA.Columns.Clear();

            //Atur Tabel
            dataGridViewRekapPenjualanOMA.Columns.Add("WaktuPembelian", "Waktu Pembelian");
            dataGridViewRekapPenjualanOMA.Columns.Add("JumlahIsi", "Jumlah Isi");
            dataGridViewRekapPenjualanOMA.Columns.Add("Pelanggan", "Pelanggan");

            //Atur Ukuran Cell
            dataGridViewRekapPenjualanOMA.Columns["WaktuPembelian"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewRekapPenjualanOMA.Columns["JumlahIsi"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewRekapPenjualanOMA.Columns["Pelanggan"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            //Buat Button Aksi
            DataGridViewButtonColumn bcol = new DataGridViewButtonColumn();
            bcol.HeaderText = "Aksi";
            bcol.Text = "Detail";
            bcol.Name = "btnDetailGrid";
            bcol.UseColumnTextForButtonValue = true;
            dataGridViewRekapPenjualanOMA.Columns.Add(bcol);

            //Batasi Aktivitas User
            dataGridViewRekapPenjualanOMA.AllowUserToAddRows = false;
            dataGridViewRekapPenjualanOMA.ReadOnly = true;
        }
        public void TampilDataGrid()
        {
            dataGridViewRekapPenjualanOMA.Rows.Clear();

            if (listPenjualanOMASaldo.Count > 0)
            {
                foreach (RiwayatIsiSaldo ris in listPenjualanOMASaldo)
                {
                    dataGridViewRekapPenjualanOMA.Rows.Add(ris.Waktu, ris.IsiSaldo, ris.Pelanggan.Nama);
                }
            }
            else
            {
                dataGridViewRekapPenjualanOMA.DataSource = null;
            }
        }
        private void FormRekapPenjualanOMASaldo_Load(object sender, EventArgs e)
        {
            FormatDataGrid();
            listPenjualanOMASaldo = RiwayatIsiSaldo.BacaData("", "");
            TampilDataGrid();
        }

        private void dataGridViewRekapPenjualanOMA_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string tanggal = dataGridViewRekapPenjualanOMA.CurrentRow.Cells["WaktuPembelian"].Value.ToString();
            int jumlahIsi = (int)dataGridViewRekapPenjualanOMA.CurrentRow.Cells["JumlahIsi"].Value;
            string pelanggan = dataGridViewRekapPenjualanOMA.CurrentRow.Cells["Pelanggan"].Value.ToString();

            if (e.ColumnIndex == dataGridViewRekapPenjualanOMA.Columns["btnDetailGrid"].Index && e.RowIndex >= 0)
            {
                FormRekapPenjualanOMASaldoDetail frm = new FormRekapPenjualanOMASaldoDetail();
                frm.Owner = this;
                frm.labelTanggal.Text = tanggal;
                frm.labelJumlahIsi.Text = jumlahIsi.ToString("C0", new CultureInfo("id"));
                frm.labelPelanggan.Text = pelanggan;
                frm.Show();
            }
        }

        private void textBoxCBRekapPenjualanOMA_TextChanged(object sender, EventArgs e)
        {
            FormatDataGrid();
            string kriteria = "";
            switch (comboBoxCBRekapPenjualanOMA.Text)
            {
                case "Tanggal":
                    kriteria = "ris.waktu";
                    break;
                case "Jumlah Isi":
                    kriteria = "ris.isi_saldo";
                    break;
                case "Pelanggan":
                    kriteria = "p.nama";
                    break;
            }
            if (textBoxCBRekapPenjualanOMA.Text == "Type Here...")
            {
                listPenjualanOMASaldo = RiwayatIsiSaldo.BacaData(kriteria, "");
            }
            else
            {
                listPenjualanOMASaldo = RiwayatIsiSaldo.BacaData(kriteria, textBoxCBRekapPenjualanOMA.Text);
            }

            if (radioButtonBulan.Checked)
            {
                listPenjualanOMASaldo = RiwayatIsiSaldo.BacaData("month(ris.waktu)", "");
            }
            else if(radioButtonTahun.Checked)
            {
                listPenjualanOMASaldo = RiwayatIsiSaldo.BacaData("year(ris.waktu)", "");
            }
            TampilDataGrid();
        }
    }
}
