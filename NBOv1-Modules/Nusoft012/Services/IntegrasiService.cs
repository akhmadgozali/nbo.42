using DevExpress.Data.Filtering;
using DevExpress.Xpo;
using NuSoft.NPO.Modules.ModSys;
using NuSoft.NUI.Win.Forms.Modules.NuSoft001.Persistent;
using NuSoft.NUI.Win.Forms.Modules.NuSoft007.Persistent;
using NuSoft.NUI.Win.Forms.Modules.NuSoft007.Services;
using NuSoft.NUI.Win.Forms.Modules.NuSoft012.Persistent;
using System;
using System.Collections.Generic;
using System.Linq;

namespace NuSoft.NUI.Win.Forms.Modules.NuSoft012.Services {
	internal class IntegrasiService {
		internal static List<MappingAkunIklan> GetIklanMappingAkun(UnitOfWork session) {
			var regional = new XPQuery<Regional>(session).ToList();
			var existing = new XPQuery<MappingAkunIklan>(session).ToList();

			foreach (var reg in regional) {
				var kolom = existing.Find(f => f.Regional == reg && f.TipeIklan == ETipeIklan.Kolom);
				if (kolom == null) {
					existing.Add(new MappingAkunIklan(session) { Regional = reg, TipeIklan = ETipeIklan.Kolom });
				}
				var deret = existing.Find(f => f.Regional == reg && f.TipeIklan == ETipeIklan.Deret);
				if (deret == null) {
					existing.Add(new MappingAkunIklan(session) { Regional = reg, TipeIklan = ETipeIklan.Deret });
				}
			}

			return existing;
		}
		internal static bool CekPeriodeTutupBuku(UnitOfWork session, DateTime Tanggal) {
			var item = session.FindObject<PeriodeAkuntansi>(new GroupOperator(GroupOperatorType.And,
				new BinaryOperator(nameof(PeriodeAkuntansi.Tahun), Tanggal.Year, BinaryOperatorType.Equal),
				new BinaryOperator(nameof(PeriodeAkuntansi.Bulan), Tanggal.Month, BinaryOperatorType.Equal)));

			return item != null && item.Tutup;
		}
		internal static List<KeyValuePair<DateTime, string>> GetPeriode(UnitOfWork session) {
			var periode = new List<KeyValuePair<DateTime, string>>();
			var aaa = new XPQuery<PeriodeAkuntansi>(session).Select(s => s.Periode).ToList();
			foreach (var x in aaa.OrderByDescending(o => o))
				periode.Add(new KeyValuePair<DateTime, string>(x, x.ToString("MMMM yyyy")));

			return periode;
		}

