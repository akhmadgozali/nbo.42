namespace NuSoft.NUI.Win.Forms.Modules.NuSoft007.UI.PPn
{
	partial class UI_FPKeluaran
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UI_FPKeluaran));
			this.colNoSeri = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colTanggal = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colPelangganNama = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colPelangganNPWP = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colNoInvoice = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colModuleId = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colStatus = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colTahun = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colBulan = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colDpp = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colPPn = new DevExpress.XtraGrid.Columns.GridColumn();
			this.collast_modified = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colNomor = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
			this.btnUpdateStatus = new DevExpress.XtraBars.BarSubItem();
			this.btnStatusValid = new DevExpress.XtraBars.BarButtonItem();
			this.btnStatusEksporCSV = new DevExpress.XtraBars.BarButtonItem();
			this.btnStatusApproval = new DevExpress.XtraBars.BarButtonItem();
			this.btnStatusFPPengganti = new DevExpress.XtraBars.BarButtonItem();
			this.btnStatusFPBatal = new DevExpress.XtraBars.BarButtonItem();
			this.btnStatusEdit = new DevExpress.XtraBars.BarButtonItem();
			this.btnPDF = new DevExpress.XtraBars.BarButtonItem();
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
            this.btnUpdateStatus,
            this.btnStatusValid,
            this.btnStatusEksporCSV,
            this.btnStatusApproval,
            this.btnStatusFPPengganti,
            this.btnStatusFPBatal,
            this.btnStatusEdit,
            this.btnPDF});
			this.barMan.MaxItemId = 21;
			// 
			// xGridView
			// 
			this.xGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colTahun,
            this.colBulan,
            this.colNoSeri,
            this.colNomor,
            this.colTanggal,
            this.colPelangganNama,
            this.colPelangganNPWP,
            this.colNoInvoice,
            this.colDpp,
            this.colPPn,
            this.colModuleId,
            this.colStatus,
            this.collast_modified,
            this.colId});
			this.xGridView.GroupCount = 2;
			this.xGridView.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "DppCustom", null, "[Dpp = {0:n0}]"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "PPnNominalCustom", null, "[PPn = {0:n0}]"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "NomorSeri", null, "[Jumlah FP = {0:n0}]")});
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
			this.ifSource.DisplayableProperties = "Id;NomorSeri;Tanggal;NamaPelanggan;NPWPPelanggan;NomorInvoice;PPnPersen;PPnNomina" +
    "l;ModuleId;StatusFaktur;Tahun;Bulan;Dpp;NoSeriLengkap;last_modified;KodePajak;No" +
    "morSeriValid;DppCustom;PPnNominalCustom";
			this.ifSource.ObjectType = typeof(NuSoft.NUI.Win.Forms.Modules.NuSoft007.Persistent.PPnKeluaran);
			// 
			// barMenu
			// 
			this.barMenu.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnUpdateStatus, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnPDF, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
			this.barMenu.OptionsBar.AllowQuickCustomization = false;
			this.barMenu.OptionsBar.DrawDragBorder = false;
			this.barMenu.OptionsBar.UseWholeRow = true;
			// 
			// colNoSeri
			// 
			this.colNoSeri.Caption = "Kode";
			this.colNoSeri.FieldName = "KodePajak";
			this.colNoSeri.Name = "colNoSeri";
			this.colNoSeri.Visible = true;
			this.colNoSeri.VisibleIndex = 0;
			this.colNoSeri.Width = 95;
			// 
			// colTanggal
			// 
			this.colTanggal.DisplayFormat.FormatString = "dd MMM yyyy";
			this.colTanggal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
			this.colTanggal.FieldName = "Tanggal";
			this.colTanggal.Name = "colTanggal";
			this.colTanggal.Visible = true;
			this.colTanggal.VisibleIndex = 2;
			this.colTanggal.Width = 65;
			// 
			// colPelangganNama
			// 
			this.colPelangganNama.Caption = "Nama Pelanggan";
			this.colPelangganNama.FieldName = "NamaPelanggan";
			this.colPelangganNama.Name = "colPelangganNama";
			this.colPelangganNama.Visible = true;
			this.colPelangganNama.VisibleIndex = 3;
			this.colPelangganNama.Width = 181;
			// 
			// colPelangganNPWP
			// 
			this.colPelangganNPWP.Caption = "NPWP Pelanggan";
			this.colPelangganNPWP.FieldName = "NPWPPelanggan";
			this.colPelangganNPWP.Name = "colPelangganNPWP";
			this.colPelangganNPWP.Visible = true;
			this.colPelangganNPWP.VisibleIndex = 4;
			this.colPelangganNPWP.Width = 81;
			// 
			// colNoInvoice
			// 
			this.colNoInvoice.FieldName = "NomorInvoice";
			this.colNoInvoice.Name = "colNoInvoice";
			this.colNoInvoice.Visible = true;
			this.colNoInvoice.VisibleIndex = 5;
			this.colNoInvoice.Width = 81;
			// 
			// colModuleId
			// 
			this.colModuleId.FieldName = "ModuleId";
			this.colModuleId.Name = "colModuleId";
			this.colModuleId.Visible = true;
			this.colModuleId.VisibleIndex = 8;
			this.colModuleId.Width = 58;
			// 
			// colStatus
			// 
			this.colStatus.Caption = "Status";
			this.colStatus.FieldName = "StatusFaktur";
			this.colStatus.Name = "colStatus";
			this.colStatus.Visible = true;
			this.colStatus.VisibleIndex = 9;
			this.colStatus.Width = 58;
			// 
			// colTahun
			// 
			this.colTahun.FieldName = "Tahun";
			this.colTahun.Name = "colTahun";
			this.colTahun.Visible = true;
			this.colTahun.VisibleIndex = 7;
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
			this.colBulan.VisibleIndex = 7;
			// 
			// colDpp
			// 
			this.colDpp.DisplayFormat.FormatString = "n0";
			this.colDpp.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.colDpp.FieldName = "Dpp";
			this.colDpp.Name = "colDpp";
			this.colDpp.Visible = true;
			this.colDpp.VisibleIndex = 6;
			this.colDpp.Width = 72;
			// 
			// colPPn
			// 
			this.colPPn.Caption = "PPn";
			this.colPPn.DisplayFormat.FormatString = "n0";
			this.colPPn.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.colPPn.FieldName = "PPnNominal";
			this.colPPn.Name = "colPPn";
			this.colPPn.Visible = true;
			this.colPPn.VisibleIndex = 7;
			this.colPPn.Width = 72;
			// 
			// collast_modified
			// 
			this.collast_modified.Caption = "Last Modified";
			this.collast_modified.FieldName = "last_modified";
			this.collast_modified.Name = "collast_modified";
			this.collast_modified.Visible = true;
			this.collast_modified.VisibleIndex = 10;
			this.collast_modified.Width = 80;
			// 
			// colNomor
			// 
			this.colNomor.Caption = "Nomor Seri";
			this.colNomor.FieldName = "NomorSeri";
			this.colNomor.Name = "colNomor";
			this.colNomor.Visible = true;
			this.colNomor.VisibleIndex = 1;
			this.colNomor.Width = 70;
			// 
			// colId
			// 
			this.colId.FieldName = "Id";
			this.colId.Name = "colId";
			// 
			// btnUpdateStatus
			// 
			this.btnUpdateStatus.Caption = "Update Status";
			this.btnUpdateStatus.Glyph = ((System.Drawing.Image)(resources.GetObject("btnUpdateStatus.Glyph")));
			this.btnUpdateStatus.Id = 13;
			this.btnUpdateStatus.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnUpdateStatus.LargeGlyph")));
			this.btnUpdateStatus.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnStatusValid),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnStatusEksporCSV),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnStatusApproval),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnStatusFPPengganti),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnStatusFPBatal),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnStatusEdit)});
			this.btnUpdateStatus.Name = "btnUpdateStatus";
			// 
			// btnStatusValid
			// 
			this.btnStatusValid.Caption = "Valid";
			this.btnStatusValid.Glyph = ((System.Drawing.Image)(resources.GetObject("btnStatusValid.Glyph")));
			this.btnStatusValid.Id = 14;
			this.btnStatusValid.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnStatusValid.LargeGlyph")));
			this.btnStatusValid.Name = "btnStatusValid";
			// 
			// btnStatusEksporCSV
			// 
			this.btnStatusEksporCSV.Caption = "Ekspor CSV";
			this.btnStatusEksporCSV.Glyph = ((System.Drawing.Image)(resources.GetObject("btnStatusEksporCSV.Glyph")));
			this.btnStatusEksporCSV.Id = 15;
			this.btnStatusEksporCSV.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnStatusEksporCSV.LargeGlyph")));
			this.btnStatusEksporCSV.Name = "btnStatusEksporCSV";
			// 
			// btnStatusApproval
			// 
			this.btnStatusApproval.Caption = "Approval";
			this.btnStatusApproval.Glyph = ((System.Drawing.Image)(resources.GetObject("btnStatusApproval.Glyph")));
			this.btnStatusApproval.Id = 16;
			this.btnStatusApproval.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnStatusApproval.LargeGlyph")));
			this.btnStatusApproval.Name = "btnStatusApproval";
			// 
			// btnStatusFPPengganti
			// 
			this.btnStatusFPPengganti.Caption = "FP Pengganti";
			this.btnStatusFPPengganti.Glyph = ((System.Drawing.Image)(resources.GetObject("btnStatusFPPengganti.Glyph")));
			this.btnStatusFPPengganti.Id = 17;
			this.btnStatusFPPengganti.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnStatusFPPengganti.LargeGlyph")));
			this.btnStatusFPPengganti.Name = "btnStatusFPPengganti";
			// 
			// btnStatusFPBatal
			// 
			this.btnStatusFPBatal.Caption = "FP Batal";
			this.btnStatusFPBatal.Glyph = ((System.Drawing.Image)(resources.GetObject("btnStatusFPBatal.Glyph")));
			this.btnStatusFPBatal.Id = 18;
			this.btnStatusFPBatal.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnStatusFPBatal.LargeGlyph")));
			this.btnStatusFPBatal.Name = "btnStatusFPBatal";
			// 
			// btnStatusEdit
			// 
			this.btnStatusEdit.Caption = "Edit";
			this.btnStatusEdit.Glyph = ((System.Drawing.Image)(resources.GetObject("btnStatusEdit.Glyph")));
			this.btnStatusEdit.Id = 19;
			this.btnStatusEdit.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnStatusEdit.LargeGlyph")));
			this.btnStatusEdit.Name = "btnStatusEdit";
			// 
			// btnPDF
			// 
			this.btnPDF.Caption = "PDF";
			this.btnPDF.Glyph = ((System.Drawing.Image)(resources.GetObject("btnPDF.Glyph")));
			this.btnPDF.Id = 20;
			this.btnPDF.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnPDF.LargeGlyph")));
			this.btnPDF.Name = "btnPDF";
			// 
			// UI_FPKeluaran
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(945, 359);
			this.Name = "UI_FPKeluaran";
			this.Text = "PPn Keluaran";
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
		private DevExpress.XtraGrid.Columns.GridColumn colNoInvoice;
		private DevExpress.XtraGrid.Columns.GridColumn colDpp;
		private DevExpress.XtraGrid.Columns.GridColumn colPPn;
		private DevExpress.XtraGrid.Columns.GridColumn colModuleId;
		private DevExpress.XtraGrid.Columns.GridColumn colStatus;
		private DevExpress.XtraGrid.Columns.GridColumn collast_modified;
		private DevExpress.XtraGrid.Columns.GridColumn colNomor;
		private DevExpress.XtraGrid.Columns.GridColumn colId;
		private DevExpress.XtraBars.BarSubItem btnUpdateStatus;
		private DevExpress.XtraBars.BarButtonItem btnStatusValid;
		private DevExpress.XtraBars.BarButtonItem btnStatusEksporCSV;
		private DevExpress.XtraBars.BarButtonItem btnStatusApproval;
		private DevExpress.XtraBars.BarButtonItem btnStatusFPPengganti;
		private DevExpress.XtraBars.BarButtonItem btnStatusFPBatal;
		private DevExpress.XtraBars.BarButtonItem btnStatusEdit;
		private DevExpress.XtraBars.BarButtonItem btnPDF;
	}
}
