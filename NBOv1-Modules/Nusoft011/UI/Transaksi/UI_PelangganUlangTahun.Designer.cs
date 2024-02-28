namespace NuSoft.NUI.Win.Forms.Modules.NuSoft011.UI.Transaksi
{
	partial class UI_PelangganUlangTahun
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
			this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
			this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
			this.txtBulan = new DevExpress.XtraEditors.ComboBoxEdit();
			this.colAgen = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colKabupaten = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colKecamatan = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colNama = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colAlamat = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colTanggalLahir = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colTelpRumah = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colTelpKantor = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colHP = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colEmail = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colNomor = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colUmur = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colBulanLahir = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
			((System.ComponentModel.ISupportInitialize)(this.xGrid)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.xpCol)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.barMan)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.session)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.xGridView)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.popMenu)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
			this.panelControl1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.txtBulan.Properties)).BeginInit();
			this.SuspendLayout();
			// 
			// xGrid
			// 
			this.xGrid.DataSource = this.ifSource;
			this.xGrid.Location = new System.Drawing.Point(0, 37);
			this.xGrid.Size = new System.Drawing.Size(972, 295);
			// 
			// xGridView
			// 
			this.xGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colKabupaten,
            this.colKecamatan,
            this.colAgen,
            this.colNomor,
            this.colNama,
            this.colTanggalLahir,
            this.colUmur,
            this.colAlamat,
            this.colTelpRumah,
            this.colTelpKantor,
            this.colHP,
            this.colEmail,
            this.colBulanLahir,
            this.colId});
			this.xGridView.GroupCount = 2;
			this.xGridView.OptionsBehavior.Editable = false;
			this.xGridView.OptionsDetail.EnableMasterViewMode = false;
			this.xGridView.OptionsSelection.MultiSelect = true;
			this.xGridView.OptionsView.ShowAutoFilterRow = true;
			this.xGridView.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
			this.xGridView.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colKabupaten, DevExpress.Data.ColumnSortOrder.Ascending),
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colKecamatan, DevExpress.Data.ColumnSortOrder.Ascending)});
			// 
			// ifSource
			// 
			this.ifSource.DisplayableProperties = "Agen.Nama;Kabupaten.Kode;Kecamatan.Kode;Nama;Alamat;TempatLahir;TanggalLahir;Peke" +
    "rjaan;NoTelpRumah;NoTelpKantor;NoHP;Email;Aktif;Kode;HargaLangganan;Umur;BulanLa" +
    "hir;Id";
			this.ifSource.FixedFilterString = "[Aktif] = True And [BulanLahir] <> 0";
			this.ifSource.ObjectType = typeof(NuSoft.NUI.Win.Forms.Modules.NuSoft011.Persistent.Pelanggan);
			// 
			// barMenu
			// 
			this.barMenu.OptionsBar.AllowQuickCustomization = false;
			this.barMenu.OptionsBar.DrawDragBorder = false;
			this.barMenu.OptionsBar.UseWholeRow = true;
			// 
			// panelControl1
			// 
			this.panelControl1.Controls.Add(this.labelControl1);
			this.panelControl1.Controls.Add(this.txtBulan);
			this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panelControl1.Location = new System.Drawing.Point(0, 0);
			this.panelControl1.Name = "panelControl1";
			this.panelControl1.Size = new System.Drawing.Size(972, 37);
			this.panelControl1.TabIndex = 1;
			// 
			// labelControl1
			// 
			this.labelControl1.Location = new System.Drawing.Point(22, 12);
			this.labelControl1.Name = "labelControl1";
			this.labelControl1.Size = new System.Drawing.Size(26, 13);
			this.labelControl1.TabIndex = 1;
			this.labelControl1.Text = "Bulan";
			// 
			// txtBulan
			// 
			this.txtBulan.Location = new System.Drawing.Point(64, 9);
			this.txtBulan.Name = "txtBulan";
			this.txtBulan.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.txtBulan.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
			this.txtBulan.Size = new System.Drawing.Size(174, 20);
			this.txtBulan.TabIndex = 0;
			// 
			// colAgen
			// 
			this.colAgen.Caption = "Agen";
			this.colAgen.FieldName = "Agen.Nama";
			this.colAgen.Name = "colAgen";
			this.colAgen.Visible = true;
			this.colAgen.VisibleIndex = 0;
			this.colAgen.Width = 110;
			// 
			// colKabupaten
			// 
			this.colKabupaten.Caption = "Kabupaten";
			this.colKabupaten.FieldName = "Kabupaten.Kode";
			this.colKabupaten.Name = "colKabupaten";
			this.colKabupaten.Visible = true;
			this.colKabupaten.VisibleIndex = 1;
			// 
			// colKecamatan
			// 
			this.colKecamatan.Caption = "Kecamatan";
			this.colKecamatan.FieldName = "Kecamatan.Kode";
			this.colKecamatan.Name = "colKecamatan";
			this.colKecamatan.Visible = true;
			this.colKecamatan.VisibleIndex = 1;
			// 
			// colNama
			// 
			this.colNama.FieldName = "Nama";
			this.colNama.Name = "colNama";
			this.colNama.Visible = true;
			this.colNama.VisibleIndex = 2;
			this.colNama.Width = 150;
			// 
			// colAlamat
			// 
			this.colAlamat.FieldName = "Alamat";
			this.colAlamat.Name = "colAlamat";
			this.colAlamat.Visible = true;
			this.colAlamat.VisibleIndex = 5;
			this.colAlamat.Width = 250;
			// 
			// colTanggalLahir
			// 
			this.colTanggalLahir.Caption = "Tgl Lahir";
			this.colTanggalLahir.DisplayFormat.FormatString = "dd MMM yyyy";
			this.colTanggalLahir.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
			this.colTanggalLahir.FieldName = "TanggalLahir";
			this.colTanggalLahir.Name = "colTanggalLahir";
			this.colTanggalLahir.Visible = true;
			this.colTanggalLahir.VisibleIndex = 3;
			this.colTanggalLahir.Width = 77;
			// 
			// colTelpRumah
			// 
			this.colTelpRumah.FieldName = "NoTelpRumah";
			this.colTelpRumah.Name = "colTelpRumah";
			this.colTelpRumah.Visible = true;
			this.colTelpRumah.VisibleIndex = 6;
			this.colTelpRumah.Width = 58;
			// 
			// colTelpKantor
			// 
			this.colTelpKantor.FieldName = "NoTelpKantor";
			this.colTelpKantor.Name = "colTelpKantor";
			this.colTelpKantor.Visible = true;
			this.colTelpKantor.VisibleIndex = 7;
			this.colTelpKantor.Width = 58;
			// 
			// colHP
			// 
			this.colHP.FieldName = "NoHP";
			this.colHP.Name = "colHP";
			this.colHP.Visible = true;
			this.colHP.VisibleIndex = 8;
			this.colHP.Width = 58;
			// 
			// colEmail
			// 
			this.colEmail.FieldName = "Email";
			this.colEmail.Name = "colEmail";
			this.colEmail.Visible = true;
			this.colEmail.VisibleIndex = 9;
			this.colEmail.Width = 85;
			// 
			// colNomor
			// 
			this.colNomor.Caption = "Nomor";
			this.colNomor.FieldName = "Kode";
			this.colNomor.Name = "colNomor";
			this.colNomor.Visible = true;
			this.colNomor.VisibleIndex = 1;
			this.colNomor.Width = 80;
			// 
			// colUmur
			// 
			this.colUmur.FieldName = "Umur";
			this.colUmur.Name = "colUmur";
			this.colUmur.Visible = true;
			this.colUmur.VisibleIndex = 4;
			this.colUmur.Width = 38;
			// 
			// colBulanLahir
			// 
			this.colBulanLahir.FieldName = "BulanLahir";
			this.colBulanLahir.Name = "colBulanLahir";
			// 
			// colId
			// 
			this.colId.FieldName = "Id";
			this.colId.Name = "colId";
			// 
			// UI_PelangganUlangTahun
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(972, 359);
			this.Controls.Add(this.panelControl1);
			this.Name = "UI_PelangganUlangTahun";
			this.Text = "Pengingat Ultah";
			this.xpCol = this.xpCol;
			this.Controls.SetChildIndex(this.panelControl1, 0);
			this.Controls.SetChildIndex(this.xGrid, 0);
			((System.ComponentModel.ISupportInitialize)(this.xGrid)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.xpCol)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.barMan)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.session)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.xGridView)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.popMenu)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
			this.panelControl1.ResumeLayout(false);
			this.panelControl1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.txtBulan.Properties)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private DevExpress.XtraEditors.PanelControl panelControl1;
		private DevExpress.XtraEditors.LabelControl labelControl1;
		private DevExpress.XtraEditors.ComboBoxEdit txtBulan;
		private DevExpress.XtraGrid.Columns.GridColumn colKabupaten;
		private DevExpress.XtraGrid.Columns.GridColumn colKecamatan;
		private DevExpress.XtraGrid.Columns.GridColumn colAgen;
		private DevExpress.XtraGrid.Columns.GridColumn colNomor;
		private DevExpress.XtraGrid.Columns.GridColumn colNama;
		private DevExpress.XtraGrid.Columns.GridColumn colTanggalLahir;
		private DevExpress.XtraGrid.Columns.GridColumn colUmur;
		private DevExpress.XtraGrid.Columns.GridColumn colAlamat;
		private DevExpress.XtraGrid.Columns.GridColumn colTelpRumah;
		private DevExpress.XtraGrid.Columns.GridColumn colTelpKantor;
		private DevExpress.XtraGrid.Columns.GridColumn colHP;
		private DevExpress.XtraGrid.Columns.GridColumn colEmail;
		private DevExpress.XtraGrid.Columns.GridColumn colBulanLahir;
		private DevExpress.XtraGrid.Columns.GridColumn colId;
	}
}
