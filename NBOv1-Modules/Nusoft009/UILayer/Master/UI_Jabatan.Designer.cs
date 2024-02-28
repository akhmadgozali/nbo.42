namespace NuSoft.NUI.Win.Forms.Modules.NuSoft009.UILayer.Master
{
	partial class UI_Jabatan
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
			this.colKode = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colNama = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colGajiPokok = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colTunjanganJabatan = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colTunjanganLain = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colTunjanganTenagaKerja = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colTunjanganGolongan = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colTunjanganKesehatan = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colPotonganTenagaKerja = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colPotonganKesehatan = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colPotonganPensiun = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colPotonganLain = new DevExpress.XtraGrid.Columns.GridColumn();
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
            this.colKode,
            this.colNama,
            this.colGajiPokok,
            this.colTunjanganJabatan,
            this.colTunjanganLain,
            this.colTunjanganTenagaKerja,
            this.colTunjanganGolongan,
            this.colTunjanganKesehatan,
            this.colPotonganTenagaKerja,
            this.colPotonganKesehatan,
            this.colPotonganPensiun,
            this.colPotonganLain});
			this.xGridView.OptionsBehavior.Editable = false;
			this.xGridView.OptionsDetail.EnableMasterViewMode = false;
			this.xGridView.OptionsSelection.MultiSelect = true;
			this.xGridView.OptionsView.ShowGroupPanel = false;
			// 
			// ifSource
			// 
			this.ifSource.ObjectType = typeof(NuSoft.NUI.Win.Forms.Modules.NuSoft09.Persistent.Jabatan);
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
			this.colId.Visible = true;
			this.colId.VisibleIndex = 0;
			// 
			// colKode
			// 
			this.colKode.FieldName = "Kode";
			this.colKode.Name = "colKode";
			this.colKode.Visible = true;
			this.colKode.VisibleIndex = 1;
			// 
			// colNama
			// 
			this.colNama.FieldName = "Nama";
			this.colNama.Name = "colNama";
			this.colNama.Visible = true;
			this.colNama.VisibleIndex = 2;
			// 
			// colGajiPokok
			// 
			this.colGajiPokok.FieldName = "GajiPokok";
			this.colGajiPokok.Name = "colGajiPokok";
			this.colGajiPokok.Visible = true;
			this.colGajiPokok.VisibleIndex = 3;
			// 
			// colTunjanganJabatan
			// 
			this.colTunjanganJabatan.FieldName = "TunjanganJabatan";
			this.colTunjanganJabatan.Name = "colTunjanganJabatan";
			this.colTunjanganJabatan.Visible = true;
			this.colTunjanganJabatan.VisibleIndex = 4;
			// 
			// colTunjanganLain
			// 
			this.colTunjanganLain.FieldName = "TunjanganLain";
			this.colTunjanganLain.Name = "colTunjanganLain";
			this.colTunjanganLain.Visible = true;
			this.colTunjanganLain.VisibleIndex = 5;
			// 
			// colTunjanganTenagaKerja
			// 
			this.colTunjanganTenagaKerja.FieldName = "TunjanganTenagaKerja";
			this.colTunjanganTenagaKerja.Name = "colTunjanganTenagaKerja";
			this.colTunjanganTenagaKerja.Visible = true;
			this.colTunjanganTenagaKerja.VisibleIndex = 6;
			// 
			// colTunjanganGolongan
			// 
			this.colTunjanganGolongan.FieldName = "TunjanganGolongan";
			this.colTunjanganGolongan.Name = "colTunjanganGolongan";
			this.colTunjanganGolongan.Visible = true;
			this.colTunjanganGolongan.VisibleIndex = 7;
			// 
			// colTunjanganKesehatan
			// 
			this.colTunjanganKesehatan.FieldName = "TunjanganKesehatan";
			this.colTunjanganKesehatan.Name = "colTunjanganKesehatan";
			this.colTunjanganKesehatan.Visible = true;
			this.colTunjanganKesehatan.VisibleIndex = 8;
			// 
			// colPotonganTenagaKerja
			// 
			this.colPotonganTenagaKerja.FieldName = "PotonganTenagaKerja";
			this.colPotonganTenagaKerja.Name = "colPotonganTenagaKerja";
			this.colPotonganTenagaKerja.Visible = true;
			this.colPotonganTenagaKerja.VisibleIndex = 9;
			// 
			// colPotonganKesehatan
			// 
			this.colPotonganKesehatan.FieldName = "PotonganKesehatan";
			this.colPotonganKesehatan.Name = "colPotonganKesehatan";
			this.colPotonganKesehatan.Visible = true;
			this.colPotonganKesehatan.VisibleIndex = 10;
			// 
			// colPotonganPensiun
			// 
			this.colPotonganPensiun.FieldName = "PotonganPensiun";
			this.colPotonganPensiun.Name = "colPotonganPensiun";
			this.colPotonganPensiun.Visible = true;
			this.colPotonganPensiun.VisibleIndex = 11;
			// 
			// colPotonganLain
			// 
			this.colPotonganLain.FieldName = "PotonganLain";
			this.colPotonganLain.Name = "colPotonganLain";
			this.colPotonganLain.Visible = true;
			this.colPotonganLain.VisibleIndex = 12;
			// 
			// UI_Jabatan
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Name = "UI_Jabatan";
			this.Text = "Jabatan";
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
		private DevExpress.XtraGrid.Columns.GridColumn colKode;
		private DevExpress.XtraGrid.Columns.GridColumn colNama;
		private DevExpress.XtraGrid.Columns.GridColumn colGajiPokok;
		private DevExpress.XtraGrid.Columns.GridColumn colTunjanganJabatan;
		private DevExpress.XtraGrid.Columns.GridColumn colTunjanganLain;
		private DevExpress.XtraGrid.Columns.GridColumn colTunjanganTenagaKerja;
		private DevExpress.XtraGrid.Columns.GridColumn colTunjanganGolongan;
		private DevExpress.XtraGrid.Columns.GridColumn colTunjanganKesehatan;
		private DevExpress.XtraGrid.Columns.GridColumn colPotonganTenagaKerja;
		private DevExpress.XtraGrid.Columns.GridColumn colPotonganKesehatan;
		private DevExpress.XtraGrid.Columns.GridColumn colPotonganPensiun;
		private DevExpress.XtraGrid.Columns.GridColumn colPotonganLain;
	}
}