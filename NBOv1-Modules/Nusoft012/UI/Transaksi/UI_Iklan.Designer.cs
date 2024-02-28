namespace NuSoft.NUI.Win.Forms.Modules.NuSoft012.UI.Transaksi
{
	partial class UI_Iklan
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
		private void InitializeComponent() {
			DevExpress.XtraGrid.StyleFormatCondition styleFormatCondition1 = new DevExpress.XtraGrid.StyleFormatCondition();
			DevExpress.XtraGrid.StyleFormatCondition styleFormatCondition2 = new DevExpress.XtraGrid.StyleFormatCondition();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UI_Iklan));
			this.colStatusBayar = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colTahun = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colBulan = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colWilayah = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colNomorInvoice = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colNomorOrder = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colTanggal = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colSales = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colPemasang = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colTotal = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colTipeInvoice = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colTotalKomisiPersen = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colTotalCashbackNominal = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colInvoiceKeterangan = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colTanggalInvoice = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colTotalKomisiNominal = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
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
			this.xGrid.Size = new System.Drawing.Size(728, 369);
			// 
			// xGridView
			// 
			this.xGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colTahun,
            this.colBulan,
            this.colWilayah,
            this.colNomorInvoice,
            this.colNomorOrder,
            this.colTanggal,
            this.colTanggalInvoice,
            this.colSales,
            this.colPemasang,
            this.colTipeInvoice,
            this.colTotal,
            this.colTotalKomisiPersen,
            this.colTotalKomisiNominal,
            this.colTotalCashbackNominal,
            this.colInvoiceKeterangan,
            this.colStatusBayar,
            this.colId});
			styleFormatCondition1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
			styleFormatCondition1.Appearance.Options.UseBackColor = true;
			styleFormatCondition1.ApplyToRow = true;
			styleFormatCondition1.Column = this.colStatusBayar;
			styleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal;
			styleFormatCondition1.Value1 = 1;
			styleFormatCondition2.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			styleFormatCondition2.Appearance.Options.UseBackColor = true;
			styleFormatCondition2.ApplyToRow = true;
			styleFormatCondition2.Column = this.colStatusBayar;
			styleFormatCondition2.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal;
			styleFormatCondition2.Value1 = 2;
			this.xGridView.FormatConditions.AddRange(new DevExpress.XtraGrid.StyleFormatCondition[] {
            styleFormatCondition1,
            styleFormatCondition2});
			this.xGridView.GroupCount = 3;
			this.xGridView.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Total", null, "| Total : {0:n0}")});
			this.xGridView.OptionsBehavior.Editable = false;
			this.xGridView.OptionsDetail.EnableMasterViewMode = false;
			this.xGridView.OptionsSelection.MultiSelect = true;
			this.xGridView.OptionsView.ShowAutoFilterRow = true;
			this.xGridView.OptionsView.ShowFooter = true;
			this.xGridView.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colTahun, DevExpress.Data.ColumnSortOrder.Descending),
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colBulan, DevExpress.Data.ColumnSortOrder.Descending),
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colWilayah, DevExpress.Data.ColumnSortOrder.Ascending)});
			// 
			// ifSource
			// 
			this.ifSource.DisplayableProperties = resources.GetString("ifSource.DisplayableProperties");
			this.ifSource.FixedFilterString = "[SaldoAwal] = False";
			this.ifSource.ObjectType = typeof(NuSoft.NUI.Win.Forms.Modules.NuSoft012.Persistent.Invoice);
			// 
			// barMenu
			// 
			this.barMenu.OptionsBar.AllowQuickCustomization = false;
			this.barMenu.OptionsBar.DrawDragBorder = false;
			this.barMenu.OptionsBar.UseWholeRow = true;
			// 
			// colStatusBayar
			// 
			this.colStatusBayar.FieldName = "StatusBayar";
			this.colStatusBayar.Name = "colStatusBayar";
			// 
			// colTahun
			// 
			this.colTahun.FieldName = "Tahun";
			this.colTahun.Name = "colTahun";
			this.colTahun.Visible = true;
			this.colTahun.VisibleIndex = 0;
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
			this.colBulan.VisibleIndex = 0;
			// 
			// colWilayah
			// 
			this.colWilayah.Caption = "Wilayah";
			this.colWilayah.FieldName = "Wilayah.Nama";
			this.colWilayah.Name = "colWilayah";
			this.colWilayah.Visible = true;
			this.colWilayah.VisibleIndex = 0;
			// 
			// colNomorInvoice
			// 
			this.colNomorInvoice.FieldName = "NoInvoice";
			this.colNomorInvoice.Name = "colNomorInvoice";
			this.colNomorInvoice.Visible = true;
			this.colNomorInvoice.VisibleIndex = 0;
			this.colNomorInvoice.Width = 83;
			// 
			// colNomorOrder
			// 
			this.colNomorOrder.FieldName = "NoOrder";
			this.colNomorOrder.Name = "colNomorOrder";
			this.colNomorOrder.Visible = true;
			this.colNomorOrder.VisibleIndex = 1;
			this.colNomorOrder.Width = 30;
			// 
			// colTanggal
			// 
			this.colTanggal.Caption = "Tgl. Omzet";
			this.colTanggal.DisplayFormat.FormatString = "dd MMM yyyy";
			this.colTanggal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
			this.colTanggal.FieldName = "TanggalOmzet";
			this.colTanggal.Name = "colTanggal";
			this.colTanggal.Visible = true;
			this.colTanggal.VisibleIndex = 2;
			this.colTanggal.Width = 33;
			// 
			// colSales
			// 
			this.colSales.Caption = "Sales";
			this.colSales.FieldName = "Sales.Nama";
			this.colSales.Name = "colSales";
			this.colSales.Visible = true;
			this.colSales.VisibleIndex = 4;
			this.colSales.Width = 35;
			// 
			// colPemasang
			// 
			this.colPemasang.Caption = "Pemasang";
			this.colPemasang.FieldName = "InvoiceNama";
			this.colPemasang.Name = "colPemasang";
			this.colPemasang.Visible = true;
			this.colPemasang.VisibleIndex = 5;
			this.colPemasang.Width = 35;
			// 
			// colTotal
			// 
			this.colTotal.Caption = "Total";
			this.colTotal.DisplayFormat.FormatString = "n0";
			this.colTotal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.colTotal.FieldName = "Total";
			this.colTotal.Name = "colTotal";
			this.colTotal.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Total", "{0:n0}")});
			this.colTotal.Visible = true;
			this.colTotal.VisibleIndex = 7;
			this.colTotal.Width = 33;
			// 
			// colTipeInvoice
			// 
			this.colTipeInvoice.Caption = "Tipe Invoice";
			this.colTipeInvoice.FieldName = "TipeInvoice.Nama";
			this.colTipeInvoice.Name = "colTipeInvoice";
			this.colTipeInvoice.Visible = true;
			this.colTipeInvoice.VisibleIndex = 6;
			this.colTipeInvoice.Width = 35;
			// 
			// colTotalKomisiPersen
			// 
			this.colTotalKomisiPersen.Caption = "Komisi (%)";
			this.colTotalKomisiPersen.DisplayFormat.FormatString = "n0";
			this.colTotalKomisiPersen.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.colTotalKomisiPersen.FieldName = "KomisiPersen";
			this.colTotalKomisiPersen.Name = "colTotalKomisiPersen";
			this.colTotalKomisiPersen.Visible = true;
			this.colTotalKomisiPersen.VisibleIndex = 8;
			this.colTotalKomisiPersen.Width = 20;
			// 
			// colTotalCashbackNominal
			// 
			this.colTotalCashbackNominal.Caption = "Cashback";
			this.colTotalCashbackNominal.DisplayFormat.FormatString = "n0";
			this.colTotalCashbackNominal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.colTotalCashbackNominal.FieldName = "CashbackNominal";
			this.colTotalCashbackNominal.Name = "colTotalCashbackNominal";
			this.colTotalCashbackNominal.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "CashbackNominal", "{0:n0}")});
			this.colTotalCashbackNominal.Visible = true;
			this.colTotalCashbackNominal.VisibleIndex = 10;
			this.colTotalCashbackNominal.Width = 31;
			// 
			// colInvoiceKeterangan
			// 
			this.colInvoiceKeterangan.Caption = "Judul";
			this.colInvoiceKeterangan.FieldName = "InvoiceKeterangan";
			this.colInvoiceKeterangan.Name = "colInvoiceKeterangan";
			this.colInvoiceKeterangan.Visible = true;
			this.colInvoiceKeterangan.VisibleIndex = 11;
			this.colInvoiceKeterangan.Width = 120;
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
			this.colTanggalInvoice.Width = 37;
			// 
			// colTotalKomisiNominal
			// 
			this.colTotalKomisiNominal.Caption = "Komisi";
			this.colTotalKomisiNominal.DisplayFormat.FormatString = "n0";
			this.colTotalKomisiNominal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.colTotalKomisiNominal.FieldName = "KomisiNominal";
			this.colTotalKomisiNominal.Name = "colTotalKomisiNominal";
			this.colTotalKomisiNominal.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "KomisiNominal", "{0:n0}")});
			this.colTotalKomisiNominal.Visible = true;
			this.colTotalKomisiNominal.VisibleIndex = 9;
			this.colTotalKomisiNominal.Width = 33;
			// 
			// colId
			// 
			this.colId.FieldName = "Id";
			this.colId.Name = "colId";
			// 
			// UI_Iklan
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(728, 396);
			this.Name = "UI_Iklan";
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

		private DevExpress.XtraGrid.Columns.GridColumn colTahun;
		private DevExpress.XtraGrid.Columns.GridColumn colBulan;
		private DevExpress.XtraGrid.Columns.GridColumn colWilayah;
		private DevExpress.XtraGrid.Columns.GridColumn colNomorInvoice;
		private DevExpress.XtraGrid.Columns.GridColumn colNomorOrder;
		private DevExpress.XtraGrid.Columns.GridColumn colTanggal;
		private DevExpress.XtraGrid.Columns.GridColumn colSales;
		private DevExpress.XtraGrid.Columns.GridColumn colPemasang;
		private DevExpress.XtraGrid.Columns.GridColumn colTotal;
		private DevExpress.XtraGrid.Columns.GridColumn colTipeInvoice;
		private DevExpress.XtraGrid.Columns.GridColumn colTotalKomisiPersen;
		private DevExpress.XtraGrid.Columns.GridColumn colTotalCashbackNominal;
		private DevExpress.XtraGrid.Columns.GridColumn colInvoiceKeterangan;
		private DevExpress.XtraGrid.Columns.GridColumn colTanggalInvoice;
		private DevExpress.XtraGrid.Columns.GridColumn colStatusBayar;
		private DevExpress.XtraGrid.Columns.GridColumn colTotalKomisiNominal;
		private DevExpress.XtraGrid.Columns.GridColumn colId;
	}
}
