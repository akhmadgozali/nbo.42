using DevExpress.Data.Filtering;
using DevExpress.Xpo;
using NuSoft.Core.Modules;
using NuSoft.NPO.Modules;
using NuSoft.NPO.Modules.ModSys;
using NuSoft.NUI.Win.Forms.Modules.NuSoft001.Persistent;
using NuSoft.NUI.Win.Forms.Modules.NuSoft012.Persistent;
using NuSoft.Utils.CustomAttribute;
using System.Collections.Generic;
using System.Linq;

namespace NuSoft.NUI.Win.Forms.Modules.NuSoft012.Services {
	internal class FinaNumberConst {
		public const string FormatSumber = "[S]";
		public const string FormatRegional = "[R]";
		public const string FormatAkun = "[A]";
	}
	internal class FinaNumberClass : NumberBase {
		internal FinaNumberClass(UnitOfWork uow) : base(uow) { }

		public override List<NumberFormat> RegisterFormat() {
			var result = new List<NumberFormat>();
			result.Add(AddRegister(FinaNumberConst.FormatAkun, 2, nameof(Akun.FormatNomor), nameof(Akun.Id)));
			result.Add(AddRegister(FinaNumberConst.FormatSumber, 2, nameof(SumberData.Kode), nameof(SumberData.Id)));
			result.Add(AddRegister(FinaNumberConst.FormatRegional, 3, nameof(Regional.Kode), nameof(Regional.Id)));
			return result;
		}
		public override string SequenceFormat() => "[X{0}]";
	}

	internal enum FinaSumberDataJenis {
		[EnumDescription("Kas Masuk")] KM = 1,
		[EnumDescription("Kas Keluar")] KK = 2,
		[EnumDescription("Bank Masuk")] BM = 3,
		[EnumDescription("Bank Keluar")] BK = 4,
		[EnumDescription("Jurnal Umum")] JU = 5
	}
	internal class FinaSumberDataCollection : SumberDataCollection<FinaSumberDataJenis> {
		internal FinaSumberDataCollection(UnitOfWork session) : base(session) { }
		public override ModuleId ModuleId() => NPO.Modules.ModuleId.Fina;
	}

	internal class FinaSetting : SettingBase {
		public FinaSetting(UnitOfWork connection) : base(connection) { }
		public override ModuleId ModuleId() {
			return NPO.Modules.ModuleId.Fina;
		}

		public string FormatNomor { get; set; }
	}

	internal class AkunService {
		public static List<Akun> GetAkunCollection(UnitOfWork session, bool childOnly, params TipeAkun[] tipeAkun) {
			CriteriaOperator criteria = new NotOperator(new NullOperator(nameof(Akun.Id)));
			if (childOnly) {
				criteria = CriteriaOperator.And(criteria, new BinaryOperator(nameof(Akun.IsInduk), false));
			}
			if (tipeAkun.GetUpperBound(0) >= 0) criteria = CriteriaOperator.And(criteria, new InOperator(nameof(Akun.TipeAkun), tipeAkun));

			return new XPCollection<Akun>(session, criteria).ToList();
		}
	}
	internal class GLService {
		public static GlMain GetItem(GlMain obj) {
			List<GlMainDetailForSave> temp = new List<GlMainDetailForSave>();
			if (obj.Detail != null)
				foreach (var det in obj.Detail.Where(w => w.Urutan != 0)) {
					temp.Add(new GlMainDetailForSave() {
						Id = det.Id,
						Urutan = det.Urutan,
						Akun = det.Akun,
						Debit = det.Debit,
						Kredit = det.Kredit,
						Kurs = det.Kurs,
						DebitValas = det.DebitValas,
						KreditValas = det.KreditValas,
						Divisi = det.Divisi,
						MataUang = det.MataUang,
						Rekonsiliasi = det.Rekonsiliasi,
						Keterangan = det.Keterangan
					});
				}

			obj.DetailForSave = temp;
			return obj;
		}

