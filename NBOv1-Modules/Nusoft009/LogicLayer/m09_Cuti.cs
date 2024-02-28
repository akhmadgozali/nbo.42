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
	public enum eJenisCuti	{
		CutiReguler = 0,
		CutiBesar = 1
	}
	public enum eStatusCuti	{
		Draft = 0,
		Approve = 1,
		Realisasi = 2
	}
	[Persistent("m09_mastercuti")]	public class MasterCuti : NPOBase	{
		public MasterCuti(UnitOfWork uow) : base(uow) { }
		public MasterCuti(UnitOfWork uow, XPClassInfo classInfo) : base(uow, classInfo) { }

		private long _id;
		private Int16 _u_tahun;// SmallInt(6) NOT NULL,
    private eJenisCuti _u_tipe;//           SmallInt(6) NOT NULL DEFAULT 0,
		private Karyawan _f_karyawan;// Integer(11) NOT NULL,
		private int _d_jumlah;//         SmallInt(6) DEFAULT 0,
		private bool _d_aktif;// SmallInt(6) DEFAULT 0,
		private DateTime _d_tanggalexpired;// Date,

		[Persistent("p_id"), Key()] public long Id { get => _id; set => SetPropertyValue(nameof(Id), ref _id, value); }
		[Persistent("u_tahun")] public Int16 Tahun { get => _u_tahun; set => SetPropertyValue(nameof(Tahun), ref _u_tahun, value); }
		[Persistent("u_tipe")] public eJenisCuti Tipe { get => _u_tipe; set => SetPropertyValue(nameof(Tipe), ref _u_tipe, value); }
		[Persistent("f_karyawan"), Association("fk_karyawan_mastercuti")] public Karyawan Karyawan { get => _f_karyawan; set => SetPropertyValue(nameof(Karyawan), ref _f_karyawan, value); }
		[Persistent("d_jumlah")] public int Jumlah { get => _d_jumlah; set => SetPropertyValue(nameof(Jumlah), ref _d_jumlah, value); }
		[Persistent("d_aktif")] public bool Aktif { get => _d_aktif; set => SetPropertyValue(nameof(Aktif), ref _d_aktif, value); }
		[Persistent("d_tanggalexpired")] public DateTime Expired { get => _d_tanggalexpired; set => SetPropertyValue(nameof(Expired), ref _d_tanggalexpired, value); }

		[Association("fk_m09_mastercuti_realisasi"), Aggregated] public XPCollection<RealisasiCutiDetail> Realisasi => GetCollection<RealisasiCutiDetail>(nameof(Realisasi));

		[NonPersistent] public int JumlahRealisasi => Realisasi.Count;
		[NonPersistent] public int SisaSaldo => Jumlah-JumlahRealisasi;
	}

	[Persistent("m09_pengajuancuti")] public class PengajuanCuti : NPOBase	{
		public PengajuanCuti(UnitOfWork uow) : base(uow) { }
		public PengajuanCuti(UnitOfWork uow, XPClassInfo classInfo) : base(uow, classInfo) { }

		private long _id;
		private Int16 _u_year;// SmallInt(6),
		private Int16 _u_month;// SmallInt(6),
		private Int16 _u_sequence;// SmallInt(6),
		private string _u_code;// VarChar(30) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL,
		private DateTime _d_date;// Date NOT NULL,
		private Karyawan _f_karyawan;//       Integer(11) NOT NULL,
		private DateTime _d_tanggalawal;//  Date,
		private DateTime _d_tanggalakhir;//   Date,
		private string _d_keterangan;//  VarChar(250) CHARACTER SET latin1 COLLATE latin1_swedish_ci,
		private eJenisCuti _d_jenis;//  SmallInt(6) DEFAULT 0,
		private int _d_jumlahhari;//  SmallInt(6) DEFAULT 0,
		private bool _d_cutidadakan;//  SmallInt(6) DEFAULT 0,
		private eStatusCuti _d_status;//  SmallInt(6) DEFAULT 0,
		private string _d_keteranganapp;//  VarChar(250) CHARACTER SET latin1 COLLATE latin1_swedish_ci,
		private MasterCuti _f_mastercuti;//  Integer(10) UNSIGNED,

		[Persistent("p_id"), Key()] public long Id { get => _id; set => SetPropertyValue(nameof(Id), ref _id, value); }
		[Persistent("u_year")] public Int16 Tahun { get => _u_year; set => SetPropertyValue(nameof(Tahun), ref _u_year, value); }
		[Persistent("u_month")] public Int16 Bulan { get => _u_month; set => SetPropertyValue(nameof(Bulan), ref _u_month, value); }
		[Persistent("u_sequence")] public Int16 Urutan { get => _u_sequence; set => SetPropertyValue(nameof(Urutan), ref _u_sequence, value); }
		[Persistent("u_code")] public String Kode { get => _u_code; set => SetPropertyValue(nameof(Kode), ref _u_code, value); }
		[Persistent("d_date")] public DateTime Tanggal { get => _d_date; set => SetPropertyValue(nameof(Tanggal), ref _d_date, value); }
		[Persistent("f_karyawan")] public Karyawan Karyawan { get => _f_karyawan; set => SetPropertyValue(nameof(Karyawan), ref _f_karyawan, value); }
		[Persistent("d_tanggalawal")] public DateTime TanggalAwal { get => _d_tanggalawal; set => SetPropertyValue(nameof(TanggalAwal), ref _d_tanggalawal, value); }
		[Persistent("d_tanggalakhir")] public DateTime TanggalAkhir { get => _d_tanggalakhir; set => SetPropertyValue(nameof(TanggalAkhir), ref _d_tanggalakhir, value); }
		[Persistent("d_keterangan")] public String Keterangan { get => _d_keterangan; set => SetPropertyValue(nameof(Keterangan), ref _d_keterangan, value); }
		[Persistent("d_jenis")] public eJenisCuti Jenis { get => _d_jenis; set => SetPropertyValue(nameof(Jenis), ref _d_jenis, value); }
		[Persistent("d_jumlahhari")] public int JumlahHari { get => _d_jumlahhari; set => SetPropertyValue(nameof(JumlahHari), ref _d_jumlahhari, value); }
		[Persistent("d_cutidadakan")] public bool CutiDadakan { get => _d_cutidadakan; set => SetPropertyValue(nameof(CutiDadakan), ref _d_cutidadakan, value); }
		[Persistent("d_status")] public eStatusCuti Status { get => _d_status; set => SetPropertyValue(nameof(Status), ref _d_status, value); }
		[Persistent("d_keteranganapp")] public String KeteranganApprove { get => _d_keteranganapp; set => SetPropertyValue(nameof(KeteranganApprove), ref _d_keteranganapp, value); }
		[Persistent("f_mastercuti")] public MasterCuti MasterCuti { get => _f_mastercuti; set => SetPropertyValue(nameof(MasterCuti), ref _f_mastercuti, value); }

		[Association("fk_pengajuancuti_detail"), Aggregated] public XPCollection<PengajuanCutiDetail> Detail => GetCollection<PengajuanCutiDetail>(nameof(Detail));

	}
	[Persistent("m09_pengajuancutidetail")] public class PengajuanCutiDetail : NPOBase	{
		public PengajuanCutiDetail(UnitOfWork uow) : base(uow) { }
		public PengajuanCutiDetail(UnitOfWork uow, XPClassInfo classInfo) : base(uow, classInfo) { }

		private long _id;
		private PengajuanCuti _main;
		private DateTime _d_tanggal;
		private Absensi _f_absensi;
		private AbsensiTipe _f_absesitipe;
		private MasterCuti _f_mastercuti;//  Integer(10) UNSIGNED,

		[Persistent("primary_main"), Key()] public long Id { get => _id; set => SetPropertyValue(nameof(Id), ref _id, value); }
		[Persistent("p_id"), Association("fk_pengajuancuti_detail")] public PengajuanCuti Main { get => _main; set => SetPropertyValue(nameof(Main), ref _main, value); }
		[Persistent("d_tanggal")] public DateTime Tanggal { get => _d_tanggal; set => SetPropertyValue(nameof(Tanggal), ref _d_tanggal, value); }
		[Persistent("f_absensi")] public Absensi Absensi { get => _f_absensi; set => SetPropertyValue(nameof(Absensi), ref _f_absensi, value); }
		[Persistent("f_statusabsen")] public AbsensiTipe StatusAbsensi { get => _f_absesitipe; set => SetPropertyValue(nameof(StatusAbsensi), ref _f_absesitipe, value); }
		[Persistent("f_mastercuti")] public MasterCuti MasterCuti { get => _f_mastercuti; set => SetPropertyValue(nameof(MasterCuti), ref _f_mastercuti, value); }
	}


	[Persistent("m09_realisasicuti")] public class RealisasiCuti : NPOBase {
		public RealisasiCuti(UnitOfWork uow) : base(uow) { }
		public RealisasiCuti(UnitOfWork uow, XPClassInfo classInfo) : base(uow, classInfo) { }

		private long _id;
		private Int16 _u_year;// SmallInt(6),
		private Int16 _u_month;// SmallInt(6),
		private Int16 _u_sequence;// SmallInt(6),
		private string _u_code;// VarChar(30) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL,
		private DateTime _d_date;// Date NOT NULL,
		private Karyawan _f_karyawan;//       Integer(11) NOT NULL,
		private MasterIjin _d_jenis;//          SmallInt(6) NOT NULL,
		private bool _d_cutimendadak;//   SmallInt(6) DEFAULT 0,
		private MasterCuti _f_cutimaster;// Integer(10) UNSIGNED,
		private bool _d_cutibesar;// SmallInt(6) DEFAULT 0,
		private bool _d_cutikompensasi;// SmallInt(6) DEFAULT 0,
		private PengajuanCuti _f_cutipengajuan;// Integer(11),
		private DateTime _d_tanggalawal;// Date,
		private DateTime _d_tanggalakhir;//   Date,
		private string _d_keterangan;// VarChar(255) CHARACTER SET latin1 COLLATE latin1_swedish_ci,
		private TimeSpan _d_jamawal;// Time,
		private TimeSpan _d_jamakhir;//       Time,
		private int _d_jumlahhari;// SmallInt(6) DEFAULT 0,
		private bool _d_reimbusmakan;// SmallInt(6) DEFAULT 0,

		[Persistent("p_id"), Key()] public long Id { get => _id; set => SetPropertyValue(nameof(Id), ref _id, value); }
		[Persistent("u_year")] public Int16 Tahun { get => _u_year; set => SetPropertyValue(nameof(Tahun), ref _u_year, value); }
		[Persistent("u_month")] public Int16 Bulan { get => _u_month; set => SetPropertyValue(nameof(Bulan), ref _u_month, value); }
		[Persistent("u_sequence")] public Int16 Urutan { get => _u_sequence; set => SetPropertyValue(nameof(Urutan), ref _u_sequence, value); }
		[Persistent("u_code")] public String Kode { get => _u_code; set => SetPropertyValue(nameof(Kode), ref _u_code, value); }
		[Persistent("d_date")] public DateTime Tanggal { get => _d_date; set => SetPropertyValue(nameof(Tanggal), ref _d_date, value); }
		[Persistent("f_karyawan")] public Karyawan Karyawan { get => _f_karyawan; set => SetPropertyValue(nameof(Karyawan), ref _f_karyawan, value); }
		[Persistent("d_jenis")] public MasterIjin Jenis { get => _d_jenis; set => SetPropertyValue(nameof(Jenis), ref _d_jenis, value); }
		[Persistent("d_cutimendadak")] public bool CutiMendadak { get => _d_cutimendadak; set => SetPropertyValue(nameof(CutiMendadak), ref _d_cutimendadak, value); }
		[Persistent("f_cutimaster")] public MasterCuti CutiMaster { get => _f_cutimaster; set => SetPropertyValue(nameof(CutiMaster), ref _f_cutimaster, value); }
		[Persistent("d_cutibesar")] public bool CutiBesar { get => _d_cutibesar; set => SetPropertyValue(nameof(CutiBesar), ref _d_cutibesar, value); }
		[Persistent("d_cutikompensasi")] public bool CutiKompensasi { get => _d_cutikompensasi; set => SetPropertyValue(nameof(CutiKompensasi), ref _d_cutikompensasi, value); }
		[Persistent("f_cutipengajuan")] public PengajuanCuti CutiPengajuan { get => _f_cutipengajuan; set => SetPropertyValue(nameof(CutiPengajuan), ref _f_cutipengajuan, value); }
		[Persistent("d_tanggalawal")] public DateTime TanggalAwal { get => _d_tanggalawal; set => SetPropertyValue(nameof(TanggalAwal), ref _d_tanggalawal, value); }
		[Persistent("d_tanggalakhir")] public DateTime TanggalAkhir { get => _d_tanggalakhir; set => SetPropertyValue(nameof(TanggalAkhir), ref _d_tanggalakhir, value); }
		[Persistent("d_keterangan")] public string Keterangan { get => _d_keterangan; set => SetPropertyValue(nameof(Keterangan), ref _d_keterangan, value); }
		[Persistent("d_jamawal")] public TimeSpan JamAwal { get => _d_jamawal; set => SetPropertyValue(nameof(JamAwal), ref _d_jamawal, value); }
		[Persistent("d_jamakhir")] public TimeSpan JamAkhir { get => _d_jamakhir; set => SetPropertyValue(nameof(JamAkhir), ref _d_jamakhir, value); }
		[Persistent("d_jumlahhari")] public int JumlahHari { get => _d_jumlahhari; set => SetPropertyValue(nameof(JumlahHari), ref _d_jumlahhari, value); }
		[Persistent("d_reimbusmakan")] public bool ReimbusMakan { get => _d_reimbusmakan; set => SetPropertyValue(nameof(ReimbusMakan), ref _d_reimbusmakan, value); }

		[Association("fk_realisasicuti_detail"), Aggregated] public XPCollection<RealisasiCutiDetail> Detail => GetCollection<RealisasiCutiDetail>(nameof(Detail));
	}
	[Persistent("m09_realisasicutidetail")] public class RealisasiCutiDetail : NPOBase	{
		public RealisasiCutiDetail(UnitOfWork uow) : base(uow) { }
		public RealisasiCutiDetail(UnitOfWork uow, XPClassInfo classInfo) : base(uow, classInfo) { }

		private long _id;
		private Ijin _main;
		private DateTime _d_tanggal;
		private AbsensiTipe _f_absesitipe;
		private MasterCuti _f_cutimaster;

		[Persistent("primary_main"), Key()] public long Id { get => _id; set => SetPropertyValue(nameof(Id), ref _id, value); }
		[Persistent("p_id"), Association("fk_ijin_detail")] public Ijin Main { get => _main; set => SetPropertyValue(nameof(Main), ref _main, value); }
		[Persistent("d_tanggal")] public DateTime Tanggal { get => _d_tanggal; set => SetPropertyValue(nameof(Tanggal), ref _d_tanggal, value); }
		[Persistent("f_absesitipe")] public AbsensiTipe StatusAbsensi { get => _f_absesitipe; set => SetPropertyValue(nameof(StatusAbsensi), ref _f_absesitipe, value); }
		[Persistent("f_cutimaster"), Association("fk_m09_mastercuti_realisasi")] public MasterCuti MasterCuti { get => _f_cutimaster; set => SetPropertyValue(nameof(MasterCuti), ref _f_cutimaster, value); }
	}
}
