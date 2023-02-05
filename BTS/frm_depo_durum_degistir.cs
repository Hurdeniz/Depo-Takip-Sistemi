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
    public partial class frm_depo_durum_degistir : DevExpress.XtraEditors.XtraForm
    {
        public frm_depo_durum_degistir()
        {
            InitializeComponent();
        }
        SqlConnection bag = new SqlConnection(@"Data Source=.;Initial Catalog=db_bts;Integrated Security=True");
        public int durum;
        public int isletme_depo_id;
        
        private void frm_depo_durum_degistir_Load(object sender, EventArgs e)
        {
            
            if (durum==1)
            {
                checkEdit1.Enabled = false;
            }
            else if (durum == 2)
            {
                checkEdit2.Enabled = false;
            }
            else if (durum == 3)
            {
                checkEdit3.Enabled = false;
            }
        }
       
        //KAYDET
        string adi;
        private void btn_kaydet_Click(object sender, EventArgs e)
        {
            if (checkEdit1.Checked == true)
            {

                adi = "POMPALI";
                kaydet();

            }
            else if (checkEdit2.Checked == true)
            {

                adi = "POMPASIZ";
                kaydet();

            }
            else if (checkEdit3.Checked == true)
            {

                adi = "HELEZONLU";
                kaydet();

            }


            else
            {
                XtraMessageBox.Show("LÜTFEN DEPO DURUMU SEÇİNİZ", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        // VERİ GÜNCELLEME
        void kaydet()
        {
            if (durum == 1)
            {
                bag.Open();
                SqlCommand kmt = new SqlCommand("update tbl_isletme_depo set depo_durumu=@p1 where depo_id=@p2", bag);
                kmt.Parameters.AddWithValue("@p1", adi.ToString());
                kmt.Parameters.AddWithValue("@p2", isletme_depo_id.ToString());

                kmt.Connection = bag;

                SqlTransaction trans;
                trans = bag.BeginTransaction();
                kmt.Transaction = trans;

                try
                {
                    kmt.ExecuteNonQuery();
                    trans.Commit();
                    XtraMessageBox.Show("İŞLETME DEPO DURUMU GÜNCELLENMİŞTİR.", "GÜNCELLEME BAŞARILI ", MessageBoxButtons.OK);

                }
                catch
                {
                    trans.Rollback();
                    XtraMessageBox.Show("GÜNCELLEME YAPILAMAMIŞTIR.LÜTFEN ALANLARI KONTROL EDİN DOĞRU BİLGİ GİRDİĞİNİZDEN EMİN OLUN", "GÜNCELLEME BAŞARISIZ ", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                finally
                {
                    bag.Close();
                }



                // POMPALI FORMUNDAKİ GRİD YENİLEME

                frm_depo_pompali pompali = (frm_depo_pompali)Application.OpenForms["frm_depo_pompali"];
                pompali.depo_pompali();

                //FORM KAPAT
                this.Close();
            }
            else if (durum == 2)
            {
                bag.Open();
                SqlCommand kmt = new SqlCommand("update tbl_isletme_depo set depo_durumu=@p1 where depo_id=@p2", bag);
                kmt.Parameters.AddWithValue("@p1", adi.ToString());
                kmt.Parameters.AddWithValue("@p2", isletme_depo_id.ToString());

                kmt.Connection = bag;

                SqlTransaction trans;
                trans = bag.BeginTransaction();
                kmt.Transaction = trans;

                try
                {
                    kmt.ExecuteNonQuery();
                    trans.Commit();
                    XtraMessageBox.Show("İŞLETME DEPO DURUMU GÜNCELLENMİŞTİR.", "GÜNCELLEME BAŞARILI ", MessageBoxButtons.OK);

                }
                catch
                {
                    trans.Rollback();
                    XtraMessageBox.Show("GÜNCELLEME YAPILAMAMIŞTIR.LÜTFEN ALANLARI KONTROL EDİN DOĞRU BİLGİ GİRDİĞİNİZDEN EMİN OLUN", "GÜNCELLEME BAŞARISIZ ", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                finally
                {
                    bag.Close();
                }



                // POMPALI FORMUNDAKİ GRİD YENİLEME

                frm_depo_pompasiz pompasiz = (frm_depo_pompasiz)Application.OpenForms["frm_depo_pompasiz"];
                pompasiz.depo_pompasiz();

                //FORM KAPAT
                this.Close();
            }
            else if (durum == 3)
            {
                bag.Open();
                SqlCommand kmt = new SqlCommand("update tbl_isletme_depo set depo_durumu=@p1 where depo_id=@p2", bag);
                kmt.Parameters.AddWithValue("@p1", adi.ToString());
                kmt.Parameters.AddWithValue("@p2", isletme_depo_id.ToString());

                kmt.Connection = bag;

                SqlTransaction trans;
                trans = bag.BeginTransaction();
                kmt.Transaction = trans;

                try
                {
                    kmt.ExecuteNonQuery();
                    trans.Commit();
                    XtraMessageBox.Show("İŞLETME DEPO DURUMU GÜNCELLENMİŞTİR.", "GÜNCELLEME BAŞARILI ", MessageBoxButtons.OK);

                }
                catch
                {
                    trans.Rollback();
                    XtraMessageBox.Show("GÜNCELLEME YAPILAMAMIŞTIR.LÜTFEN ALANLARI KONTROL EDİN DOĞRU BİLGİ GİRDİĞİNİZDEN EMİN OLUN", "GÜNCELLEME BAŞARISIZ ", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                finally
                {
                    bag.Close();
                }



                // POMPALI FORMUNDAKİ GRİD YENİLEME

                frm_depo_helezonlu helezonlu = (frm_depo_helezonlu)Application.OpenForms["frm_depo_helezonlu"];
                helezonlu.depo_helezonlu();

                //FORM KAPAT
                this.Close();




            }

        }
        private void checkEdit1_CheckedChanged(object sender, EventArgs e)
        {

            if (checkEdit1.Checked == true)
            {
                checkEdit2.Enabled = false;
                checkEdit3.Enabled = false;
               
            }
            else
            {
                checkEdit1.Checked = false;
                checkEdit2.Enabled = true;
                checkEdit3.Enabled = true;
             
            }
        }

        private void checkEdit2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkEdit2.Checked == true)
            {
                checkEdit1.Enabled = false;
                checkEdit3.Enabled = false;

            }
            else
            {
                checkEdit2.Checked = false;
                checkEdit1.Enabled = true;
                checkEdit3.Enabled = true;

            }
        }

        private void checkEdit3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkEdit3.Checked == true)
            {
                checkEdit1.Enabled = false;
                checkEdit2.Enabled = false;

            }
            else
            {
                checkEdit3.Checked = false;
                checkEdit1.Enabled = true;
                checkEdit2.Enabled = true;

            }
        }
    }
}