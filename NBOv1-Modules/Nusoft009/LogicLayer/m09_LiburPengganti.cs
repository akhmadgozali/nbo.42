using DevExpress.Xpo;
using DevExpress.Xpo.Metadata;
using NuSoft.NPO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NuSoft.NUI.Win.Forms.Modules.NuSoft09.Persistent
{
	[Persistent("m09_liburpengganti")]public class LiburPengganti : NPOBase	{
		public LiburPengganti(UnitOfWork uow) : base(uow) { }
		public LiburPengganti(UnitOfWork uow, XPClassInfo classInfo) : base(uow, classInfo) { }

		private long _id;
		private Int16 _u_year;// SmallInt(6),
		private Int16 _u_month;// SmallInt(6),
		private Int16 _u_sequence;// SmallInt(6),
		private string _u_code;// VarChar(30) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL,
		private DateTime _d_date;// Date NOT NULL,
		private Karyawan _f_karyawan;//       Integer(11) NOT NULL,
		private DateTime _d_tanggalawal;// Date,
		private DateTime _d_tanggalakhir;//   Date,
		private string _d_keterangan;// VarChar(255) CHARACTER SET latin1 COLLATE latin1_swedish_ci,
		private int _d_jumlahhari;// SmallInt(6) DEFAULT 0,

		[Persistent("p_id"), Key()] public long Id { get => _id; set => SetPropertyValue(nameof(Id), ref _id, value); }
		[Persistent("u_year")] public Int16 Tahun { get => _u_year; set => SetPropertyValue(nameof(Tahun), ref _u_year, value); }
		[Persistent("u_month")] public Int16 Bulan { get => _u_month; set => SetPropertyValue(nameof(Bulan), ref _u_month, value); }
		[Persistent("u_sequence")] public Int16 Urutan { get => _u_sequence; set => SetPropertyValue(nameof(Urutan), ref _u_sequence, value); }
		[Persistent("u_code")] public String Kode { get => _u_code; set => SetPropertyValue(nameof(Kode), ref _u_code, value); }
		[Persistent("d_date")] public DateTime Tanggal { get => _d_date; set => SetPropertyValue(nameof(Tanggal), ref _d_date, value); }
		[Persistent("f_karyawan")] public Karyawan Karyawan { get => _f_karyawan; set => SetPropertyValue(nameof(Karyawan), ref _f_karyawan, value); }
		[Persistent("d_tanggalawal")] public DateTime TanggalAwal { get => _d_tanggalawal; set => SetPropertyValue(nameof(TanggalAwal), ref _d_tanggalawal, value); }
		[Persistent("d_tanggalakhir")] public DateTime TanggalAkhir { get => _d_tanggalakhir; set => SetPropertyValue(nameof(TanggalAkhir), ref _d_tanggalakhir, value); }
		[Persistent("d_keterangan")] public string Keterangan { get => _d_keterangan; set => SetPropertyValue(nameof(Keterangan), ref _d_keterangan, value); }
		[Persistent("d_jumlahhari")] public int JumlahHari { get => _d_jumlahhari; set => SetPropertyValue(nameof(JumlahHari), ref _d_jumlahhari, value); }

		[Association("fk_liburpengganti_detail"), Aggregated] public XPCollection<LiburPenggantiDetail> Detail => GetCollection<LiburPenggantiDetail>(nameof(Detail));
	}
	[Persistent("m09_liburpenggantidetail")] public class LiburPenggantiDetail : NPOBase	{
		public LiburPenggantiDetail(UnitOfWork uow) : base(uow) { }
		public LiburPenggantiDetail(UnitOfWork uow, XPClassInfo classInfo) : base(uow, classInfo) { }

		private long _id;
		private LiburPengganti _main;
		private DateTime _d_tanggal;
		private AbsensiTipe _f_absesitipe;
		private DateTime _d_tanggalpengganti;
		private Absensi _f_absensi;

		[Persistent("primary_main"), Key()] public long Id { get => _id; set => SetPropertyValue(nameof(Id), ref _id, value); }
		[Persistent("p_id"), Association("fk_liburpengganti_detail")] public LiburPengganti Main { get => _main; set => SetPropertyValue(nameof(Main), ref _main, value); }
		[Persistent("d_tanggal")] public DateTime Tanggal { get => _d_tanggal; set => SetPropertyValue(nameof(Tanggal), ref _d_tanggal, value); }
		[Persistent("f_absesitipe")] public AbsensiTipe StatusAbsensi { get => _f_absesitipe; set => SetPropertyValue(nameof(StatusAbsensi), ref _f_absesitipe, value); }
		[Persistent("d_tanggalpengganti")] public DateTime TanggalPengganti { get => _d_tanggalpengganti; set => SetPropertyValue(nameof(TanggalPengganti), ref _d_tanggalpengganti, value); }
		[Persistent("f_absensi")] public Absensi Absensi { get => _f_absensi; set => SetPropertyValue(nameof(Absensi), ref _f_absensi, value); }
	}
}
