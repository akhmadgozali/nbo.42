using DevExpress.Xpo;
using DevExpress.Xpo.Metadata;
using NuSoft.Core.Modules;
using NuSoft.NPO;
using NuSoft.NPO.Modules;
using NuSoft.NPO.Modules.ModSys;
using NuSoft.NPO.NAttribute;
using NuSoft.NUI.Win.Forms.Modules.NuSoft001.Persistent;
using System;
using System.Collections.Generic;

namespace NuSoft.NUI.Win.Forms.Modules.NuSoft012.Persistent {
  [NonPersistent] internal abstract class TransactionMain : TransactionBase {
    internal TransactionMain(UnitOfWork uow) : base(uow) { }
    internal TransactionMain(UnitOfWork uow, XPClassInfo classInfo) : base(uow, classInfo) { }
    internal TransactionMain(UnitOfWork uow, NumberBase Nomor) : base(uow, Nomor) { }

    private Akun _ucoa;
    private SumberData _usrc;
    private Regional _ureg;

    [Persistent("u_coa"), NCriteria(Services.FinaNumberConst.FormatAkun)] public Akun UAkun { get => _ucoa; set => SetPropertyValue(nameof(UAkun), ref _ucoa, value); }
    [Persistent("u_source"), NCriteria(Services.FinaNumberConst.FormatSumber)] public SumberData USumber { get => _usrc; set => SetPropertyValue(nameof(USumber), ref _usrc, value); }
    [Persistent("u_regional"), NCriteria(Services.FinaNumberConst.FormatRegional)] public Regional URegional { get => _ureg; set => SetPropertyValue(nameof(URegional), ref _ureg, value); }

    protected override void OnSaving() {
      if (!Number.FormatNomor.Contains(Services.FinaNumberConst.FormatAkun)) _ucoa = null;
      if (!Number.FormatNomor.Contains(Services.FinaNumberConst.FormatSumber)) _usrc = null;
      if (!Number.FormatNomor.Contains(Services.FinaNumberConst.FormatRegional)) _ureg = null;

      base.OnSaving();
    }
  }

	internal enum TipeAkun {
		Kas = 1,
		Bank = 2,
		Piutang = 3,
		Persediaan = 4,
		AktivaLancarLainnya = 5,
		AktivaTetap = 6,
		AkumulasiPenyusutan = 7,
		Hutang = 8,
		HutangLancarLainnya = 9,
		HutangJangkaPanjang = 10,
		Modal = 11,
		Pendapatan = 12,
		HPP = 13,
		Biaya = 14,
		PendapatanLainLain = 15,
		BiayaLainLain = 16,
		LabaDitahan = 17,
		LabaBerjalan = 18
	}
	[Persistent("m01bcoa")] internal class Akun : NPOBase {
		internal Akun(UnitOfWork uow) : base(uow) { }
		internal Akun(UnitOfWork uow, XPClassInfo classInfo) : base(uow, classInfo) { }

		private int _id;
		private TipeAkun _tipeAkun;
		private string _kode;
		private string _nama;
		private bool _aktif;
		private Akun _induk;
		private string _formatNomor;
		private string _keterangan;

		[Persistent("p_id"), Key()] public int Id { get => _id; set => SetPropertyValue(nameof(Id), ref _id, value); }
		[Persistent("f_type")] public TipeAkun TipeAkun { get => _tipeAkun; set => SetPropertyValue(nameof(TipeAkun), ref _tipeAkun, value); }
		[Persistent("u_code")] public string Kode { get => _kode; set => SetPropertyValue(nameof(Kode), ref _kode, value); }
		[Persistent("d_name")] public string Nama { get => _nama; set => SetPropertyValue(nameof(Nama), ref _nama, value); }
		[Persistent("d_active")] public bool Aktif { get => _aktif; set => SetPropertyValue(nameof(Aktif), ref _aktif, value); }
		[Persistent("d_parent"), Association("m01Akun_Induk")] public Akun Induk { get => _induk; set => SetPropertyValue(nameof(Induk), ref _induk, value); }
		[Persistent("d_format")] public string FormatNomor { get => _formatNomor; set => SetPropertyValue(nameof(FormatNomor), ref _formatNomor, value); }
		[Persistent("d_note")] public string Keterangan { get => _keterangan; set => SetPropertyValue(nameof(Keterangan), ref _keterangan, value); }

		[Association("m01Akun_Induk")] public XPCollection<Akun> Children => GetCollection<Akun>(nameof(Children));
		[PersistentAlias(nameof(Children) + ".Count() > 0")] public bool IsInduk => (bool)EvaluateAlias(nameof(IsInduk));
	}

