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
    public partial class VatandaşForm : Form
    {
        private static VatandaşForm form = null;

        private VatandaşForm()
        {
            InitializeComponent();
        }

        public static VatandaşForm getForm()
        {
            if (form == null)
            {
                form = new VatandaşForm();
                form.Show();
            }
            return form;
        }

        public void openChild(Vatandaş vatandaş)
        {
            vatandaş.MdiParent = this;
            vatandaş.Show();
        }

        private void VatandaşForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            form = null;
        }
    }
}
