using DevExpress.XtraEditors.Controls;
using NuSoft.Core.Win.Forms;
using NuSoft.NUI.Win.Forms.Modules.NuSoft011.Services;

namespace NuSoft.NUI.Win.Forms.Modules.NuSoft011.UI.Konfigurasi {
	public partial class UI_SettingSirkulasi : DialogForm {
		public UI_SettingSirkulasi() {
			InitializeComponent();
			txtPembayaranFormatNomor.EditValueChanging += new ChangingEventHandler(FormatNomorChanging);
			AutoCloseOnSave = true;
		}

		private SirkulasiSetting item;

		private void FormatNomorChanging(object sender, ChangingEventArgs e) {
			txtPembayaranFormatNomorJml.Text = NomorService.HitungPanjangFormatNomor(e.NewValue.ToString()).ToString(); // number.FormatCount(e.NewValue.ToString()).ToString();
		}

		public override void InitializeData() {
			GetSession();
			item = new SirkulasiSetting(session);
			txtPembayaranFormatNomor.Text = item.FormatNomorPembayaran;
			txtPembayaranUraian.Text = item.UraianPembayaran;
			txtInvoiceTTDNama.Text = item.TagihanTTdNama;
			txtInvoiceTTDJabatan.Text = item.TagihanTTdJabatan;
			txtInvoiceNomorRekening.Text = item.TagihanRekeningBank;
			txtInvoiceJatuhTempo.EditValue = item.TagihanJatuhTempo;
			txtOpsiPiutangTanggalAwal.EditValue = item.TanggalAwalPiutang;
			txtTTdNamaOrderCetak.Text = item.OrderCetakTtdNama;
			txtTTdJabatanOrderCetak.Text = item.OrderCetakTtdJabatan;
			txtSatuKoli.Value = item.SatuKoliPerEks;
			txtToleransi.Value = item.ToleransiKoli;

			if (SirkulasiHarianService.IsATransaction(session)) {
				txtOpsiPiutangTanggalAwal.Enabled = false;
			}
			if (PembayaranService.IsATransaction(session)) {
				txtPembayaranFormatNomor.Enabled = false;
			}
		}
		public override void Btn1Click() {
			item.FormatNomorPembayaran = txtPembayaranFormatNomor.Text;
			item.UraianPembayaran = txtPembayaranUraian.Text;
			item.TagihanTTdNama = txtInvoiceTTDNama.Text;
			item.TagihanTTdJabatan = txtInvoiceTTDJabatan.Text;
			item.TagihanRekeningBank = txtInvoiceNomorRekening.Text;
			item.TagihanJatuhTempo = (int)txtInvoiceJatuhTempo.Value;
			item.TanggalAwalPiutang = txtOpsiPiutangTanggalAwal.DateTime.ToString("yyyy-MM-dd");
			item.OrderCetakTtdNama = txtTTdNamaOrderCetak.Text;
			item.OrderCetakTtdJabatan = txtTTdJabatanOrderCetak.Text;
			item.SatuKoliPerEks = (int)txtSatuKoli.Value;
			item.ToleransiKoli = (int)txtToleransi.Value;

			item.Save();
			session.CommitChanges();
		}
		public override void Btn2Click() {
			session.RollbackTransaction();
		}
	}
}
