using DevExpress.Data.Filtering;
using DevExpress.Xpo;
using NuSoft.Core.Win.Forms;
using NuSoft.NUI.Win.Forms.Modules.NuSoft012.Persistent;
using System.Collections.Generic;
using static NuSoft.NUI.Win.Forms.Modules.NuSoft012.MainClass;

namespace NuSoft.NUI.Win.Forms.Modules.NuSoft012.UI.ReportFilter {
	internal partial class UI_FilterInvoice : FilterForm {
		private readonly string _kodeLaporan;

		public UI_FilterInvoice(string KodeLaporan) {
			InitializeComponent();
			_kodeLaporan = KodeLaporan;
			switch (_kodeLaporan) {
				case ReportCodeTransaksiInvoiceKolom: Text = "Filter Laporan - Invoice Kolom"; break;
				case ReportCodeTransaksiInvoiceDeret: Text = "Filter Laporan - Invoice Deret"; break;
				case ReportCodeTransaksiInvoiceGabungan: Text = "Filter Laporan - Invoice Gabungan"; break;
				case ReportCodeTransaksiOrderIklan: Text = "Filter Laporan - Order Iklan"; break;
				case ReportCodeTransaksiTandaTerima: Text = "Filter Laporan - Tanda Terima"; break;
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

			var _settingPajak = new NuSoft007.Services.TaxSetting(_sesi);
			if (_settingPajak != null) {
				AddParameter("CompanyNPWP", _settingPajak.PerusahaanNPWP, typeof(string));
			}

			switch (_kodeLaporan) {
				case ReportCodeTransaksiInvoiceKolom:
				case ReportCodeTransaksiInvoiceDeret:
				case ReportCodeTransaksiInvoiceGabungan:
				case ReportCodeTransaksiOrderIklan:
				case ReportCodeTransaksiTandaTerima:
					_dataSource = new XPCollection<Invoice>(_sesi, CreateCriteriaInvoice());
					break;
			}
		}
		private CriteriaOperator CreateCriteriaInvoice() {
			var result = new List<CriteriaOperator>();

			result.Add(new BinaryOperator(nameof(Invoice.SaldoAwal), false));
			result.Add(new NullOperator(nameof(Invoice.IndukInvoice)));
			result.Add(new NullOperator(nameof(Invoice.KoreksiInvoice)));
			switch (_kodeLaporan) {
				case ReportCodeTransaksiInvoiceKolom:
					result.Add(new BinaryOperator(nameof(Invoice.TipeInvoice) + "." + nameof(TipeInvoice.TipeIklan), ETipeIklan.Kolom, BinaryOperatorType.Equal));
					result.Add(new BinaryOperator(nameof(Invoice.DaftarAnakCount), 0, BinaryOperatorType.Equal));
					break;
				case ReportCodeTransaksiInvoiceDeret:
					result.Add(new BinaryOperator(nameof(Invoice.TipeInvoice) + "." + nameof(TipeInvoice.TipeIklan), ETipeIklan.Deret, BinaryOperatorType.Equal));
					result.Add(new BinaryOperator(nameof(Invoice.DaftarAnakCount), 0, BinaryOperatorType.Equal));
					break;
				case ReportCodeTransaksiInvoiceGabungan:
					result.Add(new BinaryOperator(nameof(Invoice.DaftarAnakCount), 0, BinaryOperatorType.Greater));
					break;
			}

			if (!string.IsNullOrEmpty(txtInvoice1.Text)) {
				if (string.IsNullOrEmpty(txtInvoice2.Text)) result.Add(new FunctionOperator(FunctionOperatorType.Contains, new OperandProperty(nameof(Invoice.NoInvoice)), new OperandValue(txtInvoice1.Text)));
				else result.Add(new BetweenOperator(nameof(Invoice.NoInvoice), txtInvoice1.Text, txtInvoice2.Text));
			}
			if (!string.IsNullOrEmpty(txtOrder1.Text)) {
				if (string.IsNullOrEmpty(txtOrder2.Text)) result.Add(new FunctionOperator(FunctionOperatorType.Contains, new OperandProperty(nameof(Invoice.NoOrder)), new OperandValue(txtOrder1.Text)));
				else result.Add(new BetweenOperator(nameof(Invoice.NoOrder), txtOrder1.Text, txtOrder2.Text));
			}
			if (!string.IsNullOrEmpty(txtTanggal1.Text)) {
				if (string.IsNullOrEmpty(txtTanggal2.Text)) result.Add(new BinaryOperator(nameof(Invoice.TanggalOmzet), txtTanggal1.DateTime.Date, BinaryOperatorType.Equal));
				else result.Add(new BetweenOperator(nameof(Invoice.TanggalOmzet), txtTanggal1.DateTime.Date, txtTanggal2.DateTime.Date));
			}
			if (!string.IsNullOrEmpty(txtWilayah.Text)) result.Add(new FunctionOperator(FunctionOperatorType.Contains, new OperandProperty(nameof(Invoice.Wilayah) + "." + nameof(Wilayah.Nama)), new OperandValue(txtWilayah.Text)));
			if (!string.IsNullOrEmpty(txtSales.Text)) result.Add(new FunctionOperator(FunctionOperatorType.Contains, new OperandProperty(nameof(Invoice.Sales) + "." + nameof(Sales.Nama)), new OperandValue(txtSales.Text)));
			if (!string.IsNullOrEmpty(txtPemasang.Text)) result.Add(new FunctionOperator(FunctionOperatorType.Contains, new OperandProperty(nameof(Invoice.InvoiceNama)), new OperandValue(txtPemasang.Text)));

			if (result.Count > 0) return GroupOperator.And(result);
			else return null;
		}
	}
}