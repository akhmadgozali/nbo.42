using DevExpress.Xpo;
using DevExpress.Xpo.Metadata;
using NuSoft.NPO;
using NuSoft.NPO.Modules.ModSys;
using NuSoft.NUI.Win.Forms.Modules.NuSoft007.Persistent;
using System;
using System.Collections.Generic;

namespace NuSoft.NUI.Win.Forms.Modules.NuSoft012.Persistent {
	[Persistent("m12cpembayaraniklan")] internal class PembayaranIklan : NPOBase {
		internal PembayaranIklan(UnitOfWork uow) : base(uow) { }
		internal PembayaranIklan(UnitOfWork uow, XPClassInfo classInfo) : base(uow, classInfo) { }

		private long _id;
		private Regional _regional;
		private string _noKwitansi;
		private DateTime _tanggal;
		private CaraBayar _caraBayar;
		private Sales _sales;
		private string _pemasang;
		private string _keterangan;
		private GlMain _glId;
		private PembayaranIklan _batalBayarId;

		[Key(true)] public long Id { get => _id; set => SetPropertyValue(nameof(Id), ref _id, value); }
		public Regional Regional { get => _regional; set => SetPropertyValue(nameof(Regional), ref _regional, value); }
		public string NoKwitansi { get => _noKwitansi; set => SetPropertyValue(nameof(NoKwitansi), ref _noKwitansi, value); }
		public DateTime Tanggal { get => _tanggal; set => SetPropertyValue(nameof(Tanggal), ref _tanggal, value); }
		public CaraBayar CaraBayar { get => _caraBayar; set => SetPropertyValue(nameof(CaraBayar), ref _caraBayar, value); }
		public Sales Sales { get => _sales; set => SetPropertyValue(nameof(Sales), ref _sales, value); }
		public string Pemasang { get => _pemasang; set => SetPropertyValue(nameof(Pemasang), ref _pemasang, value); }
		public string Keterangan { get => _keterangan; set => SetPropertyValue(nameof(Keterangan), ref _keterangan, value); }
		public GlMain GLId { get => _glId; set => SetPropertyValue(nameof(GLId), ref _glId, value); }
		public PembayaranIklan BatalBayarId { get => _batalBayarId; set => SetPropertyValue(nameof(BatalBayarId), ref _batalBayarId, value); }

		[PersistentAlias("GetYear(" + nameof(Tanggal) + ")")] public int Tahun => Convert.ToInt32(EvaluateAlias(nameof(Tahun)));
		[PersistentAlias("Concat(GetYear(" + nameof(Tanggal) + "),'-',GetMonth(" + nameof(Tanggal) + "),'-01')")] public DateTime Bulan => Convert.ToDateTime(EvaluateAlias(nameof(Bulan)));
		[PersistentAlias("IIf(GetMonth(" + nameof(Tanggal) + ") <= 6, 1, 2)")] public int Semester => Convert.ToInt32(EvaluateAlias(nameof(Semester)));
		[PersistentAlias("Iif(GetDay(" + nameof(Tanggal) + ") <= 7, 1, Iif(GetDay(" + nameof(Tanggal) + ") <= 14, 2, Iif(GetDay(" + nameof(Tanggal) + ") <= 21, 3, 4)))")] public int Minggu => Convert.ToInt32(EvaluateAlias(nameof(Minggu)));

		[Association("m12_PembayaranIklan_Detail"), Aggregated] public XPCollection<PembayaranIklanDetail> Detail => GetCollection<PembayaranIklanDetail>(nameof(Detail));
		[PersistentAlias(nameof(Detail) + ".Sum(" + nameof(PembayaranIklanDetail.NominalBayar) + ")")] public decimal JumlahBayar => Convert.ToDecimal(EvaluateAlias(nameof(JumlahBayar)));

		[PersistentAlias("Iif(IsNull(" + nameof(Sales) + ")," + nameof(Pemasang) + "," + nameof(Sales) + "." + nameof(Persistent.Sales.Nama) + ")")] public string AtasNama => Convert.ToString(EvaluateAlias(nameof(AtasNama)));

		[PersistentAlias("Iif(IsNull(" + nameof(BatalBayarId) + ")," + nameof(JumlahBayar) + ", 0)")]
			public decimal PembayaranNonKoreksi => Convert.ToDecimal(EvaluateAlias(nameof(PembayaranNonKoreksi)));
		[PersistentAlias("Iif(IsNull(" + nameof(BatalBayarId) + "), 0," + nameof(JumlahBayar) + ")")]
			public decimal PembayaranKoreksi => Convert.ToDecimal(EvaluateAlias(nameof(PembayaranKoreksi)));

		[NonPersistent] public List<PembayaranIklanDetailForSave> DetailForSave { get; set; }
		[NonPersistent] public List<BatalBayarIklanDetailForSave> BatalBayarDetailForSave { get; set; }
		[NonPersistent] public string Terbilang => Utils.Common.Character.Terbilang((double)JumlahBayar).ToUpper();
	}
	[Persistent("m12dpembayaraniklandetail")] internal class PembayaranIklanDetail : NPOBase {
		internal PembayaranIklanDetail(UnitOfWork uow) : base(uow) { }
		internal PembayaranIklanDetail(UnitOfWork uow, XPClassInfo classInfo) : base(uow, classInfo) { }

		private long _id;
		private PembayaranIklan _pembayaran;
		private Invoice _invoice;
		private decimal _nominalBayar;
		private bool _lunas;
		private decimal _cashbackPersen;
		private decimal _cashbackNominal;
		private decimal _potonganKomisiNominal;
		private decimal _komisiPersen;
		private decimal _komisiNominal;
		private PPh23 _pph23Id;
		private string _keterangan;

		[Key(true)] public long Id { get => _id; set => SetPropertyValue(nameof(Id), ref _id, value); }
		[Association("m12_PembayaranIklan_Detail")] public PembayaranIklan Pembayaran { get => _pembayaran; set => SetPropertyValue(nameof(Pembayaran), ref _pembayaran, value); }
		[Association("m12_Invoice_Pembayaran")] public Invoice Invoice { get => _invoice; set => SetPropertyValue(nameof(Invoice), ref _invoice, value); }
		public decimal NominalBayar { get => _nominalBayar; set => SetPropertyValue(nameof(NominalBayar), ref _nominalBayar, value); }
		public bool Lunas { get => _lunas; set => SetPropertyValue(nameof(Lunas), ref _lunas, value); }
		public decimal CashbackPersen { get => _cashbackPersen; set => SetPropertyValue(nameof(CashbackPersen), ref _cashbackPersen, value); }
		public decimal CashbackNominal { get => _cashbackNominal; set => SetPropertyValue(nameof(CashbackNominal), ref _cashbackNominal, value); }
		public decimal PotonganKomisiNominal { get => _potonganKomisiNominal; set => SetPropertyValue(nameof(PotonganKomisiNominal), ref _potonganKomisiNominal, value); }
		public decimal KomisiPersen { get => _komisiPersen; set => SetPropertyValue(nameof(KomisiPersen), ref _komisiPersen, value); }
		public decimal KomisiNominal { get => _komisiNominal; set => SetPropertyValue(nameof(KomisiNominal), ref _komisiNominal, value); }
		public PPh23 PPh23Id { get => _pph23Id; set => SetPropertyValue(nameof(PPh23Id), ref _pph23Id, value); }
		public string Keterangan { get => _keterangan; set => SetPropertyValue(nameof(Keterangan), ref _keterangan, value); }

		[Association("m12_PembayaranIklanDetail_Komisi")] public XPCollection<PencairanKomisiDetail> BayarKomisi => GetCollection<PencairanKomisiDetail>(nameof(BayarKomisi));
		[Association("m12_PembayaranIklanDetail_Cashback")] public XPCollection<PencairanCashbackDetail> BayarCashback => GetCollection<PencairanCashbackDetail>(nameof(BayarCashback));

		[PersistentAlias("IsNull(" + nameof(BayarKomisi) + ".Sum(" + nameof(PencairanKomisiDetail.NominalCair) + "), 0)")]
			public decimal JumlahKomisiCair => Convert.ToDecimal(EvaluateAlias(nameof(JumlahKomisiCair)));
		[PersistentAlias(nameof(KomisiNominal) + " - " + nameof(JumlahKomisiCair))]
			public decimal HutangKomisi => Convert.ToDecimal(EvaluateAlias(nameof(HutangKomisi)));
		[PersistentAlias("IsNull(" + nameof(BayarCashback) + ".Sum(" + nameof(PencairanCashbackDetail.NominalCair) + "), 0)")]
			public decimal JumlahCashbackCair => Convert.ToDecimal(EvaluateAlias(nameof(JumlahCashbackCair)));
		[PersistentAlias(nameof(CashbackNominal) + " - " + nameof(JumlahCashbackCair))]
			public decimal HutangCashback => Convert.ToDecimal(EvaluateAlias(nameof(HutangCashback)));

		[PersistentAlias("Iif(IsNull(" + nameof(Pembayaran) + "." + nameof(PembayaranIklan.BatalBayarId) + ")," + nameof(NominalBayar) + ", 0)")]
			public decimal PembayaranNonKoreksi => Convert.ToDecimal(EvaluateAlias(nameof(PembayaranNonKoreksi)));
		[PersistentAlias("Iif(IsNull(" + nameof(Pembayaran) + "." + nameof(PembayaranIklan.BatalBayarId) + "), 0," + nameof(NominalBayar) + ")")]
			public decimal PembayaranKoreksi => Convert.ToDecimal(EvaluateAlias(nameof(PembayaranKoreksi)));
	}
	internal class PembayaranIklanDetailForSave {
		public long Id { get; set; }
		public Invoice Invoice { get; set; }
		public decimal NominalBayar { get; set; }
		public decimal CashbackPersen { get; set; }
		public decimal CashbackNominal { get; set; }
		public decimal PotonganKomisiNominal { get; set; }
		public decimal KomisiPersen { get; set; }
		public decimal KomisiNominal { get; set; }
		public string Keterangan { get; set; }

