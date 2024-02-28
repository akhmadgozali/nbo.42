namespace NuSoft.NUI.Win.Forms.Modules.NuSoft012.UI.DataCashback
{
	partial class UI_RincianHutangCashback
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
			this.colNoInvoice = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colTanggal = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colRegional = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colWilayah = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colPemasang = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colSales = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colTipeInvoice = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colKomisiCashback = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colTerbayar = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colTahun = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colBulan = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colHutang = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colKeteranganIklan = new DevExpress.XtraGrid.Columns.GridColumn();
			this.barEditItem1 = new DevExpress.XtraBars.BarEditItem();
			this.repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
			this.txtPeriodeEdit = new DevExpress.XtraBars.BarEditItem();
			this.txtPeriode = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
			this.txtTampilkanSaldo0Edit = new DevExpress.XtraBars.BarEditItem();
			this.txtTampilkanSaldo0 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
			this.colNoKwitansi = new DevExpress.XtraGrid.Columns.GridColumn();
			((System.ComponentModel.ISupportInitialize)(this.barMan)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.xpCol)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.session)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.popMenu)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.xGrid)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.xGridView)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.SplitContainerControl1)).BeginInit();
			this.SplitContainerControl1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.chartPopUp)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtPeriode)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtTampilkanSaldo0)).BeginInit();
			this.SuspendLayout();
			// 
			// barMan
			// 
			this.barMan.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barEditItem1,
            this.txtPeriodeEdit,
            this.txtTampilkanSaldo0Edit});
			this.barMan.MaxItemId = 25;
			this.barMan.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemTextEdit1,
            this.txtPeriode,
            this.txtTampilkanSaldo0});
			// 
			// xGridView
			// 
			this.xGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colTahun,
            this.colBulan,
            this.colNoInvoice,
            this.colNoKwitansi,
            this.colTanggal,
            this.colRegional,
            this.colWilayah,
            this.colTipeInvoice,
            this.colSales,
            this.colPemasang,
            this.colKomisiCashback,
            this.colTerbayar,
            this.colHutang,
            this.colKeteranganIklan});
			this.xGridView.GroupCount = 2;
			this.xGridView.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Hutang", null, "| Hutang : {0:n0}")});
			this.xGridView.OptionsBehavior.Editable = false;
			this.xGridView.OptionsDetail.EnableMasterViewMode = false;
			this.xGridView.OptionsSelection.MultiSelect = true;
			this.xGridView.OptionsView.ShowAutoFilterRow = true;
			this.xGridView.OptionsView.ShowFooter = true;
			this.xGridView.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colTahun, DevExpress.Data.ColumnSortOrder.Descending),
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colBulan, DevExpress.Data.ColumnSortOrder.Descending)});
			// 
			// barMenu
			// 
			this.barMenu.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.txtPeriodeEdit, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.txtTampilkanSaldo0Edit, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
			this.barMenu.OptionsBar.AllowQuickCustomization = false;
			this.barMenu.OptionsBar.DrawDragBorder = false;
			this.barMenu.OptionsBar.UseWholeRow = true;
			// 
			// colNoInvoice
			// 
			this.colNoInvoice.FieldName = "NoInvoice";
			this.colNoInvoice.Name = "colNoInvoice";
			this.colNoInvoice.Visible = true;
			this.colNoInvoice.VisibleIndex = 0;
			this.colNoInvoice.Width = 109;
			// 
			// colTanggal
			// 
			this.colTanggal.DisplayFormat.FormatString = "dd MMM yyyy";
			this.colTanggal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
			this.colTanggal.FieldName = "Tanggal";
			this.colTanggal.Name = "colTanggal";
			this.colTanggal.Visible = true;
			this.colTanggal.VisibleIndex = 2;
			this.colTanggal.Width = 56;
			// 
			// colRegional
			// 
			this.colRegional.FieldName = "Regional";
			this.colRegional.Name = "colRegional";
			this.colRegional.Visible = true;
			this.colRegional.VisibleIndex = 3;
			this.colRegional.Width = 81;
			// 
			// colWilayah
			// 
			this.colWilayah.FieldName = "Wilayah";
			this.colWilayah.Name = "colWilayah";
			this.colWilayah.Visible = true;
			this.colWilayah.VisibleIndex = 4;
			this.colWilayah.Width = 81;
			// 
			// colPemasang
			// 
			this.colPemasang.FieldName = "Pemasang";
			this.colPemasang.Name = "colPemasang";
			this.colPemasang.Visible = true;
			this.colPemasang.VisibleIndex = 7;
			this.colPemasang.Width = 81;
			// 
			// colSales
			// 
			this.colSales.FieldName = "Sales";
			this.colSales.Name = "colSales";
			this.colSales.Visible = true;
			this.colSales.VisibleIndex = 6;
			this.colSales.Width = 81;
			// 
			// colTipeInvoice
			// 
			this.colTipeInvoice.Caption = "Tipe Invoice";
			this.colTipeInvoice.FieldName = "TipeInvoice";
			this.colTipeInvoice.Name = "colTipeInvoice";
			this.colTipeInvoice.Visible = true;
			this.colTipeInvoice.VisibleIndex = 5;
			this.colTipeInvoice.Width = 55;
			// 
			// colKomisiCashback
			// 
			this.colKomisiCashback.Caption = "Cashback";
			this.colKomisiCashback.DisplayFormat.FormatString = "n0";
			this.colKomisiCashback.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.colKomisiCashback.FieldName = "KomisiCashback";
			this.colKomisiCashback.Name = "colKomisiCashback";
			this.colKomisiCashback.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "KomisiCashback", "{0:n0}")});
			this.colKomisiCashback.Visible = true;
			this.colKomisiCashback.VisibleIndex = 8;
			this.colKomisiCashback.Width = 56;
			// 
			// colTerbayar
			// 
			this.colTerbayar.DisplayFormat.FormatString = "n0";
			this.colTerbayar.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.colTerbayar.FieldName = "Pembayaran";
			this.colTerbayar.Name = "colTerbayar";
			this.colTerbayar.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Pembayaran", "{0:n0}")});
			this.colTerbayar.Visible = true;
			this.colTerbayar.VisibleIndex = 9;
			this.colTerbayar.Width = 56;
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
			// colHutang
			// 
			this.colHutang.Caption = "Hutang";
			this.colHutang.DisplayFormat.FormatString = "n0";
			this.colHutang.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.colHutang.FieldName = "Hutang";
			this.colHutang.Name = "colHutang";
			this.colHutang.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Hutang", "{0:n0}")});
			this.colHutang.Visible = true;
			this.colHutang.VisibleIndex = 10;
			this.colHutang.Width = 56;
			// 
			// colKeteranganIklan
			// 
			this.colKeteranganIklan.Caption = "Judul";
			this.colKeteranganIklan.FieldName = "JudulIklan";
			this.colKeteranganIklan.Name = "colKeteranganIklan";
			this.colKeteranganIklan.Visible = true;
			this.colKeteranganIklan.VisibleIndex = 11;
			this.colKeteranganIklan.Width = 78;
			// 
			// barEditItem1
			// 
			this.barEditItem1.Caption = "barEditItem1";
			this.barEditItem1.Edit = this.repositoryItemTextEdit1;
			this.barEditItem1.Id = 22;
			this.barEditItem1.Name = "barEditItem1";
			// 
			// repositoryItemTextEdit1
			// 
			this.repositoryItemTextEdit1.AutoHeight = false;
			this.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1";
			// 
			// txtPeriodeEdit
			// 
			this.txtPeriodeEdit.Caption = "Periode :  ";
			this.txtPeriodeEdit.Edit = this.txtPeriode;
			this.txtPeriodeEdit.Id = 23;
			this.txtPeriodeEdit.Name = "txtPeriodeEdit";
			this.txtPeriodeEdit.Width = 157;
			// 
			// txtPeriode
			// 
			this.txtPeriode.AutoHeight = false;
			this.txtPeriode.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.txtPeriode.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Value", "Value")});
			this.txtPeriode.DisplayMember = "Value";
			this.txtPeriode.Name = "txtPeriode";
			this.txtPeriode.NullText = "[ Pilih Periode ]";
			this.txtPeriode.ShowHeader = false;
			this.txtPeriode.ValueMember = "Key";
			// 
			// txtTampilkanSaldo0Edit
			// 
			this.txtTampilkanSaldo0Edit.Caption = "Tampilkan Saldo 0   ";
			this.txtTampilkanSaldo0Edit.Edit = this.txtTampilkanSaldo0;
			this.txtTampilkanSaldo0Edit.EditValue = false;
			this.txtTampilkanSaldo0Edit.Id = 24;
			this.txtTampilkanSaldo0Edit.Name = "txtTampilkanSaldo0Edit";
			this.txtTampilkanSaldo0Edit.Width = 21;
			// 
			// txtTampilkanSaldo0
			// 
			this.txtTampilkanSaldo0.AutoHeight = false;
			this.txtTampilkanSaldo0.Caption = "Check";
			this.txtTampilkanSaldo0.Name = "txtTampilkanSaldo0";
			// 
			// colNoKwitansi
			// 
			this.colNoKwitansi.Caption = "No Kwitansi";
			this.colNoKwitansi.FieldName = "NoKwitansi";
			this.colNoKwitansi.Name = "colNoKwitansi";
			this.colNoKwitansi.Visible = true;
			this.colNoKwitansi.VisibleIndex = 1;
			this.colNoKwitansi.Width = 80;
			// 
			// UI_RincianHutangCashback
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(888, 405);
			this.Name = "UI_RincianHutangCashback";
			this.Text = "Rincian Hutang Cashback";
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
			((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtPeriode)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtTampilkanSaldo0)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion
		private DevExpress.XtraGrid.Columns.GridColumn colNoInvoice;
		private DevExpress.XtraGrid.Columns.GridColumn colTanggal;
		private DevExpress.XtraGrid.Columns.GridColumn colRegional;
		private DevExpress.XtraGrid.Columns.GridColumn colWilayah;
		private DevExpress.XtraGrid.Columns.GridColumn colPemasang;
		private DevExpress.XtraGrid.Columns.GridColumn colSales;
		private DevExpress.XtraGrid.Columns.GridColumn colTipeInvoice;
		private DevExpress.XtraGrid.Columns.GridColumn colKomisiCashback;
		private DevExpress.XtraGrid.Columns.GridColumn colTerbayar;
		private DevExpress.XtraGrid.Columns.GridColumn colTahun;
		private DevExpress.XtraGrid.Columns.GridColumn colBulan;
		private DevExpress.XtraGrid.Columns.GridColumn colHutang;
		private DevExpress.XtraGrid.Columns.GridColumn colKeteranganIklan;
		private DevExpress.XtraBars.BarEditItem barEditItem1;
		private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit1;
		private DevExpress.XtraBars.BarEditItem txtPeriodeEdit;
		private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit txtPeriode;
		private DevExpress.XtraBars.BarEditItem txtTampilkanSaldo0Edit;
		private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit txtTampilkanSaldo0;
		private DevExpress.XtraGrid.Columns.GridColumn colNoKwitansi;
	}
}
