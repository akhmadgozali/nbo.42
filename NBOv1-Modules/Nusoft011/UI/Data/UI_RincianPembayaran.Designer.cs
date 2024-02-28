namespace NuSoft.NUI.Win.Forms.Modules.NuSoft011.UI.Data
{
	partial class UI_RincianPembayaran
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
			this.colAgen = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colWilayah = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colSetor = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colTahun = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colBulan = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colBayar = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colTanggal = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colKode = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colKeterangan = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colCaraBayar = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colRegionalNama = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colMinggu = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colDiskon = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colNoGL = new DevExpress.XtraGrid.Columns.GridColumn();
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
			this.ifSource.DisplayableProperties = "Id;Kode;Regional.Nama;Agen.Rute.KodeNama;Agen.Nama;CaraBayar.Alias;Tanggal;TotalB" +
    "ayar;Diskon;Keterangan;GLId.Kode;Tahun;Bulan;Minggu;TotalSetor";
			this.ifSource.ObjectType = typeof(NuSoft.NUI.Win.Forms.Modules.NuSoft011.Persistent.BayarKoran);
			// 
			// xGrid
			// 
			this.xGrid.DataSource = this.ifSource;
			this.xGrid.Size = new System.Drawing.Size(880, 212);
			// 
			// xGridView
			// 
			this.xGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colTahun,
            this.colBulan,
            this.colWilayah,
            this.colKode,
            this.colAgen,
            this.colTanggal,
            this.colMinggu,
            this.colCaraBayar,
            this.colBayar,
            this.colDiskon,
            this.colSetor,
            this.colKeterangan,
            this.colRegionalNama,
            this.colNoGL});
			this.xGridView.GroupCount = 4;
			this.xGridView.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TotalBayar", null, "| Bayar : {0:n0}"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Diskon", null, "| Diskon : {0:n0}"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TotalSetor", null, "| Setor : {0:n0}")});
			this.xGridView.OptionsBehavior.Editable = false;
			this.xGridView.OptionsDetail.EnableMasterViewMode = false;
			this.xGridView.OptionsSelection.MultiSelect = true;
			this.xGridView.OptionsView.ShowAutoFilterRow = true;
			this.xGridView.OptionsView.ShowFooter = true;
			this.xGridView.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colTahun, DevExpress.Data.ColumnSortOrder.Descending),
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colBulan, DevExpress.Data.ColumnSortOrder.Descending),
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colRegionalNama, DevExpress.Data.ColumnSortOrder.Ascending),
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colWilayah, DevExpress.Data.ColumnSortOrder.Ascending)});
			// 
			// barMenu
			// 
			this.barMenu.OptionsBar.AllowQuickCustomization = false;
			this.barMenu.OptionsBar.DrawDragBorder = false;
			this.barMenu.OptionsBar.UseWholeRow = true;
			// 
			// SplitContainerControl1
			// 
			this.SplitContainerControl1.Size = new System.Drawing.Size(880, 377);
			// 
			// colAgen
			// 
			this.colAgen.Caption = "Agen";
			this.colAgen.FieldName = "Agen.Nama";
			this.colAgen.Name = "colAgen";
			this.colAgen.Visible = true;
			this.colAgen.VisibleIndex = 1;
			this.colAgen.Width = 116;
			// 
			// colWilayah
			// 
			this.colWilayah.Caption = "Rute";
			this.colWilayah.FieldName = "Agen.Rute.KodeNama";
			this.colWilayah.Name = "colWilayah";
			this.colWilayah.Visible = true;
			this.colWilayah.VisibleIndex = 1;
			// 
			// colSetor
			// 
			this.colSetor.Caption = "Setor";
			this.colSetor.DisplayFormat.FormatString = "n0";
			this.colSetor.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.colSetor.FieldName = "TotalSetor";
			this.colSetor.Name = "colSetor";
			this.colSetor.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TotalSetor", "{0:n0}")});
			this.colSetor.Visible = true;
			this.colSetor.VisibleIndex = 7;
			this.colSetor.Width = 73;
			// 
			// colTahun
			// 
			this.colTahun.FieldName = "Tahun";
			this.colTahun.Name = "colTahun";
			this.colTahun.Visible = true;
			this.colTahun.VisibleIndex = 4;
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
			this.colBulan.VisibleIndex = 4;
			// 
			// colBayar
			// 
			this.colBayar.Caption = "Bayar";
			this.colBayar.DisplayFormat.FormatString = "n0";
			this.colBayar.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.colBayar.FieldName = "TotalBayar";
			this.colBayar.Name = "colBayar";
			this.colBayar.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TotalBayar", "{0:n0}")});
			this.colBayar.Visible = true;
			this.colBayar.VisibleIndex = 5;
			this.colBayar.Width = 81;
			// 
			// colTanggal
			// 
			this.colTanggal.DisplayFormat.FormatString = "dd MMM yyyy";
			this.colTanggal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
			this.colTanggal.FieldName = "Tanggal";
			this.colTanggal.Name = "colTanggal";
			this.colTanggal.Visible = true;
			this.colTanggal.VisibleIndex = 2;
			this.colTanggal.Width = 95;
			// 
			// colKode
			// 
			this.colKode.FieldName = "Kode";
			this.colKode.Name = "colKode";
			this.colKode.Visible = true;
			this.colKode.VisibleIndex = 0;
			this.colKode.Width = 104;
			// 
			// colKeterangan
			// 
			this.colKeterangan.FieldName = "Keterangan";
			this.colKeterangan.Name = "colKeterangan";
			this.colKeterangan.Visible = true;
			this.colKeterangan.VisibleIndex = 8;
			this.colKeterangan.Width = 42;
			// 
			// colCaraBayar
			// 
			this.colCaraBayar.Caption = "Cara Bayar";
			this.colCaraBayar.FieldName = "CaraBayar.Alias";
			this.colCaraBayar.Name = "colCaraBayar";
			this.colCaraBayar.Visible = true;
			this.colCaraBayar.VisibleIndex = 4;
			this.colCaraBayar.Width = 52;
			// 
			// colRegionalNama
			// 
			this.colRegionalNama.Caption = "Regional";
			this.colRegionalNama.FieldName = "Regional.Nama";
			this.colRegionalNama.Name = "colRegionalNama";
			this.colRegionalNama.Visible = true;
			this.colRegionalNama.VisibleIndex = 7;
			// 
			// colMinggu
			// 
			this.colMinggu.FieldName = "Minggu";
			this.colMinggu.Name = "colMinggu";
			this.colMinggu.Visible = true;
			this.colMinggu.VisibleIndex = 3;
			this.colMinggu.Width = 39;
			// 
			// colDiskon
			// 
			this.colDiskon.Caption = "Diskon";
			this.colDiskon.DisplayFormat.FormatString = "n0";
			this.colDiskon.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.colDiskon.FieldName = "Diskon";
			this.colDiskon.Name = "colDiskon";
			this.colDiskon.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Diskon", "{0:n0}")});
			this.colDiskon.Visible = true;
			this.colDiskon.VisibleIndex = 6;
			this.colDiskon.Width = 76;
			// 
			// colNoGL
			// 
			this.colNoGL.Caption = "Nomor GL";
			this.colNoGL.FieldName = "GLId.Kode";
			this.colNoGL.Name = "colNoGL";
			this.colNoGL.Visible = true;
			this.colNoGL.VisibleIndex = 9;
			// 
			// UI_RincianPembayaran
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(880, 404);
			this.Name = "UI_RincianPembayaran";
			this.Text = "Rincian Pembayaran";
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

		private DevExpress.XtraGrid.Columns.GridColumn colTahun;
		private DevExpress.XtraGrid.Columns.GridColumn colBulan;
		private DevExpress.XtraGrid.Columns.GridColumn colWilayah;
		private DevExpress.XtraGrid.Columns.GridColumn colAgen;
		private DevExpress.XtraGrid.Columns.GridColumn colBayar;
		private DevExpress.XtraGrid.Columns.GridColumn colSetor;
		private DevExpress.XtraGrid.Columns.GridColumn colTanggal;
		private DevExpress.XtraGrid.Columns.GridColumn colKode;
		private DevExpress.XtraGrid.Columns.GridColumn colCaraBayar;
		private DevExpress.XtraGrid.Columns.GridColumn colKeterangan;
		private DevExpress.XtraGrid.Columns.GridColumn colMinggu;
		private DevExpress.XtraGrid.Columns.GridColumn colRegionalNama;
		private DevExpress.XtraGrid.Columns.GridColumn colDiskon;
		private DevExpress.XtraGrid.Columns.GridColumn colNoGL;
	}
}
