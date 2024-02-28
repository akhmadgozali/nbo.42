namespace NuSoft.NUI.Win.Forms.Modules.NuSoft011.UI.Transaksi
{
	partial class UI_Retur
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
			this.colBulan = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colKodeAgen = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colNamaAgen = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colRute = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colJatah = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colKonsi = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colGratis = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colRetur = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colOplah = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colTahun = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colOmzetRetur = new DevExpress.XtraGrid.Columns.GridColumn();
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
			this.xGrid.Size = new System.Drawing.Size(765, 375);
			// 
			// xGridView
			// 
			this.xGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colTahun,
            this.colBulan,
            this.colKodeAgen,
            this.colNamaAgen,
            this.colRute,
            this.colJatah,
            this.colKonsi,
            this.colGratis,
            this.colOplah,
            this.colRetur,
            this.colOmzetRetur,
            this.colId});
			this.xGridView.GroupCount = 3;
			this.xGridView.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Retur", null, " | Retur = {0:n0}"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "OmzetRetur", null, " | Nominal = {0:n0}")});
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
			this.ifSource.DisplayableProperties = "Id;Tanggal;Agen.Rute.KodeNama;Agen.Kode;Agen.Nama;Jatah;Konsi;Gratis;Retur;OmzetJ" +
    "atah;OmzetKonsi;OmzetRetur;Tahun;Oplah;Omzet";
			this.ifSource.ObjectType = typeof(NuSoft.NUI.Win.Forms.Modules.NuSoft011.Persistent.SirkulasiAgen);
			// 
			// barMenu
			// 
			this.barMenu.OptionsBar.AllowQuickCustomization = false;
			this.barMenu.OptionsBar.DrawDragBorder = false;
			this.barMenu.OptionsBar.UseWholeRow = true;
			// 
			// colBulan
			// 
			this.colBulan.Caption = "Bulan";
			this.colBulan.DisplayFormat.FormatString = "MMMM";
			this.colBulan.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
			this.colBulan.FieldName = "Tanggal";
			this.colBulan.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.DisplayText;
			this.colBulan.GroupFormat.FormatString = "MMMM";
			this.colBulan.GroupFormat.FormatType = DevExpress.Utils.FormatType.Custom;
			this.colBulan.Name = "colBulan";
			this.colBulan.Visible = true;
			this.colBulan.VisibleIndex = 0;
			// 
			// colKodeAgen
			// 
			this.colKodeAgen.Caption = "Kode Agen";
			this.colKodeAgen.FieldName = "Agen.Kode";
			this.colKodeAgen.Name = "colKodeAgen";
			this.colKodeAgen.Visible = true;
			this.colKodeAgen.VisibleIndex = 0;
			this.colKodeAgen.Width = 83;
			// 
			// colNamaAgen
			// 
			this.colNamaAgen.Caption = "Nama Agen";
			this.colNamaAgen.FieldName = "Agen.Nama";
			this.colNamaAgen.Name = "colNamaAgen";
			this.colNamaAgen.Visible = true;
			this.colNamaAgen.VisibleIndex = 1;
			this.colNamaAgen.Width = 150;
			// 
			// colRute
			// 
			this.colRute.Caption = "Rute";
			this.colRute.FieldName = "Agen.Rute.KodeNama";
			this.colRute.Name = "colRute";
			this.colRute.Visible = true;
			this.colRute.VisibleIndex = 2;
			// 
			// colJatah
			// 
			this.colJatah.DisplayFormat.FormatString = "n0";
			this.colJatah.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.colJatah.FieldName = "Jatah";
			this.colJatah.Name = "colJatah";
			this.colJatah.Visible = true;
			this.colJatah.VisibleIndex = 2;
			this.colJatah.Width = 68;
			// 
			// colKonsi
			// 
			this.colKonsi.DisplayFormat.FormatString = "n0";
			this.colKonsi.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.colKonsi.FieldName = "Konsi";
			this.colKonsi.Name = "colKonsi";
			this.colKonsi.Visible = true;
			this.colKonsi.VisibleIndex = 3;
			this.colKonsi.Width = 68;
			// 
			// colGratis
			// 
			this.colGratis.DisplayFormat.FormatString = "n0";
			this.colGratis.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.colGratis.FieldName = "Gratis";
			this.colGratis.Name = "colGratis";
			this.colGratis.Visible = true;
			this.colGratis.VisibleIndex = 4;
			this.colGratis.Width = 68;
			// 
			// colRetur
			// 
			this.colRetur.Caption = "Retur";
			this.colRetur.DisplayFormat.FormatString = "n0";
			this.colRetur.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.colRetur.FieldName = "Retur";
			this.colRetur.Name = "colRetur";
			this.colRetur.Visible = true;
			this.colRetur.VisibleIndex = 6;
			this.colRetur.Width = 68;
			// 
			// colOplah
			// 
			this.colOplah.DisplayFormat.FormatString = "n0";
			this.colOplah.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.colOplah.FieldName = "Oplah";
			this.colOplah.Name = "colOplah";
			this.colOplah.Visible = true;
			this.colOplah.VisibleIndex = 5;
			this.colOplah.Width = 92;
			// 
			// colTahun
			// 
			this.colTahun.Caption = "Tahun";
			this.colTahun.FieldName = "Tahun";
			this.colTahun.Name = "colTahun";
			this.colTahun.Visible = true;
			this.colTahun.VisibleIndex = 10;
			// 
			// colOmzetRetur
			// 
			this.colOmzetRetur.Caption = "Nominal";
			this.colOmzetRetur.DisplayFormat.FormatString = "n0";
			this.colOmzetRetur.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.colOmzetRetur.FieldName = "OmzetRetur";
			this.colOmzetRetur.Name = "colOmzetRetur";
			this.colOmzetRetur.Visible = true;
			this.colOmzetRetur.VisibleIndex = 7;
			// 
			// colId
			// 
			this.colId.FieldName = "Id";
			this.colId.Name = "colId";
			// 
			// UI_Retur
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(765, 402);
			this.Name = "UI_Retur";
			this.Text = "Retur Koran";
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

		private DevExpress.XtraGrid.Columns.GridColumn colBulan;
		private DevExpress.XtraGrid.Columns.GridColumn colKodeAgen;
		private DevExpress.XtraGrid.Columns.GridColumn colNamaAgen;
		private DevExpress.XtraGrid.Columns.GridColumn colRute;
		private DevExpress.XtraGrid.Columns.GridColumn colJatah;
		private DevExpress.XtraGrid.Columns.GridColumn colKonsi;
		private DevExpress.XtraGrid.Columns.GridColumn colGratis;
		private DevExpress.XtraGrid.Columns.GridColumn colRetur;
		private DevExpress.XtraGrid.Columns.GridColumn colOplah;
		private DevExpress.XtraGrid.Columns.GridColumn colTahun;
		private DevExpress.XtraGrid.Columns.GridColumn colOmzetRetur;
		private DevExpress.XtraGrid.Columns.GridColumn colId;
	}
}
