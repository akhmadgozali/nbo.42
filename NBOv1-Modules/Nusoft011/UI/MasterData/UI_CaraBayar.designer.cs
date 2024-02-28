namespace NuSoft.NUI.Win.Forms.Modules.NuSoft011.UI.MasterData
{
	partial class UI_CaraBayar
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
			this.colKodeAkun = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colNamaAkun = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colAlias = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colKeterangan = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colAktif = new DevExpress.XtraGrid.Columns.GridColumn();
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
            this.colKodeAkun,
            this.colNamaAkun,
            this.colAlias,
            this.colAktif,
            this.colKeterangan,
            this.colId});
			this.xGridView.OptionsBehavior.Editable = false;
			this.xGridView.OptionsDetail.EnableMasterViewMode = false;
			this.xGridView.OptionsSelection.MultiSelect = true;
			this.xGridView.OptionsView.ShowGroupPanel = false;
			// 
			// ifSource
			// 
			this.ifSource.DisplayableProperties = "Id;Akun.Kode;Akun.Nama;Alias;Aktif;Keterangan";
			this.ifSource.ObjectType = typeof(NuSoft.NUI.Win.Forms.Modules.NuSoft011.Persistent.CaraBayar);
			// 
			// barMenu
			// 
			this.barMenu.OptionsBar.AllowQuickCustomization = false;
			this.barMenu.OptionsBar.DrawDragBorder = false;
			this.barMenu.OptionsBar.UseWholeRow = true;
			// 
			// colKodeAkun
			// 
			this.colKodeAkun.Caption = "Kode COA";
			this.colKodeAkun.FieldName = "Akun.Kode";
			this.colKodeAkun.Name = "colKodeAkun";
			this.colKodeAkun.Visible = true;
			this.colKodeAkun.VisibleIndex = 0;
			this.colKodeAkun.Width = 149;
			// 
			// colNamaAkun
			// 
			this.colNamaAkun.Caption = "Nama COA";
			this.colNamaAkun.FieldName = "Akun.Nama";
			this.colNamaAkun.Name = "colNamaAkun";
			this.colNamaAkun.Visible = true;
			this.colNamaAkun.VisibleIndex = 1;
			this.colNamaAkun.Width = 149;
			// 
			// colAlias
			// 
			this.colAlias.Caption = "Alias";
			this.colAlias.FieldName = "Alias";
			this.colAlias.Name = "colAlias";
			this.colAlias.Visible = true;
			this.colAlias.VisibleIndex = 2;
			this.colAlias.Width = 149;
			// 
			// colKeterangan
			// 
			this.colKeterangan.FieldName = "Keterangan";
			this.colKeterangan.Name = "colKeterangan";
			this.colKeterangan.Visible = true;
			this.colKeterangan.VisibleIndex = 4;
			this.colKeterangan.Width = 270;
			// 
			// colId
			// 
			this.colId.FieldName = "Id";
			this.colId.Name = "colId";
			// 
			// colAktif
			// 
			this.colAktif.Caption = "Aktif";
			this.colAktif.FieldName = "Aktif";
			this.colAktif.Name = "colAktif";
			this.colAktif.Visible = true;
			this.colAktif.VisibleIndex = 3;
			this.colAktif.Width = 30;
			// 
			// UI_CaraBayar
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(765, 402);
			this.Name = "UI_CaraBayar";
			this.Text = "Cara Bayar";
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

		private DevExpress.XtraGrid.Columns.GridColumn colKodeAkun;
		private DevExpress.XtraGrid.Columns.GridColumn colNamaAkun;
		private DevExpress.XtraGrid.Columns.GridColumn colAlias;
		private DevExpress.XtraGrid.Columns.GridColumn colKeterangan;
		private DevExpress.XtraGrid.Columns.GridColumn colId;
		private DevExpress.XtraGrid.Columns.GridColumn colAktif;
	}
}
