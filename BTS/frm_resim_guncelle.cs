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
    public partial class frm_resim_guncelle : DevExpress.XtraEditors.XtraForm
    {
        public frm_resim_guncelle()
        {
            InitializeComponent();
        }
        SqlConnection bag = new SqlConnection(@"Data Source=.;Initial Catalog=db_bts;Integrated Security=True");
        public int isletme_id;
        private void frm_resim_guncelle_Load(object sender, EventArgs e)
        {
            isletme_bilgiler();
        }
        // İŞLETME BİLGİLERİ VERİ TABANINDAN ÇEKME
        public void isletme_bilgiler()
        {
            bag.Open();
            SqlCommand kmt = new SqlCommand("select * from tbl_isletme_depo where depo_id=@p1", bag);
            kmt.Parameters.AddWithValue("@p1", isletme_id.ToString());

            SqlDataReader oku = kmt.ExecuteReader();
            while (oku.Read())
            {
               
                txt_isletme_no.Text = oku["depo_id"].ToString();
                txt_isletme_adi.Text = oku["depo_no"].ToString();
             

            }
            bag.Close();
        }

        private void btn_kaydet_Click(object sender, EventArgs e)
        {
            kaydet();
        }
        // VERİ GÜNCELLEME
        void kaydet()
        {

            bag.Open();
            SqlCommand kmt = new SqlCommand("update tbl_isletme_depo set resim=@p1 where depo_id=@p2", bag);
            kmt.Parameters.AddWithValue("@p1", txt_resim.Text);
            kmt.Parameters.AddWithValue("@p2", isletme_id.ToString());

            kmt.Connection = bag;

            SqlTransaction trans;
            trans = bag.BeginTransaction();
            kmt.Transaction = trans;

            try
            {
                kmt.ExecuteNonQuery();
                trans.Commit();
                XtraMessageBox.Show("İŞLETME DEPO RESMİ GÜNCELLENMİŞTİR.", "GÜNCELLEME BAŞARILI ", MessageBoxButtons.OK);

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



            // E-GELECEK FORMUNDAKİ GRİD YENİLEME

            frm_kapasite_durum kapasite_depo = (frm_kapasite_durum)Application.OpenForms["frm_kapasite_durum"];
            kapasite_depo.depo_listele();

            //FORM KAPAT
            this.Close();


        }

        private void txt_resim_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {

            xtraOpenFileDialog1.ShowDialog();
            txt_resim.Text = xtraOpenFileDialog1.FileName;
        }
    }
}