namespace NuSoft.NUI.Win.Forms.Modules.NuSoft007.UI.PPh
{
	partial class UI_PPh21
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UI_PPh21));
			this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colNomorInvoice = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colTanggalInvoice = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colInvoiceNominal = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colSales = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colWilayah = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colKeteranganInvoice = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colNPWPSales = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colFeeNominalBruto = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colPPh21Nominal = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colFeeNominalNetto = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
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
            this.colSales,
            this.colNPWPSales,
            this.colKeteranganInvoice,
            this.colInvoiceNominal,
            this.colFeeNominalBruto,
            this.colPPh21Nominal,
            this.colFeeNominalNetto,
            this.colId,
            this.colIsUploadBuktiPotong});
			this.xGridView.GroupCount = 2;
			this.xGridView.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "PPh21", null, "[PPh 21 = {0:n0}]"),
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
			this.ifSource.DisplayableProperties = resources.GetString("ifSource.DisplayableProperties");
			this.ifSource.ObjectType = typeof(NuSoft.NUI.Win.Forms.Modules.NuSoft007.Persistent.PPh21Komisi);
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
			this.gridColumn1.Width = 90;
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
			this.gridColumn3.Width = 60;
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
			// colNomorInvoice
			// 
			this.colNomorInvoice.Caption = "No. Invoice";
			this.colNomorInvoice.FieldName = "NoInvoice";
			this.colNomorInvoice.Name = "colNomorInvoice";
			this.colNomorInvoice.Visible = true;
			this.colNomorInvoice.VisibleIndex = 2;
			this.colNomorInvoice.Width = 70;
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
			this.colTanggalInvoice.Width = 60;
			// 
			// colInvoiceNominal
			// 
			this.colInvoiceNominal.AppearanceHeader.Options.UseTextOptions = true;
			this.colInvoiceNominal.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
			this.colInvoiceNominal.Caption = "Omzet";
			this.colInvoiceNominal.DisplayFormat.FormatString = "n0";
			this.colInvoiceNominal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.colInvoiceNominal.FieldName = "DppKomisi";
			this.colInvoiceNominal.Name = "colInvoiceNominal";
			this.colInvoiceNominal.Visible = true;
			this.colInvoiceNominal.VisibleIndex = 8;
			this.colInvoiceNominal.Width = 60;
			// 
			// colSales
			// 
			this.colSales.FieldName = "Penerima";
			this.colSales.Name = "colSales";
			this.colSales.Visible = true;
			this.colSales.VisibleIndex = 5;
			this.colSales.Width = 80;
			// 
			// colWilayah
			// 
			this.colWilayah.FieldName = "Wilayah";
			this.colWilayah.Name = "colWilayah";
			this.colWilayah.Visible = true;
			this.colWilayah.VisibleIndex = 4;
			this.colWilayah.Width = 80;
			// 
			// colKeteranganInvoice
			// 
			this.colKeteranganInvoice.Caption = "Keterangan";
			this.colKeteranganInvoice.FieldName = "KeteranganInvoice";
			this.colKeteranganInvoice.Name = "colKeteranganInvoice";
			this.colKeteranganInvoice.Visible = true;
			this.colKeteranganInvoice.VisibleIndex = 7;
			this.colKeteranganInvoice.Width = 135;
			// 
			// colNPWPSales
			// 
			this.colNPWPSales.FieldName = "NPWPPenerima";
			this.colNPWPSales.Name = "colNPWPSales";
			this.colNPWPSales.Visible = true;
			this.colNPWPSales.VisibleIndex = 6;
			this.colNPWPSales.Width = 80;
			// 
			// colFeeNominalBruto
			// 
			this.colFeeNominalBruto.AppearanceHeader.Options.UseTextOptions = true;
			this.colFeeNominalBruto.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
			this.colFeeNominalBruto.Caption = "Komisi";
			this.colFeeNominalBruto.DisplayFormat.FormatString = "n0";
			this.colFeeNominalBruto.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.colFeeNominalBruto.FieldName = "KomisiNominal";
			this.colFeeNominalBruto.Name = "colFeeNominalBruto";
			this.colFeeNominalBruto.Visible = true;
			this.colFeeNominalBruto.VisibleIndex = 9;
			this.colFeeNominalBruto.Width = 60;
			// 
			// colPPh21Nominal
			// 
			this.colPPh21Nominal.AppearanceHeader.Options.UseTextOptions = true;
			this.colPPh21Nominal.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
			this.colPPh21Nominal.Caption = "PPh 21";
			this.colPPh21Nominal.DisplayFormat.FormatString = "n0";
			this.colPPh21Nominal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.colPPh21Nominal.FieldName = "PPh21";
			this.colPPh21Nominal.Name = "colPPh21Nominal";
			this.colPPh21Nominal.Visible = true;
			this.colPPh21Nominal.VisibleIndex = 10;
			this.colPPh21Nominal.Width = 50;
			// 
			// colFeeNominalNetto
			// 
			this.colFeeNominalNetto.AppearanceHeader.Options.UseTextOptions = true;
			this.colFeeNominalNetto.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
			this.colFeeNominalNetto.Caption = "Komisi Netto";
			this.colFeeNominalNetto.DisplayFormat.FormatString = "n0";
			this.colFeeNominalNetto.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.colFeeNominalNetto.FieldName = "KomisiNetto";
			this.colFeeNominalNetto.Name = "colFeeNominalNetto";
			this.colFeeNominalNetto.Visible = true;
			this.colFeeNominalNetto.VisibleIndex = 11;
			this.colFeeNominalNetto.Width = 67;
			// 
			// colId
			// 
			this.colId.FieldName = "Id";
			this.colId.Name = "colId";
			// 
			// colIsUploadBuktiPotong
			// 
			this.colIsUploadBuktiPotong.Caption = "Bukti Potong";
			this.colIsUploadBuktiPotong.FieldName = "IsUploadBuktiPotong";
			this.colIsUploadBuktiPotong.Name = "colIsUploadBuktiPotong";
			this.colIsUploadBuktiPotong.Visible = true;
			this.colIsUploadBuktiPotong.VisibleIndex = 12;
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
			// UI_PPh21
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(945, 359);
			this.Name = "UI_PPh21";
			this.Text = "PPh 21 Komisi";
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
		private DevExpress.XtraGrid.Columns.GridColumn colSales;
		private DevExpress.XtraGrid.Columns.GridColumn colKeteranganInvoice;
		private DevExpress.XtraGrid.Columns.GridColumn colInvoiceNominal;
		private DevExpress.XtraGrid.Columns.GridColumn colNPWPSales;
		private DevExpress.XtraGrid.Columns.GridColumn colFeeNominalBruto;
		private DevExpress.XtraGrid.Columns.GridColumn colPPh21Nominal;
		private DevExpress.XtraGrid.Columns.GridColumn colFeeNominalNetto;
		private DevExpress.XtraGrid.Columns.GridColumn colId;
		private DevExpress.XtraGrid.Columns.GridColumn colIsUploadBuktiPotong;
		private DevExpress.XtraBars.BarButtonItem btnUploadBuktiPotong;
		private DevExpress.XtraBars.BarButtonItem btnLihatBuktiPotong;
	}
}
