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
    public partial class Administrator : Form 
    {
        Business bus = new Business();
        public Administrator()
        {
            InitializeComponent();
        }

        private void Administrator_Load(object sender, EventArgs e)
        {
            toonBegeleiders();
            toonActiviteiten();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnVoegLeerkrachtToe_Click(object sender, EventArgs e)
        {
            VoegBegeleiderToe Leerkracht = new VoegBegeleiderToe();
            Leerkracht.Show();
            this.Close();
            toonBegeleiders();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnVoegActiviteitToe_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Voegt een activiteit toe
            if(txtAantalPlaatsen.Text==""|| txtNaam.Text == "" || txtOmschrijving.Text == "" || txtPrijs.Text == "" ||(rdbNamiddag.Checked==false && rdbVoormiddag.Checked == false))
            {
                MessageBox.Show("U bent een veld vergeten invullen", "Opgelet", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            else
            {
                string strUur = "_";
                if (rdbNamiddag.Checked == true)
                {
                    strUur = "Namiddag";
                }
                if (rdbVoormiddag.Checked == true)
                {
                    strUur = "Voormiddag";
                }
                int aantal;
                double price;
                if (Double.TryParse(txtPrijs.Text, out price)&& int.TryParse(txtAantalPlaatsen.Text, out aantal))
                {
                    bus.addActiviteit(txtNaam.Text, txtOmschrijving.Text, Convert.ToDouble(txtPrijs.Text),
            Convert.ToInt32(txtAantalPlaatsen.Text), mclDag.SelectionStart, strUur, txtURLFoto.Text);
                    //Dit connecteerd een activiteit en de gekozen begeleider
                    string item;
                    for (int i = 0; i < clbBegeleiders.CheckedItems.Count; i++)
                    {
                        string strLetter = "", strNaam = "";
                        item = clbBegeleiders.CheckedItems[i].ToString();
                        for (int j = 0; j < item.Length; j++)
                        {
                            strLetter = item.Substring(j, 1);
                            if (strLetter == " ")
                            {
                                j = item.Length;
                            }
                            strNaam += strLetter;
                        }
                        bus.connectActiviteitBegeleider(strNaam, txtNaam.Text);
                    }
                    makeEmpty();

                    toonActiviteiten();
                }
                else
                {
                    MessageBox.Show("Er staat een belangerijk veld op, gelieve die in te vullen", "Opgelet", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

            }
        }

        private void clbBegeleiders_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void btnOverzetten_Click(object sender, EventArgs e)
        {


        }

        private void mclDag_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        public void makeEmpty()
        {
            txtNaam.Text = "";
            txtAantalPlaatsen.Text = "";
            txtPrijs.Text = "";
            txtOmschrijving.Text = "";
            txtURLFoto.Text = "";
            rdbVoormiddag.Checked = false;
            rdbVoormiddag.Checked = false;
            mclDag.ShowToday = true;
            clbBegeleiders.Items.Clear();
            foreach (string lijn in bus.getBegeleidersNamen())
            {
                clbBegeleiders.Items.Add(lijn);
            }
        }
        public void toonActiviteiten()
        {
            txtActiviteiten.Clear();
            foreach(string lijn in bus.getActiviteiten())
            {
                txtActiviteiten.Text+=lijn+Environment.NewLine;
            }

        }
        public void toonBegeleiders()
        {
            clbBegeleiders.Items.Clear();
            foreach (string lijn in bus.getBegeleidersNamen())
            {
                clbBegeleiders.Items.Add(lijn);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            ActiviteitAanpassen form = new ActiviteitAanpassen();
            form.Show();
            this.Close();
            toonActiviteiten();
        }

        private void btnBegeleiderAanpassen_Click(object sender, EventArgs e)
        {
            BegeleiderAanpassen begaanpassen = new BegeleiderAanpassen();
            begaanpassen.Show();
            this.Close();

        }

        private void btnLijsten_Click(object sender, EventArgs e)
        {
            Lijsten lijsten = new Lijsten();
            lijsten.Show();
            this.Close();
        }

        private void btnTerug_Click(object sender, EventArgs e)
        {
            frmStartscherm startscherm = new frmStartscherm();
            startscherm.Show();
            this.Close();
        }

        private void Administrator_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Application.OpenForms.Count == 0)
            {
                frmStartscherm startscherm = new frmStartscherm();
                startscherm.StartPosition = FormStartPosition.CenterParent;
                startscherm.Show();
            }
            else { }
        }

        private void Administrator_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void txtURLFoto_TextChanged(object sender, EventArgs e)
        {
            if (txtURLFoto.TextLength > 400)
            {
                txtURLFoto.Text = "";
                MessageBox.Show("De url onder de 400 karakters houden a.u.b.", "Opgelet", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else { }
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            if (txtTest.Text != "")
            {
                if (txtTest.TextLength > 400)
                {
                    txtTest.Text = "";
                    MessageBox.Show("De url onder de 400 karakters houden a.u.b.", "Opgelet", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    pcbTest.ImageLocation = txtTest.Text;

                }
            }
            else
            {
                MessageBox.Show("U moet eerst een URL ingeven", "Opgelet", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void rdbVoormiddag_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