		internal static void SavePajakIklan(UnitOfWork session, Invoice invoice) {
			if (invoice.TaxId == null) invoice.TaxId = new PPnKeluaran(session);
			invoice.TaxId = PPnKeluaranService.GetItem(invoice.TaxId);
			var originalData = (PPnKeluaran)invoice.TaxId.Clone();
			var settingIklan = new IntegrasiIklanSetting(session);

			// ======================================== start create detail ===========================================
			if (session.IsNewObject(invoice.TaxId)) {
				invoice.TaxId.KodeTransaksi = invoice.Pemasang == null ? "01" : invoice.Pemasang.KodeFaktur;
			}
			invoice.TaxId.NamaPelanggan = invoice.InvoiceNama;
			invoice.TaxId.AlamatPelanggan = invoice.InvoiceAlamat;
			invoice.TaxId.NPWPPelanggan = invoice.InvoiceNPWP;
			invoice.TaxId.NIKPelanggan = invoice.InvoiceNIK;
			invoice.TaxId.Tanggal = invoice.TanggalInvoiceKoreksi;
			invoice.TaxId.NomorInvoice = invoice.NoInvoice;
			invoice.TaxId.UangMuka = 0;
			invoice.TaxId.PPnPersen = invoice.PajakPersen;
			invoice.TaxId.PPnNominal = invoice.PajakNominalGabungan;
			invoice.TaxId.Regional = session.GetObjectByKey<RegionalPajak>(invoice.Wilayah.Regional);

			var listInvoice = new List<Invoice>() { invoice };
			listInvoice.AddRange(invoice.DaftarAnak);

			// remove detail
			for (var i = invoice.TaxId.DetailForSave.Count - 1; i >= 0; i--) {
				var tax1 = invoice.TaxId.DetailForSave[i];
				var find = listInvoice.Find(f => f.Id.ToString() == tax1.ReferensiId);
				if (find == null) { invoice.TaxId.DetailForSave.Remove(tax1); }
			}
			// hapus pajak di anak
			foreach (var inv in listInvoice) {
				if (inv != invoice && inv.TaxId != null) {
					var deletedPPn = inv.TaxId;
					inv.TaxId = null;
					deletedPPn.Delete();
				}
			}
			// Insert Update
			//var msg = "";
			foreach (var inv in listInvoice) {
				var find = invoice.TaxId.DetailForSave.Find(f => f.ReferensiId == inv.Id.ToString());
				if (find == null) {
					find = new PPnKeluaranDetailForSave() { ReferensiId = inv.Id.ToString() };
					invoice.TaxId.DetailForSave.Add(find);
					//msg += "id = " + inv.Id.ToString() + " / new \r\n";
				}
				//else msg += "id = " + inv.Id.ToString() + " / edit \r\n";

				find.Nama = string.Format("{0}", inv.JudulIklan);
				if (settingIklan.PajakTampilkanUkuran && inv.UkuranX > 0 && inv.UkuranY > 0)
					find.Nama = string.Format("{0}\r\nUKURAN : {1} KOLOM x {2} MM", find.Nama, inv.UkuranX, inv.UkuranY);
				if (settingIklan.PajakTampilkanTanggalTerbit)
					find.Nama = string.Format("{0}\r\nTERBIT : {1}", find.Nama, inv.TanggalTerbit);

				find.Qty = 1;
				find.Harga = inv.BrutoKoreksi;
				find.Diskon = inv.DiskonNominalKoreksi;
			}

			//throw new Exception(msg + "jumlah row = " + invoice.TaxId.DetailForSave.Count);
			PPnKeluaranService.SaveData(session, invoice.TaxId, session.IsNewObject(invoice.TaxId) ? null : originalData, MainClass.GetModuleId());
		}
		internal static void SavePajakPPh23(UnitOfWork session, PembayaranIklanDetail bayarIklan) {
			if (bayarIklan.PPh23Id == null) bayarIklan.PPh23Id = new PPh23(session);
			var originalData = (PPh23)bayarIklan.PPh23Id.Clone();

			// ======================================== start create detail ===========================================
			bayarIklan.PPh23Id.NoInvoice = bayarIklan.Invoice.NoInvoice;
			bayarIklan.PPh23Id.NoKwitansi = bayarIklan.Pembayaran.NoKwitansi;
			bayarIklan.PPh23Id.TanggalInvoice = bayarIklan.Invoice.TanggalInvoice;
			bayarIklan.PPh23Id.TanggalKwitansi = bayarIklan.Pembayaran.Tanggal;
			bayarIklan.PPh23Id.Wilayah = bayarIklan.Invoice.Wilayah.Nama;
			bayarIklan.PPh23Id.KeteranganInvoice = bayarIklan.Invoice.InvoiceKeterangan;
			bayarIklan.PPh23Id.Pemasang = bayarIklan.Invoice.InvoiceNama;
			bayarIklan.PPh23Id.DppPPh23 = bayarIklan.Invoice.Netto;
			bayarIklan.PPh23Id.PPh23Persen = bayarIklan.Pembayaran.CaraBayar.PPh23Persen;
			bayarIklan.PPh23Id.PPh23Nominal = bayarIklan.NominalBayar;

			PPh23Service.SaveData(session, bayarIklan.PPh23Id, session.IsNewObject(bayarIklan.PPh23Id) ? null : originalData, MainClass.GetModuleId());
		}
		internal static void SavePajakPPh21(UnitOfWork session, PencairanKomisiDetail bayarKomisi) {
			if (bayarKomisi.PPh21KomisiId == null) bayarKomisi.PPh21KomisiId = new PPh21Komisi(session);
			var originalData = (PPh21Komisi)bayarKomisi.PPh21KomisiId.Clone();

			// ======================================== start create detail ===========================================
			bayarKomisi.PPh21KomisiId.NoInvoice = bayarKomisi.Komisi.Invoice.NoInvoice;
			bayarKomisi.PPh21KomisiId.NoKwitansi = bayarKomisi.Komisi.Pembayaran.NoKwitansi;
			bayarKomisi.PPh21KomisiId.TanggalInvoice = bayarKomisi.Komisi.Invoice.TanggalInvoice;
			bayarKomisi.PPh21KomisiId.TanggalKwitansi = bayarKomisi.Komisi.Pembayaran.Tanggal;
			bayarKomisi.PPh21KomisiId.Wilayah = bayarKomisi.Komisi.Invoice.Wilayah.Nama;
			bayarKomisi.PPh21KomisiId.KeteranganInvoice = bayarKomisi.Komisi.Invoice.InvoiceKeterangan;
			bayarKomisi.PPh21KomisiId.Penerima = bayarKomisi.Komisi.Invoice.Sales.Nama;
			bayarKomisi.PPh21KomisiId.NPWPPenerima = bayarKomisi.Komisi.Invoice.Sales.NPWP;
			bayarKomisi.PPh21KomisiId.DppKomisi = bayarKomisi.Komisi.Invoice.Netto - bayarKomisi.Komisi.Invoice.CashbackNominal - bayarKomisi.Komisi.Invoice.PotonganKomisiNominal;
			bayarKomisi.PPh21KomisiId.KomisiPersen = bayarKomisi.Komisi.KomisiPersen;
			bayarKomisi.PPh21KomisiId.KomisiNominal = bayarKomisi.Komisi.KomisiNominal;
			bayarKomisi.PPh21KomisiId.TarifPPh21 = TarihPPh17Service.GetTarif(session, bayarKomisi.Komisi.KomisiNominal);
			bayarKomisi.PPh21KomisiId.PPh21 = bayarKomisi.NominalCair;

			PPh21KomisiService.SaveData(session, bayarKomisi.PPh21KomisiId, session.IsNewObject(bayarKomisi.PPh21KomisiId) ? null : originalData, MainClass.GetModuleId());
		}

