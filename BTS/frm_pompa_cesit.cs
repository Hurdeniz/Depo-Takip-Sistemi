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
    public partial class frm_pompa_cesit : DevExpress.XtraEditors.XtraForm
    {
        public frm_pompa_cesit()
        {
            InitializeComponent();
        }
        SqlConnection bag = new SqlConnection(@"Data Source=.;Initial Catalog=db_bts;Integrated Security=True");


        public int isletme_depo_cesit_id;
     
        private void frm_pompa_cesit_Load(object sender, EventArgs e)
        {

        }

        private void checkEdit1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkEdit1.Checked == true)
            {
                checkEdit2.Enabled = false;


            }
            else
            {
                checkEdit1.Checked = false;
                checkEdit2.Enabled = true;


            }
        }

        private void checkEdit2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkEdit2.Checked == true)
            {
                checkEdit1.Enabled = false;


            }
            else
            {
                checkEdit2.Checked = false;
                checkEdit1.Enabled = true;


            }
        }
        //KAYDET
        string adi;
        private void btn_kaydet_Click(object sender, EventArgs e)
        {
            if (checkEdit1.Checked == true)
            {

                adi = "ET1";
                kaydet();

            }
            else if (checkEdit2.Checked == true)
            {

                adi = "-";
                kaydet();

            }

            else
            {
                XtraMessageBox.Show("LÜTFEN POMPA ÇEŞİTİ SEÇİNİZ", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        void kaydet()
        {

            bag.Open();
            SqlCommand kmt = new SqlCommand("update tbl_isletme_depo set pompa_cesit=@p1 where depo_id=@p2 ", bag);
            kmt.Parameters.AddWithValue("@p1", adi.ToString());
            kmt.Parameters.AddWithValue("@p2", isletme_depo_cesit_id.ToString());

            kmt.Connection = bag;

            SqlTransaction trans;
            trans = bag.BeginTransaction();
            kmt.Transaction = trans;

            try
            {
                kmt.ExecuteNonQuery();
                trans.Commit();
                XtraMessageBox.Show("İŞLETME DEPO POMPA ÇEŞİTİNİZ GÜNCELLENMİŞTİR.", "GÜNCELLEME BAŞARILI ", MessageBoxButtons.OK);

            }
            catch
            {
                trans.Rollback();
                XtraMessageBox.Show("GÜNCELLEME YAPILAMAMIŞTIR.LÜTFEN ALANLARI KONTROL EDİN DOĞRU BİLGİ GİRDİĞİNİZDEN EMİN OLUN", "GÜNCELLEME BAŞARISIZ ", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            finally
            {
                bag.Close();
            }

            // POMPALI FORMUNDAKİ GRİD YENİLEME

            frm_depo_pompali pompali = (frm_depo_pompali)Application.OpenForms["frm_depo_pompali"];
            pompali.depo_pompali();

            //FORM KAPAT
            this.Close();
        }
    }

}