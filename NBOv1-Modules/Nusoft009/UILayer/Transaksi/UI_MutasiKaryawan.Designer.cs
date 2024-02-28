namespace NuSoft.NUI.Win.Forms.Modules.NuSoft009.UILayer.Transaksi
{
	partial class UI_MutasiKaryawan
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UI_MutasiKaryawan));
			this.colcreated_date = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colcreated_user = new DevExpress.XtraGrid.Columns.GridColumn();
			this.collast_date = new DevExpress.XtraGrid.Columns.GridColumn();
			this.collast_modified = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
			this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colTanggal = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colCatatan = new DevExpress.XtraGrid.Columns.GridColumn();
			this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colGajiPokok = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colTunjanganJabatan = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colTunjanganLain = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colTunjanganTenagaKerja = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colTunjanganGolongan = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colPotonganKesehatan = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colPotonganPensiun = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colPotonganLain = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colPremiKehadiran = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colJenis = new DevExpress.XtraGrid.Columns.GridColumn();
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
			this.xGrid.Size = new System.Drawing.Size(800, 423);
			// 
			// xGridView
			// 
			this.xGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colcreated_date,
            this.colcreated_user,
            this.collast_date,
            this.collast_modified,
            this.colId,
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.colTanggal,
            this.colCatatan,
            this.gridColumn4,
            this.gridColumn5,
            this.colGajiPokok,
            this.colTunjanganJabatan,
            this.colTunjanganLain,
            this.colTunjanganTenagaKerja,
            this.colTunjanganGolongan,
            this.colPotonganKesehatan,
            this.colPotonganPensiun,
            this.colPotonganLain,
            this.colPremiKehadiran,
            this.colJenis});
			this.xGridView.GroupCount = 1;
			this.xGridView.OptionsBehavior.Editable = false;
			this.xGridView.OptionsDetail.EnableMasterViewMode = false;
			this.xGridView.OptionsSelection.MultiSelect = true;
			this.xGridView.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colJenis, DevExpress.Data.ColumnSortOrder.Ascending)});
			// 
			// ifSource
			// 
			this.ifSource.DisplayableProperties = resources.GetString("ifSource.DisplayableProperties");
			this.ifSource.ObjectType = typeof(NuSoft.NUI.Win.Forms.Modules.NuSoft09.Persistent.PromosiKaryawan);
			// 
			// barMenu
			// 
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
			// gridColumn1
			// 
			this.gridColumn1.FieldName = "Karyawan.Id";
			this.gridColumn1.Name = "gridColumn1";
			this.gridColumn1.OptionsColumn.ReadOnly = true;
			// 
			// gridColumn2
			// 
			this.gridColumn2.Caption = "Kode Karyawan";
			this.gridColumn2.FieldName = "Karyawan.Kode";
			this.gridColumn2.Name = "gridColumn2";
			this.gridColumn2.OptionsColumn.ReadOnly = true;
			this.gridColumn2.Visible = true;
			this.gridColumn2.VisibleIndex = 0;
			// 
			// gridColumn3
			// 
			this.gridColumn3.Caption = "Nama Karyawan";
			this.gridColumn3.FieldName = "Karyawan.Nama";
			this.gridColumn3.Name = "gridColumn3";
			this.gridColumn3.OptionsColumn.ReadOnly = true;
			this.gridColumn3.Visible = true;
			this.gridColumn3.VisibleIndex = 1;
			// 
			// colTanggal
			// 
			this.colTanggal.Caption = "Tanggal";
			this.colTanggal.FieldName = "Tanggal";
			this.colTanggal.Name = "colTanggal";
			this.colTanggal.Visible = true;
			this.colTanggal.VisibleIndex = 2;
			// 
			// colCatatan
			// 
			this.colCatatan.Caption = "Catatan";
			this.colCatatan.FieldName = "Catatan";
			this.colCatatan.Name = "colCatatan";
			this.colCatatan.Visible = true;
			this.colCatatan.VisibleIndex = 3;
			// 
			// gridColumn4
			// 
			this.gridColumn4.Caption = "Kode Jabatan";
			this.gridColumn4.FieldName = "Jabatan.Kode";
			this.gridColumn4.Name = "gridColumn4";
			this.gridColumn4.OptionsColumn.ReadOnly = true;
			this.gridColumn4.Visible = true;
			this.gridColumn4.VisibleIndex = 4;
			// 
			// gridColumn5
			// 
			this.gridColumn5.Caption = "Nama Jabatan";
			this.gridColumn5.FieldName = "Jabatan.Nama";
			this.gridColumn5.Name = "gridColumn5";
			this.gridColumn5.OptionsColumn.ReadOnly = true;
			this.gridColumn5.Visible = true;
			this.gridColumn5.VisibleIndex = 5;
			// 
			// colGajiPokok
			// 
			this.colGajiPokok.Caption = "Gaji Pokok";
			this.colGajiPokok.FieldName = "GajiPokok";
			this.colGajiPokok.Name = "colGajiPokok";
			this.colGajiPokok.Visible = true;
			this.colGajiPokok.VisibleIndex = 6;
			// 
			// colTunjanganJabatan
			// 
			this.colTunjanganJabatan.Caption = "Tun Jabatan";
			this.colTunjanganJabatan.FieldName = "TunjanganJabatan";
			this.colTunjanganJabatan.Name = "colTunjanganJabatan";
			this.colTunjanganJabatan.Visible = true;
			this.colTunjanganJabatan.VisibleIndex = 7;
			// 
			// colTunjanganLain
			// 
			this.colTunjanganLain.Caption = "Tun Lain";
			this.colTunjanganLain.FieldName = "TunjanganLain";
			this.colTunjanganLain.Name = "colTunjanganLain";
			this.colTunjanganLain.Visible = true;
			this.colTunjanganLain.VisibleIndex = 8;
			// 
			// colTunjanganTenagaKerja
			// 
			this.colTunjanganTenagaKerja.Caption = "Tun Tenaga Kerja";
			this.colTunjanganTenagaKerja.FieldName = "TunjanganTenagaKerja";
			this.colTunjanganTenagaKerja.Name = "colTunjanganTenagaKerja";
			this.colTunjanganTenagaKerja.Visible = true;
			this.colTunjanganTenagaKerja.VisibleIndex = 9;
			// 
			// colTunjanganGolongan
			// 
			this.colTunjanganGolongan.Caption = "Tun Golongan";
			this.colTunjanganGolongan.FieldName = "TunjanganGolongan";
			this.colTunjanganGolongan.Name = "colTunjanganGolongan";
			this.colTunjanganGolongan.Visible = true;
			this.colTunjanganGolongan.VisibleIndex = 10;
			// 
			// colPotonganKesehatan
			// 
			this.colPotonganKesehatan.Caption = "Pot Kesehatan";
			this.colPotonganKesehatan.FieldName = "PotonganKesehatan";
			this.colPotonganKesehatan.Name = "colPotonganKesehatan";
			this.colPotonganKesehatan.Visible = true;
			this.colPotonganKesehatan.VisibleIndex = 12;
			// 
			// colPotonganPensiun
			// 
			this.colPotonganPensiun.Caption = "Pot Pensiun";
			this.colPotonganPensiun.FieldName = "PotonganPensiun";
			this.colPotonganPensiun.Name = "colPotonganPensiun";
			this.colPotonganPensiun.Visible = true;
			this.colPotonganPensiun.VisibleIndex = 13;
			// 
			// colPotonganLain
			// 
			this.colPotonganLain.Caption = "Pot Lain";
			this.colPotonganLain.FieldName = "PotonganLain";
			this.colPotonganLain.Name = "colPotonganLain";
			this.colPotonganLain.Visible = true;
			this.colPotonganLain.VisibleIndex = 14;
			// 
			// colPremiKehadiran
			// 
			this.colPremiKehadiran.Caption = "Premi Kehadiran";
			this.colPremiKehadiran.FieldName = "PremiKehadiran.Nilai";
			this.colPremiKehadiran.Name = "colPremiKehadiran";
			this.colPremiKehadiran.Visible = true;
			this.colPremiKehadiran.VisibleIndex = 11;
			// 
			// colJenis
			// 
			this.colJenis.Caption = "Jenis";
			this.colJenis.FieldName = "Jenis";
			this.colJenis.Name = "colJenis";
			this.colJenis.Visible = true;
			this.colJenis.VisibleIndex = 15;
			// 
			// UI_MutasiKaryawan
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Name = "UI_MutasiKaryawan";
			this.Text = "Mutasi Karyawan";
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
		private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
		private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
		private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
		private DevExpress.XtraGrid.Columns.GridColumn colTanggal;
		private DevExpress.XtraGrid.Columns.GridColumn colCatatan;
		private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
		private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
		private DevExpress.XtraGrid.Columns.GridColumn colGajiPokok;
		private DevExpress.XtraGrid.Columns.GridColumn colTunjanganJabatan;
		private DevExpress.XtraGrid.Columns.GridColumn colTunjanganLain;
		private DevExpress.XtraGrid.Columns.GridColumn colTunjanganTenagaKerja;
		private DevExpress.XtraGrid.Columns.GridColumn colTunjanganGolongan;
		private DevExpress.XtraGrid.Columns.GridColumn colPotonganKesehatan;
		private DevExpress.XtraGrid.Columns.GridColumn colPotonganPensiun;
		private DevExpress.XtraGrid.Columns.GridColumn colPotonganLain;
		private DevExpress.XtraGrid.Columns.GridColumn colPremiKehadiran;
		private DevExpress.XtraGrid.Columns.GridColumn colJenis;
	}
}