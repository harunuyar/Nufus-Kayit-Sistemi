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
    public partial class AdminPaneli : WindowsProjeBase.PanelBase
    {

        List<Control> vatandaşTextList;

        public static string[] vatandaşColumns = {"tcno", "ad", "soyad", "baba", "anne", "cinsiyet", "dogumYeri", "dogumTarihi",
                                        "medeniHali","dini","kanGrubu","koil","koilce","kokoy","cilt","aileSira","sira"};
        public static string[] kullanıcıColumns = {"id", "kullaniciAdi", "parola", "isAdmin"};
       
        public AdminPaneli(Form form) : base(form)
        {
            InitializeComponent();
            initVadandaşList();
            listViewPeople_SelectedIndexChanged(new object(), new EventArgs());
            userTexts_TextChanged(new object(), new EventArgs());
        }

        private bool IsNumeric(string text)
        {
            double test;
            return double.TryParse(text, out test);
        }

        private void seçilenKaydıGöster(ListView lw, Label lb)
        {
            if (lw.SelectedItems.Count == 0)
            {
                lb.Text = "";
            }
            else
            {

                lb.Text = "'" + lw.SelectedItems[0].Text + "'";
                if (lw.SelectedItems.Count > 1)
                {
                    lb.Text += "  ve " + (lw.SelectedItems.Count - 1) + " kayıt daha";
                }
            }
        }



        // Vatandaş İşlemleri

        private void initVadandaşList()
        {
            vatandaşTextList = new List<Control>();
            vatandaşTextList.Add(t1);
            vatandaşTextList.Add(t2);
            vatandaşTextList.Add(t3);
            vatandaşTextList.Add(t4);
            vatandaşTextList.Add(t5);
            vatandaşTextList.Add(t6);
            vatandaşTextList.Add(t7);
            vatandaşTextList.Add(t8);
            vatandaşTextList.Add(t9);
            vatandaşTextList.Add(t10);
            vatandaşTextList.Add(t11);
            vatandaşTextList.Add(t12);
            vatandaşTextList.Add(t13);
            vatandaşTextList.Add(t14);
            vatandaşTextList.Add(t15);
            vatandaşTextList.Add(t16);
            vatandaşTextList.Add(t17);
        }

        private void vatandaşTexts_TextChanged(object sender, EventArgs e)
        {
            bool ekleAktif = false;
            foreach (Control con in vatandaşTextList)
            {
                if (con.Text != "")
                {
                    ekleAktif = true;
                }
                else
                {
                    if (vatandaşTextList.IndexOf(con) != 9 && vatandaşTextList.IndexOf(con) != 10 && vatandaşTextList.IndexOf(con) != 3 && vatandaşTextList.IndexOf(con) != 4) // Kan grubu ve din NULL olabilir
                    {
                        ekleAktif = false;
                        break;
                    }
                }
            }
            if (ekleAktif)
            {
                if (listViewPeople.SelectedItems.Count == 0)
                {
                    buttonEkle.Enabled = true;
                    buttonGuncelle.Enabled = false;
                    buttonSil.Enabled = false;
                }
                else
                {
                    buttonEkle.Enabled = false;
                    buttonGuncelle.Enabled = true;
                    buttonSil.Enabled = true;
                }
            }
            else
            {
                if (listViewPeople.SelectedItems.Count == 0)
                {
                    buttonEkle.Enabled = false;
                    buttonGuncelle.Enabled = false;
                    buttonSil.Enabled = false;
                }
                else
                {
                    buttonEkle.Enabled = false;
                    buttonGuncelle.Enabled = false;
                    buttonSil.Enabled = true;
                }
            }

            buttonAra.Enabled = false;
            foreach ( Control con in vatandaşTextList)
            {
                if (con.Text != "" && con.Name != "t8")
                {
                    buttonAra.Enabled = true;
                    break;
                }
            }

            seçilenKaydıGöster(listViewPeople, labelSeçilenBilgisi);
        }

        private void listViewPeople_SelectedIndexChanged(object sender, EventArgs e)
        {
            vatandaşTexts_TextChanged(sender, e);

            if (listViewPeople.SelectedItems.Count != 0)
            {
                for (int i = 0; i < vatandaşTextList.Count; i++)
                {
                    vatandaşTextList[i].Text = listViewPeople.SelectedItems[0].SubItems[i].Text;
                }
            }
        }

        private void buttonTemizle_Click(object sender, EventArgs e)
        {
            foreach (Control con in vatandaşTextList)
            {
                con.Text = "";
            }
            listViewPeople.Items.Clear();
            setFoundRecords(0);
            setProgressBarValue(0);
        }
        

        private void buttonAra_Click(object sender, EventArgs e)
        {
            setProgressBarValue(0);
            if (t1.Text != "" && (t1.Text.Length != 11 || !IsNumeric(t1.Text)))
            {
                MessageBox.Show("TC Kimlik Numarasını Yanlış Girdiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            List<string> colList = new List<string>();
            List<string> valList = new List<string>();

            for(int i=0; i<vatandaşTextList.Count; i++)
            {
                if (vatandaşTextList[i].Text != "" && vatandaşTextList[i].Name != "t8")
                {
                    colList.Add(vatandaşColumns[i]);
                    valList.Add(vatandaşTextList[i].Text);
                }
            }

            if (colList.Count == 0)
            {
                MessageBox.Show("Bütün girişler boş!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            setProgressBarValue(40);

            if (MySQLHelper.select("Citizen", colList, valList, listViewPeople).Items.Count == 0)
            {
                setProgressBarValue(0);
                MessageBox.Show("Kayıt bulunamadı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                setProgressBarValue(100);
            }

            setFoundRecords(listViewPeople.Items.Count);
        }

        private void buttonEkle_Click(object sender, EventArgs e)
        {
            if (t1.Text.Length != 11 || !IsNumeric(t1.Text))
            {
                 MessageBox.Show("TC Kimlik Numarasını Yanlış Girdiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string[] columns = { "tcno" };
            string[] values = { t1.Text };

            if (!MySQLHelper.exists("Citizen", columns, values))
            {
                ListViewItem item = new ListViewItem();
                item.Text = vatandaşTextList[0].Text;
                for (int i = 1; i < vatandaşTextList.Count; i++)
                {
                    item.SubItems.Add(vatandaşTextList[i].Text);
                }
                if(MySQLHelper.insert(item, "Citizen"))
                {
                    MessageBox.Show("Kayıt eklendi!", "Başarılı!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    buttonAra_Click(new object(), new EventArgs());
                }
            }
            else
            {
                MessageBox.Show("Bu TC Kimlik numarasına sahip bir vatandaş zaten var.", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonGuncelle_Click(object sender, EventArgs e)
        {
            string komutString;

            if (t1.Text.Length != 11 || !IsNumeric(t1.Text))
            {
                MessageBox.Show("TC Kimlik Numarasını Yanlış Girdiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;//Hata
            }
            komutString = "select tcno from Citizen where tcno=" + t1.Text;

            ArrayList al = MySQLHelper.select(komutString);

            if (listViewPeople.SelectedItems.Count != 0)
            {
                if (al.Count == 0 || (al.Count == 1 && al[0].Equals(listViewPeople.SelectedItems[0].SubItems[0].Text)))
                {
                    //Güncelleme
                    ListViewItem item = new ListViewItem();
                    item.Text = vatandaşTextList[0].Text;
                    for (int i = 1; i < vatandaşTextList.Count; i++)
                    {
                        item.SubItems.Add(vatandaşTextList[i].Text);
                    }
                    if (MySQLHelper.update(item, "Citizen", "tcno", listViewPeople.SelectedItems[0].SubItems[0].Text, vatandaşColumns))
                    {
                        MessageBox.Show("Kayıt güncellendi!", "Başarılı!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        buttonAra_Click(new object(), new EventArgs());
                    }
                }
                else
                {
                    MessageBox.Show("Bu TC Kimlik numarasına sahip bir vatandaş zaten var.", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void buttonSil_Click(object sender, EventArgs e)
        {
            if (MySQLHelper.delete("Citizen","tcno", 0, listViewPeople.SelectedItems))
            {
                MessageBox.Show("Kayıt(lar) silindi!", "Başarılı!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                buttonTemizle_Click(new object(), new EventArgs());
            }
        }

        private void buttonTümünüListele1_Click(object sender, EventArgs e)
        {
            setProgressBarValue(0);
            setProgressBarValue(40);
            if (MySQLHelper.select("select * from Citizen", listViewPeople).Items.Count == 0)
            {
                setProgressBarValue(0);
                MessageBox.Show("Kayıt bulunamadı", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                setProgressBarValue(100);
            }
            setFoundRecords(listViewPeople.Items.Count);
        }

        private string adBul(string TC)
        {
            ArrayList al = MySQLHelper.select("select ad from Citizen where tcno='" + TC + "'");
            return al.Count!=0 ? al[0] as string : "-";
        }
        

        // Kullanıcı işlemleri

        private void userTexts_TextChanged(object sender, EventArgs e)
        {
            if (tId.Text != "" && tUser.Text != "" && tPass.Text != "")
            {
                if (listViewKullanicilar.SelectedItems.Count == 0)
                {
                    buttonEkle2.Enabled = true;
                    buttonGuncelle2.Enabled = false;
                    buttonSil2.Enabled = false;
                }
                else
                {
                    buttonEkle2.Enabled = false;
                    buttonGuncelle2.Enabled = true;
                    buttonSil2.Enabled = true;
                }
            }
            else
            {
                if (listViewKullanicilar.SelectedItems.Count == 0)
                {
                    buttonEkle2.Enabled = false;
                    buttonGuncelle2.Enabled = false;
                    buttonSil2.Enabled = false;
                }
                else
                {
                    buttonEkle2.Enabled = false;
                    buttonGuncelle2.Enabled = false;
                    buttonSil2.Enabled = true;
                }
            }

            if ((tId.Text != "" || (tUser.Text != "")) && listViewKullanicilar.SelectedItems.Count == 0)
            {
                buttonAra2.Enabled = true;
            }
            else
            {
                buttonAra2.Enabled = false;
            }

            seçilenKaydıGöster(listViewKullanicilar, labelSeçilenBilgisi2);
        }

        private void listViewKullanicilar_SelectedIndexChanged(object sender, EventArgs e)
        {
            userTexts_TextChanged(sender, e);

            if (listViewKullanicilar.SelectedItems.Count != 0)
            {
                tId.Text = listViewKullanicilar.SelectedItems[0].SubItems[0].Text;
                tUser.Text = listViewKullanicilar.SelectedItems[0].SubItems[1].Text;
                tPass.Text = listViewKullanicilar.SelectedItems[0].SubItems[2].Text;
                checkBoxAdmin.Checked = listViewKullanicilar.SelectedItems[0].SubItems[3].Text == "True" ? true : false;
            }
        }

        private void buttonTemizle2_Click(object sender, EventArgs e)
        {
            tId.Text = "";
            tUser.Text = "";
            tPass.Text = "";
            checkBoxAdmin.Checked = false;
            listViewKullanicilar.Items.Clear();

            setFoundRecords(0);
            setProgressBarValue(0);
        }

        private void buttonAra2_Click(object sender, EventArgs e)
        {
            string komutString;

            setProgressBarValue(0);
            if (tId.Text != "")
            {
                if (!IsNumeric(tId.Text))
                {
                    MessageBox.Show("Id Yanlış Girdiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                komutString = "select * from User where id=" + tId.Text;
            }
            else if (tUser.Text != "" )
            {
                komutString = "select * from User where kullaniciAdi='" + tUser.Text +"'";
            }
            else
            {
                return;
            }

            setProgressBarValue(40);
            if (MySQLHelper.select(komutString, listViewKullanicilar).Items.Count == 0)
            {
                MessageBox.Show("Kayıt bulunamadı", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                setProgressBarValue(0);
            }
            else
            {
                setProgressBarValue(100);
            }
            setFoundRecords(listViewKullanicilar.Items.Count);
        }

        private void buttonEkle2_Click(object sender, EventArgs e)
        {
            string komutString;

            if (!IsNumeric(tId.Text))
            {
                MessageBox.Show("ID Yanlış Girdiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;//Hata
            }
            komutString = "select id from User where id='" + tId.Text + "' or kullaniciAdi='" + tUser.Text + "'";

            if (MySQLHelper.select(komutString).Count == 0)
            {
                //Ekleme
                ListViewItem item = new ListViewItem();
                item.Text = tId.Text;
                item.SubItems.Add(tUser.Text);
                item.SubItems.Add(tPass.Text);

                if (checkBoxAdmin.Checked)
                    item.SubItems.Add("1");
                else
                    item.SubItems.Add("0");
                if (MySQLHelper.insert(item, "User"))
                {
                    MessageBox.Show("Kayıt eklendi!", "Başarılı!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    buttonAra2_Click(new object(), new EventArgs());
                }
            }
            else
            {
                MessageBox.Show("ID numarasına ya da kullanıcı adına sahip bir kullanıcı zaten var.", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        private void buttonGuncelle2_Click(object sender, EventArgs e)
        {
            string komutString;

            if (!IsNumeric(tId.Text))
            {
                MessageBox.Show("ID'yi Yanlış Girdiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            komutString = "select id from User where id=" + tId.Text;

            ArrayList al = MySQLHelper.select(komutString);

            if (al.Count == 0 || (al.Count == 1 && al[0].ToString().Equals(listViewKullanicilar.SelectedItems[0].SubItems[0].Text)))
            {
                string[] userTList = { tId.Text, tUser.Text, tPass.Text, checkBoxAdmin.Checked ? "1":"0" };
                ListViewItem item = new ListViewItem(userTList);

                if (MySQLHelper.update(item, "User", "id", listViewKullanicilar.SelectedItems[0].SubItems[0].Text, kullanıcıColumns))
                {
                    MessageBox.Show("Kayıt güncellendi!", "Başarılı!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    buttonAra2_Click(new object(), new EventArgs());
                }
            }
            else
            {
                MessageBox.Show("Bu ID numarasına sahip bir vatandaş zaten var.", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonSil2_Click(object sender, EventArgs e)
        {
            if (MySQLHelper.delete("User", "id", 0, listViewKullanicilar.SelectedItems))
            {
                MessageBox.Show("Kayıt(lar) silindi!", "Başarılı!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                buttonTemizle2_Click(new object(), new EventArgs());
            }
        }

        private void buttonTümünüListele2_Click(object sender, EventArgs e)
        {
            setProgressBarValue(0);
            setProgressBarValue(40);

            if (MySQLHelper.select("select * from User", listViewKullanicilar).Items.Count == 0)
            {
                MessageBox.Show("Kayıt bulunamadı", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                setProgressBarValue(0);
            }
            else
            {
                setProgressBarValue(100);
            }
            setFoundRecords(listViewKullanicilar.Items.Count);
        }
    }
}
