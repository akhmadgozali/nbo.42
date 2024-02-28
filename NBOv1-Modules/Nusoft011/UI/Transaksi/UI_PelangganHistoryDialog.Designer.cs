namespace NuSoft.NUI.Win.Forms.Modules.NuSoft011.UI.Transaksi
{
	partial class UI_PelangganHistoryDialog
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
			this.xGrid = new DevExpress.XtraGrid.GridControl();
			this.xGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.colTanggal = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colJumlahExp = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colStatus = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colKeterangan = new DevExpress.XtraGrid.Columns.GridColumn();
			this.txtAlamat = new DevExpress.XtraEditors.MemoEdit();
			this.txtStatus = new DevExpress.XtraEditors.TextEdit();
			this.txtNama = new DevExpress.XtraEditors.TextEdit();
			this.txtNomor = new DevExpress.XtraEditors.TextEdit();
			this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
			this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
			this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
			this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
			this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
			this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
			this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
			((System.ComponentModel.ISupportInitialize)(this.PanelControl1)).BeginInit();
			this.PanelControl1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
			this.layoutControl1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.xGrid)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.xGridView)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtAlamat.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtStatus.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtNama.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtNomor.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
			this.SuspendLayout();
			// 
			// btn1
			// 
			this.btn1.Appearance.ForeColor = System.Drawing.Color.Green;
			this.btn1.Appearance.Options.UseForeColor = true;
			this.btn1.Location = new System.Drawing.Point(386, 12);
			// 
			// btn2
			// 
			this.btn2.Appearance.ForeColor = System.Drawing.Color.Red;
			this.btn2.Appearance.Options.UseForeColor = true;
			this.btn2.Location = new System.Drawing.Point(479, 12);
			// 
			// PanelControl1
			// 
			this.PanelControl1.Location = new System.Drawing.Point(0, 460);
			this.PanelControl1.Size = new System.Drawing.Size(578, 49);
			// 
			// layoutControl1
			// 
			this.layoutControl1.Controls.Add(this.xGrid);
			this.layoutControl1.Controls.Add(this.txtAlamat);
			this.layoutControl1.Controls.Add(this.txtStatus);
			this.layoutControl1.Controls.Add(this.txtNama);
			this.layoutControl1.Controls.Add(this.txtNomor);
			this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.layoutControl1.Location = new System.Drawing.Point(0, 0);
			this.layoutControl1.Name = "layoutControl1";
			this.layoutControl1.Root = this.layoutControlGroup1;
			this.layoutControl1.Size = new System.Drawing.Size(578, 460);
			this.layoutControl1.TabIndex = 2;
			this.layoutControl1.Text = "layoutControl1";
			// 
			// xGrid
			// 
			this.xGrid.Location = new System.Drawing.Point(12, 160);
			this.xGrid.MainView = this.xGridView;
			this.xGrid.Name = "xGrid";
			this.xGrid.Size = new System.Drawing.Size(554, 288);
			this.xGrid.TabIndex = 8;
			this.xGrid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.xGridView});
			// 
			// xGridView
			// 
			this.xGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colTanggal,
            this.colJumlahExp,
            this.colStatus,
            this.colKeterangan});
			this.xGridView.GridControl = this.xGrid;
			this.xGridView.Name = "xGridView";
			this.xGridView.OptionsDetail.EnableMasterViewMode = false;
			this.xGridView.OptionsNavigation.EnterMoveNextColumn = true;
			this.xGridView.OptionsView.ShowGroupPanel = false;
			this.xGridView.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colTanggal, DevExpress.Data.ColumnSortOrder.Ascending)});
			// 
			// colTanggal
			// 
			this.colTanggal.Caption = "Tanggal";
			this.colTanggal.DisplayFormat.FormatString = "dd MMM yyyy";
			this.colTanggal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
			this.colTanggal.FieldName = "Tanggal";
			this.colTanggal.Name = "colTanggal";
			this.colTanggal.OptionsColumn.AllowEdit = false;
			this.colTanggal.OptionsColumn.ReadOnly = true;
			this.colTanggal.Visible = true;
			this.colTanggal.VisibleIndex = 0;
			this.colTanggal.Width = 96;
			// 
			// colJumlahExp
			// 
			this.colJumlahExp.Caption = "Jumlah Exp";
			this.colJumlahExp.DisplayFormat.FormatString = "n0";
			this.colJumlahExp.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.colJumlahExp.FieldName = "JumlahExp";
			this.colJumlahExp.Name = "colJumlahExp";
			this.colJumlahExp.OptionsColumn.AllowEdit = false;
			this.colJumlahExp.OptionsColumn.ReadOnly = true;
			this.colJumlahExp.Visible = true;
			this.colJumlahExp.VisibleIndex = 1;
			this.colJumlahExp.Width = 70;
			// 
			// colStatus
			// 
			this.colStatus.AppearanceHeader.Options.UseTextOptions = true;
			this.colStatus.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colStatus.Caption = "Status";
			this.colStatus.FieldName = "Aktif";
			this.colStatus.Name = "colStatus";
			this.colStatus.OptionsColumn.AllowEdit = false;
			this.colStatus.OptionsColumn.ReadOnly = true;
			this.colStatus.Visible = true;
			this.colStatus.VisibleIndex = 2;
			this.colStatus.Width = 40;
			// 
			// colKeterangan
			// 
			this.colKeterangan.Caption = "Keterangan";
			this.colKeterangan.FieldName = "Keterangan";
			this.colKeterangan.Name = "colKeterangan";
			this.colKeterangan.OptionsColumn.AllowEdit = false;
			this.colKeterangan.OptionsColumn.ReadOnly = true;
			this.colKeterangan.Visible = true;
			this.colKeterangan.VisibleIndex = 3;
			this.colKeterangan.Width = 330;
			// 
			// txtAlamat
			// 
			this.txtAlamat.EnterMoveNextControl = true;
			this.txtAlamat.Location = new System.Drawing.Point(98, 60);
			this.txtAlamat.Name = "txtAlamat";
			this.txtAlamat.Properties.Appearance.BackColor = System.Drawing.Color.WhiteSmoke;
			this.txtAlamat.Properties.Appearance.Options.UseBackColor = true;
			this.txtAlamat.Properties.ReadOnly = true;
			this.txtAlamat.Size = new System.Drawing.Size(468, 68);
			this.txtAlamat.StyleController = this.layoutControl1;
			this.txtAlamat.TabIndex = 7;
			// 
			// txtStatus
			// 
			this.txtStatus.EnterMoveNextControl = true;
			this.txtStatus.Location = new System.Drawing.Point(377, 12);
			this.txtStatus.Name = "txtStatus";
			this.txtStatus.Properties.Appearance.BackColor = System.Drawing.Color.WhiteSmoke;
			this.txtStatus.Properties.Appearance.Options.UseBackColor = true;
			this.txtStatus.Properties.ReadOnly = true;
			this.txtStatus.Size = new System.Drawing.Size(189, 20);
			this.txtStatus.StyleController = this.layoutControl1;
			this.txtStatus.TabIndex = 6;
			// 
			// txtNama
			// 
			this.txtNama.EnterMoveNextControl = true;
			this.txtNama.Location = new System.Drawing.Point(98, 36);
			this.txtNama.Name = "txtNama";
			this.txtNama.Properties.Appearance.BackColor = System.Drawing.Color.WhiteSmoke;
			this.txtNama.Properties.Appearance.Options.UseBackColor = true;
			this.txtNama.Properties.ReadOnly = true;
			this.txtNama.Size = new System.Drawing.Size(468, 20);
			this.txtNama.StyleController = this.layoutControl1;
			this.txtNama.TabIndex = 5;
			// 
			// txtNomor
			// 
			this.txtNomor.EnterMoveNextControl = true;
			this.txtNomor.Location = new System.Drawing.Point(98, 12);
			this.txtNomor.Name = "txtNomor";
			this.txtNomor.Properties.Appearance.BackColor = System.Drawing.Color.WhiteSmoke;
			this.txtNomor.Properties.Appearance.Options.UseBackColor = true;
			this.txtNomor.Properties.ReadOnly = true;
			this.txtNomor.Size = new System.Drawing.Size(189, 20);
			this.txtNomor.StyleController = this.layoutControl1;
			this.txtNomor.TabIndex = 4;
			// 
			// layoutControlGroup1
			// 
			this.layoutControlGroup1.CustomizationFormText = "layoutControlGroup1";
			this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
			this.layoutControlGroup1.GroupBordersVisible = false;
			this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.emptySpaceItem1,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.layoutControlItem5});
			this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
			this.layoutControlGroup1.Name = "layoutControlGroup1";
			this.layoutControlGroup1.Size = new System.Drawing.Size(578, 460);
			this.layoutControlGroup1.Text = "layoutControlGroup1";
			this.layoutControlGroup1.TextVisible = false;
			// 
			// layoutControlItem1
			// 
			this.layoutControlItem1.Control = this.txtNomor;
			this.layoutControlItem1.CustomizationFormText = "Kode Pelanggan  ";
			this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
			this.layoutControlItem1.Name = "layoutControlItem1";
			this.layoutControlItem1.Size = new System.Drawing.Size(279, 24);
			this.layoutControlItem1.Text = "Kode Pelanggan  ";
			this.layoutControlItem1.TextSize = new System.Drawing.Size(83, 13);
			// 
			// emptySpaceItem1
			// 
			this.emptySpaceItem1.AllowHotTrack = false;
			this.emptySpaceItem1.CustomizationFormText = "emptySpaceItem1";
			this.emptySpaceItem1.Location = new System.Drawing.Point(0, 120);
			this.emptySpaceItem1.Name = "emptySpaceItem1";
			this.emptySpaceItem1.Size = new System.Drawing.Size(558, 10);
			this.emptySpaceItem1.Text = "emptySpaceItem1";
			this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
			// 
			// layoutControlItem2
			// 
			this.layoutControlItem2.Control = this.txtNama;
			this.layoutControlItem2.CustomizationFormText = "Nama";
			this.layoutControlItem2.Location = new System.Drawing.Point(0, 24);
			this.layoutControlItem2.Name = "layoutControlItem2";
			this.layoutControlItem2.Size = new System.Drawing.Size(558, 24);
			this.layoutControlItem2.Text = "Nama";
			this.layoutControlItem2.TextSize = new System.Drawing.Size(83, 13);
			// 
			// layoutControlItem3
			// 
			this.layoutControlItem3.Control = this.txtStatus;
			this.layoutControlItem3.CustomizationFormText = "Status";
			this.layoutControlItem3.Location = new System.Drawing.Point(279, 0);
			this.layoutControlItem3.Name = "layoutControlItem3";
			this.layoutControlItem3.Size = new System.Drawing.Size(279, 24);
			this.layoutControlItem3.Text = "Status";
			this.layoutControlItem3.TextSize = new System.Drawing.Size(83, 13);
			// 
			// layoutControlItem4
			// 
			this.layoutControlItem4.Control = this.txtAlamat;
			this.layoutControlItem4.CustomizationFormText = "Alamat";
			this.layoutControlItem4.Location = new System.Drawing.Point(0, 48);
			this.layoutControlItem4.Name = "layoutControlItem4";
			this.layoutControlItem4.Size = new System.Drawing.Size(558, 72);
			this.layoutControlItem4.Text = "Alamat";
			this.layoutControlItem4.TextSize = new System.Drawing.Size(83, 13);
			// 
			// layoutControlItem5
			// 
			this.layoutControlItem5.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.layoutControlItem5.AppearanceItemCaption.Options.UseFont = true;
			this.layoutControlItem5.Control = this.xGrid;
			this.layoutControlItem5.CustomizationFormText = "History Pelanggan";
			this.layoutControlItem5.Location = new System.Drawing.Point(0, 130);
			this.layoutControlItem5.Name = "layoutControlItem5";
			this.layoutControlItem5.Size = new System.Drawing.Size(558, 310);
			this.layoutControlItem5.Text = "History Pelanggan";
			this.layoutControlItem5.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize;
			this.layoutControlItem5.TextLocation = DevExpress.Utils.Locations.Top;
			this.layoutControlItem5.TextSize = new System.Drawing.Size(103, 13);
			this.layoutControlItem5.TextToControlDistance = 5;
			// 
			// UI_PelangganHistoryDialog
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(578, 509);
			this.Controls.Add(this.layoutControl1);
			this.Name = "UI_PelangganHistoryDialog";
			this.Text = "History Pelanggan";
			this.Controls.SetChildIndex(this.PanelControl1, 0);
			this.Controls.SetChildIndex(this.layoutControl1, 0);
			((System.ComponentModel.ISupportInitialize)(this.PanelControl1)).EndInit();
			this.PanelControl1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
			this.layoutControl1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.xGrid)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.xGridView)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtAlamat.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtStatus.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtNama.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtNomor.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private DevExpress.XtraLayout.LayoutControl layoutControl1;
		private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
		private DevExpress.XtraGrid.GridControl xGrid;
		private DevExpress.XtraGrid.Views.Grid.GridView xGridView;
		private DevExpress.XtraEditors.MemoEdit txtAlamat;
		private DevExpress.XtraEditors.TextEdit txtStatus;
		private DevExpress.XtraEditors.TextEdit txtNama;
		private DevExpress.XtraEditors.TextEdit txtNomor;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
		private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
		private DevExpress.XtraGrid.Columns.GridColumn colTanggal;
		private DevExpress.XtraGrid.Columns.GridColumn colStatus;
		private DevExpress.XtraGrid.Columns.GridColumn colKeterangan;
		private DevExpress.XtraGrid.Columns.GridColumn colJumlahExp;
	}
}