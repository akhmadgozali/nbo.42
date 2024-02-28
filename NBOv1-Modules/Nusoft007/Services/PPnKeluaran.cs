using DevExpress.Data.Filtering;
using DevExpress.Xpo;
using NuSoft.NPO.Modules;
using NuSoft.NUI.Win.Forms.Modules.NuSoft007.Persistent;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace NuSoft.NUI.Win.Forms.Modules.NuSoft007.Services {
	internal class NomorFakturPajakService : ServiceBase<NomorSeriPajak> {
		internal NomorFakturPajakService(UnitOfWork connection) : base(connection) { }
		internal NomorFakturPajakService(UnitOfWork connection, NomorSeriPajak originalDataEdit) : base(connection, originalDataEdit) { }

		protected internal override bool CheckBeforeDelete(NomorSeriPajak obj) {
			var terpakai = new XPQuery<PPnKeluaran>(uow).Where(w => w.NomorSeriValid != null && w.NomorSeriValid.Main == obj);
			if (terpakai.Count() > 0) throw new Utils.Exception(string.Format("Nomor dengan range {0} - {1} tidak bisa dihapus, karena sudah dipakai.", obj.NomorDari, obj.NomorSampai), -1);

			return true;
		}
		protected internal override bool CheckBeforeSave(NomorSeriPajak obj) {
			if (obj.TanggalMulaiBerlaku == default) throw new Utils.Exception("Masukkan tanggal mulai faktur", -1);
			if (string.IsNullOrEmpty(obj.NomorDari)) throw new Utils.Exception("Masukkan nomor faktur pajak awal", -2);
			if (string.IsNullOrEmpty(obj.NomorSampai)) throw new Utils.Exception("Masukkan nomor faktur pajak terakhir", -3);

			bool cekNomorDari = false; bool cekNomorSampai = false;

			if (uow.IsNewObject(obj)) { cekNomorDari = true; cekNomorSampai = true; }
			else {
				if (_dataOriginalEdit.NomorDari == obj.NomorDari) cekNomorDari = true;
				if (_dataOriginalEdit.NomorSampai == obj.NomorSampai) cekNomorSampai = true;
			}

			if (cekNomorDari && uow.FindObject<NomorSeriPajak>(new BinaryOperator(nameof(NomorSeriPajak.NomorDari), obj.NomorDari, BinaryOperatorType.Equal)) != null)
				throw new Utils.Exception("Nomor faktur awal sudah ada yang memakai.\r\nSilahkan ganti dengan yang lain", -2);
			if (cekNomorSampai && uow.FindObject<NomorSeriPajak>(new BinaryOperator(nameof(NomorSeriPajak.NomorSampai), obj.NomorSampai, BinaryOperatorType.Equal)) != null)
				throw new Utils.Exception("Nomor faktur akhir sudah ada yang memakai.\r\nSilahkan ganti dengan yang lain", -3);

			return true;
		}

		protected internal override void SaveAction(NomorSeriPajak obj) {
			// Delete detail
			for (var i = obj.Detail.Count - 1; i >= 0; i--) {
				var detail = obj.Detail[i];
				var find = obj.DetailForSave.Find(f => f.NomorSeriFaktur == detail.NomorSeriFaktur);
				if (find == null) { obj.Detail.Remove(detail); detail.Delete(); }
			}

			// Insert Update
			foreach (var detail in obj.DetailForSave) {
				var find = obj.Detail.ToList().Find(f => f.NomorSeriFaktur == detail.NomorSeriFaktur);
				if (find == null) find = new NomorSeriPajakDetail(uow) { Main = obj, NomorSeriFaktur = detail.NomorSeriFaktur };
				find.Keterangan = detail.Keterangan;
			}
		}
		internal static NomorSeriPajak GetItem(NomorSeriPajak obj) {
			var listPPn = new XPQuery<PPnKeluaran>(obj.Session).Where(w => w.NomorSeriValid != null && w.NomorSeriValid.Main == obj).ToList();
			
			List<NomorSeriPajakDetailForSave> temp = new List<NomorSeriPajakDetailForSave>();
			foreach (var det in obj.Detail) {
				temp.Add(new NomorSeriPajakDetailForSave() {
					Id = det.Id,
					NomorSeriFaktur = det.NomorSeriFaktur,
					Keterangan = det.Keterangan,
					Terpakai = listPPn.Find(f => f.NomorSeriValid == det) != null
				});
			}

			obj.DetailForSave = temp;
			return obj;
		}
	}

	public class PPnKeluaranService : ServiceBase<PPnKeluaran> {
		public PPnKeluaranService(UnitOfWork connection) : base(connection) { }
		public PPnKeluaranService(UnitOfWork connection, PPnKeluaran originalDataEdit) : base(connection, originalDataEdit) { }

		protected internal override bool CheckBeforeDelete(PPnKeluaran obj) { return CheckDataBeforeDeleted(obj, ModuleId.TaxManagement); }
		protected internal override bool CheckBeforeSave(PPnKeluaran obj) { return CheckDataBeforeSave(uow, obj, _dataOriginalEdit); }
		protected internal override void SaveAction(PPnKeluaran obj) { SaveDataPrivate(uow, obj, _dataOriginalEdit, ModuleId.TaxManagement); }

		private static bool CheckDataBeforeDeleted(PPnKeluaran obj, ModuleId modulesId) {
			if (obj.StatusFaktur != EFakturStatus.Edit) throw new Utils.Exception(string.Format("FP {0} tidak bisa dihapus, karena status nya bukan edit.", obj.NomorSeri));
			if (obj.ModuleId != modulesId) throw new Utils.Exception(string.Format("Data {0} tidak bisa dihapus, karena harus dari module " + obj.ModuleId.ToString(), obj.NomorSeri));

			return true;
		}
		private static bool CheckDataBeforeSave(UnitOfWork session, PPnKeluaran obj, PPnKeluaran originalEdit) {
			if (obj.Tanggal == default) throw new Utils.Exception("Masukkan tanggal", -1);
			if (string.IsNullOrEmpty(obj.NamaPelanggan)) throw new Utils.Exception("Masukkan nama pelanggan", -2);
			if (string.IsNullOrEmpty(obj.AlamatPelanggan)) throw new Utils.Exception("Masukkan alamat pelanggan", -3);
			if (string.IsNullOrEmpty(obj.NPWPPelanggan)) throw new Utils.Exception("Masukkan npwp pelanggan", -4);
			if (string.IsNullOrEmpty(obj.NomorInvoice)) throw new Utils.Exception("Masukkan nomor invoice", -5);
			if (obj.Regional == null) throw new Utils.Exception("Masukkan regional", -6);
			if (obj.PPnPersen == default) throw new Utils.Exception("Masukkan prosentase pajak", -7);
			if (obj.PPnNominal == default) throw new Utils.Exception("Masukkan nominal pajak", -8);
			if (obj.DetailForSave.Sum(s => s.Subtotal) == default) throw new Utils.Exception("Masukkan nominal pajak", -99);

			// check no seri
			if (!session.IsNewObject(obj) && ((originalEdit.KodeStatus + originalEdit.NomorSeri) == (obj.KodeStatus + obj.NomorSeri))) return true;
			if (!string.IsNullOrEmpty(obj.NomorSeri) &&
				session.FindObject<PPnKeluaran>(
					new GroupOperator(GroupOperatorType.And,
					new BinaryOperator(nameof(PPnKeluaran.KodeStatus), obj.KodeStatus, BinaryOperatorType.Equal),
					new BinaryOperator(nameof(PPnKeluaran.NomorSeri), obj.NomorSeri, BinaryOperatorType.Equal))
				) != null)
				throw new Utils.Exception("No. seri faktur pajak sudah ada yang memakai.\r\nSilahkan ganti no. seri yang lain", -100);

			return true;
		}
		private static void SaveDataPrivate(UnitOfWork session, PPnKeluaran obj, PPnKeluaran originalEdit, ModuleId moduleId) {
			bool setNomorSeri = false;

			if (session.IsNewObject(obj)) {
				// Default value
				var settingPajak = new TaxSetting(session);

				if (string.IsNullOrEmpty(obj.KodeTransaksi)) obj.KodeTransaksi = "01";
				obj.KodeStatus = "0";				
				obj.StatusFaktur = EFakturStatus.Edit;
				obj.NamaPerusahaan = settingPajak.PerusahaanNama;
				obj.AlamatPerusahaan = settingPajak.PerusahaanAlamat;
				obj.NPWPPerusahaan = settingPajak.PerusahaanNPWP;
				obj.TanggalPKPPerusahaan = settingPajak.PerusahaanTglPKP;
				obj.ModuleId = moduleId;
				setNomorSeri = true;
			}
			obj.NamaRegional = obj.Regional.Id.Nama;
			obj.TtdNama = obj.Regional.TtdNama;
			obj.TtdJabatan = obj.Regional.TtdJabatan;
			if (!session.IsNewObject(obj) && obj.Tanggal.Year != originalEdit.Tanggal.Year) setNomorSeri = true;
			if (setNomorSeri) obj.NomorSeri = GetNomorDummy(session, obj.Tanggal);

			// Delete detail
			for (var i = obj.Detail.Count - 1; i >= 0; i--) {
				var detail = obj.Detail[i];
				var find = obj.DetailForSave.Find(f => f.ReferensiId == detail.ReferensiId);
				if (find == null) { obj.Detail.Remove(detail); detail.Delete(); }
			}
			// Insert Update
			foreach (var detail in obj.DetailForSave) {
				var find = obj.Detail.ToList().Find(f => f.ReferensiId == detail.ReferensiId);
				if (find == null) find = new PPnKeluaranDetail(session) { Main = obj, ReferensiId = detail.ReferensiId };
				find.Qty = detail.Qty == 0 ? 1 : detail.Qty;
				find.Harga = detail.Harga;
				find.Diskon = detail.Diskon;
				find.Nama = detail.Nama;
				find.Keterangan = detail.Keterangan;
			}
		}
		private static string GetNomorDummy(UnitOfWork session, DateTime tanggal) {
			var nomorTerakhir = 0;
			var listTerakhir = new XPQuery<PPnKeluaran>(session).Where(w => w.Tanggal.Year == tanggal.Year && w.NomorSeriValid == null)
				.OrderByDescending(o => o.NomorSeri).Take(1).SingleOrDefault();
			if (listTerakhir != null) {
				var splitted = listTerakhir.NomorSeri.Split('.');
				nomorTerakhir = int.Parse(splitted[1]);
			}

			return "000-" + tanggal.ToString("yy") + "." + (nomorTerakhir + 1).ToString("00000000");
		}

		public static void SaveData(UnitOfWork session, PPnKeluaran obj, PPnKeluaran originalEdit, ModuleId moduleId) {
			if (CheckDataBeforeSave(session, obj, originalEdit)) SaveDataPrivate(session, obj, originalEdit, moduleId);
		}
		public static PPnKeluaran GetItem(PPnKeluaran obj) {
			List<PPnKeluaranDetailForSave> temp = new List<PPnKeluaranDetailForSave>();
			foreach (var det in obj.Detail) {
				temp.Add(new PPnKeluaranDetailForSave() {
					Id = det.Id,
					Nama = det.Nama,
					Qty = det.Qty,
					Harga = det.Harga,
					Diskon = det.Diskon,
					Keterangan = det.Keterangan,
					ReferensiId = det.ReferensiId
				});
			}

			obj.DetailForSave = temp;
			return obj;
		}

		public static string GetDefaultNPWP() => "00.000.000.0-000.000";
		public static string GetDefaultNoSeri() => "000-00.00000000";
		public static string GetNPWPMask() => @"\d\d\.\d\d\d\.\d\d\d\.\d-\d\d\d\.\d\d\d";
		public static string GetNomorFakturMask() => @"\d\d\d\.\d\d\d-\d\d\.\d\d\d\d\d\d\d\d";

		private static string GetString(string data, bool EOF) {
			if (EOF) return @"""" + data + @"""";
			else return @"""" + data + @""";";
		}
		public static void EksporCSV(UnitOfWork session, string LokasiFile, List<PPnKeluaran> listData) {
			var settingPajak = new TaxSetting(session);

			foreach (var item in listData) {
				if (item.ExportCSV == null) item.ExportCSV = new PPnEksporCsv(session);
				item.ExportCSV.LokasiFile = LokasiFile;

				//		'== FORMAT HEADER == "FK","KD_JENIS_TRANSAKSI","FG_PENGGANTI","NOMOR_FAKTUR","MASA_PAJAK","TAHUN_PAJAK","TANGGAL_FAKTUR","NPWP","NAMA","ALAMAT_LENGKAP","JUMLAH_DPP","JUMLAH_PPN","JUMLAH_PPNBM","ID_KETERANGAN_TAMBAHAN","FG_UANG_MUKA","UANG_MUKA_DPP","UANG_MUKA_PPN","UANG_MUKA_PPNBM","REFERENSI"
				item.ExportCSV.CSV = GetString("FK", false);                         //'== Flag
				item.ExportCSV.CSV += GetString(item.KodeTransaksi, false); //'== KD_JENIS_TRANSAKSI
				item.ExportCSV.CSV += GetString(item.KodeStatus, false); //'== FG_PENGGANTI
				item.ExportCSV.CSV += GetString(item.NomorSeri.Replace(".", "").Replace("-", ""), false); //  '== NOMOR_FAKTUR
				item.ExportCSV.CSV += GetString(item.Tanggal.Month.ToString(), false); //         '== MASA_PAJAK
				item.ExportCSV.CSV += GetString(item.Tanggal.Year.ToString(), false); //          '== TAHUN_PAJAK
				item.ExportCSV.CSV += GetString(item.Tanggal.ToString("dd/MM/yyyy"), false); // '== TANGGAL_FAKTUR
				item.ExportCSV.CSV += GetString(item.NPWPPelanggan.Replace(".", "").Replace("-", ""), false); // '== NPWP
				item.ExportCSV.CSV += GetString(item.NamaPelanggan, false); //'== NAMA
				item.ExportCSV.CSV += GetString(item.AlamatPelanggan, false); //'== ALAMAT_LENGKAP
				item.ExportCSV.CSV += GetString(item.Dpp.ToString("f0"), false); //'== JUMLAH_DPP
				item.ExportCSV.CSV += GetString(item.PPnNominal.ToString("f0"), false); //'== JUMLAH_PPN
				item.ExportCSV.CSV += GetString("0", false); //'== JUMLAH_PPNBM
				item.ExportCSV.CSV += item.KodeTransaksi == "07" ? GetString("6", false) : GetString("", false); //'== ID_KETERANGAN_TAMBAHAN
				item.ExportCSV.CSV += GetString("0", false); //'== FG_UANG_MUKA
				item.ExportCSV.CSV += GetString("0", false); //'== UANG_MUKA_DPP
				item.ExportCSV.CSV += GetString("0", false); //'== UANG_MUKA_PPN
				item.ExportCSV.CSV += GetString("0", false); //'== UANG_MUKA_PPNBM
				if (settingPajak.TampilkanNoInvoice)
					item.ExportCSV.CSV += GetString("NOMOR INVOICE : " + item.NomorInvoice + (string.IsNullOrEmpty(item.NIKPelanggan) ? "" : " | NIK : ") + item.NIKPelanggan, true); //'== REFERENSI
				else
					item.ExportCSV.CSV += GetString("", true); //'== REFERENSI
				item.ExportCSV.CSV += "\r\n"; // Ganti Baris

				//		'== FORMAT DETAIL == "OF","KODE_OBJEK","NAMA","HARGA_SATUAN","JUMLAH_BARANG","HARGA_TOTAL","DISKON","DPP","PPN","TARIF_PPNBM","PPNBM"
				string nama = "";
				int j = 0;
				foreach (var det in item.Detail) {
					j++;
					item.ExportCSV.CSV += GetString("OF", false); // '== Flag
					item.ExportCSV.CSV += GetString("", false); // '== KODE_OBJEK
					nama = det.Nama.Replace(@"""", " ").Replace("\r\n", " "); //.Replace(String.ChrW(31), "");
																																		//			'For vv = 0 To nama.Length - 1
																																		//			'	MsgBox(nama.Chars(vv) & " --" & Asc(nama.Chars(vv)))
																																		//			'Next
					item.ExportCSV.CSV += nama.Length >= 254 ? GetString(nama.Substring(0, 254), false) : GetString(nama, false); //'== NAMA
					item.ExportCSV.CSV += GetString(det.Harga.ToString("f0"), false); // '== HARGA_SATUAN
					item.ExportCSV.CSV += GetString(det.Qty.ToString("f0"), false); //'== JUMLAH_BARANG
					item.ExportCSV.CSV += GetString(det.Subtotal.ToString("f0"), false); //'== HARGA_TOTAL
					item.ExportCSV.CSV += GetString(det.Diskon.ToString("f0"), false); //'== DISKON
					item.ExportCSV.CSV += GetString((det.Subtotal - det.Diskon).ToString("f0"), false); //'== DPP
					item.ExportCSV.CSV += GetString((((det.Subtotal - det.Diskon) * item.PPnPersen) / 100).ToString("f0"), false); //  '== PPN
					item.ExportCSV.CSV += GetString("0", false); //'== TARIF_PPNBM
					item.ExportCSV.CSV += GetString("0", true); //'== PPNBM
				}

				item.StatusFaktur = EFakturStatus.ExportCSV;
			}
			session.CommitChanges();

			var csvBody = new List<string>();
			//	=== Create header
			for (int i = 0; i <= 2; i++) csvBody.Add("");
			csvBody.AddRange(listData.Select(s => s.ExportCSV.CSV));

			File.WriteAllLines(LokasiFile, csvBody);
		}
		public static void Approval(UnitOfWork session, string LokasiFile, PPnKeluaran data) {
			var fileInfo = new FileInfo(LokasiFile);
			if (fileInfo.Length > 1024000) throw new Exception("Ukuran max file yang diupload adalah 1024 KB.\r\nUkuran file '" + LokasiFile + "' adalah " + fileInfo.Length / 1000 + " KB.");

			if (data.ApprovalPDF == null) data.ApprovalPDF = new PPnApprovalPdf(session);
			data.ApprovalPDF.LokasiFile = LokasiFile;
			data.ApprovalPDF.PDF = Utils.Binary.ConvertToBinary(LokasiFile);
			data.StatusFaktur = EFakturStatus.Approval;

			session.CommitChanges();
		}
		public static void FPBatalPengganti(UnitOfWork session, List<PPnKeluaran> listData, bool isBatal) {
			// edit fp lama dengan nomor fp baru status Edit
			foreach (var data in listData) {
				data.OldKodeStatus = data.KodeStatus;
				data.OldNomorSeri = data.NomorSeri;
				data.OldNomorSeriValid = data.NomorSeriValid;
				data.OldExportCSV = data.ExportCSV;
				data.OldApprovalPDF = data.ApprovalPDF;

				data.StatusFaktur = EFakturStatus.Edit;
				if (isBatal) { // ganti nomor seri baru
					data.NomorSeriValid = new XPQuery<NomorSeriPajakDetail>(session).Where(w =>
						w.Main.TanggalMulaiBerlaku.Year == data.Tanggal.Year &&
						w.Main.TanggalMulaiBerlaku.Date <= data.Tanggal.Date && !w.Terpakai)
					.OrderBy(o => o.NomorSeriFaktur).Take(1).SingleOrDefault();

					if (data.NomorSeriValid == null) throw new Exception("Nomor seri faktur habis");
					data.NomorSeri = data.NomorSeriValid.NomorSeriFaktur;
					data.KodeStatus = "0";
				}
				else { // pengganti
					data.KodeStatus = "1";
				}
				data.ExportCSV = null;
				data.ApprovalPDF = null;
			}
			session.CommitChanges();

			// buat fp baru dengan nomor fp lama status FPBatal / FP Pengganti
			foreach (var data in listData) {
				var fpbatal = new PPnKeluaran(session) {
					StatusFaktur = isBatal ? EFakturStatus.FPDiBatalkan : EFakturStatus.FPDiganti,
					KodeTransaksi = data.KodeTransaksi,
					KodeStatus = data.OldKodeStatus,
					NomorSeri = data.OldNomorSeri,
					NamaPerusahaan = data.NamaPerusahaan,
					AlamatPerusahaan = data.AlamatPerusahaan,
					NPWPPerusahaan = data.NPWPPerusahaan,
					TanggalPKPPerusahaan = data.TanggalPKPPerusahaan,
					NamaPelanggan = data.NamaPelanggan,
					AlamatPelanggan = data.AlamatPelanggan,
					NPWPPelanggan = data.NPWPPelanggan,
					NIKPelanggan = data.NIKPelanggan,
					NomorInvoice = data.NomorInvoice,
					Tanggal = data.Tanggal,
					UangMuka = data.UangMuka,
					PPnPersen = data.PPnPersen,
					PPnNominal = data.PPnNominal,
					Regional = data.Regional,
					NamaRegional = data.NamaRegional,
					TtdNama = data.TtdNama,
					TtdJabatan = data.TtdJabatan,
					NomorSeriValid = data.OldNomorSeriValid,
					ExportCSV = data.OldExportCSV,
					ApprovalPDF = data.OldApprovalPDF,
					ModuleId = data.ModuleId
				};
				foreach (var det in data.Detail) {
					new PPnKeluaranDetail(session) {
						Main = fpbatal,
						Nama = det.Nama,
						Qty = det.Qty,
						Harga = det.Harga,
						Diskon = det.Diskon,
						Keterangan = det.Keterangan						
					};
				}
			}
			session.CommitChanges();
		}
	}
}
