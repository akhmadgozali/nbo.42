Imports DevExpress.Data.Filtering

Public Class pjp_TransaksiTKIDialog
  Private itemToEdit As Persistent.xPJPGLMain
  Private Sub xpColTKI_ResolveSession(sender As Object, e As DevExpress.Xpo.ResolveSessionEventArgs) Handles xpColTKI.ResolveSession
    e.Session = session
  End Sub
  Sub New()
    ' This call is required by the designer.
    InitializeComponent()
    ' Add any initialization after the InitializeComponent() call.
    AutoCloseOnSave = True
    NoDropIdentityMap = True
  End Sub
  Overrides Sub LoadBeforeInitialize()
    txtNilai.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
    txtNilai.Properties.Mask.EditMask = "n2"
    itemToEdit = CType(IdToEdit, Persistent.xPJPGLMain)
    txtNilai.EditValue = "0.0"
    txtNilai.Text = "0.0"
    If My.Computer.FileSystem.FileExists(Logic.Umum.xLokasiLayout("TKIDialogGrid.xml")) = True Then
      xGridView.RestoreLayoutFromXml(Logic.Umum.xLokasiLayout("TKIDialogGrid.xml"))
    End If

  End Sub
  Overrides Sub SimpanData()
    Dim item As Persistent.xPJPGlTKI
    If xGridView.SelectedRowsCount = 0 Then
      Throw New Exception("Silahkan pilih nama TKI")
      Return
    End If
    Dim xIDTKI As Int64
    For i = 0 To xGridView.SelectedRowsCount - 1
      If (xGridView.GetSelectedRows()(i) >= 0) Then
        xIDTKI = Convert.ToInt64(xGridView.GetRowCellValue(xGridView.GetSelectedRows()(i), "Id").ToString())
        'cari dahulu, jika ada maka lewati
        If Not itemToEdit.DetailTKI.ToList.Exists(Function(m) m.TKI.Id = xIDTKI) Then
          item = New Persistent.xPJPGlTKI(session)
          item.Main = itemToEdit
          item.TKI = session.GetObjectByKey(Of NuSoft001.Persistent.xPJPTKI)(xIDTKI)
          item.Nilai = CType(txtNilai.EditValue, Double)
          itemToEdit.DetailTKI.Add(item)
        End If
      End If
    Next
  End Sub


  Private Sub btnTampilkan_Click(sender As Object, e As EventArgs) Handles btnTampilkan.Click
    Dim result As New List(Of CriteriaOperator)
    Dim format As String = "%{0}%"
    If txtNamaTKI.Text <> "" Then
      result.Add(New BinaryOperator("Nama", String.Format(format, txtNamaTKI.Text), BinaryOperatorType.Like))
    End If
    If Not txtTglDaftar.EditValue Is Nothing Then
      result.Add(New BinaryOperator("TanggalDaftar", txtTglDaftar.DateTime, BinaryOperatorType.Equal))
    End If
    If Not txtTglMedicalPra.EditValue Is Nothing Then
      result.Add(New BinaryOperator("TanggalMedicalPra", txtTglMedicalPra.DateTime, BinaryOperatorType.Equal))
    End If
    If Not txtTglMedicalFull.EditValue Is Nothing Then
      result.Add(New BinaryOperator("TanggalMedicalFull", txtTglMedicalFull.DateTime, BinaryOperatorType.Equal))
    End If
    If Not txtTglMedicalTerusan.EditValue Is Nothing Then
      result.Add(New BinaryOperator("TanggalMedicalTerusan", txtTglMedicalTerusan.DateTime, BinaryOperatorType.Equal))
    End If
    If Not txtTglRekomPaspor.EditValue Is Nothing Then
      result.Add(New BinaryOperator("TanggalPasporPengajuan", txtTglRekomPaspor.DateTime, BinaryOperatorType.Equal))
    End If
    If Not txtTglVisa.EditValue Is Nothing Then
      result.Add(New BinaryOperator("TanggalVisa", txtTglRekomPaspor.DateTime, BinaryOperatorType.Equal))
    End If
    If Not txtTglTiket.EditValue Is Nothing Then
      result.Add(New BinaryOperator("TanggalTicket", txtTglTiket.DateTime, BinaryOperatorType.Equal))
    End If
    If Not txtTglSKCK.EditValue Is Nothing Then
      result.Add(New BinaryOperator("TanggalSKCKPengajuan", txtTglSKCK.DateTime, BinaryOperatorType.Equal))
    End If

    xGridView.ActiveFilterCriteria = GroupOperator.And(result)
  End Sub
  Private Sub xGridView_ColumnWidthChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.ColumnEventArgs) Handles xGridView.ColumnWidthChanged
    xGridView.SaveLayoutToXml(Logic.Umum.xLokasiLayout("TkiDialogGrid.xml"))
  End Sub
End Class