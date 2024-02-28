Imports DevExpress.Xpo
Imports DevExpress.Data.Filtering
Imports NuSoft.Utils.CustomAttribute
Imports NuSoft.NUI.Win.Forms.Modules.NuSoft001.Persistent

Public Class UI_CekData
  Public Enum TipeTransaksi
    <EnumDescription("Permintaan Barang")> PB = 0
    <EnumDescription("Permintaan Penawaran")> RQ = 1
    <EnumDescription("Order Pembelian")> PO = 2
    <EnumDescription("Penerimaan Barang")> GR = 3
    <EnumDescription("DP Pembelian")> DP = 4
    <EnumDescription("Penerimaan Invoice")> RI = 5
    <EnumDescription("Pembayaran Invoice")> VP = 6
  End Enum
  Public Enum TipeForm
    <EnumDescription("Menu")> Menu = 0
    <EnumDescription("Dialog")> Dialog = 1
  End Enum

  Private _tipeForm As TipeForm
  Sub New(xTipeForm As TipeForm)
    ' This call is required by the designer.
    InitializeComponent()
    ' Add any initialization after the InitializeComponent() call.
    _tipeForm = xTipeForm
  End Sub
  Overrides Sub FirstLoad()
    If _tipeForm = TipeForm.Menu Then
      Me.session = NuSoft.Data.DbClient.GetXPOSession(NamaDatabase)
      txtTipe.EditValue = TipeTransaksi.PB
    Else
      txtTipe.Enabled = False
      txtNoTransaksi.Enabled = False
      btnCari.Enabled = False
    End If
    txtTipe.Properties.DataSource = Utils.Helper.EnumDescription.ToList(GetType(TipeTransaksi))
  End Sub
  Public Sub btnCari_Click(sender As Object, e As EventArgs) Handles btnCari.Click
    Select Case txtTipe.EditValue
      Case TipeTransaksi.PB
        SetHutangDetail()
        Dim ds = New XPCollection(Of Persistent.PermintaanStock)(session, New GroupOperator(GroupOperatorType.And, New BinaryOperator("Jenis", NuSoft004.Persistent.eJenisPermintaan.PermintaanPembelian, BinaryOperatorType.Equal), New BinaryOperator("Kode", "%" & txtNoTransaksi.Text & "%", BinaryOperatorType.Like)))
        Dim rq = New XPQuery(Of Persistent.Penawaran)(session).Where(Function(w) ds.Contains(w.NoPermintaan)).ToList
        Dim noOrder = New XPQuery(Of Persistent.OrderPembelian)(session).Where(Function(w) rq.Contains(w.NoPenawaran)).ToList
        Dim invoice = New XPQuery(Of Persistent.PenerimaanInvoice)(session).Where(Function(w) noOrder.Contains(w.NoOrder)).ToList
        Dim inv = invoice.Where(Function(w) w.Sumber.Id = Persistent.SumberDataJenis.RI).ToList
        Dim dp = invoice.Where(Function(w) w.Sumber.Id = Persistent.SumberDataJenis.AP).Select(Function(s) s.Id).ToList

        gridPB.DataSource = ds
        gridRQ.DataSource = rq
        gridPO.DataSource = noOrder
        gridDP.DataSource = New XPQuery(Of Persistent.DPPembelian)(session).Where(Function(w) dp.Contains(w.Id)).ToList
        gridGR.DataSource = New XPQuery(Of Persistent.PenerimaanBarang)(session).Where(Function(w) noOrder.Contains(w.NoOrder)).ToList
        gridRI.DataSource = inv
        gridVP.DataSource = New XPQuery(Of Persistent.PembayaranHutangDetail)(session).Where(Function(w) invoice.Contains(w.NoInvoice)).ToList
      Case TipeTransaksi.RQ
        SetHutangDetail()
        Dim ds = New XPCollection(Of Persistent.Penawaran)(session, New BinaryOperator("Kode", "%" & txtNoTransaksi.Text & "%", BinaryOperatorType.Like))
        Dim noOrder = New XPQuery(Of Persistent.OrderPembelian)(session).Where(Function(w) ds.Contains(w.NoPenawaran)).ToList
        Dim invoice = New XPQuery(Of Persistent.PenerimaanInvoice)(session).Where(Function(w) noOrder.Contains(w.NoOrder)).ToList
        Dim inv = invoice.Where(Function(w) w.Sumber.Id = Persistent.SumberDataJenis.RI).ToList
        Dim dp = invoice.Where(Function(w) w.Sumber.Id = Persistent.SumberDataJenis.AP).Select(Function(s) s.Id).ToList

        gridPB.DataSource = ds.Where(Function(w) Not w.NoPermintaan Is Nothing).Select(Function(s) s.NoPermintaan).ToList
        gridRQ.DataSource = ds
        gridPO.DataSource = noOrder
        gridDP.DataSource = New XPQuery(Of Persistent.DPPembelian)(session).Where(Function(w) dp.Contains(w.Id)).ToList
        gridGR.DataSource = New XPQuery(Of Persistent.PenerimaanBarang)(session).Where(Function(w) noOrder.Contains(w.NoOrder)).ToList
        gridRI.DataSource = inv
        gridVP.DataSource = New XPQuery(Of Persistent.PembayaranHutangDetail)(session).Where(Function(w) invoice.Contains(w.NoInvoice)).ToList
      Case TipeTransaksi.PO
        SetHutangDetail()
        Dim ds = New XPCollection(Of Persistent.OrderPembelian)(session, New BinaryOperator("Kode", "%" & txtNoTransaksi.Text & "%", BinaryOperatorType.Like))
        Dim rq = ds.Where(Function(w) Not w.NoPenawaran Is Nothing).Select(Function(s) s.NoPenawaran).ToList
        Dim invoice = New XPQuery(Of Persistent.PenerimaanInvoice)(session).Where(Function(w) ds.Contains(w.NoOrder)).ToList
        Dim inv = invoice.Where(Function(w) w.Sumber.Id = Persistent.SumberDataJenis.RI).ToList
        Dim dp = invoice.Where(Function(w) w.Sumber.Id = Persistent.SumberDataJenis.AP).Select(Function(s) s.Id).ToList

        gridPB.DataSource = rq.Where(Function(w) Not w.NoPermintaan Is Nothing).Select(Function(s) s.NoPermintaan).ToList
        gridRQ.DataSource = rq
        gridPO.DataSource = ds
        gridDP.DataSource = New XPQuery(Of Persistent.DPPembelian)(session).Where(Function(w) dp.Contains(w.Id)).ToList
        gridGR.DataSource = New XPQuery(Of Persistent.PenerimaanBarang)(session).Where(Function(w) ds.Contains(w.NoOrder)).ToList
        gridRI.DataSource = inv
        gridVP.DataSource = New XPQuery(Of Persistent.PembayaranHutangDetail)(session).Where(Function(w) invoice.Contains(w.NoInvoice)).ToList
      Case TipeTransaksi.GR
        SetHutangDetail()
        Dim ds = New XPCollection(Of Persistent.PenerimaanBarang)(session, New GroupOperator(GroupOperatorType.And, New BinaryOperator("Kode", "%" & txtNoTransaksi.Text & "%", BinaryOperatorType.Like), New BinaryOperator("Sumber", Persistent.SumberDataJenis.GR, BinaryOperatorType.Equal)))
        Dim noOrder = ds.Where(Function(w) Not w.NoOrder Is Nothing).Select(Function(s) s.NoOrder).ToList
        Dim invoice = New XPQuery(Of Persistent.PenerimaanInvoice)(session).Where(Function(w) noOrder.Contains(w.NoOrder)).ToList
        Dim rq = noOrder.Where(Function(w) Not w.NoPenawaran Is Nothing).Select(Function(s) s.NoPenawaran).ToList
        Dim inv = invoice.Where(Function(w) w.Sumber.Id = Persistent.SumberDataJenis.RI).ToList
        Dim dp = invoice.Where(Function(w) w.Sumber.Id = Persistent.SumberDataJenis.AP).Select(Function(s) s.Id).ToList

        gridPB.DataSource = rq.Where(Function(w) Not w.NoPermintaan Is Nothing).Select(Function(s) s.NoPermintaan).ToList
        gridRQ.DataSource = rq
        gridPO.DataSource = noOrder
        gridDP.DataSource = New XPQuery(Of Persistent.DPPembelian)(session).Where(Function(w) dp.Contains(w.Id)).ToList
        gridGR.DataSource = ds
        gridRI.DataSource = inv
        gridVP.DataSource = New XPQuery(Of Persistent.PembayaranHutangDetail)(session).Where(Function(w) invoice.Contains(w.NoInvoice)).ToList
      Case TipeTransaksi.DP
        SetHutangDetail()
        Dim ds = New XPCollection(Of Persistent.DPPembelian)(session, New GroupOperator(GroupOperatorType.And, New BinaryOperator("Kode", "%" & txtNoTransaksi.Text & "%", BinaryOperatorType.Like), New BinaryOperator("Sumber", Persistent.SumberDataJenis.AP, BinaryOperatorType.Equal)))
        Dim noOrder = ds.Where(Function(w) Not w.PO Is Nothing).Select(Function(s) s.PO).ToList
        Dim invoice = New XPQuery(Of Persistent.PenerimaanInvoice)(session).Where(Function(w) noOrder.Contains(w.NoOrder)).ToList
        Dim rq = noOrder.Where(Function(w) Not w.NoPenawaran Is Nothing).Select(Function(s) s.NoPenawaran).ToList
        Dim inv = invoice.Where(Function(w) w.Sumber.Id = Persistent.SumberDataJenis.RI).ToList
        Dim dp = invoice.Where(Function(w) w.Sumber.Id = Persistent.SumberDataJenis.AP).Select(Function(s) s.Id).ToList

        gridPB.DataSource = rq.Where(Function(w) Not w.NoPermintaan Is Nothing).Select(Function(s) s.NoPermintaan).ToList
        gridRQ.DataSource = rq
        gridPO.DataSource = noOrder
        gridDP.DataSource = ds
        gridGR.DataSource = New XPQuery(Of Persistent.PenerimaanBarang)(session).Where(Function(w) noOrder.Contains(w.NoOrder)).ToList
        gridRI.DataSource = inv
        gridVP.DataSource = New XPQuery(Of Persistent.PembayaranHutangDetail)(session).Where(Function(w) invoice.Contains(w.NoInvoice)).ToList
      Case TipeTransaksi.RI
        SetHutangDetail()
        Dim ds = New XPCollection(Of Persistent.PenerimaanInvoice)(session, New GroupOperator(GroupOperatorType.And, New BinaryOperator("Kode", "%" & txtNoTransaksi.Text & "%", BinaryOperatorType.Like), New BinaryOperator("Sumber", Persistent.SumberDataJenis.RI, BinaryOperatorType.Equal)))
        Dim noOrder = ds.Where(Function(w) Not w.NoOrder Is Nothing).Select(Function(s) s.NoOrder).ToList
        Dim rq = noOrder.Where(Function(w) Not w.NoPenawaran Is Nothing).Select(Function(s) s.NoPenawaran).ToList

        gridPB.DataSource = rq.Where(Function(w) Not w.NoPermintaan Is Nothing).Select(Function(s) s.NoPermintaan).ToList
        gridRQ.DataSource = rq
        gridPO.DataSource = noOrder
        gridDP.DataSource = New XPQuery(Of Persistent.DPPembelian)(session).Where(Function(w) noOrder.Contains(w.PO)).ToList
        gridGR.DataSource = New XPQuery(Of Persistent.PenerimaanBarang)(session).Where(Function(w) noOrder.Contains(w.NoOrder)).ToList
        gridRI.DataSource = ds
        gridVP.DataSource = New XPQuery(Of Persistent.PembayaranHutangDetail)(session).Where(Function(w) ds.Contains(w.NoInvoice)).ToList
      Case TipeTransaksi.VP
        SetHutangMain()
        Dim ds = New XPCollection(Of Persistent.PembayaranHutang)(session, New BinaryOperator("Kode", "%" & txtNoTransaksi.Text & "%", BinaryOperatorType.Like))
        Dim xxx = ds.ToList.SelectMany(Function(s) s.Detail).Select(Function(x) x.NoInvoice).ToList
        Dim noOrder = xxx.Where(Function(w) Not w.NoOrder Is Nothing).Select(Function(s) s.NoOrder).ToList
        Dim rq = noOrder.Where(Function(w) Not w.NoPenawaran Is Nothing).Select(Function(s) s.NoPenawaran).ToList
        Dim invoice = New XPQuery(Of Persistent.PenerimaanInvoice)(session).Where(Function(w) noOrder.Contains(w.NoOrder)).ToList
        Dim inv = invoice.Where(Function(w) w.Sumber.Id = Persistent.SumberDataJenis.RI).ToList
        Dim dp = invoice.Where(Function(w) w.Sumber.Id = Persistent.SumberDataJenis.AP).Select(Function(s) s.Id).ToList

        gridPB.DataSource = rq.Where(Function(w) Not w.NoPermintaan Is Nothing).Select(Function(s) s.NoPermintaan).ToList
        gridRQ.DataSource = rq
        gridPO.DataSource = noOrder
        gridDP.DataSource = New XPQuery(Of Persistent.DPPembelian)(session).Where(Function(w) dp.Contains(w.Id)).ToList
        gridGR.DataSource = New XPQuery(Of Persistent.PenerimaanBarang)(session).Where(Function(w) noOrder.Contains(w.NoOrder)).ToList
        gridRI.DataSource = inv
        gridVP.DataSource = ds
    End Select
  End Sub
  Private Sub SetHutangMain()
    colVPId.FieldName = NameOf(Persistent.PembayaranHutang.Id)
    colVPKode.FieldName = NameOf(Persistent.PembayaranHutang.Kode)
    colVPTanggal.FieldName = NameOf(Persistent.PembayaranHutang.Tanggal)
    colVPVendor.FieldName = NameOf(Persistent.PembayaranHutang.Vendor) & "." & NameOf(Kontak.Nama)
    colVPPembayaran.FieldName = NameOf(Persistent.PembayaranHutang.Total)
    colVPAkun.FieldName = NameOf(Persistent.PembayaranHutang.coakasbank) & "." & NameOf(Coa.Nama)
  End Sub
  Private Sub SetHutangDetail()
    colVPId.FieldName = NameOf(Persistent.PembayaranHutangDetail.Id)
    colVPKode.FieldName = NameOf(Persistent.PembayaranHutangDetail.Main) & "." & NameOf(Persistent.PembayaranHutang.Kode)
    colVPTanggal.FieldName = NameOf(Persistent.PembayaranHutangDetail.Main) & "." & NameOf(Persistent.PembayaranHutang.Tanggal)
    colVPVendor.FieldName = NameOf(Persistent.PembayaranHutangDetail.Main) & "." & NameOf(Persistent.PembayaranHutang.Vendor) & "." & NameOf(Kontak.Nama)
    colVPPembayaran.FieldName = NameOf(Persistent.PembayaranHutangDetail.NilaiBayar)
    colVPAkun.FieldName = NameOf(Persistent.PembayaranHutangDetail.Main) & "." & NameOf(Persistent.PembayaranHutang.coakasbank) & "." & NameOf(Coa.Nama)
  End Sub
End Class