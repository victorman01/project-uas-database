﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnlineMart_SubrataSquad
{
    public partial class FormUbahMetodePembayaran : Form
    {
        public FormUbahMetodePembayaran()
        {
            InitializeComponent();
        }

        private void buttonKeluar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBoxNamaMP_Enter(object sender, EventArgs e)
        {
            if (textBoxNamaMP.Text == "Type Here...")
            {
                textBoxNamaMP.Text = "";
                textBoxNamaMP.ForeColor = Color.Black;
                textBoxNamaMP.Font = new Font("Tahoma", 10, FontStyle.Regular);
            }
        }

        private void textBoxNamaMP_Leave(object sender, EventArgs e)
        {
            if (textBoxNamaMP.Text == "")
            {
                textBoxNamaMP.Text = "Type Here...";
                textBoxNamaMP.ForeColor = Color.Silver;
                textBoxNamaMP.Font = new Font("Tahoma", 10, FontStyle.Italic);
            }
        }

        private void textBoxKodeMP_Enter(object sender, EventArgs e)
        {
            if (textBoxKodeMP.Text == "Type Here...")
            {
                textBoxKodeMP.Text = "";
                textBoxKodeMP.ForeColor = Color.Black;
                textBoxKodeMP.Font = new Font("Tahoma", 10, FontStyle.Regular);
            }
        }

        private void textBoxKodeMP_Leave(object sender, EventArgs e)
        {
            if (textBoxKodeMP.Text == "")
            {
                textBoxKodeMP.Text = "Type Here...";
                textBoxKodeMP.ForeColor = Color.Silver;
                textBoxKodeMP.Font = new Font("Tahoma", 10, FontStyle.Italic);
            }
        }

        private void buttonKosongi_Click(object sender, EventArgs e)
        {

        }

        private void buttonSimpan_Click(object sender, EventArgs e)
        {

        }
    }
}
