using DevExpress.Data.Filtering;
using DevExpress.Xpo;
using NuSoft.Core.Win.Forms;
using NuSoft.NUI.Win.Forms.Modules.NuSoft011.Persistent;
using NuSoft.NUI.Win.Forms.Modules.NuSoft011.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using static NuSoft.NUI.Win.Forms.Modules.NuSoft011.MainClass;

namespace NuSoft.NUI.Win.Forms.Modules.NuSoft011.UI.ReportFilter {
	internal partial class UI_FilterTanggalAgenWilayah : FilterForm {
		private readonly ReportName _kodeLaporan;
		public UI_FilterTanggalAgenWilayah(ReportName KodeLaporan) {
			InitializeComponent();
			_kodeLaporan = KodeLaporan;
			switch (_kodeLaporan) {
				case ReportName.OrderLabel: Text = "Filter Laporan - Label Expedisi";
					layCaraBayar.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
					break;
				case ReportName.AgenPembayaranHarianRekap: Text = "Filter Laporan - Rekap Pembayaran Harian";
					kodeAgenLay1.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
					kodeAgenLay2.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
					break;
			}
		}

		public override void InitializeData() {
			txtRute.Properties.DataSource = new XPQuery<Rute>(_sesi).ToList();
			switch (_kodeLaporan) {
				case ReportName.OrderLabel: SetDefaultLabel(); break;
				case ReportName.AgenPembayaranHarianRekap:
					txtCaraBayar.Properties.DataSource = new XPQuery<CaraBayar>(_sesi).ToList();
					txtTanggal1.DateTime = DateTime.Now;
					txtTanggal2.DateTime = DateTime.Now;
					txtRute.CheckAll();
					txtCaraBayar.CheckAll();
					break;
			}
		}
		private void SetDefaultLabel() {
			txtTanggal1.DateTime = DateTime.Now.AddDays(1);
			layTanggal2.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
			txtRute.CheckAll();
			layCaraBayar.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
			this.Height -= layCaraBayar.Height - 1;
		}

		public override void Filter() {
			var setting = new NuSoftModSys.LogicLayer.Config(_sesi);
			var settingSirkulasi = new SirkulasiSetting(_sesi);
			if (setting != null) {
				AddParameter("NamaPerusahaan", setting.NamaPerusahaan, typeof(string));
				AddParameter("NamaAlias", setting.NamaAlias, typeof(string));
				AddParameter("Slogan", setting.Slogan, typeof(string));
				AddParameter("Alamat1", setting.Alamat1, typeof(string));
				AddParameter("Alamat2", setting.Alamat2, typeof(string));
				AddParameter("AlamatPerusahaan", setting.Alamat1 + " " + setting.Alamat2, typeof(string));
				AddParameter("NoTelp", setting.NoTelp, typeof(string));
				AddParameter("NoFax", setting.NoFax, typeof(string));
			}

			switch (_kodeLaporan) {
				case ReportName.OrderLabel:
					if (txtTanggal1.DateTime == null || txtTanggal1.DateTime == default(DateTime)) throw new Utils.Exception("Masukkan tanggal", -1);
					if (settingSirkulasi.SatuKoliPerEks == default(int)) throw new Utils.Exception("Masukkan setting per koli", -1);
					if (txtRute.Properties.GetItems().GetCheckedValues().Count() < 0) throw new Utils.Exception("Masukkan rute", -2);

					AddParameter("Tanggal", txtTanggal1.DateTime, typeof(DateTime));
					AddParameter("TTdNama", settingSirkulasi.OrderCetakTtdNama, typeof(string));
					AddParameter("TTdJabatan", settingSirkulasi.OrderCetakTtdJabatan, typeof(string));
					GetLabelDataSource(settingSirkulasi);
					break;
				case ReportName.AgenPembayaranHarianRekap:
					if (txtTanggal1.DateTime == null || txtTanggal1.DateTime == default(DateTime)) throw new Utils.Exception("Masukkan tanggal awal", -1);
					if (txtTanggal2.DateTime == null || txtTanggal2.DateTime == default(DateTime)) throw new Utils.Exception("Masukkan tanggal akhir", -3);
					if (txtRute.Properties.GetItems().GetCheckedValues().Count() < 0) throw new Utils.Exception("Masukkan rute", -2);
					if (txtCaraBayar.Properties.GetItems().GetCheckedValues().Count() < 0) throw new Utils.Exception("Masukkan cara bayar", -4);

					AddParameter("Tanggal1", txtTanggal1.DateTime, typeof(DateTime));
					AddParameter("Tanggal2", txtTanggal2.DateTime, typeof(DateTime));

					_dataSource = new XPCollection<BayarKoran>(_sesi, CreateCriteriaPenerimaanPembayaran());
					break;
			}
		}

