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
	public enum eJenisKaryawan {
		Operator_Pabrik = 0,
		QC = 1,
		Warehouse=2
	}
	public enum eStatusLembur
	{
		Draft = 0,
		App1 = 1,
		App2 = 2,
		Ready = 3,
		Realisasi = 4
	}
	[Persistent("m09_karyawanlembur")] public class KaryawanLembur : NPOBase {
		public KaryawanLembur(UnitOfWork uow) : base(uow) { }
		public KaryawanLembur(UnitOfWork uow, XPClassInfo classInfo) : base(uow, classInfo) { }

		private long _id;
		private Karyawan _f_karyawan;// Integer(11),
		private Golongan _f_golongan;// SmallInt(6),
		private Divisi _f_divisi;// SmallInt(6),
		private SPKLDetail _f_pengajuanlembur;// Integer(10) UNSIGNED,
		private DateTime _d_tanggal;// Date,
		private Absensi _f_absensi;//           Integer(10) UNSIGNED,
		private TimeSpan _d_jammulai;// Time,
		private TimeSpan _d_jamselesai;//        Time,
		private String _d_catatan;// VarChar(250) CHARACTER SET latin1 COLLATE latin1_swedish_ci,
		private Double _d_gajipokok;// Double DEFAULT 0,
		private Double _d_nilai;// Double DEFAULT 0,
		private Double _d_nilailembur;// Double DEFAULT 0,
		private Double _d_jumlahjam;// Double DEFAULT 0,
		private Double _d_jumlahistirahat;// Double DEFAULT 0,
		private Double _d_lembur1;// Double DEFAULT 0,
		private Double _d_lembur2;// Double DEFAULT 0,
		private Double _d_lembur3;// Double DEFAULT 0,
		private Double _d_lembur4;// Double DEFAULT 0,
		private eJenisKaryawan _d_jenis;// SmallInt(6) DEFAULT 0,
		private bool _d_overlembur;// SmallInt(6) DEFAULT 0,
		private Double _d_nilai7a;// Double DEFAULT 0,
		private bool _d_tunjanganshift;// Double DEFAULT 0,
		private bool _d_transport;// SmallInt(6) DEFAULT 0,
		private bool _d_tunjanganshift2;// SmallInt(6) DEFAULT 0,
		private bool _d_tunjanganshift3;// SmallInt(6) DEFAULT 0,
		private Double _d_nilailemburmanual;// Double DEFAULT 0,
		private bool _d_jagamesin;// SmallInt(6) DEFAULT 0,

		[Persistent("p_id"), Key()] public long Id { get => _id; set => SetPropertyValue(nameof(Id), ref _id, value); }
		[Persistent("f_karyawan")] public Karyawan Karyawan { get => _f_karyawan; set => SetPropertyValue(nameof(Karyawan), ref _f_karyawan, value); }
		[Persistent("f_golongan")] public Golongan Golongan { get => _f_golongan; set => SetPropertyValue(nameof(Golongan), ref _f_golongan, value); }
		[Persistent("f_divisi")] public Divisi Divisi { get => _f_divisi; set => SetPropertyValue(nameof(Divisi), ref _f_divisi, value); }
		[Persistent("f_pengajuanlembur")] public SPKLDetail SPKLDetail { get => _f_pengajuanlembur; set => SetPropertyValue(nameof(SPKLDetail), ref _f_pengajuanlembur, value); }
		[Persistent("d_tanggal")] public DateTime Tanggal { get => _d_tanggal; set => SetPropertyValue(nameof(Tanggal), ref _d_tanggal, value); }
		[Persistent("f_absensi")] public Absensi Absensi { get => _f_absensi; set => SetPropertyValue(nameof(Absensi), ref _f_absensi, value); }
		[Persistent("d_jammulai")] public TimeSpan JamMulai { get => _d_jammulai; set => SetPropertyValue(nameof(JamMulai), ref _d_jammulai, value); }
		[Persistent("d_jamselesai")] public TimeSpan JamSelesai { get => _d_jamselesai; set => SetPropertyValue(nameof(JamSelesai), ref _d_jamselesai, value); }
		[Persistent("d_catatan")] public String Catatan { get => _d_catatan; set => SetPropertyValue(nameof(Catatan), ref _d_catatan, value); }
		[Persistent("d_gajipokok")] public Double GajiPokok { get => _d_gajipokok; set => SetPropertyValue(nameof(GajiPokok), ref _d_gajipokok, value); }
		[Persistent("d_nilai")] public Double Nilai { get => _d_nilai; set => SetPropertyValue(nameof(Nilai), ref _d_nilai, value); }
		[Persistent("d_nilailembur")] public Double NilaiLembur { get => _d_nilailembur; set => SetPropertyValue(nameof(NilaiLembur), ref _d_nilailembur, value); }
		[Persistent("d_nilai7a")] public Double NilaiLembur7A { get => _d_nilai7a; set => SetPropertyValue(nameof(NilaiLembur7A), ref _d_nilai7a, value); }
		[Persistent("d_nilailemburmanual")] public Double NilaiLemburManual { get => _d_nilailemburmanual; set => SetPropertyValue(nameof(NilaiLemburManual), ref _d_nilailemburmanual, value); }
		[Persistent("d_jumlahjam")] public Double JumlahJam { get => _d_jumlahjam; set => SetPropertyValue(nameof(JumlahJam), ref _d_jumlahjam, value); }
		[Persistent("d_jumlahistirahat")] public Double JumlahIstirahat { get => _d_jumlahistirahat; set => SetPropertyValue(nameof(JumlahIstirahat), ref _d_jumlahistirahat, value); }
		[Persistent("d_lembur1")] public Double Lembur1 { get => _d_lembur1; set => SetPropertyValue(nameof(Lembur1), ref _d_lembur1, value); }
		[Persistent("d_lembur2")] public Double Lembur2 { get => _d_lembur2; set => SetPropertyValue(nameof(Lembur2), ref _d_lembur2, value); }
		[Persistent("d_lembur3")] public Double Lembur3 { get => _d_lembur3; set => SetPropertyValue(nameof(Lembur3), ref _d_lembur3, value); }
		[Persistent("d_lembur4")] public Double Lembur4 { get => _d_lembur4; set => SetPropertyValue(nameof(Lembur4), ref _d_lembur4, value); }
		[Persistent("d_jenis")] public eJenisKaryawan Jenis { get => _d_jenis; set => SetPropertyValue(nameof(Jenis), ref _d_jenis, value); }
		[Persistent("d_overlembur")] public bool OverLembur { get => _d_overlembur; set => SetPropertyValue(nameof(OverLembur), ref _d_overlembur, value); }
		[Persistent("d_tunjanganshift")] public bool TunjanganShift { get => _d_tunjanganshift; set => SetPropertyValue(nameof(TunjanganShift), ref _d_tunjanganshift, value); }
		[Persistent("d_transport")] public bool TunjanganTransport { get => _d_transport; set => SetPropertyValue(nameof(TunjanganTransport), ref _d_transport, value); }
		[Persistent("d_tunjanganshift2")] public bool TunjanganShift2 { get => _d_tunjanganshift2; set => SetPropertyValue(nameof(TunjanganShift2), ref _d_tunjanganshift2, value); }
		[Persistent("d_tunjanganshift3")] public bool TunjanganShift3 { get => _d_tunjanganshift3; set => SetPropertyValue(nameof(TunjanganShift3), ref _d_tunjanganshift3, value); }
		[Persistent("d_jagamesin")] public bool JagaMesin { get => _d_jagamesin; set => SetPropertyValue(nameof(JagaMesin), ref _d_jagamesin, value); }
	}
	[Persistent("m09_pengajuanlembur")]public class SPKL : NPOBase	{
		public SPKL(UnitOfWork uow) : base(uow) { }
		public SPKL(UnitOfWork uow, XPClassInfo classInfo) : base(uow, classInfo) { }

		private long _id;
		private Int16 _u_year;// SmallInt(6),
		private Int16 _u_month;// SmallInt(6),
		private Int16 _u_sequence;// SmallInt(6),
		private string _u_code;// VarChar(30) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL,
		private DateTime _d_date;// Date NOT NULL,
		private Divisi _f_divisi;//        SmallInt(6),
		private DateTime _d_tanggallembur;// Date,
		private string _d_keterangan;//    VarChar(250) CHARACTER SET latin1 COLLATE latin1_swedish_ci,
		private DateTime _d_tanggalapp1;// Date,
		private DateTime _d_tanggalapp2;//   Date,
		private eStatusLembur _d_status;// SmallInt(6) DEFAULT 0,

		[Persistent("p_id"), Key()] public long Id { get => _id; set => SetPropertyValue(nameof(Id), ref _id, value); }
		[Persistent("u_year")] public Int16 Tahun { get => _u_year; set => SetPropertyValue(nameof(Tahun), ref _u_year, value); }
		[Persistent("u_month")] public Int16 Bulan { get => _u_month; set => SetPropertyValue(nameof(Bulan), ref _u_month, value); }
		[Persistent("u_sequence")] public Int16 Urutan { get => _u_sequence; set => SetPropertyValue(nameof(Urutan), ref _u_sequence, value); }
		[Persistent("u_code")] public String Kode { get => _u_code; set => SetPropertyValue(nameof(Kode), ref _u_code, value); }
		[Persistent("d_date")] public DateTime Tanggal { get => _d_date; set => SetPropertyValue(nameof(Tanggal), ref _d_date, value); }
		[Persistent("f_divisi")] public Divisi Divisi { get => _f_divisi; set => SetPropertyValue(nameof(Divisi), ref _f_divisi, value); }
		[Persistent("d_tanggallembur")] public DateTime TanggalLembur { get => _d_tanggallembur; set => SetPropertyValue(nameof(TanggalLembur), ref _d_tanggallembur, value); }
		[Persistent("d_keterangan")] public string Keterangan { get => _d_keterangan; set => SetPropertyValue(nameof(Keterangan), ref _d_keterangan, value); }
		[Persistent("d_tanggalapp1")] public DateTime TanggalApp1 { get => _d_tanggalapp1; set => SetPropertyValue(nameof(TanggalApp1), ref _d_tanggalapp1, value); }
		[Persistent("d_tanggalapp2")] public DateTime TanggalApp2 { get => _d_tanggalapp2; set => SetPropertyValue(nameof(TanggalApp2), ref _d_tanggalapp2, value); }
		[Persistent("d_status")] public eStatusLembur Status { get => _d_status; set => SetPropertyValue(nameof(Status), ref _d_status, value); }

		[Association("fk_pengajuanlembur_detail"), Aggregated] public XPCollection<SPKLDetail> Detail => GetCollection<SPKLDetail>(nameof(Detail));
	}
	[Persistent("m09_pengajuanlembur_detail")] public class SPKLDetail : NPOBase {
		public SPKLDetail(UnitOfWork uow) : base(uow) { }
		public SPKLDetail(UnitOfWork uow, XPClassInfo classInfo) : base(uow, classInfo) { }

		private long _id;
		private SPKL _main;//
		private Karyawan _f_karyawan;// Integer(11) NOT NULL,
		private TimeSpan _d_jamawal;//           Time,
		private TimeSpan _d_jamakhir;// Time,
		private string _d_pekerjaan;//         VarChar(250) CHARACTER SET latin1 COLLATE latin1_swedish_ci,
		private bool _d_bersedia;// SmallInt(6) DEFAULT 0,
		private Karyawan _d_karyawanrealisasi;// Integer(11),
		private TimeSpan _d_jamawalrealisasi;// Time,
		private TimeSpan _d_jamakhirrealisasi;// Time,
		private string _d_keterangan;// VarChar(250) CHARACTER SET latin1 COLLATE latin1_swedish_ci,
		private eStatusLembur _d_status;// SmallInt(6) DEFAULT 0,
		private bool _d_tukarcuti;// SmallInt(6) DEFAULT 0,
		private bool _d_lemburwajib;// SmallInt(6) DEFAULT 0,
		private bool _d_liburpengganti;// SmallInt(6) DEFAULT 0,
		private bool _d_uangmakan;// SmallInt(6) DEFAULT 0,
		private bool _d_shift2;// SmallInt(6) DEFAULT 0,
		private bool _d_shift3;// SmallInt(6) DEFAULT 0,
		private bool _d_potongan;// Integer(11) DEFAULT 0,
		private bool _d_jagamesin;// SmallInt(6) DEFAULT 0,
		private Absensi _f_absensi;// Integer(10) UNSIGNED NOT NULL,

		[Persistent("primary_main"), Key()] public long Id { get => _id; set => SetPropertyValue(nameof(Id), ref _id, value); }
		[Persistent("p_id"), Association("fk_pengajuanlembur_detail")] public SPKL Main { get => _main; set => SetPropertyValue(nameof(Main), ref _main, value); }
		[Persistent("f_karyawan")] public Karyawan Karyawan { get => _f_karyawan; set => SetPropertyValue(nameof(Karyawan), ref _f_karyawan, value); }
		[Persistent("d_jamawal")] public TimeSpan JamAwal { get => _d_jamawal; set => SetPropertyValue(nameof(JamAwal), ref _d_jamawal, value); }
		[Persistent("d_jamakhir")] public TimeSpan JamAkhir { get => _d_jamakhir; set => SetPropertyValue(nameof(JamAkhir), ref _d_jamakhir, value); }
		[Persistent("d_pekerjaan")] public string Pekerjaan { get => _d_pekerjaan; set => SetPropertyValue(nameof(Pekerjaan), ref _d_pekerjaan, value); }
		[Persistent("d_bersedia")] public bool Bersedia { get => _d_bersedia; set => SetPropertyValue(nameof(Bersedia), ref _d_bersedia, value); }
		[Persistent("d_karyawanrealisasi")] public Karyawan KaryawanRealisasi { get => _d_karyawanrealisasi; set => SetPropertyValue(nameof(KaryawanRealisasi), ref _d_karyawanrealisasi, value); }
		[Persistent("d_jamawalrealisasi")] public TimeSpan JamRealisasiAwal { get => _d_jamawalrealisasi; set => SetPropertyValue(nameof(JamRealisasiAwal), ref _d_jamawalrealisasi, value); }
		[Persistent("d_jamakhirrealisasi")] public TimeSpan JamRealisasiAkhir { get => _d_jamakhirrealisasi; set => SetPropertyValue(nameof(JamRealisasiAkhir), ref _d_jamakhirrealisasi, value); }
		[Persistent("d_keterangan")] public string Keterangan { get => _d_keterangan; set => SetPropertyValue(nameof(Keterangan), ref _d_keterangan, value); }
		[Persistent("d_status")] public eStatusLembur Status { get => _d_status; set => SetPropertyValue(nameof(Status), ref _d_status, value); }
		[Persistent("d_tukarcuti")] public bool TukarCuti { get => _d_tukarcuti; set => SetPropertyValue(nameof(TukarCuti), ref _d_tukarcuti, value); }
		[Persistent("d_lemburwajib")] public bool LemburWajib { get => _d_lemburwajib; set => SetPropertyValue(nameof(LemburWajib), ref _d_lemburwajib, value); }
		[Persistent("d_liburpengganti")] public bool LiburPengganti { get => _d_liburpengganti; set => SetPropertyValue(nameof(LiburPengganti), ref _d_liburpengganti, value); }
		[Persistent("d_uangmakan")] public bool UangMakan { get => _d_uangmakan; set => SetPropertyValue(nameof(UangMakan), ref _d_uangmakan, value); }
		[Persistent("d_shift2")] public bool Shift2 { get => _d_shift2; set => SetPropertyValue(nameof(Shift2), ref _d_shift2, value); }
		[Persistent("d_shift3")] public bool Shift3 { get => _d_shift3; set => SetPropertyValue(nameof(Shift3), ref _d_shift3, value); }
		[Persistent("d_potongan")] public bool Potongan { get => _d_potongan; set => SetPropertyValue(nameof(Potongan), ref _d_potongan, value); }
		[Persistent("d_jagamesin")] public bool JagaMesin { get => _d_jagamesin; set => SetPropertyValue(nameof(JagaMesin), ref _d_jagamesin, value); }
		[Persistent("f_absensi")] public Absensi Absensi { get => _f_absensi; set => SetPropertyValue(nameof(Absensi), ref _f_absensi, value); }
	}
}
