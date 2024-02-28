using DevExpress.Data.Filtering;
using DevExpress.Xpo;
using NuSoft.NUI.Win.Forms.Modules.NuSoft007.Persistent;
using NuSoft.NUI.Win.Forms.Modules.NuSoft012.Persistent;
using System;
using System.Collections.Generic;
using System.Linq;

namespace NuSoft.NUI.Win.Forms.Modules.NuSoft012.Services {
	internal class InvoiceService : ServiceBase<Invoice> {
		public InvoiceService(UnitOfWork connection) : base(connection) { }
		public InvoiceService(UnitOfWork connection, Invoice originalDataEdit) : base(connection, originalDataEdit) { }

		private PPnKeluaran deletedPPn;
		private List<Invoice> deletedForGL;

		protected internal override bool CheckBeforeDelete(Invoice obj) {
			CheckIsInUse(uow, obj);
			return true;
		}
		protected internal override void BeforeDeleteAction(Invoice obj) {
			if (obj.TaxId != null) deletedPPn = obj.TaxId;
		}
		protected internal override void AfterDeleteAction(Invoice obj) {
			if (deletedPPn != null) deletedPPn.Delete();
		}
		protected internal override void BeforeDeleteCommit(List<Invoice> objs) {
			deletedForGL = objs;
		}
		protected internal override void AfterDeleteCommit() {
			var queryGL = deletedForGL.GroupBy(g => new DateTime(g.TanggalOmzet.Year, g.TanggalOmzet.Month, 1)).Select(s => s.Key);
			foreach (var g in queryGL) IntegrasiService.SaveGLIklan(uow, g);
		}

