using DevExpress.Xpo;
using DevExpress.Xpo.Metadata;
using NuSoft.NPO;
using NuSoft.NUI.Win.Forms.Modules.NuSoft001.Persistent;
using System;
using System.Collections.Generic;

namespace NuSoft.NUI.Win.Forms.Modules.NuSoft011.Persistent {
	[Persistent("m11corder")] internal class OrderKoran : NPOBase {
		internal OrderKoran(UnitOfWork uow) : base(uow) { }
		internal OrderKoran(UnitOfWork uow, XPClassInfo classInfo) : base(uow, classInfo) { }

		private long _id;
		private DateTime _tanggal;
		private bool _hariKhusus;
		private string _keterangan;

		[Key(true)] public long Id { get => _id; set => SetPropertyValue(nameof(Id), ref _id, value); }
		public DateTime Tanggal { get => _tanggal; set => SetPropertyValue(nameof(Tanggal), ref _tanggal, value); }
		public bool HariKhusus { get => _hariKhusus; set => SetPropertyValue(nameof(HariKhusus), ref _hariKhusus, value); }
		public string Keterangan { get => _keterangan; set => SetPropertyValue(nameof(Keterangan), ref _keterangan, value); }

		[Association("fk_orderkoran_detail"), Aggregated] public XPCollection<OrderKoranDetail> Detail => GetCollection<OrderKoranDetail>(nameof(Detail));
		[PersistentAlias("GetYear(" + nameof(Tanggal) + ")")] public int Tahun => Convert.ToInt32(EvaluateAlias(nameof(Tahun)));
		[PersistentAlias("Concat(GetYear(" + nameof(Tanggal) + "),'-',GetMonth(" + nameof(Tanggal) + "),'-01')")] public DateTime Bulan => Convert.ToDateTime(EvaluateAlias(nameof(Bulan)));
		[PersistentAlias(nameof(Detail) + ".Sum(" + nameof(OrderKoranDetail.Oplah) + ")")] public int TotalOplah => Convert.ToInt32(EvaluateAlias(nameof(TotalOplah)));
		[NonPersistent] public List<OrderKoranDetailForSave> DetailForSave { get; set; }
	}
	[Persistent("m11dorderdetail")] internal class OrderKoranDetail : NPOBase {
		internal OrderKoranDetail(UnitOfWork uow) : base(uow) { }
		internal OrderKoranDetail(UnitOfWork uow, XPClassInfo classInfo) : base(uow, classInfo) { }

		private long _id;
		private OrderKoran _main;
		private Agen _agen;
		private int _jatah;
		private int _konsi;
		private int _gratis;

		[Key(true)] public long Id { get => _id; set => SetPropertyValue(nameof(Id), ref _id, value); }
		[Association("fk_orderkoran_detail")] public OrderKoran Main { get => _main; set => SetPropertyValue(nameof(Main), ref _main, value); }
		public Agen Agen { get => _agen; set => SetPropertyValue(nameof(Agen), ref _agen, value); }
		public int Jatah { get => _jatah; set => SetPropertyValue(nameof(Jatah), ref _jatah, value); }
		public int Konsi { get => _konsi; set => SetPropertyValue(nameof(Konsi), ref _konsi, value); }
		public int Gratis { get => _gratis; set => SetPropertyValue(nameof(Gratis), ref _gratis, value); }
		[PersistentAlias(nameof(Jatah) + " + " + nameof(Konsi) + " + " + nameof(Gratis))] public int Oplah => Convert.ToInt32(EvaluateAlias(nameof(Oplah)));
	}
	internal class OrderKoranDetailForSave {
		public long Id { get; set; }
		public Agen Agen { get; set; }
		public int Jatah { get; set; }
		public int Konsi { get; set; }
		public int Gratis { get; set; }
		public int Oplah => Jatah + Konsi + Gratis;
	}