		public bool AllowEdit { get; set; }
		public decimal Omzet { get; set; }
		public decimal Terbayar { get; set; }
		public decimal Piutang => Omzet - Terbayar;
	}
	internal class BatalBayarIklanDetailForSave {
		public long Id { get; set; }
		public PembayaranIklanDetail PembayaranDetail { get; set; }
		public bool AllowEdit { get; set; }
		public string NoInvoice { get; set; }
		public DateTime Tanggal { get; set; }
		public string Sales { get; set; }
		public string Pemasang { get; set; }
		public string Keterangan { get; set; }

		public decimal InvoiceNominalBayar { get; set; }
		public decimal KoreksiNominalBayar { get; set; }
		public decimal SelisihNominalBayar => KoreksiNominalBayar - InvoiceNominalBayar;
	}

	[Persistent("m12dpencairankomisi")] internal class PencairanKomisi : NPOBase {
		internal PencairanKomisi(UnitOfWork uow) : base(uow) { }
		internal PencairanKomisi(UnitOfWork uow, XPClassInfo classInfo) : base(uow, classInfo) { }

		private long _id;
		private Regional _regional;
		private string _noBukti;
		private DateTime _tanggal;
		private CaraBayar _caraBayar;
		private Sales _sales;
		private string _keterangan;
		private GlMain _glId;

		[Key(true)] public long Id { get => _id; set => SetPropertyValue(nameof(Id), ref _id, value); }
		public Regional Regional { get => _regional; set => SetPropertyValue(nameof(Regional), ref _regional, value); }
		public string NoBukti { get => _noBukti; set => SetPropertyValue(nameof(NoBukti), ref _noBukti, value); }
		public DateTime Tanggal { get => _tanggal; set => SetPropertyValue(nameof(Tanggal), ref _tanggal, value); }
		public CaraBayar CaraBayar { get => _caraBayar; set => SetPropertyValue(nameof(CaraBayar), ref _caraBayar, value); }
		public Sales Sales { get => _sales; set => SetPropertyValue(nameof(Sales), ref _sales, value); }
		public string Keterangan { get => _keterangan; set => SetPropertyValue(nameof(Keterangan), ref _keterangan, value); }
		public GlMain GLId { get => _glId; set => SetPropertyValue(nameof(GLId), ref _glId, value); }

		[PersistentAlias("GetYear(" + nameof(Tanggal) + ")")] public int Tahun => Convert.ToInt32(EvaluateAlias(nameof(Tahun)));
		[PersistentAlias("Concat(GetYear(" + nameof(Tanggal) + "),'-',GetMonth(" + nameof(Tanggal) + "),'-01')")] public DateTime Bulan => Convert.ToDateTime(EvaluateAlias(nameof(Bulan)));
		[PersistentAlias("IIf(GetMonth(" + nameof(Tanggal) + ") <= 6, 1, 2)")] public int Semester => Convert.ToInt32(EvaluateAlias(nameof(Semester)));
		[PersistentAlias("Iif(GetDay(" + nameof(Tanggal) + ") <= 7, 1, Iif(GetDay(" + nameof(Tanggal) + ") <= 14, 2, Iif(GetDay(" + nameof(Tanggal) + ") <= 21, 3, 4)))")] public int Minggu => Convert.ToInt32(EvaluateAlias(nameof(Minggu)));

		[Association("m12_PencairanKomisi_Detail"), Aggregated] public XPCollection<PencairanKomisiDetail> Detail => GetCollection<PencairanKomisiDetail>(nameof(Detail));
		[PersistentAlias(nameof(Detail) + ".Sum(" + nameof(PencairanKomisiDetail.NominalCair) + ")")] public decimal JumlahPencairan => Convert.ToDecimal(EvaluateAlias(nameof(JumlahPencairan)));

		[NonPersistent] public List<PencairanKomisiDetailForSave> DetailForSave { get; set; }
		[NonPersistent] public string Terbilang => Utils.Common.Character.Terbilang((double)JumlahPencairan).ToUpper();
	}
	[Persistent("m12epencairankomisidetail")] internal class PencairanKomisiDetail : NPOBase {
		internal PencairanKomisiDetail(UnitOfWork uow) : base(uow) { }
		internal PencairanKomisiDetail(UnitOfWork uow, XPClassInfo classInfo) : base(uow, classInfo) { }

		private long _id;
		private PencairanKomisi _pencairanKomisi;
		private PembayaranIklanDetail _komisi;
		private decimal _nominalCair;
		private string _keterangan;
		private PPh21Komisi _pph21KomisiId;

		[Key(true)] public long Id { get => _id; set => SetPropertyValue(nameof(Id), ref _id, value); }
		[Association("m12_PencairanKomisi_Detail")] public PencairanKomisi PencairanKomisi { get => _pencairanKomisi; set => SetPropertyValue(nameof(PencairanKomisi), ref _pencairanKomisi, value); }
		[Association("m12_PembayaranIklanDetail_Komisi")] public PembayaranIklanDetail Komisi { get => _komisi; set => SetPropertyValue(nameof(Komisi), ref _komisi, value); }
		public decimal NominalCair { get => _nominalCair; set => SetPropertyValue(nameof(NominalCair), ref _nominalCair, value); }
		public string Keterangan { get => _keterangan; set => SetPropertyValue(nameof(Keterangan), ref _keterangan, value); }
		public PPh21Komisi PPh21KomisiId { get => _pph21KomisiId; set => SetPropertyValue(nameof(PPh21KomisiId), ref _pph21KomisiId, value); }
	}
	internal class PencairanKomisiDetailForSave {
		public long Id { get; set; }
		public PembayaranIklanDetail Komisi { get; set; }
		public decimal NominalCair { get; set; }
		public string Keterangan { get; set; }

