namespace NuSoft.NUI.Win.Forms.Modules.NuSoft011.UI.Transaksi
{
	partial class UI_ReturDialog
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
			this.colTgl = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colKonsiTotal = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colRetur = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colSpinRepo = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
			this.txtPeriode = new DevExpress.XtraEditors.TextEdit();
			this.txtAgen = new DevExpress.XtraEditors.TextEdit();
			this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
			this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
			this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
			this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
			this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
			((System.ComponentModel.ISupportInitialize)(this.session)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
			this.layoutControl1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.xGrid)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.xGridView)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.colSpinRepo)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtPeriode.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtAgen.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
			this.SuspendLayout();
			// 
			// layoutControl1
			// 
			this.layoutControl1.Controls.Add(this.xGrid);
			this.layoutControl1.Controls.Add(this.txtPeriode);
			this.layoutControl1.Controls.Add(this.txtAgen);
			this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.layoutControl1.Location = new System.Drawing.Point(0, 0);
			this.layoutControl1.Name = "layoutControl1";
			this.layoutControl1.Root = this.layoutControlGroup1;
			this.layoutControl1.Size = new System.Drawing.Size(382, 490);
			this.layoutControl1.TabIndex = 2;
			this.layoutControl1.Text = "layoutControl1";
			// 
			// xGrid
			// 
			this.xGrid.Location = new System.Drawing.Point(12, 70);
			this.xGrid.MainView = this.xGridView;
			this.xGrid.Name = "xGrid";
			this.xGrid.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.colSpinRepo});
			this.xGrid.Size = new System.Drawing.Size(358, 408);
			this.xGrid.TabIndex = 8;
			this.xGrid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.xGridView});
			// 
			// xGridView
			// 
			this.xGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colTgl,
            this.colKonsiTotal,
            this.colRetur});
			this.xGridView.FixedLineWidth = 1;
			this.xGridView.GridControl = this.xGrid;
			this.xGridView.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Oplah", null, " | Oplah = {0:n0}")});
			this.xGridView.Name = "xGridView";
			this.xGridView.OptionsDetail.EnableMasterViewMode = false;
			this.xGridView.OptionsNavigation.EnterMoveNextColumn = true;
			this.xGridView.OptionsView.ShowFooter = true;
			this.xGridView.OptionsView.ShowGroupPanel = false;
			// 
			// colTgl
			// 
			this.colTgl.AppearanceCell.Options.UseTextOptions = true;
			this.colTgl.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colTgl.AppearanceHeader.Options.UseTextOptions = true;
			this.colTgl.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colTgl.Caption = "Tanggal";
			this.colTgl.DisplayFormat.FormatString = "dd";
			this.colTgl.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
			this.colTgl.FieldName = "Main.Tanggal";
			this.colTgl.Name = "colTgl";
			this.colTgl.OptionsColumn.AllowEdit = false;
			this.colTgl.OptionsColumn.ReadOnly = true;
			this.colTgl.Visible = true;
			this.colTgl.VisibleIndex = 0;
			this.colTgl.Width = 50;
			// 
			// colKonsiTotal
			// 
			this.colKonsiTotal.AppearanceCell.Options.UseTextOptions = true;
			this.colKonsiTotal.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
			this.colKonsiTotal.AppearanceHeader.Options.UseTextOptions = true;
			this.colKonsiTotal.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colKonsiTotal.Caption = "Konsi";
			this.colKonsiTotal.DisplayFormat.FormatString = "n0";
			this.colKonsiTotal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.colKonsiTotal.FieldName = "Konsi";
			this.colKonsiTotal.Name = "colKonsiTotal";
			this.colKonsiTotal.OptionsColumn.AllowEdit = false;
			this.colKonsiTotal.OptionsColumn.ReadOnly = true;
			this.colKonsiTotal.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Konsi", "{0:n0}")});
			this.colKonsiTotal.Visible = true;
			this.colKonsiTotal.VisibleIndex = 1;
			this.colKonsiTotal.Width = 50;
			// 
			// colRetur
			// 
			this.colRetur.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.colRetur.AppearanceCell.Options.UseBackColor = true;
			this.colRetur.AppearanceCell.Options.UseTextOptions = true;
			this.colRetur.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
			this.colRetur.AppearanceHeader.Options.UseTextOptions = true;
			this.colRetur.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colRetur.Caption = "Retur";
			this.colRetur.ColumnEdit = this.colSpinRepo;
			this.colRetur.DisplayFormat.FormatString = "n0";
			this.colRetur.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.colRetur.FieldName = "Retur";
			this.colRetur.Name = "colRetur";
			this.colRetur.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Retur", "{0:n0}")});
			this.colRetur.Visible = true;
			this.colRetur.VisibleIndex = 2;
			this.colRetur.Width = 50;
			// 
			// colSpinRepo
			// 
			this.colSpinRepo.AutoHeight = false;
			this.colSpinRepo.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.colSpinRepo.Name = "colSpinRepo";
			// 
			// txtPeriode
			// 
			this.txtPeriode.Enabled = false;
			this.txtPeriode.Location = new System.Drawing.Point(66, 36);
			this.txtPeriode.Name = "txtPeriode";
			this.txtPeriode.Size = new System.Drawing.Size(304, 20);
			this.txtPeriode.StyleController = this.layoutControl1;
			this.txtPeriode.TabIndex = 5;
			// 
			// txtAgen
			// 
			this.txtAgen.Enabled = false;
			this.txtAgen.Location = new System.Drawing.Point(66, 12);
			this.txtAgen.Name = "txtAgen";
			this.txtAgen.Size = new System.Drawing.Size(304, 20);
			this.txtAgen.StyleController = this.layoutControl1;
			this.txtAgen.TabIndex = 4;
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
            this.layoutControlItem3});
			this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
			this.layoutControlGroup1.Name = "layoutControlGroup1";
			this.layoutControlGroup1.Size = new System.Drawing.Size(382, 490);
			this.layoutControlGroup1.Text = "layoutControlGroup1";
			this.layoutControlGroup1.TextVisible = false;
			// 
			// layoutControlItem1
			// 
			this.layoutControlItem1.Control = this.txtAgen;
			this.layoutControlItem1.CustomizationFormText = "Agen";
			this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
			this.layoutControlItem1.Name = "layoutControlItem1";
			this.layoutControlItem1.Size = new System.Drawing.Size(362, 24);
			this.layoutControlItem1.Text = "Agen";
			this.layoutControlItem1.TextSize = new System.Drawing.Size(51, 13);
			// 
			// emptySpaceItem1
			// 
			this.emptySpaceItem1.AllowHotTrack = false;
			this.emptySpaceItem1.CustomizationFormText = "emptySpaceItem1";
			this.emptySpaceItem1.Location = new System.Drawing.Point(0, 48);
			this.emptySpaceItem1.Name = "emptySpaceItem1";
			this.emptySpaceItem1.Size = new System.Drawing.Size(362, 10);
			this.emptySpaceItem1.Text = "emptySpaceItem1";
			this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
			// 
			// layoutControlItem2
			// 
			this.layoutControlItem2.Control = this.txtPeriode;
			this.layoutControlItem2.CustomizationFormText = "Periode     ";
			this.layoutControlItem2.Location = new System.Drawing.Point(0, 24);
			this.layoutControlItem2.Name = "layoutControlItem2";
			this.layoutControlItem2.Size = new System.Drawing.Size(362, 24);
			this.layoutControlItem2.Text = "Periode     ";
			this.layoutControlItem2.TextSize = new System.Drawing.Size(51, 13);
			// 
			// layoutControlItem3
			// 
			this.layoutControlItem3.Control = this.xGrid;
			this.layoutControlItem3.CustomizationFormText = "layoutControlItem3";
			this.layoutControlItem3.Location = new System.Drawing.Point(0, 58);
			this.layoutControlItem3.Name = "layoutControlItem3";
			this.layoutControlItem3.Size = new System.Drawing.Size(362, 412);
			this.layoutControlItem3.Text = "layoutControlItem3";
			this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
			this.layoutControlItem3.TextToControlDistance = 0;
			this.layoutControlItem3.TextVisible = false;
			// 
			// UI_ReturDialog
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(382, 539);
			this.Controls.Add(this.layoutControl1);
			this.Name = "UI_ReturDialog";
			this.Text = "UI_MutasiAgenDialog";
			this.Controls.SetChildIndex(this.layoutControl1, 0);
			((System.ComponentModel.ISupportInitialize)(this.session)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
			this.layoutControl1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.xGrid)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.xGridView)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.colSpinRepo)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtPeriode.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtAgen.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private DevExpress.XtraLayout.LayoutControl layoutControl1;
		private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
		private DevExpress.XtraEditors.TextEdit txtPeriode;
		private DevExpress.XtraEditors.TextEdit txtAgen;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
		private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
		private DevExpress.XtraGrid.GridControl xGrid;
		private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit colSpinRepo;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
		private DevExpress.XtraGrid.Views.Grid.GridView xGridView;
		private DevExpress.XtraGrid.Columns.GridColumn colTgl;
		private DevExpress.XtraGrid.Columns.GridColumn colKonsiTotal;
		private DevExpress.XtraGrid.Columns.GridColumn colRetur;
	}
}