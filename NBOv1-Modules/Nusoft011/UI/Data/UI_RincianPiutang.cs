using DevExpress.Xpo;
using DevExpress.XtraEditors.Controls;
using NuSoft.Core.Win.Forms;
using NuSoft.NUI.Win.Forms.Modules.NuSoft011.Persistent;
using NuSoft.NUI.Win.Forms.Modules.NuSoft011.Services;
using System;
using System.Collections.Generic;
using System.Linq;

namespace NuSoft.NUI.Win.Forms.Modules.NuSoft011.UI.Data {
	public partial class UI_RincianPiutang : GridOutput {
		public UI_RincianPiutang() {
			InitializeComponent();
			txtPeriode1.EditValueChanging += new ChangingEventHandler(PeriodeChanging);
			showChart = false;
			showFilter = false;
			useFeedbackSource = false;
		}
		public override void FirstLoad() {
			GetSession();

			var periode = new XPQuery<SirkulasiHarian>(session).Select(s => s.Tanggal).ToList();
			var data = new List<KeyValuePair<DateTime, string>>();
			foreach (var y in periode.GroupBy(g => new DateTime(g.Year, g.Month, 1)).Select(s => s.Key).OrderByDescending(o => o))
				data.Add(new KeyValuePair<DateTime, string>(y, y.ToString("MMMM yyyy")));

			txtPeriode1.DataSource = data;
			barPeriode.EditValue = data[0].Key;
			SetDataSource(data[0].Key);
		}
		private void PeriodeChanging(object sender, ChangingEventArgs e) {
			if (e.NewValue != null) SetDataSource((DateTime)e.NewValue);
			else xGrid.DataSource = null;
		}
		private void SetDataSource(DateTime tanggal) {
			if (tanggal == default) xGrid.DataSource = null;
			else  xGrid.DataSource = PiutangService.GetPiutangBerjalanKoran(session, tanggal.Year, tanggal.Month);
		}
	}
}