		protected internal override bool CheckBeforeSave(Invoice obj) {
			if (obj.TanggalOmzet == default) throw new Utils.Exception("Masukkan tanggal omzet", -1);
			if (obj.TanggalInvoice == default) throw new Utils.Exception("Masukkan tanggal invoice", -2);
			if (obj.TanggalJatuhTempo == default) throw new Utils.Exception("Masukkan tanggal jatuh tempo", -3);
			if (obj.Wilayah == null) throw new Utils.Exception("Masukkan wilayah", -4);
			if (obj.Sales == null) throw new Utils.Exception("Masukkan sales", -5);
			if (obj.TipeInvoice == null) throw new Utils.Exception("Masukkan tipe invoice iklan", -6);
			if (string.IsNullOrEmpty(obj.InvoiceNama)) throw new Utils.Exception("Masukkan pemasang", -7);
			if (string.IsNullOrEmpty(obj.InvoiceAlamat)) throw new Utils.Exception("Masukkan alamat pemasang", -8);
			if (string.IsNullOrEmpty(obj.InvoiceNPWP)) throw new Utils.Exception("Masukkan NPWP pemasang", -9);
			if (obj.TanggalOmzet > obj.TanggalJatuhTempo) throw new Utils.Exception("Tanggal omzet tidak boleh lebih besar dari tanggal jatuh tempo.", -1);
			if (obj.TanggalInvoice > obj.TanggalJatuhTempo) throw new Utils.Exception("Tanggal invoice tidak boleh lebih besar dari tanggal jatuh tempo.", -2);

			if (obj.SaldoAwal) {
				if (obj.Netto == 0) throw new Utils.Exception("Masukkan omzet iklan", -10);
				if (obj.Total == 0) throw new Utils.Exception("Masukkan saldo piutang", -11);
				if (obj.Total > obj.Netto) throw new Utils.Exception("Saldo piutang tidak boleh lebih besar dari omzet", -11);
				if (string.IsNullOrEmpty(obj.NoInvoice)) throw new Utils.Exception("Masukkan nomor invoice", -99);
				obj.NoOrder = obj.NoInvoice;

				var settingIntegrasi = new IntegrasiIklanSetting(uow);
				if (obj.TanggalOmzet >= settingIntegrasi.PeriodeMulai) throw new Utils.Exception("Tanggal piutang tidak boleh lebih dari bulan " + settingIntegrasi.PeriodeMulai.ToString("MMMM yyyy"), -1);
			}
			else {
				if (obj.TanggalMulai == default) throw new Utils.Exception("Masukkan tanggal awal terbit", -12);
				if (obj.TanggalAkhir == default) throw new Utils.Exception("Masukkan tanggal akhir terbit", -13);
				if (obj.TipeInvoice.TipeIklan == ETipeIklan.Kolom) {
					if (obj.UkuranX == 0) throw new Utils.Exception("Masukkan ukuran X", -14);
					if (obj.UkuranY == 0) throw new Utils.Exception("Masukkan ukuran Y", -15);
					if (obj.Halaman == 0) throw new Utils.Exception("Masukkan halaman", -16);
					if (string.IsNullOrEmpty(obj.JudulIklan)) throw new Utils.Exception("Masukkan judul iklan kolom", -17);
				}
				else {
					if (string.IsNullOrEmpty(obj.MateriDeretLinear)) throw new Utils.Exception("Masukkan materi iklan deret", -18);
					if (obj.JumlahBarisDeret == default) throw new Utils.Exception("Masukkan jumlah baris iklan deret", -19);
				}

				if (IntegrasiService.CekPeriodeTutupBuku(uow, obj.TanggalOmzet))
					throw new Utils.Exception("Invoice tidak bisa disimpan, karena periode nya sudah ditutup.", -1);
			}

			if (uow.IsNewObject(obj)) {
				if (!string.IsNullOrEmpty(obj.NoOrder)) CheckNomorOrder(uow, obj);
				if (!string.IsNullOrEmpty(obj.NoInvoice)) CheckNomorInvoice(uow, obj);
			}
			else {
				if (_dataOriginalEdit.NoOrder != obj.NoOrder) CheckNomorOrder(uow, obj);
				if (_dataOriginalEdit.NoInvoice != obj.NoInvoice) CheckNomorInvoice(uow, obj);
			}

			return true;
		}
		protected internal override void SaveAction(Invoice obj) {
			obj.InvoiceTtdNama = obj.Wilayah.KelompokOmzet.TtdNama;
			obj.InvoiceTtdJabatan = obj.Wilayah.KelompokOmzet.TtdJabatan;

			if (!obj.SaldoAwal) {
				if (string.IsNullOrEmpty(obj.NoInvoice)) obj.NoInvoice = NomorService.GetNomorOrderInvoice(uow, obj.TanggalOmzet, true, obj.Wilayah, obj.TipeInvoice);
				if (string.IsNullOrEmpty(obj.NoOrder)) obj.NoOrder = NomorService.GetNomorOrderInvoice(uow, obj.TanggalOmzet, false, obj.Wilayah, obj.TipeInvoice);

				if (obj.TipeInvoice.TipeIklan == ETipeIklan.Kolom) {
					obj.InvoiceKeterangan = obj.JudulIklan;
					obj.MateriDeretLinear = string.Empty;
					obj.MateriDeretLinear = string.Empty;
					obj.JumlahBarisDeret = 0;
				}
				else {
					obj.InvoiceKeterangan = obj.MateriDeretLinear;
					obj.UkuranX = 0;
					obj.UkuranY = 0;
					obj.Halaman = 0;
					obj.JudulIklan = string.Empty;
				}

				//============== TANGGAL TERBIT
				// Delete detail
				for (var i = obj.DaftarTerbit.Count - 1; i >= 0; i--) {
					var detail = obj.DaftarTerbit[i];
					var find = obj.TanggalTerbitForSave.Find(f => f.TanggalTerbit == detail.TanggalTerbit);
					if (find == null) { obj.DaftarTerbit.Remove(detail); detail.Delete(); }
					else if (find.TanggalTerbit == default) detail.Delete();
				}
				// Insert Update
				foreach (var detail in obj.TanggalTerbitForSave) {
					if (detail.TanggalTerbit == default) continue;
					var find = obj.DaftarTerbit.ToList().Find(f => f.TanggalTerbit == detail.TanggalTerbit);
					if (find == null) find = new InvoiceTerbit(uow) { Invoice = obj, TanggalTerbit = detail.TanggalTerbit };
					find.Aktif = detail.Aktif;
					find.Keterangan = detail.Keterangan;
				}

				// =============== BUAT FAKTUR PAJAK
				if (obj.PajakNominalGabungan > 0) {
					IntegrasiService.SavePajakIklan(uow, obj);
				}
				else {
					if (obj.TaxId != null) {
						var ppn = obj.TaxId;
						obj.TaxId = null;
						ppn.Delete();
					}
				}
			}
		}
		protected internal override void AfterSaveCommit(Invoice obj) {
			IntegrasiService.SaveGLIklan(uow, obj, _dataOriginalEdit);
		}

