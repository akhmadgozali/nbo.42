Imports DevExpress.Xpo
Imports DevExpress.Data.Filtering
Imports NuSoft.NPO

Namespace Logic
  Public Class FinaSetting
    Inherits Core.Modules.SettingBase

    Property AwalPeriodeBulan As Integer
    Property AwalPeriodeTahun As Integer
    Property MultiDivisi As Boolean
    Property MultiProyek As Boolean
    Property MultiMataUangPakai As Boolean
    Property MultiMataUangAkunKurs As Integer
    Property MultiMataUangDefault As Integer
    Property FormatDigit As Integer
    Property FormatNomor As String
    Property PenampungSaldoAwal As Integer
    Property CoaKasBankPadaJU As Boolean

    Property UraianKM As String
    Property UraianKK As String
    Property UraianBM As String
    Property UraianBK As String
    Property UraianJU As String
    Property UraianJA As String
    Property UraianSA As String
    Property UraianGM As String
    Property UraianGK As String
    Property UraianPD As String

    ReadOnly Property NumericFormatString As String
      Get
        Return "{0:n" & FormatDigit & "}"
      End Get
    End Property
    ReadOnly Property NumericFormatToString As String
      Get
        Return "n" & FormatDigit
      End Get
    End Property
    ReadOnly Property FormatAngka() As String
      Get
        Dim result As String

        If IsNumeric(FormatDigit) Then
          If FormatDigit > 0 Then
            result = String.Format("#,##0.{0}", Microsoft.VisualBasic.Strings.StrDup(FormatDigit, "0"))
          Else
            result = "#,##0"
          End If
        Else
          result = "#,##0.00"
        End If

        Return result
      End Get
    End Property
    ReadOnly Property FormatAngkaNegativMinus() As String
      Get
        Dim result As String

        If IsNumeric(FormatDigit) Then
          If FormatDigit > 0 Then
            result = String.Format("#,##0.{0};-#,##0.{0}", Microsoft.VisualBasic.Strings.StrDup(FormatDigit, "0"))
          Else
            result = "#,##0;-#,##0"
          End If
        Else
          result = "#,##0.00;-#,##0.00"
        End If

        Return result
      End Get
    End Property
    ReadOnly Property FormatAngkaNegativKurung() As String
      Get
        Dim result As String

        If IsNumeric(FormatDigit) Then
          If FormatDigit > 0 Then
            result = String.Format("#,##0.{0};(#,##0.{0})", Microsoft.VisualBasic.Strings.StrDup(FormatDigit, "0"))
          Else
            result = "#,##0;(#,##0)"
          End If
        Else
          result = "#,##0.00;(#,##0.00)"
        End If

        Return result
      End Get
    End Property

    Sub New(session As DevExpress.Xpo.UnitOfWork)
      MyBase.New(session)
    End Sub
    Public Overrides Function ModuleId() As NPO.Modules.ModuleId
      Return MainClass.GetModuleId
    End Function
  End Class
End Namespace

