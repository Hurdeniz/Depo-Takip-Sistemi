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
    public partial class frm_depo_bilgileri : DevExpress.XtraEditors.XtraForm
    {
        public frm_depo_bilgileri()
        {
            InitializeComponent();
        }
        SqlConnection bag = new SqlConnection(@"Data Source=.;Initial Catalog=db_bts;Integrated Security=True");
     
        private void frm_depo_bilgileri_Load(object sender, EventArgs e)
        {
            listele_depo_bilgileri();
        }
        //GRİD DOLDUR
        void listele_depo_bilgileri()
        {

            bag.Open();
            SqlDataAdapter adt = new SqlDataAdapter("Execute depo_bilgileri", bag);

            DataTable dt = new DataTable();
            adt.Fill(dt);
            grid_isletme.DataSource = dt;
            bag.Close();

            isim();

            // TABLO EN SON VERİ SEÇME
            gridView1.MoveFirst();

            //İŞLETME SAYI
            gridView1.Columns["isletme_no"].SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Count;
            gridView1.Columns["isletme_no"].SummaryItem.Tag = 1;

        }
        //GRİD KOLON İSİM
        void isim()
        {

            gridView1.Columns[0].Caption = "İŞLETME NO";
            gridView1.Columns[1].Caption = "İŞLETME ADI";
            gridView1.Columns[2].Caption = "DEPO ID";
            gridView1.Columns[3].Caption = "DEPO NO";
            gridView1.Columns[4].Caption = "POMPA DURUMU";
            gridView1.Columns[5].Caption = "POMPA ÇEŞİTİ";
            gridView1.Columns[6].Caption = "DEPO KAPASİTESİ";
            gridView1.Columns[7].Caption = "DOLULUK MİKTARI";
            gridView1.Columns[8].Caption = "DOLUM SÜRESİ";
            gridView1.Columns[9].Caption = "ERKEK HAYVAN";
            gridView1.Columns[10].Caption = "DİŞİ HAYVAN";
            gridView1.Columns[11].Caption = "TOPLAM HAYVAN";
            gridView1.Columns[12].Caption = "ADRES";




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
        //YENİLE
        private void bar_btn_yenile_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            listele_depo_bilgileri();
        }
        //RESİM
        private void bar_btn_resim_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // GUNCELLE FORMUNA ID GÖNDERME

            frm_depo_resim depo_resim = new frm_depo_resim();

            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);

            if (dr != null)
            {
                
                depo_resim.depo_resim_id = int.Parse(dr["depo_id"].ToString());

            }

            depo_resim.Show();
        }
    }
}