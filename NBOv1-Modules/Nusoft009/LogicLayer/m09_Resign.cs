using DevExpress.Xpo;
using DevExpress.Xpo.Metadata;
using NuSoft.NPO;
using NuSoft.Utils.CustomAttribute;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NuSoft.NUI.Win.Forms.Modules.NuSoft09.Persistent
{
	public enum eJenisResign
	{
		[EnumDescription("PHK")] PHK = 0,
		[EnumDescription("Habis Kontrak")] HabisKontrak = 1,
		[EnumDescription("Resign")] Resign = 2,
		[EnumDescription("Meninggal")] Meninggal = 3
	}
	[Persistent("m09_resign")]	public class Resign : NPOBase	{
		public Resign(UnitOfWork uow) : base(uow) { }
		public Resign(UnitOfWork uow, XPClassInfo classInfo) : base(uow, classInfo) { }

		private long _id;
		private Int16 _u_year;// SmallInt(6),
		private Int16 _u_month;// SmallInt(6),
		private Int16 _u_sequence;// SmallInt(6),
		private string _u_code;// VarChar(30) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL,
		private DateTime _d_date;// Date NOT NULL,
		private Karyawan _f_karyawan;//       Integer(11) NOT NULL,
		private eJenisResign _d_tipe;
		private string _d_keterangan;// VarChar(255) CHARACTER SET latin1 COLLATE latin1_swedish_ci,

		[Persistent("p_id"), Key()] public long Id { get => _id; set => SetPropertyValue(nameof(Id), ref _id, value); }
		[Persistent("u_year")] public Int16 Tahun { get => _u_year; set => SetPropertyValue(nameof(Tahun), ref _u_year, value); }
		[Persistent("u_month")] public Int16 Bulan { get => _u_month; set => SetPropertyValue(nameof(Bulan), ref _u_month, value); }
		[Persistent("u_sequence")] public Int16 Urutan { get => _u_sequence; set => SetPropertyValue(nameof(Urutan), ref _u_sequence, value); }
		[Persistent("u_code")] public String Kode { get => _u_code; set => SetPropertyValue(nameof(Kode), ref _u_code, value); }
		[Persistent("d_date")] public DateTime Tanggal { get => _d_date; set => SetPropertyValue(nameof(Tanggal), ref _d_date, value); }
		[Persistent("f_karyawan")] public Karyawan Karyawan { get => _f_karyawan; set => SetPropertyValue(nameof(Karyawan), ref _f_karyawan, value); }
		[Persistent("d_tipe")] public eJenisResign Jenis { get => _d_tipe; set => SetPropertyValue(nameof(Jenis), ref _d_tipe, value); }
		[Persistent("d_catatan")] public string Keterangan { get => _d_keterangan; set => SetPropertyValue(nameof(Keterangan), ref _d_keterangan, value); }
	}
}
