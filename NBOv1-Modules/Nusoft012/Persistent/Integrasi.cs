using DevExpress.Xpo;
using DevExpress.Xpo.Metadata;
using NuSoft.NPO;
using NuSoft.NPO.Modules.ModSys;

namespace NuSoft.NUI.Win.Forms.Modules.NuSoft012.Persistent {
	[Persistent("m12zmapakun")] internal class MappingAkunIklan : NPOBase {
		internal MappingAkunIklan(UnitOfWork uow) : base(uow) { }
		internal MappingAkunIklan(UnitOfWork uow, XPClassInfo classInfo) : base(uow, classInfo) { }

		private int _id;
		private ETipeIklan _tipeIklan;
		private Regional _regional;
		private Akun _akunPiutang;
		private Akun _akunPendapatan;
		private Akun _akunDiskon;
		private string _keterangan;

		[Key(true)] public int Id { get => _id; set => SetPropertyValue(nameof(Id), ref _id, value); }
		public ETipeIklan TipeIklan { get => _tipeIklan; set => SetPropertyValue(nameof(TipeIklan), ref _tipeIklan, value); }
		public Regional Regional { get => _regional; set => SetPropertyValue(nameof(Regional), ref _regional, value); }
		public Akun AkunPiutang { get => _akunPiutang; set => SetPropertyValue(nameof(AkunPiutang), ref _akunPiutang, value); }
		public Akun AkunPendapatan { get => _akunPendapatan; set => SetPropertyValue(nameof(AkunPendapatan), ref _akunPendapatan, value); }
		public Akun AkunDiskon { get => _akunDiskon; set => SetPropertyValue(nameof(AkunDiskon), ref _akunDiskon, value); }
		public string Keterangan { get => _keterangan; set => SetPropertyValue(nameof(Keterangan), ref _keterangan, value); }
	}
	[Persistent("m12zmapgl")] internal class MappingGLIklan : NPOBase {
		internal MappingGLIklan(UnitOfWork uow) : base(uow) { }
		internal MappingGLIklan(UnitOfWork uow, XPClassInfo classInfo) : base(uow, classInfo) { }

		private int _id;
		private int _tahun;
		private int _bulan;
		private Regional _regional;
		private GlMain _glId;

		[Key(true)] public int Id { get => _id; set => SetPropertyValue(nameof(Id), ref _id, value); }
		public int Tahun { get => _tahun; set => SetPropertyValue(nameof(Tahun), ref _tahun, value); }
		public int Bulan { get => _bulan; set => SetPropertyValue(nameof(Bulan), ref _bulan, value); }
		public Regional Regional { get => _regional; set => SetPropertyValue(nameof(Regional), ref _regional, value); }
		public GlMain GlId { get => _glId; set => SetPropertyValue(nameof(GlId), ref _glId, value); }
	}
}