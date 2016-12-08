using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsProje
{
    class MSSQLHelper
    {
        public static SqlConnection baglanti; //Bağlantı degiskeni
        public static SqlCommand komut;

        public static void ilkle(string connectionString)
        {
            baglanti = new SqlConnection(connectionString);
            komut = new SqlCommand();
            komut.Connection = baglanti;
        }

        public static ListView select(string komutString, ListView doldurulacakListView)
        {
            try
            {
                baglanti.Open();
                komut.CommandText = komutString;
                SqlDataReader reader = komut.ExecuteReader();

                doldurulacakListView.Items.Clear();

                while (reader.Read())
                {
                    ListViewItem item = new ListViewItem();
                    item.Text = reader[0].ToString();

                    for (int i = 1; i < doldurulacakListView.Columns.Count; i++)
                    {
                        item.SubItems.Add(reader[i].ToString());
                    }

                    doldurulacakListView.Items.Add(item);

                }
                baglanti.Close();
            }
            catch (Exception e)
            {
                baglanti.Close();
                MessageBox.Show("Veritabanı hatası." + e.ToString(), "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return doldurulacakListView;
        }

        public static ArrayList select(string komutString)
        {
            ArrayList list = new ArrayList();
            try
            {
                baglanti.Open();
                komut.CommandText = komutString;
                SqlDataReader reader = komut.ExecuteReader();
                while (reader.Read())
                {
                    list.Add(reader[0]);
                }

                baglanti.Close();
            }
            catch (Exception e)
            {
                baglanti.Close();
                MessageBox.Show("Veritabanı hatası. " + e.ToString(), "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return list;
        }

        public static ListView select(string tablo, List<string> columnNames, List<string> columnValues, ListView doldurulacakListView)
        {
            string komut = "select * from " + tablo + " where " + columnNames[0] + "='" + columnValues[0] + "'";

            for (int i = 1; i < columnNames.Count; i++)
            {
                komut += " AND " + columnNames[i] + "='" + columnValues[i] + "'";
            }

            return select(komut, doldurulacakListView);
        }
             
        public static bool exists(string tablo, string[] columns, string[] values)
        {
            string komutString = "select * from " + tablo + " where";

            for(int i=0; i<columns.Length; i++)
            {
                komutString += " " + columns[i] + " ='" + values[i] + "'";
                if (i != columns.Length - 1)
                    komutString += " AND";
            }

            try
            {
                baglanti.Open();
                komut.CommandText = komutString;
                SqlDataReader reader = komut.ExecuteReader();
                if (reader.Read())
                {
                    baglanti.Close();
                    return true;
                }
                else
                {
                    baglanti.Close();
                    return false;
                }
            }
            catch (Exception e)
            {
                baglanti.Close();
                MessageBox.Show("Veritabanı hatası. " + e.ToString(), "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public static bool insert(ListViewItem item, string tabloAdı) // Bir ListViewItem ve bir tablo adı alıp o veriyi o tabloya işleyen metod
        {
            string komut = "insert into " + tabloAdı + " values('" + item.SubItems[0].Text + "'";

            for (int i = 1; i < item.SubItems.Count; i++)
            {
                komut += ",'" + item.SubItems[i].Text + "'";
            }

            komut += ")";

            return execute(komut);
        }

        public static bool update(ListViewItem item, string tablo, string pkName, string primaryKeyValue, string[] columnNames)
        {
            string komut = "update " + tablo + " set " + columnNames[0] + "='" + item.SubItems[0].Text + "'";

            for (int i = 1; i < item.SubItems.Count; i++)
            {
                komut += ", " + columnNames[i] + "='" + item.SubItems[i].Text + "'";

            }

            komut += "where " + pkName + "='" + primaryKeyValue + "'";

            return MSSQLHelper.execute(komut);
        }

        public static bool delete(string tablo, string pkName, string primaryKeyValue)
        {
            string komut = "delete from " + tablo + " where " + pkName + " = '" + primaryKeyValue + "'";
            return MSSQLHelper.execute(komut);
        }

        public static bool delete(string tablo, string pkName, int pkIndex, ListView.SelectedListViewItemCollection items)
        {
            bool succeed = false;
            foreach (ListViewItem item in items)
            {
                succeed = delete(tablo, pkName, item.SubItems[pkIndex].Text);
            }
            return succeed;
        }

        public static bool execute(string komutString)
        {
            try
            {
                baglanti.Open();
                komut.CommandText = komutString;
                komut.ExecuteNonQuery();
                baglanti.Close();
                return true;
            }
            catch (Exception e)
            {
                baglanti.Close();
                MessageBox.Show("Veritabanı hatası. " + e.ToString(), "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }
}
