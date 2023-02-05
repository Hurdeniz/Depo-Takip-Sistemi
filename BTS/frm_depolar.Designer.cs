namespace BTS
{
    partial class frm_depolar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_depolar));
            DevExpress.Utils.SuperToolTip superToolTip1 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem1 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.SuperToolTip superToolTip2 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem2 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.SuperToolTip superToolTip3 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem3 = new DevExpress.Utils.ToolTipTitleItem();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.bar_btn_yenile = new DevExpress.XtraBars.BarButtonItem();
            this.bar_btn_guncelle = new DevExpress.XtraBars.BarButtonItem();
            this.btn_sil = new DevExpress.XtraBars.BarButtonItem();
            this.bar_btn_excel = new DevExpress.XtraBars.BarButtonItem();
            this.bar_btn_aktif = new DevExpress.XtraBars.BarButtonItem();
            this.bar_btn_pasif = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.xtraSaveFileDialog1 = new DevExpress.XtraEditors.XtraSaveFileDialog(this.components);
            this.grid_isletme = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_isletme)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btn_sil,
            this.bar_btn_excel,
            this.bar_btn_yenile,
            this.bar_btn_guncelle,
            this.bar_btn_aktif,
            this.bar_btn_pasif});
            this.barManager1.MaxItemId = 7;
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.bar_btn_yenile),
            new DevExpress.XtraBars.LinkPersistInfo(this.bar_btn_guncelle, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_sil, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.bar_btn_excel, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.bar_btn_aktif, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.bar_btn_pasif, true)});
            this.bar1.OptionsBar.AllowQuickCustomization = false;
            this.bar1.Text = "Tools";
            // 
            // bar_btn_yenile
            // 
            this.bar_btn_yenile.Caption = "YENİLE";
            this.bar_btn_yenile.Id = 2;
            this.bar_btn_yenile.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bar_btn_yenile.ImageOptions.Image")));
            this.bar_btn_yenile.Name = "bar_btn_yenile";
            toolTipTitleItem1.Text = "YENİLE";
            superToolTip1.Items.Add(toolTipTitleItem1);
            this.bar_btn_yenile.SuperTip = superToolTip1;
            this.bar_btn_yenile.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bar_btn_yenile_ItemClick);
            // 
            // bar_btn_guncelle
            // 
            this.bar_btn_guncelle.Caption = "GÜNCELLE";
            this.bar_btn_guncelle.Id = 3;
            this.bar_btn_guncelle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bar_btn_guncelle.ImageOptions.Image")));
            this.bar_btn_guncelle.Name = "bar_btn_guncelle";
            this.bar_btn_guncelle.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bar_btn_guncelle_ItemClick);
            // 
            // btn_sil
            // 
            this.btn_sil.Caption = "SİL";
            this.btn_sil.Id = 0;
            this.btn_sil.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_sil.ImageOptions.Image")));
            this.btn_sil.Name = "btn_sil";
            toolTipTitleItem2.Text = "SİL";
            superToolTip2.Items.Add(toolTipTitleItem2);
            this.btn_sil.SuperTip = superToolTip2;
            this.btn_sil.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_sil_ItemClick);
            // 
            // bar_btn_excel
            // 
            this.bar_btn_excel.Caption = "EXCEL";
            this.bar_btn_excel.Id = 1;
            this.bar_btn_excel.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bar_btn_excel.ImageOptions.Image")));
            this.bar_btn_excel.Name = "bar_btn_excel";
            toolTipTitleItem3.Text = "EXCEL AKTAR";
            superToolTip3.Items.Add(toolTipTitleItem3);
            this.bar_btn_excel.SuperTip = superToolTip3;
            this.bar_btn_excel.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bar_btn_excel_ItemClick);
            // 
            // bar_btn_aktif
            // 
            this.bar_btn_aktif.Caption = "AKTİF YAP";
            this.bar_btn_aktif.Id = 5;
            this.bar_btn_aktif.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bar_btn_aktif.ImageOptions.Image")));
            this.bar_btn_aktif.Name = "bar_btn_aktif";
            this.bar_btn_aktif.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bar_btn_aktif_ItemClick);
            // 
            // bar_btn_pasif
            // 
            this.bar_btn_pasif.Caption = "PASİF YAP";
            this.bar_btn_pasif.Id = 6;
            this.bar_btn_pasif.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bar_btn_pasif.ImageOptions.Image")));
            this.bar_btn_pasif.Name = "bar_btn_pasif";
            this.bar_btn_pasif.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bar_btn_pasif_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(1066, 57);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 775);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1066, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 57);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 718);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1066, 57);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 718);
            // 
            // xtraSaveFileDialog1
            // 
            this.xtraSaveFileDialog1.FileName = "xtraSaveFileDialog1";
            // 
            // grid_isletme
            // 
            this.grid_isletme.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid_isletme.Location = new System.Drawing.Point(0, 57);
            this.grid_isletme.MainView = this.gridView1;
            this.grid_isletme.Name = "grid_isletme";
            this.grid_isletme.Size = new System.Drawing.Size(1066, 718);
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
            this.gridView1.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.gridView1.Appearance.Row.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.gridView1.Appearance.Row.Options.UseBackColor = true;
            this.gridView1.Appearance.Row.Options.UseTextOptions = true;
            this.gridView1.Appearance.Row.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.GridControl = this.grid_isletme;
            this.gridView1.GroupPanelText = "İŞLETME DEPOLARI";
            this.gridView1.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "", null, "(ADET={0})")});
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsMenu.ShowFooterItem = true;
            this.gridView1.OptionsView.ShowFooter = true;
            // 
            // frm_depolar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1066, 775);
            this.Controls.Add(this.grid_isletme);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frm_depolar";
            this.Text = "DEPOLAR";
            this.Load += new System.EventHandler(this.frm_depolar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_isletme)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarButtonItem bar_btn_guncelle;
        private DevExpress.XtraBars.BarButtonItem btn_sil;
        private DevExpress.XtraBars.BarButtonItem bar_btn_yenile;
        private DevExpress.XtraBars.BarButtonItem bar_btn_excel;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraEditors.XtraSaveFileDialog xtraSaveFileDialog1;
        private DevExpress.XtraGrid.GridControl grid_isletme;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraBars.BarButtonItem bar_btn_aktif;
        private DevExpress.XtraBars.BarButtonItem bar_btn_pasif;
    }
}