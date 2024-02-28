namespace NuSoft.NUI.Win.Forms.Modules.NuSoft007.UI.PPh
{
	partial class UI_TarifPPhPs17
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
			this.colTarif = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colBatasBawah = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colBatasAtas = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colKeterangan = new DevExpress.XtraGrid.Columns.GridColumn();
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
			this.xGrid.Size = new System.Drawing.Size(765, 375);
			// 
			// xGridView
			// 
			this.xGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colTarif,
            this.colBatasBawah,
            this.colBatasAtas,
            this.colKeterangan,
            this.colId});
			this.xGridView.OptionsBehavior.Editable = false;
			this.xGridView.OptionsDetail.EnableMasterViewMode = false;
			this.xGridView.OptionsSelection.MultiSelect = true;
			this.xGridView.OptionsView.ShowGroupPanel = false;
			// 
			// ifSource
			// 
			this.ifSource.DisplayableProperties = "Id;Tarif;BatasBawah;BatasAtas;Keterangan";
			this.ifSource.ObjectType = typeof(NuSoft.NUI.Win.Forms.Modules.NuSoft007.Persistent.TarifPPh17);
			// 
			// barMenu
			// 
			this.barMenu.OptionsBar.AllowQuickCustomization = false;
			this.barMenu.OptionsBar.DrawDragBorder = false;
			this.barMenu.OptionsBar.UseWholeRow = true;
			// 
			// colTarif
			// 
			this.colTarif.DisplayFormat.FormatString = "n0";
			this.colTarif.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.colTarif.FieldName = "Tarif";
			this.colTarif.Name = "colTarif";
			this.colTarif.Visible = true;
			this.colTarif.VisibleIndex = 0;
			// 
			// colBatasBawah
			// 
			this.colBatasBawah.DisplayFormat.FormatString = "n0";
			this.colBatasBawah.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.colBatasBawah.FieldName = "BatasBawah";
			this.colBatasBawah.Name = "colBatasBawah";
			this.colBatasBawah.Visible = true;
			this.colBatasBawah.VisibleIndex = 1;
			// 
			// colBatasAtas
			// 
			this.colBatasAtas.DisplayFormat.FormatString = "n0";
			this.colBatasAtas.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.colBatasAtas.FieldName = "BatasAtas";
			this.colBatasAtas.Name = "colBatasAtas";
			this.colBatasAtas.Visible = true;
			this.colBatasAtas.VisibleIndex = 2;
			// 
			// colKeterangan
			// 
			this.colKeterangan.FieldName = "Keterangan";
			this.colKeterangan.Name = "colKeterangan";
			this.colKeterangan.Visible = true;
			this.colKeterangan.VisibleIndex = 3;
			// 
			// colId
			// 
			this.colId.FieldName = "Id";
			this.colId.Name = "colId";
			// 
			// UI_TarifPPhPs17
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(765, 402);
			this.Name = "UI_TarifPPhPs17";
			this.Text = "Tarih PPh 17";
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

		private DevExpress.XtraGrid.Columns.GridColumn colTarif;
		private DevExpress.XtraGrid.Columns.GridColumn colBatasBawah;
		private DevExpress.XtraGrid.Columns.GridColumn colBatasAtas;
		private DevExpress.XtraGrid.Columns.GridColumn colKeterangan;
		private DevExpress.XtraGrid.Columns.GridColumn colId;
	}
}
