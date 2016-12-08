using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsProje
{
    public partial class KullanıcıPaneli : Form
    {
        Form senderForm;

        public KullanıcıPaneli(Form form)
        {
            InitializeComponent();
            this.senderForm = form;
        }

        private void buttonAra_Click(object sender, EventArgs e)
        {
            string komutString;

            if (txtTc.Text != "")
            {
                if (txtTc.Text.Length != 11 || !IsNumeric(txtTc.Text))
                {
                    MessageBox.Show("TC Kimlik Numarasını Yanlış Girdiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                komutString = "select * from Citizen where tcno=" + txtTc.Text;
            }
            else if (txtTc.Text == "" && txtAd.Text != "" && txtSoyad.Text != "")
            {
                komutString = "select * from Citizen where ad='" + txtAd.Text + "' and soyad='" + txtSoyad.Text + "'";
            }
            else
            {
                return;
            }

            if (MySQLHelper.select(komutString, listView).Items.Count == 0)
            {
                MessageBox.Show("Kayıt bulunamadı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                txtAd.Text = "";
                txtSoyad.Text = "";
                txtTc.Text = "";
            }
        }

        private bool IsNumeric(string text)
        {
            double test;
            return double.TryParse(text, out test);
        }

        private void allTexts_TextChanged(object sender, EventArgs e)
        {
            if ((txtAd.Text != "" && txtSoyad.Text != "") || txtTc.Text != "")//Eğer boşsa buton pasif halde
                buttonAra.Enabled = true;
            else
                buttonAra.Enabled = false;
            if (txtAd.Text=="" && txtSoyad.Text == "")//Ad soyad boşsa tc aktif halde
            {
                txtTc.Enabled = true;
            }
            else
            {
                txtTc.Enabled = false;
            }
            if (txtTc.Text== "")//Tc boşsa ad ve soyad aktif haldedir.
            {
                txtAd.Enabled = true;
                txtSoyad.Enabled = true;
            }
            else
            {
                txtAd.Enabled = false;
                txtSoyad.Enabled = false;
            }
        }

        private void oturumuKapatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Oturumunuzu kapatmak istiyor musunuz?", "Oturumu Kapat", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                this.Close();
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Programı kapatmak istiyor musunuz?", "Çıkış", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                Application.Exit();
        }

        private void hakkındaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Giriş.hakkında();
        }

        private void yardımToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bilgiler...\n...\n...\n...", "Yardım");
        }
        
        private void kullanıcıPaneli_FormClosed(object sender, FormClosedEventArgs e)
        {
            senderForm.Show();
        }

        private void buttonNKÖrneği_Click(object sender, EventArgs e)
        {
            if (listView.SelectedItems.Count > 0)
            {
                NüfusKayıtÖrneği nkö = new NüfusKayıtÖrneği(this,listView.SelectedItems[0].SubItems[0].Text);
                this.Enabled = false;
                nkö.Show();
            }
        }
    }
}
