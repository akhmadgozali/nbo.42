namespace NuSoft.NUI.Win.Forms.Modules.NuSoft009.UILayer.Transaksi
{
	partial class UI_Pinjaman
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UI_Pinjaman));
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
			this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colJenis = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colNilai = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colLama = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colStatus = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colTanggalPencairan = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colTanggalApprove = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colTanggalPotongan = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colKeterangan = new DevExpress.XtraGrid.Columns.GridColumn();
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
            this.gridColumn5,
            this.gridColumn6,
            this.gridColumn7,
            this.colJenis,
            this.colNilai,
            this.colLama,
            this.colStatus,
            this.colTanggalPencairan,
            this.colTanggalApprove,
            this.colTanggalPotongan,
            this.colKeterangan});
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
			this.ifSource.ObjectType = typeof(NuSoft.NUI.Win.Forms.Modules.NuSoft09.Persistent.Pinjaman);
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
			// gridColumn5
			// 
			this.gridColumn5.Caption = "Karyawan ID";
			this.gridColumn5.FieldName = "Karyawan.Id";
			this.gridColumn5.Name = "gridColumn5";
			this.gridColumn5.OptionsColumn.ReadOnly = true;
			this.gridColumn5.Visible = true;
			this.gridColumn5.VisibleIndex = 2;
			// 
			// gridColumn6
			// 
			this.gridColumn6.Caption = "Kode Karyawan";
			this.gridColumn6.FieldName = "Karyawan.Kode";
			this.gridColumn6.Name = "gridColumn6";
			this.gridColumn6.OptionsColumn.ReadOnly = true;
			this.gridColumn6.Visible = true;
			this.gridColumn6.VisibleIndex = 3;
			// 
			// gridColumn7
			// 
			this.gridColumn7.Caption = "Nama Karyawan";
			this.gridColumn7.FieldName = "Karyawan.Nama";
			this.gridColumn7.Name = "gridColumn7";
			this.gridColumn7.OptionsColumn.ReadOnly = true;
			this.gridColumn7.Visible = true;
			this.gridColumn7.VisibleIndex = 4;
			// 
			// colJenis
			// 
			this.colJenis.Caption = "Jenis";
			this.colJenis.FieldName = "Jenis";
			this.colJenis.Name = "colJenis";
			this.colJenis.Visible = true;
			this.colJenis.VisibleIndex = 5;
			// 
			// colNilai
			// 
			this.colNilai.Caption = "Nilai";
			this.colNilai.FieldName = "Nilai";
			this.colNilai.Name = "colNilai";
			this.colNilai.Visible = true;
			this.colNilai.VisibleIndex = 6;
			// 
			// colLama
			// 
			this.colLama.Caption = "Lama";
			this.colLama.FieldName = "Lama";
			this.colLama.Name = "colLama";
			this.colLama.Visible = true;
			this.colLama.VisibleIndex = 7;
			// 
			// colStatus
			// 
			this.colStatus.Caption = "Status";
			this.colStatus.FieldName = "Status";
			this.colStatus.Name = "colStatus";
			this.colStatus.Visible = true;
			this.colStatus.VisibleIndex = 8;
			// 
			// colTanggalPencairan
			// 
			this.colTanggalPencairan.Caption = "Tanggal Pencairan";
			this.colTanggalPencairan.FieldName = "TanggalPencairan";
			this.colTanggalPencairan.Name = "colTanggalPencairan";
			this.colTanggalPencairan.Visible = true;
			this.colTanggalPencairan.VisibleIndex = 9;
			// 
			// colTanggalApprove
			// 
			this.colTanggalApprove.Caption = "Tanggal Approve";
			this.colTanggalApprove.FieldName = "TanggalApprove";
			this.colTanggalApprove.Name = "colTanggalApprove";
			this.colTanggalApprove.Visible = true;
			this.colTanggalApprove.VisibleIndex = 10;
			// 
			// colTanggalPotongan
			// 
			this.colTanggalPotongan.Caption = "Tanggal Potongan";
			this.colTanggalPotongan.FieldName = "TanggalPotongan";
			this.colTanggalPotongan.Name = "colTanggalPotongan";
			this.colTanggalPotongan.Visible = true;
			this.colTanggalPotongan.VisibleIndex = 11;
			// 
			// colKeterangan
			// 
			this.colKeterangan.Caption = "Keterangan";
			this.colKeterangan.FieldName = "Keterangan";
			this.colKeterangan.Name = "colKeterangan";
			this.colKeterangan.Visible = true;
			this.colKeterangan.VisibleIndex = 12;
			// 
			// UI_Pinjaman
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Name = "UI_Pinjaman";
			this.Text = "Pinjaman";
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
		private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
		private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
		private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
		private DevExpress.XtraGrid.Columns.GridColumn colJenis;
		private DevExpress.XtraGrid.Columns.GridColumn colNilai;
		private DevExpress.XtraGrid.Columns.GridColumn colLama;
		private DevExpress.XtraGrid.Columns.GridColumn colStatus;
		private DevExpress.XtraGrid.Columns.GridColumn colTanggalPencairan;
		private DevExpress.XtraGrid.Columns.GridColumn colTanggalApprove;
		private DevExpress.XtraGrid.Columns.GridColumn colTanggalPotongan;
		private DevExpress.XtraGrid.Columns.GridColumn colKeterangan;
	}
}