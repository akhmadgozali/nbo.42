using DevExpress.Data.Filtering;
using DevExpress.Xpo;
using NuSoft.NUI.Win.Forms.Modules.NuSoft011.Persistent;
using System;
using System.Linq;

namespace NuSoft.NUI.Win.Forms.Modules.NuSoft011.Services {
	internal class PelangganService : ServiceBase<Pelanggan> {
		internal PelangganService(UnitOfWork connection) : base(connection) { }
		internal PelangganService(UnitOfWork connection, Pelanggan originalDataEdit) : base(connection, originalDataEdit) { }

		protected internal override bool CheckBeforeDelete(Pelanggan obj) => true;
		protected internal override bool CheckBeforeSave(Pelanggan obj) {
			if (obj.Agen == null) throw new Utils.Exception("Masukkan agen pelanggan", -1);
			if (string.IsNullOrEmpty(obj.Kode)) throw new Utils.Exception("Masukkan kode pelanggan", -2);
			if (string.IsNullOrEmpty(obj.Nama)) throw new Utils.Exception("Masukkan nama pelanggan", -3);

			if (!uow.IsNewObject(obj) && _dataOriginalEdit.Kode == obj.Kode) return true;
			if (uow.FindObject<Pelanggan>(new BinaryOperator(nameof(Pelanggan.Kode), obj.Kode, BinaryOperatorType.Equal)) != null)
				throw new Utils.Exception("Kode pelanggan sudah ada yang memakai.\r\nSilahkan ganti kode yang lain", -2);

			return true;
		}
		protected internal override void SaveAction(Pelanggan obj) {
			if (uow.IsNewObject(obj)) SetStatusPelanggan(uow, obj, obj.JumlahExpAwal, obj.TanggalMulaiLangganan, ModeStatusPelanggan.Aktifkan, "Mulai berlangganan pada tanggal " + obj.TanggalMulaiLangganan.ToString("dd MMMM yyyy"));
		}

		public enum ModeStatusPelanggan {
			NonAktifkan,
			Aktifkan,
			TambahExp
		}

		public static int GetNomor(UnitOfWork session, string maskKode) {
			var data = new XPQuery<Pelanggan>(session).Where(w => w.Kode.StartsWith(maskKode)).ToList();
			if (data.Count > 0) {
				var kode = data.OrderByDescending(o => o.Kode).FirstOrDefault();
				if (kode == null) return 1;

				var nomor = kode.Kode.Split('-')[1];
				if (nomor == "_____") return 1;
				return int.Parse(nomor) + 1;
			}
			else return 1;
		}
		public static void SetStatusPelanggan(UnitOfWork session, Pelanggan obj, int JumlahExp, DateTime tanggal, ModeStatusPelanggan status, string keterangan) {
			if (tanggal == null) throw new Exception("Masukkan tanggal");
			if (string.IsNullOrEmpty(keterangan)) throw new Exception("Masukkan keterangan");

			var item = new PelangganHistory(session) {
				JumlahExp = JumlahExp,
				Aktif = status == ModeStatusPelanggan.NonAktifkan ? false : true,
				Keterangan = keterangan,
				Pelanggan = obj,
				Tanggal = tanggal
			};
		}

		//public static List<PelangganForReport> GetDataPelanggan(JCon session, int Tahun, int Bulan) {
		//	var periodeIni = new DateTime(Tahun, Bulan, DateTime.DaysInMonth(Tahun, Bulan));
		//	var periodeLalu = periodeIni.AddMonths(-1);
		//	var sirkulasiSetting = new SirkulasiSetting(session);
		//	var data = new XPQuery<HistoryPelanggan>(session).Where(w => w.Tanggal.Date <= periodeIni).ToList();
		//	var dataLalu = data.Where(w => w.Tanggal.Date <= periodeLalu).GroupBy(g => g.Pelanggan)
		//		.Select(s => new { Pelanggan = s.Key, JmlExp = s.Sum(d => d.JumlahExpAktif - d.JumlahExpNonAktif), TglMasuk = s.Min(d => d.Tanggal) })
		//		.ToList();
		//	var dataIni = data.Where(w => w.Tanggal.Month == Bulan && w.Tanggal.Year == Tahun).ToList();
		//	var result = new List<PelangganForReport>();

		//	if (!sirkulasiSetting.HargaPelangganProporsional)
		//	{
		//		dataIni = new List<HistoryPelanggan>();
		//		dataLalu = data.GroupBy(g => g.Pelanggan)
		//			.Select(s => new { Pelanggan = s.Key, JmlExp = s.Sum(d => d.JumlahExpAktif - d.JumlahExpNonAktif), TglMasuk = s.Min(d => d.Tanggal) })
		//			.ToList();
		//	}

		//	foreach (var d in dataLalu)
		//	{
		//		result.Add(new PelangganForReport()
		//		{
		//			KategoriPelanggan = string.Empty,
		//			Tanggal = d.TglMasuk,
		//			Pelanggan = d.Pelanggan,
		//			Aktif = d.JmlExp > 0,
		//			Harga = d.Pelanggan.HargaPelanggan,
		//			JumlahExp = d.JmlExp
		//		});
		//	}
		//	foreach (var d in dataIni)
		//	{
		//		var selisihHari = d.Aktif ? DateTime.DaysInMonth(d.Tanggal.Year, d.Tanggal.Month) - d.Tanggal.Day + 1 : d.Tanggal.Day;
		//		var pembagi = sirkulasiSetting.HargaHarianPelangganDibagi30 ? 30 : DateTime.DaysInMonth(d.Tanggal.Year, d.Tanggal.Month);
		//		result.Add(new PelangganForReport()
		//		{
		//			KategoriPelanggan = d.Aktif ? "LANGGANAN BARU" : "STOP LANGGANAN",
		//			Tanggal = d.Tanggal,
		//			Pelanggan = d.Pelanggan,
		//			Aktif = d.Aktif,
		//			JumlahExp = d.JumlahExp,
		//			Harga = sirkulasiSetting.HargaPelangganProporsional ? (d.Pelanggan.HargaPelanggan / pembagi) * selisihHari : d.Pelanggan.HargaPelanggan
		//		});
		//		if (!d.Aktif)
		//		{
		//			var find = result.Find(f => f.Pelanggan == d.Pelanggan && f.KategoriPelanggan == string.Empty);
		//			if (find != null) find.Harga = 0;
		//		}
		//	}

		//	return result;
		//}
	}
	internal class KomplainPelangganService : ServiceBase<PelangganKomplain> {
		internal KomplainPelangganService(UnitOfWork connection) : base(connection) { }
		internal KomplainPelangganService(UnitOfWork connection, PelangganKomplain originalDataEdit) : base(connection, originalDataEdit) { }

		protected internal override bool CheckBeforeDelete(PelangganKomplain obj) => true;
		protected internal override bool CheckBeforeSave(PelangganKomplain obj) {
			if (obj.Pelanggan == null) throw new Utils.Exception("Masukkan pelanggan", -1);
			if (obj.Tanggal == null || obj.Tanggal == default(DateTime)) throw new Utils.Exception("Masukkan tanggal", -2);
			if (string.IsNullOrEmpty(obj.Penerima)) throw new Utils.Exception("Masukkan nama penerima komplain", -3);
			if (string.IsNullOrEmpty(obj.Keluhan)) throw new Utils.Exception("Masukkan keluhan pelanggan", -4);

			return true;
		}
	}
}
