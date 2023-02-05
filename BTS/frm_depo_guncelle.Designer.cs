namespace BTS
{
    partial class frm_depo_guncelle
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_depo_guncelle));
            this.ımageCollection1 = new DevExpress.Utils.ImageCollection(this.components);
            this.xtraOpenFileDialog1 = new DevExpress.XtraEditors.XtraOpenFileDialog(this.components);
            this.label14 = new System.Windows.Forms.Label();
            this.cmb_depo_durumu = new DevExpress.XtraEditors.ComboBoxEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_depo_no = new DevExpress.XtraEditors.TextEdit();
            this.memo_adres = new DevExpress.XtraEditors.MemoEdit();
            this.label18 = new System.Windows.Forms.Label();
            this.cmb_depo_durum = new DevExpress.XtraEditors.ComboBoxEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_resim = new DevExpress.XtraEditors.ButtonEdit();
            this.btn_kaydet = new DevExpress.XtraEditors.SimpleButton();
            this.date_dolum_tarih = new DevExpress.XtraEditors.DateEdit();
            this.label5 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.txt_depo_kapasitesi = new DevExpress.XtraEditors.TextEdit();
            this.txt_disi_hayvan = new DevExpress.XtraEditors.TextEdit();
            this.txt_dolum_suresi = new DevExpress.XtraEditors.TextEdit();
            this.label15 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_erkek_hayvan = new DevExpress.XtraEditors.TextEdit();
            this.txt_doluluk_orani = new DevExpress.XtraEditors.TextEdit();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            ((System.ComponentModel.ISupportInitialize)(this.ımageCollection1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_depo_durumu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_depo_no.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memo_adres.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_depo_durum.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_resim.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.date_dolum_tarih.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.date_dolum_tarih.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_depo_kapasitesi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_disi_hayvan.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_dolum_suresi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_erkek_hayvan.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_doluluk_orani.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            this.SuspendLayout();
            // 
            // ımageCollection1
            // 
            this.ımageCollection1.ImageSize = new System.Drawing.Size(50, 50);
            this.ımageCollection1.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("ımageCollection1.ImageStream")));
            this.ımageCollection1.Images.SetKeyName(0, "iconfinder_save_46830.png");
            this.ımageCollection1.Images.SetKeyName(1, "iconfinder_34_61498.png");
            // 
            // xtraOpenFileDialog1
            // 
            this.xtraOpenFileDialog1.FileName = "xtraOpenFileDialog1";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label14.Location = new System.Drawing.Point(5, 246);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(178, 29);
            this.label14.TabIndex = 50;
            this.label14.Text = "DEPO DURUMU";
            // 
            // cmb_depo_durumu
            // 
            this.cmb_depo_durumu.EditValue = "AKTİF";
            this.cmb_depo_durumu.Location = new System.Drawing.Point(9, 277);
            this.cmb_depo_durumu.Name = "cmb_depo_durumu";
            this.cmb_depo_durumu.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmb_depo_durumu.Properties.Appearance.Options.UseFont = true;
            this.cmb_depo_durumu.Properties.Appearance.Options.UseTextOptions = true;
            this.cmb_depo_durumu.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.cmb_depo_durumu.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmb_depo_durumu.Properties.Items.AddRange(new object[] {
            "AKTİF",
            "PASİF"});
            this.cmb_depo_durumu.Size = new System.Drawing.Size(324, 34);
            this.cmb_depo_durumu.TabIndex = 4;
            this.cmb_depo_durumu.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmb_depo_durumu_KeyDown);
            this.cmb_depo_durumu.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmb_depo_durumu_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(5, 178);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 29);
            this.label1.TabIndex = 46;
            this.label1.Text = "DEPO RESMİ";
            // 
            // txt_depo_no
            // 
            this.txt_depo_no.Location = new System.Drawing.Point(9, 73);
            this.txt_depo_no.Name = "txt_depo_no";
            this.txt_depo_no.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_depo_no.Properties.Appearance.Options.UseFont = true;
            this.txt_depo_no.Properties.Appearance.Options.UseTextOptions = true;
            this.txt_depo_no.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txt_depo_no.Properties.Mask.EditMask = "d";
            this.txt_depo_no.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txt_depo_no.Size = new System.Drawing.Size(324, 34);
            this.txt_depo_no.TabIndex = 1;
            this.txt_depo_no.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_depo_no_KeyDown);
            // 
            // memo_adres
            // 
            this.memo_adres.Location = new System.Drawing.Point(10, 349);
            this.memo_adres.Name = "memo_adres";
            this.memo_adres.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.memo_adres.Properties.Appearance.Options.UseFont = true;
            this.memo_adres.Size = new System.Drawing.Size(323, 137);
            this.memo_adres.TabIndex = 5;
            this.memo_adres.KeyDown += new System.Windows.Forms.KeyEventHandler(this.memo_adres_KeyDown);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label18.Location = new System.Drawing.Point(5, 110);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(195, 29);
            this.label18.TabIndex = 45;
            this.label18.Text = "POMPA DURUMU";
            // 
            // cmb_depo_durum
            // 
            this.cmb_depo_durum.EditValue = "DURUM SEÇİNİZ...";
            this.cmb_depo_durum.Location = new System.Drawing.Point(9, 141);
            this.cmb_depo_durum.Name = "cmb_depo_durum";
            this.cmb_depo_durum.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmb_depo_durum.Properties.Appearance.Options.UseFont = true;
            this.cmb_depo_durum.Properties.Appearance.Options.UseTextOptions = true;
            this.cmb_depo_durum.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.cmb_depo_durum.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmb_depo_durum.Properties.Items.AddRange(new object[] {
            "POMPALI",
            "POMPASIZ",
            "HELEZONLU"});
            this.cmb_depo_durum.Size = new System.Drawing.Size(324, 34);
            this.cmb_depo_durum.TabIndex = 2;
            this.cmb_depo_durum.SelectedIndexChanged += new System.EventHandler(this.cmb_depo_durum_SelectedIndexChanged);
            this.cmb_depo_durum.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmb_depo_durum_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(5, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(196, 29);
            this.label2.TabIndex = 48;
            this.label2.Text = "DEPO NUMARASI";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(5, 317);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 29);
            this.label7.TabIndex = 13;
            this.label7.Text = "ADRES";
            // 
            // txt_resim
            // 
            this.txt_resim.Location = new System.Drawing.Point(9, 209);
            this.txt_resim.Name = "txt_resim";
            this.txt_resim.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_resim.Properties.Appearance.Options.UseFont = true;
            this.txt_resim.Properties.Appearance.Options.UseTextOptions = true;
            this.txt_resim.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txt_resim.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.txt_resim.Properties.Mask.EditMask = "d";
            this.txt_resim.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txt_resim.Size = new System.Drawing.Size(324, 34);
            this.txt_resim.TabIndex = 3;
            this.txt_resim.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.txt_resim_ButtonClick);
            this.txt_resim.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_resim_KeyDown);
            // 
            // btn_kaydet
            // 
            this.btn_kaydet.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_kaydet.Appearance.Options.UseFont = true;
            this.btn_kaydet.ImageOptions.ImageIndex = 0;
            this.btn_kaydet.ImageOptions.ImageList = this.ımageCollection1;
            this.btn_kaydet.Location = new System.Drawing.Point(216, 514);
            this.btn_kaydet.Name = "btn_kaydet";
            this.btn_kaydet.Size = new System.Drawing.Size(298, 59);
            this.btn_kaydet.TabIndex = 12;
            this.btn_kaydet.TabStop = false;
            this.btn_kaydet.Text = "KAYDET";
            this.btn_kaydet.Click += new System.EventHandler(this.btn_kaydet_Click);
            // 
            // date_dolum_tarih
            // 
            this.date_dolum_tarih.EditValue = null;
            this.date_dolum_tarih.Location = new System.Drawing.Point(10, 418);
            this.date_dolum_tarih.Name = "date_dolum_tarih";
            this.date_dolum_tarih.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.date_dolum_tarih.Properties.Appearance.Options.UseFont = true;
            this.date_dolum_tarih.Properties.Appearance.Options.UseTextOptions = true;
            this.date_dolum_tarih.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.date_dolum_tarih.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.date_dolum_tarih.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.date_dolum_tarih.Properties.Mask.EditMask = "99.99.0000";
            this.date_dolum_tarih.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple;
            this.date_dolum_tarih.Size = new System.Drawing.Size(324, 34);
            this.date_dolum_tarih.TabIndex = 11;
            this.date_dolum_tarih.TabStop = false;
            this.date_dolum_tarih.KeyDown += new System.Windows.Forms.KeyEventHandler(this.date_dolum_tarih_KeyDown);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(5, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(206, 29);
            this.label5.TabIndex = 31;
            this.label5.Text = "DEPO KAPASİTESİ";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label17.Location = new System.Drawing.Point(5, 386);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(178, 29);
            this.label17.TabIndex = 44;
            this.label17.Text = "DOLUM TARİHİ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(5, 178);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(180, 29);
            this.label6.TabIndex = 33;
            this.label6.Text = "DOLUM SÜRESİ";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label16.Location = new System.Drawing.Point(5, 317);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(236, 29);
            this.label16.TabIndex = 43;
            this.label16.Text = "DİŞİ HAYVAN SAYISI";
            // 
            // txt_depo_kapasitesi
            // 
            this.txt_depo_kapasitesi.Location = new System.Drawing.Point(9, 73);
            this.txt_depo_kapasitesi.Name = "txt_depo_kapasitesi";
            this.txt_depo_kapasitesi.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_depo_kapasitesi.Properties.Appearance.Options.UseFont = true;
            this.txt_depo_kapasitesi.Properties.Appearance.Options.UseTextOptions = true;
            this.txt_depo_kapasitesi.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txt_depo_kapasitesi.Properties.Mask.EditMask = "d";
            this.txt_depo_kapasitesi.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txt_depo_kapasitesi.Size = new System.Drawing.Size(324, 34);
            this.txt_depo_kapasitesi.TabIndex = 6;
            this.txt_depo_kapasitesi.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_depo_kapasitesi_KeyDown);
            // 
            // txt_disi_hayvan
            // 
            this.txt_disi_hayvan.Location = new System.Drawing.Point(9, 349);
            this.txt_disi_hayvan.Name = "txt_disi_hayvan";
            this.txt_disi_hayvan.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_disi_hayvan.Properties.Appearance.Options.UseFont = true;
            this.txt_disi_hayvan.Properties.Appearance.Options.UseTextOptions = true;
            this.txt_disi_hayvan.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txt_disi_hayvan.Properties.Mask.EditMask = "d";
            this.txt_disi_hayvan.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txt_disi_hayvan.Size = new System.Drawing.Size(324, 34);
            this.txt_disi_hayvan.TabIndex = 10;
            this.txt_disi_hayvan.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_disi_hayvan_KeyDown);
            // 
            // txt_dolum_suresi
            // 
            this.txt_dolum_suresi.Location = new System.Drawing.Point(10, 209);
            this.txt_dolum_suresi.Name = "txt_dolum_suresi";
            this.txt_dolum_suresi.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_dolum_suresi.Properties.Appearance.Options.UseFont = true;
            this.txt_dolum_suresi.Properties.Appearance.Options.UseTextOptions = true;
            this.txt_dolum_suresi.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txt_dolum_suresi.Properties.Mask.EditMask = "d";
            this.txt_dolum_suresi.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txt_dolum_suresi.Size = new System.Drawing.Size(324, 34);
            this.txt_dolum_suresi.TabIndex = 8;
            this.txt_dolum_suresi.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_dolum_suresi_KeyDown);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label15.Location = new System.Drawing.Point(5, 246);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(258, 29);
            this.label15.TabIndex = 40;
            this.label15.Text = "ERKEK HAYVAN SAYISI";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(5, 110);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(195, 29);
            this.label9.TabIndex = 36;
            this.label9.Text = "DOLULUK ORANI";
            // 
            // txt_erkek_hayvan
            // 
            this.txt_erkek_hayvan.Location = new System.Drawing.Point(10, 277);
            this.txt_erkek_hayvan.Name = "txt_erkek_hayvan";
            this.txt_erkek_hayvan.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_erkek_hayvan.Properties.Appearance.Options.UseFont = true;
            this.txt_erkek_hayvan.Properties.Appearance.Options.UseTextOptions = true;
            this.txt_erkek_hayvan.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txt_erkek_hayvan.Properties.Mask.EditMask = "d";
            this.txt_erkek_hayvan.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txt_erkek_hayvan.Size = new System.Drawing.Size(324, 34);
            this.txt_erkek_hayvan.TabIndex = 9;
            this.txt_erkek_hayvan.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_erkek_hayvan_KeyDown);
            // 
            // txt_doluluk_orani
            // 
            this.txt_doluluk_orani.Location = new System.Drawing.Point(10, 141);
            this.txt_doluluk_orani.Name = "txt_doluluk_orani";
            this.txt_doluluk_orani.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_doluluk_orani.Properties.Appearance.Options.UseFont = true;
            this.txt_doluluk_orani.Properties.Appearance.Options.UseTextOptions = true;
            this.txt_doluluk_orani.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txt_doluluk_orani.Properties.Mask.EditMask = "d";
            this.txt_doluluk_orani.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txt_doluluk_orani.Size = new System.Drawing.Size(324, 34);
            this.txt_doluluk_orani.TabIndex = 7;
            this.txt_doluluk_orani.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_doluluk_orani_KeyDown);
            // 
            // groupControl1
            // 
            this.groupControl1.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupControl1.AppearanceCaption.Options.UseFont = true;
            this.groupControl1.AppearanceCaption.Options.UseTextOptions = true;
            this.groupControl1.AppearanceCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.groupControl1.CaptionImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("groupControl1.CaptionImageOptions.Image")));
            this.groupControl1.Controls.Add(this.label14);
            this.groupControl1.Controls.Add(this.cmb_depo_durumu);
            this.groupControl1.Controls.Add(this.txt_resim);
            this.groupControl1.Controls.Add(this.label1);
            this.groupControl1.Controls.Add(this.label7);
            this.groupControl1.Controls.Add(this.txt_depo_no);
            this.groupControl1.Controls.Add(this.label2);
            this.groupControl1.Controls.Add(this.memo_adres);
            this.groupControl1.Controls.Add(this.cmb_depo_durum);
            this.groupControl1.Controls.Add(this.label18);
            this.groupControl1.Location = new System.Drawing.Point(12, 12);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(345, 496);
            this.groupControl1.TabIndex = 28;
            this.groupControl1.Text = "DEPO BİLGİLERİ";
            // 
            // groupControl2
            // 
            this.groupControl2.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupControl2.AppearanceCaption.Options.UseFont = true;
            this.groupControl2.AppearanceCaption.Options.UseTextOptions = true;
            this.groupControl2.AppearanceCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.groupControl2.CaptionImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("groupControl2.CaptionImageOptions.Image")));
            this.groupControl2.Controls.Add(this.date_dolum_tarih);
            this.groupControl2.Controls.Add(this.label5);
            this.groupControl2.Controls.Add(this.txt_doluluk_orani);
            this.groupControl2.Controls.Add(this.txt_erkek_hayvan);
            this.groupControl2.Controls.Add(this.label17);
            this.groupControl2.Controls.Add(this.label9);
            this.groupControl2.Controls.Add(this.label15);
            this.groupControl2.Controls.Add(this.label6);
            this.groupControl2.Controls.Add(this.txt_dolum_suresi);
            this.groupControl2.Controls.Add(this.label16);
            this.groupControl2.Controls.Add(this.txt_disi_hayvan);
            this.groupControl2.Controls.Add(this.txt_depo_kapasitesi);
            this.groupControl2.Location = new System.Drawing.Point(363, 12);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(345, 496);
            this.groupControl2.TabIndex = 29;
            this.groupControl2.Text = "KAPASİTE BİLGİLERİ";
            // 
            // frm_depo_guncelle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 584);
            this.Controls.Add(this.btn_kaydet);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IconOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("frm_depo_guncelle.IconOptions.LargeImage")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_depo_guncelle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DEPO GÜNCELLE";
            this.Load += new System.EventHandler(this.frm_depo_guncelle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ımageCollection1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_depo_durumu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_depo_no.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memo_adres.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_depo_durum.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_resim.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.date_dolum_tarih.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.date_dolum_tarih.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_depo_kapasitesi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_disi_hayvan.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_dolum_suresi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_erkek_hayvan.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_doluluk_orani.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.Utils.ImageCollection ımageCollection1;
        private DevExpress.XtraEditors.XtraOpenFileDialog xtraOpenFileDialog1;
        private System.Windows.Forms.Label label14;
        private DevExpress.XtraEditors.ComboBoxEdit cmb_depo_durumu;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.TextEdit txt_depo_no;
        private DevExpress.XtraEditors.MemoEdit memo_adres;
        private System.Windows.Forms.Label label18;
        private DevExpress.XtraEditors.ComboBoxEdit cmb_depo_durum;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private DevExpress.XtraEditors.ButtonEdit txt_resim;
        private DevExpress.XtraEditors.SimpleButton btn_kaydet;
        private DevExpress.XtraEditors.DateEdit date_dolum_tarih;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label16;
        private DevExpress.XtraEditors.TextEdit txt_depo_kapasitesi;
        private DevExpress.XtraEditors.TextEdit txt_disi_hayvan;
        private DevExpress.XtraEditors.TextEdit txt_dolum_suresi;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label9;
        private DevExpress.XtraEditors.TextEdit txt_erkek_hayvan;
        private DevExpress.XtraEditors.TextEdit txt_doluluk_orani;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
    }
}