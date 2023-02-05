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
    public partial class frm_sevkiyat_olustur : DevExpress.XtraEditors.XtraForm
    {
        public frm_sevkiyat_olustur()
        {
            InitializeComponent();
        }

    SqlConnection bag = new SqlConnection(@"Data Source=.;Initial Catalog=db_bts;Integrated Security=True");

    DateTime tarih = DateTime.Now;
    DateTime baslangic, bitis;
    private void frm_sevkiyat_olustur_Load(object sender, EventArgs e)
        {
            cmb_personel.Focus();

            listele();

            personel();
            arac();
        }
        //GRİD DOLDUR
        void listele()
        {
            baslangic = Convert.ToDateTime(tarih.AddDays(-10).ToShortDateString());
            bitis = Convert.ToDateTime(tarih.AddDays(3).ToShortDateString());

            bag.Open();
            SqlDataAdapter adt = new SqlDataAdapter("select tbl_yeni_isletme.isletme_id,isletme_no,isletme_adi,depo_id,depo_no,depo_durumu,pompa_cesit,depo_kapasitesi,doluluk_miktar,gunluk_dolum,dolum_suresi,adres,tedarik_tarihi,dolum_tarihi from tbl_isletme_depo inner join tbl_yeni_isletme on tbl_isletme_depo.isletme_id = tbl_yeni_isletme.isletme_id where isletme_durumu = 'AKTİF' and depo_durum = 'AKTİF' and durum=0 and dolum_tarihi between @tar1 and @tar2 order by dolum_tarihi DESC", bag);
            adt.SelectCommand.Parameters.AddWithValue("@tar1", Convert.ToDateTime(baslangic.ToShortDateString()));
            adt.SelectCommand.Parameters.AddWithValue("@tar2", Convert.ToDateTime(bitis.ToShortDateString()));


            DataTable dt = new DataTable();
            adt.Fill(dt);
            grid_isletme.DataSource = dt;
            bag.Close();

            isim();

            // TABLO EN SON VERİ SEÇME
            gridView1.MoveFirst();

            //PERSONEL SAYI
            gridView1.Columns["isletme_id"].SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Count;
            gridView1.Columns["isletme_id"].SummaryItem.Tag = 1;

        }


        //GRİD KOLON İSİM
        void isim()
        {

            gridView1.Columns[0].Caption = "İŞLETME ID";
            gridView1.Columns[1].Caption = "İŞLETME NO";
            gridView1.Columns[2].Caption = "İŞLETME ADI";
            gridView1.Columns[3].Caption = "DEPO ID";
            gridView1.Columns[4].Caption = "DEPO NO";
            gridView1.Columns[5].Caption = "DEPO DURUMU";
            gridView1.Columns[6].Caption = "POMPA ÇEŞİT";
            gridView1.Columns[7].Caption = "DEPO KAPASİTESİ";
            gridView1.Columns[8].Caption = "DOLULUK MİKTARI";
            gridView1.Columns[9].Caption = "GÜNLÜK DOLUM";
            gridView1.Columns[10].Caption = "DOLUK SÜRESİ";
            gridView1.Columns[11].Caption = "ADRES";
            gridView1.Columns[12].Caption = "SON TEDARİK";
            gridView1.Columns[13].Caption = "DOLUM TARİHİ";
        }


        //PERSONEL VERİ TABANINDAN ÇEKME
        void personel()
        {
            bag.Open();
            SqlCommand kmt = new SqlCommand("Select adi_soyadi from tbl_personel", bag);
            SqlDataReader dr = kmt.ExecuteReader();
            while (dr.Read())
            {
                cmb_personel.Properties.Items.Add(dr[0]);

            }
            bag.Close();


        }
        //ARAÇ BİLGİLERİNİ VERİ TABANINDAN ÇEKME
        void arac()
        {
            bag.Open();
            SqlCommand kmt = new SqlCommand("Select arac_plaka from tbl_arac", bag);
            SqlDataReader dr = kmt.ExecuteReader();
            while (dr.Read())
            {
                cmb_arac.Properties.Items.Add(dr[0]);

            }
            bag.Close();

        }
       

        private void btn_kaydet_Click(object sender, EventArgs e)
        {
            kaydet();
        }
        int a, b, c;
        int kapasite, tedarik, bos, gunluk, sonuc, dolum;

        private void btn_sevkiyat_liste_Click(object sender, EventArgs e)
        {
            frm_sevkiyat_liste sevkiyat_list = new frm_sevkiyat_liste();
            sevkiyat_list.Show();
        }

        private void bar_btn_yenile_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            listele();
        }

        private void txt_depo_kapasite_KeyDown(object sender, KeyEventArgs e)
        {
            //ENTER TUSU
            if (e.KeyCode == Keys.Enter)
            {
                kaydet();

            }
        }

        private void txt_doluluk_KeyDown(object sender, KeyEventArgs e)
        {
            //ENTER TUSU
            if (e.KeyCode == Keys.Enter)
            {
                kaydet();

            }
        }

        private void txt_kalan_gun_KeyDown(object sender, KeyEventArgs e)
        {
            //ENTER TUSU
            if (e.KeyCode == Keys.Enter)
            {
                kaydet();

            }
        }

        private void cmb_personel_KeyDown(object sender, KeyEventArgs e)
        {
            //ENTER TUSU
            if (e.KeyCode == Keys.Enter)
            {
                kaydet();

            }
        }

        private void cmb_arac_KeyDown(object sender, KeyEventArgs e)
        {
            //ENTER TUSU
            if (e.KeyCode == Keys.Enter)
            {
                kaydet();

            }
        }

        private void memo_aciklama_KeyDown(object sender, KeyEventArgs e)
        {
            //ENTER TUSU
            if (e.KeyCode == Keys.Enter)
            {
                kaydet();

            }
        }

        DateTime suan = DateTime.Now;
        DateTime dolum_tarihi;
        void kaydet()
        {

            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            a = int.Parse(dr["depo_id"].ToString());



            bag.Open();
            SqlCommand kmt = new SqlCommand("insert into tbl_yeni_sevkiyat (isletme_id,depo_id,tarih,tedarik_tarih,arac_plaka,personel,doluluk_miktar,dolum_tarih,depo_kapasitesi,dolum_suresi,aciklama) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10,@p11)", bag);
            kmt.Parameters.AddWithValue("@p1", int.Parse(isletme_id.ToString()));
            kmt.Parameters.AddWithValue("@p2", int.Parse(depo_id.ToString()));
            kmt.Parameters.AddWithValue("@p3", Convert.ToDateTime(tedarik_tarih.ToShortDateString()));
            kmt.Parameters.AddWithValue("@p4", Convert.ToDateTime(bugun.ToShortDateString()));
            kmt.Parameters.AddWithValue("@p5", cmb_arac.Text);
            kmt.Parameters.AddWithValue("@p6", cmb_personel.Text);
            kmt.Parameters.AddWithValue("@p7", int.Parse(doluluk_miktar.ToString()));
            kmt.Parameters.AddWithValue("@p8", Convert.ToDateTime(dolum_tarih.ToShortDateString()));
            kmt.Parameters.AddWithValue("@p9", txt_depo_kapasite.Text);
            kmt.Parameters.AddWithValue("@p10", int.Parse(dolum_suresi.ToString()));
            kmt.Parameters.AddWithValue("@p11", memo_aciklama.Text);




            SqlCommand kmt2 = new SqlCommand("update tbl_isletme_depo set tedarik_tarihi=@p1,durum=@p2 where depo_id=@p3", bag);
            kmt2.Parameters.AddWithValue("@p1", Convert.ToDateTime(bugun.ToShortDateString()));
            kmt2.Parameters.AddWithValue("@p2", 1);
            kmt2.Parameters.AddWithValue("@p3", Convert.ToInt32(a.ToString()));



            SqlTransaction trans;
            trans = bag.BeginTransaction();
            kmt.Transaction = trans;
            kmt2.Transaction = trans;

            try
            {
                kmt.ExecuteNonQuery();
                kmt2.ExecuteNonQuery();
                trans.Commit();
                XtraMessageBox.Show("İŞLETME SEVKİYAT LİSTESİNE EKLENMİŞTİR", "SEVKİYAT OLUŞTUR", MessageBoxButtons.OK);



            }
            catch
            {
                trans.Rollback();
                XtraMessageBox.Show("LÜTFEN ALANLARI KONTROL EDİNİZ DOĞRU BİLGİ GİRDİĞİNİZDEN EMİN OLUNUZ", "UYARI ", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            finally
            {
                bag.Close();
                temizle();
                listele();
                cmb_personel.Focus();

            }

        }
        void temizle()
        {
            txt_depo_kapasite.Text = "";
            txt_doluluk.Text = "";
            txt_kalan_gun.Text = "";
            cmb_personel.Text = "";
            cmb_arac.Text = "";
            memo_aciklama.Text = "";


        }



        DateTime dolum_tarih, tedarik_tarih, bugun;
        int gun_sonuc, k, isletme_id, depo_id;
        int doluluk_miktar, gunluk_dolum, doluluk_sonuc, dolum_suresi;

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dr != null)
            {
                dolum_tarih = Convert.ToDateTime(dr["dolum_tarihi"].ToString());
                tedarik_tarih = Convert.ToDateTime(dr["tedarik_tarihi"].ToString());
                isletme_id = Convert.ToInt32(dr["isletme_id"].ToString());
                depo_id = Convert.ToInt32(dr["depo_id"].ToString());
                txt_depo_kapasite.Text = dr["depo_kapasitesi"].ToString();
                doluluk_miktar = Convert.ToInt32(dr["doluluk_miktar"].ToString());
                gunluk_dolum = Convert.ToInt32(dr["gunluk_dolum"].ToString());
                bugun = Convert.ToDateTime(DateTime.Now.ToShortDateString());
                dolum_suresi = Convert.ToInt32(dr["dolum_suresi"].ToString());
                gun_sonuc = bugun.Day - tedarik_tarih.Day;
                doluluk_sonuc = gun_sonuc * gunluk_dolum + doluluk_miktar;
                txt_doluluk.Text = doluluk_sonuc.ToString();

                k = dolum_tarih.Day - bugun.Day;
                txt_kalan_gun.Text = k.ToString();
            }
        }

      



    }
}