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
    public partial class frm_depo_pompasiz : DevExpress.XtraEditors.XtraForm
    {
        public frm_depo_pompasiz()
        {
            InitializeComponent();
        }
        SqlConnection bag = new SqlConnection(@"Data Source=.;Initial Catalog=db_bts;Integrated Security=True");
      
        private void frm_depo_pompasiz_Load(object sender, EventArgs e)
        {
            depo_pompasiz();
        }
        //GRİD DOLDUR
        public void depo_pompasiz()
        {

            bag.Open();
            SqlDataAdapter adt = new SqlDataAdapter("Execute pompasiz_depo ", bag);


            DataTable dt = new DataTable();
            adt.Fill(dt);
            grid_isletme.DataSource = dt;
            bag.Close();

            isim();

            // TABLO EN SON VERİ SEÇME
            gridView1.MoveFirst();

            //İŞLETME SAYI
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
            gridView1.Columns[4].Caption = "DEPO KAPASİTESİ";
            gridView1.Columns[5].Caption = "DOLULUK MİKTARI";
            gridView1.Columns[6].Caption = "HAYVAN SAYISI";



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
            depo_pompasiz();
        }

        private void bar_btn_durum_degistir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // GUNCELLE FORMUNA ID GÖNDERME

            frm_depo_durum_degistir durum_guncelle = new frm_depo_durum_degistir();

            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);

            if (dr != null)
            {
                durum_guncelle.durum = Convert.ToInt32("2");
                durum_guncelle.isletme_depo_id = int.Parse(dr["depo_id"].ToString());

            }

            durum_guncelle.Show();
        }
    }
}