using MySql.Data.MySqlClient;
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
    public partial class NüfusKayıtÖrneği : Form
    {
        public static MySqlConnection bağlantı; 
        public static MySqlCommand komut;

        private string tcno;
        private Form senderForm;
        public NüfusKayıtÖrneği(Form senderForm, string tcno)
        {
            InitializeComponent();
            this.tcno = tcno;
            this.senderForm = senderForm;

            bağlantı = new MySqlConnection(Giriş.connectionString);
            komut = new MySqlCommand();
            komut.Connection = bağlantı;
        }

        private void NüfusKayıtÖrneği_Load(object sender, EventArgs e)
        {
            try
            {
                bağlantı.Open();
                MySqlDataReader reader;

                ListViewItem item;

                komut.CommandText = "select ad from Citizen where tcno='" + this.tcno + "'";
                reader = komut.ExecuteReader();
                if (reader.Read())
                {
                    item = new ListViewItem();
                    item.Text = "Kendisi";
                    item.SubItems.Add(reader[0].ToString());
                    listView.Items.Add(item);
                }
                reader.Close();

                komut.CommandText = "select Citizen.ad from Citizen, Marriage where Marriage.erkek='" + this.tcno + "' and Marriage.kadin=Citizen.tcno";
                reader = komut.ExecuteReader();
                if (reader.Read())
                {
                    item = new ListViewItem();
                    item.Text = "Karısı";
                    item.SubItems.Add(reader[0].ToString());
                    listView.Items.Add(item);
                }
                else
                {
                    reader.Close();

                    komut.CommandText = "select Citizen.ad from Citizen, Marriage where Marriage.kadın='" + this.tcno + "' and Marriage.erkek=Citizen.tcno";
                    reader = komut.ExecuteReader();
                    if (reader.Read())
                    {
                        item = new ListViewItem();
                        item.Text = "Kocası";
                        item.SubItems.Add(reader[0].ToString());
                        listView.Items.Add(item);
                    }
                }
                reader.Close();

                komut.CommandText = "select b.ad from Citizen a, Citizen b where a.baba is not null and a.tcno='" + this.tcno + "' and a.baba=b.tcno";
                reader = komut.ExecuteReader();
                if (reader.Read())
                {
                    item = new ListViewItem();
                    item.Text = "Babası";
                    item.SubItems.Add(reader[0].ToString());
                    listView.Items.Add(item);
                }
                reader.Close();

                komut.CommandText = "select b.ad from Citizen a, Citizen b where a.anne is not null and a.tcno='" + this.tcno + "' and a.anne=b.tcno";
                reader = komut.ExecuteReader();
                if (reader.Read())
                {
                    item = new ListViewItem();
                    item.Text = "Annesi";
                    item.SubItems.Add(reader[0].ToString());
                    listView.Items.Add(item);
                }
                reader.Close();

                komut.CommandText = "select b.ad from Citizen a, Citizen b where a.tcno='" + this.tcno + "' and a.tcno<>b.tcno and ((a.baba=b.baba and a.baba is not null and a.baba<>'') or (a.anne=b.anne and a.anne is not null and a.anne<>''))";
                reader = komut.ExecuteReader();
                while (reader.Read())
                {
                    item = new ListViewItem();
                    item.Text = "Kardeşi";
                    item.SubItems.Add(reader[0].ToString());
                    listView.Items.Add(item);
                }
                reader.Close();

                komut.CommandText = "select b.ad from Citizen a, Citizen b where a.tcno='" + this.tcno + "' and (a.tcno=b.baba or a.tcno=b.anne)";
                reader = komut.ExecuteReader();
                while (reader.Read())
                {
                    item = new ListViewItem();
                    item.Text = "Çocuğu";
                    item.SubItems.Add(reader[0].ToString());
                    listView.Items.Add(item);
                }
                reader.Close();

                bağlantı.Close();
            }
            catch (Exception exc)
            {
                bağlantı.Close();
                MessageBox.Show("Veritabanı hatası. " + exc.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void NüfusKayıtÖrneği_FormClosed(object sender, FormClosedEventArgs e)
        {
            senderForm.Enabled = true;
        }
    }
}
