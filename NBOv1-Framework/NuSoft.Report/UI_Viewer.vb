Imports DevExpress.XtraReports.UI

Public Class UI_Viewer
  Property FileName As String
  Property dataSource As Object
  Property Parameters As List(Of DevExpress.XtraReports.Parameters.Parameter)

  Dim newReport As DevExpress.XtraReports.UI.XtraReport

  Sub New()
    ' This call is required by the designer.
    InitializeComponent()
    ' Add any initialization after the InitializeComponent() call.
    Me.Icon = My.Resources.NusoftIcon
  End Sub
  Public Sub OpenReport(ByVal Export As Boolean, ByVal Print As Boolean)
    Try
      newReport = New DevExpress.XtraReports.UI.XtraReport
      newReport.LoadLayout(FileName)
      newReport.DataSource = dataSource
      newReport.Parameters.Clear()
      newReport.Parameters.AddRange(Parameters.ToArray)
      newReport.PrintingSystem.SetCommandVisibility(DevExpress.XtraPrinting.PrintingSystemCommand.ClosePreview, DevExpress.XtraPrinting.CommandVisibility.None)
      PrintControl1.PrintingSystem = newReport.PrintingSystem
      SetPrivileges(Export, Print)
      newReport.CreateDocument(True)
    Catch ex As Exception
      Throw New Exception(ex.Message, ex.InnerException)
    End Try
  End Sub

  Private Sub SetPrivileges(ByVal Export As Boolean, ByVal Print As Boolean)
    'PrintPreviewBarItem8.Enabled = Print
    'PrintPreviewBarItem9.Enabled = Print
    'PrintPreviewBarItem10.Enabled = Print
    'PrintPreviewBarItem24.Enabled = Export
    'PrintPreviewBarItem25.Enabled = Export

    Dim eks, cet As DevExpress.XtraPrinting.CommandVisibility
    If Export Then
      eks = DevExpress.XtraPrinting.CommandVisibility.All
    Else
      eks = DevExpress.XtraPrinting.CommandVisibility.None
    End If
    If Print Then
      cet = DevExpress.XtraPrinting.CommandVisibility.All
    Else
      cet = DevExpress.XtraPrinting.CommandVisibility.None
    End If

    newReport.PrintingSystem.SetCommandVisibility(DevExpress.XtraPrinting.PrintingSystemCommand.ExportCsv, eks)
    newReport.PrintingSystem.SetCommandVisibility(DevExpress.XtraPrinting.PrintingSystemCommand.ExportFile, eks)
    newReport.PrintingSystem.SetCommandVisibility(DevExpress.XtraPrinting.PrintingSystemCommand.ExportGraphic, eks)
    newReport.PrintingSystem.SetCommandVisibility(DevExpress.XtraPrinting.PrintingSystemCommand.ExportHtm, eks)
    newReport.PrintingSystem.SetCommandVisibility(DevExpress.XtraPrinting.PrintingSystemCommand.ExportMht, eks)
    newReport.PrintingSystem.SetCommandVisibility(DevExpress.XtraPrinting.PrintingSystemCommand.ExportPdf, eks)
    newReport.PrintingSystem.SetCommandVisibility(DevExpress.XtraPrinting.PrintingSystemCommand.ExportRtf, eks)
    newReport.PrintingSystem.SetCommandVisibility(DevExpress.XtraPrinting.PrintingSystemCommand.ExportTxt, eks)
    newReport.PrintingSystem.SetCommandVisibility(DevExpress.XtraPrinting.PrintingSystemCommand.ExportXls, eks)
    newReport.PrintingSystem.SetCommandVisibility(DevExpress.XtraPrinting.PrintingSystemCommand.ExportXlsx, eks)
    newReport.PrintingSystem.SetCommandVisibility(DevExpress.XtraPrinting.PrintingSystemCommand.ExportXps, eks)
    newReport.PrintingSystem.SetCommandVisibility(DevExpress.XtraPrinting.PrintingSystemCommand.Print, cet)
    newReport.PrintingSystem.SetCommandVisibility(DevExpress.XtraPrinting.PrintingSystemCommand.PrintDirect, cet)
    newReport.PrintingSystem.SetCommandVisibility(DevExpress.XtraPrinting.PrintingSystemCommand.Save, eks)
    newReport.PrintingSystem.SetCommandVisibility(DevExpress.XtraPrinting.PrintingSystemCommand.SendCsv, eks)
    newReport.PrintingSystem.SetCommandVisibility(DevExpress.XtraPrinting.PrintingSystemCommand.SendFile, eks)
    newReport.PrintingSystem.SetCommandVisibility(DevExpress.XtraPrinting.PrintingSystemCommand.SendGraphic, eks)
    newReport.PrintingSystem.SetCommandVisibility(DevExpress.XtraPrinting.PrintingSystemCommand.SendMht, eks)
    newReport.PrintingSystem.SetCommandVisibility(DevExpress.XtraPrinting.PrintingSystemCommand.SendPdf, eks)
    newReport.PrintingSystem.SetCommandVisibility(DevExpress.XtraPrinting.PrintingSystemCommand.SendRtf, eks)
    newReport.PrintingSystem.SetCommandVisibility(DevExpress.XtraPrinting.PrintingSystemCommand.SendTxt, eks)
    newReport.PrintingSystem.SetCommandVisibility(DevExpress.XtraPrinting.PrintingSystemCommand.SendXls, eks)
    newReport.PrintingSystem.SetCommandVisibility(DevExpress.XtraPrinting.PrintingSystemCommand.SendXlsx, eks)
    newReport.PrintingSystem.SetCommandVisibility(DevExpress.XtraPrinting.PrintingSystemCommand.SendXps, eks)

  End Sub
  Public Sub Print()
    'newReport.PrintingSystem.ExecCommand(DevExpress.XtraPrinting.PrintingSystemCommand.PrintDirect)
    Using printTool As New ReportPrintTool(newReport)
      printTool.Print()
    End Using
  End Sub

  Private Sub ShowDesignerForm(ByVal designForm As Form, ByVal parentForm As Form)
    designForm.MinimumSize = parentForm.MinimumSize
    If parentForm.WindowState = FormWindowState.Normal Then
      designForm.Bounds = parentForm.Bounds
    End If
    designForm.WindowState = parentForm.WindowState
    parentForm.Visible = False
    designForm.ShowDialog()
    parentForm.Visible = True
  End Sub
  Private Sub BarEdit_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles barEdit.ItemClick
    newReport.PrintingSystem.ExecCommand(DevExpress.XtraPrinting.PrintingSystemCommand.StopPageBuilding)

    Using xReport As DevExpress.XtraReports.UI.XtraReport = DevExpress.XtraReports.UI.XtraReport.FromFile(FileName, True)
      Dim designForm As UI_Designer = New UI_Designer()
      designForm.OpenReport(newReport)
      designForm.ActiveXRDesignPanel.FileName = FileName
      ShowDesignerForm(designForm, Me.FindForm())
      If Not (designForm.ActiveXRDesignPanel Is Nothing) AndAlso designForm.ActiveXRDesignPanel.FileName <> FileName AndAlso IO.File.Exists(designForm.ActiveXRDesignPanel.FileName) Then
        IO.File.Copy(designForm.ActiveXRDesignPanel.FileName, FileName, True)
      End If

      designForm.Dispose()
    End Using

    If System.IO.File.Exists(FileName) Then
      newReport.LoadLayout(FileName)
      newReport.CreateDocument(True)
    End If
  End Sub
End Class