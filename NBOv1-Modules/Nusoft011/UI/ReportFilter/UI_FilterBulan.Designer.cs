﻿namespace NuSoft.NUI.Win.Forms.Modules.NuSoft011.UI.ReportFilter
{
	partial class UI_FilterBulan
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
			this.txtCek = new DevExpress.XtraEditors.CheckEdit();
			this.txtTahun = new DevExpress.XtraEditors.SpinEdit();
			this.txtBulan = new DevExpress.XtraEditors.ComboBoxEdit();
			this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
			this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
			this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
			this.layCek = new DevExpress.XtraLayout.LayoutControlItem();
			this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
			((System.ComponentModel.ISupportInitialize)(this._sesi)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
			this.layoutControl1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.txtCek.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtTahun.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtBulan.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layCek)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
			this.SuspendLayout();
			// 
			// layoutControl1
			// 
			this.layoutControl1.Controls.Add(this.txtCek);
			this.layoutControl1.Controls.Add(this.txtTahun);
			this.layoutControl1.Controls.Add(this.txtBulan);
			this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.layoutControl1.Location = new System.Drawing.Point(0, 0);
			this.layoutControl1.Name = "layoutControl1";
			this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(393, 1, 650, 400);
			this.layoutControl1.Root = this.layoutControlGroup1;
			this.layoutControl1.Size = new System.Drawing.Size(341, 68);
			this.layoutControl1.TabIndex = 2;
			this.layoutControl1.Text = "layoutControl1";
			// 
			// txtCek
			// 
			this.txtCek.Location = new System.Drawing.Point(64, 36);
			this.txtCek.Name = "txtCek";
			this.txtCek.Properties.Caption = "Akumulasi";
			this.txtCek.Size = new System.Drawing.Size(265, 19);
			this.txtCek.StyleController = this.layoutControl1;
			this.txtCek.TabIndex = 6;
			// 
			// txtTahun
			// 
			this.txtTahun.EditValue = new decimal(new int[] {
            2000,
            0,
            0,
            0});
			this.txtTahun.EnterMoveNextControl = true;
			this.txtTahun.Location = new System.Drawing.Point(257, 12);
			this.txtTahun.Name = "txtTahun";
			this.txtTahun.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.txtTahun.Properties.MaxValue = new decimal(new int[] {
            2000,
            0,
            0,
            0});
			this.txtTahun.Properties.MinValue = new decimal(new int[] {
            2000,
            0,
            0,
            0});
			this.txtTahun.Size = new System.Drawing.Size(72, 20);
			this.txtTahun.StyleController = this.layoutControl1;
			this.txtTahun.TabIndex = 5;
			// 
			// txtBulan
			// 
			this.txtBulan.EnterMoveNextControl = true;
			this.txtBulan.Location = new System.Drawing.Point(60, 12);
			this.txtBulan.Name = "txtBulan";
			this.txtBulan.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.txtBulan.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
			this.txtBulan.Size = new System.Drawing.Size(193, 20);
			this.txtBulan.StyleController = this.layoutControl1;
			this.txtBulan.TabIndex = 4;
			// 
			// layoutControlGroup1
			// 
			this.layoutControlGroup1.CustomizationFormText = "Root";
			this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
			this.layoutControlGroup1.GroupBordersVisible = false;
			this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layCek,
            this.emptySpaceItem1});
			this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
			this.layoutControlGroup1.Name = "Root";
			this.layoutControlGroup1.Size = new System.Drawing.Size(341, 68);
			this.layoutControlGroup1.Text = "Root";
			this.layoutControlGroup1.TextVisible = false;
			// 
			// layoutControlItem1
			// 
			this.layoutControlItem1.Control = this.txtBulan;
			this.layoutControlItem1.CustomizationFormText = "Periode   ";
			this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
			this.layoutControlItem1.Name = "layoutControlItem1";
			this.layoutControlItem1.Size = new System.Drawing.Size(245, 24);
			this.layoutControlItem1.Text = "Periode   ";
			this.layoutControlItem1.TextSize = new System.Drawing.Size(45, 13);
			// 
			// layoutControlItem2
			// 
			this.layoutControlItem2.Control = this.txtTahun;
			this.layoutControlItem2.CustomizationFormText = " Tahun  ";
			this.layoutControlItem2.Location = new System.Drawing.Point(245, 0);
			this.layoutControlItem2.Name = "layoutControlItem2";
			this.layoutControlItem2.Size = new System.Drawing.Size(76, 24);
			this.layoutControlItem2.Text = " Tahun  ";
			this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
			this.layoutControlItem2.TextToControlDistance = 0;
			this.layoutControlItem2.TextVisible = false;
			// 
			// layCek
			// 
			this.layCek.Control = this.txtCek;
			this.layCek.CustomizationFormText = "layCek";
			this.layCek.Location = new System.Drawing.Point(52, 24);
			this.layCek.Name = "layCek";
			this.layCek.Size = new System.Drawing.Size(269, 24);
			this.layCek.Text = "layCek";
			this.layCek.TextSize = new System.Drawing.Size(0, 0);
			this.layCek.TextToControlDistance = 0;
			this.layCek.TextVisible = false;
			// 
			// emptySpaceItem1
			// 
			this.emptySpaceItem1.AllowHotTrack = false;
			this.emptySpaceItem1.CustomizationFormText = "emptySpaceItem1";
			this.emptySpaceItem1.Location = new System.Drawing.Point(0, 24);
			this.emptySpaceItem1.Name = "emptySpaceItem1";
			this.emptySpaceItem1.Size = new System.Drawing.Size(52, 24);
			this.emptySpaceItem1.Text = "emptySpaceItem1";
			this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
			// 
			// UI_FilterBulan
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(341, 117);
			this.Controls.Add(this.layoutControl1);
			this.Name = "UI_FilterBulan";
			this.Text = "UI_FilterBulan";
			this.Controls.SetChildIndex(this.layoutControl1, 0);
			((System.ComponentModel.ISupportInitialize)(this._sesi)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
			this.layoutControl1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.txtCek.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtTahun.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtBulan.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layCek)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private DevExpress.XtraLayout.LayoutControl layoutControl1;
		private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
		private DevExpress.XtraEditors.SpinEdit txtTahun;
		private DevExpress.XtraEditors.ComboBoxEdit txtBulan;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
		private DevExpress.XtraEditors.CheckEdit txtCek;
		private DevExpress.XtraLayout.LayoutControlItem layCek;
		private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
	}
}