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
	internal class ShiftService : ServiceBase<Shift>{
		public ShiftService(UnitOfWork connection) : base(connection) { }
		public ShiftService(UnitOfWork connection, Shift originalDataEdit) : base(connection, originalDataEdit) { }

		protected internal override bool CheckBeforeDelete(Shift obj){
			return true;
		}
		protected internal override bool CheckBeforeSave(Shift obj) {
			//if (obj.Rute == null) throw new Utils.Exception("Masukkan rute", -1);
			//if (string.IsNullOrEmpty(obj.Kode)) throw new Utils.Exception("Masukkan kode agen", -2);
			//if (string.IsNullOrEmpty(obj.Nama)) throw new Utils.Exception("Masukkan nama agen", -3);
			//if (string.IsNullOrEmpty(obj.KodePelanggan)) throw new Utils.Exception("Masukkan kode di pelanggan", -4);
			//if (string.IsNullOrEmpty(obj.NPWP)) throw new Utils.Exception("Masukkan npwp agen.\r\nJika tidak punya, masukkan " + PPnKeluaranService.GetDefaultNPWP(), -5);

			//if (!uow.IsNewObject(obj) && _dataOriginalEdit.Kode == obj.Kode) return true;
			//if (uow.FindObject<Agen>(new BinaryOperator(nameof(Agen.Kode), obj.Kode, BinaryOperatorType.Equal)) != null)
			//	throw new Utils.Exception("Kode agen sudah ada yang memakai.\r\nSilahkan ganti kode yang lain", -2);

			return true;
		}
		protected internal override void SaveAction(Shift obj) {

		}
	}
	internal class DivisiService : ServiceBase<Divisi>	{
		public DivisiService(UnitOfWork connection) : base(connection) { }
		public DivisiService(UnitOfWork connection, Divisi originalDataEdit) : base(connection, originalDataEdit) { }

		protected internal override bool CheckBeforeDelete(Divisi obj)	{
			return true;
		}
		protected internal override bool CheckBeforeSave(Divisi obj)	{
			//if (obj.Rute == null) throw new Utils.Exception("Masukkan rute", -1);
			//if (string.IsNullOrEmpty(obj.Kode)) throw new Utils.Exception("Masukkan kode agen", -2);
			//if (string.IsNullOrEmpty(obj.Nama)) throw new Utils.Exception("Masukkan nama agen", -3);
			//if (string.IsNullOrEmpty(obj.KodePelanggan)) throw new Utils.Exception("Masukkan kode di pelanggan", -4);
			//if (string.IsNullOrEmpty(obj.NPWP)) throw new Utils.Exception("Masukkan npwp agen.\r\nJika tidak punya, masukkan " + PPnKeluaranService.GetDefaultNPWP(), -5);

			//if (!uow.IsNewObject(obj) && _dataOriginalEdit.Kode == obj.Kode) return true;
			//if (uow.FindObject<Agen>(new BinaryOperator(nameof(Agen.Kode), obj.Kode, BinaryOperatorType.Equal)) != null)
			//	throw new Utils.Exception("Kode agen sudah ada yang memakai.\r\nSilahkan ganti kode yang lain", -2);

			return true;
		}
		protected internal override void SaveAction(Divisi obj)	{

		}
	}

}
