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
    public partial class KullanıcıPaneli : WindowsProjeBase.PanelBase
    {
        private VatandaşForm vatandaşForm;

        public KullanıcıPaneli(Form form) : base(form)
        {
            InitializeComponent();
            vatandaşForm = null;
        }

        private void buttonAra_Click(object sender, EventArgs e)
        {
            setProgressBarValue(0);

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

            setProgressBarValue(40);

            if (MySQLHelper.select(komutString, listView).Items.Count == 0)
            {
                MessageBox.Show("Kayıt bulunamadı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                setFoundRecords(0);
            }
            else
            {
                txtAd.Text = "";
                txtSoyad.Text = "";
                txtTc.Text = "";
                setFoundRecords(listView.Items.Count);
            }
            setProgressBarValue(100);
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

        private void listView_DoubleClick(object sender, EventArgs e)
        {
            if (listView.SelectedItems.Count > 0) {
                Vatandaş v = new Vatandaş(listView.SelectedItems[0]);
                vatandaşForm = VatandaşForm.getForm();
                vatandaşForm.openChild(v);
            }
        }
    }
}
