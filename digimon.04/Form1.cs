using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace digimon._04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lblnome_Click(object sender, EventArgs e)
        {
            lbltitulo.Text = "Higor Gomes";
        }

        private void lbltitulo_Click(object sender, EventArgs e)
        {
        }

        private void btnabra_CheckedChanged(object sender, EventArgs e)
        {
            imgBox.Image = Properties.Resources.abra1;
        }

        private void btncartepie_CheckedChanged(object sender, EventArgs e)
        {
            imgBox.Image = Properties.Resources.cartepie1;
        }

        private void btnratata_CheckedChanged(object sender, EventArgs e)
        {
            imgBox.Image = Properties.Resources.ratata1;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            imgBox.Image = Properties.Resources.growlithe1;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            imgBox.Image = Properties.Resources.weedle2;
        }

        private void btnpsyduck_CheckedChanged(object sender, EventArgs e)
        {
            imgBox.Image = Properties.Resources.PSYDUCK1;
        }

        private void btnZubat_CheckedChanged(object sender, EventArgs e)
        {
            imgBox.Image = Properties.Resources.zubat1;
        }

        private void btnOddish_CheckedChanged(object sender, EventArgs e)
        {
            imgBox.Image = Properties.Resources.odissh1;
        }

        private void btnPikachu_CheckedChanged(object sender, EventArgs e)
        {
            imgBox.Image = Properties.Resources.pikachu1;
        }

        private void btnMankey_CheckedChanged(object sender, EventArgs e)
        {
            imgBox.Image = Properties.Resources.mankey1;
        }

        private void imgBox_Click(object sender, EventArgs e)
        {
            imgBox.
        }
    }
}
