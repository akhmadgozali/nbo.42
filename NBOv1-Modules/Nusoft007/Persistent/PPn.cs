using DevExpress.Xpo;
using DevExpress.Xpo.Metadata;
using NuSoft.NPO;
using NuSoft.NPO.Modules;
using System;
using System.Collections.Generic;

namespace NuSoft.NUI.Win.Forms.Modules.NuSoft007.Persistent {
	[Persistent("m07anomorseri")] public class NomorSeriPajak : NPOBase {
		public NomorSeriPajak(UnitOfWork uow) : base(uow) { }
		public NomorSeriPajak(UnitOfWork uow, XPClassInfo classInfo) : base(uow, classInfo) { }

		private int _id;
		private DateTime _tanggalMulaiBerlaku;
		private string _nomorDari;
		private string _nomorSampai;
		private string _keterangan;

		[Key(true)] public int Id { get => _id; set => SetPropertyValue(nameof(Id), ref _id, value); }
		public DateTime TanggalMulaiBerlaku { get => _tanggalMulaiBerlaku; set => SetPropertyValue(nameof(TanggalMulaiBerlaku), ref _tanggalMulaiBerlaku, value); }
		public string NomorDari { get => _nomorDari; set => SetPropertyValue(nameof(NomorDari), ref _nomorDari, value); }
		public string NomorSampai { get => _nomorSampai; set => SetPropertyValue(nameof(NomorSampai), ref _nomorSampai, value); }
		public string Keterangan { get => _keterangan; set => SetPropertyValue(nameof(Keterangan), ref _keterangan, value); }

		[Association("fk_07nomorseripajak_detail"), Aggregated] public XPCollection<NomorSeriPajakDetail> Detail => GetCollection<NomorSeriPajakDetail>(nameof(Detail));
		[PersistentAlias(nameof(Detail) + ".Count")] public int JumlahFP => Convert.ToInt32(EvaluateAlias(nameof(JumlahFP)));
		[PersistentAlias(nameof(Detail) + ".Sum(" + nameof(NomorSeriPajakDetail.PPnKeluaran) + ".Count)")] public int Terpakai => Convert.ToInt32(EvaluateAlias(nameof(Terpakai)));
		[PersistentAlias(nameof(JumlahFP) + " - " + nameof(Terpakai))] public int SisaFP => Convert.ToInt32(EvaluateAlias(nameof(SisaFP)));
		[PersistentAlias(nameof(Terpakai) + " > 0 ")] public bool Locked => Convert.ToBoolean(EvaluateAlias(nameof(Locked)));

		[NonPersistent] public List<NomorSeriPajakDetailForSave> DetailForSave { get; set; }
	}
	[Persistent("m07bnomorseridetail")] public class NomorSeriPajakDetail : NPOBase {
		public NomorSeriPajakDetail(UnitOfWork uow) : base(uow) { }
		public NomorSeriPajakDetail(UnitOfWork uow, XPClassInfo classInfo) : base(uow, classInfo) { }

		private int _id;
		private NomorSeriPajak _main;
		private string _nomorSeriFaktur;
		private string _keterangan;

		[Key(true)] public int Id { get => _id; set => SetPropertyValue(nameof(Id), ref _id, value); }
		[Association("fk_07nomorseripajak_detail")] public NomorSeriPajak Main { get => _main; set => SetPropertyValue(nameof(Main), ref _main, value); }
		public string NomorSeriFaktur { get => _nomorSeriFaktur; set => SetPropertyValue(nameof(NomorSeriFaktur), ref _nomorSeriFaktur, value); }
		public string Keterangan { get => _keterangan; set => SetPropertyValue(nameof(Keterangan), ref _keterangan, value); }

		[Association("fk_NomorSeriPajakDetail_PPnKeluaran")] public XPCollection<PPnKeluaran> PPnKeluaran => GetCollection<PPnKeluaran>(nameof(PPnKeluaran));
		[PersistentAlias(nameof(PPnKeluaran) + ".Count > 0")] public bool Terpakai => (bool)EvaluateAlias(nameof(Terpakai));
	}
	public class NomorSeriPajakDetailForSave {
		public int Id { get; set; }
		public string NomorSeriFaktur { get; set; }
		public string Keterangan { get; set; }
		public bool Terpakai { get; set; }
	}

