namespace NuSoft.NUI.Win.Forms.Modules.NuSoft009.UILayer.Transaksi
{
	partial class UI_SuratPeringatanDialog
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
			this.txtKeterangan = new DevExpress.XtraEditors.MemoEdit();
			this.txtJenis = new DevExpress.XtraEditors.LookUpEdit();
			this.txtKaryawan = new DevExpress.XtraEditors.SearchLookUpEdit();
			this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.txtNoBukti = new DevExpress.XtraEditors.TextEdit();
			this.txtTanggal = new DevExpress.XtraEditors.DateEdit();
			this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
			this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
			this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
			this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
			this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
			this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
			this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.txtExpired = new DevExpress.XtraEditors.DateEdit();
			this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
			((System.ComponentModel.ISupportInitialize)(this.session)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
			this.layoutControl1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.txtKeterangan.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtJenis.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtKaryawan.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtNoBukti.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtTanggal.Properties.CalendarTimeProperties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtTanggal.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtExpired.Properties.CalendarTimeProperties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtExpired.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
			this.SuspendLayout();
			// 
			// layoutControl1
			// 
			this.layoutControl1.Controls.Add(this.txtExpired);
			this.layoutControl1.Controls.Add(this.txtKeterangan);
			this.layoutControl1.Controls.Add(this.txtJenis);
			this.layoutControl1.Controls.Add(this.txtKaryawan);
			this.layoutControl1.Controls.Add(this.txtNoBukti);
			this.layoutControl1.Controls.Add(this.txtTanggal);
			this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.layoutControl1.Location = new System.Drawing.Point(0, 0);
			this.layoutControl1.Name = "layoutControl1";
			this.layoutControl1.Root = this.layoutControlGroup1;
			this.layoutControl1.Size = new System.Drawing.Size(419, 424);
			this.layoutControl1.TabIndex = 100;
			this.layoutControl1.Text = "layoutControl1";
			// 
			// txtKeterangan
			// 
			this.txtKeterangan.Location = new System.Drawing.Point(12, 148);
			this.txtKeterangan.Name = "txtKeterangan";
			this.txtKeterangan.Size = new System.Drawing.Size(395, 264);
			this.txtKeterangan.StyleController = this.layoutControl1;
			this.txtKeterangan.TabIndex = 8;
			// 
			// txtJenis
			// 
			this.txtJenis.Location = new System.Drawing.Point(71, 84);
			this.txtJenis.Name = "txtJenis";
			this.txtJenis.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.txtJenis.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Value", "Nama")});
			this.txtJenis.Properties.DisplayMember = "Value";
			this.txtJenis.Properties.NullText = "<Pilih Jenis SP>";
			this.txtJenis.Properties.ValueMember = "Key";
			this.txtJenis.Size = new System.Drawing.Size(336, 20);
			this.txtJenis.StyleController = this.layoutControl1;
			this.txtJenis.TabIndex = 7;
			// 
			// txtKaryawan
			// 
			this.txtKaryawan.Location = new System.Drawing.Point(71, 60);
			this.txtKaryawan.Name = "txtKaryawan";
			this.txtKaryawan.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.txtKaryawan.Properties.DisplayMember = "Nama";
			this.txtKaryawan.Properties.NullText = "<Pilih Karyawan>";
			this.txtKaryawan.Properties.ValueMember = "This";
			this.txtKaryawan.Properties.View = this.searchLookUpEdit1View;
			this.txtKaryawan.Size = new System.Drawing.Size(336, 20);
			this.txtKaryawan.StyleController = this.layoutControl1;
			this.txtKaryawan.TabIndex = 6;
			// 
			// searchLookUpEdit1View
			// 
			this.searchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3});
			this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
			this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
			this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
			this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
			// 
			// txtNoBukti
			// 
			this.txtNoBukti.Location = new System.Drawing.Point(71, 36);
			this.txtNoBukti.Name = "txtNoBukti";
			this.txtNoBukti.Size = new System.Drawing.Size(336, 20);
			this.txtNoBukti.StyleController = this.layoutControl1;
			this.txtNoBukti.TabIndex = 5;
			// 
			// txtTanggal
			// 
			this.txtTanggal.EditValue = null;
			this.txtTanggal.Location = new System.Drawing.Point(71, 12);
			this.txtTanggal.Name = "txtTanggal";
			this.txtTanggal.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.txtTanggal.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.txtTanggal.Size = new System.Drawing.Size(336, 20);
			this.txtTanggal.StyleController = this.layoutControl1;
			this.txtTanggal.TabIndex = 4;
			// 
			// layoutControlGroup1
			// 
			this.layoutControlGroup1.CustomizationFormText = "layoutControlGroup1";
			this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
			this.layoutControlGroup1.GroupBordersVisible = false;
			this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.layoutControlItem5,
            this.layoutControlItem6});
			this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
			this.layoutControlGroup1.Name = "layoutControlGroup1";
			this.layoutControlGroup1.Size = new System.Drawing.Size(419, 424);
			this.layoutControlGroup1.Text = "layoutControlGroup1";
			this.layoutControlGroup1.TextVisible = false;
			// 
			// layoutControlItem1
			// 
			this.layoutControlItem1.Control = this.txtTanggal;
			this.layoutControlItem1.CustomizationFormText = "Tanggal";
			this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
			this.layoutControlItem1.Name = "layoutControlItem1";
			this.layoutControlItem1.Size = new System.Drawing.Size(399, 24);
			this.layoutControlItem1.Text = "Tanggal";
			this.layoutControlItem1.TextSize = new System.Drawing.Size(56, 13);
			// 
			// layoutControlItem2
			// 
			this.layoutControlItem2.Control = this.txtNoBukti;
			this.layoutControlItem2.CustomizationFormText = "No Bukti";
			this.layoutControlItem2.Location = new System.Drawing.Point(0, 24);
			this.layoutControlItem2.Name = "layoutControlItem2";
			this.layoutControlItem2.Size = new System.Drawing.Size(399, 24);
			this.layoutControlItem2.Text = "No Bukti";
			this.layoutControlItem2.TextSize = new System.Drawing.Size(56, 13);
			// 
			// layoutControlItem3
			// 
			this.layoutControlItem3.Control = this.txtKaryawan;
			this.layoutControlItem3.CustomizationFormText = "Karyawan";
			this.layoutControlItem3.Location = new System.Drawing.Point(0, 48);
			this.layoutControlItem3.Name = "layoutControlItem3";
			this.layoutControlItem3.Size = new System.Drawing.Size(399, 24);
			this.layoutControlItem3.Text = "Karyawan";
			this.layoutControlItem3.TextSize = new System.Drawing.Size(56, 13);
			// 
			// layoutControlItem4
			// 
			this.layoutControlItem4.Control = this.txtJenis;
			this.layoutControlItem4.CustomizationFormText = "Jenis";
			this.layoutControlItem4.Location = new System.Drawing.Point(0, 72);
			this.layoutControlItem4.Name = "layoutControlItem4";
			this.layoutControlItem4.Size = new System.Drawing.Size(399, 24);
			this.layoutControlItem4.Text = "Jenis";
			this.layoutControlItem4.TextSize = new System.Drawing.Size(56, 13);
			// 
			// layoutControlItem5
			// 
			this.layoutControlItem5.Control = this.txtKeterangan;
			this.layoutControlItem5.CustomizationFormText = "Keterangan";
			this.layoutControlItem5.Location = new System.Drawing.Point(0, 120);
			this.layoutControlItem5.Name = "layoutControlItem5";
			this.layoutControlItem5.Size = new System.Drawing.Size(399, 284);
			this.layoutControlItem5.Text = "Keterangan";
			this.layoutControlItem5.TextLocation = DevExpress.Utils.Locations.Top;
			this.layoutControlItem5.TextSize = new System.Drawing.Size(56, 13);
			// 
			// gridColumn1
			// 
			this.gridColumn1.Caption = "Kode";
			this.gridColumn1.FieldName = "Kode";
			this.gridColumn1.Name = "gridColumn1";
			this.gridColumn1.Visible = true;
			this.gridColumn1.VisibleIndex = 0;
			// 
			// gridColumn2
			// 
			this.gridColumn2.Caption = "Nama";
			this.gridColumn2.FieldName = "Nama";
			this.gridColumn2.Name = "gridColumn2";
			this.gridColumn2.Visible = true;
			this.gridColumn2.VisibleIndex = 1;
			// 
			// gridColumn3
			// 
			this.gridColumn3.Caption = "Divisi";
			this.gridColumn3.FieldName = "Divisi.Nama";
			this.gridColumn3.Name = "gridColumn3";
			this.gridColumn3.Visible = true;
			this.gridColumn3.VisibleIndex = 2;
			// 
			// txtExpired
			// 
			this.txtExpired.EditValue = null;
			this.txtExpired.Location = new System.Drawing.Point(71, 108);
			this.txtExpired.Name = "txtExpired";
			this.txtExpired.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.txtExpired.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.txtExpired.Size = new System.Drawing.Size(336, 20);
			this.txtExpired.StyleController = this.layoutControl1;
			this.txtExpired.TabIndex = 9;
			// 
			// layoutControlItem6
			// 
			this.layoutControlItem6.Control = this.txtExpired;
			this.layoutControlItem6.CustomizationFormText = "Expired";
			this.layoutControlItem6.Location = new System.Drawing.Point(0, 96);
			this.layoutControlItem6.Name = "layoutControlItem6";
			this.layoutControlItem6.Size = new System.Drawing.Size(399, 24);
			this.layoutControlItem6.Text = "Expired";
			this.layoutControlItem6.TextSize = new System.Drawing.Size(56, 13);
			// 
			// UI_SuratPeringatanDialog
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(419, 473);
			this.Controls.Add(this.layoutControl1);
			this.Name = "UI_SuratPeringatanDialog";
			this.Text = "Surat Peringatan";
			this.Controls.SetChildIndex(this.layoutControl1, 0);
			((System.ComponentModel.ISupportInitialize)(this.session)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
			this.layoutControl1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.txtKeterangan.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtJenis.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtKaryawan.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtNoBukti.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtTanggal.Properties.CalendarTimeProperties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtTanggal.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtExpired.Properties.CalendarTimeProperties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtExpired.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private DevExpress.XtraLayout.LayoutControl layoutControl1;
		private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
		private DevExpress.XtraEditors.MemoEdit txtKeterangan;
		private DevExpress.XtraEditors.LookUpEdit txtJenis;
		private DevExpress.XtraEditors.SearchLookUpEdit txtKaryawan;
		private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
		private DevExpress.XtraEditors.TextEdit txtNoBukti;
		private DevExpress.XtraEditors.DateEdit txtTanggal;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
		private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
		private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
		private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
		private DevExpress.XtraEditors.DateEdit txtExpired;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
	}
}