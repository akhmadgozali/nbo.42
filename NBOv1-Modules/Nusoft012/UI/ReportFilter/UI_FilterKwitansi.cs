using DevExpress.Data.Filtering;
using DevExpress.Xpo;
using NuSoft.Core.Win.Forms;
using NuSoft.NUI.Win.Forms.Modules.NuSoft012.Persistent;
using NuSoft.NUI.Win.Forms.Modules.NuSoft012.Services;
using System.Collections.Generic;

namespace NuSoft.NUI.Win.Forms.Modules.NuSoft012.UI.ReportFilter {
	public partial class UI_FilterKwitansi : FilterForm {
		private readonly string _kodeLaporan;
		public UI_FilterKwitansi(string KodeLaporan) {
			InitializeComponent();
			_kodeLaporan = KodeLaporan;
			switch (_kodeLaporan) {
				case MainClass.ReportCodeTransaksiKwitansi: Text = "Filter Laporan - Kwitansi"; break;
				case MainClass.ReportCodeTransaksiSuratKomisi: Text = "Filter Laporan - Surat Komisi"; break;
				case MainClass.ReportCodeTransaksiSuratCashback: Text = "Filter Laporan - Surat Cashback"; break;
				case MainClass.ReportCodeTransaksiBuktiPencairanKomisi: Text = "Filter Laporan - Bukti Pencairan Komisi";
					layAtasNama.Text = "Sales";
					break;
				case MainClass.ReportCodeTransaksiBuktiPencairanCashback:
					Text = "Filter Laporan - Bukti Pencairan Cashback";
					layAtasNama.Text = "Pemasang";
					break;
			}
		}

		public override void Filter() {
			var _setting = new NuSoftModSys.LogicLayer.Config(_sesi);
			if (_setting != null) {
				AddParameter("CompanyName", _setting.NamaPerusahaan, typeof(string));
				AddParameter("CompanyAlias", _setting.NamaAlias, typeof(string));
				AddParameter("CompanyAlamat", string.Format("{0} {1}", _setting.Alamat1, _setting.Alamat2), typeof(string));
				AddParameter("CompanyTelp", _setting.NoTelp, typeof(string));
				AddParameter("CompanyFax", _setting.NoFax, typeof(string));
			}

			var _settingIklan = new IklanSetting(_sesi);
			if (_settingIklan != null) {
				AddParameter("TtdNamaKomisiMengajukan", _settingIklan.TtdNamaKomisiMengajukan, typeof(string));
				AddParameter("TtdJabatanKomisiMengajukan", _settingIklan.TtdJabatanKomisiMengajukan, typeof(string));
				AddParameter("TtdNamaKomisiMenyetujui", _settingIklan.TtdNamaKomisiMenyetujui, typeof(string));
				AddParameter("TtdJabatanKomisiMenyetujui", _settingIklan.TtdJabatanKomisiMenyetujui, typeof(string));
				AddParameter("TtdNamaKomisiMengetahui", _settingIklan.TtdNamaKomisiMengetahui, typeof(string));
				AddParameter("TtdJabatanKomisiMengetahui", _settingIklan.TtdJabatanKomisiMengetahui, typeof(string));

				AddParameter("TtdNamaCashbackMengajukan", _settingIklan.TtdNamaCashbackMengajukan, typeof(string));
				AddParameter("TtdJabatanCashbackMengajukan", _settingIklan.TtdJabatanCashbackMengajukan, typeof(string));
				AddParameter("TtdNamaCashbackMenyetujui", _settingIklan.TtdNamaCashbackMenyetujui, typeof(string));
				AddParameter("TtdJabatanCashbackMenyetujui", _settingIklan.TtdJabatanCashbackMenyetujui, typeof(string));
				AddParameter("TtdNamaCashbackMengetahui", _settingIklan.TtdNamaCashbackMengetahui, typeof(string));
				AddParameter("TtdJabatanCashbackMengetahui", _settingIklan.TtdJabatanCashbackMengetahui, typeof(string));
			}

			switch (_kodeLaporan) {
				case MainClass.ReportCodeTransaksiKwitansi:
				case MainClass.ReportCodeTransaksiSuratKomisi:
				case MainClass.ReportCodeTransaksiSuratCashback:
					_dataSource = new XPCollection<PembayaranIklanDetail>(_sesi, CreateCriteriaPembayaran());
					break;
				case MainClass.ReportCodeTransaksiBuktiPencairanKomisi:
					_dataSource = new XPCollection<PencairanKomisi>(_sesi, CreateCriteriaPencairanKomisi());
					break;
				case MainClass.ReportCodeTransaksiBuktiPencairanCashback:
					_dataSource = new XPCollection<PencairanCashback>(_sesi, CreateCriteriaPencairanCashback());
					break;
			}
		}

