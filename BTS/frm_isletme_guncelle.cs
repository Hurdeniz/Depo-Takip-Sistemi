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
    public partial class frm_isletme_guncelle : DevExpress.XtraEditors.XtraForm
    {
        public frm_isletme_guncelle()
        {
            InitializeComponent();
        }
        SqlConnection bag = new SqlConnection(@"Data Source=.;Initial Catalog=db_bts;Integrated Security=True");
        public int isletme_id;
        private void frm_isletme_guncelle_Load(object sender, EventArgs e)
        {
            isletme_bilgiler();
        }
        // İŞLETME BİLGİLERİ VERİ TABANINDAN ÇEKME
        public void isletme_bilgiler()
        {
            bag.Open();
            SqlCommand kmt = new SqlCommand("select * from tbl_yeni_isletme where isletme_id=@p1", bag);
            kmt.Parameters.AddWithValue("@p1", isletme_id.ToString());

            SqlDataReader oku = kmt.ExecuteReader();
            while (oku.Read())
            {
                txt_isletme_no.Text = oku["isletme_no"].ToString();
                txt_isletme_adi.Text = oku["isletme_adi"].ToString();
                txt_isletme_sahibi.Text = oku["isletme_sahibi"].ToString();
                txt_irtibat_kisi.Text = oku["irtibat_kisi"].ToString();
                txt_telefon.Text = oku["irtibat_telefon"].ToString();
                cmb_isletme_durumu.Text = oku["isletme_durumu"].ToString();



            }
            bag.Close();
        }

        //GRİDDEN TEXTBOXLARA VERİ AKTARMA
        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
         
        }
        
        private void btn_ileri_Click(object sender, EventArgs e)
        {
           
        }
       
        private void btn_kaydet_Click(object sender, EventArgs e)
        {
        }
      
        
   

        private void txt_erkek_hayvan_KeyDown(object sender, KeyEventArgs e)
        {
           
        }

        private void txt_disi_hayvan_KeyDown(object sender, KeyEventArgs e)
        {
           
        }

        private void txt_dolum_suresi_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void txt_doluluk_orani_KeyDown(object sender, KeyEventArgs e)
        {
          
        }

     
        private void memo_adres_KeyDown(object sender, KeyEventArgs e)
        {
           
        }
        

        private void txt_depo_kapasitesi_KeyDown(object sender, KeyEventArgs e)
        {
          
        }
        //KAYDET BUTONU
        private void btn_kaydet_Click_1(object sender, EventArgs e)
        {
            guncelle_kaydet();
        }
        void guncelle_kaydet()
        {
            

            



            bag.Open();
            SqlCommand kmt = new SqlCommand("update tbl_yeni_isletme set isletme_no=@p1,isletme_adi=@p2,isletme_sahibi=@p3,isletme_durumu=@p4,irtibat_kisi=@p5,irtibat_telefon=@p6 where isletme_id=@p7", bag);
            kmt.Parameters.AddWithValue("@p1", txt_isletme_no.Text);
            kmt.Parameters.AddWithValue("@p2", txt_isletme_adi.Text);
            kmt.Parameters.AddWithValue("@p3", txt_isletme_sahibi.Text);
            kmt.Parameters.AddWithValue("@p4", cmb_isletme_durumu.Text);
            kmt.Parameters.AddWithValue("@p5", txt_irtibat_kisi.Text);
            kmt.Parameters.AddWithValue("@p6", txt_telefon.Text);
            kmt.Parameters.AddWithValue("@p7", Convert.ToInt32(isletme_id.ToString()));

            kmt.Connection = bag;

            SqlTransaction trans;
            trans = bag.BeginTransaction();
            kmt.Transaction = trans;

            try
            {
                kmt.ExecuteNonQuery();
                trans.Commit();
                XtraMessageBox.Show("İŞLETME BİLGİLERİNİZ GÜNCELLENMİŞTİR.", "GÜNCELLEME BAŞARILI ", MessageBoxButtons.OK);

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

            // İŞLETME PASİF FORMUNDAKİ GRİD YENİLEME

            frm_isletmeler frm_isletmeler = (frm_isletmeler)Application.OpenForms["frm_isletmeler"];
            frm_isletmeler.listele_isletme();

            //FORM KAPAT
            this.Close();
        }

        private void txt_isletme_no_KeyDown(object sender, KeyEventArgs e)
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

        private void txt_isletme_sahibi_KeyDown(object sender, KeyEventArgs e)
        {
            //ENTER TUSU
            if (e.KeyCode == Keys.Enter)
            {
                guncelle_kaydet();
            }
        }

        private void txt_irtibat_kisi_KeyDown(object sender, KeyEventArgs e)
        {
            //ENTER TUSU
            if (e.KeyCode == Keys.Enter)
            {
                guncelle_kaydet();
            }
        }

        private void txt_telefon_KeyDown(object sender, KeyEventArgs e)
        {
            //ENTER TUSU
            if (e.KeyCode == Keys.Enter)
            {
                guncelle_kaydet();
            }
        }

        private void cmb_isletme_durumu_KeyDown(object sender, KeyEventArgs e)
        {
            //ENTER TUSU
            if (e.KeyCode == Keys.Enter)
            {
                guncelle_kaydet();
            }
        }
    }
}