	[Persistent("m07bppnexportcsv")] public class PPnEksporCsv : NPOBase {
		public PPnEksporCsv(UnitOfWork uow) : base(uow) { }
		public PPnEksporCsv(UnitOfWork uow, XPClassInfo classInfo) : base(uow, classInfo) { }

		private long _id;
		private string _lokasiFile;
		private string _csv;

		[Key(true)] public long Id { get => _id; set => SetPropertyValue(nameof(Id), ref _id, value); }
		public string LokasiFile { get => _lokasiFile; set => SetPropertyValue(nameof(LokasiFile), ref _lokasiFile, value); }
		public string CSV { get => _csv; set => SetPropertyValue(nameof(CSV), ref _csv, value); }
	}
	[Persistent("m07bppnapproval")] public class PPnApprovalPdf : NPOBase {
		public PPnApprovalPdf(UnitOfWork uow) : base(uow) { }
		public PPnApprovalPdf(UnitOfWork uow, XPClassInfo classInfo) : base(uow, classInfo) { }

		private long _id;
		private string _lokasiFile;
		private byte[] _pdf;

		[Key(true)] public long Id { get => _id; set => SetPropertyValue(nameof(Id), ref _id, value); }
		public string LokasiFile { get => _lokasiFile; set => SetPropertyValue(nameof(LokasiFile), ref _lokasiFile, value); }
		public byte[] PDF { get => _pdf; set => SetPropertyValue(nameof(PDF), ref _pdf, value); }
	}

