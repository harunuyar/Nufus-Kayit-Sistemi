using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsProje
{
    public partial class Vatandaş : Form
    {
        public Vatandaş(ListViewItem item)
        {
            InitializeComponent();

            this.Text = item.SubItems[1].Text + " " + item.SubItems[2].Text;

            if (item.SubItems[5].Text == "ERKEK")
            {
                pictureBox.Image = Properties.Resources.nufuscuzdanierkek;
            }
            else
            {
                pictureBox.Image = Properties.Resources.nufuscuzdanikadin;
            }

            labelTc.Text = item.SubItems[0].Text;
            labelAd.Text = item.SubItems[1].Text;
            labelSoyad.Text = item.SubItems[2].Text;
            labelBaba.Text = item.SubItems[3].Text;
            labelAnne.Text = item.SubItems[4].Text;
            labelDogumYeri.Text = item.SubItems[6].Text;
            labelDogumTarihi.Text = item.SubItems[7].Text.Split(' ')[0];
            labelMedeniHal.Text = item.SubItems[8].Text;
            labelDin.Text = item.SubItems[9].Text;
            labelKanGrubu.Text = item.SubItems[10].Text;
            labelil.Text = item.SubItems[11].Text;
            labelilçe.Text = item.SubItems[12].Text;
            labelMahalle.Text = item.SubItems[13].Text;
            labelCiltNo.Text = item.SubItems[14].Text;
            labelAileSıra.Text = item.SubItems[15].Text;
            labelSıra.Text = item.SubItems[16].Text;
        }
    }
}
