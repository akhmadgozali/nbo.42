namespace NuSoft.NUI.Win.Forms.Modules.NuSoft011.UI.Transaksi
{
	partial class UI_Komplain
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
			this.colAgen = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colPelanggan = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colNomor = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colTanggal = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colPenerima = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colKeluhan = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colSolusi = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colBatasWaktu = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colHP = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colStatus = new DevExpress.XtraGrid.Columns.GridColumn();
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
			this.xGrid.Size = new System.Drawing.Size(1005, 332);
			// 
			// xGridView
			// 
			this.xGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colStatus,
            this.colAgen,
            this.colNomor,
            this.colPelanggan,
            this.colHP,
            this.colTanggal,
            this.colPenerima,
            this.colKeluhan,
            this.colBatasWaktu,
            this.colSolusi,
            this.colId});
			this.xGridView.GroupCount = 2;
			this.xGridView.OptionsBehavior.Editable = false;
			this.xGridView.OptionsDetail.EnableMasterViewMode = false;
			this.xGridView.OptionsSelection.MultiSelect = true;
			this.xGridView.OptionsView.ShowAutoFilterRow = true;
			this.xGridView.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colStatus, DevExpress.Data.ColumnSortOrder.Ascending),
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colAgen, DevExpress.Data.ColumnSortOrder.Ascending)});
			// 
			// ifSource
			// 
			this.ifSource.DisplayableProperties = "Pelanggan.Agen.Nama;Pelanggan.Nama;Pelanggan.Kode;Tanggal;Penerima;Keluhan;Solusi" +
    ";BatasWaktu;Keterangan;Pelanggan.NoHP;Id;Status";
			this.ifSource.ObjectType = typeof(NuSoft.NUI.Win.Forms.Modules.NuSoft011.Persistent.PelangganKomplain);
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
			this.colAgen.FieldName = "Pelanggan.Agen.Nama";
			this.colAgen.Name = "colAgen";
			this.colAgen.Visible = true;
			this.colAgen.VisibleIndex = 0;
			// 
			// colPelanggan
			// 
			this.colPelanggan.Caption = "Nama Pelanggan";
			this.colPelanggan.FieldName = "Pelanggan.Nama";
			this.colPelanggan.Name = "colPelanggan";
			this.colPelanggan.Visible = true;
			this.colPelanggan.VisibleIndex = 1;
			this.colPelanggan.Width = 150;
			// 
			// colNomor
			// 
			this.colNomor.Caption = "Nomor";
			this.colNomor.FieldName = "Pelanggan.Kode";
			this.colNomor.Name = "colNomor";
			this.colNomor.Visible = true;
			this.colNomor.VisibleIndex = 0;
			this.colNomor.Width = 90;
			// 
			// colTanggal
			// 
			this.colTanggal.DisplayFormat.FormatString = "dd MMM yyyy";
			this.colTanggal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
			this.colTanggal.FieldName = "Tanggal";
			this.colTanggal.Name = "colTanggal";
			this.colTanggal.Visible = true;
			this.colTanggal.VisibleIndex = 3;
			this.colTanggal.Width = 80;
			// 
			// colPenerima
			// 
			this.colPenerima.FieldName = "Penerima";
			this.colPenerima.Name = "colPenerima";
			this.colPenerima.Visible = true;
			this.colPenerima.VisibleIndex = 4;
			this.colPenerima.Width = 100;
			// 
			// colKeluhan
			// 
			this.colKeluhan.FieldName = "Keluhan";
			this.colKeluhan.Name = "colKeluhan";
			this.colKeluhan.Visible = true;
			this.colKeluhan.VisibleIndex = 5;
			this.colKeluhan.Width = 130;
			// 
			// colSolusi
			// 
			this.colSolusi.FieldName = "Solusi";
			this.colSolusi.Name = "colSolusi";
			this.colSolusi.Visible = true;
			this.colSolusi.VisibleIndex = 7;
			this.colSolusi.Width = 130;
			// 
			// colBatasWaktu
			// 
			this.colBatasWaktu.DisplayFormat.FormatString = "dd MMM yyyy";
			this.colBatasWaktu.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
			this.colBatasWaktu.FieldName = "BatasWaktu";
			this.colBatasWaktu.Name = "colBatasWaktu";
			this.colBatasWaktu.Visible = true;
			this.colBatasWaktu.VisibleIndex = 6;
			this.colBatasWaktu.Width = 80;
			// 
			// colHP
			// 
			this.colHP.Caption = "HP";
			this.colHP.FieldName = "Pelanggan.NoHP";
			this.colHP.Name = "colHP";
			this.colHP.Visible = true;
			this.colHP.VisibleIndex = 2;
			this.colHP.Width = 60;
			// 
			// colStatus
			// 
			this.colStatus.FieldName = "Status";
			this.colStatus.Name = "colStatus";
			this.colStatus.Visible = true;
			this.colStatus.VisibleIndex = 10;
			// 
			// colId
			// 
			this.colId.FieldName = "Id";
			this.colId.Name = "colId";
			// 
			// UI_Komplain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1005, 359);
			this.Name = "UI_Komplain";
			this.Text = "Komplain Pelanggan";
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

		private DevExpress.XtraGrid.Columns.GridColumn colStatus;
		private DevExpress.XtraGrid.Columns.GridColumn colAgen;
		private DevExpress.XtraGrid.Columns.GridColumn colPelanggan;
		private DevExpress.XtraGrid.Columns.GridColumn colNomor;
		private DevExpress.XtraGrid.Columns.GridColumn colTanggal;
		private DevExpress.XtraGrid.Columns.GridColumn colPenerima;
		private DevExpress.XtraGrid.Columns.GridColumn colKeluhan;
		private DevExpress.XtraGrid.Columns.GridColumn colSolusi;
		private DevExpress.XtraGrid.Columns.GridColumn colBatasWaktu;
		private DevExpress.XtraGrid.Columns.GridColumn colHP;
		private DevExpress.XtraGrid.Columns.GridColumn colId;
	}
}
