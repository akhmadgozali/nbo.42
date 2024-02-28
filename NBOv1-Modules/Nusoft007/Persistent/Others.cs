using DevExpress.Xpo;
using DevExpress.Xpo.Metadata;
using NuSoft.NPO;
using NuSoft.NPO.Modules.ModSys;

namespace NuSoft.NUI.Win.Forms.Modules.NuSoft007.Persistent {
	[Persistent("m07aregional")] public class RegionalPajak : NPOBase {
		public RegionalPajak(UnitOfWork uow) : base(uow) { }
		public RegionalPajak(UnitOfWork uow, XPClassInfo classInfo) : base(uow, classInfo) { }

		private Regional _id;
		private string _ttdNama;
		private string _ttdJabatan;

		[Key()] public Regional Id { get => _id; set => SetPropertyValue(nameof(Id), ref _id, value); }
		public string TtdNama { get => _ttdNama; set => SetPropertyValue(nameof(TtdNama), ref _ttdNama, value); }
		public string TtdJabatan { get => _ttdJabatan; set => SetPropertyValue(nameof(TtdJabatan), ref _ttdJabatan, value); }
	}
}