		internal static void SaveGLIklan(UnitOfWork session, Invoice invoice, Invoice invoiceLama) {
			DateTime tglLama = default(DateTime);
			Regional regLama = null;

			if (invoiceLama != null) {
				tglLama = invoiceLama.TanggalOmzet;
				regLama = invoiceLama.Wilayah.Regional;
			}

			SaveGLIklan(session, invoice.TanggalOmzet, tglLama, new List<Regional>() { invoice.Wilayah.Regional }, new List<Regional>() { regLama });
		}
		internal static void SaveGLIklan(UnitOfWork session, DateTime periode) {
			SaveGLIklan(session, periode, default, new XPQuery<Regional>(session).ToList(), null);
		}
		internal static void SaveGLIklan(UnitOfWork session, DateTime periode, DateTime periodeLama, List<Regional> regional, List<Regional> regionalLama) {
			var setting = new IntegrasiIklanSetting(session);
			if (!setting.AktifkanIntegrasi) return;
			if (int.Parse(new DateTime(setting.PeriodeTahunMulai, setting.PeriodeBulanMulai, 1).ToString("yyyyMM")) > int.Parse(periode.ToString("yyyyMM"))) return;

			if (periodeLama != default && periode.ToString("yyyyMM") != periodeLama.ToString("yyyyMM")) {
				foreach (var ag in regionalLama) SaveGLIklan(session, setting, periodeLama, ag);
			}
			foreach (var ag in regional) SaveGLIklan(session, setting, periode, ag);
		}