		public static bool CheckItemBeforeSave(UnitOfWork session, GlMain obj, GlMain originalEdit) {
			if (obj.Regional == null) throw new Utils.Exception("Masukkan regional", -1);
			//if (obj.SumberData == null) throw new Utils.Exception("Masukkan sumber asal transaksi", -2);
			if (string.IsNullOrEmpty(obj.Uraian)) throw new Utils.Exception("Masukkan keterangan", -3);
			if (obj.Tanggal == null) throw new Utils.Exception("Masukkan tanggal transaksi", -4);
			//if (obj.Kontak == null) throw new Utils.Exception("Masukkan kontak", -5);

			// detail
			if (obj.DetailForSave == null || !(obj.DetailForSave.Count > 0)) throw new Utils.Exception("Masukkan detail transaksi", -6);
			foreach (var detail in obj.DetailForSave)
			{
				if (detail.Akun == null) throw new Utils.Exception("Masukkan akun", -6);
				if (detail.Debit + detail.Kredit == 0) throw new Utils.Exception("Masukkan jumlah nominal pada akun " + detail.Akun.Kode + " - " + detail.Akun.Nama + "\r\nDebit = " + detail.Debit.ToString("n2") + "\r\nKredit = " + detail.Kredit.ToString("n2"), -6);
			}

			var debit = obj.DetailForSave.Sum(s => s.Debit);
			var kredit = obj.DetailForSave.Sum(s => s.Kredit);
			if (debit == 0) throw new Utils.Exception("Debit tidak boleh 0", -6);
			if (kredit == 0) throw new Utils.Exception("Kredit tidak boleh 0", -6);
			if (debit != kredit) throw new Utils.Exception("Jurnal tidak seimbang.\r\nDebit = " + debit + "\r\nKredit = " + kredit, -6);

			// periode
			var periode = IntegrasiService.CekPeriodeTutupBuku(session, obj.Tanggal);
			if (periode) throw new Utils.Exception("Data tidak bisa disimpan, karena periode nya sudah ditutup.", -4);

			// no bukti
			if (!session.IsNewObject(obj) && originalEdit.Kode == obj.Kode) return true;
			if (!string.IsNullOrEmpty(obj.Kode) &&
				session.FindObject<GlMain>(new BinaryOperator(nameof(GlMain.Kode), obj.Kode, BinaryOperatorType.Equal)) != null)
				throw new Utils.Exception("No. Bukti transaksi sudah ada yang memakai.\r\nSilahkan ganti no. bukti yang lain", -7);

			return true;
		}
		public static void SaveGL(UnitOfWork session, GlMain obj, GlMain originalEdit, MataUang mataUang, FinaSumberDataJenis sumberData, ModuleId moduleId) {
			// delete urutan 0 jika Omzet Koran
			if (sumberData == FinaSumberDataJenis.JU) {
				obj.AkunKasBank = null;
				obj.UAkun = null;
				var detail = obj.DetailForSave.Find(f => f.Urutan == 0);
				if (detail != null) obj.DetailForSave.Remove(detail);
			}
			// create urutan 0
			else if (sumberData == FinaSumberDataJenis.KM || sumberData == FinaSumberDataJenis.BM) {
				var debit = obj.DetailForSave.Sum(s => s.Debit);
				var kredit = obj.DetailForSave.Sum(s => s.Kredit);

				var itemDetail = obj.DetailForSave.Find(f => f.Urutan == 0);
				if (itemDetail == null) { itemDetail = new GlMainDetailForSave() { Urutan = 0 }; obj.DetailForSave.Add(itemDetail); }
				itemDetail.Akun = obj.AkunKasBank;
				itemDetail.Debit = kredit - debit;
				itemDetail.Kredit = 0;
				itemDetail.MataUang = mataUang;
				itemDetail.Kurs = 1;
				itemDetail.DebitValas = 0;
				itemDetail.KreditValas = 0;
				itemDetail.Divisi = null;
			}
			else if (sumberData == FinaSumberDataJenis.KK || sumberData == FinaSumberDataJenis.BK) {
				var debit = obj.DetailForSave.Sum(s => s.Debit);
				var kredit = obj.DetailForSave.Sum(s => s.Kredit);

				var itemDetail = obj.DetailForSave.Find(f => f.Urutan == 0);
				if (itemDetail == null) { itemDetail = new GlMainDetailForSave() { Urutan = 0 }; obj.DetailForSave.Add(itemDetail); }
				itemDetail.Akun = obj.AkunKasBank;
				itemDetail.Debit = 0;
				itemDetail.Kredit = debit - kredit;
				itemDetail.MataUang = mataUang;
				itemDetail.Kurs = 1;
				itemDetail.DebitValas = 0;
				itemDetail.KreditValas = 0;
				itemDetail.Divisi = null;
			}

			if (CheckItemBeforeSave(session, obj, originalEdit)) {
				var sumber = new FinaSumberDataCollection(session);
				var finaSetting = new FinaSetting(session);
				obj.Number = new FinaNumberClass(session) { FormatNomor = finaSetting.FormatNomor };
				obj.SumberData = sumber.GetObject(sumberData);
				obj.ModuleId = moduleId;

				// Default value
				obj.URegional = obj.Regional;
				obj.USumber = obj.SumberData;
				obj.UAkun = obj.AkunKasBank;				
				//throw new System.Exception("Number = " + obj.Tanggal + "/" + obj.URegional.Kode + "/" + obj.USumber.Kode + "/" + obj.UAkun.FormatNomor);
				if (string.IsNullOrEmpty(obj.Kode)) obj.Kode = obj.Number.GetNewNumber().Kode;
				//throw new System.Exception("regional = " + (obj.URegional != null).ToString() + "\r\nsumber = " + (obj.USumber != null).ToString() + "\r\nakun kas bank = " + (obj.UAkun != null).ToString());
				if (session.IsNewObject(obj)) {
					var reg = session.GetObjectByKey<FinaSettingRegional>(obj.Regional);
					if (string.IsNullOrEmpty(obj.Direktur)) obj.Direktur = reg.Direktur;
					if (string.IsNullOrEmpty(obj.Akunting)) obj.Akunting = reg.Akunting;
					if (string.IsNullOrEmpty(obj.Kasir)) obj.Kasir = sumberData == FinaSumberDataJenis.BM || sumberData == FinaSumberDataJenis.BK ? reg.KasirBank : reg.KasirKas;
				}

				// Delete detail
				for (var i = obj.Detail.Count - 1; i >= 0; i--) {
					var detail = obj.Detail[i];
					var find = obj.DetailForSave.Find(f => f.Urutan == detail.Urutan);
					if (find == null) { obj.Detail.Remove(detail); detail.Delete(); }
				}

				// Insert Update
				foreach (var detail in obj.DetailForSave) {
					var find = obj.Detail.ToList().Find(f => f.Urutan == detail.Urutan);
					if (find == null) find = new GlMainDetail(session) { Main = obj, Urutan = detail.Urutan };

					find.Akun = detail.Akun;
					find.Debit = detail.Debit;
					find.Kredit = detail.Kredit;
					find.Kurs = detail.Kurs;
					find.Divisi = detail.Divisi;
					find.MataUang = detail.MataUang;
					find.DebitValas = detail.DebitValas;
					find.KreditValas = detail.KreditValas;
					find.Keterangan = detail.Keterangan;
				}
			}
		}
	}
}
