namespace NuSoft.NUI.Win.Forms.Modules.NuSoft012.UI.ReportFilter
{
	partial class UI_FilterKonfirmasiPiutang
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
			this.components = new System.ComponentModel.Container();
			this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
			this.txtStatus = new DevExpress.XtraEditors.RadioGroup();
			this.txtTampilkan = new DevExpress.XtraEditors.RadioGroup();
			this.txtNama = new DevExpress.XtraEditors.TextEdit();
			this.txtWilayah = new DevExpress.XtraEditors.TextEdit();
			this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
			this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
			this.layoutControlItem8 = new DevExpress.XtraLayout.LayoutControlItem();
			this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
			this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
			this.txtPerTanggal = new DevExpress.XtraEditors.DateEdit();
			this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
			((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
			this.layoutControl1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.txtStatus.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtTampilkan.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtNama.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtWilayah.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtPerTanggal.Properties.CalendarTimeProperties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtPerTanggal.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
			this.SuspendLayout();
			// 
			// layoutControl1
			// 
			this.layoutControl1.Controls.Add(this.txtPerTanggal);
			this.layoutControl1.Controls.Add(this.txtStatus);
			this.layoutControl1.Controls.Add(this.txtTampilkan);
			this.layoutControl1.Controls.Add(this.txtNama);
			this.layoutControl1.Controls.Add(this.txtWilayah);
			this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.layoutControl1.Location = new System.Drawing.Point(0, 27);
			this.layoutControl1.Name = "layoutControl1";
			this.layoutControl1.Root = this.layoutControlGroup1;
			this.layoutControl1.Size = new System.Drawing.Size(374, 150);
			this.layoutControl1.TabIndex = 2;
			this.layoutControl1.Text = "layoutControl1";
			// 
			// txtStatus
			// 
			this.txtStatus.Location = new System.Drawing.Point(81, 84);
			this.txtStatus.Name = "txtStatus";
			this.txtStatus.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(0, "<Semua>"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(1, "Lunas"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(2, "Belum Lunas")});
			this.txtStatus.Size = new System.Drawing.Size(281, 25);
			this.txtStatus.StyleController = this.layoutControl1;
			this.txtStatus.TabIndex = 15;
			// 
			// txtTampilkan
			// 
			this.txtTampilkan.Location = new System.Drawing.Point(81, 113);
			this.txtTampilkan.Name = "txtTampilkan";
			this.txtTampilkan.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(1, "Pemasang"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(2, "Sales")});
			this.txtTampilkan.Size = new System.Drawing.Size(281, 25);
			this.txtTampilkan.StyleController = this.layoutControl1;
			this.txtTampilkan.TabIndex = 14;
			// 
			// txtNama
			// 
			this.txtNama.EnterMoveNextControl = true;
			this.txtNama.Location = new System.Drawing.Point(81, 36);
			this.txtNama.Name = "txtNama";
			this.txtNama.Size = new System.Drawing.Size(281, 20);
			this.txtNama.StyleController = this.layoutControl1;
			this.txtNama.TabIndex = 11;
			// 
			// txtWilayah
			// 
			this.txtWilayah.EnterMoveNextControl = true;
			this.txtWilayah.Location = new System.Drawing.Point(81, 60);
			this.txtWilayah.Name = "txtWilayah";
			this.txtWilayah.Size = new System.Drawing.Size(281, 20);
			this.txtWilayah.StyleController = this.layoutControl1;
			this.txtWilayah.TabIndex = 10;
			// 
			// layoutControlGroup1
			// 
			this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
			this.layoutControlGroup1.GroupBordersVisible = false;
			this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem7,
            this.layoutControlItem8,
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem3});
			this.layoutControlGroup1.Name = "layoutControlGroup1";
			this.layoutControlGroup1.Size = new System.Drawing.Size(374, 150);
			this.layoutControlGroup1.TextVisible = false;
			// 
			// layoutControlItem7
			// 
			this.layoutControlItem7.Control = this.txtWilayah;
			this.layoutControlItem7.Location = new System.Drawing.Point(0, 48);
			this.layoutControlItem7.Name = "layoutControlItem7";
			this.layoutControlItem7.Size = new System.Drawing.Size(354, 24);
			this.layoutControlItem7.Text = "Wilayah";
			this.layoutControlItem7.TextSize = new System.Drawing.Size(66, 13);
			// 
			// layoutControlItem8
			// 
			this.layoutControlItem8.Control = this.txtNama;
			this.layoutControlItem8.Location = new System.Drawing.Point(0, 24);
			this.layoutControlItem8.Name = "layoutControlItem8";
			this.layoutControlItem8.Size = new System.Drawing.Size(354, 24);
			this.layoutControlItem8.Text = "Nama";
			this.layoutControlItem8.TextSize = new System.Drawing.Size(66, 13);
			// 
			// layoutControlItem1
			// 
			this.layoutControlItem1.Control = this.txtTampilkan;
			this.layoutControlItem1.Location = new System.Drawing.Point(0, 101);
			this.layoutControlItem1.Name = "layoutControlItem1";
			this.layoutControlItem1.Size = new System.Drawing.Size(354, 29);
			this.layoutControlItem1.Text = "Tampilkan     ";
			this.layoutControlItem1.TextSize = new System.Drawing.Size(66, 13);
			// 
			// layoutControlItem2
			// 
			this.layoutControlItem2.Control = this.txtStatus;
			this.layoutControlItem2.Location = new System.Drawing.Point(0, 72);
			this.layoutControlItem2.Name = "layoutControlItem2";
			this.layoutControlItem2.Size = new System.Drawing.Size(354, 29);
			this.layoutControlItem2.Text = "Status";
			this.layoutControlItem2.TextSize = new System.Drawing.Size(66, 13);
			// 
			// txtPerTanggal
			// 
			this.txtPerTanggal.EditValue = null;
			this.txtPerTanggal.Location = new System.Drawing.Point(81, 12);
			this.txtPerTanggal.Name = "txtPerTanggal";
			this.txtPerTanggal.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.txtPerTanggal.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.txtPerTanggal.Properties.DisplayFormat.FormatString = "D";
			this.txtPerTanggal.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
			this.txtPerTanggal.Size = new System.Drawing.Size(281, 20);
			this.txtPerTanggal.StyleController = this.layoutControl1;
			this.txtPerTanggal.TabIndex = 16;
			// 
			// layoutControlItem3
			// 
			this.layoutControlItem3.Control = this.txtPerTanggal;
			this.layoutControlItem3.Location = new System.Drawing.Point(0, 0);
			this.layoutControlItem3.Name = "layoutControlItem3";
			this.layoutControlItem3.Size = new System.Drawing.Size(354, 24);
			this.layoutControlItem3.Text = "Per Tanggal   ";
			this.layoutControlItem3.TextSize = new System.Drawing.Size(66, 13);
			// 
			// UI_FilterKonfirmasiPiutang
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(374, 208);
			this.Controls.Add(this.layoutControl1);
			this.Name = "UI_FilterKonfirmasiPiutang";
			this.Text = "UI_FilterInvoice";
			this.Controls.SetChildIndex(this.layoutControl1, 0);
			((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
			this.layoutControl1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.txtStatus.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtTampilkan.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtNama.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtWilayah.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtPerTanggal.Properties.CalendarTimeProperties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtPerTanggal.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private DevExpress.XtraLayout.LayoutControl layoutControl1;
		private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
		private DevExpress.XtraEditors.TextEdit txtNama;
		private DevExpress.XtraEditors.TextEdit txtWilayah;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem8;
		private DevExpress.XtraEditors.RadioGroup txtStatus;
		private DevExpress.XtraEditors.RadioGroup txtTampilkan;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
		private DevExpress.XtraEditors.DateEdit txtPerTanggal;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
	}
}