	public enum EFakturStatus { 
		Edit = 1,
		Valid = 2,
		ExportCSV = 3,
		Approval = 4,
		FPDiganti = 5,
		FPDiBatalkan = 6
	}
	[Persistent("m07cppnkeluaran")] public class PPnKeluaran : NPOBase {
		public PPnKeluaran(UnitOfWork uow) : base(uow) { }
		public PPnKeluaran(UnitOfWork uow, XPClassInfo classInfo) : base(uow, classInfo) { }

		private long _id;
		private string _kodeTransaksi;
		private string _kodeStatus;
		private string _nomorSeri;
		private DateTime _tanggal;
		private string _namaPerusahaan;
		private string _alamatPerusahaan;
		private string _npwpPerusahaan;
		private DateTime _tanggalPkpPerusahaan;
		private string _namaPelanggan;
		private string _alamatPelanggan;
		private string _npwpPelanggan;
		private string _nikPelanggan;
		private string _nomorInvoice;
		private decimal _uangMuka;
		private decimal _ppnPersen;
		private decimal _ppnNominal;
		private RegionalPajak _regional;
		private string _namaRegional;
		private string _ttdNama;
		private string _ttdJabatan;
		private ModuleId _moduleId;
		private NomorSeriPajakDetail _nomorSeriValid;
		private PPnEksporCsv _exportCSV;
		private PPnApprovalPdf _approvalPDF;
		private EFakturStatus _statusFaktur;

		[Key(true)] public long Id { get => _id; set => SetPropertyValue(nameof(Id), ref _id, value); }
		public string KodeTransaksi { get => _kodeTransaksi; set => SetPropertyValue(nameof(KodeTransaksi), ref _kodeTransaksi, value); }
		public string KodeStatus { get => _kodeStatus; set => SetPropertyValue(nameof(KodeStatus), ref _kodeStatus, value); }
		public string NomorSeri { get => _nomorSeri; set => SetPropertyValue(nameof(NomorSeri), ref _nomorSeri, value); }
		public DateTime Tanggal { get => _tanggal; set => SetPropertyValue(nameof(Tanggal), ref _tanggal, value); }
		public string NamaPerusahaan { get => _namaPerusahaan; set => SetPropertyValue(nameof(NamaPerusahaan), ref _namaPerusahaan, value); }
		public string AlamatPerusahaan { get => _alamatPerusahaan; set => SetPropertyValue(nameof(AlamatPerusahaan), ref _alamatPerusahaan, value); }
		public string NPWPPerusahaan { get => _npwpPerusahaan; set => SetPropertyValue(nameof(NPWPPerusahaan), ref _npwpPerusahaan, value); }
		public DateTime TanggalPKPPerusahaan { get => _tanggalPkpPerusahaan; set => SetPropertyValue(nameof(TanggalPKPPerusahaan), ref _tanggalPkpPerusahaan, value); }
		public string NamaPelanggan { get => _namaPelanggan; set => SetPropertyValue(nameof(NamaPelanggan), ref _namaPelanggan, value); }
		public string AlamatPelanggan { get => _alamatPelanggan; set => SetPropertyValue(nameof(AlamatPelanggan), ref _alamatPelanggan, value); }
		public string NPWPPelanggan { get => _npwpPelanggan; set => SetPropertyValue(nameof(NPWPPelanggan), ref _npwpPelanggan, value); }
		public string NIKPelanggan { get => _nikPelanggan; set => SetPropertyValue(nameof(NIKPelanggan), ref _nikPelanggan, value); }
		public string NomorInvoice { get => _nomorInvoice; set => SetPropertyValue(nameof(NomorInvoice), ref _nomorInvoice, value); }
		public decimal UangMuka { get => _uangMuka; set => SetPropertyValue(nameof(UangMuka), ref _uangMuka, value); }
		public decimal PPnPersen { get => _ppnPersen; set => SetPropertyValue(nameof(PPnPersen), ref _ppnPersen, value); }
		public decimal PPnNominal { get => _ppnNominal; set => SetPropertyValue(nameof(PPnNominal), ref _ppnNominal, value); }
		public RegionalPajak Regional { get => _regional; set => SetPropertyValue(nameof(Regional), ref _regional, value); }
		public string NamaRegional { get => _namaRegional; set => SetPropertyValue(nameof(NamaRegional), ref _namaRegional, value); }
		public string TtdNama { get => _ttdNama; set => SetPropertyValue(nameof(TtdNama), ref _ttdNama, value); }
		public string TtdJabatan { get => _ttdJabatan; set => SetPropertyValue(nameof(TtdJabatan), ref _ttdJabatan, value); }
		public ModuleId ModuleId { get => _moduleId; set => SetPropertyValue(nameof(ModuleId), ref _moduleId, value); }
		[Association("fk_NomorSeriPajakDetail_PPnKeluaran")] public NomorSeriPajakDetail NomorSeriValid { get => _nomorSeriValid; set => SetPropertyValue(nameof(NomorSeriValid), ref _nomorSeriValid, value); }
		public PPnEksporCsv ExportCSV { get => _exportCSV; set => SetPropertyValue(nameof(ExportCSV), ref _exportCSV, value); }
		public PPnApprovalPdf ApprovalPDF { get => _approvalPDF; set => SetPropertyValue(nameof(ApprovalPDF), ref _approvalPDF, value); }
		public EFakturStatus StatusFaktur { get => _statusFaktur; set => SetPropertyValue(nameof(StatusFaktur), ref _statusFaktur, value); }

		[Association("fk_07ppnkeluaran_detail"), Aggregated] public XPCollection<PPnKeluaranDetail> Detail => GetCollection<PPnKeluaranDetail>(nameof(Detail));

		[PersistentAlias("GetYear(" + nameof(Tanggal) + ")")] public int Tahun => Convert.ToInt32(EvaluateAlias(nameof(Tahun)));
		[PersistentAlias("Concat(GetYear(" + nameof(Tanggal) + "),'-',GetMonth(" + nameof(Tanggal) + "),'-01')")] public DateTime Bulan => Convert.ToDateTime(EvaluateAlias(nameof(Bulan)));
		[PersistentAlias("Concat(" + nameof(KodeTransaksi) + "," + nameof(KodeStatus) + ")")] public string KodePajak => Convert.ToString(EvaluateAlias(nameof(KodePajak)));
		[PersistentAlias("Concat(" + nameof(KodePajak) + ",'.'," + nameof(NomorSeri) + ")")] public string NoSeriLengkap => Convert.ToString(EvaluateAlias(nameof(NoSeriLengkap)));
		[PersistentAlias(nameof(Detail) + ".Sum(" + nameof(PPnKeluaranDetail.Subtotal) + ")")] public decimal Subtotal => Convert.ToDecimal(EvaluateAlias(nameof(Subtotal)));
		[PersistentAlias(nameof(Detail) + ".Sum(" + nameof(PPnKeluaranDetail.Diskon) + ")")] public decimal Diskon => Convert.ToDecimal(EvaluateAlias(nameof(Diskon)));
		[PersistentAlias(nameof(Subtotal) + " - " + nameof(Diskon) + " - " + nameof(UangMuka))] public decimal Dpp => Convert.ToDecimal(EvaluateAlias(nameof(Dpp)));
		[PersistentAlias("Iif(" + nameof(StatusFaktur) + " == 5 || " + nameof(StatusFaktur) + " == 6, 0, " + nameof(Dpp) + ")")] public decimal DppCustom => Convert.ToDecimal(EvaluateAlias(nameof(DppCustom)));
		[PersistentAlias("Iif(" + nameof(StatusFaktur) + " == 5 || " + nameof(StatusFaktur) + " == 6, 0, " + nameof(PPnNominal) + ")")] public decimal PPnNominalCustom => Convert.ToDecimal(EvaluateAlias(nameof(PPnNominalCustom)));

		[NonPersistent] public List<PPnKeluaranDetailForSave> DetailForSave { get; set; }

		// dipakai untuk FP Pengganti / FP Batal
		[NonPersistent] public string OldKodeStatus { get; set; }
		[NonPersistent] public string OldNomorSeri { get; set; }
		[NonPersistent] public NomorSeriPajakDetail OldNomorSeriValid { get; set; }
		[NonPersistent] public PPnEksporCsv OldExportCSV { get; set; }
		[NonPersistent] public PPnApprovalPdf OldApprovalPDF { get; set; }
	}
	[Persistent("m07dppnkeluarandetail")] public class PPnKeluaranDetail : NPOBase {
		public PPnKeluaranDetail(UnitOfWork uow) : base(uow) { }
		public PPnKeluaranDetail(UnitOfWork uow, XPClassInfo classInfo) : base(uow, classInfo) { }

		private long _id;
		private PPnKeluaran _main;
		private string _nama;
		private decimal _qty;
		private decimal _harga;
		private decimal _diskon;
		private string _keterangan;
		private string _referensiId;

		[Key(true)] public long Id { get => _id; set => SetPropertyValue(nameof(Id), ref _id, value); }
		[Association("fk_07ppnkeluaran_detail")] public PPnKeluaran Main { get => _main; set => SetPropertyValue(nameof(Main), ref _main, value); }
		public string Nama { get => _nama; set => SetPropertyValue(nameof(Nama), ref _nama, value); }
		public decimal Qty { get => _qty; set => SetPropertyValue(nameof(Qty), ref _qty, value); }
		public decimal Harga { get => _harga; set => SetPropertyValue(nameof(Harga), ref _harga, value); }
		public decimal Diskon { get => _diskon; set => SetPropertyValue(nameof(Diskon), ref _diskon, value); }
		public string Keterangan { get => _keterangan; set => SetPropertyValue(nameof(Keterangan), ref _keterangan, value); }
		public string ReferensiId { get => _referensiId; set => SetPropertyValue(nameof(ReferensiId), ref _referensiId, value); }

		[PersistentAlias(nameof(Qty) + " * " + nameof(Harga))] public decimal Subtotal => Convert.ToDecimal(EvaluateAlias(nameof(Subtotal)));
	}
	public class PPnKeluaranDetailForSave {
		public long Id { get; set; }
		public string Nama { get; set; }
		public decimal Qty { get; set; }
		public decimal Harga { get; set; }
		public decimal Diskon { get; set; }
		public string Keterangan { get; set; }
		public string ReferensiId { get; set; }

