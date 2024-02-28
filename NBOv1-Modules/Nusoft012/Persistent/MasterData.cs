using DevExpress.Xpo;
using DevExpress.Xpo.Metadata;
using NuSoft.NPO;
using NuSoft.NPO.Modules.ModSys;
using System.Collections.Generic;

namespace NuSoft.NUI.Win.Forms.Modules.NuSoft012.Persistent {
	internal enum ETipeIklan { 
		Kolom = 1,
		Deret = 2
	}
	internal struct TipeIklan {
		public ETipeIklan Id { get; set; }
		public string Nama { get; set; }

		public static List<TipeIklan> GetCollection() {
			var result = new List<TipeIklan>();
			result.Add(new TipeIklan() { Id = ETipeIklan.Kolom, Nama = "Kolom" });
			result.Add(new TipeIklan() { Id = ETipeIklan.Deret, Nama = "Deret" });
			return result;
		}
	}

	[Persistent("m12acarabayar")] internal class CaraBayar : NPOBase {
		internal CaraBayar(UnitOfWork uow) : base(uow) { }
		internal CaraBayar(UnitOfWork uow, XPClassInfo classInfo) : base(uow, classInfo) { }

		private int _id;
		private Akun _akun;
		private string _alias;
		private bool _aktif;
		private bool _isPPh23;
		private decimal _pph23Persen;
		private bool _isPPh21;
		private string _keterangan;

		[Key(true)] public int Id { get => _id; set => SetPropertyValue(nameof(Id), ref _id, value); }
		public Akun Akun { get => _akun; set => SetPropertyValue(nameof(Akun), ref _akun, value); }
		public string Alias { get => _alias; set => SetPropertyValue(nameof(Alias), ref _alias, value); }
		public bool Aktif { get => _aktif; set => SetPropertyValue(nameof(Aktif), ref _aktif, value); }
		public bool IsPPh23 { get => _isPPh23; set => SetPropertyValue(nameof(IsPPh23), ref _isPPh23, value); }
		public decimal PPh23Persen { get => _pph23Persen; set => SetPropertyValue(nameof(PPh23Persen), ref _pph23Persen, value); }
		public bool IsPPh21 { get => _isPPh21; set => SetPropertyValue(nameof(IsPPh21), ref _isPPh21, value); }
		public string Keterangan { get => _keterangan; set => SetPropertyValue(nameof(Keterangan), ref _keterangan, value); }
	}
	[Persistent("m12akelompokomzet")] internal class KelompokOmzet : NPOBase {
		internal KelompokOmzet(UnitOfWork uow) : base(uow) { }
		internal KelompokOmzet(UnitOfWork uow, XPClassInfo classInfo) : base(uow, classInfo) { }

		private int _id;
		private string _kode;
		private string _ttdNama;
		private string _ttdJabatan;
		private string _keterangan;

		[Key(true)] public int Id { get => _id; set => SetPropertyValue(nameof(Id), ref _id, value); }
		public string Kode { get => _kode; set => SetPropertyValue(nameof(Kode), ref _kode, value); }
		public string TtdNama { get => _ttdNama; set => SetPropertyValue(nameof(TtdNama), ref _ttdNama, value); }
		public string TtdJabatan { get => _ttdJabatan; set => SetPropertyValue(nameof(TtdJabatan), ref _ttdJabatan, value); }
		public string Keterangan { get => _keterangan; set => SetPropertyValue(nameof(Keterangan), ref _keterangan, value); }
	}
	[Persistent("m12akurir")] internal class Kurir : NPOBase {
		internal Kurir(UnitOfWork uow) : base(uow) { }
		internal Kurir(UnitOfWork uow, XPClassInfo classInfo) : base(uow, classInfo) { }

		private int _id;
		private string _nama;
		private bool _aktif;
		private string _keterangan;

		[Key(true)] public int Id { get => _id; set => SetPropertyValue(nameof(Id), ref _id, value); }
		public string Nama { get => _nama; set => SetPropertyValue(nameof(Nama), ref _nama, value); }
		public bool Aktif { get => _aktif; set => SetPropertyValue(nameof(Aktif), ref _aktif, value); }
		public string Keterangan { get => _keterangan; set => SetPropertyValue(nameof(Keterangan), ref _keterangan, value); }
	}
	[Persistent("m12apemasang")] internal class Pemasang : NPOBase {
		internal Pemasang(UnitOfWork uow) : base(uow) { }
		internal Pemasang(UnitOfWork uow, XPClassInfo classInfo) : base(uow, classInfo) { }

		private int _id;
		private string _kode;
		private string _nama;
		private string _alamat;
		private string _npwp;
		private string _kodeFaktur;
		private string _nik;
		private string _noTelpon;
		private string _noFax;
		private string _noHP1;
		private string _noHP2;
		private string _email;
		private bool _aktif;
		private decimal _diskonDefault;
		private int _jatuhTempoDefault;
		private string _kontakPerson;
		private string _keterangan;

		[Key(true)] public int Id { get => _id; set => SetPropertyValue(nameof(Id), ref _id, value); }
		public string Kode { get => _kode; set => SetPropertyValue(nameof(Kode), ref _kode, value); }
		public string Nama { get => _nama; set => SetPropertyValue(nameof(Nama), ref _nama, value); }
		public string Alamat { get => _alamat; set => SetPropertyValue(nameof(Alamat), ref _alamat, value); }
		public string NPWP { get => _npwp; set => SetPropertyValue(nameof(NPWP), ref _npwp, value); }
		public string KodeFaktur { get => _kodeFaktur; set => SetPropertyValue(nameof(KodeFaktur), ref _kodeFaktur, value); }
		public string NIK { get => _nik; set => SetPropertyValue(nameof(NIK), ref _nik, value); }
		public string NoTelpon { get => _noTelpon; set => SetPropertyValue(nameof(NoTelpon), ref _noTelpon, value); }
		public string NoFax { get => _noFax; set => SetPropertyValue(nameof(NoFax), ref _noFax, value); }
		public string NoHP1 { get => _noHP1; set => SetPropertyValue(nameof(NoHP1), ref _noHP1, value); }
		public string NoHP2 { get => _noHP2; set => SetPropertyValue(nameof(NoHP2), ref _noHP2, value); }
		public string Email { get => _email; set => SetPropertyValue(nameof(Email), ref _email, value); }
		public bool Aktif { get => _aktif; set => SetPropertyValue(nameof(Aktif), ref _aktif, value); }
		public decimal DiskonDefault { get => _diskonDefault; set => SetPropertyValue(nameof(DiskonDefault), ref _diskonDefault, value); }
		public int JatuhTempoDefault { get => _jatuhTempoDefault; set => SetPropertyValue(nameof(JatuhTempoDefault), ref _jatuhTempoDefault, value); }
		public string KontakPerson { get => _kontakPerson; set => SetPropertyValue(nameof(KontakPerson), ref _kontakPerson, value); }
		public string Keterangan { get => _keterangan; set => SetPropertyValue(nameof(Keterangan), ref _keterangan, value); }
	}
	[Persistent("m12aproduk")] internal class Produk : NPOBase {
		internal Produk(UnitOfWork uow) : base(uow) { }
		internal Produk(UnitOfWork uow, XPClassInfo classInfo) : base(uow, classInfo) { }

		private int _id;
		private string _kode;
		private string _nama;
		private string _keterangan;

		[Key(true)] public int Id { get => _id; set => SetPropertyValue(nameof(Id), ref _id, value); }
		public string Kode { get => _kode; set => SetPropertyValue(nameof(Kode), ref _kode, value); }
		public string Nama { get => _nama; set => SetPropertyValue(nameof(Nama), ref _nama, value); }
		public string Keterangan { get => _keterangan; set => SetPropertyValue(nameof(Keterangan), ref _keterangan, value); }
	}
	[Persistent("m12asales")] internal class Sales : NPOBase {
		internal Sales(UnitOfWork uow) : base(uow) { }
		internal Sales(UnitOfWork uow, XPClassInfo classInfo) : base(uow, classInfo) { }

		private int _id;
		private string _kode;
		private string _nama;
		private string _alamat;
		private string _npwp;
		private string _nik;
		private string _noTelpon;
		private string _noFax;
		private string _noHP1;
		private string _noHP2;
		private string _email;
		private bool _aktif;
		private decimal _komisiDefault;
		private string _keterangan;

		[Key(true)] public int Id { get => _id; set => SetPropertyValue(nameof(Id), ref _id, value); }
		public string Kode { get => _kode; set => SetPropertyValue(nameof(Kode), ref _kode, value); }
		public string Nama { get => _nama; set => SetPropertyValue(nameof(Nama), ref _nama, value); }
		public string Alamat { get => _alamat; set => SetPropertyValue(nameof(Alamat), ref _alamat, value); }
		public string NPWP { get => _npwp; set => SetPropertyValue(nameof(NPWP), ref _npwp, value); }
		public string NIK { get => _nik; set => SetPropertyValue(nameof(NIK), ref _nik, value); }
		public string NoTelpon { get => _noTelpon; set => SetPropertyValue(nameof(NoTelpon), ref _noTelpon, value); }
		public string NoFax { get => _noFax; set => SetPropertyValue(nameof(NoFax), ref _noFax, value); }
		public string NoHP1 { get => _noHP1; set => SetPropertyValue(nameof(NoHP1), ref _noHP1, value); }
		public string NoHP2 { get => _noHP2; set => SetPropertyValue(nameof(NoHP2), ref _noHP2, value); }
		public string Email { get => _email; set => SetPropertyValue(nameof(Email), ref _email, value); }
		public bool Aktif { get => _aktif; set => SetPropertyValue(nameof(Aktif), ref _aktif, value); }
		public decimal KomisiDefault { get => _komisiDefault; set => SetPropertyValue(nameof(KomisiDefault), ref _komisiDefault, value); }
		public string Keterangan { get => _keterangan; set => SetPropertyValue(nameof(Keterangan), ref _keterangan, value); }
	}
	[Persistent("m12atarifiklan")] internal class TarifIklan : NPOBase {
		internal TarifIklan(UnitOfWork uow) : base(uow) { }
		internal TarifIklan(UnitOfWork uow, XPClassInfo classInfo) : base(uow, classInfo) { }

		private int _id;
		private string _kode;
		private string _nama;
		private ETipeIklan _tipeIklan;
		private decimal _tarif;
		private bool _aktif;
		private string _keterangan;

		[Key(true)] public int Id { get => _id; set => SetPropertyValue(nameof(Id), ref _id, value); }
		public string Kode { get => _kode; set => SetPropertyValue(nameof(Kode), ref _kode, value); }
		public string Nama { get => _nama; set => SetPropertyValue(nameof(Nama), ref _nama, value); }
		public ETipeIklan TipeIklan { get => _tipeIklan; set => SetPropertyValue(nameof(TipeIklan), ref _tipeIklan, value); }
		public decimal Tarif { get => _tarif; set => SetPropertyValue(nameof(Tarif), ref _tarif, value); }
		public bool Aktif { get => _aktif; set => SetPropertyValue(nameof(Aktif), ref _aktif, value); }
		public string Keterangan { get => _keterangan; set => SetPropertyValue(nameof(Keterangan), ref _keterangan, value); }
	}
	[Persistent("m12atipeinvoice")] internal class TipeInvoice : NPOBase {
		internal TipeInvoice(UnitOfWork uow) : base(uow) { }
		internal TipeInvoice(UnitOfWork uow, XPClassInfo classInfo) : base(uow, classInfo) { }

		private int _id;
		private string _kode;
		private string _nama;
		private ETipeIklan _tipeIklan;
		private string _keterangan;
		private Akun _akunPiutang;
		private Akun _akunPendapatan;
		private Akun _akunDiskon;
		private Akun _akunHutangKomisi;
		private Akun _akunBiayaKomisi;
		private Akun _akunHutangCashback;
		private Akun _akunBiayaCashback;

		[Key(true)] public int Id { get => _id; set => SetPropertyValue(nameof(Id), ref _id, value); }
		public string Kode { get => _kode; set => SetPropertyValue(nameof(Kode), ref _kode, value); }
		public string Nama { get => _nama; set => SetPropertyValue(nameof(Nama), ref _nama, value); }
		public ETipeIklan TipeIklan { get => _tipeIklan; set => SetPropertyValue(nameof(TipeIklan), ref _tipeIklan, value); }
		public string Keterangan { get => _keterangan; set => SetPropertyValue(nameof(Keterangan), ref _keterangan, value); }
		public Akun AkunPiutang { get => _akunPiutang; set => SetPropertyValue(nameof(AkunPiutang), ref _akunPiutang, value); }
		public Akun AkunPendapatan { get => _akunPendapatan; set => SetPropertyValue(nameof(AkunPendapatan), ref _akunPendapatan, value); }
		public Akun AkunDiskon { get => _akunDiskon; set => SetPropertyValue(nameof(AkunDiskon), ref _akunDiskon, value); }
		public Akun AkunHutangKomisi { get => _akunHutangKomisi; set => SetPropertyValue(nameof(AkunHutangKomisi), ref _akunHutangKomisi, value); }
		public Akun AkunBiayaKomisi { get => _akunBiayaKomisi; set => SetPropertyValue(nameof(AkunBiayaKomisi), ref _akunBiayaKomisi, value); }
		public Akun AkunHutangCashback { get => _akunHutangCashback; set => SetPropertyValue(nameof(AkunHutangCashback), ref _akunHutangCashback, value); }
		public Akun AkunBiayaCashback { get => _akunBiayaCashback; set => SetPropertyValue(nameof(AkunBiayaCashback), ref _akunBiayaCashback, value); }
	}
	[Persistent("m12bmerk")] internal class Merk : NPOBase {
		internal Merk(UnitOfWork uow) : base(uow) { }
		internal Merk(UnitOfWork uow, XPClassInfo classInfo) : base(uow, classInfo) { }

		private int _id;
		private Produk _produk;
		private string _kode;
		private string _nama;
		private string _keterangan;

		[Key(true)] public int Id { get => _id; set => SetPropertyValue(nameof(Id), ref _id, value); }
		public Produk Produk { get => _produk; set => SetPropertyValue(nameof(Produk), ref _produk, value); }
		public string Kode { get => _kode; set => SetPropertyValue(nameof(Kode), ref _kode, value); }
		public string Nama { get => _nama; set => SetPropertyValue(nameof(Nama), ref _nama, value); }
		public string Keterangan { get => _keterangan; set => SetPropertyValue(nameof(Keterangan), ref _keterangan, value); }
	}
	[Persistent("m12bwilayah")] internal class Wilayah : NPOBase {
		internal Wilayah(UnitOfWork uow) : base(uow) { }
		internal Wilayah(UnitOfWork uow, XPClassInfo classInfo) : base(uow, classInfo) { }

		private int _id;
		private Regional _regional;
		private KelompokOmzet _kelompokOmzet;
		private string _kode;
		private string _nama;
		private int _jatuhTempo;
		private string _keterangan;

		[Key(true)] public int Id { get => _id; set => SetPropertyValue(nameof(Id), ref _id, value); }
		public Regional Regional { get => _regional; set => SetPropertyValue(nameof(Regional), ref _regional, value); }
		public KelompokOmzet KelompokOmzet { get => _kelompokOmzet; set => SetPropertyValue(nameof(KelompokOmzet), ref _kelompokOmzet, value); }
		public string Kode { get => _kode; set => SetPropertyValue(nameof(Kode), ref _kode, value); }
		public string Nama { get => _nama; set => SetPropertyValue(nameof(Nama), ref _nama, value); }
		public int JatuhTempo { get => _jatuhTempo; set => SetPropertyValue(nameof(JatuhTempo), ref _jatuhTempo, value); }
		public string Keterangan { get => _keterangan; set => SetPropertyValue(nameof(Keterangan), ref _keterangan, value); }
	}
}
