﻿using System;
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
    public partial class FormUbahMetodePembayaran : Form
    {
        public List<MetodePembayaran> listMetodePembayaran = new List<MetodePembayaran>();
        public FormUbahMetodePembayaran()
        {
            InitializeComponent();
        }

        private void buttonKeluar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonKosongi_Click(object sender, EventArgs e)
        {
            textBoxNamaMP.Text = "";
            textBoxNamaMP.Focus();
        }

        private void buttonSimpan_Click(object sender, EventArgs e)
        {
            try
            {
                MetodePembayaran mp = new MetodePembayaran(int.Parse(textBoxKodeMP.Text), textBoxNamaMP.Text);
                MetodePembayaran.UbahData(mp);
                MessageBox.Show("Data Changed.");

                FormPengaturanMetodePembayaran form = (FormPengaturanMetodePembayaran)this.Owner;
                form.FormPengaturanMetodePembayaran_Load(sender, e);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("There's error when changing data. Error message : " + ex.Message,
                    "Failure");
            }
        }
    }
}