		private static void SaveGLIklan(UnitOfWork session, IntegrasiIklanSetting settingIntegrasiIklan, DateTime periode, Regional regional) {
			// ====   cache data   ====
			var queryData = new XPQuery<Invoice>(session)
				.Where(w => w.TanggalOmzet.Year == periode.Year && w.TanggalOmzet.Month == periode.Month && w.Wilayah.Regional == regional && !w.SaldoAwal)
				.GroupBy(g => g.TipeInvoice)
				.Select(s => new { TipeInvoice = s.Key, Bruto = s.Sum(a => a.Bruto), Diskon = s.Sum(a => a.DiskonNominal), PPn = s.Sum(a => a.PajakNominal), Piutang = s.Sum(a => a.Total) })
				.ToList();
			var jmlPendapatan = queryData.Sum(m => m.Bruto);
			var jmlPpn = queryData.Sum(m => m.PPn);

			// cek requirement setting;
			foreach (var map in queryData) {
				if (map.TipeInvoice.AkunPiutang == null) throw new Exception(string.Format("Akun Piutang untuk tipe {0} belum disetting", map.TipeInvoice.Nama));
				if (map.TipeInvoice.AkunPendapatan == null) throw new Exception(string.Format("Akun Pendapatan untuk tipe {0} belum disetting", map.TipeInvoice.Nama));
				if (map.TipeInvoice.AkunDiskon == null) throw new Exception(string.Format("Akun Diskon untuk tipe {0} belum disetting", map.TipeInvoice.Nama));
			}
			var akunPPn = session.GetObjectByKey<Akun>(settingIntegrasiIklan.CoaHutangPPn);
			if (akunPPn == null && jmlPpn > 0) throw new Exception("Akun PPn belum disetting");
			var mataUang = session.GetObjectByKey<MataUang>(settingIntegrasiIklan.MataUangDefault);
			if (mataUang == null) throw new Exception("Mata Uang default belum disetting");

			// ========================= start mapping ============================
			MappingGLIklan itemMapping = new XPQuery<MappingGLIklan>(session).SingleOrDefault(w => w.Bulan == periode.Month && w.Tahun == periode.Year && w.Regional == regional);
			if (itemMapping == null) itemMapping = new MappingGLIklan(session) { Bulan = periode.Month, Tahun = periode.Year, Regional = regional };
			if (itemMapping.GlId == null) itemMapping.GlId = new GlMain(session);
			itemMapping.GlId = GLService.GetItem(itemMapping.GlId);
			var originalData = (GlMain)itemMapping.GlId.Clone();

			if (jmlPendapatan == 0) {
				var gl = itemMapping.GlId;
				itemMapping.Delete();
				gl.Delete();
				session.CommitChanges();
				return;
			}

			// ======================================== start create detail ===========================================
			itemMapping.GlId.Regional = regional;
			itemMapping.GlId.Tanggal = new DateTime(periode.Year, periode.Month, DateTime.DaysInMonth(periode.Year, periode.Month));
			itemMapping.GlId.Kurs = 1;
			itemMapping.GlId.MataUang = mataUang.Simbol;
			itemMapping.GlId.Uraian = string.Format("{0} {1} BULAN {2}",
				settingIntegrasiIklan.KeteranganOmzet, regional.Nama.ToUpper(), periode.ToString("MMMM yyyy"));

			short i = 0;
			foreach (var data in queryData) {
				// piutang
				if (data.Piutang != 0) SaveGLIklanDetail(itemMapping.GlId.DetailForSave, ++i, data.TipeInvoice.AkunPiutang, data.Piutang, 0, mataUang, itemMapping.GlId.Uraian + " - " + data.TipeInvoice.Nama);
				// diskon
				if (data.Diskon != 0) SaveGLIklanDetail(itemMapping.GlId.DetailForSave, ++i, data.TipeInvoice.AkunDiskon, data.Diskon, 0, mataUang, itemMapping.GlId.Uraian + " - " + data.TipeInvoice.Nama);
				// pendapatan
				if (data.Bruto != 0) SaveGLIklanDetail(itemMapping.GlId.DetailForSave, ++i, data.TipeInvoice.AkunPendapatan, 0, data.Bruto, mataUang, itemMapping.GlId.Uraian + " - " + data.TipeInvoice.Nama);
				// ppn
				if (data.PPn != 0) SaveGLIklanDetail(itemMapping.GlId.DetailForSave, ++i, akunPPn, 0, data.PPn, mataUang, itemMapping.GlId.Uraian + " - " + data.TipeInvoice.Nama);
			}

			// delete jika ada kelebihan akun
			itemMapping.GlId.DetailForSave.RemoveAll(w => w.Urutan > i);

			GLService.SaveGL(session, itemMapping.GlId, session.IsNewObject(itemMapping.GlId) ? null : originalData, mataUang, FinaSumberDataJenis.JU, MainClass.GetModuleId());
			session.CommitChanges();
		}
		private static void SaveGLIklanDetail(List<GlMainDetailForSave> detail, short urutan, Akun akun, decimal debit, decimal kredit, MataUang mataUang, string keterangan) {
			var itemDetail = detail.Find(f => f.Urutan == urutan);
			if (itemDetail == null) { itemDetail = new GlMainDetailForSave() { Urutan = urutan }; detail.Add(itemDetail); }
			itemDetail.Akun = akun;
			itemDetail.Debit = (double)debit;
			itemDetail.Kredit = (double)kredit;
			itemDetail.MataUang = mataUang;
			itemDetail.Kurs = 1;
			itemDetail.DebitValas = 0;
			itemDetail.KreditValas = 0;
			itemDetail.Divisi = null;
			itemDetail.Keterangan = keterangan;
		}

