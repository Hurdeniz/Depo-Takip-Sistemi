﻿using System;
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
    public partial class frm_sevkiyat_liste : DevExpress.XtraEditors.XtraForm
    {
        public frm_sevkiyat_liste()
        {
            InitializeComponent();
        }
        SqlConnection bag = new SqlConnection(@"Data Source=.;Initial Catalog=db_bts;Integrated Security=True");
        private void frm_sevkiyat_liste_Load(object sender, EventArgs e)
        {

            date_baslangic.Text = DateTime.Now.ToShortDateString();
            date_bitis.Text = DateTime.Now.ToShortDateString();
            listele_sevkiyat();
        }
        //GRİD DOLDUR
        public void listele_sevkiyat()
        {

            bag.Open();
            SqlDataAdapter adt = new SqlDataAdapter("select isletme_no,isletme_adi,irtibat_kisi,irtibat_telefon,tbl_isletme_depo.depo_no,depo_durumu,pompa_cesit,personel,arac_plaka,tedarik_tarih,adres from tbl_yeni_sevkiyat inner join tbl_isletme_depo on tbl_yeni_sevkiyat.depo_id = tbl_isletme_depo.depo_id inner join tbl_yeni_isletme on tbl_yeni_sevkiyat.isletme_id = tbl_yeni_isletme.isletme_id where tedarik_tarih BETWEEN @tar1 and @tar2 Order By tedarik_tarih ASC", bag);
            adt.SelectCommand.Parameters.AddWithValue("@tar1", Convert.ToDateTime(date_baslangic.Text));
            adt.SelectCommand.Parameters.AddWithValue("@tar2", Convert.ToDateTime(date_bitis.Text));

            DataTable dt = new DataTable();
            adt.Fill(dt);
            grid_sevkiyat.DataSource = dt;
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
            gridView1.Columns[2].Caption = "İRTİBAT KİŞİ";
            gridView1.Columns[3].Caption = "TELEFON";
            gridView1.Columns[4].Caption = "DEPO NO";
            gridView1.Columns[5].Caption = "POMPA DURUMU";
            gridView1.Columns[6].Caption = "POMPA ÇEŞİT";
            gridView1.Columns[7].Caption = "PERSONEL";
            gridView1.Columns[8].Caption = "ARAÇ PLAKA";
            gridView1.Columns[9].Caption = "TEDARİK TARİHİ";
            gridView1.Columns[10].Caption = "ADRES";



        }

        private void bar_btn_excel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            XtraSaveFileDialog save = new XtraSaveFileDialog();

            if (save.ShowDialog() == DialogResult.OK)
            {
                gridView1.ExportToXlsx(save.FileName + ".xlsx");
            }
        }
        // FİLTRE BUTONU
        int sayac = 1;
        private void bar_btn_filtre_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (sayac == 2)
            {
                panel_tarihh.Visible = false;

                sayac = 1;
            }
            else
            {
                panel_tarihh.Visible = true;
                sayac++;

            }
        }

        private void bar_btn_yenile_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            listele_sevkiyat();
        }

        private void btn_goster_Click(object sender, EventArgs e)
        {
            listele_sevkiyat();
        }
    }
}