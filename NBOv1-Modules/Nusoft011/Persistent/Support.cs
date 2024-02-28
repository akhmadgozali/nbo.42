using DevExpress.Xpo;
using DevExpress.Xpo.Metadata;
using NuSoft.NPO;
using NuSoft.NPO.Modules.ModSys;
using NuSoft.NUI.Win.Forms.Modules.NuSoft007.Persistent;
using System;
using System.Collections.Generic;

namespace NuSoft.NUI.Win.Forms.Modules.NuSoft011.Persistent {
	[Persistent("m11ceditharga")] internal class EditHarga : NPOBase {
		internal EditHarga(UnitOfWork uow) : base(uow) { }
		internal EditHarga(UnitOfWork uow, XPClassInfo classInfo) : base(uow, classInfo) { }

		private long _id;
		private int _tahun;
		private int _bulan;
		private int _jumlahHari;
		private string _keterangan;

		[Key(true)] public long Id { get => _id; set => SetPropertyValue(nameof(Id), ref _id, value); }
		public int Tahun { get => _tahun; set => SetPropertyValue(nameof(Tahun), ref _tahun, value); }
		public int Bulan { get => _bulan; set => SetPropertyValue(nameof(Bulan), ref _bulan, value); }
		public int JumlahHari { get => _jumlahHari; set => SetPropertyValue(nameof(JumlahHari), ref _jumlahHari, value); }
		public string Keterangan { get => _keterangan; set => SetPropertyValue(nameof(Keterangan), ref _keterangan, value); }

		[Association("fk_editharga_detail"), Aggregated] public XPCollection<EditHargaDetail> Detail => GetCollection<EditHargaDetail>(nameof(Detail));
		[NonPersistent] public List<EditHargaDetailForSave> DetailForSave { get; set; }
	}
	[Persistent("m11dedithargadetail")] internal class EditHargaDetail : NPOBase {
		internal EditHargaDetail(UnitOfWork uow) : base(uow) { }
		internal EditHargaDetail(UnitOfWork uow, XPClassInfo classInfo) : base(uow, classInfo) { }

		private long _id;
		private EditHarga _main;
		private Agen _agen;
		private double _hargaJatahLama;
		private double _hargaKonsiLama;
		private double _hargaJatahBaru;
		private double _hargaKonsiBaru;
		private string _keterangan;

		[Key(true)] public long Id { get => _id; set => SetPropertyValue(nameof(Id), ref _id, value); }
		[Association("fk_editharga_detail")] public EditHarga Main { get => _main; set => SetPropertyValue(nameof(Main), ref _main, value); }
		public Agen Agen { get => _agen; set => SetPropertyValue(nameof(Agen), ref _agen, value); }
		public double HargaJatahLama { get => _hargaJatahLama; set => SetPropertyValue(nameof(HargaJatahLama), ref _hargaJatahLama, value); }
		public double HargaKonsiLama { get => _hargaKonsiLama; set => SetPropertyValue(nameof(HargaKonsiLama), ref _hargaKonsiLama, value); }
		public double HargaJatahBaru { get => _hargaJatahBaru; set => SetPropertyValue(nameof(HargaJatahBaru), ref _hargaJatahBaru, value); }
		public double HargaKonsiBaru { get => _hargaKonsiBaru; set => SetPropertyValue(nameof(HargaKonsiBaru), ref _hargaKonsiBaru, value); }
		public string Keterangan { get => _keterangan; set => SetPropertyValue(nameof(Keterangan), ref _keterangan, value); }
	}
	internal class EditHargaDetailForSave {
		public long Id { get; set; }
		public Agen Agen { get; set; }
		public double HargaJatahLama { get; set; }
		public double HargaKonsiLama { get; set; }
		public double HargaJatahBaru { get; set; }
		public double HargaKonsiBaru { get; set; }
		public string Keterangan { get; set; }
	}