		internal static void SavePembayaranIklan(UnitOfWork session, PembayaranIklan pembayaran) {
			var setting = new IntegrasiIklanSetting(session);
			if (!setting.AktifkanIntegrasi) return;
			if (int.Parse(new DateTime(setting.PeriodeTahunMulai, setting.PeriodeBulanMulai, 1).ToString("yyyyMM")) > int.Parse(pembayaran.Tanggal.ToString("yyyyMM"))) return;

			// ========== cache data   =============
			var queryData = pembayaran.Detail.GroupBy(g => g.Invoice.TipeInvoice.AkunPiutang)
				.Select(s => new { AkunPiutang = s.Key, Bayar = s.Sum(a => a.NominalBayar) })
				.ToList();

			// cek requirement setting;
			foreach (var x in queryData) {
				if (x.AkunPiutang == null) throw new Exception("Akun piutang belum disetting");
			}

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
			pembayaran.GLId.KontakNama = pembayaran.AtasNama;
			pembayaran.GLId.Uraian = pembayaran.Keterangan + "; NOMOR = " + pembayaran.NoKwitansi;

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
				if (pembayaran.JumlahBayar < 0)
					SaveGLIklanDetail(pembayaran.GLId.DetailForSave, i, pembayaran.CaraBayar.Akun, 0, Math.Abs(pembayaran.JumlahBayar), mataUang, "");
				else if (pembayaran.JumlahBayar > 0)
					SaveGLIklanDetail(pembayaran.GLId.DetailForSave, i, pembayaran.CaraBayar.Akun, pembayaran.JumlahBayar, 0, mataUang, "");
			}

			foreach (var que in queryData) {
				if (pembayaran.JumlahBayar < 0)
					SaveGLIklanDetail(pembayaran.GLId.DetailForSave, ++i, que.AkunPiutang, Math.Abs(que.Bayar), 0, mataUang, "");
				else if (pembayaran.JumlahBayar > 0)
					SaveGLIklanDetail(pembayaran.GLId.DetailForSave, ++i, que.AkunPiutang, 0, que.Bayar, mataUang, "");
			}

			// ambil yang lunas, jika ada komisi / cashback buat jurnal hutang komisi dan biayanya
			var queryHutangCashback = pembayaran.Detail.Where(w => w.Lunas && w.CashbackNominal > 0).GroupBy(g => g.Invoice.TipeInvoice.AkunHutangCashback)
				.Select(s => new { AkunHutangCashback = s.Key, Cashback = s.Sum(a => a.CashbackNominal) }).ToList();
			var queryBiayaCashback = pembayaran.Detail.Where(w => w.Lunas && w.CashbackNominal > 0).GroupBy(g => g.Invoice.TipeInvoice.AkunBiayaCashback)
				.Select(s => new { AkunBiayaCashback = s.Key, Cashback = s.Sum(a => a.CashbackNominal) }).ToList();
			var queryHutangKomisi = pembayaran.Detail.Where(w => w.Lunas && w.KomisiNominal > 0).GroupBy(g => g.Invoice.TipeInvoice.AkunHutangKomisi)
				.Select(s => new { AkunHutangKomisi = s.Key, Komisi = s.Sum(a => a.KomisiNominal) }).ToList();
			var queryBiayaKomisi = pembayaran.Detail.Where(w => w.Lunas && w.KomisiNominal > 0).GroupBy(g => g.Invoice.TipeInvoice.AkunBiayaKomisi)
				.Select(s => new { AkunBiayaKomisi = s.Key, Komisi = s.Sum(a => a.KomisiNominal) }).ToList();
			foreach (var q in queryBiayaCashback) SaveGLIklanDetail(pembayaran.GLId.DetailForSave, ++i, q.AkunBiayaCashback, q.Cashback, 0, mataUang, "");
			foreach (var q in queryHutangCashback) SaveGLIklanDetail(pembayaran.GLId.DetailForSave, ++i, q.AkunHutangCashback, 0, q.Cashback, mataUang, "");
			foreach (var q in queryBiayaKomisi) SaveGLIklanDetail(pembayaran.GLId.DetailForSave, ++i, q.AkunBiayaKomisi, q.Komisi, 0, mataUang, "");
			foreach (var q in queryHutangKomisi) SaveGLIklanDetail(pembayaran.GLId.DetailForSave, ++i, q.AkunHutangKomisi, 0, q.Komisi, mataUang, "");

