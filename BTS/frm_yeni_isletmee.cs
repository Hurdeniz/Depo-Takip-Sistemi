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
    public partial class frm_yeni_isletmee : DevExpress.XtraEditors.XtraForm
    {
        public frm_yeni_isletmee()
        {
            InitializeComponent();
        }
        SqlConnection bag = new SqlConnection(@"Data Source=.;Initial Catalog=db_bts;Integrated Security=True");
        private void frm_yeni_isletmee_Load(object sender, EventArgs e)
        {
            txt_isletme_no.Focus();
            listele();
        }
        //GRİD DOLDUR
        void listele()
        {

            bag.Open();
            SqlDataAdapter adt = new SqlDataAdapter("select isletme_no,isletme_adi,isletme_sahibi,isletme_durumu,irtibat_kisi,irtibat_telefon,kayit_tarihi from tbl_yeni_isletme Order By kayit_tarihi DESC ", bag);


            DataTable dt = new DataTable();
            adt.Fill(dt);
            grid_isletme.DataSource = dt;
            bag.Close();

            isim();

            // TABLO EN SON VERİ SEÇME
            gridView1.MoveFirst();

            //İŞLETME NO SAYI
            gridView1.Columns["isletme_no"].SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Count;
            gridView1.Columns["isletme_no"].SummaryItem.FieldName = "İŞLETME SAYISI";
            gridView1.Columns["isletme_no"].SummaryItem.Tag = 1;






        }
        //GRİD KOLON İSİM
        void isim()
        {
            gridView1.Columns[0].Caption = "İŞLETME NO";
            gridView1.Columns[1].Caption = "İŞLETME ADI";
            gridView1.Columns[2].Caption = "İŞLETME SAHİBİ";
            gridView1.Columns[3].Caption = "İŞLETME DURUMU";
            gridView1.Columns[4].Caption = "İRTİBAT KİŞİ";
            gridView1.Columns[5].Caption = "TELEFON";
            gridView1.Columns[6].Caption = "KAYIT TARİHİ";
           
        }
        //KAYDET
        private void btn_kaydet_Click(object sender, EventArgs e)
        {
            kaydet();
        }
        // AYNI VERİ ENGELLEME
        bool durum;
        public void control()
        {
            bag.Open();
            SqlCommand kmt = new SqlCommand("select * from tbl_yeni_isletme where isletme_no=@p1", bag);
            kmt.Parameters.AddWithValue("@p1",txt_isletme_no.Text);
            SqlDataReader oku = kmt.ExecuteReader();
            if (oku.Read())
            {
                durum = true;
            }
            else
            {
                durum = false;
            }

            bag.Close();

        }
        //VERİ KAYDETME       
        public void kaydet()
        {
            control();
            if (durum == false)
            {
                if (txt_isletme_no.Text=="")
                {
                    XtraMessageBox.Show("LÜTFEN İŞLETME NUMARASINI GİRİNİZ", "UYARI ", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else if (txt_isletme_adi.Text == "")
                {
                    XtraMessageBox.Show("LÜTFEN İŞLETME ADINI GİRİNİZ", "UYARI ", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {
             

                DateTime bugun = new DateTime();
                bugun = Convert.ToDateTime(DateTime.Now.ToShortDateString());

                bag.Open();
                SqlCommand kmt = new SqlCommand("insert into tbl_yeni_isletme (isletme_no,isletme_adi,isletme_sahibi,isletme_durumu,irtibat_kisi,irtibat_telefon,kayit_tarihi) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7)", bag);
                kmt.Parameters.AddWithValue("@p1", txt_isletme_no.Text);
                kmt.Parameters.AddWithValue("@p2", txt_isletme_adi.Text);
                kmt.Parameters.AddWithValue("@p3", txt_isletme_sahibi.Text);
                kmt.Parameters.AddWithValue("@p4", cmb_isletme_durumu.Text);
                kmt.Parameters.AddWithValue("@p5", txt_irtibat_kisi.Text);
                kmt.Parameters.AddWithValue("@p6", txt_telefon.Text);
                kmt.Parameters.AddWithValue("@p7", Convert.ToDateTime(bugun.ToString()));

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
                    listele();                 
                    txt_isletme_no.Focus();
                        frm_yeni_depoo yeni_depo = new frm_yeni_depoo();
                        yeni_depo.isletme_no = txt_isletme_no.Text.ToString();
                        yeni_depo.isletme_adi = txt_isletme_adi.Text.ToString();
                        yeni_depo.Show();
                        temizle();
                    }

                }
            }
            else
            {
                XtraMessageBox.Show("İŞLETME NUMARASI KAYITLI LÜTFEN BAŞKA İŞLETME NUMARASI GİRİNİZ... ", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        //TEMİZLE
        void temizle()
        {
            txt_isletme_no.Text = "";
            txt_isletme_adi.Text = "";
            txt_isletme_sahibi.Text = "";
            txt_irtibat_kisi.Text = "";
            txt_telefon.Text = "";



        }

        private void txt_isletme_no_KeyDown(object sender, KeyEventArgs e)
        {
            //ENTER TUSU
            if (e.KeyCode == Keys.Enter)
            {
                kaydet();
            }
        }

        private void txt_isletme_adi_KeyDown(object sender, KeyEventArgs e)
        {
            //ENTER TUSU
            if (e.KeyCode == Keys.Enter)
            {
                kaydet();
            }
        }

        private void txt_isletme_sahibi_KeyDown(object sender, KeyEventArgs e)
        {
            //ENTER TUSU
            if (e.KeyCode == Keys.Enter)
            {
                kaydet();
            }
        }

        private void txt_irtibat_kisi_KeyDown(object sender, KeyEventArgs e)
        {
            //ENTER TUSU
            if (e.KeyCode == Keys.Enter)
            {
                kaydet();
            }
        }

        private void txt_telefon_KeyDown(object sender, KeyEventArgs e)
        {
            //ENTER TUSU
            if (e.KeyCode == Keys.Enter)
            {
                kaydet();
            }
        }

        private void cmb_isletme_durumu_KeyDown(object sender, KeyEventArgs e)
        {
            //ENTER TUSU
            if (e.KeyCode == Keys.Enter)
            {
                kaydet();
            }
        }

        private void memo_adres_KeyDown(object sender, KeyEventArgs e)
        {
            //ENTER TUSU
            if (e.KeyCode == Keys.Enter)
            {
                kaydet();
            }
        }
    }
}