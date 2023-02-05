namespace BTS
{
    partial class frm_pasif_durum_degistir
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_pasif_durum_degistir));
            this.date_dolum_tarih = new DevExpress.XtraEditors.DateEdit();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.txt_disi_hayvan = new DevExpress.XtraEditors.TextEdit();
            this.label15 = new System.Windows.Forms.Label();
            this.txt_erkek_hayvan = new DevExpress.XtraEditors.TextEdit();
            this.txt_doluluk_orani = new DevExpress.XtraEditors.TextEdit();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_dolum_suresi = new DevExpress.XtraEditors.TextEdit();
            this.txt_depo_kapasitesi = new DevExpress.XtraEditors.TextEdit();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ımageCollection1 = new DevExpress.Utils.ImageCollection(this.components);
            this.btn_kaydet = new DevExpress.XtraEditors.SimpleButton();
            this.txt_isletme_adi = new DevExpress.XtraEditors.TextEdit();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.date_dolum_tarih.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.date_dolum_tarih.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_disi_hayvan.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_erkek_hayvan.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_doluluk_orani.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_dolum_suresi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_depo_kapasitesi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ımageCollection1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_isletme_adi.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // date_dolum_tarih
            // 
            this.date_dolum_tarih.EditValue = null;
            this.date_dolum_tarih.Location = new System.Drawing.Point(17, 455);
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
            this.date_dolum_tarih.Size = new System.Drawing.Size(304, 34);
            this.date_dolum_tarih.TabIndex = 31;
            this.date_dolum_tarih.TabStop = false;
            this.date_dolum_tarih.KeyDown += new System.Windows.Forms.KeyEventHandler(this.date_dolum_tarih_KeyDown);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label17.Location = new System.Drawing.Point(12, 423);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(178, 29);
            this.label17.TabIndex = 34;
            this.label17.Text = "DOLUM TARİHİ";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label16.Location = new System.Drawing.Point(12, 354);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(236, 29);
            this.label16.TabIndex = 33;
            this.label16.Text = "DİŞİ HAYVAN SAYISI";
            // 
            // txt_disi_hayvan
            // 
            this.txt_disi_hayvan.Location = new System.Drawing.Point(17, 386);
            this.txt_disi_hayvan.Name = "txt_disi_hayvan";
            this.txt_disi_hayvan.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_disi_hayvan.Properties.Appearance.Options.UseFont = true;
            this.txt_disi_hayvan.Properties.Appearance.Options.UseTextOptions = true;
            this.txt_disi_hayvan.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txt_disi_hayvan.Properties.Mask.EditMask = "d";
            this.txt_disi_hayvan.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txt_disi_hayvan.Size = new System.Drawing.Size(304, 34);
            this.txt_disi_hayvan.TabIndex = 30;
            this.txt_disi_hayvan.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_disi_hayvan_KeyDown);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label15.Location = new System.Drawing.Point(12, 285);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(258, 29);
            this.label15.TabIndex = 32;
            this.label15.Text = "ERKEK HAYVAN SAYISI";
            // 
            // txt_erkek_hayvan
            // 
            this.txt_erkek_hayvan.Location = new System.Drawing.Point(17, 317);
            this.txt_erkek_hayvan.Name = "txt_erkek_hayvan";
            this.txt_erkek_hayvan.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_erkek_hayvan.Properties.Appearance.Options.UseFont = true;
            this.txt_erkek_hayvan.Properties.Appearance.Options.UseTextOptions = true;
            this.txt_erkek_hayvan.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txt_erkek_hayvan.Properties.Mask.EditMask = "d";
            this.txt_erkek_hayvan.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txt_erkek_hayvan.Size = new System.Drawing.Size(304, 34);
            this.txt_erkek_hayvan.TabIndex = 29;
            this.txt_erkek_hayvan.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_erkek_hayvan_KeyDown);
            // 
            // txt_doluluk_orani
            // 
            this.txt_doluluk_orani.Location = new System.Drawing.Point(17, 179);
            this.txt_doluluk_orani.Name = "txt_doluluk_orani";
            this.txt_doluluk_orani.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_doluluk_orani.Properties.Appearance.Options.UseFont = true;
            this.txt_doluluk_orani.Properties.Appearance.Options.UseTextOptions = true;
            this.txt_doluluk_orani.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txt_doluluk_orani.Properties.Mask.EditMask = "d";
            this.txt_doluluk_orani.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txt_doluluk_orani.Size = new System.Drawing.Size(304, 34);
            this.txt_doluluk_orani.TabIndex = 25;
            this.txt_doluluk_orani.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_doluluk_orani_KeyDown);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(12, 147);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(195, 29);
            this.label9.TabIndex = 28;
            this.label9.Text = "DOLULUK ORANI";
            // 
            // txt_dolum_suresi
            // 
            this.txt_dolum_suresi.Location = new System.Drawing.Point(17, 248);
            this.txt_dolum_suresi.Name = "txt_dolum_suresi";
            this.txt_dolum_suresi.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_dolum_suresi.Properties.Appearance.Options.UseFont = true;
            this.txt_dolum_suresi.Properties.Appearance.Options.UseTextOptions = true;
            this.txt_dolum_suresi.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txt_dolum_suresi.Properties.Mask.EditMask = "d";
            this.txt_dolum_suresi.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txt_dolum_suresi.Size = new System.Drawing.Size(304, 34);
            this.txt_dolum_suresi.TabIndex = 27;
            this.txt_dolum_suresi.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_dolum_suresi_KeyDown);
            // 
            // txt_depo_kapasitesi
            // 
            this.txt_depo_kapasitesi.Enabled = false;
            this.txt_depo_kapasitesi.Location = new System.Drawing.Point(17, 110);
            this.txt_depo_kapasitesi.Name = "txt_depo_kapasitesi";
            this.txt_depo_kapasitesi.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_depo_kapasitesi.Properties.Appearance.ForeColor = System.Drawing.Color.DarkRed;
            this.txt_depo_kapasitesi.Properties.Appearance.Options.UseFont = true;
            this.txt_depo_kapasitesi.Properties.Appearance.Options.UseForeColor = true;
            this.txt_depo_kapasitesi.Properties.Appearance.Options.UseTextOptions = true;
            this.txt_depo_kapasitesi.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txt_depo_kapasitesi.Properties.Mask.EditMask = "d";
            this.txt_depo_kapasitesi.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txt_depo_kapasitesi.Size = new System.Drawing.Size(304, 34);
            this.txt_depo_kapasitesi.TabIndex = 24;
            this.txt_depo_kapasitesi.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_depo_kapasitesi_KeyDown);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(12, 216);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(180, 29);
            this.label6.TabIndex = 26;
            this.label6.Text = "DOLUM SÜRESİ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(12, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(206, 29);
            this.label5.TabIndex = 23;
            this.label5.Text = "DEPO KAPASİTESİ";
            // 
            // ımageCollection1
            // 
            this.ımageCollection1.ImageSize = new System.Drawing.Size(50, 50);
            this.ımageCollection1.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("ımageCollection1.ImageStream")));
            this.ımageCollection1.Images.SetKeyName(0, "iconfinder_save_46830.png");
            this.ımageCollection1.Images.SetKeyName(1, "iconfinder_34_61498.png");
            // 
            // btn_kaydet
            // 
            this.btn_kaydet.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_kaydet.Appearance.Options.UseFont = true;
            this.btn_kaydet.ImageOptions.ImageIndex = 0;
            this.btn_kaydet.ImageOptions.ImageList = this.ımageCollection1;
            this.btn_kaydet.Location = new System.Drawing.Point(17, 495);
            this.btn_kaydet.Name = "btn_kaydet";
            this.btn_kaydet.Size = new System.Drawing.Size(304, 59);
            this.btn_kaydet.TabIndex = 35;
            this.btn_kaydet.TabStop = false;
            this.btn_kaydet.Text = "KAYDET";
            this.btn_kaydet.Click += new System.EventHandler(this.btn_kaydet_Click);
            // 
            // txt_isletme_adi
            // 
            this.txt_isletme_adi.Enabled = false;
            this.txt_isletme_adi.Location = new System.Drawing.Point(17, 41);
            this.txt_isletme_adi.Name = "txt_isletme_adi";
            this.txt_isletme_adi.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_isletme_adi.Properties.Appearance.ForeColor = System.Drawing.Color.DarkRed;
            this.txt_isletme_adi.Properties.Appearance.Options.UseFont = true;
            this.txt_isletme_adi.Properties.Appearance.Options.UseForeColor = true;
            this.txt_isletme_adi.Properties.Appearance.Options.UseTextOptions = true;
            this.txt_isletme_adi.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txt_isletme_adi.Properties.Mask.EditMask = "d";
            this.txt_isletme_adi.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txt_isletme_adi.Size = new System.Drawing.Size(304, 34);
            this.txt_isletme_adi.TabIndex = 37;
            this.txt_isletme_adi.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_isletme_adi_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 29);
            this.label1.TabIndex = 36;
            this.label1.Text = "DEPO NUMARASI";
            // 
            // frm_pasif_durum_degistir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 570);
            this.Controls.Add(this.txt_isletme_adi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_kaydet);
            this.Controls.Add(this.date_dolum_tarih);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.txt_disi_hayvan);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txt_erkek_hayvan);
            this.Controls.Add(this.txt_doluluk_orani);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txt_dolum_suresi);
            this.Controls.Add(this.txt_depo_kapasitesi);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IconOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("frm_pasif_durum_degistir.IconOptions.LargeImage")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_pasif_durum_degistir";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DEPO DURUM DEĞİŞTİR";
            this.Load += new System.EventHandler(this.frm_pasif_durum_degistir_Load);
            ((System.ComponentModel.ISupportInitialize)(this.date_dolum_tarih.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.date_dolum_tarih.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_disi_hayvan.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_erkek_hayvan.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_doluluk_orani.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_dolum_suresi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_depo_kapasitesi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ımageCollection1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_isletme_adi.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.DateEdit date_dolum_tarih;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private DevExpress.XtraEditors.TextEdit txt_disi_hayvan;
        private System.Windows.Forms.Label label15;
        private DevExpress.XtraEditors.TextEdit txt_erkek_hayvan;
        private DevExpress.XtraEditors.TextEdit txt_doluluk_orani;
        private System.Windows.Forms.Label label9;
        private DevExpress.XtraEditors.TextEdit txt_dolum_suresi;
        private DevExpress.XtraEditors.TextEdit txt_depo_kapasitesi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private DevExpress.Utils.ImageCollection ımageCollection1;
        private DevExpress.XtraEditors.SimpleButton btn_kaydet;
        private DevExpress.XtraEditors.TextEdit txt_isletme_adi;
        private System.Windows.Forms.Label label1;
    }
}