		private void GetLabelDataSource(SirkulasiSetting setting) {
			var ds = SirkulasiHarianService.GetMutasiDetail(_sesi, txtTanggal1.DateTime, false).ToList();

			if (!string.IsNullOrEmpty(txtKodeAgen1.Text)) {
				if (string.IsNullOrEmpty(txtKodeAgen2.Text)) ds = ds.Where(w => w.Agen.Kode.ToLower().Contains(txtKodeAgen1.Text.ToLower())).ToList();
				else ds = ds.Where(w => w.Agen.Kode.ToLower().CompareTo(txtKodeAgen1.Text.ToLower()) >= 0 && w.Agen.Kode.ToLower().CompareTo(txtKodeAgen2.Text.ToLower()) <= 0).ToList();
			}
			if (!string.IsNullOrEmpty(txtNamaAgen.Text)) ds = ds.Where(w => w.Agen.Nama.ToLower().Contains(txtNamaAgen.Text.ToLower())).ToList();
			ds = ds.Where(w => txtRute.Properties.GetItems().GetCheckedValues().Contains(w.Agen.Rute)).ToList();

			var result = new List<LabelExpedisi>();
			int id = 1;
			int JmlKoli, jmlKoranPerKoli;
			int toleransi = setting.ToleransiKoli;

			for (int i = 0; i <= ds.Count - 1; i++) {
				JmlKoli = (int)Math.Ceiling(ds[i].Oplah / (double)(setting.SatuKoliPerEks + toleransi));
				jmlKoranPerKoli = ds[i].Oplah;
				for (int j = 0; j <= JmlKoli - 1; j++) {
					var z = new LabelExpedisi();
					z.AlamatAgen = ds[i].Agen.Alamat;
					z.Gratis = ds[i].GratisOrder;
					z.Id = id;
					id += 1;
					z.Jatah = ds[i].JatahOrder;
					z.JumlahKoli = JmlKoli;
					z.KoliKe = j + 1;
					z.Konsi = ds[i].KonsiOrder;
					z.NamaAgen = ds[i].Agen.Nama;
					z.NoHPAgen = ds[i].Agen.NoHP1;
					z.WilayahKode = ds[i].Agen.Rute.Kode;
					z.WilayahNama = ds[i].Agen.Rute.Nama;
					z.Tanggal = txtTanggal1.DateTime;
					if (JmlKoli == 1 || j == JmlKoli - 1) z.KoranPerKoli = jmlKoranPerKoli;
					else {
						z.KoranPerKoli = setting.SatuKoliPerEks;
						jmlKoranPerKoli -= z.KoranPerKoli;
					}
					result.Add(z);
				}
			}
			_dataSource = result;
		}
		private CriteriaOperator CreateCriteriaPenerimaanPembayaran() {
			var result = new List<CriteriaOperator> {
				new InOperator(nameof(BayarKoran.Agen) + "." + nameof(Agen.Rute), txtRute.Properties.GetItems().GetCheckedValues()),
				new InOperator(nameof(BayarKoran.CaraBayar), txtCaraBayar.Properties.GetItems().GetCheckedValues())
			};

			if (txtTanggal1.EditValue != null) {
				if (txtTanggal2.EditValue == null) result.Add(new BinaryOperator(nameof(BayarKoran.Tanggal), txtTanggal1.DateTime.Date, BinaryOperatorType.Equal));
				else result.Add(new BetweenOperator(nameof(BayarKoran.Tanggal), txtTanggal1.DateTime.Date, txtTanggal2.DateTime.Date));
			}
			if (!string.IsNullOrEmpty(txtKodeAgen1.Text)) {
				if (string.IsNullOrEmpty(txtKodeAgen2.Text)) result.Add(new FunctionOperator(FunctionOperatorType.Contains, new OperandProperty(nameof(BayarKoran.Agen) + "." + nameof(Agen.Kode)), new OperandValue(txtKodeAgen1.Text)));
				else result.Add(new BetweenOperator(nameof(BayarKoran.Agen) + "." + nameof(Agen.Kode), txtKodeAgen1.Text, txtKodeAgen2.Text));
			}
			if (!string.IsNullOrEmpty(txtNamaAgen.Text)) result.Add(new FunctionOperator(FunctionOperatorType.Contains, new OperandProperty(nameof(BayarKoran.Agen) + "." + nameof(Agen.Nama)), new OperandValue(txtNamaAgen.Text)));

			if (result.Count > 0) return GroupOperator.And(result);
			else return null;
		}
	}
}
