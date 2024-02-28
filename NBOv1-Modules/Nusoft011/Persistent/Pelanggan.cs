using DevExpress.Xpo;
using DevExpress.Xpo.Metadata;
using NuSoft.NPO;
using System;

namespace NuSoft.NUI.Win.Forms.Modules.NuSoft011.Persistent {
	[Persistent("m11cpelanggan")] internal class Pelanggan : NPOBase {
		internal Pelanggan(UnitOfWork uow) : base(uow) { }
		internal Pelanggan(UnitOfWork uow, XPClassInfo classInfo) : base(uow, classInfo) { }

		private long _id;
		private Agen _agen;
		private string _kode;
		private string _nama;
		private string _alamat;
		private Propinsi _propinsi;
		private Kabupaten _kabupaten;
		private Kecamatan _kecamatan;
		private Kelurahan _kelurahan;
		private string _nik;
		private string _tempatLahir;
		private DateTime _tanggalLahir;
		private string _pekerjaan;
		private string _noTelpRumah;
		private string _noTelpKantor;
		private string _noHP;
		private string _email;
		private double _harga;
		private string _keterangan;
		private decimal _koordinatX;
		private decimal _koordinatY;
		private DateTime _tanggalMulaiLangganan;

		[Key(true)] public long Id { get => _id; set => SetPropertyValue(nameof(Id), ref _id, value); }
		public Agen Agen { get => _agen; set => SetPropertyValue(nameof(Agen), ref _agen, value); }
		public string Kode { get => _kode; set => SetPropertyValue(nameof(Kode), ref _kode, value); }
		public string Nama { get => _nama; set => SetPropertyValue(nameof(Nama), ref _nama, value); }
		public string Alamat { get => _alamat; set => SetPropertyValue(nameof(Alamat), ref _alamat, value); }
		public Propinsi Propinsi { get => _propinsi; set => SetPropertyValue(nameof(Propinsi), ref _propinsi, value); }
		public Kabupaten Kabupaten { get => _kabupaten; set => SetPropertyValue(nameof(Kabupaten), ref _kabupaten, value); }
		public Kecamatan Kecamatan { get => _kecamatan; set => SetPropertyValue(nameof(Kecamatan), ref _kecamatan, value); }
		public Kelurahan Kelurahan { get => _kelurahan; set => SetPropertyValue(nameof(Kelurahan), ref _kelurahan, value); }
		public string NIK { get => _nik; set => SetPropertyValue(nameof(NIK), ref _nik, value); }
		public string TempatLahir { get => _tempatLahir; set => SetPropertyValue(nameof(TempatLahir), ref _tempatLahir, value); }
		public DateTime TanggalLahir { get => _tanggalLahir; set => SetPropertyValue(nameof(TanggalLahir), ref _tanggalLahir, value); }
		public string Pekerjaan { get => _pekerjaan; set => SetPropertyValue(nameof(Pekerjaan), ref _pekerjaan, value); }
		public string NoTelpRumah { get => _noTelpRumah; set => SetPropertyValue(nameof(NoTelpRumah), ref _noTelpRumah, value); }
		public string NoTelpKantor { get => _noTelpKantor; set => SetPropertyValue(nameof(NoTelpKantor), ref _noTelpKantor, value); }
		public string NoHP { get => _noHP; set => SetPropertyValue(nameof(NoHP), ref _noHP, value); }
		public string Email { get => _email; set => SetPropertyValue(nameof(Email), ref _email, value); }
		public double Harga { get => _harga; set => SetPropertyValue(nameof(Harga), ref _harga, value); }
		public string Keterangan { get => _keterangan; set => SetPropertyValue(nameof(Keterangan), ref _keterangan, value); }
		public decimal KoordinatX { get => _koordinatX; set => SetPropertyValue(nameof(KoordinatX), ref _koordinatX, value); }
		public decimal KoordinatY { get => _koordinatY; set => SetPropertyValue(nameof(KoordinatY), ref _koordinatY, value); }
		public DateTime TanggalMulaiLangganan { get => _tanggalMulaiLangganan; set => SetPropertyValue(nameof(TanggalMulaiLangganan), ref _tanggalMulaiLangganan, value); }

		[NonPersistent] public int JumlahExpAwal { get; set; }

		[Association("fk_pelanggan_history"), Aggregated] public XPCollection<PelangganHistory> History => GetCollection<PelangganHistory>(nameof(History));
		[Association("fk_pelanggan_komplain"), Aggregated] public XPCollection<PelangganKomplain> Komplain => GetCollection<PelangganKomplain>(nameof(Komplain));

		[PersistentAlias(nameof(History) + ".Min(iif(isnull(" + nameof(PelangganHistory.Keterangan) + "),''," + nameof(PelangganHistory.Keterangan) + "))")] public string KeteranganTerakhir => EvaluateAlias(nameof(KeteranganTerakhir)).ToString();
		[PersistentAlias(nameof(History) + ".Sum(" + nameof(PelangganHistory.JumlahExpAktif) + " - " + nameof(PelangganHistory.JumlahExpNonAktif) + ")")] public int JumlahExp => Convert.ToInt32(EvaluateAlias(nameof(JumlahExp)));
		[PersistentAlias(nameof(JumlahExp) + " > 0")] public bool Aktif => Convert.ToBoolean(EvaluateAlias(nameof(Aktif)));

		[PersistentAlias("iif(" + nameof(Harga) + "=0, " + nameof(Agen) + "." + nameof(Persistent.Agen.HargaLangganan) + ", " + nameof(Harga) + ")")] public decimal HargaLangganan => Convert.ToDecimal(EvaluateAlias(nameof(HargaLangganan)));
		[PersistentAlias("iif(IsNull(" + nameof(TanggalLahir) + "),0,DateDiffYear(" + nameof(TanggalLahir) + ", Now()))")] public int Umur => Convert.ToInt32(EvaluateAlias(nameof(Umur)));
		[PersistentAlias("iif(IsNull(" + nameof(TanggalLahir) + "),0,GetMonth(" + nameof(TanggalLahir) + "))")] public int BulanLahir => Convert.ToInt32(EvaluateAlias(nameof(BulanLahir)));
	}
	[Persistent("m11dpelangganhistory")] internal class PelangganHistory : NPOBase {
		internal PelangganHistory(UnitOfWork uow) : base(uow) { }
		internal PelangganHistory(UnitOfWork uow, XPClassInfo classInfo) : base(uow, classInfo) { }

		private long _id;
		private Pelanggan _pelanggan;
		private DateTime _tanggal;
		private bool _aktif;
		private int _jumlahExp;
		private string _keterangan;

		[Key(true)] public long Id { get => _id; set => SetPropertyValue(nameof(Id), ref _id, value); }
		[Association("fk_pelanggan_history")] public Pelanggan Pelanggan { get => _pelanggan; set => SetPropertyValue(nameof(Pelanggan), ref _pelanggan, value); }
		public DateTime Tanggal { get => _tanggal; set => SetPropertyValue(nameof(Tanggal), ref _tanggal, value); }
		public bool Aktif { get => _aktif; set => SetPropertyValue(nameof(Aktif), ref _aktif, value); }
		public int JumlahExp { get => _jumlahExp; set => SetPropertyValue(nameof(JumlahExp), ref _jumlahExp, value); }
		public string Keterangan { get => _keterangan; set => SetPropertyValue(nameof(Keterangan), ref _keterangan, value); }

		[PersistentAlias("IIf(" + nameof(Aktif) + "," + nameof(JumlahExp) + ",0)")] public int JumlahExpAktif => Convert.ToInt32(EvaluateAlias(nameof(JumlahExpAktif)));
		[PersistentAlias("IIf(" + nameof(Aktif) + ",0," + nameof(JumlahExp) + ")")] public int JumlahExpNonAktif => Convert.ToInt32(EvaluateAlias(nameof(JumlahExpNonAktif)));
	}
	[Persistent("m11dpelanggankomplain")] internal class PelangganKomplain : NPOBase {
		internal PelangganKomplain(UnitOfWork uow) : base(uow) { }
		internal PelangganKomplain(UnitOfWork uow, XPClassInfo classInfo) : base(uow, classInfo) { }

		private long _id;
		private Pelanggan _pelanggan;
		private DateTime _tanggal;
		private string _penerima;
		private string _keluhan;
		private string _solusi;
		private DateTime _batasWaktu;
		private bool _selesai;
		private string _keterangan;

		[Key(true)] public long Id { get => _id; set => SetPropertyValue(nameof(Id), ref _id, value); }
		[Association("fk_pelanggan_komplain")] public Pelanggan Pelanggan { get => _pelanggan; set => SetPropertyValue(nameof(Pelanggan), ref _pelanggan, value); }
		public DateTime Tanggal { get => _tanggal; set => SetPropertyValue(nameof(Tanggal), ref _tanggal, value); }
		public string Penerima { get => _penerima; set => SetPropertyValue(nameof(Penerima), ref _penerima, value); }
		public string Keluhan { get => _keluhan; set => SetPropertyValue(nameof(Keluhan), ref _keluhan, value); }
		public string Solusi { get => _solusi; set => SetPropertyValue(nameof(Solusi), ref _solusi, value); }
		public DateTime BatasWaktu { get => _batasWaktu; set => SetPropertyValue(nameof(BatasWaktu), ref _batasWaktu, value); }
		public bool Selesai { get => _selesai; set => SetPropertyValue(nameof(Selesai), ref _selesai, value); }
		public string Keterangan { get => _keterangan; set => SetPropertyValue(nameof(Keterangan), ref _keterangan, value); }

		[PersistentAlias("IIf(" + nameof(Selesai) + ",'Selesai','Belum Selesai')")] public string Status => EvaluateAlias(nameof(Status)).ToString();
	}

	internal class PelangganForReport {
		public Pelanggan Pelanggan { get; set; }
		public string KategoriPelanggan { get; set; }
		public DateTime Tanggal { get; set; }
		public bool Aktif { get; set; }
		public int JumlahExp { get; set; }
		public decimal Harga { get; set; }
		public string Terbilang { get; set; }
		public decimal TotalHarga => JumlahExp * Harga;

		public DateTime? TglPembayaran { get; set; }
		public decimal? NominalBayar { get; set; }
		public string Keterangan { get; set; }
	}
}
