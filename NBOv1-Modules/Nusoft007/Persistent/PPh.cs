using DevExpress.Xpo;
using DevExpress.Xpo.Metadata;
using NuSoft.NPO;
using NuSoft.NPO.Modules;
using System;

namespace NuSoft.NUI.Win.Forms.Modules.NuSoft007.Persistent {
	[Persistent("m07bpphbuktipotong")] public class BuktiPotongPPh : NPOBase {
		public BuktiPotongPPh(UnitOfWork uow) : base(uow) { }
		public BuktiPotongPPh(UnitOfWork uow, XPClassInfo classInfo) : base(uow, classInfo) { }

		private long _id;
		private string _lokasiFile;
		private byte[] _fileBlob;

		[Key(true)] public long Id { get => _id; set => SetPropertyValue(nameof(Id), ref _id, value); }
		public string LokasiFile { get => _lokasiFile; set => SetPropertyValue(nameof(LokasiFile), ref _lokasiFile, value); }
		public byte[] FileBlob { get => _fileBlob; set => SetPropertyValue(nameof(FileBlob), ref _fileBlob, value); }
	}
	[Persistent("m07btarifpph17")] public class TarifPPh17 : NPOBase {
		public TarifPPh17(UnitOfWork uow) : base(uow) { }
		public TarifPPh17(UnitOfWork uow, XPClassInfo classInfo) : base(uow, classInfo) { }

		private int _id;
		private decimal _tarif;
		private decimal _batasBawah;
		private decimal _batasAtas;
		private string _keterangan;

		[Key(true)] public int Id { get => _id; set => SetPropertyValue(nameof(Id), ref _id, value); }
		public decimal Tarif { get => _tarif; set => SetPropertyValue(nameof(Tarif), ref _tarif, value); }
		public decimal BatasBawah { get => _batasBawah; set => SetPropertyValue(nameof(BatasBawah), ref _batasBawah, value); }
		public decimal BatasAtas { get => _batasAtas; set => SetPropertyValue(nameof(BatasAtas), ref _batasAtas, value); }
		public string Keterangan { get => _keterangan; set => SetPropertyValue(nameof(Keterangan), ref _keterangan, value); }
	}