		public decimal Subtotal => Qty * Harga;
	}

	[Persistent("m07cppnmasukan")] public class PPnMasukan : NPOBase {
		public PPnMasukan(UnitOfWork uow) : base(uow) { }
		public PPnMasukan(UnitOfWork uow, XPClassInfo classInfo) : base(uow, classInfo) { }

		private long _id;
		private string _NomorFaktur;
		private string _SupplierNama;
		private string _SupplierNPWP;
		private DateTime _Tanggal;
		private int _MasaPajak;
		private int _TahunPajak;
		private bool _IsKredit;
		private decimal _dpp;
		private decimal _ppn;
		private decimal _ppnBM;
		private string _Keterangan;
		private ModuleId _ModuleId;

		[Key(true)] public long Id { get => _id; set => SetPropertyValue(nameof(Id), ref _id, value); }
		public string NomorFaktur { get => _NomorFaktur; set => SetPropertyValue(nameof(NomorFaktur), ref _NomorFaktur, value); }
		public string SupplierNama { get => _SupplierNama; set => SetPropertyValue(nameof(SupplierNama), ref _SupplierNama, value); }
		public string SupplierNPWP { get => _SupplierNPWP; set => SetPropertyValue(nameof(SupplierNPWP), ref _SupplierNPWP, value); }
		public DateTime Tanggal { get => _Tanggal; set => SetPropertyValue(nameof(Tanggal), ref _Tanggal, value); }
		public int MasaPajak { get => _MasaPajak; set => SetPropertyValue(nameof(MasaPajak), ref _MasaPajak, value); }
		public int TahunPajak { get => _TahunPajak; set => SetPropertyValue(nameof(TahunPajak), ref _TahunPajak, value); }
		public bool IsKredit { get => _IsKredit; set => SetPropertyValue(nameof(IsKredit), ref _IsKredit, value); }
		public decimal Dpp { get => _dpp; set => SetPropertyValue(nameof(Dpp), ref _dpp, value); }
		public decimal PPn { get => _ppn; set => SetPropertyValue(nameof(PPn), ref _ppn, value); }
		public decimal PPnBM { get => _ppnBM; set => SetPropertyValue(nameof(PPnBM), ref _ppnBM, value); }
		public string Keterangan { get => _Keterangan; set => SetPropertyValue(nameof(Keterangan), ref _Keterangan, value); }
		public ModuleId ModuleId { get => _ModuleId; set => SetPropertyValue(nameof(ModuleId), ref _ModuleId, value); }

		[PersistentAlias("Concat(" + nameof(TahunPajak) + ",'-'," + nameof(MasaPajak) + ",'-01')")] public DateTime Bulan => Convert.ToDateTime(EvaluateAlias(nameof(Bulan)));
	}
}
