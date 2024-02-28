Namespace NuSoft.Core.Win.Component
  Public Class XtraLookUpEdit
    Shared Function GetFirstValue(lookUp As DevExpress.XtraEditors.LookUpEdit) As Object
      Return lookUp.Properties.GetDataSourceValue(lookUp.Properties.ValueMember, 0)
    End Function
    Shared Function GetLastValue(lookUp As DevExpress.XtraEditors.LookUpEdit) As Object
      Return lookUp.Properties.GetDataSourceValue(lookUp.Properties.ValueMember, CType(lookUp.Properties.DataSource, IList).Count - 1)
    End Function
    Shared Function GetValue(lookUp As DevExpress.XtraEditors.LookUpEdit, fieldName As String) As Object
      Return lookUp.Properties.GetDataSourceValue(fieldName, lookUp.Properties.GetDataSourceRowIndex(fieldName, lookUp.EditValue))
    End Function
    Shared Function GetValue(lookUp As DevExpress.XtraEditors.LookUpEdit, fieldName As String, value As Object) As Object
      Return lookUp.Properties.GetDataSourceValue(fieldName, lookUp.Properties.GetDataSourceRowIndex(fieldName, value))
    End Function
  End Class
End Namespace