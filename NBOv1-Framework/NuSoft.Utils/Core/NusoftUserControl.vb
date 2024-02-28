Namespace NuSoft.Core.Win.Forms
  Public Class NuSoftUserControl
    Inherits DevExpress.XtraEditors.XtraUserControl

    Private _namaDatabase As String
    Public Event DatabaseChanged()

    Property NamaDatabase As String
      Get
        Return _namaDatabase
      End Get
      Set(value As String)
        _namaDatabase = value
        RaiseEvent DatabaseChanged()
      End Set
    End Property
  End Class
End Namespace