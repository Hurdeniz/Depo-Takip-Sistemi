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
    public partial class frm_arac : DevExpress.XtraEditors.XtraForm
    {
        public frm_arac()
        {
            InitializeComponent();
        }
        SqlConnection bag = new SqlConnection(@"Data Source=.;Initial Catalog=db_bts;Integrated Security=True");
        private void frm_arac_Load(object sender, EventArgs e)
        {
            txt_adi_soyadi.Focus();
            listele_personel();
        }
        //GRİD DOLDUR

        void listele_personel()
        {

            bag.Open();
            SqlDataAdapter adt = new SqlDataAdapter("SELECT * FROM tbl_arac", bag);



            DataTable dt = new DataTable();
            adt.Fill(dt);
            grid_isletme.DataSource = dt;
            bag.Close();

            isim();

            // TABLO EN SON VERİ SEÇME
            gridView1.MoveFirst();

            //PERSONEL SAYI
            gridView1.Columns["arac_id"].SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Count;
            gridView1.Columns["arac_id"].SummaryItem.Tag = 1;

        }
        //GRİD KOLON İSİM
        void isim()
        {
            gridView1.Columns[0].Caption = "ARAÇ ID";
            gridView1.Columns[1].Caption = "ARAÇ PLAKA";

        }

        private void bar_btn_filtre_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int id;

            // GRİD DEN VERİ ÇEKME

            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            id = int.Parse(dr["arac_id"].ToString());
            //VERİ TABANINDAN SİLME İŞLEMİ

            DialogResult cevap;
            cevap = XtraMessageBox.Show("KAYIDI SİLMEK İSTEDİĞİNİZE EMİN MİSİNİZ ? ", "UYARI", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (cevap == DialogResult.Yes)
            {
                bag.Open();
                SqlCommand sil = new SqlCommand("Delete from tbl_arac where arac_id=" + id + " ", bag);
                sil.ExecuteNonQuery();
                bag.Close();
                listele_personel();
            }
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
            listele_personel();
        }

        private void btn_kaydet_Click(object sender, EventArgs e)
        {
            kaydet();
        }
        //VERİ KAYDETME       
        public void kaydet()
        {

            bag.Open();
            SqlCommand kmt = new SqlCommand("insert into tbl_arac(arac_plaka) values (@p1)", bag);
            kmt.Parameters.AddWithValue("@p1", txt_adi_soyadi.Text);


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
                XtraMessageBox.Show("LÜTFEN ALANLARI KONTROL EDİNİZ DOĞRU BİLGİ GİRDİĞİNİZDEN EMİN OLUNUZ", "UYARI ", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            finally
            {
                bag.Close();
                txt_adi_soyadi.Focus();
                listele_personel();
                txt_adi_soyadi.Text = "";
            }




        }

        private void txt_adi_soyadi_KeyDown(object sender, KeyEventArgs e)
        {
            //ENTER TUSU
            if (e.KeyCode == Keys.Enter)
            {
                kaydet();
            }
        }
    }
}