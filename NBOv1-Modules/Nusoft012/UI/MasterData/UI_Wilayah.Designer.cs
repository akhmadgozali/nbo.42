namespace NuSoft.NUI.Win.Forms.Modules.NuSoft012.UI.MasterData
{
	partial class UI_Wilayah
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
			this.colRegional = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colKelompokOmzet = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colNama = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colJatuhTempo = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colKodeInvoice = new DevExpress.XtraGrid.Columns.GridColumn();
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
			// 
			// xGridView
			// 
			this.xGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colRegional,
            this.colKelompokOmzet,
            this.colKodeInvoice,
            this.colNama,
            this.colJatuhTempo,
            this.colKeterangan,
            this.colId});
			this.xGridView.OptionsBehavior.Editable = false;
			this.xGridView.OptionsDetail.EnableMasterViewMode = false;
			this.xGridView.OptionsSelection.MultiSelect = true;
			this.xGridView.OptionsView.ShowAutoFilterRow = true;
			this.xGridView.OptionsView.ShowGroupPanel = false;
			// 
			// ifSource
			// 
			this.ifSource.DisplayableProperties = "Id;Regional.Nama;KelompokOmzet.Kode;Kode;Nama;JatuhTempo;Keterangan";
			this.ifSource.ObjectType = typeof(NuSoft.NUI.Win.Forms.Modules.NuSoft012.Persistent.Wilayah);
			// 
			// barMenu
			// 
			this.barMenu.OptionsBar.AllowQuickCustomization = false;
			this.barMenu.OptionsBar.DrawDragBorder = false;
			this.barMenu.OptionsBar.UseWholeRow = true;
			// 
			// colRegional
			// 
			this.colRegional.Caption = "Regional";
			this.colRegional.FieldName = "Regional.Nama";
			this.colRegional.Name = "colRegional";
			this.colRegional.Visible = true;
			this.colRegional.VisibleIndex = 0;
			// 
			// colKelompokOmzet
			// 
			this.colKelompokOmzet.Caption = "Kelompok Omzet";
			this.colKelompokOmzet.FieldName = "KelompokOmzet.Kode";
			this.colKelompokOmzet.Name = "colKelompokOmzet";
			this.colKelompokOmzet.Visible = true;
			this.colKelompokOmzet.VisibleIndex = 1;
			// 
			// colNama
			// 
			this.colNama.FieldName = "Nama";
			this.colNama.Name = "colNama";
			this.colNama.Visible = true;
			this.colNama.VisibleIndex = 2;
			// 
			// colJatuhTempo
			// 
			this.colJatuhTempo.FieldName = "JatuhTempo";
			this.colJatuhTempo.Name = "colJatuhTempo";
			this.colJatuhTempo.Visible = true;
			this.colJatuhTempo.VisibleIndex = 3;
			// 
			// colKodeInvoice
			// 
			this.colKodeInvoice.FieldName = "Kode";
			this.colKodeInvoice.Name = "colKodeInvoice";
			this.colKodeInvoice.Visible = true;
			this.colKodeInvoice.VisibleIndex = 2;
			// 
			// colKeterangan
			// 
			this.colKeterangan.FieldName = "Keterangan";
			this.colKeterangan.Name = "colKeterangan";
			this.colKeterangan.Visible = true;
			this.colKeterangan.VisibleIndex = 5;
			// 
			// colId
			// 
			this.colId.FieldName = "Id";
			this.colId.Name = "colId";
			// 
			// UI_Wilayah
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(759, 395);
			this.Name = "UI_Wilayah";
			this.Text = "Wilayah";
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

		private DevExpress.XtraGrid.Columns.GridColumn colRegional;
		private DevExpress.XtraGrid.Columns.GridColumn colKelompokOmzet;
		private DevExpress.XtraGrid.Columns.GridColumn colNama;
		private DevExpress.XtraGrid.Columns.GridColumn colJatuhTempo;
		private DevExpress.XtraGrid.Columns.GridColumn colKodeInvoice;
		private DevExpress.XtraGrid.Columns.GridColumn colKeterangan;
		private DevExpress.XtraGrid.Columns.GridColumn colId;
	}
}
