using DevExpress.Xpo;
using NuSoft.NUI.Win.Forms.Modules.NuSoft011.Persistent;
using System;
using System.Collections.Generic;
using System.Linq;

namespace NuSoft.NUI.Win.Forms.Modules.NuSoft011.Services {
	internal class PiutangService {
		private static List<ViewPiutangAwalAgen> GetBeginningMutasiList(UnitOfWork session, DateTime perTanggal) {
			string sqlOmzet = "select d.Agen as Id,coalesce(sum(" +
				"((d.JatahOrder + d.JatahMutasi) * d.HargaJatah) + " +
				"((d.KonsiOrder + d.KonsiMutasi - d.Retur) * d.HargaKonsi) " +
				"),0) as Saldo " +
				"from m11dmutationdetail d left join m11cmutation c on d.Main = c.Id " +
				"where c.Tanggal < '{0}' group by d.Agen;";

			return session.GetObjectsFromQuery<ViewPiutangAwalAgen>(string.Format(sqlOmzet, perTanggal.ToString("yyyy-MM-dd"))).ToList();
		}
		//private static List<ViewPiutangAwalAgen> GetBeginningKoreksiList(JCon session, DateTime perTanggal)
		//{
		//	string sqlKoreksi = "select ed.Agen as Id,coalesce(sum(de.Omzet - (de.Retur * de.HargaKoran)),0) as Saldo " +
		//		"from m03koreksireturdetail de left join m03koreksiretur ed on de.Main = ed.Id " +
		//		"where ed.Tanggal < '{0}' group by ed.Agen;";

