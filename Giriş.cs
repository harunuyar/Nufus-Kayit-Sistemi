using System;
using System.Collections;
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
    public partial class Giriş : Form
    {
        public static string connectionString = "server=harunuyar.net;user id=harun;password=658898;persistsecurityinfo=True;database=harundb";

        public Giriş()
        {
            InitializeComponent();
            MySQLHelper.ilkle(connectionString);

        }

        private void buttonIptal_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonGiris_Click(object sender, EventArgs e)
        {
            if (checkUserAndPassword(textBoxKullanici.Text, textBoxSifre.Text))
            {
                this.Hide();
                textBoxKullanici.Text = "";
                textBoxSifre.Text = "";
            }
            else
            {
                txtHata.Visible = true;
            }
        }

        private Boolean checkUserAndPassword(string tcno,string password)
        {
            string komutString = "select isAdmin from User where kullaniciAdi='" + textBoxKullanici.Text
                + "' and parola='" + textBoxSifre.Text + "'";
            ArrayList list = MySQLHelper.select(komutString);

            if (list.Count != 0)
            {
                if (list[0].Equals(true))
                {
                    AdminPaneli yöneticiPaneli = new AdminPaneli(this);
                    yöneticiPaneli.Show();
                    return true;
                }
                else
                {
                    KullanıcıPaneli kullaniciPaneli = new KullanıcıPaneli(this);
                    kullaniciPaneli.Show();
                    return true;
                }
            }
            return false;
        }

        private void checkBoxGoster_CheckedChanged(object sender, EventArgs e)
        {
            //Check box seçili ise
            if (checkBoxGoster.Checked)
            {
                textBoxSifre.PasswordChar = '\0';

            }
            //Checkbox seçili değilse
            else
            {
                textBoxSifre.PasswordChar = '*';
            }
        }

        private void textBoxKullanici_TextChanged(object sender, EventArgs e)
        {
            txtHata.Visible = false;
        }

        public static void hakkında()
        {
            MessageBox.Show("Hakkında", "Hakkında");
        }
       
    }
}
