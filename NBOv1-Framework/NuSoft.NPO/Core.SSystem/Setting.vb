Imports DevExpress.Xpo
Imports DevExpress.Data.Filtering
Imports System.ComponentModel

Namespace NuSoft.Core.SSystem
  Public MustInherit Class SettingBase
    Private _sesi As DevExpress.Xpo.UnitOfWork

    Sub New(ByVal session As DevExpress.Xpo.UnitOfWork)
      _sesi = session
      Load()
    End Sub

    Sub Load()
      Dim data As New DevExpress.Xpo.XPCollection(Of NPO.SSystem.Setting)(_sesi)

      If data.Count > 0 Then
        Dim properties As PropertyDescriptorCollection = TypeDescriptor.GetProperties(Me)
        Dim propName As String

        For Each prop As PropertyDescriptor In properties
          propName = prop.Name
          If Not data.ToList.Find(Function(m) m.Kode = propName) Is Nothing Then
            prop.SetValue(Me, Convert.ChangeType(data.ToList.Find(Function(m) m.Kode = propName).Isi, prop.PropertyType))
          End If
        Next
      End If
    End Sub
    Function Save() As Boolean
      Dim properties As PropertyDescriptorCollection = TypeDescriptor.GetProperties(Me)
      Dim obj As NPO.SSystem.Setting

      Try
        For Each prop As PropertyDescriptor In properties
          obj = _sesi.FindObject(Of NPO.SSystem.Setting)(DevExpress.Data.Filtering.CriteriaOperator.Parse(String.Format("Kode='{0}'", prop.Name)))
          If obj Is Nothing Then
            obj = New NPO.SSystem.Setting(_sesi)
            obj.Kode = prop.Name
          End If

          If prop.GetValue(Me) Is Nothing Then
            obj.Isi = ""
          Else
            obj.Isi = prop.GetValue(Me).ToString
          End If
          obj.Save()
        Next
        _sesi.CommitChanges()
        Return True
      Catch ex As Exception
        Throw New Exception(ex.Message, ex.InnerException)
        Return False
      End Try
    End Function
  End Class

  Public Class FrameworkSetting
    Inherits SettingBase

    Property LayoutLaporanTerpisah As Boolean

    Sub New(ByVal session As DevExpress.Xpo.UnitOfWork)
      MyBase.New(session)
    End Sub
  End Class
End Namespace