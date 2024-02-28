Imports DevExpress.Data.Filtering
Imports NuSoft.NPO.Modules.ModSys
Imports DevExpress.Xpo
Imports NuSoft.Core.SSystem
Imports System.Windows.Forms
Imports NuSoft.Utils.CustomAttribute
Friend Class RF_Item
  Public Enum TipeRF_Item
    <EnumDescription("Barang Reorder")> BarangReorder = 0
  End Enum
  Private glSetting As NuSoft001.Logic.FinaSetting
  Private _tipedata As TipeRF_Item
  Sub New(xTipe As TipeRF_Item)
    ' This call is required by the designer.
    InitializeComponent()
    ' Add any initialization after the InitializeComponent() call.
    _tipedata = xTipe
  End Sub
  Overrides Sub InitializeData()
    glSetting = New NuSoft001.Logic.FinaSetting(_sesi)
    txtTanggal.DateTime = Now
  End Sub
  Overrides Sub Filter()
    Dim setting As New NuSoftModSys.LogicLayer.Config(_sesi)
    AddParameter("CompanyName", setting.NamaPerusahaan, GetType(String))
    AddParameter("Alamat1", setting.Alamat1, GetType(String))
    AddParameter("Alamat2", setting.Alamat2, GetType(String))
    AddParameter("BidangUsaha", setting.BidangUsaha, GetType(String))
    AddParameter("NoFax", setting.NoFax, GetType(String))
    AddParameter("NoTelp", setting.NoTelp, GetType(String))
    AddParameter("FormatString", glSetting.NumericFormatString, GetType(String))
    AddParameter("Periode", Format(txtTanggal.DateTime, "dd-MMMM-yyyy").ToString, GetType(String))
    Select Case _tipedata
      Case TipeRF_Item.BarangReorder
        CreateDataBarangReorder()
        Return
      Case Else
        _dataSource = New DevExpress.Xpo.XPCollection(Of Persistent.ViewInvoice)(_sesi, CreateCriteria)
    End Select
  End Sub
  Private Sub CreateDataBarangReorder()
    Dim xData As New XPCollection(Of Persistent.ViewItem)(_sesi, CreateCriteria)
    Dim xDataStock As New XPCollection(Of Persistent.StockDetail)(_sesi, New BinaryOperator("Main.Tanggal", txtTanggal.DateTime, BinaryOperatorType.LessOrEqual))
    Dim pI As Int64
    For pI = 0 To xData.Count - 1
      xData(pI).stockin = xDataStock.Where(Function(m) m.Barang.Id = xData(pI).Barang.Id).Sum(Function(n) n.QtyIn)
      xData(pI).stockout = xDataStock.Where(Function(m) m.Barang.Id = xData(pI).Barang.Id).Sum(Function(n) n.QtyOut)
    Next
    If chkSemua.Checked = True Then
      _dataSource = xData
    Else
      _dataSource = xData.Where(Function(m) m.Barang.StockMin > 0 And m.Barang.StockMin > (m.stockin - m.stockout))
    End If
  End Sub
  Private Function CreateCriteria() As CriteriaOperator
    Dim result As New List(Of CriteriaOperator)
    Dim format As String = "%{0}%"

    If Not txtKode.EditValue Is Nothing Then
      result.Add(New BinaryOperator("Barang.Kode", txtKode.EditValue, BinaryOperatorType.Like))
    End If
    If Not txtNama.EditValue Is Nothing Then
      result.Add(New BinaryOperator("Barang.Nama", txtNama.EditValue, BinaryOperatorType.Like))
    End If

    Return GroupOperator.And(result)
  End Function
End Class