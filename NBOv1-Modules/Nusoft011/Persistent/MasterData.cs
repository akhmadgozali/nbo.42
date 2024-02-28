using DevExpress.Xpo;
using DevExpress.Xpo.Metadata;
using NuSoft.NPO;
using NuSoft.NPO.Modules.ModSys;
using System;
using System.Collections.Generic;

namespace NuSoft.NUI.Win.Forms.Modules.NuSoft011.Persistent {
	public enum EWeekdayName {
		Khusus = 0,
		Senin = 1,
		Selasa = 2,
		Rabu = 3,
		Kamis = 4,
		Jumat = 5,
		Sabtu = 6,
		Minggu = 7
	}

	[Persistent("dtaprovince")] internal class Propinsi : NPOBase {
		internal Propinsi(UnitOfWork uow) : base(uow) { }
		internal Propinsi(UnitOfWork uow, XPClassInfo classInfo) : base(uow, classInfo) { }

		private int _id;
		private string _kode;
		private string _keterangan;

		[Persistent("p_id"), Key()] public int Id { get => _id; set => SetPropertyValue(nameof(Id), ref _id, value); }
		[Persistent("u_code")] public string Kode { get => _kode; set => SetPropertyValue(nameof(Kode), ref _kode, value); }
		[Persistent("d_note")] public string Keterangan { get => _keterangan; set => SetPropertyValue(nameof(Keterangan), ref _keterangan, value); }
	}
	[Persistent("dtbdistrict")] internal class Kabupaten : NPOBase {
		internal Kabupaten(UnitOfWork uow) : base(uow) { }
		internal Kabupaten(UnitOfWork uow, XPClassInfo classInfo) : base(uow, classInfo) { }

		private int _id;
		private Propinsi _propinsi;
		private string _kode;
		private string _keterangan;

		[Persistent("p_id"), Key()] public int Id { get => _id; set => SetPropertyValue(nameof(Id), ref _id, value); }
		[Persistent("f_province")] public Propinsi Propinsi { get => _propinsi; set => SetPropertyValue(nameof(Propinsi), ref _propinsi, value); }
		[Persistent("u_code")] public string Kode { get => _kode; set => SetPropertyValue(nameof(Kode), ref _kode, value); }
		[Persistent("d_note")] public string Keterangan { get => _keterangan; set => SetPropertyValue(nameof(Keterangan), ref _keterangan, value); }
	}
	[Persistent("dtcsubdistrict")] internal class Kecamatan : NPOBase {
		internal Kecamatan(UnitOfWork uow) : base(uow) { }
		internal Kecamatan(UnitOfWork uow, XPClassInfo classInfo) : base(uow, classInfo) { }

		private int _id;
		private Kabupaten _kabupaten;
		private string _kode;
		private string _keterangan;

		[Persistent("p_id"), Key()] public int Id { get => _id; set => SetPropertyValue(nameof(Id), ref _id, value); }
		[Persistent("f_district")] public Kabupaten Kabupaten { get => _kabupaten; set => SetPropertyValue(nameof(Kabupaten), ref _kabupaten, value); }
		[Persistent("u_code")] public string Kode { get => _kode; set => SetPropertyValue(nameof(Kode), ref _kode, value); }
		[Persistent("d_note")] public string Keterangan { get => _keterangan; set => SetPropertyValue(nameof(Keterangan), ref _keterangan, value); }
	}
	[Persistent("dtdvillage")] internal class Kelurahan : NPOBase {
		internal Kelurahan(UnitOfWork uow) : base(uow) { }
		internal Kelurahan(UnitOfWork uow, XPClassInfo classInfo) : base(uow, classInfo) { }

		private int _id;
		private Kecamatan _kecamatan;
		private string _kode;
		private string _keterangan;

		[Persistent("p_id"), Key()] public int Id { get => _id; set => SetPropertyValue(nameof(Id), ref _id, value); }
		[Persistent("f_subdistrict")] public Kecamatan Kecamatan { get => _kecamatan; set => SetPropertyValue(nameof(Kecamatan), ref _kecamatan, value); }
		[Persistent("u_code")] public string Kode { get => _kode; set => SetPropertyValue(nameof(Kode), ref _kode, value); }
		[Persistent("d_note")] public string Keterangan { get => _keterangan; set => SetPropertyValue(nameof(Keterangan), ref _keterangan, value); }
	}

