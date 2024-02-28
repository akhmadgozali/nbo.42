namespace NuSoft.NUI.Win.Forms.Modules.NuSoft007.UI.PPn
{
	partial class UI_NomorFakturDialog
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
			this.xGridDetail = new DevExpress.XtraGrid.GridControl();
			this.xGridViewDetail = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.colDNomor = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colDTerpakai = new DevExpress.XtraGrid.Columns.GridColumn();
			this.txtKeterangan = new DevExpress.XtraEditors.MemoEdit();
			this.txtNomorAkhir = new DevExpress.XtraEditors.TextEdit();
			this.txtNomorAwal = new DevExpress.XtraEditors.TextEdit();
			this.txtTanggalBerlaku = new DevExpress.XtraEditors.DateEdit();
			this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
			this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
			this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
			this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
			this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
			this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
			((System.ComponentModel.ISupportInitialize)(this.session)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
			this.layoutControl1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.xGridDetail)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.xGridViewDetail)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtKeterangan.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtNomorAkhir.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtNomorAwal.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtTanggalBerlaku.Properties.CalendarTimeProperties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtTanggalBerlaku.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
			this.SuspendLayout();
			// 
			// layoutControl1
			// 
			this.layoutControl1.Controls.Add(this.xGridDetail);
			this.layoutControl1.Controls.Add(this.txtKeterangan);
			this.layoutControl1.Controls.Add(this.txtNomorAkhir);
			this.layoutControl1.Controls.Add(this.txtNomorAwal);
			this.layoutControl1.Controls.Add(this.txtTanggalBerlaku);
			this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.layoutControl1.Location = new System.Drawing.Point(0, 0);
			this.layoutControl1.Name = "layoutControl1";
			this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(716, 132, 650, 400);
			this.layoutControl1.OptionsFocus.EnableAutoTabOrder = false;
			this.layoutControl1.Root = this.layoutControlGroup1;
			this.layoutControl1.Size = new System.Drawing.Size(672, 407);
			this.layoutControl1.TabIndex = 0;
			this.layoutControl1.Text = "layoutControl1";
			// 
			// xGridDetail
			// 
			this.xGridDetail.Location = new System.Drawing.Point(338, 28);
			this.xGridDetail.MainView = this.xGridViewDetail;
			this.xGridDetail.Name = "xGridDetail";
			this.xGridDetail.Size = new System.Drawing.Size(322, 367);
			this.xGridDetail.TabIndex = 4;
			this.xGridDetail.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.xGridViewDetail});
			// 
			// xGridViewDetail
			// 
			this.xGridViewDetail.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colDNomor,
            this.colDTerpakai});
			this.xGridViewDetail.GridControl = this.xGridDetail;
			this.xGridViewDetail.Name = "xGridViewDetail";
			this.xGridViewDetail.OptionsDetail.EnableMasterViewMode = false;
			this.xGridViewDetail.OptionsView.ShowFooter = true;
			this.xGridViewDetail.OptionsView.ShowGroupPanel = false;
			// 
			// colDNomor
			// 
			this.colDNomor.Caption = "Nomor Seri";
			this.colDNomor.FieldName = "NomorSeriFaktur";
			this.colDNomor.Name = "colDNomor";
			this.colDNomor.OptionsColumn.AllowEdit = false;
			this.colDNomor.OptionsColumn.ReadOnly = true;
			this.colDNomor.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "NomorSeriFaktur", "Jumlah FP : {0:n0}")});
			this.colDNomor.Visible = true;
			this.colDNomor.VisibleIndex = 0;
			this.colDNomor.Width = 220;
			// 
			// colDTerpakai
			// 
			this.colDTerpakai.Caption = "Terpakai";
			this.colDTerpakai.FieldName = "Terpakai";
			this.colDTerpakai.Name = "colDTerpakai";
			this.colDTerpakai.OptionsColumn.AllowEdit = false;
			this.colDTerpakai.OptionsColumn.ReadOnly = true;
			this.colDTerpakai.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Custom, "Terpakai", "{0:n0}", "Terpakai")});
			this.colDTerpakai.Visible = true;
			this.colDTerpakai.VisibleIndex = 1;
			this.colDTerpakai.Width = 84;
			// 
			// txtKeterangan
			// 
			this.txtKeterangan.EnterMoveNextControl = true;
			this.txtKeterangan.Location = new System.Drawing.Point(89, 84);
			this.txtKeterangan.Name = "txtKeterangan";
			this.txtKeterangan.Size = new System.Drawing.Size(245, 311);
			this.txtKeterangan.StyleController = this.layoutControl1;
			this.txtKeterangan.TabIndex = 3;
			// 
			// txtNomorAkhir
			// 
			this.txtNomorAkhir.EnterMoveNextControl = true;
			this.txtNomorAkhir.Location = new System.Drawing.Point(89, 60);
			this.txtNomorAkhir.Name = "txtNomorAkhir";
			this.txtNomorAkhir.Properties.Mask.EditMask = "000-00.00000000";
			this.txtNomorAkhir.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple;
			this.txtNomorAkhir.Size = new System.Drawing.Size(245, 20);
			this.txtNomorAkhir.StyleController = this.layoutControl1;
			this.txtNomorAkhir.TabIndex = 2;
			// 
			// txtNomorAwal
			// 
			this.txtNomorAwal.EnterMoveNextControl = true;
			this.txtNomorAwal.Location = new System.Drawing.Point(89, 36);
			this.txtNomorAwal.Name = "txtNomorAwal";
			this.txtNomorAwal.Properties.Mask.EditMask = "000-00.00000000";
			this.txtNomorAwal.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple;
			this.txtNomorAwal.Size = new System.Drawing.Size(245, 20);
			this.txtNomorAwal.StyleController = this.layoutControl1;
			this.txtNomorAwal.TabIndex = 1;
			// 
			// txtTanggalBerlaku
			// 
			this.txtTanggalBerlaku.EditValue = null;
			this.txtTanggalBerlaku.EnterMoveNextControl = true;
			this.txtTanggalBerlaku.Location = new System.Drawing.Point(89, 12);
			this.txtTanggalBerlaku.Name = "txtTanggalBerlaku";
			this.txtTanggalBerlaku.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.txtTanggalBerlaku.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.txtTanggalBerlaku.Properties.DisplayFormat.FormatString = "D";
			this.txtTanggalBerlaku.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
			this.txtTanggalBerlaku.Size = new System.Drawing.Size(245, 20);
			this.txtTanggalBerlaku.StyleController = this.layoutControl1;
			this.txtTanggalBerlaku.TabIndex = 0;
			// 
			// layoutControlGroup1
			// 
			this.layoutControlGroup1.CustomizationFormText = "Root";
			this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
			this.layoutControlGroup1.GroupBordersVisible = false;
			this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.layoutControlItem5,
            this.layoutControlItem6});
			this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
			this.layoutControlGroup1.Name = "Root";
			this.layoutControlGroup1.Size = new System.Drawing.Size(672, 407);
			this.layoutControlGroup1.Text = "Root";
			this.layoutControlGroup1.TextVisible = false;
			// 
			// layoutControlItem1
			// 
			this.layoutControlItem1.Control = this.txtTanggalBerlaku;
			this.layoutControlItem1.CustomizationFormText = "Mulai Berlaku";
			this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
			this.layoutControlItem1.Name = "layoutControlItem1";
			this.layoutControlItem1.Size = new System.Drawing.Size(326, 24);
			this.layoutControlItem1.Text = "Mulai Berlaku";
			this.layoutControlItem1.TextSize = new System.Drawing.Size(74, 13);
			// 
			// layoutControlItem3
			// 
			this.layoutControlItem3.Control = this.txtNomorAwal;
			this.layoutControlItem3.CustomizationFormText = "Nomor FP Dari  ";
			this.layoutControlItem3.Location = new System.Drawing.Point(0, 24);
			this.layoutControlItem3.Name = "layoutControlItem3";
			this.layoutControlItem3.Size = new System.Drawing.Size(326, 24);
			this.layoutControlItem3.Text = "Nomor FP Dari  ";
			this.layoutControlItem3.TextSize = new System.Drawing.Size(74, 13);
			// 
			// layoutControlItem4
			// 
			this.layoutControlItem4.Control = this.txtNomorAkhir;
			this.layoutControlItem4.CustomizationFormText = "s/d";
			this.layoutControlItem4.Location = new System.Drawing.Point(0, 48);
			this.layoutControlItem4.Name = "layoutControlItem4";
			this.layoutControlItem4.Size = new System.Drawing.Size(326, 24);
			this.layoutControlItem4.Text = "s/d";
			this.layoutControlItem4.TextSize = new System.Drawing.Size(74, 13);
			// 
			// layoutControlItem5
			// 
			this.layoutControlItem5.Control = this.txtKeterangan;
			this.layoutControlItem5.CustomizationFormText = "Keterangan";
			this.layoutControlItem5.Location = new System.Drawing.Point(0, 72);
			this.layoutControlItem5.Name = "layoutControlItem5";
			this.layoutControlItem5.Size = new System.Drawing.Size(326, 315);
			this.layoutControlItem5.Text = "Keterangan";
			this.layoutControlItem5.TextSize = new System.Drawing.Size(74, 13);
			// 
			// layoutControlItem6
			// 
			this.layoutControlItem6.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.layoutControlItem6.AppearanceItemCaption.Options.UseFont = true;
			this.layoutControlItem6.Control = this.xGridDetail;
			this.layoutControlItem6.CustomizationFormText = "Detail Nomor";
			this.layoutControlItem6.Location = new System.Drawing.Point(326, 0);
			this.layoutControlItem6.Name = "layoutControlItem6";
			this.layoutControlItem6.Size = new System.Drawing.Size(326, 387);
			this.layoutControlItem6.Text = "Detail Nomor";
			this.layoutControlItem6.TextLocation = DevExpress.Utils.Locations.Top;
			this.layoutControlItem6.TextSize = new System.Drawing.Size(74, 13);
			// 
			// UI_NomorFakturDialog
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(672, 456);
			this.Controls.Add(this.layoutControl1);
			this.Name = "UI_NomorFakturDialog";
			this.Text = "UI_NomorFakturDialog";
			this.Controls.SetChildIndex(this.layoutControl1, 0);
			((System.ComponentModel.ISupportInitialize)(this.session)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
			this.layoutControl1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.xGridDetail)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.xGridViewDetail)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtKeterangan.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtNomorAkhir.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtNomorAwal.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtTanggalBerlaku.Properties.CalendarTimeProperties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtTanggalBerlaku.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private DevExpress.XtraLayout.LayoutControl layoutControl1;
		private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
		private DevExpress.XtraGrid.GridControl xGridDetail;
		private DevExpress.XtraGrid.Views.Grid.GridView xGridViewDetail;
		private DevExpress.XtraEditors.MemoEdit txtKeterangan;
		private DevExpress.XtraEditors.TextEdit txtNomorAkhir;
		private DevExpress.XtraEditors.TextEdit txtNomorAwal;
		private DevExpress.XtraEditors.DateEdit txtTanggalBerlaku;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
		private DevExpress.XtraGrid.Columns.GridColumn colDNomor;
		private DevExpress.XtraGrid.Columns.GridColumn colDTerpakai;
	}
}