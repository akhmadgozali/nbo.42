namespace NuSoft.NUI.Win.Forms.Modules.NuSoft011.UI.Transaksi
{
	partial class UI_BatalBayar
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
			this.colKode = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colAgen = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colRute = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colCaraBayar = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colTanggal = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colNominal = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colKeterangan = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colGL = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colTahun = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colBulan = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colKoreksi = new DevExpress.XtraGrid.Columns.GridColumn();
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
			// 
			// xGridView
			// 
			this.xGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colTahun,
            this.colBulan,
            this.colRute,
            this.colKode,
            this.colTanggal,
            this.colAgen,
            this.colCaraBayar,
            this.colKoreksi,
            this.colNominal,
            this.colKeterangan,
            this.colGL,
            this.colId});
			this.xGridView.GroupCount = 3;
			this.xGridView.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Nominal", null, " | Jumlah = {0:n0}")});
			this.xGridView.OptionsBehavior.Editable = false;
			this.xGridView.OptionsDetail.EnableMasterViewMode = false;
			this.xGridView.OptionsSelection.MultiSelect = true;
			this.xGridView.OptionsView.ShowAutoFilterRow = true;
			this.xGridView.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colTahun, DevExpress.Data.ColumnSortOrder.Descending),
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colBulan, DevExpress.Data.ColumnSortOrder.Descending),
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colRute, DevExpress.Data.ColumnSortOrder.Ascending)});
			// 
			// ifSource
			// 
			this.ifSource.DisplayableProperties = "Kode;Agen.Nama;Agen.Rute.KodeNama;CaraBayar.Alias;Tanggal;TotalBayar;Keterangan;G" +
    "LId.Kode;BatalBayarId!;Tahun;Bulan;BatalBayarId.Kode;Id";
			this.ifSource.FixedFilterString = "Not IsNullOrEmpty([BatalBayarId!])";
			this.ifSource.ObjectType = typeof(NuSoft.NUI.Win.Forms.Modules.NuSoft011.Persistent.BayarKoran);
			// 
			// barMenu
			// 
			this.barMenu.OptionsBar.AllowQuickCustomization = false;
			this.barMenu.OptionsBar.DrawDragBorder = false;
			this.barMenu.OptionsBar.UseWholeRow = true;
			// 
			// colKode
			// 
			this.colKode.Caption = "No. Pembatalan";
			this.colKode.FieldName = "Kode";
			this.colKode.Name = "colKode";
			this.colKode.Visible = true;
			this.colKode.VisibleIndex = 0;
			this.colKode.Width = 83;
			// 
			// colAgen
			// 
			this.colAgen.Caption = "Agen";
			this.colAgen.FieldName = "Agen.Nama";
			this.colAgen.Name = "colAgen";
			this.colAgen.Visible = true;
			this.colAgen.VisibleIndex = 2;
			this.colAgen.Width = 98;
			// 
			// colRute
			// 
			this.colRute.Caption = "Rute";
			this.colRute.FieldName = "Agen.Rute.KodeNama";
			this.colRute.Name = "colRute";
			this.colRute.Visible = true;
			this.colRute.VisibleIndex = 2;
			// 
			// colCaraBayar
			// 
			this.colCaraBayar.Caption = "Cara Bayar";
			this.colCaraBayar.FieldName = "CaraBayar.Alias";
			this.colCaraBayar.Name = "colCaraBayar";
			this.colCaraBayar.Visible = true;
			this.colCaraBayar.VisibleIndex = 3;
			this.colCaraBayar.Width = 80;
			// 
			// colTanggal
			// 
			this.colTanggal.DisplayFormat.FormatString = "dd MMM yyyy";
			this.colTanggal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
			this.colTanggal.FieldName = "Tanggal";
			this.colTanggal.Name = "colTanggal";
			this.colTanggal.Visible = true;
			this.colTanggal.VisibleIndex = 1;
			this.colTanggal.Width = 53;
			// 
			// colNominal
			// 
			this.colNominal.DisplayFormat.FormatString = "n0";
			this.colNominal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.colNominal.FieldName = "TotalBayar";
			this.colNominal.Name = "colNominal";
			this.colNominal.Visible = true;
			this.colNominal.VisibleIndex = 5;
			this.colNominal.Width = 69;
			// 
			// colKeterangan
			// 
			this.colKeterangan.FieldName = "Keterangan";
			this.colKeterangan.Name = "colKeterangan";
			this.colKeterangan.Visible = true;
			this.colKeterangan.VisibleIndex = 6;
			this.colKeterangan.Width = 156;
			// 
			// colGL
			// 
			this.colGL.Caption = "No. GL";
			this.colGL.FieldName = "GLId.Kode";
			this.colGL.Name = "colGL";
			this.colGL.Visible = true;
			this.colGL.VisibleIndex = 7;
			this.colGL.Width = 36;
			// 
			// colTahun
			// 
			this.colTahun.FieldName = "Tahun";
			this.colTahun.Name = "colTahun";
			this.colTahun.Visible = true;
			this.colTahun.VisibleIndex = 9;
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
			this.colBulan.VisibleIndex = 9;
			// 
			// colKoreksi
			// 
			this.colKoreksi.Caption = "No. Kwitansi";
			this.colKoreksi.FieldName = "BatalBayarId.Kode";
			this.colKoreksi.Name = "colKoreksi";
			this.colKoreksi.Visible = true;
			this.colKoreksi.VisibleIndex = 4;
			this.colKoreksi.Width = 90;
			// 
			// colId
			// 
			this.colId.FieldName = "Id";
			this.colId.Name = "colId";
			// 
			// UI_BatalBayar
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(759, 395);
			this.Name = "UI_BatalBayar";
			this.Text = "Batal Bayar";
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
		private DevExpress.XtraGrid.Columns.GridColumn colRute;
		private DevExpress.XtraGrid.Columns.GridColumn colKode;
		private DevExpress.XtraGrid.Columns.GridColumn colTanggal;
		private DevExpress.XtraGrid.Columns.GridColumn colAgen;
		private DevExpress.XtraGrid.Columns.GridColumn colCaraBayar;
		private DevExpress.XtraGrid.Columns.GridColumn colNominal;
		private DevExpress.XtraGrid.Columns.GridColumn colKeterangan;
		private DevExpress.XtraGrid.Columns.GridColumn colGL;
		private DevExpress.XtraGrid.Columns.GridColumn colKoreksi;
		private DevExpress.XtraGrid.Columns.GridColumn colId;
	}
}
