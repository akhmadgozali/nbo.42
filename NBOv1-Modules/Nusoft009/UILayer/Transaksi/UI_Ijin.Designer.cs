namespace NuSoft.NUI.Win.Forms.Modules.NuSoft009.UILayer.Transaksi
{
	partial class UI_Ijin
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UI_Ijin));
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
			this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colTanggalAwal = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colTanggalAkhir = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colKeterangan = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colJamAwal = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colJamAkhir = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colJumlahHari = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colReimbusMakan = new DevExpress.XtraGrid.Columns.GridColumn();
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
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn6,
            this.colTanggalAwal,
            this.colTanggalAkhir,
            this.colKeterangan,
            this.colJamAwal,
            this.colJamAkhir,
            this.colJumlahHari,
            this.colReimbusMakan});
			this.xGridView.GroupCount = 2;
			this.xGridView.OptionsBehavior.Editable = false;
			this.xGridView.OptionsDetail.EnableMasterViewMode = false;
			this.xGridView.OptionsSelection.MultiSelect = true;
			this.xGridView.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colTahun, DevExpress.Data.ColumnSortOrder.Ascending),
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colBulan, DevExpress.Data.ColumnSortOrder.Ascending)});
			// 
			// ifSource
			// 
			this.ifSource.DisplayableProperties = resources.GetString("ifSource.DisplayableProperties");
			this.ifSource.ObjectType = typeof(NuSoft.NUI.Win.Forms.Modules.NuSoft09.Persistent.Ijin);
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
			this.colTahun.Caption = "Tahun";
			this.colTahun.FieldName = "Tahun";
			this.colTahun.Name = "colTahun";
			this.colTahun.Visible = true;
			this.colTahun.VisibleIndex = 0;
			// 
			// colBulan
			// 
			this.colBulan.Caption = "Bulan";
			this.colBulan.FieldName = "Bulan";
			this.colBulan.Name = "colBulan";
			this.colBulan.Visible = true;
			this.colBulan.VisibleIndex = 1;
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
			this.colKode.VisibleIndex = 0;
			// 
			// colTanggal
			// 
			this.colTanggal.Caption = "Tanggal";
			this.colTanggal.FieldName = "Tanggal";
			this.colTanggal.Name = "colTanggal";
			this.colTanggal.Visible = true;
			this.colTanggal.VisibleIndex = 1;
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
			this.gridColumn2.VisibleIndex = 2;
			// 
			// gridColumn3
			// 
			this.gridColumn3.Caption = "Nama Karyawan";
			this.gridColumn3.FieldName = "Karyawan.Nama";
			this.gridColumn3.Name = "gridColumn3";
			this.gridColumn3.OptionsColumn.ReadOnly = true;
			this.gridColumn3.Visible = true;
			this.gridColumn3.VisibleIndex = 3;
			// 
			// gridColumn4
			// 
			this.gridColumn4.FieldName = "Jenis.Id";
			this.gridColumn4.Name = "gridColumn4";
			this.gridColumn4.OptionsColumn.ReadOnly = true;
			// 
			// gridColumn5
			// 
			this.gridColumn5.Caption = "Jenis";
			this.gridColumn5.FieldName = "Jenis.Kode";
			this.gridColumn5.Name = "gridColumn5";
			this.gridColumn5.OptionsColumn.ReadOnly = true;
			this.gridColumn5.Visible = true;
			this.gridColumn5.VisibleIndex = 4;
			// 
			// gridColumn6
			// 
			this.gridColumn6.FieldName = "Jenis.Nama";
			this.gridColumn6.Name = "gridColumn6";
			this.gridColumn6.OptionsColumn.ReadOnly = true;
			// 
			// colTanggalAwal
			// 
			this.colTanggalAwal.Caption = "Tanggal Awal";
			this.colTanggalAwal.FieldName = "TanggalAwal";
			this.colTanggalAwal.Name = "colTanggalAwal";
			this.colTanggalAwal.Visible = true;
			this.colTanggalAwal.VisibleIndex = 5;
			// 
			// colTanggalAkhir
			// 
			this.colTanggalAkhir.Caption = "Tanggal Akhir";
			this.colTanggalAkhir.FieldName = "TanggalAkhir";
			this.colTanggalAkhir.Name = "colTanggalAkhir";
			this.colTanggalAkhir.Visible = true;
			this.colTanggalAkhir.VisibleIndex = 6;
			// 
			// colKeterangan
			// 
			this.colKeterangan.Caption = "Keterangan";
			this.colKeterangan.FieldName = "Keterangan";
			this.colKeterangan.Name = "colKeterangan";
			this.colKeterangan.Visible = true;
			this.colKeterangan.VisibleIndex = 7;
			// 
			// colJamAwal
			// 
			this.colJamAwal.Caption = "Jam Awal";
			this.colJamAwal.FieldName = "JamAwal";
			this.colJamAwal.Name = "colJamAwal";
			this.colJamAwal.Visible = true;
			this.colJamAwal.VisibleIndex = 8;
			// 
			// colJamAkhir
			// 
			this.colJamAkhir.Caption = "Jam Akhir";
			this.colJamAkhir.FieldName = "JamAkhir";
			this.colJamAkhir.Name = "colJamAkhir";
			this.colJamAkhir.Visible = true;
			this.colJamAkhir.VisibleIndex = 9;
			// 
			// colJumlahHari
			// 
			this.colJumlahHari.Caption = "Jumlah Hari";
			this.colJumlahHari.FieldName = "JumlahHari";
			this.colJumlahHari.Name = "colJumlahHari";
			this.colJumlahHari.Visible = true;
			this.colJumlahHari.VisibleIndex = 10;
			// 
			// colReimbusMakan
			// 
			this.colReimbusMakan.Caption = "Reimbus Makan";
			this.colReimbusMakan.FieldName = "ReimbusMakan";
			this.colReimbusMakan.Name = "colReimbusMakan";
			this.colReimbusMakan.Visible = true;
			this.colReimbusMakan.VisibleIndex = 11;
			// 
			// UI_Ijin
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Name = "UI_Ijin";
			this.Text = "Ijin";
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
		private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
		private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
		private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
		private DevExpress.XtraGrid.Columns.GridColumn colTanggalAwal;
		private DevExpress.XtraGrid.Columns.GridColumn colTanggalAkhir;
		private DevExpress.XtraGrid.Columns.GridColumn colKeterangan;
		private DevExpress.XtraGrid.Columns.GridColumn colJamAwal;
		private DevExpress.XtraGrid.Columns.GridColumn colJamAkhir;
		private DevExpress.XtraGrid.Columns.GridColumn colJumlahHari;
		private DevExpress.XtraGrid.Columns.GridColumn colReimbusMakan;
	}
}