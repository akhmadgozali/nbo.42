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
	public enum eJenisKelamin	{
		Laki_Laki = 0,
		Perempuan = 1
	}
	public enum eTipeKaryawan	{
		[EnumDescription("Karyawan Tetap")] Tetap = 0,
		[EnumDescription("Karyawan Kontrak")] Kontrak_I = 1,
		[EnumDescription("Outsourcing")] Outsourcing = 2,
		[EnumDescription("Karyawan Kontrak II")] Kontrak_II = 3,
		[EnumDescription("Karyawan Magang")] Magang = 4,
		[EnumDescription("Resign")] Resign = 5
	}
	public enum ePendidikan {
		S3 = 0,
		S2 = 1,
		S1 = 2,
		D4 = 3,
		D3 = 4,
		D2 = 5,
		D1 = 6,
		SMU_SMK = 7,
		SMP = 8,
		SD = 9
	}
	public enum eStatusPernikahan	{
		Belum_Kawin = 1,
		Kawin_Anak0 = 2,
		Kawin_Anak1 = 3,
		Kawin_Anak2 = 4,
		Kawin_Anak3 = 5,
		Duda = 6,
	}
	public enum eJenisKeluarga	{
		Suami = 1,
		Istri = 2,
		Anak = 3,
		Ibu = 4,
		Bapak = 5,
		Mertua = 6,
	}
	[Persistent("m09_karyawan")] public class Karyawan : NPOBase	{
		public Karyawan(UnitOfWork uow) : base(uow) { }
		public Karyawan(UnitOfWork uow, XPClassInfo classInfo) : base(uow, classInfo) { }

		private long _id;
		private string _kode;
		private string _d_nama;
		private int _d_absensiid;
		private Divisi _f_divisi;
		private Jabatan _f_jabatan;
		private DateTime _d_tanggallahir;
		private DateTime _d_tanggaljoin;
		private eJenisKelamin _d_gender;
		private eTipeKaryawan _d_jenis;
		private string _d_negara;
		private eStatusPernikahan _d_statusnikah;
		private int _d_jumlahanak;
		private string _d_telp;
		private string _d_nohp;
		private string _d_email;
		private string _d_telpemergency;
		private string _d_agama;
		private string _d_tempatlahir;
		private string _d_alamat;
		private string _d_bank;
		private string _d_bankac;
		private string _d_bankname;
		private ePendidikan _d_pendidikan;
		private string _d_pendidikannama;
		private string _d_pendidikanstudi;
		private string _d_pendidikandari;
		private string _d_pendidikansampai;
		private string _d_noktp;
		private string _d_nonpwp;
		private string _d_nobpjstk;
		private string _d_nobpjskesehatan;
		private string _d_catatan;
		private Pajak _f_statuspajak;
		private string _d_alamatktp;
		private string _d_namaibu;
		private string _d_namaayah;
		private string _d_office;
		private string _d_groupproduksi;
		private string _f_golongan;
		private string _f_kehadiran;
		private double _d_iurankop;
		private double _d_iuranserikat;
		private string _d_iuranserikatnama;
		private bool _d_management;
		private string _d_password;
		private string _f_promosi;

		[Persistent("p_id"), Key()] public long Id { get => _id; set => SetPropertyValue(nameof(Id), ref _id, value); }
		[Persistent("u_kode")] public string Kode { get => _kode; set => SetPropertyValue(nameof(Kode), ref _kode, value); }
		[Persistent("d_nama")] public string Nama { get => _d_nama; set => SetPropertyValue(nameof(Nama), ref _d_nama, value); }
		[Persistent("d_absensiid")] public int AbsensiID { get => _d_absensiid; set => SetPropertyValue(nameof(AbsensiID), ref _d_absensiid, value); }
		[Persistent("f_divisi")] public Divisi Divisi { get => _f_divisi; set => SetPropertyValue(nameof(Divisi), ref _f_divisi, value); }
		[Persistent("f_jabatan")] public Jabatan Jabatan { get => _f_jabatan; set => SetPropertyValue(nameof(Jabatan), ref _f_jabatan, value); }
		[Persistent("d_tanggallahir")] public DateTime TanggalLahir { get => _d_tanggallahir; set => SetPropertyValue(nameof(TanggalLahir), ref _d_tanggallahir, value); }
		[Persistent("d_tanggaljoin")] public DateTime TanggalJoin { get => _d_tanggaljoin; set => SetPropertyValue(nameof(TanggalJoin), ref _d_tanggaljoin, value); }
		[Persistent("d_gender")] public eJenisKelamin Gender { get => _d_gender; set => SetPropertyValue(nameof(Gender), ref _d_gender, value); }
		[Persistent("d_jenis")] public eTipeKaryawan Jenis { get => _d_jenis; set => SetPropertyValue(nameof(Jenis), ref _d_jenis, value); }
		[Persistent("d_negara")] public string Negara { get => _d_negara; set => SetPropertyValue(nameof(Negara), ref _d_negara, value); }
		[Persistent("d_statusnikah")] public eStatusPernikahan StatusNikah { get => _d_statusnikah; set => SetPropertyValue(nameof(StatusNikah), ref _d_statusnikah, value); }
		[Persistent("d_jumlahanak")] public int JumlahAnak { get => _d_jumlahanak; set => SetPropertyValue(nameof(JumlahAnak), ref _d_jumlahanak, value); }
		[Persistent("d_telp")] public string Telp { get => _d_telp; set => SetPropertyValue(nameof(Telp), ref _d_telp, value); }
		[Persistent("d_nohp")] public string NoHP { get => _d_nohp; set => SetPropertyValue(nameof(NoHP), ref _d_nohp, value); }
		[Persistent("d_email")] public string Email { get => _d_email; set => SetPropertyValue(nameof(Email), ref _d_email, value); }
		[Persistent("d_telpemergency")] public string TelpEmergency { get => _d_telpemergency; set => SetPropertyValue(nameof(TelpEmergency), ref _d_telpemergency, value); }
		[Persistent("d_agama")] public string Agama { get => _d_agama; set => SetPropertyValue(nameof(Agama), ref _d_agama, value); }
		[Persistent("d_tempatlahir")] public string TempatLahir { get => _d_tempatlahir; set => SetPropertyValue(nameof(TempatLahir), ref _d_tempatlahir, value); }
		[Persistent("d_alamat")] public string Alamat { get => _d_alamat; set => SetPropertyValue(nameof(Alamat), ref _d_alamat, value); }
		[Persistent("d_bank")] public string Bank { get => _d_bank; set => SetPropertyValue(nameof(Bank), ref _d_bank, value); }
		[Persistent("d_bankac")] public string BankAC { get => _d_bankac; set => SetPropertyValue(nameof(BankAC), ref _d_bankac, value); }
		[Persistent("d_bankname")] public string BankName { get => _d_bankname; set => SetPropertyValue(nameof(BankName), ref _d_bankname, value); }
		[Persistent("d_pendidikan")] public ePendidikan Pendidikan { get => _d_pendidikan; set => SetPropertyValue(nameof(Pendidikan), ref _d_pendidikan, value); }
		[Persistent("d_pendidikannama")] public string PendidikanNama { get => _d_pendidikannama; set => SetPropertyValue(nameof(PendidikanNama), ref _d_pendidikannama, value); }
		[Persistent("d_pendidikanstudi")] public string PendidikanStudi { get => _d_pendidikanstudi; set => SetPropertyValue(nameof(PendidikanStudi), ref _d_pendidikanstudi, value); }
		[Persistent("d_pendidikandari")] public string PendidikanDari { get => _d_pendidikandari; set => SetPropertyValue(nameof(PendidikanDari), ref _d_pendidikandari, value); }
		[Persistent("d_pendidikansampai")] public string PendidikanSampai { get => _d_pendidikansampai; set => SetPropertyValue(nameof(PendidikanSampai), ref _d_pendidikansampai, value); }
		[Persistent("d_noktp")] public string NoKTP { get => _d_noktp; set => SetPropertyValue(nameof(NoKTP), ref _d_noktp, value); }
		[Persistent("d_nonpwp")] public string NoNPWP { get => _d_nonpwp; set => SetPropertyValue(nameof(NoNPWP), ref _d_nonpwp, value); }
		[Persistent("d_nobpjstk")] public string NoBPJSTK { get => _d_nobpjstk; set => SetPropertyValue(nameof(NoBPJSTK), ref _d_nobpjstk, value); }
		[Persistent("d_nobpjskesehatan")] public string NoBPSJKesehatan { get => _d_nobpjskesehatan; set => SetPropertyValue(nameof(NoBPSJKesehatan), ref _d_nobpjskesehatan, value); }
		[Persistent("d_catatan")] public string Catatan { get => _d_catatan; set => SetPropertyValue(nameof(Catatan), ref _d_catatan, value); }
		[Persistent("f_statuspajak")] public Pajak StatusPajak { get => _f_statuspajak; set => SetPropertyValue(nameof(StatusPajak), ref _f_statuspajak, value); }
		[Persistent("d_alamatktp")] public string AlamatKTP { get => _d_alamatktp; set => SetPropertyValue(nameof(AlamatKTP), ref _d_alamatktp, value); }
		[Persistent("d_namaibu")] public string NamaIBU { get => _d_namaibu; set => SetPropertyValue(nameof(NamaIBU), ref _d_namaibu, value); }
		[Persistent("d_namaayah")] public string NamaAyah { get => _d_namaayah; set => SetPropertyValue(nameof(NamaAyah), ref _d_namaayah, value); }
		[Persistent("d_office")] public string Office { get => _d_office; set => SetPropertyValue(nameof(Office), ref _d_office, value); }
		[Persistent("d_groupproduksi")] public string GroupProduksi { get => _d_groupproduksi; set => SetPropertyValue(nameof(GroupProduksi), ref _d_groupproduksi, value); }
		[Persistent("f_golongan")] public string Golongan { get => _f_golongan; set => SetPropertyValue(nameof(Golongan), ref _f_golongan, value); }
		[Persistent("f_kehadiran")] public string Kehadiran { get => _f_kehadiran; set => SetPropertyValue(nameof(Kehadiran), ref _f_kehadiran, value); }
		[Persistent("d_iurankop")] public double IuranKoperasi { get => _d_iurankop; set => SetPropertyValue(nameof(IuranKoperasi), ref _d_iurankop, value); }
		[Persistent("d_iuranserikat")] public double IuranSerikat { get => _d_iuranserikat; set => SetPropertyValue(nameof(IuranSerikat), ref _d_iuranserikat, value); }
		[Persistent("d_iuranserikatnama")] public string IuranSerikatNama { get => _d_iuranserikatnama; set => SetPropertyValue(nameof(IuranSerikatNama), ref _d_iuranserikatnama, value); }
		[Persistent("d_management")] public bool Management { get => _d_management; set => SetPropertyValue(nameof(Management), ref _d_management, value); }
		[Persistent("d_password")] public string Password { get => _d_password; set => SetPropertyValue(nameof(Password), ref _d_password, value); }
		[Persistent("f_promosi")] public string Promosi { get => _f_promosi; set => SetPropertyValue(nameof(Promosi), ref _f_promosi, value); }


		[Association("fk_karyawan_pindahdivisi"), Aggregated] public XPCollection<KaryawanPindahDivisi> PindahDivisi => GetCollection<KaryawanPindahDivisi>(nameof(PindahDivisi));
		[Association("fk_karyawan_keluarga"), Aggregated] public XPCollection<KaryawanKeluarga> Keluarga => GetCollection<KaryawanKeluarga>(nameof(Keluarga));
		[Association("fk_karyawan_mastercuti"), Aggregated] public XPCollection<MasterCuti> MasterCuti => GetCollection<MasterCuti>(nameof(MasterCuti));
	}
	[Persistent("m09_karyawankeluarga")] public class KaryawanKeluarga : NPOBase	{
		public KaryawanKeluarga(UnitOfWork uow) : base(uow) { }
		public KaryawanKeluarga(UnitOfWork uow, XPClassInfo classInfo) : base(uow, classInfo) { }

		private long _id;
		private Karyawan _f_karyawan;// Integer(11) NOT NULL,
		private eJenisKeluarga _d_jenis;//        SmallInt(6),
		private string _d_nama;// VarChar(100) CHARACTER SET latin1 COLLATE latin1_swedish_ci,
		private DateTime _d_tanggallahir;// Date,
		private string _d_nomorhp;//      VarChar(50),
		private string _d_alamat;// VarChar(250), 

		[Persistent("p_id"), Key()] public long Id { get => _id; set => SetPropertyValue(nameof(Id), ref _id, value); }
		[Persistent("f_karyawan"), Association("fk_karyawan_keluarga")] public Karyawan Karyawan { get => _f_karyawan; set => SetPropertyValue(nameof(Karyawan), ref _f_karyawan, value); }
		[Persistent("d_jenis")] public eJenisKeluarga Jenis { get => _d_jenis; set => SetPropertyValue(nameof(Jenis), ref _d_jenis, value); }
		[Persistent("d_nama")] public String NamaKeluarga { get => _d_nama; set => SetPropertyValue(nameof(NamaKeluarga), ref _d_nama, value); }
		[Persistent("d_tanggallahir")] public DateTime TanggalLahir { get => _d_tanggallahir; set => SetPropertyValue(nameof(TanggalLahir), ref _d_tanggallahir, value); }
		[Persistent("d_nomorhp")] public String NomorHP { get => _d_nomorhp; set => SetPropertyValue(nameof(NomorHP), ref _d_nomorhp, value); }
		[Persistent("d_alamat")] public String Alamat { get => _d_alamat; set => SetPropertyValue(nameof(Alamat), ref _d_alamat, value); }
	}


	[Persistent("m09_karyawanpindahdivisi")] public class KaryawanPindahDivisi : NPOBase {
		public KaryawanPindahDivisi(UnitOfWork uow) : base(uow) { }
		public KaryawanPindahDivisi(UnitOfWork uow, XPClassInfo classInfo) : base(uow, classInfo) { }

		private long _id;
		private Karyawan _f_karyawan;// Integer(11) NOT NULL,
		private DateTime _d_tanggal;//        Date NOT NULL,
		private Divisi _f_divisi;// SmallInt(6) NOT NULL,
		private String _d_catatan;//        VarChar(150) CHARACTER SET latin1 COLLATE latin1_swedish_ci,
		private JadwalProduksi _f_jadwalproduksi;// Integer(11),

		[Persistent("p_id"), Key()] public long Id { get => _id; set => SetPropertyValue(nameof(Id), ref _id, value); }
		[Persistent("f_karyawan"), Association("fk_karyawan_pindahdivisi")] public Karyawan Karyawan { get => _f_karyawan; set => SetPropertyValue(nameof(Karyawan), ref _f_karyawan, value); }
		[Persistent("d_tanggal")] public DateTime Tanggal { get => _d_tanggal; set => SetPropertyValue(nameof(Tanggal), ref _d_tanggal, value); }
		[Persistent("f_divisi")] public Divisi Divisi { get => _f_divisi; set => SetPropertyValue(nameof(Divisi), ref _f_divisi, value); }
		[Persistent("d_catatan")] public String Catatan { get => _d_catatan; set => SetPropertyValue(nameof(Catatan), ref _d_catatan, value); }
		[Persistent("f_jadwalproduksi")] public JadwalProduksi JadwalProduksi { get => _f_jadwalproduksi; set => SetPropertyValue(nameof(JadwalProduksi), ref _f_jadwalproduksi, value); }


	}
}