	[Persistent("m07cpph21komisi")] public class PPh21Komisi : NPOBase {
		public PPh21Komisi(UnitOfWork uow) : base(uow) { }
		public PPh21Komisi(UnitOfWork uow, XPClassInfo classInfo) : base(uow, classInfo) { }

		private long _id;
		private string _noInvoice;
		private string _noKwitansi;
		private DateTime _tanggalInvoice;
		private DateTime _tanggalKwitansi;
		private string _wilayah;
		private string _keteranganInvoice;
		private string _penerima;
		private string _npwpPenerima;
		private decimal _dppKomisi;
		private decimal _komisiPersen;
		private decimal _komisiNominal;
		private decimal _tarifPPh21;
		private decimal _pph21;
		private string _keterangan;
		private ModuleId _moduleId;
		private BuktiPotongPPh _buktiPotong;

		[Key(true)] public long Id { get => _id; set => SetPropertyValue(nameof(Id), ref _id, value); }
		public string NoInvoice { get => _noInvoice; set => SetPropertyValue(nameof(NoInvoice), ref _noInvoice, value); }
		public string NoKwitansi { get => _noKwitansi; set => SetPropertyValue(nameof(NoKwitansi), ref _noKwitansi, value); }
		public DateTime TanggalInvoice { get => _tanggalInvoice; set => SetPropertyValue(nameof(TanggalInvoice), ref _tanggalInvoice, value); }
		public DateTime TanggalKwitansi { get => _tanggalKwitansi; set => SetPropertyValue(nameof(TanggalKwitansi), ref _tanggalKwitansi, value); }
		public string Wilayah { get => _wilayah; set => SetPropertyValue(nameof(Wilayah), ref _wilayah, value); }
		public string KeteranganInvoice { get => _keteranganInvoice; set => SetPropertyValue(nameof(KeteranganInvoice), ref _keteranganInvoice, value); }
		public string Penerima { get => _penerima; set => SetPropertyValue(nameof(Penerima), ref _penerima, value); }
		public string NPWPPenerima { get => _npwpPenerima; set => SetPropertyValue(nameof(NPWPPenerima), ref _npwpPenerima, value); }
		public decimal DppKomisi { get => _dppKomisi; set => SetPropertyValue(nameof(DppKomisi), ref _dppKomisi, value); }
		public decimal KomisiPersen { get => _komisiPersen; set => SetPropertyValue(nameof(KomisiPersen), ref _komisiPersen, value); }
		public decimal KomisiNominal { get => _komisiNominal; set => SetPropertyValue(nameof(KomisiNominal), ref _komisiNominal, value); }
		public decimal TarifPPh21 { get => _tarifPPh21; set => SetPropertyValue(nameof(TarifPPh21), ref _tarifPPh21, value); }
		public decimal PPh21 { get => _pph21; set => SetPropertyValue(nameof(PPh21), ref _pph21, value); }
		public string Keterangan { get => _keterangan; set => SetPropertyValue(nameof(Keterangan), ref _keterangan, value); }
		public ModuleId ModuleId { get => _moduleId; set => SetPropertyValue(nameof(ModuleId), ref _moduleId, value); }
		public BuktiPotongPPh BuktiPotong { get => _buktiPotong; set => SetPropertyValue(nameof(BuktiPotong), ref _buktiPotong, value); }

		[PersistentAlias("GetYear(" + nameof(TanggalKwitansi) + ")")] public int Tahun => Convert.ToInt32(EvaluateAlias(nameof(Tahun)));
		[PersistentAlias("Concat(GetYear(" + nameof(TanggalKwitansi) + "),'-',GetMonth(" + nameof(TanggalKwitansi) + "),'-01')")] public DateTime Bulan => Convert.ToDateTime(EvaluateAlias(nameof(Bulan)));
		[PersistentAlias(nameof(KomisiNominal) + " - " + nameof(PPh21))] public decimal KomisiNetto => Convert.ToDecimal(EvaluateAlias(nameof(KomisiNetto)));
		[PersistentAlias("Iif(IsNull(" + nameof(BuktiPotong) + "),0,1)")] public bool IsUploadBuktiPotong => Convert.ToBoolean(EvaluateAlias(nameof(IsUploadBuktiPotong)));
	}
	[Persistent("m07cpph23")] public class PPh23 : NPOBase {
		public PPh23(UnitOfWork uow) : base(uow) { }
		public PPh23(UnitOfWork uow, XPClassInfo classInfo) : base(uow, classInfo) { }

		private long _id;
		private string _noInvoice;
		private string _noKwitansi;
		private DateTime _tanggalInvoice;
		private DateTime _tanggalKwitansi;
		private string _wilayah;
		private string _keteranganInvoice;
		private string _pemasang;
		private decimal _dppPPh23;
		private decimal _pph23Persen;
		private decimal _pph23Nominal;
		private string _keterangan;
		private ModuleId _moduleId;
		private BuktiPotongPPh _buktiPotong;

		[Key(true)] public long Id { get => _id; set => SetPropertyValue(nameof(Id), ref _id, value); }
		public string NoInvoice { get => _noInvoice; set => SetPropertyValue(nameof(NoInvoice), ref _noInvoice, value); }
		public string NoKwitansi { get => _noKwitansi; set => SetPropertyValue(nameof(NoKwitansi), ref _noKwitansi, value); }
		public DateTime TanggalInvoice { get => _tanggalInvoice; set => SetPropertyValue(nameof(TanggalInvoice), ref _tanggalInvoice, value); }
		public DateTime TanggalKwitansi { get => _tanggalKwitansi; set => SetPropertyValue(nameof(TanggalKwitansi), ref _tanggalKwitansi, value); }
		public string Wilayah { get => _wilayah; set => SetPropertyValue(nameof(Wilayah), ref _wilayah, value); }
		public string KeteranganInvoice { get => _keteranganInvoice; set => SetPropertyValue(nameof(KeteranganInvoice), ref _keteranganInvoice, value); }
		public string Pemasang { get => _pemasang; set => SetPropertyValue(nameof(Pemasang), ref _pemasang, value); }
		public decimal DppPPh23 { get => _dppPPh23; set => SetPropertyValue(nameof(DppPPh23), ref _dppPPh23, value); }
		public decimal PPh23Persen { get => _pph23Persen; set => SetPropertyValue(nameof(PPh23Persen), ref _pph23Persen, value); }
		public decimal PPh23Nominal { get => _pph23Nominal; set => SetPropertyValue(nameof(PPh23Nominal), ref _pph23Nominal, value); }
		public string Keterangan { get => _keterangan; set => SetPropertyValue(nameof(Keterangan), ref _keterangan, value); }
		public ModuleId ModuleId { get => _moduleId; set => SetPropertyValue(nameof(ModuleId), ref _moduleId, value); }
		public BuktiPotongPPh BuktiPotong { get => _buktiPotong; set => SetPropertyValue(nameof(BuktiPotong), ref _buktiPotong, value); }

		[PersistentAlias("GetYear(" + nameof(TanggalKwitansi) + ")")] public int Tahun => Convert.ToInt32(EvaluateAlias(nameof(Tahun)));
		[PersistentAlias("Concat(GetYear(" + nameof(TanggalKwitansi) + "),'-',GetMonth(" + nameof(TanggalKwitansi) + "),'-01')")] public DateTime Bulan => Convert.ToDateTime(EvaluateAlias(nameof(Bulan)));
		[PersistentAlias("Iif(IsNull(" + nameof(BuktiPotong) + "),0,1)")] public bool IsUploadBuktiPotong => Convert.ToBoolean(EvaluateAlias(nameof(IsUploadBuktiPotong)));
	}
}