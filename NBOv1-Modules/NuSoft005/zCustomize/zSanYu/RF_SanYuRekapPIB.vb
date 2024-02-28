Imports DevExpress.Data.Filtering
Imports NuSoft.NPO.Modules.ModSys
Imports DevExpress.Xpo
Friend Class RF_SanYuRekapPIB
  Private _ReportName As MainClass.reportName
  'Sub New(xReportName As MainClass.reportName)
  '  Me.New(xReportName)
  'End Sub
  Sub New(xReportName As MainClass.reportName)
    ' This call is required by the designer.
    InitializeComponent()
    ' Add any initialization after the InitializeComponent() call.
    _ReportName = xReportName
  End Sub

  Overrides Sub Filter()
    Dim setting As New NuSoftModSys.LogicLayer.Config(_sesi)
    Dim glSetting As New NuSoft001.Logic.FinaSetting(_sesi)
    AddParameter("CompanyName", setting.NamaPerusahaan, GetType(String))
    AddParameter("Alamat1", setting.Alamat1, GetType(String))
    AddParameter("Alamat2", setting.Alamat2, GetType(String))
    AddParameter("BidangUsaha", setting.BidangUsaha, GetType(String))
    AddParameter("NoFax", setting.NoFax, GetType(String))
    AddParameter("NoTelp", setting.NoTelp, GetType(String))
    AddParameter("FormatString", glSetting.NumericFormatString, GetType(String))

    Select Case _ReportName
      Case MainClass.reportName.zSanyuRekapPIB : _dataSource = New XPCollection(Of Persistent.SanYu_PIBDetail)(_sesi, CreateCriteria)
      Case MainClass.reportName.zSanyuRekapPIBRealisasi : _dataSource = New XPCollection(Of Persistent.SanYu_PenerimaanBarangDetail)(_sesi, CreateCriteria2)
    End Select

  End Sub
  Private Function CreateCriteria2() As CriteriaOperator
    Dim result As New List(Of CriteriaOperator)
    Dim format As String = "%{0}%"

    result.Add(New BinaryOperator("Main.Sumber", Persistent.SumberDataJenis.GR, BinaryOperatorType.Equal))

    If txtFasilitasKite.CheckState = Windows.Forms.CheckState.Checked Then
      result.Add(New BinaryOperator("NoPIB.Kite", True, BinaryOperatorType.Equal))
    ElseIf txtFasilitasKite.CheckState = Windows.Forms.CheckState.Unchecked Then
      result.Add(New BinaryOperator("NoPIB.Kite", False, BinaryOperatorType.Equal))
    End If
    If Not txtTgl1.EditValue Is Nothing Then
      If txtTgl2.EditValue Is Nothing Then
        result.Add(New BinaryOperator("NoPIB.Main.Tanggal", txtTgl1.DateTime, BinaryOperatorType.Equal))
      Else
        result.Add(New BetweenOperator("NoPIB.Main.Tanggal", txtTgl1.DateTime, txtTgl2.DateTime))
      End If
    End If
    If txtNoPengajuan.Text <> "" Then
      result.Add(New BinaryOperator("NoPIB.Main.NoPengajuan", String.Format(format, txtNoPengajuan.Text), BinaryOperatorType.Like))
    End If
    If txtNoPendaftaran.Text <> "" Then
      result.Add(New BinaryOperator("NoPIB.Main.NoPendaftaran", String.Format(format, txtNoPendaftaran.Text), BinaryOperatorType.Like))
    End If
    If Not txtTglPendaftaran.EditValue Is Nothing Then
      If txtTglPendaftaran2.EditValue Is Nothing Then
        result.Add(New BinaryOperator("NoPIB.Main.TglPendaftaran", txtTglPendaftaran.DateTime, BinaryOperatorType.Equal))
      Else
        result.Add(New BetweenOperator("NoPIB.Main.TglPendaftaran", txtTglPendaftaran.DateTime, txtTglPendaftaran2.DateTime))
      End If
    End If
    If txtKPBC.Text <> "" Then
      result.Add(New BinaryOperator("NoPIB.Main.KPBC", String.Format(format, txtKPBC.Text), BinaryOperatorType.Like))
    End If
    Return GroupOperator.And(result)
  End Function
  Private Function CreateCriteria() As CriteriaOperator
    Dim result As New List(Of CriteriaOperator)
    Dim format As String = "%{0}%"

    If txtFasilitasKite.CheckState = Windows.Forms.CheckState.Checked Then
      result.Add(New BinaryOperator("Kite", True, BinaryOperatorType.Equal))
    ElseIf txtFasilitasKite.CheckState = Windows.Forms.CheckState.Unchecked Then
      result.Add(New BinaryOperator("Kite", False, BinaryOperatorType.Equal))
    End If
    If Not txtTgl1.EditValue Is Nothing Then
      If txtTgl2.EditValue Is Nothing Then
        result.Add(New BinaryOperator("Main.Tanggal", txtTgl1.DateTime, BinaryOperatorType.Equal))
      Else
        result.Add(New BetweenOperator("Main.Tanggal", txtTgl1.DateTime, txtTgl2.DateTime))
      End If
    End If
    If txtNoPengajuan.Text <> "" Then
      result.Add(New BinaryOperator("Main.NoPengajuan", String.Format(format, txtNoPengajuan.Text), BinaryOperatorType.Like))
    End If
    If txtNoPendaftaran.Text <> "" Then
      result.Add(New BinaryOperator("Main.NoPendaftaran", String.Format(format, txtNoPendaftaran.Text), BinaryOperatorType.Like))
    End If
    If Not txtTglPendaftaran.EditValue Is Nothing Then
      If txtTglPendaftaran2.EditValue Is Nothing Then
        result.Add(New BinaryOperator("Main.TglPendaftaran", txtTglPendaftaran.DateTime, BinaryOperatorType.Equal))
      Else
        result.Add(New BetweenOperator("Main.TglPendaftaran", txtTglPendaftaran.DateTime, txtTglPendaftaran2.DateTime))
      End If
    End If
    If txtKPBC.Text <> "" Then
      result.Add(New BinaryOperator("Main.KPBC", String.Format(format, txtKPBC.Text), BinaryOperatorType.Like))
    End If
    Return GroupOperator.And(result)
  End Function
  Private Sub txtTgl1_EditValueChanging(sender As Object, e As DevExpress.XtraEditors.Controls.ChangingEventArgs) Handles txtTgl1.EditValueChanging
    txtTgl2.Properties.MinValue = CDate(e.NewValue)
  End Sub
  Private Sub txtTgl2_EditValueChanging(sender As Object, e As DevExpress.XtraEditors.Controls.ChangingEventArgs) Handles txtTgl2.EditValueChanging
    txtTgl1.Properties.MaxValue = CDate(e.NewValue)
  End Sub
End Class