Public Class Privileges
  Private _xUm As IEnumerable(Of NPO.SSystem.UserMenu)
  Private _xUr As IEnumerable(Of NPO.SSystem.UserReport)

  ReadOnly Property UserMenu As IEnumerable(Of NPO.SSystem.UserMenu)
    Get
      Return _xUm
    End Get
  End Property
  ReadOnly Property UserReport As IEnumerable(Of NPO.SSystem.UserReport)
    Get
      Return _xUr
    End Get
  End Property

  Sub Load(session As DevExpress.Xpo.UnitOfWork)
    'Dim session As DevExpress.Xpo.UnitOfWork = Data.DbSystem.GetXPOSession
    If Core.SSystem.UserInfo.GetUserLevel = 9 Then
      Dim resultMenu As New DevExpress.Xpo.XPCollection(Of NPO.SSystem.UserMenu)(session, DevExpress.Data.Filtering.CriteriaOperator.Parse("[User.Id]=-99")) ' & Core.SSystem.UserInfo.GetUserId))
      Dim resultReport As New DevExpress.Xpo.XPCollection(Of NPO.SSystem.UserReport)(session, DevExpress.Data.Filtering.CriteriaOperator.Parse("[User.Id]=-99")) ' & Core.SSystem.UserInfo.GetUserId))
      Dim itemM As NPO.SSystem.UserMenu
      Dim itemR As NPO.SSystem.UserReport

      Dim _xDatabase = New DevExpress.Xpo.XPCollection(Of NPO.SSystem.Database)(session)
      Dim _xMenu = New DevExpress.Xpo.XPCollection(Of NPO.SSystem.Menu)(session)
      Dim _xReport = New DevExpress.Xpo.XPCollection(Of NPO.SSystem.Laporan)(session)

      For i = 0 To _xDatabase.Count - 1
        For j = 0 To _xMenu.Count - 1
          itemM = New NPO.SSystem.UserMenu(session)
          itemM.Buka = True
          itemM.Cetak = True
          itemM.Database = _xDatabase(i)
          itemM.Edit = True
          itemM.Eksport = True
          itemM.Hapus = True
          itemM.Id = CInt(_xDatabase(i).Id.ToString("00") & _xMenu(j).Id)
          itemM.Menu = _xMenu(j)
          itemM.Tambah = True
          resultMenu.Add(itemM)
        Next

        For j = 0 To _xReport.Count - 1
          itemR = New NPO.SSystem.UserReport(session)
          itemR.Buka = True
          itemR.Cetak = True
          itemR.Database = _xDatabase(i)
          itemR.Eksport = True
          itemR.Id = CInt(_xDatabase(i).Id.ToString("00") & _xReport(j).Id)
          itemR.Report = _xReport(j)
          resultReport.Add(itemR)
        Next
      Next

      _xUm = From c In resultMenu Select c
      _xUr = From d In resultReport Select d
    Else
      _xUr = New DevExpress.Xpo.XPCollection(Of NPO.SSystem.UserReport)(session, DevExpress.Data.Filtering.CriteriaOperator.Parse("[User.Id]= " & Core.SSystem.UserInfo.GetUserId))
      _xUm = New DevExpress.Xpo.XPCollection(Of NPO.SSystem.UserMenu)(session, DevExpress.Data.Filtering.CriteriaOperator.Parse("[User.Id]= " & Core.SSystem.UserInfo.GetUserId))
    End If
  End Sub
End Class
