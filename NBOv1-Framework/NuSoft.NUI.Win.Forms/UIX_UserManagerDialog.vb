Imports DevExpress.XtraEditors.Controls

Friend Class UIX_UserManagerDialog
  Private xpUser As NPO.SSystem.User
  Private xpUserMenu As DevExpress.Xpo.XPCollection(Of NPO.SSystem.UserMenu)
  Private xpUserReport As DevExpress.Xpo.XPCollection(Of NPO.SSystem.UserReport)
  Private xpUserRegional As DevExpress.Xpo.XPCollection(Of NPO.SSystem.UserRegional)
  Private xpUserDivisi As DevExpress.Xpo.XPCollection(Of NPO.SSystem.UserDivision)
  Private xpMenu As DevExpress.Xpo.XPCollection(Of NPO.SSystem.Menu)
  Private xpReport As DevExpress.Xpo.XPCollection(Of NPO.SSystem.Laporan)
  Private dsMenu As List(Of NPO.NonPersistent.MenuInUser)
  Private dsReport As List(Of NPO.NonPersistent.ReportInUser)
  Private dsRegional As List(Of NPO.NonPersistent.RegionalInUser)
  Private dsDivisi As List(Of NPO.NonPersistent.DivisiInUser)
  Private isPasswordChanged As Boolean = False

  Sub New()
    ' This call is required by the designer.
    InitializeComponent()
    ' Add any initialization after the InitializeComponent() call.
    AutoCloseOnSave = True
    txtWilayahTertentu.Checked = False
    txtDivisiTertentu.Checked = False
    'NPO.SSystem.UserDivision.AutoSaveOnEndEdit = False
    'NPO.SSystem.UserRegional.AutoSaveOnEndEdit = False
  End Sub
  Overrides Sub LoadBeforeInitialize()
    Dim itMenu As NPO.NonPersistent.MenuInUser
    Dim itReport As NPO.NonPersistent.ReportInUser

    dsMenu = New List(Of NPO.NonPersistent.MenuInUser)
    dsReport = New List(Of NPO.NonPersistent.ReportInUser)

    xpMenu = New DevExpress.Xpo.XPCollection(Of NPO.SSystem.Menu)(session)
    For i = 0 To xpMenu.Count - 1
      itMenu = New NPO.NonPersistent.MenuInUser
      itMenu.Menu = xpMenu(i)
      itMenu.MenuId = xpMenu(i).Id
      itMenu.MenuNama = xpMenu(i).Nama
      itMenu.MenuParent = xpMenu(i).Induk
      itMenu.Buka = False
      itMenu.Tambah = False
      itMenu.Edit = False
      itMenu.Hapus = False
      itMenu.Eksport = False
      itMenu.Cetak = False
      dsMenu.Add(itMenu)
    Next

    xpReport = New DevExpress.Xpo.XPCollection(Of NPO.SSystem.Laporan)(session)
    For i = 0 To xpReport.Count - 1
      itReport = New NPO.NonPersistent.ReportInUser
      itReport.Report = xpReport(i)
      itReport.ReportId = xpReport(i).Id
      itReport.ReportNama = xpReport(i).Nama
      itReport.ReportParent = xpReport(i).Induk
      itReport.Buka = False
      itReport.Eksport = False
      itReport.Cetak = False
      dsReport.Add(itReport)
    Next

    treeMenu.DataSource = dsMenu
    treeReport.DataSource = dsReport
    txtHomeMenu.Properties.DataSource = dsMenu

    treeMenu.RefreshDataSource()
    treeReport.RefreshDataSource()

    If Core.SSystem.UserInfo.GetUserLevel = 2 Then
      txtLevel.Properties.Items.RemoveAt(3)
    End If

    txtDashboardId.Properties.MinValue = 0
    txtDashboardId.Properties.MaxValue = Integer.MaxValue
    txtDashboardModul.Properties.DataSource = New DevExpress.Xpo.XPQuery(Of NPO.SSystem.Modul)(session).ToList
  End Sub
  Overrides Sub LoadAfterInitialize()
    If Tipe = InputType.Tambah Then
      xpUserMenu = New DevExpress.Xpo.XPCollection(Of NPO.SSystem.UserMenu)(session, DevExpress.Data.Filtering.ContainsOperator.Parse("User.Id=-99"))
      xpUserReport = New DevExpress.Xpo.XPCollection(Of NPO.SSystem.UserReport)(session, DevExpress.Data.Filtering.ContainsOperator.Parse("User.Id=-99"))
      xpUserRegional = New DevExpress.Xpo.XPCollection(Of NPO.SSystem.UserRegional)(session, DevExpress.Data.Filtering.ContainsOperator.Parse("User.Id=-99"))
      xpUserDivisi = New DevExpress.Xpo.XPCollection(Of NPO.SSystem.UserDivision)(session, DevExpress.Data.Filtering.ContainsOperator.Parse("User.Id=-99"))
      xpUser = New NPO.SSystem.User(session)
    Else
      xpUserMenu = New DevExpress.Xpo.XPCollection(Of NPO.SSystem.UserMenu)(session, DevExpress.Data.Filtering.ContainsOperator.Parse("User.Id=" & IdToEdit.ToString))
      xpUserReport = New DevExpress.Xpo.XPCollection(Of NPO.SSystem.UserReport)(session, DevExpress.Data.Filtering.ContainsOperator.Parse("User.Id=" & IdToEdit.ToString))
      xpUserRegional = New DevExpress.Xpo.XPCollection(Of NPO.SSystem.UserRegional)(session, DevExpress.Data.Filtering.ContainsOperator.Parse("User.Id=" & IdToEdit.ToString))
      xpUserDivisi = New DevExpress.Xpo.XPCollection(Of NPO.SSystem.UserDivision)(session, DevExpress.Data.Filtering.ContainsOperator.Parse("User.Id=" & IdToEdit.ToString))
      xpUser = session.GetObjectByKey(Of NPO.SSystem.User)(CInt(IdToEdit))
      txtUser.Text = xpUser.Kode
      txtNama.Text = xpUser.Nama
      txtPassword.Text = xpUser.Password
      txtLevel.SelectedIndex = xpUser.Level
      txtKeterangan.Text = xpUser.Keterangan
      txtAktif.Checked = xpUser.Aktif
      txtWilayahTertentu.Checked = xpUser.LimitRegional
      txtDivisiTertentu.Checked = xpUser.LimitDivisi
      txtDashboardId.Value = xpUser.DashboardId
      txtDashboardModul.SetEditValue(xpUser.DashboardModul)
      txtHomeMenu.EditValue = xpUser.HomeMenu
    End If

    xTabControl.SelectedTabPage = xTabUser
    txtWilayahTertentu_CheckedChanged(Me, Nothing)
    txtDivisiTertentu_CheckedChanged(Me, Nothing)
  End Sub
  Overrides Sub InitializeData()
    MyBase.InitializeData()
    txtLevel.SelectedIndex = 1
    txtAktif.Checked = True
    txtDashboardModul.EditValue = Nothing
  End Sub
  Overrides Sub SimpanData()
    Dim encryptDES As New Utils.Cryptograph.DES() With {.Key = Core.SSystem.UserInfo.GetUserKey}

    xpUser.Kode = txtUser.Text
    xpUser.Nama = txtNama.Text
    If xpUser.Password <> txtPassword.Text Then
      xpUser.Password = Data.Helper.GetSHA2(session, encryptDES.Encrypt(txtPassword.Text)).ToString
      'xpUser.Password = txtPassword.Text
    End If
    xpUser.Level = CShort(txtLevel.SelectedIndex)
    xpUser.Keterangan = txtKeterangan.Text
    xpUser.Aktif = txtAktif.Checked
    xpUser.LimitRegional = txtWilayahTertentu.Checked
    xpUser.LimitDivisi = txtDivisiTertentu.Checked
    xpUser.DashboardId = CInt(txtDashboardId.Value)
    If Not txtDashboardModul.EditValue Is Nothing Then
      xpUser.DashboardModul = txtDashboardModul.EditValue.ToString
    Else
      xpUser.DashboardModul = Nothing
    End If
    If Not txtHomeMenu.EditValue Is Nothing Then
      xpUser.HomeMenu = CType(txtHomeMenu.EditValue, NPO.SSystem.Menu)
    Else
      xpUser.HomeMenu = Nothing
    End If

    If ValidateData(xpUser) Then
      Try
        'session.BeginTransaction()
        session.Save(xpUser)
        SaveMenuBeforeChanging(txtDbMenu.EditValue)
        SaveReportBeforeChanging(txtDbReport.EditValue)
        SaveRegionalBeforeChanging(txtDbRegional.EditValue)
        SaveDivisiBeforeChanging(txtDbDivisi.EditValue)
        session.Save(xpUserMenu)
        session.Save(xpUserReport)
        session.Save(xpUserRegional)
        session.Save(xpUserDivisi)
        session.CommitTransaction()
      Catch ex As Exception
        session.RollbackTransaction()
        Throw New Utils.Exception(ex.Message)
      End Try
    End If
  End Sub
  Overrides Sub ErrorSimpan(ex As Utils.Exception)
    ex.ShowWinMessageBox()
    Select Case ex.ErrorNumber
      Case 1 : txtUser.Focus()
      Case 2 : txtNama.Focus()
      Case 3 : txtPassword.Focus()
      Case 4 : xTabControl.SelectedTabPage = xTabMenu
      Case 5 : xTabControl.SelectedTabPage = xTabReport
      Case 6 : xTabControl.SelectedTabPage = xTabRegional
      Case 7 : xTabControl.SelectedTabPage = xTabDivisi
      Case Else : txtUser.Focus()
    End Select
  End Sub

  Private Sub xpDb_ResolveSession(ByVal sender As Object, ByVal e As DevExpress.Xpo.ResolveSessionEventArgs) Handles xpDb.ResolveSession
    e.Session = session
  End Sub
  Private Sub txtWilayahTertentu_CheckedChanged(sender As Object, e As System.EventArgs) Handles txtWilayahTertentu.CheckedChanged
    xTabRegional.PageEnabled = txtWilayahTertentu.Checked
  End Sub
  Private Sub txtDivisiTertentu_CheckedChanged(sender As Object, e As System.EventArgs) Handles txtDivisiTertentu.CheckedChanged
    xTabDivisi.PageEnabled = txtDivisiTertentu.Checked
  End Sub
  Private Sub txtPassword_EditValueChanging(sender As Object, e As DevExpress.XtraEditors.Controls.ChangingEventArgs) Handles txtPassword.EditValueChanging
    isPasswordChanged = True
  End Sub

  Private Sub treeMenu_CellValueChanged(sender As Object, e As DevExpress.XtraTreeList.CellValueChangedEventArgs) Handles treeMenu.CellValueChanged
    CheckChildNode(e.Node, e.Column, e.Value)
    CheckParentNode(e.Node, e.Column, e.Value)
  End Sub
  Private Sub treeMenu_CellValueChanging(sender As Object, e As DevExpress.XtraTreeList.CellValueChangedEventArgs) Handles treeMenu.CellValueChanging
    CheckSelectedDatabase(txtDbMenu)
  End Sub
  Private Sub treeReport_CellValueChanged(sender As Object, e As DevExpress.XtraTreeList.CellValueChangedEventArgs) Handles treeReport.CellValueChanged
    CheckChildNode(e.Node, e.Column, e.Value)
    CheckParentNode(e.Node, e.Column, e.Value)
  End Sub
  Private Sub treeReport_CellValueChanging(sender As Object, e As DevExpress.XtraTreeList.CellValueChangedEventArgs) Handles treeReport.CellValueChanging
    CheckSelectedDatabase(txtDbReport)
  End Sub
  Private Sub treeRegional_CellValueChanging(sender As Object, e As DevExpress.XtraTreeList.CellValueChangedEventArgs) Handles treeRegional.CellValueChanging
    CheckSelectedDatabase(txtDbRegional)
  End Sub
  Private Sub treeDivisi_CellValueChanging(sender As Object, e As DevExpress.XtraTreeList.CellValueChangedEventArgs) Handles treeDivisi.CellValueChanging
    CheckSelectedDatabase(txtDbDivisi)
  End Sub
  Private Sub txtDbMenu_EditValueChanging(sender As Object, e As DevExpress.XtraEditors.Controls.ChangingEventArgs) Handles txtDbMenu.EditValueChanging
    SaveMenuBeforeChanging(e.OldValue)
    LoadMenuAfterChanging(e.NewValue)
  End Sub
  Private Sub txtDbReport_EditValueChanging(sender As Object, e As DevExpress.XtraEditors.Controls.ChangingEventArgs) Handles txtDbReport.EditValueChanging
    SaveReportBeforeChanging(e.OldValue)
    LoadReportAfterChanging(e.NewValue)
  End Sub
  Private Sub txtDbRegional_EditValueChanging(sender As Object, e As DevExpress.XtraEditors.Controls.ChangingEventArgs) Handles txtDbRegional.EditValueChanging
    SaveRegionalBeforeChanging(e.OldValue)
    LoadRegionalAfterChanging(e.NewValue)
  End Sub
  Private Sub txtDbDivisi_EditValueChanging(sender As Object, e As DevExpress.XtraEditors.Controls.ChangingEventArgs) Handles txtDbDivisi.EditValueChanging
    SaveDivisiBeforeChanging(e.OldValue)
    LoadDivisiAfterChanging(e.NewValue)
  End Sub

  Private Function CheckSelectedDatabase(cbo As DevExpress.XtraEditors.LookUpEdit) As Boolean
    If cbo.EditValue Is Nothing Then
      Utils.Win.MessageBox.Show("Pilih database terlebih dahulu", Me.Text, "", Utils.Win.MessageBox.Button.OK, Utils.Win.MessageBox.Icon.Peringatan)
      cbo.Focus()
      cbo.SelectAll()
      Return False
    Else
      Return True
    End If
  End Function
  Private Sub CheckChildNode(ByVal node As DevExpress.XtraTreeList.Nodes.TreeListNode, ByVal col As Object, ByVal value As Object)
    For i = 0 To node.Nodes.Count - 1
      node.Nodes(i).SetValue(col, value)
      CheckChildNode(node.Nodes(i), col, value)
    Next
  End Sub
  Private Sub CheckParentNode(ByVal node As DevExpress.XtraTreeList.Nodes.TreeListNode, ByVal col As Object, ByVal value As Object)
    If Not node.ParentNode Is Nothing Then
      Dim b As Boolean = False
      Dim childValue As Object

      For i = 0 To node.ParentNode.Nodes.Count - 1
        childValue = node.ParentNode.Nodes(i).GetValue(col)
        If CBool(childValue) Then
          b = Not b
          Exit For
        End If
      Next

      If b Then
        node.ParentNode.SetValue(col, True)
      Else
        node.ParentNode.SetValue(col, value)
      End If
      CheckParentNode(node.ParentNode, col, value)
    End If
  End Sub
  Private Sub SaveMenuBeforeChanging(value As Object)
    If Not value Is Nothing Then
      Dim newUserMenu As NPO.SSystem.UserMenu
      Dim menu As NPO.SSystem.Menu

      For i = 0 To dsMenu.Count - 1
        menu = dsMenu(i).Menu
        newUserMenu = xpUserMenu.ToList.Find(Function(m) m.Menu Is menu And m.User Is xpUser And m.Database Is value)
        If newUserMenu Is Nothing Then
          newUserMenu = New NPO.SSystem.UserMenu(session)
          newUserMenu.Buka = dsMenu(i).Buka
          newUserMenu.Tambah = dsMenu(i).Tambah
          newUserMenu.Edit = dsMenu(i).Edit
          newUserMenu.Hapus = dsMenu(i).Hapus
          newUserMenu.Eksport = dsMenu(i).Eksport
          newUserMenu.Cetak = dsMenu(i).Cetak
          newUserMenu.Database = CType(value, NPO.SSystem.Database)
          newUserMenu.Menu = menu
          newUserMenu.User = xpUser
          xpUserMenu.Add(newUserMenu)
        Else
          newUserMenu.Buka = dsMenu(i).Buka
          newUserMenu.Tambah = dsMenu(i).Tambah
          newUserMenu.Edit = dsMenu(i).Edit
          newUserMenu.Hapus = dsMenu(i).Hapus
          newUserMenu.Eksport = dsMenu(i).Eksport
          newUserMenu.Cetak = dsMenu(i).Cetak
        End If
      Next
    End If
  End Sub
  Private Sub LoadMenuAfterChanging(value As Object)
    If Not value Is Nothing Then
      For i = 0 To dsMenu.Count - 1
        Dim menu As NPO.SSystem.Menu = dsMenu(i).Menu
        Dim loadUserMenu As NPO.SSystem.UserMenu = xpUserMenu.ToList.Find(Function(m) m.Menu Is menu And m.User Is xpUser And m.Database Is value)
        If loadUserMenu Is Nothing Then
          dsMenu(i).Buka = False
          dsMenu(i).Tambah = False
          dsMenu(i).Edit = False
          dsMenu(i).Hapus = False
          dsMenu(i).Eksport = False
          dsMenu(i).Cetak = False
        Else
          dsMenu(i).Buka = loadUserMenu.Buka
          dsMenu(i).Tambah = loadUserMenu.Tambah
          dsMenu(i).Edit = loadUserMenu.Edit
          dsMenu(i).Hapus = loadUserMenu.Hapus
          dsMenu(i).Eksport = loadUserMenu.Eksport
          dsMenu(i).Cetak = loadUserMenu.Cetak
        End If
      Next
      treeMenu.RefreshDataSource()
    End If
  End Sub
  Private Sub SaveReportBeforeChanging(value As Object)
    Dim newUserReport As NPO.SSystem.UserReport
    Dim itemReport As NPO.SSystem.Laporan

    If Not value Is Nothing Then
      For i = 0 To dsReport.Count - 1
        itemReport = dsReport(i).Report
        newUserReport = xpUserReport.ToList.Find(Function(m) m.Report Is itemReport And m.User Is xpUser And m.Database Is value)
        If newUserReport Is Nothing Then
          newUserReport = New NPO.SSystem.UserReport(session)
          newUserReport.Buka = dsReport(i).Buka
          newUserReport.Eksport = dsReport(i).Eksport
          newUserReport.Cetak = dsReport(i).Cetak
          newUserReport.Database = CType(value, NPO.SSystem.Database)
          newUserReport.Report = dsReport(i).Report
          newUserReport.User = xpUser
          xpUserReport.Add(newUserReport)
        Else
          newUserReport.Buka = dsReport(i).Buka
          newUserReport.Eksport = dsReport(i).Eksport
          newUserReport.Cetak = dsReport(i).Cetak
        End If
      Next
    End If
  End Sub
  Private Sub LoadReportAfterChanging(value As Object)
    If Not value Is Nothing Then
      For i = 0 To dsReport.Count - 1
        Dim report As NPO.SSystem.Laporan = dsReport(i).Report
        Dim loadUserReport As NPO.SSystem.UserReport = xpUserReport.ToList.Find(Function(m) m.Report Is report And m.User Is xpUser And m.Database Is value)
        If loadUserReport Is Nothing Then
          dsReport(i).Buka = False
          dsReport(i).Eksport = False
          dsReport(i).Cetak = False
        Else
          dsReport(i).Buka = loadUserReport.Buka
          dsReport(i).Eksport = loadUserReport.Eksport
          dsReport(i).Cetak = loadUserReport.Cetak
        End If
      Next
      treeReport.RefreshDataSource()
    End If
  End Sub
  Private Sub SaveRegionalBeforeChanging(value As Object)
    Dim newUserRegional As NPO.SSystem.UserRegional
    Dim itemRegional As UInt16

    If Not value Is Nothing Then
      For i = 0 To dsRegional.Count - 1
        itemRegional = dsRegional(i).RegionalId
        newUserRegional = xpUserRegional.ToList.Find(Function(m) m.Regional = itemRegional And m.User Is xpUser And m.Database Is value)
        If newUserRegional Is Nothing Then
          newUserRegional = New NPO.SSystem.UserRegional(session)
          newUserRegional.Buka = dsRegional(i).Buka
          newUserRegional.IsDefault = dsRegional(i).IsDefault
          newUserRegional.Database = CType(value, NPO.SSystem.Database)
          newUserRegional.Regional = dsRegional(i).RegionalId
          newUserRegional.User = xpUser
          xpUserRegional.Add(newUserRegional)
        Else
          newUserRegional.Buka = dsRegional(i).Buka
          newUserRegional.IsDefault = dsRegional(i).IsDefault
        End If
      Next
    End If
  End Sub
  Private Sub LoadRegionalAfterChanging(value As Object)
    If Not value Is Nothing Then
      LoadRegionalDataSource(value)

      For i = 0 To dsRegional.Count - 1
        Dim regionalId As UInt16 = dsRegional(i).RegionalId
        Dim loadUserRegional As NPO.SSystem.UserRegional = xpUserRegional.ToList.Find(Function(m) m.Regional = regionalId And m.User Is xpUser And m.Database Is value)
        If loadUserRegional Is Nothing Then
          dsRegional(i).Buka = True
          dsRegional(i).IsDefault = False
        Else
          dsRegional(i).Buka = loadUserRegional.Buka
          dsRegional(i).IsDefault = loadUserRegional.IsDefault
        End If
      Next
      treeRegional.RefreshDataSource()
    End If
  End Sub

  Private Sub SaveDivisiBeforeChanging(value As Object)
    Dim newUserDivisi As NPO.SSystem.UserDivision
    Dim itemDivisi As UInt16

    If Not value Is Nothing Then
      For i = 0 To dsDivisi.Count - 1
        itemDivisi = dsDivisi(i).DivisiId
        newUserDivisi = xpUserDivisi.ToList.Find(Function(m) m.Divisi = itemDivisi And m.User Is xpUser And m.Database Is value)
        If newUserDivisi Is Nothing Then
          newUserDivisi = New NPO.SSystem.UserDivision(session)
          newUserDivisi.Buka = dsDivisi(i).Buka
          newUserDivisi.Database = CType(value, NPO.SSystem.Database)
          newUserDivisi.Divisi = dsDivisi(i).DivisiId
          newUserDivisi.User = xpUser
          xpUserDivisi.Add(newUserDivisi)
        Else
          newUserDivisi.Buka = dsDivisi(i).Buka
        End If
      Next
    End If
  End Sub
  Private Sub LoadDivisiAfterChanging(value As Object)
    If Not value Is Nothing Then
      LoadDivisiDataSource(value)

      For i = 0 To dsDivisi.Count - 1
        Dim divisiId As UInt16 = dsDivisi(i).DivisiId
        Dim loadUserDivisi As NPO.SSystem.UserDivision = xpUserDivisi.ToList.Find(Function(m) m.Divisi = divisiId And m.User Is xpUser And m.Database Is value)
        If loadUserDivisi Is Nothing Then
          dsDivisi(i).Buka = False
        Else
          dsDivisi(i).Buka = loadUserDivisi.Buka
        End If
      Next
      treeDivisi.RefreshDataSource()
    End If
  End Sub

  Private Sub LoadRegionalDataSource(value As Object)
    Dim db As NPO.SSystem.Database = CType(value, NPO.SSystem.Database)
    Dim sesiDb As DevExpress.Xpo.Session = NuSoft.Data.DbClient.GetXPOSession(db.NamaDatabase)
    Dim data As New DevExpress.Xpo.XPCollection(Of NPO.Modules.ModSys.Regional)(sesiDb)
    Dim regionalItem As NPO.NonPersistent.RegionalInUser

    dsRegional = New List(Of NPO.NonPersistent.RegionalInUser)
    For i = 0 To data.Count - 1
      regionalItem = New NPO.NonPersistent.RegionalInUser()
      regionalItem.IsDefault = False
      regionalItem.Buka = False
      regionalItem.RegionalId = data(i).Id
      regionalItem.RegionalNama = data(i).Nama
      dsRegional.Add(regionalItem)
    Next

    treeRegional.DataSource = dsRegional
    treeRegional.RefreshDataSource()
  End Sub
  Private Sub LoadDivisiDataSource(value As Object)
    Dim db As NPO.SSystem.Database = CType(value, NPO.SSystem.Database)
    Dim sesiDb As DevExpress.Xpo.Session = NuSoft.Data.DbClient.GetXPOSession(db.NamaDatabase)
    Dim data As New DevExpress.Xpo.XPCollection(Of NPO.Modules.ModSys.Divisi)(sesiDb)
    Dim divisiItem As NPO.NonPersistent.DivisiInUser

    dsDivisi = New List(Of NPO.NonPersistent.DivisiInUser)
    For i = 0 To data.Count - 1
      divisiItem = New NPO.NonPersistent.DivisiInUser
      divisiItem.Buka = False
      divisiItem.DivisiId = data(i).Id
      divisiItem.DivisiNama = data(i).Kode
      dsDivisi.Add(divisiItem)
    Next

    treeDivisi.DataSource = dsDivisi
    treeDivisi.RefreshDataSource()
  End Sub

  Private Function ValidateData(data As NPO.SSystem.User) As Boolean
    If data.Kode = Nothing Then
      Throw New Utils.Exception("Masukkan kode user", 1)
      Return False
    End If
    If data.Nama = Nothing Then
      Throw New Utils.Exception("Masukkan nama user", 2)
      Return False
    End If
    If data.Password = Nothing Then
      Throw New Utils.Exception("Masukkan password user", 3)
      Return False
    End If
    If xpUserMenu Is Nothing Then
      Throw New Utils.Exception("Masukkan hak akses menu", 4)
      Return False
    End If
    If xpUserReport Is Nothing Then
      Throw New Utils.Exception("Masukkan hak akses laporan", 5)
      Return False
    End If
    If txtWilayahTertentu.Checked Then
      If xpUserRegional Is Nothing Then
        Throw New Utils.Exception("Masukkan hak akses regional", 6)
        Return False
      End If
    End If
    If txtDivisiTertentu.Checked Then
      If xpUserDivisi Is Nothing Then
        Throw New Utils.Exception("Masukkan hak akses divisi", 7)
        Return False
      End If
    End If

    Return True
  End Function

  Private Sub txtHomeMenu_ButtonPressed(sender As Object, e As ButtonPressedEventArgs) Handles txtHomeMenu.ButtonPressed
    If e.Button.Kind = ButtonPredefines.Delete Then
      txtHomeMenu.EditValue = Nothing
    End If
  End Sub
End Class