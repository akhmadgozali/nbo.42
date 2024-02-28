namespace NuSoft.NUI.Win.Forms.Modules.NuSoft009.UILayer.Transaksi
{
	partial class UI_Absensi
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UI_Absensi));
			this.colcreated_date = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colcreated_user = new DevExpress.XtraGrid.Columns.GridColumn();
			this.collast_date = new DevExpress.XtraGrid.Columns.GridColumn();
			this.collast_modified = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
			this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colTanggal = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colJamMasuk = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colJamPulang = new DevExpress.XtraGrid.Columns.GridColumn();
			this.gridColumn92 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colCatatan = new DevExpress.XtraGrid.Columns.GridColumn();
			this.gridColumn98 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.gridColumn99 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.gridColumn111 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.gridColumn112 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.gridColumn113 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colHariKerja = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colLembur = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colLemburPengganti = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colLiburNasional = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colCutiBesar = new DevExpress.XtraGrid.Columns.GridColumn();
			this.gridColumn118 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colLupaAbsen = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colReimbusMakan = new DevExpress.XtraGrid.Columns.GridColumn();
			this.btnCreateAbsensi = new DevExpress.XtraBars.BarButtonItem();
			this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
			this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
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
			this.xGrid.Size = new System.Drawing.Size(1136, 480);
			// 
			// barMan
			// 
			this.barMan.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnCreateAbsensi,
            this.barButtonItem2,
            this.barButtonItem3});
			this.barMan.MaxItemId = 16;
			// 
			// xGridView
			// 
			this.xGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colcreated_date,
            this.colcreated_user,
            this.collast_date,
            this.collast_modified,
            this.colId,
            this.gridColumn7,
            this.gridColumn8,
            this.colTanggal,
            this.colJamMasuk,
            this.colJamPulang,
            this.gridColumn92,
            this.colCatatan,
            this.gridColumn98,
            this.gridColumn99,
            this.gridColumn111,
            this.gridColumn112,
            this.gridColumn113,
            this.colHariKerja,
            this.colLembur,
            this.colLemburPengganti,
            this.colLiburNasional,
            this.colCutiBesar,
            this.gridColumn118,
            this.colLupaAbsen,
            this.colReimbusMakan});
			this.xGridView.GroupCount = 1;
			this.xGridView.OptionsBehavior.Editable = false;
			this.xGridView.OptionsDetail.EnableMasterViewMode = false;
			this.xGridView.OptionsSelection.MultiSelect = true;
			this.xGridView.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.gridColumn98, DevExpress.Data.ColumnSortOrder.Ascending)});
			// 
			// ifSource
			// 
			this.ifSource.DisplayableProperties = resources.GetString("ifSource.DisplayableProperties");
			this.ifSource.ObjectType = typeof(NuSoft.NUI.Win.Forms.Modules.NuSoft09.Persistent.Absensi);
			// 
			// barMenu
			// 
			this.barMenu.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnCreateAbsensi, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButtonItem2, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButtonItem3, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
			this.barMenu.OptionsBar.AllowQuickCustomization = false;
			this.barMenu.OptionsBar.DrawDragBorder = false;
			this.barMenu.OptionsBar.UseWholeRow = true;
			// 
			// colcreated_date
			// 
			this.colcreated_date.FieldName = "created_date";
			this.colcreated_date.Name = "colcreated_date";
			// 
			// colcreated_user
			// 
			this.colcreated_user.FieldName = "created_user";
			this.colcreated_user.Name = "colcreated_user";
			// 
			// collast_date
			// 
			this.collast_date.FieldName = "last_date";
			this.collast_date.Name = "collast_date";
			// 
			// collast_modified
			// 
			this.collast_modified.FieldName = "last_modified";
			this.collast_modified.Name = "collast_modified";
			// 
			// colId
			// 
			this.colId.FieldName = "Id";
			this.colId.Name = "colId";
			// 
			// gridColumn7
			// 
			this.gridColumn7.Caption = "Nama";
			this.gridColumn7.FieldName = "Karyawan.Nama";
			this.gridColumn7.Name = "gridColumn7";
			this.gridColumn7.OptionsColumn.ReadOnly = true;
			this.gridColumn7.Visible = true;
			this.gridColumn7.VisibleIndex = 2;
			this.gridColumn7.Width = 140;
			// 
			// gridColumn8
			// 
			this.gridColumn8.Caption = "Kode";
			this.gridColumn8.FieldName = "Karyawan.Kode";
			this.gridColumn8.Name = "gridColumn8";
			this.gridColumn8.OptionsColumn.ReadOnly = true;
			this.gridColumn8.Visible = true;
			this.gridColumn8.VisibleIndex = 1;
			this.gridColumn8.Width = 85;
			// 
			// colTanggal
			// 
			this.colTanggal.Caption = "Tanggal";
			this.colTanggal.FieldName = "Tanggal";
			this.colTanggal.Name = "colTanggal";
			this.colTanggal.Visible = true;
			this.colTanggal.VisibleIndex = 3;
			this.colTanggal.Width = 81;
			// 
			// colJamMasuk
			// 
			this.colJamMasuk.Caption = "Jam Masuk";
			this.colJamMasuk.FieldName = "JamMasuk";
			this.colJamMasuk.Name = "colJamMasuk";
			this.colJamMasuk.Visible = true;
			this.colJamMasuk.VisibleIndex = 4;
			this.colJamMasuk.Width = 81;
			// 
			// colJamPulang
			// 
			this.colJamPulang.Caption = "Jam Pulang";
			this.colJamPulang.FieldName = "JamPulang";
			this.colJamPulang.Name = "colJamPulang";
			this.colJamPulang.Visible = true;
			this.colJamPulang.VisibleIndex = 5;
			this.colJamPulang.Width = 81;
			// 
			// gridColumn92
			// 
			this.gridColumn92.Caption = "Status";
			this.gridColumn92.FieldName = "Status.Kode";
			this.gridColumn92.Name = "gridColumn92";
			this.gridColumn92.OptionsColumn.ReadOnly = true;
			this.gridColumn92.Visible = true;
			this.gridColumn92.VisibleIndex = 6;
			this.gridColumn92.Width = 81;
			// 
			// colCatatan
			// 
			this.colCatatan.Caption = "Catatan";
			this.colCatatan.FieldName = "Catatan";
			this.colCatatan.Name = "colCatatan";
			this.colCatatan.Visible = true;
			this.colCatatan.VisibleIndex = 7;
			this.colCatatan.Width = 81;
			// 
			// gridColumn98
			// 
			this.gridColumn98.Caption = "Kode Divisi";
			this.gridColumn98.FieldName = "Divisi.Kode";
			this.gridColumn98.Name = "gridColumn98";
			this.gridColumn98.OptionsColumn.ReadOnly = true;
			this.gridColumn98.Visible = true;
			this.gridColumn98.VisibleIndex = 8;
			// 
			// gridColumn99
			// 
			this.gridColumn99.Caption = "Nama Divisi";
			this.gridColumn99.FieldName = "Divisi.Nama";
			this.gridColumn99.Name = "gridColumn99";
			this.gridColumn99.OptionsColumn.ReadOnly = true;
			this.gridColumn99.Visible = true;
			this.gridColumn99.VisibleIndex = 0;
			this.gridColumn99.Width = 85;
			// 
			// gridColumn111
			// 
			this.gridColumn111.Caption = "Shift";
			this.gridColumn111.FieldName = "Shift.Kode";
			this.gridColumn111.Name = "gridColumn111";
			this.gridColumn111.OptionsColumn.ReadOnly = true;
			this.gridColumn111.Visible = true;
			this.gridColumn111.VisibleIndex = 8;
			this.gridColumn111.Width = 81;
			// 
			// gridColumn112
			// 
			this.gridColumn112.Caption = "Jadwal Jam Masuk";
			this.gridColumn112.FieldName = "Shift.JamMasuk";
			this.gridColumn112.Name = "gridColumn112";
			this.gridColumn112.OptionsColumn.ReadOnly = true;
			this.gridColumn112.Visible = true;
			this.gridColumn112.VisibleIndex = 9;
			this.gridColumn112.Width = 81;
			// 
			// gridColumn113
			// 
			this.gridColumn113.Caption = "Jadwal Jam Pulang";
			this.gridColumn113.FieldName = "Shift.JamKeluar";
			this.gridColumn113.Name = "gridColumn113";
			this.gridColumn113.OptionsColumn.ReadOnly = true;
			this.gridColumn113.Visible = true;
			this.gridColumn113.VisibleIndex = 10;
			this.gridColumn113.Width = 81;
			// 
			// colHariKerja
			// 
			this.colHariKerja.Caption = "Hari Kerja";
			this.colHariKerja.FieldName = "HariKerja";
			this.colHariKerja.Name = "colHariKerja";
			this.colHariKerja.Visible = true;
			this.colHariKerja.VisibleIndex = 11;
			this.colHariKerja.Width = 81;
			// 
			// colLembur
			// 
			this.colLembur.Caption = "Lembur";
			this.colLembur.FieldName = "Lembur";
			this.colLembur.Name = "colLembur";
			this.colLembur.Visible = true;
			this.colLembur.VisibleIndex = 12;
			this.colLembur.Width = 81;
			// 
			// colLemburPengganti
			// 
			this.colLemburPengganti.Caption = "Lembur Pengganti";
			this.colLemburPengganti.FieldName = "LemburPengganti";
			this.colLemburPengganti.Name = "colLemburPengganti";
			this.colLemburPengganti.Visible = true;
			this.colLemburPengganti.VisibleIndex = 13;
			this.colLemburPengganti.Width = 81;
			// 
			// colLiburNasional
			// 
			this.colLiburNasional.Caption = "Libur Nasional";
			this.colLiburNasional.FieldName = "LiburNasional";
			this.colLiburNasional.Name = "colLiburNasional";
			this.colLiburNasional.Visible = true;
			this.colLiburNasional.VisibleIndex = 14;
			this.colLiburNasional.Width = 81;
			// 
			// colCutiBesar
			// 
			this.colCutiBesar.Caption = "Cuti Besar";
			this.colCutiBesar.FieldName = "CutiBesar";
			this.colCutiBesar.Name = "colCutiBesar";
			this.colCutiBesar.Visible = true;
			this.colCutiBesar.VisibleIndex = 15;
			this.colCutiBesar.Width = 81;
			// 
			// gridColumn118
			// 
			this.gridColumn118.Caption = "Jadwal Produksi";
			this.gridColumn118.FieldName = "JadwalProduksi.Id";
			this.gridColumn118.Name = "gridColumn118";
			this.gridColumn118.OptionsColumn.ReadOnly = true;
			this.gridColumn118.Width = 81;
			// 
			// colLupaAbsen
			// 
			this.colLupaAbsen.Caption = "Lupa Absen";
			this.colLupaAbsen.FieldName = "LupaAbsen";
			this.colLupaAbsen.Name = "colLupaAbsen";
			this.colLupaAbsen.Visible = true;
			this.colLupaAbsen.VisibleIndex = 16;
			this.colLupaAbsen.Width = 81;
			// 
			// colReimbusMakan
			// 
			this.colReimbusMakan.Caption = "Reimbus Makan";
			this.colReimbusMakan.FieldName = "ReimbusMakan";
			this.colReimbusMakan.Name = "colReimbusMakan";
			this.colReimbusMakan.Visible = true;
			this.colReimbusMakan.VisibleIndex = 17;
			this.colReimbusMakan.Width = 107;
			// 
			// btnCreateAbsensi
			// 
			this.btnCreateAbsensi.Caption = "Create Absensi";
			this.btnCreateAbsensi.Glyph = ((System.Drawing.Image)(resources.GetObject("btnCreateAbsensi.Glyph")));
			this.btnCreateAbsensi.Id = 13;
			this.btnCreateAbsensi.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnCreateAbsensi.LargeGlyph")));
			this.btnCreateAbsensi.Name = "btnCreateAbsensi";
			// 
			// barButtonItem2
			// 
			this.barButtonItem2.Caption = "Get Data";
			this.barButtonItem2.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem2.Glyph")));
			this.barButtonItem2.Id = 14;
			this.barButtonItem2.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem2.LargeGlyph")));
			this.barButtonItem2.Name = "barButtonItem2";
			// 
			// barButtonItem3
			// 
			this.barButtonItem3.Caption = "Lupa Absensi";
			this.barButtonItem3.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem3.Glyph")));
			this.barButtonItem3.Id = 15;
			this.barButtonItem3.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem3.LargeGlyph")));
			this.barButtonItem3.Name = "barButtonItem3";
			// 
			// UI_Absensi
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1136, 507);
			this.Name = "UI_Absensi";
			this.Text = "Absensi";
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

		private DevExpress.XtraGrid.Columns.GridColumn colcreated_date;
		private DevExpress.XtraGrid.Columns.GridColumn colcreated_user;
		private DevExpress.XtraGrid.Columns.GridColumn collast_date;
		private DevExpress.XtraGrid.Columns.GridColumn collast_modified;
		private DevExpress.XtraGrid.Columns.GridColumn colId;
		private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
		private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
		private DevExpress.XtraGrid.Columns.GridColumn colTanggal;
		private DevExpress.XtraGrid.Columns.GridColumn colJamMasuk;
		private DevExpress.XtraGrid.Columns.GridColumn colJamPulang;
		private DevExpress.XtraGrid.Columns.GridColumn gridColumn92;
		private DevExpress.XtraGrid.Columns.GridColumn colCatatan;
		private DevExpress.XtraGrid.Columns.GridColumn gridColumn98;
		private DevExpress.XtraGrid.Columns.GridColumn gridColumn99;
		private DevExpress.XtraGrid.Columns.GridColumn gridColumn111;
		private DevExpress.XtraGrid.Columns.GridColumn gridColumn112;
		private DevExpress.XtraGrid.Columns.GridColumn gridColumn113;
		private DevExpress.XtraGrid.Columns.GridColumn colHariKerja;
		private DevExpress.XtraGrid.Columns.GridColumn colLembur;
		private DevExpress.XtraGrid.Columns.GridColumn colLemburPengganti;
		private DevExpress.XtraGrid.Columns.GridColumn colLiburNasional;
		private DevExpress.XtraGrid.Columns.GridColumn colCutiBesar;
		private DevExpress.XtraGrid.Columns.GridColumn gridColumn118;
		private DevExpress.XtraGrid.Columns.GridColumn colLupaAbsen;
		private DevExpress.XtraGrid.Columns.GridColumn colReimbusMakan;
		private DevExpress.XtraBars.BarButtonItem btnCreateAbsensi;
		private DevExpress.XtraBars.BarButtonItem barButtonItem2;
		private DevExpress.XtraBars.BarButtonItem barButtonItem3;
	}
}