namespace NuSoft.NUI.Win.Forms.Modules.NuSoft012.UI.DataIklan
{
	partial class UI_RincianOmzet
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UI_RincianOmzet));
			this.colTanggalOmzet = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colNoInvoice = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colOmzet = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colWilayah = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colRegional = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colTipeInvoice = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colJatuhTempo = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colSales = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colTanggalInvoice = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colPemasang = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colMerk = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colProduk = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colTahun = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colBulan = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colInvoiceKeterangan = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colKoreksi = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colNoOrder = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colNoSeriFaktur = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colCashback = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colKomisi = new DevExpress.XtraGrid.Columns.GridColumn();
			((System.ComponentModel.ISupportInitialize)(this.barMan)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.xpCol)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.session)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.popMenu)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.xGrid)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.xGridView)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.SplitContainerControl1)).BeginInit();
			this.SplitContainerControl1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.chartPopUp)).BeginInit();
			this.SuspendLayout();
			// 
			// ifSource
			// 
			this.ifSource.DisplayableProperties = resources.GetString("ifSource.DisplayableProperties");
			this.ifSource.FixedFilterString = "[SaldoAwal] = False";
			this.ifSource.ObjectType = typeof(NuSoft.NUI.Win.Forms.Modules.NuSoft012.Persistent.Invoice);
			// 
			// xGrid
			// 
			this.xGrid.DataSource = this.ifSource;
			// 
			// xGridView
			// 
			this.xGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colTahun,
            this.colBulan,
            this.colNoInvoice,
            this.colNoOrder,
            this.colTanggalOmzet,
            this.colTanggalInvoice,
            this.colJatuhTempo,
            this.colRegional,
            this.colWilayah,
            this.colSales,
            this.colPemasang,
            this.colTipeInvoice,
            this.colProduk,
            this.colMerk,
            this.colOmzet,
            this.colKoreksi,
            this.colKomisi,
            this.colCashback,
            this.colNoSeriFaktur,
            this.colInvoiceKeterangan});
			this.xGridView.GroupCount = 2;
			this.xGridView.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Total", null, "| Total Omzet : {0:n0}")});
			this.xGridView.OptionsBehavior.Editable = false;
			this.xGridView.OptionsDetail.EnableMasterViewMode = false;
			this.xGridView.OptionsSelection.MultiSelect = true;
			this.xGridView.OptionsView.ColumnAutoWidth = false;
			this.xGridView.OptionsView.ShowAutoFilterRow = true;
			this.xGridView.OptionsView.ShowFooter = true;
			this.xGridView.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colTahun, DevExpress.Data.ColumnSortOrder.Descending),
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colBulan, DevExpress.Data.ColumnSortOrder.Descending)});
			// 
			// barMenu
			// 
			this.barMenu.OptionsBar.AllowQuickCustomization = false;
			this.barMenu.OptionsBar.DrawDragBorder = false;
			this.barMenu.OptionsBar.UseWholeRow = true;
			// 
			// colTanggalOmzet
			// 
			this.colTanggalOmzet.Caption = "Tgl Omzet";
			this.colTanggalOmzet.DisplayFormat.FormatString = "dd MMM yyyy";
			this.colTanggalOmzet.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
			this.colTanggalOmzet.FieldName = "TanggalOmzet";
			this.colTanggalOmzet.Name = "colTanggalOmzet";
			this.colTanggalOmzet.Visible = true;
			this.colTanggalOmzet.VisibleIndex = 2;
			this.colTanggalOmzet.Width = 80;
			// 
			// colNoInvoice
			// 
			this.colNoInvoice.FieldName = "NoInvoice";
			this.colNoInvoice.Name = "colNoInvoice";
			this.colNoInvoice.Visible = true;
			this.colNoInvoice.VisibleIndex = 0;
			this.colNoInvoice.Width = 150;
			// 
			// colOmzet
			// 
			this.colOmzet.Caption = "Omzet";
			this.colOmzet.DisplayFormat.FormatString = "n0";
			this.colOmzet.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.colOmzet.FieldName = "OmzetNonKoreksi";
			this.colOmzet.Name = "colOmzet";
			this.colOmzet.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "OmzetNonKoreksi", "{0:n0}")});
			this.colOmzet.Visible = true;
			this.colOmzet.VisibleIndex = 12;
			this.colOmzet.Width = 80;
			// 
			// colWilayah
			// 
			this.colWilayah.Caption = "Wilayah";
			this.colWilayah.FieldName = "Wilayah.Nama";
			this.colWilayah.Name = "colWilayah";
			this.colWilayah.Visible = true;
			this.colWilayah.VisibleIndex = 6;
			this.colWilayah.Width = 90;
			// 
			// colRegional
			// 
			this.colRegional.Caption = "Regional";
			this.colRegional.FieldName = "Wilayah.Regional.Nama";
			this.colRegional.Name = "colRegional";
			this.colRegional.Visible = true;
			this.colRegional.VisibleIndex = 5;
			this.colRegional.Width = 90;
			// 
			// colTipeInvoice
			// 
			this.colTipeInvoice.Caption = "Tipe Invoice";
			this.colTipeInvoice.FieldName = "TipeInvoice.Nama";
			this.colTipeInvoice.Name = "colTipeInvoice";
			this.colTipeInvoice.Visible = true;
			this.colTipeInvoice.VisibleIndex = 9;
			this.colTipeInvoice.Width = 80;
			// 
			// colJatuhTempo
			// 
			this.colJatuhTempo.Caption = "Jatuh Tempo";
			this.colJatuhTempo.DisplayFormat.FormatString = "dd MMM yyyy";
			this.colJatuhTempo.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
			this.colJatuhTempo.FieldName = "TanggalJatuhTempo";
			this.colJatuhTempo.Name = "colJatuhTempo";
			this.colJatuhTempo.Visible = true;
			this.colJatuhTempo.VisibleIndex = 4;
			this.colJatuhTempo.Width = 80;
			// 
			// colSales
			// 
			this.colSales.Caption = "Sales";
			this.colSales.FieldName = "Sales.Nama";
			this.colSales.Name = "colSales";
			this.colSales.Visible = true;
			this.colSales.VisibleIndex = 7;
			this.colSales.Width = 100;
			// 
			// colTanggalInvoice
			// 
			this.colTanggalInvoice.Caption = "Tgl Invoice";
			this.colTanggalInvoice.DisplayFormat.FormatString = "dd MMM yyyy";
			this.colTanggalInvoice.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
			this.colTanggalInvoice.FieldName = "TanggalInvoice";
			this.colTanggalInvoice.Name = "colTanggalInvoice";
			this.colTanggalInvoice.Visible = true;
			this.colTanggalInvoice.VisibleIndex = 3;
			this.colTanggalInvoice.Width = 80;
			// 
			// colPemasang
			// 
			this.colPemasang.Caption = "Pemasang";
			this.colPemasang.FieldName = "InvoiceNama";
			this.colPemasang.Name = "colPemasang";
			this.colPemasang.Visible = true;
			this.colPemasang.VisibleIndex = 8;
			this.colPemasang.Width = 180;
			// 
			// colMerk
			// 
			this.colMerk.Caption = "Merk";
			this.colMerk.FieldName = "Merk.Nama";
			this.colMerk.Name = "colMerk";
			this.colMerk.Visible = true;
			this.colMerk.VisibleIndex = 11;
			this.colMerk.Width = 90;
			// 
			// colProduk
			// 
			this.colProduk.Caption = "Produk";
			this.colProduk.FieldName = "Merk.Produk.Nama";
			this.colProduk.Name = "colProduk";
			this.colProduk.Visible = true;
			this.colProduk.VisibleIndex = 10;
			this.colProduk.Width = 90;
			// 
			// colTahun
			// 
			this.colTahun.FieldName = "Tahun";
			this.colTahun.Name = "colTahun";
			this.colTahun.Visible = true;
			this.colTahun.VisibleIndex = 13;
			// 
			// colBulan
			// 
			this.colBulan.DisplayFormat.FormatString = "MMMM";
			this.colBulan.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
			this.colBulan.FieldName = "Bulan";
			this.colBulan.GroupFormat.FormatString = "MMMM";
			this.colBulan.GroupFormat.FormatType = DevExpress.Utils.FormatType.Custom;
			this.colBulan.Name = "colBulan";
			this.colBulan.Visible = true;
			this.colBulan.VisibleIndex = 13;
			// 
			// colInvoiceKeterangan
			// 
			this.colInvoiceKeterangan.Caption = "Judul";
			this.colInvoiceKeterangan.FieldName = "InvoiceKeterangan";
			this.colInvoiceKeterangan.Name = "colInvoiceKeterangan";
			this.colInvoiceKeterangan.Visible = true;
			this.colInvoiceKeterangan.VisibleIndex = 17;
			this.colInvoiceKeterangan.Width = 120;
			// 
			// colKoreksi
			// 
			this.colKoreksi.Caption = "Koreksi";
			this.colKoreksi.DisplayFormat.FormatString = "n0";
			this.colKoreksi.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.colKoreksi.FieldName = "OmzetKoreksi";
			this.colKoreksi.Name = "colKoreksi";
			this.colKoreksi.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "OmzetKoreksi", "{0:n0}")});
			this.colKoreksi.Visible = true;
			this.colKoreksi.VisibleIndex = 13;
			this.colKoreksi.Width = 80;
			// 
			// colNoOrder
			// 
			this.colNoOrder.Caption = "No Order";
			this.colNoOrder.FieldName = "NoOrder";
			this.colNoOrder.Name = "colNoOrder";
			this.colNoOrder.Visible = true;
			this.colNoOrder.VisibleIndex = 1;
			this.colNoOrder.Width = 100;
			// 
			// colNoSeriFaktur
			// 
			this.colNoSeriFaktur.Caption = "No. Seri Faktur";
			this.colNoSeriFaktur.FieldName = "TaxId.NoSeriLengkap";
			this.colNoSeriFaktur.Name = "colNoSeriFaktur";
			this.colNoSeriFaktur.Visible = true;
			this.colNoSeriFaktur.VisibleIndex = 16;
			this.colNoSeriFaktur.Width = 90;
			// 
			// colCashback
			// 
			this.colCashback.Caption = "Cashback";
			this.colCashback.DisplayFormat.FormatString = "n0";
			this.colCashback.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.colCashback.FieldName = "CashbackNominal";
			this.colCashback.Name = "colCashback";
			this.colCashback.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "CashbackNominal", "{0:n0}")});
			this.colCashback.Visible = true;
			this.colCashback.VisibleIndex = 15;
			this.colCashback.Width = 70;
			// 
			// colKomisi
			// 
			this.colKomisi.Caption = "Komisi";
			this.colKomisi.DisplayFormat.FormatString = "n0";
			this.colKomisi.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.colKomisi.FieldName = "KomisiNominal";
			this.colKomisi.Name = "colKomisi";
			this.colKomisi.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "KomisiNominal", "{0:n0}")});
			this.colKomisi.Visible = true;
			this.colKomisi.VisibleIndex = 14;
			this.colKomisi.Width = 70;
			// 
			// UI_RincianOmzet
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(888, 405);
			this.Name = "UI_RincianOmzet";
			this.Text = "Rincian Omzet";
			this.xpCol = this.xpCol;
			((System.ComponentModel.ISupportInitialize)(this.barMan)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.xpCol)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.session)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.popMenu)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.xGrid)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.xGridView)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.SplitContainerControl1)).EndInit();
			this.SplitContainerControl1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.chartPopUp)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion
		private DevExpress.XtraGrid.Columns.GridColumn colTanggalOmzet;
		private DevExpress.XtraGrid.Columns.GridColumn colNoInvoice;
		private DevExpress.XtraGrid.Columns.GridColumn colOmzet;
		private DevExpress.XtraGrid.Columns.GridColumn colWilayah;
		private DevExpress.XtraGrid.Columns.GridColumn colRegional;
		private DevExpress.XtraGrid.Columns.GridColumn colTipeInvoice;
		private DevExpress.XtraGrid.Columns.GridColumn colJatuhTempo;
		private DevExpress.XtraGrid.Columns.GridColumn colSales;
		private DevExpress.XtraGrid.Columns.GridColumn colTanggalInvoice;
		private DevExpress.XtraGrid.Columns.GridColumn colPemasang;
		private DevExpress.XtraGrid.Columns.GridColumn colMerk;
		private DevExpress.XtraGrid.Columns.GridColumn colProduk;
		private DevExpress.XtraGrid.Columns.GridColumn colTahun;
		private DevExpress.XtraGrid.Columns.GridColumn colBulan;
		private DevExpress.XtraGrid.Columns.GridColumn colInvoiceKeterangan;
		private DevExpress.XtraGrid.Columns.GridColumn colKoreksi;
		private DevExpress.XtraGrid.Columns.GridColumn colNoOrder;
		private DevExpress.XtraGrid.Columns.GridColumn colNoSeriFaktur;
		private DevExpress.XtraGrid.Columns.GridColumn colKomisi;
		private DevExpress.XtraGrid.Columns.GridColumn colCashback;
	}
}
