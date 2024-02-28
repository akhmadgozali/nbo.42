Namespace NuSoft.Core.Win.Component
  Public Class XtraNavBar
    Shared Function GroupExists(ByVal navBarControl As DevExpress.XtraNavBar.NavBarControl, ByVal groupName As String) As Boolean
      For Each item As DevExpress.XtraNavBar.NavBarGroup In navBarControl.Groups
        If item.Name = groupName Then
          Return True
        End If
      Next
      Return False
    End Function
  End Class
End Namespace