namespace NuSoft.NUI.Win.Forms.Modules.NuSoft009.UILayer.Transaksi
{
	partial class UI_RealisasiCuti
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UI_RealisasiCuti));
			this.colcreated_date = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colcreated_user = new DevExpress.XtraGrid.Columns.GridColumn();
			this.collast_date = new DevExpress.XtraGrid.Columns.GridColumn();
			this.collast_modified = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colTahun = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colBulan = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colUrutan = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colKode = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colTanggal = new DevExpress.XtraGrid.Columns.GridColumn();
			this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colCutiMendadak = new DevExpress.XtraGrid.Columns.GridColumn();
			this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colCutiBesar = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colCutiKompensasi = new DevExpress.XtraGrid.Columns.GridColumn();
			this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colTanggalAwal = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colTanggalAkhir = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colKeterangan = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colJumlahHari = new DevExpress.XtraGrid.Columns.GridColumn();
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
            this.colTahun,
            this.colBulan,
            this.colUrutan,
            this.colKode,
            this.colTanggal,
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.colCutiMendadak,
            this.gridColumn4,
            this.gridColumn5,
            this.colCutiBesar,
            this.colCutiKompensasi,
            this.gridColumn6,
            this.gridColumn7,
            this.colTanggalAwal,
            this.colTanggalAkhir,
            this.colKeterangan,
            this.colJumlahHari});
			this.xGridView.GroupCount = 2;
			this.xGridView.OptionsBehavior.Editable = false;
			this.xGridView.OptionsDetail.EnableMasterViewMode = false;
			this.xGridView.OptionsSelection.MultiSelect = true;
			this.xGridView.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colTahun, DevExpress.Data.ColumnSortOrder.Ascending),
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colBulan, DevExpress.Data.ColumnSortOrder.Ascending),
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.gridColumn4, DevExpress.Data.ColumnSortOrder.Ascending)});
			// 
			// ifSource
			// 
			this.ifSource.DisplayableProperties = resources.GetString("ifSource.DisplayableProperties");
			this.ifSource.ObjectType = typeof(NuSoft.NUI.Win.Forms.Modules.NuSoft09.Persistent.RealisasiCuti);
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
			// colTahun
			// 
			this.colTahun.FieldName = "Tahun";
			this.colTahun.Name = "colTahun";
			this.colTahun.Visible = true;
			this.colTahun.VisibleIndex = 0;
			// 
			// colBulan
			// 
			this.colBulan.FieldName = "Bulan";
			this.colBulan.Name = "colBulan";
			this.colBulan.Visible = true;
			this.colBulan.VisibleIndex = 5;
			// 
			// colUrutan
			// 
			this.colUrutan.FieldName = "Urutan";
			this.colUrutan.Name = "colUrutan";
			// 
			// colKode
			// 
			this.colKode.Caption = "No Bukti";
			this.colKode.FieldName = "Kode";
			this.colKode.Name = "colKode";
			this.colKode.Visible = true;
			this.colKode.VisibleIndex = 1;
			// 
			// colTanggal
			// 
			this.colTanggal.Caption = "Tanggal";
			this.colTanggal.FieldName = "Tanggal";
			this.colTanggal.Name = "colTanggal";
			this.colTanggal.Visible = true;
			this.colTanggal.VisibleIndex = 2;
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
			this.gridColumn2.VisibleIndex = 3;
			// 
			// gridColumn3
			// 
			this.gridColumn3.Caption = "Nama Karyawan";
			this.gridColumn3.FieldName = "Karyawan.Nama";
			this.gridColumn3.Name = "gridColumn3";
			this.gridColumn3.OptionsColumn.ReadOnly = true;
			this.gridColumn3.Visible = true;
			this.gridColumn3.VisibleIndex = 4;
			// 
			// colCutiMendadak
			// 
			this.colCutiMendadak.Caption = "Cuti Mendadak";
			this.colCutiMendadak.FieldName = "CutiMendadak";
			this.colCutiMendadak.Name = "colCutiMendadak";
			this.colCutiMendadak.Visible = true;
			this.colCutiMendadak.VisibleIndex = 5;
			// 
			// gridColumn4
			// 
			this.gridColumn4.FieldName = "CutiMaster.Id";
			this.gridColumn4.Name = "gridColumn4";
			this.gridColumn4.OptionsColumn.ReadOnly = true;
			// 
			// gridColumn5
			// 
			this.gridColumn5.FieldName = "CutiMaster.Tahun";
			this.gridColumn5.Name = "gridColumn5";
			this.gridColumn5.OptionsColumn.ReadOnly = true;
			// 
			// colCutiBesar
			// 
			this.colCutiBesar.Caption = "Jenis";
			this.colCutiBesar.FieldName = "CutiBesar";
			this.colCutiBesar.Name = "colCutiBesar";
			this.colCutiBesar.Visible = true;
			this.colCutiBesar.VisibleIndex = 0;
			// 
			// colCutiKompensasi
			// 
			this.colCutiKompensasi.Caption = "Kompensasi Cuti";
			this.colCutiKompensasi.FieldName = "CutiKompensasi";
			this.colCutiKompensasi.Name = "colCutiKompensasi";
			this.colCutiKompensasi.Visible = true;
			this.colCutiKompensasi.VisibleIndex = 6;
			// 
			// gridColumn6
			// 
			this.gridColumn6.FieldName = "CutiPengajuan.Id";
			this.gridColumn6.Name = "gridColumn6";
			this.gridColumn6.OptionsColumn.ReadOnly = true;
			// 
			// gridColumn7
			// 
			this.gridColumn7.Caption = "No Pengajuan";
			this.gridColumn7.FieldName = "CutiPengajuan.Kode";
			this.gridColumn7.Name = "gridColumn7";
			this.gridColumn7.OptionsColumn.ReadOnly = true;
			this.gridColumn7.Visible = true;
			this.gridColumn7.VisibleIndex = 7;
			// 
			// colTanggalAwal
			// 
			this.colTanggalAwal.Caption = "Tanggal Awal";
			this.colTanggalAwal.FieldName = "TanggalAwal";
			this.colTanggalAwal.Name = "colTanggalAwal";
			this.colTanggalAwal.Visible = true;
			this.colTanggalAwal.VisibleIndex = 8;
			// 
			// colTanggalAkhir
			// 
			this.colTanggalAkhir.Caption = "Tanggal Akhir";
			this.colTanggalAkhir.FieldName = "TanggalAkhir";
			this.colTanggalAkhir.Name = "colTanggalAkhir";
			this.colTanggalAkhir.Visible = true;
			this.colTanggalAkhir.VisibleIndex = 9;
			// 
			// colKeterangan
			// 
			this.colKeterangan.Caption = "Keterangan";
			this.colKeterangan.FieldName = "Keterangan";
			this.colKeterangan.Name = "colKeterangan";
			this.colKeterangan.Visible = true;
			this.colKeterangan.VisibleIndex = 10;
			// 
			// colJumlahHari
			// 
			this.colJumlahHari.Caption = "Jumlah Hari";
			this.colJumlahHari.FieldName = "JumlahHari";
			this.colJumlahHari.Name = "colJumlahHari";
			this.colJumlahHari.Visible = true;
			this.colJumlahHari.VisibleIndex = 11;
			// 
			// UI_RealisasiCuti
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Name = "UI_RealisasiCuti";
			this.Text = "Realisasi Cuti";
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
		private DevExpress.XtraGrid.Columns.GridColumn colTahun;
		private DevExpress.XtraGrid.Columns.GridColumn colBulan;
		private DevExpress.XtraGrid.Columns.GridColumn colUrutan;
		private DevExpress.XtraGrid.Columns.GridColumn colKode;
		private DevExpress.XtraGrid.Columns.GridColumn colTanggal;
		private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
		private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
		private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
		private DevExpress.XtraGrid.Columns.GridColumn colCutiMendadak;
		private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
		private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
		private DevExpress.XtraGrid.Columns.GridColumn colCutiBesar;
		private DevExpress.XtraGrid.Columns.GridColumn colCutiKompensasi;
		private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
		private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
		private DevExpress.XtraGrid.Columns.GridColumn colTanggalAwal;
		private DevExpress.XtraGrid.Columns.GridColumn colTanggalAkhir;
		private DevExpress.XtraGrid.Columns.GridColumn colKeterangan;
		private DevExpress.XtraGrid.Columns.GridColumn colJumlahHari;
	}
}