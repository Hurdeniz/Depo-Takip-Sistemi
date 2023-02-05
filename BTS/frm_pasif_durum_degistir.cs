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
    public partial class frm_pasif_durum_degistir : DevExpress.XtraEditors.XtraForm
    {
        public frm_pasif_durum_degistir()
        {
            InitializeComponent();
        }
        SqlConnection bag = new SqlConnection(@"Data Source=.;Initial Catalog=db_bts;Integrated Security=True");
     
        public int isletme_depo_id;
        private void frm_pasif_durum_degistir_Load(object sender, EventArgs e)
        {
            txt_doluluk_orani.Focus();
            isletme_bilgiler();
        }
        // İŞLETME BİLGİLERİ VERİ TABANINDAN ÇEKME
        public void isletme_bilgiler()
        {
            bag.Open();
            SqlCommand kmt = new SqlCommand("select * from tbl_isletme_depo where depo_id=@p1", bag);
            kmt.Parameters.AddWithValue("@p1", isletme_depo_id.ToString());

            SqlDataReader oku = kmt.ExecuteReader();
            while (oku.Read())
            {
                txt_isletme_adi.Text = oku["depo_no"].ToString();
                txt_depo_kapasitesi.Text = oku["depo_kapasitesi"].ToString();
             


            }
            bag.Close();
        }
 
        //DEPO HESAP
        int erkek, disi, sonuc, kapasite, doluluk, sure, sonuc1, sonuc2;

        private void txt_dolum_suresi_KeyDown(object sender, KeyEventArgs e)
        {
            //ENTER TUSU
            if (e.KeyCode == Keys.Enter)
            {
                guncelle_kaydet();
            }
        }

        private void txt_erkek_hayvan_KeyDown(object sender, KeyEventArgs e)
        {
            //ENTER TUSU
            if (e.KeyCode == Keys.Enter)
            {
                guncelle_kaydet();
            }
        }

        private void txt_disi_hayvan_KeyDown(object sender, KeyEventArgs e)
        {
            //ENTER TUSU
            if (e.KeyCode == Keys.Enter)
            {
                guncelle_kaydet();
            }
        }

        private void date_dolum_tarih_KeyDown(object sender, KeyEventArgs e)
        {
            //ENTER TUSU
            if (e.KeyCode == Keys.Enter)
            {
                guncelle_kaydet();
            }
        }

        private void txt_doluluk_orani_KeyDown(object sender, KeyEventArgs e)
        {
            //ENTER TUSU
            if (e.KeyCode == Keys.Enter)
            {
                guncelle_kaydet();
            }
        }

        private void txt_depo_kapasitesi_KeyDown(object sender, KeyEventArgs e)
        {
            //ENTER TUSU
            if (e.KeyCode == Keys.Enter)
            {
                guncelle_kaydet();
            }
        }

        private void txt_isletme_adi_KeyDown(object sender, KeyEventArgs e)
        {
            //ENTER TUSU
            if (e.KeyCode == Keys.Enter)
            {
                guncelle_kaydet();
            }
        }

        void depo_hesap()
        {
            kapasite = Convert.ToInt32(txt_depo_kapasitesi.Text);
            sure = Convert.ToInt32(txt_dolum_suresi.Text);
            doluluk = Convert.ToInt32(txt_doluluk_orani.Text);
            sonuc1 = kapasite / sure;
            sonuc2 = kapasite - doluluk;


            erkek = Convert.ToInt32(txt_erkek_hayvan.Text);
            disi = Convert.ToInt32(txt_disi_hayvan.Text);
            sonuc = erkek + disi;


        }
        //kaydet
        private void btn_kaydet_Click(object sender, EventArgs e)
        {
            guncelle_kaydet();
        }
        string isletme_durum = "AKTİF";
        void guncelle_kaydet()
        {

            depo_hesap();

            bag.Open();
            SqlCommand kmt = new SqlCommand("update tbl_isletme_depo set doluluk_miktar=@p1,dolum_suresi=@p2,gunluk_dolum=@p3,kalan_miktar=@p4,erkek_hayvan=@p5,disi_hayvan=@p6,hayvan_sayisi=@p7,dolum_tarihi=@p8,depo_durum=@p9 where depo_id=@p10", bag);           
            kmt.Parameters.AddWithValue("@p1", Convert.ToInt32(txt_doluluk_orani.Text));
            kmt.Parameters.AddWithValue("@p2", Convert.ToInt32(txt_dolum_suresi.Text));
            kmt.Parameters.AddWithValue("@p3", Convert.ToInt32(sonuc1.ToString()));
            kmt.Parameters.AddWithValue("@p4", Convert.ToInt32(sonuc2.ToString()));
            kmt.Parameters.AddWithValue("@p5", txt_erkek_hayvan.Text);
            kmt.Parameters.AddWithValue("@p6", txt_disi_hayvan.Text);
            kmt.Parameters.AddWithValue("@p7", sonuc.ToString());
            kmt.Parameters.AddWithValue("@p8", Convert.ToDateTime(date_dolum_tarih.Text));
            kmt.Parameters.AddWithValue("@p9", isletme_durum.ToString());
            kmt.Parameters.AddWithValue("@p10", isletme_depo_id.ToString());

            kmt.Connection = bag;

            SqlTransaction trans;
            trans = bag.BeginTransaction();
            kmt.Transaction = trans;

            try
            {
                kmt.ExecuteNonQuery();
                trans.Commit();
              
             
            }
            catch
            {
                trans.Rollback();
                XtraMessageBox.Show("DEPO DURUMUNUZ AKTİF YAPILAMAMIŞTIR.LÜTFEN ALANLARI KONTROL EDİN DOĞRU BİLGİ GİRDİĞİNİZDEN EMİN OLUN", "GÜNCELLEME BAŞARISIZ ", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            finally
            {
                bag.Close();
                // DEPOLAR  FORMUNDAKİ GRİD YENİLEME

                frm_depolar depolar = (frm_depolar)Application.OpenForms["frm_depolar"];
                depolar.listele_depolar();

                //FORM KAPAT
                this.Close();
            }
         

        }
    }
}