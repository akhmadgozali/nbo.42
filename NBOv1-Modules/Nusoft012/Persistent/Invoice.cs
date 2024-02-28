using DevExpress.Xpo;
using DevExpress.Xpo.Metadata;
using NuSoft.NPO;
using NuSoft.NUI.Win.Forms.Modules.NuSoft007.Persistent;
using System;
using System.Collections.Generic;
using System.Linq;

namespace NuSoft.NUI.Win.Forms.Modules.NuSoft012.Persistent {
	[Persistent("m12cinvoice")] internal class Invoice : NPOBase {
		internal Invoice(UnitOfWork uow) : base(uow) { }
		internal Invoice(UnitOfWork uow, XPClassInfo classInfo) : base(uow, classInfo) { }

		private long _id;
    private Wilayah _wilayah;
    private TipeInvoice _tipeInvoice;
    private string _noInvoice;
    private string _noOrder;
    private Sales _sales;
    private Pemasang _pemasang;
    private Kurir _kurir;
    private bool _saldoAwal;
    private DateTime _tanggalOmzet;
    private DateTime _tanggalInvoice;
    private DateTime _tanggalJatuhTempo;
    private string _invoiceNama;
    private string _invoiceAlamat;
    private string _invoiceTtdNama;
    private string _invoiceTtdJabatan;
    private string _invoiceNPWP;
    private string _invoiceNIK;
    private string _invoiceKeterangan;
    private DateTime _orderTanggalBayar;
    private string _orderBayarVia;
    private string _orderKontakPerson;
    private decimal _orderDp;
    private string _orderTtdNama;
    private string _orderKeterangan;
    private bool _warnaBW;
    private Merk _merk;
    private TarifIklan _tarifIklan;
    private decimal _ukuranX;
    private decimal _ukuranY;
    private int _halaman;
    private string _judulIklan;
    private string _materiDeretLinear;
    private string _materiDeretBaris;
    private int _jumlahBarisDeret;
    private decimal _hargaIklan;
    private DateTime _tanggalMulai;
    private DateTime _tanggalAkhir;
    private bool _hargaTermasukPajak;
    private decimal _bruto;
    private decimal _diskonPersen;
    private decimal _diskonNominal;
    private decimal _netto;
    private decimal _pajakPersen;
    private decimal _pajakNominal;
    private decimal _total;
    private decimal _cashbackPersen;
    private decimal _cashbackNominal;
    private decimal _potonganKomisiNominal;
    private decimal _komisiPersen;
    private decimal _komisiNominal;
    private int _cetakKe;
    private string _keterangan;
    private Invoice _indukInvoice;
    private Invoice _koreksiInvoice;
    private PPnKeluaran _taxId;

		[Key(true)] public long Id { get => _id; set => SetPropertyValue(nameof(Id), ref _id, value); }
		public Wilayah Wilayah { get => _wilayah; set => SetPropertyValue(nameof(Wilayah), ref _wilayah, value); }
		public TipeInvoice TipeInvoice { get => _tipeInvoice; set => SetPropertyValue(nameof(TipeInvoice), ref _tipeInvoice, value); }
		public string NoInvoice { get => _noInvoice; set => SetPropertyValue(nameof(NoInvoice), ref _noInvoice, value); }
		public string NoOrder { get => _noOrder; set => SetPropertyValue(nameof(NoOrder), ref _noOrder, value); }
		public Sales Sales { get => _sales; set => SetPropertyValue(nameof(Sales), ref _sales, value); }
    public Pemasang Pemasang { get => _pemasang; set => SetPropertyValue(nameof(Pemasang), ref _pemasang, value); }
    public Kurir Kurir { get => _kurir; set => SetPropertyValue(nameof(Kurir), ref _kurir, value); }
    public bool SaldoAwal { get => _saldoAwal; set => SetPropertyValue(nameof(SaldoAwal), ref _saldoAwal, value); }
    public DateTime TanggalOmzet { get => _tanggalOmzet; set => SetPropertyValue(nameof(TanggalOmzet), ref _tanggalOmzet, value); }
    public DateTime TanggalInvoice { get => _tanggalInvoice; set => SetPropertyValue(nameof(TanggalInvoice), ref _tanggalInvoice, value); }
    public DateTime TanggalJatuhTempo { get => _tanggalJatuhTempo; set => SetPropertyValue(nameof(TanggalJatuhTempo), ref _tanggalJatuhTempo, value); }
    public string InvoiceNama { get => _invoiceNama; set => SetPropertyValue(nameof(InvoiceNama), ref _invoiceNama, value); }
    public string InvoiceAlamat { get => _invoiceAlamat; set => SetPropertyValue(nameof(InvoiceAlamat), ref _invoiceAlamat, value); }
    public string InvoiceTtdNama { get => _invoiceTtdNama; set => SetPropertyValue(nameof(InvoiceTtdNama), ref _invoiceTtdNama, value); }
    public string InvoiceTtdJabatan { get => _invoiceTtdJabatan; set => SetPropertyValue(nameof(InvoiceTtdJabatan), ref _invoiceTtdJabatan, value); }
    public string InvoiceNPWP { get => _invoiceNPWP; set => SetPropertyValue(nameof(InvoiceNPWP), ref _invoiceNPWP, value); }
    public string InvoiceNIK { get => _invoiceNIK; set => SetPropertyValue(nameof(InvoiceNIK), ref _invoiceNIK, value); }
    public string InvoiceKeterangan { get => _invoiceKeterangan; set => SetPropertyValue(nameof(InvoiceKeterangan), ref _invoiceKeterangan, value); }
    public DateTime OrderTanggalBayar { get => _orderTanggalBayar; set => SetPropertyValue(nameof(OrderTanggalBayar), ref _orderTanggalBayar, value); }
    public string OrderBayarVia { get => _orderBayarVia; set => SetPropertyValue(nameof(OrderBayarVia), ref _orderBayarVia, value); }
    public string OrderKontakPerson { get => _orderKontakPerson; set => SetPropertyValue(nameof(OrderKontakPerson), ref _orderKontakPerson, value); }
    public decimal OrderDp { get => _orderDp; set => SetPropertyValue(nameof(OrderDp), ref _orderDp, value); }
    public string OrderTtdNama { get => _orderTtdNama; set => SetPropertyValue(nameof(OrderTtdNama), ref _orderTtdNama, value); }
    public string OrderKeterangan { get => _orderKeterangan; set => SetPropertyValue(nameof(OrderKeterangan), ref _orderKeterangan, value); }
    public bool WarnaBW { get => _warnaBW; set => SetPropertyValue(nameof(WarnaBW), ref _warnaBW, value); }
    public Merk Merk { get => _merk; set => SetPropertyValue(nameof(Merk), ref _merk, value); }
    public TarifIklan TarifIklan { get => _tarifIklan; set => SetPropertyValue(nameof(TarifIklan), ref _tarifIklan, value); }
    public decimal UkuranX { get => _ukuranX; set => SetPropertyValue(nameof(UkuranX), ref _ukuranX, value); }
    public decimal UkuranY { get => _ukuranY; set => SetPropertyValue(nameof(UkuranY), ref _ukuranY, value); }
    public int Halaman { get => _halaman; set => SetPropertyValue(nameof(Halaman), ref _halaman, value); }
    public string JudulIklan { get => _judulIklan; set => SetPropertyValue(nameof(JudulIklan), ref _judulIklan, value); }
    public string MateriDeretLinear { get => _materiDeretLinear; set => SetPropertyValue(nameof(MateriDeretLinear), ref _materiDeretLinear, value); }
    public string MateriDeretBaris { get => _materiDeretBaris; set => SetPropertyValue(nameof(MateriDeretBaris), ref _materiDeretBaris, value); }
    public int JumlahBarisDeret { get => _jumlahBarisDeret; set => SetPropertyValue(nameof(JumlahBarisDeret), ref _jumlahBarisDeret, value); }
    public decimal HargaIklan { get => _hargaIklan; set => SetPropertyValue(nameof(HargaIklan), ref _hargaIklan, value); }
    public DateTime TanggalMulai { get => _tanggalMulai; set => SetPropertyValue(nameof(TanggalMulai), ref _tanggalMulai, value); }
    public DateTime TanggalAkhir { get => _tanggalAkhir; set => SetPropertyValue(nameof(TanggalAkhir), ref _tanggalAkhir, value); }
    public bool HargaTermasukPajak { get => _hargaTermasukPajak; set => SetPropertyValue(nameof(HargaTermasukPajak), ref _hargaTermasukPajak, value); }
    public decimal Bruto { get => _bruto; set => SetPropertyValue(nameof(Bruto), ref _bruto, value); }
    public decimal DiskonPersen { get => _diskonPersen; set => SetPropertyValue(nameof(DiskonPersen), ref _diskonPersen, value); }
    public decimal DiskonNominal { get => _diskonNominal; set => SetPropertyValue(nameof(DiskonNominal), ref _diskonNominal, value); }
    public decimal Netto { get => _netto; set => SetPropertyValue(nameof(Netto), ref _netto, value); }
    public decimal PajakPersen { get => _pajakPersen; set => SetPropertyValue(nameof(PajakPersen), ref _pajakPersen, value); }
    public decimal PajakNominal { get => _pajakNominal; set => SetPropertyValue(nameof(PajakNominal), ref _pajakNominal, value); }
    public decimal Total { get => _total; set => SetPropertyValue(nameof(Total), ref _total, value); }
    public decimal CashbackPersen { get => _cashbackPersen; set => SetPropertyValue(nameof(CashbackPersen), ref _cashbackPersen, value); }
    public decimal CashbackNominal { get => _cashbackNominal; set => SetPropertyValue(nameof(CashbackNominal), ref _cashbackNominal, value); }
    public decimal PotonganKomisiNominal { get => _potonganKomisiNominal; set => SetPropertyValue(nameof(PotonganKomisiNominal), ref _potonganKomisiNominal, value); }
    public decimal KomisiPersen { get => _komisiPersen; set => SetPropertyValue(nameof(KomisiPersen), ref _komisiPersen, value); }
    public decimal KomisiNominal { get => _komisiNominal; set => SetPropertyValue(nameof(KomisiNominal), ref _komisiNominal, value); }
    public int CetakKe { get => _cetakKe; set => SetPropertyValue(nameof(CetakKe), ref _cetakKe, value); }
    public string Keterangan { get => _keterangan; set => SetPropertyValue(nameof(Keterangan), ref _keterangan, value); }
    [Association("m12_Invoice_Parent")] public Invoice IndukInvoice { get => _indukInvoice; set => SetPropertyValue(nameof(IndukInvoice), ref _indukInvoice, value); }
    [Association("m12_Invoice_Koreksi")] public Invoice KoreksiInvoice { get => _koreksiInvoice; set => SetPropertyValue(nameof(KoreksiInvoice), ref _koreksiInvoice, value); }
    public PPnKeluaran TaxId { get => _taxId; set => SetPropertyValue(nameof(TaxId), ref _taxId, value); }

    [Association("m12_Invoice_Terbit"), Aggregated] public XPCollection<InvoiceTerbit> DaftarTerbit => GetCollection<InvoiceTerbit>(nameof(DaftarTerbit));
    [Association("m12_Invoice_Penagihan"), Aggregated] public XPCollection<InvoicePenagihan> DaftarPenagihan => GetCollection<InvoicePenagihan>(nameof(DaftarPenagihan));
    [Association("m12_Invoice_Parent")] public XPCollection<Invoice> DaftarAnak => GetCollection<Invoice>(nameof(DaftarAnak));
    [Association("m12_Invoice_Koreksi")] public XPCollection<Invoice> DaftarKoreksi => GetCollection<Invoice>(nameof(DaftarKoreksi));
    [Association("m12_Invoice_Pembayaran")] public XPCollection<PembayaranIklanDetail> DaftarPembayaran => GetCollection<PembayaranIklanDetail>(nameof(DaftarPembayaran));

    [PersistentAlias("GetYear(" + nameof(TanggalOmzet) + ")")] public int Tahun => Convert.ToInt32(EvaluateAlias(nameof(Tahun)));
    [PersistentAlias("IIf(GetMonth(" + nameof(TanggalOmzet) + ") <= 6, 1, 2)")] public int Semester => Convert.ToInt32(EvaluateAlias(nameof(Semester)));
    [PersistentAlias("Concat(GetYear(" + nameof(TanggalOmzet) + "),'-',GetMonth(" + nameof(TanggalOmzet) + "),'-01')")] public DateTime Bulan => Convert.ToDateTime(EvaluateAlias(nameof(Bulan)));
    [PersistentAlias("Iif(GetDay(" + nameof(TanggalOmzet) + ") <= 7,1,Iif(GetDay(" + nameof(TanggalOmzet) + ") <= 14,2,Iif(GetDay(" + nameof(TanggalOmzet) + ") <= 21,3,4))) ")] public int Minggu => Convert.ToInt32(EvaluateAlias(nameof(Minggu)));
    
    [PersistentAlias("IsNull(" + nameof(DaftarKoreksi) + ".Max(" + nameof(TanggalInvoice) + "), " + nameof(TanggalInvoice) + ")")]
      public DateTime TanggalInvoiceKoreksi => Convert.ToDateTime(EvaluateAlias(nameof(TanggalInvoiceKoreksi)));

    [PersistentAlias(nameof(Bruto) + " + IsNull(" + nameof(DaftarKoreksi) + ".Sum(" + nameof(Bruto) + "), 0)")]
      public decimal BrutoKoreksi => Convert.ToDecimal(EvaluateAlias(nameof(BrutoKoreksi)));
    [PersistentAlias(nameof(DiskonNominal) + " + IsNull(" + nameof(DaftarKoreksi) + ".Sum(" + nameof(DiskonNominal) + "), 0)")]
      public decimal DiskonNominalKoreksi => Convert.ToDecimal(EvaluateAlias(nameof(DiskonNominalKoreksi)));
    [PersistentAlias(nameof(Netto) + " + IsNull(" + nameof(DaftarKoreksi) + ".Sum(" + nameof(Netto) + "), 0)")]
      public decimal NettoKoreksi => Convert.ToDecimal(EvaluateAlias(nameof(NettoKoreksi)));
    [PersistentAlias(nameof(PajakNominal) + " + IsNull(" + nameof(DaftarKoreksi) + ".Sum(" + nameof(PajakNominal) + "), 0)")]
      public decimal PajakNominalKoreksi => Convert.ToDecimal(EvaluateAlias(nameof(PajakNominalKoreksi)));
    [PersistentAlias(nameof(Total) + " + IsNull(" + nameof(DaftarKoreksi) + ".Sum(" + nameof(Total) + "), 0)")]
      public decimal TotalKoreksi => Convert.ToDecimal(EvaluateAlias(nameof(TotalKoreksi)));

    [PersistentAlias(nameof(BrutoKoreksi) + " + IsNull(" + nameof(DaftarAnak) + ".Sum(" + nameof(BrutoKoreksi) + "), 0)")]
      public decimal BrutoGabungan => Convert.ToDecimal(EvaluateAlias(nameof(BrutoGabungan)));
    [PersistentAlias("(" + nameof(DiskonNominalGabungan) + "/" + nameof(BrutoGabungan) + ") * 100")]
      public decimal DiskonPersenGabungan => Convert.ToDecimal(EvaluateAlias(nameof(DiskonPersenGabungan)));
    [PersistentAlias(nameof(DiskonNominalKoreksi) + " + IsNull(" + nameof(DaftarAnak) + ".Sum(" + nameof(DiskonNominalKoreksi) + "), 0)")]
      public decimal DiskonNominalGabungan => Convert.ToDecimal(EvaluateAlias(nameof(DiskonNominalGabungan)));
    [PersistentAlias(nameof(NettoKoreksi) + " + IsNull(" + nameof(DaftarAnak) + ".Sum(" + nameof(NettoKoreksi) + "), 0)")]
      public decimal NettoGabungan => Convert.ToDecimal(EvaluateAlias(nameof(NettoGabungan)));
    [PersistentAlias(nameof(PajakNominalKoreksi) + " + IsNull(" + nameof(DaftarAnak) + ".Sum(" + nameof(PajakNominalKoreksi) + "), 0)")]
      public decimal PajakNominalGabungan => Convert.ToDecimal(EvaluateAlias(nameof(PajakNominalGabungan)));
    [PersistentAlias(nameof(TotalKoreksi) + " + IsNull(" + nameof(DaftarAnak) + ".Sum(" + nameof(TotalKoreksi) + "), 0)")]
      public decimal TotalGabungan => Convert.ToDecimal(EvaluateAlias(nameof(TotalGabungan)));

    [PersistentAlias("Iif(IsNull(" + nameof(KoreksiInvoice) + ")," + nameof(Total) + ", 0)")]
      public decimal OmzetNonKoreksi => Convert.ToDecimal(EvaluateAlias(nameof(OmzetNonKoreksi)));
    [PersistentAlias("Iif(IsNull(" + nameof(KoreksiInvoice) + "), 0," + nameof(Total) + ")")]
      public decimal OmzetKoreksi => Convert.ToDecimal(EvaluateAlias(nameof(OmzetKoreksi)));

    [PersistentAlias(nameof(DaftarTerbit) + ".Sum(" + nameof(InvoiceTerbit.AktifInt) + ")")] public int DaftarTerbitCount => Convert.ToInt32(EvaluateAlias(nameof(DaftarTerbitCount)));
    [PersistentAlias(nameof(DaftarAnak) + ".Count()")] public int DaftarAnakCount => Convert.ToInt32(EvaluateAlias(nameof(DaftarAnakCount)));

    [PersistentAlias(nameof(DaftarPenagihan) + "[Id == ^." + nameof(DaftarPenagihan) + ".Max(Id)].Single()")]
      public InvoicePenagihan PenagihanTerakhir => (InvoicePenagihan)EvaluateAlias(nameof(PenagihanTerakhir));

    [PersistentAlias("IsNull(" + nameof(DaftarPembayaran) + ".Sum(" + nameof(PembayaranIklanDetail.NominalBayar) + "), 0)")]
      public decimal JumlahBayar => Convert.ToDecimal(EvaluateAlias(nameof(JumlahBayar)));
    [PersistentAlias("Iif(" + nameof(JumlahBayar) + " == 0, 0, Iif(" + nameof(JumlahBayar) + " < " + nameof(TotalGabungan) + ",1,2))")]
      public int StatusBayar => Convert.ToInt32(EvaluateAlias(nameof(StatusBayar)));
    [PersistentAlias(nameof(TotalGabungan) + " - " + nameof(JumlahBayar))]
      public decimal Piutang => Convert.ToDecimal(EvaluateAlias(nameof(Piutang)));
    [PersistentAlias("DateDiffDay(" + nameof(TanggalJatuhTempo) + ", Now())")] public int SelisihJatuhTempo => (int)EvaluateAlias(nameof(SelisihJatuhTempo));

    public List<InvoiceTerbitForSave> TanggalTerbitForSave { get; set; }
    public List<InvoicePenagihanForSave> PenagihanForSave { get; set; }
    public List<Invoice> GabungIklanForSave { get; set; }

    [NonPersistent] public string TanggalTerbit {
      get {
        var tglMin = DaftarTerbit.Min(o => o.TanggalTerbit);
        var tglMax = DaftarTerbit.Max(o => o.TanggalTerbit);

        if (tglMin.Year == tglMax.Year) {
          if (tglMin.Month == tglMax.Month) {
            if (tglMin.Day == tglMax.Day) return tglMax.ToString("dd MMMM yyyy");
            else return tglMin.ToString("dd") + " s/d " + tglMax.ToString("dd MMMM yyyy");
          }
          else return tglMin.ToString("dd MMMM") + " s/d " + tglMax.ToString("dd MMMM yyyy");
        }
        else return tglMin.ToString("dd MMMM yyyy") + " s/d " + tglMax.ToString("dd MMMM yyyy");
      }
    }
    [NonPersistent] public string TanggalTerbitRinci {
      get {
        var data = DaftarTerbit.Where(m => m.Aktif == true).OrderBy(o => o.TanggalTerbit).ToList();
        DateTime lastDate = default(DateTime);
        var result = "";

        foreach (var x in data) {
          if (lastDate == default(DateTime)) lastDate = x.TanggalTerbit;
          else {
            if (lastDate.Year == x.TanggalTerbit.Year) {
              if (lastDate.Month == x.TanggalTerbit.Month) result += ", " + lastDate.ToString("dd");
              else result += ", " + lastDate.ToString("dd MMM");
            }
            else result += ", " + lastDate.ToString("dd MMM yyyy");
            lastDate = x.TanggalTerbit;
          }
        }
        result += ", " + lastDate.ToString("dd MMM yyyy");
        return result.Substring(1);
      }
    }
    //[NonPersistent] public string Terbilang => Utils.Common.Character.Terbilang((double)Total).ToUpper();
    //[NonPersistent] public string TerbilangKoreksi => Utils.Common.Character.Terbilang((double)TotalKoreksi).ToUpper();
    [NonPersistent] public string TerbilangGabungan => Utils.Common.Character.Terbilang((double)TotalGabungan).ToUpper();
  }
  [Persistent("m12dinvoiceterbit")] internal class InvoiceTerbit : NPOBase {
    internal InvoiceTerbit(UnitOfWork uow) : base(uow) { }
    internal InvoiceTerbit(UnitOfWork uow, XPClassInfo classInfo) : base(uow, classInfo) { }

    private long _id;
    private Invoice _invoice;
    private DateTime _tanggalTerbit;
    private bool _aktif;
    private string _keterangan;

    [Key(true)] public long Id { get => _id; set => SetPropertyValue(nameof(Id), ref _id, value); }
    [Association("m12_Invoice_Terbit")] public Invoice Invoice { get => _invoice; set => SetPropertyValue(nameof(Invoice), ref _invoice, value); }
    public DateTime TanggalTerbit { get => _tanggalTerbit; set => SetPropertyValue(nameof(TanggalTerbit), ref _tanggalTerbit, value); }
    public bool Aktif { get => _aktif; set => SetPropertyValue(nameof(Aktif), ref _aktif, value); }
    public string Keterangan { get => _keterangan; set => SetPropertyValue(nameof(Keterangan), ref _keterangan, value); }

    [PersistentAlias("Iif(" + nameof(Aktif) + ",1,0)")] public int AktifInt => Convert.ToInt32(EvaluateAlias(nameof(AktifInt)));
  }
  internal class InvoiceTerbitForSave {
    public long Id { get; set; }
    public DateTime TanggalTerbit { get; set; }
    public bool Aktif { get; set; }
    public string Keterangan { get; set; }
  }

