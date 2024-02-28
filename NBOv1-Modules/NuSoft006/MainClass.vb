Public Class MainClass
  Shared Function GetSmallImage() As Drawing.Image
    Return My.Resources.account_balances_16
  End Function
  Shared Function GetLargeImage() As Drawing.Image
    Return My.Resources.account_balances_24
  End Function
	Shared Function GetModuleId() As NPO.Modules.ModuleId
		Return NPO.Modules.ModuleId.Sales
	End Function

  Private Enum menuName
    TransaksiPenawaran
    TransaksiOrderPenjualan
    TransaksiDPenjualan
    TransaksiPengirimanBarang
    TransaksiInvoicePenjualan2
    TransaksiInvoicePenjualan
    TransaksiPembayaranPiutang
    TransaksiPenerimaanRetur
    TransaksiReturPenjualan
    TransaksiSaldoAwalDP
    TransaksiSaldoAwalPengirimanBarang
    TransaksiSaldoAwalPiutang
    TransaksiPOS

    TransaksiRAB
    TransaksiMasterProyek

    DataCekTransaksi
    DataSaldoPiutang
    DataUmurPiutang
    DataStatistik
    DataUserLOG
    DataSOOutstanding

    MasterPajak
    MasterSatuan
    MasterTermin
    MasterGudang
    MasterItem
    MasterKontak
    MasterVia
    MasterProyek
    Setting

    TransaksizParamaSO
    TransaksizParamaInvoice
    TransaksizParamaCP
    TransaksizForwarderInvoice
    TransaksizForwarderCP
    TransaksizForwarderStuffing
    MasterzForwarderDestination
    MasterzForwarderShipment
    MasterzForwarderProduk

		'=========== Travel ===============
		zTravelTransaksiOrder
		zTravelTransaksiDP
		zTravelTransaksiInvoice
		zTravelTransaksiPembayaran
		zTravelTransaksiRefund
		zTravelMasterPaketJasa

		'===========  ===============
		zRexxaOrderPenjualan
		zRexxaInvoicePenjualan
    zRexxaPembayaranPiutang
    zRexxaMutasiBarang
    zRexxaSaldoPiutang
    zRexxaUmurPiutang

		'===========  ===============
		zWoojinOrderPenjualan
		zWoojinInvoicePenjualan
    zWoojinPembayaranPiutang

    '=== TM
    tOrder
    tShipmentByProduct

    'fusoh
    zFusohItem
    zFusohSQ
    zFusohSO
    zFusohSJ
    zFusohIV
    zFusohCP
    zFusohDataSO
    zFusohDataSalesDashboard
    zFusohSOPPIC
    zFusohSOTracking

    'SanYu
    zSanYuSalesOrder
    zSanYuApproveSO
    zSanYuPengirimanBarang
    zSanYuPEB
    zSanYuInvoice
    zSanYuPembayaran
    zSanyuDataHarga
    zSanyuDataPEB
    zSanyuSetting

    'Nishi
    zNishiQuotation
    zNishiQuotationApp
    zNishiJobOrder
    zNishiPIB
    zNishiPEB
    zNishiInvoice
    zNishiDebitNote
    zNishiPembayaran
    zNishiMasterItem

    'mustofa
    zMustofaPOS
  End Enum
  Private Shared Function GetMenu(ByVal menuCode As String) As menuName
    Select Case menuCode
      Case "0101.01" : Return menuName.TransaksiPenawaran
      Case "0101.02" : Return menuName.TransaksiOrderPenjualan
      Case "0101.03" : Return menuName.TransaksiDPenjualan
      Case "0101.04" : Return menuName.TransaksiPengirimanBarang
			Case "0101.05" : Return menuName.TransaksiInvoicePenjualan
			Case "0101.06" : Return menuName.TransaksIPembayaranPiutang
      Case "0101.07" : Return menuName.TransaksiSaldoAWalPiutang
      Case "0101.08" : Return menuName.TransaksiPenerimaanRetur
      Case "0101.09" : Return menuName.TransaksiReturPenjualan
      Case "0101.10" : Return menuName.TransaksiPOS
      Case "0102.01" : Return menuName.DataCekTransaksi
      Case "0102.02" : Return menuName.DataSaldoPiutang
      Case "0102.03" : Return menuName.DataUmurPiutang
      Case "0102.04" : Return menuName.DataStatistik
      Case "0102.05" : Return menuName.DataSOOutstanding
      Case "0102.09" : Return menuName.DataUserLOG
      Case "0103.01" : Return menuName.MasterTermin
      Case "0103.02" : Return menuName.MasterSatuan
      Case "0103.03" : Return menuName.MasterGudang
      Case "0103.04" : Return menuName.MasterPajak
      Case "0103.05" : Return menuName.MasterItem
      Case "0103.06" : Return menuName.MasterKontak
      Case "0103.07" : Return menuName.MasterVia
      Case "0103.08" : Return menuName.MasterProyek

      Case "0101.91" : Return menuName.TransaksiRAB
      Case "0101.92" : Return menuName.TransaksiMasterProyek


      Case "0104.01" : Return menuName.Setting
        'parama
      Case "0101.99" : Return menuName.TransaksizParamaSO
      Case "0101.98" : Return menuName.TransaksizParamaInvoice
      Case "0101.97" : Return menuName.TransaksizParamaCP
        'rexxa
      Case "0101.89" : Return menuName.zRexxaOrderPenjualan
      Case "0101.88" : Return menuName.zRexxaInvoicePenjualan
      Case "0101.87" : Return menuName.zRexxaPembayaranPiutang
      Case "0101.86" : Return menuName.zRexxaMutasiBarang

      Case "0102.89" : Return menuName.zRexxaSaldoPiutang
      Case "0102.88" : Return menuName.zRexxaUmurPiutang

        'woojin
      Case "0101.79" : Return menuName.zWoojinOrderPenjualan
      Case "0101.78" : Return menuName.zWoojinInvoicePenjualan
      Case "0101.77" : Return menuName.zWoojinPembayaranPiutang

        'forwarder
      Case "0101.55" : Return menuName.TransaksiInvoicePenjualan2
      Case "0101.95" : Return menuName.TransaksizForwarderInvoice
      Case "0101.94" : Return menuName.TransaksizForwarderCP
      Case "0101.93" : Return menuName.TransaksizForwarderStuffing
      Case "0103.99" : Return menuName.MasterzForwarderShipment
      Case "0103.98" : Return menuName.MasterzForwarderDestination
			Case "0103.97" : Return menuName.MasterzForwarderProduk

				'tm
			Case "0601.01" : Return menuName.tOrder
			Case "0601.09" : Return menuName.tShipmentByProduct

				'fusoh
			Case "0901.01" : Return menuName.zFusohSQ
			Case "0901.02" : Return menuName.zFusohSO
			Case "0901.04" : Return menuName.zFusohSJ
			Case "0901.05" : Return menuName.zFusohIV
			Case "0901.06" : Return menuName.zFusohCP
			Case "0901.99" : Return menuName.zFusohItem
      Case "0901.02" : Return menuName.zFusohSO

        'catatan penomoran '06.9xx.y.zz --> xx nomor urut custom (perPelanggan), y = 1 transaksi,2 data, 3 report, 4 master, 5 setting, zz= no urut
      Case "06.901.1.01" : Return menuName.zFusohSOPPIC
      Case "06.901.2.01" : Return menuName.zFusohDataSO'06.901.2.02
      Case "06.901.2.02" : Return menuName.zFusohSOTracking
      Case "06.901.2.11" : Return menuName.zFusohDataSalesDashboard
        '*************
      Case "06.902.1.01" : Return menuName.zSanYuSalesOrder
      Case "06.902.1.02" : Return menuName.zSanYuApproveSO
      Case "06.902.1.03" : Return menuName.zSanYuPengirimanBarang
      Case "06.902.1.04" : Return menuName.zSanYuInvoice
      Case "06.902.1.05" : Return menuName.zSanYuPEB
      Case "06.902.1.06" : Return menuName.zSanYuPembayaran
      Case "06.902.2.01" : Return menuName.zSanyuDataHarga
      Case "06.902.2.02" : Return menuName.zSanyuDataPEB
      Case "06.902.5.01" : Return menuName.zSanyuSetting


        'nishi
      Case "06.903.1.01" : Return menuName.zNishiJobOrder
      Case "06.903.1.02" : Return menuName.zNishiPIB
      Case "06.903.1.03" : Return menuName.zNishiPEB
      Case "06.903.1.04" : Return menuName.zNishiInvoice
      Case "06.903.1.05" : Return menuName.zNishiDebitNote
      Case "06.903.1.06" : Return menuName.zNishiPembayaran
      Case "06.903.1.07" : Return menuName.zNishiQuotation
      Case "06.903.1.08" : Return menuName.zNishiQuotationApp
      Case "06.903.3.01" : Return menuName.zNishiMasterItem

     '=========== Travel ===============
      Case "06.904.1.01" : Return menuName.zTravelTransaksiOrder
			Case "06.904.1.02" : Return menuName.zTravelTransaksiDP
			Case "06.904.1.03" : Return menuName.zTravelTransaksiInvoice
			Case "06.904.1.04" : Return menuName.zTravelTransaksiPembayaran
			Case "06.904.1.05" : Return menuName.zTravelTransaksiRefund
      Case "06.904.3.01" : Return menuName.zTravelMasterPaketJasa

        '=========== POS ===============
      Case "06.905.1.01" : Return menuName.zMustofaPOS


      Case Else : Return Nothing
    End Select
  End Function
	Shared Function GetForm(ByVal menuCode As String) As Core.Win.Forms.NuSoftForm
		Select Case GetMenu(menuCode)
			Case menuName.TransaksiPenawaran : Return New UI_Penawaran
			Case menuName.TransaksiOrderPenjualan : Return New UI_OrderPenjualan
			Case menuName.TransaksiDPenjualan : Return New UI_DPPenjualan
			Case menuName.TransaksiPengirimanBarang : Return New UI_PengirimanBarang
      Case menuName.TransaksiInvoicePenjualan : Return New UI_InvoicePenjualan
      Case menuName.TransaksiPembayaranPiutang : Return New UI_Pembayaran
			Case menuName.TransaksiSaldoAwalPiutang : Return New UI_SaldoAwalPiutang
			Case menuName.TransaksiPenerimaanRetur : Return New UI_PenerimaanRetur
			Case menuName.TransaksiPOS : Return New UI_POS

			Case menuName.TransaksiRAB : Return New UI_RAB
			Case menuName.TransaksiMasterProyek : Return New UI_Proyek

			Case menuName.DataCekTransaksi : Return New UI_CekData(UI_CekData.TipeForm.Menu)
			Case menuName.DataSaldoPiutang : Return New UI_SaldoPiutang
			Case menuName.DataUmurPiutang : Return New UI_SaldoPiutangUmur
      Case menuName.DataStatistik : Return New UI_Statistik
      Case menuName.DataSOOutstanding : Return New UI_SOOutstanding
      Case menuName.DataUserLOG : Return New UI_ZLog

      Case menuName.MasterTermin : Return NuSoft005.MainClass.GetForm("0103.01")
      Case menuName.MasterSatuan : Return NuSoft004.MainClass.GetForm("0103.02")
			Case menuName.MasterGudang : Return NuSoft004.MainClass.GetForm("0103.03")
			Case menuName.MasterPajak : Return NuSoft004.MainClass.GetForm("0103.04")
			Case menuName.MasterItem : Return NuSoft004.MainClass.GetForm("0103.05")
			Case menuName.MasterKontak : Return NuSoft001.MainClass.GetForm("0103.02")
      Case menuName.MasterProyek : Return NuSoft001.MainClass.GetForm("0103.06")
      Case menuName.MasterzForwarderShipment : Return New UI_zShipment
			Case menuName.MasterzForwarderDestination : Return New UI_zDestination
			Case menuName.MasterzForwarderProduk : Return New UI_zProduk
			Case menuName.Setting : Return New UI_Setting

			Case menuName.zRexxaOrderPenjualan : Return New zRexaUI_OrderPenjualan
			Case menuName.zRexxaInvoicePenjualan : Return New zRexaUI_InvoicePenjualan
			Case menuName.zRexxaPembayaranPiutang : Return New zRexaUI_Pembayaran
			Case menuName.zRexxaMutasiBarang : Return New zRexaUI_MutasiStock

			Case menuName.zRexxaSaldoPiutang : Return New zRexxaUI_SaldoPiutang
			Case menuName.zRexxaUmurPiutang : Return New zRexxaUI_SaldoPiutangUmur

			Case menuName.zWoojinOrderPenjualan : Return New zWoojinUI_OrderPenjualan
			Case menuName.zWoojinInvoicePenjualan : Return New zWoojinUI_InvoicePenjualan
			Case menuName.zWoojinPembayaranPiutang : Return New zWoojinUI_Pembayaran

			Case menuName.TransaksizParamaSO : Return New UI_zParamaSO
			Case menuName.TransaksizParamaInvoice : Return New UI_zParamaIV
			Case menuName.TransaksizParamaCP : Return New UI_zParamaPembayaran
			Case menuName.TransaksizForwarderInvoice : Return New UI_zForwarderInvoice
			Case menuName.TransaksizForwarderCP : Return New UI_zForwarderPembayaran
			Case menuName.TransaksizForwarderStuffing : Return New UI_zForwarderStuffing

				'==== TM
			Case menuName.tOrder : Return New UI_TMOrder
			Case menuName.tShipmentByProduct : Return New UI_TMShipByP

				'==== Fusoh
			Case menuName.zFusohSQ : Return New UI_Fusoh_SQ
      Case menuName.zFusohSO : Return New UI_Fusoh_SO
      Case menuName.zFusohSOPPIC : Return New UI_Fusoh_SOPPIC
      Case menuName.zFusohSJ : Return New UI_FusohSJ
			Case menuName.zFusohIV : Return New UI_FusohInvoicePenjualan
			Case menuName.zFusohCP : Return New UI_FusohPembayaran
      Case menuName.zFusohItem : Return NuSoft004.MainClass.GetForm("0498.99")
      Case menuName.zFusohDataSO : Return New UI_FusohDataSO
      Case menuName.zFusohSOTracking : Return New UI_FusohDataSOTracking
      Case menuName.zFusohDataSalesDashboard : Return New UI_FusohSalesDashboard

        '==== SanYu
      Case menuName.zSanYuSalesOrder : Return New UI_SanYuOrderPenjualan
      Case menuName.zSanYuPengirimanBarang : Return New UI_SanYuPengirimanBarang
      Case menuName.zSanYuInvoice : Return New UI_SanYuInvoice
      Case menuName.zSanyuSetting : Return New UI_SanYuSetting
      Case menuName.zSanyuDataHarga : Return New UI_SanYuDataHarga
      Case menuName.zSanYuPEB : Return New UI_SanYuPIB
      Case menuName.zSanYuPembayaran : Return New UI_SanYuPembayaran
      Case menuName.zSanyuDataPEB : Return New UI_SanYuDataPEB

        '==== Nishi
      Case menuName.zNishiQuotation : Return New UI_zNishiQuotation
      Case menuName.zNishiQuotationApp : Return New UI_zNishiQuotationApp
      Case menuName.zNishiJobOrder : Return New UI_zNishiOrderPenjualan
      Case menuName.zNishiPIB : Return New UI_zNishiPIB
      Case menuName.zNishiPEB : Return New UI_zNishiPEB
      Case menuName.zNishiInvoice : Return New UI_zNishiInvoicePenjualan
      Case menuName.zNishiDebitNote : Return New UI_zNishiDebitNote
      Case menuName.zNishiPembayaran : Return New UI_zNishiPembayaran
      Case menuName.zNishiMasterItem : Return NuSoft004.MainClass.GetForm("04903.3.01")

				'==== Travel
			Case menuName.zTravelTransaksiOrder : Return New UI_TravelOrder
			Case menuName.zTravelTransaksiDP : Return New UI_TravelDP
			Case menuName.zTravelTransaksiInvoice : Return New UI_TravelInvoicePenjualan
			Case menuName.zTravelTransaksiPembayaran : Return New UI_TravelPembayaran
			Case menuName.zTravelTransaksiRefund : Return New UI_TravelRefund
      Case menuName.zTravelMasterPaketJasa : Return New NuSoft004.UI_TravelMasterItem(NuSoft004.Persistent.JenisBarang.Jasa)

        '==== Mustofa
      Case menuName.zMustofaPOS : Return New UI_zMustofaPOS

      Case Else : Return New UI_Kosong
		End Select
	End Function

  Friend Enum reportName
    VoucherSQ
    VoucherSO
    VoucherDP
    VoucherSJ
    VoucherIV
    VoucherCP
    VoucherFP
    VoucherFPValas
    VoucherRN
    VoucherJurnal
    RekapSQ
    RekapSQDetail
    RekapSO
    RekapSODetail
    RekapDP
    RekapSJ
    RekapSJDetail
    RekapIV
		RekapIVDetail
		RekapIVDetail2
		RekapCP
    RekapCPDetail
    RekapPPN
    RekapQS
    TravelVoucherIV
		TravelVoucherFP
		RekapHPP

		SuratPiutang
    KartuPiutang
    KartuPiutangDetail
    DaftarPiutang
    UmurPiutang
    LabaRugiPerInvoice
    LabaRugiPOS
    LabaRugiPerBarang
    LabaRugiPerHari
    LabaRugiPerBulan

    'parama
    zVoucherParamaIV1
    zVoucherParamaIV2
    zVoucherParamaIV3
    zVoucherParamaIV4
    zVoucherParamaPajak
    zVoucherParamaSO
    zVoucherParamaCP
    zRekapIV
    'forwarder
    zForwarderVoucherInvoice
    zForwarderVoucherInvoiceDIce
    zForwarderVoucherInvoiceDIce2
    zForwarderVoucherInvoiceDDry
    zForwarderVoucherInvoiceDDry2
    zForwarderVoucherFP
    zForwarderStuffing

    'rexxa
    zRexxaVoucherInvoice
    zRexxaVoucherSO
    zRexxaVoucherInvoiceGedung
    zRexxaVoucherMutasiMasuk
    zRexxaVoucherMutasiKeluar
    zRexxaRekapMutasiMasuk
    zRexxaRekapMutasiKeluar
    zRexxaRekapAlatGudang
    zRexxaRekapAlatGudang2
    zRexxaSaldoPiutang
    zRexxaUmurPiutang
    zRexxaKartuPiutang
    zRexxaKartuPiutangDetail

    'woojin
    zWoojinVoucherSO
    zWoojinVoucherIV
    zWoojinVoucherFP
    zWoojinRekapPPN
    zWoojinRekapMaterialOrder

    'fusoh
    zFusohVoucherSQ
    zFusohVoucherSQ2
    zFusohVoucherSO
    zFusohVoucherSJ
    zFusohVoucherPackingList
    zFusohVoucherInvoice
    zFusohVoucherInvoice2
		zFusohVoucherInvoice3
		zFusohVoucherPembayaran
		zFusohRekapPenawaran
    zFusohRekapOrderPenjualan
    zFusohRekapSuratJalan
    zFusohRekapInvoice
    zFusohRekapPembayaran
    zFusohRekapSJDetail
    zFusohRekapSJKurs
    zFusohRekapSJ

    'tm
    tSuratJalan
    tBayAllocation

    'Sanyu
    zSanyuVoucherSO
    zSanyuVoucherPackingList
    zSanyuVoucherPackingListDetail
    zSanyuVoucherIV
    zSanyuVoucherCP

    'nishi
    zNishiVoucherJOImpor
    zNishiVoucherJOEkspor
    zNishiVoucherIV
    zNishiVoucherDN
    zNishiVoucherIVStorage
    zNishiVoucherIVTruck
    zNishiVoucherSQ
    zNishiVoucherSQstorage
    zNishiVoucherSQTruck
    zNishiRekapJOEkspor
    zNishiRekapJOImpor
    zNishiRekapIV
    zNishiRekapIVStorage
    zNishiRekapIVTruck

    'travel
    zTravelVoucherDP
    zTravelRekapIV
    zTravelVoucherIV
    zTravelVoucherCP
    zTravelSisaPiutang

  End Enum
  Friend Shared Function GetReport(ByVal reportCode As reportName) As String
    Select Case reportCode
      Case reportName.VoucherSQ : Return "60101"
      Case reportName.VoucherSO : Return "60102"
      Case reportName.VoucherDP : Return "60103"
      Case reportName.VoucherSJ : Return "60104"
      Case reportName.VoucherIV : Return "60105"
      Case reportName.VoucherCP : Return "60106"
      Case reportName.VoucherFP : Return "60107"
      Case reportName.VoucherFPValas : Return "60108"
      Case reportName.VoucherRN : Return "60109"
      Case reportName.VoucherJurnal : Return "60110"
      Case reportName.RekapSQ : Return "60201"
      Case reportName.RekapSQDetail : Return "60202"
      Case reportName.RekapSO : Return "60203"
      Case reportName.RekapSODetail : Return "60204"
      Case reportName.RekapDP : Return "60205"
      Case reportName.RekapSJ : Return "60206"
      Case reportName.RekapSJDetail : Return "60207"
      Case reportName.RekapIV : Return "60208"
      Case reportName.RekapIVDetail : Return "60209"
      Case reportName.RekapCP : Return "60210"
      Case reportName.RekapCPDetail : Return "60211"
      Case reportName.RekapPPN : Return "60212"
      Case reportName.RekapQS : Return "60213"
			Case reportName.RekapIVDetail2 : Return "60214"
			Case reportName.RekapHPP : Return "60215"

			Case reportName.TravelVoucherIV : Return "60105"
      Case reportName.TravelVoucherFP : Return "60107"


      Case reportName.SuratPiutang : Return "60301"
      Case reportName.KartuPiutang : Return "60302"
      Case reportName.KartuPiutangDetail : Return "60303"
      Case reportName.DaftarPiutang : Return "60304"
      Case reportName.UmurPiutang : Return "60305"
      Case reportName.LabaRugiPerInvoice : Return "60306"
      Case reportName.LabaRugiPOS : Return "60307"
      Case reportName.LabaRugiPerBarang : Return "60308"
      Case reportName.LabaRugiPerHari : Return "60309"
      Case reportName.LabaRugiPerBulan : Return "60310"

      Case reportName.zVoucherParamaIV1 : Return "60199"
      Case reportName.zVoucherParamaIV2 : Return "60198"
      Case reportName.zVoucherParamaIV3 : Return "60197"
      Case reportName.zVoucherParamaIV4 : Return "60196"
      Case reportName.zVoucherParamaPajak : Return "60195"
      Case reportName.zVoucherParamaSO : Return "60194"
      Case reportName.zVoucherParamaCP : Return "60193"
      Case reportName.zRekapIV : Return "60192"


        'forwarder
      Case reportName.zForwarderVoucherInvoice : Return "60901"
      Case reportName.zForwarderVoucherInvoiceDIce : Return "60902"
      Case reportName.zForwarderVoucherInvoiceDDry : Return "60903"
      Case reportName.zForwarderVoucherFP : Return "60904"
      Case reportName.zForwarderStuffing : Return "60905"
      Case reportName.zForwarderVoucherInvoiceDIce2 : Return "60906"
      Case reportName.zForwarderVoucherInvoiceDDry2 : Return "60907"


        '======= Custom Report

        'rexxa
      Case reportName.zRexxaVoucherInvoice : Return "69101"
      Case reportName.zRexxaVoucherSO : Return "69102"
      Case reportName.zRexxaVoucherInvoiceGedung : Return "69103"
      Case reportName.zRexxaVoucherMutasiKeluar : Return "69104"
      Case reportName.zRexxaVoucherMutasiMasuk : Return "69105"

      Case reportName.zRexxaRekapMutasiKeluar : Return "69201"
      Case reportName.zRexxaRekapMutasiMasuk : Return "69202"
      Case reportName.zRexxaRekapAlatGudang : Return "69203"
      Case reportName.zRexxaRekapAlatGudang2 : Return "69204"
      Case reportName.zRexxaSaldoPiutang : Return "69205"
      Case reportName.zRexxaUmurPiutang : Return "69206"
      Case reportName.zRexxaKartuPiutang : Return "69207"
      Case reportName.zRexxaKartuPiutangDetail : Return "69208"

        'woojin
      Case reportName.zWoojinVoucherSO : Return "69111"
      Case reportName.zWoojinVoucherIV : Return "69112"
      Case reportName.zWoojinVoucherFP : Return "69113"
      Case reportName.zWoojinRekapPPN : Return "69211"
			Case reportName.zWoojinRekapMaterialOrder : Return "69212"

				'fusoh
			Case reportName.zFusohVoucherSQ : Return "68101"
      Case reportName.zFusohVoucherSO : Return "68102"
			Case reportName.zFusohVoucherSJ : Return "68103"
			Case reportName.zFusohVoucherPackingList : Return "68104"
			Case reportName.zFusohVoucherInvoice : Return "68105"
			Case reportName.zFusohVoucherPembayaran : Return "68106"
      Case reportName.zFusohVoucherSQ2 : Return "68107"
      Case reportName.zFusohVoucherInvoice2 : Return "68108"
			Case reportName.zFusohVoucherInvoice3 : Return "68109"
			Case reportName.zFusohRekapPenawaran : Return "68201"
			Case reportName.zFusohRekapOrderPenjualan : Return "68202"
			Case reportName.zFusohRekapSuratJalan : Return "68203"
			Case reportName.zFusohRekapInvoice : Return "68204"
			Case reportName.zFusohRekapPembayaran : Return "68205"
      Case reportName.zFusohRekapSJDetail : Return "68206"
      Case reportName.zFusohRekapSJKurs : Return "68207"
			Case reportName.zFusohRekapSJ : Return "68208"

			Case reportName.zSanyuVoucherSO : Return "67101"
      Case reportName.zSanyuVoucherPackingList : Return "67103"
      Case reportName.zSanyuVoucherPackingListDetail : Return "67104"
      Case reportName.zSanyuVoucherIV : Return "67105"
      Case reportName.zSanyuVoucherCP : Return "67106"

        'tm
      Case reportName.tSuratJalan : Return "60601"
      Case reportName.tBayAllocation : Return "60602"




        'custom pelanggan "6903101"  69 03 (customer) 1 grup 01 urutan


        'nishi
      Case reportName.zNishiVoucherJOImpor : Return "6903101"
      Case reportName.zNishiVoucherIV : Return "6903102"
      Case reportName.zNishiVoucherDN : Return "6903103"
      Case reportName.zNishiVoucherJOEkspor : Return "6903104"
      Case reportName.zNishiVoucherIVStorage : Return "6903105"
      Case reportName.zNishiVoucherIVTruck : Return "6903106"

      Case reportName.zNishiRekapJOEkspor : Return "6903201"
      Case reportName.zNishiRekapJOImpor : Return "6903202"
      Case reportName.zNishiRekapIV : Return "6903203"
      Case reportName.zNishiRekapIVStorage : Return "6903204"
			Case reportName.zNishiRekapIVTruck : Return "6903205"

				'travel
			Case reportName.zTravelVoucherDP : Return "6904101"
      Case reportName.zTravelVoucherIV : Return "6904102"
      Case reportName.zTravelVoucherCP : Return "6904103"
      Case reportName.zTravelRekapIV : Return "6904201"
      Case reportName.zTravelSisaPiutang : Return "6904202"

      Case Else : Return Nothing
    End Select
  End Function
	Shared Function GetReportFilter(ByVal reportCode As String) As Core.Win.Forms.ReportFilter
		'MsgBox("T:" & reportCode)
		Select Case reportCode
			Case GetReport(reportName.VoucherSQ) : Return New RF_DataDataTransaksi(Persistent.SumberDataJenis.SQ, reportName.VoucherSQ)
			Case GetReport(reportName.VoucherSO) : Return New RF_DataDataTransaksi(Persistent.SumberDataJenis.SO, reportName.VoucherSO)
			Case GetReport(reportName.VoucherDP) : Return New RF_DataDataTransaksi(Persistent.SumberDataJenis.DP, reportName.VoucherDP)
			Case GetReport(reportName.VoucherSJ) : Return New RF_DataDataTransaksi(Persistent.SumberDataJenis.SJ, reportName.VoucherSJ)
			Case GetReport(reportName.VoucherIV) : Return New RF_DataDataTransaksi(Persistent.SumberDataJenis.IV, reportName.VoucherIV)
			Case GetReport(reportName.VoucherCP) : Return New RF_DataDataTransaksi(Persistent.SumberDataJenis.CP, reportName.VoucherCP)
			Case GetReport(reportName.VoucherFP) : Return New RF_DataDataTransaksi(Persistent.SumberDataJenis.IV, reportName.VoucherFP)
			Case GetReport(reportName.VoucherFPValas) : Return New RF_DataDataTransaksi(Persistent.SumberDataJenis.IV, reportName.VoucherFPValas)
			Case GetReport(reportName.VoucherRN) : Return New RF_DataDataTransaksi(Persistent.SumberDataJenis.RN, reportName.VoucherRN)
			Case GetReport(reportName.VoucherJurnal) : Return New RF_DataDataJurnal
			Case GetReport(reportName.TravelVoucherIV) : Return New RF_DataDataTransaksi(Persistent.SumberDataJenis.IV, reportName.TravelVoucherIV)
			Case GetReport(reportName.TravelVoucherFP) : Return New RF_DataDataTransaksi(Persistent.SumberDataJenis.IV, reportName.TravelVoucherFP)

			Case GetReport(reportName.RekapSQ) : Return New RF_DataDataTransaksi(Persistent.SumberDataJenis.SQ, reportName.RekapSQ)
			Case GetReport(reportName.RekapSQDetail) : Return New RF_DataDataTransaksi(Persistent.SumberDataJenis.SQ, reportName.RekapSQDetail)
			Case GetReport(reportName.RekapSO) : Return New RF_DataDataTransaksi(Persistent.SumberDataJenis.SO, reportName.RekapSO)
			Case GetReport(reportName.RekapSODetail) : Return New RF_DataDataTransaksi(Persistent.SumberDataJenis.SO, reportName.RekapSODetail)
			Case GetReport(reportName.RekapDP) : Return New RF_DataDataTransaksi(Persistent.SumberDataJenis.DP, reportName.RekapDP)
			Case GetReport(reportName.RekapSJ) : Return New RF_DataDataTransaksi(Persistent.SumberDataJenis.SJ, reportName.RekapSJ)
			Case GetReport(reportName.RekapSJDetail) : Return New RF_DataDataTransaksi(Persistent.SumberDataJenis.SJ, reportName.RekapSJDetail)
			Case GetReport(reportName.RekapHPP) : Return New RF_DataDataTransaksi(Persistent.SumberDataJenis.SJ, reportName.RekapSJDetail)
			Case GetReport(reportName.RekapIV) : Return New RF_DataDataTransaksi(Persistent.SumberDataJenis.IV, reportName.RekapIV)
			Case GetReport(reportName.RekapIVDetail) : Return New RF_DataDataTransaksi(Persistent.SumberDataJenis.IV, reportName.RekapIVDetail)
			Case GetReport(reportName.RekapIVDetail2) : Return New RF_DataDataTransaksi(Persistent.SumberDataJenis.IV, reportName.RekapIVDetail2)
			Case GetReport(reportName.RekapCP) : Return New RF_DataDataTransaksi(Persistent.SumberDataJenis.CP, reportName.RekapCP)
			Case GetReport(reportName.RekapCPDetail) : Return New RF_DataDataTransaksi(Persistent.SumberDataJenis.CP, reportName.RekapCPDetail)
			Case GetReport(reportName.RekapPPN) : Return New RF_RekapPPN
			Case GetReport(reportName.RekapQS) : Return New RF_DataDataTransaksi(Persistent.SumberDataJenis.QS, reportName.RekapQS)

			Case GetReport(reportName.SuratPiutang) : Return New RF_Piutang
			Case GetReport(reportName.KartuPiutang) : Return New RF_Piutang
			Case GetReport(reportName.KartuPiutangDetail) : Return New RF_Piutang
			Case GetReport(reportName.DaftarPiutang) : Return New RF_Piutang
			Case GetReport(reportName.UmurPiutang) : Return New RF_Piutang
			Case GetReport(reportName.LabaRugiPerInvoice) : Return New RF_DataDataTransaksi(Persistent.SumberDataJenis.IV, reportName.LabaRugiPerInvoice)
			Case GetReport(reportName.LabaRugiPOS) : Return New RF_DataDataTransaksi(Persistent.SumberDataJenis.QS, reportName.LabaRugiPOS)
			Case GetReport(reportName.LabaRugiPerBarang) : Return New RF_DataDataTransaksi(Persistent.SumberDataJenis.IV, reportName.LabaRugiPerBarang)
			Case GetReport(reportName.LabaRugiPerHari) : Return New RF_DataDataTransaksi(Persistent.SumberDataJenis.IV, reportName.LabaRugiPerHari)
			Case GetReport(reportName.LabaRugiPerBulan) : Return New RF_DataDataTransaksi(Persistent.SumberDataJenis.IV, reportName.LabaRugiPerBulan)

				'parama
			Case GetReport(reportName.zVoucherParamaIV1) : Return New RF_zDataDataTransaksiParama(Persistent.SumberDataJenis.IV)
			Case GetReport(reportName.zVoucherParamaIV2) : Return New RF_zDataDataTransaksiParama(Persistent.SumberDataJenis.IV)
			Case GetReport(reportName.zVoucherParamaIV3) : Return New RF_zDataDataTransaksiParama(Persistent.SumberDataJenis.IV)
			Case GetReport(reportName.zVoucherParamaIV4) : Return New RF_zDataDataTransaksiParama(Persistent.SumberDataJenis.IV)
			Case GetReport(reportName.zVoucherParamaPajak) : Return New RF_zDataDataTransaksiParama(Persistent.SumberDataJenis.IV)
			Case GetReport(reportName.zVoucherParamaSO) : Return New RF_zDataDataTransaksiParama(Persistent.SumberDataJenis.SO)
			Case GetReport(reportName.zVoucherParamaCP) : Return New RF_zDataDataTransaksiParama(Persistent.SumberDataJenis.CP)
			Case GetReport(reportName.zRekapIV) : Return New RF_zDataDataTransaksiParama(Persistent.SumberDataJenis.IV)

				'forwarder
			Case GetReport(reportName.zForwarderVoucherInvoice) : Return New RF_zForwarderDataData(Persistent.SumberDataJenis.IV)
			Case GetReport(reportName.zForwarderVoucherInvoiceDIce) : Return New RF_zForwarderDataData(Persistent.SumberDataJenis.IV)
			Case GetReport(reportName.zForwarderVoucherInvoiceDIce2) : Return New RF_zForwarderDataData(Persistent.SumberDataJenis.IV)
			Case GetReport(reportName.zForwarderVoucherInvoiceDDry) : Return New RF_zForwarderDataData(Persistent.SumberDataJenis.IV)
			Case GetReport(reportName.zForwarderVoucherInvoiceDDry2) : Return New RF_zForwarderDataData(Persistent.SumberDataJenis.IV)
			Case GetReport(reportName.zForwarderVoucherFP) : Return New RF_zForwarderDataData(Persistent.SumberDataJenis.IV)
			Case GetReport(reportName.zForwarderStuffing) : Return New RF_zForwarderDataData(Persistent.SumberDataJenis.SF)

				'rexxa
			Case GetReport(reportName.zRexxaVoucherInvoice) : Return New zRexaRF_DataDataTransaksi(Persistent.SumberDataJenis.IV)
			Case GetReport(reportName.zRexxaVoucherSO) : Return New zRexaRF_DataDataTransaksi(Persistent.SumberDataJenis.SO)
			Case GetReport(reportName.zRexxaVoucherInvoiceGedung) : Return New zRexaRF_DataDataTransaksi(Persistent.SumberDataJenis.IV)
			Case GetReport(reportName.zRexxaVoucherMutasiKeluar) : Return New zRexaRF_DataDataTransaksi(Persistent.SumberDataJenis.TS)
			Case GetReport(reportName.zRexxaVoucherMutasiMasuk) : Return New zRexaRF_DataDataTransaksi(Persistent.SumberDataJenis.TS)
			Case GetReport(reportName.zRexxaRekapMutasiKeluar) : Return New zRexaRF_RekapData(reportName.zRexxaRekapMutasiKeluar)
			Case GetReport(reportName.zRexxaRekapMutasiMasuk) : Return New zRexaRF_RekapData(reportName.zRexxaRekapMutasiMasuk)
			Case GetReport(reportName.zRexxaRekapAlatGudang) : Return New zRexaRF_RekapData(reportName.zRexxaRekapAlatGudang)
			Case GetReport(reportName.zRexxaRekapAlatGudang2) : Return New zRexaRF_RekapData(reportName.zRexxaRekapAlatGudang2)
			Case GetReport(reportName.zRexxaUmurPiutang) : Return New zRexxaRF_Piutang
			Case GetReport(reportName.zRexxaSaldoPiutang) : Return New zRexxaRF_Piutang
			Case GetReport(reportName.zRexxaKartuPiutang) : Return New zRexxaRF_Piutang
			Case GetReport(reportName.zRexxaKartuPiutangDetail) : Return New zRexxaRF_Piutang

				'woojin
			Case GetReport(reportName.zWoojinVoucherSO) : Return New zWoojinRF_DataDataTransaksi(Persistent.SumberDataJenis.SO)
			Case GetReport(reportName.zWoojinVoucherIV) : Return New zWoojinRF_DataDataTransaksi(Persistent.SumberDataJenis.IV)
			Case GetReport(reportName.zWoojinVoucherFP) : Return New zWoojinRF_DataDataTransaksi(Persistent.SumberDataJenis.IV)
			Case GetReport(reportName.zWoojinRekapPPN) : Return New zWoojinRF_RekapData(reportName.zWoojinRekapPPN)
			Case GetReport(reportName.zWoojinRekapMaterialOrder) : Return New zWoojinRF_RAB(reportName.zWoojinRekapMaterialOrder)

				'fusoh
			Case GetReport(reportName.zFusohVoucherSQ) : Return New RF_FusohVoucher(Persistent.SumberDataJenis.SQ)
			Case GetReport(reportName.zFusohVoucherSQ2) : Return New RF_FusohVoucher(Persistent.SumberDataJenis.SQ)
			Case GetReport(reportName.zFusohVoucherSO) : Return New RF_FusohVoucher(Persistent.SumberDataJenis.SO)
			Case GetReport(reportName.zFusohVoucherSJ) : Return New RF_FusohVoucher(Persistent.SumberDataJenis.FD)
			Case GetReport(reportName.zFusohVoucherPackingList) : Return New RF_FusohVoucher(Persistent.SumberDataJenis.SJ)
			Case GetReport(reportName.zFusohRekapInvoice) : Return New RF_FusohVoucher(Persistent.SumberDataJenis.IV)
			Case GetReport(reportName.zFusohRekapSuratJalan) : Return New RF_FusohVoucher(Persistent.SumberDataJenis.FD)
			Case GetReport(reportName.zFusohRekapOrderPenjualan) : Return New RF_FusohVoucher(Persistent.SumberDataJenis.SO)
			Case GetReport(reportName.zFusohVoucherInvoice) : Return New RF_FusohVoucher(Persistent.SumberDataJenis.IV)
			Case GetReport(reportName.zFusohVoucherInvoice2) : Return New RF_FusohVoucher(Persistent.SumberDataJenis.IV)
			Case GetReport(reportName.zFusohVoucherInvoice3) : Return New RF_FusohVoucher(Persistent.SumberDataJenis.IV)



			Case GetReport(reportName.zFusohRekapSJDetail) : Return New RF_FusohVoucher(Persistent.SumberDataJenis.FD)
			Case GetReport(reportName.zFusohRekapSJKurs) : Return New RF_FusohTanggal(reportName.zFusohRekapSJKurs)
			Case GetReport(reportName.zFusohRekapSJ) : Return New RF_FusohRekap(Persistent.SumberDataJenis.FD)
				'tm
			Case GetReport(reportName.tSuratJalan) : Return New RF_TMVoucher(Persistent.SumberDataJenis.SO)

				'sanyu
			Case GetReport(reportName.zSanyuVoucherSO) : Return New RF_SanyuVoucher(Persistent.SumberDataJenis.SO, reportName.zSanyuVoucherSO)
			Case GetReport(reportName.zSanyuVoucherPackingList) : Return New RF_SanyuVoucher(Persistent.SumberDataJenis.SJ, reportName.zSanyuVoucherPackingList)
			Case GetReport(reportName.zSanyuVoucherPackingListDetail) : Return New RF_SanyuVoucher(Persistent.SumberDataJenis.SJ, reportName.zSanyuVoucherPackingListDetail)
			Case GetReport(reportName.zSanyuVoucherIV) : Return New RF_SanyuVoucher(Persistent.SumberDataJenis.IV, reportName.zSanyuVoucherIV)
			Case GetReport(reportName.zSanyuVoucherCP) : Return New RF_SanyuVoucher(Persistent.SumberDataJenis.CP, reportName.zSanyuVoucherCP)

				'nishi
			Case GetReport(reportName.zNishiVoucherJOImpor) : Return New RF_zNishiVoucher(Persistent.SumberDataJenis.JO, reportName.zNishiVoucherJOImpor)
			Case GetReport(reportName.zNishiVoucherJOEkspor) : Return New RF_zNishiVoucher(Persistent.SumberDataJenis.JO, reportName.zNishiVoucherJOEkspor)
			Case GetReport(reportName.zNishiVoucherDN) : Return New RF_zNishiVoucher(Persistent.SumberDataJenis.DN, reportName.zNishiVoucherDN)
			Case GetReport(reportName.zNishiVoucherIV) : Return New RF_zNishiVoucher(Persistent.SumberDataJenis.IV, reportName.zNishiVoucherIV)
			Case GetReport(reportName.zNishiVoucherIVStorage) : Return New RF_zNishiVoucher(Persistent.SumberDataJenis.IV, reportName.zNishiVoucherIVStorage)
			Case GetReport(reportName.zNishiVoucherIVTruck) : Return New RF_zNishiVoucher(Persistent.SumberDataJenis.IV, reportName.zNishiVoucherIVTruck)
			Case GetReport(reportName.zNishiRekapJOEkspor) : Return New RF_zNishiVoucher(Persistent.SumberDataJenis.JO, reportName.zNishiRekapJOEkspor)
			Case GetReport(reportName.zNishiRekapJOImpor) : Return New RF_zNishiVoucher(Persistent.SumberDataJenis.JO, reportName.zNishiRekapJOImpor)
			Case GetReport(reportName.zNishiRekapIV) : Return New RF_zNishiVoucher(Persistent.SumberDataJenis.IV, reportName.zNishiRekapJOImpor)
			Case GetReport(reportName.zNishiRekapIVStorage) : Return New RF_zNishiVoucher(Persistent.SumberDataJenis.IV, reportName.zNishiRekapIVStorage)
			Case GetReport(reportName.zNishiRekapIVTruck) : Return New RF_zNishiVoucher(Persistent.SumberDataJenis.IV, reportName.zNishiRekapIVTruck)

				'Travel
			Case GetReport(reportName.zTravelVoucherDP) : Return New RF_TravelDataTransaksi(Persistent.SumberDataJenis.IV, reportName.zTravelRekapIV)
			Case GetReport(reportName.zTravelVoucherIV) : Return New RF_TravelDataTransaksi(Persistent.SumberDataJenis.IV, reportName.zTravelVoucherIV)
			Case GetReport(reportName.zTravelVoucherCP) : Return New RF_TravelDataTransaksi(Persistent.SumberDataJenis.CP, reportName.zTravelVoucherCP)
			Case GetReport(reportName.zTravelRekapIV) : Return New RF_TravelDataTransaksi(Persistent.SumberDataJenis.IV, reportName.zTravelRekapIV)
			Case GetReport(reportName.zTravelSisaPiutang) : Return New RF_TravelDataTransaksi(Persistent.SumberDataJenis.IV, reportName.zTravelSisaPiutang)
			Case Else : Return Nothing
		End Select
	End Function
End Class