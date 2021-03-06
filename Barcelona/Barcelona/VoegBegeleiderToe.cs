﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Barcelona
{
    public partial class VoegBegeleiderToe : Form
    {
        Business bus = new Business();
        public VoegBegeleiderToe()
        {
            InitializeComponent();
        }

        private void VoegLeerkrachtToe_Load(object sender, EventArgs e)
        {
            lstBegeleiders.Items.Clear();
            foreach(string lijn in bus.getBegeleiders())
            {
                lstBegeleiders.Items.Add(lijn);
            }
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtVoornaam.Text != "" || txtAchternaam.Text != "" || txtGsmNummer.Text != "")
            {
                bus.addBegeleider(txtVoornaam.Text, txtAchternaam.Text, txtGsmNummer.Text);
                lstBegeleiders.Items.Clear();
                foreach (string lijn in bus.getBegeleiders())
                {
                    lstBegeleiders.Items.Add(lijn);
                }
                txtAchternaam.Text = "";
                txtVoornaam.Text = "";
                txtGsmNummer.Text = "";
            }
            else
            {
                MessageBox.Show("U bent een veld vergeten invullen", "opgelet", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void btnAnnuleren_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lstBegeleiders_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void VoegBegeleiderToe_FormClosed(object sender, FormClosedEventArgs e)
        {
            Administrator admin = new Administrator();
            admin.Show();
        }
    }
}
