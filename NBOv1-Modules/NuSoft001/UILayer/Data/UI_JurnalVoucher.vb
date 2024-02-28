Imports System.Windows.Forms
Imports System.Drawing
Imports DevExpress.Data.Filtering
Imports DevExpress.Xpo

Public Class UI_JurnalVoucher
  Private _NoVoucher As String
  Sub New(xNoVoucher As String)
    ' This call is required by the designer.
    InitializeComponent()
    ' Add any initialization after the InitializeComponent() call.
    _NoVoucher = xNoVoucher
  End Sub
  Overrides Sub FirstLoad()
    Dim setting As New Logic.FinaSetting(session)
    If My.Computer.FileSystem.FileExists(Logic.Umum.xLokasiLayout("JurnalVoucher.xml")) = True Then
      xGridView.RestoreLayoutFromXml(Logic.Umum.xLokasiLayout("JurnalVoucher.xml"))
    End If
    colDebit.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    colDebit.DisplayFormat.FormatString = setting.NumericFormatString
    colKredit.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    colKredit.DisplayFormat.FormatString = setting.NumericFormatString
    colDebitValas.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    colDebitValas.DisplayFormat.FormatString = setting.NumericFormatString
    colKreditValas.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    colKreditValas.DisplayFormat.FormatString = setting.NumericFormatString
    colDebit.SummaryItem.DisplayFormat = setting.NumericFormatString
    colKredit.SummaryItem.DisplayFormat = setting.NumericFormatString
    colDebitValas.SummaryItem.DisplayFormat = setting.NumericFormatString
    colKreditValas.SummaryItem.DisplayFormat = setting.NumericFormatString
    xGrid.DataSource = New XPCollection(Of Persistent.GlMainDetail)(session, New BinaryOperator("Main.Kode", _NoVoucher, BinaryOperatorType.Equal))
    xGridView.OptionsBehavior.ReadOnly = True
    xGridView.OptionsBehavior.Editable = False
    Me.Text = "Jurnal Voucher : " & _NoVoucher
  End Sub
  Private Sub UI_JurnalVoucher_Load(sender As Object, e As EventArgs) Handles Me.Load
    Dim x As Integer
    Dim y As Integer
    x = Screen.PrimaryScreen.WorkingArea.Width
    y = Screen.PrimaryScreen.WorkingArea.Height - Me.Height

    Do Until x = Screen.PrimaryScreen.WorkingArea.Width - Me.Width
      x = x - 1
      Me.Location = New Point(x, y)
    Loop
  End Sub
  Private Sub xGridView_ColumnWidthChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.ColumnEventArgs) Handles xGridView.ColumnWidthChanged
    xGridView.SaveLayoutToXml(Logic.Umum.xLokasiLayout("JurnalVoucher.xml"))
  End Sub
End Class