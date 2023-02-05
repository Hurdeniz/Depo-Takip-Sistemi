namespace BTS
{
    partial class frm_yeni_sevkiyat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_yeni_sevkiyat));
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.grid_isletme = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.btn_sevkiyat_liste = new DevExpress.XtraEditors.SimpleButton();
            this.ımageCollection1 = new DevExpress.Utils.ImageCollection(this.components);
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_depo_kapasite = new DevExpress.XtraEditors.TextEdit();
            this.btn_kaydet = new DevExpress.XtraEditors.SimpleButton();
            this.cmb_arac = new DevExpress.XtraEditors.ComboBoxEdit();
            this.txt_tedarik_miktar = new DevExpress.XtraEditors.TextEdit();
            this.txt_kalan_gun = new DevExpress.XtraEditors.TextEdit();
            this.cmb_personel = new DevExpress.XtraEditors.ComboBoxEdit();
            this.label11 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_doluluk = new DevExpress.XtraEditors.TextEdit();
            this.label15 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_isletme)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ımageCollection1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_depo_kapasite.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_arac.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_tedarik_miktar.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_kalan_gun.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_personel.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_doluluk.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.grid_isletme);
            this.panelControl2.Controls.Add(this.btn_sevkiyat_liste);
            this.panelControl2.Controls.Add(this.groupControl1);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(0, 0);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(1940, 911);
            this.panelControl2.TabIndex = 2;
            this.panelControl2.Paint += new System.Windows.Forms.PaintEventHandler(this.panelControl2_Paint);
            // 
            // grid_isletme
            // 
            this.grid_isletme.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid_isletme.Location = new System.Drawing.Point(2, 2);
            this.grid_isletme.MainView = this.gridView1;
            this.grid_isletme.Name = "grid_isletme";
            this.grid_isletme.Size = new System.Drawing.Size(1580, 848);
            this.grid_isletme.TabIndex = 28;
            this.grid_isletme.TabStop = false;
            this.grid_isletme.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Appearance.GroupPanel.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gridView1.Appearance.GroupPanel.Options.UseFont = true;
            this.gridView1.Appearance.GroupPanel.Options.UseTextOptions = true;
            this.gridView1.Appearance.GroupPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gridView1.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView1.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.gridView1.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.gridView1.Appearance.Row.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.gridView1.Appearance.Row.Options.UseBackColor = true;
            this.gridView1.Appearance.Row.Options.UseTextOptions = true;
            this.gridView1.Appearance.Row.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.GridControl = this.grid_isletme;
            this.gridView1.GroupPanelText = "DOLUMU YAKLAŞAN İŞLETMELER";
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsMenu.ShowFooterItem = true;
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged_2);
            // 
            // btn_sevkiyat_liste
            // 
            this.btn_sevkiyat_liste.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_sevkiyat_liste.Appearance.Options.UseFont = true;
            this.btn_sevkiyat_liste.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_sevkiyat_liste.ImageOptions.ImageIndex = 2;
            this.btn_sevkiyat_liste.ImageOptions.ImageList = this.ımageCollection1;
            this.btn_sevkiyat_liste.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btn_sevkiyat_liste.Location = new System.Drawing.Point(2, 850);
            this.btn_sevkiyat_liste.Name = "btn_sevkiyat_liste";
            this.btn_sevkiyat_liste.Size = new System.Drawing.Size(1580, 59);
            this.btn_sevkiyat_liste.TabIndex = 27;
            this.btn_sevkiyat_liste.Text = " SEVKİYAT LİSTESİ";
            this.btn_sevkiyat_liste.Click += new System.EventHandler(this.btn_sevkiyat_liste_Click);
            // 
            // ımageCollection1
            // 
            this.ımageCollection1.ImageSize = new System.Drawing.Size(50, 50);
            this.ımageCollection1.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("ımageCollection1.ImageStream")));
            this.ımageCollection1.Images.SetKeyName(0, "iconfinder_save_46830.png");
            this.ımageCollection1.Images.SetKeyName(1, "iconfinder_34_61498.png");
            this.ımageCollection1.Images.SetKeyName(2, "icons8_container_truck_125px_1.png");
            // 
            // groupControl1
            // 
            this.groupControl1.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupControl1.AppearanceCaption.Options.UseFont = true;
            this.groupControl1.AppearanceCaption.Options.UseTextOptions = true;
            this.groupControl1.AppearanceCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.groupControl1.CaptionImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("groupControl1.CaptionImageOptions.Image")));
            this.groupControl1.Controls.Add(this.label9);
            this.groupControl1.Controls.Add(this.txt_depo_kapasite);
            this.groupControl1.Controls.Add(this.btn_kaydet);
            this.groupControl1.Controls.Add(this.cmb_arac);
            this.groupControl1.Controls.Add(this.txt_tedarik_miktar);
            this.groupControl1.Controls.Add(this.txt_kalan_gun);
            this.groupControl1.Controls.Add(this.cmb_personel);
            this.groupControl1.Controls.Add(this.label11);
            this.groupControl1.Controls.Add(this.label14);
            this.groupControl1.Controls.Add(this.label6);
            this.groupControl1.Controls.Add(this.txt_doluluk);
            this.groupControl1.Controls.Add(this.label15);
            this.groupControl1.Controls.Add(this.label10);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupControl1.Location = new System.Drawing.Point(1582, 2);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(356, 907);
            this.groupControl1.TabIndex = 25;
            this.groupControl1.Text = "SEVKİYAT BİLGİLERİ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(5, 48);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(206, 29);
            this.label9.TabIndex = 40;
            this.label9.Text = "DEPO KAPASİTESİ";
            // 
            // txt_depo_kapasite
            // 
            this.txt_depo_kapasite.Enabled = false;
            this.txt_depo_kapasite.Location = new System.Drawing.Point(10, 80);
            this.txt_depo_kapasite.Name = "txt_depo_kapasite";
            this.txt_depo_kapasite.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_depo_kapasite.Properties.Appearance.ForeColor = System.Drawing.Color.DarkRed;
            this.txt_depo_kapasite.Properties.Appearance.Options.UseFont = true;
            this.txt_depo_kapasite.Properties.Appearance.Options.UseForeColor = true;
            this.txt_depo_kapasite.Properties.Appearance.Options.UseTextOptions = true;
            this.txt_depo_kapasite.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txt_depo_kapasite.Size = new System.Drawing.Size(338, 34);
            this.txt_depo_kapasite.TabIndex = 39;
            this.txt_depo_kapasite.TabStop = false;
            // 
            // btn_kaydet
            // 
            this.btn_kaydet.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_kaydet.Appearance.Options.UseFont = true;
            this.btn_kaydet.ImageOptions.ImageIndex = 0;
            this.btn_kaydet.ImageOptions.ImageList = this.ımageCollection1;
            this.btn_kaydet.Location = new System.Drawing.Point(10, 634);
            this.btn_kaydet.Name = "btn_kaydet";
            this.btn_kaydet.Size = new System.Drawing.Size(338, 59);
            this.btn_kaydet.TabIndex = 5;
            this.btn_kaydet.Text = "KAYDET";
            this.btn_kaydet.Click += new System.EventHandler(this.btn_kaydet_Click);
            // 
            // cmb_arac
            // 
            this.cmb_arac.EditValue = "";
            this.cmb_arac.Location = new System.Drawing.Point(10, 356);
            this.cmb_arac.Name = "cmb_arac";
            this.cmb_arac.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmb_arac.Properties.Appearance.Options.UseFont = true;
            this.cmb_arac.Properties.Appearance.Options.UseTextOptions = true;
            this.cmb_arac.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.cmb_arac.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmb_arac.Size = new System.Drawing.Size(338, 34);
            this.cmb_arac.TabIndex = 2;
            // 
            // txt_tedarik_miktar
            // 
            this.txt_tedarik_miktar.Location = new System.Drawing.Point(10, 422);
            this.txt_tedarik_miktar.Name = "txt_tedarik_miktar";
            this.txt_tedarik_miktar.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_tedarik_miktar.Properties.Appearance.Options.UseFont = true;
            this.txt_tedarik_miktar.Properties.Appearance.Options.UseTextOptions = true;
            this.txt_tedarik_miktar.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txt_tedarik_miktar.Size = new System.Drawing.Size(338, 34);
            this.txt_tedarik_miktar.TabIndex = 3;
            // 
            // txt_kalan_gun
            // 
            this.txt_kalan_gun.Enabled = false;
            this.txt_kalan_gun.Location = new System.Drawing.Point(10, 218);
            this.txt_kalan_gun.Name = "txt_kalan_gun";
            this.txt_kalan_gun.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_kalan_gun.Properties.Appearance.ForeColor = System.Drawing.Color.DarkRed;
            this.txt_kalan_gun.Properties.Appearance.Options.UseFont = true;
            this.txt_kalan_gun.Properties.Appearance.Options.UseForeColor = true;
            this.txt_kalan_gun.Properties.Appearance.Options.UseTextOptions = true;
            this.txt_kalan_gun.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txt_kalan_gun.Size = new System.Drawing.Size(338, 34);
            this.txt_kalan_gun.TabIndex = 37;
            this.txt_kalan_gun.TabStop = false;
            // 
            // cmb_personel
            // 
            this.cmb_personel.EditValue = "";
            this.cmb_personel.Location = new System.Drawing.Point(10, 287);
            this.cmb_personel.Name = "cmb_personel";
            this.cmb_personel.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmb_personel.Properties.Appearance.Options.UseFont = true;
            this.cmb_personel.Properties.Appearance.Options.UseTextOptions = true;
            this.cmb_personel.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.cmb_personel.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmb_personel.Size = new System.Drawing.Size(338, 34);
            this.cmb_personel.TabIndex = 1;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(5, 393);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(210, 29);
            this.label11.TabIndex = 24;
            this.label11.Text = "TEDARİK MİKTARI";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label14.Location = new System.Drawing.Point(5, 186);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(139, 29);
            this.label14.TabIndex = 38;
            this.label14.Text = "KALAN GÜN";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(5, 117);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(195, 29);
            this.label6.TabIndex = 34;
            this.label6.Text = "DOLULUK ORANI";
            // 
            // txt_doluluk
            // 
            this.txt_doluluk.Enabled = false;
            this.txt_doluluk.Location = new System.Drawing.Point(10, 149);
            this.txt_doluluk.Name = "txt_doluluk";
            this.txt_doluluk.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_doluluk.Properties.Appearance.ForeColor = System.Drawing.Color.DarkRed;
            this.txt_doluluk.Properties.Appearance.Options.UseFont = true;
            this.txt_doluluk.Properties.Appearance.Options.UseForeColor = true;
            this.txt_doluluk.Properties.Appearance.Options.UseTextOptions = true;
            this.txt_doluluk.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txt_doluluk.Size = new System.Drawing.Size(338, 34);
            this.txt_doluluk.TabIndex = 33;
            this.txt_doluluk.TabStop = false;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label15.Location = new System.Drawing.Point(5, 255);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(125, 29);
            this.label15.TabIndex = 18;
            this.label15.Text = "PERSONEL";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(5, 324);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(145, 29);
            this.label10.TabIndex = 32;
            this.label10.Text = "ARAÇ PLAKA";
            // 
            // frm_yeni_sevkiyat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1940, 911);
            this.Controls.Add(this.panelControl2);
            this.Name = "frm_yeni_sevkiyat";
            this.Text = "SEVKİYAT OLUŞTUR";
            this.Load += new System.EventHandler(this.frm_yeni_sevkiyat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grid_isletme)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ımageCollection1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_depo_kapasite.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_arac.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_tedarik_miktar.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_kalan_gun.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_personel.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_doluluk.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.TextEdit txt_tedarik_miktar;
        private System.Windows.Forms.Label label11;
        private DevExpress.Utils.ImageCollection ımageCollection1;
        private DevExpress.XtraEditors.SimpleButton btn_kaydet;
        private System.Windows.Forms.Label label6;
        private DevExpress.XtraEditors.TextEdit txt_doluluk;
        private System.Windows.Forms.Label label14;
        private DevExpress.XtraEditors.TextEdit txt_kalan_gun;
        private System.Windows.Forms.Label label9;
        private DevExpress.XtraEditors.TextEdit txt_depo_kapasite;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraGrid.GridControl grid_isletme;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.SimpleButton btn_sevkiyat_liste;
        private DevExpress.XtraEditors.ComboBoxEdit cmb_arac;
        private DevExpress.XtraEditors.ComboBoxEdit cmb_personel;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label10;
    }
}