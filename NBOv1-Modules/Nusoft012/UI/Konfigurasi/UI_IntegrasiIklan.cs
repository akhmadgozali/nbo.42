using DevExpress.Xpo;
using NuSoft.Core.Win.Forms;
using NuSoft.NUI.Win.Forms.Modules.NuSoft001.Persistent;
using NuSoft.NUI.Win.Forms.Modules.NuSoft012.Persistent;
using NuSoft.NUI.Win.Forms.Modules.NuSoft012.Services;
using System;
using System.Globalization;
using System.Linq;

namespace NuSoft.NUI.Win.Forms.Modules.NuSoft012.UI.Konfigurasi {
	public partial class UI_IntegrasiIklan : DialogForm {
		public UI_IntegrasiIklan() {
			InitializeComponent();
			AutoCloseOnSave = true;
			txtPajakGabungNonNpwp.CheckedChanged += new EventHandler(PajakGabungNonNpwpChecked);
		}

		private IntegrasiIklanSetting item;
		private void PajakGabungNonNpwpChecked(object sender, EventArgs e) {
			txtPajakNonNpwpNama.Enabled = txtPajakGabungNonNpwp.Checked;
		}

		public override void InitializeUsedComponent() {
			GetSession();
			txtPeriodeBulan.Properties.Items.Clear();
			for (var i = 1; i <= 12; i++) {
				txtPeriodeBulan.Properties.Items.Add(CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(i));
			}
			var allAkun = AkunService.GetAkunCollection(session, true);
			txtCoaHutangPPn.Properties.DataSource = allAkun.Where(w => w.TipeAkun == TipeAkun.Hutang || w.TipeAkun == TipeAkun.HutangLancarLainnya).ToList();

			colCoaDiskonRepo.DataSource = allAkun.Where(w => w.TipeAkun == TipeAkun.Biaya).ToList();
			colCoaOmzetRepo.DataSource = allAkun.Where(w => w.TipeAkun == TipeAkun.Pendapatan).ToList();
			colCoaPiutangRepo.DataSource = allAkun.Where(w => w.TipeAkun == TipeAkun.Piutang).ToList();
			colCoaHutangKomisiRepo.DataSource = allAkun.Where(w => w.TipeAkun == TipeAkun.Hutang || w.TipeAkun == TipeAkun.HutangLancarLainnya).ToList();
			colCoaHutangCashbackRepo.DataSource = allAkun.Where(w => w.TipeAkun == TipeAkun.Hutang || w.TipeAkun == TipeAkun.HutangLancarLainnya).ToList();
			colCoaBiayaKomisiRepo.DataSource = allAkun.Where(w => w.TipeAkun == TipeAkun.Biaya).ToList();
			colCoaBiayaCashbackRepo.DataSource = allAkun.Where(w => w.TipeAkun == TipeAkun.Biaya).ToList();
			txtMataUang.Properties.DataSource = new XPQuery<MataUang>(session).ToList();
		}
		public override void InitializeData() {
			item = new IntegrasiIklanSetting(session);
			txtAktifIntegrasi.Checked = item.AktifkanIntegrasi;
			txtPeriodeBulan.SelectedIndex = item.PeriodeBulanMulai - 1;
			txtPeriodeTahun.Value = item.PeriodeTahunMulai;
			txtKeteranganBayar.Text = item.KeteranganPembayaran;
			txtKeteranganOmzet.Text = item.KeteranganOmzet;
			txtMataUang.EditValue = item.MataUangDefault;
			txtPajakGabungNonNpwp.Checked = item.PajakGabungPPnNonNPWP;
			txtPajakNonNpwpNama.Text = item.PajakGabungPPnNonNPWPAtasNama;
			txtPajakTampilkanTanggalTerbit.Checked = item.PajakTampilkanTanggalTerbit;
			txtPajakTampilkanUkuran.Checked = item.PajakTampilkanUkuran;
			txtCoaHutangPPn.EditValue = item.CoaHutangPPn;

			xGridMapping.DataSource = new XPQuery<TipeInvoice>(session).ToList(); //IntegrasiService.GetIklanMappingAkun(session);

			var mapGL = new XPQuery<MappingGLIklan>(session).Count();
			if (mapGL > 0) {
				txtAktifIntegrasi.Enabled = false;
				txtPeriodeBulan.Enabled = false;
				txtPeriodeTahun.Enabled = false;
			}

			PajakGabungNonNpwpChecked(this, null);
		}
		public override void Btn1Click() {
			item.AktifkanIntegrasi = txtAktifIntegrasi.Checked;
			item.PeriodeBulanMulai = txtPeriodeBulan.SelectedIndex + 1;
			item.PeriodeTahunMulai = (int)txtPeriodeTahun.Value;
			item.KeteranganOmzet = txtKeteranganOmzet.Text;
			item.KeteranganPembayaran = txtKeteranganBayar.Text;
			item.MataUangDefault = (int)txtMataUang.EditValue;

			item.CoaHutangPPn = (int)txtCoaHutangPPn.EditValue;
			item.PajakGabungPPnNonNPWP = txtPajakGabungNonNpwp.Checked;
			item.PajakGabungPPnNonNPWPAtasNama = txtPajakNonNpwpNama.Text;
			item.PajakTampilkanTanggalTerbit = txtPajakTampilkanTanggalTerbit.Checked;
			item.PajakTampilkanUkuran = txtPajakTampilkanUkuran.Checked;

			item.Save();
			session.CommitChanges();
		}
		public override void Btn2Click() {
			session.RollbackTransaction();
		}
	}
}
