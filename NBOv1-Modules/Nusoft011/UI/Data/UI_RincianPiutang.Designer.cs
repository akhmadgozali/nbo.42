namespace NuSoft.NUI.Win.Forms.Modules.NuSoft011.UI.Data
{
	partial class UI_RincianPiutang
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
			this.colWilayah = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colNamaAgen = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colSaldoAwal = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colOmzet = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colRetur = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colPembayaran = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colSaldoAkhir = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colUmurPiutang = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colRegional = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colStatus = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colAktif = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colKodeAgen = new DevExpress.XtraGrid.Columns.GridColumn();
			this.barPeriode = new DevExpress.XtraBars.BarEditItem();
			this.txtPeriode1 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
			((System.ComponentModel.ISupportInitialize)(this.barMan)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.xpCol)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.session)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.popMenu)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.xGrid)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.xGridView)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.SplitContainerControl1)).BeginInit();
			this.SplitContainerControl1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.chartPopUp)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtPeriode1)).BeginInit();
			this.SuspendLayout();
			// 
			// barMan
			// 
			this.barMan.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barPeriode});
			this.barMan.MaxItemId = 23;
			this.barMan.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.txtPeriode1});
			// 
			// xGrid
			// 
			this.xGrid.Size = new System.Drawing.Size(880, 238);
			// 
			// xGridView
			// 
			this.xGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colStatus,
            this.colRegional,
            this.colWilayah,
            this.colKodeAgen,
            this.colNamaAgen,
            this.colSaldoAwal,
            this.colOmzet,
            this.colRetur,
            this.colPembayaran,
            this.colSaldoAkhir,
            this.colUmurPiutang,
            this.colAktif});
			this.xGridView.GroupCount = 3;
			this.xGridView.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "SaldoAkhir", null, "| Saldo Akhir : {0:n0}")});
			this.xGridView.OptionsBehavior.Editable = false;
			this.xGridView.OptionsDetail.EnableMasterViewMode = false;
			this.xGridView.OptionsSelection.MultiSelect = true;
			this.xGridView.OptionsView.ShowAutoFilterRow = true;
			this.xGridView.OptionsView.ShowFooter = true;
			this.xGridView.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colStatus, DevExpress.Data.ColumnSortOrder.Ascending),
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colRegional, DevExpress.Data.ColumnSortOrder.Ascending),
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colWilayah, DevExpress.Data.ColumnSortOrder.Ascending)});
			// 
			// barMenu
			// 
			this.barMenu.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barPeriode, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.Caption)});
			this.barMenu.OptionsBar.AllowQuickCustomization = false;
			this.barMenu.OptionsBar.DrawDragBorder = false;
			this.barMenu.OptionsBar.UseWholeRow = true;
			// 
			// SplitContainerControl1
			// 
			this.SplitContainerControl1.Size = new System.Drawing.Size(880, 336);
			this.SplitContainerControl1.SplitterPosition = 238;
			// 
			// colWilayah
			// 
			this.colWilayah.Caption = "Rute";
			this.colWilayah.FieldName = "Agen.Rute.KodeNama";
			this.colWilayah.Name = "colWilayah";
			this.colWilayah.Visible = true;
			this.colWilayah.VisibleIndex = 0;
			// 
			// colNamaAgen
			// 
			this.colNamaAgen.Caption = "Nama Agen";
			this.colNamaAgen.FieldName = "Agen.Nama";
			this.colNamaAgen.Name = "colNamaAgen";
			this.colNamaAgen.Visible = true;
			this.colNamaAgen.VisibleIndex = 1;
			this.colNamaAgen.Width = 116;
			// 
			// colSaldoAwal
			// 
			this.colSaldoAwal.Caption = "Saldo Awal";
			this.colSaldoAwal.DisplayFormat.FormatString = "n0";
			this.colSaldoAwal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.colSaldoAwal.FieldName = "SaldoAwal";
			this.colSaldoAwal.Name = "colSaldoAwal";
			this.colSaldoAwal.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "SaldoAwal", "{0:n0}")});
			this.colSaldoAwal.Visible = true;
			this.colSaldoAwal.VisibleIndex = 2;
			this.colSaldoAwal.Width = 68;
			// 
			// colOmzet
			// 
			this.colOmzet.Caption = "Omzet";
			this.colOmzet.DisplayFormat.FormatString = "n0";
			this.colOmzet.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.colOmzet.FieldName = "Omzet";
			this.colOmzet.Name = "colOmzet";
			this.colOmzet.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Omzet", "{0:n0}")});
			this.colOmzet.Visible = true;
			this.colOmzet.VisibleIndex = 3;
			this.colOmzet.Width = 68;
			// 
			// colRetur
			// 
			this.colRetur.Caption = "Retur";
			this.colRetur.DisplayFormat.FormatString = "n0";
			this.colRetur.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.colRetur.FieldName = "ReturOmzet";
			this.colRetur.Name = "colRetur";
			this.colRetur.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "ReturOmzet", "{0:n0}")});
			this.colRetur.Visible = true;
			this.colRetur.VisibleIndex = 4;
			this.colRetur.Width = 68;
			// 
			// colPembayaran
			// 
			this.colPembayaran.Caption = "Pembayaran";
			this.colPembayaran.DisplayFormat.FormatString = "n0";
			this.colPembayaran.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.colPembayaran.FieldName = "Pembayaran";
			this.colPembayaran.Name = "colPembayaran";
			this.colPembayaran.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Pembayaran", "{0:n0}")});
			this.colPembayaran.Visible = true;
			this.colPembayaran.VisibleIndex = 5;
			this.colPembayaran.Width = 68;
			// 
			// colSaldoAkhir
			// 
			this.colSaldoAkhir.Caption = "Saldo Akhir";
			this.colSaldoAkhir.DisplayFormat.FormatString = "n0";
			this.colSaldoAkhir.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.colSaldoAkhir.FieldName = "SaldoAkhir";
			this.colSaldoAkhir.Name = "colSaldoAkhir";
			this.colSaldoAkhir.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "SaldoAkhir", "{0:n0}")});
			this.colSaldoAkhir.Visible = true;
			this.colSaldoAkhir.VisibleIndex = 6;
			// 
			// colUmurPiutang
			// 
			this.colUmurPiutang.Caption = "Umur";
			this.colUmurPiutang.DisplayFormat.FormatString = "n0";
			this.colUmurPiutang.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.colUmurPiutang.FieldName = "UmurPiutang";
			this.colUmurPiutang.Name = "colUmurPiutang";
			this.colUmurPiutang.Visible = true;
			this.colUmurPiutang.VisibleIndex = 7;
			this.colUmurPiutang.Width = 43;
			// 
			// colRegional
			// 
			this.colRegional.Caption = "Regional";
			this.colRegional.FieldName = "Agen.Rute.Regional.Nama";
			this.colRegional.Name = "colRegional";
			this.colRegional.Visible = true;
			this.colRegional.VisibleIndex = 9;
			// 
			// colStatus
			// 
			this.colStatus.Caption = "Status";
			this.colStatus.FieldName = "colStatus";
			this.colStatus.Name = "colStatus";
			this.colStatus.UnboundExpression = "Iif([Agen.Aktif] = True, \'Aktif\', \'Non Aktif\')";
			this.colStatus.UnboundType = DevExpress.Data.UnboundColumnType.String;
			this.colStatus.Visible = true;
			this.colStatus.VisibleIndex = 9;
			// 
			// colAktif
			// 
			this.colAktif.Caption = "Aktif";
			this.colAktif.FieldName = "Agen.Aktif";
			this.colAktif.Name = "colAktif";
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
			// barPeriode
			// 
			this.barPeriode.Caption = "Periode   ";
			this.barPeriode.Edit = this.txtPeriode1;
			this.barPeriode.Id = 22;
			this.barPeriode.Name = "barPeriode";
			this.barPeriode.Width = 200;
			// 
			// txtPeriode1
			// 
			this.txtPeriode1.AutoHeight = false;
			this.txtPeriode1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.txtPeriode1.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Value", "Periode")});
			this.txtPeriode1.DisplayMember = "Value";
			this.txtPeriode1.Name = "txtPeriode1";
			this.txtPeriode1.NullText = "[ Pilih Periode ]";
			this.txtPeriode1.ShowHeader = false;
			this.txtPeriode1.ValueMember = "Key";
			// 
			// UI_RincianPiutang
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(880, 363);
			this.Name = "UI_RincianPiutang";
			this.Text = "Rincian Piutang";
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
			((System.ComponentModel.ISupportInitialize)(this.txtPeriode1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion
		private DevExpress.XtraGrid.Columns.GridColumn colWilayah;
		private DevExpress.XtraGrid.Columns.GridColumn colNamaAgen;
		private DevExpress.XtraGrid.Columns.GridColumn colSaldoAwal;
		private DevExpress.XtraGrid.Columns.GridColumn colOmzet;
		private DevExpress.XtraGrid.Columns.GridColumn colRetur;
		private DevExpress.XtraGrid.Columns.GridColumn colPembayaran;
		private DevExpress.XtraGrid.Columns.GridColumn colSaldoAkhir;
		private DevExpress.XtraGrid.Columns.GridColumn colUmurPiutang;
		private DevExpress.XtraGrid.Columns.GridColumn colRegional;
		private DevExpress.XtraGrid.Columns.GridColumn colStatus;
		private DevExpress.XtraGrid.Columns.GridColumn colAktif;
		private DevExpress.XtraGrid.Columns.GridColumn colKodeAgen;
		private DevExpress.XtraBars.BarEditItem barPeriode;
		private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit txtPeriode1;
	}
}
