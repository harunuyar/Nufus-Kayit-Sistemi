using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsProjeBase
{
    public partial class PanelBase : Form
    {
        protected Form senderForm;
        protected bool appExit;

        public PanelBase()
        {
            InitializeComponent();
            this.senderForm = null;
            appExit = false;
        }

        public PanelBase(Form senderForm)
        {
            InitializeComponent();
            this.senderForm = senderForm;
            appExit = false;
        }

        protected void oturumuKapat(object sender, EventArgs e)
        {
            appExit = false;
            this.Close();
        }

        protected void programıKapat(object sender, EventArgs e)
        {
            appExit = true;
            this.Close();
        }

        protected void PanelBase_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (appExit)
            {
                if (MessageBox.Show("Programı kapatmak istiyor musunuz?", "Programı Kapat", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                {
                    e.Cancel = true;
                    appExit = false;
                }
            }
            else
            {
                if (MessageBox.Show("Oturumu kapatmak istiyor musunuz?", "Oturumu Kapat", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                {
                    e.Cancel = true;
                    appExit = false;
                }
            }
        }

        protected void PanelBase_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (appExit)
            {
                Application.Exit();
            }
            else
            {
                senderForm.Show();
            }
        }

        protected void hakkında(object sender, EventArgs e)
        {
            MessageBox.Show("Hakkında", "Harun Uyar\n" +
                                        "Naim Yürek\n" +
                                        "Sedat Girgin");
        }

        protected void setFoundRecords(int value)
        {
            this.searchStatus.setFoundRecords(value);
        }

        protected void setProgressBarValue(int value)
        {
            this.searchStatus.setProgressBarValue(value);
        }
    }
}