	[Persistent("m11zmapgl")] internal class MappingGLSirkulasi : NPOBase {
		internal MappingGLSirkulasi(UnitOfWork uow) : base(uow) { }
		internal MappingGLSirkulasi(UnitOfWork uow, XPClassInfo classInfo) : base(uow, classInfo) { }

		private long _id;
		private int _tahun;
		private int _bulan;
		private Regional _regional;
		private GlMain _glId;

		[Key(true)] public long Id { get => _id; set => SetPropertyValue(nameof(Id), ref _id, value); }
		public int Tahun { get => _tahun; set => SetPropertyValue(nameof(Tahun), ref _tahun, value); }
		public int Bulan { get => _bulan; set => SetPropertyValue(nameof(Bulan), ref _bulan, value); }
		public Regional Regional { get => _regional; set => SetPropertyValue(nameof(Regional), ref _regional, value); }
		public GlMain GLId { get => _glId; set => SetPropertyValue(nameof(GLId), ref _glId, value); }
	}
	[Persistent("m11zmaptax")] internal class MappingPajakSirkulasi : NPOBase {
		internal MappingPajakSirkulasi(UnitOfWork uow) : base(uow) { }
		internal MappingPajakSirkulasi(UnitOfWork uow, XPClassInfo classInfo) : base(uow, classInfo) { }

		private long _id;
		private int _tahun;
		private int _bulan;
		private Agen _agen;
		private PPnKeluaran _taxId;

		[Key(true)] public long Id { get => _id; set => SetPropertyValue(nameof(Id), ref _id, value); }
		public int Tahun { get => _tahun; set => SetPropertyValue(nameof(Tahun), ref _tahun, value); }
		public int Bulan { get => _bulan; set => SetPropertyValue(nameof(Bulan), ref _bulan, value); }
		public Agen Agen { get => _agen; set => SetPropertyValue(nameof(Agen), ref _agen, value); }
		public PPnKeluaran TaxId { get => _taxId; set => SetPropertyValue(nameof(TaxId), ref _taxId, value); }
	}

	internal class PiutangAgen {
		public int Periode { get; set; }
		public Agen Agen { get; set; }
		public double SaldoAwalPiutang { get; set; }
		public double KoreksiOmzet { get; set; }
		public double KoreksiPembayaran { get; set; }
		public int KoreksiReturOplah { get; set; }
		public double KoreksiReturOmzet { get; set; }
		public int Jatah { get; set; }
		public int Konsi { get; set; }
		public int Gratis { get; set; }
		public double Omzet { get; set; }
		public int ReturOplah { get; set; }
		public double ReturOmzet { get; set; }
		public double Pembayaran { get; set; }
		public List<PiutangAgenDetail> Detail { get; set; }
		public double HargaJatah { get; set; }
		public double HargaKonsi { get; set; }

		public long Id => long.Parse(Periode.ToString() + Agen.Id.ToString("00000"));
		public double SaldoAwal => (SaldoAwalPiutang + KoreksiOmzet) - KoreksiReturOmzet - KoreksiPembayaran;
		public double OmzetNetto => Omzet - ReturOmzet;
		public double TotalOmzet => KoreksiOmzet + Omzet;
		public double TotalOmzetNetto => TotalOmzet - TotalReturOmzet;
		public int TotalJatahKonsi => Jatah + Konsi;
		public int TotalJatahKonsiNetto => TotalJatahKonsi - TotalReturOplah;
		public int TotalOplah => Jatah + Konsi + Gratis;
		public int TotalOplahNetto => TotalOplah - ReturOplah;
		public int TotalReturOplah => KoreksiReturOplah + ReturOplah;
		public double TotalReturOmzet => KoreksiReturOmzet + ReturOmzet;
		public double TotalPembayaran => KoreksiPembayaran + Pembayaran;
		public double OmzetMinPembayaran => Omzet - Pembayaran;
		public double SaldoAkhir => (SaldoAwal + OmzetNetto) - Pembayaran;

