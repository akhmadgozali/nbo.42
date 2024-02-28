using DevExpress.Data.Filtering;
using DevExpress.Xpo;
using NuSoft.Core.Win.Forms;
using NuSoft.NUI.Win.Forms.Modules.NuSoft012.Persistent;
using System;
using System.Collections.Generic;
using System.Linq;

namespace NuSoft.NUI.Win.Forms.Modules.NuSoft012.UI.ReportFilter {
	public partial class UI_FilterRegister : FilterForm {
		private readonly string _kodeLaporan;
		public UI_FilterRegister(string KodeLaporan) {
			InitializeComponent();
			_kodeLaporan = KodeLaporan;
			switch (_kodeLaporan) {
				case MainClass.ReportCodePiutangIklanTermuatDeret: Text = "Filter Laporan - Register Iklan Deret"; break;
				case MainClass.ReportCodePiutangIklanTermuatKolom: Text = "Filter Laporan - Register Iklan Kolom"; break;
			}
		}

		public override void InitializeData() {
			txtWilayah.Properties.DataSource = new XPCollection<Wilayah>(_sesi);

			switch (_kodeLaporan) {
				case MainClass.ReportCodePiutangIklanTermuatDeret:
					txtJenisIklan.Properties.DataSource = new XPQuery<TipeInvoice>(_sesi).Where(w => w.TipeIklan == ETipeIklan.Deret).ToList();
					SetDefaultTanggal(); break;
				case MainClass.ReportCodePiutangIklanTermuatKolom:
					txtJenisIklan.Properties.DataSource = new XPQuery<TipeInvoice>(_sesi).Where(w => w.TipeIklan == ETipeIklan.Kolom).ToList();
					SetDefaultTanggal(); break;
			}

			txtWilayah.CheckAll();
			txtJenisIklan.CheckAll();
		}
		private void SetDefaultTanggal() { txtTanggal1.DateTime = DateTime.Now; }

		public override void Filter() {
			try {
				if (txtTanggal1.EditValue == null) throw new Utils.Exception("Masukkan filter tanggal", -1);
				if (txtWilayah.Properties.GetItems().GetCheckedValues().Count < 1) throw new Utils.Exception("Masukkan filter wilayah.", -2);
				if (txtJenisIklan.Properties.GetItems().GetCheckedValues().Count < 1) throw new Utils.Exception("Masukkan filter jenis iklan.", -3);

				var _setting = new NuSoftModSys.LogicLayer.Config(_sesi);
				if (_setting != null) {
					AddParameter("CompanyName", _setting.NamaPerusahaan, typeof(string));
					AddParameter("CompanyAlias", _setting.NamaAlias, typeof(string));
					AddParameter("CompanyAlamat", string.Format("{0} {1}", _setting.Alamat1, _setting.Alamat2), typeof(string));
					AddParameter("CompanyTelp", _setting.NoTelp, typeof(string));
					AddParameter("CompanyFax", _setting.NoFax, typeof(string));
				}
				AddParameter("Tanggal1", txtTanggal1.DateTime, typeof(DateTime));

				switch (_kodeLaporan) {
					case MainClass.ReportCodePiutangIklanTermuatDeret:
					case MainClass.ReportCodePiutangIklanTermuatKolom:
						_dataSource = new XPCollection<InvoiceTerbit>(_sesi, CreateCriteriaRegister());
						break;
				}
			}
			catch (Utils.Exception ex) { ex.ShowWinMessageBox(); }
		}
		private CriteriaOperator CreateCriteriaRegister() {
			var result = new List<CriteriaOperator>();

			result.Add(new BinaryOperator(nameof(InvoiceTerbit.Aktif), true));
			result.Add(new BinaryOperator(nameof(InvoiceTerbit.TanggalTerbit), txtTanggal1.DateTime.Date, BinaryOperatorType.Equal));
			result.Add(new InOperator(nameof(InvoiceTerbit.Invoice) + "." + nameof(Invoice.TipeInvoice), txtJenisIklan.Properties.GetItems().GetCheckedValues()));
			result.Add(new InOperator(nameof(InvoiceTerbit.Invoice) + "." + nameof(Invoice.Wilayah), txtWilayah.Properties.GetItems().GetCheckedValues()));

			if (!string.IsNullOrEmpty(txtProduk.Text)) result.Add(new FunctionOperator(FunctionOperatorType.Contains, new OperandProperty(nameof(InvoiceTerbit.Invoice) + "." + nameof(Invoice.Merk) + "." + nameof(Merk.Produk) + "." + nameof(Produk.Nama)), new OperandValue(txtProduk.Text)));
			if (!string.IsNullOrEmpty(txtMerk.Text)) result.Add(new FunctionOperator(FunctionOperatorType.Contains, new OperandProperty(nameof(InvoiceTerbit.Invoice) + "." + nameof(Invoice.Merk) + "." + nameof(Merk.Nama)), new OperandValue(txtMerk.Text)));

			if (result.Count > 0) return GroupOperator.And(result);
			else return null;
		}
	}
}