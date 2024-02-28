using DevExpress.Data.Filtering;
using DevExpress.Xpo;
using NuSoft.NUI.Win.Forms.Modules.NuSoft011.Persistent;
using System;
using System.Collections.Generic;
using System.Linq;

namespace NuSoft.NUI.Win.Forms.Modules.NuSoft011.Services {
	internal class OrderKoranService : ServiceBase<OrderKoran> {
		public OrderKoranService(UnitOfWork connection) : base(connection) { }
		public OrderKoranService(UnitOfWork connection, OrderKoran originalDataEdit) : base(connection, originalDataEdit) { }

		protected internal override bool CheckBeforeDelete(OrderKoran obj) {
			if (CheckIsInUse(uow, obj.Tanggal))
				throw new Exception(string.Format("Data {0} tidak bisa dihapus, karena sudah terpakai di sirkulasi harian.", obj.Tanggal.ToString("dd MMM yyyy")));

			return true;
		}
		protected internal override bool CheckBeforeSave(OrderKoran obj) {
			if (obj.Tanggal == null) throw new Utils.Exception("Masukkan tanggal order koran", -1);

			if (!uow.IsNewObject(obj) && _dataOriginalEdit.Tanggal == obj.Tanggal) return true;
			if (uow.FindObject<OrderKoran>(new BinaryOperator(nameof(OrderKoran.Tanggal), obj.Tanggal.ToString("yyyy-MM-dd"), BinaryOperatorType.Equal)) != null) 
				throw new Utils.Exception("Tanggal order sudah ada yang memakai.\r\nSilahkan ganti tanggal yang lain", -1);

			return true;
		}
		protected internal override void SaveAction(OrderKoran obj) {
			// Delete detail
			for (var i = obj.Detail.Count - 1; i >= 0; i--) {
				var detail = obj.Detail[i];
				var find = obj.DetailForSave.Find(f => f.Agen == detail.Agen);
				if (find == null || find.Oplah == 0) { obj.Detail.Remove(detail); detail.Delete(); }
			}

			// Insert Update
			foreach (var detail in obj.DetailForSave) {
				if (detail.Oplah == 0) continue;
				var find = obj.Detail.ToList().Find(f => f.Agen == detail.Agen);
				if (find == null) find = new OrderKoranDetail(uow) { Main = obj };
				find.Agen = detail.Agen;
				find.Jatah = detail.Jatah;
				find.Konsi = detail.Konsi;
				find.Gratis = detail.Gratis;
			}
		}
		public static bool CheckIsInUse(UnitOfWork session, DateTime tanggal) {
			return session.FindObject<SirkulasiHarian>(new BinaryOperator(nameof(SirkulasiHarian.Tanggal), tanggal, BinaryOperatorType.Equal)) != null;
		}
		public static OrderKoran GetItem(UnitOfWork session, OrderKoran obj) {
			List<OrderKoranDetailForSave> temp = new List<OrderKoranDetailForSave>();
			foreach (var det in obj.Detail) {
				temp.Add(new OrderKoranDetailForSave() {
					Id = det.Id,
					Agen = det.Agen,
					Jatah = det.Jatah,
					Konsi = det.Konsi,
					Gratis = det.Gratis
				});
			}
			var listAgen = new XPQuery<Agen>(session).Where(w => w.Aktif).ToList();
			foreach (var agen in listAgen) {
				var x = temp.Find(f => f.Agen == agen);
				if (x == null) {
					temp.Add(new OrderKoranDetailForSave() {
						Agen = agen,
						Jatah = 0,
						Konsi = 0,
						Gratis = 0
					});
				}
			}

			obj.DetailForSave = temp;
			return obj;
		}
		public static List<OrderKoranDetailForSave> GetOrderDetail(UnitOfWork session, DateTime Tanggal, bool hariKhusus) {
			var result = new List<OrderKoranDetailForSave>();
			var mutasi = new XPQuery<SirkulasiHarian>(session).Where(w => w.Tanggal.Date < Tanggal.Date).OrderByDescending(o => o.Tanggal).Take(1).SingleOrDefault();
			var listAgen = new XPQuery<Agen>(session).Where(w => w.Aktif).ToList();

			foreach (var agen in listAgen) {
				int jatah = 0; int konsi = 0; int gratis = 0;
				if (agen.OrderTetap) {
					var index = (int)Tanggal.DayOfWeek;
					if (hariKhusus) index = 0;
					else if (index == 0) index = 7;

					var othari = agen.DetailOrderTetap.ToList().Find(f => (int)f.IndexHari == index);
					if (othari != null) { jatah = othari.Jatah; konsi = othari.Konsi; gratis = othari.Gratis; }
				}
				else {
					if (mutasi != null) {
						var m = mutasi.Detail.ToList().Find(f => f.Agen == agen);
						if (m != null) { jatah = m.Jatah; konsi = m.Konsi; gratis = m.Gratis; }
					}
				}
				result.Add(new OrderKoranDetailForSave() { Id = (long)agen.Id, Agen = agen, Gratis = gratis, Jatah = jatah, Konsi = konsi });
			}
			return result;
		}
	}
}