	[Persistent("m11cmutation")] internal class SirkulasiHarian : NPOBase {
		internal SirkulasiHarian(UnitOfWork uow) : base(uow) { }
		internal SirkulasiHarian(UnitOfWork uow, XPClassInfo classInfo) : base(uow, classInfo) { }

		private long _id;
		private DateTime _tanggal;
		private bool _hariKhusus;
		private string _keterangan;

		[Key(true)] public long Id { get => _id; set => SetPropertyValue(nameof(Id), ref _id, value); }
		public DateTime Tanggal { get => _tanggal; set => SetPropertyValue(nameof(Tanggal), ref _tanggal, value); }
		public bool HariKhusus { get => _hariKhusus; set => SetPropertyValue(nameof(HariKhusus), ref _hariKhusus, value); }
		public string Keterangan { get => _keterangan; set => SetPropertyValue(nameof(Keterangan), ref _keterangan, value); }

		[Association("fk_mutasikoran_detail"), Aggregated] public XPCollection<SirkulasiHarianDetail> Detail => GetCollection<SirkulasiHarianDetail>(nameof(Detail));
		[PersistentAlias("GetYear(" + nameof(Tanggal) + ")")] public int Tahun => Convert.ToInt32(EvaluateAlias(nameof(Tahun)));
		[PersistentAlias("Concat(GetYear(" + nameof(Tanggal) + "),'-',GetMonth(" + nameof(Tanggal) + "),'-01')")] public DateTime Bulan => Convert.ToDateTime(EvaluateAlias(nameof(Bulan)));
		[PersistentAlias("Iif(GetDay(" + nameof(Tanggal) + ") <= 7, 1, Iif(GetDay(" + nameof(Tanggal) + ") <= 14, 2, Iif(GetDay(" + nameof(Tanggal) + ") <= 21, 3, 4)))")] public int Minggu => Convert.ToInt32(EvaluateAlias(nameof(Minggu)));
		[PersistentAlias(nameof(Detail) + ".Sum(" + nameof(SirkulasiHarianDetail.Oplah) + ")")] public int TotalOplah => Convert.ToInt32(EvaluateAlias(nameof(TotalOplah)));
		[PersistentAlias(nameof(Detail) + ".Sum(" + nameof(SirkulasiHarianDetail.Omzet) + ")")] public double TotalOmzet => Convert.ToDouble(EvaluateAlias(nameof(TotalOmzet)));
		[NonPersistent] public List<SirkulasiHarianDetailForSave> DetailForSave { get; set; }
	}
	[Persistent("m11dmutationdetail")] internal class SirkulasiHarianDetail : NPOBase {
		internal SirkulasiHarianDetail(UnitOfWork uow) : base(uow) { }
		internal SirkulasiHarianDetail(UnitOfWork uow, XPClassInfo classInfo) : base(uow, classInfo) { }

		private long _id;
		private SirkulasiHarian _main;
		private Agen _agen;
		private int _jatahOrder;
		private int _jatahMutasi;
		private int _konsiOrder;
		private int _konsiMutasi;
		private int _gratisOrder;
		private int _gratisMutasi;
		private double _hargaJatah;
		private double _hargaKonsi;
		private string _keterangan;
		private int _retur;
		private string _keteranganRetur;

		[Key(true)] public long Id { get => _id; set => SetPropertyValue(nameof(Id), ref _id, value); }
		[Association("fk_mutasikoran_detail")] public SirkulasiHarian Main { get => _main; set => SetPropertyValue(nameof(Main), ref _main, value); }
		public Agen Agen { get => _agen; set => SetPropertyValue(nameof(Agen), ref _agen, value); }
		public int JatahOrder { get => _jatahOrder; set => SetPropertyValue(nameof(JatahOrder), ref _jatahOrder, value); }
		public int JatahMutasi { get => _jatahMutasi; set => SetPropertyValue(nameof(JatahMutasi), ref _jatahMutasi, value); }
		public int KonsiOrder { get => _konsiOrder; set => SetPropertyValue(nameof(KonsiOrder), ref _konsiOrder, value); }
		public int KonsiMutasi { get => _konsiMutasi; set => SetPropertyValue(nameof(KonsiMutasi), ref _konsiMutasi, value); }
		public int GratisOrder { get => _gratisOrder; set => SetPropertyValue(nameof(GratisOrder), ref _gratisOrder, value); }
		public int GratisMutasi { get => _gratisMutasi; set => SetPropertyValue(nameof(GratisMutasi), ref _gratisMutasi, value); }
		public double HargaJatah { get => _hargaJatah; set => SetPropertyValue(nameof(HargaJatah), ref _hargaJatah, value); }
		public double HargaKonsi { get => _hargaKonsi; set => SetPropertyValue(nameof(HargaKonsi), ref _hargaKonsi, value); }
		public string Keterangan { get => _keterangan; set => SetPropertyValue(nameof(Keterangan), ref _keterangan, value); }
		public int Retur { get => _retur; set => SetPropertyValue(nameof(Retur), ref _retur, value); }
		public string KeteranganRetur { get => _keteranganRetur; set => SetPropertyValue(nameof(KeteranganRetur), ref _keteranganRetur, value); }

		[PersistentAlias(nameof(JatahOrder) + " + " + nameof(JatahMutasi))] public int Jatah => Convert.ToInt32(EvaluateAlias(nameof(Jatah)));
		[PersistentAlias(nameof(KonsiOrder) + " + " + nameof(KonsiMutasi))] public int Konsi => Convert.ToInt32(EvaluateAlias(nameof(Konsi)));
		[PersistentAlias(nameof(GratisOrder) + " + " + nameof(GratisMutasi))] public int Gratis => Convert.ToInt32(EvaluateAlias(nameof(Gratis)));
		[PersistentAlias(nameof(Jatah) + " + " + nameof(Konsi) + " + " + nameof(Gratis))] public int Oplah => Convert.ToInt32(EvaluateAlias(nameof(Oplah)));
		[PersistentAlias(nameof(Oplah) + " - " + nameof(Retur))] public int OplahDikurangiRetur => Convert.ToInt32(EvaluateAlias(nameof(OplahDikurangiRetur)));

		[PersistentAlias(nameof(Jatah) + " * " + nameof(HargaJatah))] public double OmzetJatah => Convert.ToDouble(EvaluateAlias(nameof(OmzetJatah)));
		[PersistentAlias(nameof(Konsi) + " * " + nameof(HargaKonsi))] public double OmzetKonsi => Convert.ToDouble(EvaluateAlias(nameof(OmzetKonsi)));
		[PersistentAlias(nameof(OmzetJatah) + " + " + nameof(OmzetKonsi))] public double Omzet => Convert.ToDouble(EvaluateAlias(nameof(Omzet)));
		[PersistentAlias(nameof(Retur) + " * " + nameof(HargaKonsi))] public double OmzetRetur => Convert.ToDouble(EvaluateAlias(nameof(OmzetRetur)));
		[PersistentAlias(nameof(Omzet) + " - " + nameof(OmzetRetur))] public double OmzetDikurangiRetur => Convert.ToDouble(EvaluateAlias(nameof(OmzetDikurangiRetur)));
	}
	internal class SirkulasiHarianDetailForSave {
		public long Id { get; set; }
		public Agen Agen { get; set; }
		public int JatahOrder { get; set; }
		public int JatahMutasi { get; set; }
		public int KonsiOrder { get; set; }
		public int KonsiMutasi { get; set; }
		public int GratisOrder { get; set; }
		public int GratisMutasi { get; set; }
		public double HargaJatah { get; set; }
		public double HargaKonsi { get; set; }
		public string Keterangan { get; set; }
		public int Retur { get; set; }
		public string KeteranganRetur { get; set; }

