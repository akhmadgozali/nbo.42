namespace NuSoft.NUI.Win.Forms.Modules.NuSoft012.UI.DataIklan
{
	partial class UI_PiutangJatuhTempo
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UI_PiutangJatuhTempo));
			DevExpress.XtraGrid.StyleFormatCondition styleFormatCondition1 = new DevExpress.XtraGrid.StyleFormatCondition();
			this.colSelisihJatuhTempo = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colWilayah = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colNoInvoice = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colSales = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colPemasang = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colTanggalInvoiceKoreksi = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colJatuhTempo = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colOmzet = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colTerbayar = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colPiutang = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colTipeInvoice = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colTahun = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colBulan = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colRegional = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colCP = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colPenagihan = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colTanggalOmzet = new DevExpress.XtraGrid.Columns.GridColumn();
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
			this.ifSource.FixedFilterString = "IsNullOrEmpty([IndukInvoice]) And IsNullOrEmpty([KoreksiInvoice]) And [Piutang] <" +
    "> 0.0m";
			this.ifSource.ObjectType = typeof(NuSoft.NUI.Win.Forms.Modules.NuSoft012.Persistent.Invoice);
			// 
			// xGrid
			// 
			this.xGrid.DataSource = this.ifSource;
			// 
			// xGridView
			// 
			this.xGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colWilayah,
            this.colNoInvoice,
            this.colSales,
            this.colPemasang,
            this.colTanggalOmzet,
            this.colTanggalInvoiceKoreksi,
            this.colJatuhTempo,
            this.colSelisihJatuhTempo,
            this.colOmzet,
            this.colTerbayar,
            this.colPiutang,
            this.colTipeInvoice,
            this.colTahun,
            this.colBulan,
            this.colRegional,
            this.colCP,
            this.colPenagihan});
			styleFormatCondition1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			styleFormatCondition1.Appearance.Options.UseBackColor = true;
			styleFormatCondition1.ApplyToRow = true;
			styleFormatCondition1.Column = this.colSelisihJatuhTempo;
			styleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.Greater;
			styleFormatCondition1.Value1 = 0;
			this.xGridView.FormatConditions.AddRange(new DevExpress.XtraGrid.StyleFormatCondition[] {
            styleFormatCondition1});
			this.xGridView.GroupCount = 4;
			this.xGridView.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TotalGabungan", null, "Total Omzet : {0:n0}"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "JumlahBayar", null, "Total Terbayar : {0:n0}"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Piutang", null, "Total Piutang : {0:n0}")});
			this.xGridView.OptionsBehavior.Editable = false;
			this.xGridView.OptionsDetail.EnableMasterViewMode = false;
			this.xGridView.OptionsSelection.MultiSelect = true;
			this.xGridView.OptionsView.ShowAutoFilterRow = true;
			this.xGridView.OptionsView.ShowFooter = true;
			this.xGridView.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colTahun, DevExpress.Data.ColumnSortOrder.Ascending),
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colBulan, DevExpress.Data.ColumnSortOrder.Ascending),
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colRegional, DevExpress.Data.ColumnSortOrder.Ascending),
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colWilayah, DevExpress.Data.ColumnSortOrder.Ascending),
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colSelisihJatuhTempo, DevExpress.Data.ColumnSortOrder.Descending)});
			// 
			// barMenu
			// 
			this.barMenu.OptionsBar.AllowQuickCustomization = false;
			this.barMenu.OptionsBar.DrawDragBorder = false;
			this.barMenu.OptionsBar.UseWholeRow = true;
			// 
			// colSelisihJatuhTempo
			// 
			this.colSelisihJatuhTempo.Caption = "Umur Piutang";
			this.colSelisihJatuhTempo.DisplayFormat.FormatString = "n0";
			this.colSelisihJatuhTempo.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.colSelisihJatuhTempo.FieldName = "SelisihJatuhTempo";
			this.colSelisihJatuhTempo.Name = "colSelisihJatuhTempo";
			this.colSelisihJatuhTempo.Visible = true;
			this.colSelisihJatuhTempo.VisibleIndex = 6;
			// 
			// colWilayah
			// 
			this.colWilayah.Caption = "Wilayah";
			this.colWilayah.FieldName = "Wilayah.Nama";
			this.colWilayah.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.DisplayText;
			this.colWilayah.Name = "colWilayah";
			this.colWilayah.Visible = true;
			this.colWilayah.VisibleIndex = 0;
			this.colWilayah.Width = 83;
			// 
			// colNoInvoice
			// 
			this.colNoInvoice.Caption = "No. Invoice";
			this.colNoInvoice.FieldName = "NoInvoice";
			this.colNoInvoice.Name = "colNoInvoice";
			this.colNoInvoice.Visible = true;
			this.colNoInvoice.VisibleIndex = 0;
			this.colNoInvoice.Width = 104;
			// 
			// colSales
			// 
			this.colSales.Caption = "Sales";
			this.colSales.FieldName = "Sales.Nama";
			this.colSales.Name = "colSales";
			this.colSales.Visible = true;
			this.colSales.VisibleIndex = 1;
			// 
			// colPemasang
			// 
			this.colPemasang.Caption = "Pemasang";
			this.colPemasang.FieldName = "InvoiceNama";
			this.colPemasang.Name = "colPemasang";
			this.colPemasang.Visible = true;
			this.colPemasang.VisibleIndex = 2;
			// 
			// colTanggalInvoiceKoreksi
			// 
			this.colTanggalInvoiceKoreksi.Caption = "Tgl. Invoice";
			this.colTanggalInvoiceKoreksi.DisplayFormat.FormatString = "dd MMM yyyy";
			this.colTanggalInvoiceKoreksi.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
			this.colTanggalInvoiceKoreksi.FieldName = "TanggalInvoiceKoreksi";
			this.colTanggalInvoiceKoreksi.Name = "colTanggalInvoiceKoreksi";
			this.colTanggalInvoiceKoreksi.Visible = true;
			this.colTanggalInvoiceKoreksi.VisibleIndex = 4;
			// 
			// colJatuhTempo
			// 
			this.colJatuhTempo.Caption = "Jatuh Tempo";
			this.colJatuhTempo.DisplayFormat.FormatString = "dd MMM yyyy";
			this.colJatuhTempo.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
			this.colJatuhTempo.FieldName = "TanggalJatuhTempo";
			this.colJatuhTempo.Name = "colJatuhTempo";
			this.colJatuhTempo.Visible = true;
			this.colJatuhTempo.VisibleIndex = 5;
			// 
			// colOmzet
			// 
			this.colOmzet.Caption = "Omzet";
			this.colOmzet.DisplayFormat.FormatString = "n0";
			this.colOmzet.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.colOmzet.FieldName = "TotalGabungan";
			this.colOmzet.Name = "colOmzet";
			this.colOmzet.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TotalGabungan", "{0:n0}")});
			this.colOmzet.Visible = true;
			this.colOmzet.VisibleIndex = 7;
			// 
			// colTerbayar
			// 
			this.colTerbayar.Caption = "Terbayar";
			this.colTerbayar.DisplayFormat.FormatString = "n0";
			this.colTerbayar.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.colTerbayar.FieldName = "JumlahBayar";
			this.colTerbayar.Name = "colTerbayar";
			this.colTerbayar.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "JumlahBayar", "{0:n0}")});
			this.colTerbayar.Visible = true;
			this.colTerbayar.VisibleIndex = 8;
			// 
			// colPiutang
			// 
			this.colPiutang.Caption = "Piutang";
			this.colPiutang.DisplayFormat.FormatString = "n0";
			this.colPiutang.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.colPiutang.FieldName = "Piutang";
			this.colPiutang.Name = "colPiutang";
			this.colPiutang.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Piutang", "{0:n0}")});
			this.colPiutang.Visible = true;
			this.colPiutang.VisibleIndex = 9;
			// 
			// colTipeInvoice
			// 
			this.colTipeInvoice.Caption = "Tipe Invoice";
			this.colTipeInvoice.FieldName = "TipeInvoice.Nama";
			this.colTipeInvoice.Name = "colTipeInvoice";
			this.colTipeInvoice.Visible = true;
			this.colTipeInvoice.VisibleIndex = 10;
			// 
			// colTahun
			// 
			this.colTahun.Caption = "Tahun";
			this.colTahun.FieldName = "Tahun";
			this.colTahun.Name = "colTahun";
			this.colTahun.Visible = true;
			this.colTahun.VisibleIndex = 11;
			// 
			// colBulan
			// 
			this.colBulan.Caption = "Bulan";
			this.colBulan.DisplayFormat.FormatString = "MMMM";
			this.colBulan.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
			this.colBulan.FieldName = "Bulan";
			this.colBulan.GroupFormat.FormatString = "MMMM";
			this.colBulan.GroupFormat.FormatType = DevExpress.Utils.FormatType.Custom;
			this.colBulan.Name = "colBulan";
			this.colBulan.Visible = true;
			this.colBulan.VisibleIndex = 12;
			// 
			// colRegional
			// 
			this.colRegional.Caption = "Regional";
			this.colRegional.FieldName = "Wilayah.Regional.Nama";
			this.colRegional.Name = "colRegional";
			this.colRegional.Visible = true;
			this.colRegional.VisibleIndex = 11;
			// 
			// colCP
			// 
			this.colCP.Caption = "Kontak Person";
			this.colCP.FieldName = "OrderKontakPerson";
			this.colCP.Name = "colCP";
			this.colCP.Visible = true;
			this.colCP.VisibleIndex = 11;
			// 
			// colPenagihan
			// 
			this.colPenagihan.FieldName = "Kurir.Nama";
			this.colPenagihan.Name = "colPenagihan";
			this.colPenagihan.Visible = true;
			this.colPenagihan.VisibleIndex = 12;
			// 
			// colTanggalOmzet
			// 
			this.colTanggalOmzet.Caption = "Tgl. Omzet";
			this.colTanggalOmzet.DisplayFormat.FormatString = "dd MMM yyyy";
			this.colTanggalOmzet.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
			this.colTanggalOmzet.FieldName = "TanggalOmzet";
			this.colTanggalOmzet.Name = "colTanggalOmzet";
			this.colTanggalOmzet.Visible = true;
			this.colTanggalOmzet.VisibleIndex = 3;
			// 
			// UI_PiutangJatuhTempo
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(888, 405);
			this.Name = "UI_PiutangJatuhTempo";
			this.Text = "Piutang Jatuh Tempo";
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

		private DevExpress.XtraGrid.Columns.GridColumn colWilayah;
		private DevExpress.XtraGrid.Columns.GridColumn colNoInvoice;
		private DevExpress.XtraGrid.Columns.GridColumn colSales;
		private DevExpress.XtraGrid.Columns.GridColumn colPemasang;
		private DevExpress.XtraGrid.Columns.GridColumn colTanggalInvoiceKoreksi;
		private DevExpress.XtraGrid.Columns.GridColumn colJatuhTempo;
		private DevExpress.XtraGrid.Columns.GridColumn colSelisihJatuhTempo;
		private DevExpress.XtraGrid.Columns.GridColumn colOmzet;
		private DevExpress.XtraGrid.Columns.GridColumn colTerbayar;
		private DevExpress.XtraGrid.Columns.GridColumn colPiutang;
		private DevExpress.XtraGrid.Columns.GridColumn colTipeInvoice;
		private DevExpress.XtraGrid.Columns.GridColumn colTahun;
		private DevExpress.XtraGrid.Columns.GridColumn colBulan;
		private DevExpress.XtraGrid.Columns.GridColumn colRegional;
		private DevExpress.XtraGrid.Columns.GridColumn colCP;
		private DevExpress.XtraGrid.Columns.GridColumn colPenagihan;
		private DevExpress.XtraGrid.Columns.GridColumn colTanggalOmzet;
	}
}
