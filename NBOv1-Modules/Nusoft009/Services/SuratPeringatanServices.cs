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
	internal class SuratPeringatanServices : ServiceBase<SuratPeringatan>
	{
		public SuratPeringatanServices(UnitOfWork connection) : base(connection) { }
		public SuratPeringatanServices(UnitOfWork connection, SuratPeringatan originalDataEdit) : base(connection, originalDataEdit) { }

		protected internal override bool CheckBeforeDelete(SuratPeringatan obj)
		{
			return true;
		}
		protected internal override bool CheckBeforeSave(SuratPeringatan obj)
		{
			if (obj.Tanggal == null) throw new Utils.Exception("Masukkan tanggal absensi", -1);
			if (obj.Karyawan == null) throw new Utils.Exception("Masukkan karyawan", -2);
			return true;
		}
		protected internal override void SaveAction(SuratPeringatan obj)
		{
			//if (string.IsNullOrEmpty(obj.Kode)) obj.Kode = NomorService.GetNomorPembayaranPemasaran(uow, obj.Tanggal);
		}
	}
}
