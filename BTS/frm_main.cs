using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;

namespace BTS
{
    public partial class frm_main : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public frm_main()
        {
            InitializeComponent();
        }
        //YENİ İŞLETME
        frm_yeni_isletmee frm_yeni;
        private void bar_btn_yeni_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (frm_yeni == null || frm_yeni.IsDisposed)
            {
                
                frm_yeni = new frm_yeni_isletmee();
                frm_yeni.MdiParent = this;
                frm_yeni.Show();
            }
        }
        
        private void bar_btn_guncelle_ItemClick(object sender, ItemClickEventArgs e)
        {
          
        }

        private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
        {

        }
        //YENİ SEVKİYAT
        frm_sevkiyat_olustur frm_sevkiyat;
        private void bar_btn_yeni_sevkiyat_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (frm_sevkiyat == null || frm_sevkiyat.IsDisposed)
            {
                frm_sevkiyat = new frm_sevkiyat_olustur();
                frm_sevkiyat.MdiParent = this;
                frm_sevkiyat.Show();
            }

        }

        private void barButtonItem16_ItemClick(object sender, ItemClickEventArgs e)
        {
            
        }
        //İŞLETMELER
        frm_isletmeler frm_isletme;
        private void bar_btn_isletmeler_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (frm_isletme == null || frm_isletme.IsDisposed)
            {
                frm_isletme = new frm_isletmeler();
                frm_isletme.MdiParent = this;
                frm_isletme.Show();
            }
        }
        //DEPO BİLGİLERİ
        frm_depo_bilgileri depo_bilgiler;
        private void bar_btn_depo_bilgileri_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (depo_bilgiler == null || depo_bilgiler.IsDisposed)
            {
                depo_bilgiler = new frm_depo_bilgileri();
                depo_bilgiler.MdiParent = this;
                depo_bilgiler.Show();
            }
        }
        //KAPASİTE DURUM
        frm_kapasite_durum kapasite_durum;
        private void bar_btn_kapasite_durum_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (kapasite_durum == null || kapasite_durum.IsDisposed)
            {
                kapasite_durum = new frm_kapasite_durum();
                kapasite_durum.MdiParent = this;
                kapasite_durum.Show();
            }
        }
        //DOLMAK ÜZERE
        frm_dolmak_uzere frm_dolmak_uzere;
        private void bar_btn_dolmak_uzere_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (frm_dolmak_uzere == null || frm_dolmak_uzere.IsDisposed)
            {
                frm_dolmak_uzere = new frm_dolmak_uzere();
                frm_dolmak_uzere.MdiParent = this;
                frm_dolmak_uzere.Show();
            }
        }
        //POMPALI DEPO
        frm_depo_pompali pompali_depo;
        private void bar_btn_pompali_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (pompali_depo == null || pompali_depo.IsDisposed)
            {
                pompali_depo = new frm_depo_pompali();
                pompali_depo.MdiParent = this;
                pompali_depo.Show();
            }
        }
        //POMPASIZ DEPO
        frm_depo_pompasiz pompasiz_depo;
        private void bar_btn_pompasiz_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (pompasiz_depo == null || pompasiz_depo.IsDisposed)
            {
                pompasiz_depo = new frm_depo_pompasiz();
                pompasiz_depo.MdiParent = this;
                pompasiz_depo.Show();
            }
        }
        //HELEZONLU DEPO
        frm_depo_helezonlu helezonlu_depo;
        private void bar_btn_helezonlu_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (helezonlu_depo == null || helezonlu_depo.IsDisposed)
            {
                helezonlu_depo = new frm_depo_helezonlu();
                helezonlu_depo.MdiParent = this;
                helezonlu_depo.Show();
            }
        }
        //AKTİF İŞETME
        frm_aktif_isletme aktif_isletme;
        private void bar_btn_aktif_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (aktif_isletme == null || aktif_isletme.IsDisposed)
            {
                aktif_isletme = new frm_aktif_isletme();
                aktif_isletme.MdiParent = this;
                aktif_isletme.Show();
            }
        }
        //PASİF İŞLETME
        frm_pasif_isletme pasif_isletme;
        private void bar_btn_pasif_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (pasif_isletme == null || pasif_isletme.IsDisposed)
            {
                pasif_isletme = new frm_pasif_isletme();
                pasif_isletme.MdiParent = this;
                pasif_isletme.Show();
            }
        }
        //SVKİYAT LİSTESİ
        frm_sevkiyat_listesi sevkiyat_liste;
        private void bar_btn_sevkiyat_liste_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (sevkiyat_liste == null || sevkiyat_liste.IsDisposed)
            {
                sevkiyat_liste = new frm_sevkiyat_listesi();
                sevkiyat_liste.MdiParent = this;
                sevkiyat_liste.Show();
            }
        }
        
        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
        }
        //YENİ DEPO GİRİŞ
        frm_yeni_depo yeni_depo;
        private void bar_btn_yeni_depo_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (yeni_depo == null || yeni_depo.IsDisposed)
            {
                yeni_depo = new frm_yeni_depo();
                yeni_depo.MdiParent = this;
                yeni_depo.Show();
            }
        }
        //İŞLETME DEPOLARI
        frm_depolar depolar;
        private void bar_btn_depolar_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (depolar == null || depolar.IsDisposed)
            {
                depolar = new frm_depolar();
                depolar.MdiParent = this;
                depolar.Show();
            }
        }
        //KM VE TONAJ
        frm_km_gir km_tonaj;
        private void bar_btn_km_tonaj_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (km_tonaj == null || km_tonaj.IsDisposed)
            {
                km_tonaj = new frm_km_gir();
                km_tonaj.MdiParent = this;
                km_tonaj.Show();
            }
        }
        //SEVKİYAT LİSTESİ
        frm_sevkiyat_listele sevk_liste;
        private void bar_btn_sevkiyat_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (sevk_liste == null || sevk_liste.IsDisposed)
            {
                sevk_liste = new frm_sevkiyat_listele();
                sevk_liste.MdiParent = this;
                sevk_liste.Show();
            }
        }

        private void bar_btn_personel_ItemClick(object sender, ItemClickEventArgs e)
        {
            frm_personel personel = new frm_personel();
            personel.Show();
        }

        private void bar_btn_arac_ItemClick(object sender, ItemClickEventArgs e)
        {
            frm_arac arac = new frm_arac();
            arac.Show();
        }

        private void frm_main_Load(object sender, EventArgs e)
        {
            timer1.Start();

            if (frm_dolmak_uzere == null)
            {
                frm_dolmak_uzere = new frm_dolmak_uzere();
                frm_dolmak_uzere.MdiParent = this;
                frm_dolmak_uzere.Show();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            date_tarih.EditValue = DateTime.Now.ToShortDateString();
            date_saat.EditValue = DateTime.Now.ToShortTimeString();
        }
       
        private void bar_btn_rapor_ItemClick(object sender, ItemClickEventArgs e)
        {
          
        }

        private void frm_main_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr = XtraMessageBox.Show("PROGRAMDAN ÇIKMAK İSTEDİĞİNİZDEN EMİN MİSİNİZ ? ", "İŞLETME DEPO TAKİP SİSTEMİ", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (dr == DialogResult.No)
            {
                e.Cancel = true;
            }
            else
            {
                e.Cancel = false;

            }
        }

        private void frm_main_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void barEditItem1_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void bar_btn_rapor_isletme_ItemClick(object sender, ItemClickEventArgs e)
        {
           
        }

        private void bar_btn_rapor_depo_ItemClick(object sender, ItemClickEventArgs e)
        {
           
        }
        // İŞLETME RAPOR
        private void bar_btn_rpr_isletme_ItemClick(object sender, ItemClickEventArgs e)
        {
            frm_raporr rpr = new frm_raporr(new rpt_isletmeler());
            rpr.Show();
        }
        //DEPO RAPOR
        private void bar_btn_rpr_depo_ItemClick(object sender, ItemClickEventArgs e)
        {
            frm_raporr rpr = new frm_raporr(new rpt_isletme_depolar());
            rpr.Show();
        }
        //SEVKİYAT RAPOR
        private void bar_btn_rpr_sevkiyat_ItemClick(object sender, ItemClickEventArgs e)
        {
            frm_raporr rpr = new frm_raporr(new XtraReport1());
            rpr.Show();
        }
        //AKTİF İŞLETME RAPOR
        private void bar_btn_rpr_aktif_ItemClick(object sender, ItemClickEventArgs e)
        {
            frm_raporr rpr = new frm_raporr(new rpt_aktif_isletme());
            rpr.Show();
        }

        private void bar_btn_rpr_pasif_ItemClick(object sender, ItemClickEventArgs e)
        {
            frm_raporr rpr = new frm_raporr(new rpt_pasif_isletme());
            rpr.Show();
        }

        private void bar_btn_rpr_pompali_ItemClick(object sender, ItemClickEventArgs e)
        {
            frm_raporr rpr = new frm_raporr(new rpt_pompali_depo());
            rpr.Show();
        }

        private void bar_btn_rpr_pompasiz_ItemClick(object sender, ItemClickEventArgs e)
        {
            frm_raporr rpr = new frm_raporr(new rpt_pompasiz_depo());
            rpr.Show();
        }

        private void bar_btn_rpr_helezonlu_ItemClick(object sender, ItemClickEventArgs e)
        {
            frm_raporr rpr = new frm_raporr(new rpt_helezonlu_depo());
            rpr.Show();
        }
    }
}