		//	return session.GetObjectsFromQuery<ViewPiutangAwalAgen>(string.Format(sqlKoreksi, perTanggal.ToString("yyyy-MM-dd"))).ToList();
		//}
		private static List<ViewPiutangAwalAgen> GetBeginningPembayaranList(UnitOfWork session, DateTime perTanggal) {
			string sqlPembayaran = "SELECT Agen as Id,coalesce(sum(TotalBayar),0) as Saldo FROM m11cbayarkoran WHERE Tanggal < '{0}' group by Agen;";

			return session.GetObjectsFromQuery<ViewPiutangAwalAgen>(string.Format(sqlPembayaran, perTanggal.ToString("yyyy-MM-dd"))).ToList();
		}
		public static List<PiutangAgen> GetPiutangBerjalanKoran(UnitOfWork session, int tahun, int bulan) { 
			return GetPiutangBerjalanKoran(session, tahun, bulan, false, false, false, string.Empty, string.Empty, string.Empty, null);
		}
		public static List<PiutangAgen> GetPiutangBerjalanKoran(UnitOfWork session, int tahun, int bulan, bool showNull, bool showDetail, bool akumulasi, string kodeAgen1, string kodeAgen2, string namaAgen, List<object> rute) {
			if (tahun == default(int) || bulan == default(int)) throw new Utils.Exception("Masukkan periode", -1);

			List<Agen> dsAgen;
			if (rute != null) dsAgen = new XPQuery<Agen>(session).Where(w => rute.Contains(w.Rute)).ToList();
			else dsAgen = new XPQuery<Agen>(session).ToList();

			if (!string.IsNullOrEmpty(kodeAgen1)) {
				if (string.IsNullOrEmpty(kodeAgen2)) dsAgen = dsAgen.Where(w => w.Kode.ToLower().Contains(kodeAgen1.ToLower())).ToList();
				else dsAgen = dsAgen.Where(w => w.Kode.ToLower().CompareTo(kodeAgen1.ToLower()) >= 0 && w.Kode.ToLower().CompareTo(kodeAgen2.ToLower()) <= 0).ToList();
			}
			if (!string.IsNullOrEmpty(namaAgen)) dsAgen = dsAgen.Where(w => w.Nama.ToLower().Contains(namaAgen.ToLower())).ToList();

			var result = new List<PiutangAgen>();
			//List<KoreksiOmzetDetail> totalkoreksiOmzet; 
			List<SirkulasiHarianDetail> totalmutasi; List<BayarKoran> totalpembayaran;
			DateTime batasAwal;

			if (akumulasi) {
				//totalkoreksiOmzet = new XPQuery<KoreksiOmzetDetail>(session).Where(w => w.Main.Tanggal.Year == tahun && w.Main.Tanggal.Month <= bulan).ToList();
				totalmutasi = new XPQuery<SirkulasiHarianDetail>(session).Where(w => w.Main.Tanggal.Year == tahun && w.Main.Tanggal.Month <= bulan).ToList();
				totalpembayaran = new XPQuery<BayarKoran>(session).Where(w => w.Tanggal.Year == tahun && w.Tanggal.Month <= bulan).ToList();
				batasAwal = new DateTime(tahun, 1, 1);
			}
			else {
				//totalkoreksiOmzet = new XPQuery<KoreksiOmzetDetail>(session).Where(w => w.Main.Tanggal.Year == tahun && w.Main.Tanggal.Month == bulan).ToList();
				totalmutasi = new XPQuery<SirkulasiHarianDetail>(session).Where(w => w.Main.Tanggal.Year == tahun && w.Main.Tanggal.Month == bulan).ToList();
				totalpembayaran = new XPQuery<BayarKoran>(session).Where(w => w.Tanggal.Year == tahun && w.Tanggal.Month == bulan).ToList();
				batasAwal = new DateTime(tahun, bulan, 1);
			}

			var beginMutasi = GetBeginningMutasiList(session, batasAwal);
			//var beginKoreksiOmzet = GetBeginningKoreksiList(session, batasAwal);
			var beginPembayaran = GetBeginningPembayaranList(session, batasAwal);

			foreach (var agen in dsAgen) {
				var item = new PiutangAgen() { Agen = agen, Periode = int.Parse(tahun.ToString() + bulan.ToString("00")) };

				item.SaldoAwalPiutang = (agen.SaldoPiutangAwal) +
					beginMutasi.Where(w => w.Id == agen.Id).Sum(s => s.Saldo) - // +
					//beginKoreksiOmzet.Where(w => (listChildrenId.Contains((int)w.Id)) || w.Id == agen.Id.Id).Sum(s => s.Saldo) -
					beginPembayaran.Where(w => w.Id == agen.Id).Sum(s => s.Saldo);

				var mutasi = totalmutasi.Where(w => w.Agen == agen);
				item.KoreksiOmzet = 0; //totalkoreksiOmzet.Where(w => w.Main.Agen == agen || w.Main.Agen.IndukAgen == agen).Sum(s => s.Omzet);
				item.KoreksiReturOplah = 0; // totalkoreksiOmzet.Where(w => w.Main.Agen == agen || w.Main.Agen.IndukAgen == agen).Sum(s => s.Retur);
				item.KoreksiReturOmzet = 0; // totalkoreksiOmzet.Where(w => w.Main.Agen == agen || w.Main.Agen.IndukAgen == agen).Sum(s => s.OmzetRetur);
				item.KoreksiPembayaran = totalpembayaran.Where(w => (w.Agen == agen) && w.BatalBayarId != null).Sum(s => (double)s.TotalBayar);
				item.Jatah = mutasi.Sum(s => s.Jatah);
				item.Konsi = mutasi.Sum(s => s.Konsi);
				item.Gratis = mutasi.Sum(s => s.Gratis);
				item.Omzet = mutasi.Sum(s => s.Omzet);
				item.Pembayaran = totalpembayaran.Where(w => (w.Agen == agen) && w.BatalBayarId == null).Sum(s => (double)s.TotalBayar);
				item.ReturOplah = mutasi.Sum(s => s.Retur);
				item.ReturOmzet = mutasi.Sum(s => s.OmzetRetur);

				item.HargaJatah = mutasi.Count() > 0 ? mutasi.Average(a => a.HargaJatah) : agen.HargaJatah;
				item.HargaKonsi = mutasi.Count() > 0 ? mutasi.Average(a => a.HargaKonsi) : agen.HargaKonsi;

				if (showDetail && !akumulasi) {
					item.Detail = new List<PiutangAgenDetail>();
					for (int i = 1; i <= DateTime.DaysInMonth(tahun, bulan); i++) {
						var det = new PiutangAgenDetail() { Tanggal = new DateTime(tahun, bulan, i) };
						var mutasiDet = totalmutasi.Where(f => (f.Agen == agen) && f.Main.Tanggal == det.Tanggal).ToList();
						if (mutasiDet.Count > 0) {
							det.OrderGratis = mutasiDet.Sum(s => s.GratisOrder);
							det.OrderJatah = mutasiDet.Sum(s => s.JatahOrder);
							det.OrderKonsi = mutasiDet.Sum(s => s.KonsiOrder);
							det.MutasiGratis = mutasiDet.Sum(s => s.GratisMutasi);
							det.MutasiJatah = mutasiDet.Sum(s => s.JatahMutasi);
							det.MutasiKonsi = mutasiDet.Sum(s => s.KonsiMutasi);
							det.ReturFisik = mutasiDet.Sum(s => s.Retur);
							det.HargaKonsi = mutasiDet.Average(s => s.HargaKonsi);
							det.HargaJatah = mutasiDet.Average(s => s.HargaJatah);
						}
						det.Pembayaran = totalpembayaran.Where(f => (f.Agen == agen) && f.Tanggal == det.Tanggal.Date && f.BatalBayarId == null).Sum(s => (double)s.TotalBayar);
						item.Detail.Add(det);
					}
				}
				item.TerbilangOmzet = Utils.Common.Character.Terbilang(item.TotalOmzet, "Rupiah");

				// set umur piutang
				var jmlHari = DateTime.DaysInMonth(tahun, bulan);
				var totOmzet = (item.Omzet - item.ReturOmzet + item.KoreksiOmzet - item.KoreksiReturOmzet);
				item.UmurPiutang = totOmzet == 0 ? 0 : (decimal)(((item.SaldoAwal + item.SaldoAkhir) / 2) / totOmzet) * jmlHari;

				if (showNull) result.Add(item);
				else
					if (item.SaldoAwal != 0 || item.Omzet != 0 || item.Pembayaran != 0 || item.ReturOmzet != 0 || item.SaldoAkhir != 0) result.Add(item);
			}
			return result;
		}
	}
}
