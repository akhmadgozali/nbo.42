Friend Class UI_Aktiva
  Sub New()
    ' This call is required by the designer.
    InitializeComponent()
    ' Add any initialization after the InitializeComponent() call.
    baseView = xGridView
    KeyField = "Id"
  End Sub
  Public Overrides Sub FirstLoad()
    'load setingan default kolom
    If My.Computer.FileSystem.FileExists(Logic.Umum.xLokasiLayout("masteraktiva.xml")) = True Then
      xGridView.RestoreLayoutFromXml(Logic.Umum.xLokasiLayout("masteraktiva.xml"))
    End If
  End Sub
  Overrides Function GetDialogForm() As Core.Win.Forms.InputBase
    Return New UI_AktivaDialog
  End Function
  Public Overrides Function GetKeteranganHapus(selectedRows() As Integer) As System.Collections.Generic.List(Of Core.Win.Forms.GridDeletedData)
    Dim result As New List(Of Core.Win.Forms.GridDeletedData)
    Dim item As Core.Win.Forms.GridDeletedData

    For i = selectedRows.GetLowerBound(0) To selectedRows.GetUpperBound(0)
      If Not xGridView.IsGroupRow(selectedRows(i)) Then
        item = New Core.Win.Forms.GridDeletedData
        item.Row = selectedRows(i)
        item.Data = String.Format("{0} - {1}", xGridView.GetRowCellValue(selectedRows(i), "Kode"), xGridView.GetRowCellValue(selectedRows(i), "Nama"))
        result.Add(item)
      End If
    Next
    Return result
  End Function
  Public Overrides Function HapusData(selectedData As System.Collections.Generic.List(Of Core.Win.Forms.GridDeletedData)) As Boolean
    For i = 0 To selectedData.Count - 1
      If Not xGridView.IsGroupRow(selectedData(i).Row) Then
        CType(xGridView.GetRow(selectedData(i).Row), Persistent.AktivaTetap).Delete()
      End If
    Next
    session.CommitChanges()
    Return True
  End Function
  Public Overrides Sub GridViewColumnWidthChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.ColumnEventArgs)
    xGridView.SaveLayoutToXml(Logic.Umum.xLokasiLayout("masteraktiva.xml"))
  End Sub
  Private Sub btnResetUlang_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnResetUlang.ItemClick

    If MsgBox("Apakah anda yakin ingin membuat ulang tabel penyusutan?", vbYesNo, "Konfirmasi") = MsgBoxResult.Yes Then
      Dim xDataAsset As New DevExpress.Xpo.XPCollection(Of Persistent.AktivaTetap)(session)
      For pK = 0 To xDataAsset.Count - 1
        'create tabel penyusutannya
        Dim TipePenyusutan As Persistent.ePenyusutanAsset
        Dim xHarga As Double, xResidu As Double, xUmur As Long, txtNilaiPenyusutan As Double

        TipePenyusutan = xDataAsset(pK).Kelompok.TipePenyusutan
        xHarga = xDataAsset(pK).Harga
        xResidu = xDataAsset(pK).NilaiResidu
        xUmur = xDataAsset(pK).Kelompok.Umur

        Dim xDate As Date = xDataAsset(pK).TanggalBeli, xSisaUmur As Long = xUmur, pI As Integer = 1
        txtNilaiPenyusutan = (xHarga - xResidu) / xUmur
        xSisaUmur = xUmur
        If TipePenyusutan = Persistent.ePenyusutanAsset.TanpaPenyusutan Then
          xSisaUmur = 0
          txtNilaiPenyusutan = 0
        End If

        If xDataAsset(pK).Tgl15 = True Then
          If Day(xDataAsset(pK).TanggalBeli) > 15 Then
            xDate = DateAdd(DateInterval.Month, 1, xDate)
          End If
        End If

        Do While xSisaUmur > 0
          Dim detail As Persistent.AktivaTetapPenyusutan = xDataAsset(pK).Depreciation.ToList.Find(Function(m) m.Sequence = pI)
          If detail Is Nothing Then
            detail = New Persistent.AktivaTetapPenyusutan(session)
            detail.Sequence = pI
            xDataAsset(pK).Depreciation.Add(detail)
          End If
          If pI = 1 Then
            detail.Month = CShort(13 - Month(xDate))
          Else
            If xSisaUmur > 11 Then
              detail.Month = 12
            Else
              detail.Month = CShort(xSisaUmur)
            End If
          End If
          detail.Sequence = pI
          detail.Year = Year(xDate)
          detail.TglAwal = xDate
          xDate = DateAdd(DateInterval.Month, detail.Month - 1, xDate)
          detail.TglAkhir = xDate
          detail.Nilai = txtNilaiPenyusutan
          xSisaUmur = xSisaUmur - detail.Month
          xDate = DateAdd(DateInterval.Month, 1, xDate)
          pI = pI + 1
        Loop

        For i = xDataAsset(pK).Depreciation.Count - 1 To pI - 1 Step -1
          xDataAsset(pK).Depreciation(i).Delete()
        Next

        If TipePenyusutan = Persistent.ePenyusutanAsset.SaldoMenurun Then
          Dim xNilaiPenyusutan As Double, xNilaiBuku As Double, xPresentase As Double
          xPresentase = 200 / (xUmur)
          xNilaiBuku = CDbl(xDataAsset(pK).Harga) - CDbl(xDataAsset(pK).NilaiResidu)

          For i = 0 To xDataAsset(pK).Depreciation.Count - 1
            If i = xDataAsset(pK).Depreciation.Count - 1 Then
              xNilaiPenyusutan = xNilaiBuku / xDataAsset(pK).Depreciation(i).Month
            Else
              xNilaiPenyusutan = (xPresentase / 100 * xNilaiBuku) / 12
            End If
            xDataAsset(pK).Depreciation(i).Nilai = xNilaiPenyusutan
            xNilaiBuku = xNilaiBuku - (xDataAsset(pK).Depreciation(i).Total)
          Next
        End If
      Next
      session.CommitChanges()
      MsgBox("Proses selesai.")
    End If
  End Sub
End Class