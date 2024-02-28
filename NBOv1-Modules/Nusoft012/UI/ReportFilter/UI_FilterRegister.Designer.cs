namespace NuSoft.NUI.Win.Forms.Modules.NuSoft012.UI.ReportFilter
{
	partial class UI_FilterRegister
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
			this.txtJenisIklan = new DevExpress.XtraEditors.CheckedComboBoxEdit();
			this.txtWilayah = new DevExpress.XtraEditors.CheckedComboBoxEdit();
			this.txtTanggal1 = new DevExpress.XtraEditors.DateEdit();
			this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
			this.layTanggal = new DevExpress.XtraLayout.LayoutControlItem();
			this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
			this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
			this.txtProduk = new DevExpress.XtraEditors.TextEdit();
			this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
			this.txtMerk = new DevExpress.XtraEditors.TextEdit();
			this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
			((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
			this.layoutControl1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.txtJenisIklan.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtWilayah.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtTanggal1.Properties.CalendarTimeProperties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtTanggal1.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layTanggal)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtProduk.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtMerk.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
			this.SuspendLayout();
			// 
			// layoutControl1
			// 
			this.layoutControl1.Controls.Add(this.txtMerk);
			this.layoutControl1.Controls.Add(this.txtProduk);
			this.layoutControl1.Controls.Add(this.txtJenisIklan);
			this.layoutControl1.Controls.Add(this.txtWilayah);
			this.layoutControl1.Controls.Add(this.txtTanggal1);
			this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.layoutControl1.Location = new System.Drawing.Point(0, 27);
			this.layoutControl1.Name = "layoutControl1";
			this.layoutControl1.Root = this.layoutControlGroup1;
			this.layoutControl1.Size = new System.Drawing.Size(345, 143);
			this.layoutControl1.TabIndex = 2;
			this.layoutControl1.Text = "layoutControl1";
			// 
			// txtJenisIklan
			// 
			this.txtJenisIklan.Location = new System.Drawing.Point(90, 60);
			this.txtJenisIklan.Name = "txtJenisIklan";
			this.txtJenisIklan.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.txtJenisIklan.Properties.DisplayMember = "Nama";
			this.txtJenisIklan.Properties.ValueMember = "This";
			this.txtJenisIklan.Size = new System.Drawing.Size(243, 20);
			this.txtJenisIklan.StyleController = this.layoutControl1;
			this.txtJenisIklan.TabIndex = 11;
			// 
			// txtWilayah
			// 
			this.txtWilayah.Location = new System.Drawing.Point(90, 36);
			this.txtWilayah.Name = "txtWilayah";
			this.txtWilayah.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.txtWilayah.Properties.DisplayMember = "Nama";
			this.txtWilayah.Properties.ValueMember = "This";
			this.txtWilayah.Size = new System.Drawing.Size(243, 20);
			this.txtWilayah.StyleController = this.layoutControl1;
			this.txtWilayah.TabIndex = 10;
			// 
			// txtTanggal1
			// 
			this.txtTanggal1.EditValue = null;
			this.txtTanggal1.EnterMoveNextControl = true;
			this.txtTanggal1.Location = new System.Drawing.Point(90, 12);
			this.txtTanggal1.Name = "txtTanggal1";
			this.txtTanggal1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.txtTanggal1.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.txtTanggal1.Properties.DisplayFormat.FormatString = "D";
			this.txtTanggal1.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
			this.txtTanggal1.Size = new System.Drawing.Size(243, 20);
			this.txtTanggal1.StyleController = this.layoutControl1;
			this.txtTanggal1.TabIndex = 8;
			// 
			// layoutControlGroup1
			// 
			this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
			this.layoutControlGroup1.GroupBordersVisible = false;
			this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layTanggal,
            this.layoutControlItem1,
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.layoutControlItem2});
			this.layoutControlGroup1.Name = "layoutControlGroup1";
			this.layoutControlGroup1.Size = new System.Drawing.Size(345, 143);
			this.layoutControlGroup1.TextVisible = false;
			// 
			// layTanggal
			// 
			this.layTanggal.Control = this.txtTanggal1;
			this.layTanggal.Location = new System.Drawing.Point(0, 0);
			this.layTanggal.Name = "layTanggal";
			this.layTanggal.Size = new System.Drawing.Size(325, 24);
			this.layTanggal.Text = "Tanggal Terbit  ";
			this.layTanggal.TextSize = new System.Drawing.Size(75, 13);
			// 
			// layoutControlItem1
			// 
			this.layoutControlItem1.Control = this.txtWilayah;
			this.layoutControlItem1.Location = new System.Drawing.Point(0, 24);
			this.layoutControlItem1.Name = "layoutControlItem1";
			this.layoutControlItem1.Size = new System.Drawing.Size(325, 24);
			this.layoutControlItem1.Text = "Wilayah";
			this.layoutControlItem1.TextSize = new System.Drawing.Size(75, 13);
			// 
			// layoutControlItem2
			// 
			this.layoutControlItem2.Control = this.txtJenisIklan;
			this.layoutControlItem2.Location = new System.Drawing.Point(0, 48);
			this.layoutControlItem2.Name = "layoutControlItem2";
			this.layoutControlItem2.Size = new System.Drawing.Size(325, 24);
			this.layoutControlItem2.Text = "Jenis Iklan";
			this.layoutControlItem2.TextSize = new System.Drawing.Size(75, 13);
			// 
			// txtProduk
			// 
			this.txtProduk.EnterMoveNextControl = true;
			this.txtProduk.Location = new System.Drawing.Point(90, 84);
			this.txtProduk.Name = "txtProduk";
			this.txtProduk.Size = new System.Drawing.Size(243, 20);
			this.txtProduk.StyleController = this.layoutControl1;
			this.txtProduk.TabIndex = 12;
			// 
			// layoutControlItem3
			// 
			this.layoutControlItem3.Control = this.txtProduk;
			this.layoutControlItem3.Location = new System.Drawing.Point(0, 72);
			this.layoutControlItem3.Name = "layoutControlItem3";
			this.layoutControlItem3.Size = new System.Drawing.Size(325, 24);
			this.layoutControlItem3.Text = "Produk";
			this.layoutControlItem3.TextSize = new System.Drawing.Size(75, 13);
			// 
			// txtMerk
			// 
			this.txtMerk.EnterMoveNextControl = true;
			this.txtMerk.Location = new System.Drawing.Point(90, 108);
			this.txtMerk.Name = "txtMerk";
			this.txtMerk.Size = new System.Drawing.Size(243, 20);
			this.txtMerk.StyleController = this.layoutControl1;
			this.txtMerk.TabIndex = 13;
			// 
			// layoutControlItem4
			// 
			this.layoutControlItem4.Control = this.txtMerk;
			this.layoutControlItem4.Location = new System.Drawing.Point(0, 96);
			this.layoutControlItem4.Name = "layoutControlItem4";
			this.layoutControlItem4.Size = new System.Drawing.Size(325, 27);
			this.layoutControlItem4.Text = "Merk";
			this.layoutControlItem4.TextSize = new System.Drawing.Size(75, 13);
			// 
			// UI_FilterRegister
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(345, 201);
			this.Controls.Add(this.layoutControl1);
			this.Name = "UI_FilterRegister";
			this.Text = "UI_FilterKwitansi";
			this.Controls.SetChildIndex(this.layoutControl1, 0);
			((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
			this.layoutControl1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.txtJenisIklan.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtWilayah.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtTanggal1.Properties.CalendarTimeProperties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtTanggal1.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layTanggal)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtProduk.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtMerk.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private DevExpress.XtraLayout.LayoutControl layoutControl1;
		private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
		private DevExpress.XtraEditors.DateEdit txtTanggal1;
		private DevExpress.XtraLayout.LayoutControlItem layTanggal;
		private DevExpress.XtraEditors.CheckedComboBoxEdit txtJenisIklan;
		private DevExpress.XtraEditors.CheckedComboBoxEdit txtWilayah;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
		private DevExpress.XtraEditors.TextEdit txtMerk;
		private DevExpress.XtraEditors.TextEdit txtProduk;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
	}
}