	[Persistent("m01cmaingl")] internal class GlMain : TransactionMain {
    internal GlMain(UnitOfWork uow) : base(uow) { }
    internal GlMain(UnitOfWork uow, XPClassInfo classInfo) : base(uow, classInfo) { }

    private Regional _regional;
    private SumberData _sumberData;
    private Akun _akunKasBank;
    private Kontak _kontak;
    private string _kontakNama;
    private string _uraian;
    private string _mataUang;
    private double _kurs;
    private string _catatan;
    private DateTime _tanggalRekonsiliasi;
    private GlMain _cashAdvance;
    private ModuleId _moduleId;
    private string _direktur;
    private string _akunting;
    private string _kasir;

    [Persistent("f_reg")] public Regional Regional { get => _regional; set => SetPropertyValue(nameof(Regional), ref _regional, value); }
    [Persistent("f_source")] public SumberData SumberData { get => _sumberData; set => SetPropertyValue(nameof(SumberData), ref _sumberData, value); }
    [Persistent("f_coa")] public Akun AkunKasBank { get => _akunKasBank; set => SetPropertyValue(nameof(AkunKasBank), ref _akunKasBank, value); }
    [Persistent("f_contact")] public Kontak Kontak { get => _kontak; set => SetPropertyValue(nameof(Kontak), ref _kontak, value); }
    [Persistent("d_contact")] public string KontakNama { get => _kontakNama; set => SetPropertyValue(nameof(KontakNama), ref _kontakNama, value); }
    [Persistent("d_description"), Size(255)] public string Uraian { get => _uraian; set => SetPropertyValue(nameof(Uraian), ref _uraian, value); }
    [Persistent("d_currency")] public string MataUang { get => _mataUang; set => SetPropertyValue(nameof(MataUang), ref _mataUang, value); }
    [Persistent("d_rate")] public double Kurs { get => _kurs; set => SetPropertyValue(nameof(Kurs), ref _kurs, value); }
    [Persistent("d_note"), Size(255)] public string Catatan { get => _catatan; set => SetPropertyValue(nameof(Catatan), ref _catatan, value); }
    [Persistent("d_reconciliation")] public DateTime TanggalRekonsiliasi { get => _tanggalRekonsiliasi; set => SetPropertyValue(nameof(TanggalRekonsiliasi), ref _tanggalRekonsiliasi, value); }
    [Persistent("fk_cashadvance")] public GlMain CashAdvance { get => _cashAdvance; set => SetPropertyValue(nameof(CashAdvance), ref _cashAdvance, value); }
    [Persistent("x_module")] public ModuleId ModuleId { get => _moduleId; set => SetPropertyValue(nameof(ModuleId), ref _moduleId, value); }
    [Persistent("d_director")] public string Direktur { get => _direktur; set => SetPropertyValue(nameof(Direktur), ref _direktur, value); }
    [Persistent("d_accounting")] public string Akunting { get => _akunting; set => SetPropertyValue(nameof(Akunting), ref _akunting, value); }
    [Persistent("d_cashier")] public string Kasir { get => _kasir; set => SetPropertyValue(nameof(Kasir), ref _kasir, value); }

    [Association("m01cmaingl_detail"), Aggregated()] public XPCollection<GlMainDetail> Detail => GetCollection<GlMainDetail>(nameof(Detail));
    [PersistentAlias("Detail.Sum(Debit)")] public double Saldo => Convert.ToDouble(EvaluateAlias(nameof(Saldo)));
    [PersistentAlias("Detail.Sum(DebitValas + KreditValas)")] public double SaldoValas => Convert.ToDouble(EvaluateAlias(nameof(SaldoValas)));
    [PersistentAlias("Detail.Sum(DebitValas)")] public double SaldoValasDebit => Convert.ToDouble(EvaluateAlias(nameof(SaldoValasDebit)));
    [PersistentAlias("Detail.Sum(KreditValas)")] public double SaldoValasKredit => Convert.ToDouble(EvaluateAlias(nameof(SaldoValasKredit)));
    [PersistentAlias("Detail.Sum(Debit - Kredit)")] public double Selisih => Convert.ToDouble(EvaluateAlias(nameof(Selisih)));
    [PersistentAlias("Terbilang(Saldo)")] public string Terbilang => Convert.ToString(EvaluateAlias(nameof(Terbilang)));

    [NonPersistent] public List<GlMainDetailForSave> DetailForSave { get; set; }
  }
  [Persistent("m01dmaindetail")] internal class GlMainDetail : NPOBase {
    internal GlMainDetail(UnitOfWork uow) : base(uow) { }
    internal GlMainDetail(UnitOfWork uow, XPClassInfo classInfo) : base(uow, classInfo) { }

    private long _id;
    private GlMain _main;
    private short _urutan;
    private Akun _akun;
    private double _debit;
    private double _kredit;
    private double _kurs;
    private Divisi _divisi;
    private MataUang _matauang;
    private double _debitv;
    private double _creditv;
    private string _keterangan;
    private bool _rekonsiliasi;

    [Persistent("primary_main"), Key(true)] public long Id { get => _id; set => SetPropertyValue(nameof(Id), ref _id, value); }
    [Persistent("p_id"), Association("m01cmaingl_detail")] public GlMain Main { get => _main; set => SetPropertyValue(nameof(Main), ref _main, value); }
    [Persistent("p_order")] public short Urutan { get => _urutan; set => SetPropertyValue(nameof(Urutan), ref _urutan, value); }
    [Persistent("f_coa")] public Akun Akun { get => _akun; set => SetPropertyValue(nameof(Akun), ref _akun, value); }
    [Persistent("d_debit")] public double Debit { get => _debit; set => SetPropertyValue(nameof(Debit), ref _debit, value); }
    [Persistent("d_credit")] public double Kredit { get => _kredit; set => SetPropertyValue(nameof(Kredit), ref _kredit, value); }
    [Persistent("d_rate")] public double Kurs { get => _kurs; set => SetPropertyValue(nameof(Kurs), ref _kurs, value); }
    [Persistent("f_currency")] public MataUang MataUang { get => _matauang; set => SetPropertyValue(nameof(MataUang), ref _matauang, value); }
    [Persistent("d_debitvalas")] public double DebitValas { get => _debitv; set => SetPropertyValue(nameof(DebitValas), ref _debitv, value); }
    [Persistent("d_creditvalas")] public double KreditValas { get => _creditv; set => SetPropertyValue(nameof(KreditValas), ref _creditv, value); }
    [Persistent("f_division")] public Divisi Divisi { get => _divisi; set => SetPropertyValue(nameof(Divisi), ref _divisi, value); }
    [Persistent("d_note")] public string Keterangan { get => _keterangan; set => SetPropertyValue(nameof(Keterangan), ref _keterangan, value); }
    [Persistent("d_rekonsiliasi")] public bool Rekonsiliasi { get => _rekonsiliasi; set => SetPropertyValue(nameof(Rekonsiliasi), ref _rekonsiliasi, value); }
  }
  internal class GlMainDetailForSave {
    public long Id { get; set; }
    public short Urutan { get; set; }
    public Akun Akun { get; set; }
    public double Debit { get; set; }
    public double Kredit { get; set; }
    public double Kurs { get; set; }
    public MataUang MataUang { get; set; }
    public double DebitValas { get; set; }
    public double KreditValas { get; set; }
    public Divisi Divisi { get; set; }
    public string Keterangan { get; set; }
    public bool Rekonsiliasi { get; set; }
  }

