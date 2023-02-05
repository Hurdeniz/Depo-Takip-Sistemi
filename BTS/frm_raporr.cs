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
    public partial class frm_raporr : DevExpress.XtraEditors.XtraForm
    {
        public frm_raporr(XtraReport rapor)
        {
            InitializeComponent();
            documentViewer1.DocumentSource = rapor;
        }

        private void frm_raporr_Load(object sender, EventArgs e)
        {
            
            
        }
    }
}