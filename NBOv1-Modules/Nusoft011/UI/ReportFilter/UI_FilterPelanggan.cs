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
	internal partial class UI_FilterPelanggan : FilterForm {
		private readonly ReportName _kodeLaporan;
		public UI_FilterPelanggan(ReportName KodeLaporan) {
			InitializeComponent();
			_kodeLaporan = KodeLaporan;
			switch (_kodeLaporan) {
				case ReportName.PelangganKwitansi: Text = "Filter Laporan - Kwitansi Pelanggan"; break;
				case ReportName.PelangganDaftar: Text = "Filter Laporan - Daftar Pelanggan"; break;
			}
		}

		public override void InitializeData() {
			txtPeriodeBulan.Properties.Items.Clear();
			for (int i = 1; i <= 12; i++) {
				txtPeriodeBulan.Properties.Items.Add(new DateTime(DateTime.Now.Year, i, 1).ToString("MMMM"));
			}
			txtPeriodeTahun.Properties.MaxValue = DateTime.Now.Year + 10;
			txtPeriodeBulan.SelectedIndex = DateTime.Now.Month - 1;
			txtPeriodeTahun.EditValue = DateTime.Now.Year;

			switch (_kodeLaporan) {
				case ReportName.PelangganKwitansi:
					//layStatus.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
					//this.Height = this.Height - layStatus.Height + 1;
					txtPerTanggal.DateTime = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
					break;
				case ReportName.PelangganDaftar:
					layPerTanggal.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
					this.Height = this.Height - layPerTanggal.Height + 1;
					break;
			}
		}

		public override void Filter() {
			var periode = new DateTime((int)txtPeriodeTahun.Value, txtPeriodeBulan.SelectedIndex + 1, DateTime.DaysInMonth((int)txtPeriodeTahun.Value, txtPeriodeBulan.SelectedIndex + 1));
			var periodeLalu = new DateTime(periode.AddMonths(-1).Year, periode.AddMonths(-1).Month, DateTime.DaysInMonth(periode.AddMonths(-1).Year, periode.AddMonths(-1).Month));
			AddParameter("Periode", periode, typeof(DateTime));
			var setting = new NuSoftModSys.LogicLayer.Config(_sesi);
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
				case ReportName.PelangganKwitansi:
					if (txtPerTanggal.EditValue == null) throw new Utils.Exception("Masukkan per tanggal.", -1);
					AddParameter("PerTanggal", txtPerTanggal.DateTime, typeof(DateTime));
					break;
				case ReportName.PelangganDaftar:
					break;
			}

			var sirkulasiSetting = new SirkulasiSetting(_sesi);
			var data = new XPCollection<PelangganHistory>(_sesi, CreateCriteriaKwitansiPelanggan(periode, sirkulasiSetting)).ToList();
			//if (txtTglLangganan.Value > 0)
			//	data = data.Where(w => w.Pelanggan.TanggalMulaiLangganan.Day == txtTglLangganan.Value).ToList();
			var dataLalu = data.Where(w => w.Tanggal.Date <= periodeLalu).GroupBy(g => g.Pelanggan).Select(s => new { Pelanggan = s.Key, JmlExp = s.Sum(d => d.JumlahExpAktif - d.JumlahExpNonAktif), TglMasuk = s.Min(d => d.Tanggal) }).ToList();
			var dataIni = data.Where(w => w.Tanggal.Month == periode.Month && w.Tanggal.Year == periode.Year).ToList();
			var result = new List<PelangganForReport>();

			switch (_kodeLaporan) {
				case ReportName.PelangganKwitansi:
				case ReportName.PelangganDaftar:
					dataIni = new List<PelangganHistory>();
					dataLalu = data.GroupBy(g => g.Pelanggan).Select(s => new { Pelanggan = s.Key, JmlExp = s.Sum(d => d.JumlahExpAktif - d.JumlahExpNonAktif), TglMasuk = s.Min(d => d.Tanggal) }).ToList();
					break;
			}

			foreach (var d in dataLalu) {
				switch ((short)txtStatus.EditValue) {
					case 1: if (d.JmlExp <= 0) continue; break;
					case 2: if (d.JmlExp > 0) continue; break;
				}

				result.Add(new PelangganForReport() {
					KategoriPelanggan = string.Empty,
					Tanggal = d.TglMasuk, // periode.AddMonths(-1),
					Pelanggan = d.Pelanggan,
					Aktif = true,
					Harga = d.Pelanggan.HargaLangganan,
					JumlahExp = d.JmlExp
				});
			}
			foreach (var d in dataIni) {
				var selisihHari = d.Aktif ? DateTime.DaysInMonth(d.Tanggal.Year, d.Tanggal.Month) - d.Tanggal.Day + 1 : d.Tanggal.Day;
				//var pembagi = 1; // sirkulasiSetting.HargaHarianPelangganDibagi30 ? 30 : DateTime.DaysInMonth(d.Tanggal.Year, d.Tanggal.Month);
				result.Add(new PelangganForReport() {
					KategoriPelanggan = d.Aktif ? "LANGGANAN BARU" : "STOP LANGGANAN",
					Tanggal = d.Tanggal,
					Pelanggan = d.Pelanggan,
					Aktif = d.Aktif,
					JumlahExp = d.JumlahExp,
					Harga = d.Pelanggan.HargaLangganan //sirkulasiSetting.HargaPelangganProporsional ? (d.Pelanggan.HargaPelanggan / pembagi) * selisihHari : d.Pelanggan.HargaPelanggan
				});
				if (!d.Aktif) {
					var find = result.Find(f => f.Pelanggan == d.Pelanggan && f.KategoriPelanggan == string.Empty);
					if (find != null) find.Harga = 0;
				}
			}

			switch (_kodeLaporan) {
				case ReportName.PelangganKwitansi:
					//_dataSource = new XPCollection<Pelanggan>(Session, CreateCriteriaKwitansiPelanggan());
					_dataSource = result.GroupBy(g => g.Pelanggan).Select(s => new {
						Pelanggan = s.Key,
						Harga = s.Sum(d => d.Harga * d.JumlahExp),
						Terbilang = Utils.Common.Character.Terbilang((double)(s.Sum(d => d.Harga * d.JumlahExp)), "Rupiah")
					}).OrderBy(o => o.Pelanggan.Kode).ToList();
					break;
				default:
					_dataSource = result.OrderBy(o => o.Pelanggan.Kode).ToList();
					break;
			}
		}

		private CriteriaOperator CreateCriteriaKwitansiPelanggan(DateTime periode, SirkulasiSetting setting) {
			var result = new List<CriteriaOperator>();
			
			if (!string.IsNullOrEmpty(txtKodeAgen1.Text)) {
				if (string.IsNullOrEmpty(txtKodeAgen2.Text)) result.Add(new FunctionOperator(FunctionOperatorType.Contains, new OperandProperty(nameof(PelangganHistory.Pelanggan) + "." + nameof(Pelanggan.Agen) + "." + nameof(Agen.KodePelanggan)), new OperandValue(txtKodeAgen1.Text)));
				else result.Add(new BetweenOperator(nameof(PelangganHistory.Pelanggan) + "." + nameof(Pelanggan.Agen) + "." + nameof(Agen.KodePelanggan), txtKodeAgen1.Text, txtKodeAgen2.Text));
			}
			if (!string.IsNullOrEmpty(txtNamaAgen.Text)) result.Add(new FunctionOperator(FunctionOperatorType.Contains, new OperandProperty(nameof(PelangganHistory.Pelanggan) + "." + nameof(Pelanggan.Agen) + "." + nameof(Agen.Nama)), new OperandValue(txtNamaAgen.Text)));
			if (!string.IsNullOrEmpty(txtKodePelanggan1.Text)) {
				if (string.IsNullOrEmpty(txtKodePelanggan2.Text)) result.Add(new FunctionOperator(FunctionOperatorType.Contains, new OperandProperty(nameof(PelangganHistory.Pelanggan) + "." + nameof(Pelanggan.Kode)), new OperandValue(txtKodePelanggan1.Text)));
				else result.Add(new BetweenOperator(nameof(PelangganHistory.Pelanggan) + "." + nameof(Pelanggan.Kode), txtKodePelanggan1.Text, txtKodePelanggan2.Text));
			}
			if (!string.IsNullOrEmpty(txtNamaPelanggan.Text)) result.Add(new FunctionOperator(FunctionOperatorType.Contains, new OperandProperty(nameof(PelangganHistory.Pelanggan) + "." + nameof(Pelanggan.Nama)), new OperandValue(txtNamaPelanggan.Text)));
			if (!string.IsNullOrEmpty(txtWilayah.Text)) result.Add(new FunctionOperator(FunctionOperatorType.Contains, new OperandProperty(nameof(PelangganHistory.Pelanggan) + "." + nameof(Pelanggan.Agen) + "." + nameof(Agen.Rute) + "." + nameof(Rute.Nama)), new OperandValue(txtWilayah.Text)));
			if (!string.IsNullOrEmpty(txtKeterangan.Text)) result.Add(new FunctionOperator(FunctionOperatorType.Contains, new OperandProperty(nameof(PelangganHistory.Pelanggan) + "." + nameof(Pelanggan.Keterangan)), new OperandValue(txtKeterangan.Text)));

			if (result.Count > 0) return GroupOperator.And(result);
			else return null;
		}
	}
}