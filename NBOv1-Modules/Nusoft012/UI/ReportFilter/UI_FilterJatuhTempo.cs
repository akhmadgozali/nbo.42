using DevExpress.Data.Filtering;
using DevExpress.Xpo;
using NuSoft.Core.Win.Forms;
using NuSoft.NUI.Win.Forms.Modules.NuSoft012.Persistent;
using System;
using System.Collections.Generic;

namespace NuSoft.NUI.Win.Forms.Modules.NuSoft012.UI.ReportFilter {
	public partial class UI_FilterJatuhTempo : FilterForm {
		private readonly string _kodeLaporan;
		public UI_FilterJatuhTempo(string KodeLaporan) {
			InitializeComponent();
			_kodeLaporan = KodeLaporan;
			switch (_kodeLaporan) {
				case MainClass.ReportCodePiutangPiutangJatuhTempo: Text = "Filter Laporan - Piutang Jatuh Tempo"; break;
			}
		}

		public override void InitializeData() {
			txtWilayah.Properties.DataSource = new XPCollection<Wilayah>(_sesi);
			txtWilayah.CheckAll();

			switch (_kodeLaporan) {
				case MainClass.ReportCodePiutangPiutangJatuhTempo:
					SetDefaultJatuhTempo(); break;
			}
		}
		private void SetDefaultJatuhTempo() { txtTanggal1.DateTime = DateTime.Now; txtTanggal2.DateTime = DateTime.Now; }

		public override void Filter() {
			try {
				if (txtTanggal1.EditValue == null || txtTanggal2.EditValue == null) throw new Utils.Exception("Masukkan filter tanggal.", -1);
				if (txtWilayah.Properties.GetItems().GetCheckedValues().Count < 1) throw new Utils.Exception("Masukkan filter wilayah.", -2);

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
					case MainClass.ReportCodePiutangPiutangJatuhTempo:
						_dataSource = new XPCollection<Invoice>(_sesi, CreateCriteriaJatuhTempo());
						break;
				}
			}
			catch (Utils.Exception ex) { ex.ShowWinMessageBox(); }
		}
		private CriteriaOperator CreateCriteriaJatuhTempo() {
			var result = new List<CriteriaOperator>();

			result.Add(new BinaryOperator(nameof(Invoice.Piutang), 0, BinaryOperatorType.Greater));

			if (!string.IsNullOrEmpty(txtTanggal1.Text)) {
				if (string.IsNullOrEmpty(txtTanggal2.Text)) result.Add(new BinaryOperator(nameof(Invoice.TanggalJatuhTempo), txtTanggal1.DateTime.Date, BinaryOperatorType.Equal));
				else result.Add(new BetweenOperator(nameof(Invoice.TanggalJatuhTempo), txtTanggal1.DateTime.Date, txtTanggal2.DateTime.Date));
			}
			result.Add(new InOperator(nameof(Invoice.Wilayah), txtWilayah.Properties.GetItems().GetCheckedValues()));

			if (result.Count > 0) return GroupOperator.And(result);
			else return null;
		}
	}
}