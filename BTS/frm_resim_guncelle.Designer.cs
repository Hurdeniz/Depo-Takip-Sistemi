namespace BTS
{
    partial class frm_resim_guncelle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_resim_guncelle));
            this.txt_isletme_no = new DevExpress.XtraEditors.TextEdit();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_isletme_adi = new DevExpress.XtraEditors.TextEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.ımageCollection1 = new DevExpress.Utils.ImageCollection(this.components);
            this.xtraOpenFileDialog1 = new DevExpress.XtraEditors.XtraOpenFileDialog(this.components);
            this.label19 = new System.Windows.Forms.Label();
            this.btn_kaydet = new DevExpress.XtraEditors.SimpleButton();
            this.txt_resim = new DevExpress.XtraEditors.ButtonEdit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_isletme_no.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_isletme_adi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ımageCollection1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_resim.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_isletme_no
            // 
            this.txt_isletme_no.Enabled = false;
            this.txt_isletme_no.Location = new System.Drawing.Point(17, 41);
            this.txt_isletme_no.Name = "txt_isletme_no";
            this.txt_isletme_no.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_isletme_no.Properties.Appearance.Options.UseFont = true;
            this.txt_isletme_no.Properties.Appearance.Options.UseTextOptions = true;
            this.txt_isletme_no.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txt_isletme_no.Size = new System.Drawing.Size(304, 34);
            this.txt_isletme_no.TabIndex = 17;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.Location = new System.Drawing.Point(12, 9);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(105, 29);
            this.label12.TabIndex = 19;
            this.label12.Text = "DEPO ID";
            // 
            // txt_isletme_adi
            // 
            this.txt_isletme_adi.Enabled = false;
            this.txt_isletme_adi.Location = new System.Drawing.Point(17, 110);
            this.txt_isletme_adi.Name = "txt_isletme_adi";
            this.txt_isletme_adi.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_isletme_adi.Properties.Appearance.Options.UseFont = true;
            this.txt_isletme_adi.Properties.Appearance.Options.UseTextOptions = true;
            this.txt_isletme_adi.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txt_isletme_adi.Size = new System.Drawing.Size(304, 34);
            this.txt_isletme_adi.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 29);
            this.label1.TabIndex = 16;
            this.label1.Text = "DEPO NUMARASI";
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
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label19.Location = new System.Drawing.Point(12, 147);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(149, 29);
            this.label19.TabIndex = 30;
            this.label19.Text = "DEPO RESMİ";
            // 
            // btn_kaydet
            // 
            this.btn_kaydet.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_kaydet.Appearance.Options.UseFont = true;
            this.btn_kaydet.ImageOptions.ImageIndex = 0;
            this.btn_kaydet.ImageOptions.ImageList = this.ımageCollection1;
            this.btn_kaydet.Location = new System.Drawing.Point(17, 218);
            this.btn_kaydet.Name = "btn_kaydet";
            this.btn_kaydet.Size = new System.Drawing.Size(304, 59);
            this.btn_kaydet.TabIndex = 29;
            this.btn_kaydet.Text = "KAYDET";
            this.btn_kaydet.Click += new System.EventHandler(this.btn_kaydet_Click);
            // 
            // txt_resim
            // 
            this.txt_resim.Location = new System.Drawing.Point(16, 178);
            this.txt_resim.Name = "txt_resim";
            this.txt_resim.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_resim.Properties.Appearance.Options.UseFont = true;
            this.txt_resim.Properties.Appearance.Options.UseTextOptions = true;
            this.txt_resim.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txt_resim.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.txt_resim.Properties.Mask.EditMask = "d";
            this.txt_resim.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txt_resim.Size = new System.Drawing.Size(304, 34);
            this.txt_resim.TabIndex = 28;
            this.txt_resim.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.txt_resim_ButtonClick);
            // 
            // frm_resim_guncelle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 294);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.btn_kaydet);
            this.Controls.Add(this.txt_resim);
            this.Controls.Add(this.txt_isletme_no);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txt_isletme_adi);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IconOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("frm_resim_guncelle.IconOptions.LargeImage")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_resim_guncelle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RESİM GÜNCELLE";
            this.Load += new System.EventHandler(this.frm_resim_guncelle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txt_isletme_no.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_isletme_adi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ımageCollection1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_resim.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit txt_isletme_no;
        private System.Windows.Forms.Label label12;
        private DevExpress.XtraEditors.TextEdit txt_isletme_adi;
        private System.Windows.Forms.Label label1;
        private DevExpress.Utils.ImageCollection ımageCollection1;
        private DevExpress.XtraEditors.XtraOpenFileDialog xtraOpenFileDialog1;
        private System.Windows.Forms.Label label19;
        private DevExpress.XtraEditors.SimpleButton btn_kaydet;
        private DevExpress.XtraEditors.ButtonEdit txt_resim;
    }
}