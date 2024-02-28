namespace NuSoft.NUI.Win.Forms.Modules.NuSoft011.UI.Transaksi
{
	partial class UI_Pelanggan
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UI_Pelanggan));
			this.colAgen = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colKabupaten = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colKecamatan = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colNama = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colTanggalMasuk = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colAlamat = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colTanggalLahir = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colHP = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colEmail = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colNomorPelanggan = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colHargaPelanggan = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colJumlahExp = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colKeterangan = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colKeteranganTerakhir = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colTelpKantor = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colTelpRumah = new DevExpress.XtraGrid.Columns.GridColumn();
			this.btnNonAktifkan = new DevExpress.XtraBars.BarButtonItem();
			this.btnHistory = new DevExpress.XtraBars.BarButtonItem();
			this.btnTambahExp = new DevExpress.XtraBars.BarButtonItem();
			this.btnKomplain = new DevExpress.XtraBars.BarButtonItem();
			this.btnAktifkan = new DevExpress.XtraBars.BarButtonItem();
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
			// barMan
			// 
			this.barMan.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnNonAktifkan,
            this.btnHistory,
            this.btnTambahExp,
            this.btnKomplain,
            this.btnAktifkan});
			this.barMan.MaxItemId = 18;
			// 
			// xGridView
			// 
			this.xGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colKabupaten,
            this.colKecamatan,
            this.colAgen,
            this.colNomorPelanggan,
            this.colNama,
            this.colHargaPelanggan,
            this.colTanggalMasuk,
            this.colAlamat,
            this.colTanggalLahir,
            this.colTelpRumah,
            this.colTelpKantor,
            this.colHP,
            this.colEmail,
            this.colJumlahExp,
            this.colKeterangan,
            this.colKeteranganTerakhir,
            this.colId});
			this.xGridView.GroupCount = 3;
			this.xGridView.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "JumlahExp", null, "| Jml Exp : {0:n0}"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "NomorPelanggan", null, "| Jml Plg : {0:n0}")});
			this.xGridView.OptionsBehavior.Editable = false;
			this.xGridView.OptionsDetail.EnableMasterViewMode = false;
			this.xGridView.OptionsSelection.MultiSelect = true;
			this.xGridView.OptionsView.ColumnAutoWidth = false;
			this.xGridView.OptionsView.ShowAutoFilterRow = true;
			this.xGridView.OptionsView.ShowFooter = true;
			this.xGridView.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colKabupaten, DevExpress.Data.ColumnSortOrder.Ascending),
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colKecamatan, DevExpress.Data.ColumnSortOrder.Ascending),
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colAgen, DevExpress.Data.ColumnSortOrder.Ascending)});
			// 
			// ifSource
			// 
			this.ifSource.DisplayableProperties = resources.GetString("ifSource.DisplayableProperties");
			this.ifSource.ObjectType = typeof(NuSoft.NUI.Win.Forms.Modules.NuSoft011.Persistent.Pelanggan);
			// 
			// popMenu
			// 
			this.popMenu.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnNonAktifkan, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnAktifkan, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnHistory),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnTambahExp),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnKomplain)});
			// 
			// barMenu
			// 
			this.barMenu.OptionsBar.AllowQuickCustomization = false;
			this.barMenu.OptionsBar.DrawDragBorder = false;
			this.barMenu.OptionsBar.UseWholeRow = true;
			// 
			// colAgen
			// 
			this.colAgen.Caption = "Agen";
			this.colAgen.FieldName = "Agen.Nama";
			this.colAgen.Name = "colAgen";
			this.colAgen.Visible = true;
			this.colAgen.VisibleIndex = 0;
			// 
			// colKabupaten
			// 
			this.colKabupaten.Caption = "Kabupaten";
			this.colKabupaten.FieldName = "Kabupaten.Kode";
			this.colKabupaten.Name = "colKabupaten";
			this.colKabupaten.Visible = true;
			this.colKabupaten.VisibleIndex = 2;
			// 
			// colKecamatan
			// 
			this.colKecamatan.Caption = "Kecamatan";
			this.colKecamatan.FieldName = "Kecamatan.Kode";
			this.colKecamatan.Name = "colKecamatan";
			this.colKecamatan.Visible = true;
			this.colKecamatan.VisibleIndex = 2;
			// 
			// colNama
			// 
			this.colNama.FieldName = "Nama";
			this.colNama.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
			this.colNama.Name = "colNama";
			this.colNama.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "Nama", "Jml. Pelanggan = {0:n0}")});
			this.colNama.Visible = true;
			this.colNama.VisibleIndex = 1;
			this.colNama.Width = 250;
			// 
			// colTanggalMasuk
			// 
			this.colTanggalMasuk.DisplayFormat.FormatString = "dd MMM yyyy";
			this.colTanggalMasuk.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
			this.colTanggalMasuk.FieldName = "TanggalMulaiLangganan";
			this.colTanggalMasuk.Name = "colTanggalMasuk";
			this.colTanggalMasuk.Visible = true;
			this.colTanggalMasuk.VisibleIndex = 4;
			this.colTanggalMasuk.Width = 90;
			// 
			// colAlamat
			// 
			this.colAlamat.FieldName = "Alamat";
			this.colAlamat.Name = "colAlamat";
			this.colAlamat.Visible = true;
			this.colAlamat.VisibleIndex = 5;
			this.colAlamat.Width = 300;
			// 
			// colTanggalLahir
			// 
			this.colTanggalLahir.DisplayFormat.FormatString = "dd MMM yyyy";
			this.colTanggalLahir.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
			this.colTanggalLahir.FieldName = "TanggalLahir";
			this.colTanggalLahir.Name = "colTanggalLahir";
			this.colTanggalLahir.Visible = true;
			this.colTanggalLahir.VisibleIndex = 6;
			this.colTanggalLahir.Width = 90;
			// 
			// colHP
			// 
			this.colHP.FieldName = "NoHP";
			this.colHP.Name = "colHP";
			this.colHP.Visible = true;
			this.colHP.VisibleIndex = 9;
			this.colHP.Width = 70;
			// 
			// colEmail
			// 
			this.colEmail.FieldName = "Email";
			this.colEmail.Name = "colEmail";
			this.colEmail.Visible = true;
			this.colEmail.VisibleIndex = 10;
			this.colEmail.Width = 90;
			// 
			// colNomorPelanggan
			// 
			this.colNomorPelanggan.FieldName = "Kode";
			this.colNomorPelanggan.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
			this.colNomorPelanggan.Name = "colNomorPelanggan";
			this.colNomorPelanggan.Visible = true;
			this.colNomorPelanggan.VisibleIndex = 0;
			this.colNomorPelanggan.Width = 150;
			// 
			// colHargaPelanggan
			// 
			this.colHargaPelanggan.Caption = "Harga Langganan";
			this.colHargaPelanggan.DisplayFormat.FormatString = "n0";
			this.colHargaPelanggan.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.colHargaPelanggan.FieldName = "HargaLangganan";
			this.colHargaPelanggan.Name = "colHargaPelanggan";
			this.colHargaPelanggan.Visible = true;
			this.colHargaPelanggan.VisibleIndex = 3;
			this.colHargaPelanggan.Width = 100;
			// 
			// colJumlahExp
			// 
			this.colJumlahExp.AppearanceHeader.Options.UseTextOptions = true;
			this.colJumlahExp.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
			this.colJumlahExp.Caption = "Exp";
			this.colJumlahExp.DisplayFormat.FormatString = "n0";
			this.colJumlahExp.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.colJumlahExp.FieldName = "JumlahExp";
			this.colJumlahExp.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
			this.colJumlahExp.Name = "colJumlahExp";
			this.colJumlahExp.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "JumlahExp", "{0:n0}")});
			this.colJumlahExp.Visible = true;
			this.colJumlahExp.VisibleIndex = 2;
			this.colJumlahExp.Width = 30;
			// 
			// colKeterangan
			// 
			this.colKeterangan.FieldName = "Keterangan";
			this.colKeterangan.Name = "colKeterangan";
			this.colKeterangan.Visible = true;
			this.colKeterangan.VisibleIndex = 11;
			this.colKeterangan.Width = 100;
			// 
			// colKeteranganTerakhir
			// 
			this.colKeteranganTerakhir.Caption = "Alasan";
			this.colKeteranganTerakhir.FieldName = "KeteranganTerakhir";
			this.colKeteranganTerakhir.Name = "colKeteranganTerakhir";
			this.colKeteranganTerakhir.Visible = true;
			this.colKeteranganTerakhir.VisibleIndex = 12;
			// 
			// colTelpKantor
			// 
			this.colTelpKantor.FieldName = "NoTelpKantor";
			this.colTelpKantor.Name = "colTelpKantor";
			this.colTelpKantor.Visible = true;
			this.colTelpKantor.VisibleIndex = 8;
			this.colTelpKantor.Width = 70;
			// 
			// colTelpRumah
			// 
			this.colTelpRumah.FieldName = "NoTelpRumah";
			this.colTelpRumah.Name = "colTelpRumah";
			this.colTelpRumah.Visible = true;
			this.colTelpRumah.VisibleIndex = 7;
			this.colTelpRumah.Width = 70;
			// 
			// btnNonAktifkan
			// 
			this.btnNonAktifkan.Caption = "NonAktifkan";
			this.btnNonAktifkan.Glyph = ((System.Drawing.Image)(resources.GetObject("btnNonAktifkan.Glyph")));
			this.btnNonAktifkan.Id = 13;
			this.btnNonAktifkan.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnNonAktifkan.LargeGlyph")));
			this.btnNonAktifkan.Name = "btnNonAktifkan";
			// 
			// btnHistory
			// 
			this.btnHistory.Caption = "History";
			this.btnHistory.Glyph = ((System.Drawing.Image)(resources.GetObject("btnHistory.Glyph")));
			this.btnHistory.Id = 14;
			this.btnHistory.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnHistory.LargeGlyph")));
			this.btnHistory.Name = "btnHistory";
			// 
			// btnTambahExp
			// 
			this.btnTambahExp.Caption = "Tambah Exp";
			this.btnTambahExp.Glyph = ((System.Drawing.Image)(resources.GetObject("btnTambahExp.Glyph")));
			this.btnTambahExp.Id = 15;
			this.btnTambahExp.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnTambahExp.LargeGlyph")));
			this.btnTambahExp.Name = "btnTambahExp";
			// 
			// btnKomplain
			// 
			this.btnKomplain.Caption = "Komplain";
			this.btnKomplain.Glyph = ((System.Drawing.Image)(resources.GetObject("btnKomplain.Glyph")));
			this.btnKomplain.Id = 16;
			this.btnKomplain.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnKomplain.LargeGlyph")));
			this.btnKomplain.Name = "btnKomplain";
			// 
			// btnAktifkan
			// 
			this.btnAktifkan.Caption = "Aktifkan";
			this.btnAktifkan.Glyph = ((System.Drawing.Image)(resources.GetObject("btnAktifkan.Glyph")));
			this.btnAktifkan.Id = 17;
			this.btnAktifkan.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnAktifkan.LargeGlyph")));
			this.btnAktifkan.Name = "btnAktifkan";
			// 
			// colId
			// 
			this.colId.FieldName = "Id";
			this.colId.Name = "colId";
			// 
			// UI_Pelanggan
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(765, 402);
			this.Name = "UI_Pelanggan";
			this.Text = "Pelanggan";
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

		private DevExpress.XtraGrid.Columns.GridColumn colKabupaten;
		private DevExpress.XtraGrid.Columns.GridColumn colKecamatan;
		private DevExpress.XtraGrid.Columns.GridColumn colAgen;
		private DevExpress.XtraGrid.Columns.GridColumn colNomorPelanggan;
		private DevExpress.XtraGrid.Columns.GridColumn colNama;
		private DevExpress.XtraGrid.Columns.GridColumn colHargaPelanggan;
		private DevExpress.XtraGrid.Columns.GridColumn colTanggalMasuk;
		private DevExpress.XtraGrid.Columns.GridColumn colAlamat;
		private DevExpress.XtraGrid.Columns.GridColumn colTanggalLahir;
		private DevExpress.XtraGrid.Columns.GridColumn colHP;
		private DevExpress.XtraGrid.Columns.GridColumn colEmail;
		private DevExpress.XtraGrid.Columns.GridColumn colJumlahExp;
		private DevExpress.XtraGrid.Columns.GridColumn colKeterangan;
		private DevExpress.XtraGrid.Columns.GridColumn colKeteranganTerakhir;
		private DevExpress.XtraGrid.Columns.GridColumn colTelpRumah;
		private DevExpress.XtraGrid.Columns.GridColumn colTelpKantor;
		private DevExpress.XtraBars.BarButtonItem btnNonAktifkan;
		private DevExpress.XtraBars.BarButtonItem btnHistory;
		private DevExpress.XtraBars.BarButtonItem btnTambahExp;
		private DevExpress.XtraBars.BarButtonItem btnKomplain;
		private DevExpress.XtraBars.BarButtonItem btnAktifkan;
		private DevExpress.XtraGrid.Columns.GridColumn colId;
	}
}
