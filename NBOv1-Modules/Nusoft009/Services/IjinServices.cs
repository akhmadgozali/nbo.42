using NuSoft.NUI.Win.Forms.Modules.NuSoft09.Persistent;
using NuSoft.NUI.Win.Forms.Modules.NuSoft09.Services;
using DevExpress.Data.Filtering;
using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NuSoft.NUI.Win.Forms.Modules.NuSoft009.Services
{
	internal class IjinServices : ServiceBase<Ijin>	{
		public IjinServices(UnitOfWork connection) : base(connection) { }
		public IjinServices(UnitOfWork connection, Ijin originalDataEdit) : base(connection, originalDataEdit) { }

		protected internal override bool CheckBeforeDelete(Ijin obj)	{
			return true;
		}
		protected internal override bool CheckBeforeSave(Ijin obj)		{
			if (obj.Tanggal == null) throw new Utils.Exception("Masukkan tanggal transaksi", -1);
			if (obj.Karyawan == null) throw new Utils.Exception("Masukkan karyawan", -2);
			return true;
		}
		protected internal override void SaveAction(Ijin obj)		{

		}
		public static Ijin GetItem(Ijin obj) {
			List<IjinDetailForSave> temp = new List<IjinDetailForSave>();
			foreach (var det in obj.Detail) {
				temp.Add(new IjinDetailForSave() {
					Id = det.Id,
					Tanggal = det.Tanggal,
					StatusAbsensi = det.StatusAbsensi,
					TanggalPengganti = det.TanggalPengganti,
					Absensi = det.Absensi
				});
			}

			obj.DetailForSave = temp;
			return obj;
		}
		public static List<IjinDetailForSave> GetDetailIjin(UnitOfWork session, DateTime TanggalAwal, DateTime TanggalAkhir, Karyawan Karyawan) {
			var result = new List<IjinDetailForSave>();

			if (TanggalAwal != null && TanggalAkhir != null) {
				TimeSpan timeSpan = TanggalAkhir.Subtract(TanggalAwal);
				int Jumlah = timeSpan.Days;
				for (int i = 0; i <= Jumlah; i++)
				{
					var xtanggal = TanggalAwal.AddDays(i);
					//carikan absensinya untuk karyawan tsb
					var xAbsensi = new XPQuery<Absensi>(session).Where(w=>w.Tanggal == xtanggal && w.Karyawan.Id == Karyawan.Id).FirstOrDefault();
					if (xAbsensi == null) {
						result.Add(new IjinDetailForSave() { Id = (long)i, Tanggal = xtanggal});
					} else {
						result.Add(new IjinDetailForSave() { Id = (long)i, Tanggal = xtanggal, Absensi = xAbsensi, StatusAbsensi = xAbsensi.Status });
					}
					
				}
			}

			return result;
		}


	}
}
