Public Class MainClass
  Shared Function GetSmallImage() As Drawing.Image
    Return My.Resources.account_balances_16
  End Function
  Shared Function GetLargeImage() As Drawing.Image
    Return My.Resources.account_balances_24
  End Function
  Shared Function GetModuleId() As NPO.Modules.ModuleId
    Return NPO.Modules.ModuleId.Purchase
  End Function

  Private Enum menuName
    DataCek
    DataSaldoHutang
    DataUmurHutang
    DataStatistik
    DataUserLOG
    MasterPajak
    MasterSatuan
    MasterTermin
    MasterGudang
    MasterItem
    MasterKontak
    MasterVia
    TransaksiPermintaan
    TransaksiPenawaran
    TransaksiOrderPembelian
    TransaksiOrderPembelianApprove
    TransaksiDPPembelian
    TransaksiPenerimaanBarang
    TransaksiInvoicePembelian
    TransaksIPembayaranHutang
    TransaksiSaldoAwalDP
    TransaksiSaldoAwalPenerimaanBarang
    TransaksiSaldoAWalHutang
    TransaksiPengirimanRetur
    TransaksiReturPembelian
    TransaksiPembelianCash
    Setting

    '==== Fusoh
    zFusohItem
    zFusohKuotaImpor
    zFusohForecast
    zFusohOrderPembelian
    zFusohExim
    zFusohPenerimaan
    zFusohInvoice
    zFusohCostSheet
    zFusohPembayaranHutang
    zFusohDataCostSheet
    zFusohResetKurs
    zFusohDataPO

    '==== SanYu
    zSanyuKuotaImpor
    zSanyuOrderPembelian
    zSanyuPIB
    zSanyuPenerimaan
    zSanyuInvoice
    zSanyuPembayaran
    zSanYuDataPIB
    zSanYuMasterItem

    zNishiInvoicePembelian
    zNishiPengajuanPembayaran
    zNishiPembayaran
    zNishiMasterItem
  End Enum
  Private Shared Function GetMenu(ByVal menuCode As String) As menuName
    Select Case menuCode
      Case "0101.01" : Return menuName.TransaksiPermintaan
      Case "0101.02" : Return menuName.TransaksiPenawaran
      Case "0101.03" : Return menuName.TransaksiOrderPembelian
      Case "0101.04" : Return menuName.TransaksiDPPembelian
      Case "0101.05" : Return menuName.TransaksiPenerimaanBarang
      Case "0101.06" : Return menuName.TransaksiInvoicePembelian
      Case "0101.07" : Return menuName.TransaksIPembayaranHutang
      Case "0101.08" : Return menuName.TransaksiSaldoAWalHutang
      Case "0101.09" : Return menuName.TransaksiPembelianCash
      Case "0101.99" : Return menuName.TransaksiOrderPembelianApprove
      Case "0102.01" : Return menuName.DataCek
      Case "0102.02" : Return menuName.DataSaldoHutang
      Case "0102.03" : Return menuName.DataUmurHutang
      Case "0102.04" : Return menuName.DataStatistik
      Case "0102.09" : Return menuName.DataUserLOG
      Case "0102.99" : Return menuName.zFusohDataCostSheet

      Case "0103.01" : Return menuName.MasterTermin
      Case "0103.02" : Return menuName.MasterSatuan
      Case "0103.03" : Return menuName.MasterGudang
      Case "0103.04" : Return menuName.MasterPajak
      Case "0103.05" : Return menuName.MasterItem
      Case "0103.06" : Return menuName.MasterKontak
      Case "0103.07" : Return menuName.MasterVia
      Case "0104.01" : Return menuName.Setting

                'fusoh
      Case "0901.01" : Return menuName.zFusohKuotaImpor
      Case "0901.02" : Return menuName.zFusohForecast
      Case "0901.03" : Return menuName.zFusohOrderPembelian
      Case "0901.05" : Return menuName.zFusohExim
      Case "0901.06" : Return menuName.zFusohPenerimaan
      Case "0901.07" : Return menuName.zFusohInvoice
      Case "0901.04" : Return menuName.zFusohCostSheet
      Case "0901.08" : Return menuName.zFusohPembayaranHutang
      Case "0901.09" : Return menuName.zFusohResetKurs
      Case "0901.10" : Return menuName.zFusohDataPO
      Case "0901.99" : Return menuName.zFusohItem

        'catatan penomoran '09xx.y.zz --> xx nomor urut custom (perPelanggan), y = 1 transaksi,2 data, 3 report, 4 master, 5 setting, zz= no urut
        'sanYu
      Case "0902.1.01" : Return menuName.zSanyuKuotaImpor
      Case "0902.1.02" : Return menuName.zSanyuOrderPembelian
      Case "0902.1.03" : Return menuName.zSanyuPIB
      Case "0902.1.04" : Return menuName.zSanyuPenerimaan
      Case "0902.1.05" : Return menuName.zSanyuInvoice
      Case "0902.1.06" : Return menuName.zSanyuPembayaran
      Case "0902.2.01" : Return menuName.zSanYuDataPIB
      Case "0902.4.01" : Return menuName.zSanYuMasterItem

        'nishi
      Case "0903.1.01" : Return menuName.zNishiInvoicePembelian
      Case "0903.1.02" : Return menuName.zNishiPengajuanPembayaran
      Case "0903.1.03" : Return menuName.zNishiPembayaran
      Case "0903.3.01" : Return menuName.zNishiMasterItem

      Case Else : Return Nothing
    End Select
  End Function
  Shared Function GetForm(ByVal menuCode As String) As Core.Win.Forms.NuSoftForm
    Select Case GetMenu(menuCode)
      Case menuName.TransaksiPermintaan : Return New NuSoft004.UI_PermintaanStock(NuSoft004.Persistent.eJenisPermintaan.PermintaanPembelian)
      Case menuName.TransaksiPenawaran : Return New UI_Penawaran
      Case menuName.TransaksiOrderPembelian : Return New UI_OrderPembelian
      Case menuName.TransaksiOrderPembelianApprove : Return New UI_OrderPembelianApprove
      Case menuName.TransaksiDPPembelian : Return New UI_DPPembelian
      Case menuName.TransaksiPenerimaanBarang : Return New UI_PenerimaanBarang
      Case menuName.TransaksiInvoicePembelian : Return New UI_PenerimaanInvoice
      Case menuName.TransaksIPembayaranHutang : Return New UI_Pembayaran
      Case menuName.TransaksiPengirimanRetur : Return New UI_PengirimanRetur
      Case menuName.TransaksiSaldoAWalHutang : Return New UI_SaldoAwalHutang
      Case menuName.TransaksiPembelianCash : Return New UI_PembelianCash

      Case menuName.DataCek : Return New UI_CekData(UI_CekData.TipeForm.Menu)
      Case menuName.DataSaldoHutang : Return New UI_SaldoHutang
      Case menuName.DataUmurHutang : Return New UI_SaldoHutangUmur
      Case menuName.DataStatistik : Return New UI_Statistik
      Case menuName.DataUserLOG : Return New UI_ZLog


      Case menuName.MasterTermin : Return New UI_Termin
      Case menuName.MasterSatuan : Return NuSoft004.MainClass.GetForm("0103.02")
      Case menuName.MasterGudang : Return NuSoft004.MainClass.GetForm("0103.03")
      Case menuName.MasterPajak : Return NuSoft004.MainClass.GetForm("0103.04")
      Case menuName.MasterItem : Return NuSoft004.MainClass.GetForm("0103.05")
      Case menuName.MasterKontak : Return NuSoft001.MainClass.GetForm("0103.02")
      Case menuName.MasterVia : Return New UI_Via
      Case menuName.Setting : Return New UI_Setting

                '=== fusoh
      Case menuName.zFusohKuotaImpor : Return New UI_FusohKuotaImpor
      Case menuName.zFusohForecast : Return New UI_FusohForecast
      Case menuName.zFusohOrderPembelian : Return New UI_FusohOrderPembelian
      Case menuName.zFusohExim : Return New UI_FusohEximRev01 'UI_FusohExim
      Case menuName.zFusohPenerimaan : Return New UI_FusohPenerimaanBarangRev01 'UI_FusohPenerimaanBarang
      Case menuName.zFusohInvoice : Return New UI_FusohPenerimaanInvoiceRev01  ' UI_FusohPenerimaanInvoice
      Case menuName.zFusohCostSheet : Return New UI_FusohCostSheet
      Case menuName.zFusohPembayaranHutang : Return New UI_FusohPembayaran
      Case menuName.zFusohResetKurs : Return New UI_FusohResetKurs
      Case menuName.zFusohDataCostSheet : Return New UI_FusohDataCostSheet
      Case menuName.zFusohItem : Return NuSoft004.MainClass.GetForm("0498.99")
      Case menuName.zFusohDataPO : Return New UI_FusohDataOrderPembelian

        '==SanYu
      Case menuName.zSanyuKuotaImpor : Return New UI_SanYuKuotaImpor
      Case menuName.zSanyuOrderPembelian : Return New UI_SanYuOrderPembelian
      Case menuName.zSanyuPIB : Return New UI_SanYuPIB
      Case menuName.zSanyuPenerimaan : Return New UI_SanYuPenerimaanBarang
      Case menuName.zSanyuInvoice : Return New UI_SanYuPenerimaanInvoice
      Case menuName.zSanyuPembayaran : Return New UI_SanYuPembayaran

      Case menuName.zSanYuDataPIB : Return New UI_SanYuCekStockPIB

      Case menuName.zSanYuMasterItem : Return NuSoft004.MainClass.GetForm("04901.4.01")

      Case menuName.zNishiInvoicePembelian : Return New UI_NishiPenerimaanInvoice
      Case menuName.zNishiPengajuanPembayaran : Return New UI_NishiPembayaran
      Case menuName.zNishiPembayaran : Return New UI_NishiPembayaranAPP
      Case menuName.zNishiMasterItem : Return NuSoft004.MainClass.GetForm("04903.3.01")
      Case Else : Return Nothing
    End Select
  End Function

  Shared Function GetReportFilter(ByVal reportCode As String) As Core.Win.Forms.ReportFilter
    Select Case reportCode
      Case GetReport(reportName.VoucherPermintaanStock) : Return New RF_DataDataTransaksi(Persistent.SumberDataJenis.PB)
      Case GetReport(reportName.VoucherPermintaanPenawaran) : Return New RF_DataDataTransaksi(Persistent.SumberDataJenis.RQ)
      Case GetReport(reportName.VoucherOrderPembelian) : Return New RF_DataDataTransaksi(Persistent.SumberDataJenis.PO)
      Case GetReport(reportName.VoucherDPPembelian) : Return New RF_DataDataTransaksi(Persistent.SumberDataJenis.AP)
      Case GetReport(reportName.VoucherPenerimaanBarang) : Return New RF_DataDataTransaksi(Persistent.SumberDataJenis.GR)
      Case GetReport(reportName.VoucherPenerimaanInvoice) : Return New RF_DataDataTransaksi(Persistent.SumberDataJenis.RI)
      Case GetReport(reportName.VoucherPembayaranInvoice) : Return New RF_DataDataTransaksi(Persistent.SumberDataJenis.VP)
      Case GetReport(reportName.VoucherPengirimanRetur) : Return New RF_DataDataTransaksi(Persistent.SumberDataJenis.DN)
      Case GetReport(reportName.VoucherPembelianTunai) : Return New RF_DataDataTransaksi(Persistent.SumberDataJenis.PC)

      Case GetReport(reportName.RekapPermintaanStock) : Return New RF_DataDataTransaksi(Persistent.SumberDataJenis.PB)
      Case GetReport(reportName.RekapPermintaanStockDetail) : Return New RF_DataDataTransaksi(Persistent.SumberDataJenis.PB)
      Case GetReport(reportName.RekapPermintaanPenawaran) : Return New RF_DataDataTransaksi(Persistent.SumberDataJenis.RQ)
      Case GetReport(reportName.RekapPermintaanPenawaranDetail) : Return New RF_DataDataTransaksi(Persistent.SumberDataJenis.RQ)
      Case GetReport(reportName.RekapOrderPembelian) : Return New RF_DataDataTransaksi(Persistent.SumberDataJenis.PO)
      Case GetReport(reportName.RekapOrderPembelianDetail) : Return New RF_DataDataTransaksi(Persistent.SumberDataJenis.PO)
      Case GetReport(reportName.RekapOrderPembelianPerVendor) : Return New RF_DataDataTransaksi(Persistent.SumberDataJenis.PO)
      Case GetReport(reportName.RekapPenerimaanBarang) : Return New RF_DataDataTransaksi(Persistent.SumberDataJenis.GR)
      Case GetReport(reportName.RekapPenerimaanBarangDetail) : Return New RF_DataDataTransaksi(Persistent.SumberDataJenis.GR)
      Case GetReport(reportName.RekapPenerimaanBarangPerVendor) : Return New RF_DataDataTransaksi(Persistent.SumberDataJenis.GR)
      Case GetReport(reportName.RekapPenerimaanInvoice) : Return New RF_DataDataTransaksi(Persistent.SumberDataJenis.RI)
      Case GetReport(reportName.RekapPenerimaanInvoicePerVendor) : Return New RF_DataDataTransaksi(Persistent.SumberDataJenis.RI)
      Case GetReport(reportName.RekapPembayaranInvoice) : Return New RF_DataDataTransaksi(Persistent.SumberDataJenis.VP)
      Case GetReport(reportName.RekapPembayaranInvoicePerVendor) : Return New RF_DataDataTransaksi(Persistent.SumberDataJenis.VP)

      Case GetReport(reportName.DataKartuHutang) : Return New RF_Hutang(RF_Hutang.TipeDataHutang.KartuHutang)
      Case GetReport(reportName.DataKartuHutangDetail) : Return New RF_Hutang(RF_Hutang.TipeDataHutang.KartuHutang)
      Case GetReport(reportName.DataDaftarHutang) : Return New RF_Hutang(RF_Hutang.TipeDataHutang.DaftarHutang)
      Case GetReport(reportName.DataUmurHutang) : Return New RF_Hutang(RF_Hutang.TipeDataHutang.UmurHutang)
      Case GetReport(reportName.DataLeadTime) : Return New RF_DataDataTransaksi(Persistent.SumberDataJenis.GR)
      Case GetReport(reportName.DataAnalisaBarangOrder) : Return New RF_Item(RF_Item.TipeRF_Item.BarangReorder)

			Case GetReport(reportName.RekapPurchaseOrderStock) : Return New RF_RekapData(reportName.RekapPurchaseOrderStock)

        'fusoh
      Case GetReport(reportName.zFusohVoucherPO) : Return New RF_FusohVoucher(Persistent.SumberDataJenis.PO, reportName.zFusohVoucherPO)
			Case GetReport(reportName.zFusohVoucherGRN) : Return New RF_FusohVoucher(Persistent.SumberDataJenis.CSIM, reportName.zFusohVoucherGRN)
			Case GetReport(reportName.zFusohVoucherCostSheetActualRate) : Return New RF_FusohVoucherBaru(reportName.zFusohVoucherCostSheetActualRate)
      Case GetReport(reportName.zFusohRekapCostSheet) : Return New RF_FusohRekap(Persistent.SumberDataJenis.CS)
			Case GetReport(reportName.zFusohRekapQuotaImport) : Return New RF_FusohRekapQuotaImport
			Case GetReport(reportName.zFusohRekapPenerimaanBarang) : Return New RF_FusohVoucher(Persistent.SumberDataJenis.CSIM, reportName.zFusohRekapPenerimaanBarang)
			Case GetReport(reportName.zFusohRekapGRN) : Return New RF_FusohRekap(Persistent.SumberDataJenis.CSIM)

				'sanyu
			Case GetReport(reportName.zSanyuRekapPIB) : Return New RF_SanYuRekapPIB(MainClass.reportName.zSanyuRekapPIB)
      Case GetReport(reportName.zSanyuRekapPIBRealisasi) : Return New RF_SanYuRekapPIB(MainClass.reportName.zSanyuRekapPIBRealisasi)
      Case GetReport(reportName.zSanyuRekapPenerimaan) : Return New RF_SanYuRekapPenerimaan()
      Case GetReport(reportName.zSanyuRekapPembayaran) : Return New RF_SanYuVoucher(Persistent.SumberDataJenis.VP)
      Case GetReport(reportName.zSanyuVoucherPO) : Return New RF_SanYuVoucher(Persistent.SumberDataJenis.PO)
      Case GetReport(reportName.zSanyuVoucherGRN) : Return New RF_SanYuVoucher(Persistent.SumberDataJenis.GR)
      Case GetReport(reportName.zSanyuVoucherRI) : Return New RF_SanYuVoucher(Persistent.SumberDataJenis.RI)
      Case GetReport(reportName.zSanyuVoucherVP) : Return New RF_SanYuVoucher(Persistent.SumberDataJenis.VP)
      Case GetReport(reportName.zSanyuVoucherPIB) : Return New RF_SanYuVoucher(Persistent.SumberDataJenis.PI)

        'nishi
      Case GetReport(reportName.zNishiVoucherRIBiaya) : Return New RF_NishiVoucher(Persistent.SumberDataJenis.RI, reportName.zNishiVoucherRIBiaya)
      Case GetReport(reportName.zNishiVoucherRITR) : Return New RF_NishiVoucher(Persistent.SumberDataJenis.RI, reportName.zNishiVoucherRITR)
      Case GetReport(reportName.zNishiVoucherRIGL) : Return New RF_NishiVoucher(Persistent.SumberDataJenis.RI, reportName.zNishiVoucherRIGL)
      Case GetReport(reportName.zNishiVoucherVP) : Return New RF_NishiVoucher(Persistent.SumberDataJenis.VP, reportName.zNishiVoucherVP)
      Case GetReport(reportName.zNishiRekapRI) : Return New RF_NishiVoucher(Persistent.SumberDataJenis.RI, reportName.zNishiRekapRI)

      Case Else : Return Nothing
    End Select
  End Function
  Friend Enum reportName
    VoucherPermintaanStock
    VoucherPermintaanPenawaran
    VoucherOrderPembelian
    VoucherDPPembelian
    VoucherPenerimaanBarang
    VoucherPenerimaanInvoice
    VoucherPembayaranInvoice
    VoucherPengirimanRetur
    VoucherReturPembelian
    VoucherPembelianTunai
    VoucherOrderPembelianApprove
    RekapPermintaanStock
    RekapPermintaanStockDetail
    RekapPermintaanPenawaran
    RekapPermintaanPenawaranDetail
    RekapOrderPembelian
    RekapOrderPembelianDetail
    RekapOrderPembelianPerVendor
    RekapPenerimaanBarang
    RekapPenerimaanBarangDetail
    RekapPenerimaanBarangPerVendor
    RekapPenerimaanInvoice
    RekapPenerimaanInvoicePerVendor
    RekapPembayaranInvoice
    RekapPembayaranInvoicePerVendor
    DataKartuHutang
    DataKartuHutangDetail
    DataDaftarHutang
    DataUmurHutang
    DataLeadTime
    DataAnalisaBarangOrder
    RekapMaterialOrderAnalisys
    RekapPurchaseOrderStock

    '==== Fusoh
    zFusohVoucherPO
    zFusohVoucherGRN
    zFusohVoucherCostSheet
    zFusohVoucherCostSheetActualRate
    zFusohRekapQuotaImport
    zFusohRekapRealisasiImpor
    zFusohRekapOrderPembelian
    zFusohRekapPenerimaanBarang
    zFusohRekapPenerimaanInvoice
    zFusohRekapPembayaranHutang
    zFusohRekapCostSheet
		zFusohRekapGRN

		'==== Sanyu
		zSanyuRekapPIB
    zSanyuRekapPIBRealisasi
    zSanyuRekapPenerimaan
    zSanyuRekapPembayaran
    zSanyuVoucherPO
    zSanyuVoucherGRN
    zSanyuVoucherPIB
    zSanyuVoucherRI
    zSanyuVoucherVP

    '==== Nishi
    zNishiVoucherRIBiaya
    zNishiVoucherRITR
    zNishiVoucherRIGL
    zNishiVoucherVP
    zNishiVoucherPD
    zNishiVoucherCash
    zNishiRekapRI
  End Enum
  Friend Shared Function GetReport(ByVal reportCode As reportName) As String
    Select Case reportCode
      Case reportName.VoucherPermintaanStock : Return "50101"
      Case reportName.VoucherPermintaanPenawaran : Return "50102"
      Case reportName.VoucherOrderPembelian : Return "50103"
      Case reportName.VoucherDPPembelian : Return "50104"
      Case reportName.VoucherPenerimaanBarang : Return "50105"
      Case reportName.VoucherPenerimaanInvoice : Return "50106"
      Case reportName.VoucherPembayaranInvoice : Return "50107"
      Case reportName.VoucherPengirimanRetur : Return "50108"
      Case reportName.VoucherPembelianTunai : Return "50109"
      Case reportName.VoucherOrderPembelianApprove : Return "50199"
      Case reportName.RekapPermintaanStock : Return "50201"
      Case reportName.RekapPermintaanStockDetail : Return "50202"
      Case reportName.RekapPermintaanPenawaran : Return "50203"
      Case reportName.RekapPermintaanPenawaranDetail : Return "50204"
      Case reportName.RekapOrderPembelian : Return "50205"
      Case reportName.RekapOrderPembelianDetail : Return "50206"
      Case reportName.RekapOrderPembelianPerVendor : Return "50207"
      Case reportName.RekapPenerimaanBarang : Return "50208"
      Case reportName.RekapPenerimaanBarangDetail : Return "50209"
      Case reportName.RekapPenerimaanBarangPerVendor : Return "50210"
      Case reportName.RekapPenerimaanInvoice : Return "50211"
      Case reportName.RekapPenerimaanInvoicePerVendor : Return "50212"
      Case reportName.RekapPembayaranInvoice : Return "50213"
      Case reportName.RekapPembayaranInvoicePerVendor : Return "50214"
      Case reportName.RekapMaterialOrderAnalisys : Return "50299"
      Case reportName.RekapPurchaseOrderStock : Return "50298"
      Case reportName.DataKartuHutang : Return "50301"
      Case reportName.DataKartuHutangDetail : Return "50302"
      Case reportName.DataDaftarHutang : Return "50303"
      Case reportName.DataUmurHutang : Return "50304"
      Case reportName.DataLeadTime : Return "50305"
			Case reportName.DataAnalisaBarangOrder : Return "50306"

				'fusoh
			Case reportName.zFusohVoucherPO : Return "58101"
			Case reportName.zFusohVoucherGRN : Return "58102"
			Case reportName.zFusohVoucherCostSheet : Return "58103"
      Case reportName.zFusohVoucherCostSheetActualRate : Return "58104"
      Case reportName.zFusohRekapRealisasiImpor : Return "58201"
			Case reportName.zFusohRekapOrderPembelian : Return "58202"
			Case reportName.zFusohRekapPenerimaanBarang : Return "58203"
			Case reportName.zFusohRekapPenerimaanInvoice : Return "58204"
			Case reportName.zFusohRekapPembayaranHutang : Return "58205"
      Case reportName.zFusohRekapCostSheet : Return "58206"
			Case reportName.zFusohRekapQuotaImport : Return "58207"
			Case reportName.zFusohRekapGRN : Return "58208"

				'sanyu
			Case reportName.zSanyuVoucherPO : Return "57101"
      Case reportName.zSanyuVoucherGRN : Return "57102"
      Case reportName.zSanyuVoucherPIB : Return "57103"
      Case reportName.zSanyuVoucherRI : Return "57104"
      Case reportName.zSanyuVoucherVP : Return "57105"

      Case reportName.zSanyuRekapPIB : Return "57201"
      Case reportName.zSanyuRekapPIBRealisasi : Return "57202"
      Case reportName.zSanyuRekapPenerimaan : Return "57203"
      Case reportName.zSanyuRekapPembayaran : Return "57204"


        '59zzxxx zz = No Urut Pelanggan,xx= NoUrut Report
      Case reportName.zNishiVoucherRIBiaya : Return "5901101"
      Case reportName.zNishiVoucherRITR : Return "5901102"
      Case reportName.zNishiVoucherVP : Return "5901103"
      Case reportName.zNishiVoucherRIGL : Return "5901104"
      Case reportName.zNishiRekapRI : Return "56201"
      Case Else : Return Nothing
    End Select
  End Function
End Class