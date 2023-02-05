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
    public partial class frm_dolmak_uzere : DevExpress.XtraEditors.XtraForm
    {
        public frm_dolmak_uzere()
        {
            InitializeComponent();
        }
        SqlConnection bag = new SqlConnection(@"Data Source=.;Initial Catalog=db_bts;Integrated Security=True");

        DateTime tarih = DateTime.Now;
        DateTime baslangic, bitis;

        private void frm_dolmak_uzere_Load(object sender, EventArgs e)
        {
            listele();
        }
        //GRİD DOLDUR
        void listele()
        {
            baslangic = Convert.ToDateTime(tarih.AddDays(-10).ToShortDateString());
            bitis = Convert.ToDateTime(tarih.AddDays(3).ToShortDateString());

            bag.Open();
            SqlDataAdapter adt = new SqlDataAdapter("select isletme_no,isletme_adi,depo_no,depo_durumu,pompa_cesit,depo_kapasitesi,hayvan_sayisi,tedarik_tarihi,dolum_tarihi from tbl_isletme_depo inner join tbl_yeni_isletme on tbl_isletme_depo.isletme_id = tbl_yeni_isletme.isletme_id where isletme_durumu = 'AKTİF' and depo_durum = 'AKTİF' and durum=0 and dolum_tarihi between @tar1 and @tar2 order by dolum_tarihi DESC", bag);
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
            gridView1.Columns["isletme_no"].SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Count;
            gridView1.Columns["isletme_no"].SummaryItem.Tag = 1;

        }
        //GRİD KOLON İSİM
        void isim()
        {
            gridView1.Columns[0].Caption = "İŞLETME NO";
            gridView1.Columns[1].Caption = "İŞLETME ADI";
            gridView1.Columns[2].Caption = "DEPO NO";
            gridView1.Columns[3].Caption = "POMPA DURUMU";
            gridView1.Columns[4].Caption = "POMPA ÇEŞİT";
            gridView1.Columns[5].Caption = "DEPO KAPASİTESİ";
            gridView1.Columns[6].Caption = "TOPLAM HAYVAN";
            gridView1.Columns[7].Caption = "TEDARİK TARİHİ";
            gridView1.Columns[8].Caption = "DOLUM TARİHİ";
        }

        private void bar_btn_excel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
             XtraSaveFileDialog save = new XtraSaveFileDialog();

            if (save.ShowDialog() == DialogResult.OK)
            {
                gridView1.ExportToXlsx(save.FileName + ".xlsx");
            }
           
           
        }

        private void bar_btn_yenile_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            listele();
        }

      
    }
}