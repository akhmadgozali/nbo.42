using NuSoft.Core.Win.Forms;
using NuSoft.NPO.Modules;
using NuSoft.NUI.Win.Forms.Modules.NuSoft009.Properties;
using NuSoft.NUI.Win.Forms.Modules.NuSoft009.UILayer.Master;
using NuSoft.NUI.Win.Forms.Modules.NuSoft009.UILayer.Transaksi;
using System;
using System.Drawing;

namespace NuSoft.NUI.Win.Forms.Modules.NuSoft009 {
	public class MainClass {
		public static Image GetSmallImage() => Resources.GaugeStyleHalfCircular_16x16;
		public static Image GetLargeImage() => Resources.GaugeStyleHalfCircular_32x32;
		public static ModuleId GetModuleId() => ModuleId.Operasional;

		private enum eMenuName { 
			Absensi,
			Ijin,
			ApproveIjin,
			LiburPengganti,
			FormCuti,
			RealisasiCuti,
			SuratPerintahKerjaLembur,
			SPKLApp1,
			SPKLApp2,
			FormLembur,
			SuratPeringatan,
			MutasiKaryawan,
			Resign,
			Pinjaman,
			TambahanPotonganPajak,
			TambahanPotonganNonPajak,
			Penggajian,
			Lembur,
			Karyawan,
			Cuti,
			JadwalProduksi,
			JadwalWarehouse,
			DayOff,
			Jabatan,
			Divisi,
			Tarif,
			Permit
		}
		private static eMenuName GetMenu(string menuCode) {
			switch (menuCode) {
				case "0101.01": return eMenuName.Absensi;
				case "0101.02": return eMenuName.Ijin;
				case "0101.03": return eMenuName.ApproveIjin;
				case "0101.04": return eMenuName.LiburPengganti;
				case "0101.05": return eMenuName.FormCuti;
				case "0101.06": return eMenuName.RealisasiCuti;
				case "0101.07": return eMenuName.SuratPerintahKerjaLembur;
				case "0101.08": return eMenuName.SPKLApp1;
				case "0101.09": return eMenuName.SPKLApp2;
				case "0101.10": return eMenuName.FormLembur;
				case "0101.11": return eMenuName.SuratPeringatan;
				case "0101.12": return eMenuName.MutasiKaryawan;
				case "0101.13": return eMenuName.Resign;
				case "0101.14": return eMenuName.Pinjaman;
				case "0101.15": return eMenuName.TambahanPotonganPajak;
				case "0101.16": return eMenuName.TambahanPotonganNonPajak;
				case "0101.17": return eMenuName.Penggajian;
				case "0102.01": return eMenuName.Lembur;
				case "0103.01": return eMenuName.Karyawan;
				case "0103.02": return eMenuName.Cuti;
				case "0103.03": return eMenuName.JadwalProduksi;
				case "0103.04": return eMenuName.JadwalWarehouse;
				case "0103.05": return eMenuName.DayOff;
				case "0103.06": return eMenuName.Jabatan;
				case "0103.07": return eMenuName.Divisi;
				case "0103.08": return eMenuName.Tarif;
				case "0103.09": return eMenuName.Permit;

				default: throw new NotImplementedException(); // return default;
			}
		}
		public static NuSoftForm GetForm(string menuCode) {
			switch (GetMenu(menuCode)) {
				case eMenuName.Absensi: return new UI_Absensi();
				case eMenuName.Ijin: return new UI_Ijin();
				//case eMenuName.ApproveIjin: return new UI_Absensi();
				case eMenuName.LiburPengganti: return new UI_LiburPengganti();
				case eMenuName.FormCuti: return new UI_FormCuti();
				case eMenuName.RealisasiCuti: return new UI_RealisasiCuti();
				case eMenuName.SuratPerintahKerjaLembur: return new UI_SPKL();
				//case eMenuName.SPKLApp1:
				//case eMenuName.SPKLApp2:
				case eMenuName.FormLembur:return new UI_FormLembur();
				case eMenuName.SuratPeringatan: return new UI_SuratPeringatan();
				case eMenuName.MutasiKaryawan: return new UI_MutasiKaryawan();
				case eMenuName.Resign: return new UI_Resign();
				case eMenuName.Pinjaman: return new UI_Pinjaman();
				//case eMenuName.TambahanPotonganPajak:
				//case eMenuName.TambahanPotonganNonPajak:
				//case eMenuName.Penggajian:
				//case eMenuName.Lembur:
				case eMenuName.Karyawan: return new UI_Karyawan();
				case eMenuName.Cuti: return new UI_Cuti();
				case eMenuName.JadwalProduksi: return new UI_JadwalProduksi();
				//case eMenuName.JadwalWarehouse:
				case eMenuName.DayOff: return new UI_Dayoff();
				case eMenuName.Jabatan: return new UI_Jabatan();
				case eMenuName.Divisi: return new UI_Divisi();
				//case eMenuName.Tarif:
				//case eMenuName.Permit:
				default: throw new NotImplementedException();
			}
		}

		private enum ReportName {
			Null
		}
		private static ReportName GetReport(string reportCode) {
			switch (reportCode) {
				default: return ReportName.Null;
			}
		}
		public static ReportFilter GetReportFilter(string reportCode) {
			var kode = GetReport(reportCode);
			switch (kode) {
				default: return null;
			}
		}
	}
}
