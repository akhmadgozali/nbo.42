namespace NuSoft.NUI.Win.Forms.Modules.NuSoft012.UI.MasterData
{
	partial class UI_KelompokOmzetDialog
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
			this.txtTTdJabatan = new DevExpress.XtraEditors.TextEdit();
			this.txtTTdNama = new DevExpress.XtraEditors.TextEdit();
			this.txtNama = new DevExpress.XtraEditors.TextEdit();
			this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
			this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
			this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
			this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
			this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
			((System.ComponentModel.ISupportInitialize)(this.session)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
			this.layoutControl1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.txtKeterangan.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtTTdJabatan.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtTTdNama.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtNama.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
			this.SuspendLayout();
			// 
			// layoutControl1
			// 
			this.layoutControl1.Controls.Add(this.txtKeterangan);
			this.layoutControl1.Controls.Add(this.txtTTdJabatan);
			this.layoutControl1.Controls.Add(this.txtTTdNama);
			this.layoutControl1.Controls.Add(this.txtNama);
			this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.layoutControl1.Location = new System.Drawing.Point(0, 0);
			this.layoutControl1.Name = "layoutControl1";
			this.layoutControl1.Root = this.layoutControlGroup1;
			this.layoutControl1.Size = new System.Drawing.Size(406, 198);
			this.layoutControl1.TabIndex = 0;
			this.layoutControl1.Text = "layoutControl1";
			// 
			// txtKeterangan
			// 
			this.txtKeterangan.EnterMoveNextControl = true;
			this.txtKeterangan.Location = new System.Drawing.Point(153, 84);
			this.txtKeterangan.Name = "txtKeterangan";
			this.txtKeterangan.Size = new System.Drawing.Size(241, 102);
			this.txtKeterangan.StyleController = this.layoutControl1;
			this.txtKeterangan.TabIndex = 3;
			// 
			// txtTTdJabatan
			// 
			this.txtTTdJabatan.EnterMoveNextControl = true;
			this.txtTTdJabatan.Location = new System.Drawing.Point(153, 60);
			this.txtTTdJabatan.Name = "txtTTdJabatan";
			this.txtTTdJabatan.Properties.MaxLength = 100;
			this.txtTTdJabatan.Size = new System.Drawing.Size(241, 20);
			this.txtTTdJabatan.StyleController = this.layoutControl1;
			this.txtTTdJabatan.TabIndex = 2;
			// 
			// txtTTdNama
			// 
			this.txtTTdNama.EnterMoveNextControl = true;
			this.txtTTdNama.Location = new System.Drawing.Point(153, 36);
			this.txtTTdNama.Name = "txtTTdNama";
			this.txtTTdNama.Properties.MaxLength = 100;
			this.txtTTdNama.Size = new System.Drawing.Size(241, 20);
			this.txtTTdNama.StyleController = this.layoutControl1;
			this.txtTTdNama.TabIndex = 1;
			// 
			// txtNama
			// 
			this.txtNama.EnterMoveNextControl = true;
			this.txtNama.Location = new System.Drawing.Point(153, 12);
			this.txtNama.Name = "txtNama";
			this.txtNama.Properties.MaxLength = 30;
			this.txtNama.Size = new System.Drawing.Size(241, 20);
			this.txtNama.StyleController = this.layoutControl1;
			this.txtNama.TabIndex = 0;
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
            this.layoutControlItem4});
			this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
			this.layoutControlGroup1.Name = "layoutControlGroup1";
			this.layoutControlGroup1.Size = new System.Drawing.Size(406, 198);
			this.layoutControlGroup1.Text = "layoutControlGroup1";
			this.layoutControlGroup1.TextVisible = false;
			// 
			// layoutControlItem1
			// 
			this.layoutControlItem1.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.layoutControlItem1.AppearanceItemCaption.Options.UseFont = true;
			this.layoutControlItem1.Control = this.txtNama;
			this.layoutControlItem1.CustomizationFormText = "Nama";
			this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
			this.layoutControlItem1.Name = "layoutControlItem1";
			this.layoutControlItem1.Size = new System.Drawing.Size(386, 24);
			this.layoutControlItem1.Text = "Nama";
			this.layoutControlItem1.TextSize = new System.Drawing.Size(138, 13);
			// 
			// layoutControlItem2
			// 
			this.layoutControlItem2.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.layoutControlItem2.AppearanceItemCaption.Options.UseFont = true;
			this.layoutControlItem2.Control = this.txtTTdNama;
			this.layoutControlItem2.CustomizationFormText = "Nama Penandatangan";
			this.layoutControlItem2.Location = new System.Drawing.Point(0, 24);
			this.layoutControlItem2.Name = "layoutControlItem2";
			this.layoutControlItem2.Size = new System.Drawing.Size(386, 24);
			this.layoutControlItem2.Text = "Nama Penandatangan";
			this.layoutControlItem2.TextSize = new System.Drawing.Size(138, 13);
			// 
			// layoutControlItem3
			// 
			this.layoutControlItem3.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.layoutControlItem3.AppearanceItemCaption.Options.UseFont = true;
			this.layoutControlItem3.Control = this.txtTTdJabatan;
			this.layoutControlItem3.CustomizationFormText = "Jabatan Penandatangan";
			this.layoutControlItem3.Location = new System.Drawing.Point(0, 48);
			this.layoutControlItem3.Name = "layoutControlItem3";
			this.layoutControlItem3.Size = new System.Drawing.Size(386, 24);
			this.layoutControlItem3.Text = "Jabatan Penandatangan";
			this.layoutControlItem3.TextSize = new System.Drawing.Size(138, 13);
			// 
			// layoutControlItem4
			// 
			this.layoutControlItem4.Control = this.txtKeterangan;
			this.layoutControlItem4.CustomizationFormText = "Keterangan";
			this.layoutControlItem4.Location = new System.Drawing.Point(0, 72);
			this.layoutControlItem4.Name = "layoutControlItem4";
			this.layoutControlItem4.Size = new System.Drawing.Size(386, 106);
			this.layoutControlItem4.Text = "Keterangan";
			this.layoutControlItem4.TextSize = new System.Drawing.Size(138, 13);
			// 
			// UI_KelompokOmzetDialog
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(406, 247);
			this.Controls.Add(this.layoutControl1);
			this.Name = "UI_KelompokOmzetDialog";
			this.Text = "UI_KelompokOmzetDialog";
			this.Controls.SetChildIndex(this.layoutControl1, 0);
			((System.ComponentModel.ISupportInitialize)(this.session)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
			this.layoutControl1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.txtKeterangan.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtTTdJabatan.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtTTdNama.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtNama.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private DevExpress.XtraLayout.LayoutControl layoutControl1;
		private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
		private DevExpress.XtraEditors.MemoEdit txtKeterangan;
		private DevExpress.XtraEditors.TextEdit txtTTdJabatan;
		private DevExpress.XtraEditors.TextEdit txtTTdNama;
		private DevExpress.XtraEditors.TextEdit txtNama;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
	}
}