﻿namespace NuSoft.NUI.Win.Forms.Modules.NuSoft011.UI.ReportFilter
{
	partial class UI_FilterAgenWilayah
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
			this.txtRute = new DevExpress.XtraEditors.CheckedComboBoxEdit();
			this.txtNamaAgen = new DevExpress.XtraEditors.TextEdit();
			this.txtKodeAgen2 = new DevExpress.XtraEditors.TextEdit();
			this.txtKodeAgen1 = new DevExpress.XtraEditors.TextEdit();
			this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
			this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
			this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
			this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
			this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
			((System.ComponentModel.ISupportInitialize)(this._sesi)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
			this.layoutControl1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.txtRute.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtNamaAgen.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtKodeAgen2.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtKodeAgen1.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
			this.SuspendLayout();
			// 
			// layoutControl1
			// 
			this.layoutControl1.Controls.Add(this.txtRute);
			this.layoutControl1.Controls.Add(this.txtNamaAgen);
			this.layoutControl1.Controls.Add(this.txtKodeAgen2);
			this.layoutControl1.Controls.Add(this.txtKodeAgen1);
			this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.layoutControl1.Location = new System.Drawing.Point(0, 0);
			this.layoutControl1.Name = "layoutControl1";
			this.layoutControl1.Root = this.layoutControlGroup1;
			this.layoutControl1.Size = new System.Drawing.Size(540, 103);
			this.layoutControl1.TabIndex = 2;
			this.layoutControl1.Text = "layoutControl1";
			// 
			// txtRute
			// 
			this.txtRute.EditValue = "";
			this.txtRute.EnterMoveNextControl = true;
			this.txtRute.Location = new System.Drawing.Point(76, 60);
			this.txtRute.Name = "txtRute";
			this.txtRute.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.txtRute.Properties.DisplayMember = "Nama";
			this.txtRute.Properties.SelectAllItemCaption = "(Pilih Semua)";
			this.txtRute.Properties.ValueMember = "This";
			this.txtRute.Size = new System.Drawing.Size(452, 20);
			this.txtRute.StyleController = this.layoutControl1;
			this.txtRute.TabIndex = 9;
			// 
			// txtNamaAgen
			// 
			this.txtNamaAgen.EnterMoveNextControl = true;
			this.txtNamaAgen.Location = new System.Drawing.Point(76, 36);
			this.txtNamaAgen.Name = "txtNamaAgen";
			this.txtNamaAgen.Size = new System.Drawing.Size(452, 20);
			this.txtNamaAgen.StyleController = this.layoutControl1;
			this.txtNamaAgen.TabIndex = 8;
			// 
			// txtKodeAgen2
			// 
			this.txtKodeAgen2.EnterMoveNextControl = true;
			this.txtKodeAgen2.Location = new System.Drawing.Point(304, 12);
			this.txtKodeAgen2.Name = "txtKodeAgen2";
			this.txtKodeAgen2.Size = new System.Drawing.Size(224, 20);
			this.txtKodeAgen2.StyleController = this.layoutControl1;
			this.txtKodeAgen2.TabIndex = 7;
			// 
			// txtKodeAgen1
			// 
			this.txtKodeAgen1.EnterMoveNextControl = true;
			this.txtKodeAgen1.Location = new System.Drawing.Point(76, 12);
			this.txtKodeAgen1.Name = "txtKodeAgen1";
			this.txtKodeAgen1.Size = new System.Drawing.Size(192, 20);
			this.txtKodeAgen1.StyleController = this.layoutControl1;
			this.txtKodeAgen1.TabIndex = 6;
			// 
			// layoutControlGroup1
			// 
			this.layoutControlGroup1.CustomizationFormText = "layoutControlGroup1";
			this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
			this.layoutControlGroup1.GroupBordersVisible = false;
			this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.layoutControlItem5,
            this.layoutControlItem6});
			this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
			this.layoutControlGroup1.Name = "layoutControlGroup1";
			this.layoutControlGroup1.Size = new System.Drawing.Size(540, 103);
			this.layoutControlGroup1.Text = "layoutControlGroup1";
			this.layoutControlGroup1.TextVisible = false;
			// 
			// layoutControlItem3
			// 
			this.layoutControlItem3.Control = this.txtKodeAgen1;
			this.layoutControlItem3.CustomizationFormText = "Kode Agen";
			this.layoutControlItem3.Location = new System.Drawing.Point(0, 0);
			this.layoutControlItem3.Name = "layoutControlItem3";
			this.layoutControlItem3.Size = new System.Drawing.Size(260, 24);
			this.layoutControlItem3.Text = "Kode Agen";
			this.layoutControlItem3.TextSize = new System.Drawing.Size(61, 13);
			// 
			// layoutControlItem4
			// 
			this.layoutControlItem4.Control = this.txtKodeAgen2;
			this.layoutControlItem4.CustomizationFormText = "  s/d  ";
			this.layoutControlItem4.Location = new System.Drawing.Point(260, 0);
			this.layoutControlItem4.Name = "layoutControlItem4";
			this.layoutControlItem4.Size = new System.Drawing.Size(260, 24);
			this.layoutControlItem4.Text = "  s/d  ";
			this.layoutControlItem4.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize;
			this.layoutControlItem4.TextSize = new System.Drawing.Size(27, 13);
			this.layoutControlItem4.TextToControlDistance = 5;
			// 
			// layoutControlItem5
			// 
			this.layoutControlItem5.Control = this.txtNamaAgen;
			this.layoutControlItem5.CustomizationFormText = "Nama Agen  ";
			this.layoutControlItem5.Location = new System.Drawing.Point(0, 24);
			this.layoutControlItem5.Name = "layoutControlItem5";
			this.layoutControlItem5.Size = new System.Drawing.Size(520, 24);
			this.layoutControlItem5.Text = "Nama Agen  ";
			this.layoutControlItem5.TextSize = new System.Drawing.Size(61, 13);
			// 
			// layoutControlItem6
			// 
			this.layoutControlItem6.Control = this.txtRute;
			this.layoutControlItem6.CustomizationFormText = "Rute";
			this.layoutControlItem6.Location = new System.Drawing.Point(0, 48);
			this.layoutControlItem6.Name = "layoutControlItem6";
			this.layoutControlItem6.Size = new System.Drawing.Size(520, 35);
			this.layoutControlItem6.Text = "Rute";
			this.layoutControlItem6.TextSize = new System.Drawing.Size(61, 13);
			// 
			// UI_FilterAgenWilayah
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(540, 152);
			this.Controls.Add(this.layoutControl1);
			this.Name = "UI_FilterAgenWilayah";
			this.Text = "UI_FilterTanggalAgenWilayah";
			this.Controls.SetChildIndex(this.layoutControl1, 0);
			((System.ComponentModel.ISupportInitialize)(this._sesi)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
			this.layoutControl1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.txtRute.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtNamaAgen.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtKodeAgen2.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtKodeAgen1.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private DevExpress.XtraLayout.LayoutControl layoutControl1;
		private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
		private DevExpress.XtraEditors.CheckedComboBoxEdit txtRute;
		private DevExpress.XtraEditors.TextEdit txtNamaAgen;
		private DevExpress.XtraEditors.TextEdit txtKodeAgen2;
		private DevExpress.XtraEditors.TextEdit txtKodeAgen1;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
	}
}