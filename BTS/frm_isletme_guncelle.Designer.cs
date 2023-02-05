namespace BTS
{
    partial class frm_isletme_guncelle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_isletme_guncelle));
            this.ımageCollection1 = new DevExpress.Utils.ImageCollection(this.components);
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btn_kaydet = new DevExpress.XtraEditors.SimpleButton();
            this.label14 = new System.Windows.Forms.Label();
            this.txt_isletme_sahibi = new DevExpress.XtraEditors.TextEdit();
            this.label13 = new System.Windows.Forms.Label();
            this.txt_isletme_no = new DevExpress.XtraEditors.TextEdit();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_isletme_adi = new DevExpress.XtraEditors.TextEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_irtibat_kisi = new DevExpress.XtraEditors.TextEdit();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_telefon = new DevExpress.XtraEditors.TextEdit();
            this.cmb_isletme_durumu = new DevExpress.XtraEditors.ComboBoxEdit();
            ((System.ComponentModel.ISupportInitialize)(this.ımageCollection1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_isletme_sahibi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_isletme_no.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_isletme_adi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_irtibat_kisi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_telefon.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_isletme_durumu.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // ımageCollection1
            // 
            this.ımageCollection1.ImageSize = new System.Drawing.Size(50, 50);
            this.ımageCollection1.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("ımageCollection1.ImageStream")));
            this.ımageCollection1.Images.SetKeyName(0, "iconfinder_save_46830.png");
            this.ımageCollection1.Images.SetKeyName(1, "iconfinder_34_61498.png");
            // 
            // groupControl1
            // 
            this.groupControl1.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupControl1.AppearanceCaption.Options.UseFont = true;
            this.groupControl1.AppearanceCaption.Options.UseTextOptions = true;
            this.groupControl1.AppearanceCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.groupControl1.CaptionImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("groupControl1.CaptionImageOptions.Image")));
            this.groupControl1.Controls.Add(this.btn_kaydet);
            this.groupControl1.Controls.Add(this.label14);
            this.groupControl1.Controls.Add(this.txt_isletme_sahibi);
            this.groupControl1.Controls.Add(this.label13);
            this.groupControl1.Controls.Add(this.txt_isletme_no);
            this.groupControl1.Controls.Add(this.label12);
            this.groupControl1.Controls.Add(this.txt_isletme_adi);
            this.groupControl1.Controls.Add(this.label1);
            this.groupControl1.Controls.Add(this.label2);
            this.groupControl1.Controls.Add(this.txt_irtibat_kisi);
            this.groupControl1.Controls.Add(this.label3);
            this.groupControl1.Controls.Add(this.txt_telefon);
            this.groupControl1.Controls.Add(this.cmb_isletme_durumu);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(347, 543);
            this.groupControl1.TabIndex = 24;
            this.groupControl1.Text = "İŞLETME BİLGİLERİ";
            // 
            // btn_kaydet
            // 
            this.btn_kaydet.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_kaydet.Appearance.Options.UseFont = true;
            this.btn_kaydet.ImageOptions.ImageIndex = 0;
            this.btn_kaydet.ImageOptions.ImageList = this.ımageCollection1;
            this.btn_kaydet.Location = new System.Drawing.Point(11, 460);
            this.btn_kaydet.Name = "btn_kaydet";
            this.btn_kaydet.Size = new System.Drawing.Size(324, 59);
            this.btn_kaydet.TabIndex = 8;
            this.btn_kaydet.TabStop = false;
            this.btn_kaydet.Text = "KAYDET";
            this.btn_kaydet.Click += new System.EventHandler(this.btn_kaydet_Click_1);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label14.Location = new System.Drawing.Point(6, 389);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(212, 29);
            this.label14.TabIndex = 27;
            this.label14.Text = "İŞLETME DURUMU";
            // 
            // txt_isletme_sahibi
            // 
            this.txt_isletme_sahibi.Location = new System.Drawing.Point(10, 213);
            this.txt_isletme_sahibi.Name = "txt_isletme_sahibi";
            this.txt_isletme_sahibi.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_isletme_sahibi.Properties.Appearance.Options.UseFont = true;
            this.txt_isletme_sahibi.Properties.Appearance.Options.UseTextOptions = true;
            this.txt_isletme_sahibi.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txt_isletme_sahibi.Size = new System.Drawing.Size(324, 34);
            this.txt_isletme_sahibi.TabIndex = 3;
            this.txt_isletme_sahibi.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_isletme_sahibi_KeyDown);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.Location = new System.Drawing.Point(5, 181);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(189, 29);
            this.label13.TabIndex = 33;
            this.label13.Text = "İŞLETME SAHİBİ";
            // 
            // txt_isletme_no
            // 
            this.txt_isletme_no.Location = new System.Drawing.Point(10, 75);
            this.txt_isletme_no.Name = "txt_isletme_no";
            this.txt_isletme_no.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_isletme_no.Properties.Appearance.Options.UseFont = true;
            this.txt_isletme_no.Properties.Appearance.Options.UseTextOptions = true;
            this.txt_isletme_no.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txt_isletme_no.Size = new System.Drawing.Size(324, 34);
            this.txt_isletme_no.TabIndex = 1;
            this.txt_isletme_no.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_isletme_no_KeyDown);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.Location = new System.Drawing.Point(5, 43);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(147, 29);
            this.label12.TabIndex = 32;
            this.label12.Text = "İŞLETME NO";
            // 
            // txt_isletme_adi
            // 
            this.txt_isletme_adi.Location = new System.Drawing.Point(10, 144);
            this.txt_isletme_adi.Name = "txt_isletme_adi";
            this.txt_isletme_adi.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_isletme_adi.Properties.Appearance.Options.UseFont = true;
            this.txt_isletme_adi.Properties.Appearance.Options.UseTextOptions = true;
            this.txt_isletme_adi.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txt_isletme_adi.Size = new System.Drawing.Size(324, 34);
            this.txt_isletme_adi.TabIndex = 2;
            this.txt_isletme_adi.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_isletme_adi_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(5, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 29);
            this.label1.TabIndex = 19;
            this.label1.Text = "İŞLETME ADI";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(5, 250);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 29);
            this.label2.TabIndex = 23;
            this.label2.Text = "İRTİBAT KİŞİ";
            // 
            // txt_irtibat_kisi
            // 
            this.txt_irtibat_kisi.Location = new System.Drawing.Point(10, 282);
            this.txt_irtibat_kisi.Name = "txt_irtibat_kisi";
            this.txt_irtibat_kisi.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_irtibat_kisi.Properties.Appearance.Options.UseFont = true;
            this.txt_irtibat_kisi.Properties.Appearance.Options.UseTextOptions = true;
            this.txt_irtibat_kisi.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txt_irtibat_kisi.Size = new System.Drawing.Size(324, 34);
            this.txt_irtibat_kisi.TabIndex = 4;
            this.txt_irtibat_kisi.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_irtibat_kisi_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(5, 319);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 29);
            this.label3.TabIndex = 26;
            this.label3.Text = "TELEFON";
            // 
            // txt_telefon
            // 
            this.txt_telefon.Location = new System.Drawing.Point(10, 351);
            this.txt_telefon.Name = "txt_telefon";
            this.txt_telefon.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_telefon.Properties.Appearance.Options.UseFont = true;
            this.txt_telefon.Properties.Appearance.Options.UseTextOptions = true;
            this.txt_telefon.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txt_telefon.Properties.Mask.EditMask = "(999) 000-0000";
            this.txt_telefon.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple;
            this.txt_telefon.Size = new System.Drawing.Size(324, 34);
            this.txt_telefon.TabIndex = 5;
            this.txt_telefon.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_telefon_KeyDown);
            // 
            // cmb_isletme_durumu
            // 
            this.cmb_isletme_durumu.EditValue = "AKTİF";
            this.cmb_isletme_durumu.Location = new System.Drawing.Point(10, 420);
            this.cmb_isletme_durumu.Name = "cmb_isletme_durumu";
            this.cmb_isletme_durumu.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmb_isletme_durumu.Properties.Appearance.Options.UseFont = true;
            this.cmb_isletme_durumu.Properties.Appearance.Options.UseTextOptions = true;
            this.cmb_isletme_durumu.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.cmb_isletme_durumu.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmb_isletme_durumu.Properties.Items.AddRange(new object[] {
            "AKTİF",
            "PASİF"});
            this.cmb_isletme_durumu.Size = new System.Drawing.Size(324, 34);
            this.cmb_isletme_durumu.TabIndex = 6;
            this.cmb_isletme_durumu.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmb_isletme_durumu_KeyDown);
            // 
            // frm_isletme_guncelle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 543);
            this.Controls.Add(this.groupControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IconOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("frm_isletme_guncelle.IconOptions.LargeImage")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_isletme_guncelle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "İŞLETME GÜNCELLE";
            this.Load += new System.EventHandler(this.frm_isletme_guncelle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ımageCollection1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_isletme_sahibi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_isletme_no.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_isletme_adi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_irtibat_kisi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_telefon.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_isletme_durumu.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.Utils.ImageCollection ımageCollection1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton btn_kaydet;
        private System.Windows.Forms.Label label14;
        private DevExpress.XtraEditors.TextEdit txt_isletme_sahibi;
        private System.Windows.Forms.Label label13;
        private DevExpress.XtraEditors.TextEdit txt_isletme_no;
        private System.Windows.Forms.Label label12;
        private DevExpress.XtraEditors.TextEdit txt_isletme_adi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.TextEdit txt_irtibat_kisi;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.TextEdit txt_telefon;
        private DevExpress.XtraEditors.ComboBoxEdit cmb_isletme_durumu;
    }
}