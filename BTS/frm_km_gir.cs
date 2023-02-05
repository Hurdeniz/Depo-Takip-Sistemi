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
    public partial class frm_km_gir : DevExpress.XtraEditors.XtraForm
    {
        public frm_km_gir()
        {
            InitializeComponent();
        }
        SqlConnection bag = new SqlConnection(@"Data Source=.;Initial Catalog=db_bts;Integrated Security=True");
        private void frm_km_gir_Load(object sender, EventArgs e)
        {
            txt_tedarik_miktar.Focus();

            date_baslangic.Text = DateTime.Now.ToShortDateString();
            date_bitis.Text = DateTime.Now.ToShortDateString();
            listele_sevkiyat();
            
        }
        //GRİD DOLDUR
        public void listele_sevkiyat()
        {

            bag.Open();
            SqlDataAdapter adt = new SqlDataAdapter("select sevkiyat_id,isletme_no,isletme_adi,tbl_isletme_depo.depo_id,tbl_isletme_depo.depo_no,tbl_isletme_depo.depo_kapasitesi,tbl_isletme_depo.doluluk_miktar,tbl_isletme_depo.gunluk_dolum,tbl_isletme_depo.dolum_suresi,tbl_yeni_sevkiyat.tarih,tedarik_miktar,km from tbl_yeni_sevkiyat inner join tbl_isletme_depo on tbl_yeni_sevkiyat.depo_id = tbl_isletme_depo.depo_id inner join tbl_yeni_isletme on tbl_yeni_sevkiyat.isletme_id = tbl_yeni_isletme.isletme_id where tedarik_tarih BETWEEN @tar1 and @tar2 Order By tedarik_tarih ASC", bag);
            adt.SelectCommand.Parameters.AddWithValue("@tar1", Convert.ToDateTime(date_baslangic.Text));
            adt.SelectCommand.Parameters.AddWithValue("@tar2", Convert.ToDateTime(date_bitis.Text));

            DataTable dt = new DataTable();
            adt.Fill(dt);
            grid_sevkiyat.DataSource = dt;
            bag.Close();

            isim();



            //İŞLETME SAYI
            gridView1.Columns["sevkiyat_id"].SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Count;
            gridView1.Columns["sevkiyat_id"].SummaryItem.Tag = 1;

            gridView1.Columns["tedarik_miktar"].SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            gridView1.Columns["tedarik_miktar"].SummaryItem.DisplayFormat = "{0}";
            gridView1.Columns["tedarik_miktar"].SummaryItem.Tag = 1;



        }
        //GRİD KOLON İSİM
        void isim()
        {

            gridView1.Columns[0].Caption = "SEVKİYAT ID";
            gridView1.Columns[1].Caption = "İŞLETME NO";
            gridView1.Columns[2].Caption = "İŞLETME ADI";
            gridView1.Columns[3].Caption = "DEPO ID";
            gridView1.Columns[4].Caption = "DEPO NO";
            gridView1.Columns[5].Caption = "DEPO KAPASİTESİ";
            gridView1.Columns[6].Caption = "DOLULUK MİKTAR";
            gridView1.Columns[7].Caption = "GÜNLÜK DOLUM";
            gridView1.Columns[8].Caption = "DOLUM SÜRESİ";
            gridView1.Columns[9].Caption = "SON TEDARİK TARİHİ";
            gridView1.Columns[10].Caption = "TONAJ MİKTAR";
            gridView1.Columns[11].Caption = "KM ORANI";



        }
        //KAYDET
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            kaydet();
        }
        int a, b, c;
        int kapasite, tedarik, bos, gunluk, sonuc, dolum;

        DateTime suan = DateTime.Now;
        DateTime dolum_tarihi;
        void kaydet()
        {


            int id;
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            id = int.Parse(dr["sevkiyat_id"].ToString());

            a = int.Parse(dr["depo_id"].ToString());
            b = int.Parse(txt_tedarik_miktar.Text);
            c = int.Parse(txt_doluluk.Text);

            if (b > c)
            {
                XtraMessageBox.Show("TONAJ MİKTARI DEPONUN DOLULUK MİKTARINDAN BÜYÜK OLAMAZ", "UYARI ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (txt_tedarik_miktar.Text == "")
                {
                    XtraMessageBox.Show("LÜTFEN TONAJ MİKTARI GİRİNİZ", "UYARI ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {

                    bag.Open();
                    SqlCommand kmt = new SqlCommand("update tbl_yeni_sevkiyat set km=@p1,tedarik_miktar=@p2 where sevkiyat_id=@p3", bag);
                    kmt.Parameters.AddWithValue("@p1", decimal.Parse(txt_km_orani.Text));
                    kmt.Parameters.AddWithValue("@p2", int.Parse(txt_tedarik_miktar.Text));
                    kmt.Parameters.AddWithValue("@p3", id.ToString());

                    kapasite = int.Parse(dr["depo_kapasitesi"].ToString());
                    gunluk = int.Parse(dr["gunluk_dolum"].ToString());
                    tedarik = int.Parse(txt_tedarik_miktar.Text);

                    sonuc = c - tedarik;
                    bos = kapasite - sonuc;
                    dolum = bos / gunluk;




                    dolum_tarihi = Convert.ToDateTime(suan.AddDays(Convert.ToInt32(dolum)).ToShortDateString());

                    SqlCommand kmt2 = new SqlCommand("update tbl_isletme_depo set dolum_tarihi=@p1,doluluk_miktar=@p2,durum=@p3 where depo_id=@p4", bag);
                    kmt2.Parameters.AddWithValue("@p1", Convert.ToDateTime(dolum_tarihi.ToShortDateString()));
                    kmt2.Parameters.AddWithValue("@p2", Convert.ToInt32(sonuc.ToString()));
                    kmt2.Parameters.AddWithValue("@p3", 0);
                    kmt2.Parameters.AddWithValue("@p4", Convert.ToInt32(a.ToString()));

                    kmt.Connection = bag;

                    SqlTransaction trans;
                    trans = bag.BeginTransaction();
                    kmt.Transaction = trans;
                    kmt2.Transaction = trans;

                    try
                    {
                        kmt.ExecuteNonQuery();
                        kmt2.ExecuteNonQuery();
                        trans.Commit();


                    }
                    catch
                    {
                        trans.Rollback();
                        XtraMessageBox.Show("GÜNCELLEME YAPILAMAMIŞTIR.LÜTFEN ALANLARI KONTROL EDİN DOĞRU BİLGİ GİRDİĞİNİZDEN EMİN OLUN", "GÜNCELLEME BAŞARISIZ ", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                    finally
                    {
                        bag.Close();
                        temizle();
                        listele_sevkiyat();
                        txt_tedarik_miktar.Focus();
                       
                       
                    }

                }
            }
        }

        void temizle()
        {
            txt_isletme_no.Text = "";
            txt_isletme_adi.Text = "";
            txt_depo_no.Text = "";
            txt_depo_kapasite.Text = "";
            txt_doluluk.Text = "";
            txt_tedarik_miktar.Text = "";
            txt_km_orani.Text = "";
            


        }

   
       
       

        private void txt_tedarik_miktar_KeyDown(object sender, KeyEventArgs e)
        {
            //ENTER TUSU
            if (e.KeyCode == Keys.Enter)
            {
                kaydet();

            }
        }
        DateTime tedarik_tarih, bugun;
        int gun_sonuc  ;
        int doluluk_miktar, gunluk_dolum, doluluk_sonuc, dolum_suresi;
        ////GRİD VERİLERİ TEXTBOX AKTARMA
        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dr != null)
            {

                txt_isletme_no.Text = dr["isletme_no"].ToString();
                txt_isletme_adi.Text = dr["isletme_adi"].ToString();
                txt_depo_no.Text = dr["depo_no"].ToString();          
                tedarik_tarih = Convert.ToDateTime(dr["tarih"].ToString());             
                txt_depo_kapasite.Text = dr["depo_kapasitesi"].ToString();
                doluluk_miktar = Convert.ToInt32(dr["doluluk_miktar"].ToString());
                gunluk_dolum = Convert.ToInt32(dr["gunluk_dolum"].ToString());
                bugun = Convert.ToDateTime(DateTime.Now.ToShortDateString());
                dolum_suresi = Convert.ToInt32(dr["dolum_suresi"].ToString());
                gun_sonuc = bugun.Day - tedarik_tarih.Day;
                doluluk_sonuc = gun_sonuc * gunluk_dolum + doluluk_miktar;
                txt_doluluk.Text = doluluk_sonuc.ToString();


            }
        }

        private void txt_km_orani_KeyDown(object sender, KeyEventArgs e)
        {
            //ENTER TUSU
            if (e.KeyCode == Keys.Enter)
            {
                kaydet();

            }
        }

        private void txt_tonaj_miktari_KeyDown(object sender, KeyEventArgs e)
        {
            //ENTER TUSU
            if (e.KeyCode == Keys.Enter)
            {
                kaydet();

            }
        }
        //excel
        private void bar_btn_excel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            XtraSaveFileDialog save = new XtraSaveFileDialog();

            if (save.ShowDialog() == DialogResult.OK)
            {
                gridView1.ExportToXlsx(save.FileName + ".xlsx");
            }
        }
        //yenile
        private void bar_btn_yenile_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            listele_sevkiyat();
        }
        //göster
        private void btn_goster_Click(object sender, EventArgs e)
        {
            listele_sevkiyat();
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
    }
}