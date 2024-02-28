using NuSoft.Core.Win.Forms;
using NuSoft.NUI.Win.Forms.Modules.NuSoft007.Persistent;
using NuSoft.NUI.Win.Forms.Modules.NuSoft007.Services;
using System;
using System.ComponentModel;
using System.Linq;

namespace NuSoft.NUI.Win.Forms.Modules.NuSoft007.UI.PPn {
	public partial class UI_NomorFakturDialog : InputDialog {
		public UI_NomorFakturDialog() {
			InitializeComponent();
			txtNomorAwal.LostFocus += new EventHandler(NomorFPValueChanged);
			txtNomorAkhir.LostFocus += new EventHandler(NomorFPValueChanged);
			xGridViewDetail.CustomSummaryCalculate += new DevExpress.Data.CustomSummaryEventHandler(DetailCustomSummary);
			AutoCloseOnSave = true;
		}
		private BindingList<NomorSeriPajakDetailForSave> Detail;
		private NomorSeriPajak originalEdit;
		private bool editAssign;
		private int validRowCount;

		private void CheckDisableControl(NomorSeriPajak item) {
			var disable = false;
			if (item.Locked) disable = true;
			if (disable) {
				//DisableSave();
				txtTanggalBerlaku.Enabled = false;
				txtNomorAwal.Enabled = false;
				txtNomorAkhir.Enabled = false;
				txtKeterangan.Enabled = false;
			}
		}
		private void NomorFPValueChanged(object sender, EventArgs e) {
			if (editAssign) return;
			if (txtNomorAwal.EditValue == null) return;
			if (txtNomorAkhir.EditValue == null) return;

			try {
				xGridDetail.BeginUpdate();
				ulong nomorAwal = ulong.Parse(txtNomorAwal.Text.Replace("-", "").Replace(".", "").Replace("_", ""));
				ulong nomorAkhir = ulong.Parse(txtNomorAkhir.Text.Replace("-", "").Replace(".", "").Replace("_", ""));

				for (ulong i = nomorAwal; i <= nomorAkhir; i++) {
					string b = i.ToString("0000000000000");
					string a = string.Format("{0}-{1}.{2:00000000}", b.Substring(0, 3), b.Substring(3, 2), int.Parse(b.Substring(5)));
					if (Detail.ToList().Find(f => f.NomorSeriFaktur == a) == null) Detail.Add(new NomorSeriPajakDetailForSave() {
						NomorSeriFaktur = a, Terpakai = false
					});
				}

				xGridDetail.EndUpdate();
			}
			catch (Exception ex) { throw new Exception(ex.Message, ex.InnerException); }
		}
		private void DetailCustomSummary(object sender, DevExpress.Data.CustomSummaryEventArgs e) {
			DevExpress.XtraGrid.GridColumnSummaryItem item = e.Item as DevExpress.XtraGrid.GridColumnSummaryItem;
			DevExpress.XtraGrid.Views.Grid.GridView view = sender as DevExpress.XtraGrid.Views.Grid.GridView;

			if (Equals("Terpakai", item.Tag)) {
				if (e.SummaryProcess == DevExpress.Data.CustomSummaryProcess.Start) validRowCount = 0;
				if (e.SummaryProcess == DevExpress.Data.CustomSummaryProcess.Calculate)
					if ((bool)view.GetRowCellValue(e.RowHandle, colDTerpakai)) validRowCount += 1;
				if (e.SummaryProcess == DevExpress.Data.CustomSummaryProcess.Finalize) e.TotalValue = validRowCount;
			}
		}

		public override void InitializeData() {
			Detail = new BindingList<NomorSeriPajakDetailForSave>();

			if (Tipe == InputType.Tambah) {
				Text = "Nomor Seri : Tambah";
				txtTanggalBerlaku.DateTime = DateTime.Now;
				txtNomorAwal.EditValue = null;
				txtNomorAkhir.EditValue = null;
				txtKeterangan.Text = "";
			}
			else {
				editAssign = true;
				originalEdit = session.GetObjectByKey<NomorSeriPajak>(Convert.ToInt32(IdToEdit));
				Text = "Nomor Seri : Edit";
				txtTanggalBerlaku.DateTime = originalEdit.TanggalMulaiBerlaku;
				txtNomorAwal.EditValue = originalEdit.NomorDari;
				txtNomorAkhir.EditValue = originalEdit.NomorSampai;
				txtKeterangan.Text = originalEdit.Keterangan;

				originalEdit = NomorFakturPajakService.GetItem(originalEdit);
				foreach (var item in originalEdit.DetailForSave) Detail.Add(item);
				CheckDisableControl(originalEdit);
				editAssign = false;
			}
			txtTanggalBerlaku.Focus();
			xGridDetail.DataSource = Detail;
		}
		public override void SimpanData() {
			NomorSeriPajak instance;
			if (Tipe == InputType.Tambah) instance = new NomorSeriPajak(session);
			else instance = session.GetObjectByKey<NomorSeriPajak>(Convert.ToInt32(IdToEdit));
			var service = new NomorFakturPajakService(session, originalEdit);
			instance.TanggalMulaiBerlaku = txtTanggalBerlaku.DateTime;
			instance.NomorDari = txtNomorAwal.Text;
			instance.NomorSampai = txtNomorAkhir.Text;
			instance.Keterangan = txtKeterangan.Text;
			instance.DetailForSave = Detail.ToList();
			service.Save(instance);
		}
		public override void ErrorSimpan(Utils.Exception ex) {
			ex.ShowWinMessageBox();
			switch (ex.ErrorNumber) {
				case -1: txtTanggalBerlaku.Focus(); break;
				case -2: txtNomorAwal.Focus(); break;
				case -3: txtNomorAkhir.Focus(); break;
			}
		}
	}
}
