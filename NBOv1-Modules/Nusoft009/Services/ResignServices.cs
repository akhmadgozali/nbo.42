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
	internal class ResignServices : ServiceBase<Resign>
	{
		public ResignServices(UnitOfWork connection) : base(connection) { }
		public ResignServices(UnitOfWork connection, Resign originalDataEdit) : base(connection, originalDataEdit) { }

		protected internal override bool CheckBeforeDelete(Resign obj)
		{
			return true;
		}
		protected internal override bool CheckBeforeSave(Resign obj)
		{
			if (obj.Tanggal == null) throw new Utils.Exception("Masukkan tanggal resign", -1);
			if (obj.Karyawan == null) throw new Utils.Exception("Masukkan karyawan", -2);
			return true;
		}
		protected internal override void SaveAction(Resign obj)
		{

		}


	}
}
