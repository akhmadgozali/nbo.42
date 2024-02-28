using DevExpress.Xpo;
using NuSoft.NUI.Win.Forms.Modules.NuSoft012.Persistent;
using System;
using System.Collections.Generic;
using System.Linq;

namespace NuSoft.NUI.Win.Forms.Modules.NuSoft012.Services {
	public static class PiutangServices {
		public static List<ViewPiutangRincianIklan> GetRincianPiutang(UnitOfWork session, DateTime perTanggal, bool modePerBulan, bool TampilkanSaldo0) {
			if (modePerBulan) perTanggal = new DateTime(perTanggal.Year, perTanggal.Month, DateTime.DaysInMonth(perTanggal.Year, perTanggal.Month));
			string sqlQuery = "select d.Id,d.NoInvoice,d.TanggalOmzet as Tanggal,d.TanggalJatuhTempo,wil.Nama as Wilayah," +
							"reg.d_name as Regional,cast(reg.p_id as signed) as RegionalId," +
							"d.InvoiceNama as Pemasang,cast(sales.Id as signed) as SalesId,sales.Nama as Sales," +
							"tipe.Nama as TipeInvoice,ko.Kode as KelompokOmzet,cast(ko.Id as signed) as KelompokOmzetId," +
							"if(SaldoAwal,d.Netto/1.1,f12_getinvnetto(d.Id, d.Netto, '{0}')) as Netto,f12_getinvppn(d.Id, d.PajakNominal, '{0}') as PPn," +
							"if(SaldoAwal,d.Netto,f12_getinvomzet(d.Id, d.Total, '{0}')) as Omzet," +
							"if(SaldoAwal,(d.Netto-d.Total) + f12_getinvpaid(d.Id, '{0}'),f12_getinvpaid(d.Id, '{0}')) as Pembayaran," +
							"d.InvoiceKeterangan as JudulIklan " +
							"from m12cinvoice d " +
							"left join m12bwilayah wil on d.Wilayah = wil.Id " +
							"left join a_regional reg ON wil.Regional = reg.p_id " +
							"left join m12asales sales on d.Sales = sales.Id " +
							"left join m12atipeinvoice tipe on d.TipeInvoice = tipe.Id " +
							"left join m12akelompokomzet ko on wil.KelompokOmzet = ko.Id " +
							"where f12_getinvomzet(d.Id, d.Total, '{0}') - f12_getinvpaid(d.Id, '{0}') <> 0 and d.TanggalOmzet <= '{0}' and d.IndukInvoice is null and d.KoreksiInvoice is null " +
							"union " +
							"select d.Id,d.NoInvoice,pay.Tanggal as Tanggal,d.TanggalJatuhTempo,wil.Nama as Wilayah," +
							"reg.d_name as Regional,cast(reg.p_id as signed) as RegionalId," +
							"d.InvoiceNama as Pemasang,cast(sales.Id as signed) as SalesId,sales.Nama as Sales," +
							"tipe.Nama as TipeInvoice,ko.Kode as KelompokOmzet,cast(ko.Id as signed) as KelompokOmzetId," +
							"0 as Netto,0 as PPn," +
							"0 as Omzet,NominalBayar as Pembayaran," +
							"d.InvoiceKeterangan as JudulIklan " +
							"from m12dpembayaraniklandetail paydet " +
							"left join m12cpembayaraniklan pay on paydet.Pembayaran = pay.Id " +
							"left join m12cinvoice d on paydet.Invoice=d.Id " +
							"left join m12bwilayah wil on d.Wilayah = wil.Id " +
							"left join a_regional reg ON wil.Regional = reg.p_id " +
							"left join m12asales sales on d.Sales = sales.Id " +
							"left join m12atipeinvoice tipe on d.TipeInvoice = tipe.Id " +
							"left join m12akelompokomzet ko on wil.KelompokOmzet = ko.Id " +
							"where d.TanggalOmzet > '{0}' and pay.Tanggal <= '{0}' and d.IndukInvoice is null and d.KoreksiInvoice is null";

			if (TampilkanSaldo0) {
				sqlQuery = sqlQuery.Replace("f12_getinvomzet(d.Id, d.Total, '{0}') - f12_getinvpaid(d.Id, '{0}') <> 0 and ", "");
			}
			return session.GetObjectsFromQuery<ViewPiutangRincianIklan>(string.Format(sqlQuery, perTanggal.ToString("yyyy-MM-dd"))).ToList();
		}
		public static List<ViewPiutangBerjalanIklan> GetPiutangBerjalan(UnitOfWork session, DateTime periode, int groupByPemasangSales, bool tampilkanSaldoNol) {
			List<ViewPiutangBerjalanIklan> result;
			List<ViewPiutangBerjalanIklan> omzetbaru;
			var dataPiutang = GetRincianPiutang(session, periode, true, false);
			var dataPiutangLama = dataPiutang.Where(w => w.Tanggal < periode).ToList();
			var dataPiutangBaru = dataPiutang.Where(w => w.Tanggal.Month == periode.Month && w.Tanggal.Year == periode.Year).ToList();

			// get saldo awal
			if (groupByPemasangSales == 1)
			{
				result = dataPiutangLama.GroupBy(b => new { Pemasang = b.Pemasang, Wilayah = b.Wilayah })
					.Select(s => new ViewPiutangBerjalanIklan() { PemasangSales = s.Key.Pemasang, Wilayah = s.Key.Wilayah, SaldoAwal = s.Sum(b => b.Piutang), Omzet = 0, Pembayaran = 0, Regional = s.Min(x => x.Regional), RegionalId = s.Min(x => x.RegionalId) }).ToList();
				omzetbaru = dataPiutangBaru.GroupBy(b => new { Pemasang = b.Pemasang, Wilayah = b.Wilayah })
					.Select(s => new ViewPiutangBerjalanIklan() { PemasangSales = s.Key.Pemasang, Wilayah = s.Key.Wilayah, SaldoAwal = 0, Omzet = (double)s.Sum(b => b.Omzet), Pembayaran = (double)s.Sum(b => b.Pembayaran), Regional = s.Min(x => x.Regional), RegionalId = s.Min(x => x.RegionalId) }).ToList();
			}
			else if (groupByPemasangSales == 2)
			{
				result = dataPiutangLama.GroupBy(b => new { Sales = b.Sales, Wilayah = b.Wilayah })
					.Select(s => new ViewPiutangBerjalanIklan() { PemasangSales = s.Key.Sales, Wilayah = s.Key.Wilayah, SaldoAwal = s.Sum(b => b.Piutang), Omzet = 0, Pembayaran = 0, Regional = s.Min(x => x.Regional), RegionalId = s.Min(x => x.RegionalId) }).ToList();
				omzetbaru = dataPiutangBaru.GroupBy(b => new { Sales = b.Sales, Wilayah = b.Wilayah })
					.Select(s => new ViewPiutangBerjalanIklan() { PemasangSales = s.Key.Sales, Wilayah = s.Key.Wilayah, SaldoAwal = 0, Omzet = (double)s.Sum(b => b.Omzet), Pembayaran = (double)s.Sum(b => b.Pembayaran), Regional = s.Min(x => x.Regional), RegionalId = s.Min(x => x.RegionalId) }).ToList();
			}
			else return null;

			// combine
			foreach (var x in result)
			{
				var findRow = omzetbaru.Find(f => f.Wilayah == x.Wilayah && f.PemasangSales == x.PemasangSales);
				if (findRow != null)
				{
					x.Omzet = findRow.Omzet;
					x.Pembayaran = findRow.Pembayaran;
				}
			}
			// insert missing
			foreach (var x in omzetbaru)
			{
				var findRow = result.Find(f => f.Wilayah == x.Wilayah && f.PemasangSales == x.PemasangSales);
				if (findRow == null) result.Add(x);
			}

			// delete lunas
			if (!tampilkanSaldoNol) for (int i = result.Count() - 1; i >= 0; i--) if (result[i].SaldoAwal == 0 && result[i].Omzet == 0 && result[i].Pembayaran == 0) result.Remove(result[i]);
			// set umur piutang
			var jmlHari = DateTime.DaysInMonth(periode.Year, periode.Month);
			foreach (var z in result) z.UmurPiutang = (z.Omzet) == 0 ? 0 : (((z.SaldoAwal + z.Piutang) / 2) / (z.Omzet)) * jmlHari;

			return result;
		}
		public static List<ViewUmurPiutangIklan> GetUmurPiutang(UnitOfWork session, DateTime periode) {
			var serverDate = Data.Helper.GetTimeStamp(session);
			var akhirBulan = new DateTime(periode.Year, periode.Month, DateTime.DaysInMonth(periode.Year, periode.Month));
			var settingIklan = new IklanSetting(session);

			//.GroupBy(g => g.NoInvoice)
			var data = GetRincianPiutang(session, akhirBulan, true, false).Select(s => new ViewUmurPiutangIklan() {
				NoInvoice = s.NoInvoice,
				Tanggal = s.Tanggal,
				TanggalJatuhTempo = s.TanggalJatuhTempo,
				Wilayah = s.Wilayah,
				Regional = s.Regional,
				RegionalId = (int)s.RegionalId,
				Pemasang = s.Pemasang,
				Sales = s.Sales,
				TipeInvoice = s.TipeInvoice,
				Omzet = (decimal)s.Omzet,
				Pembayaran = (decimal)s.Pembayaran
			}).ToList();

			if (serverDate < akhirBulan) akhirBulan = serverDate;
			for (int i = data.Count() - 1; i >= 0; i--) {
				data[i].UmurPiutang = akhirBulan.Subtract(data[i].TanggalJatuhTempo).Days;
				if (data[i].UmurPiutang < 0) data[i].KelompokUmurPiutang = "0: BLM JATUH TEMPO";
				else if (data[i].UmurPiutang >= 0 && data[i].UmurPiutang <= settingIklan.UmurPiutang1) data[i].KelompokUmurPiutang = "1: < " + settingIklan.UmurPiutang1;
				else if (data[i].UmurPiutang > settingIklan.UmurPiutang1 && data[i].UmurPiutang <= settingIklan.UmurPiutang2) data[i].KelompokUmurPiutang = "2: " + (settingIklan.UmurPiutang1 + 1) + " - " + settingIklan.UmurPiutang2;
				else if (data[i].UmurPiutang > settingIklan.UmurPiutang2 && data[i].UmurPiutang <= settingIklan.UmurPiutang3) data[i].KelompokUmurPiutang = "3: " + (settingIklan.UmurPiutang2 + 1) + " - " + settingIklan.UmurPiutang3;
				else if (data[i].UmurPiutang > settingIklan.UmurPiutang3 && data[i].UmurPiutang <= settingIklan.UmurPiutang4) data[i].KelompokUmurPiutang = "4: " + (settingIklan.UmurPiutang3 + 1) + " - " + settingIklan.UmurPiutang4;
				else if (data[i].UmurPiutang > settingIklan.UmurPiutang4) data[i].KelompokUmurPiutang = "5: > " + (settingIklan.UmurPiutang4);
			}

			return data;
		}
		public static List<ViewPiutangBerjalanIklan> GetRekapPiutang(UnitOfWork session, DateTime periodeAwal, DateTime periodeAkhir) {
			var dataPiutang = GetRincianPiutang(session, periodeAkhir, false, true);
			var result = new List<ViewPiutangBerjalanIklan>();

			foreach (var x in dataPiutang) {
				var item = new ViewPiutangBerjalanIklan();
				item.Wilayah = x.Wilayah;
				item.Regional = x.Regional;
				item.RegionalId = x.RegionalId;
				item.Sales = x.Sales;
				item.Pemasang = x.Pemasang;
				item.TipeInvoice = x.TipeInvoice;
				item.KelompokOmzet = x.KelompokOmzet;
				item.KelompokOmzetId = x.KelompokOmzetId;
				item.NoInvoice = x.NoInvoice;
				item.Tanggal = x.Tanggal;
				item.TanggalJatuhTempo = x.TanggalJatuhTempo;

				if (x.Tanggal < periodeAwal) {
					item.SaldoAwal = x.Piutang; item.Omzet = 0; item.Pembayaran = 0;
					if (x.Piutang != 0) result.Add(item);
				}
				else {
					item.SaldoAwal = 0; item.Omzet = x.Omzet; item.Pembayaran = x.Pembayaran;
					result.Add(item);
				}
			}

			return result;
		}
	}

