﻿using DevExpress.Data.Filtering;
using DevExpress.Xpo;
using DevExpress.Xpo.DB;
using NuSoft.NPO;
using NuSoft.NUI.Win.Forms.Modules.NuSoft011.Persistent;
using System;
using System.Collections.Generic;
using System.Linq;

namespace NuSoft.NUI.Win.Forms.Modules.NuSoft011.Services {
	internal class NomorService {
		public const string KodeFormatTahun4 = "[Y4]";
		public const int KodeFormatTahun4Length = 4;
		public const string KodeFormatTahun2 = "[Y2]";
		public const int KodeFormatTahun2Length = 2;
		public const string KodeFormatBulan0 = "[M0]";
		public const int KodeFormatBulan0Length = 2;
		public const string KodeFormatBulanRomawi = "[Mr]";
		public const int KodeFormatBulanRomawiLength = 4;
		public const string KodeFormatAngka = "[X{0}]";
		public const string MaskAngka = "\\d";

		public static string IntToRoman(int number) {
			if ((number < 0) || (number > 3999)) throw new ArgumentOutOfRangeException("insert value betwheen 1 and 3999");
			if (number < 1) return string.Empty;
			if (number >= 1000) return "M" + IntToRoman(number - 1000);
			if (number >= 900) return "CM" + IntToRoman(number - 900);
			if (number >= 500) return "D" + IntToRoman(number - 500);
			if (number >= 400) return "CD" + IntToRoman(number - 400);
			if (number >= 100) return "C" + IntToRoman(number - 100);
			if (number >= 90) return "XC" + IntToRoman(number - 90);
			if (number >= 50) return "L" + IntToRoman(number - 50);
			if (number >= 40) return "XL" + IntToRoman(number - 40);
			if (number >= 10) return "X" + IntToRoman(number - 10);
			if (number >= 9) return "IX" + IntToRoman(number - 9);
			if (number >= 5) return "V" + IntToRoman(number - 5);
			if (number >= 4) return "IV" + IntToRoman(number - 4);
			if (number >= 1) return "I" + IntToRoman(number - 1);
			throw new ArgumentOutOfRangeException("something bad happened");
		}
		public static string DuplicateString(string value, int count) {
			string result = "";
			for (int i = 1; i <= count; i++) result += value;
			return result;
		}
		public static int CountSameString(string source, string separator) {
			var d = source.Split(new string[] { separator }, StringSplitOptions.None);
			return d.GetUpperBound(0);
		}
		public static string CombineNomor(string mask, int xcount, int value) {
			var formatInt = new string('0', xcount);
			var ookk = DuplicateString(MaskAngka, xcount);

			return mask.Replace(ookk, value.ToString(formatInt));
		}
		public static int HitungPanjangFormatNomor(string format) {
			int result = 0;

			for (int i = 1; i <= 9; i++) {
				if (format.Contains(string.Format(KodeFormatAngka, i))) {
					result += i;
					format = format.Replace(string.Format(KodeFormatAngka, i), "");
					break;
				}
			}

			if (format.Contains(KodeFormatBulan0)) { result += KodeFormatBulan0Length; format = format.Replace(KodeFormatBulan0, string.Empty); }
			if (format.Contains(KodeFormatBulanRomawi)) { result += KodeFormatBulanRomawiLength; format = format.Replace(KodeFormatBulanRomawi, string.Empty); }
			if (format.Contains(KodeFormatTahun2)) { result += KodeFormatTahun2Length; format = format.Replace(KodeFormatTahun2, string.Empty); }
			if (format.Contains(KodeFormatTahun4)) { result += KodeFormatTahun4Length; format = format.Replace(KodeFormatTahun4, string.Empty); }

			//if (format.Contains(KodeFormatAkun)) { result += KodeFormatAkunLength; format = format.Replace(KodeFormatAkun, string.Empty); }
			//if (format.Contains(KodeFormatSumber)) { result += KodeFormatSumberLength; format = format.Replace(KodeFormatSumber, string.Empty); }
			//if (format.Contains(KodeFormatRegional)) { result += KodeFormatRegionalLength; format = format.Replace(KodeFormatRegional, string.Empty); }
			//if (format.Contains(KodeFormatWilayah)) { result += KodeFormatWilayahLength; format = format.Replace(KodeFormatWilayah, string.Empty); }
			//if (format.Contains(KodeFormatJenisIklan)) { result += KodeFormatJenisIklanLength; format = format.Replace(KodeFormatJenisIklan, string.Empty); }

			result += format.Length;
			return result;
		}