		public bool AllowEdit { get; set; }
		public decimal Nominal { get; set; }
		public decimal Cair { get; set; }
		public decimal Hutang => Nominal - Cair;
	}

	[Persistent("m12dpencairancashback")] internal class PencairanCashback : NPOBase {
		internal PencairanCashback(UnitOfWork uow) : base(uow) { }
		internal PencairanCashback(UnitOfWork uow, XPClassInfo classInfo) : base(uow, classInfo) { }

		private long _id;
		private Regional _regional;
		private string _noBukti;
		private DateTime _tanggal;
		private CaraBayar _caraBayar;
		private string _pemasang;
		private string _keterangan;
		private GlMain _glId;

		[Key(true)] public long Id { get => _id; set => SetPropertyValue(nameof(Id), ref _id, value); }
		public Regional Regional { get => _regional; set => SetPropertyValue(nameof(Regional), ref _regional, value); }
		public string NoBukti { get => _noBukti; set => SetPropertyValue(nameof(NoBukti), ref _noBukti, value); }
		public DateTime Tanggal { get => _tanggal; set => SetPropertyValue(nameof(Tanggal), ref _tanggal, value); }
		public CaraBayar CaraBayar { get => _caraBayar; set => SetPropertyValue(nameof(CaraBayar), ref _caraBayar, value); }
		public string Pemasang { get => _pemasang; set => SetPropertyValue(nameof(Pemasang), ref _pemasang, value); }
		public string Keterangan { get => _keterangan; set => SetPropertyValue(nameof(Keterangan), ref _keterangan, value); }
		public GlMain GLId { get => _glId; set => SetPropertyValue(nameof(GLId), ref _glId, value); }

		[PersistentAlias("GetYear(" + nameof(Tanggal) + ")")] public int Tahun => Convert.ToInt32(EvaluateAlias(nameof(Tahun)));
		[PersistentAlias("Concat(GetYear(" + nameof(Tanggal) + "),'-',GetMonth(" + nameof(Tanggal) + "),'-01')")] public DateTime Bulan => Convert.ToDateTime(EvaluateAlias(nameof(Bulan)));
		[PersistentAlias("IIf(GetMonth(" + nameof(Tanggal) + ") <= 6, 1, 2)")] public int Semester => Convert.ToInt32(EvaluateAlias(nameof(Semester)));
		[PersistentAlias("Iif(GetDay(" + nameof(Tanggal) + ") <= 7, 1, Iif(GetDay(" + nameof(Tanggal) + ") <= 14, 2, Iif(GetDay(" + nameof(Tanggal) + ") <= 21, 3, 4)))")] public int Minggu => Convert.ToInt32(EvaluateAlias(nameof(Minggu)));

		[Association("m12_PencairanCashback_Detail"), Aggregated] public XPCollection<PencairanCashbackDetail> Detail => GetCollection<PencairanCashbackDetail>(nameof(Detail));
		[PersistentAlias(nameof(Detail) + ".Sum(" + nameof(PencairanCashbackDetail.NominalCair) + ")")] public decimal JumlahPencairan => Convert.ToDecimal(EvaluateAlias(nameof(JumlahPencairan)));

		[NonPersistent] public List<PencairanCashbackDetailForSave> DetailForSave { get; set; }
		[NonPersistent] public string Terbilang => Utils.Common.Character.Terbilang((double)JumlahPencairan).ToUpper();
	}
	[Persistent("m12epencairancashbackdetail")] internal class PencairanCashbackDetail : NPOBase {
		internal PencairanCashbackDetail(UnitOfWork uow) : base(uow) { }
		internal PencairanCashbackDetail(UnitOfWork uow, XPClassInfo classInfo) : base(uow, classInfo) { }

		private long _id;
		private PencairanCashback _pencairanCashback;
		private PembayaranIklanDetail _cashback;
		private decimal _nominalCair;
		private string _keterangan;

		[Key(true)] public long Id { get => _id; set => SetPropertyValue(nameof(Id), ref _id, value); }
		[Association("m12_PencairanCashback_Detail")] public PencairanCashback PencairanCashback { get => _pencairanCashback; set => SetPropertyValue(nameof(PencairanCashback), ref _pencairanCashback, value); }
		[Association("m12_PembayaranIklanDetail_Cashback")] public PembayaranIklanDetail Cashback { get => _cashback; set => SetPropertyValue(nameof(Cashback), ref _cashback, value); }
		public decimal NominalCair { get => _nominalCair; set => SetPropertyValue(nameof(NominalCair), ref _nominalCair, value); }
		public string Keterangan { get => _keterangan; set => SetPropertyValue(nameof(Keterangan), ref _keterangan, value); }
	}
	internal class PencairanCashbackDetailForSave {
		public long Id { get; set; }
		public PembayaranIklanDetail Cashback { get; set; }
		public decimal NominalCair { get; set; }
		public string Keterangan { get; set; }

		public bool AllowEdit { get; set; }
		public decimal Nominal { get; set; }
		public decimal Cair { get; set; }
		public decimal Hutang => Nominal - Cair;
	}
}