		private CriteriaOperator CreateCriteriaPembayaran() {
			var result = new List<CriteriaOperator>();

			result.Add(new NullOperator(nameof(PembayaranIklanDetail.Pembayaran) + "." + nameof(PembayaranIklan.BatalBayarId)));
			result.Add(new BinaryOperator(nameof(PembayaranIklanDetail.NominalBayar), 0, BinaryOperatorType.Greater));
			switch (_kodeLaporan) {
				case MainClass.ReportCodeTransaksiSuratKomisi:
					result.Add(new BinaryOperator(nameof(PembayaranIklanDetail.KomisiNominal), 0, BinaryOperatorType.Greater));
					break;
				case MainClass.ReportCodeTransaksiSuratCashback:
					result.Add(new BinaryOperator(nameof(PembayaranIklanDetail.CashbackNominal), 0, BinaryOperatorType.Greater));
					break;
			}

			if (!string.IsNullOrEmpty(txtKwitansi1.Text)) {
				if (string.IsNullOrEmpty(txtKwitansi2.Text)) result.Add(new FunctionOperator(FunctionOperatorType.Contains, new OperandProperty(nameof(PembayaranIklanDetail.Pembayaran) + "." + nameof(PembayaranIklan.NoKwitansi)), new OperandValue(txtKwitansi1.Text)));
				else result.Add(new BetweenOperator(nameof(PembayaranIklanDetail.Pembayaran) + "." + nameof(PembayaranIklan.NoKwitansi), txtKwitansi1.Text, txtKwitansi2.Text));
			}
			if (!string.IsNullOrEmpty(txtTanggal1.Text)) {
				if (string.IsNullOrEmpty(txtTanggal2.Text)) result.Add(new BinaryOperator(nameof(PembayaranIklanDetail.Pembayaran) + "." + nameof(PembayaranIklan.Tanggal), txtTanggal1.DateTime.Date, BinaryOperatorType.Equal));
				else result.Add(new BetweenOperator(nameof(PembayaranIklanDetail.Pembayaran) + "." + nameof(PembayaranIklan.Tanggal), txtTanggal1.DateTime.Date, txtTanggal2.DateTime.Date));
			}
			if (!string.IsNullOrEmpty(txtPemasang.Text)) result.Add(new FunctionOperator(FunctionOperatorType.Contains, new OperandProperty(nameof(PembayaranIklanDetail.Pembayaran) + "." + nameof(PembayaranIklan.AtasNama)), new OperandValue(txtPemasang.Text)));

			if (result.Count > 0) return GroupOperator.And(result);
			else return null;
		}
		private CriteriaOperator CreateCriteriaPencairanKomisi() {
			var result = new List<CriteriaOperator>();

			result.Add(new BinaryOperator(nameof(PencairanKomisi.JumlahPencairan), 0, BinaryOperatorType.Greater));

			if (!string.IsNullOrEmpty(txtKwitansi1.Text)) {
				if (string.IsNullOrEmpty(txtKwitansi2.Text)) result.Add(new FunctionOperator(FunctionOperatorType.Contains, new OperandProperty(nameof(PencairanKomisi.NoBukti)), new OperandValue(txtKwitansi1.Text)));
				else result.Add(new BetweenOperator(nameof(PencairanKomisi.NoBukti), txtKwitansi1.Text, txtKwitansi2.Text));
			}
			if (!string.IsNullOrEmpty(txtTanggal1.Text)) {
				if (string.IsNullOrEmpty(txtTanggal2.Text)) result.Add(new BinaryOperator(nameof(PencairanKomisi.Tanggal), txtTanggal1.DateTime.Date, BinaryOperatorType.Equal));
				else result.Add(new BetweenOperator(nameof(PencairanKomisi.Tanggal), txtTanggal1.DateTime.Date, txtTanggal2.DateTime.Date));
			}
			if (!string.IsNullOrEmpty(txtPemasang.Text)) result.Add(new FunctionOperator(FunctionOperatorType.Contains, new OperandProperty(nameof(PencairanKomisi.Sales) + "." + nameof(Sales.Nama)), new OperandValue(txtPemasang.Text)));

			if (result.Count > 0) return GroupOperator.And(result);
			else return null;
		}
		private CriteriaOperator CreateCriteriaPencairanCashback() {
			var result = new List<CriteriaOperator>();

			result.Add(new BinaryOperator(nameof(PencairanCashback.JumlahPencairan), 0, BinaryOperatorType.Greater));

			if (!string.IsNullOrEmpty(txtKwitansi1.Text)) {
				if (string.IsNullOrEmpty(txtKwitansi2.Text)) result.Add(new FunctionOperator(FunctionOperatorType.Contains, new OperandProperty(nameof(PencairanCashback.NoBukti)), new OperandValue(txtKwitansi1.Text)));
				else result.Add(new BetweenOperator(nameof(PencairanCashback.NoBukti), txtKwitansi1.Text, txtKwitansi2.Text));
			}
			if (!string.IsNullOrEmpty(txtTanggal1.Text)) {
				if (string.IsNullOrEmpty(txtTanggal2.Text)) result.Add(new BinaryOperator(nameof(PencairanCashback.Tanggal), txtTanggal1.DateTime.Date, BinaryOperatorType.Equal));
				else result.Add(new BetweenOperator(nameof(PencairanCashback.Tanggal), txtTanggal1.DateTime.Date, txtTanggal2.DateTime.Date));
			}
			if (!string.IsNullOrEmpty(txtPemasang.Text)) result.Add(new FunctionOperator(FunctionOperatorType.Contains, new OperandProperty(nameof(PencairanCashback.Pemasang)), new OperandValue(txtPemasang.Text)));

			if (result.Count > 0) return GroupOperator.And(result);
			else return null;
		}
	}
}