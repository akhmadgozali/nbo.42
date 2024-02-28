Imports DevExpress.Xpo

Friend Class x_Main
  Private Const skinMask As String = "Skin: "
  Private Const coreFile As String = "NuSoft.NUI.Win.Forms.dll"
  Private ReadOnly MainClass As New Privileges
  Private closeBeforeLogin As Boolean
  Private dbCount As Integer
  Private settingFramework As Core.SSystem.FrameworkSetting
  Private session As UnitOfWork

  Public Sub New()
    ' This call is required by the designer.
    InitializeComponent()
    ' Add any initialization after the InitializeComponent() call.
    dockMenu.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Hidden
    Text = String.Format("{0} {1}.{2}", My.Application.Info.ProductName, My.Application.Info.Version.Major, My.Application.Info.Version.Minor)
    Icon = My.Resources.NusoftIcon
    barTxtVersi.Caption = String.Format("Versi : {0}", My.Application.Info.Version)
    LoadSkin()

    Connector.SUIMainClass = Me
  End Sub

  Private Sub Me_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
    If Not closeBeforeLogin Then
      LogoffEvent()
    End If
  End Sub
  Private Sub Me_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
    If Not Utils.Serial.IsRegister Then
      Using x As New x_Serial(x_Serial.Mode.User)
        If Not x.ShowDialog = DialogResult.OK Then
          Me.Close()
        End If
      End Using
    End If

    ShowLogin()
  End Sub

  Private Sub LoadSkin()
    barManager.ForceInitialize()
    For Each cnt As DevExpress.Skins.SkinContainer In DevExpress.Skins.SkinManager.Default.Skins
      Dim item As DevExpress.XtraBars.BarButtonItem = New DevExpress.XtraBars.BarButtonItem(barManager, skinMask & cnt.SkinName)
      barSubSkin.AddItem(item)
      AddHandler item.ItemClick, AddressOf OnSkinClick
    Next cnt

    barSubSkin.Caption = skinMask & DevExpress.LookAndFeel.UserLookAndFeel.Default.ActiveSkinName
  End Sub
  Private Sub OnSkinClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
    Dim skinName As String = e.Item.Caption.Replace(skinMask, "")
    DevExpress.LookAndFeel.UserLookAndFeel.Default.SetSkinStyle(skinName)
    barManager.GetController.PaintStyleName = "Skin"
    barSubSkin.Caption = e.Item.Caption
    barSubSkin.Hint = barSubSkin.Caption
    barSubSkin.ImageIndex = -1

    My.Settings.SkinName = skinName
    My.Settings.Save()
  End Sub

  Private Sub LogoffEvent()
    Core.SSystem.SystemLog.Save(Nothing, NPO.SSystem.SystemLog.Action.Info, "LogOff")
  End Sub
  Private Sub ShowLogoff()
    CloseAllWindows()
    barTxtUser.Caption = ""
    dockMenu.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Hidden
    LogoffEvent()
    ShowLogin()
  End Sub
  Private Sub ShowLogin()
    Using login As New x_Login
      If login.ShowDialog = Windows.Forms.DialogResult.OK Then
        Using splashManager As DevExpress.XtraSplashScreen.SplashScreenManager = New DevExpress.XtraSplashScreen.SplashScreenManager(Me, GetType(x_Splash), True, True)
          splashManager.SendCommand(x_Splash.SplashScreenCommand.ChangeProgress, "Loading User ...")
          barNavControl.SuspendLayout()

          '====== Load Data based user id
          session = Data.DbSystem.GetXPOSession
          MainClass.Load(session)
          settingFramework = New Core.SSystem.FrameworkSetting(session)

          '===== Load Group with TreeView
          splashManager.SendCommand(x_Splash.SplashScreenCommand.ChangeProgress, "Loading Modules ...")
          Dim y = (From d In MainClass.UserMenu Select d.Menu.Modul).Distinct
          LoadGroup(y)

          '==== Load Database
          splashManager.SendCommand(x_Splash.SplashScreenCommand.ChangeProgress, "Loading Databases ...")

          Dim z = (From d In MainClass.UserMenu Where d.Database.Aktif = True Select d.Database).Distinct
          barDtDatabaseRepo.DataSource = z
          dbCount = z.Count
          barDtDatabase.EditValue = barDtDatabaseRepo.GetDataSourceValue("NamaDatabase", 0)

          '==== Load Misc
          splashManager.SendCommand(x_Splash.SplashScreenCommand.ChangeProgress, "Loading Menu ...")
          barTxtUser.Caption = Core.SSystem.UserInfo.GetUserName

          If Not barDtDatabase.EditValue Is Nothing Then
            SetModule(barDtDatabase.EditValue.ToString)
            SetReport(barDtDatabase.EditValue.ToString)
          End If
          barNavReport.Visible = settingFramework.LayoutLaporanTerpisah
          barNavAdmin.Visible = (Core.SSystem.UserInfo.GetUserLevel > 1)
          barNavSuperAdmin.Visible = (Core.SSystem.UserInfo.GetUserLevel > 2)
          barNavControl.ActiveGroup = barNavControl.Groups(0)
          barNavControl.ResumeLayout()

          '==== Set Update Timer
          Dim encryptDES As New NuSoft.Utils.Cryptograph.DES() With {.Key = Data.Helper.GetKey}
          If CBool(Data.Helper.GetSyncAuto(encryptDES)) Then
            tmrUpdate.Interval = CInt(Data.Helper.GetSyncInterval(encryptDES)) * 60 * 1000
            tmrUpdate.Enabled = True
          Else
            tmrUpdate.Enabled = False
          End If

          splashManager.CloseWaitForm()
          dockMenu.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Visible

          ''==== Show dashboard form
          'If Core.SSystem.UserInfo.GetDashboardModul <> "" Then
          '  OpenForm(coreFile, 99, "99", False)
          'End If

          '==== Show Home Menu
          Dim home = Core.SSystem.UserInfo.GetHomeMenu
          If Not home Is Nothing Then
            Dim pathFile As String = String.Format("Modules\{0}.dll", home.Modul.Kode)
            If My.Computer.FileSystem.FileExists(pathFile) Then
              OpenForm(pathFile, home.Id, home.Kode, True)
            End If
          End If

        End Using
        closeBeforeLogin = False
      Else
        closeBeforeLogin = True
        System.Windows.Forms.Application.Exit()
      End If
    End Using
  End Sub
  Private Sub LoadGroup(ByVal eModules As IEnumerable(Of NPO.SSystem.Modul))
    Dim imageCount As Integer = imageBarLarge.Images.Count
    Dim i As Integer = 0
    Dim newGroup As DevExpress.XtraNavBar.NavBarGroup
    Dim newGroupContainer As DevExpress.XtraNavBar.NavBarGroupControlContainer
    Dim decrypt As New Utils.Cryptograph.Encryption.Hash(Utils.Cryptograph.Encryption.Hash.Provider.CRC32)
    Dim key As New Utils.Cryptograph.Encryption.Data(Core.SSystem.UserInfo.GetUserKey)

    For Each modul As NPO.SSystem.Modul In eModules
      If Not Core.Win.Component.XtraNavBar.GroupExists(barNavControl, modul.Kode) Then
        Dim pathFile As String = String.Format("Modules\{0}.dll", modul.Kode)
        If My.Computer.FileSystem.FileExists(pathFile) Then
          Dim x = decrypt.Calculate(New Utils.Cryptograph.Encryption.Data(modul.Id.ToString), key).Hex
          If Convert.ToInt32(Connector.GetModuleId(pathFile)) = Convert.ToInt32(x, 16) Then
            imageBarLarge.Images.Add(Connector.GetModuleLargeImages(pathFile))
            imageBarSmall.Images.Add(Connector.GetModuleSmallImages(pathFile))

            newGroup = New DevExpress.XtraNavBar.NavBarGroup
            newGroupContainer = New DevExpress.XtraNavBar.NavBarGroupControlContainer

            newGroupContainer.SuspendLayout()

            barNavControl.Controls.Add(newGroupContainer)
            barNavControl.Groups.Insert(i, newGroup)
            newGroupContainer.Controls.Add(GetModuleTreeList(modul.Id, pathFile))

            newGroup.ControlContainer = newGroupContainer
            newGroup.Caption = modul.Nama
            newGroup.Name = modul.Kode
            newGroup.SmallImageIndex = i + imageCount
            newGroup.LargeImageIndex = i + imageCount
            newGroup.GroupStyle = DevExpress.XtraNavBar.NavBarGroupStyle.ControlContainer
            newGroup.DragDropFlags = DevExpress.XtraNavBar.NavBarDragDrop.None
            newGroup.GroupCaptionUseImage = DevExpress.XtraNavBar.NavBarImage.Large

            newGroupContainer.ResumeLayout()
            i += 1
          End If
        End If
      End If
    Next
  End Sub
  Private Function GetModuleTreeList(ByVal modulId As Integer, ByVal FileName As String) As DevExpress.XtraTreeList.TreeList
    Dim newTreeName As New DevExpress.XtraTreeList.Columns.TreeListColumn With {.Caption = "Menu", .FieldName = "Nama", .MinWidth = 35, .Name = "newTreeName"}
    Dim newTree As New DevExpress.XtraTreeList.TreeList() With {.Dock = DockStyle.Fill, .BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder, .KeyFieldName = "This", .ParentFieldName = "Induk"}

    newTree.OptionsBehavior.Editable = False
    newTree.OptionsSelection.EnableAppearanceFocusedCell = False
    newTree.OptionsView.ShowColumns = False
    newTree.OptionsView.ShowIndentAsRowStyle = True
    newTree.OptionsView.ShowIndicator = False
    newTree.SelectImageList = imageManager
    newTree.Columns.AddRange(New DevExpress.XtraTreeList.Columns.TreeListColumn() {newTreeName})
    newTree.Tag = FileName

    newTreeName.OptionsColumn.AllowEdit = False
    newTreeName.OptionsColumn.AllowMove = False
    newTreeName.OptionsColumn.AllowMoveToCustomizationForm = False
    newTreeName.OptionsColumn.AllowSort = False
    newTreeName.OptionsColumn.ReadOnly = True
    newTreeName.OptionsColumn.ShowInCustomizationForm = False
    newTreeName.Visible = True
    newTreeName.VisibleIndex = 0

    AddHandler newTree.GetSelectImage, AddressOf treeGetSelectImage
    AddHandler newTree.DoubleClick, AddressOf tree_DoubleClick
    AddHandler newTree.KeyDown, AddressOf tree_KeyDown
    Return newTree
  End Function

  Private Sub SetMenu(ByVal dbName As String, ByVal group As DevExpress.XtraNavBar.NavBarGroup)
    Try
      Dim xmenu = From z In MainClass.UserMenu Where z.Database.NamaDatabase = dbName And z.Buka = True And z.Menu.Modul.Kode = group.Name And z.Menu.Aktif = True And Not z.Menu.Induk Is Nothing Select z.Menu Order By Menu.Urutan, Menu.Kode
      Dim tree As DevExpress.XtraTreeList.TreeList = CType(group.ControlContainer.Controls(0), DevExpress.XtraTreeList.TreeList)

      If settingFramework.LayoutLaporanTerpisah Then
        tree.DataSource = xmenu.ToList
      Else
        Dim newStructure As New List(Of MenuReportStructure)
        Dim item As MenuReportStructure
        Dim laporan = GetReportSource(dbName, group.Name)

        For i = 0 To xmenu.ToList.Count - 1
          item = New MenuReportStructure
          item.Id = xmenu.ToList(i).Id
          item.Induk = xmenu.ToList(i).Induk.Id
          item.Kode = xmenu.ToList(i).Kode
          item.Nama = xmenu.ToList(i).Nama
          item.This = xmenu.ToList(i).Id
          item.IsMenu = True
          newStructure.Add(item)
        Next

        For i = 0 To laporan.ToList.Count - 1
          item = New MenuReportStructure
          item.Id = CInt("99" & laporan.ToList(i).Id)
          If laporan.ToList(i).Induk Is Nothing Then
            item.Induk = Nothing
            item.Nama = "Laporan"
          Else
            item.Induk = CInt("99" & laporan.ToList(i).Induk.Id)
            item.Nama = laporan.ToList(i).Nama
          End If
          item.Kode = laporan.ToList(i).Kode
          item.This = item.Id
          item.NamaFile = laporan.ToList(i).NamaFile
          item.IsMenu = False
          newStructure.Add(item)
        Next

        tree.DataSource = newStructure
      End If
    Catch ex As Exception
      If Not ex.Message.Contains("Object reference not set to an instance") Then
        DevExpress.XtraEditors.XtraMessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
      End If
    End Try
  End Sub
  Private Sub SetModule(ByVal dbName As String)
    Try
      Dim x = (From z In MainClass.UserMenu Where z.Database.NamaDatabase = dbName And z.Buka = True And z.Menu.Aktif = True And Not z.Menu.Induk Is Nothing Select z.Menu.Modul).Distinct
      Dim fileName As String

      For i = 0 To barNavControl.Groups.Count - 1
        If Not barNavControl.Groups(i) Is barNavAdmin AndAlso Not barNavControl.Groups(i) Is barNavSuperAdmin AndAlso Not barNavControl.Groups(i) Is barNavReport Then
          fileName = barNavControl.Groups(i).Name
          barNavControl.Groups(i).Visible = x.ToList.Exists(Function(m) m.Kode = fileName)
        End If
      Next
    Catch ex As Exception
      If Not ex.Message.Contains("Object reference not set to an instance") Then
        DevExpress.XtraEditors.XtraMessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
      End If
    End Try
  End Sub
  Private Function GetReportSource(dbName As String, moduleCode As String) As IEnumerable(Of NPO.SSystem.Laporan)
    Return From z In MainClass.UserReport Where z.Database.NamaDatabase = dbName And z.Buka = True And z.Report.Modul.Kode = moduleCode And z.Report.Aktif = True Select z.Report Order By Report.Kode Order By Report.Urutan, Report.Kode
  End Function
  Private Sub SetReport(ByVal dbName As String)
    Try
      Dim x = From z In MainClass.UserReport Where z.Database.NamaDatabase = dbName And z.Buka = True And z.Report.Aktif = True Select z.Report Order By Report.Kode Order By Report.Urutan, Report.Kode

      treeReport.DataSource = x.ToList
    Catch ex As Exception
      If Not ex.Message.Contains("Object reference not set to an instance") Then
        DevExpress.XtraEditors.XtraMessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
      End If
    End Try
  End Sub

  Private Sub tmrJam_Tick(ByVal sender As Object, ByVal e As EventArgs) Handles tmrJam.Tick
    barTxtJam.Caption = Now.ToString("dddd, dd MMMM yyyy hh:mm:ss")
  End Sub
  Private Sub barBtnLogOff_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles barBtnLogOff.ItemClick
    ShowLogoff()
  End Sub
  Private Sub barBtnCloseAllWindow_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles barBtnCloseAllWindow.ItemClick
    CloseAllWindows()
  End Sub
  Private Sub barBtnChangePassword_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles barBtnChangePassword.ItemClick
    Using xPass As New x_Password()
      xPass.ShowDialog()
    End Using
  End Sub
  Private Sub barBtnCekUpdate_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles barBtnCekUpdate.ItemClick
    tmrUpdate.Enabled = False
    BackgroundWorker1.CancelAsync()
    While BackgroundWorker1.IsBusy
      System.Windows.Forms.Application.DoEvents()
    End While
    If My.Computer.FileSystem.DirectoryExists(My.Application.Info.DirectoryPath & "\upd") Then
      My.Computer.FileSystem.DeleteDirectory(My.Application.Info.DirectoryPath & "\upd", FileIO.DeleteDirectoryOption.DeleteAllContents)
    End If

    Dim frm As New Sync.Frm_Proses
    frm.Text = "Proses Update SyBiru " & My.Application.Info.Version.Major & "." & My.Application.Info.Version.Minor & "." & My.Application.Info.Version.Build
    frm.ShowIcon = False
    frm.ShowDialog()

    '==== Check Directory
    If My.Computer.FileSystem.DirectoryExists(My.Application.Info.DirectoryPath & "\upd") Then
      If My.Computer.FileSystem.GetFiles(My.Application.Info.DirectoryPath & "\upd").Count > 0 Then
        If DevExpress.XtraEditors.XtraMessageBox.Show("File update sudah didownload." & vbCrLf & "Apakah anda ingin merestart aplikasi ini ?", "Restart Aplikasi", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.OK Then
          System.Windows.Forms.Application.Restart()
        End If
      End If
    End If
    tmrUpdate.Enabled = True
  End Sub

  Private Sub barNavControl_ActiveGroupChanged(ByVal sender As Object, ByVal e As DevExpress.XtraNavBar.NavBarGroupEventArgs) Handles barNavControl.ActiveGroupChanged
    If Not e.Group Is barNavAdmin AndAlso Not e.Group Is barNavSuperAdmin AndAlso Not e.Group Is barNavReport Then
      SetMenu(barDtDatabase.EditValue.ToString, e.Group)
    End If
  End Sub
  Private Sub barDtDatabaseRepo_EditValueChanging(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ChangingEventArgs) Handles barDtDatabaseRepo.EditValueChanging
    SetModule(e.NewValue.ToString)
    SetReport(e.NewValue.ToString)

    If barNavControl.Groups.GetVisibleGroupCount > 0 Then
      If Not barNavControl.ActiveGroup Is barNavAdmin AndAlso Not barNavControl.ActiveGroup Is barNavSuperAdmin AndAlso Not barNavControl.ActiveGroup Is barNavReport Then
        SetMenu(e.NewValue.ToString, barNavControl.ActiveGroup)
      End If
    End If
  End Sub

  Private Sub treeGetSelectImage(ByVal sender As Object, ByVal e As DevExpress.XtraTreeList.GetSelectImageEventArgs)
    If Not e.Node.HasChildren Then
      e.NodeImageIndex = 9
    ElseIf e.Node.Expanded Then
      e.NodeImageIndex = 8
    Else
      e.NodeImageIndex = 10
    End If
  End Sub
  Private Sub treeReport_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles treeReport.KeyDown
    If e.KeyCode = Keys.Enter Then
      treeSelect(CType(sender, DevExpress.XtraTreeList.TreeList))
    End If
  End Sub
  Private Sub treeReport_DoubleClick(sender As Object, e As System.EventArgs) Handles treeReport.DoubleClick
    reportSelect(CType(sender, DevExpress.XtraTreeList.TreeList))
  End Sub
  Private Sub treeReport_GetSelectImage(sender As Object, e As DevExpress.XtraTreeList.GetSelectImageEventArgs) Handles treeReport.GetSelectImage
    If Not e.Node.HasChildren Then
      e.NodeImageIndex = 11
    ElseIf e.Node.Expanded Then
      e.NodeImageIndex = 8
    Else
      e.NodeImageIndex = 10
    End If
  End Sub

  Private Sub barNavSuperAdminDatabase_LinkClicked(ByVal sender As Object, ByVal e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles barNavSuperAdminDatabase.LinkClicked
    OpenForm(coreFile, 1, "1", False)
  End Sub
  Private Sub barNavSuperAdminModule_LinkClicked(ByVal sender As Object, ByVal e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles barNavSuperAdminModule.LinkClicked
    OpenForm(coreFile, 2, "2", False)
  End Sub
  Private Sub barNavSuperAdminMenu_LinkClicked(ByVal sender As Object, ByVal e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles barNavSuperAdminMenu.LinkClicked
    OpenForm(coreFile, 3, "3", False)
  End Sub
  Private Sub barNavSuperAdminReport_LinkClicked(ByVal sender As Object, ByVal e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles barNavSuperAdminReport.LinkClicked
    OpenForm(coreFile, 4, "4", False)
  End Sub
  Private Sub barNavAdminUserman_LinkClicked(ByVal sender As Object, ByVal e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles barNavAdminUserman.LinkClicked
    OpenForm(coreFile, 5, "5", False)
  End Sub
  Private Sub barNavAdminUserlog_LinkClicked(ByVal sender As Object, ByVal e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles barNavAdminUserlog.LinkClicked
    OpenForm(coreFile, 6, "6", False)
  End Sub
  Private Sub barNavAdminSystemLog_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles barNavAdminSystemLog.LinkClicked
    OpenForm(coreFile, 7, "7", False)
  End Sub
  Private Sub barNavAdminSetting_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles barNavAdminSetting.LinkClicked
    Using xPass As New x_Setting()
      xPass.ShowDialog()
    End Using
  End Sub
  Private Sub barNavSerial_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles barNavSerial.LinkClicked
    Using x As New x_Serial(x_Serial.Mode.Admin)
      x.ShowDialog()
    End Using
  End Sub

  Private Sub OpenForm(ByVal fileName As String, ByVal menuId As Integer, ByVal menuCode As String, isHome As Boolean)
    If barDtDatabase.EditValue Is Nothing AndAlso Not (fileName = coreFile AndAlso menuId <> 99) Then
      Utils.Win.MessageBox.Show("Pilih database terlebih dahulu.", Me.Text)
      Exit Sub
    End If

    Using splashManager As DevExpress.XtraSplashScreen.SplashScreenManager = New DevExpress.XtraSplashScreen.SplashScreenManager(Me, GetType(x_Wait), True, True)
      Try
        splashManager.ShowWaitForm()
        splashManager.SetWaitFormCaption("Silahkan Tunggu")
        splashManager.SetWaitFormDescription("Sedang membuka form ...")

        Dim Frm As Core.Win.Forms.NuSoftForm = Connector.GetForms(fileName, menuCode)
        If Not (fileName = coreFile AndAlso menuId <> 99) Then
          Frm.NamaDatabase = barDtDatabase.EditValue.ToString
        End If
        Frm.MenuId = menuId

        If TypeOf (Frm) Is Core.Win.Forms.DialogForm Then
          splashManager.CloseWaitForm()
          Frm.ShowDialog()
          Exit Sub
        End If

        If isHome Then
          Frm.ControlBox = False
        End If

        If dbCount > 1 Then
          Dim newFormTitle As String
          If fileName = coreFile Then
            newFormTitle = Frm.Text
          Else
            newFormTitle = String.Format("{0} @ {1}", Frm.Text, barDtDatabaseRepo.GetDisplayText(barDtDatabase.EditValue))
          End If

          For Each oFrm In MdiChildren
            If Frm.Name = oFrm.Name Then
              If oFrm.Text = newFormTitle Then
                oFrm.Focus()
                splashManager.CloseWaitForm()
                Exit Sub
              End If
            End If
          Next
          Frm.Text = newFormTitle
        Else
          For Each oFrm In MdiChildren
            If Frm.Name = oFrm.Name Then
              If oFrm.Text = Frm.Text Then
                oFrm.Focus()
                splashManager.CloseWaitForm()
                Exit Sub
              End If
            End If
          Next
        End If

        Frm.WindowState = FormWindowState.Maximized
        Frm.MdiParent = Me
        Frm.Show()
        splashManager.CloseWaitForm()
      Catch ex As Exception
        splashManager.CloseWaitForm()
        Throw New Exception(ex.Message, ex.InnerException)
      End Try
    End Using
  End Sub
  Sub OpenFormInMDI(form As Core.Win.Forms.NuSoftForm)
    Using splashManager As DevExpress.XtraSplashScreen.SplashScreenManager = New DevExpress.XtraSplashScreen.SplashScreenManager(Me, GetType(x_Wait), True, True)
      Try
        splashManager.ShowWaitForm()
        splashManager.SetWaitFormCaption("Silahkan Tunggu")
        splashManager.SetWaitFormDescription("Sedang membuka form ...")

        If dbCount > 1 Then
          Dim newFormTitle As String = String.Format("{0} @ {1}", form.Text, barDtDatabaseRepo.GetDisplayText(barDtDatabase.EditValue))

          For Each oFrm In MdiChildren
            If form.Name = oFrm.Name Then
              If oFrm.Text = newFormTitle Then
                oFrm.Focus()
                splashManager.CloseWaitForm()
                Exit Sub
              End If
            End If
          Next
          form.Text = newFormTitle
        Else
          For Each oFrm In MdiChildren
            If form.Name = oFrm.Name Then
              If oFrm.Text = form.Text Then
                oFrm.Focus()
                splashManager.CloseWaitForm()
                Exit Sub
              End If
            End If
          Next
        End If

        form.WindowState = FormWindowState.Maximized
        form.MdiParent = Me
        form.Show()
        splashManager.CloseWaitForm()
      Catch ex As Exception
        splashManager.CloseWaitForm()
        Throw New Exception(ex.Message, ex.InnerException)
      End Try
    End Using
  End Sub

  Private Sub OpenReport(ByVal fileName As String, ByVal reportId As Integer, ByVal reportCode As String, reportName As String, reportFile As String)
    If barDtDatabase.EditValue Is Nothing Then
      Utils.Win.MessageBox.Show("Pilih database terlebih dahulu.", Me.Text)
      Exit Sub
    End If

    Using splashManager As DevExpress.XtraSplashScreen.SplashScreenManager = New DevExpress.XtraSplashScreen.SplashScreenManager(Me, GetType(x_Wait), True, True)
      Try
        Dim filePath As String = String.Format("{0}\Report\{1}", My.Application.Info.DirectoryPath, reportFile)
        If Not System.IO.File.Exists(filePath) Then
          Utils.Win.MessageBox.Show(String.Format("File report '{0}' tidak ditemukan.", filePath), Me.Text, String.Format("Pastikan file {0} ada didalam folder report", reportFile), Utils.Win.MessageBox.Button.OK, Utils.Win.MessageBox.Icon.Peringatan)
          Exit Sub
        End If

        splashManager.ShowWaitForm()
        splashManager.SetWaitFormCaption("Silahkan Tunggu")
        splashManager.SetWaitFormDescription("Sedang membuka filter laporan ...")

        Dim Frm As Core.Win.Forms.ReportFilter = Connector.GetReportFilter(String.Format("Modules\{0}.dll", fileName), reportCode)
        Frm.LayoutReportTerpisah = settingFramework.LayoutLaporanTerpisah
        Frm.NamaDatabase = barDtDatabase.EditValue.ToString
        Frm.ReportId = reportId
        splashManager.CloseWaitForm()

        If Frm.ShowDialog = Windows.Forms.DialogResult.OK Then
          Dim isExport As Boolean = Frm.IsRightToExport
          Dim isPrint As Boolean = Frm.IsRightToPrint
          Dim ds As Object = Frm.DataSource
          Dim parameters As List(Of DevExpress.XtraReports.Parameters.Parameter) = Frm.Parameters

          splashManager.ShowWaitForm()
          splashManager.SetWaitFormCaption("Silahkan Tunggu")
          splashManager.SetWaitFormDescription("Sedang membuka laporan ...")
          Dim FrmReport As New Report.UI_Viewer
          If dbCount > 1 Then
            FrmReport.Text = String.Format("Laporan {0} @ {1}", reportName, barDtDatabaseRepo.GetDisplayText(barDtDatabase.EditValue))
          Else
            FrmReport.Text = "Laporan " & reportName
          End If
          FrmReport.FileName = filePath
          FrmReport.dataSource = ds
          FrmReport.Parameters = parameters
          FrmReport.OpenReport(isExport, isPrint)

          FrmReport.WindowState = FormWindowState.Maximized
          FrmReport.MdiParent = Me
          FrmReport.Show()
          splashManager.CloseWaitForm()
        End If
      Catch ex As Exception
        splashManager.CloseWaitForm()
        Throw New Exception(ex.Message, ex.InnerException)
      End Try
    End Using
  End Sub

  Private Sub CloseAllWindows()
    Dim xForm As DevExpress.XtraEditors.XtraForm
    For Each xForm In Me.MdiChildren
      xForm.Close()
    Next
  End Sub
  Private Sub tree_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs)
    treeSelect(CType(sender, DevExpress.XtraTreeList.TreeList))
  End Sub
  Private Sub tree_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
    If e.KeyCode = Keys.Enter Then
      treeSelect(CType(sender, DevExpress.XtraTreeList.TreeList))
    End If
  End Sub
  Private Sub treeSelect(ByVal tree As DevExpress.XtraTreeList.TreeList)
    If Not tree.Selection(0).HasChildren Then
      If settingFramework.LayoutLaporanTerpisah Then
        OpenForm(tree.Tag.ToString, CInt(tree.Selection(0)("Id")), tree.Selection(0)("Kode").ToString, False)
      Else
        If CBool(tree.Selection(0)("IsMenu")) Then
          OpenForm(tree.Tag.ToString, CInt(tree.Selection(0)("Id")), tree.Selection(0)("Kode").ToString, False)
        Else
          OpenReport(barNavControl.ActiveGroup.Name, CInt(tree.Selection(0)("Id")), tree.Selection(0)("Kode").ToString, tree.Selection(0)("Nama").ToString, tree.Selection(0)("NamaFile").ToString)
        End If
      End If
    End If
  End Sub
  Private Sub reportSelect(ByVal tree As DevExpress.XtraTreeList.TreeList)
    If Not tree.Selection(0).HasChildren Then
      OpenReport(CType(tree.Selection(0)("Modul"), NPO.SSystem.Modul).Kode, CInt(tree.Selection(0)("Id")), tree.Selection(0)("Kode").ToString, tree.Selection(0)("Nama").ToString, tree.Selection(0)("NamaFile").ToString)
    End If
  End Sub

  Private Sub tmrUpdate_Tick(sender As Object, e As System.EventArgs) Handles tmrUpdate.Tick
    CekUpdate()
  End Sub

  Private WithEvents clsUpdate As New Sync.FTPUpdate
  Private Sub CekUpdate()
    If My.Computer.FileSystem.DirectoryExists(My.Application.Info.DirectoryPath & "\upd") Then
      My.Computer.FileSystem.DeleteDirectory(My.Application.Info.DirectoryPath & "\upd", FileIO.DeleteDirectoryOption.DeleteAllContents)
    End If

    If Not BackgroundWorker1.IsBusy Then
      tmrUpdate.Enabled = False
      BackgroundWorker1.RunWorkerAsync()
    End If
  End Sub
  Private Sub bkgUpdate_DoWork(ByVal sender As Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
    barTxtInfo.Caption = "Update otomatis berjalan ..."
    clsUpdate.StartProcess(False)
  End Sub
  Private Sub bkgUpdate_RunWorkerCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted
    barTxtInfo.Caption = ""
    tmrUpdate.Enabled = True
  End Sub
  Private Sub cls_Preparing(ByVal progress As String) Handles clsUpdate.Preparing
    barTxtInfo.Caption = progress
  End Sub
  Private Sub cls_Progress(ByVal progress As String, ByVal Prosentase As Integer) Handles clsUpdate.Progress
    barTxtInfo.Caption = progress
  End Sub
  Private Sub cls_Selesai() Handles clsUpdate.Selesai
    barTxtInfo.Caption = ""
    tmrUpdate.Enabled = True
  End Sub
End Class

Friend Class MenuReportStructure
  Property This As Integer
  Property Id As Integer
  Property Kode As String
  Property Nama As String
  Property Induk As Integer
  Property NamaFile As String
  Property IsMenu As Boolean
End Class