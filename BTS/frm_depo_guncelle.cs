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
    public partial class frm_depo_guncelle : DevExpress.XtraEditors.XtraForm
    {
        public frm_depo_guncelle()
        {
            InitializeComponent();
        }
        SqlConnection bag = new SqlConnection(@"Data Source=.;Initial Catalog=db_bts;Integrated Security=True");
        public int depo_id;
        private void frm_depo_guncelle_Load(object sender, EventArgs e)
        {
            depo_bilgiler();
        }
        // DEPO BİLGİLERİ VERİ TABANINDAN ÇEKME
        public void depo_bilgiler()
        {
            DateTime a;
            bag.Open();
            SqlCommand kmt = new SqlCommand("select * from tbl_isletme_depo where depo_id=@p1", bag);
            kmt.Parameters.AddWithValue("@p1", depo_id.ToString());

            SqlDataReader oku = kmt.ExecuteReader();
            while (oku.Read())
            {
                txt_depo_no.Text = oku["depo_no"].ToString();
                cmb_depo_durumu.Text = oku["depo_durum"].ToString();
                cmb_depo_durum.Text = oku["depo_durumu"].ToString();
                txt_depo_kapasitesi.Text = oku["depo_kapasitesi"].ToString();
                txt_doluluk_orani.Text = oku["doluluk_miktar"].ToString();
                txt_dolum_suresi.Text = oku["dolum_suresi"].ToString();
                txt_erkek_hayvan.Text = oku["erkek_hayvan"].ToString();
                txt_disi_hayvan.Text = oku["disi_hayvan"].ToString();
                a =Convert.ToDateTime( oku["dolum_tarihi"].ToString());
                date_dolum_tarih.Text = a.ToShortDateString();
                txt_resim.Text = oku["resim"].ToString();
                memo_adres.Text = oku["adres"].ToString();



            }
            bag.Close();
        }
       
        int erkek, disi, sonuc, kapasite, doluluk, sure, sonuc1, sonuc2;

        private void txt_resim_KeyDown(object sender, KeyEventArgs e)
        {
            //ENTER TUSU
            if (e.KeyCode == Keys.Enter)
            {
                kaydet();
            }
        }

        private void cmb_depo_durumu_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void cmb_depo_durumu_KeyDown(object sender, KeyEventArgs e)
        {
            //ENTER TUSU
            if (e.KeyCode == Keys.Enter)
            {
                kaydet();
            }
        }

        private void memo_adres_KeyDown(object sender, KeyEventArgs e)
        {
            //ENTER TUSU
            if (e.KeyCode == Keys.Enter)
            {
                kaydet();
            }
        }

        private void txt_depo_kapasitesi_KeyDown(object sender, KeyEventArgs e)
        {
            //ENTER TUSU
            if (e.KeyCode == Keys.Enter)
            {
                kaydet();
            }
        }

        private void txt_doluluk_orani_KeyDown(object sender, KeyEventArgs e)
        {
            //ENTER TUSU
            if (e.KeyCode == Keys.Enter)
            {
                kaydet();
            }
        }

        private void txt_dolum_suresi_KeyDown(object sender, KeyEventArgs e)
        {
            //ENTER TUSU
            if (e.KeyCode == Keys.Enter)
            {
                kaydet();
            }
        }

        private void txt_erkek_hayvan_KeyDown(object sender, KeyEventArgs e)
        {
            //ENTER TUSU
            if (e.KeyCode == Keys.Enter)
            {
                kaydet();
            }
        }

        private void txt_disi_hayvan_KeyDown(object sender, KeyEventArgs e)
        {
            //ENTER TUSU
            if (e.KeyCode == Keys.Enter)
            {
                kaydet();
            }
        }

        private void date_dolum_tarih_KeyDown(object sender, KeyEventArgs e)
        {
            //ENTER TUSU
            if (e.KeyCode == Keys.Enter)
            {
                kaydet();
            }
        }

        private void cmb_depo_durum_KeyDown(object sender, KeyEventArgs e)
        {
            //ENTER TUSU
            if (e.KeyCode == Keys.Enter)
            {
                kaydet();
            }
        }

        private void txt_depo_no_KeyDown(object sender, KeyEventArgs e)
        {
            //ENTER TUSU
            if (e.KeyCode == Keys.Enter)
            {
                kaydet();
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
            kaydet();
        }
        //VERİ KAYDETME       
        public void kaydet()
        {
            depo_hesap();

            bag.Open();
            SqlCommand kmt = new SqlCommand("update tbl_isletme_depo set depo_no=@p1,depo_durumu=@p2,resim=@p3,depo_durum=@p4,adres=@p5,depo_kapasitesi=@p6,doluluk_miktar=@p7,dolum_suresi=@p8,gunluk_dolum=@p9,kalan_miktar=@p10,erkek_hayvan=@p11,disi_hayvan=@p12,hayvan_sayisi=@p13,dolum_tarihi=@p14 where depo_id=@p15", bag);
            kmt.Parameters.AddWithValue("@p1", txt_depo_no.Text);
            kmt.Parameters.AddWithValue("@p2", cmb_depo_durum.Text);
            kmt.Parameters.AddWithValue("@p3", txt_resim.Text);
            kmt.Parameters.AddWithValue("@p4", cmb_depo_durumu.Text);
            kmt.Parameters.AddWithValue("@p5", memo_adres.Text);
            kmt.Parameters.AddWithValue("@p6", Convert.ToInt32(txt_depo_kapasitesi.Text));
            kmt.Parameters.AddWithValue("@p7", Convert.ToInt32(txt_doluluk_orani.Text));
            kmt.Parameters.AddWithValue("@p8", Convert.ToInt32(txt_dolum_suresi.Text));
            kmt.Parameters.AddWithValue("@p9", Convert.ToInt32(sonuc1.ToString()));
            kmt.Parameters.AddWithValue("@p10", Convert.ToInt32(sonuc2.ToString()));
            kmt.Parameters.AddWithValue("@p11", Convert.ToInt32(txt_erkek_hayvan.Text));
            kmt.Parameters.AddWithValue("@p12", Convert.ToInt32(txt_disi_hayvan.Text));
            kmt.Parameters.AddWithValue("@p13", Convert.ToInt32(sonuc.ToString()));
            kmt.Parameters.AddWithValue("@p14", Convert.ToDateTime(date_dolum_tarih.Text));
            kmt.Parameters.AddWithValue("@p15", Convert.ToInt32(depo_id.ToString()));

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

            frm_depolar depolar = (frm_depolar)Application.OpenForms["frm_depolar"];
            depolar.listele_depolar();

            //FORM KAPAT
            this.Close();


        }
       
    private void cmb_depo_durum_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }
        //RESİM
        private void txt_resim_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            xtraOpenFileDialog1.ShowDialog();
            txt_resim.Text = xtraOpenFileDialog1.FileName;
        }
    }
}