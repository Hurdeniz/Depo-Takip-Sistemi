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
    public partial class frm_aktif_isletme : DevExpress.XtraEditors.XtraForm
    {
        public frm_aktif_isletme()
        {
            InitializeComponent();
        }
        SqlConnection bag = new SqlConnection(@"Data Source=.;Initial Catalog=db_bts;Integrated Security=True");
       
        private void frm_aktif_isletme_Load(object sender, EventArgs e)
        {
            listele_aktif();
        }
        //GRİD DOLDUR
        public void listele_aktif()
        {

            bag.Open();
            SqlDataAdapter adt = new SqlDataAdapter("Execute aktif_isletme", bag);


            DataTable dt = new DataTable();
            adt.Fill(dt);
            grid_isletme.DataSource = dt;
            bag.Close();

            isim();

            // TABLO EN SON VERİ SEÇME
            gridView1.MoveFirst();

            //İŞLETME SAYI
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
            gridView1.Columns[4].Caption = "İRTİBAT KİŞİ";
            gridView1.Columns[5].Caption = "TELEFON";
          
         




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
            listele_aktif();
        }
        //DURUM DEĞİŞTİR
        string isletme_durum = "PASİF";
        
        private void bar_btn_durum_degistir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int id;

            // GRİD DEN VERİ ÇEKME

            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            id = int.Parse(dr["isletme_id"].ToString());
            //VERİ TABANINDAN SİLME İŞLEMİ

            DialogResult cevap;
            cevap = XtraMessageBox.Show("İŞLETMEYİ PASİF YAPMAK İSTEDİĞİNİZDEN EMİN MİSİNİZ? ", "UYARI", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (cevap == DialogResult.Yes)
            {
                bag.Open();
                SqlCommand kmt = new SqlCommand("update tbl_yeni_isletme set isletme_durumu=@p1 where isletme_id=@p2", bag);
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
                    XtraMessageBox.Show("İŞLETME PASİF YAPILAMAMIŞTIR.LÜTFEN ALANLARI KONTROL EDİN DOĞRU BİLGİ GİRDİĞİNİZDEN EMİN OLUN", "GÜNCELLEME BAŞARISIZ ", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                finally
                {
                    bag.Close();
                    listele_aktif();
                }


            }
        }
    }
}