		private static void CheckNomorInvoice(UnitOfWork session, Invoice obj) {
			if (session.FindObject<Invoice>(new BinaryOperator(nameof(Invoice.NoInvoice), obj.NoInvoice, BinaryOperatorType.Equal)) != null)
				throw new Utils.Exception("Nomor invoice sudah ada yang memakai.\r\nSilahkan ganti nomor yang lain", -99);
		}
		private static void CheckNomorOrder(UnitOfWork session, Invoice obj) {
			if (session.FindObject<Invoice>(new BinaryOperator(nameof(Invoice.NoOrder), obj.NoOrder, BinaryOperatorType.Equal)) != null)
				throw new Utils.Exception("Nomor order sudah ada yang memakai.\r\nSilahkan ganti nomor yang lain", -98);
		}

		public static Invoice GetItem(Invoice obj) {
			List<InvoiceTerbitForSave> temp = new List<InvoiceTerbitForSave>();
			var selisih = obj.TanggalAkhir.Subtract(obj.TanggalMulai).Days;
			for (var i = 0; i <= selisih; i++) {
				var d = new InvoiceTerbitForSave() { TanggalTerbit = obj.TanggalMulai.AddDays(i) };
				var exist = obj.DaftarTerbit.ToList().Find(f => f.TanggalTerbit == d.TanggalTerbit);
				if (exist != null) {
					d.Id = exist.Id;
					d.Aktif = exist.Aktif;
					d.Keterangan = exist.Keterangan;
				}
				temp.Add(d);
			}

			obj.TanggalTerbitForSave = temp;
			return obj;
		}
		public static void CheckIsInUse(UnitOfWork session, Invoice obj) {
			if (IntegrasiService.CekPeriodeTutupBuku(session, obj.TanggalOmzet))
				throw new Utils.Exception(string.Format("Nomor {0} tidak bisa dihapus, karena periode nya sudah ditutup.", obj.NoInvoice), -1);
			if (obj.TaxId != null && obj.TaxId.StatusFaktur != EFakturStatus.Edit)
				throw new Utils.Exception(string.Format("Nomor {0} tidak bisa dihapus, karena faktur pajak nya sudah di proses.", obj.NoInvoice), -1);
			if (session.FindObject<PembayaranIklanDetail>(new BinaryOperator(nameof(PembayaranIklanDetail.Invoice), obj, BinaryOperatorType.Equal)) != null)
				throw new Utils.Exception(string.Format("Nomor {0} tidak bisa dihapus, karena sudah di bayar.", obj.NoInvoice), -1);
			if (obj.DaftarAnak.Count > 0)
				throw new Utils.Exception(string.Format("Nomor {0} tidak bisa dihapus, karena sudah di jadikan induk invoice lain.", obj.NoInvoice), -1);
			if (obj.DaftarKoreksi.Count > 0)
				throw new Utils.Exception(string.Format("Nomor {0} tidak bisa dihapus, karena sudah di koreksi.", obj.NoInvoice), -1);

			if (obj.IndukInvoice != null)
				throw new Utils.Exception(string.Format("Nomor {0} tidak bisa dihapus, karena sudah di gabung dengan invoice lain.", obj.NoInvoice), -1);
		}
		public static bool IsATransaction(UnitOfWork session) { return ((int)session.Evaluate<Invoice>(CriteriaOperator.Parse("Count()"), null)) > 0; }

