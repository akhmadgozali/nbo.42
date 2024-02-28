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
	[Persistent("m09_mastershift")]public class Shift : NPOBase	{
		public Shift(UnitOfWork uow) : base(uow) { }
		public Shift(UnitOfWork uow, XPClassInfo classInfo) : base(uow, classInfo) { }

		private long _id;
		private string _kode;
		private TimeSpan _jammasuk;
		private TimeSpan _jamkeluar;

		[Persistent("p_id"),Key()] public long Id { get => _id; set => SetPropertyValue(nameof(Id), ref _id, value); }
		[Persistent("u_kode")] public string Kode { get => _kode; set => SetPropertyValue(nameof(Kode), ref _kode, value); }
		[Persistent("d_jammasuk")] public TimeSpan JamMasuk { get => _jammasuk; set => SetPropertyValue(nameof(JamMasuk), ref _jammasuk, value); }
		[Persistent("d_jampulang")] public TimeSpan JamKeluar { get => _jamkeluar; set => SetPropertyValue(nameof(JamKeluar), ref _jamkeluar, value); }
	}
	[Persistent("m09_masterdivisi")] public class Divisi : NPOBase
	{
		public Divisi(UnitOfWork uow) : base(uow) { }
		public Divisi(UnitOfWork uow, XPClassInfo classInfo) : base(uow, classInfo) { }

		private long _id;
		private string _kode;
		private string _nama;
		private bool _shift;
		private string _leader;
		private string _supervisor;
		private string _manager;
		private string _managerasistent;
		private bool _aktif;

		[Persistent("p_id"),Key()] public long Id { get => _id; set => SetPropertyValue(nameof(Id), ref _id, value); }
		[Persistent("u_kode")] public string Kode { get => _kode; set => SetPropertyValue(nameof(Kode), ref _kode, value); }
		[Persistent("d_nama")] public string Nama { get => _nama; set => SetPropertyValue(nameof(Nama), ref _nama, value); }
		[Persistent("d_shift")] public bool Shift { get => _shift; set => SetPropertyValue(nameof(Shift), ref _shift, value); }
		[Persistent("d_leader")] public string Leader { get => _leader; set => SetPropertyValue(nameof(Leader), ref _leader, value); }
		[Persistent("d_supervisor")] public string Supervisor { get => _supervisor; set => SetPropertyValue(nameof(Supervisor), ref _supervisor, value); }
		[Persistent("d_manager")] public string Manager { get => _manager; set => SetPropertyValue(nameof(Manager), ref _manager, value); }
		[Persistent("d_managerasistent")] public string ManagerAsistent { get => _managerasistent; set => SetPropertyValue(nameof(ManagerAsistent), ref _managerasistent, value); }
		[Persistent("d_aktif")] public bool Aktif { get => _aktif; set => SetPropertyValue(nameof(Aktif), ref _aktif, value); }
	}
	[Persistent("m09_masterijin")] public class MasterIjin : NPOBase
	{
		public MasterIjin(UnitOfWork uow) : base(uow) { }
		public MasterIjin(UnitOfWork uow, XPClassInfo classInfo) : base(uow, classInfo) { }

		private long _id;
		private string _kode;
		private string _nama;
		private int _lama;

		[Persistent("p_id"), Key()] public long Id { get => _id; set => SetPropertyValue(nameof(Id), ref _id, value); }
		[Persistent("u_kode")] public string Kode { get => _kode; set => SetPropertyValue(nameof(Kode), ref _kode, value); }
		[Persistent("d_nama")] public string Nama { get => _nama; set => SetPropertyValue(nameof(Nama), ref _nama, value); }
		[Persistent("d_lama")] public int Lama { get => _lama; set => SetPropertyValue(nameof(Lama), ref _lama, value); }
	}
	[Persistent("m09_mastergolongan")] public class Golongan : NPOBase {
		public Golongan(UnitOfWork uow) : base(uow) { }
		public Golongan(UnitOfWork uow, XPClassInfo classInfo) : base(uow, classInfo) { }

		private long _id;
		private string _kode;
		private bool _lembur;

		[Persistent("p_id"), Key()] public long Id { get => _id; set => SetPropertyValue(nameof(Id), ref _id, value); }
		[Persistent("u_kode")] public string Kode { get => _kode; set => SetPropertyValue(nameof(Kode), ref _kode, value); }
		[Persistent("d_lembur")] public bool Lembur { get => _lembur; set => SetPropertyValue(nameof(Lembur), ref _lembur, value); }
	}
	[Persistent("m09_masterjabatan")] public class Jabatan : NPOBase {
		public Jabatan(UnitOfWork uow) : base(uow) { }
		public Jabatan(UnitOfWork uow, XPClassInfo classInfo) : base(uow, classInfo) { }

		private long _id;
		private string _kode;
		private string _nama;
		private double _d_gajipokok;
		private double _d_tunjanganjabatan;
	  private double _d_tunjanganlain;
		private double _d_tunjangantenagakerja;
		private double _d_tunjangangolongan;
		private double _d_tunjangankesehatan;
		private double _d_pottenagakerja;
		private double _d_potkesehatan;
		private double _d_potpensiun;
		private double _d_potlain;


		[Persistent("p_id"), Key()] public long Id { get => _id; set => SetPropertyValue(nameof(Id), ref _id, value); }
		[Persistent("u_kode")] public string Kode { get => _kode; set => SetPropertyValue(nameof(Kode), ref _kode, value); }
		[Persistent("d_nama")] public string Nama { get => _nama; set => SetPropertyValue(nameof(Nama), ref _nama, value); }
		[Persistent("d_gajipokok")] public double GajiPokok { get => _d_gajipokok; set => SetPropertyValue(nameof(GajiPokok), ref _d_gajipokok, value); }
		[Persistent("d_tunjanganjabatan")] public double TunjanganJabatan { get => _d_tunjanganjabatan; set => SetPropertyValue(nameof(TunjanganJabatan), ref _d_tunjanganjabatan, value); }
		[Persistent("d_tunjanganlain")] public double TunjanganLain { get => _d_tunjanganlain; set => SetPropertyValue(nameof(TunjanganLain), ref _d_tunjanganlain, value); }
		[Persistent("d_tunjangantenagakerja")] public double TunjanganTenagaKerja { get => _d_tunjangantenagakerja; set => SetPropertyValue(nameof(TunjanganTenagaKerja), ref _d_tunjangantenagakerja, value); }
		[Persistent("d_tunjangangolongan")] public double TunjanganGolongan { get => _d_tunjangangolongan; set => SetPropertyValue(nameof(TunjanganGolongan), ref _d_tunjangangolongan, value); }
		[Persistent("d_tunjangankesehatan")] public double TunjanganKesehatan { get => _d_tunjangankesehatan; set => SetPropertyValue(nameof(TunjanganKesehatan), ref _d_tunjangankesehatan, value); }
		[Persistent("d_pottenagakerja")] public double PotonganTenagaKerja { get => _d_pottenagakerja; set => SetPropertyValue(nameof(PotonganTenagaKerja), ref _d_pottenagakerja, value); }
		[Persistent("d_potkesehatan")] public double PotonganKesehatan { get => _d_potkesehatan; set => SetPropertyValue(nameof(PotonganKesehatan), ref _d_potkesehatan, value); }
		[Persistent("d_potpensiun")] public double PotonganPensiun { get => _d_potlain; set => SetPropertyValue(nameof(PotonganPensiun), ref _d_potpensiun, value); }
		[Persistent("d_potlain")] public double PotonganLain { get => _d_potlain; set => SetPropertyValue(nameof(PotonganLain), ref _d_potlain, value); }
	}
	[Persistent("m09_masterkehadiran")] public class Kehadiran : NPOBase {
		public Kehadiran(UnitOfWork uow) : base(uow) { }
		public Kehadiran(UnitOfWork uow, XPClassInfo classInfo) : base(uow, classInfo) { }

		private long _id;
		private string _kode;
		private int _nilai;

		[Persistent("p_id"), Key()] public long Id { get => _id; set => SetPropertyValue(nameof(Id), ref _id, value); }
		[Persistent("u_kode")] public string Kode { get => _kode; set => SetPropertyValue(nameof(Kode), ref _kode, value); }
		[Persistent("d_nilai")] public int Nilai { get => _nilai; set => SetPropertyValue(nameof(Nilai), ref _nilai, value); }
	}
	[Persistent("m09_masterpajak")] public class Pajak : NPOBase {
		public Pajak(UnitOfWork uow) : base(uow) { }
		public Pajak(UnitOfWork uow, XPClassInfo classInfo) : base(uow, classInfo) { }

		private long _id;
		private string _kode;
		private string _nama;
		private double _nilai;

		[Persistent("p_id"), Key()] public long Id { get => _id; set => SetPropertyValue(nameof(Id), ref _id, value); }
		[Persistent("u_kode")] public string Kode { get => _kode; set => SetPropertyValue(nameof(Kode), ref _kode, value); }
		[Persistent("d_nama")] public string Nama { get => _nama; set => SetPropertyValue(nameof(Nama), ref _nama, value); }
		[Persistent("d_nilaiptkp")] public double Nilai { get => _nilai; set => SetPropertyValue(nameof(Nilai), ref _nilai, value); }
	}
	//"Hari Libur Nasional~Lebaran Idul Fitri~Cuti Bersama Lebaran"
	public enum eTipeDayOff
	{
		Hari_Libur_Nasional = 0,
		Lebaran_Idul_Fitri = 1,
		Cuti_Bersama_Lebaran = 2
	}
	[Persistent("m09_dayoff")]	public class DayOff : NPOBase{
		public DayOff(UnitOfWork uow) : base(uow) { }
		public DayOff(UnitOfWork uow, XPClassInfo classInfo) : base(uow, classInfo) { }

		private long _id;
		private string _kode;
		private DateTime _tanggal;
		private eTipeDayOff _tipe;

    [Persistent("p_id"), Key()] public long Id { get => _id; set => SetPropertyValue(nameof(Id), ref _id, value); }
		[Persistent("d_keterangan")] public string Kode { get => _kode; set => SetPropertyValue(nameof(Kode), ref _kode, value); }
		[Persistent("u_tanggal")] public DateTime Tanggal { get => _tanggal; set => SetPropertyValue(nameof(Tanggal), ref _tanggal, value); }
		[Persistent("d_nilaiptkp")] public eTipeDayOff Tipe { get => _tipe; set => SetPropertyValue(nameof(Tipe), ref _tipe, value); }
	}
}