Namespace Persistent
  <Persistent("m01zregional")>
  Public Class SettingRegional
    Inherits NPOBase

    Public Sub New(ByVal session As UnitOfWork)
      MyBase.New(session)
    End Sub
    Public Sub New(ByVal session As UnitOfWork, ByVal classInfo As DevExpress.Xpo.Metadata.XPClassInfo)
      MyBase.New(session, classInfo)
    End Sub

    Private _regional As NPO.Modules.ModSys.Regional
    Private _akunKas As Coa
    Private _formatTransaksi As String
    Private _kasir As String
    Private _kasirBank As String
    Private _akunting As String
    Private _direktur As String

    <Persistent("p_id"), Key()> Property Regional As NPO.Modules.ModSys.Regional
      Get
        Return _regional
      End Get
      Set(value As NPO.Modules.ModSys.Regional)
        SetPropertyValue(Of NPO.Modules.ModSys.Regional)("Regional", _regional, value)
      End Set
    End Property
    <Persistent("f_coacash")> Property AkunKas As Coa
      Get
        Return _akunKas
      End Get
      Set(value As Coa)
        SetPropertyValue(Of Coa)("AkunKas", _akunKas, value)
      End Set
    End Property
    <Persistent("d_format")> Property FormatTransaksi As String
      Get
        Return _formatTransaksi
      End Get
      Set(value As String)
        SetPropertyValue(Of String)("FormatTransaksi", _formatTransaksi, value)
      End Set
    End Property
    <Persistent("d_cashier")> Property Kasir As String
      Get
        Return _kasir
      End Get
      Set(value As String)
        SetPropertyValue(Of String)("Kasir", _kasir, value)
      End Set
    End Property
    <Persistent("d_cashierbank")> Property KasirBank As String
      Get
        Return _kasirBank
      End Get
      Set(value As String)
        SetPropertyValue(Of String)("KasirBank", _kasirBank, value)
      End Set
    End Property
    <Persistent("d_accounting")> Property Akunting As String
      Get
        Return _akunting
      End Get
      Set(value As String)
        SetPropertyValue(Of String)("Akunting", _akunting, value)
      End Set
    End Property
    <Persistent("d_director")> Property Direktur As String
      Get
        Return _direktur
      End Get
      Set(value As String)
        SetPropertyValue(Of String)("Direktur", _direktur, value)
      End Set
    End Property
  End Class

  '<Persistent("m01source")> Public Class SumberData
  '  Inherits XPLiteObject

  '  Public Sub New(ByVal session As UnitOfWork)
  '    MyBase.New(session)
  '  End Sub
  '  Public Sub New(ByVal session As UnitOfWork, ByVal classInfo As DevExpress.Xpo.Metadata.XPClassInfo)
  '    MyBase.New(session, classInfo)
  '  End Sub

  '  <Persistent("p_id"), Key()> Property Id As Int16
  '  <Persistent("u_code"), Size(2)> Property Kode As String
  '  <Persistent("d_note")> Property Keterangan As String
  '  <NonPersistent> Property Jenis As SumberDataJenis
  'End Class
  'Public Enum SumberDataJenis
  '  KM = 1
  '  KK = 2
  '  BM = 3
  '  BK = 4
  '  JU = 5
  '  JA = 6
  '  LA = 7
  '  RV = 8
  '  SA = 9
  '  PD = 10
  '  FA = 11
  '  PB = 12
  '  ST = 13
  '  AM = 14
  '  PS = 15
  '  OS = 16
  '  PR = 17
  '  RQ = 18
  '  PO = 19
  '  AP = 20
  '  GR = 21
  '  RI = 22
  '  VP = 23
  '  DN = 24
  '  PN = 25
  '  SQ = 26
  '  SO = 27
  '  DP = 28
  '  SJ = 29
  '  IV = 30
  '  CP = 31
  '  RN = 32
  '  SR = 33
  '  BS = 34
  '  PE = 35
  'End Enum
  'Public Class SumberDataCollection
  '  Implements IList
  '  Property session As DevExpress.Xpo.UnitOfWork
  '  Public Sub New(ByVal session As UnitOfWork)
  '    Me.session = session
  '  End Sub
  '  Protected ReadOnly Property Objects As IList
  '    Get
  '      Return CreateObjects()
  '    End Get
  '  End Property
  '  Private Function CreateObjects() As IList
  '    If session Is Nothing Then
  '      Throw New Utils.Exception("Parameter session belum di set", -11, "Set session di sub new atau property", "CreateObjects")
  '    End If

  '    Dim result As New List(Of SumberData)

  '    result.Add(AddItem(SumberDataJenis.BK, "Bank Keluar"))
  '    result.Add(AddItem(SumberDataJenis.BM, "Bank Masuk"))
  '    result.Add(AddItem(SumberDataJenis.KK, "Kas Keluar"))
  '    result.Add(AddItem(SumberDataJenis.KM, "Kas Masuk"))
  '    result.Add(AddItem(SumberDataJenis.JA, "Jurnal Adjusment"))
  '    result.Add(AddItem(SumberDataJenis.JU, "Jurnal Umum"))
  '    result.Add(AddItem(SumberDataJenis.LA, "Load Administration"))
  '    result.Add(AddItem(SumberDataJenis.RV, "Revaluasi Valas"))
  '    result.Add(AddItem(SumberDataJenis.SA, "Saldo Awal"))
  '    result.Add(AddItem(SumberDataJenis.PD, "Pengajuan Dana"))
  '    result.Add(AddItem(SumberDataJenis.FA, "Fixed Asset"))
  '    result.Add(AddItem(SumberDataJenis.PB, "Permintaan Barang"))
  '    result.Add(AddItem(SumberDataJenis.ST, "Mutasi Stock"))
  '    result.Add(AddItem(SumberDataJenis.AM, "Produksi"))
  '    result.Add(AddItem(SumberDataJenis.PS, "Penyesuaian Stock"))
  '    result.Add(AddItem(SumberDataJenis.OS, "Stock Opname"))
  '    result.Add(AddItem(SumberDataJenis.PR, "Permintaan Pembelian"))
  '    result.Add(AddItem(SumberDataJenis.RQ, "Permintaan Penawaran"))
  '    result.Add(AddItem(SumberDataJenis.PO, "Order Pembelian"))
  '    result.Add(AddItem(SumberDataJenis.AP, "DP Pembelian"))
  '    result.Add(AddItem(SumberDataJenis.GR, "Penerimaan Barang"))
  '    result.Add(AddItem(SumberDataJenis.RI, "Penerimaan Invoice"))
  '    result.Add(AddItem(SumberDataJenis.VP, "Pembayaran Hutang"))
  '    result.Add(AddItem(SumberDataJenis.DN, "Pengiriman Retur"))
  '    result.Add(AddItem(SumberDataJenis.PN, "Retur Pembelian"))
  '    result.Add(AddItem(SumberDataJenis.SQ, "Penawaran Penjualan"))
  '    result.Add(AddItem(SumberDataJenis.SO, "Order Penjualan"))
  '    result.Add(AddItem(SumberDataJenis.DP, "DP Penjualan"))
  '    result.Add(AddItem(SumberDataJenis.SJ, "Surat Jalan"))
  '    result.Add(AddItem(SumberDataJenis.IV, "Invoice Penjualan"))
  '    result.Add(AddItem(SumberDataJenis.CP, "Penerimaan Piutang"))
  '    result.Add(AddItem(SumberDataJenis.RN, "Penerimaan Retur"))
  '    result.Add(AddItem(SumberDataJenis.SR, "Retur Penjualan"))
  '    result.Add(AddItem(SumberDataJenis.BS, "Saldo Awal Stock"))
  '    result.Add(AddItem(SumberDataJenis.PE, "Amortisasi Prepaid Expense"))
  '    Return result
  '  End Function
  '  Private Function AddItem(Id As SumberDataJenis, Keterangan As String) As SumberData
  '    Dim result As SumberData = session.GetObjectByKey(Of SumberData)(CType(Id, Int16))

  '    If result Is Nothing Then
  '      result = New SumberData(session)
  '      result.Id = CType(Id, Int16)
  '      result.Kode = Id.ToString
  '      result.Keterangan = Keterangan
  '      result.Jenis = Id
  '      result.Save()
  '    End If
  '    Return result
  '  End Function

  '  Public Function Add(value As Object) As Integer Implements System.Collections.IList.Add
  '    Return Objects.Add(value)
  '  End Function
  '  Public Sub Clear() Implements System.Collections.IList.Clear
  '    Objects.Clear()
  '  End Sub
  '  Public Function Contains(value As Object) As Boolean Implements System.Collections.IList.Contains
  '    Return Objects.Contains(value)
  '  End Function
  '  Public Sub CopyTo(array As System.Array, index As Integer) Implements System.Collections.IList.CopyTo
  '    Objects.CopyTo(array, index)
  '  End Sub
  '  Public ReadOnly Property Count As Integer Implements System.Collections.IList.Count
  '    Get
  '      Return Objects.Count
  '    End Get
  '  End Property
  '  Public Function IndexOf(value As Object) As Integer Implements System.Collections.IList.IndexOf
  '    Return Objects.IndexOf(value)
  '  End Function
  '  Public Sub Insert(index As Integer, value As Object) Implements System.Collections.IList.Insert
  '    Objects.Insert(index, value)
  '  End Sub
  '  Public ReadOnly Property IsFixedSize As Boolean Implements System.Collections.IList.IsFixedSize
  '    Get
  '      Return Objects.IsFixedSize
  '    End Get
  '  End Property
  '  Public ReadOnly Property IsReadOnly As Boolean Implements System.Collections.IList.IsReadOnly
  '    Get
  '      Return Objects.IsReadOnly
  '    End Get
  '  End Property
  '  Public ReadOnly Property IsSynchronized As Boolean Implements System.Collections.IList.IsSynchronized
  '    Get
  '      Return Objects.IsSynchronized
  '    End Get
  '  End Property
  '  Default Public Property Item(index As Integer) As Object Implements System.Collections.IList.Item
  '    Get
  '      Return Objects.Item(index)
  '    End Get
  '    Set(value As Object)
  '      Objects(index) = value
  '    End Set
  '  End Property
  '  Public ReadOnly Property SyncRoot As Object Implements System.Collections.IList.SyncRoot
  '    Get
  '      Return Objects.SyncRoot
  '    End Get
  '  End Property
  '  Public Function GetEnumerator() As System.Collections.IEnumerator Implements System.Collections.IEnumerable.GetEnumerator
  '    Return Objects.GetEnumerator
  '  End Function
  '  Public Sub Remove(value As Object) Implements System.Collections.IList.Remove
  '    Objects.Remove(value)
  '  End Sub
  '  Public Sub RemoveAt(index As Integer) Implements System.Collections.IList.RemoveAt
  '    Objects.RemoveAt(index)
  '  End Sub
  'End Class
End Namespace