using DevExpress.Data.Async.Helpers;
using DevExpress.Data.Filtering;
using DevExpress.Utils.Drawing.Helpers;
using DevExpress.XtraBars;
using NuSoft.Core.Win.Forms;
using NuSoft.NUI.Win.Forms.Modules.NuSoft011.Persistent;
using NuSoft.NUI.Win.Forms.Modules.NuSoft011.Services;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace NuSoft.NUI.Win.Forms.Modules.NuSoft011.UI.Transaksi {
	public partial class UI_Pelanggan : GridInput {
		private readonly bool _status;
		public UI_Pelanggan(bool status) {
			InitializeComponent();
			_status = status;
			ifSource.FixedFilterCriteria = new BinaryOperator(nameof(Pelanggan.Aktif), status);
			if (!status) {
				allowAdd = false; allowDelete = false;
				btnNonAktifkan.Visibility = BarItemVisibility.Never;
				btnTambahExp.Visibility = BarItemVisibility.Never;
				btnKomplain.Visibility = BarItemVisibility.Never;
				Text = "Pelanggan Non Aktif";
			}
			else {
				colKeteranganTerakhir.Visible = false;
				btnAktifkan.Visibility = BarItemVisibility.Never;
				Text = "Pelanggan Aktif";
			}

			ActivateToolTip = false;
			baseView = xGridView;
			KeyField = nameof(Pelanggan.Id);
			useFeedbackSource = true;
			useMDIforDialog = false;
			UseDbSystem = false;

			btnNonAktifkan.ItemClick += new ItemClickEventHandler(PelangganAktifNonAktif);
			btnAktifkan.ItemClick += new ItemClickEventHandler(PelangganAktifNonAktif);
			btnTambahExp.ItemClick += new ItemClickEventHandler(PelangganTambahExp);
			btnHistory.ItemClick += new ItemClickEventHandler(HistoryPelanggan);
			btnKomplain.ItemClick += new ItemClickEventHandler(KomplainPelanggan);
		}

		public override InputBase GetDialogForm() { return new UI_PelangganDialog(); }
		public override List<GridDeletedData> GetKeteranganHapus(int[] selectedRows) {
			var result = new List<GridDeletedData>();
			GridDeletedData item;

			for (int i = selectedRows.GetLowerBound(0); i <= selectedRows.GetUpperBound(0); i++) {
				if (!xGridView.IsGroupRow(selectedRows[i])) {
					item = new GridDeletedData() {
						Row = selectedRows[i],
						Data = string.Format("{0} - {1}\r\n",
							xGridView.GetRowCellValue(selectedRows[i], nameof(Pelanggan.Kode)),
							xGridView.GetRowCellValue(selectedRows[i], nameof(Pelanggan.Nama)))
					};
					result.Add(item);
				}
			}
			return result;
		}
		public override bool HapusData(List<GridDeletedData> selectedData) {
			var service = new PelangganService(session);
			List<Pelanggan> deleted = new List<Pelanggan>();

			foreach (var x in selectedData) {
				if (!xGridView.IsGroupRow(x.Row)) {
					deleted.Add((Pelanggan)((ReadonlyThreadSafeProxyForObjectFromAnotherThread)xGridView.GetRow(x.Row)).OriginalRow);
				}
			}

			try {
				return service.Delete(deleted);
			}
			catch (Exception ex) {
				MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
				return true;
			}
		}

		private void PelangganTambahExp(object sender, ItemClickEventArgs e) {
			if (xGridView.IsGroupRow(xGridView.FocusedRowHandle)) return;
			var _form = new UI_PelangganAktifNonAktifDialog(PelangganService.ModeStatusPelanggan.TambahExp);
			_form.SetData(session, (Pelanggan)((ReadonlyThreadSafeProxyForObjectFromAnotherThread)xGridView.GetRow(xGridView.FocusedRowHandle)).OriginalRow);
			_form.ShowDialog();
			RefreshData();
		}
		private void PelangganAktifNonAktif(object sender, ItemClickEventArgs e) {
			if (xGridView.IsGroupRow(xGridView.FocusedRowHandle)) return;
			var _form = _status ? new UI_PelangganAktifNonAktifDialog(PelangganService.ModeStatusPelanggan.NonAktifkan) : new UI_PelangganAktifNonAktifDialog(PelangganService.ModeStatusPelanggan.Aktifkan);
			_form.SetData(session, (Pelanggan)((ReadonlyThreadSafeProxyForObjectFromAnotherThread)xGridView.GetRow(xGridView.FocusedRowHandle)).OriginalRow);
			_form.ShowDialog();
			RefreshData();
		}
		private void HistoryPelanggan(object sender, ItemClickEventArgs e) {
			if (xGridView.IsGroupRow(xGridView.FocusedRowHandle)) return;
			var _form = new UI_PelangganHistoryDialog();
			_form.SetData((Pelanggan)((ReadonlyThreadSafeProxyForObjectFromAnotherThread)xGridView.GetRow(xGridView.FocusedRowHandle)).OriginalRow);
			_form.ShowDialog();
		}
		private void KomplainPelanggan(object sender, ItemClickEventArgs e) {
			if (xGridView.IsGroupRow(xGridView.FocusedRowHandle)) return;
			var form = new UI_KomplainDialog();
			form.NamaDatabase = NamaDatabase;
			form.MenuId = MenuId;
			form.session = session;
			form.Tipe = InputBase.InputType.Tambah;
			form.Owner = this;
			form.Pelanggan = (Pelanggan)((ReadonlyThreadSafeProxyForObjectFromAnotherThread)xGridView.GetRow(xGridView.FocusedRowHandle)).OriginalRow;
			form.ShowDialog();
		}
	}
}