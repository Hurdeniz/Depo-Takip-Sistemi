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
    public partial class frm_isletmeler : DevExpress.XtraEditors.XtraForm
    {
        public frm_isletmeler()
        {
            InitializeComponent();
        }
        SqlConnection bag = new SqlConnection(@"Data Source=.;Initial Catalog=db_bts;Integrated Security=True");
        private void frm_isletmeler_Load(object sender, EventArgs e)
        {
            listele_isletme();
        }
        //GRİD DOLDUR
       public void listele_isletme()
        {

            bag.Open();
            SqlDataAdapter adt = new SqlDataAdapter("select * from tbl_yeni_isletme Order By kayit_tarihi DESC ", bag);


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
            gridView1.Columns[3].Caption = "İŞLETME SAHİBİ";
            gridView1.Columns[4].Caption = "İŞLETME DURUMU";
            gridView1.Columns[5].Caption = "İRTİBAT KİŞİ";
            gridView1.Columns[6].Caption = "TELEFON";
            gridView1.Columns[7].Caption = "KAYIT TARİHİ";



        }
        //SİL
        private void btn_sil_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int id;

            // GRİD DEN VERİ ÇEKME

            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            id = int.Parse(dr["isletme_id"].ToString());
            //VERİ TABANINDAN SİLME İŞLEMİ

            DialogResult cevap;
            cevap = XtraMessageBox.Show("KAYIDI SİLMEK İSTEDİĞİNİZE EMİN MİSİNİZ ? ", "UYARI", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (cevap == DialogResult.Yes)
            {
                bag.Open();
                SqlCommand sil = new SqlCommand("Delete from tbl_yeni_isletme where isletme_id=" + id + " ", bag);
                sil.ExecuteNonQuery();
                bag.Close();
                listele_isletme();
            }
           
        }
        //EXCEL AKTAR
        private void bar_btn_excel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            XtraSaveFileDialog save = new XtraSaveFileDialog();

            if (save.ShowDialog() == DialogResult.OK)
            {
                gridView1.ExportToXlsx(save.FileName + ".xlsx");
            }
        }
        //YENİLER
        private void bar_btn_yenile_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            listele_isletme();
        }
        //İŞLETME GÜNCELLE
        private void bar_btn_guncelle_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // GUNCELLE FORMUNA ID GÖNDERME

            frm_isletme_guncelle isletme_guncelle = new frm_isletme_guncelle();

            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);

            if (dr != null)
            {

                isletme_guncelle.isletme_id = int.Parse(dr["isletme_id"].ToString());

            }

            isletme_guncelle.Show();
        }
    }
}