  [Persistent("m01period")] internal class PeriodeAkuntansi : NPOBase {
    internal PeriodeAkuntansi(UnitOfWork uow) : base(uow) { }
    internal PeriodeAkuntansi(UnitOfWork uow, XPClassInfo classInfo) : base(uow, classInfo) { }

    private int _id;
    private int _tahun;
    private int _bulan;
    private bool _tutup;

    [Persistent("p_id"), Key(true)] public int Id { get => _id; set => SetPropertyValue(nameof(Id), ref _id, value); }
    [Persistent("u_year")] public int Tahun { get => _tahun; set => SetPropertyValue(nameof(Tahun), ref _tahun, value); }
    [Persistent("u_month")] public int Bulan { get => _bulan; set => SetPropertyValue(nameof(Bulan), ref _bulan, value); }
    [Persistent("d_lock")] public bool Tutup { get => _tutup; set => SetPropertyValue(nameof(Tutup), ref _tutup, value); }

    [PersistentAlias("Concat(" + nameof(Tahun) + ",'-'," + nameof(Bulan) + ",'-01')")] public DateTime Periode => Convert.ToDateTime(EvaluateAlias(nameof(Periode)));
  }

  [Persistent("m01zregional")] internal class FinaSettingRegional : NPOBase {
    internal FinaSettingRegional(UnitOfWork uow) : base(uow) { }
    internal FinaSettingRegional(UnitOfWork uow, XPClassInfo classInfo) : base(uow, classInfo) { }

    private Regional _id;
    private string _kasirKas;
    private string _kasirBank;
    private string _akunting;
    private string _direktur;

    [Persistent("p_id"), Key()] public Regional Id { get => _id; set => SetPropertyValue(nameof(Id), ref _id, value); }
    [Persistent("d_cashier")] public string KasirKas { get => _kasirKas; set => SetPropertyValue(nameof(KasirKas), ref _kasirKas, value); }
    [Persistent("d_cashierbank")] public string KasirBank { get => _kasirBank; set => SetPropertyValue(nameof(KasirBank), ref _kasirBank, value); }
    [Persistent("d_accounting")] public string Akunting { get => _akunting; set => SetPropertyValue(nameof(Akunting), ref _akunting, value); }
    [Persistent("d_director")] public string Direktur { get => _direktur; set => SetPropertyValue(nameof(Direktur), ref _direktur, value); }
  }
}
