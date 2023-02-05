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
    public partial class frm_depo_isletme : DevExpress.XtraEditors.XtraForm
    {
        public frm_depo_isletme()
        {
            InitializeComponent();
        }
        SqlConnection bag = new SqlConnection(@"Data Source=.;Initial Catalog=db_bts;Integrated Security=True");
        private void frm_depo_isletme_Load(object sender, EventArgs e)
        {
            listele();
        }
        //GRİD DOLDUR
        string isletme_durum = "AKTİF";
        void listele()
        {

            bag.Open();
            SqlDataAdapter adt = new SqlDataAdapter("select isletme_id,isletme_no,isletme_adi,isletme_sahibi,isletme_durumu,irtibat_kisi,irtibat_telefon,kayit_tarihi from tbl_yeni_isletme WHERE isletme_durumu=@p1 Order By kayit_tarihi DESC ", bag);
            adt.SelectCommand.Parameters.AddWithValue("@p1", isletme_durum.ToString());


            DataTable dt = new DataTable();
            adt.Fill(dt);
            grid_isletme.DataSource = dt;
            bag.Close();

            isim();

            // TABLO EN SON VERİ SEÇME
            gridView1.MoveFirst();

            //İŞLETME NO SAYI
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

        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {

            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);

          
            // YENİ DEPO FORMUNA ID GONDERME

            frm_yeni_depo yeni_depo_frm = (frm_yeni_depo)Application.OpenForms["frm_yeni_depo"];
            yeni_depo_frm.txt_isletme_id.Text = dr["isletme_id"].ToString();

            //FORM KAPAT
            this.Close();

        }
    }
}