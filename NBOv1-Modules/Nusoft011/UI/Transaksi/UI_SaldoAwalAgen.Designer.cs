namespace NuSoft.NUI.Win.Forms.Modules.NuSoft011.UI.Transaksi {
	partial class UI_SaldoAwalAgen
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
			this.xGrid = new DevExpress.XtraGrid.GridControl();
			this.xGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.colRute = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colKodeAgen = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colNamaAgen = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colSaldoAwal = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colSaldoRepo = new DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit();
			this.colKeterangan = new DevExpress.XtraGrid.Columns.GridColumn();
			((System.ComponentModel.ISupportInitialize)(this.PanelControl1)).BeginInit();
			this.PanelControl1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.xGrid)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.xGridView)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.colSaldoRepo)).BeginInit();
			this.SuspendLayout();
			// 
			// btn1
			// 
			this.btn1.Appearance.ForeColor = System.Drawing.Color.Green;
			this.btn1.Appearance.Options.UseForeColor = true;
			this.btn1.Location = new System.Drawing.Point(595, 11);
			// 
			// btn2
			// 
			this.btn2.Appearance.ForeColor = System.Drawing.Color.Red;
			this.btn2.Appearance.Options.UseForeColor = true;
			this.btn2.Location = new System.Drawing.Point(688, 11);
			// 
			// PanelControl1
			// 
			this.PanelControl1.Location = new System.Drawing.Point(0, 412);
			this.PanelControl1.Size = new System.Drawing.Size(787, 49);
			// 
			// xGrid
			// 
			this.xGrid.Dock = System.Windows.Forms.DockStyle.Fill;
			this.xGrid.Location = new System.Drawing.Point(0, 0);
			this.xGrid.MainView = this.xGridView;
			this.xGrid.Name = "xGrid";
			this.xGrid.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.colSaldoRepo});
			this.xGrid.Size = new System.Drawing.Size(787, 412);
			this.xGrid.TabIndex = 2;
			this.xGrid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.xGridView});
			// 
			// xGridView
			// 
			this.xGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colRute,
            this.colKodeAgen,
            this.colNamaAgen,
            this.colSaldoAwal,
            this.colKeterangan});
			this.xGridView.GridControl = this.xGrid;
			this.xGridView.GroupCount = 1;
			this.xGridView.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "SaldoPiutangAwal", null, " | Saldo Awal : {0:n0}")});
			this.xGridView.Name = "xGridView";
			this.xGridView.OptionsDetail.EnableMasterViewMode = false;
			this.xGridView.OptionsView.ShowAutoFilterRow = true;
			this.xGridView.OptionsView.ShowFooter = true;
			this.xGridView.OptionsView.ShowGroupPanel = false;
			this.xGridView.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colRute, DevExpress.Data.ColumnSortOrder.Ascending)});
			// 
			// colRute
			// 
			this.colRute.Caption = "Rute";
			this.colRute.FieldName = "Rute.KodeNama";
			this.colRute.Name = "colRute";
			this.colRute.OptionsColumn.AllowEdit = false;
			this.colRute.OptionsColumn.ReadOnly = true;
			this.colRute.Visible = true;
			this.colRute.VisibleIndex = 0;
			this.colRute.Width = 437;
			// 
			// colKodeAgen
			// 
			this.colKodeAgen.Caption = "Kode Agen";
			this.colKodeAgen.FieldName = "Kode";
			this.colKodeAgen.Name = "colKodeAgen";
			this.colKodeAgen.OptionsColumn.AllowEdit = false;
			this.colKodeAgen.OptionsColumn.ReadOnly = true;
			this.colKodeAgen.Visible = true;
			this.colKodeAgen.VisibleIndex = 0;
			this.colKodeAgen.Width = 140;
			// 
			// colNamaAgen
			// 
			this.colNamaAgen.Caption = "Nama Agen";
			this.colNamaAgen.FieldName = "Nama";
			this.colNamaAgen.Name = "colNamaAgen";
			this.colNamaAgen.OptionsColumn.AllowEdit = false;
			this.colNamaAgen.OptionsColumn.ReadOnly = true;
			this.colNamaAgen.Visible = true;
			this.colNamaAgen.VisibleIndex = 1;
			this.colNamaAgen.Width = 270;
			// 
			// colSaldoAwal
			// 
			this.colSaldoAwal.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.colSaldoAwal.AppearanceCell.Options.UseBackColor = true;
			this.colSaldoAwal.AppearanceHeader.Options.UseTextOptions = true;
			this.colSaldoAwal.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
			this.colSaldoAwal.Caption = "Saldo Awal";
			this.colSaldoAwal.ColumnEdit = this.colSaldoRepo;
			this.colSaldoAwal.DisplayFormat.FormatString = "n0";
			this.colSaldoAwal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.colSaldoAwal.FieldName = "SaldoPiutangAwal";
			this.colSaldoAwal.Name = "colSaldoAwal";
			this.colSaldoAwal.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "SaldoPiutangAwal", "{0:n0}")});
			this.colSaldoAwal.Visible = true;
			this.colSaldoAwal.VisibleIndex = 2;
			this.colSaldoAwal.Width = 160;
			// 
			// colSaldoRepo
			// 
			this.colSaldoRepo.AutoHeight = false;
			this.colSaldoRepo.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.colSaldoRepo.Name = "colSaldoRepo";
			// 
			// colKeterangan
			// 
			this.colKeterangan.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.colKeterangan.AppearanceCell.Options.UseBackColor = true;
			this.colKeterangan.Caption = "Keterangan";
			this.colKeterangan.FieldName = "KeteranganSaldoAwal";
			this.colKeterangan.Name = "colKeterangan";
			this.colKeterangan.Visible = true;
			this.colKeterangan.VisibleIndex = 3;
			this.colKeterangan.Width = 304;
			// 
			// UI_SaldoAwalAgen
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(787, 461);
			this.Controls.Add(this.xGrid);
			this.Name = "UI_SaldoAwalAgen";
			this.Text = "Saldo Awal Piutang Agen";
			this.Controls.SetChildIndex(this.PanelControl1, 0);
			this.Controls.SetChildIndex(this.xGrid, 0);
			((System.ComponentModel.ISupportInitialize)(this.PanelControl1)).EndInit();
			this.PanelControl1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.xGrid)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.xGridView)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.colSaldoRepo)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private DevExpress.XtraGrid.GridControl xGrid;
		private DevExpress.XtraGrid.Views.Grid.GridView xGridView;
		private DevExpress.XtraGrid.Columns.GridColumn colRute;
		private DevExpress.XtraGrid.Columns.GridColumn colKodeAgen;
		private DevExpress.XtraGrid.Columns.GridColumn colNamaAgen;
		private DevExpress.XtraGrid.Columns.GridColumn colSaldoAwal;
		private DevExpress.XtraGrid.Columns.GridColumn colKeterangan;
		private DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit colSaldoRepo;
	}
}