namespace NuSoft.NUI.Win.Forms.Modules.NuSoft012.UI.MasterData
{
	partial class UI_Pemasang
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
			this.colKode = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colNama = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colAlamat = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colKontakPerson = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colDiskon = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colJatuhTempo = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colTelp = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colNoHP1 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colNoHP2 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colEmail = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colNPWP = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colAktif = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colKeterangan = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
			((System.ComponentModel.ISupportInitialize)(this.xGrid)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.xpCol)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.barMan)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.session)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.xGridView)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.popMenu)).BeginInit();
			this.SuspendLayout();
			// 
			// xGrid
			// 
			this.xGrid.DataSource = this.ifSource;
			this.xGrid.Size = new System.Drawing.Size(765, 375);
			// 
			// xGridView
			// 
			this.xGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colKode,
            this.colNama,
            this.colAlamat,
            this.colKontakPerson,
            this.colDiskon,
            this.colJatuhTempo,
            this.colTelp,
            this.colNoHP1,
            this.colNoHP2,
            this.colEmail,
            this.colNPWP,
            this.colAktif,
            this.colKeterangan,
            this.colId});
			this.xGridView.OptionsBehavior.AllowFixedGroups = DevExpress.Utils.DefaultBoolean.True;
			this.xGridView.OptionsBehavior.Editable = false;
			this.xGridView.OptionsDetail.EnableMasterViewMode = false;
			this.xGridView.OptionsSelection.MultiSelect = true;
			this.xGridView.OptionsView.ShowAutoFilterRow = true;
			this.xGridView.OptionsView.ShowGroupedColumns = true;
			// 
			// ifSource
			// 
			this.ifSource.DisplayableProperties = "Id;Kode;Nama;Alamat;NPWP;KodeFaktur;NIK;NoTelpon;NoFax;NoHP1;NoHP2;Email;Aktif;Di" +
    "skonDefault;JatuhTempoDefault;KontakPerson;Keterangan";
			this.ifSource.ObjectType = typeof(NuSoft.NUI.Win.Forms.Modules.NuSoft012.Persistent.Pemasang);
			// 
			// barMenu
			// 
			this.barMenu.OptionsBar.AllowQuickCustomization = false;
			this.barMenu.OptionsBar.DrawDragBorder = false;
			this.barMenu.OptionsBar.UseWholeRow = true;
			// 
			// colKode
			// 
			this.colKode.Caption = "Kode";
			this.colKode.FieldName = "Kode";
			this.colKode.Name = "colKode";
			this.colKode.Visible = true;
			this.colKode.VisibleIndex = 0;
			this.colKode.Width = 41;
			// 
			// colNama
			// 
			this.colNama.Caption = "Nama";
			this.colNama.FieldName = "Nama";
			this.colNama.Name = "colNama";
			this.colNama.Visible = true;
			this.colNama.VisibleIndex = 1;
			this.colNama.Width = 80;
			// 
			// colAlamat
			// 
			this.colAlamat.Caption = "Alamat";
			this.colAlamat.FieldName = "Alamat";
			this.colAlamat.Name = "colAlamat";
			this.colAlamat.Visible = true;
			this.colAlamat.VisibleIndex = 2;
			this.colAlamat.Width = 100;
			// 
			// colKontakPerson
			// 
			this.colKontakPerson.FieldName = "KontakPerson";
			this.colKontakPerson.Name = "colKontakPerson";
			this.colKontakPerson.Visible = true;
			this.colKontakPerson.VisibleIndex = 3;
			this.colKontakPerson.Width = 50;
			// 
			// colDiskon
			// 
			this.colDiskon.FieldName = "DiskonDefault";
			this.colDiskon.Name = "colDiskon";
			this.colDiskon.Visible = true;
			this.colDiskon.VisibleIndex = 4;
			this.colDiskon.Width = 25;
			// 
			// colJatuhTempo
			// 
			this.colJatuhTempo.FieldName = "JatuhTempoDefault";
			this.colJatuhTempo.Name = "colJatuhTempo";
			this.colJatuhTempo.Visible = true;
			this.colJatuhTempo.VisibleIndex = 5;
			this.colJatuhTempo.Width = 30;
			// 
			// colTelp
			// 
			this.colTelp.Caption = "No. Telp";
			this.colTelp.FieldName = "NoTelpon";
			this.colTelp.Name = "colTelp";
			this.colTelp.Visible = true;
			this.colTelp.VisibleIndex = 6;
			this.colTelp.Width = 37;
			// 
			// colNoHP1
			// 
			this.colNoHP1.Caption = "No. HP 1";
			this.colNoHP1.FieldName = "NoHP1";
			this.colNoHP1.Name = "colNoHP1";
			this.colNoHP1.Visible = true;
			this.colNoHP1.VisibleIndex = 7;
			this.colNoHP1.Width = 37;
			// 
			// colNoHP2
			// 
			this.colNoHP2.Caption = "No. HP 2";
			this.colNoHP2.FieldName = "NoHP2";
			this.colNoHP2.Name = "colNoHP2";
			this.colNoHP2.Visible = true;
			this.colNoHP2.VisibleIndex = 8;
			this.colNoHP2.Width = 37;
			// 
			// colEmail
			// 
			this.colEmail.Caption = "Email";
			this.colEmail.FieldName = "Email";
			this.colEmail.Name = "colEmail";
			this.colEmail.Visible = true;
			this.colEmail.VisibleIndex = 9;
			this.colEmail.Width = 49;
			// 
			// colNPWP
			// 
			this.colNPWP.Caption = "NPWP";
			this.colNPWP.FieldName = "NPWP";
			this.colNPWP.Name = "colNPWP";
			this.colNPWP.Visible = true;
			this.colNPWP.VisibleIndex = 10;
			this.colNPWP.Width = 55;
			// 
			// colAktif
			// 
			this.colAktif.Caption = "Aktif";
			this.colAktif.FieldName = "Aktif";
			this.colAktif.Name = "colAktif";
			this.colAktif.Visible = true;
			this.colAktif.VisibleIndex = 11;
			this.colAktif.Width = 20;
			// 
			// colKeterangan
			// 
			this.colKeterangan.Caption = "Keterangan";
			this.colKeterangan.FieldName = "Keterangan";
			this.colKeterangan.Name = "colKeterangan";
			this.colKeterangan.Visible = true;
			this.colKeterangan.VisibleIndex = 12;
			this.colKeterangan.Width = 105;
			// 
			// colId
			// 
			this.colId.FieldName = "Id";
			this.colId.Name = "colId";
			// 
			// UI_Pemasang
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(765, 402);
			this.Name = "UI_Pemasang";
			this.Text = "Pemasang";
			this.xpCol = this.xpCol;
			((System.ComponentModel.ISupportInitialize)(this.xGrid)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.xpCol)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.barMan)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.session)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.xGridView)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.popMenu)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private DevExpress.XtraGrid.Columns.GridColumn colKode;
		private DevExpress.XtraGrid.Columns.GridColumn colNama;
		private DevExpress.XtraGrid.Columns.GridColumn colAlamat;
		private DevExpress.XtraGrid.Columns.GridColumn colKontakPerson;
		private DevExpress.XtraGrid.Columns.GridColumn colDiskon;
		private DevExpress.XtraGrid.Columns.GridColumn colJatuhTempo;
		private DevExpress.XtraGrid.Columns.GridColumn colTelp;
		private DevExpress.XtraGrid.Columns.GridColumn colNoHP1;
		private DevExpress.XtraGrid.Columns.GridColumn colNoHP2;
		private DevExpress.XtraGrid.Columns.GridColumn colEmail;
		private DevExpress.XtraGrid.Columns.GridColumn colNPWP;
		private DevExpress.XtraGrid.Columns.GridColumn colAktif;
		private DevExpress.XtraGrid.Columns.GridColumn colKeterangan;
		private DevExpress.XtraGrid.Columns.GridColumn colId;
	}
}