		public static List<WarningTerbit> GetWarningTerbit(UnitOfWork session) {
			var serverDate = Data.Helper.GetTimeStamp(session);
			var xpTerbit = new XPQuery<InvoiceTerbit>(session).Where(w => w.TanggalTerbit.Date >= serverDate.Date).GroupBy(g => g.Invoice).Select(s => s.Key);
			var result = new List<WarningTerbit>();

			foreach (var x in xpTerbit) {
				var item = new WarningTerbit() {
					Id = x.Id,
					Judul = x.InvoiceKeterangan,
					Merk = x.Merk.Nama,
					NoInvoice = x.NoInvoice,
					Pemasang = x.InvoiceNama,
					Sales = x.Sales.Nama,
					TglInvoice = x.TanggalInvoice,
					Wilayah = x.Wilayah.Nama,
					Regional = x.Wilayah.Regional.Nama,
					RegionalId = x.Wilayah.Regional.Id
				};
				item.TerbitTerakhir = x.DaftarTerbit.Where(w => w.Aktif).Max(m => m.TanggalTerbit);
				item.SisaTerbit = x.DaftarTerbit.Count(w => w.Aktif && w.TanggalTerbit.Date >= serverDate.Date);

				result.Add(item);
			}

			return result;
		}

		public static void SaveEditTanggalTerbit(UnitOfWork session, Invoice invoice, List<InvoiceTerbitForSave> terbit, bool updateGL) {
			if (string.IsNullOrEmpty(invoice.NoInvoice)) invoice.NoInvoice = NomorService.GetNomorOrderInvoice(session, invoice.TanggalOmzet, true, invoice.Wilayah, invoice.TipeInvoice);

			//============== TERBIT
			// Delete detail
			for (var i = invoice.DaftarTerbit.Count - 1; i >= 0; i--) {
				var detail = invoice.DaftarTerbit[i];
				var find = terbit.Find(f => f.TanggalTerbit.Date == detail.TanggalTerbit.Date);
				if (find == null) { invoice.DaftarTerbit.Remove(detail); detail.Delete(); }
				else if (!find.Aktif) detail.Delete();
			}

			// Insert Update
			//var jmlTerbit = terbit.Count(w => w.Aktif);
			foreach (var detail in terbit) {
				if (!detail.Aktif) continue;
				var find = invoice.DaftarTerbit.ToList().Find(f => f.TanggalTerbit.Date == detail.TanggalTerbit.Date);
				if (find == null) find = new InvoiceTerbit(session) { Invoice = invoice, TanggalTerbit = detail.TanggalTerbit };
				find.Aktif = detail.Aktif;
				find.Keterangan = detail.Keterangan;
			}

			if (invoice.TaxId != null && invoice.TaxId.StatusFaktur == EFakturStatus.Edit) {
				IntegrasiService.SavePajakIklan(session, invoice);
			}
			session.CommitChanges();

			if (updateGL) IntegrasiService.SaveGLIklan(session, invoice, null);
		}
		public static string SetMateriBaris(string materiLinier, int jmlKarakter) {
			var str = materiLinier;
			var chunkLength = jmlKarakter;
			var result = "";

			if (string.IsNullOrEmpty(str)) {
				return string.Empty;
			}
			if (chunkLength < 1) return string.Empty;

			for (int i = 0; i < str.Length; i += chunkLength) {
				if (chunkLength + i > str.Length)
					chunkLength = str.Length - i;

				result += str.Substring(i, chunkLength) + "\r\n";
			}
			return result;
		}
	}
	internal class PenagihanInvoiceService : ServiceBase<Invoice> {
		public PenagihanInvoiceService(UnitOfWork connection) : base(connection) { }
		public PenagihanInvoiceService(UnitOfWork connection, Invoice originalDataEdit) : base(connection, originalDataEdit) { }

