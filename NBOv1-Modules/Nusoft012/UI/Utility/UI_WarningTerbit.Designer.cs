namespace NuSoft.NUI.Win.Forms.Modules.NuSoft012.UI.Utility
{
	partial class UI_WarningTerbit
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
			this.colWilayah = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colNoInvoice = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colTanggal = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colSales = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colPemasang = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colMerk = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colJudul = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colTerbitTerakhir = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colSisaTerbit = new DevExpress.XtraGrid.Columns.GridColumn();
			((System.ComponentModel.ISupportInitialize)(this.barMan)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.xpCol)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.session)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.popMenu)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.xGrid)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.xGridView)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.SplitContainerControl1)).BeginInit();
			this.SplitContainerControl1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.chartPopUp)).BeginInit();
			this.SuspendLayout();
			// 
			// xGrid
			// 
			this.xGrid.Size = new System.Drawing.Size(894, 212);
			// 
			// xGridView
			// 
			this.xGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colWilayah,
            this.colNoInvoice,
            this.colTanggal,
            this.colSales,
            this.colPemasang,
            this.colMerk,
            this.colJudul,
            this.colTerbitTerakhir,
            this.colSisaTerbit});
			this.xGridView.GroupCount = 1;
			this.xGridView.OptionsBehavior.Editable = false;
			this.xGridView.OptionsDetail.EnableMasterViewMode = false;
			this.xGridView.OptionsSelection.MultiSelect = true;
			this.xGridView.OptionsView.ShowAutoFilterRow = true;
			this.xGridView.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colWilayah, DevExpress.Data.ColumnSortOrder.Ascending)});
			// 
			// barMenu
			// 
			this.barMenu.OptionsBar.AllowQuickCustomization = false;
			this.barMenu.OptionsBar.DrawDragBorder = false;
			this.barMenu.OptionsBar.UseWholeRow = true;
			// 
			// SplitContainerControl1
			// 
			this.SplitContainerControl1.Size = new System.Drawing.Size(894, 385);
			// 
			// colWilayah
			// 
			this.colWilayah.Caption = "Wilayah";
			this.colWilayah.FieldName = "Wilayah";
			this.colWilayah.Name = "colWilayah";
			this.colWilayah.Visible = true;
			this.colWilayah.VisibleIndex = 0;
			// 
			// colNoInvoice
			// 
			this.colNoInvoice.Caption = "No. Invoice";
			this.colNoInvoice.FieldName = "NoInvoice";
			this.colNoInvoice.Name = "colNoInvoice";
			this.colNoInvoice.Visible = true;
			this.colNoInvoice.VisibleIndex = 0;
			// 
			// colTanggal
			// 
			this.colTanggal.Caption = "Tanggal";
			this.colTanggal.DisplayFormat.FormatString = "dd MMM yyyy";
			this.colTanggal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
			this.colTanggal.FieldName = "TglInvoice";
			this.colTanggal.Name = "colTanggal";
			this.colTanggal.Visible = true;
			this.colTanggal.VisibleIndex = 1;
			// 
			// colSales
			// 
			this.colSales.Caption = "Sales";
			this.colSales.FieldName = "Sales";
			this.colSales.Name = "colSales";
			this.colSales.Visible = true;
			this.colSales.VisibleIndex = 2;
			// 
			// colPemasang
			// 
			this.colPemasang.Caption = "Pemasang";
			this.colPemasang.FieldName = "Pemasang";
			this.colPemasang.Name = "colPemasang";
			this.colPemasang.Visible = true;
			this.colPemasang.VisibleIndex = 3;
			// 
			// colMerk
			// 
			this.colMerk.Caption = "Merk";
			this.colMerk.FieldName = "Merk";
			this.colMerk.Name = "colMerk";
			this.colMerk.Visible = true;
			this.colMerk.VisibleIndex = 4;
			// 
			// colJudul
			// 
			this.colJudul.Caption = "Judul";
			this.colJudul.FieldName = "Judul";
			this.colJudul.Name = "colJudul";
			this.colJudul.Visible = true;
			this.colJudul.VisibleIndex = 5;
			// 
			// colTerbitTerakhir
			// 
			this.colTerbitTerakhir.Caption = "Terbit Terakhir";
			this.colTerbitTerakhir.DisplayFormat.FormatString = "dd MMM yyyy";
			this.colTerbitTerakhir.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
			this.colTerbitTerakhir.FieldName = "TerbitTerakhir";
			this.colTerbitTerakhir.Name = "colTerbitTerakhir";
			this.colTerbitTerakhir.Visible = true;
			this.colTerbitTerakhir.VisibleIndex = 6;
			// 
			// colSisaTerbit
			// 
			this.colSisaTerbit.AppearanceHeader.Options.UseTextOptions = true;
			this.colSisaTerbit.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
			this.colSisaTerbit.Caption = "Sisa Terbit";
			this.colSisaTerbit.DisplayFormat.FormatString = "n0";
			this.colSisaTerbit.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.colSisaTerbit.FieldName = "SisaTerbit";
			this.colSisaTerbit.Name = "colSisaTerbit";
			this.colSisaTerbit.Visible = true;
			this.colSisaTerbit.VisibleIndex = 7;
			// 
			// UI_WarningTerbit
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(894, 412);
			this.Name = "UI_WarningTerbit";
			this.Text = "Warning Terbit";
			this.xpCol = this.xpCol;
			((System.ComponentModel.ISupportInitialize)(this.barMan)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.xpCol)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.session)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.popMenu)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.xGrid)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.xGridView)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.SplitContainerControl1)).EndInit();
			this.SplitContainerControl1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.chartPopUp)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private DevExpress.XtraGrid.Columns.GridColumn colWilayah;
		private DevExpress.XtraGrid.Columns.GridColumn colNoInvoice;
		private DevExpress.XtraGrid.Columns.GridColumn colTanggal;
		private DevExpress.XtraGrid.Columns.GridColumn colSales;
		private DevExpress.XtraGrid.Columns.GridColumn colPemasang;
		private DevExpress.XtraGrid.Columns.GridColumn colMerk;
		private DevExpress.XtraGrid.Columns.GridColumn colJudul;
		private DevExpress.XtraGrid.Columns.GridColumn colTerbitTerakhir;
		private DevExpress.XtraGrid.Columns.GridColumn colSisaTerbit;
	}
}
