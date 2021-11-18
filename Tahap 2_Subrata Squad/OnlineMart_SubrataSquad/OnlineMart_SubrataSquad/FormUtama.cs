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
    public partial class FormUtama : Form
    {
        public Pegawai pegawai;
        public Pelanggan pelanggan;
        public Driver driver;
        public string loginAs;

        public FormUtama()
        {
            InitializeComponent();
        }

        private void keluarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void barangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = Application.OpenForms["FormBarang"];
            if (frm == null)
            {
                FormBarang formBarang = new FormBarang();
                formBarang.MdiParent = this;
                formBarang.pelanggan = pelanggan;
                formBarang.Show();
            }
            else
            {
                frm.Show();
                frm.BringToFront();
            }
        }

        private void keranjangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = Application.OpenForms["FormKeranjang"];
            if (frm == null)
            {
                FormKeranjang formKeranjang = new FormKeranjang();
                formKeranjang.pelanggan = pelanggan;
                formKeranjang.MdiParent = this;
                formKeranjang.Show();
            }
            else
            {
                frm.Show();
                frm.BringToFront();
            }
        }

        private void saldoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = Application.OpenForms["FormIsiSaldo"];
            if (frm == null)
            {
                FormIsiSaldo formIsiSaldo = new FormIsiSaldo();
                formIsiSaldo.pelanggan = pelanggan;
                formIsiSaldo.MdiParent = this;
                formIsiSaldo.Show();
            }
            else
            {
                frm.Show();
                frm.BringToFront();
            }
        }

        private void profilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = Application.OpenForms["FormProfile"];
            if (frm == null)
            {
                FormProfile formProfile = new FormProfile();
                formProfile.MdiParent = this;
                formProfile.idPelanggan = pelanggan.Id;
                formProfile.Show();
            }
            else
            {
                frm.Show();
                frm.BringToFront();
            }
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dR = MessageBox.Show("Are You Sure?", "Confirmation", MessageBoxButtons.YesNo);
            if (dR == DialogResult.Yes)
            {
                MessageBox.Show("Logout success.", "Information");
                this.Hide();
                FormDashboard formUtama = new FormDashboard();
                formUtama.MdiParent = this;
                formUtama.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Logout fail.", "Information");
            }
        }

        private void rekapPembelianToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = Application.OpenForms["FormHistory"];
            if (frm == null)
            {
                FormHistory formHistory = new FormHistory();
                formHistory.MdiParent = this;
                formHistory.pelanggan = pelanggan;
                formHistory.Show();
            }
            else
            {
                frm.Show();
                frm.BringToFront();
            }
        }

        public void FormUtamaKonsumen_Load(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;
            this.WindowState = FormWindowState.Maximized;
            switch (loginAs)
            {
                case "Pegawai":
                    labelNama.Text = "Pegawai - " + pegawai.Nama;
                    break;
                case "Pelanggan":
                    labelNama.Text = "Pelanggan - " + pelanggan.Nama;
                    break;
                case "Driver":
                    labelNama.Text = "Driver - " + driver.Nama;
                    break;
            }
        }

        private void pesananToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = Application.OpenForms["FormCekPesanan"];
            if (frm == null)
            {
                FormCekPesanan form = new FormCekPesanan();
                form.MdiParent = this;
                form.Show();
            }
            else
            {
                frm.Show();
                frm.BringToFront();
            }

        }

        private void promoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = Application.OpenForms["FormPromo"];
            if (frm == null)
            {
                FormPromo form = new FormPromo();
                form.MdiParent = this;
                form.Show();
            }
            else
            {
                frm.Show();
                frm.BringToFront();
            }
        }

        private void kategoriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = Application.OpenForms["FormPengaturanKategori"];
            if (frm == null)
            {
                FormPengaturanKategori formPengaturanKategori = new FormPengaturanKategori();
                formPengaturanKategori.MdiParent = this;
                formPengaturanKategori.Show();
            }
            else
            {
                frm.Show();
                frm.BringToFront();
            }
        }

        private void pegawaiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = Application.OpenForms["FormPengaturanPegawai"];
            if (frm == null)
            {
                FormPengaturanPegawai formPengaturPegawai = new FormPengaturanPegawai();
                formPengaturPegawai.MdiParent = this;
                formPengaturPegawai.Show();
            }
            else
            {
                frm.Show();
                frm.BringToFront();
            }
        }

        private void daftarPengirimanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = Application.OpenForms["FormListPengiriman"];
            if (frm == null)
            {
                FormListPengiriman formListPengiriman = new FormListPengiriman();
                formListPengiriman.MdiParent = this;
                formListPengiriman.Show();
            }
            else
            {
                frm.Show();
                frm.BringToFront();
            }
        }

        private void kontakToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cabangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = Application.OpenForms["FormPengaturanCabang"];
            if (frm == null)
            {
                FormPengaturanCabang formPengaturanCabang = new FormPengaturanCabang();
                formPengaturanCabang.MdiParent = this;
                formPengaturanCabang.Show();
            }
            else
            {
                frm.Show();
                frm.BringToFront();
            }
        }


        private void metodePembayaranToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = Application.OpenForms["FormPengaturanMetodePembayaran"];
            if (frm == null)
            {
                FormPengaturanMetodePembayaran formPengaturanMetodePembayaran = new FormPengaturanMetodePembayaran();
                formPengaturanMetodePembayaran.MdiParent = this;
                formPengaturanMetodePembayaran.Show();
            }
            else
            {
                frm.Show();
                frm.BringToFront();
            }
        }

        private void promoPegawaiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = Application.OpenForms["FormPengaturanPromo"];
            if (frm == null)
            {
                FormPengaturanPromo formPengaturanPromo = new FormPengaturanPromo();
                formPengaturanPromo.MdiParent = this;
                formPengaturanPromo.Show();
            }
            else
            {
                frm.Show();
                frm.BringToFront();
            }
        }

        private void hadiahToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = Application.OpenForms["FormPengaturanHadiah"];
            if (frm == null)
            {
                FormPengaturanHadiah formPengaturanHadiah = new FormPengaturanHadiah();
                formPengaturanHadiah.MdiParent = this;
                formPengaturanHadiah.Show();
            }
            else
            {
                frm.Show();
                frm.BringToFront();
            }
        }

        private void rekapPendapatanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = Application.OpenForms["FormRekapPendapatan"];
            if (frm == null)
            {
                FormRekapPendapatan formRekapPendapatan = new FormRekapPendapatan();
                formRekapPendapatan.MdiParent = this;
                formRekapPendapatan.Show();
            }
            else
            {
                frm.Show();
                frm.BringToFront();
            }
        }

        private void rekapPenjualanBarangToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void rekapPenjualanOMASaldoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void barangToolStripMenuItem_Click_2(object sender, EventArgs e)
        {
            Form frm = Application.OpenForms["FormPengaturanBarang"];
            if (frm == null)
            {
                FormPengaturanBarang formPengaturanBarang = new FormPengaturanBarang();
                formPengaturanBarang.MdiParent = this;
                formPengaturanBarang.Show();
            }
            else
            {
                frm.Show();
                frm.BringToFront();
            }
        }
    }
}
