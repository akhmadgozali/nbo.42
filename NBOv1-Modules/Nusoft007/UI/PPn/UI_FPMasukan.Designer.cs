namespace NuSoft.NUI.Win.Forms.Modules.NuSoft007.UI.PPn
{
	partial class UI_FPMasukan
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
			this.colNoSeri = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colTanggal = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colPelangganNama = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colPelangganNPWP = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colIsKredit = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colModuleId = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colTahun = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colBulan = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colDpp = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colPPn = new DevExpress.XtraGrid.Columns.GridColumn();
			this.collast_modified = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colPPnBM = new DevExpress.XtraGrid.Columns.GridColumn();
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
			this.xGrid.Size = new System.Drawing.Size(945, 332);
			// 
			// xGridView
			// 
			this.xGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colTahun,
            this.colBulan,
            this.colNoSeri,
            this.colTanggal,
            this.colPelangganNama,
            this.colPelangganNPWP,
            this.colIsKredit,
            this.colDpp,
            this.colPPn,
            this.colPPnBM,
            this.colModuleId,
            this.collast_modified,
            this.colId});
			this.xGridView.GroupCount = 2;
			this.xGridView.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Dpp", null, "[Dpp = {0:n0}]"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "PPn", null, "[PPn = {0:n0}]"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "PPnBM", null, "[PPnBM = {0:n0}]"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "NoSeri", null, "[Jumlah FP = {0:n0}]")});
			this.xGridView.OptionsBehavior.Editable = false;
			this.xGridView.OptionsDetail.EnableMasterViewMode = false;
			this.xGridView.OptionsSelection.MultiSelect = true;
			this.xGridView.OptionsView.ShowAutoFilterRow = true;
			this.xGridView.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colTahun, DevExpress.Data.ColumnSortOrder.Descending),
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colBulan, DevExpress.Data.ColumnSortOrder.Descending)});
			// 
			// ifSource
			// 
			this.ifSource.DisplayableProperties = "last_modified;Id;NomorFaktur;SupplierNama;SupplierNPWP;Tanggal;MasaPajak;TahunPaj" +
    "ak;IsKredit;Dpp;PPn;PPnBM;Keterangan;ModuleId;Bulan";
			this.ifSource.ObjectType = typeof(NuSoft.NUI.Win.Forms.Modules.NuSoft007.Persistent.PPnMasukan);
			// 
			// barMenu
			// 
			this.barMenu.OptionsBar.AllowQuickCustomization = false;
			this.barMenu.OptionsBar.DrawDragBorder = false;
			this.barMenu.OptionsBar.UseWholeRow = true;
			// 
			// colNoSeri
			// 
			this.colNoSeri.FieldName = "NomorFaktur";
			this.colNoSeri.Name = "colNoSeri";
			this.colNoSeri.Visible = true;
			this.colNoSeri.VisibleIndex = 0;
			this.colNoSeri.Width = 110;
			// 
			// colTanggal
			// 
			this.colTanggal.DisplayFormat.FormatString = "dd MMM yyyy";
			this.colTanggal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
			this.colTanggal.FieldName = "Tanggal";
			this.colTanggal.Name = "colTanggal";
			this.colTanggal.Visible = true;
			this.colTanggal.VisibleIndex = 1;
			this.colTanggal.Width = 77;
			// 
			// colPelangganNama
			// 
			this.colPelangganNama.Caption = "Nama Supplier";
			this.colPelangganNama.FieldName = "SupplierNama";
			this.colPelangganNama.Name = "colPelangganNama";
			this.colPelangganNama.Visible = true;
			this.colPelangganNama.VisibleIndex = 2;
			this.colPelangganNama.Width = 190;
			// 
			// colPelangganNPWP
			// 
			this.colPelangganNPWP.Caption = "NPWP Supplier";
			this.colPelangganNPWP.FieldName = "SupplierNPWP";
			this.colPelangganNPWP.Name = "colPelangganNPWP";
			this.colPelangganNPWP.Visible = true;
			this.colPelangganNPWP.VisibleIndex = 3;
			this.colPelangganNPWP.Width = 100;
			// 
			// colIsKredit
			// 
			this.colIsKredit.Caption = "Dikreditkan";
			this.colIsKredit.FieldName = "IsKredit";
			this.colIsKredit.Name = "colIsKredit";
			this.colIsKredit.Visible = true;
			this.colIsKredit.VisibleIndex = 4;
			this.colIsKredit.Width = 65;
			// 
			// colModuleId
			// 
			this.colModuleId.FieldName = "ModuleId";
			this.colModuleId.Name = "colModuleId";
			this.colModuleId.Visible = true;
			this.colModuleId.VisibleIndex = 8;
			this.colModuleId.Width = 57;
			// 
			// colTahun
			// 
			this.colTahun.Caption = "Tahun";
			this.colTahun.FieldName = "TahunPajak";
			this.colTahun.Name = "colTahun";
			this.colTahun.Visible = true;
			this.colTahun.VisibleIndex = 7;
			// 
			// colBulan
			// 
			this.colBulan.Caption = "Bulan";
			this.colBulan.DisplayFormat.FormatString = "MMMM";
			this.colBulan.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
			this.colBulan.FieldName = "Bulan";
			this.colBulan.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.DisplayText;
			this.colBulan.GroupFormat.FormatString = "MMMM";
			this.colBulan.GroupFormat.FormatType = DevExpress.Utils.FormatType.Custom;
			this.colBulan.Name = "colBulan";
			this.colBulan.Visible = true;
			this.colBulan.VisibleIndex = 7;
			// 
			// colDpp
			// 
			this.colDpp.Caption = "Dpp";
			this.colDpp.DisplayFormat.FormatString = "n0";
			this.colDpp.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.colDpp.FieldName = "Dpp";
			this.colDpp.Name = "colDpp";
			this.colDpp.Visible = true;
			this.colDpp.VisibleIndex = 5;
			this.colDpp.Width = 70;
			// 
			// colPPn
			// 
			this.colPPn.Caption = "PPn";
			this.colPPn.DisplayFormat.FormatString = "n0";
			this.colPPn.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.colPPn.FieldName = "PPn";
			this.colPPn.Name = "colPPn";
			this.colPPn.Visible = true;
			this.colPPn.VisibleIndex = 6;
			this.colPPn.Width = 70;
			// 
			// collast_modified
			// 
			this.collast_modified.Caption = "Last Modified";
			this.collast_modified.FieldName = "last_modified";
			this.collast_modified.Name = "collast_modified";
			this.collast_modified.Visible = true;
			this.collast_modified.VisibleIndex = 9;
			this.collast_modified.Width = 128;
			// 
			// colPPnBM
			// 
			this.colPPnBM.DisplayFormat.FormatString = "n0";
			this.colPPnBM.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.colPPnBM.FieldName = "PPnBM";
			this.colPPnBM.Name = "colPPnBM";
			this.colPPnBM.Visible = true;
			this.colPPnBM.VisibleIndex = 7;
			this.colPPnBM.Width = 70;
			// 
			// colId
			// 
			this.colId.FieldName = "Id";
			this.colId.Name = "colId";
			// 
			// UI_FPMasukan
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(945, 359);
			this.Name = "UI_FPMasukan";
			this.Text = "PPn Masukan";
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
		private DevExpress.XtraGrid.Columns.GridColumn colNoSeri;
		private DevExpress.XtraGrid.Columns.GridColumn colTanggal;
		private DevExpress.XtraGrid.Columns.GridColumn colPelangganNama;
		private DevExpress.XtraGrid.Columns.GridColumn colPelangganNPWP;
		private DevExpress.XtraGrid.Columns.GridColumn colIsKredit;
		private DevExpress.XtraGrid.Columns.GridColumn colDpp;
		private DevExpress.XtraGrid.Columns.GridColumn colPPn;
		private DevExpress.XtraGrid.Columns.GridColumn colModuleId;
		private DevExpress.XtraGrid.Columns.GridColumn collast_modified;
		private DevExpress.XtraGrid.Columns.GridColumn colPPnBM;
		private DevExpress.XtraGrid.Columns.GridColumn colId;
	}
}
