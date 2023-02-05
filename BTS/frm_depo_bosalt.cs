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
    public partial class frm_depo_bosalt : DevExpress.XtraEditors.XtraForm
    {
        public frm_depo_bosalt()
        {
            InitializeComponent();
        }
        SqlConnection bag = new SqlConnection(@"Data Source=.;Initial Catalog=db_bts;Integrated Security=True");
        public int sevkiyat_id;
        public string isletme_no, isletme_adi, depo_no;

        private void btn_kaydet_Click(object sender, EventArgs e)
        {
            kaydet();
        }

        private void memo_aciklama_KeyDown(object sender, KeyEventArgs e)
        {
            //ENTER TUSU
            if (e.KeyCode == Keys.Enter)
            {
                kaydet();

            }
        }

        void kaydet()
        {

            bag.Open();
            SqlCommand kmt = new SqlCommand("update tbl_yeni_sevkiyat set aciklama=@p1 where sevkiyat_id=@p2", bag);
            kmt.Parameters.AddWithValue("@p1", memo_aciklama.Text);
            kmt.Parameters.AddWithValue("@p2", sevkiyat_id.ToString());

            kmt.Connection = bag;

            SqlTransaction trans;
            trans = bag.BeginTransaction();
            kmt.Transaction = trans;

            try
            {
                kmt.ExecuteNonQuery();
                trans.Commit();
                XtraMessageBox.Show("İŞLETME DEPONUZ BOŞALTILMIŞTIR", "GÜNCELLEME BAŞARILI ", MessageBoxButtons.OK);

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



            // SEVKİYAT FORMUNDAKİ GRİD YENİLEME

            frm_sevkiyat_listesi sevkiyat = (frm_sevkiyat_listesi)Application.OpenForms["frm_sevkiyat_listesi"];
            sevkiyat.listele_sevkiyat();

            //FORM KAPAT
            this.Close();
        }
        private void frm_depo_bosalt_Load(object sender, EventArgs e)
        {
            txt_isletme_no.Text = isletme_no.ToString();
            txt_isletme_adi.Text = isletme_adi.ToString();
            txt_depo_no.Text = depo_no.ToString();
        }
    }
}