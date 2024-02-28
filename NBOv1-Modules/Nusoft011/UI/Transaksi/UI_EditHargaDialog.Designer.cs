namespace NuSoft.NUI.Win.Forms.Modules.NuSoft011.UI.Transaksi
{
	partial class UI_EditHargaDialog
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
			this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
			this.txtUpdateKonsi = new DevExpress.XtraEditors.SpinEdit();
			this.txtUpdateJatah = new DevExpress.XtraEditors.SpinEdit();
			this.txtJmlHari = new DevExpress.XtraEditors.SpinEdit();
			this.txtKeterangan = new DevExpress.XtraEditors.MemoEdit();
			this.txtPeriode = new DevExpress.XtraEditors.LookUpEdit();
			this.xGrid = new DevExpress.XtraGrid.GridControl();
			this.xBandGrid = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridView();
			this.bandAgen = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
			this.colAgenRute = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
			this.colAgenKode = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
			this.colAgenNama = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
			this.bandJatah = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
			this.colJatahLama = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
			this.coJatahBaru = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
			this.colSpinRepo = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
			this.bandKonsi = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
			this.colKonsiLama = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
			this.colKonsiBaru = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
			this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
			this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
			this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
			this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
			this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
			this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
			this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
			this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
			this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
			this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
			((System.ComponentModel.ISupportInitialize)(this.barMan)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.session)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
			this.layoutControl1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.txtUpdateKonsi.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtUpdateJatah.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtJmlHari.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtKeterangan.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtPeriode.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.xGrid)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.xBandGrid)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.colSpinRepo)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
			this.SuspendLayout();
			// 
			// barMenu
			// 
			this.barMenu.OptionsBar.AllowQuickCustomization = false;
			this.barMenu.OptionsBar.DrawDragBorder = false;
			this.barMenu.OptionsBar.UseWholeRow = true;
			// 
			// layoutControl1
			// 
			this.layoutControl1.Controls.Add(this.txtUpdateKonsi);
			this.layoutControl1.Controls.Add(this.txtUpdateJatah);
			this.layoutControl1.Controls.Add(this.txtJmlHari);
			this.layoutControl1.Controls.Add(this.txtKeterangan);
			this.layoutControl1.Controls.Add(this.txtPeriode);
			this.layoutControl1.Controls.Add(this.xGrid);
			this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.layoutControl1.Location = new System.Drawing.Point(0, 0);
			this.layoutControl1.Name = "layoutControl1";
			this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(678, 230, 650, 400);
			this.layoutControl1.Root = this.layoutControlGroup1;
			this.layoutControl1.Size = new System.Drawing.Size(962, 512);
			this.layoutControl1.TabIndex = 2;
			this.layoutControl1.Text = "layoutControl1";
			// 
			// txtUpdateKonsi
			// 
			this.txtUpdateKonsi.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
			this.txtUpdateKonsi.EnterMoveNextControl = true;
			this.txtUpdateKonsi.Location = new System.Drawing.Point(763, 67);
			this.txtUpdateKonsi.Name = "txtUpdateKonsi";
			this.txtUpdateKonsi.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.txtUpdateKonsi.Properties.DisplayFormat.FormatString = "n0";
			this.txtUpdateKonsi.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.txtUpdateKonsi.Properties.EditFormat.FormatString = "n0";
			this.txtUpdateKonsi.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.txtUpdateKonsi.Size = new System.Drawing.Size(175, 20);
			this.txtUpdateKonsi.StyleController = this.layoutControl1;
			this.txtUpdateKonsi.TabIndex = 14;
			// 
			// txtUpdateJatah
			// 
			this.txtUpdateJatah.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
			this.txtUpdateJatah.EnterMoveNextControl = true;
			this.txtUpdateJatah.Location = new System.Drawing.Point(508, 67);
			this.txtUpdateJatah.Name = "txtUpdateJatah";
			this.txtUpdateJatah.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.txtUpdateJatah.Properties.DisplayFormat.FormatString = "n0";
			this.txtUpdateJatah.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.txtUpdateJatah.Properties.EditFormat.FormatString = "n0";
			this.txtUpdateJatah.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.txtUpdateJatah.Size = new System.Drawing.Size(183, 20);
			this.txtUpdateJatah.StyleController = this.layoutControl1;
			this.txtUpdateJatah.TabIndex = 12;
			// 
			// txtJmlHari
			// 
			this.txtJmlHari.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
			this.txtJmlHari.EnterMoveNextControl = true;
			this.txtJmlHari.Location = new System.Drawing.Point(351, 12);
			this.txtJmlHari.Name = "txtJmlHari";
			this.txtJmlHari.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.txtJmlHari.Properties.MaxValue = new decimal(new int[] {
            32,
            0,
            0,
            0});
			this.txtJmlHari.Size = new System.Drawing.Size(73, 20);
			this.txtJmlHari.StyleController = this.layoutControl1;
			this.txtJmlHari.TabIndex = 11;
			// 
			// txtKeterangan
			// 
			this.txtKeterangan.EnterMoveNextControl = true;
			this.txtKeterangan.Location = new System.Drawing.Point(80, 36);
			this.txtKeterangan.Name = "txtKeterangan";
			this.txtKeterangan.Size = new System.Drawing.Size(344, 63);
			this.txtKeterangan.StyleController = this.layoutControl1;
			this.txtKeterangan.TabIndex = 10;
			// 
			// txtPeriode
			// 
			this.txtPeriode.EnterMoveNextControl = true;
			this.txtPeriode.Location = new System.Drawing.Point(80, 12);
			this.txtPeriode.Name = "txtPeriode";
			this.txtPeriode.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.txtPeriode.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Value", "Value")});
			this.txtPeriode.Properties.DisplayMember = "Value";
			this.txtPeriode.Properties.NullText = "[ Pilih Periode ]";
			this.txtPeriode.Properties.ShowHeader = false;
			this.txtPeriode.Properties.ValueMember = "Key";
			this.txtPeriode.Size = new System.Drawing.Size(199, 20);
			this.txtPeriode.StyleController = this.layoutControl1;
			this.txtPeriode.TabIndex = 9;
			// 
			// xGrid
			// 
			this.xGrid.Location = new System.Drawing.Point(12, 119);
			this.xGrid.MainView = this.xBandGrid;
			this.xGrid.Name = "xGrid";
			this.xGrid.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.colSpinRepo});
			this.xGrid.Size = new System.Drawing.Size(938, 381);
			this.xGrid.TabIndex = 8;
			this.xGrid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.xBandGrid});
			// 
			// xBandGrid
			// 
			this.xBandGrid.Bands.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.GridBand[] {
            this.bandAgen,
            this.bandJatah,
            this.bandKonsi});
			this.xBandGrid.Columns.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn[] {
            this.colAgenKode,
            this.colAgenNama,
            this.colAgenRute,
            this.colJatahLama,
            this.coJatahBaru,
            this.colKonsiLama,
            this.colKonsiBaru});
			this.xBandGrid.FixedLineWidth = 1;
			this.xBandGrid.GridControl = this.xGrid;
			this.xBandGrid.GroupCount = 1;
			this.xBandGrid.Name = "xBandGrid";
			this.xBandGrid.OptionsDetail.EnableMasterViewMode = false;
			this.xBandGrid.OptionsNavigation.EnterMoveNextColumn = true;
			this.xBandGrid.OptionsView.ShowAutoFilterRow = true;
			this.xBandGrid.OptionsView.ShowFooter = true;
			this.xBandGrid.OptionsView.ShowGroupPanel = false;
			this.xBandGrid.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colAgenRute, DevExpress.Data.ColumnSortOrder.Ascending)});
			// 
			// bandAgen
			// 
			this.bandAgen.AppearanceHeader.Options.UseTextOptions = true;
			this.bandAgen.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.bandAgen.Caption = "Agen";
			this.bandAgen.Columns.Add(this.colAgenRute);
			this.bandAgen.Columns.Add(this.colAgenKode);
			this.bandAgen.Columns.Add(this.colAgenNama);
			this.bandAgen.Name = "bandAgen";
			this.bandAgen.VisibleIndex = 0;
			this.bandAgen.Width = 378;
			// 
			// colAgenRute
			// 
			this.colAgenRute.Caption = "Rute";
			this.colAgenRute.FieldName = "Agen.Rute.KodeNama";
			this.colAgenRute.Name = "colAgenRute";
			this.colAgenRute.OptionsColumn.AllowEdit = false;
			this.colAgenRute.OptionsColumn.ReadOnly = true;
			this.colAgenRute.Visible = true;
			this.colAgenRute.Width = 94;
			// 
			// colAgenKode
			// 
			this.colAgenKode.Caption = "Kode";
			this.colAgenKode.FieldName = "Agen.Kode";
			this.colAgenKode.Name = "colAgenKode";
			this.colAgenKode.OptionsColumn.AllowEdit = false;
			this.colAgenKode.OptionsColumn.ReadOnly = true;
			this.colAgenKode.Visible = true;
			this.colAgenKode.Width = 94;
			// 
			// colAgenNama
			// 
			this.colAgenNama.Caption = "Nama";
			this.colAgenNama.FieldName = "Agen.Nama";
			this.colAgenNama.Name = "colAgenNama";
			this.colAgenNama.OptionsColumn.AllowEdit = false;
			this.colAgenNama.OptionsColumn.ReadOnly = true;
			this.colAgenNama.Visible = true;
			this.colAgenNama.Width = 190;
			// 
			// bandJatah
			// 
			this.bandJatah.AppearanceHeader.Options.UseTextOptions = true;
			this.bandJatah.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.bandJatah.Caption = "Harga Jatah";
			this.bandJatah.Columns.Add(this.colJatahLama);
			this.bandJatah.Columns.Add(this.coJatahBaru);
			this.bandJatah.Name = "bandJatah";
			this.bandJatah.VisibleIndex = 1;
			this.bandJatah.Width = 128;
			// 
			// colJatahLama
			// 
			this.colJatahLama.AppearanceCell.Options.UseTextOptions = true;
			this.colJatahLama.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
			this.colJatahLama.AppearanceHeader.Options.UseTextOptions = true;
			this.colJatahLama.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
			this.colJatahLama.Caption = "Lama";
			this.colJatahLama.DisplayFormat.FormatString = "n0";
			this.colJatahLama.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.colJatahLama.FieldName = "HargaJatahLama";
			this.colJatahLama.Name = "colJatahLama";
			this.colJatahLama.OptionsColumn.AllowEdit = false;
			this.colJatahLama.OptionsColumn.ReadOnly = true;
			this.colJatahLama.Visible = true;
			this.colJatahLama.Width = 64;
			// 
			// coJatahBaru
			// 
			this.coJatahBaru.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.coJatahBaru.AppearanceCell.Options.UseBackColor = true;
			this.coJatahBaru.AppearanceCell.Options.UseTextOptions = true;
			this.coJatahBaru.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
			this.coJatahBaru.AppearanceHeader.Options.UseTextOptions = true;
			this.coJatahBaru.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
			this.coJatahBaru.Caption = "Baru";
			this.coJatahBaru.ColumnEdit = this.colSpinRepo;
			this.coJatahBaru.DisplayFormat.FormatString = "n0";
			this.coJatahBaru.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.coJatahBaru.FieldName = "HargaJatahBaru";
			this.coJatahBaru.Name = "coJatahBaru";
			this.coJatahBaru.Visible = true;
			this.coJatahBaru.Width = 64;
			// 
			// colSpinRepo
			// 
			this.colSpinRepo.AutoHeight = false;
			this.colSpinRepo.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.colSpinRepo.Name = "colSpinRepo";
			// 
			// bandKonsi
			// 
			this.bandKonsi.AppearanceHeader.Options.UseTextOptions = true;
			this.bandKonsi.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.bandKonsi.Caption = "Harga Konsi";
			this.bandKonsi.Columns.Add(this.colKonsiLama);
			this.bandKonsi.Columns.Add(this.colKonsiBaru);
			this.bandKonsi.Name = "bandKonsi";
			this.bandKonsi.VisibleIndex = 2;
			this.bandKonsi.Width = 131;
			// 
			// colKonsiLama
			// 
			this.colKonsiLama.AppearanceCell.Options.UseTextOptions = true;
			this.colKonsiLama.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
			this.colKonsiLama.AppearanceHeader.Options.UseTextOptions = true;
			this.colKonsiLama.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
			this.colKonsiLama.Caption = "Lama";
			this.colKonsiLama.DisplayFormat.FormatString = "n0";
			this.colKonsiLama.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.colKonsiLama.FieldName = "HargaKonsiLama";
			this.colKonsiLama.Name = "colKonsiLama";
			this.colKonsiLama.OptionsColumn.AllowEdit = false;
			this.colKonsiLama.OptionsColumn.ReadOnly = true;
			this.colKonsiLama.Visible = true;
			this.colKonsiLama.Width = 64;
			// 
			// colKonsiBaru
			// 
			this.colKonsiBaru.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.colKonsiBaru.AppearanceCell.Options.UseBackColor = true;
			this.colKonsiBaru.AppearanceCell.Options.UseTextOptions = true;
			this.colKonsiBaru.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
			this.colKonsiBaru.AppearanceHeader.Options.UseTextOptions = true;
			this.colKonsiBaru.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
			this.colKonsiBaru.Caption = "Baru";
			this.colKonsiBaru.ColumnEdit = this.colSpinRepo;
			this.colKonsiBaru.DisplayFormat.FormatString = "n0";
			this.colKonsiBaru.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.colKonsiBaru.FieldName = "HargaKonsiBaru";
			this.colKonsiBaru.Name = "colKonsiBaru";
			this.colKonsiBaru.Visible = true;
			this.colKonsiBaru.Width = 67;
			// 
			// layoutControlGroup1
			// 
			this.layoutControlGroup1.CustomizationFormText = "Root";
			this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
			this.layoutControlGroup1.GroupBordersVisible = false;
			this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.emptySpaceItem1,
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.emptySpaceItem2,
            this.layoutControlGroup2});
			this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
			this.layoutControlGroup1.Name = "Root";
			this.layoutControlGroup1.Size = new System.Drawing.Size(962, 512);
			this.layoutControlGroup1.Text = "Root";
			this.layoutControlGroup1.TextVisible = false;
			// 
			// emptySpaceItem1
			// 
			this.emptySpaceItem1.AllowHotTrack = false;
			this.emptySpaceItem1.CustomizationFormText = "emptySpaceItem1";
			this.emptySpaceItem1.Location = new System.Drawing.Point(0, 91);
			this.emptySpaceItem1.Name = "emptySpaceItem1";
			this.emptySpaceItem1.Size = new System.Drawing.Size(942, 16);
			this.emptySpaceItem1.Text = "emptySpaceItem1";
			this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
			// 
			// layoutControlItem3
			// 
			this.layoutControlItem3.Control = this.xGrid;
			this.layoutControlItem3.CustomizationFormText = "layoutControlItem3";
			this.layoutControlItem3.Location = new System.Drawing.Point(0, 107);
			this.layoutControlItem3.Name = "layoutControlItem3";
			this.layoutControlItem3.Size = new System.Drawing.Size(942, 385);
			this.layoutControlItem3.Text = "layoutControlItem3";
			this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
			this.layoutControlItem3.TextToControlDistance = 0;
			this.layoutControlItem3.TextVisible = false;
			// 
			// layoutControlItem4
			// 
			this.layoutControlItem4.Control = this.txtPeriode;
			this.layoutControlItem4.CustomizationFormText = "Periode";
			this.layoutControlItem4.Location = new System.Drawing.Point(0, 0);
			this.layoutControlItem4.Name = "layoutControlItem4";
			this.layoutControlItem4.Size = new System.Drawing.Size(271, 24);
			this.layoutControlItem4.Text = "Periode";
			this.layoutControlItem4.TextSize = new System.Drawing.Size(65, 13);
			// 
			// layoutControlItem1
			// 
			this.layoutControlItem1.Control = this.txtKeterangan;
			this.layoutControlItem1.CustomizationFormText = "Keterangan   ";
			this.layoutControlItem1.Location = new System.Drawing.Point(0, 24);
			this.layoutControlItem1.Name = "layoutControlItem1";
			this.layoutControlItem1.Size = new System.Drawing.Size(416, 67);
			this.layoutControlItem1.Text = "Keterangan   ";
			this.layoutControlItem1.TextSize = new System.Drawing.Size(65, 13);
			// 
			// layoutControlItem2
			// 
			this.layoutControlItem2.Control = this.txtJmlHari;
			this.layoutControlItem2.CustomizationFormText = "Jml. Hari  ";
			this.layoutControlItem2.Location = new System.Drawing.Point(271, 0);
			this.layoutControlItem2.Name = "layoutControlItem2";
			this.layoutControlItem2.Size = new System.Drawing.Size(145, 24);
			this.layoutControlItem2.Text = "Jml. Hari  ";
			this.layoutControlItem2.TextSize = new System.Drawing.Size(65, 13);
			// 
			// emptySpaceItem2
			// 
			this.emptySpaceItem2.AllowHotTrack = false;
			this.emptySpaceItem2.CustomizationFormText = "emptySpaceItem2";
			this.emptySpaceItem2.Location = new System.Drawing.Point(416, 0);
			this.emptySpaceItem2.Name = "emptySpaceItem2";
			this.emptySpaceItem2.Size = new System.Drawing.Size(526, 24);
			this.emptySpaceItem2.Text = "emptySpaceItem2";
			this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
			// 
			// layoutControlGroup2
			// 
			this.layoutControlGroup2.AppearanceGroup.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.layoutControlGroup2.AppearanceGroup.Options.UseFont = true;
			this.layoutControlGroup2.CustomizationFormText = "Update Harga";
			this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem5,
            this.layoutControlItem7});
			this.layoutControlGroup2.Location = new System.Drawing.Point(416, 24);
			this.layoutControlGroup2.Name = "layoutControlGroup2";
			this.layoutControlGroup2.Size = new System.Drawing.Size(526, 67);
			this.layoutControlGroup2.Text = "Update Harga";
			// 
			// layoutControlItem5
			// 
			this.layoutControlItem5.Control = this.txtUpdateJatah;
			this.layoutControlItem5.CustomizationFormText = "Jatah";
			this.layoutControlItem5.Location = new System.Drawing.Point(0, 0);
			this.layoutControlItem5.Name = "layoutControlItem5";
			this.layoutControlItem5.Size = new System.Drawing.Size(255, 24);
			this.layoutControlItem5.Text = "Jatah";
			this.layoutControlItem5.TextSize = new System.Drawing.Size(65, 13);
			// 
			// layoutControlItem7
			// 
			this.layoutControlItem7.Control = this.txtUpdateKonsi;
			this.layoutControlItem7.CustomizationFormText = "Konsi";
			this.layoutControlItem7.Location = new System.Drawing.Point(255, 0);
			this.layoutControlItem7.Name = "layoutControlItem7";
			this.layoutControlItem7.Size = new System.Drawing.Size(247, 24);
			this.layoutControlItem7.Text = "Konsi";
			this.layoutControlItem7.TextSize = new System.Drawing.Size(65, 13);
			// 
			// UI_EditHargaDialog
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(962, 539);
			this.Controls.Add(this.layoutControl1);
			this.Name = "UI_EditHargaDialog";
			this.Text = "UI_MutasiAgenDialog";
			this.Controls.SetChildIndex(this.layoutControl1, 0);
			((System.ComponentModel.ISupportInitialize)(this.barMan)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.session)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
			this.layoutControl1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.txtUpdateKonsi.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtUpdateJatah.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtJmlHari.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtKeterangan.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtPeriode.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.xGrid)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.xBandGrid)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.colSpinRepo)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private DevExpress.XtraLayout.LayoutControl layoutControl1;
		private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
		private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
		private DevExpress.XtraGrid.GridControl xGrid;
		private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit colSpinRepo;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
		private DevExpress.XtraEditors.SpinEdit txtJmlHari;
		private DevExpress.XtraEditors.MemoEdit txtKeterangan;
		private DevExpress.XtraEditors.LookUpEdit txtPeriode;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
		private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
		private DevExpress.XtraGrid.Views.BandedGrid.BandedGridView xBandGrid;
		private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colAgenKode;
		private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colAgenNama;
		private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colJatahLama;
		private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn coJatahBaru;
		private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colKonsiLama;
		private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colKonsiBaru;
		private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colAgenRute;
		private DevExpress.XtraEditors.SpinEdit txtUpdateJatah;
		private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
		private DevExpress.XtraEditors.SpinEdit txtUpdateKonsi;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
		private DevExpress.XtraGrid.Views.BandedGrid.GridBand bandAgen;
		private DevExpress.XtraGrid.Views.BandedGrid.GridBand bandJatah;
		private DevExpress.XtraGrid.Views.BandedGrid.GridBand bandKonsi;
	}
}