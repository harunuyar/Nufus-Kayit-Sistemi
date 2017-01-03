using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsProjeBase
{
    public partial class SearchStatus : UserControl
    {
        private static string label = "Bulunan kayıt sayısı: ";

        public SearchStatus()
        {
            InitializeComponent();
            setFoundRecords(0);
            setProgressBarValue(0);
        }

        public void setProgressBarValue(int value)
        {
            this.toolStripProgressBar.Value = value;
        }

        public void setFoundRecords(int value)
        {
            this.toolStripStatusLabel.Text = label + value;
        }
    }
}
