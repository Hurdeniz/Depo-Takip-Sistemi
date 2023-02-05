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
    public partial class frm_yeni_depo : DevExpress.XtraEditors.XtraForm
    {
        public frm_yeni_depo()
        {
            InitializeComponent();
        }
        SqlConnection bag = new SqlConnection(@"Data Source=.;Initial Catalog=db_bts;Integrated Security=True");
        private void frm_yeni_depo_Load(object sender, EventArgs e)
        {
            date_dolum_tarih.Text = DateTime.Now.ToShortDateString();
            listele_depo();
        }
        //GRİD DOLDUR

        void listele_depo()
        {

            bag.Open();
            SqlDataAdapter adt = new SqlDataAdapter("Execute isletme_depolari", bag);



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
            gridView1.Columns[2].Caption = "DEPO NUMARASI";
            gridView1.Columns[3].Caption = "DEPO DURUMU";
            gridView1.Columns[4].Caption = "POMPA DURUMU";
            gridView1.Columns[5].Caption = "POMPA ÇEŞİT";
            gridView1.Columns[6].Caption = "DEPO KAPASİTESİ";
            gridView1.Columns[7].Caption = "HAYVAN SAYISI";
            gridView1.Columns[8].Caption = " ADRES";




        }

        private void txt_isletme_no_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            frm_depo_isletme isletmeler = new frm_depo_isletme();
            isletmeler.Show();
        }

        private void txt_resim_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            xtraOpenFileDialog1.ShowDialog();
            txt_resim.Text = xtraOpenFileDialog1.FileName;
        }

        private void cmb_depo_durum_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_depo_durum.SelectedIndex == 0)
            {
                check_et1.Visible = true;

            }
            else if (cmb_depo_durum.SelectedIndex == 1)
            {
                check_et1.Visible = false;

            }
            else if (cmb_depo_durum.SelectedIndex == 2)
            {
                check_et1.Visible = false;

            }
        }

        private void txt_depo_kapasitesi_KeyDown(object sender, KeyEventArgs e)
        {
            //ENTER TUSU
            if (e.KeyCode == Keys.Enter)
            {
                kaydet();
            }
        }

        private void txt_doluluk_orani_KeyDown(object sender, KeyEventArgs e)
        {
            //ENTER TUSU
            if (e.KeyCode == Keys.Enter)
            {
                kaydet();
            }
        }

        private void txt_dolum_suresi_KeyDown(object sender, KeyEventArgs e)
        {
            //ENTER TUSU
            if (e.KeyCode == Keys.Enter)
            {
                kaydet();
            }
        }

        private void txt_erkek_hayvan_KeyDown(object sender, KeyEventArgs e)
        {
            //ENTER TUSU
            if (e.KeyCode == Keys.Enter)
            {
                kaydet();
            }
        }

        private void txt_disi_hayvan_KeyDown(object sender, KeyEventArgs e)
        {
            //ENTER TUSU
            if (e.KeyCode == Keys.Enter)
            {
                kaydet();
            }
        }

        private void date_dolum_tarih_KeyDown(object sender, KeyEventArgs e)
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
                xtraTabControl1.SelectedTabPage = xtraTabPage2;
                txt_depo_kapasitesi.Focus();
            }


        }

        private void memo_adres_Enter(object sender, EventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            xtraTabControl1.SelectedTabPage = xtraTabPage2;
            txt_depo_kapasitesi.Focus();
        }

        private void xtraTabPage1_Paint(object sender, PaintEventArgs e)
        {

        }
        string cesit;
        int erkek, disi, sonuc, kapasite, doluluk, sure, sonuc1, sonuc2;

        void depo_hesap()
        {
            kapasite = Convert.ToInt32(txt_depo_kapasitesi.Text);
            sure = Convert.ToInt32(txt_dolum_suresi.Text);
            doluluk = Convert.ToInt32(txt_doluluk_orani.Text);
            sonuc1 = kapasite / sure;
            sonuc2 = kapasite - doluluk;


            erkek = Convert.ToInt32(txt_erkek_hayvan.Text);
            disi = Convert.ToInt32(txt_disi_hayvan.Text);
            sonuc = erkek + disi;


        }
        private void btn_kaydet_Click(object sender, EventArgs e)
        {
            kaydet();
        }
        // AYNI VERİ ENGELLEME
        bool durum;
        public void control()
        {
            bag.Open();
            SqlCommand kmt = new SqlCommand("select * from tbl_isletme_depo where depo_no=@p1 and isletme_id=@p2 ", bag);
            kmt.Parameters.AddWithValue("@p1", txt_depo_no.Text);
            kmt.Parameters.AddWithValue("@p2", txt_isletme_id.Text);
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
                if (check_et1.Checked == true)
                {

                    cesit = "ET1";

                    DateTime bugun = new DateTime();
                    bugun = Convert.ToDateTime(DateTime.Now.ToShortDateString());

                    depo_hesap();


                    bag.Open();
                    SqlCommand kmt = new SqlCommand("insert into tbl_isletme_depo (isletme_id,depo_no,depo_durum,depo_durumu,pompa_cesit,depo_kapasitesi,doluluk_miktar,dolum_suresi,gunluk_dolum,kalan_miktar,erkek_hayvan,disi_hayvan,hayvan_sayisi,tedarik_tarihi,kayit_tarihi,dolum_tarihi,resim,adres,durum) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10,@p11,@p12,@p13,@p14,@p15,@p16,@p17,@p18,@p19)", bag);
                    kmt.Parameters.AddWithValue("@p1", Convert.ToInt32(txt_isletme_id.Text));
                    kmt.Parameters.AddWithValue("@p2", txt_depo_no.Text);
                    kmt.Parameters.AddWithValue("@p3", cmb_depo_durumu.Text);
                    kmt.Parameters.AddWithValue("@p4", cmb_depo_durum.Text);
                    kmt.Parameters.AddWithValue("@p5", cesit.ToString());
                    kmt.Parameters.AddWithValue("@p6", Convert.ToInt32(txt_depo_kapasitesi.Text));
                    kmt.Parameters.AddWithValue("@p7", Convert.ToInt32(txt_doluluk_orani.Text));
                    kmt.Parameters.AddWithValue("@p8", Convert.ToInt32(txt_dolum_suresi.Text));
                    kmt.Parameters.AddWithValue("@p9", Convert.ToInt32(sonuc1.ToString()));
                    kmt.Parameters.AddWithValue("@p10", Convert.ToInt32(sonuc2.ToString()));
                    kmt.Parameters.AddWithValue("@p11", Convert.ToInt32(txt_erkek_hayvan.Text));
                    kmt.Parameters.AddWithValue("@p12", Convert.ToInt32(txt_disi_hayvan.Text));
                    kmt.Parameters.AddWithValue("@p13", Convert.ToInt32(sonuc.ToString()));
                    kmt.Parameters.AddWithValue("@p14", Convert.ToDateTime(bugun.ToString()));
                    kmt.Parameters.AddWithValue("@p15", Convert.ToDateTime(bugun.ToString()));
                    kmt.Parameters.AddWithValue("@p16", Convert.ToDateTime(date_dolum_tarih.Text));
                    kmt.Parameters.AddWithValue("@p17", txt_resim.Text);
                    kmt.Parameters.AddWithValue("@p18", memo_adres.Text);
                    kmt.Parameters.AddWithValue("@p19", 0);



                    SqlTransaction trans;
                    trans = bag.BeginTransaction();
                    kmt.Transaction = trans;

                    try
                    {
                        kmt.ExecuteNonQuery();
                        trans.Commit();
                        temizle();
                        xtraTabControl1.SelectedTabPage = xtraTabPage1;
                        txt_depo_no.Focus();

                    }
                    catch
                    {
                        trans.Rollback();
                        XtraMessageBox.Show("LÜTFEN ALANLARI KONTROL EDİNİZ DOĞRU BİLGİ GİRDİĞİNİZDEN EMİN OLUNUZ", "UYARI ", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                    finally
                    {
                        bag.Close();
                        listele_depo();
                    }

                }
                else
                {
                    cesit = "-";

                    DateTime bugun = new DateTime();
                    bugun = Convert.ToDateTime(DateTime.Now.ToShortDateString());

                    depo_hesap();

                    bag.Open();
                    SqlCommand kmt = new SqlCommand("insert into tbl_isletme_depo (isletme_id,depo_no,depo_durum,depo_durumu,pompa_cesit,depo_kapasitesi,doluluk_miktar,dolum_suresi,gunluk_dolum,kalan_miktar,erkek_hayvan,disi_hayvan,hayvan_sayisi,tedarik_tarihi,kayit_tarihi,dolum_tarihi,resim,adres,durum) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10,@p11,@p12,@p13,@p14,@p15,@p16,@p17,@p18,@p19)", bag);
                    kmt.Parameters.AddWithValue("@p1", Convert.ToInt32(txt_isletme_id.Text));
                    kmt.Parameters.AddWithValue("@p2", txt_depo_no.Text);
                    kmt.Parameters.AddWithValue("@p3", cmb_depo_durumu.Text);
                    kmt.Parameters.AddWithValue("@p4", cmb_depo_durum.Text);
                    kmt.Parameters.AddWithValue("@p5", cesit.ToString()); ;
                    kmt.Parameters.AddWithValue("@p6", Convert.ToInt32(txt_depo_kapasitesi.Text));
                    kmt.Parameters.AddWithValue("@p7", Convert.ToInt32(txt_doluluk_orani.Text));
                    kmt.Parameters.AddWithValue("@p8", Convert.ToInt32(txt_dolum_suresi.Text));
                    kmt.Parameters.AddWithValue("@p9", Convert.ToInt32(sonuc1.ToString()));
                    kmt.Parameters.AddWithValue("@p10", Convert.ToInt32(sonuc2.ToString()));
                    kmt.Parameters.AddWithValue("@p11", Convert.ToInt32(txt_erkek_hayvan.Text));
                    kmt.Parameters.AddWithValue("@p12", Convert.ToInt32(txt_disi_hayvan.Text));
                    kmt.Parameters.AddWithValue("@p13", Convert.ToInt32(sonuc.ToString()));
                    kmt.Parameters.AddWithValue("@p14", Convert.ToDateTime(bugun.ToString()));
                    kmt.Parameters.AddWithValue("@p15", Convert.ToDateTime(bugun.ToString()));
                    kmt.Parameters.AddWithValue("@p16", Convert.ToDateTime(date_dolum_tarih.Text));
                    kmt.Parameters.AddWithValue("@p17", txt_resim.Text);
                    kmt.Parameters.AddWithValue("@p18", memo_adres.Text);
                    kmt.Parameters.AddWithValue("@p19", 0);

                    SqlTransaction trans;
                    trans = bag.BeginTransaction();
                    kmt.Transaction = trans;

                    try
                    {
                        kmt.ExecuteNonQuery();
                        trans.Commit();
                        temizle();
                        xtraTabControl1.SelectedTabPage = xtraTabPage1;
                        txt_depo_no.Focus();
                    }
                    catch
                    {
                        trans.Rollback();
                        XtraMessageBox.Show("LÜTFEN ALANLARI KONTROL EDİNİZ DOĞRU BİLGİ GİRDİĞİNİZDEN EMİN OLUNUZ", "UYARI ", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                    finally
                    {
                        bag.Close();
                        listele_depo();

                    }



                }


            }
            else
            {
                XtraMessageBox.Show("İŞLETMEYE KAYITLI DEPO NUMARASI VARDIR LÜTFEN BAŞKA DEPO NUMARASI GİRİNİZ... ", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //TEMİZLE
        void temizle()
        {

            txt_depo_no.Text = "";
            txt_dolum_suresi.Text = "";
            memo_adres.Text = "";
            cmb_depo_durum.Text = "DURUM SEÇİNİZ...";
            txt_depo_kapasitesi.Text = "";
            txt_erkek_hayvan.Text = "";
            txt_disi_hayvan.Text = "";
            txt_dolum_suresi.Text = "";
            txt_doluluk_orani.Text = "";
            txt_resim.Text = "";



        }
    }
    }