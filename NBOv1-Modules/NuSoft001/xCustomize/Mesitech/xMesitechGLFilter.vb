Imports DevExpress.Xpo
Imports DevExpress.Data.Filtering
Public Class xMesitechGLFilter
  Sub New()
    ' This call is required by the designer.
    InitializeComponent()

    ' Add any initialization after the InitializeComponent() call.
    Btn2IsClosedButton = True
    AutoCloseOnSave = True
  End Sub
  Overrides Sub InitializeData()
    txtAkun1.Properties.DataSource = Logic.Coa.GetCoa(session, True) 'New XPCollection(Of Persistent.GlMain)(session)
    txtAkun2.Properties.DataSource = Logic.Coa.GetCoa(session, True) 'New XPCollection(Of Persistent.GlMain)(session)
    txtDivisi.Properties.DataSource = New XPCollection(Of NPO.Modules.ModSys.Divisi)(session)
    txtProyek.Properties.DataSource = New XPCollection(Of Persistent.Proyek)(session)
    txtSubProyek.Properties.DataSource = New XPCollection(Of Persistent.ProyekSub)(session)
    txtKontak.Properties.DataSource = New XPCollection(Of Persistent.Kontak)(session)
    txtNoTransaksi.Properties.DataSource = New XPCollection(Of Persistent.xMesitechGLMain)(session)
    txtNoTransaksi2.Properties.DataSource = New XPCollection(Of Persistent.xMesitechGLMain)(session)
  End Sub
  Overrides Sub Btn1Click()
    Dim result As New List(Of CriteriaOperator)
    Dim format As String = "%{0}%"
    If Not txtTgl1.EditValue Is Nothing Then
      If txtTgl2.EditValue Is Nothing Then
        result.Add(New BinaryOperator("Main.Tanggal", txtTgl1.DateTime, BinaryOperatorType.Equal))
      Else
        result.Add(New BetweenOperator("Main.Tanggal", txtTgl1.DateTime, txtTgl2.DateTime))
      End If
    End If
    If Not txtAkun1.EditValue Is Nothing Then
      If txtAkun2.EditValue Is Nothing Then
        result.Add(New BinaryOperator("Akun.Kode", txtAkun1.EditValue, BinaryOperatorType.Equal))
      Else
        result.Add(New BetweenOperator("Akun.Kode", txtAkun1.EditValue, txtAkun2.EditValue))
      End If
    End If
    If Not txtNoTransaksi.EditValue Is Nothing Then
      If Not txtNoTransaksi2.EditValue Is Nothing Then
        result.Add(New BinaryOperator("Main.Kode", txtNoTransaksi.EditValue, BinaryOperatorType.Equal))
      Else
        result.Add(New BetweenOperator("Main.Kode", txtNoTransaksi.EditValue, txtNoTransaksi2.EditValue))
      End If
    End If
    'If Not txtNoTransaksi.Text Is Nothing Then
    '  If Not txtNoTransaksi2.Text Is Nothing Then
    '    result.Add(New BinaryOperator("Main.Kode", txtNoTransaksi.EditValue, BinaryOperatorType.Equal))
    '  Else
    '    result.Add(New BetweenOperator("Main.Kode", txtNoTransaksi.EditValue, txtNoTransaksi2.EditValue))
    '  End If
    'End If
    If Not txtKontak.EditValue Is Nothing Then
      result.Add(New BinaryOperator("Main.Kontak.Kode", txtKontak.EditValue, BinaryOperatorType.Equal))
    End If
    If txtUraian.Text <> "" Then
      result.Add(New BinaryOperator("Main.Uraian", String.Format(format, txtUraian.Text), BinaryOperatorType.Like))
    End If
    If Not txtDivisi.EditValue Is Nothing Then
      result.Add(New BinaryOperator("Divisi.Kode", txtDivisi.EditValue, BinaryOperatorType.Equal))
    End If
    If Not txtProyek.EditValue Is Nothing Then
      result.Add(New BinaryOperator("Proyek.Kode", txtProyek.EditValue, BinaryOperatorType.Equal))
    End If
    If Not txtSubProyek.EditValue Is Nothing Then
      result.Add(New BinaryOperator("ProyekSub.Kode", txtSubProyek.EditValue, BinaryOperatorType.Equal))
    End If
    CType(Owner, xMesitechGL).InitFilter(GroupOperator.And(result))
  End Sub
End Class