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
    public partial class frm_kapasite_durum : DevExpress.XtraEditors.XtraForm
    {
        public frm_kapasite_durum()
        {
            InitializeComponent();
        }
        SqlConnection bag = new SqlConnection(@"Data Source=.;Initial Catalog=db_bts;Integrated Security=True");

        private void frm_kapasite_durum_Load(object sender, EventArgs e)
        {
            depo_listele();
        }
        //GRİD DOLDUR
       public void depo_listele()
        {

            bag.Open();
            SqlDataAdapter adt = new SqlDataAdapter("Execute depo_resim", bag);


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
            gridView1.Columns[4].Caption = "RESİM";
          




        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dr != null)
            {
                pictureBox1.ImageLocation = dr["resim"].ToString();

            }
        }

        private void bar_btn_excel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // GUNCELLE FORMUNA ID GÖNDERME

            frm_resim_guncelle resim_guncelle = new frm_resim_guncelle();

            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);

            if (dr != null)
            {
                resim_guncelle.isletme_id = int.Parse(dr["depo_id"].ToString());

            }

            resim_guncelle.Show();
        }

        private void bar_btn_yenile_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            depo_listele();
        }
    }
}