			// delete jika ada kelebihan akun, kondisi jika ada edit dari JM ke Kas/Bank
			pembayaran.GLId.DetailForSave.RemoveAll(w => w.Urutan > i);

			GLService.SaveGL(session, pembayaran.GLId, session.IsNewObject(pembayaran.GLId) ? null : originalData, mataUang, sumberData, MainClass.GetModuleId());
		}
		internal static void SavePencairanKomisi(UnitOfWork session, PencairanKomisi bayarKomisi) {
			var setting = new IntegrasiIklanSetting(session);
			if (!setting.AktifkanIntegrasi) return;
			if (int.Parse(new DateTime(setting.PeriodeTahunMulai, setting.PeriodeBulanMulai, 1).ToString("yyyyMM")) > int.Parse(bayarKomisi.Tanggal.ToString("yyyyMM"))) return;

			// ========== cache data   =============
			var queryData = bayarKomisi.Detail.GroupBy(g => g.Komisi.Invoice.TipeInvoice)
				.Select(s => new { TipeInvoice = s.Key, Bayar = s.Sum(a => a.NominalCair) })
				.ToList();

			// cek requirement setting;
			foreach (var x in queryData) {
				if (x.TipeInvoice.AkunHutangKomisi == null) throw new Exception(string.Format("Akun hutang komisi untuk tipe {0} belum disetting", x.TipeInvoice.Nama));
			}

			var mataUang = session.GetObjectByKey<MataUang>(setting.MataUangDefault);
			if (mataUang == null) throw new Exception("Mata Uang default belum disetting");

			// ======================================= start mapping ===========================================
			if (bayarKomisi.GLId == null) bayarKomisi.GLId = new GlMain(session);
			bayarKomisi.GLId = GLService.GetItem(bayarKomisi.GLId);
			var originalData = (GlMain)bayarKomisi.GLId.Clone();

			if (originalData.Tanggal.ToString("yyyyMM") != bayarKomisi.Tanggal.ToString("yyyyMM")) bayarKomisi.GLId.Kode = string.Empty;

			// ======================================== start create detail ===========================================
			FinaSumberDataJenis sumberData;
			bayarKomisi.GLId.Regional = bayarKomisi.Regional;
			bayarKomisi.GLId.Tanggal = bayarKomisi.Tanggal;
			bayarKomisi.GLId.Kurs = 1;
			bayarKomisi.GLId.MataUang = mataUang.Simbol;
			bayarKomisi.GLId.KontakNama = bayarKomisi.Sales.Nama;
			bayarKomisi.GLId.Uraian = bayarKomisi.Keterangan + "; NOMOR = " + bayarKomisi.NoBukti;

			short i = 0;
			switch (bayarKomisi.CaraBayar.Akun.TipeAkun) {
				case TipeAkun.Kas:
					sumberData = FinaSumberDataJenis.KK;
					bayarKomisi.GLId.AkunKasBank = bayarKomisi.CaraBayar.Akun;
					if (bayarKomisi.CaraBayar.Akun != originalData.AkunKasBank) bayarKomisi.GLId.Kode = string.Empty;
					break;
				case TipeAkun.Bank:
					sumberData = FinaSumberDataJenis.BK;
					bayarKomisi.GLId.AkunKasBank = bayarKomisi.CaraBayar.Akun;
					if (bayarKomisi.CaraBayar.Akun != originalData.AkunKasBank) bayarKomisi.GLId.Kode = string.Empty;
					break;
				default:
					sumberData = FinaSumberDataJenis.JU;
					bayarKomisi.GLId.AkunKasBank = null; i = 1;
					if (originalData.AkunKasBank != null) bayarKomisi.GLId.Kode = string.Empty;
					break;
			}

			// akun cara bayar JM
			if (i == 1) {
					SaveGLIklanDetail(bayarKomisi.GLId.DetailForSave, i, bayarKomisi.CaraBayar.Akun, 0, bayarKomisi.JumlahPencairan, mataUang, "");
			}

			foreach (var que in queryData) {
					SaveGLIklanDetail(bayarKomisi.GLId.DetailForSave, ++i, que.TipeInvoice.AkunPiutang, que.Bayar, 0, mataUang, "");
			}

			// delete jika ada kelebihan akun, kondisi jika ada edit dari JM ke Kas/Bank
			bayarKomisi.GLId.DetailForSave.RemoveAll(w => w.Urutan > i);

			GLService.SaveGL(session, bayarKomisi.GLId, session.IsNewObject(bayarKomisi.GLId) ? null : originalData, mataUang, sumberData, MainClass.GetModuleId());
		}
		internal static void SavePencairanCashback(UnitOfWork session, PencairanCashback bayarCashback) {
			var setting = new IntegrasiIklanSetting(session);
			if (!setting.AktifkanIntegrasi) return;
			if (int.Parse(new DateTime(setting.PeriodeTahunMulai, setting.PeriodeBulanMulai, 1).ToString("yyyyMM")) > int.Parse(bayarCashback.Tanggal.ToString("yyyyMM"))) return;

			// ========== cache data   =============
			var queryData = bayarCashback.Detail.GroupBy(g => g.Cashback.Invoice.TipeInvoice)
				.Select(s => new { TipeInvoice = s.Key, Bayar = s.Sum(a => a.NominalCair) })
				.ToList();

			// cek requirement setting;
			foreach (var x in queryData) {
				if (x.TipeInvoice.AkunHutangCashback == null) throw new Exception(string.Format("Akun hutang cashback untuk tipe {0} belum disetting", x.TipeInvoice.Nama));
			}

			var mataUang = session.GetObjectByKey<MataUang>(setting.MataUangDefault);
			if (mataUang == null) throw new Exception("Mata Uang default belum disetting");

			// ======================================= start mapping ===========================================
			if (bayarCashback.GLId == null) bayarCashback.GLId = new GlMain(session);
			bayarCashback.GLId = GLService.GetItem(bayarCashback.GLId);
			var originalData = (GlMain)bayarCashback.GLId.Clone();

			if (originalData.Tanggal.ToString("yyyyMM") != bayarCashback.Tanggal.ToString("yyyyMM")) bayarCashback.GLId.Kode = string.Empty;

			// ======================================== start create detail ===========================================
			FinaSumberDataJenis sumberData;
			bayarCashback.GLId.Regional = bayarCashback.Regional;
			bayarCashback.GLId.Tanggal = bayarCashback.Tanggal;
			bayarCashback.GLId.Kurs = 1;
			bayarCashback.GLId.MataUang = mataUang.Simbol;
			bayarCashback.GLId.KontakNama = bayarCashback.Pemasang;
			bayarCashback.GLId.Uraian = bayarCashback.Keterangan + "; NOMOR = " + bayarCashback.NoBukti;

			short i = 0;
			switch (bayarCashback.CaraBayar.Akun.TipeAkun) {
				case TipeAkun.Kas:
					sumberData = FinaSumberDataJenis.KK;
					bayarCashback.GLId.AkunKasBank = bayarCashback.CaraBayar.Akun;
					if (bayarCashback.CaraBayar.Akun != originalData.AkunKasBank) bayarCashback.GLId.Kode = string.Empty;
					break;
				case TipeAkun.Bank:
					sumberData = FinaSumberDataJenis.BK;
					bayarCashback.GLId.AkunKasBank = bayarCashback.CaraBayar.Akun;
					if (bayarCashback.CaraBayar.Akun != originalData.AkunKasBank) bayarCashback.GLId.Kode = string.Empty;
					break;
				default:
					sumberData = FinaSumberDataJenis.JU;
					bayarCashback.GLId.AkunKasBank = null; i = 1;
					if (originalData.AkunKasBank != null) bayarCashback.GLId.Kode = string.Empty;
					break;
			}

			// akun cara bayar JM
			if (i == 1) {
				SaveGLIklanDetail(bayarCashback.GLId.DetailForSave, i, bayarCashback.CaraBayar.Akun, 0, bayarCashback.JumlahPencairan, mataUang, "");
			}

			foreach (var que in queryData) {
				SaveGLIklanDetail(bayarCashback.GLId.DetailForSave, ++i, que.TipeInvoice.AkunPiutang, que.Bayar, 0, mataUang, "");
			}

			// delete jika ada kelebihan akun, kondisi jika ada edit dari JM ke Kas/Bank
			bayarCashback.GLId.DetailForSave.RemoveAll(w => w.Urutan > i);

			GLService.SaveGL(session, bayarCashback.GLId, session.IsNewObject(bayarCashback.GLId) ? null : originalData, mataUang, sumberData, MainClass.GetModuleId());
		}
	}
}
