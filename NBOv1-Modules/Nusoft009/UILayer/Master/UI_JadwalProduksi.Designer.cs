namespace NuSoft.NUI.Win.Forms.Modules.NuSoft009.UILayer.Master
{
	partial class UI_JadwalProduksi
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UI_JadwalProduksi));
			this.colcreated_date = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colcreated_user = new DevExpress.XtraGrid.Columns.GridColumn();
			this.collast_date = new DevExpress.XtraGrid.Columns.GridColumn();
			this.collast_modified = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colJenis = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colTahun = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colTanggalAwal = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colTanggalAkhir = new DevExpress.XtraGrid.Columns.GridColumn();
			this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colStatus = new DevExpress.XtraGrid.Columns.GridColumn();
			this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.gridColumn9 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.gridColumn10 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.gridColumn11 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.gridColumn12 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.gridColumn13 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.gridColumn14 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.gridColumn15 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.gridColumn16 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.gridColumn17 = new DevExpress.XtraGrid.Columns.GridColumn();
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
            this.colJenis,
            this.colTahun,
            this.colTanggalAwal,
            this.colTanggalAkhir,
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.colStatus,
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn6,
            this.gridColumn7,
            this.gridColumn8,
            this.gridColumn9,
            this.gridColumn10,
            this.gridColumn11,
            this.gridColumn12,
            this.gridColumn13,
            this.gridColumn14,
            this.gridColumn15,
            this.gridColumn16,
            this.gridColumn17});
			this.xGridView.OptionsBehavior.Editable = false;
			this.xGridView.OptionsDetail.EnableMasterViewMode = false;
			this.xGridView.OptionsSelection.MultiSelect = true;
			this.xGridView.OptionsView.ShowGroupPanel = false;
			// 
			// ifSource
			// 
			this.ifSource.DisplayableProperties = resources.GetString("ifSource.DisplayableProperties");
			this.ifSource.ObjectType = typeof(NuSoft.NUI.Win.Forms.Modules.NuSoft09.Persistent.JadwalProduksi);
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
			// colJenis
			// 
			this.colJenis.FieldName = "Jenis";
			this.colJenis.Name = "colJenis";
			this.colJenis.Visible = true;
			this.colJenis.VisibleIndex = 0;
			// 
			// colTahun
			// 
			this.colTahun.FieldName = "Tahun";
			this.colTahun.Name = "colTahun";
			this.colTahun.Visible = true;
			this.colTahun.VisibleIndex = 1;
			// 
			// colTanggalAwal
			// 
			this.colTanggalAwal.FieldName = "TanggalAwal";
			this.colTanggalAwal.Name = "colTanggalAwal";
			this.colTanggalAwal.Visible = true;
			this.colTanggalAwal.VisibleIndex = 2;
			// 
			// colTanggalAkhir
			// 
			this.colTanggalAkhir.FieldName = "TanggalAkhir";
			this.colTanggalAkhir.Name = "colTanggalAkhir";
			this.colTanggalAkhir.Visible = true;
			this.colTanggalAkhir.VisibleIndex = 3;
			// 
			// gridColumn1
			// 
			this.gridColumn1.FieldName = "Divisi.Id";
			this.gridColumn1.Name = "gridColumn1";
			this.gridColumn1.OptionsColumn.ReadOnly = true;
			// 
			// gridColumn2
			// 
			this.gridColumn2.Caption = "Kode Divisi";
			this.gridColumn2.FieldName = "Divisi.Kode";
			this.gridColumn2.Name = "gridColumn2";
			this.gridColumn2.OptionsColumn.ReadOnly = true;
			this.gridColumn2.Visible = true;
			this.gridColumn2.VisibleIndex = 4;
			// 
			// gridColumn3
			// 
			this.gridColumn3.FieldName = "Divisi.Nama";
			this.gridColumn3.Name = "gridColumn3";
			this.gridColumn3.OptionsColumn.ReadOnly = true;
			// 
			// colStatus
			// 
			this.colStatus.Caption = "Status";
			this.colStatus.FieldName = "Status";
			this.colStatus.Name = "colStatus";
			this.colStatus.Visible = true;
			this.colStatus.VisibleIndex = 5;
			// 
			// gridColumn4
			// 
			this.gridColumn4.Caption = "P1";
			this.gridColumn4.FieldName = "P1.Kode";
			this.gridColumn4.Name = "gridColumn4";
			this.gridColumn4.OptionsColumn.ReadOnly = true;
			this.gridColumn4.Visible = true;
			this.gridColumn4.VisibleIndex = 6;
			// 
			// gridColumn5
			// 
			this.gridColumn5.Caption = "P2";
			this.gridColumn5.FieldName = "P2.Kode";
			this.gridColumn5.Name = "gridColumn5";
			this.gridColumn5.OptionsColumn.ReadOnly = true;
			this.gridColumn5.Visible = true;
			this.gridColumn5.VisibleIndex = 7;
			// 
			// gridColumn6
			// 
			this.gridColumn6.Caption = "P3";
			this.gridColumn6.FieldName = "P3.Kode";
			this.gridColumn6.Name = "gridColumn6";
			this.gridColumn6.OptionsColumn.ReadOnly = true;
			this.gridColumn6.Visible = true;
			this.gridColumn6.VisibleIndex = 8;
			// 
			// gridColumn7
			// 
			this.gridColumn7.Caption = "P4";
			this.gridColumn7.FieldName = "P4.Kode";
			this.gridColumn7.Name = "gridColumn7";
			this.gridColumn7.OptionsColumn.ReadOnly = true;
			this.gridColumn7.Visible = true;
			this.gridColumn7.VisibleIndex = 9;
			// 
			// gridColumn8
			// 
			this.gridColumn8.Caption = "P5";
			this.gridColumn8.FieldName = "P5.Kode";
			this.gridColumn8.Name = "gridColumn8";
			this.gridColumn8.OptionsColumn.ReadOnly = true;
			this.gridColumn8.Visible = true;
			this.gridColumn8.VisibleIndex = 10;
			// 
			// gridColumn9
			// 
			this.gridColumn9.Caption = "P6";
			this.gridColumn9.FieldName = "P6.Kode";
			this.gridColumn9.Name = "gridColumn9";
			this.gridColumn9.OptionsColumn.ReadOnly = true;
			this.gridColumn9.Visible = true;
			this.gridColumn9.VisibleIndex = 11;
			// 
			// gridColumn10
			// 
			this.gridColumn10.Caption = "P7";
			this.gridColumn10.FieldName = "P7.Kode";
			this.gridColumn10.Name = "gridColumn10";
			this.gridColumn10.OptionsColumn.ReadOnly = true;
			this.gridColumn10.Visible = true;
			this.gridColumn10.VisibleIndex = 12;
			// 
			// gridColumn11
			// 
			this.gridColumn11.Caption = "P8";
			this.gridColumn11.FieldName = "P8.Kode";
			this.gridColumn11.Name = "gridColumn11";
			this.gridColumn11.OptionsColumn.ReadOnly = true;
			this.gridColumn11.Visible = true;
			this.gridColumn11.VisibleIndex = 13;
			// 
			// gridColumn12
			// 
			this.gridColumn12.Caption = "P9";
			this.gridColumn12.FieldName = "P9.Kode";
			this.gridColumn12.Name = "gridColumn12";
			this.gridColumn12.OptionsColumn.ReadOnly = true;
			this.gridColumn12.Visible = true;
			this.gridColumn12.VisibleIndex = 14;
			// 
			// gridColumn13
			// 
			this.gridColumn13.Caption = "P10";
			this.gridColumn13.FieldName = "P10.Kode";
			this.gridColumn13.Name = "gridColumn13";
			this.gridColumn13.OptionsColumn.ReadOnly = true;
			this.gridColumn13.Visible = true;
			this.gridColumn13.VisibleIndex = 15;
			// 
			// gridColumn14
			// 
			this.gridColumn14.Caption = "P11";
			this.gridColumn14.FieldName = "P11.Kode";
			this.gridColumn14.Name = "gridColumn14";
			this.gridColumn14.OptionsColumn.ReadOnly = true;
			this.gridColumn14.Visible = true;
			this.gridColumn14.VisibleIndex = 16;
			// 
			// gridColumn15
			// 
			this.gridColumn15.Caption = "P12";
			this.gridColumn15.FieldName = "P12.Kode";
			this.gridColumn15.Name = "gridColumn15";
			this.gridColumn15.OptionsColumn.ReadOnly = true;
			this.gridColumn15.Visible = true;
			this.gridColumn15.VisibleIndex = 17;
			// 
			// gridColumn16
			// 
			this.gridColumn16.Caption = "P13";
			this.gridColumn16.FieldName = "P13.Kode";
			this.gridColumn16.Name = "gridColumn16";
			this.gridColumn16.OptionsColumn.ReadOnly = true;
			this.gridColumn16.Visible = true;
			this.gridColumn16.VisibleIndex = 18;
			// 
			// gridColumn17
			// 
			this.gridColumn17.Caption = "P14";
			this.gridColumn17.FieldName = "P14.Kode";
			this.gridColumn17.Name = "gridColumn17";
			this.gridColumn17.OptionsColumn.ReadOnly = true;
			this.gridColumn17.Visible = true;
			this.gridColumn17.VisibleIndex = 19;
			// 
			// UI_JadwalProduksi
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Name = "UI_JadwalProduksi";
			this.Text = "Jadwal Produksi";
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
		private DevExpress.XtraGrid.Columns.GridColumn colJenis;
		private DevExpress.XtraGrid.Columns.GridColumn colTahun;
		private DevExpress.XtraGrid.Columns.GridColumn colTanggalAwal;
		private DevExpress.XtraGrid.Columns.GridColumn colTanggalAkhir;
		private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
		private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
		private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
		private DevExpress.XtraGrid.Columns.GridColumn colStatus;
		private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
		private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
		private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
		private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
		private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
		private DevExpress.XtraGrid.Columns.GridColumn gridColumn9;
		private DevExpress.XtraGrid.Columns.GridColumn gridColumn10;
		private DevExpress.XtraGrid.Columns.GridColumn gridColumn11;
		private DevExpress.XtraGrid.Columns.GridColumn gridColumn12;
		private DevExpress.XtraGrid.Columns.GridColumn gridColumn13;
		private DevExpress.XtraGrid.Columns.GridColumn gridColumn14;
		private DevExpress.XtraGrid.Columns.GridColumn gridColumn15;
		private DevExpress.XtraGrid.Columns.GridColumn gridColumn16;
		private DevExpress.XtraGrid.Columns.GridColumn gridColumn17;
	}
}