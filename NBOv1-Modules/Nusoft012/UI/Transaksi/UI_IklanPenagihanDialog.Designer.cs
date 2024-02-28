namespace NuSoft.NUI.Win.Forms.Modules.NuSoft012.UI.Transaksi {
	partial class UI_IklanPenagihanDialog
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UI_IklanPenagihanDialog));
			this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
			this.xGrid = new DevExpress.XtraGrid.GridControl();
			this.xGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.colTanggal = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colTanggalRepo = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
			this.colKeterangan = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colKeteranganRepo = new DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit();
			this.txtKeterangan = new DevExpress.XtraEditors.MemoEdit();
			this.txtKurir = new DevExpress.XtraEditors.LookUpEdit();
			this.txtCetak = new DevExpress.XtraEditors.CheckEdit();
			this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
			this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
			this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
			this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
			this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
			this.layCetak = new DevExpress.XtraLayout.SimpleLabelItem();
			this.emptySpaceItem3 = new DevExpress.XtraLayout.EmptySpaceItem();
			this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
			this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
			((System.ComponentModel.ISupportInitialize)(this.session)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
			this.layoutControl1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.xGrid)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.xGridView)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.colTanggalRepo)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.colTanggalRepo.CalendarTimeProperties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.colKeteranganRepo)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtKeterangan.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtKurir.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtCetak.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layCetak)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
			this.SuspendLayout();
			// 
			// layoutControl1
			// 
			this.layoutControl1.Controls.Add(this.xGrid);
			this.layoutControl1.Controls.Add(this.txtKeterangan);
			this.layoutControl1.Controls.Add(this.txtKurir);
			this.layoutControl1.Controls.Add(this.txtCetak);
			this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.layoutControl1.Location = new System.Drawing.Point(0, 0);
			this.layoutControl1.Name = "layoutControl1";
			this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(716, 138, 650, 400);
			this.layoutControl1.Root = this.layoutControlGroup1;
			this.layoutControl1.Size = new System.Drawing.Size(762, 275);
			this.layoutControl1.TabIndex = 2;
			this.layoutControl1.Text = "layoutControl1";
			// 
			// xGrid
			// 
			this.xGrid.Location = new System.Drawing.Point(314, 35);
			this.xGrid.MainView = this.xGridView;
			this.xGrid.Name = "xGrid";
			this.xGrid.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.colTanggalRepo,
            this.colKeteranganRepo});
			this.xGrid.Size = new System.Drawing.Size(431, 223);
			this.xGrid.TabIndex = 7;
			this.xGrid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.xGridView});
			// 
			// xGridView
			// 
			this.xGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colTanggal,
            this.colKeterangan});
			this.xGridView.GridControl = this.xGrid;
			this.xGridView.Name = "xGridView";
			this.xGridView.NewItemRowText = "Tambah Data";
			this.xGridView.OptionsDetail.EnableMasterViewMode = false;
			this.xGridView.OptionsNavigation.EnterMoveNextColumn = true;
			this.xGridView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top;
			this.xGridView.OptionsView.ShowGroupPanel = false;
			// 
			// colTanggal
			// 
			this.colTanggal.Caption = "Tanggal";
			this.colTanggal.ColumnEdit = this.colTanggalRepo;
			this.colTanggal.DisplayFormat.FormatString = "D";
			this.colTanggal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
			this.colTanggal.FieldName = "TanggalKirim";
			this.colTanggal.Name = "colTanggal";
			this.colTanggal.Visible = true;
			this.colTanggal.VisibleIndex = 0;
			this.colTanggal.Width = 170;
			// 
			// colTanggalRepo
			// 
			this.colTanggalRepo.AutoHeight = false;
			this.colTanggalRepo.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.colTanggalRepo.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.colTanggalRepo.DisplayFormat.FormatString = "D";
			this.colTanggalRepo.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
			this.colTanggalRepo.Name = "colTanggalRepo";
			// 
			// colKeterangan
			// 
			this.colKeterangan.Caption = "Keterangan";
			this.colKeterangan.FieldName = "Keterangan";
			this.colKeterangan.Name = "colKeterangan";
			this.colKeterangan.Visible = true;
			this.colKeterangan.VisibleIndex = 1;
			this.colKeterangan.Width = 243;
			// 
			// colKeteranganRepo
			// 
			this.colKeteranganRepo.AutoHeight = false;
			this.colKeteranganRepo.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.colKeteranganRepo.Name = "colKeteranganRepo";
			// 
			// txtKeterangan
			// 
			this.txtKeterangan.EnterMoveNextControl = true;
			this.txtKeterangan.Location = new System.Drawing.Point(80, 114);
			this.txtKeterangan.Name = "txtKeterangan";
			this.txtKeterangan.Properties.MaxLength = 255;
			this.txtKeterangan.Size = new System.Drawing.Size(225, 149);
			this.txtKeterangan.StyleController = this.layoutControl1;
			this.txtKeterangan.TabIndex = 6;
			// 
			// txtKurir
			// 
			this.txtKurir.EnterMoveNextControl = true;
			this.txtKurir.Location = new System.Drawing.Point(80, 90);
			this.txtKurir.Name = "txtKurir";
			this.txtKurir.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.txtKurir.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama", "Nama")});
			this.txtKurir.Properties.DisplayMember = "Nama";
			this.txtKurir.Properties.NullText = "[ Pilih Kurir ]";
			this.txtKurir.Properties.ShowHeader = false;
			this.txtKurir.Properties.ValueMember = "This";
			this.txtKurir.Size = new System.Drawing.Size(225, 20);
			this.txtKurir.StyleController = this.layoutControl1;
			this.txtKurir.TabIndex = 5;
			// 
			// txtCetak
			// 
			this.txtCetak.EnterMoveNextControl = true;
			this.txtCetak.Location = new System.Drawing.Point(46, 44);
			this.txtCetak.Name = "txtCetak";
			this.txtCetak.Properties.Caption = "Cetak Tanda Terima";
			this.txtCetak.Size = new System.Drawing.Size(247, 19);
			this.txtCetak.StyleController = this.layoutControl1;
			this.txtCetak.TabIndex = 4;
			// 
			// layoutControlGroup1
			// 
			this.layoutControlGroup1.CustomizationFormText = "Root";
			this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
			this.layoutControlGroup1.GroupBordersVisible = false;
			this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem3,
            this.layoutControlItem2,
            this.layoutControlGroup2,
            this.layoutControlItem4,
            this.emptySpaceItem1});
			this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
			this.layoutControlGroup1.Name = "Root";
			this.layoutControlGroup1.Size = new System.Drawing.Size(762, 275);
			this.layoutControlGroup1.Text = "Root";
			this.layoutControlGroup1.TextVisible = false;
			// 
			// layoutControlItem3
			// 
			this.layoutControlItem3.Control = this.txtKeterangan;
			this.layoutControlItem3.CustomizationFormText = "Keterangan   ";
			this.layoutControlItem3.Location = new System.Drawing.Point(0, 102);
			this.layoutControlItem3.Name = "layoutControlItem3";
			this.layoutControlItem3.Size = new System.Drawing.Size(297, 153);
			this.layoutControlItem3.Text = "Keterangan   ";
			this.layoutControlItem3.TextSize = new System.Drawing.Size(65, 13);
			// 
			// layoutControlItem2
			// 
			this.layoutControlItem2.Control = this.txtKurir;
			this.layoutControlItem2.CustomizationFormText = "Kurir";
			this.layoutControlItem2.Location = new System.Drawing.Point(0, 78);
			this.layoutControlItem2.Name = "layoutControlItem2";
			this.layoutControlItem2.Size = new System.Drawing.Size(297, 24);
			this.layoutControlItem2.Text = "Kurir";
			this.layoutControlItem2.TextSize = new System.Drawing.Size(65, 13);
			// 
			// layoutControlGroup2
			// 
			this.layoutControlGroup2.CustomizationFormText = "layoutControlGroup2";
			this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layCetak,
            this.emptySpaceItem3});
			this.layoutControlGroup2.Location = new System.Drawing.Point(0, 0);
			this.layoutControlGroup2.Name = "layoutControlGroup2";
			this.layoutControlGroup2.Size = new System.Drawing.Size(297, 67);
			this.layoutControlGroup2.Text = "layoutControlGroup2";
			this.layoutControlGroup2.TextVisible = false;
			// 
			// layoutControlItem1
			// 
			this.layoutControlItem1.Control = this.txtCetak;
			this.layoutControlItem1.CustomizationFormText = "layoutControlItem1";
			this.layoutControlItem1.Location = new System.Drawing.Point(22, 20);
			this.layoutControlItem1.Name = "layoutControlItem1";
			this.layoutControlItem1.Size = new System.Drawing.Size(251, 23);
			this.layoutControlItem1.Text = "layoutControlItem1";
			this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
			this.layoutControlItem1.TextToControlDistance = 0;
			this.layoutControlItem1.TextVisible = false;
			// 
			// layCetak
			// 
			this.layCetak.AllowHotTrack = false;
			this.layCetak.CustomizationFormText = "Nama Printer";
			this.layCetak.Image = ((System.Drawing.Image)(resources.GetObject("layCetak.Image")));
			this.layCetak.Location = new System.Drawing.Point(0, 0);
			this.layCetak.Name = "layCetak";
			this.layCetak.Size = new System.Drawing.Size(273, 20);
			this.layCetak.Text = "Nama Printer";
			this.layCetak.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize;
			this.layCetak.TextSize = new System.Drawing.Size(83, 16);
			// 
			// emptySpaceItem3
			// 
			this.emptySpaceItem3.AllowHotTrack = false;
			this.emptySpaceItem3.CustomizationFormText = "emptySpaceItem3";
			this.emptySpaceItem3.Location = new System.Drawing.Point(0, 20);
			this.emptySpaceItem3.Name = "emptySpaceItem3";
			this.emptySpaceItem3.Size = new System.Drawing.Size(22, 23);
			this.emptySpaceItem3.Text = "emptySpaceItem3";
			this.emptySpaceItem3.TextSize = new System.Drawing.Size(0, 0);
			// 
			// layoutControlItem4
			// 
			this.layoutControlItem4.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.layoutControlItem4.AppearanceItemCaption.Options.UseFont = true;
			this.layoutControlItem4.Control = this.xGrid;
			this.layoutControlItem4.CustomizationFormText = "Hasil Pengantaran :";
			this.layoutControlItem4.Location = new System.Drawing.Point(297, 0);
			this.layoutControlItem4.Name = "layoutControlItem4";
			this.layoutControlItem4.Size = new System.Drawing.Size(445, 255);
			this.layoutControlItem4.Spacing = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
			this.layoutControlItem4.Text = "Hasil Pengantaran :";
			this.layoutControlItem4.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize;
			this.layoutControlItem4.TextLocation = DevExpress.Utils.Locations.Top;
			this.layoutControlItem4.TextSize = new System.Drawing.Size(109, 13);
			this.layoutControlItem4.TextToControlDistance = 5;
			// 
			// emptySpaceItem1
			// 
			this.emptySpaceItem1.AllowHotTrack = false;
			this.emptySpaceItem1.CustomizationFormText = "emptySpaceItem1";
			this.emptySpaceItem1.Location = new System.Drawing.Point(0, 67);
			this.emptySpaceItem1.Name = "emptySpaceItem1";
			this.emptySpaceItem1.Size = new System.Drawing.Size(297, 11);
			this.emptySpaceItem1.Text = "emptySpaceItem1";
			this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
			// 
			// UI_IklanPenagihanDialog
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(762, 324);
			this.Controls.Add(this.layoutControl1);
			this.Name = "UI_IklanPenagihanDialog";
			this.Text = "UI_IklanKirimInvoiceDialog";
			this.Controls.SetChildIndex(this.layoutControl1, 0);
			((System.ComponentModel.ISupportInitialize)(this.session)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
			this.layoutControl1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.xGrid)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.xGridView)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.colTanggalRepo.CalendarTimeProperties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.colTanggalRepo)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.colKeteranganRepo)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtKeterangan.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtKurir.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtCetak.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layCetak)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private DevExpress.XtraLayout.LayoutControl layoutControl1;
		private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
		private DevExpress.XtraGrid.GridControl xGrid;
		private DevExpress.XtraGrid.Views.Grid.GridView xGridView;
		private DevExpress.XtraEditors.MemoEdit txtKeterangan;
		private DevExpress.XtraEditors.LookUpEdit txtKurir;
		private DevExpress.XtraEditors.CheckEdit txtCetak;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
		private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
		private DevExpress.XtraLayout.SimpleLabelItem layCetak;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
		private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
		private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem3;
		private DevExpress.XtraGrid.Columns.GridColumn colTanggal;
		private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit colTanggalRepo;
		private DevExpress.XtraGrid.Columns.GridColumn colKeterangan;
		private DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit colKeteranganRepo;
	}
}