Imports NuSoft.NUI.Win.Forms.Modules.NuSoft004.Persistent

Public Class MainClass
	Shared Function GetSmallImage() As Drawing.Image
		Return My.Resources.account_balances_16
	End Function
	Shared Function GetLargeImage() As Drawing.Image
		Return My.Resources.account_balances_24
	End Function
	Shared Function GetModuleId() As NPO.Modules.ModuleId
		Return NPO.Modules.ModuleId.Inventory
	End Function

	Private Enum menuName
		MasterPajak
		MasterSatuan
		MasterTipeTransaksi
		MasterGudang
		MasterItem
		MasterKontak
		MasterBiayaLain
		MasterKategori
		MasterSubKategori
		MasterMerk

		DataCekStock
		DataStatistik
		DataUserLog
		DataNilaiPersediaan

		TransaksiPermintaan
		TransaksiMutasi
		TransaksiPemakaianBarang
		TransaksiPemakaianBarang2
		TransaksiProduksi
		TransaksiPenyesuaian
		TransaksiStockOpname
		TransaksiStockOpnameProses
		TransaksiSaldoAwal
		SettingInventory
		SettingMasterItem

		xDiptaMasterLokasi
		xDiptaInbound
		xDiptaOutbound

		zFusohItem
		zFusohMasterMesin
		zFusohSaldoAwalStok
		zFusohOrderProduksi
		zFusohProduksi
		zFusohDataCekStock
		zFusohBackToMaterial
		zFusohStockAdjustment
		zFusohDataSerial
		zFusohTransferFinishGoods
		zFusohAdjusmentFG
		zFusohAdjusmentRM
		zFusohDataProduksi
		zFusohDataStock
		zFusohCekData
		zFusohDataDempyou
		zFusohDailyProcess
		zFusohSettingWIP
		zFusohCuttingWIP
		zFusohMasterProcessCutting
		zFusohStockTacking
		zFusohProductionPlan
    zFusohBreakdownWIP
    zFusohDataDempyou2

    zSanyuRencanaProduksi
		zSanyuProduksi
		zSanyuDataCekStock
		zSanYuMasterItem
		zSanYuMutasiStock

		zNishiMasterItem
		zNishiBarangMasuk
		zNishiPermintaanBarangKeluar
		zNishiBarangKeluar
		zNishiSaldoAwalStock
		zNishiDataCekStock
		zNishiDataStock

		zTravelTransaksiPenyerahanBarang
		zTravelDataCekStok
		zTravelMasterItem
	End Enum
	Private Shared Function GetMenu(ByVal menuCode As String) As menuName
		Select Case menuCode
			Case "0101.01" : Return menuName.TransaksiPermintaan
			Case "0101.02" : Return menuName.TransaksiMutasi
			Case "0101.03" : Return menuName.TransaksiPemakaianBarang
			Case "0101.04" : Return menuName.TransaksiPenyesuaian
			Case "0101.05" : Return menuName.TransaksiProduksi
			Case "0101.06" : Return menuName.TransaksiStockOpname
			Case "0101.07" : Return menuName.TransaksiStockOpnameProses
			Case "0101.08" : Return menuName.TransaksiSaldoAwal
			Case "0101.09" : Return menuName.TransaksiPemakaianBarang2

			Case "0102.01" : Return menuName.DataCekStock
			Case "0102.02" : Return menuName.DataStatistik
			Case "0102.03" : Return menuName.DataNilaiPersediaan
			Case "0102.09" : Return menuName.DataUserLog

			Case "0102.99" : Return menuName.zFusohDataCekStock


			Case "0103.01" : Return menuName.MasterTipeTransaksi
			Case "0103.02" : Return menuName.MasterSatuan
			Case "0103.03" : Return menuName.MasterGudang
			Case "0103.04" : Return menuName.MasterPajak
			Case "0103.05" : Return menuName.MasterItem
			Case "0103.06" : Return menuName.MasterKontak
			Case "0103.07" : Return menuName.MasterBiayaLain
			Case "0103.08" : Return menuName.MasterKategori
			Case "0103.09" : Return menuName.MasterSubKategori
			Case "0103.10" : Return menuName.MasterMerk
			Case "0104.01" : Return menuName.SettingInventory
			Case "0104.02" : Return menuName.SettingMasterItem

			Case "0499.01" : Return menuName.xDiptaMasterLokasi
			Case "0499.02" : Return menuName.xDiptaInbound
			Case "0499.03" : Return menuName.xDiptaOutbound

			'========== Fusoh =========
			Case "0498.01" : Return menuName.zFusohOrderProduksi
			Case "0498.02" : Return menuName.zFusohProduksi
			Case "0498.03" : Return menuName.zFusohBackToMaterial
			Case "0498.04" : Return menuName.zFusohStockAdjustment
			Case "0498.09" : Return menuName.zFusohSaldoAwalStok
			Case "0498.10" : Return menuName.zFusohTransferFinishGoods
			Case "0498.11" : Return menuName.zFusohAdjusmentFG
			Case "0498.12" : Return menuName.zFusohAdjusmentRM
			Case "0498.13" : Return menuName.zFusohDailyProcess
			Case "0498.14" : Return menuName.zFusohCuttingWIP
			Case "0498.90" : Return menuName.zFusohMasterMesin
			Case "0498.91" : Return menuName.zFusohMasterProcessCutting
			Case "0498.92" : Return menuName.zFusohSettingWIP
			Case "0498.99" : Return menuName.zFusohItem
			Case "04902.2.01" : Return menuName.zFusohDataSerial
			Case "04902.2.02" : Return menuName.zFusohDataProduksi
			Case "04902.2.03" : Return menuName.zFusohDataStock
			Case "04902.2.04" : Return menuName.zFusohCekData
			Case "04902.2.05" : Return menuName.zFusohDataDempyou
			Case "04902.2.06" : Return menuName.zFusohStockTacking
			Case "04902.2.07" : Return menuName.zFusohProductionPlan
			Case "04902.2.08" : Return menuName.zFusohBreakdownWIP
      Case "04902.2.09" : Return menuName.zFusohDataDempyou2
        'catatan penomoran '049xx.y.zz --> xx nomor urut custom (perPelanggan), y = 1 transaksi,2 data, 3 report, 4 master, 5 setting, zz= no urut
        'sanYu
        '========== SanYu =========
      Case "04901.1.01" : Return menuName.zSanyuRencanaProduksi
			Case "04901.1.02" : Return menuName.zSanyuProduksi
			Case "04901.1.03" : Return menuName.zSanYuMutasiStock
			Case "04901.2.01" : Return menuName.zSanyuDataCekStock
			Case "04901.4.01" : Return menuName.zSanYuMasterItem

				'==nishi
			Case "04903.1.01" : Return menuName.zNishiBarangMasuk
			Case "04903.1.02" : Return menuName.zNishiPermintaanBarangKeluar
			Case "04903.1.03" : Return menuName.zNishiBarangKeluar
			Case "04903.1.04" : Return menuName.zNishiBarangKeluar
			Case "04903.2.01" : Return menuName.zNishiDataCekStock
			Case "04903.2.02" : Return menuName.zNishiDataCekStock
			Case "04903.3.01" : Return menuName.zNishiMasterItem

				'========== Travel =========
			Case "04904.1.01" : Return menuName.zTravelTransaksiPenyerahanBarang
			Case "04904.2.01" : Return menuName.zTravelDataCekStok
			Case "04904.3.01" : Return menuName.zTravelMasterItem

			Case Else : Return Nothing
		End Select
	End Function
	Shared Function GetForm(ByVal menuCode As String) As Core.Win.Forms.NuSoftForm
		Select Case GetMenu(menuCode)
			Case menuName.TransaksiPermintaan : Return New UI_PermintaanStock(Persistent.eJenisPermintaan.PermintaanMutasi)
			Case menuName.TransaksiMutasi : Return New UI_MutasiStock
			Case menuName.TransaksiPemakaianBarang : Return New UI_PemakaianStock
			Case menuName.TransaksiPemakaianBarang2 : Return New UI_zPemakaianStock
			Case menuName.TransaksiPenyesuaian : Return New UI_PenyesuaianStock
			Case menuName.TransaksiProduksi : Return New UI_Produksi
			Case menuName.TransaksiStockOpname : Return New UI_StockOpname
			Case menuName.TransaksiStockOpnameProses : Return New UI_StockOpnameProses
			Case menuName.TransaksiSaldoAwal : Return New UI_SaldoAwal
			Case menuName.DataCekStock : Return New UI_CekStock
			Case menuName.DataNilaiPersediaan : Return New UI_BukuBesarStock
			Case menuName.DataUserLog : Return New UI_ZLog
				'Case menuName.DataStatistik : Return New UI_CekStock
			Case menuName.MasterPajak : Return New UI_Pajak
			Case menuName.MasterSatuan : Return New UI_Uom
			Case menuName.MasterTipeTransaksi : Return New UI_TipeTransaksi
			Case menuName.MasterGudang : Return New UI_Gudang
			Case menuName.MasterItem : Return New UI_Barang
			Case menuName.MasterKontak : Return NuSoft001.MainClass.GetForm("0103.02")
			Case menuName.MasterBiayaLain : Return New UI_Cost
			Case menuName.SettingInventory : Return New UI_Setting
			Case menuName.SettingMasterItem : Return New UI_SettingItem
			Case menuName.MasterKategori : Return New UI_Kategori
			Case menuName.MasterSubKategori : Return New UI_SubKategori
			Case menuName.MasterMerk : Return New UI_Merk

			Case menuName.xDiptaMasterLokasi : Return New UI_MasterLokasi
			Case menuName.xDiptaInbound : Return New UI_Inbound
			Case menuName.xDiptaOutbound : Return New UI_BarangOutbond

				'=== fusoh
			Case menuName.zFusohOrderProduksi : Return New UI_FusohOrderProduksi
			Case menuName.zFusohProduksi : Return New UI_FusohProduksi
			Case menuName.zFusohBackToMaterial : Return New UI_FusohBackToMaterial
			Case menuName.zFusohSaldoAwalStok : Return New UI_FusohSaldoAwal
			Case menuName.zFusohItem : Return New UI_FusohBarang
			Case menuName.zFusohDataCekStock : Return New UI_FusohCekStock
			Case menuName.zFusohDataSerial : Return New UI_FusohDataSerial2
			Case menuName.zFusohTransferFinishGoods : Return New UI_FusohTransferStock
			Case menuName.zFusohAdjusmentFG : Return New UI_FusohAdjusmentFG
			Case menuName.zFusohAdjusmentRM : Return New UI_FusohAdjusmentRM
			Case menuName.zFusohDataProduksi : Return New UI_FusohDataProduksi
			Case menuName.zFusohDataStock : Return New UI_FusohDataStock
			Case menuName.zFusohCekData : Return New UI_FusohCekData
			Case menuName.zFusohDataDempyou : Return New UI_FusohDataDempyou
			Case menuName.zFusohDailyProcess : Return New UI_FusohDailyProsesWIP
			Case menuName.zFusohMasterMesin : Return New UI_FusohMesin
			Case menuName.zFusohSettingWIP : Return New UI_SettingWIP
			Case menuName.zFusohCuttingWIP : Return New UI_FusohCuttingWIP
			Case menuName.zFusohMasterProcessCutting : Return New UI_FusohMasterProcessCutting
			Case menuName.zFusohStockTacking : Return New UI_FusohStockTacking
			Case menuName.zFusohProductionPlan : Return New UI_FusohProductionPlan
      Case menuName.zFusohBreakdownWIP : Return New UI_FusohBreakdownWIP
      Case menuName.zFusohDataDempyou2 : Return New UI_FusohDempyou

        '=== SanYu
      Case menuName.zSanYuMasterItem : Return New UI_SanYuBarang
			Case menuName.zSanyuRencanaProduksi : Return New UI_SanYuRencanaProduksi
			Case menuName.zSanYuMutasiStock : Return New UI_SanYuMutasiStock
			Case menuName.zSanyuProduksi : Return New UI_SanYuProduksi
			Case menuName.zSanyuDataCekStock : Return New UI_SanYuCekStock

				'=== Nishi
			Case menuName.zNishiMasterItem : Return New UI_NishiBarang
			Case menuName.zNishiBarangMasuk : Return New UI_NishiStockIN
			Case menuName.zNishiPermintaanBarangKeluar : Return New UI_NishiPermintaanStockOut
			Case menuName.zNishiBarangKeluar : Return New UI_NishiStockOut
			Case menuName.zNishiDataCekStock : Return New UI_NishiCekStock

				'=== Travel
			Case menuName.zTravelTransaksiPenyerahanBarang : Return New UI_TravelPenyerahanBarang
				'Case menuName.zTravelDataCekStok : Return New UI_TravelMasterItem
			Case menuName.zTravelMasterItem : Return New UI_TravelMasterItem(JenisBarang.Persediaan)

			Case Else : Return Nothing
		End Select
	End Function

	Friend Enum reportName
		VoucherPermintaan
		VoucherMutasiStock
		VoucherPemakaianBarang
		VoucherPenyesuaianStock
		VoucherProduksi
		RekapPermintaanStock
		RekapMutasiStock
		RekapPemakaianStock
		KartuStock
		BukuBesarStock
		NilaiPersediaan
		AnalisaPersediaan
		BlankoStockOpname
		StockPerTanggal
		StockMinimum
		TransaksiBarang


		'====== Fusoh
		zFusohDempyou
		zFusohProcessRequest
		zFusohSlipCard
		zFusohRekapDempyou
		zFusohRekapKartuStok
		zFusohRekapStockBalance
		zFusohRekapDeliveryData
		zFusohRekapOrderBalance
		zFusohRekapDeliveryForecast
		zFusohRekapTurnover
		zFusohRekapOrderProduksi
		zFusohRekapProduksi
		zFusohRekapDetailStokBahanBaku
		zFusohRekapSerial
		zFusohRekapDailyProcess
		zFusohMutasiWIP
		zFusohMutasiWIPDetail

		'===== Sanyu
		zSanyuVoucherRencanaProduksi
		zSanyuVoucherProduksi
		zSanyuRekapProduksi
		zSanyuRekapRandemen
		zSanyuTallyCard
		zSanyuVoucherMutasi

		'===== Nishi
		zNishiVoucherBarangMasukCoil
		zNishiVoucherBarangMasukSteel
		zNishiVoucherBarangKeluarCoil
		zNishiVoucherBarangKeluarSteel
		zNishiKartuStockDetail
		zNishiKartuStockSummary
	End Enum
	Friend Shared Function GetReport(ByVal reportCode As reportName) As String
		Select Case reportCode
			Case reportName.VoucherPermintaan : Return "40101"
			Case reportName.VoucherMutasiStock : Return "40102"
			Case reportName.VoucherPemakaianBarang : Return "40103"
			Case reportName.VoucherPenyesuaianStock : Return "40104"
			Case reportName.VoucherProduksi : Return "40105"
			Case reportName.KartuStock : Return "40201"
			Case reportName.NilaiPersediaan : Return "40202"
			Case reportName.BukuBesarStock : Return "40203"
			Case reportName.AnalisaPersediaan : Return "40204"
			Case reportName.BlankoStockOpname : Return "40205"
			Case reportName.StockPerTanggal : Return "40206"
			Case reportName.StockMinimum : Return "40207"
			Case reportName.RekapPemakaianStock : Return "40208"
			Case reportName.TransaksiBarang : Return "40209"


			Case reportName.zFusohDempyou : Return "48101"
			Case reportName.zFusohProcessRequest : Return "48102"
			Case reportName.zFusohSlipCard : Return "48103"
			Case reportName.zFusohRekapDempyou : Return "48201"
			Case reportName.zFusohRekapKartuStok : Return "48202"
			Case reportName.zFusohRekapStockBalance : Return "48203"
			Case reportName.zFusohRekapDeliveryData : Return "48204"
			Case reportName.zFusohRekapOrderBalance : Return "48205"
			Case reportName.zFusohRekapDeliveryForecast : Return "48206"
			Case reportName.zFusohRekapTurnover : Return "48207"
			Case reportName.zFusohRekapOrderProduksi : Return "48208"
			Case reportName.zFusohRekapProduksi : Return "48209"
			Case reportName.zFusohRekapDetailStokBahanBaku : Return "48210"
			Case reportName.zFusohRekapSerial : Return "48211"
			Case reportName.zFusohRekapDailyProcess : Return "48212"
			Case reportName.zFusohMutasiWIP : Return "48213"
			Case reportName.zFusohMutasiWIPDetail : Return "48214"

				'4901101 ==> 4 Module . 9 Custom 01 Customer 1 1 Induk 01 urutan
			Case reportName.zSanyuVoucherRencanaProduksi : Return "4901101"
			Case reportName.zSanyuVoucherProduksi : Return "4901102"
			Case reportName.zSanyuTallyCard : Return "4901103"
			Case reportName.zSanyuVoucherMutasi : Return "4901104"
			Case reportName.zSanyuRekapProduksi : Return "4901201"
			Case reportName.zSanyuRekapRandemen : Return "4901202"

			Case reportName.zNishiVoucherBarangMasukCoil : Return "4902101"
			Case reportName.zNishiVoucherBarangMasukSteel : Return "4902102"
			Case reportName.zNishiVoucherBarangKeluarCoil : Return "4902103"
			Case reportName.zNishiVoucherBarangKeluarSteel : Return "4902104"
			Case reportName.zNishiKartuStockDetail : Return "4902201"
			Case reportName.zNishiKartuStockSummary : Return "4902202"

			Case Else : Return Nothing
		End Select
	End Function
	Shared Function GetReportFilter(ByVal reportCode As String) As Core.Win.Forms.ReportFilter
		Select Case reportCode
			Case GetReport(reportName.VoucherPermintaan) : Return New RF_DataDataTransaksi(Persistent.SumberDataJenis.PB)
			Case GetReport(reportName.VoucherMutasiStock) : Return New RF_DataDataTransaksi(Persistent.SumberDataJenis.ST)
			Case GetReport(reportName.VoucherPemakaianBarang) : Return New RF_DataDataTransaksi(Persistent.SumberDataJenis.CS)
			Case GetReport(reportName.VoucherPenyesuaianStock) : Return New RF_DataDataTransaksi(Persistent.SumberDataJenis.PS)
			Case GetReport(reportName.VoucherProduksi) : Return New RF_DataDataTransaksi(Persistent.SumberDataJenis.AM)
			Case GetReport(reportName.RekapPermintaanStock) : Return New RF_DataDataTransaksi(Persistent.SumberDataJenis.PB)
			Case GetReport(reportName.RekapMutasiStock) : Return New RF_DataDataTransaksi(Persistent.SumberDataJenis.ST)
			Case GetReport(reportName.RekapPemakaianStock) : Return New RF_DataDataTransaksi(Persistent.SumberDataJenis.CS)
			Case GetReport(reportName.KartuStock) : Return New RF_BukuBesarStock(RF_BukuBesarStock.TipeForm.KartuStock)
			Case GetReport(reportName.BukuBesarStock) : Return New RF_BukuBesarStock(RF_BukuBesarStock.TipeForm.BukuBesar)
			Case GetReport(reportName.NilaiPersediaan) : Return New RF_BukuBesarStock(RF_BukuBesarStock.TipeForm.NilaiPersediaan)
			Case GetReport(reportName.BlankoStockOpname) : Return New RF_BukuBesarStock(RF_BukuBesarStock.TipeForm.BlankoStockOpname)
			Case GetReport(reportName.StockMinimum) : Return New RF_BukuBesarStock(RF_BukuBesarStock.TipeForm.StockMinimum)
			Case GetReport(reportName.TransaksiBarang) : Return New RF_BukuBesarStock(RF_BukuBesarStock.TipeForm.TransaksiStock)

				'fusoh
			Case GetReport(reportName.zFusohDempyou) : Return New RF_FusohVoucher(Persistent.SumberDataJenis.OP)
			Case GetReport(reportName.zFusohProcessRequest) : Return New RF_FusohVoucher(Persistent.SumberDataJenis.OP)
			Case GetReport(reportName.zFusohSlipCard) : Return New RF_FusohVoucher(Persistent.SumberDataJenis.OP)
			Case GetReport(reportName.zFusohRekapStockBalance) : Return New RF_FusohStockBalance(reportName.zFusohRekapStockBalance)
			Case GetReport(reportName.zFusohRekapOrderProduksi) : Return New RF_FusohRekap(Persistent.SumberDataJenis.OP)
			Case GetReport(reportName.zFusohRekapProduksi) : Return New RF_FusohRekap(Persistent.SumberDataJenis.AM)
			Case GetReport(reportName.zFusohRekapDetailStokBahanBaku) : Return New RF_FusohDetailStokBahanBaku
			Case GetReport(reportName.zFusohRekapSerial) : Return New RF_FusohRekapSerial
			Case GetReport(reportName.zFusohRekapDailyProcess) : Return New RF_FusohRekapDailyProcess
			Case GetReport(reportName.zFusohMutasiWIP) : Return New RF_FusohRekapTransaksi(reportName.zFusohMutasiWIP)
			Case GetReport(reportName.zFusohMutasiWIPDetail) : Return New RF_FusohRekapTransaksi(reportName.zFusohMutasiWIPDetail)


				'sanyu
			Case GetReport(reportName.zSanyuVoucherRencanaProduksi) : Return New RF_SanyuVoucherRencanaProduksi(Persistent.SumberDataJenis.OP)
			Case GetReport(reportName.zSanyuVoucherProduksi) : Return New RF_SanYuVoucherProduksi(reportName.zSanyuVoucherProduksi)
			Case GetReport(reportName.zSanyuTallyCard) : Return New RF_SanYuVoucherProduksi(reportName.zSanyuTallyCard)
			Case GetReport(reportName.zSanyuRekapProduksi) : Return New RF_SanYuRekapProduksi(reportName.zSanyuRekapProduksi)
			Case GetReport(reportName.zSanyuRekapRandemen) : Return New RF_SanYuRekapProduksi(reportName.zSanyuRekapRandemen)
			Case GetReport(reportName.zSanyuVoucherMutasi) : Return New RF_SanyuVoucher(Persistent.SumberDataJenis.ST)

				'nishi
			Case GetReport(reportName.zNishiVoucherBarangMasukCoil) : Return New RF_NishiVoucher(reportName.zNishiVoucherBarangMasukCoil)
			Case GetReport(reportName.zNishiVoucherBarangMasukSteel) : Return New RF_NishiVoucher(reportName.zNishiVoucherBarangMasukSteel)
			Case GetReport(reportName.zNishiVoucherBarangKeluarCoil) : Return New RF_NishiVoucher(reportName.zNishiVoucherBarangKeluarCoil)
			Case GetReport(reportName.zNishiVoucherBarangKeluarSteel) : Return New RF_NishiVoucher(reportName.zNishiVoucherBarangKeluarSteel)
			Case GetReport(reportName.zNishiKartuStockDetail) : Return New RF_NishiKartuStock(reportName.zNishiKartuStockDetail)
			Case GetReport(reportName.zNishiKartuStockSummary) : Return New RF_NishiKartuStock(reportName.zNishiKartuStockSummary)

			Case Else : Return Nothing
		End Select
	End Function
End Class