  [Persistent("m12dinvoicekirim")] internal class InvoicePenagihan : NPOBase {
    internal InvoicePenagihan(UnitOfWork uow) : base(uow) { }
    internal InvoicePenagihan(UnitOfWork uow, XPClassInfo classInfo) : base(uow, classInfo) { }

    private long _id;
    private Invoice _invoice;
    private DateTime _tanggalKirim;
    private string _keterangan;

    [Key(true)] public long Id { get => _id; set => SetPropertyValue(nameof(Id), ref _id, value); }
    [Association("m12_Invoice_Penagihan")] public Invoice Invoice { get => _invoice; set => SetPropertyValue(nameof(Invoice), ref _invoice, value); }
    public DateTime TanggalKirim { get => _tanggalKirim; set => SetPropertyValue(nameof(TanggalKirim), ref _tanggalKirim, value); }
    public string Keterangan { get => _keterangan; set => SetPropertyValue(nameof(Keterangan), ref _keterangan, value); }
  }
  internal class InvoicePenagihanForSave {
    public long Id { get; set; }
    public DateTime TanggalKirim { get; set; }
    public string Keterangan { get; set; }
  }

  internal class WarningTerbit {
    public long Id { get; set; }
    public string Wilayah { get; set; }
    public string Regional { get; set; }
    public int RegionalId { get; set; }
    public string NoInvoice { get; set; }
    public DateTime TglInvoice { get; set; }
    public string Sales { get; set; }
    public string Pemasang { get; set; }
    public string Merk { get; set; }
    public string Judul { get; set; }
    public DateTime TerbitTerakhir { get; set; }
    public int SisaTerbit { get; set; }
  }
}
