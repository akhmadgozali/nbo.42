using DevExpress.Data.Filtering;
using DevExpress.Xpo;
using NuSoft.Core.Win.Forms;
using NuSoft.NUI.Win.Forms.Modules.NuSoft012.Services;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace NuSoft.NUI.Win.Forms.Modules.NuSoft012.UI.ReportFilter {
	public partial class UI_FilterKonfirmasiPiutang : FilterForm {
		private readonly string _kodeLaporan;
		public UI_FilterKonfirmasiPiutang(string KodeLaporan) {
			InitializeComponent();
			_kodeLaporan = KodeLaporan;
			switch (_kodeLaporan) {
				case MainClass.ReportCodePiutangKonfirmasiPiutang: Text = "Filter Laporan - Konfirmasi Piutang"; break;
			}
		}

		public override void InitializeData() {
			switch (_kodeLaporan) {
				case MainClass.ReportCodePiutangKonfirmasiPiutang: SetDefaultKonfirmasi(); break;
			}
		}
		private void SetDefaultKonfirmasi() {
			txtPerTanggal.DateTime = DateTime.Now;
			txtTampilkan.EditValue = 2;
			txtStatus.EditValue = 2;
		}

		public override void Filter() {
			try {
				if (txtPerTanggal.EditValue == null) throw new Utils.Exception("Masukkan filter per tanggal", -1);

				var _setting = new NuSoftModSys.LogicLayer.Config(_sesi);
				if (_setting != null) {
					AddParameter("CompanyName", _setting.NamaPerusahaan, typeof(string));
					AddParameter("CompanyAlias", _setting.NamaAlias, typeof(string));
					AddParameter("CompanyAlamat", string.Format("{0} {1}", _setting.Alamat1, _setting.Alamat2), typeof(string));
					AddParameter("CompanyTelp", _setting.NoTelp, typeof(string));
					AddParameter("CompanyFax", _setting.NoFax, typeof(string));
				}

				var _settingIklan = new IklanSetting(_sesi);
				switch (_kodeLaporan) {
					case MainClass.ReportCodePiutangKonfirmasiPiutang:
						AddParameter("KomisiMengajukanNama", _settingIklan.TtdNamaKomisiMengajukan, typeof(string));
						AddParameter("KomisiMengajukanJabatan", _settingIklan.TtdJabatanKomisiMengajukan, typeof(string));
						AddParameter("KomisiMenyetujuiNama", _settingIklan.TtdNamaKomisiMenyetujui, typeof(string));
						AddParameter("KomisiMenyetujuiJabatan", _settingIklan.TtdJabatanKomisiMenyetujui, typeof(string));
						AddParameter("KomisiMengetahuiNama", _settingIklan.TtdNamaKomisiMengetahui, typeof(string));
						AddParameter("KomisiMengetahuiJabatan", _settingIklan.TtdJabatanKomisiMengetahui, typeof(string));
						AddParameter("Tampilkan", txtTampilkan.EditValue, typeof(int));
						AddParameter("PerTanggal", txtPerTanggal.DateTime, typeof(int));

						//var data = new XPCollection<ViewPiutangPerTanggal>(Session, CreateCriteriaKonfirmasiPiutang()).ToList();
						//var allDs = data.GroupBy(g => g.NoInvoice).Select(s => new {
						//	Regional = s.Min(m => m.Regional),
						//	NoInvoice = s.Key,
						//	Tanggal = s.Min(m => m.Tanggal),
						//	Pemasang = s.Min(m => m.Pemasang),
						//	Sales = s.Min(m => m.Sales),
						//	SalesId = s.Min(m => m.SalesId).ToString("0000"),
						//	Judul = s.Min(m => m.Judul),
						//	Omzet = s.Sum(m => m.Omzet),
						//	Terbayar = s.Sum(m => m.Terbayar),
						//	Piutang = s.Sum(m => m.Piutang)
						//}).ToList();

						var dataPiutang = PiutangServices.GetRincianPiutang(_sesi, txtPerTanggal.DateTime.Date, false, true);
						if (!string.IsNullOrEmpty(txtNama.Text)) {
							if ((int)txtTampilkan.EditValue == 1)
								dataPiutang = dataPiutang.Where(w => w.Pemasang.Contains(txtNama.Text)).ToList();
							else
								dataPiutang = dataPiutang.Where(w => w.Sales.Contains(txtNama.Text)).ToList();
						}
						if (!string.IsNullOrEmpty(txtWilayah.Text))
							dataPiutang = dataPiutang.Where(w => w.Wilayah.Contains(txtWilayah.Text)).ToList();

						if ((int)txtStatus.EditValue == 1) _dataSource = dataPiutang.Where(w => w.Piutang == 0).ToList();
						else if ((int)txtStatus.EditValue == 2) _dataSource = dataPiutang.Where(w => w.Piutang != 0).ToList();
						else _dataSource = dataPiutang;
						break;
				}
			}
			catch (Utils.Exception ex) { ex.ShowWinMessageBox(); }
		}

		//private CriteriaOperator CreateCriteriaKonfirmasiPiutang() {
		//	var result = new List<CriteriaOperator>();

		//	if (!string.IsNullOrEmpty(txtNama.Text)) {
		//		if ((int)txtTampilkan.EditValue == 1)
		//			result.Add(new FunctionOperator(FunctionOperatorType.Contains, new OperandProperty(nameof(ViewPiutangPerTanggal.Pemasang)), new OperandValue(txtNama.Text)));
		//		else
		//			result.Add(new FunctionOperator(FunctionOperatorType.Contains, new OperandProperty(nameof(ViewPiutangPerTanggal.Sales)), new OperandValue(txtNama.Text)));
		//	}
		//	if (!string.IsNullOrEmpty(txtWilayah.Text)) result.Add(new FunctionOperator(FunctionOperatorType.Contains, new OperandProperty(nameof(ViewPiutangPerTanggal.Wilayah)), new OperandValue(txtWilayah.Text)));

		//	if (result.Count > 0) return GroupOperator.And(result);
		//	else return null;
		//}
	}
}