	[Persistent("m11arute")] internal class Rute : NPOBase {
		internal Rute(UnitOfWork uow) : base(uow) { }
		internal Rute(UnitOfWork uow, XPClassInfo classInfo) : base(uow, classInfo) { }

		private int _id;
		private Regional _regional;
		private string _kode;
		private string _nama;
		private string _keterangan;
		private Akun _akunPiutang;
		private Akun _akunPendapatan;
		private Akun _akunRetur;
		private Akun _akunDiskon;

		[Key(true)] public int Id { get => _id; set => SetPropertyValue(nameof(Id), ref _id, value); }
		public Regional Regional { get => _regional; set => SetPropertyValue(nameof(Regional), ref _regional, value); }
		public string Kode { get => _kode; set => SetPropertyValue(nameof(Kode), ref _kode, value); }
		public string Nama { get => _nama; set => SetPropertyValue(nameof(Nama), ref _nama, value); }
		public string Keterangan { get => _keterangan; set => SetPropertyValue(nameof(Keterangan), ref _keterangan, value); }
		
		public Akun AkunPiutang { get => _akunPiutang; set => SetPropertyValue(nameof(AkunPiutang), ref _akunPiutang, value); }
		public Akun AkunPendapatan { get => _akunPendapatan; set => SetPropertyValue(nameof(AkunPendapatan), ref _akunPendapatan, value); }
		public Akun AkunRetur { get => _akunRetur; set => SetPropertyValue(nameof(AkunRetur), ref _akunRetur, value); }
		public Akun AkunDiskon { get => _akunDiskon; set => SetPropertyValue(nameof(AkunDiskon), ref _akunDiskon, value); }

		[PersistentAlias("Concat(" + nameof(Kode) + ",' - '," + nameof(Nama) + ")")] public string KodeNama => Convert.ToString(EvaluateAlias(nameof(KodeNama)));
	}
	[Persistent("m11bagen")] internal class Agen : NPOBase {
		internal Agen(UnitOfWork uow) : base(uow) { }
		internal Agen(UnitOfWork uow, XPClassInfo classInfo) : base(uow, classInfo) { }

		private int _id;
		private Rute _rute;
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
		private double _hargaJatah;
		private double _hargaKonsi;
		private string _kodePelanggan;
		private double _hargaLangganan;
		private bool _orderTetap;
		private string _keterangan;
		private double _saldoPiutangAwal;
		private string _keteranganSaldoAwal;

		[Key(true)] public int Id { get => _id; set => SetPropertyValue(nameof(Id), ref _id, value); }
		public Rute Rute { get => _rute; set => SetPropertyValue(nameof(Rute), ref _rute, value); }
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
		public double HargaJatah { get => _hargaJatah; set => SetPropertyValue(nameof(HargaJatah), ref _hargaJatah, value); }
		public double HargaKonsi { get => _hargaKonsi; set => SetPropertyValue(nameof(HargaKonsi), ref _hargaKonsi, value); }
		public string KodePelanggan { get => _kodePelanggan; set => SetPropertyValue(nameof(KodePelanggan), ref _kodePelanggan, value); }
		public double HargaLangganan { get => _hargaLangganan; set => SetPropertyValue(nameof(HargaLangganan), ref _hargaLangganan, value); }
		public bool OrderTetap { get => _orderTetap; set => SetPropertyValue(nameof(OrderTetap), ref _orderTetap, value); }
		public string Keterangan { get => _keterangan; set => SetPropertyValue(nameof(Keterangan), ref _keterangan, value); }
		public double SaldoPiutangAwal { get => _saldoPiutangAwal; set => SetPropertyValue(nameof(SaldoPiutangAwal), ref _saldoPiutangAwal, value); }
		public string KeteranganSaldoAwal { get => _keteranganSaldoAwal; set => SetPropertyValue(nameof(KeteranganSaldoAwal), ref _keteranganSaldoAwal, value); }

		[Association("fk_agen_ordertetap"), Aggregated] public XPCollection<AgenOrderTetap> DetailOrderTetap => GetCollection<AgenOrderTetap>(nameof(DetailOrderTetap));

		[NonPersistent] public List<AgenOrderTetapForSave> DetailOrderTetapForSave { get; set; }
	}
	[Persistent("m11bagenorder")] internal class AgenOrderTetap : NPOBase {
		internal AgenOrderTetap(UnitOfWork uow) : base(uow) { }
		internal AgenOrderTetap(UnitOfWork uow, XPClassInfo classInfo) : base(uow, classInfo) { }

		private int _id;
		private Agen _agen;
		private EWeekdayName _indexHari;
		private int _jatah;
		private int _konsi;
		private int _gratis;

		[Key(true)] public int Id { get => _id; set => SetPropertyValue(nameof(Id), ref _id, value); }
		[Association("fk_agen_ordertetap")] public Agen Agen { get => _agen; set => SetPropertyValue(nameof(Agen), ref _agen, value); }
		public EWeekdayName IndexHari { get => _indexHari; set => SetPropertyValue(nameof(IndexHari), ref _indexHari, value); }
		public int Jatah { get => _jatah; set => SetPropertyValue(nameof(Jatah), ref _jatah, value); }
		public int Konsi { get => _konsi; set => SetPropertyValue(nameof(Konsi), ref _konsi, value); }
		public int Gratis { get => _gratis; set => SetPropertyValue(nameof(Gratis), ref _gratis, value); }
	}
	internal class AgenOrderTetapForSave {
		public EWeekdayName IndexHari { get; set; }
		public int Jatah { get; set; }
		public int Konsi { get; set; }
		public int Gratis { get; set; }
	}

	[Persistent("m11acarabayar")] internal class CaraBayar : NPOBase {
		internal CaraBayar(UnitOfWork uow) : base(uow) { }
		internal CaraBayar(UnitOfWork uow, XPClassInfo classInfo) : base(uow, classInfo) { }

		private int _id;
		private Akun _akun;
		private string _alias;
		private bool _aktif;
		private string _keterangan;

		[Key(true)] public int Id { get => _id; set => SetPropertyValue(nameof(Id), ref _id, value); }
		public Akun Akun { get => _akun; set => SetPropertyValue(nameof(Akun), ref _akun, value); }
		public string Alias { get => _alias; set => SetPropertyValue(nameof(Alias), ref _alias, value); }
		public bool Aktif { get => _aktif; set => SetPropertyValue(nameof(Aktif), ref _aktif, value); }
		public string Keterangan { get => _keterangan; set => SetPropertyValue(nameof(Keterangan), ref _keterangan, value); }
	}
}