	public static class HutangServices {
		public static List<ViewHutangKomisiCashbackRincian> GetRincianHutangKomisi(UnitOfWork session, DateTime perTanggal, bool TampilkanSaldo0) {
			string sqlQuery = "select det.Id,inv.NoInvoice,bay.NoKwitansi,bay.Tanggal,wil.Nama as Wilayah," +
							"reg.d_name as Regional,cast(reg.p_id as signed) as RegionalId," +
							"inv.InvoiceNama as Pemasang,cast(sales.Id as signed) as SalesId,sales.Nama as Sales," +
							"tipe.Nama as TipeInvoice,ko.Kode as KelompokOmzet,cast(ko.Id as signed) as KelompokOmzetId," +
							"det.KomisiNominal as KomisiCashback," +
							"f12_getkomisipaid(det.Id,'{0}') as Pembayaran," +
							"inv.InvoiceKeterangan as JudulIklan " +
							"from m12dpembayaraniklandetail det " +
							"left join m12cpembayaraniklan bay on det.Pembayaran = bay.Id " +
							"left join m12cinvoice inv on det.Invoice = inv.Id " +
							"left join m12bwilayah wil on inv.Wilayah = wil.Id " +
							"left join a_regional reg ON wil.Regional = reg.p_id " +
							"left join m12asales sales on inv.Sales = sales.Id " +
							"left join m12atipeinvoice tipe on inv.TipeInvoice = tipe.Id " +
							"left join m12akelompokomzet ko on wil.KelompokOmzet = ko.Id " +
							"where det.Lunas=1 and det.KomisiNominal > 0 " +
							"and det.KomisiNominal - f12_getkomisipaid(det.Id,'{0}') <> 0 and bay.Tanggal <= '{0}' " +
							"union " +
							"select det.Id,inv.NoInvoice,bay.NoKwitansi,pay.Tanggal as Tanggal,wil.Nama as Wilayah," +
							"reg.d_name as Regional,cast(reg.p_id as signed) as RegionalId," +
							"inv.InvoiceNama as Pemasang,cast(sales.Id as signed) as SalesId,sales.Nama as Sales," +
							"tipe.Nama as TipeInvoice,ko.Kode as KelompokOmzet,cast(ko.Id as signed) as KelompokOmzetId," +
							"0 as KomisiCashback,NominalCair as Pembayaran," +
							"inv.InvoiceKeterangan as JudulIklan " +
							"from m12epencairankomisidetail paydet " +
							"left join m12dpencairankomisi pay on paydet.PencairanKomisi = pay.Id " +
							"left join m12dpembayaraniklandetail det on paydet.Komisi=det.Id " +
							"left join m12cpembayaraniklan bay on det.Pembayaran=bay.Id " +
							"left join m12cinvoice inv on det.Invoice=inv.Id " +
							"left join m12bwilayah wil on inv.Wilayah = wil.Id " +
							"left join a_regional reg ON wil.Regional = reg.p_id " +
							"left join m12asales sales on inv.Sales = sales.Id " +
							"left join m12atipeinvoice tipe on inv.TipeInvoice = tipe.Id " +
							"left join m12akelompokomzet ko on wil.KelompokOmzet = ko.Id " +
							"where bay.Tanggal > '{0}' and pay.Tanggal <= '{0}' ";

			if (TampilkanSaldo0) {
				sqlQuery = sqlQuery.Replace("det.KomisiNominal - f12_getkomisipaid(det.Id,'{0}') <> 0 and ", "");
			}
			return session.GetObjectsFromQuery<ViewHutangKomisiCashbackRincian>(string.Format(sqlQuery, perTanggal.ToString("yyyy-MM-dd"))).ToList();
		}
		public static List<ViewHutangKomisiCashbackRincian> GetRincianHutangCashback(UnitOfWork session, DateTime perTanggal, bool TampilkanSaldo0) {
			string sqlQuery = "select det.Id,inv.NoInvoice,bay.NoKwitansi,bay.Tanggal,wil.Nama as Wilayah," +
							"reg.d_name as Regional,cast(reg.p_id as signed) as RegionalId," +
							"inv.InvoiceNama as Pemasang,cast(sales.Id as signed) as SalesId,sales.Nama as Sales," +
							"tipe.Nama as TipeInvoice,ko.Kode as KelompokOmzet,cast(ko.Id as signed) as KelompokOmzetId," +
							"det.CashbackNominal as KomisiCashback," +
							"f12_getcashbackpaid(det.Id,'{0}') as Pembayaran," +
							"inv.InvoiceKeterangan as JudulIklan " +
							"from m12dpembayaraniklandetail det " +
							"left join m12cpembayaraniklan bay on det.Pembayaran = bay.Id " +
							"left join m12cinvoice inv on det.Invoice = inv.Id " +
							"left join m12bwilayah wil on inv.Wilayah = wil.Id " +
							"left join a_regional reg ON wil.Regional = reg.p_id " +
							"left join m12asales sales on inv.Sales = sales.Id " +
							"left join m12atipeinvoice tipe on inv.TipeInvoice = tipe.Id " +
							"left join m12akelompokomzet ko on wil.KelompokOmzet = ko.Id " +
							"where det.Lunas=1 and det.CashbackNominal > 0 " +
							"and det.CashbackNominal - f12_getcashbackpaid(det.Id,'{0}') <> 0 and bay.Tanggal <= '{0}' " +
							"union " +
							"select det.Id,inv.NoInvoice,bay.NoKwitansi,pay.Tanggal as Tanggal,wil.Nama as Wilayah," +
							"reg.d_name as Regional,cast(reg.p_id as signed) as RegionalId," +
							"inv.InvoiceNama as Pemasang,cast(sales.Id as signed) as SalesId,sales.Nama as Sales," +
							"tipe.Nama as TipeInvoice,ko.Kode as KelompokOmzet,cast(ko.Id as signed) as KelompokOmzetId," +
							"0 as KomisiCashback,NominalCair as Pembayaran," +
							"inv.InvoiceKeterangan as JudulIklan " +
							"from m12epencairancashbackdetail paydet " +
							"left join m12dpencairancashback pay on paydet.PencairanCashback = pay.Id " +
							"left join m12dpembayaraniklandetail det on paydet.Cashback=det.Id " +
							"left join m12cpembayaraniklan bay on det.Pembayaran=bay.Id " +
							"left join m12cinvoice inv on det.Invoice=inv.Id " +
							"left join m12bwilayah wil on inv.Wilayah = wil.Id " +
							"left join a_regional reg ON wil.Regional = reg.p_id " +
							"left join m12asales sales on inv.Sales = sales.Id " +
							"left join m12atipeinvoice tipe on inv.TipeInvoice = tipe.Id " +
							"left join m12akelompokomzet ko on wil.KelompokOmzet = ko.Id " +
							"where bay.Tanggal > '{0}' and pay.Tanggal <= '{0}' ";

			if (TampilkanSaldo0) {
				sqlQuery = sqlQuery.Replace("det.CashbackNominal - f12_getcashbackpaid(det.Id,'{0}') <> 0 and ", "");
			}
			return session.GetObjectsFromQuery<ViewHutangKomisiCashbackRincian>(string.Format(sqlQuery, perTanggal.ToString("yyyy-MM-dd"))).ToList();
		}

