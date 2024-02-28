namespace NuSoft.NUI.Win.Forms.Modules.NuSoft012.UI.MasterData {
	partial class UI_Sales
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
			this.colKode = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colNama = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colTelepon = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colHP1 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colNIK = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colEmail = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colNPWP = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colAktif = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colKeterangan = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colKomisi = new DevExpress.XtraGrid.Columns.GridColumn();
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
			// 
			// xGridView
			// 
			this.xGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colKode,
            this.colNama,
            this.colTelepon,
            this.colHP1,
            this.colEmail,
            this.colNPWP,
            this.colNIK,
            this.colKomisi,
            this.colAktif,
            this.colKeterangan,
            this.colId});
			this.xGridView.OptionsBehavior.AllowFixedGroups = DevExpress.Utils.DefaultBoolean.True;
			this.xGridView.OptionsBehavior.Editable = false;
			this.xGridView.OptionsDetail.EnableMasterViewMode = false;
			this.xGridView.OptionsSelection.MultiSelect = true;
			this.xGridView.OptionsView.ShowAutoFilterRow = true;
			this.xGridView.OptionsView.ShowGroupedColumns = true;
			// 
			// ifSource
			// 
			this.ifSource.DisplayableProperties = "Id;Kode;Nama;Alamat;NPWP;NIK;NoTelpon;NoFax;NoHP1;NoHP2;Email;Aktif;KomisiDefault" +
    ";Keterangan";
			this.ifSource.ObjectType = typeof(NuSoft.NUI.Win.Forms.Modules.NuSoft012.Persistent.Sales);
			// 
			// barMenu
			// 
			this.barMenu.OptionsBar.AllowQuickCustomization = false;
			this.barMenu.OptionsBar.DrawDragBorder = false;
			this.barMenu.OptionsBar.UseWholeRow = true;
			// 
			// colKode
			// 
			this.colKode.Caption = "Kode";
			this.colKode.FieldName = "Kode";
			this.colKode.Name = "colKode";
			this.colKode.Visible = true;
			this.colKode.VisibleIndex = 0;
			this.colKode.Width = 53;
			// 
			// colNama
			// 
			this.colNama.Caption = "Nama";
			this.colNama.FieldName = "Nama";
			this.colNama.Name = "colNama";
			this.colNama.Visible = true;
			this.colNama.VisibleIndex = 1;
			this.colNama.Width = 71;
			// 
			// colTelepon
			// 
			this.colTelepon.Caption = "Telepon";
			this.colTelepon.FieldName = "NoTelpon";
			this.colTelepon.Name = "colTelepon";
			this.colTelepon.Visible = true;
			this.colTelepon.VisibleIndex = 2;
			this.colTelepon.Width = 53;
			// 
			// colHP1
			// 
			this.colHP1.Caption = "HP 1";
			this.colHP1.FieldName = "NoHP1";
			this.colHP1.Name = "colHP1";
			this.colHP1.Visible = true;
			this.colHP1.VisibleIndex = 3;
			this.colHP1.Width = 53;
			// 
			// colNIK
			// 
			this.colNIK.Caption = "NIK";
			this.colNIK.FieldName = "NIK";
			this.colNIK.Name = "colNIK";
			this.colNIK.Visible = true;
			this.colNIK.VisibleIndex = 6;
			this.colNIK.Width = 53;
			// 
			// colEmail
			// 
			this.colEmail.Caption = "Email";
			this.colEmail.FieldName = "Email";
			this.colEmail.Name = "colEmail";
			this.colEmail.Visible = true;
			this.colEmail.VisibleIndex = 4;
			this.colEmail.Width = 53;
			// 
			// colNPWP
			// 
			this.colNPWP.Caption = "NPWP";
			this.colNPWP.FieldName = "NPWP";
			this.colNPWP.Name = "colNPWP";
			this.colNPWP.Visible = true;
			this.colNPWP.VisibleIndex = 5;
			this.colNPWP.Width = 53;
			// 
			// colAktif
			// 
			this.colAktif.Caption = "Aktif";
			this.colAktif.FieldName = "Aktif";
			this.colAktif.Name = "colAktif";
			this.colAktif.Visible = true;
			this.colAktif.VisibleIndex = 8;
			this.colAktif.Width = 22;
			// 
			// colKeterangan
			// 
			this.colKeterangan.Caption = "Keterangan";
			this.colKeterangan.FieldName = "Keterangan";
			this.colKeterangan.Name = "colKeterangan";
			this.colKeterangan.Visible = true;
			this.colKeterangan.VisibleIndex = 9;
			this.colKeterangan.Width = 152;
			// 
			// colKomisi
			// 
			this.colKomisi.FieldName = "KomisiDefault";
			this.colKomisi.Name = "colKomisi";
			this.colKomisi.Visible = true;
			this.colKomisi.VisibleIndex = 7;
			this.colKomisi.Width = 40;
			// 
			// colId
			// 
			this.colId.FieldName = "Id";
			this.colId.Name = "colId";
			// 
			// UI_Sales
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(759, 395);
			this.Name = "UI_Sales";
			this.Text = "Sales";
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
		private DevExpress.XtraGrid.Columns.GridColumn colKode;
		private DevExpress.XtraGrid.Columns.GridColumn colNama;
		private DevExpress.XtraGrid.Columns.GridColumn colTelepon;
		private DevExpress.XtraGrid.Columns.GridColumn colHP1;
		private DevExpress.XtraGrid.Columns.GridColumn colNIK;
		private DevExpress.XtraGrid.Columns.GridColumn colEmail;
		private DevExpress.XtraGrid.Columns.GridColumn colNPWP;
		private DevExpress.XtraGrid.Columns.GridColumn colAktif;
		private DevExpress.XtraGrid.Columns.GridColumn colKeterangan;
		private DevExpress.XtraGrid.Columns.GridColumn colKomisi;
		private DevExpress.XtraGrid.Columns.GridColumn colId;
	}
}
