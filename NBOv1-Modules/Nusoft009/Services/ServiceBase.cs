using DevExpress.Xpo;
using NuSoft.NPO;
using System;
using System.Collections.Generic;

namespace NuSoft.NUI.Win.Forms.Modules.NuSoft09.Services
{
	internal abstract class ServiceBase<T> where T : NPOBase
	{
		protected internal UnitOfWork uow;
		protected internal T _dataOriginalEdit;
		protected internal virtual void SaveAction(T obj) { }
		protected internal abstract bool CheckBeforeSave(T obj);
		protected internal abstract bool CheckBeforeDelete(T obj);
		protected internal virtual void BeforeDeleteAction(T obj) { }
		protected internal virtual void AfterDeleteAction(T obj) { }
		protected internal virtual void BeforeDeleteCommit(List<T> objs) { }
		protected internal virtual void AfterDeleteCommit() { }
		protected internal virtual void AfterSaveCommit(T obj) { }

		protected internal ServiceBase(UnitOfWork connection) : this(connection, null) { }
		protected internal ServiceBase(UnitOfWork connection, T dataOriginalEdit) { uow = connection; _dataOriginalEdit = dataOriginalEdit == null ? null : (T)dataOriginalEdit.Clone(); }

		protected internal bool Delete(T obj)
		{
			try
			{
				if (!CheckBeforeDelete(obj)) return false;
				BeforeDeleteAction(obj);
				obj.Delete();
				AfterDeleteAction(obj);
				return true;
			}
			catch (Exception ex) { throw new Exception(ex.Message, ex.InnerException); }
		}
		protected internal bool Delete(List<T> objs)
		{
			try
			{
				var errorMessage = "";
				bool anySuccess = false;
				BeforeDeleteCommit(objs);
				foreach (T obj in objs)
				{
					try { Delete(obj); anySuccess = true; }
					catch (Exception ex) { errorMessage += ex.Message + "\r\n"; }
				}

				if (anySuccess) uow.CommitChanges();
				AfterDeleteCommit();
				if (!string.IsNullOrEmpty(errorMessage)) throw new Exception(errorMessage);

				return true;
			}
			catch (Exception ex) { throw new Exception(ex.Message, ex.InnerException); }
		}
		protected internal bool Save(T obj)
		{
			try
			{
				if (CheckBeforeSave(obj))
				{
					SaveAction(obj);
					uow.CommitChanges();

					AfterSaveCommit(obj);
					return true;
				}
				else { uow.RollbackTransaction(); return false; }
			}
			catch (Utils.Exception ex) { uow.RollbackTransaction(); throw new Utils.Exception(ex.Message, ex.ErrorNumber); }
			catch (Exception ex) { throw new Exception(ex.Message, ex.InnerException); }
		}
	}
}
