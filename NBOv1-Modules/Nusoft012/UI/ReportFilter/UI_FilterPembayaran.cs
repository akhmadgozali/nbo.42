using DevExpress.Data.Filtering;
using DevExpress.Xpo;
using NuSoft.Core.Win.Forms;
using NuSoft.NPO.Modules.ModSys;
using NuSoft.NUI.Win.Forms.Modules.NuSoft012.Persistent;
using System;
using System.Collections.Generic;
using System.Linq;

namespace NuSoft.NUI.Win.Forms.Modules.NuSoft012.UI.ReportFilter {
	public partial class UI_FilterPembayaran : FilterForm {
		private readonly string _kodeLaporan;
		public UI_FilterPembayaran(string KodeLaporan) {
			InitializeComponent();
			_kodeLaporan = KodeLaporan;
			switch (_kodeLaporan) {
				case MainClass.ReportCodePiutangPenerimaanPembayaran: Text = "Filter Laporan - Penerimaan Pembayaran"; break;
				case MainClass.ReportCodePiutangRincianPembayaran: Text = "Filter Laporan - Rincian Pembayaran"; break;
			}
		}

		public override void InitializeData() {
			txtRegional.Properties.DataSource = new XPCollection<Regional>(_sesi);
			txtCaraBayar.Properties.DataSource = new XPQuery<CaraBayar>(_sesi).Where(w => w.Aktif).ToList();

			txtRegional.CheckAll();
			txtCaraBayar.CheckAll();

			switch (_kodeLaporan) {
				case MainClass.ReportCodePiutangPenerimaanPembayaran:
				case MainClass.ReportCodePiutangRincianPembayaran:
					SetDefaultPembayaran(); break;
			}
		}
		private void SetDefaultPembayaran() { txtTanggal1.DateTime = DateTime.Now; txtTanggal2.DateTime = DateTime.Now; }

		public override void Filter() {
			try {
				if (txtTanggal1.EditValue == null || txtTanggal2.EditValue == null) throw new Utils.Exception("Masukkan filter tanggal.", -1);
				if (txtRegional.Properties.GetItems().GetCheckedValues().Count < 1) throw new Utils.Exception("Masukkan filter regional.", -2);
				if (txtCaraBayar.Properties.GetItems().GetCheckedValues().Count < 1) throw new Utils.Exception("Masukkan filter cara bayar.", -3);

				var _setting = new NuSoftModSys.LogicLayer.Config(_sesi);
				if (_setting != null) {
					AddParameter("CompanyName", _setting.NamaPerusahaan, typeof(string));
					AddParameter("CompanyAlias", _setting.NamaAlias, typeof(string));
					AddParameter("CompanyAlamat", string.Format("{0} {1}", _setting.Alamat1, _setting.Alamat2), typeof(string));
					AddParameter("CompanyTelp", _setting.NoTelp, typeof(string));
					AddParameter("CompanyFax", _setting.NoFax, typeof(string));
				}
				AddParameter("Tanggal1", txtTanggal1.DateTime, typeof(DateTime));
				AddParameter("Tanggal2", txtTanggal2.DateTime, typeof(DateTime));

				switch (_kodeLaporan) {
					case MainClass.ReportCodePiutangPenerimaanPembayaran:
						_dataSource = new XPCollection<PembayaranIklan>(_sesi, CreateCriteriaPembayaran());
						break;
					case MainClass.ReportCodePiutangRincianPembayaran:
						_dataSource = new XPCollection<PembayaranIklanDetail>(_sesi, CreateCriteriaPembayaranDetail());
						break;
				}
			}
			catch (Utils.Exception ex) { ex.ShowWinMessageBox(); }
		}
		private CriteriaOperator CreateCriteriaPembayaran() {
			var result = new List<CriteriaOperator>();

			result.Add(new NullOperator(nameof(PembayaranIklan.BatalBayarId)));
			result.Add(new BinaryOperator(nameof(PembayaranIklan.JumlahBayar), 0, BinaryOperatorType.Greater));

			if (!string.IsNullOrEmpty(txtTanggal1.Text)) {
				if (string.IsNullOrEmpty(txtTanggal2.Text)) result.Add(new BinaryOperator(nameof(PembayaranIklan.Tanggal), txtTanggal1.DateTime.Date, BinaryOperatorType.Equal));
				else result.Add(new BetweenOperator(nameof(PembayaranIklan.Tanggal), txtTanggal1.DateTime.Date, txtTanggal2.DateTime.Date));
			}
			result.Add(new InOperator(nameof(PembayaranIklan.Regional), txtRegional.Properties.GetItems().GetCheckedValues()));
			result.Add(new InOperator(nameof(PembayaranIklan.CaraBayar), txtCaraBayar.Properties.GetItems().GetCheckedValues()));

			if (result.Count > 0) return GroupOperator.And(result);
			else return null;
		}
		private CriteriaOperator CreateCriteriaPembayaranDetail() {
			var result = new List<CriteriaOperator>();

			result.Add(new NullOperator(nameof(PembayaranIklanDetail.Pembayaran) + "." + nameof(PembayaranIklan.BatalBayarId)));
			result.Add(new BinaryOperator(nameof(PembayaranIklanDetail.Pembayaran) + "." + nameof(PembayaranIklan.JumlahBayar), 0, BinaryOperatorType.Greater));

			if (!string.IsNullOrEmpty(txtTanggal1.Text)) {
				if (string.IsNullOrEmpty(txtTanggal2.Text)) result.Add(new BinaryOperator(nameof(PembayaranIklanDetail.Pembayaran) + "." + nameof(PembayaranIklan.Tanggal), txtTanggal1.DateTime.Date, BinaryOperatorType.Equal));
				else result.Add(new BetweenOperator(nameof(PembayaranIklanDetail.Pembayaran) + "." + nameof(PembayaranIklan.Tanggal), txtTanggal1.DateTime.Date, txtTanggal2.DateTime.Date));
			}
			result.Add(new InOperator(nameof(PembayaranIklanDetail.Pembayaran) + "." + nameof(PembayaranIklan.Regional), txtRegional.Properties.GetItems().GetCheckedValues()));
			result.Add(new InOperator(nameof(PembayaranIklanDetail.Pembayaran) + "." + nameof(PembayaranIklan.CaraBayar), txtCaraBayar.Properties.GetItems().GetCheckedValues()));

			if (result.Count > 0) return GroupOperator.And(result);
			else return null;
		}
	}
}