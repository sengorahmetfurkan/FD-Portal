using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FD_Portal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnyeniteklif_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.Teklifcalismasi teklifcalismasi = new Formlar.Teklifcalismasi();
            teklifcalismasi.MdiParent = this;
            teklifcalismasi.Show();
        }

        private void newteklif_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.yeniteklif yeniteklif = new Formlar.yeniteklif();
            yeniteklif.MdiParent = this;
            yeniteklif.Show();
        }
    }
}
