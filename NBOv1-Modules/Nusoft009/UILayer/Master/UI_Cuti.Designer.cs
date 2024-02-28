namespace NuSoft.NUI.Win.Forms.Modules.NuSoft009.UILayer.Master
{
	partial class UI_Cuti
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
			this.colTipe = new DevExpress.XtraGrid.Columns.GridColumn();
			this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colJumlah = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colAktif = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colExpired = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colJumlahRealisasi = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colSisaSaldo = new DevExpress.XtraGrid.Columns.GridColumn();
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
			this.xGrid.DataSource = this.xpCol;
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
            this.colTipe,
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.colJumlah,
            this.colAktif,
            this.colExpired,
            this.colJumlahRealisasi,
            this.colSisaSaldo});
			this.xGridView.GroupCount = 2;
			this.xGridView.OptionsBehavior.Editable = false;
			this.xGridView.OptionsDetail.EnableMasterViewMode = false;
			this.xGridView.OptionsSelection.MultiSelect = true;
			this.xGridView.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colTahun, DevExpress.Data.ColumnSortOrder.Ascending),
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colTipe, DevExpress.Data.ColumnSortOrder.Ascending)});
			// 
			// ifSource
			// 
			this.ifSource.DisplayableProperties = "created_date;created_user;last_date;last_modified;Id;Tahun;Tipe;Karyawan.Id;Karya" +
    "wan.Kode;Karyawan.Nama;Jumlah;Aktif;Expired;JumlahRealisasi;SisaSaldo";
			this.ifSource.ObjectType = typeof(NuSoft.NUI.Win.Forms.Modules.NuSoft09.Persistent.MasterCuti);
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
			// colTipe
			// 
			this.colTipe.FieldName = "Tipe";
			this.colTipe.Name = "colTipe";
			this.colTipe.Visible = true;
			this.colTipe.VisibleIndex = 3;
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
			// colJumlah
			// 
			this.colJumlah.Caption = "Jumlah";
			this.colJumlah.FieldName = "Jumlah";
			this.colJumlah.Name = "colJumlah";
			this.colJumlah.Visible = true;
			this.colJumlah.VisibleIndex = 4;
			// 
			// colAktif
			// 
			this.colAktif.Caption = "Aktif";
			this.colAktif.FieldName = "Aktif";
			this.colAktif.Name = "colAktif";
			this.colAktif.Visible = true;
			this.colAktif.VisibleIndex = 3;
			// 
			// colExpired
			// 
			this.colExpired.Caption = "Expired";
			this.colExpired.FieldName = "Expired";
			this.colExpired.Name = "colExpired";
			this.colExpired.Visible = true;
			this.colExpired.VisibleIndex = 2;
			// 
			// colJumlahRealisasi
			// 
			this.colJumlahRealisasi.FieldName = "JumlahRealisasi";
			this.colJumlahRealisasi.Name = "colJumlahRealisasi";
			this.colJumlahRealisasi.Visible = true;
			this.colJumlahRealisasi.VisibleIndex = 5;
			// 
			// colSisaSaldo
			// 
			this.colSisaSaldo.FieldName = "SisaSaldo";
			this.colSisaSaldo.Name = "colSisaSaldo";
			this.colSisaSaldo.Visible = true;
			this.colSisaSaldo.VisibleIndex = 6;
			// 
			// UI_Cuti
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Name = "UI_Cuti";
			this.Text = "Master Cuti";
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
		private DevExpress.XtraGrid.Columns.GridColumn colTipe;
		private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
		private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
		private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
		private DevExpress.XtraGrid.Columns.GridColumn colJumlah;
		private DevExpress.XtraGrid.Columns.GridColumn colAktif;
		private DevExpress.XtraGrid.Columns.GridColumn colExpired;
		private DevExpress.XtraGrid.Columns.GridColumn colJumlahRealisasi;
		private DevExpress.XtraGrid.Columns.GridColumn colSisaSaldo;
	}
}