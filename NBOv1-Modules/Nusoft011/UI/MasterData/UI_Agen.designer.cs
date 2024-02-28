namespace NuSoft.NUI.Win.Forms.Modules.NuSoft011.UI.MasterData
{
	partial class UI_Agen
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
			this.colRute = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colKode = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colNama = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colAktif = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colHargaJatah = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colHargaKonsi = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colAlamat = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colNoHP1 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colNoHP2 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colNoTelpon = new DevExpress.XtraGrid.Columns.GridColumn();
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
			this.xGrid.Size = new System.Drawing.Size(765, 375);
			// 
			// xGridView
			// 
			this.xGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colRute,
            this.colKode,
            this.colNama,
            this.colAktif,
            this.colHargaJatah,
            this.colHargaKonsi,
            this.colAlamat,
            this.colNoHP1,
            this.colNoHP2,
            this.colNoTelpon,
            this.colKeterangan});
			this.xGridView.GroupCount = 1;
			this.xGridView.OptionsBehavior.Editable = false;
			this.xGridView.OptionsDetail.EnableMasterViewMode = false;
			this.xGridView.OptionsSelection.MultiSelect = true;
			this.xGridView.OptionsView.ShowAutoFilterRow = true;
			this.xGridView.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colRute, DevExpress.Data.ColumnSortOrder.Ascending)});
			// 
			// ifSource
			// 
			this.ifSource.DisplayableProperties = "Id;Rute.Nama;Kode;Nama;Alamat;NoTelpon;NoFax;NoHP1;NoHP2;Email;Aktif;HargaJatah;H" +
    "argaKonsi;KodePelanggan;HargaLangganan;OrderTetap;Keterangan";
			this.ifSource.ObjectType = typeof(NuSoft.NUI.Win.Forms.Modules.NuSoft011.Persistent.Agen);
			// 
			// barMenu
			// 
			this.barMenu.OptionsBar.AllowQuickCustomization = false;
			this.barMenu.OptionsBar.DrawDragBorder = false;
			this.barMenu.OptionsBar.UseWholeRow = true;
			// 
			// colRute
			// 
			this.colRute.Caption = "Rute";
			this.colRute.FieldName = "Rute.Nama";
			this.colRute.Name = "colRute";
			this.colRute.Visible = true;
			this.colRute.VisibleIndex = 0;
			// 
			// colKode
			// 
			this.colKode.FieldName = "Kode";
			this.colKode.Name = "colKode";
			this.colKode.Visible = true;
			this.colKode.VisibleIndex = 0;
			this.colKode.Width = 70;
			// 
			// colNama
			// 
			this.colNama.FieldName = "Nama";
			this.colNama.Name = "colNama";
			this.colNama.Visible = true;
			this.colNama.VisibleIndex = 1;
			this.colNama.Width = 100;
			// 
			// colId
			// 
			this.colId.FieldName = "Id";
			this.colId.Name = "colId";
			// 
			// colAktif
			// 
			this.colAktif.FieldName = "Aktif";
			this.colAktif.Name = "colAktif";
			this.colAktif.Visible = true;
			this.colAktif.VisibleIndex = 2;
			this.colAktif.Width = 30;
			// 
			// colHargaJatah
			// 
			this.colHargaJatah.DisplayFormat.FormatString = "n0";
			this.colHargaJatah.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.colHargaJatah.FieldName = "HargaJatah";
			this.colHargaJatah.Name = "colHargaJatah";
			this.colHargaJatah.Visible = true;
			this.colHargaJatah.VisibleIndex = 3;
			this.colHargaJatah.Width = 70;
			// 
			// colHargaKonsi
			// 
			this.colHargaKonsi.DisplayFormat.FormatString = "n0";
			this.colHargaKonsi.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.colHargaKonsi.FieldName = "HargaKonsi";
			this.colHargaKonsi.Name = "colHargaKonsi";
			this.colHargaKonsi.Visible = true;
			this.colHargaKonsi.VisibleIndex = 4;
			this.colHargaKonsi.Width = 65;
			// 
			// colAlamat
			// 
			this.colAlamat.FieldName = "Alamat";
			this.colAlamat.Name = "colAlamat";
			this.colAlamat.Visible = true;
			this.colAlamat.VisibleIndex = 5;
			this.colAlamat.Width = 120;
			// 
			// colNoHP1
			// 
			this.colNoHP1.FieldName = "NoHP1";
			this.colNoHP1.Name = "colNoHP1";
			this.colNoHP1.Visible = true;
			this.colNoHP1.VisibleIndex = 6;
			this.colNoHP1.Width = 50;
			// 
			// colNoHP2
			// 
			this.colNoHP2.FieldName = "NoHP2";
			this.colNoHP2.Name = "colNoHP2";
			this.colNoHP2.Visible = true;
			this.colNoHP2.VisibleIndex = 7;
			this.colNoHP2.Width = 50;
			// 
			// colNoTelpon
			// 
			this.colNoTelpon.FieldName = "NoTelpon";
			this.colNoTelpon.Name = "colNoTelpon";
			this.colNoTelpon.Visible = true;
			this.colNoTelpon.VisibleIndex = 8;
			this.colNoTelpon.Width = 60;
			// 
			// colKeterangan
			// 
			this.colKeterangan.FieldName = "Keterangan";
			this.colKeterangan.Name = "colKeterangan";
			this.colKeterangan.Visible = true;
			this.colKeterangan.VisibleIndex = 9;
			this.colKeterangan.Width = 132;
			// 
			// UI_Agen
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(765, 402);
			this.Name = "UI_Agen";
			this.Text = "Agen";
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

		private DevExpress.XtraGrid.Columns.GridColumn colRute;
		private DevExpress.XtraGrid.Columns.GridColumn colKode;
		private DevExpress.XtraGrid.Columns.GridColumn colNama;
		private DevExpress.XtraGrid.Columns.GridColumn colId;
		private DevExpress.XtraGrid.Columns.GridColumn colAktif;
		private DevExpress.XtraGrid.Columns.GridColumn colHargaJatah;
		private DevExpress.XtraGrid.Columns.GridColumn colHargaKonsi;
		private DevExpress.XtraGrid.Columns.GridColumn colAlamat;
		private DevExpress.XtraGrid.Columns.GridColumn colNoHP1;
		private DevExpress.XtraGrid.Columns.GridColumn colNoHP2;
		private DevExpress.XtraGrid.Columns.GridColumn colNoTelpon;
		private DevExpress.XtraGrid.Columns.GridColumn colKeterangan;
	}
}
