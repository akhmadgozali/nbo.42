namespace NuSoft.NUI.Win.Forms.Modules.NuSoft009.UILayer.Transaksi
{
	partial class UI_FormLembur
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UI_FormLembur));
			this.colcreated_date = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colcreated_user = new DevExpress.XtraGrid.Columns.GridColumn();
			this.collast_date = new DevExpress.XtraGrid.Columns.GridColumn();
			this.collast_modified = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
			this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colJamAwal = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colJamAkhir = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colPekerjaan = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colBersedia = new DevExpress.XtraGrid.Columns.GridColumn();
			this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.gridColumn9 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colJamRealisasiAwal = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colJamRealisasiAkhir = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colKeterangan = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colStatus = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colTukarCuti = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colLemburWajib = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colLiburPengganti = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colUangMakan = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colShift2 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colShift3 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colPotongan = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colJagaMesin = new DevExpress.XtraGrid.Columns.GridColumn();
			this.gridColumn10 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.gridColumn11 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.gridColumn12 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.gridColumn13 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.gridColumn14 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.gridColumn15 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.gridColumn16 = new DevExpress.XtraGrid.Columns.GridColumn();
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
			this.xGrid.Size = new System.Drawing.Size(800, 423);
			// 
			// xGridView
			// 
			this.xGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colcreated_date,
            this.colcreated_user,
            this.collast_date,
            this.collast_modified,
            this.colId,
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5,
            this.colJamAwal,
            this.colJamAkhir,
            this.colPekerjaan,
            this.colBersedia,
            this.gridColumn7,
            this.gridColumn8,
            this.gridColumn9,
            this.colJamRealisasiAwal,
            this.colJamRealisasiAkhir,
            this.colKeterangan,
            this.colStatus,
            this.colTukarCuti,
            this.colLemburWajib,
            this.colLiburPengganti,
            this.colUangMakan,
            this.colShift2,
            this.colShift3,
            this.colPotongan,
            this.colJagaMesin,
            this.gridColumn10,
            this.gridColumn11,
            this.gridColumn12,
            this.gridColumn13,
            this.gridColumn14,
            this.gridColumn15,
            this.gridColumn16});
			this.xGridView.OptionsBehavior.Editable = false;
			this.xGridView.OptionsDetail.EnableMasterViewMode = false;
			this.xGridView.OptionsSelection.MultiSelect = true;
			this.xGridView.OptionsView.ColumnAutoWidth = false;
			// 
			// ifSource
			// 
			this.ifSource.DisplayableProperties = resources.GetString("ifSource.DisplayableProperties");
			this.ifSource.ObjectType = typeof(NuSoft.NUI.Win.Forms.Modules.NuSoft09.Persistent.SPKLDetail);
			// 
			// barMenu
			// 
			this.barMenu.OptionsBar.AllowQuickCustomization = false;
			this.barMenu.OptionsBar.DrawDragBorder = false;
			this.barMenu.OptionsBar.UseWholeRow = true;
			// 
			// colcreated_date
			// 
			this.colcreated_date.FieldName = "created_date";
			this.colcreated_date.Name = "colcreated_date";
			// 
			// colcreated_user
			// 
			this.colcreated_user.FieldName = "created_user";
			this.colcreated_user.Name = "colcreated_user";
			// 
			// collast_date
			// 
			this.collast_date.FieldName = "last_date";
			this.collast_date.Name = "collast_date";
			// 
			// collast_modified
			// 
			this.collast_modified.FieldName = "last_modified";
			this.collast_modified.Name = "collast_modified";
			// 
			// colId
			// 
			this.colId.FieldName = "Id";
			this.colId.Name = "colId";
			// 
			// gridColumn1
			// 
			this.gridColumn1.Caption = "No SPKL";
			this.gridColumn1.FieldName = "Main.Kode";
			this.gridColumn1.Name = "gridColumn1";
			this.gridColumn1.OptionsColumn.ReadOnly = true;
			this.gridColumn1.Visible = true;
			this.gridColumn1.VisibleIndex = 0;
			this.gridColumn1.Width = 82;
			// 
			// gridColumn2
			// 
			this.gridColumn2.Caption = "Tanggal";
			this.gridColumn2.FieldName = "Main.Tanggal";
			this.gridColumn2.Name = "gridColumn2";
			this.gridColumn2.OptionsColumn.ReadOnly = true;
			this.gridColumn2.Visible = true;
			this.gridColumn2.VisibleIndex = 1;
			this.gridColumn2.Width = 91;
			// 
			// gridColumn3
			// 
			this.gridColumn3.Caption = "Keterangan";
			this.gridColumn3.FieldName = "Main.Keterangan";
			this.gridColumn3.Name = "gridColumn3";
			this.gridColumn3.OptionsColumn.ReadOnly = true;
			this.gridColumn3.Visible = true;
			this.gridColumn3.VisibleIndex = 2;
			this.gridColumn3.Width = 122;
			// 
			// gridColumn4
			// 
			this.gridColumn4.Caption = "APP1";
			this.gridColumn4.FieldName = "Main.TanggalApp1";
			this.gridColumn4.Name = "gridColumn4";
			this.gridColumn4.OptionsColumn.ReadOnly = true;
			this.gridColumn4.Width = 87;
			// 
			// gridColumn5
			// 
			this.gridColumn5.Caption = "APP2";
			this.gridColumn5.FieldName = "Main.TanggalApp2";
			this.gridColumn5.Name = "gridColumn5";
			this.gridColumn5.OptionsColumn.ReadOnly = true;
			this.gridColumn5.Width = 107;
			// 
			// colJamAwal
			// 
			this.colJamAwal.Caption = "Jam Awal";
			this.colJamAwal.FieldName = "JamAwal";
			this.colJamAwal.Name = "colJamAwal";
			this.colJamAwal.Visible = true;
			this.colJamAwal.VisibleIndex = 3;
			this.colJamAwal.Width = 61;
			// 
			// colJamAkhir
			// 
			this.colJamAkhir.Caption = "Jam Akhir";
			this.colJamAkhir.FieldName = "JamAkhir";
			this.colJamAkhir.Name = "colJamAkhir";
			this.colJamAkhir.Visible = true;
			this.colJamAkhir.VisibleIndex = 4;
			this.colJamAkhir.Width = 61;
			// 
			// colPekerjaan
			// 
			this.colPekerjaan.Caption = "Pekerjaan";
			this.colPekerjaan.FieldName = "Pekerjaan";
			this.colPekerjaan.Name = "colPekerjaan";
			this.colPekerjaan.Visible = true;
			this.colPekerjaan.VisibleIndex = 5;
			this.colPekerjaan.Width = 182;
			// 
			// colBersedia
			// 
			this.colBersedia.Caption = "Bersedia";
			this.colBersedia.FieldName = "Bersedia";
			this.colBersedia.Name = "colBersedia";
			this.colBersedia.Visible = true;
			this.colBersedia.VisibleIndex = 6;
			this.colBersedia.Width = 68;
			// 
			// gridColumn7
			// 
			this.gridColumn7.FieldName = "KaryawanRealisasi.Id";
			this.gridColumn7.Name = "gridColumn7";
			this.gridColumn7.OptionsColumn.ReadOnly = true;
			this.gridColumn7.Width = 41;
			// 
			// gridColumn8
			// 
			this.gridColumn8.FieldName = "KaryawanRealisasi.Kode";
			this.gridColumn8.Name = "gridColumn8";
			this.gridColumn8.OptionsColumn.ReadOnly = true;
			this.gridColumn8.Width = 134;
			// 
			// gridColumn9
			// 
			this.gridColumn9.FieldName = "KaryawanRealisasi.Nama";
			this.gridColumn9.Name = "gridColumn9";
			this.gridColumn9.OptionsColumn.ReadOnly = true;
			this.gridColumn9.Width = 130;
			// 
			// colJamRealisasiAwal
			// 
			this.colJamRealisasiAwal.Caption = "Jam Realisasi Awal";
			this.colJamRealisasiAwal.FieldName = "JamRealisasiAwal";
			this.colJamRealisasiAwal.Name = "colJamRealisasiAwal";
			this.colJamRealisasiAwal.Visible = true;
			this.colJamRealisasiAwal.VisibleIndex = 7;
			this.colJamRealisasiAwal.Width = 121;
			// 
			// colJamRealisasiAkhir
			// 
			this.colJamRealisasiAkhir.Caption = "Jam Realisasi Akhir";
			this.colJamRealisasiAkhir.FieldName = "JamRealisasiAkhir";
			this.colJamRealisasiAkhir.Name = "colJamRealisasiAkhir";
			this.colJamRealisasiAkhir.Visible = true;
			this.colJamRealisasiAkhir.VisibleIndex = 8;
			this.colJamRealisasiAkhir.Width = 112;
			// 
			// colKeterangan
			// 
			this.colKeterangan.Caption = "Keterangan";
			this.colKeterangan.FieldName = "Keterangan";
			this.colKeterangan.Name = "colKeterangan";
			this.colKeterangan.Width = 133;
			// 
			// colStatus
			// 
			this.colStatus.Caption = "Status";
			this.colStatus.FieldName = "Status";
			this.colStatus.Name = "colStatus";
			this.colStatus.Visible = true;
			this.colStatus.VisibleIndex = 9;
			this.colStatus.Width = 80;
			// 
			// colTukarCuti
			// 
			this.colTukarCuti.Caption = "Tukar Cuti";
			this.colTukarCuti.FieldName = "TukarCuti";
			this.colTukarCuti.Name = "colTukarCuti";
			this.colTukarCuti.Visible = true;
			this.colTukarCuti.VisibleIndex = 10;
			this.colTukarCuti.Width = 62;
			// 
			// colLemburWajib
			// 
			this.colLemburWajib.Caption = "Lembur Wajib";
			this.colLemburWajib.FieldName = "LemburWajib";
			this.colLemburWajib.Name = "colLemburWajib";
			this.colLemburWajib.Visible = true;
			this.colLemburWajib.VisibleIndex = 11;
			this.colLemburWajib.Width = 79;
			// 
			// colLiburPengganti
			// 
			this.colLiburPengganti.Caption = "Libur Pengganti";
			this.colLiburPengganti.FieldName = "LiburPengganti";
			this.colLiburPengganti.Name = "colLiburPengganti";
			this.colLiburPengganti.Visible = true;
			this.colLiburPengganti.VisibleIndex = 12;
			this.colLiburPengganti.Width = 89;
			// 
			// colUangMakan
			// 
			this.colUangMakan.Caption = "Uang Makan";
			this.colUangMakan.FieldName = "UangMakan";
			this.colUangMakan.Name = "colUangMakan";
			this.colUangMakan.Visible = true;
			this.colUangMakan.VisibleIndex = 13;
			this.colUangMakan.Width = 71;
			// 
			// colShift2
			// 
			this.colShift2.Caption = "Shift 2";
			this.colShift2.FieldName = "Shift2";
			this.colShift2.Name = "colShift2";
			this.colShift2.Visible = true;
			this.colShift2.VisibleIndex = 14;
			this.colShift2.Width = 41;
			// 
			// colShift3
			// 
			this.colShift3.Caption = "Shift 3";
			this.colShift3.FieldName = "Shift3";
			this.colShift3.Name = "colShift3";
			this.colShift3.Visible = true;
			this.colShift3.VisibleIndex = 15;
			this.colShift3.Width = 41;
			// 
			// colPotongan
			// 
			this.colPotongan.Caption = "Potongan";
			this.colPotongan.FieldName = "Potongan";
			this.colPotongan.Name = "colPotongan";
			this.colPotongan.Visible = true;
			this.colPotongan.VisibleIndex = 16;
			this.colPotongan.Width = 61;
			// 
			// colJagaMesin
			// 
			this.colJagaMesin.Caption = "Jaga Mesin";
			this.colJagaMesin.FieldName = "JagaMesin";
			this.colJagaMesin.Name = "colJagaMesin";
			this.colJagaMesin.Visible = true;
			this.colJagaMesin.VisibleIndex = 17;
			// 
			// gridColumn10
			// 
			this.gridColumn10.FieldName = "Absensi.Id";
			this.gridColumn10.Name = "gridColumn10";
			this.gridColumn10.OptionsColumn.ReadOnly = true;
			this.gridColumn10.Width = 41;
			// 
			// gridColumn11
			// 
			this.gridColumn11.FieldName = "Absensi.Karyawan.Kode";
			this.gridColumn11.Name = "gridColumn11";
			this.gridColumn11.OptionsColumn.ReadOnly = true;
			this.gridColumn11.Width = 41;
			// 
			// gridColumn12
			// 
			this.gridColumn12.FieldName = "Absensi.Karyawan.Nama";
			this.gridColumn12.Name = "gridColumn12";
			this.gridColumn12.OptionsColumn.ReadOnly = true;
			this.gridColumn12.Width = 41;
			// 
			// gridColumn13
			// 
			this.gridColumn13.FieldName = "Absensi.Tanggal";
			this.gridColumn13.Name = "gridColumn13";
			this.gridColumn13.OptionsColumn.ReadOnly = true;
			this.gridColumn13.Width = 41;
			// 
			// gridColumn14
			// 
			this.gridColumn14.Caption = "Absensi Jam Masuk";
			this.gridColumn14.FieldName = "Absensi.JamMasuk";
			this.gridColumn14.Name = "gridColumn14";
			this.gridColumn14.OptionsColumn.ReadOnly = true;
			this.gridColumn14.Visible = true;
			this.gridColumn14.VisibleIndex = 18;
			this.gridColumn14.Width = 104;
			// 
			// gridColumn15
			// 
			this.gridColumn15.Caption = "Absensi Jam Pulang";
			this.gridColumn15.FieldName = "Absensi.JamPulang";
			this.gridColumn15.Name = "gridColumn15";
			this.gridColumn15.OptionsColumn.ReadOnly = true;
			this.gridColumn15.Visible = true;
			this.gridColumn15.VisibleIndex = 19;
			this.gridColumn15.Width = 110;
			// 
			// gridColumn16
			// 
			this.gridColumn16.FieldName = "Absensi.Status.Kode";
			this.gridColumn16.Name = "gridColumn16";
			this.gridColumn16.OptionsColumn.ReadOnly = true;
			this.gridColumn16.Width = 106;
			// 
			// UI_FormLembur
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Name = "UI_FormLembur";
			this.Text = "Form Lembur";
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

		private DevExpress.XtraGrid.Columns.GridColumn colcreated_date;
		private DevExpress.XtraGrid.Columns.GridColumn colcreated_user;
		private DevExpress.XtraGrid.Columns.GridColumn collast_date;
		private DevExpress.XtraGrid.Columns.GridColumn collast_modified;
		private DevExpress.XtraGrid.Columns.GridColumn colId;
		private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
		private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
		private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
		private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
		private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
		private DevExpress.XtraGrid.Columns.GridColumn colJamAwal;
		private DevExpress.XtraGrid.Columns.GridColumn colJamAkhir;
		private DevExpress.XtraGrid.Columns.GridColumn colPekerjaan;
		private DevExpress.XtraGrid.Columns.GridColumn colBersedia;
		private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
		private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
		private DevExpress.XtraGrid.Columns.GridColumn gridColumn9;
		private DevExpress.XtraGrid.Columns.GridColumn colJamRealisasiAwal;
		private DevExpress.XtraGrid.Columns.GridColumn colJamRealisasiAkhir;
		private DevExpress.XtraGrid.Columns.GridColumn colKeterangan;
		private DevExpress.XtraGrid.Columns.GridColumn colStatus;
		private DevExpress.XtraGrid.Columns.GridColumn colTukarCuti;
		private DevExpress.XtraGrid.Columns.GridColumn colLemburWajib;
		private DevExpress.XtraGrid.Columns.GridColumn colLiburPengganti;
		private DevExpress.XtraGrid.Columns.GridColumn colUangMakan;
		private DevExpress.XtraGrid.Columns.GridColumn colShift2;
		private DevExpress.XtraGrid.Columns.GridColumn colShift3;
		private DevExpress.XtraGrid.Columns.GridColumn colPotongan;
		private DevExpress.XtraGrid.Columns.GridColumn colJagaMesin;
		private DevExpress.XtraGrid.Columns.GridColumn gridColumn10;
		private DevExpress.XtraGrid.Columns.GridColumn gridColumn11;
		private DevExpress.XtraGrid.Columns.GridColumn gridColumn12;
		private DevExpress.XtraGrid.Columns.GridColumn gridColumn13;
		private DevExpress.XtraGrid.Columns.GridColumn gridColumn14;
		private DevExpress.XtraGrid.Columns.GridColumn gridColumn15;
		private DevExpress.XtraGrid.Columns.GridColumn gridColumn16;
	}
}