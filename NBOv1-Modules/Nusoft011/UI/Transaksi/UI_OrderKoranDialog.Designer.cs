namespace NuSoft.NUI.Win.Forms.Modules.NuSoft011.UI.Transaksi
{
	partial class UI_OrderKoranDialog
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
		private void InitializeComponent() {
			this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
			this.txtHariKhusus = new DevExpress.XtraEditors.CheckEdit();
			this.xGrid = new DevExpress.XtraGrid.GridControl();
			this.xGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.colRute = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colKodeAgen = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colNamaAgen = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colJatah = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colSpinRepo = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
			this.colKonsi = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colGratis = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colOplah = new DevExpress.XtraGrid.Columns.GridColumn();
			this.txtKeterangan = new DevExpress.XtraEditors.TextEdit();
			this.txtTanggal = new DevExpress.XtraEditors.DateEdit();
			this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
			this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
			this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
			this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
			this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
			this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
			this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
			this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
			((System.ComponentModel.ISupportInitialize)(this.session)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
			this.layoutControl1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.txtHariKhusus.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.xGrid)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.xGridView)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.colSpinRepo)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtKeterangan.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtTanggal.Properties.CalendarTimeProperties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtTanggal.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
			this.SuspendLayout();
			// 
			// layoutControl1
			// 
			this.layoutControl1.Controls.Add(this.txtHariKhusus);
			this.layoutControl1.Controls.Add(this.xGrid);
			this.layoutControl1.Controls.Add(this.txtKeterangan);
			this.layoutControl1.Controls.Add(this.txtTanggal);
			this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.layoutControl1.Location = new System.Drawing.Point(0, 0);
			this.layoutControl1.Name = "layoutControl1";
			this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(716, 223, 650, 400);
			this.layoutControl1.Root = this.layoutControlGroup1;
			this.layoutControl1.Size = new System.Drawing.Size(675, 483);
			this.layoutControl1.TabIndex = 2;
			this.layoutControl1.Text = "layoutControl1";
			// 
			// txtHariKhusus
			// 
			this.txtHariKhusus.Location = new System.Drawing.Point(231, 12);
			this.txtHariKhusus.Name = "txtHariKhusus";
			this.txtHariKhusus.Properties.Caption = "Hari Khusus";
			this.txtHariKhusus.Size = new System.Drawing.Size(78, 19);
			this.txtHariKhusus.StyleController = this.layoutControl1;
			this.txtHariKhusus.TabIndex = 7;
			// 
			// xGrid
			// 
			this.xGrid.Location = new System.Drawing.Point(24, 102);
			this.xGrid.MainView = this.xGridView;
			this.xGrid.Name = "xGrid";
			this.xGrid.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.colSpinRepo});
			this.xGrid.Size = new System.Drawing.Size(627, 357);
			this.xGrid.TabIndex = 6;
			this.xGrid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.xGridView});
			// 
			// xGridView
			// 
			this.xGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colRute,
            this.colKodeAgen,
            this.colNamaAgen,
            this.colJatah,
            this.colKonsi,
            this.colGratis,
            this.colOplah});
			this.xGridView.GridControl = this.xGrid;
			this.xGridView.GroupCount = 1;
			this.xGridView.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Oplah", null, " | Oplah : {0:n0}"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "JatahPelanggan", this.colJatah, "{0:n0}"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Konsi", this.colKonsi, "{0:n0}"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Gratis", this.colGratis, "{0:n0}"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Oplah", this.colOplah, "{0:n0}")});
			this.xGridView.Name = "xGridView";
			this.xGridView.OptionsDetail.EnableMasterViewMode = false;
			this.xGridView.OptionsNavigation.EnterMoveNextColumn = true;
			this.xGridView.OptionsView.ShowAutoFilterRow = true;
			this.xGridView.OptionsView.ShowFooter = true;
			this.xGridView.OptionsView.ShowGroupPanel = false;
			this.xGridView.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colRute, DevExpress.Data.ColumnSortOrder.Ascending)});
			// 
			// colRute
			// 
			this.colRute.Caption = "Rute";
			this.colRute.FieldName = "Agen.Rute.KodeNama";
			this.colRute.Name = "colRute";
			this.colRute.OptionsColumn.AllowEdit = false;
			this.colRute.OptionsColumn.ReadOnly = true;
			this.colRute.Visible = true;
			this.colRute.VisibleIndex = 0;
			// 
			// colKodeAgen
			// 
			this.colKodeAgen.Caption = "Kode Agen";
			this.colKodeAgen.FieldName = "Agen.Kode";
			this.colKodeAgen.Name = "colKodeAgen";
			this.colKodeAgen.OptionsColumn.AllowEdit = false;
			this.colKodeAgen.OptionsColumn.ReadOnly = true;
			this.colKodeAgen.Visible = true;
			this.colKodeAgen.VisibleIndex = 0;
			this.colKodeAgen.Width = 110;
			// 
			// colNamaAgen
			// 
			this.colNamaAgen.Caption = "Nama Agen";
			this.colNamaAgen.FieldName = "Agen.Nama";
			this.colNamaAgen.Name = "colNamaAgen";
			this.colNamaAgen.OptionsColumn.AllowEdit = false;
			this.colNamaAgen.OptionsColumn.ReadOnly = true;
			this.colNamaAgen.Visible = true;
			this.colNamaAgen.VisibleIndex = 1;
			this.colNamaAgen.Width = 200;
			// 
			// colJatah
			// 
			this.colJatah.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.colJatah.AppearanceCell.Options.UseBackColor = true;
			this.colJatah.AppearanceHeader.Options.UseTextOptions = true;
			this.colJatah.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
			this.colJatah.Caption = "Jatah";
			this.colJatah.ColumnEdit = this.colSpinRepo;
			this.colJatah.DisplayFormat.FormatString = "n0";
			this.colJatah.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.colJatah.FieldName = "Jatah";
			this.colJatah.Name = "colJatah";
			this.colJatah.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Jatah", "{0:n0}")});
			this.colJatah.Visible = true;
			this.colJatah.VisibleIndex = 2;
			this.colJatah.Width = 70;
			// 
			// colSpinRepo
			// 
			this.colSpinRepo.AutoHeight = false;
			this.colSpinRepo.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.colSpinRepo.Name = "colSpinRepo";
			// 
			// colKonsi
			// 
			this.colKonsi.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.colKonsi.AppearanceCell.Options.UseBackColor = true;
			this.colKonsi.AppearanceHeader.Options.UseTextOptions = true;
			this.colKonsi.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
			this.colKonsi.Caption = "Konsi";
			this.colKonsi.ColumnEdit = this.colSpinRepo;
			this.colKonsi.DisplayFormat.FormatString = "n0";
			this.colKonsi.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.colKonsi.FieldName = "Konsi";
			this.colKonsi.Name = "colKonsi";
			this.colKonsi.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Konsi", "{0:n0}")});
			this.colKonsi.Visible = true;
			this.colKonsi.VisibleIndex = 3;
			this.colKonsi.Width = 70;
			// 
			// colGratis
			// 
			this.colGratis.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.colGratis.AppearanceCell.Options.UseBackColor = true;
			this.colGratis.AppearanceHeader.Options.UseTextOptions = true;
			this.colGratis.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
			this.colGratis.Caption = "Gratis";
			this.colGratis.ColumnEdit = this.colSpinRepo;
			this.colGratis.DisplayFormat.FormatString = "n0";
			this.colGratis.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.colGratis.FieldName = "Gratis";
			this.colGratis.Name = "colGratis";
			this.colGratis.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Gratis", "{0:n0}")});
			this.colGratis.Visible = true;
			this.colGratis.VisibleIndex = 4;
			this.colGratis.Width = 70;
			// 
			// colOplah
			// 
			this.colOplah.AppearanceHeader.Options.UseTextOptions = true;
			this.colOplah.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
			this.colOplah.Caption = "Oplah";
			this.colOplah.DisplayFormat.FormatString = "n0";
			this.colOplah.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.colOplah.FieldName = "Oplah";
			this.colOplah.Name = "colOplah";
			this.colOplah.OptionsColumn.AllowEdit = false;
			this.colOplah.OptionsColumn.ReadOnly = true;
			this.colOplah.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Oplah", "{0:n0}")});
			this.colOplah.Visible = true;
			this.colOplah.VisibleIndex = 5;
			this.colOplah.Width = 89;
			// 
			// txtKeterangan
			// 
			this.txtKeterangan.EnterMoveNextControl = true;
			this.txtKeterangan.Location = new System.Drawing.Point(80, 36);
			this.txtKeterangan.Name = "txtKeterangan";
			this.txtKeterangan.Size = new System.Drawing.Size(583, 20);
			this.txtKeterangan.StyleController = this.layoutControl1;
			this.txtKeterangan.TabIndex = 5;
			// 
			// txtTanggal
			// 
			this.txtTanggal.EditValue = null;
			this.txtTanggal.EnterMoveNextControl = true;
			this.txtTanggal.Location = new System.Drawing.Point(80, 12);
			this.txtTanggal.Name = "txtTanggal";
			this.txtTanggal.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.txtTanggal.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.txtTanggal.Properties.DisplayFormat.FormatString = "D";
			this.txtTanggal.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
			this.txtTanggal.Size = new System.Drawing.Size(147, 20);
			this.txtTanggal.StyleController = this.layoutControl1;
			this.txtTanggal.TabIndex = 4;
			// 
			// layoutControlGroup1
			// 
			this.layoutControlGroup1.CustomizationFormText = "Root";
			this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
			this.layoutControlGroup1.GroupBordersVisible = false;
			this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.emptySpaceItem1,
            this.layoutControlGroup2,
            this.emptySpaceItem2,
            this.layoutControlItem4});
			this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
			this.layoutControlGroup1.Name = "Root";
			this.layoutControlGroup1.Size = new System.Drawing.Size(675, 483);
			this.layoutControlGroup1.Text = "Root";
			this.layoutControlGroup1.TextVisible = false;
			// 
			// layoutControlItem1
			// 
			this.layoutControlItem1.Control = this.txtTanggal;
			this.layoutControlItem1.CustomizationFormText = "Tanggal";
			this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
			this.layoutControlItem1.Name = "layoutControlItem1";
			this.layoutControlItem1.Size = new System.Drawing.Size(219, 24);
			this.layoutControlItem1.Text = "Tanggal";
			this.layoutControlItem1.TextSize = new System.Drawing.Size(65, 13);
			// 
			// layoutControlItem2
			// 
			this.layoutControlItem2.Control = this.txtKeterangan;
			this.layoutControlItem2.CustomizationFormText = "Keterangan   ";
			this.layoutControlItem2.Location = new System.Drawing.Point(0, 24);
			this.layoutControlItem2.Name = "layoutControlItem2";
			this.layoutControlItem2.Size = new System.Drawing.Size(655, 24);
			this.layoutControlItem2.Text = "Keterangan   ";
			this.layoutControlItem2.TextSize = new System.Drawing.Size(65, 13);
			// 
			// emptySpaceItem1
			// 
			this.emptySpaceItem1.AllowHotTrack = false;
			this.emptySpaceItem1.CustomizationFormText = "emptySpaceItem1";
			this.emptySpaceItem1.Location = new System.Drawing.Point(301, 0);
			this.emptySpaceItem1.Name = "emptySpaceItem1";
			this.emptySpaceItem1.Size = new System.Drawing.Size(354, 24);
			this.emptySpaceItem1.Text = "emptySpaceItem1";
			this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
			// 
			// layoutControlGroup2
			// 
			this.layoutControlGroup2.AppearanceGroup.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.layoutControlGroup2.AppearanceGroup.Options.UseFont = true;
			this.layoutControlGroup2.CustomizationFormText = "Detail Order";
			this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem3});
			this.layoutControlGroup2.Location = new System.Drawing.Point(0, 59);
			this.layoutControlGroup2.Name = "layoutControlGroup2";
			this.layoutControlGroup2.Size = new System.Drawing.Size(655, 404);
			this.layoutControlGroup2.Text = "Detail Order";
			// 
			// layoutControlItem3
			// 
			this.layoutControlItem3.Control = this.xGrid;
			this.layoutControlItem3.CustomizationFormText = "layoutControlItem3";
			this.layoutControlItem3.Location = new System.Drawing.Point(0, 0);
			this.layoutControlItem3.Name = "layoutControlItem3";
			this.layoutControlItem3.Size = new System.Drawing.Size(631, 361);
			this.layoutControlItem3.Text = "layoutControlItem3";
			this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
			this.layoutControlItem3.TextToControlDistance = 0;
			this.layoutControlItem3.TextVisible = false;
			// 
			// emptySpaceItem2
			// 
			this.emptySpaceItem2.AllowHotTrack = false;
			this.emptySpaceItem2.CustomizationFormText = "emptySpaceItem2";
			this.emptySpaceItem2.Location = new System.Drawing.Point(0, 48);
			this.emptySpaceItem2.Name = "emptySpaceItem2";
			this.emptySpaceItem2.Size = new System.Drawing.Size(655, 11);
			this.emptySpaceItem2.Text = "emptySpaceItem2";
			this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
			// 
			// layoutControlItem4
			// 
			this.layoutControlItem4.Control = this.txtHariKhusus;
			this.layoutControlItem4.CustomizationFormText = "layoutControlItem4";
			this.layoutControlItem4.Location = new System.Drawing.Point(219, 0);
			this.layoutControlItem4.Name = "layoutControlItem4";
			this.layoutControlItem4.Size = new System.Drawing.Size(82, 24);
			this.layoutControlItem4.Text = "layoutControlItem4";
			this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
			this.layoutControlItem4.TextToControlDistance = 0;
			this.layoutControlItem4.TextVisible = false;
			// 
			// UI_OrderKoranDialog
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(675, 532);
			this.Controls.Add(this.layoutControl1);
			this.Name = "UI_OrderKoranDialog";
			this.Text = "UI_OrderKoranDialog";
			this.Controls.SetChildIndex(this.layoutControl1, 0);
			((System.ComponentModel.ISupportInitialize)(this.session)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
			this.layoutControl1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.txtHariKhusus.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.xGrid)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.xGridView)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.colSpinRepo)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtKeterangan.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtTanggal.Properties.CalendarTimeProperties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtTanggal.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private DevExpress.XtraLayout.LayoutControl layoutControl1;
		private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
		private DevExpress.XtraGrid.GridControl xGrid;
		private DevExpress.XtraGrid.Views.Grid.GridView xGridView;
		private DevExpress.XtraEditors.TextEdit txtKeterangan;
		private DevExpress.XtraEditors.DateEdit txtTanggal;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
		private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
		private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
		private DevExpress.XtraGrid.Columns.GridColumn colRute;
		private DevExpress.XtraGrid.Columns.GridColumn colKodeAgen;
		private DevExpress.XtraGrid.Columns.GridColumn colJatah;
		private DevExpress.XtraGrid.Columns.GridColumn colKonsi;
		private DevExpress.XtraGrid.Columns.GridColumn colGratis;
		private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
		private DevExpress.XtraGrid.Columns.GridColumn colNamaAgen;
		private DevExpress.XtraGrid.Columns.GridColumn colOplah;
		private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit colSpinRepo;
		private DevExpress.XtraEditors.CheckEdit txtHariKhusus;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
	}
}