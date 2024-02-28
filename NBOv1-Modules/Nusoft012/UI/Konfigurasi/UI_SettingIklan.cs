using DevExpress.XtraEditors.Controls;
using NuSoft.Core.Win.Forms;
using NuSoft.NUI.Win.Forms.Modules.NuSoft012.Services;

namespace NuSoft.NUI.Win.Forms.Modules.NuSoft012.UI.Konfigurasi {
	public partial class UI_SettingIklan : DialogForm {
		public UI_SettingIklan() {
			InitializeComponent();
			txtPembayaranFormatNomor.EditValueChanging += new ChangingEventHandler(BayarFormatNomorChanging);
			txtInvoiceFormatNomor.EditValueChanging += new ChangingEventHandler(InvoiceFormatNomorChanging);
			txtOrderFormatNomor.EditValueChanging += new ChangingEventHandler(OrderFormatNomorChanging);
			txtBayarKomisiFormatNomor.EditValueChanging += (s ,e) => {
				txtBayarKomisiFormatNomorJml.Text = NomorService.HitungPanjangFormatNomor(e.NewValue.ToString()).ToString(); 
			};
			txtBayarCashbackFormatNomor.EditValueChanging += (s, e) => {
				txtBayarCashbackFormatNomorJml.Text = NomorService.HitungPanjangFormatNomor(e.NewValue.ToString()).ToString();
			};
			AutoCloseOnSave = true;
		}

		private IklanSetting item;

		private void BayarFormatNomorChanging(object sender, ChangingEventArgs e) {
			txtPembayaranFormatNomorJml.Text = NomorService.HitungPanjangFormatNomor(e.NewValue.ToString()).ToString(); // number.FormatCount(e.NewValue.ToString()).ToString();
		}
		private void InvoiceFormatNomorChanging(object sender, ChangingEventArgs e) {
			txtInvoiceFormatNomorJml.Text = NomorService.HitungPanjangFormatNomor(e.NewValue.ToString()).ToString(); // number.FormatCount(e.NewValue.ToString()).ToString();
		}
		private void OrderFormatNomorChanging(object sender, ChangingEventArgs e) {
			txtOrderFormatNomorJml.Text = NomorService.HitungPanjangFormatNomor(e.NewValue.ToString()).ToString(); // number.FormatCount(e.NewValue.ToString()).ToString();
		}

