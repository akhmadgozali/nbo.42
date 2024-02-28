namespace NuSoft.NUI.Win.Forms.Modules.NuSoft012.UI.ReportFilter
{
	partial class UI_FilterJatuhTempo
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
			this.txtWilayah = new DevExpress.XtraEditors.CheckedComboBoxEdit();
			this.txtTanggal2 = new DevExpress.XtraEditors.DateEdit();
			this.txtTanggal1 = new DevExpress.XtraEditors.DateEdit();
			this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
			this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
			this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
			this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
			((System.ComponentModel.ISupportInitialize)(this._sesi)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
			this.layoutControl1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.txtWilayah.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtTanggal2.Properties.CalendarTimeProperties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtTanggal2.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtTanggal1.Properties.CalendarTimeProperties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtTanggal1.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
			this.SuspendLayout();
			// 
			// layoutControl1
			// 
			this.layoutControl1.Controls.Add(this.txtWilayah);
			this.layoutControl1.Controls.Add(this.txtTanggal2);
			this.layoutControl1.Controls.Add(this.txtTanggal1);
			this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.layoutControl1.Location = new System.Drawing.Point(0, 0);
			this.layoutControl1.Name = "layoutControl1";
			this.layoutControl1.Root = this.layoutControlGroup1;
			this.layoutControl1.Size = new System.Drawing.Size(471, 73);
			this.layoutControl1.TabIndex = 2;
			this.layoutControl1.Text = "layoutControl1";
			// 
			// txtWilayah
			// 
			this.txtWilayah.Location = new System.Drawing.Point(97, 36);
			this.txtWilayah.Name = "txtWilayah";
			this.txtWilayah.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.txtWilayah.Properties.DisplayMember = "Nama";
			this.txtWilayah.Properties.ValueMember = "This";
			this.txtWilayah.Size = new System.Drawing.Size(362, 20);
			this.txtWilayah.StyleController = this.layoutControl1;
			this.txtWilayah.TabIndex = 11;
			// 
			// txtTanggal2
			// 
			this.txtTanggal2.EditValue = null;
			this.txtTanggal2.EnterMoveNextControl = true;
			this.txtTanggal2.Location = new System.Drawing.Point(287, 12);
			this.txtTanggal2.Name = "txtTanggal2";
			this.txtTanggal2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.txtTanggal2.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.txtTanggal2.Properties.DisplayFormat.FormatString = "D";
			this.txtTanggal2.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
			this.txtTanggal2.Size = new System.Drawing.Size(172, 20);
			this.txtTanggal2.StyleController = this.layoutControl1;
			this.txtTanggal2.TabIndex = 9;
			// 
			// txtTanggal1
			// 
			this.txtTanggal1.EditValue = null;
			this.txtTanggal1.EnterMoveNextControl = true;
			this.txtTanggal1.Location = new System.Drawing.Point(97, 12);
			this.txtTanggal1.Name = "txtTanggal1";
			this.txtTanggal1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.txtTanggal1.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.txtTanggal1.Properties.DisplayFormat.FormatString = "D";
			this.txtTanggal1.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
			this.txtTanggal1.Size = new System.Drawing.Size(160, 20);
			this.txtTanggal1.StyleController = this.layoutControl1;
			this.txtTanggal1.TabIndex = 8;
			// 
			// layoutControlGroup1
			// 
			this.layoutControlGroup1.CustomizationFormText = "layoutControlGroup1";
			this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
			this.layoutControlGroup1.GroupBordersVisible = false;
			this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem5,
            this.layoutControlItem6,
            this.layoutControlItem2});
			this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
			this.layoutControlGroup1.Name = "layoutControlGroup1";
			this.layoutControlGroup1.Size = new System.Drawing.Size(471, 73);
			this.layoutControlGroup1.Text = "layoutControlGroup1";
			this.layoutControlGroup1.TextVisible = false;
			// 
			// layoutControlItem5
			// 
			this.layoutControlItem5.Control = this.txtTanggal1;
			this.layoutControlItem5.CustomizationFormText = "Tanggal";
			this.layoutControlItem5.Location = new System.Drawing.Point(0, 0);
			this.layoutControlItem5.Name = "layoutControlItem5";
			this.layoutControlItem5.Size = new System.Drawing.Size(249, 24);
			this.layoutControlItem5.Text = "Tgl Jatuh Tempo ";
			this.layoutControlItem5.TextSize = new System.Drawing.Size(82, 13);
			// 
			// layoutControlItem6
			// 
			this.layoutControlItem6.Control = this.txtTanggal2;
			this.layoutControlItem6.CustomizationFormText = " s/d ";
			this.layoutControlItem6.Location = new System.Drawing.Point(249, 0);
			this.layoutControlItem6.Name = "layoutControlItem6";
			this.layoutControlItem6.Size = new System.Drawing.Size(202, 24);
			this.layoutControlItem6.Text = " s/d ";
			this.layoutControlItem6.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize;
			this.layoutControlItem6.TextSize = new System.Drawing.Size(21, 13);
			this.layoutControlItem6.TextToControlDistance = 5;
			// 
			// layoutControlItem2
			// 
			this.layoutControlItem2.Control = this.txtWilayah;
			this.layoutControlItem2.CustomizationFormText = "Regional";
			this.layoutControlItem2.Location = new System.Drawing.Point(0, 24);
			this.layoutControlItem2.Name = "layoutControlItem2";
			this.layoutControlItem2.Size = new System.Drawing.Size(451, 29);
			this.layoutControlItem2.Text = "Wilayah     ";
			this.layoutControlItem2.TextSize = new System.Drawing.Size(82, 13);
			// 
			// UI_FilterJatuhTempo
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(471, 122);
			this.Controls.Add(this.layoutControl1);
			this.Name = "UI_FilterJatuhTempo";
			this.Text = "UI_FilterKwitansi";
			this.Controls.SetChildIndex(this.layoutControl1, 0);
			((System.ComponentModel.ISupportInitialize)(this._sesi)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
			this.layoutControl1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.txtWilayah.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtTanggal2.Properties.CalendarTimeProperties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtTanggal2.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtTanggal1.Properties.CalendarTimeProperties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtTanggal1.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private DevExpress.XtraLayout.LayoutControl layoutControl1;
		private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
		private DevExpress.XtraEditors.DateEdit txtTanggal2;
		private DevExpress.XtraEditors.DateEdit txtTanggal1;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
		private DevExpress.XtraEditors.CheckedComboBoxEdit txtWilayah;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
	}
}