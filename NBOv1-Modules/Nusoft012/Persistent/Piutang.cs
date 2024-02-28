using DevExpress.Xpo;
using System;

namespace NuSoft.NUI.Win.Forms.Modules.NuSoft012.Persistent {
	[NonPersistent] public class ViewPiutangRincianIklan : XPLiteObject {
		public ViewPiutangRincianIklan(UnitOfWork uow) : base(uow) { }
		[Key] public ulong Id { get; set; }
		public string NoInvoice { get; set; }
		public DateTime Tanggal { get; set; }
		public DateTime TanggalJatuhTempo { get; set; }
		public string Wilayah { get; set; }
		public string Regional { get; set; }
		public long RegionalId { get; set; }
		public string Pemasang { get; set; }
		public long SalesId { get; set; }
		public string Sales { get; set; }
		public string TipeInvoice { get; set; }
		public string KelompokOmzet { get; set; }
		public long KelompokOmzetId { get; set; }
		public double Netto { get; set; }
		public double PPn { get; set; }
		public double Omzet { get; set; }
		public double Pembayaran { get; set; }
		public string JudulIklan { get; set; }

		[NonPersistent] public int Tahun => Tanggal.Year;
		[NonPersistent] public DateTime Bulan => new DateTime(Tanggal.Year, Tanggal.Month, 1);
		[NonPersistent] public int Semester => Tanggal.Month <= 6 ? 1 : 2;
		[NonPersistent] public int Triwulan => Tanggal.Month <= 3 ? 1 : Tanggal.Month <= 6 ? 2 : Tanggal.Month <= 9 ? 3 : 4;
		[NonPersistent] public int Minggu => Tanggal.Day <= 7 ? 1 : Tanggal.Day <= 14 ? 2 : Tanggal.Day <= 21 ? 3 : 4;
		[NonPersistent] public double Piutang => Omzet - Pembayaran;
	}
	public class ViewPiutangBerjalanIklan {
		public string Wilayah { get; set; }
		public string Regional { get; set; }
		public long RegionalId { get; set; }
		public string PemasangSales { get; set; }
		public string Sales { get; set; }
		public string Pemasang { get; set; }
		public string TipeInvoice { get; set; }
		public string KelompokOmzet { get; set; }
		public long KelompokOmzetId { get; set; }
		public string NoInvoice { get; set; }
		public DateTime Tanggal { get; set; }
		public DateTime TanggalJatuhTempo { get; set; }

		public double SaldoAwal { get; set; }
		public double Omzet { get; set; }
		public double Pembayaran { get; set; }
		public double Berjalan => Omzet - Pembayaran;
		public double Piutang => SaldoAwal + Berjalan;
		public double UmurPiutang { get; set; }
	}
	public class ViewUmurPiutangIklan {
		public string NoInvoice { get; set; }
		public DateTime Tanggal { get; set; }
		public DateTime TanggalJatuhTempo { get; set; }
		public string Wilayah { get; set; }
		public string Regional { get; set; }
		public int RegionalId { get; set; }
		public string Pemasang { get; set; }
		public string Sales { get; set; }
		public string TipeInvoice { get; set; }
		public decimal Omzet { get; set; }
		public decimal Pembayaran { get; set; }
		public decimal Piutang => Omzet - Pembayaran;

		public string KelompokUmurPiutang { get; set; }
		public int UmurPiutang { get; set; }
	}

	[NonPersistent] public class ViewHutangKomisiCashbackRincian : XPLiteObject {
		public ViewHutangKomisiCashbackRincian(UnitOfWork uow) : base(uow) { }
		[Key] public ulong Id { get; set; }
		public string NoInvoice { get; set; }
		public string NoKwitansi { get; set; }
		public DateTime Tanggal { get; set; }
		public string Wilayah { get; set; }
		public string Regional { get; set; }
		public int RegionalId { get; set; }
		public string Pemasang { get; set; }
		public long SalesId { get; set; }
		public string Sales { get; set; }
		public string TipeInvoice { get; set; }
		public string KelompokOmzet { get; set; }
		public int KelompokOmzetId { get; set; }
		public decimal KomisiCashback { get; set; }
		public double Pembayaran { get; set; }
		public string JudulIklan { get; set; }

		[NonPersistent] public int Tahun => Tanggal.Year;
		[NonPersistent] public DateTime Bulan => new DateTime(Tanggal.Year, Tanggal.Month, 1);
		[NonPersistent] public int Semester => Tanggal.Month <= 6 ? 1 : 2;
		[NonPersistent] public int Triwulan => Tanggal.Month <= 3 ? 1 : Tanggal.Month <= 6 ? 2 : Tanggal.Month <= 9 ? 3 : 4;
		[NonPersistent] public int Minggu => Tanggal.Day <= 7 ? 1 : Tanggal.Day <= 14 ? 2 : Tanggal.Day <= 21 ? 3 : 4;
		[NonPersistent] public double Hutang => (double)KomisiCashback - Pembayaran;
	}
	public class ViewRekapHutangKomisiCashback {
		public string Wilayah { get; set; }
		public string Regional { get; set; }
		public int RegionalId { get; set; }
		public string PemasangSales { get; set; }
		public string Sales { get; set; }
		public string Pemasang { get; set; }
		public string TipeInvoice { get; set; }
		public string KelompokOmzet { get; set; }
		public int KelompokOmzetId { get; set; }
		public string NoInvoice { get; set; }
		public string NoKwitansi { get; set; }
		public DateTime Tanggal { get; set; }

		public double SaldoAwal { get; set; }
		public decimal KomisiCashback { get; set; }
		public double Pembayaran { get; set; }
		public double Berjalan => (double)KomisiCashback - Pembayaran;
		public double Hutang => SaldoAwal + Berjalan;
	}
}