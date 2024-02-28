using DevExpress.Xpo;
using DevExpress.Xpo.Metadata;
using NuSoft.NPO;
using NuSoft.NPO.Modules.ModSys;
using System;
using System.Collections.Generic;

namespace NuSoft.NUI.Win.Forms.Modules.NuSoft011.Persistent {
	[Persistent("m11cbayarkoran")] internal class BayarKoran : NPOBase {
		internal BayarKoran(UnitOfWork uow) : base(uow) { }
		internal BayarKoran(UnitOfWork uow, XPClassInfo classInfo) : base(uow, classInfo) { }

		private long _id;
		private string _kode;
		private Regional _regional;
		private Agen _agen;
		private CaraBayar _caraBayar;
		private DateTime _tanggal;
		private double _totalBayar;
		private double _diskon;
		private string _keterangan;
		private GlMain _glId;
		private BayarKoran _batalBayarId;

		[Key(true)] public long Id { get => _id; set => SetPropertyValue(nameof(Id), ref _id, value); }
		public string Kode { get => _kode; set => SetPropertyValue(nameof(Kode), ref _kode, value); }
		public Regional Regional { get => _regional; set => SetPropertyValue(nameof(Regional), ref _regional, value); }
		public Agen Agen { get => _agen; set => SetPropertyValue(nameof(Agen), ref _agen, value); }
		public CaraBayar CaraBayar { get => _caraBayar; set => SetPropertyValue(nameof(CaraBayar), ref _caraBayar, value); }
		public DateTime Tanggal { get => _tanggal; set => SetPropertyValue(nameof(Tanggal), ref _tanggal, value); }
		public double TotalBayar { get => _totalBayar; set => SetPropertyValue(nameof(TotalBayar), ref _totalBayar, value); }
		public double Diskon { get => _diskon; set => SetPropertyValue(nameof(Diskon), ref _diskon, value); }
		public string Keterangan { get => _keterangan; set => SetPropertyValue(nameof(Keterangan), ref _keterangan, value); }
		public GlMain GLId { get => _glId; set => SetPropertyValue(nameof(GLId), ref _glId, value); }
		public BayarKoran BatalBayarId { get => _batalBayarId; set => SetPropertyValue(nameof(BatalBayarId), ref _batalBayarId, value); }
		[NonPersistent] public string Terbilang => Utils.Common.Character.Terbilang(TotalBayar).ToUpper();

		[PersistentAlias("GetYear(" + nameof(Tanggal) + ")")] public int Tahun => Convert.ToInt32(EvaluateAlias(nameof(Tahun)));
		[PersistentAlias("Concat(GetYear(" + nameof(Tanggal) + "),'-',GetMonth(" + nameof(Tanggal) + "),'-01')")] public DateTime Bulan => Convert.ToDateTime(EvaluateAlias(nameof(Bulan)));
		[PersistentAlias("Iif(GetDay(" + nameof(Tanggal) + ") <= 7, 1, Iif(GetDay(" + nameof(Tanggal) + ") <= 14, 2, Iif(GetDay(" + nameof(Tanggal) + ") <= 21, 3, 4)))")] public int Minggu => Convert.ToInt32(EvaluateAlias(nameof(Minggu)));
		[PersistentAlias(nameof(TotalBayar) + " - " + nameof(Diskon))] public double TotalSetor => Convert.ToDouble(EvaluateAlias(nameof(TotalSetor)));
	}
}