		public override void InitializeData() {
			GetSession();
			item = new IklanSetting(session);
			txtInvoiceFormatNomor.Text = item.FormatNomorInvoice;
			txtOrderFormatNomor.Text = item.FormatNomorOrder;
			txtOrderCaraBayar.Text = item.CaraBayarOrder;
			txtOrderUraian.Text = item.UraianOrder;
			txtPembayaranFormatNomor.Text = item.FormatNomorPembayaran;
			txtPembayaranUraian.Text = item.UraianPembayaran;
			txtBayarKomisiFormatNomor.Text = item.FormatNomorPencairanKomisi;
			txtBayarKomisiUraian.Text = item.UraianPencairanKomisi;
			txtBayarCashbackFormatNomor.Text = item.FormatNomorPencairanCashback;
			txtBayarCashbackUraian.Text = item.UraianPencairanCashback;

			txtUmurPiutang1.Value = item.UmurPiutang1;
			txtUmurPiutang2.Value = item.UmurPiutang2;
			txtUmurPiutang3.Value = item.UmurPiutang3;
			txtUmurPiutang4.Value = item.UmurPiutang4;

			txtPajakPersen.Value = item.PajakPersenPPn;
			txtMaxKarakterDeret.Value = item.MaxKarakterDeret;
			txtKomisiPotongPPh21.Checked = item.KomisiDipotongPPh21;

			txtKomisiMengajukanNama.Text = item.TtdNamaKomisiMengajukan;
			txtKomisiMengajukanJabatan.Text = item.TtdJabatanKomisiMengajukan;
			txtKomisiMenyetujuiNama.Text = item.TtdNamaKomisiMenyetujui;
			txtKomisiMenyetujuiJabatan.Text = item.TtdJabatanKomisiMenyetujui;
			txtKomisiMengetahuiNama.Text = item.TtdNamaKomisiMengetahui;
			txtKomisiMengetahuiJabatan.Text = item.TtdJabatanKomisiMengetahui;

			txtCashbackMengajukanNama.Text = item.TtdNamaCashbackMengajukan;
			txtCashbackMengajukanJabatan.Text = item.TtdJabatanCashbackMengajukan;
			txtCashbackMenyetujuiNama.Text = item.TtdNamaCashbackMenyetujui;
			txtCashbackMenyetujuiJabatan.Text = item.TtdJabatanCashbackMenyetujui;
			txtCashbackMengetahuiNama.Text = item.TtdNamaCashbackMengetahui;
			txtCashbackMengetahuiJabatan.Text = item.TtdJabatanCashbackMengetahui;

			if (InvoiceService.IsATransaction(session)) {
				txtInvoiceFormatNomor.Enabled = false;
				txtOrderFormatNomor.Enabled = false;
			}
			if (PembayaranIklanService.IsATransaction(session)) {
				txtPembayaranFormatNomor.Enabled = false;
			}
			if (PencairanKomisiService.IsATransaction(session)) {
				txtBayarKomisiFormatNomor.Enabled = false;
			}
			if (PencairanCashbackService.IsATransaction(session)) {
				txtBayarCashbackFormatNomor.Enabled = false;
			}
		}
		public override void Btn1Click() {
			item.FormatNomorInvoice = txtInvoiceFormatNomor.Text;
			item.FormatNomorOrder = txtOrderFormatNomor.Text;
			item.CaraBayarOrder = txtOrderCaraBayar.Text;
			item.UraianOrder = txtOrderUraian.Text;
			item.FormatNomorPembayaran = txtPembayaranFormatNomor.Text;
			item.UraianPembayaran = txtPembayaranUraian.Text;
			item.FormatNomorPencairanKomisi = txtBayarKomisiFormatNomor.Text;
			item.UraianPencairanKomisi = txtBayarKomisiUraian.Text;
			item.FormatNomorPencairanCashback = txtBayarCashbackFormatNomor.Text;
			item.UraianPencairanCashback = txtBayarCashbackUraian.Text;

			item.UmurPiutang1 = (int)txtUmurPiutang1.Value;
			item.UmurPiutang2 = (int)txtUmurPiutang2.Value;
			item.UmurPiutang3 = (int)txtUmurPiutang3.Value;
			item.UmurPiutang4 = (int)txtUmurPiutang4.Value;

			item.PajakPersenPPn = txtPajakPersen.Value;
			item.MaxKarakterDeret = (int)txtMaxKarakterDeret.Value;
			item.KomisiDipotongPPh21 = txtKomisiPotongPPh21.Checked;

			item.TtdNamaKomisiMengajukan = txtKomisiMengajukanNama.Text;
			item.TtdJabatanKomisiMengajukan = txtKomisiMengajukanJabatan.Text;
			item.TtdNamaKomisiMenyetujui = txtKomisiMenyetujuiNama.Text;
			item.TtdJabatanKomisiMenyetujui = txtKomisiMenyetujuiJabatan.Text;
			item.TtdNamaKomisiMengetahui = txtKomisiMengetahuiNama.Text;
			item.TtdJabatanKomisiMengetahui = txtKomisiMengetahuiJabatan.Text;

			item.TtdNamaCashbackMengajukan = txtCashbackMengajukanNama.Text;
			item.TtdJabatanCashbackMengajukan = txtCashbackMengajukanJabatan.Text;
			item.TtdNamaCashbackMenyetujui = txtCashbackMenyetujuiNama.Text;
			item.TtdJabatanCashbackMenyetujui = txtCashbackMenyetujuiJabatan.Text;
			item.TtdNamaCashbackMengetahui = txtCashbackMengetahuiNama.Text;
			item.TtdJabatanCashbackMengetahui = txtCashbackMengetahuiJabatan.Text;

			item.Save();
			session.CommitChanges();
		}
		public override void Btn2Click() {
			session.RollbackTransaction();
		}
	}
}