		private static string GetGeneralMaskNomor(string format, DateTime tanggal) {
			if (format.Contains(KodeFormatTahun2)) format = format.Replace(KodeFormatTahun2, tanggal.ToString("yy"));
			if (format.Contains(KodeFormatTahun4)) format = format.Replace(KodeFormatTahun4, tanggal.ToString("yyyy"));
			if (format.Contains(KodeFormatBulan0)) format = format.Replace(KodeFormatBulan0, tanggal.ToString("MM"));
			if (format.Contains(KodeFormatBulanRomawi)) format = format.Replace(KodeFormatBulanRomawi, IntToRoman(int.Parse(tanggal.ToString("MM"))));

			for (int i = 1; i <= 9; i++) {
				if (format.Contains(string.Format(KodeFormatAngka, i))) {
					format = format.Replace(string.Format(KodeFormatAngka, i), DuplicateString(MaskAngka, i));
					break;
				}
			}

			return format;
		}
		private static string GetNomorGeneral<T>(UnitOfWork session, string maskNomor, string namaField, bool berurutan) {
			int banyakDigit = CountSameString(maskNomor, MaskAngka);
			string formatDigit = DuplicateString(MaskAngka, banyakDigit);
			string formatCriteria = maskNomor.Replace(formatDigit, "");

			// lihat posisi urutan
			var posisiNomor = maskNomor.IndexOf(formatDigit);
			// === ambil nomor terakhir
			CriteriaOperator criteria;
			if (posisiNomor == 0) {  // nomornya diawal
				criteria = new FunctionOperator(FunctionOperatorType.EndsWith, new OperandProperty(namaField), new OperandValue(formatCriteria));
			}
			else if (maskNomor.Length == posisiNomor + formatDigit.Length) { // nomornya di akhir
				criteria = new FunctionOperator(FunctionOperatorType.StartsWith, new OperandProperty(namaField), new OperandValue(formatCriteria));
			}
			else { // nomornya ditengah
				var filterAwal = maskNomor.Substring(0, posisiNomor);
				var filterAkhir = maskNomor.Substring(posisiNomor + formatDigit.Length);
				criteria = new GroupOperator(GroupOperatorType.And,
					new FunctionOperator(FunctionOperatorType.StartsWith, new OperandProperty(namaField), new OperandValue(filterAwal)),
					new FunctionOperator(FunctionOperatorType.EndsWith, new OperandProperty(namaField), new OperandValue(filterAkhir))
					);
			}
			var sort = new SortProperty(namaField, SortingDirection.Descending);
			var dataTerakhir = new XPCollection<T>(session, criteria, sort);
			dataTerakhir.DisplayableProperties = namaField;

			if (dataTerakhir.Count < 1) return CombineNomor(maskNomor, banyakDigit, 1);
			else {
				var x = (NPOBase)(object)dataTerakhir[0];
				var angkaTerakhir = int.Parse(x.ClassInfo.GetMember(namaField).GetValue(x).ToString().Substring(posisiNomor, banyakDigit));
				if (berurutan)
					return CombineNomor(maskNomor, banyakDigit, angkaTerakhir + 1);
				else {
					// list angka
					List<int> listData = new List<int>();
					//string message = "";
					foreach (var zz in dataTerakhir) {
						//message += int.Parse(((BaseEntity)(object)zz).ClassInfo.GetMember(namaField).GetValue(zz).ToString().Substring(posisiNomor, banyakDigit)).ToString() + "\r\n";
						listData.Add(int.Parse(((NPOBase)(object)zz).ClassInfo.GetMember(namaField).GetValue(zz).ToString().Substring(posisiNomor, banyakDigit)));
					}
					var vale = Enumerable.Range(1, angkaTerakhir).Except(listData).ToList();
					if (vale.Count > 0) return CombineNomor(maskNomor, banyakDigit, vale[0]);
					else return CombineNomor(maskNomor, banyakDigit, angkaTerakhir + 1);
				}
			}
		}

		public static string GetMaskNomorPemasaran(UnitOfWork session, SirkulasiSetting setting, int jenisFormat, DateTime tanggal) {
			if (setting == null) setting = new SirkulasiSetting(session);
			var format = "";
			if (jenisFormat == 1) format = setting.FormatNomorPembayaran;

			return GetGeneralMaskNomor(format, tanggal);
		}
		public static string GetNomorPembayaranPemasaran(UnitOfWork session, DateTime tanggal) {
			string mask = GetMaskNomorPemasaran(session, null, 1, tanggal);
			return GetNomorGeneral<BayarKoran>(session, mask, nameof(BayarKoran.Kode), true);
		}
	}
}