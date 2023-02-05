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
    public partial class frm_sevkiyat_listesi : DevExpress.XtraEditors.XtraForm
    {
        public frm_sevkiyat_listesi()
        {
            InitializeComponent();
        }
        SqlConnection bag = new SqlConnection(@"Data Source=.;Initial Catalog=db_bts;Integrated Security=True");
        private void frm_sevkiyat_listesi_Load(object sender, EventArgs e)
        {
            date_baslangic.Text = DateTime.Now.ToShortDateString();
            date_bitis.Text = DateTime.Now.ToShortDateString();
            listele_sevkiyat();

        }
        //GRİD DOLDUR
        public void listele_sevkiyat()
        {

            bag.Open();
            SqlDataAdapter adt = new SqlDataAdapter("select sevkiyat_id,isletme_no,isletme_adi,irtibat_kisi,irtibat_telefon,tbl_isletme_depo.depo_id,tbl_isletme_depo.depo_no,depo_durumu,pompa_cesit,tedarik_miktar,arac_plaka,personel,tedarik_tarih,aciklama,adres from tbl_yeni_sevkiyat inner join tbl_isletme_depo on tbl_yeni_sevkiyat.depo_id = tbl_isletme_depo.depo_id inner join tbl_yeni_isletme on tbl_yeni_sevkiyat.isletme_id = tbl_yeni_isletme.isletme_id where tedarik_tarih BETWEEN @tar1 and @tar2 Order By tedarik_tarih ASC", bag);
            adt.SelectCommand.Parameters.AddWithValue("@tar1", Convert.ToDateTime(date_baslangic.Text));
            adt.SelectCommand.Parameters.AddWithValue("@tar2", Convert.ToDateTime(date_bitis.Text));

            DataTable dt = new DataTable();
            adt.Fill(dt);
            grid_sevkiyat.DataSource = dt;
            bag.Close();

            isim();

            // TABLO EN SON VERİ SEÇME
            gridView1.MoveFirst();

            //İŞLETME SAYI
            gridView1.Columns["sevkiyat_id"].SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Count;
            gridView1.Columns["sevkiyat_id"].SummaryItem.Tag = 1;

            gridView1.Columns["tedarik_miktar"].SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            gridView1.Columns["tedarik_miktar"].SummaryItem.DisplayFormat = "{0} TON";
            gridView1.Columns["tedarik_miktar"].SummaryItem.Tag = 1;

        }
        //GRİD KOLON İSİM
        void isim()
        {

            gridView1.Columns[0].Caption = "SEVKİYAT ID";
            gridView1.Columns[1].Caption = "İŞLETME NO";
            gridView1.Columns[2].Caption = "İŞLETME ADI";
            gridView1.Columns[3].Caption = "İRTİBAT KİŞİ";
            gridView1.Columns[4].Caption = "TELEFON";
            gridView1.Columns[5].Caption = "DEPO ID";
            gridView1.Columns[6].Caption = "DEPO NO";
            gridView1.Columns[7].Caption = "POMPA DURUMU";
            gridView1.Columns[8].Caption = "POMPA ÇEŞİT";
            gridView1.Columns[9].Caption = "TEDARİK MİKTAR";
            gridView1.Columns[10].Caption = "ARAÇ PLAKA";
            gridView1.Columns[11].Caption = "PERSONEL";
            gridView1.Columns[12].Caption = "TEDARİK TARİHİ";
            gridView1.Columns[13].Caption = "AÇIKLAMA";
            gridView1.Columns[14].Caption = "ADRES";



        }


        // FİLTRE BUTONU
        int sayac = 1;
        private void bar_btn_filtre_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (sayac == 2)
            {
                panel_tarihh.Visible = false;

                sayac = 1;
            }
            else
            {
                panel_tarihh.Visible = true;
                sayac++;

            }
        }

        private void bar_btn_sil_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {


        }
        //EXCEL
        private void bar_btn_excel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            XtraSaveFileDialog save = new XtraSaveFileDialog();

            if (save.ShowDialog() == DialogResult.OK)
            {
                gridView1.ExportToXlsx(save.FileName + ".xlsx");
            }
        }
        //YENİLE
        private void bar_btn_yenile_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            listele_sevkiyat();
        }
        //GÖSTER
        private void btn_goster_Click(object sender, EventArgs e)
        {
            listele_sevkiyat();
        }

        private void bar_btn_bosalt_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // GUNCELLE FORMUNA ID GÖNDERME

            frm_depo_bosalt depo_bosalt = new frm_depo_bosalt();

            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);

            if (dr != null)
            {

                depo_bosalt.sevkiyat_id = int.Parse(dr["sevkiyat_id"].ToString());
                depo_bosalt.isletme_no = dr["isletme_no"].ToString();
                depo_bosalt.isletme_adi = dr["isletme_adi"].ToString();
                depo_bosalt.depo_no = dr["depo_no"].ToString();

            }

            depo_bosalt.Show();
        }

        void sil()
        {
            int sev_id;

            // GRİD DEN VERİ ÇEKME

            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            sev_id = int.Parse(dr["sevkiyat_id"].ToString());
            //VERİ TABANINDAN SİLME İŞLEMİ

         
                bag.Open();
                SqlCommand sil = new SqlCommand("Delete from tbl_yeni_sevkiyat where sevkiyat_id=" + sev_id + " ", bag);
                sil.ExecuteNonQuery();
                bag.Close();

        }
        //KALDIR
        DateTime tarih, dolum_tarihi;
        int doluluk, kapasite, depo_id, dolum_suresi;
        private void bar_btn_sil_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int id, depo_id;
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            id = int.Parse(dr["sevkiyat_id"].ToString());
            depo_id = int.Parse(dr["depo_id"].ToString());

            bag.Open();
            SqlCommand kmt = new SqlCommand("select * from tbl_yeni_sevkiyat where sevkiyat_id=@p1", bag);
            kmt.Parameters.AddWithValue("@p1", id.ToString());

            SqlDataReader oku = kmt.ExecuteReader();
            while (oku.Read())
            {
                doluluk = Convert.ToInt32(oku["doluluk_miktar"].ToString());
                tarih = Convert.ToDateTime(oku["tarih"].ToString());
                dolum_tarihi = Convert.ToDateTime(oku["dolum_tarih"].ToString());
                kapasite = Convert.ToInt32(oku["depo_kapasitesi"].ToString());
                dolum_suresi = Convert.ToInt32(oku["dolum_suresi"].ToString());
            }
            bag.Close();


            DialogResult cevap;
            cevap = XtraMessageBox.Show("KAYIDI SİLMEK İSTEDİĞİNİZE EMİN MİSİNİZ ? ", "UYARI", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (cevap == DialogResult.Yes)
            {

                bag.Open();
                SqlCommand kmt2 = new SqlCommand("update tbl_isletme_depo set doluluk_miktar=@p1,dolum_tarihi=@p2,tedarik_tarihi=@p3,depo_kapasitesi=@p4,dolum_suresi=@p5,durum=@p6 where depo_id=@p7", bag);
                kmt2.Parameters.AddWithValue("@p1", Convert.ToInt32(doluluk.ToString()));
                kmt2.Parameters.AddWithValue("@p2", Convert.ToDateTime(dolum_tarihi.ToShortDateString()));
                kmt2.Parameters.AddWithValue("@p3", Convert.ToDateTime(tarih.ToShortDateString()));
                kmt2.Parameters.AddWithValue("@p4", Convert.ToInt32(kapasite.ToString()));
                kmt2.Parameters.AddWithValue("@p5", Convert.ToInt32(dolum_suresi.ToString()));
                kmt2.Parameters.AddWithValue("@p6", 0);
                kmt2.Parameters.AddWithValue("@p7", depo_id.ToString());

                kmt2.Connection = bag;
           

                SqlTransaction trans;
                trans = bag.BeginTransaction();
                kmt2.Transaction = trans;

                try
                {
                    kmt2.ExecuteNonQuery();
                    trans.Commit();     
                  
                    SqlCommand sil = new SqlCommand("Delete from tbl_yeni_sevkiyat where sevkiyat_id=" + id + " ", bag);
                    sil.ExecuteNonQuery();
               

                }
                catch
                {
                    trans.Rollback();
                    XtraMessageBox.Show("LÜTFEN ALANLARI KONTROL EDİN DOĞRU BİLGİ GİRDİĞİNİZDEN EMİN OLUN", "GÜNCELLEME BAŞARISIZ ", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                finally
                {
                    bag.Close();
                    listele_sevkiyat();
                }

                
            }
        }
    }
}

