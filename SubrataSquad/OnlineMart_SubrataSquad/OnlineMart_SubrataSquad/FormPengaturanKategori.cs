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
    public partial class FormPengaturanKategori : Form
    {
        public List<Kategori> listKategori = new List<Kategori>();

        public FormPengaturanKategori()
        {
            InitializeComponent();
        }

        private void buttonKeluar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonTambah_Click(object sender, EventArgs e)
        {
            FormTambahKategori form = new FormTambahKategori();
            form.Owner = this;
            form.ShowDialog();
        }


        private void textBoxCBPengaturanKategori_Leave(object sender, EventArgs e)
        {
            if (textBoxCBPengaturanKategori.Text == "")
            {
                textBoxCBPengaturanKategori.Text = "Type Here...";
                textBoxCBPengaturanKategori.ForeColor = Color.Silver;
                textBoxCBPengaturanKategori.Font = new Font("Tahoma", 10, FontStyle.Italic);
            }
        }

        private void textBoxCBPengaturanKategori_Enter(object sender, EventArgs e)
        {
            if (textBoxCBPengaturanKategori.Text == "Type Here...")
            {
                textBoxCBPengaturanKategori.Text = "";
                textBoxCBPengaturanKategori.ForeColor = Color.Black;
                textBoxCBPengaturanKategori.Font = new Font("Tahoma", 10, FontStyle.Regular);
            }
        }

        public void FormPengaturanKategori_Load(object sender, EventArgs e)
        {
            listKategori = Kategori.BacaData("", "");

            if (listKategori.Count > 0)
            {
                dataGridViewPengaturanKategori.DataSource = listKategori;

                if (!dataGridViewPengaturanKategori.Columns.Contains("btnUbahGrid"))
                {
                    DataGridViewButtonColumn bcol = new DataGridViewButtonColumn();
                    bcol.HeaderText = "Aksi";
                    bcol.Text = "Ubah";
                    bcol.Name = "btnUbahGrid";
                    bcol.UseColumnTextForButtonValue = true;
                    dataGridViewPengaturanKategori.Columns.Add(bcol);

                    DataGridViewButtonColumn bcol2 = new DataGridViewButtonColumn();
                    bcol2.HeaderText = "Aksi";
                    bcol2.Text = "Hapus";
                    bcol2.Name = "btnHapusGrid";
                    bcol2.UseColumnTextForButtonValue = true;
                    dataGridViewPengaturanKategori.Columns.Add(bcol2);
                }
            }
            else
            {
                dataGridViewPengaturanKategori.DataSource = null;
            }
        }

        private void dataGridViewPengaturanKategori_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string pKodeKategori = dataGridViewPengaturanKategori.CurrentRow.Cells["id"].Value.ToString();
            string pNamaKategori = dataGridViewPengaturanKategori.CurrentRow.Cells["nama"].Value.ToString();

            if (e.ColumnIndex == dataGridViewPengaturanKategori.Columns["btnHapusGrid"].Index && e.RowIndex >= 0)
            {
                try
                {
                    DialogResult hasil = MessageBox.Show(this, "Are you sure? " + pKodeKategori +
                             " - " + pNamaKategori + " ?", "HAPUS", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (hasil == DialogResult.Yes)
                    {
                        Boolean hapus = Kategori.HapusData(pKodeKategori);
                        if (hapus == true)
                        {
                            MessageBox.Show("Delete success");

                            FormPengaturanKategori_Load(sender, e);
                        }
                        else
                        {
                            MessageBox.Show("Delete failed");
                        }
                    }
                }
                catch (Exception)
                {

                    MessageBox.Show("Category id is still used");
                }
            }
            else
            {
                FormUbahKategori frm = new FormUbahKategori();
                frm.Owner = this;
                frm.textBoxIdKategori.Text = pKodeKategori;
                frm.textBoxNamaKategori.Text = pNamaKategori;
                frm.Show();
            }
        }

        private void textBoxCBPengaturanKategori_TextChanged(object sender, EventArgs e)
        {
            string kriteria = "";
            switch (comboBoxCBPengaturanKategori.Text)
            {
                case "Kode Kategori":
                    kriteria = "Id";
                    break;
                case "Nama Kategori":
                    kriteria = "Nama";
                    break;
            }
            if (textBoxCBPengaturanKategori.Text == "Type Here...")
            {
                listKategori = Kategori.BacaData(kriteria, "");
            }
            else
            {
                listKategori = Kategori.BacaData(kriteria, textBoxCBPengaturanKategori.Text);
            }
            dataGridViewPengaturanKategori.DataSource = listKategori;
        }
    }
}
