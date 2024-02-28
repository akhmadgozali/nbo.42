namespace NuSoft.NUI.Win.Forms.Modules.NuSoft012.UI.Transaksi
{
	partial class UI_IklanPenagihan
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
			DevExpress.XtraGrid.StyleFormatCondition styleFormatCondition1 = new DevExpress.XtraGrid.StyleFormatCondition();
			DevExpress.XtraGrid.StyleFormatCondition styleFormatCondition2 = new DevExpress.XtraGrid.StyleFormatCondition();
			this.colTahun = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colBulan = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colWilayah = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colNomorInvoice = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colNomorOrder = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colTanggal = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colSales = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colPemasang = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colTotal = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colKeterangan = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colKurir = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colStatusBayar = new DevExpress.XtraGrid.Columns.GridColumn();
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
            this.colId,
            this.colNomorInvoice,
            this.colNomorOrder,
            this.colTanggal,
            this.colSales,
            this.colPemasang,
            this.colKurir,
            this.colTotal,
            this.colKeterangan,
            this.colStatusBayar});
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
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TotalGabungan", null, "| Total : {0:n0}")});
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
			this.ifSource.DisplayableProperties = "Id;Wilayah.Nama;NoInvoice;Sales.Nama;SaldoAwal;TanggalOmzet;InvoiceNama;Keteranga" +
    "n;TotalGabungan;Tahun;Bulan;StatusBayar;Kurir.Nama;NoOrder;IndukInvoice";
			this.ifSource.FixedFilterString = "[SaldoAwal] = False And IsNullOrEmpty([IndukInvoice])";
			this.ifSource.ObjectType = typeof(NuSoft.NUI.Win.Forms.Modules.NuSoft012.Persistent.Invoice);
			// 
			// barMenu
			// 
			this.barMenu.OptionsBar.AllowQuickCustomization = false;
			this.barMenu.OptionsBar.DrawDragBorder = false;
			this.barMenu.OptionsBar.UseWholeRow = true;
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
			this.colBulan.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.DisplayText;
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
			this.colNomorInvoice.VisibleIndex = 1;
			this.colNomorInvoice.Width = 82;
			// 
			// colNomorOrder
			// 
			this.colNomorOrder.FieldName = "NoOrder";
			this.colNomorOrder.Name = "colNomorOrder";
			this.colNomorOrder.Visible = true;
			this.colNomorOrder.VisibleIndex = 2;
			this.colNomorOrder.Width = 79;
			// 
			// colTanggal
			// 
			this.colTanggal.DisplayFormat.FormatString = "dd MMM yyyy";
			this.colTanggal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
			this.colTanggal.FieldName = "TanggalOmzet";
			this.colTanggal.Name = "colTanggal";
			this.colTanggal.Visible = true;
			this.colTanggal.VisibleIndex = 3;
			this.colTanggal.Width = 70;
			// 
			// colSales
			// 
			this.colSales.Caption = "Sales";
			this.colSales.FieldName = "Sales.Nama";
			this.colSales.Name = "colSales";
			this.colSales.Visible = true;
			this.colSales.VisibleIndex = 4;
			this.colSales.Width = 74;
			// 
			// colPemasang
			// 
			this.colPemasang.Caption = "Pemasang";
			this.colPemasang.FieldName = "InvoiceNama";
			this.colPemasang.Name = "colPemasang";
			this.colPemasang.Visible = true;
			this.colPemasang.VisibleIndex = 5;
			this.colPemasang.Width = 74;
			// 
			// colTotal
			// 
			this.colTotal.Caption = "Total";
			this.colTotal.DisplayFormat.FormatString = "n0";
			this.colTotal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.colTotal.FieldName = "TotalGabungan";
			this.colTotal.Name = "colTotal";
			this.colTotal.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TotalGabungan", "{0:n0}")});
			this.colTotal.Visible = true;
			this.colTotal.VisibleIndex = 7;
			this.colTotal.Width = 70;
			// 
			// colKeterangan
			// 
			this.colKeterangan.Caption = "Keterangan";
			this.colKeterangan.FieldName = "Keterangan";
			this.colKeterangan.Name = "colKeterangan";
			this.colKeterangan.Visible = true;
			this.colKeterangan.VisibleIndex = 8;
			this.colKeterangan.Width = 74;
			// 
			// colId
			// 
			this.colId.Caption = "No. Seri";
			this.colId.FieldName = "Id";
			this.colId.Name = "colId";
			this.colId.Visible = true;
			this.colId.VisibleIndex = 0;
			this.colId.Width = 87;
			// 
			// colKurir
			// 
			this.colKurir.Caption = "Kurir";
			this.colKurir.FieldName = "Kurir.Nama";
			this.colKurir.Name = "colKurir";
			this.colKurir.Visible = true;
			this.colKurir.VisibleIndex = 6;
			this.colKurir.Width = 74;
			// 
			// colStatusBayar
			// 
			this.colStatusBayar.Caption = "Status";
			this.colStatusBayar.FieldName = "StatusBayar";
			this.colStatusBayar.Name = "colStatusBayar";
			this.colStatusBayar.Width = 40;
			// 
			// UI_IklanPenagihan
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(728, 396);
			this.Name = "UI_IklanPenagihan";
			this.Text = "Penagihan Iklan";
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
		private DevExpress.XtraGrid.Columns.GridColumn colKeterangan;
		private DevExpress.XtraGrid.Columns.GridColumn colId;
		private DevExpress.XtraGrid.Columns.GridColumn colKurir;
		private DevExpress.XtraGrid.Columns.GridColumn colStatusBayar;
	}
}
