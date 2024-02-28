namespace NuSoft.NUI.Win.Forms.Modules.NuSoft011.UI.MasterData
{
	partial class UI_RuteDialog
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
			this.txtNama = new DevExpress.XtraEditors.TextEdit();
			this.txtKode = new DevExpress.XtraEditors.TextEdit();
			this.txtRegional = new DevExpress.XtraEditors.LookUpEdit();
			this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
			this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
			this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
			this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
			this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
			((System.ComponentModel.ISupportInitialize)(this.session)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
			this.layoutControl1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.txtKeterangan.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtNama.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtKode.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtRegional.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
			this.SuspendLayout();
			// 
			// layoutControl1
			// 
			this.layoutControl1.Controls.Add(this.txtKeterangan);
			this.layoutControl1.Controls.Add(this.txtNama);
			this.layoutControl1.Controls.Add(this.txtKode);
			this.layoutControl1.Controls.Add(this.txtRegional);
			this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.layoutControl1.Location = new System.Drawing.Point(0, 0);
			this.layoutControl1.Name = "layoutControl1";
			this.layoutControl1.Root = this.layoutControlGroup1;
			this.layoutControl1.Size = new System.Drawing.Size(361, 230);
			this.layoutControl1.TabIndex = 2;
			this.layoutControl1.Text = "layoutControl1";
			// 
			// txtKeterangan
			// 
			this.txtKeterangan.EnterMoveNextControl = true;
			this.txtKeterangan.Location = new System.Drawing.Point(80, 84);
			this.txtKeterangan.Name = "txtKeterangan";
			this.txtKeterangan.Size = new System.Drawing.Size(269, 134);
			this.txtKeterangan.StyleController = this.layoutControl1;
			this.txtKeterangan.TabIndex = 8;
			// 
			// txtNama
			// 
			this.txtNama.EnterMoveNextControl = true;
			this.txtNama.Location = new System.Drawing.Point(80, 60);
			this.txtNama.Name = "txtNama";
			this.txtNama.Size = new System.Drawing.Size(269, 20);
			this.txtNama.StyleController = this.layoutControl1;
			this.txtNama.TabIndex = 6;
			// 
			// txtKode
			// 
			this.txtKode.EnterMoveNextControl = true;
			this.txtKode.Location = new System.Drawing.Point(80, 36);
			this.txtKode.Name = "txtKode";
			this.txtKode.Size = new System.Drawing.Size(269, 20);
			this.txtKode.StyleController = this.layoutControl1;
			this.txtKode.TabIndex = 5;
			// 
			// txtRegional
			// 
			this.txtRegional.EnterMoveNextControl = true;
			this.txtRegional.Location = new System.Drawing.Point(80, 12);
			this.txtRegional.Name = "txtRegional";
			this.txtRegional.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.txtRegional.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama", "Nama")});
			this.txtRegional.Properties.DisplayMember = "Nama";
			this.txtRegional.Properties.NullText = "[ Pilih Regional ]";
			this.txtRegional.Properties.ShowHeader = false;
			this.txtRegional.Properties.ValueMember = "This";
			this.txtRegional.Size = new System.Drawing.Size(269, 20);
			this.txtRegional.StyleController = this.layoutControl1;
			this.txtRegional.TabIndex = 4;
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
            this.layoutControlItem5});
			this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
			this.layoutControlGroup1.Name = "layoutControlGroup1";
			this.layoutControlGroup1.Size = new System.Drawing.Size(361, 230);
			this.layoutControlGroup1.Text = "layoutControlGroup1";
			this.layoutControlGroup1.TextVisible = false;
			// 
			// layoutControlItem1
			// 
			this.layoutControlItem1.Control = this.txtRegional;
			this.layoutControlItem1.CustomizationFormText = "Regional";
			this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
			this.layoutControlItem1.Name = "layoutControlItem1";
			this.layoutControlItem1.Size = new System.Drawing.Size(341, 24);
			this.layoutControlItem1.Text = "Regional";
			this.layoutControlItem1.TextSize = new System.Drawing.Size(65, 13);
			// 
			// layoutControlItem2
			// 
			this.layoutControlItem2.Control = this.txtKode;
			this.layoutControlItem2.CustomizationFormText = "Kode";
			this.layoutControlItem2.Location = new System.Drawing.Point(0, 24);
			this.layoutControlItem2.Name = "layoutControlItem2";
			this.layoutControlItem2.Size = new System.Drawing.Size(341, 24);
			this.layoutControlItem2.Text = "Kode";
			this.layoutControlItem2.TextSize = new System.Drawing.Size(65, 13);
			// 
			// layoutControlItem3
			// 
			this.layoutControlItem3.Control = this.txtNama;
			this.layoutControlItem3.CustomizationFormText = "Nama";
			this.layoutControlItem3.Location = new System.Drawing.Point(0, 48);
			this.layoutControlItem3.Name = "layoutControlItem3";
			this.layoutControlItem3.Size = new System.Drawing.Size(341, 24);
			this.layoutControlItem3.Text = "Nama";
			this.layoutControlItem3.TextSize = new System.Drawing.Size(65, 13);
			// 
			// layoutControlItem5
			// 
			this.layoutControlItem5.Control = this.txtKeterangan;
			this.layoutControlItem5.CustomizationFormText = "Keterangan   ";
			this.layoutControlItem5.Location = new System.Drawing.Point(0, 72);
			this.layoutControlItem5.Name = "layoutControlItem5";
			this.layoutControlItem5.Size = new System.Drawing.Size(341, 138);
			this.layoutControlItem5.Text = "Keterangan   ";
			this.layoutControlItem5.TextSize = new System.Drawing.Size(65, 13);
			// 
			// UI_RuteDialog
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(361, 279);
			this.Controls.Add(this.layoutControl1);
			this.Name = "UI_RuteDialog";
			this.Text = "UI_RuteDialog";
			this.Controls.SetChildIndex(this.layoutControl1, 0);
			((System.ComponentModel.ISupportInitialize)(this.session)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
			this.layoutControl1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.txtKeterangan.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtNama.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtKode.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtRegional.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private DevExpress.XtraLayout.LayoutControl layoutControl1;
		private DevExpress.XtraEditors.MemoEdit txtKeterangan;
		private DevExpress.XtraEditors.TextEdit txtNama;
		private DevExpress.XtraEditors.TextEdit txtKode;
		private DevExpress.XtraEditors.LookUpEdit txtRegional;
		private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
	}
}