using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraReports.UI;

namespace BTS
{
    public partial class deneme : DevExpress.XtraEditors.XtraForm
    {
        private XtraReport rapor;
        public deneme()
        {
            InitializeComponent();
        }

        private void deneme_Load(object sender, EventArgs e)
        {

        }

        private void navBarControl1_Click(object sender, EventArgs e)
        {
          

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            filterControl1.Refresh();
            rapor.FilterString = filterControl1.FilterString;
            frm_raporr frm = new frm_raporr(rapor);
            frm.Show();
        }

        private void navBarItem1_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
         
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
           
        }
    }
}