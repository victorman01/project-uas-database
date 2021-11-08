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
    public partial class FormTambahCabang : Form
    {
        public List<Pegawai> listPegawai = new List<Pegawai>();

        public FormTambahCabang()
        {
            InitializeComponent();
        }

        private void buttonKeluar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBoxAlamatCabang_Enter(object sender, EventArgs e)
        {
            if (textBoxAlamatCabang.Text == "Type Here...")
            {
                textBoxAlamatCabang.Text = "";
                textBoxAlamatCabang.ForeColor = Color.Black;
                textBoxAlamatCabang.Font = new Font("Tahoma", 10, FontStyle.Regular);
            }
        }

        private void textBoxAlamatCabang_Leave(object sender, EventArgs e)
        {
            if (textBoxAlamatCabang.Text == "")
            {
                textBoxAlamatCabang.Text = "Type Here...";
                textBoxAlamatCabang.ForeColor = Color.Silver;
                textBoxAlamatCabang.Font = new Font("Tahoma", 10, FontStyle.Italic);
            }
        }

        private void textBoxNamaCabang_Enter(object sender, EventArgs e)
        {
            if (textBoxNamaCabang.Text == "Type Here...")
            {
                textBoxNamaCabang.Text = "";
                textBoxNamaCabang.ForeColor = Color.Black;
                textBoxNamaCabang.Font = new Font("Tahoma", 10, FontStyle.Regular);
            }
        }

        private void textBoxNamaCabang_Leave(object sender, EventArgs e)
        {
            if (textBoxNamaCabang.Text == "")
            {
                textBoxNamaCabang.Text = "Type Here...";
                textBoxNamaCabang.ForeColor = Color.Silver;
                textBoxNamaCabang.Font = new Font("Tahoma", 10, FontStyle.Italic);
            }
        }

        private void textBoxIDCabang_Enter(object sender, EventArgs e)
        {
            if (textBoxIDCabang.Text == "Type Here...")
            {
                textBoxIDCabang.Text = "";
                textBoxIDCabang.ForeColor = Color.Black;
                textBoxIDCabang.Font = new Font("Tahoma", 10, FontStyle.Regular);
            }
        }

        private void textBoxIDCabang_Leave(object sender, EventArgs e)
        {
            if (textBoxIDCabang.Text == "")
            {
                textBoxIDCabang.Text = "Type Here...";
                textBoxIDCabang.ForeColor = Color.Silver;
                textBoxIDCabang.Font = new Font("Tahoma", 10, FontStyle.Italic);
            }
        }

        private void buttonKosongi_Click(object sender, EventArgs e)
        {
            textBoxAlamatCabang.Text = "";
            textBoxNamaCabang.Text = "";
            textBoxIDCabang.Focus();
        }

        private void buttonSimpan_Click(object sender, EventArgs e)
        {
            try
            {
                Pegawai pegawaiDipilih = (Pegawai)comboBoxPegawai.SelectedItem;

                Cabang c = new Cabang(textBoxNamaCabang.Text, textBoxAlamatCabang.Text,
                    pegawaiDipilih);

                Cabang.TambahData(c);

                MessageBox.Show("Data cabang berhasil ditambahkan", "Informasi");

                FormPengaturanCabang frm = (FormPengaturanCabang)this.Owner;
                frm.FormPengaturanCabang_Load(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Data cabang gagal ditambahkan. Pesan kesalahan : " + ex.Message,
                    "Kesalahan");
            }
        }

        private void FormTambahCabang_Load(object sender, EventArgs e)
        {
            listPegawai = Pegawai.BacaData("", "");

            comboBoxPegawai.DataSource = listPegawai;
            comboBoxPegawai.DisplayMember = "Nama";

            comboBoxPegawai.DropDownStyle = ComboBoxStyle.DropDownList;
        }
    }
}
