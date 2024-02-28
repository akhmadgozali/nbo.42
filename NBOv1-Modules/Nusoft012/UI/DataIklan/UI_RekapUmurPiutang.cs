using DevExpress.Xpo;
using NuSoft.Core.Win.Forms;
using NuSoft.NUI.Win.Forms.Modules.NuSoft012.Persistent;
using NuSoft.NUI.Win.Forms.Modules.NuSoft012.Services;
using System;
using System.Collections.Generic;
using System.Linq;

namespace NuSoft.NUI.Win.Forms.Modules.NuSoft012.UI.DataIklan {
	public partial class UI_RekapUmurPiutang : PivotOutput {
		private bool isFirstLoad;
		public UI_RekapUmurPiutang() {
			InitializeComponent();
			txtPeriodeEdit.EditValueChanged += new EventHandler(PeriodeChanged);
			xChart = nChart;
			showChart = true;
			showFilter = false;
		}

		public override void FirstLoad() {
			isFirstLoad = true;
			GetSession();
			var periode = new List<KeyValuePair<DateTime, string>>();
			var inv = new XPQuery<Invoice>(session).GroupBy(g => new { g.TanggalOmzet.Year, g.TanggalOmzet.Month }).Select(s => new { Tahun = s.Key.Year, Bulan = s.Key.Month }).ToList();
			foreach (var item in inv.OrderByDescending(o => o.Tahun).OrderByDescending(o => o.Bulan).ToList()) {
				var d = new DateTime(item.Tahun, item.Bulan, 1);
				periode.Add(new KeyValuePair<DateTime, string>(d, d.ToString("MMMM yyyy")));
			}
			txtPeriode.DataSource = periode;
			txtPeriodeEdit.EditValue = null;
			if (periode.Count > 0) txtPeriodeEdit.EditValue = periode[0].Key;
			isFirstLoad = false;
		}
		private void PeriodeChanged(object sender, EventArgs e) {
			xPivot.DataSource = null;
			if (txtPeriodeEdit.EditValue == null) return;

			using (var splashManager = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(x_Wait), true, true)) {
				try {
					if (!isFirstLoad) {
						splashManager.ShowWaitForm();
						splashManager.SetWaitFormCaption("Silahkan Tunggu");
						splashManager.SetWaitFormDescription("Filtering data  ...");
					}

					DateTime item = (DateTime)txtPeriodeEdit.EditValue;
					var ds = PiutangServices.GetUmurPiutang(session, item);

					xPivot.DataSource = ds;
					xPivot.CollapseAll();
					xPivot.ExpandValueAsync(true, new object[] { DateTime.Now.Year });
				}
				catch (Exception ex) { throw new Exception(ex.Message, ex.InnerException); }
				finally { if (!isFirstLoad) splashManager.CloseWaitForm(); }
			}
		}
	}
}
