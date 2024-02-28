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
	[Persistent("m09_absensi")]public class Absensi : NPOBase {
		public Absensi(UnitOfWork uow) : base(uow) { }
		public Absensi(UnitOfWork uow, XPClassInfo classInfo) : base(uow, classInfo) { }

		private long _id;
		private Karyawan _f_karyawan;//        Integer(11) NOT NULL,
		private DateTime _u_tanggal;//         Date NOT NULL,
		private TimeSpan _d_jammasuk;// Time,
		private TimeSpan _d_jampulang;//       Time,
		private AbsensiTipe _f_status;// SmallInt(6) DEFAULT 0,
		private string _d_catatan;// VarChar(255) CHARACTER SET latin1 COLLATE latin1_swedish_ci,
		private Divisi _f_divisi;// SmallInt(6),
		private Shift _f_shift;// SmallInt(5) UNSIGNED,
		private bool _d_hk;// SmallInt(6),
		private bool _d_lembur;// SmallInt(6),
		private bool _d_lemburpengganti;// SmallInt(6),
		private bool _d_liburnasional;// SmallInt(6),
		private bool _d_cutibesar;// SmallInt(6),
		private JadwalProduksi _f_jadwalproduksi;// Integer(11),
		private bool _d_lupaabsen;// SmallInt(6),
		private bool _d_reimbusmakan;// SmallInt(6),
		//private TimeSpan _d_jamkerjamasuk;// Time,
		//private TimeSpan _d_jamkerjapulang;//  Time,

		[Persistent("p_id"), Key()] public long Id { get => _id; set => SetPropertyValue(nameof(Id), ref _id, value); }
		[Persistent("f_karyawan")] public Karyawan Karyawan { get => _f_karyawan; set => SetPropertyValue(nameof(Karyawan), ref _f_karyawan, value); }
		[Persistent("u_tanggal")] public DateTime Tanggal { get => _u_tanggal; set => SetPropertyValue(nameof(Tanggal), ref _u_tanggal, value); }
		[Persistent("d_jammasuk")] public TimeSpan JamMasuk { get => _d_jammasuk; set => SetPropertyValue(nameof(JamMasuk), ref _d_jammasuk, value); }
		[Persistent("d_jampulang")] public TimeSpan JamPulang { get => _d_jampulang; set => SetPropertyValue(nameof(JamPulang), ref _d_jampulang, value); }
		[Persistent("f_status")] public AbsensiTipe Status { get => _f_status; set => SetPropertyValue(nameof(Status), ref _f_status, value); }
		[Persistent("d_catatan")] public string Catatan { get => _d_catatan; set => SetPropertyValue(nameof(Catatan), ref _d_catatan, value); }
		[Persistent("f_divisi")] public Divisi Divisi { get => _f_divisi; set => SetPropertyValue(nameof(Divisi), ref _f_divisi, value); }
		[Persistent("f_shift")] public Shift Shift { get => _f_shift; set => SetPropertyValue(nameof(Shift), ref _f_shift, value); }
		[Persistent("d_hk")] public bool HariKerja { get => _d_hk; set => SetPropertyValue(nameof(HariKerja), ref _d_hk, value); }
		[Persistent("d_lembur")] public bool Lembur { get => _d_lembur; set => SetPropertyValue(nameof(Lembur), ref _d_lembur, value); }
		[Persistent("d_lemburpengganti")] public bool LemburPengganti { get => _d_lemburpengganti; set => SetPropertyValue(nameof(LemburPengganti), ref _d_lemburpengganti, value); }
		[Persistent("d_liburnasional")] public bool LiburNasional { get => _d_liburnasional; set => SetPropertyValue(nameof(LiburNasional), ref _d_liburnasional, value); }
		[Persistent("d_cutibesar")] public bool CutiBesar { get => _d_cutibesar; set => SetPropertyValue(nameof(CutiBesar), ref _d_cutibesar, value); }
		[Persistent("f_jadwalproduksi")] public JadwalProduksi JadwalProduksi { get => _f_jadwalproduksi; set => SetPropertyValue(nameof(JadwalProduksi), ref _f_jadwalproduksi, value); }
		[Persistent("d_lupaabsen")] public bool LupaAbsen { get => _d_lupaabsen; set => SetPropertyValue(nameof(LupaAbsen), ref _d_lupaabsen, value); }
		[Persistent("d_reimbusmakan")] public bool ReimbusMakan { get => _d_reimbusmakan; set => SetPropertyValue(nameof(ReimbusMakan), ref _d_reimbusmakan, value); }
		//[Persistent("d_jamkerjamasuk")] public string Kode { get => _d_jamkerjamasuk; set => SetPropertyValue(nameof(Kode), ref _d_jamkerjamasuk, value); }
		//[Persistent("d_jamkerjapulang")] public string Kode { get => _d_jamkerjapulang; set => SetPropertyValue(nameof(Kode), ref _d_jamkerjapulang, value); }
	}
	[Persistent("m09_absensitipe")]	public class AbsensiTipe : NPOBase	{
		public AbsensiTipe(UnitOfWork uow) : base(uow) { }
		public AbsensiTipe(UnitOfWork uow, XPClassInfo classInfo) : base(uow, classInfo) { }

		private long _id;
		private string _kode;

		[Persistent("p_id"), Key()] public long Id { get => _id; set => SetPropertyValue(nameof(Id), ref _id, value); }
		[Persistent("u_kode")] public string Kode { get => _kode; set => SetPropertyValue(nameof(Kode), ref _kode, value); }
	}
	[Persistent("m09_absensitipe")]	public class AbsensiLupa : NPOBase {
		public AbsensiLupa(UnitOfWork uow) : base(uow) { }
		public AbsensiLupa(UnitOfWork uow, XPClassInfo classInfo) : base(uow, classInfo) { }

		private long _id;
		private Karyawan _f_karyawan;
		private DateTime _d_tanggal;
		private TimeSpan _d_jammasuk;
		private TimeSpan _d_jamkeluar;
		private string _d_keterangan;
		private bool _d_approve;

		[Persistent("p_id"), Key()] public long Id { get => _id; set => SetPropertyValue(nameof(Id), ref _id, value); }
		[Persistent("f_karyawan")] public Karyawan Karyawan { get => _f_karyawan; set => SetPropertyValue(nameof(Karyawan), ref _f_karyawan, value); }
		[Persistent("d_tanggal")] public DateTime Tanggal { get => _d_tanggal; set => SetPropertyValue(nameof(Tanggal), ref _d_tanggal, value); }
		[Persistent("d_jammasuk")] public TimeSpan JamMasuk { get => _d_jammasuk; set => SetPropertyValue(nameof(JamMasuk), ref _d_jammasuk, value); }
		[Persistent("d_jamkeluar")] public TimeSpan JamKeluar { get => _d_jamkeluar; set => SetPropertyValue(nameof(JamKeluar), ref _d_jamkeluar, value); }
		[Persistent("d_keterangan")] public string Keterangan { get => _d_keterangan; set => SetPropertyValue(nameof(Keterangan), ref _d_keterangan, value); }
		[Persistent("d_approve")] public bool Approve { get => _d_approve; set => SetPropertyValue(nameof(Approve), ref _d_approve, value); }
	}
}
