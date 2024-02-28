using DevExpress.Xpo;
using NuSoft.Core.Win.Forms;
using NuSoft.NUI.Win.Forms.Modules.NuSoft001.Persistent;
using NuSoft.NUI.Win.Forms.Modules.NuSoft011.Persistent;
using NuSoft.NUI.Win.Forms.Modules.NuSoft011.Services;
using System;
using System.Globalization;
using System.Linq;

namespace NuSoft.NUI.Win.Forms.Modules.NuSoft011.UI.Konfigurasi {
	public partial class UI_IntegrasiKoran : DialogForm {
		public UI_IntegrasiKoran() {
			InitializeComponent();
			AutoCloseOnSave = true;
			txtPajakOmzetKenaPPn.CheckedChanged += new EventHandler(PajakChecked);
			txtPajakGabungNonNpwp.CheckedChanged += new EventHandler(PajakChecked);
		}

		private IntegrasiSirkulasiSetting item;
		private void PajakChecked(object sender, EventArgs e) {
			txtPajakPersen.Enabled = txtPajakOmzetKenaPPn.Checked;
			txtPajakCoa.Enabled = txtPajakOmzetKenaPPn.Checked;
			txtPajakGabungNonNpwp.Enabled = txtPajakOmzetKenaPPn.Checked;
			txtPajakNonNpwpNama.Enabled = txtPajakOmzetKenaPPn.Checked && txtPajakGabungNonNpwp.Checked;
		}

		public override void InitializeUsedComponent() {
			GetSession();
			txtPeriodeBulan.Properties.Items.Clear();
			for (var i = 1; i <= 12; i++) {
				txtPeriodeBulan.Properties.Items.Add(CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(i));
			}
			var allAkun = AkunService.GetAkunCollection(session, true);
			txtPajakCoa.Properties.DataSource = allAkun.Where(w => w.TipeAkun == TipeAkun.Hutang || w.TipeAkun == TipeAkun.HutangLancarLainnya).ToList();
			colCoaDiskonRepo.DataSource = allAkun.Where(w => w.TipeAkun == TipeAkun.Biaya).ToList();
			colCoaReturRepo.DataSource = allAkun.Where(w => w.TipeAkun == TipeAkun.Biaya).ToList();
			colCoaOmzetRepo.DataSource = allAkun.Where(w => w.TipeAkun == TipeAkun.Pendapatan).ToList();
			colCoaPiutangRepo.DataSource = allAkun.Where(w => w.TipeAkun == TipeAkun.Piutang).ToList();
			txtMataUang.Properties.DataSource = new XPQuery<MataUang>(session).ToList();
			txtKaryawan.Properties.DataSource = new XPQuery<Kontak>(session).Where(w => w.TipeKontak.Nama == "Karyawan").ToList();
		}
		public override void InitializeData() {
			item = new IntegrasiSirkulasiSetting(session);
			txtAktifIntegrasi.Checked = item.AktifkanIntegrasi;
			txtPeriodeBulan.SelectedIndex = item.PeriodeBulanMulai - 1;
			txtPeriodeTahun.Value = item.PeriodeTahunMulai;
			txtKeteranganBayar.Text = item.KeteranganPembayaran;
			txtKeteranganOmzet.Text = item.KeteranganOmzet;
			txtMataUang.EditValue = item.MataUangDefault;
			txtKaryawan.EditValue = item.KaryawanDefault;
			txtPajakOmzetKenaPPn.Checked = item.PajakOmzetKenaPPn;
			txtPajakPersen.Value = item.PajakPersenPPn;
			txtPajakCoa.EditValue = item.PajakCoaHutangPPn;
			txtPajakGabungNonNpwp.Checked = item.PajakGabungPPnNonNPWP;
			txtPajakNonNpwpNama.Text = item.PajakGabungPPnNonNPWPAtasNama;
			xGridRute.DataSource = new XPCollection<Rute>(session);

			var mapGL = new XPQuery<MappingGLSirkulasi>(session).Count();
			if (mapGL > 0) {
				txtAktifIntegrasi.Enabled = false;
				txtPeriodeBulan.Enabled = false;
				txtPeriodeTahun.Enabled = false;
			}

			PajakChecked(this, null);
		}
		public override void Btn1Click() {
			item.AktifkanIntegrasi = txtAktifIntegrasi.Checked;
			item.PeriodeBulanMulai = txtPeriodeBulan.SelectedIndex + 1;
			item.PeriodeTahunMulai = (int)txtPeriodeTahun.Value;
			item.KeteranganOmzet = txtKeteranganOmzet.Text;
			item.KeteranganPembayaran = txtKeteranganBayar.Text;
			item.MataUangDefault = (int)txtMataUang.EditValue;
			item.KaryawanDefault = (long)txtKaryawan.EditValue;

			item.PajakOmzetKenaPPn = txtPajakOmzetKenaPPn.Checked;
			item.PajakPersenPPn = txtPajakPersen.Value;
			item.PajakCoaHutangPPn = (int)txtPajakCoa.EditValue;
			item.PajakGabungPPnNonNPWP = txtPajakGabungNonNpwp.Checked;
			item.PajakGabungPPnNonNPWPAtasNama = txtPajakNonNpwpNama.Text;

			item.Save();
			session.CommitChanges();
		}
		public override void Btn2Click() {
			session.RollbackTransaction();
		}
	}
}
