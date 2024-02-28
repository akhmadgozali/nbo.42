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
	public enum eJenisPinjaman
	{
		Koperasi = 0,
		Kantor = 1
	}
	public enum eStatusPinjaman
	{
		Draft = 0,
		Approve = 1
	}
	[Persistent("m09_pinjaman")] public class Pinjaman : NPOBase	{
		public Pinjaman(UnitOfWork uow) : base(uow) { }
		public Pinjaman(UnitOfWork uow, XPClassInfo classInfo) : base(uow, classInfo) { }

		private long _id;
		private Int16 _u_year;// SmallInt(6),
		private Int16 _u_month;// SmallInt(6),
		private Int16 _u_sequence;// SmallInt(6),
		private string _u_code;// VarChar(30) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL,
		private DateTime _d_date;// Date NOT NULL,
		private Karyawan _f_karyawan;//       Integer(11) NOT NULL,
		private eJenisPinjaman _d_jenis;//          SmallInt(6) NOT NULL,
		private double _d_nilai;// Date,
		private int _d_lama;//   Date,
		private eStatusPinjaman _d_status;// Time,
		private DateTime _d_tanggalpencairan;//       Time,
		private DateTime _d_tanggalapprove;// SmallInt(6) DEFAULT 0,
		private DateTime _d_tanggalpotonganawal;// SmallInt(6) DEFAULT 0,
		private string _d_keterangan;// VarChar(255) CHARACTER SET latin1 COLLATE latin1_swedish_ci,

		[Persistent("p_id"), Key()] public long Id { get => _id; set => SetPropertyValue(nameof(Id), ref _id, value); }
		[Persistent("u_year")] public Int16 Tahun { get => _u_year; set => SetPropertyValue(nameof(Tahun), ref _u_year, value); }
		[Persistent("u_month")] public Int16 Bulan { get => _u_month; set => SetPropertyValue(nameof(Bulan), ref _u_month, value); }
		[Persistent("u_sequence")] public Int16 Urutan { get => _u_sequence; set => SetPropertyValue(nameof(Urutan), ref _u_sequence, value); }
		[Persistent("u_code")] public String Kode { get => _u_code; set => SetPropertyValue(nameof(Kode), ref _u_code, value); }
		[Persistent("d_date")] public DateTime Tanggal { get => _d_date; set => SetPropertyValue(nameof(Tanggal), ref _d_date, value); }
		[Persistent("f_karyawan")] public Karyawan Karyawan { get => _f_karyawan; set => SetPropertyValue(nameof(Karyawan), ref _f_karyawan, value); }
		[Persistent("d_jenis")] public eJenisPinjaman Jenis { get => _d_jenis; set => SetPropertyValue(nameof(Jenis), ref _d_jenis, value); }
		[Persistent("d_nilai")] public double Nilai { get => _d_nilai; set => SetPropertyValue(nameof(Nilai), ref _d_nilai, value); }
		[Persistent("d_lama")] public int Lama { get => _d_lama; set => SetPropertyValue(nameof(Lama), ref _d_lama, value); }
		[Persistent("d_status")] public eStatusPinjaman Status { get => _d_status; set => SetPropertyValue(nameof(Status), ref _d_status, value); }
		[Persistent("d_tanggalpencairan")] public DateTime TanggalPencairan { get => _d_tanggalpencairan; set => SetPropertyValue(nameof(TanggalPencairan), ref _d_tanggalpencairan, value); }
		[Persistent("d_tanggalapprove")] public DateTime TanggalApprove { get => _d_tanggalapprove; set => SetPropertyValue(nameof(TanggalApprove), ref _d_tanggalapprove, value); }
		[Persistent("d_tanggalpotonganawal")] public DateTime TanggalPotongan { get => _d_tanggalpotonganawal; set => SetPropertyValue(nameof(TanggalPotongan), ref _d_tanggalpotonganawal, value); }
		[Persistent("d_keterangan")] public string Keterangan { get => _d_keterangan; set => SetPropertyValue(nameof(Keterangan), ref _d_keterangan, value); }

		[Association("fk_pinjaman_detail"), Aggregated] public XPCollection<PinjamanDetail> Detail => GetCollection<PinjamanDetail>(nameof(Detail));
	}
	[Persistent("m09_pinjaman_detail")]public class PinjamanDetail : NPOBase	{
		public PinjamanDetail(UnitOfWork uow) : base(uow) { }
		public PinjamanDetail(UnitOfWork uow, XPClassInfo classInfo) : base(uow, classInfo) { }

		private long _id;
		private Ijin _main;
		private DateTime _d_tanggal;
		private double _d_nilai;

		[Persistent("primary_main"), Key()] public long Id { get => _id; set => SetPropertyValue(nameof(Id), ref _id, value); }
		[Persistent("p_id"), Association("fk_pinjaman_detail")] public Ijin Main { get => _main; set => SetPropertyValue(nameof(Main), ref _main, value); }
		[Persistent("d_tanggal")] public DateTime Tanggal { get => _d_tanggal; set => SetPropertyValue(nameof(Tanggal), ref _d_tanggal, value); }
		[Persistent("d_nilai")] public double Nilai { get => _d_nilai; set => SetPropertyValue(nameof(Nilai), ref _d_nilai, value); }
	}


}
