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
	public enum eJenisJadwal
	{
		Produksi = 0,
		Wharehouse = 1
	}
	public enum eStatusProduksi
	{
		Input = 0,
		Proses = 1
	}
	[Persistent("m09_jadwalproduksi")]	public class JadwalProduksi : NPOBase	{
		public JadwalProduksi(UnitOfWork uow) : base(uow) { }
		public JadwalProduksi(UnitOfWork uow, XPClassInfo classInfo) : base(uow, classInfo) { }

		private long _id;
		private Int16 _d_jenis;// SmallInt(6),
		private Int16 _d_tahun;// SmallInt(6),
		private DateTime _d_tanggalawal;// Date,
		private DateTime _d_tanggalakhir;// Date,
		private Divisi _f_divisi;// SmallInt(5) UNSIGNED,
		private eStatusProduksi _d_status;// SmallInt(5) UNSIGNED,
		private Shift _d_p1;// SmallInt(5) UNSIGNED,
		private Shift _d_p2;// SmallInt(5) UNSIGNED,
		private Shift _d_p3;// SmallInt(5) UNSIGNED,
		private Shift _d_p4;// SmallInt(5) UNSIGNED,
		private Shift _d_p5;//SmallInt(5) UNSIGNED,
		private Shift _d_p6;// SmallInt(5) UNSIGNED,
		private Shift _d_p7;// SmallInt(5) UNSIGNED,
		private Shift _d_p8;// SmallInt(5) UNSIGNED,
		private Shift _d_p9;// SmallInt(5) UNSIGNED,
		private Shift _d_p10;// SmallInt(5) UNSIGNED,
		private Shift _d_p11;// SmallInt(5) UNSIGNED,
		private Shift _d_p12;// SmallInt(5) UNSIGNED,
		private Shift _d_p13;// SmallInt(5) UNSIGNED,
		private Shift _d_p14;// SmallInt(5) UNSIGNED,

		[Persistent("p_id"), Key()] public long Id { get => _id; set => SetPropertyValue(nameof(Id), ref _id, value); }
		[Persistent("d_jenis")] public Int16 Jenis { get => _d_jenis; set => SetPropertyValue(nameof(Jenis), ref _d_jenis, value); }
		[Persistent("d_tahun")] public Int16 Tahun { get => _d_tahun; set => SetPropertyValue(nameof(Tahun), ref _d_tahun, value); }
		[Persistent("d_tanggalawal")] public DateTime TanggalAwal { get => _d_tanggalawal; set => SetPropertyValue(nameof(TanggalAwal), ref _d_tanggalawal, value); }
		[Persistent("d_tanggalakhir")] public DateTime TanggalAkhir { get => _d_tanggalakhir; set => SetPropertyValue(nameof(TanggalAkhir), ref _d_tanggalakhir, value); }
		[Persistent("f_divisi")] public Divisi Divisi { get => _f_divisi; set => SetPropertyValue(nameof(Divisi), ref _f_divisi, value); }
		[Persistent("d_status")] public eStatusProduksi Status { get => _d_status; set => SetPropertyValue(nameof(Status), ref _d_status, value); }

		[Persistent("d_p1")] public Shift P1 { get => _d_p1; set => SetPropertyValue(nameof(P1), ref _d_p1, value); }
		[Persistent("d_p2")] public Shift P2 { get => _d_p2; set => SetPropertyValue(nameof(P2), ref _d_p2, value); }
		[Persistent("d_p3")] public Shift P3 { get => _d_p3; set => SetPropertyValue(nameof(P3), ref _d_p3, value); }
		[Persistent("d_p4")] public Shift P4 { get => _d_p4; set => SetPropertyValue(nameof(P4), ref _d_p4, value); }
		[Persistent("d_p5")] public Shift P5 { get => _d_p5; set => SetPropertyValue(nameof(P5), ref _d_p5, value); }
		[Persistent("d_p6")] public Shift P6 { get => _d_p6; set => SetPropertyValue(nameof(P6), ref _d_p6, value); }
		[Persistent("d_p7")] public Shift P7 { get => _d_p7; set => SetPropertyValue(nameof(P7), ref _d_p7, value); }
		[Persistent("d_p8")] public Shift P8 { get => _d_p8; set => SetPropertyValue(nameof(P8), ref _d_p8, value); }
		[Persistent("d_p9")] public Shift P9 { get => _d_p9; set => SetPropertyValue(nameof(P9), ref _d_p9, value); }
		[Persistent("d_p10")] public Shift P10 { get => _d_p10; set => SetPropertyValue(nameof(P10), ref _d_p10, value); }
		[Persistent("d_p11")] public Shift P11 { get => _d_p11; set => SetPropertyValue(nameof(P11), ref _d_p11, value); }
		[Persistent("d_p12")] public Shift P12 { get => _d_p12; set => SetPropertyValue(nameof(P12), ref _d_p12, value); }
		[Persistent("d_p13")] public Shift P13 { get => _d_p13; set => SetPropertyValue(nameof(P13), ref _d_p13, value); }
		[Persistent("d_p14")] public Shift P14 { get => _d_p14; set => SetPropertyValue(nameof(P14), ref _d_p14, value); }

		[Association("fk_jadwalproduksi_detail"), Aggregated] public XPCollection<JadwalProduksiDetail> Detail => GetCollection<JadwalProduksiDetail>(nameof(Detail));

	}
	[Persistent("m09_jadwalproduksi_detail")]	public class JadwalProduksiDetail : NPOBase{
		public JadwalProduksiDetail(UnitOfWork uow) : base(uow) { }
		public JadwalProduksiDetail(UnitOfWork uow, XPClassInfo classInfo) : base(uow, classInfo) { }

		private long _id;
		private JadwalProduksi _main;
		private DateTime _tanggal;
		private Shift _shift;

		[Persistent("primary_main"), Key()] public long Id { get => _id; set => SetPropertyValue(nameof(Id), ref _id, value); }
		[Persistent("p_id"),Association("fk_jadwalproduksi_detail")] public JadwalProduksi Main { get => _main; set => SetPropertyValue(nameof(Main), ref _main, value); }
		[Persistent("d_jammasuk")] public DateTime Tanggal { get => _tanggal; set => SetPropertyValue(nameof(Tanggal), ref _tanggal, value); }
		[Persistent("d_jampulang")] public Shift Shift { get => _shift; set => SetPropertyValue(nameof(Shift), ref _shift, value); }
	}

}
