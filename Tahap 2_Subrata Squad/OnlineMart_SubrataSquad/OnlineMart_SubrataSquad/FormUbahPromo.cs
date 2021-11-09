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
    public partial class FormUbahPromo : Form
    {
        public FormUbahPromo()
        {
            InitializeComponent();
        }

        private void FormUbahPromo_Load(object sender, EventArgs e)
        {

        }

        private void buttonKosongi_Click(object sender, EventArgs e)
        {
            textBoxNamaPromo.Text = "";
            textBoxTipePromo.Text = "";
            textBoxDiskon.Text = "";
            textBoxMaksimalDiskon.Text = "";
            textBoxMinimalPembelian.Text = "";
            textBoxKodePromo.Focus();
        }

        private void buttonUbah_Click(object sender, EventArgs e)
        {
            try
            {
                Promo promo = new Promo(int.Parse(textBoxKodePromo.Text), textBoxTipePromo.Text, textBoxNamaPromo.Text,
                    int.Parse(textBoxDiskon.Text), int.Parse(textBoxMaksimalDiskon.Text), float.Parse(textBoxMinimalPembelian.Text));
                Promo.UbahData(promo);
                MessageBox.Show("Data Changed.", "Information");
                FormPengaturanPromo formPengaturanPromo = (FormPengaturanPromo)Owner;
                formPengaturanPromo.FormPengaturanPromo_Load(sender, e);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Change data failed. Error Message : " + ex.Message, "Failure");
            }
        }

        private void buttonKeluar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
