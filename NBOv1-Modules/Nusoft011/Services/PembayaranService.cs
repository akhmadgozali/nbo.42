using DevExpress.Data.Filtering;
using DevExpress.Xpo;
using NuSoft.NUI.Win.Forms.Modules.NuSoft011.Persistent;
using System;
using System.Collections.Generic;
using System.Linq;

namespace NuSoft.NUI.Win.Forms.Modules.NuSoft011.Services {
	internal class PembayaranService : ServiceBase<BayarKoran> {
		public PembayaranService(UnitOfWork connection) : base(connection) { }
		public PembayaranService(UnitOfWork connection, BayarKoran originalDataEdit) : base(connection, originalDataEdit) { }

		private GlMain deletedGL;
		protected internal override bool CheckBeforeDelete(BayarKoran obj) {
			CheckIsInUse(uow, obj);
			return true;
		}
		protected internal override bool CheckBeforeSave(BayarKoran obj) {
			if (obj.Tanggal == default(DateTime)) throw new Utils.Exception("Masukkan tanggal pembayaran", -1);
			if (obj.Agen == null) throw new Utils.Exception("Masukkan agen", -2);
			if (obj.CaraBayar == null) throw new Utils.Exception("Masukkan cara pembayaran", -3);
			if (string.IsNullOrEmpty(obj.Keterangan)) throw new Utils.Exception("Masukkan keterangan", -4);
			if (obj.TotalSetor == 0) throw new Utils.Exception("Masukkan jumlah pembayaran", -5);

			if (!uow.IsNewObject(obj) && _dataOriginalEdit.Kode == obj.Kode) return true;
			if (!string.IsNullOrEmpty(obj.Kode) && uow.FindObject<BayarKoran>(new BinaryOperator(nameof(BayarKoran.Kode), obj.Kode, BinaryOperatorType.Equal)) != null)
				throw new Utils.Exception("Kode pembayaran sudah ada yang memakai.\r\nSilahkan ganti dengan kode yang lain", -6);

			if (IntegrasiService.CekPeriodeTutupBuku(uow, obj.Tanggal))
				throw new Utils.Exception(string.Format("Data pembayaran {0} tidak bisa disimpan, karena periode nya sudah ditutup.", obj.Kode), -1);

			return true;
		}

		protected internal override void SaveAction(BayarKoran obj) {
			if (string.IsNullOrEmpty(obj.Kode)) obj.Kode = NomorService.GetNomorPembayaranPemasaran(uow, obj.Tanggal);
			obj.Regional = obj.Agen.Rute.Regional;
			if (obj.BatalBayarId != null) {
				obj.TotalBayar *= -1;
				obj.Diskon *= -1;
			}

			IntegrasiService.SavePembayaranKoran(uow, obj);
		}
		protected internal override void BeforeDeleteAction(BayarKoran obj) { deletedGL = obj.GLId; }
		protected internal override void AfterDeleteAction(BayarKoran obj) { deletedGL.Delete(); }

		public static void CheckIsInUse(UnitOfWork session, BayarKoran obj) {
			if (IntegrasiService.CekPeriodeTutupBuku(session, obj.Tanggal))
				throw new Utils.Exception(string.Format("Data pembayaran {0} tidak bisa dihapus, karena periode nya sudah ditutup.", obj.Kode), -1);
			if (session.FindObject<BayarKoran>(new BinaryOperator(nameof(BayarKoran.BatalBayarId), obj, BinaryOperatorType.Equal)) != null)
				throw new Utils.Exception(string.Format("Data pembayaran {0} tidak bisa dihapus, karena sudah dikoreksi.", obj.Kode), -2);
		}

		public static List<BayarKoran> GetSourcePembayaranKoreksi(UnitOfWork session, DateTime periode, BayarKoran objEdit) {
			var dataSdhKoreksi = new XPQuery<BayarKoran>(session).Where(w => w.BatalBayarId != null).GroupBy(g => g.BatalBayarId).Select(s => s.Key).ToList();
			if (objEdit == null)
				return new XPQuery<BayarKoran>(session).Where(w => (w.BatalBayarId == null &&
						w.Tanggal.Year == periode.Year && w.Tanggal.Month == periode.Month && !dataSdhKoreksi.Contains(w))).ToList();
			else
				return new XPQuery<BayarKoran>(session).Where(w => w == objEdit.BatalBayarId || (w.BatalBayarId == null &&
					w.Tanggal.Year == periode.Year && w.Tanggal.Month == periode.Month && !dataSdhKoreksi.Contains(w))).ToList();
		}

		public static bool IsATransaction(UnitOfWork session) { return ((int)session.Evaluate<BayarKoran>(CriteriaOperator.Parse("Count()"), null)) > 0; }
	}
}
