using DevExpress.Data.Filtering;
using DevExpress.Xpo;
using NuSoft.NPO.Modules;
using NuSoft.NPO.Modules.ModSys;
using NuSoft.NUI.Win.Forms.Modules.NuSoft001.Persistent;
using NuSoft.NUI.Win.Forms.Modules.NuSoft007.Persistent;
using NuSoft.NUI.Win.Forms.Modules.NuSoft007.Services;
using NuSoft.NUI.Win.Forms.Modules.NuSoft011.Persistent;
using System;
using System.Collections.Generic;
using System.Linq;

namespace NuSoft.NUI.Win.Forms.Modules.NuSoft011.Services {
	internal class IntegrasiService {
		internal static bool CekPeriodeTutupBuku(UnitOfWork session, DateTime Tanggal) {
			var item = session.FindObject<PeriodeAkuntansi>(new GroupOperator(GroupOperatorType.And,
				new BinaryOperator(nameof(PeriodeAkuntansi.Tahun), Tanggal.Year, BinaryOperatorType.Equal),
				new BinaryOperator(nameof(PeriodeAkuntansi.Bulan), Tanggal.Month, BinaryOperatorType.Equal)));

			return item != null && item.Tutup;
		}
		
		public static void SaveIntegrasiKoran(UnitOfWork session, SirkulasiHarian mutasi, SirkulasiHarian mutasiLama) {
			DateTime tglLama = default(DateTime);
			List<Agen> agenLama = null;
			if (mutasiLama != null) {
				tglLama = mutasiLama.Tanggal;
				agenLama = mutasiLama.Detail.Select(s => s.Agen).ToList();
			}

			SaveIntegrasiKoran(session, mutasi.Tanggal, tglLama, mutasi.Detail.Select(s => s.Agen).ToList(), agenLama);
		}
		public static void SaveIntegrasiKoran(UnitOfWork session, SirkulasiAgen mutasiPerAgen) { SaveIntegrasiKoran(session, mutasiPerAgen.Tanggal, mutasiPerAgen.Tanggal, new List<Agen>() { mutasiPerAgen.Agen }, null); }
		public static void SaveIntegrasiKoran(UnitOfWork session, DateTime periode, DateTime periodeLama, List<Agen> agen, List<Agen> agenLama) {
			var setting = new IntegrasiSirkulasiSetting(session);
			if (!setting.AktifkanIntegrasi) return;
			if (int.Parse(new DateTime(setting.PeriodeTahunMulai, setting.PeriodeBulanMulai, 1).ToString("yyyyMM")) > int.Parse(periode.ToString("yyyyMM"))) return;

			if (periodeLama != default(DateTime) && periode.ToString("yyyyMM") != periodeLama.ToString("yyyyMM")) {
				if (setting.PajakOmzetKenaPPn) {
					if (setting.PajakGabungPPnNonNPWP) {
						var agenNonNpwp = agenLama.FindAll(f => f.NPWP == PPnKeluaranService.GetDefaultNPWP());
						if (agenNonNpwp.Count > 1) {
							agenNonNpwp.Remove(agenNonNpwp[0]);
							agenLama.RemoveAll(a => agenNonNpwp.Contains(a));
						}
					}
					foreach (var ag in agenLama) SavePajakKoran(session, periodeLama, ag, setting);
				}
				foreach (var ag in agenLama.GroupBy(g => g.Rute.Regional).Select(s => s.Key)) SaveGLKoran(session, periodeLama, ag, setting);
			}

			if (setting.PajakOmzetKenaPPn) {
				if (setting.PajakGabungPPnNonNPWP) {
					var agenNonNpwp = agen.FindAll(f => f.NPWP == PPnKeluaranService.GetDefaultNPWP());
					if (agenNonNpwp.Count > 1) {
						agenNonNpwp.Remove(agenNonNpwp[0]);
						agen.RemoveAll(a => agenNonNpwp.Contains(a));
					}
				}
				foreach (var ag in agen) SavePajakKoran(session, periode, ag, setting);
			}
			foreach (var ag in agen.GroupBy(g => g.Rute.Regional).Select(s => s.Key)) SaveGLKoran(session, periode, ag, setting);
		}

