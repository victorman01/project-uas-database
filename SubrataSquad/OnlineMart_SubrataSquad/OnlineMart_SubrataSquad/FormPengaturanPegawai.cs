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
    public partial class FormPengaturanPegawai : Form
    {
        public List<Pegawai> listPegawai = new List<Pegawai>();

        public FormPengaturanPegawai()
        {
            InitializeComponent();
        }

        public void FormPengaturan_Pegawai_Load(object sender, EventArgs e)
        {
            FormatDataGrid();

            listPegawai = Pegawai.BacaData("", "");

            TampilDataGrid();
        }

        public void TampilDataGrid()
        {
            dataGridViewPengaturanPegawai.Rows.Clear();

            if (listPegawai.Count > 0)
            {
                foreach (Pegawai p in listPegawai)
                {
                    dataGridViewPengaturanPegawai.Rows.Add(p.Id, p.Nama, p.Email, p.Telepon);
                }

                if (!dataGridViewPengaturanPegawai.Columns.Contains("btnUbahGrid"))
                {
                    DataGridViewButtonColumn bcol = new DataGridViewButtonColumn();
                    bcol.HeaderText = "Aksi";
                    bcol.Text = "Ubah";
                    bcol.Name = "btnUbahGrid";
                    bcol.UseColumnTextForButtonValue = true;
                    dataGridViewPengaturanPegawai.Columns.Add(bcol);

                    DataGridViewButtonColumn bcol2 = new DataGridViewButtonColumn();
                    bcol2.HeaderText = "Aksi";
                    bcol2.Text = "Hapus";
                    bcol2.Name = "btnHapusGrid";
                    bcol2.UseColumnTextForButtonValue = true;
                    dataGridViewPengaturanPegawai.Columns.Add(bcol2);
                }
            }
            else
            {
                dataGridViewPengaturanPegawai.DataSource = null;
            }
        }

        public void FormatDataGrid()
        {
            //kosongi semua kolom di datagridview
            dataGridViewPengaturanPegawai.Columns.Clear();

            //menambah kolom di datagridview
            dataGridViewPengaturanPegawai.Columns.Add("id", "ID Pegawai");
            dataGridViewPengaturanPegawai.Columns.Add("nama", "Nama Pegawai");
            dataGridViewPengaturanPegawai.Columns.Add("email", "Email Pegawai");
            dataGridViewPengaturanPegawai.Columns.Add("telepon", "Telepon Pegawai");

            //agar lebar kolom dapat menyesuaikan panjang/isi data
            dataGridViewPengaturanPegawai.Columns["id"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewPengaturanPegawai.Columns["nama"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewPengaturanPegawai.Columns["email"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewPengaturanPegawai.Columns["telepon"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            //agar user tidak bisa menambah baris maupun mengetik langsung di datagridview
            dataGridViewPengaturanPegawai.AllowUserToAddRows = false;
            dataGridViewPengaturanPegawai.ReadOnly = true;
        }

        private void buttonKeluar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonTambah_Click(object sender, EventArgs e)
        {
            FormRegistrasiPegawai form = new FormRegistrasiPegawai();
            form.Owner = this;
            form.ShowDialog();
        }

        private void dataGridViewPengaturanPegawai_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string pIdPegawai = dataGridViewPengaturanPegawai.CurrentRow.Cells["id"].Value.ToString();
                string pNamaPegawai = dataGridViewPengaturanPegawai.CurrentRow.Cells["nama"].Value.ToString();
                string pEmailPegawai = dataGridViewPengaturanPegawai.CurrentRow.Cells["email"].Value.ToString();
                string pTeleponPegawai = dataGridViewPengaturanPegawai.CurrentRow.Cells["telepon"].Value.ToString();

                if (e.ColumnIndex == dataGridViewPengaturanPegawai.Columns["btnHapusGrid"].Index && e.RowIndex >= 0)
                {
                    DialogResult hasil = MessageBox.Show(this, "Are you sure? " + pIdPegawai +
                        " - " + pNamaPegawai + " ?", "HAPUS", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (hasil == DialogResult.Yes)
                    {
                        Boolean hapus = Pegawai.HapusData(pIdPegawai);
                        if (hapus == true)
                        {
                            MessageBox.Show("Deletion success");

                            FormPengaturan_Pegawai_Load(sender, e);
                        }
                        else
                        {
                            MessageBox.Show("Deletion failed");
                        }
                    }
                }
                else
                {
                    FormUbahPegawai frm = new FormUbahPegawai();
                    frm.Owner = this;
                    frm.textBoxIdPegawai.Text = pIdPegawai;
                    frm.textBoxNamaPegawai.Text = pNamaPegawai;
                    frm.textBoxEmailPegawai.Text = pEmailPegawai;
                    frm.textBoxNoTeleponPegawai.Text = pTeleponPegawai;
                    frm.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Employee is still connect to another item. Error Message : " + ex.Message);
            }
        }

        private void textBoxCBPengaturanKPegawai_TextChanged(object sender, EventArgs e)
        {
            FormatDataGrid();

            string kriteria = "";
            switch (comboBoxCBPengaturanPegawai.Text)
            {
                case "ID Pegawai":
                    kriteria = "id";
                    break;
                case "Nama Pegawai":
                    kriteria = "nama";
                    break;
                case "Email Pegawai":
                    kriteria = "email";
                    break;
                case "Telepon Pegawai":
                    kriteria = "telepon";
                    break;
            }
            if (comboBoxCBPengaturanPegawai.Text == "Type Here...")
            {
                listPegawai = Pegawai.BacaData(kriteria, "");
            }
            else
            {
                listPegawai = Pegawai.BacaData(kriteria, textBoxCBPengaturanKPegawai.Text);
            }
            TampilDataGrid();
        }

        private void textBoxCBPengaturanKPegawai_Enter(object sender, EventArgs e)
        {
            if (textBoxCBPengaturanKPegawai.Text == "Type Here...")
            {
                textBoxCBPengaturanKPegawai.Text = "";
                textBoxCBPengaturanKPegawai.ForeColor = Color.Black;
                textBoxCBPengaturanKPegawai.Font = new Font("Tahoma", 10, FontStyle.Regular);
            }
        }

        private void textBoxCBPengaturanKPegawai_Leave(object sender, EventArgs e)
        {
            if (textBoxCBPengaturanKPegawai.Text == "")
            {
                textBoxCBPengaturanKPegawai.Text = "Type Here...";
                textBoxCBPengaturanKPegawai.ForeColor = Color.Silver;
                textBoxCBPengaturanKPegawai.Font = new Font("Tahoma", 10, FontStyle.Italic);
            }
        }
    }
}
