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
    public partial class frm_depolar : DevExpress.XtraEditors.XtraForm
    {
        public frm_depolar()
        {
            InitializeComponent();
        }
        SqlConnection bag = new SqlConnection(@"Data Source=.;Initial Catalog=db_bts;Integrated Security=True");
        private void frm_depolar_Load(object sender, EventArgs e)
        {
            listele_depolar();
        }
        //GRİD DOLDUR
        public void listele_depolar()
        {

            bag.Open();
            SqlDataAdapter adt = new SqlDataAdapter("Execute depolar ", bag);


            DataTable dt = new DataTable();
            adt.Fill(dt);
            grid_isletme.DataSource = dt;
            bag.Close();

            isim();

            // TABLO EN SON VERİ SEÇME
            gridView1.MoveFirst();

            //PERSONEL SAYI
            gridView1.Columns["depo_id"].SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Count;
            gridView1.Columns["depo_id"].SummaryItem.Tag = 1;

        }
        //GRİD KOLON İSİM
        void isim()
        {

            gridView1.Columns[0].Caption = "DEPO ID";
            gridView1.Columns[1].Caption = "İŞLETME NO";
            gridView1.Columns[2].Caption = "İŞLETME ADI";
            gridView1.Columns[3].Caption = "DEPO NUMARASI";
            gridView1.Columns[4].Caption = "DEPO DURUMU";
            gridView1.Columns[5].Caption = "POMPA DURUMU";
            gridView1.Columns[6].Caption = "POMPA ÇEŞİTİ";
            gridView1.Columns[7].Caption = "DEPO KAPASİTESİ";
            gridView1.Columns[8].Caption = "HAYVAN SAYISI";
            gridView1.Columns[9].Caption = "DOLUM TARİHİ";
            gridView1.Columns[10].Caption = "ADRES";



        }
        //GÜNCELLE
        private void bar_btn_guncelle_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            // GUNCELLE FORMUNA ID GÖNDERME

            frm_depo_guncelle guncelle_depo = new frm_depo_guncelle();

            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);

            if (dr != null)
            {

                guncelle_depo.depo_id = int.Parse(dr["depo_id"].ToString());

            }

          
            guncelle_depo.Show();
        }
        //SİL
        private void btn_sil_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int id;

            // GRİD DEN VERİ ÇEKME

            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            id = int.Parse(dr["depo_id"].ToString());
            //VERİ TABANINDAN SİLME İŞLEMİ

            DialogResult cevap;
            cevap = XtraMessageBox.Show("KAYIDI SİLMEK İSTEDİĞİNİZE EMİN MİSİNİZ ? ", "UYARI", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (cevap == DialogResult.Yes)
            {
                bag.Open();
                SqlCommand sil = new SqlCommand("Delete from tbl_isletme_depo where depo_id=" + id + " ", bag);
                sil.ExecuteNonQuery();
                bag.Close();
                listele_depolar();
            }
        }
        //YENİLE
        private void bar_btn_yenile_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            listele_depolar();
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
      
        private void bar_btn_cesit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
        }
        //AKTİF
        
        private void bar_btn_aktif_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // GRİD DEN VERİ ÇEKME

            int id;
            string durum;
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            id = int.Parse(dr["depo_id"].ToString());
            durum = dr["depo_durum"].ToString();



            if (durum == "AKTİF")
            {
                XtraMessageBox.Show("DEPO DURUMUNUZ AKTİF ", "UYARI ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // GUNCELLE FORMUNA ID GÖNDERME

                frm_pasif_durum_degistir aktif_yap = new frm_pasif_durum_degistir();



                if (dr != null)
                {

                    aktif_yap.isletme_depo_id = int.Parse(dr["depo_id"].ToString());

                }

                aktif_yap.Show();
            }

        }
        // PASİF
        string isletme_durum = "PASİF";
        private void bar_btn_pasif_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
           

            // GRİD DEN VERİ ÇEKME

            int id;
            string durum;
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            id = int.Parse(dr["depo_id"].ToString());
            durum = dr["depo_durum"].ToString();



            if (durum == "PASİF")
            {
                XtraMessageBox.Show("DEPO DURUMUNUZ PASİF ", "UYARI ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {


                //VERİ TABANINDAN SİLME İŞLEMİ

                DialogResult cevap;
                cevap = XtraMessageBox.Show("DEPO DURUMUNU PASİF YAPMAK İSTEDİĞİNİZDEN EMİN MİSİNİZ? ", "UYARI", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (cevap == DialogResult.Yes)
                {
                    bag.Open();
                    SqlCommand kmt = new SqlCommand("update tbl_isletme_depo set depo_durum=@p1 where depo_id=@p2", bag);
                    kmt.Parameters.AddWithValue("@p1", isletme_durum.ToString());
                    kmt.Parameters.AddWithValue("@p2", id.ToString());

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
                        XtraMessageBox.Show("DEPO DURUMUNUZ PASİF YAPILAMAMIŞTIR.LÜTFEN ALANLARI KONTROL EDİN DOĞRU BİLGİ GİRDİĞİNİZDEN EMİN OLUN", "GÜNCELLEME BAŞARISIZ ", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                    finally
                    {
                        bag.Close();
                        listele_depolar();
                    }


                }
            }





            }
    }
}