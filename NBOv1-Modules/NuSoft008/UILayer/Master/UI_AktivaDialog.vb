Imports DevExpress.Xpo
Friend Class UI_AktivaDialog
  Private instance As Persistent.AktivaTetap
  Private editAsign As Boolean
  Sub New()
    ' This call is required by the designer.
    InitializeComponent()
    ' Add any initialization after the InitializeComponent() call.
    AutoCloseOnSave = True
  End Sub
  Public Overrides Sub LoadBeforeInitialize()
    If My.Computer.FileSystem.FileExists(Logic.Umum.xLokasiLayout("masteraktivadialog.xml")) = True Then
      lytControl.RestoreLayoutFromXml(Logic.Umum.xLokasiLayout("masteraktivadialog.xml"))
    End If
    Dim setting As New NuSoft001.Logic.FinaSetting(session)
    colMonth.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    colMonth.DisplayFormat.FormatString = setting.NumericFormatString
    colMonth.SummaryItem.DisplayFormat = setting.NumericFormatString
    colNilai.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    colNilai.DisplayFormat.FormatString = setting.NumericFormatString
    colNilai.SummaryItem.DisplayFormat = setting.NumericFormatString
    colTotal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    colTotal.DisplayFormat.FormatString = setting.NumericFormatString
    colTotal.SummaryItem.DisplayFormat = setting.NumericFormatString

    txtHargaBeli.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
    txtHargaBeli.Properties.Mask.EditMask = setting.NumericFormatToString
    txtNilaiResidu.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
    txtNilaiResidu.Properties.Mask.EditMask = setting.NumericFormatToString
    txtNilaiPenyusutan.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
    txtNilaiPenyusutan.Properties.Mask.EditMask = setting.NumericFormatToString
  End Sub
  Public Overrides Sub LoadAfterInitialize()
    editAsign = True
    txtKelompok.Properties.DataSource = New XPCollection(Of Persistent.AktivaKelompok)(session)
    If Tipe = InputType.Tambah Then
      Me.Text = "Aktiva Tetap : Tambah"
      instance = New Persistent.AktivaTetap(session)
      txtUmur.EditValue = 12
      txtQty.EditValue = 1
      txtTglBeli.EditValue = Now
      txtTglPakai.EditValue = Now
      txtHargaBeli.EditValue = 0
      txtNilaiResidu.EditValue = 0
      txtNilaiPenyusutan.EditValue = 0
      txtKelompok.EditValue = Core.Win.Component.XtraLookUpEdit.GetFirstValue(txtKelompok)
      If Not txtKelompok.EditValue Is Nothing Then
        txtUmur.EditValue = CType(txtKelompok.EditValue, Persistent.AktivaKelompok).Umur
      End If
    Else
      instance = session.GetObjectByKey(Of Persistent.AktivaTetap)(CType(IdToEdit, Int32))
      txtKelompok.EditValue = instance.Kelompok
      txtKode.EditValue = instance.Kode
      txtNama.EditValue = instance.Nama
      txtUmur.EditValue = instance.Kelompok.Umur
      txtQty.EditValue = instance.Qty
      txtHargaBeli.EditValue = instance.Harga
      txtNilaiResidu.EditValue = instance.NilaiResidu
      txtTglBeli.EditValue = instance.TanggalBeli
      txtTglPakai.EditValue = instance.TanggalPakai
      txtNilaiPenyusutan.EditValue = (instance.Harga - instance.NilaiResidu) / CDbl(txtUmur.EditValue)
      txtTgl15.Checked = instance.Tgl15
      txtAktivaTidakBerwujud.Checked = instance.Intangible

      xGrid.DataSource = instance.Depreciation


      Me.Text = "Aktiva Tetap : Edit - " & instance.Kode
    End If
    editAsign = False
  End Sub
  Public Overrides Sub SimpanData()
    instance.Kode = txtKode.Text
    instance.Nama = txtNama.Text
    instance.Kelompok = CType(txtKelompok.EditValue, Persistent.AktivaKelompok)
    instance.Qty = CType(txtQty.Text, Double)
    instance.Harga = CType(txtHargaBeli.Text, Double)
    instance.NilaiResidu = CType(txtNilaiResidu.Text, Double)
    instance.TanggalBeli = txtTglBeli.DateTime
    instance.TanggalPakai = txtTglPakai.DateTime
    instance.Tgl15 = txtTgl15.Checked
    instance.Intangible = txtAktivaTidakBerwujud.Checked
    instance.Save()
    session.CommitChanges()
  End Sub

  Public Overrides Sub ErrorSimpan(ByVal ex As Utils.Exception)
    ex.ShowWinMessageBox()
    Select Case ex.ErrorNumber
      Case -2 : txtKode.Focus()
      Case -3 : txtKode.Focus()
      Case -4 : txtUmur.Focus()
      Case Else
    End Select
  End Sub
  Private Sub xpCol_ResolveSession(sender As Object, e As DevExpress.Xpo.ResolveSessionEventArgs)
    e.Session = session
  End Sub
  Private Sub txtKelompok_EditValueChanged(sender As Object, e As EventArgs) Handles txtKelompok.EditValueChanged
    If editAsign = False Then
      txtUmur.EditValue = CType(txtKelompok.EditValue, Persistent.AktivaKelompok).Umur
      HitungPenyusutan()
    End If
  End Sub
  Private Sub txtHargaBeli_EditValueChanged(sender As Object, e As System.EventArgs) Handles txtHargaBeli.EditValueChanged
    If editAsign = False Then
      HitungPenyusutan()
    End If
  End Sub
  Private Sub txtNilaiResidu_EditValueChanged(sender As Object, e As System.EventArgs) Handles txtNilaiResidu.EditValueChanged
    If editAsign = False Then
      HitungPenyusutan()
    End If
  End Sub
  Sub HitungPenyusutan() 'TipePenyusutan As Persistent.ePenyusutanAsset, xHarga As Double, xResidu As Double, xUmur As Long
    If editAsign = False Then
      Dim TipePenyusutan As Persistent.ePenyusutanAsset
      Dim xHarga As Double, xResidu As Double, xUmur As Long

      TipePenyusutan = CType(txtKelompok.EditValue, Persistent.AktivaKelompok).TipePenyusutan
      xHarga = CDbl(txtHargaBeli.EditValue)
      xResidu = CDbl(txtNilaiResidu.EditValue)
      xUmur = CLng(txtUmur.EditValue)

      Dim xDate As Date = txtTglBeli.DateTime, xSisaUmur As Long = CType(txtUmur.EditValue, Long), pI As Integer = 1
      txtNilaiPenyusutan.EditValue = (xHarga - xResidu) / xUmur
      xSisaUmur = xUmur
      If CType(txtKelompok.EditValue, Persistent.AktivaKelompok).TipePenyusutan = Persistent.ePenyusutanAsset.TanpaPenyusutan Then
        xSisaUmur = 0
        txtNilaiPenyusutan.EditValue = 0
      End If

      If txtTgl15.Checked = True Then
        If Day(txtTglBeli.DateTime) > 15 Then
          xDate = DateAdd(DateInterval.Month, 1, xDate)
        End If
      End If

      Do While xSisaUmur > 0
        Dim detail As Persistent.AktivaTetapPenyusutan = instance.Depreciation.ToList.Find(Function(m) m.Sequence = pI)
        If detail Is Nothing Then
          detail = New Persistent.AktivaTetapPenyusutan(session)
          detail.Sequence = pI
          instance.Depreciation.Add(detail)
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
        detail.Nilai = CType(txtNilaiPenyusutan.EditValue, Double)
        xSisaUmur = xSisaUmur - detail.Month
        xDate = DateAdd(DateInterval.Month, 1, xDate)
        pI = pI + 1
      Loop

      For i = instance.Depreciation.Count - 1 To pI - 1 Step -1
        instance.Depreciation(i).Delete()
      Next

      If TipePenyusutan = Persistent.ePenyusutanAsset.SaldoMenurun Then
        Dim xNilaiPenyusutan As Double, xNilaiBuku As Double, xPresentase As Double
        xPresentase = 200 / (CDbl(txtUmur.EditValue) / 12)
        xNilaiBuku = CDbl(txtHargaBeli.EditValue) - CDbl(txtNilaiResidu.EditValue)

        For i = 0 To instance.Depreciation.Count - 1
          If i = instance.Depreciation.Count - 1 Then
            xNilaiPenyusutan = xNilaiBuku / instance.Depreciation(i).Month
          Else
            xNilaiPenyusutan = (xPresentase / 100 * xNilaiBuku) / 12
          End If
          instance.Depreciation(i).Nilai = xNilaiPenyusutan
          xNilaiBuku = xNilaiBuku - (instance.Depreciation(i).Total)
        Next
      End If

      xGrid.DataSource = Nothing
      xGrid.DataSource = instance.Depreciation
    End If
  End Sub
  Private Sub txtTgl15_CheckedChanged(sender As Object, e As EventArgs) Handles txtTgl15.CheckedChanged
    If editAsign = False Then
      HitungPenyusutan()
    End If
  End Sub
  Private Sub txtTglBeli_DateTimeChanged(sender As Object, e As System.EventArgs) Handles txtTglBeli.DateTimeChanged
    If editAsign = False Then
      'HitungPenyusutan()
    End If
  End Sub
End Class