		public static List<ViewRekapHutangKomisiCashback> GetRekapHutangKomisi(UnitOfWork session, DateTime periodeAwal, DateTime periodeAkhir) {
			var dataHutang = GetRincianHutangKomisi(session, periodeAkhir, true);
			var result = new List<ViewRekapHutangKomisiCashback>();

			foreach (var x in dataHutang) {
				var item = new ViewRekapHutangKomisiCashback();
				item.Wilayah = x.Wilayah;
				item.Regional = x.Regional;
				item.RegionalId = x.RegionalId;
				item.Sales = x.Sales;
				item.Pemasang = x.Pemasang;
				item.TipeInvoice = x.TipeInvoice;
				item.KelompokOmzet = x.KelompokOmzet;
				item.KelompokOmzetId = x.KelompokOmzetId;
				item.NoInvoice = x.NoInvoice;
				item.NoKwitansi = x.NoKwitansi;
				item.Tanggal = x.Tanggal;

				if (x.Tanggal < periodeAwal) {
					item.SaldoAwal = x.Hutang; item.KomisiCashback = 0; item.Pembayaran = 0;
					if (x.Hutang != 0) result.Add(item);
				}
				else {
					item.SaldoAwal = 0; item.KomisiCashback = x.KomisiCashback; item.Pembayaran = x.Pembayaran;
					result.Add(item);
				}
			}

			return result;
		}
		public static List<ViewRekapHutangKomisiCashback> GetRekapHutangCashback(UnitOfWork session, DateTime periodeAwal, DateTime periodeAkhir) {
			var dataHutang = GetRincianHutangCashback(session, periodeAkhir, true);
			var result = new List<ViewRekapHutangKomisiCashback>();

			foreach (var x in dataHutang) {
				var item = new ViewRekapHutangKomisiCashback();
				item.Wilayah = x.Wilayah;
				item.Regional = x.Regional;
				item.RegionalId = x.RegionalId;
				item.Sales = x.Sales;
				item.Pemasang = x.Pemasang;
				item.TipeInvoice = x.TipeInvoice;
				item.KelompokOmzet = x.KelompokOmzet;
				item.KelompokOmzetId = x.KelompokOmzetId;
				item.NoInvoice = x.NoInvoice;
				item.NoKwitansi = x.NoKwitansi;
				item.Tanggal = x.Tanggal;

				if (x.Tanggal < periodeAwal) {
					item.SaldoAwal = x.Hutang; item.KomisiCashback = 0; item.Pembayaran = 0;
					if (x.Hutang != 0) result.Add(item);
				}
				else {
					item.SaldoAwal = 0; item.KomisiCashback = x.KomisiCashback; item.Pembayaran = x.Pembayaran;
					result.Add(item);
				}
			}

			return result;
		}
	}
}
