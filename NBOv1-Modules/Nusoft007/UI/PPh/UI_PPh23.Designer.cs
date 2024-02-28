namespace NuSoft.NUI.Win.Forms.Modules.NuSoft007.UI.PPh
{
	partial class UI_PPh23
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UI_PPh23));
			this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colPotongPPh23 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colNomorInvoice = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colTanggalInvoice = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colNamaPemasang = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colInvoiceNominal = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colWilayah = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colKeteranganInvoice = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colIsUploadBuktiPotong = new DevExpress.XtraGrid.Columns.GridColumn();
			this.btnUploadBuktiPotong = new DevExpress.XtraBars.BarButtonItem();
			this.btnLihatBuktiPotong = new DevExpress.XtraBars.BarButtonItem();
			((System.ComponentModel.ISupportInitialize)(this.xGrid)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.xpCol)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.barMan)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.session)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.xGridView)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.popMenu)).BeginInit();
			this.SuspendLayout();
			// 
			// xGrid
			// 
			this.xGrid.DataSource = this.ifSource;
			this.xGrid.Size = new System.Drawing.Size(945, 332);
			// 
			// barMan
			// 
			this.barMan.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnUploadBuktiPotong,
            this.btnLihatBuktiPotong});
			this.barMan.MaxItemId = 15;
			// 
			// xGridView
			// 
			this.xGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn1,
            this.gridColumn3,
            this.colNomorInvoice,
            this.colTanggalInvoice,
            this.colWilayah,
            this.colNamaPemasang,
            this.colKeteranganInvoice,
            this.colInvoiceNominal,
            this.colPotongPPh23,
            this.colIsUploadBuktiPotong});
			this.xGridView.GroupCount = 2;
			this.xGridView.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "DppPPh23", null, "[Dpp = {0:n0}]"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "PPh23Nominal", null, "[PPh 23 = {0:n0}]"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "NoInvoice", null, "[Jml. Record = {0:n0}]")});
			this.xGridView.OptionsBehavior.Editable = false;
			this.xGridView.OptionsDetail.EnableMasterViewMode = false;
			this.xGridView.OptionsSelection.MultiSelect = true;
			this.xGridView.OptionsView.ShowAutoFilterRow = true;
			this.xGridView.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.gridColumn4, DevExpress.Data.ColumnSortOrder.Descending),
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.gridColumn5, DevExpress.Data.ColumnSortOrder.Descending)});
			// 
			// ifSource
			// 
			this.ifSource.DisplayableProperties = "Id;NoInvoice;NoKwitansi;TanggalInvoice;TanggalKwitansi;Wilayah;KeteranganInvoice;" +
    "Pemasang;DppPPh23;PPh23Persen;PPh23Nominal;Keterangan;Tahun;Bulan;IsUploadBuktiP" +
    "otong";
			this.ifSource.ObjectType = typeof(NuSoft.NUI.Win.Forms.Modules.NuSoft007.Persistent.PPh23);
			// 
			// barMenu
			// 
			this.barMenu.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnUploadBuktiPotong, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnLihatBuktiPotong, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
			this.barMenu.OptionsBar.AllowQuickCustomization = false;
			this.barMenu.OptionsBar.DrawDragBorder = false;
			this.barMenu.OptionsBar.UseWholeRow = true;
			// 
			// gridColumn1
			// 
			this.gridColumn1.Caption = "No. Kwitansi";
			this.gridColumn1.FieldName = "NoKwitansi";
			this.gridColumn1.Name = "gridColumn1";
			this.gridColumn1.Visible = true;
			this.gridColumn1.VisibleIndex = 0;
			this.gridColumn1.Width = 100;
			// 
			// gridColumn3
			// 
			this.gridColumn3.Caption = "Tgl. Lunas";
			this.gridColumn3.DisplayFormat.FormatString = "dd MMM yyyy";
			this.gridColumn3.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
			this.gridColumn3.FieldName = "TanggalKwitansi";
			this.gridColumn3.Name = "gridColumn3";
			this.gridColumn3.Visible = true;
			this.gridColumn3.VisibleIndex = 1;
			this.gridColumn3.Width = 70;
			// 
			// gridColumn4
			// 
			this.gridColumn4.Caption = "Tahun";
			this.gridColumn4.FieldName = "Tahun";
			this.gridColumn4.Name = "gridColumn4";
			this.gridColumn4.Visible = true;
			this.gridColumn4.VisibleIndex = 3;
			// 
			// gridColumn5
			// 
			this.gridColumn5.Caption = "Bulan";
			this.gridColumn5.DisplayFormat.FormatString = "MMMM";
			this.gridColumn5.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
			this.gridColumn5.FieldName = "Bulan";
			this.gridColumn5.GroupFormat.FormatString = "MMMM";
			this.gridColumn5.GroupFormat.FormatType = DevExpress.Utils.FormatType.Custom;
			this.gridColumn5.Name = "gridColumn5";
			this.gridColumn5.Visible = true;
			this.gridColumn5.VisibleIndex = 3;
			// 
			// colPotongPPh23
			// 
			this.colPotongPPh23.AppearanceHeader.Options.UseTextOptions = true;
			this.colPotongPPh23.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
			this.colPotongPPh23.Caption = "PPh 23";
			this.colPotongPPh23.DisplayFormat.FormatString = "n0";
			this.colPotongPPh23.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.colPotongPPh23.FieldName = "PPh23Nominal";
			this.colPotongPPh23.Name = "colPotongPPh23";
			this.colPotongPPh23.Visible = true;
			this.colPotongPPh23.VisibleIndex = 8;
			this.colPotongPPh23.Width = 60;
			// 
			// colNomorInvoice
			// 
			this.colNomorInvoice.Caption = "No. Invoice";
			this.colNomorInvoice.FieldName = "NoInvoice";
			this.colNomorInvoice.Name = "colNomorInvoice";
			this.colNomorInvoice.Visible = true;
			this.colNomorInvoice.VisibleIndex = 2;
			this.colNomorInvoice.Width = 80;
			// 
			// colTanggalInvoice
			// 
			this.colTanggalInvoice.Caption = "Tgl. Invoice";
			this.colTanggalInvoice.DisplayFormat.FormatString = "dd MMM yyyy";
			this.colTanggalInvoice.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
			this.colTanggalInvoice.FieldName = "TanggalInvoice";
			this.colTanggalInvoice.Name = "colTanggalInvoice";
			this.colTanggalInvoice.Visible = true;
			this.colTanggalInvoice.VisibleIndex = 3;
			this.colTanggalInvoice.Width = 70;
			// 
			// colNamaPemasang
			// 
			this.colNamaPemasang.Caption = "Pemasang";
			this.colNamaPemasang.FieldName = "Pemasang";
			this.colNamaPemasang.Name = "colNamaPemasang";
			this.colNamaPemasang.Visible = true;
			this.colNamaPemasang.VisibleIndex = 5;
			this.colNamaPemasang.Width = 105;
			// 
			// colInvoiceNominal
			// 
			this.colInvoiceNominal.AppearanceHeader.Options.UseTextOptions = true;
			this.colInvoiceNominal.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
			this.colInvoiceNominal.Caption = "Dpp";
			this.colInvoiceNominal.DisplayFormat.FormatString = "n0";
			this.colInvoiceNominal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.colInvoiceNominal.FieldName = "DppPPh23";
			this.colInvoiceNominal.Name = "colInvoiceNominal";
			this.colInvoiceNominal.Visible = true;
			this.colInvoiceNominal.VisibleIndex = 7;
			this.colInvoiceNominal.Width = 60;
			// 
			// colWilayah
			// 
			this.colWilayah.FieldName = "Wilayah";
			this.colWilayah.Name = "colWilayah";
			this.colWilayah.Visible = true;
			this.colWilayah.VisibleIndex = 4;
			this.colWilayah.Width = 90;
			// 
			// colKeteranganInvoice
			// 
			this.colKeteranganInvoice.Caption = "Keterangan";
			this.colKeteranganInvoice.FieldName = "KeteranganInvoice";
			this.colKeteranganInvoice.Name = "colKeteranganInvoice";
			this.colKeteranganInvoice.Visible = true;
			this.colKeteranganInvoice.VisibleIndex = 6;
			this.colKeteranganInvoice.Width = 135;
			// 
			// colIsUploadBuktiPotong
			// 
			this.colIsUploadBuktiPotong.Caption = "Bukti Potong";
			this.colIsUploadBuktiPotong.FieldName = "IsUploadBuktiPotong";
			this.colIsUploadBuktiPotong.Name = "colIsUploadBuktiPotong";
			this.colIsUploadBuktiPotong.Visible = true;
			this.colIsUploadBuktiPotong.VisibleIndex = 9;
			// 
			// btnUploadBuktiPotong
			// 
			this.btnUploadBuktiPotong.Caption = "Upload Bukti Potong";
			this.btnUploadBuktiPotong.Glyph = ((System.Drawing.Image)(resources.GetObject("btnUploadBuktiPotong.Glyph")));
			this.btnUploadBuktiPotong.Id = 13;
			this.btnUploadBuktiPotong.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnUploadBuktiPotong.LargeGlyph")));
			this.btnUploadBuktiPotong.Name = "btnUploadBuktiPotong";
			this.btnUploadBuktiPotong.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
			// 
			// btnLihatBuktiPotong
			// 
			this.btnLihatBuktiPotong.Caption = "Lihat Bukti Potong";
			this.btnLihatBuktiPotong.Glyph = ((System.Drawing.Image)(resources.GetObject("btnLihatBuktiPotong.Glyph")));
			this.btnLihatBuktiPotong.Id = 14;
			this.btnLihatBuktiPotong.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnLihatBuktiPotong.LargeGlyph")));
			this.btnLihatBuktiPotong.Name = "btnLihatBuktiPotong";
			this.btnLihatBuktiPotong.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
			// 
			// UI_PPh23
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(945, 359);
			this.Name = "UI_PPh23";
			this.Text = "PPh 23";
			this.xpCol = this.xpCol;
			((System.ComponentModel.ISupportInitialize)(this.xGrid)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.xpCol)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.barMan)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.session)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.xGridView)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.popMenu)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
		private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
		private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
		private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
		private DevExpress.XtraGrid.Columns.GridColumn colNomorInvoice;
		private DevExpress.XtraGrid.Columns.GridColumn colTanggalInvoice;
		private DevExpress.XtraGrid.Columns.GridColumn colWilayah;
		private DevExpress.XtraGrid.Columns.GridColumn colNamaPemasang;
		private DevExpress.XtraGrid.Columns.GridColumn colKeteranganInvoice;
		private DevExpress.XtraGrid.Columns.GridColumn colInvoiceNominal;
		private DevExpress.XtraGrid.Columns.GridColumn colPotongPPh23;
		private DevExpress.XtraGrid.Columns.GridColumn colIsUploadBuktiPotong;
		private DevExpress.XtraBars.BarButtonItem btnUploadBuktiPotong;
		private DevExpress.XtraBars.BarButtonItem btnLihatBuktiPotong;
	}
}
