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
	[Persistent("m09_promosikaryawan")]public class PromosiKaryawan : NPOBase{
		public PromosiKaryawan(UnitOfWork uow) : base(uow) { }
		public PromosiKaryawan(UnitOfWork uow, XPClassInfo classInfo) : base(uow, classInfo) { }

		private long _id;
		private Karyawan _f_karyawan;// Integer(11) NOT NULL,
		private DateTime _d_tanggal;//        Date NOT NULL,
		private String _d_catatan;// VarChar(250) CHARACTER SET latin1 COLLATE latin1_swedish_ci,
		private Jabatan _f_jabatan;// SmallInt(6) DEFAULT 0,
		private Double _d_gajipokok;// Double DEFAULT 0,
		private Double _d_tunkeluarga;
		private Double _d_tunjabatan;// Double DEFAULT 0,
		private Double _d_tunlain;// Double DEFAULT 0,
		private Double _d_tuntransport;
		private Double _d_tuntenagakerja;// Double DEFAULT 0,
		private Double _d_tungolongan;// Double DEFAULT 0,
		private Double _d_pokesehatan;// Double DEFAULT 0,
		private Double _d_potpensiun;// Double DEFAULT 0,
		private Double _d_potlain;// Double DEFAULT 0,
		private Double _d_pottenagakerja;
		private Kehadiran _d_premikehadiran;// Double DEFAULT 0,
		private eTipeKaryawan _d_jenis;// SmallInt(6),

		[Persistent("p_id"), Key()] public long Id { get => _id; set => SetPropertyValue(nameof(Id), ref _id, value); }
		[Persistent("f_karyawan")] public Karyawan Karyawan { get => _f_karyawan; set => SetPropertyValue(nameof(Karyawan), ref _f_karyawan, value); }
		[Persistent("d_tanggal")] public DateTime Tanggal { get => _d_tanggal; set => SetPropertyValue(nameof(Tanggal), ref _d_tanggal, value); }
		[Persistent("d_catatan")] public String Catatan { get => _d_catatan; set => SetPropertyValue(nameof(Catatan), ref _d_catatan, value); }
		[Persistent("f_jabatan")] public Jabatan Jabatan { get => _f_jabatan; set => SetPropertyValue(nameof(Jabatan), ref _f_jabatan, value); }
		[Persistent("d_gajipokok")] public Double GajiPokok { get => _d_gajipokok; set => SetPropertyValue(nameof(GajiPokok), ref _d_gajipokok, value); }
		[Persistent("d_tunkeluarga")] public Double TunjanganKeluarga { get => _d_tunkeluarga; set => SetPropertyValue(nameof(TunjanganKeluarga), ref _d_tunkeluarga, value); }
		[Persistent("d_tunjabatan")] public Double TunjanganJabatan { get => _d_tunjabatan; set => SetPropertyValue(nameof(TunjanganJabatan), ref _d_tunjabatan, value); }
		[Persistent("d_tuntransport")] public Double TunjanganTransport { get => _d_tuntransport; set => SetPropertyValue(nameof(TunjanganTransport), ref _d_tuntransport, value); }
		[Persistent("d_tunlain")] public Double TunjanganLain { get => _d_tunlain; set => SetPropertyValue(nameof(TunjanganLain), ref _d_tunlain, value); }
		[Persistent("d_tuntenagakerja")] public Double TunjanganTenagaKerja { get => _d_tuntenagakerja; set => SetPropertyValue(nameof(TunjanganTenagaKerja), ref _d_tuntenagakerja, value); }
		[Persistent("d_tungolongan")] public Double TunjanganGolongan { get => _d_tungolongan; set => SetPropertyValue(nameof(TunjanganGolongan), ref _d_tungolongan, value); }
		[Persistent("d_potlain")] public Double PotonganLain { get => _d_potlain; set => SetPropertyValue(nameof(PotonganLain), ref _d_potlain, value); }
		[Persistent("d_pokesehatan")] public Double PotonganKesehatan { get => _d_pokesehatan; set => SetPropertyValue(nameof(PotonganKesehatan), ref _d_pokesehatan, value); }
		[Persistent("d_potpensiun")] public Double PotonganPensiun { get => _d_potpensiun; set => SetPropertyValue(nameof(PotonganPensiun), ref _d_potpensiun, value); }
		[Persistent("d_pottenagakerja")] public Double PotonganTenagaKerja { get => _d_pottenagakerja; set => SetPropertyValue(nameof(PotonganTenagaKerja), ref _d_pottenagakerja, value); }
		[Persistent("f_premikehadiran")] public Kehadiran PremiKehadiran { get => _d_premikehadiran; set => SetPropertyValue(nameof(PremiKehadiran), ref _d_premikehadiran, value); }
		[Persistent("d_jenis")] public eTipeKaryawan Jenis { get => _d_jenis; set => SetPropertyValue(nameof(Jenis), ref _d_jenis, value); }
	}

}
