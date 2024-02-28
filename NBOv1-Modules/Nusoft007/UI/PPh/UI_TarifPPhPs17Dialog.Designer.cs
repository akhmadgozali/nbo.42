namespace NuSoft.NUI.Win.Forms.Modules.NuSoft007.UI.PPh
{
	partial class UI_TarifPPhPs17Dialog
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
			this.txtKeterangan = new DevExpress.XtraEditors.MemoEdit();
			this.txtBatasAtas = new DevExpress.XtraEditors.SpinEdit();
			this.txtBatasBawah = new DevExpress.XtraEditors.SpinEdit();
			this.txtTarif = new DevExpress.XtraEditors.SpinEdit();
			this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
			this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
			this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
			this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
			this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
			((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
			this.layoutControl1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.txtKeterangan.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtBatasAtas.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtBatasBawah.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtTarif.Properties)).BeginInit();
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
			this.layoutControl1.Controls.Add(this.txtBatasAtas);
			this.layoutControl1.Controls.Add(this.txtBatasBawah);
			this.layoutControl1.Controls.Add(this.txtTarif);
			this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.layoutControl1.Location = new System.Drawing.Point(0, 27);
			this.layoutControl1.Name = "layoutControl1";
			this.layoutControl1.Root = this.layoutControlGroup1;
			this.layoutControl1.Size = new System.Drawing.Size(354, 193);
			this.layoutControl1.TabIndex = 2;
			this.layoutControl1.Text = "layoutControl1";
			// 
			// txtKeterangan
			// 
			this.txtKeterangan.EnterMoveNextControl = true;
			this.txtKeterangan.Location = new System.Drawing.Point(86, 84);
			this.txtKeterangan.Name = "txtKeterangan";
			this.txtKeterangan.Size = new System.Drawing.Size(256, 97);
			this.txtKeterangan.StyleController = this.layoutControl1;
			this.txtKeterangan.TabIndex = 7;
			// 
			// txtBatasAtas
			// 
			this.txtBatasAtas.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
			this.txtBatasAtas.EnterMoveNextControl = true;
			this.txtBatasAtas.Location = new System.Drawing.Point(86, 60);
			this.txtBatasAtas.Name = "txtBatasAtas";
			this.txtBatasAtas.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.txtBatasAtas.Properties.DisplayFormat.FormatString = "n0";
			this.txtBatasAtas.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.txtBatasAtas.Size = new System.Drawing.Size(256, 20);
			this.txtBatasAtas.StyleController = this.layoutControl1;
			this.txtBatasAtas.TabIndex = 6;
			// 
			// txtBatasBawah
			// 
			this.txtBatasBawah.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
			this.txtBatasBawah.EnterMoveNextControl = true;
			this.txtBatasBawah.Location = new System.Drawing.Point(86, 36);
			this.txtBatasBawah.Name = "txtBatasBawah";
			this.txtBatasBawah.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.txtBatasBawah.Properties.DisplayFormat.FormatString = "n0";
			this.txtBatasBawah.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.txtBatasBawah.Size = new System.Drawing.Size(256, 20);
			this.txtBatasBawah.StyleController = this.layoutControl1;
			this.txtBatasBawah.TabIndex = 5;
			// 
			// txtTarif
			// 
			this.txtTarif.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
			this.txtTarif.EnterMoveNextControl = true;
			this.txtTarif.Location = new System.Drawing.Point(86, 12);
			this.txtTarif.Name = "txtTarif";
			this.txtTarif.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.txtTarif.Properties.DisplayFormat.FormatString = "n0";
			this.txtTarif.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.txtTarif.Properties.MaxValue = new decimal(new int[] {
            99,
            0,
            0,
            0});
			this.txtTarif.Size = new System.Drawing.Size(256, 20);
			this.txtTarif.StyleController = this.layoutControl1;
			this.txtTarif.TabIndex = 4;
			// 
			// layoutControlGroup1
			// 
			this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
			this.layoutControlGroup1.GroupBordersVisible = false;
			this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem4});
			this.layoutControlGroup1.Name = "layoutControlGroup1";
			this.layoutControlGroup1.Size = new System.Drawing.Size(354, 193);
			this.layoutControlGroup1.TextVisible = false;
			// 
			// layoutControlItem1
			// 
			this.layoutControlItem1.Control = this.txtTarif;
			this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
			this.layoutControlItem1.Name = "layoutControlItem1";
			this.layoutControlItem1.Size = new System.Drawing.Size(334, 24);
			this.layoutControlItem1.Text = "Tarif";
			this.layoutControlItem1.TextSize = new System.Drawing.Size(71, 13);
			// 
			// layoutControlItem2
			// 
			this.layoutControlItem2.Control = this.txtBatasBawah;
			this.layoutControlItem2.Location = new System.Drawing.Point(0, 24);
			this.layoutControlItem2.Name = "layoutControlItem2";
			this.layoutControlItem2.Size = new System.Drawing.Size(334, 24);
			this.layoutControlItem2.Text = "Batas Bawah";
			this.layoutControlItem2.TextSize = new System.Drawing.Size(71, 13);
			// 
			// layoutControlItem3
			// 
			this.layoutControlItem3.Control = this.txtBatasAtas;
			this.layoutControlItem3.Location = new System.Drawing.Point(0, 48);
			this.layoutControlItem3.Name = "layoutControlItem3";
			this.layoutControlItem3.Size = new System.Drawing.Size(334, 24);
			this.layoutControlItem3.Text = "Batas Atas";
			this.layoutControlItem3.TextSize = new System.Drawing.Size(71, 13);
			// 
			// layoutControlItem4
			// 
			this.layoutControlItem4.Control = this.txtKeterangan;
			this.layoutControlItem4.Location = new System.Drawing.Point(0, 72);
			this.layoutControlItem4.Name = "layoutControlItem4";
			this.layoutControlItem4.Size = new System.Drawing.Size(334, 101);
			this.layoutControlItem4.Text = "Keterangan     ";
			this.layoutControlItem4.TextSize = new System.Drawing.Size(71, 13);
			// 
			// UI_TarifPPhPs17Dialog
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(354, 251);
			this.Controls.Add(this.layoutControl1);
			this.Name = "UI_TarifPPhPs17Dialog";
			this.Text = "UI_TarifPPhPs17Dialog";
			this.Controls.SetChildIndex(this.layoutControl1, 0);
			((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
			this.layoutControl1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.txtKeterangan.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtBatasAtas.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtBatasBawah.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtTarif.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private DevExpress.XtraLayout.LayoutControl layoutControl1;
		private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
		private DevExpress.XtraEditors.MemoEdit txtKeterangan;
		private DevExpress.XtraEditors.SpinEdit txtBatasAtas;
		private DevExpress.XtraEditors.SpinEdit txtBatasBawah;
		private DevExpress.XtraEditors.SpinEdit txtTarif;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
	}
}