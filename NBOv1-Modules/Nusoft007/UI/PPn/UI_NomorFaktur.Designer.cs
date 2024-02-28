namespace NuSoft.NUI.Win.Forms.Modules.NuSoft007.UI.PPn
{
	partial class UI_NomorFaktur
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
		private void InitializeComponent() {
			this.colSisa = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colTanggalMulai = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colNomorDari = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colNomorKe = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colKeterangan = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colJumlahFP = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colTerpakai = new DevExpress.XtraGrid.Columns.GridColumn();
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
            this.colTanggalMulai,
            this.colNomorDari,
            this.colNomorKe,
            this.colJumlahFP,
            this.colTerpakai,
            this.colSisa,
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
			this.ifSource.DisplayableProperties = "Id;TanggalMulaiBerlaku;NomorDari;NomorSampai;Keterangan;JumlahFP;Terpakai;SisaFP";
			this.ifSource.ObjectType = typeof(NuSoft.NUI.Win.Forms.Modules.NuSoft007.Persistent.NomorSeriPajak);
			// 
			// barMenu
			// 
			this.barMenu.OptionsBar.AllowQuickCustomization = false;
			this.barMenu.OptionsBar.DrawDragBorder = false;
			this.barMenu.OptionsBar.UseWholeRow = true;
			// 
			// colSisa
			// 
			this.colSisa.Caption = "Sisa";
			this.colSisa.DisplayFormat.FormatString = "n0";
			this.colSisa.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.colSisa.FieldName = "SisaFP";
			this.colSisa.Name = "colSisa";
			this.colSisa.Visible = true;
			this.colSisa.VisibleIndex = 5;
			this.colSisa.Width = 77;
			// 
			// colTanggalMulai
			// 
			this.colTanggalMulai.Caption = "Mulai Berlaku";
			this.colTanggalMulai.DisplayFormat.FormatString = "dd MMM yyyy";
			this.colTanggalMulai.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
			this.colTanggalMulai.FieldName = "TanggalMulaiBerlaku";
			this.colTanggalMulai.Name = "colTanggalMulai";
			this.colTanggalMulai.Visible = true;
			this.colTanggalMulai.VisibleIndex = 0;
			this.colTanggalMulai.Width = 73;
			// 
			// colNomorDari
			// 
			this.colNomorDari.FieldName = "NomorDari";
			this.colNomorDari.Name = "colNomorDari";
			this.colNomorDari.Visible = true;
			this.colNomorDari.VisibleIndex = 1;
			this.colNomorDari.Width = 73;
			// 
			// colNomorKe
			// 
			this.colNomorKe.FieldName = "NomorSampai";
			this.colNomorKe.Name = "colNomorKe";
			this.colNomorKe.Visible = true;
			this.colNomorKe.VisibleIndex = 2;
			this.colNomorKe.Width = 73;
			// 
			// colKeterangan
			// 
			this.colKeterangan.FieldName = "Keterangan";
			this.colKeterangan.Name = "colKeterangan";
			this.colKeterangan.Visible = true;
			this.colKeterangan.VisibleIndex = 6;
			this.colKeterangan.Width = 92;
			// 
			// colJumlahFP
			// 
			this.colJumlahFP.Caption = "Jumlah FP";
			this.colJumlahFP.DisplayFormat.FormatString = "n0";
			this.colJumlahFP.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.colJumlahFP.FieldName = "JumlahFP";
			this.colJumlahFP.Name = "colJumlahFP";
			this.colJumlahFP.Visible = true;
			this.colJumlahFP.VisibleIndex = 3;
			this.colJumlahFP.Width = 77;
			// 
			// colTerpakai
			// 
			this.colTerpakai.Caption = "Terpakai";
			this.colTerpakai.DisplayFormat.FormatString = "n0";
			this.colTerpakai.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.colTerpakai.FieldName = "Terpakai";
			this.colTerpakai.Name = "colTerpakai";
			this.colTerpakai.Visible = true;
			this.colTerpakai.VisibleIndex = 4;
			this.colTerpakai.Width = 77;
			// 
			// colId
			// 
			this.colId.FieldName = "Id";
			this.colId.Name = "colId";
			// 
			// UI_NomorFaktur
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(759, 395);
			this.Name = "UI_NomorFaktur";
			this.Text = "Nomor Seri";
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
		private DevExpress.XtraGrid.Columns.GridColumn colTanggalMulai;
		private DevExpress.XtraGrid.Columns.GridColumn colNomorDari;
		private DevExpress.XtraGrid.Columns.GridColumn colNomorKe;
		private DevExpress.XtraGrid.Columns.GridColumn colKeterangan;
		private DevExpress.XtraGrid.Columns.GridColumn colJumlahFP;
		private DevExpress.XtraGrid.Columns.GridColumn colTerpakai;
		private DevExpress.XtraGrid.Columns.GridColumn colSisa;
		private DevExpress.XtraGrid.Columns.GridColumn colId;
	}
}
