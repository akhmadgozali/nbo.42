using DevExpress.Data.Filtering;
using DevExpress.Xpo;
using NuSoft.Core.Win.Forms;
using NuSoft.NUI.Win.Forms.Modules.NuSoft011.Persistent;
using NuSoft.NUI.Win.Forms.Modules.NuSoft011.Services;
using System.Collections.Generic;
using System.Drawing;
using static NuSoft.NUI.Win.Forms.Modules.NuSoft011.MainClass;

namespace NuSoft.NUI.Win.Forms.Modules.NuSoft011.UI.ReportFilter {
	internal partial class UI_FilterPembayaranAgen : FilterForm {
		private readonly ReportName _kodeLaporan;
		public UI_FilterPembayaranAgen(ReportName KodeLaporan) {
			InitializeComponent();
			_kodeLaporan = KodeLaporan;
			switch (_kodeLaporan) {
				case ReportName.AgenKwitansi: Text = "Filter Laporan - Kwitansi Agen"; break;
			}
		}

		public override void Filter() {
			var setting = new NuSoftModSys.LogicLayer.Config(_sesi);
			if (setting != null) {
				AddParameter("CompanyName", setting.NamaPerusahaan, typeof(string));
				AddParameter("CompanyAlias", setting.NamaAlias, typeof(string));
				AddParameter("CompanyAlamat", string.Format("{0} {1}", setting.Alamat1, setting.Alamat2), typeof(string));
				AddParameter("CompanyTelp", setting.NoTelp, typeof(string));
				AddParameter("CompanyFax", setting.NoFax, typeof(string));
			}
			var settingSirkulasi = new SirkulasiSetting(_sesi);
			switch (_kodeLaporan) {
				case ReportName.AgenKwitansi:
					AddParameter("NamaTTd", settingSirkulasi.TagihanTTdNama, typeof(string));
					AddParameter("JabatanTTd", settingSirkulasi.TagihanTTdJabatan, typeof(string));
					AddParameter("Rekening", settingSirkulasi.TagihanRekeningBank, typeof(string));
					_dataSource = new XPCollection<BayarKoran>(_sesi, CreateCriteriaKwitansiAgen());
					break;
			}
		}
		private CriteriaOperator CreateCriteriaKwitansiAgen() {
			var result = new List<CriteriaOperator>();

			result.Add(new NullOperator(nameof(BayarKoran.BatalBayarId)));
			if (!string.IsNullOrEmpty(txtNoKwitansi.Text)) result.Add(new FunctionOperator(FunctionOperatorType.Contains, new OperandProperty(nameof(BayarKoran.Kode)), new OperandValue(txtNoKwitansi.Text)));
			if (txtTanggal1.EditValue != null) {
				if (txtTanggal2.EditValue == null) result.Add(new BinaryOperator(nameof(BayarKoran.Tanggal), txtTanggal1.DateTime.Date, BinaryOperatorType.Equal));
				else result.Add(new BetweenOperator(nameof(BayarKoran.Tanggal), txtTanggal1.DateTime.Date, txtTanggal2.DateTime.Date));
			}
			if (!string.IsNullOrEmpty(txtKodeAgen1.Text)) {
				if (string.IsNullOrEmpty(txtKodeAgen2.Text)) result.Add(new FunctionOperator(FunctionOperatorType.Contains, new OperandProperty(nameof(BayarKoran.Agen) + "." + nameof(Agen.Kode)), new OperandValue(txtKodeAgen1.Text)));
				else result.Add(new BetweenOperator(nameof(BayarKoran.Agen) + "." + nameof(Agen.Kode), txtKodeAgen1.Text, txtKodeAgen2.Text));
			}
			if (!string.IsNullOrEmpty(txtNamaAgen.Text)) result.Add(new FunctionOperator(FunctionOperatorType.Contains, new OperandProperty(nameof(BayarKoran.Agen) + "." + nameof(Agen.Nama)), new OperandValue(txtNamaAgen.Text)));
			if (!string.IsNullOrEmpty(txtKeterangan.Text)) result.Add(new FunctionOperator(FunctionOperatorType.Contains, new OperandProperty(nameof(BayarKoran.Keterangan)), new OperandValue(txtKeterangan.Text)));

			if (result.Count > 0) return GroupOperator.And(result);
			else return null;
		}
	}
}