		public int Jatah => JatahOrder + JatahMutasi;
		public int Konsi => KonsiOrder + KonsiMutasi;
		public int Gratis => GratisOrder + GratisMutasi;
		public int TotalOrder => JatahOrder + KonsiOrder + GratisOrder;
		public int Oplah => Jatah + Konsi + Gratis;
	}
	internal class LabelExpedisi {
		public int Id { get; set; }
		public DateTime Tanggal { get; set; }
		public string NamaAgen { get; set; }
		public string AlamatAgen { get; set; }
		public string NoHPAgen { get; set; }
		public string WilayahKode { get; set; }
		public string WilayahNama { get; set; }
		public int Jatah { get; set; }
		public int Konsi { get; set; }
		public int Gratis { get; set; }
		public int KoliKe { get; set; }
		public int JumlahKoli { get; set; }
		public int KoranPerKoli { get; set; }

		public int JumlahKoran => Jatah + Konsi + Gratis;
	}

	[Persistent("m11vwsirkulasiagen")] internal class SirkulasiAgen : XPLiteObject {
		public SirkulasiAgen(UnitOfWork uow) : base(uow) { }
		public SirkulasiAgen(UnitOfWork uow, XPClassInfo classInfo) : base(uow, classInfo) { }

		[Key] public ulong Id { get; set; }
		public DateTime Tanggal { get; set; }
		public Agen Agen { get; set; }
		public int Jatah { get; set; }
		public int Konsi { get; set; }
		public int Gratis { get; set; }
		public int Retur { get; set; }
		public double OmzetJatah { get; set; }
		public double OmzetKonsi { get; set; }
		public double OmzetRetur { get; set; }

		[PersistentAlias("GetYear(" + nameof(Tanggal) + ")")] public int Tahun => (int)EvaluateAlias(nameof(Tahun));
		[PersistentAlias(nameof(Jatah) + "+" + nameof(Konsi) + "+" + nameof(Gratis))] public int Oplah => Convert.ToInt32(EvaluateAlias(nameof(Oplah)));
		[PersistentAlias(nameof(OmzetJatah) + "+" + nameof(OmzetKonsi))] public double Omzet => Convert.ToDouble(EvaluateAlias(nameof(Omzet)));
	}
}