		private static void SaveGLKoran(UnitOfWork session, DateTime periode, Regional regional, IntegrasiSirkulasiSetting settingIntegrasi) {
			// cek requirement setting;
			//var settingGL = new GLSetting(session);

			var rute = new XPQuery<Rute>(session).Where(w => w.Regional == regional);
			foreach (var x in rute) {
				if (x.AkunPendapatan == null) throw new Exception(string.Format("Akun Omzet untuk wilayah {0} belum disetting", x.Nama));
				if (x.AkunPiutang == null) throw new Exception(string.Format("Akun Piutang untuk wilayah {0} belum disetting", x.Nama));
				if (x.AkunRetur == null) throw new Exception(string.Format("Akun Retur untuk wilayah {0} belum disetting", x.Nama));
			}
			var mataUang = session.GetObjectByKey<MataUang>(settingIntegrasi.MataUangDefault);
			if (mataUang == null) throw new Exception("Mata Uang default belum disetting");
			//var karyawan = session.GetObjectByKey<Kontak>(settingIntegrasi.KaryawanDefault);
			//if (karyawan == null) throw new Exception("Karyawan default belum disetting");
			var akunHutangPPn = session.GetObjectByKey<Akun>(settingIntegrasi.PajakCoaHutangPPn);
			if (settingIntegrasi.PajakOmzetKenaPPn && akunHutangPPn == null) throw new Exception("Coa hutang ppn belum disetting");

			//int angkaKoma = 0;
			//double pembagi = 0; //(double)(100 + settingPajak.PPnProsentase) / 100;

			// ========================= start mapping ============================
			MappingGLSirkulasi itemMapping = new XPQuery<MappingGLSirkulasi>(session).SingleOrDefault(w => w.Bulan == periode.Month && w.Tahun == periode.Year && w.Regional == regional);
			if (itemMapping == null) itemMapping = new MappingGLSirkulasi(session) { Bulan = periode.Month, Tahun = periode.Year, Regional = regional };
			if (itemMapping.GLId == null) itemMapping.GLId = new GlMain(session);
			itemMapping.GLId = GLService.GetItem(itemMapping.GLId);
			var originalData = (GlMain)itemMapping.GLId.Clone();

			// ===================== cache data by wilayah
			var queryData = new XPQuery<SirkulasiHarianDetail>(session).Where(w => w.Main.Tanggal.Year == periode.Year && w.Main.Tanggal.Month == periode.Month && w.Agen.Rute.Regional == regional).ToList();
			if (queryData.Sum(s => s.OmzetDikurangiRetur) == 0) {
				var gl = itemMapping.GLId;
				itemMapping.Delete();
				gl.Delete();
				session.CommitChanges();
				return;
			}

			// ======================================== start create detail ===========================================
			itemMapping.GLId.Regional = regional;
			itemMapping.GLId.Tanggal = new DateTime(periode.Year, periode.Month, DateTime.DaysInMonth(periode.Year, periode.Month));
			itemMapping.GLId.Kurs = 1;
			itemMapping.GLId.MataUang = mataUang.Simbol;
			//itemMapping.GLId.Kontak = karyawan;
			itemMapping.GLId.Uraian = string.Format("{0} {1} BULAN {2} : OPLAH={3}, RETUR={4}",
				settingIntegrasi.KeteranganOmzet, regional.Nama.ToUpper(), periode.ToString("MMMM yyyy"),
				queryData.Sum(s => s.Oplah).ToString("n0"),
				queryData.Sum(s => s.Retur).ToString("n0"));

			short i = 0;
			foreach (var wil in rute) {
				var qOmzet = queryData.Where(w => w.Agen.Rute == wil).Sum(s => s.Omzet);
				var qRetur = queryData.Where(w => w.Agen.Rute == wil).Sum(s => s.OmzetRetur);
				var qPiutang = queryData.Where(w => w.Agen.Rute == wil).Sum(s => s.OmzetDikurangiRetur);
				var qPajak = 0.0;

				if (settingIntegrasi.PajakOmzetKenaPPn) {
					var pembagi = (double)(100 + settingIntegrasi.PajakPersenPPn) / 100;
					var omzetBeforePPn = qOmzet / pembagi;
					var returBeforePPn = qRetur / pembagi;

					qPajak = (qOmzet - omzetBeforePPn) - (qRetur - returBeforePPn);
					qOmzet = omzetBeforePPn;
					qRetur = returBeforePPn;
				}

				// piutang
				if (qPiutang != 0) SaveGLKoranDetail(itemMapping.GLId.DetailForSave, ++i, wil.AkunPiutang, qPiutang, 0, mataUang, itemMapping.GLId.Uraian + " - " + wil.Nama);
				// piutang
				if (qRetur != 0) SaveGLKoranDetail(itemMapping.GLId.DetailForSave, ++i, wil.AkunRetur, qRetur, 0, mataUang, itemMapping.GLId.Uraian + " - " + wil.Nama);
				// pendapatan
				if (qOmzet != 0) SaveGLKoranDetail(itemMapping.GLId.DetailForSave, ++i, wil.AkunPendapatan, 0, qOmzet, mataUang, itemMapping.GLId.Uraian + " - " + wil.Nama);
				// ppn
				if (qPajak != 0) SaveGLKoranDetail(itemMapping.GLId.DetailForSave, ++i, akunHutangPPn, 0, qPajak, mataUang, itemMapping.GLId.Uraian + " - " + wil.Nama);
			}

			// delete jika ada kelebihan akun
			itemMapping.GLId.DetailForSave.RemoveAll(w => w.Urutan > i);

			GLService.SaveGL(session, itemMapping.GLId, session.IsNewObject(itemMapping.GLId) ? null : originalData, mataUang, FinaSumberDataJenis.JU, MainClass.GetModuleId());
			session.CommitChanges();
		}
		private static void SaveGLKoranDetail(List<GlMainDetailForSave> detail, short urutan, Akun akun, double debit, double kredit, MataUang mataUang, string keterangan) {
			var itemDetail = detail.Find(f => f.Urutan == urutan);
			if (itemDetail == null) { itemDetail = new GlMainDetailForSave() { Urutan = urutan }; detail.Add(itemDetail); }
			itemDetail.Akun = akun;
			itemDetail.Debit = debit;
			itemDetail.Kredit = kredit;
			itemDetail.MataUang = mataUang;
			itemDetail.Kurs = 1;
			itemDetail.DebitValas = 0;
			itemDetail.KreditValas = 0;
			itemDetail.Divisi = null;
			itemDetail.Keterangan = keterangan;
		}
		private static void SavePajakKoran(UnitOfWork session, DateTime periode, Agen agen, IntegrasiSirkulasiSetting settingIntegrasi) {
			if (!settingIntegrasi.PajakOmzetKenaPPn) return;
			if (settingIntegrasi.PajakPersenPPn == default) return;
			var regPajak = session.GetObjectByKey<RegionalPajak>(agen.Rute.Regional);
			if (regPajak == null) throw new Exception("Nama penanda tangan pajak belum disetting");
			if (settingIntegrasi.PajakGabungPPnNonNPWP && string.IsNullOrEmpty(settingIntegrasi.PajakGabungPPnNonNPWPAtasNama)) throw new Exception("Nama pelanggan faktur utk non NPWP belum disetting");

			if (settingIntegrasi.PajakGabungPPnNonNPWP && agen.NPWP == PPnKeluaranService.GetDefaultNPWP()) agen = null;
			// ========================= start mapping ============================
			MappingPajakSirkulasi itemMapping = new XPQuery<MappingPajakSirkulasi>(session).ToList().Find(w => w.Bulan == periode.Month && w.Tahun == periode.Year && w.Agen == agen);
			if (itemMapping == null) itemMapping = new MappingPajakSirkulasi(session) { Bulan = periode.Month, Tahun = periode.Year, Agen = agen };
			if (itemMapping.TaxId == null) itemMapping.TaxId = new PPnKeluaran(session);
			itemMapping.TaxId = PPnKeluaranService.GetItem(itemMapping.TaxId);
			var originalData = (PPnKeluaran)itemMapping.TaxId.Clone();

			// ===================== cache data
			List<SirkulasiHarianDetail> queryData;
			if (agen == null) {
				queryData = new XPQuery<SirkulasiHarianDetail>(session).Where(w => w.Agen.NPWP == PPnKeluaranService.GetDefaultNPWP() && w.Main.Tanggal.Month == periode.Month && w.Main.Tanggal.Year == periode.Year).ToList();
			}
			else {
				queryData = new XPQuery<SirkulasiHarianDetail>(session).Where(w => w.Agen == agen && w.Main.Tanggal.Month == periode.Month && w.Main.Tanggal.Year == periode.Year).ToList();
			}

			if (queryData.Sum(s => s.OmzetDikurangiRetur) == 0) {
				var tax = itemMapping.TaxId;
				itemMapping.Delete();
				tax.Delete();
				session.CommitChanges();
				return;
			}

			// ======================================== start create detail ===========================================
			double pembagi = (double)(100 + settingIntegrasi.PajakPersenPPn) / 100;
			var bruto = queryData.Sum(s => s.Omzet);
			var brutomurni = bruto / pembagi;
			var retur = queryData.Sum(s => s.OmzetRetur);
			var returmurni = retur / pembagi;

			itemMapping.TaxId.NamaPelanggan = agen == null ? settingIntegrasi.PajakGabungPPnNonNPWPAtasNama : agen.Nama;
			itemMapping.TaxId.AlamatPelanggan = agen == null || string.IsNullOrEmpty(agen.Alamat) ? regPajak.Id.Nama : agen.Alamat;
			itemMapping.TaxId.NPWPPelanggan = agen == null ? PPnKeluaranService.GetDefaultNPWP() : agen.NPWP;
			itemMapping.TaxId.NIKPelanggan = agen == null ? "-" : agen.NIK;
			itemMapping.TaxId.Tanggal = new DateTime(periode.Year, periode.Month, DateTime.DaysInMonth(periode.Year, periode.Month));
			itemMapping.TaxId.NomorInvoice = "KORAN " + periode.ToString("yyyyMM") + (agen != null ? agen.Id.ToString("0000") : "");
			itemMapping.TaxId.UangMuka = 0;
			itemMapping.TaxId.PPnPersen = settingIntegrasi.PajakPersenPPn;
			itemMapping.TaxId.PPnNominal = (decimal)((bruto - brutomurni) - (retur - returmurni));
			itemMapping.TaxId.Regional = regPajak;

			var detail = itemMapping.TaxId.DetailForSave.Take(1).SingleOrDefault();
			if (detail == null) detail = new PPnKeluaranDetailForSave();
			if (agen == null) detail.Nama = string.Format("{0} BULAN {1}", settingIntegrasi.KeteranganOmzet, periode.ToString("MMMM yyyy"));
			else detail.Nama = string.Format("{0} {1} BULAN {2}", settingIntegrasi.KeteranganOmzet, agen.Nama.ToUpper(), periode.ToString("MMMM yyyy"));
			detail.Qty = 1;
			detail.Harga = (decimal)(brutomurni - returmurni);
			detail.Diskon = 0;
			detail.ReferensiId = agen == null ? "1" : agen.Id.ToString();

			itemMapping.TaxId.DetailForSave = new List<PPnKeluaranDetailForSave>() { detail };

			PPnKeluaranService.SaveData(session, itemMapping.TaxId, session.IsNewObject(itemMapping.TaxId) ? null : originalData, ModuleId.SirkulasiKoran);
			session.CommitChanges();
		}

