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
using System.Data.SqlClient;

namespace BTS
{
    public partial class frm_depo_resim : DevExpress.XtraEditors.XtraForm
    {
        public frm_depo_resim()
        {
            InitializeComponent();
        }
        SqlConnection bag = new SqlConnection(@"Data Source=.;Initial Catalog=db_bts;Integrated Security=True");
        public int depo_resim_id;
        private void frm_depo_resim_Load(object sender, EventArgs e)
        {
            isletme_resim();
            pictureBox1.ImageLocation = resim.ToString();
        }
        // İŞLETME RESİM YOLU VERİ TABANINDAN ÇEKME
        String resim;
        public void isletme_resim()
        {
            bag.Open();
            SqlCommand kmt = new SqlCommand("select * from tbl_isletme_depo where depo_id=@p1", bag);
            kmt.Parameters.AddWithValue("@p1", depo_resim_id.ToString());

            SqlDataReader oku = kmt.ExecuteReader();
            while (oku.Read())
            {

                resim = oku["resim"].ToString();
               


            }
            bag.Close();
            if (resim=="")
            {
                XtraMessageBox.Show("İŞLETMEYE AİT RESİM YOKTUR.", "RESİM YOK ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }
    }
}