		protected internal override bool CheckBeforeDelete(Invoice obj) { return false; }
		protected internal override bool CheckBeforeSave(Invoice obj) {
			if (obj.Kurir == null) throw new Utils.Exception("Masukkan nama penagihan", -1);
			foreach (var detail in obj.PenagihanForSave) {
				if (detail.TanggalKirim == default) throw new Utils.Exception("Masukkan tanggal penagihan", -99);
				if (string.IsNullOrEmpty(detail.Keterangan)) throw new Utils.Exception("Masukkan keterangan penagihan", -99);
			}

			return true;
		}
		protected internal override void SaveAction(Invoice obj) {
			// Delete detail
			for (var ji = obj.DaftarPenagihan.Count - 1; ji >= 0; ji--) {
				var detail = obj.DaftarPenagihan[ji];
				var find = obj.PenagihanForSave.Find(f => f.TanggalKirim == detail.TanggalKirim);
				if (find == null) { obj.DaftarPenagihan.Remove(detail); detail.Delete(); }
			}

			// Insert Update
			foreach (var detail in obj.PenagihanForSave) {
				var find = obj.DaftarPenagihan.ToList().Find(f => f.TanggalKirim == detail.TanggalKirim);
				if (find == null) find = new InvoicePenagihan(uow) { Invoice = obj, TanggalKirim = detail.TanggalKirim };
				find.Keterangan = detail.Keterangan;
			}
		}

		internal static Invoice GetItem(Invoice obj) {
			List<InvoicePenagihanForSave> temp = new List<InvoicePenagihanForSave>();
			foreach (var det in obj.DaftarPenagihan) {
				temp.Add(new InvoicePenagihanForSave() {
					Id = det.Id,
					TanggalKirim = det.TanggalKirim,
					Keterangan = det.Keterangan
				});
			}

			obj.PenagihanForSave = temp;
			return obj;
		}
	}

	internal class GabungInvoiceService : ServiceBase<Invoice> {
		public GabungInvoiceService(UnitOfWork connection) : base(connection) { }
		public GabungInvoiceService(UnitOfWork connection, Invoice originalDataEdit) : base(connection, originalDataEdit) { }

		protected internal override bool CheckBeforeDelete(Invoice obj) {
			for (int i = obj.DaftarAnak.Count - 1; i >= 0; i--) {
				var inv = obj.DaftarAnak[i];
				inv.IndukInvoice = null;
				IntegrasiService.SavePajakIklan(uow, inv);
				uow.CommitChanges();
			}
			IntegrasiService.SavePajakIklan(uow, obj);
			uow.CommitChanges();
			return false;
		}
		protected internal override bool CheckBeforeSave(Invoice obj) {
			if (obj.GabungIklanForSave == null || obj.GabungIklanForSave.Count < 1) throw new Utils.Exception("Masukkan invoice yang akan digabung", -1);

			return true;
		}
		protected internal override void SaveAction(Invoice obj) {
			for (int i = obj.DaftarAnak.Count - 1; i >= 0; i--) {
				var inv = obj.DaftarAnak[i];
				var found = obj.GabungIklanForSave.Find(f => f == inv);
				if (found == null) {
					inv.IndukInvoice = null;
					IntegrasiService.SavePajakIklan(uow, inv);
				}
			}

			foreach (var r in obj.GabungIklanForSave) r.IndukInvoice = obj;
			IntegrasiService.SavePajakIklan(uow, obj);
		}

		public static Invoice GetItem(Invoice obj) {
			obj.GabungIklanForSave = obj.DaftarAnak.ToList();
			return obj;
		}
	}
}
