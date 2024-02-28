namespace NuSoft.NUI.Win.Forms.Modules.NuSoft009.UILayer.Transaksi
{
	partial class UI_SPKL
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
			this.colTanggalLembur = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colKeterangan = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colTanggalApp1 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colTanggalApp2 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colStatus = new DevExpress.XtraGrid.Columns.GridColumn();
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
            this.colTanggalLembur,
            this.colKeterangan,
            this.colTanggalApp1,
            this.colTanggalApp2,
            this.colStatus});
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
			this.ifSource.DisplayableProperties = "created_date;created_user;last_date;last_modified;Id;Tahun;Bulan;Urutan;Kode;Tang" +
    "gal;Divisi.Kode;TanggalLembur;Keterangan;TanggalApp1;TanggalApp2;Status";
			this.ifSource.ObjectType = typeof(NuSoft.NUI.Win.Forms.Modules.NuSoft09.Persistent.SPKL);
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
			this.gridColumn1.Caption = "Divisi";
			this.gridColumn1.FieldName = "Divisi.Kode";
			this.gridColumn1.Name = "gridColumn1";
			this.gridColumn1.OptionsColumn.ReadOnly = true;
			this.gridColumn1.Visible = true;
			this.gridColumn1.VisibleIndex = 2;
			// 
			// colTanggalLembur
			// 
			this.colTanggalLembur.Caption = "Tanggal Lembur";
			this.colTanggalLembur.FieldName = "TanggalLembur";
			this.colTanggalLembur.Name = "colTanggalLembur";
			this.colTanggalLembur.Visible = true;
			this.colTanggalLembur.VisibleIndex = 3;
			// 
			// colKeterangan
			// 
			this.colKeterangan.Caption = "Keterangan";
			this.colKeterangan.FieldName = "Keterangan";
			this.colKeterangan.Name = "colKeterangan";
			this.colKeterangan.Visible = true;
			this.colKeterangan.VisibleIndex = 4;
			// 
			// colTanggalApp1
			// 
			this.colTanggalApp1.Caption = "Tgl APP1";
			this.colTanggalApp1.FieldName = "TanggalApp1";
			this.colTanggalApp1.Name = "colTanggalApp1";
			this.colTanggalApp1.Visible = true;
			this.colTanggalApp1.VisibleIndex = 5;
			// 
			// colTanggalApp2
			// 
			this.colTanggalApp2.Caption = "Tgl APP2";
			this.colTanggalApp2.FieldName = "TanggalApp2";
			this.colTanggalApp2.Name = "colTanggalApp2";
			this.colTanggalApp2.Visible = true;
			this.colTanggalApp2.VisibleIndex = 6;
			// 
			// colStatus
			// 
			this.colStatus.Caption = "Status";
			this.colStatus.FieldName = "Status";
			this.colStatus.Name = "colStatus";
			this.colStatus.Visible = true;
			this.colStatus.VisibleIndex = 7;
			// 
			// UI_SPKL
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Name = "UI_SPKL";
			this.Text = "SPKL";
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
		private DevExpress.XtraGrid.Columns.GridColumn colTanggalLembur;
		private DevExpress.XtraGrid.Columns.GridColumn colKeterangan;
		private DevExpress.XtraGrid.Columns.GridColumn colTanggalApp1;
		private DevExpress.XtraGrid.Columns.GridColumn colTanggalApp2;
		private DevExpress.XtraGrid.Columns.GridColumn colStatus;
	}
}