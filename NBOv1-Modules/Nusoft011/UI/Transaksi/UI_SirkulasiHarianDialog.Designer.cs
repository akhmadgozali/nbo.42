namespace NuSoft.NUI.Win.Forms.Modules.NuSoft011.UI.Transaksi
{
	partial class UI_SirkulasiHarianDialog
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

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
			this.xGrid = new DevExpress.XtraGrid.GridControl();
			this.xGridView = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridView();
			this.bandAgen = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
			this.colAgenKode = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
			this.colAgenNama = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
			this.gridBand2 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
			this.colJatahOrder = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
			this.colJatahMutasi = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
			this.colSpinRepo = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
			this.colJatahTotal = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
			this.gridBand4 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
			this.colKonsiOrder = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
			this.colKonsiMutasi = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
			this.colKonsiTotal = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
			this.gridBand5 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
			this.colGratisOrder = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
			this.colGratisMutasi = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
			this.colGratisTotal = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
			this.gridBand7 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
			this.colHargaJatah = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
			this.colCalcRepo = new DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit();
			this.colHargaKonsi = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
			this.gridBand6 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
			this.colOplah = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
			this.colRute = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
			this.txtHariKhusus = new DevExpress.XtraEditors.CheckEdit();
			this.txtKeterangan = new DevExpress.XtraEditors.TextEdit();
			this.txtTanggal = new DevExpress.XtraEditors.DateEdit();
			this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
			this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
			this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
			this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
			this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
			this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
			this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
			((System.ComponentModel.ISupportInitialize)(this.session)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
			this.layoutControl1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.xGrid)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.xGridView)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.colSpinRepo)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.colCalcRepo)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtHariKhusus.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtKeterangan.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtTanggal.Properties.CalendarTimeProperties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtTanggal.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
			this.SuspendLayout();
			// 
			// layoutControl1
			// 
			this.layoutControl1.Controls.Add(this.xGrid);
			this.layoutControl1.Controls.Add(this.txtHariKhusus);
			this.layoutControl1.Controls.Add(this.txtKeterangan);
			this.layoutControl1.Controls.Add(this.txtTanggal);
			this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.layoutControl1.Location = new System.Drawing.Point(0, 0);
			this.layoutControl1.Name = "layoutControl1";
			this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(716, 230, 650, 400);
			this.layoutControl1.Root = this.layoutControlGroup1;
			this.layoutControl1.Size = new System.Drawing.Size(916, 513);
			this.layoutControl1.TabIndex = 2;
			this.layoutControl1.Text = "layoutControl1";
			// 
			// xGrid
			// 
			this.xGrid.Location = new System.Drawing.Point(12, 87);
			this.xGrid.MainView = this.xGridView;
			this.xGrid.Name = "xGrid";
			this.xGrid.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.colCalcRepo,
            this.colSpinRepo});
			this.xGrid.Size = new System.Drawing.Size(892, 414);
			this.xGrid.TabIndex = 7;
			this.xGrid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.xGridView});
			// 
			// xGridView
			// 
			this.xGridView.Bands.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.GridBand[] {
            this.bandAgen,
            this.gridBand2,
            this.gridBand4,
            this.gridBand5,
            this.gridBand7,
            this.gridBand6});
			this.xGridView.Columns.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn[] {
            this.colAgenKode,
            this.colAgenNama,
            this.colRute,
            this.colJatahOrder,
            this.colJatahMutasi,
            this.colJatahTotal,
            this.colKonsiOrder,
            this.colKonsiMutasi,
            this.colKonsiTotal,
            this.colGratisOrder,
            this.colGratisMutasi,
            this.colGratisTotal,
            this.colOplah,
            this.colHargaJatah,
            this.colHargaKonsi});
			this.xGridView.FixedLineWidth = 1;
			this.xGridView.GridControl = this.xGrid;
			this.xGridView.GroupCount = 1;
			this.xGridView.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Oplah", null, "| Oplah : {0:n0}"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Oplah", this.colOplah, "{0:n0}"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "JatahPelangganOrder", this.colJatahOrder, "{0:n0}"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "JatahPelangganMutasi", this.colJatahMutasi, "{0:n0}"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "JatahPelanggan", this.colJatahTotal, "{0:n0}"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "KonsiOrder", this.colKonsiOrder, "{0:n0}"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "KonsiMutasi", this.colKonsiMutasi, "{0:n0}"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Konsi", this.colKonsiTotal, "{0:n0}"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "GratisOrder", this.colGratisOrder, "{0:n0}"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "GratisMutasi", this.colGratisMutasi, "{0:n0}"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Gratis", this.colGratisTotal, "{0:n0}")});
			this.xGridView.Name = "xGridView";
			this.xGridView.OptionsDetail.EnableMasterViewMode = false;
			this.xGridView.OptionsNavigation.EnterMoveNextColumn = true;
			this.xGridView.OptionsView.ColumnAutoWidth = false;
			this.xGridView.OptionsView.ShowAutoFilterRow = true;
			this.xGridView.OptionsView.ShowFooter = true;
			this.xGridView.OptionsView.ShowGroupPanel = false;
			this.xGridView.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colRute, DevExpress.Data.ColumnSortOrder.Ascending)});
			// 
			// bandAgen
			// 
			this.bandAgen.AppearanceHeader.Options.UseTextOptions = true;
			this.bandAgen.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.bandAgen.Caption = "Agen";
			this.bandAgen.Columns.Add(this.colAgenKode);
			this.bandAgen.Columns.Add(this.colAgenNama);
			this.bandAgen.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
			this.bandAgen.Name = "bandAgen";
			this.bandAgen.VisibleIndex = 0;
			this.bandAgen.Width = 245;
			// 
			// colAgenKode
			// 
			this.colAgenKode.Caption = "Kode";
			this.colAgenKode.FieldName = "Agen.Kode";
			this.colAgenKode.Name = "colAgenKode";
			this.colAgenKode.OptionsColumn.AllowEdit = false;
			this.colAgenKode.OptionsColumn.ReadOnly = true;
			this.colAgenKode.Visible = true;
			this.colAgenKode.Width = 80;
			// 
			// colAgenNama
			// 
			this.colAgenNama.Caption = "Nama";
			this.colAgenNama.FieldName = "Agen.Nama";
			this.colAgenNama.Name = "colAgenNama";
			this.colAgenNama.OptionsColumn.AllowEdit = false;
			this.colAgenNama.OptionsColumn.ReadOnly = true;
			this.colAgenNama.Visible = true;
			this.colAgenNama.Width = 165;
			// 
			// gridBand2
			// 
			this.gridBand2.AppearanceHeader.Options.UseTextOptions = true;
			this.gridBand2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.gridBand2.Caption = "Jatah";
			this.gridBand2.Columns.Add(this.colJatahOrder);
			this.gridBand2.Columns.Add(this.colJatahMutasi);
			this.gridBand2.Columns.Add(this.colJatahTotal);
			this.gridBand2.Name = "gridBand2";
			this.gridBand2.VisibleIndex = 1;
			this.gridBand2.Width = 150;
			// 
			// colJatahOrder
			// 
			this.colJatahOrder.AppearanceCell.Options.UseTextOptions = true;
			this.colJatahOrder.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
			this.colJatahOrder.AppearanceHeader.Options.UseTextOptions = true;
			this.colJatahOrder.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colJatahOrder.Caption = "Order";
			this.colJatahOrder.DisplayFormat.FormatString = "n0";
			this.colJatahOrder.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.colJatahOrder.FieldName = "JatahOrder";
			this.colJatahOrder.Name = "colJatahOrder";
			this.colJatahOrder.OptionsColumn.AllowEdit = false;
			this.colJatahOrder.OptionsColumn.ReadOnly = true;
			this.colJatahOrder.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "JatahOrder", "{0:n0}")});
			this.colJatahOrder.Visible = true;
			this.colJatahOrder.Width = 50;
			// 
			// colJatahMutasi
			// 
			this.colJatahMutasi.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.colJatahMutasi.AppearanceCell.Options.UseBackColor = true;
			this.colJatahMutasi.AppearanceCell.Options.UseTextOptions = true;
			this.colJatahMutasi.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
			this.colJatahMutasi.AppearanceHeader.Options.UseTextOptions = true;
			this.colJatahMutasi.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colJatahMutasi.Caption = "Mutasi";
			this.colJatahMutasi.ColumnEdit = this.colSpinRepo;
			this.colJatahMutasi.DisplayFormat.FormatString = "n0";
			this.colJatahMutasi.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.colJatahMutasi.FieldName = "JatahMutasi";
			this.colJatahMutasi.Name = "colJatahMutasi";
			this.colJatahMutasi.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "JatahMutasi", "{0:n0}")});
			this.colJatahMutasi.Visible = true;
			this.colJatahMutasi.Width = 50;
			// 
			// colSpinRepo
			// 
			this.colSpinRepo.AutoHeight = false;
			this.colSpinRepo.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.colSpinRepo.Name = "colSpinRepo";
			// 
			// colJatahTotal
			// 
			this.colJatahTotal.AppearanceCell.Options.UseTextOptions = true;
			this.colJatahTotal.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
			this.colJatahTotal.AppearanceHeader.Options.UseTextOptions = true;
			this.colJatahTotal.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colJatahTotal.Caption = "Total";
			this.colJatahTotal.DisplayFormat.FormatString = "n0";
			this.colJatahTotal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.colJatahTotal.FieldName = "Jatah";
			this.colJatahTotal.Name = "colJatahTotal";
			this.colJatahTotal.OptionsColumn.AllowEdit = false;
			this.colJatahTotal.OptionsColumn.ReadOnly = true;
			this.colJatahTotal.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Jatah", "{0:n0}")});
			this.colJatahTotal.Visible = true;
			this.colJatahTotal.Width = 50;
			// 
			// gridBand4
			// 
			this.gridBand4.AppearanceHeader.Options.UseTextOptions = true;
			this.gridBand4.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.gridBand4.Caption = "Konsi";
			this.gridBand4.Columns.Add(this.colKonsiOrder);
			this.gridBand4.Columns.Add(this.colKonsiMutasi);
			this.gridBand4.Columns.Add(this.colKonsiTotal);
			this.gridBand4.Name = "gridBand4";
			this.gridBand4.VisibleIndex = 2;
			this.gridBand4.Width = 150;
			// 
			// colKonsiOrder
			// 
			this.colKonsiOrder.AppearanceCell.Options.UseTextOptions = true;
			this.colKonsiOrder.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
			this.colKonsiOrder.AppearanceHeader.Options.UseTextOptions = true;
			this.colKonsiOrder.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colKonsiOrder.Caption = "Order";
			this.colKonsiOrder.DisplayFormat.FormatString = "n0";
			this.colKonsiOrder.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.colKonsiOrder.FieldName = "KonsiOrder";
			this.colKonsiOrder.Name = "colKonsiOrder";
			this.colKonsiOrder.OptionsColumn.AllowEdit = false;
			this.colKonsiOrder.OptionsColumn.ReadOnly = true;
			this.colKonsiOrder.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "KonsiOrder", "{0:n0}")});
			this.colKonsiOrder.Visible = true;
			this.colKonsiOrder.Width = 50;
			// 
			// colKonsiMutasi
			// 
			this.colKonsiMutasi.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.colKonsiMutasi.AppearanceCell.Options.UseBackColor = true;
			this.colKonsiMutasi.AppearanceCell.Options.UseTextOptions = true;
			this.colKonsiMutasi.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
			this.colKonsiMutasi.AppearanceHeader.Options.UseTextOptions = true;
			this.colKonsiMutasi.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colKonsiMutasi.Caption = "Mutasi";
			this.colKonsiMutasi.ColumnEdit = this.colSpinRepo;
			this.colKonsiMutasi.DisplayFormat.FormatString = "n0";
			this.colKonsiMutasi.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.colKonsiMutasi.FieldName = "KonsiMutasi";
			this.colKonsiMutasi.Name = "colKonsiMutasi";
			this.colKonsiMutasi.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "KonsiMutasi", "{0:n0}")});
			this.colKonsiMutasi.Visible = true;
			this.colKonsiMutasi.Width = 50;
			// 
			// colKonsiTotal
			// 
			this.colKonsiTotal.AppearanceCell.Options.UseTextOptions = true;
			this.colKonsiTotal.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
			this.colKonsiTotal.AppearanceHeader.Options.UseTextOptions = true;
			this.colKonsiTotal.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colKonsiTotal.Caption = "Total";
			this.colKonsiTotal.DisplayFormat.FormatString = "n0";
			this.colKonsiTotal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.colKonsiTotal.FieldName = "Konsi";
			this.colKonsiTotal.Name = "colKonsiTotal";
			this.colKonsiTotal.OptionsColumn.AllowEdit = false;
			this.colKonsiTotal.OptionsColumn.ReadOnly = true;
			this.colKonsiTotal.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Konsi", "{0:n0}")});
			this.colKonsiTotal.Visible = true;
			this.colKonsiTotal.Width = 50;
			// 
			// gridBand5
			// 
			this.gridBand5.AppearanceHeader.Options.UseTextOptions = true;
			this.gridBand5.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.gridBand5.Caption = "Gratis";
			this.gridBand5.Columns.Add(this.colGratisOrder);
			this.gridBand5.Columns.Add(this.colGratisMutasi);
			this.gridBand5.Columns.Add(this.colGratisTotal);
			this.gridBand5.Name = "gridBand5";
			this.gridBand5.VisibleIndex = 3;
			this.gridBand5.Width = 150;
			// 
			// colGratisOrder
			// 
			this.colGratisOrder.AppearanceCell.Options.UseTextOptions = true;
			this.colGratisOrder.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
			this.colGratisOrder.AppearanceHeader.Options.UseTextOptions = true;
			this.colGratisOrder.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colGratisOrder.Caption = "Order";
			this.colGratisOrder.DisplayFormat.FormatString = "n0";
			this.colGratisOrder.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.colGratisOrder.FieldName = "GratisOrder";
			this.colGratisOrder.Name = "colGratisOrder";
			this.colGratisOrder.OptionsColumn.ReadOnly = true;
			this.colGratisOrder.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "GratisOrder", "{0:n0}")});
			this.colGratisOrder.Visible = true;
			this.colGratisOrder.Width = 50;
			// 
			// colGratisMutasi
			// 
			this.colGratisMutasi.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.colGratisMutasi.AppearanceCell.Options.UseBackColor = true;
			this.colGratisMutasi.AppearanceCell.Options.UseTextOptions = true;
			this.colGratisMutasi.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
			this.colGratisMutasi.AppearanceHeader.Options.UseTextOptions = true;
			this.colGratisMutasi.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colGratisMutasi.Caption = "Mutasi";
			this.colGratisMutasi.ColumnEdit = this.colSpinRepo;
			this.colGratisMutasi.DisplayFormat.FormatString = "n0";
			this.colGratisMutasi.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.colGratisMutasi.FieldName = "GratisMutasi";
			this.colGratisMutasi.Name = "colGratisMutasi";
			this.colGratisMutasi.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "GratisMutasi", "{0:n0}")});
			this.colGratisMutasi.Visible = true;
			this.colGratisMutasi.Width = 50;
			// 
			// colGratisTotal
			// 
			this.colGratisTotal.AppearanceCell.Options.UseTextOptions = true;
			this.colGratisTotal.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
			this.colGratisTotal.AppearanceHeader.Options.UseTextOptions = true;
			this.colGratisTotal.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colGratisTotal.Caption = "Total";
			this.colGratisTotal.DisplayFormat.FormatString = "n0";
			this.colGratisTotal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.colGratisTotal.FieldName = "Gratis";
			this.colGratisTotal.Name = "colGratisTotal";
			this.colGratisTotal.OptionsColumn.AllowEdit = false;
			this.colGratisTotal.OptionsColumn.ReadOnly = true;
			this.colGratisTotal.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Gratis", "{0:n0}")});
			this.colGratisTotal.Visible = true;
			this.colGratisTotal.Width = 50;
			// 
			// gridBand7
			// 
			this.gridBand7.AppearanceHeader.Options.UseTextOptions = true;
			this.gridBand7.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.gridBand7.Caption = "Harga";
			this.gridBand7.Columns.Add(this.colHargaJatah);
			this.gridBand7.Columns.Add(this.colHargaKonsi);
			this.gridBand7.Name = "gridBand7";
			this.gridBand7.VisibleIndex = 4;
			this.gridBand7.Width = 100;
			// 
			// colHargaJatah
			// 
			this.colHargaJatah.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.colHargaJatah.AppearanceCell.Options.UseBackColor = true;
			this.colHargaJatah.AppearanceCell.Options.UseTextOptions = true;
			this.colHargaJatah.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
			this.colHargaJatah.AppearanceHeader.Options.UseTextOptions = true;
			this.colHargaJatah.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colHargaJatah.Caption = "Jatah";
			this.colHargaJatah.ColumnEdit = this.colCalcRepo;
			this.colHargaJatah.DisplayFormat.FormatString = "n0";
			this.colHargaJatah.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.colHargaJatah.FieldName = "HargaJatah";
			this.colHargaJatah.Name = "colHargaJatah";
			this.colHargaJatah.Visible = true;
			this.colHargaJatah.Width = 50;
			// 
			// colCalcRepo
			// 
			this.colCalcRepo.AutoHeight = false;
			this.colCalcRepo.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.colCalcRepo.Name = "colCalcRepo";
			// 
			// colHargaKonsi
			// 
			this.colHargaKonsi.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.colHargaKonsi.AppearanceCell.Options.UseBackColor = true;
			this.colHargaKonsi.AppearanceCell.Options.UseTextOptions = true;
			this.colHargaKonsi.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
			this.colHargaKonsi.AppearanceHeader.Options.UseTextOptions = true;
			this.colHargaKonsi.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colHargaKonsi.Caption = "Konsi";
			this.colHargaKonsi.ColumnEdit = this.colCalcRepo;
			this.colHargaKonsi.DisplayFormat.FormatString = "n0";
			this.colHargaKonsi.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.colHargaKonsi.FieldName = "HargaKonsi";
			this.colHargaKonsi.Name = "colHargaKonsi";
			this.colHargaKonsi.Visible = true;
			this.colHargaKonsi.Width = 50;
			// 
			// gridBand6
			// 
			this.gridBand6.AppearanceHeader.Options.UseTextOptions = true;
			this.gridBand6.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.gridBand6.Caption = "Total";
			this.gridBand6.Columns.Add(this.colOplah);
			this.gridBand6.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Right;
			this.gridBand6.Name = "gridBand6";
			this.gridBand6.VisibleIndex = 5;
			this.gridBand6.Width = 60;
			// 
			// colOplah
			// 
			this.colOplah.AppearanceCell.Options.UseTextOptions = true;
			this.colOplah.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
			this.colOplah.AppearanceHeader.Options.UseTextOptions = true;
			this.colOplah.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colOplah.Caption = "Oplah";
			this.colOplah.DisplayFormat.FormatString = "n0";
			this.colOplah.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.colOplah.FieldName = "Oplah";
			this.colOplah.Name = "colOplah";
			this.colOplah.OptionsColumn.AllowEdit = false;
			this.colOplah.OptionsColumn.ReadOnly = true;
			this.colOplah.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Oplah", "{0:n0}")});
			this.colOplah.Visible = true;
			this.colOplah.Width = 60;
			// 
			// colRute
			// 
			this.colRute.Caption = "Rute";
			this.colRute.FieldName = "Agen.Rute.KodeNama";
			this.colRute.Name = "colRute";
			this.colRute.OptionsColumn.AllowEdit = false;
			this.colRute.OptionsColumn.ReadOnly = true;
			this.colRute.Visible = true;
			// 
			// txtHariKhusus
			// 
			this.txtHariKhusus.EnterMoveNextControl = true;
			this.txtHariKhusus.Location = new System.Drawing.Point(276, 12);
			this.txtHariKhusus.Name = "txtHariKhusus";
			this.txtHariKhusus.Properties.Caption = "Hari Khusus";
			this.txtHariKhusus.Size = new System.Drawing.Size(78, 19);
			this.txtHariKhusus.StyleController = this.layoutControl1;
			this.txtHariKhusus.TabIndex = 6;
			// 
			// txtKeterangan
			// 
			this.txtKeterangan.EnterMoveNextControl = true;
			this.txtKeterangan.Location = new System.Drawing.Point(74, 36);
			this.txtKeterangan.Name = "txtKeterangan";
			this.txtKeterangan.Size = new System.Drawing.Size(830, 20);
			this.txtKeterangan.StyleController = this.layoutControl1;
			this.txtKeterangan.TabIndex = 5;
			// 
			// txtTanggal
			// 
			this.txtTanggal.EditValue = null;
			this.txtTanggal.EnterMoveNextControl = true;
			this.txtTanggal.Location = new System.Drawing.Point(74, 12);
			this.txtTanggal.Name = "txtTanggal";
			this.txtTanggal.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.txtTanggal.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.txtTanggal.Properties.DisplayFormat.FormatString = "dddd, dd MMMM yyyy";
			this.txtTanggal.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
			this.txtTanggal.Size = new System.Drawing.Size(198, 20);
			this.txtTanggal.StyleController = this.layoutControl1;
			this.txtTanggal.TabIndex = 4;
			// 
			// layoutControlGroup1
			// 
			this.layoutControlGroup1.CustomizationFormText = "Root";
			this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
			this.layoutControlGroup1.GroupBordersVisible = false;
			this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.emptySpaceItem1,
            this.emptySpaceItem2});
			this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
			this.layoutControlGroup1.Name = "Root";
			this.layoutControlGroup1.Size = new System.Drawing.Size(916, 513);
			this.layoutControlGroup1.Text = "Root";
			this.layoutControlGroup1.TextVisible = false;
			// 
			// layoutControlItem1
			// 
			this.layoutControlItem1.Control = this.txtTanggal;
			this.layoutControlItem1.CustomizationFormText = "Tanggal";
			this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
			this.layoutControlItem1.Name = "layoutControlItem1";
			this.layoutControlItem1.Size = new System.Drawing.Size(264, 24);
			this.layoutControlItem1.Text = "Tanggal";
			this.layoutControlItem1.TextSize = new System.Drawing.Size(59, 13);
			// 
			// layoutControlItem2
			// 
			this.layoutControlItem2.Control = this.txtKeterangan;
			this.layoutControlItem2.CustomizationFormText = "Keterangan ";
			this.layoutControlItem2.Location = new System.Drawing.Point(0, 24);
			this.layoutControlItem2.Name = "layoutControlItem2";
			this.layoutControlItem2.Size = new System.Drawing.Size(896, 24);
			this.layoutControlItem2.Text = "Keterangan ";
			this.layoutControlItem2.TextSize = new System.Drawing.Size(59, 13);
			// 
			// layoutControlItem3
			// 
			this.layoutControlItem3.Control = this.txtHariKhusus;
			this.layoutControlItem3.CustomizationFormText = "layoutControlItem3";
			this.layoutControlItem3.Location = new System.Drawing.Point(264, 0);
			this.layoutControlItem3.Name = "layoutControlItem3";
			this.layoutControlItem3.Size = new System.Drawing.Size(82, 24);
			this.layoutControlItem3.Text = "layoutControlItem3";
			this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
			this.layoutControlItem3.TextToControlDistance = 0;
			this.layoutControlItem3.TextVisible = false;
			// 
			// layoutControlItem4
			// 
			this.layoutControlItem4.Control = this.xGrid;
			this.layoutControlItem4.CustomizationFormText = "layoutControlItem4";
			this.layoutControlItem4.Location = new System.Drawing.Point(0, 75);
			this.layoutControlItem4.Name = "layoutControlItem4";
			this.layoutControlItem4.Size = new System.Drawing.Size(896, 418);
			this.layoutControlItem4.Text = "layoutControlItem4";
			this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
			this.layoutControlItem4.TextToControlDistance = 0;
			this.layoutControlItem4.TextVisible = false;
			// 
			// emptySpaceItem1
			// 
			this.emptySpaceItem1.AllowHotTrack = false;
			this.emptySpaceItem1.CustomizationFormText = "emptySpaceItem1";
			this.emptySpaceItem1.Location = new System.Drawing.Point(346, 0);
			this.emptySpaceItem1.Name = "emptySpaceItem1";
			this.emptySpaceItem1.Size = new System.Drawing.Size(550, 24);
			this.emptySpaceItem1.Text = "emptySpaceItem1";
			this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
			// 
			// emptySpaceItem2
			// 
			this.emptySpaceItem2.AllowHotTrack = false;
			this.emptySpaceItem2.CustomizationFormText = "emptySpaceItem2";
			this.emptySpaceItem2.Location = new System.Drawing.Point(0, 48);
			this.emptySpaceItem2.Name = "emptySpaceItem2";
			this.emptySpaceItem2.Size = new System.Drawing.Size(896, 27);
			this.emptySpaceItem2.Text = "emptySpaceItem2";
			this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
			// 
			// UI_SirkulasiHarianDialog
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(916, 562);
			this.Controls.Add(this.layoutControl1);
			this.Name = "UI_SirkulasiHarianDialog";
			this.Text = "UI_MutasiTanggalDialog";
			this.Controls.SetChildIndex(this.layoutControl1, 0);
			((System.ComponentModel.ISupportInitialize)(this.session)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
			this.layoutControl1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.xGrid)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.xGridView)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.colSpinRepo)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.colCalcRepo)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtHariKhusus.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtKeterangan.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtTanggal.Properties.CalendarTimeProperties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtTanggal.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private DevExpress.XtraLayout.LayoutControl layoutControl1;
		private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
		private DevExpress.XtraGrid.GridControl xGrid;
		private DevExpress.XtraEditors.CheckEdit txtHariKhusus;
		private DevExpress.XtraEditors.TextEdit txtKeterangan;
		private DevExpress.XtraEditors.DateEdit txtTanggal;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
		private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
		private DevExpress.XtraGrid.Views.BandedGrid.BandedGridView xGridView;
		private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colAgenKode;
		private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colAgenNama;
		private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colJatahOrder;
		private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colJatahMutasi;
		private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit colSpinRepo;
		private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colJatahTotal;
		private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colKonsiOrder;
		private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colKonsiMutasi;
		private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colKonsiTotal;
		private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colGratisOrder;
		private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colGratisMutasi;
		private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colGratisTotal;
		private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colHargaJatah;
		private DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit colCalcRepo;
		private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colHargaKonsi;
		private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colOplah;
		private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colRute;
		private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
		private DevExpress.XtraGrid.Views.BandedGrid.GridBand bandAgen;
		private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand2;
		private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand4;
		private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand5;
		private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand7;
		private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand6;
	}
}