		public static void SavePembayaranKoran(UnitOfWork session, BayarKoran pembayaran) {
			var setting = new IntegrasiSirkulasiSetting(session);
			if (!setting.AktifkanIntegrasi) return;
			if (int.Parse(new DateTime(setting.PeriodeTahunMulai, setting.PeriodeBulanMulai, 1).ToString("yyyyMM")) > int.Parse(pembayaran.Tanggal.ToString("yyyyMM"))) return;

			// cek requirement setting;
			if (pembayaran.Agen.Rute.AkunPiutang == null) throw new Exception(string.Format("Akun Piutang untuk rute {0} belum disetting", pembayaran.Agen.Rute.Nama));
			if (pembayaran.Agen.Rute.AkunDiskon == null && pembayaran.Diskon > 0) throw new Exception(string.Format("Akun Diskon untuk rute {0} belum disetting", pembayaran.Agen.Rute.Nama));

			var mataUang = session.GetObjectByKey<MataUang>(setting.MataUangDefault);
			if (mataUang == null) throw new Exception("Mata Uang default belum disetting");

			// ======================================= start mapping ===========================================
			if (pembayaran.GLId == null) pembayaran.GLId = new GlMain(session);
			pembayaran.GLId = GLService.GetItem(pembayaran.GLId);
			var originalData = (GlMain)pembayaran.GLId.Clone();

			if (originalData.Tanggal.ToString("yyyyMM") != pembayaran.Tanggal.ToString("yyyyMM")) pembayaran.GLId.Kode = string.Empty;

			// ======================================== start create detail ===========================================
			FinaSumberDataJenis sumberData;
			pembayaran.GLId.Regional = pembayaran.Regional;
			pembayaran.GLId.Tanggal = pembayaran.Tanggal;
			pembayaran.GLId.Kurs = 1;
			pembayaran.GLId.MataUang = mataUang.Simbol;
			pembayaran.GLId.KontakNama = pembayaran.Agen.Nama;
			pembayaran.GLId.Uraian = string.Format("{0} {1} - NOMOR : {2}", setting.KeteranganPembayaran, pembayaran.Keterangan, pembayaran.Kode);

			short i = 0;
			switch (pembayaran.CaraBayar.Akun.TipeAkun) {
				case TipeAkun.Kas:
					sumberData = FinaSumberDataJenis.KM;
					pembayaran.GLId.AkunKasBank = pembayaran.CaraBayar.Akun;
					if (pembayaran.CaraBayar.Akun != originalData.AkunKasBank) pembayaran.GLId.Kode = string.Empty;
					break;
				case TipeAkun.Bank:
					sumberData = FinaSumberDataJenis.BM;
					pembayaran.GLId.AkunKasBank = pembayaran.CaraBayar.Akun;
					if (pembayaran.CaraBayar.Akun != originalData.AkunKasBank) pembayaran.GLId.Kode = string.Empty;
					break;
				default:
					sumberData = FinaSumberDataJenis.JU;
					pembayaran.GLId.AkunKasBank = null; i = 1;
					if (originalData.AkunKasBank != null) pembayaran.GLId.Kode = string.Empty;
					break;
			}

			// akun cara bayar JM
			if (i == 1) {
				if (pembayaran.TotalSetor < 0)
					SaveGLKoranDetail(pembayaran.GLId.DetailForSave, i, pembayaran.CaraBayar.Akun, 0, Math.Abs(pembayaran.TotalSetor), mataUang, "");
				else if (pembayaran.TotalSetor > 0)
					SaveGLKoranDetail(pembayaran.GLId.DetailForSave, i, pembayaran.CaraBayar.Akun, pembayaran.TotalSetor, 0, mataUang, "");
			}

			// diskon
			if (pembayaran.Diskon < 0)
				SaveGLKoranDetail(pembayaran.GLId.DetailForSave, ++i, pembayaran.Agen.Rute.AkunDiskon, 0, Math.Abs(pembayaran.Diskon), mataUang, "");
			else if (pembayaran.Diskon > 0)
				SaveGLKoranDetail(pembayaran.GLId.DetailForSave, ++i, pembayaran.Agen.Rute.AkunDiskon, pembayaran.Diskon, 0, mataUang, "");

			// piutang
			if (pembayaran.TotalBayar < 0)
				SaveGLKoranDetail(pembayaran.GLId.DetailForSave, ++i, pembayaran.Agen.Rute.AkunPiutang, Math.Abs(pembayaran.TotalBayar), 0, mataUang, "");
			else if (pembayaran.TotalBayar > 0)
				SaveGLKoranDetail(pembayaran.GLId.DetailForSave, ++i, pembayaran.Agen.Rute.AkunPiutang, 0, pembayaran.TotalBayar, mataUang, "");

			// delete jika ada kelebihan akun, kondisi jika ada edit dari JM ke Kas/Bank
			pembayaran.GLId.DetailForSave.RemoveAll(w => w.Urutan > i);

			GLService.SaveGL(session, pembayaran.GLId, session.IsNewObject(pembayaran.GLId) ? null : originalData, mataUang, sumberData, MainClass.GetModuleId());
		}
	}
}
