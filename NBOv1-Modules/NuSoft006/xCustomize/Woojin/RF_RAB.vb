Imports DevExpress.Data.Filtering
Imports NuSoft.NPO.Modules.ModSys
Imports DevExpress.Xpo
Friend Class zWoojinRF_RAB
  Private _ReportName As MainClass.reportName
  Sub New(xReportName As MainClass.reportName)
    ' This call is required by the designer.
    InitializeComponent()
    ' Add any initialization after the InitializeComponent() call.
    _ReportName = xReportName
    'Select Case _ReportName
    '  Case MainClass.reportName.zWoojinRekapPPN
    'End Select
  End Sub
  Overrides Sub InitializeData()
    txtProyek.Properties.DataSource = New XPCollection(Of Persistent.Proyek)(_sesi)
  End Sub
  Overrides Sub Filter()
    If CType(txtProyek.EditValue, Persistent.Proyek).RAB Is Nothing Then
      'Utils.Win.MessageBox.Show("RAB untuk proyek tidak tersedia", Me.Text, "", Utils.Win.MessageBox.Button.OK, Utils.Win.MessageBox.Icon.Peringatan)
      Throw New Exception("RAB untuk proyek tidak tersedia")
      Return
    End If

    Dim setting As New NuSoftModSys.LogicLayer.Config(_sesi)
    Dim glSetting As New NuSoft001.Logic.FinaSetting(_sesi)
    AddParameter("CompanyName", setting.NamaPerusahaan, GetType(String))
    AddParameter("Alamat1", setting.Alamat1, GetType(String))
    AddParameter("Alamat2", setting.Alamat2, GetType(String))
    AddParameter("BidangUsaha", setting.BidangUsaha, GetType(String))
    AddParameter("NoFax", setting.NoFax, GetType(String))
    AddParameter("NoTelp", setting.NoTelp, GetType(String))
    AddParameter("FormatString", glSetting.NumericFormatString, GetType(String))


    AddParameter("KodeProyek", CType(txtProyek.EditValue, Persistent.Proyek).Kode, GetType(String))
    AddParameter("NamaProyek", CType(txtProyek.EditValue, Persistent.Proyek).Nama, GetType(String))

    Dim pData As New XPCollection(Of Persistent.ViewRAB)(_sesi, New BinaryOperator("Id.Main.Id", CType(txtProyek.EditValue, Persistent.Proyek).RAB.Id, BinaryOperatorType.Equal))
    Dim pDataPO As New XPCollection(Of Persistent.OrderPembelianDetail)(_sesi, New BinaryOperator("Proyek.Id", CType(txtProyek.EditValue, Persistent.Proyek).Id, BinaryOperatorType.Equal))
    Dim pI As Integer

    For pI = 0 To pData.Count - 1
      pData(pI).QtyPO = pDataPO.Where(Function(m) m.Barang.Id = pData(pI).Id.Barang.Id).Sum(Function(n) n.Qty)
      pData(pI).NilaiPO = pDataPO.Where(Function(m) m.Barang.Id = pData(pI).Id.Barang.Id).Sum(Function(n) n.SubTotal)
    Next
    _dataSource = pData
  End Sub

  Private Sub zWoojinRF_RAB_Load(sender As Object, e As EventArgs) Handles MyBase.Load

  End Sub
End Class