		public string TerbilangOmzet { get; set; }
		public decimal UmurPiutang { get; set; }
	}
	internal class PiutangAgenDetail {
		public DateTime Tanggal { get; set; }
		public int OrderGratis { get; set; }
		public int OrderKonsi { get; set; }
		public int OrderJatah { get; set; }
		public int MutasiGratis { get; set; }
		public int MutasiKonsi { get; set; }
		public int MutasiJatah { get; set; }
		public int ReturFisik { get; set; }
		public double HargaKonsi { get; set; }
		public double HargaJatah { get; set; }
		public double Pembayaran { get; set; }

		public int Jatah => OrderJatah + MutasiJatah;
		public int Konsi => OrderKonsi + MutasiKonsi;
		public int Gratis => OrderGratis + MutasiGratis;
		public int Oplah => Jatah + Konsi;
		public double OmzetJatah => (Jatah * HargaJatah);
		public double OmzetKonsi => (Konsi * HargaKonsi);
		public double Omzet => OmzetJatah + OmzetKonsi;
		public double ReturRupiah => ReturFisik * HargaKonsi;
		public double SaldoAkhir => Omzet - ReturRupiah - Pembayaran;
	}
	[NonPersistent] internal class ViewPiutangAwalAgen : XPLiteObject {
		public ViewPiutangAwalAgen(UnitOfWork uow) : base(uow) { }
		[Key] public uint Id { get; set; }
		public double Saldo { get; set; }
	}

	[Persistent("m11vwrekap")] internal class vwRekapitulasi : XPLiteObject {
		public vwRekapitulasi(UnitOfWork uow) : base(uow) { }
		public vwRekapitulasi(UnitOfWork uow, XPClassInfo classInfo) : base(uow, classInfo) { }

		[Key] public ulong Id { get; set; }
		public bool IsBayar { get; set; }
		public bool IsSaldoAwal { get; set; }
		public DateTime Tanggal { get; set; }
		[PersistentAlias("Iif(GetDay(" + nameof(Tanggal) + ") <= 7, 1, Iif(GetDay(" + nameof(Tanggal) + ") <= 14, 2, Iif(GetDay(" + nameof(Tanggal) + ") <= 21, 3, 4)))")] public int Minggu => Convert.ToInt32(EvaluateAlias(nameof(Minggu)));
		public string AgenKode { get; set; }
		public string AgenNama { get; set; }
		public bool AgenAktif { get; set; }
		public string RuteKode { get; set; }
		public string RuteNama { get; set; }
		public string RuteKodeNama { get; set; }
		public int RegionalId { get; set; }
		public string RegionalNama { get; set; }
		public int Jatah { get; set; }
		public int Konsi { get; set; }
		public int Gratis { get; set; }
		[PersistentAlias(nameof(Jatah) + " + " + nameof(Konsi) + " + " + nameof(Gratis))] public int Oplah => Convert.ToInt32(EvaluateAlias(nameof(Oplah)));
		public int Retur { get; set; }
		[PersistentAlias(nameof(Oplah) + " - " + nameof(Retur))] public int OplahNetto => Convert.ToInt32(EvaluateAlias(nameof(OplahNetto)));

		public double OmzetJatah { get; set; }
		public double OmzetKonsi { get; set; }
		[PersistentAlias(nameof(OmzetJatah) + " + " + nameof(OmzetKonsi))] public double Omzet => Convert.ToDouble(EvaluateAlias(nameof(Omzet)));
		public double OmzetRetur { get; set; }
		[PersistentAlias(nameof(Omzet) + " - " + nameof(OmzetRetur))] public double OmzetNetto => Convert.ToDouble(EvaluateAlias(nameof(OmzetNetto)));

		public double Pembayaran { get; set; }
		public double Diskon { get; set; }
		[PersistentAlias(nameof(Pembayaran) + " - " + nameof(Diskon))] public double Setoran => Convert.ToDouble(EvaluateAlias(nameof(Setoran)));
		[PersistentAlias(nameof(OmzetNetto) + " - " + nameof(Pembayaran))] public double Piutang => Convert.ToDouble(EvaluateAlias(nameof(Piutang)));
	}
}