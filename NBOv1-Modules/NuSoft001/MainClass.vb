Public Class MainClass
  Shared Function GetSmallImage() As Drawing.Image
    Return My.Resources.account_balances_16
  End Function
  Shared Function GetLargeImage() As Drawing.Image
    Return My.Resources.account_balances_24
  End Function
  Shared Function GetModuleId() As NPO.Modules.ModuleId
    Return NPO.Modules.ModuleId.Fina
  End Function
  Private Enum menuName
    MasterAkun
    MasterKontak
    MasterKategoriKontak
    MasterMatauang
    MasterBank
    MasterProyek
    MasterProyekSub
    MasterAktivaKelompok
    MasterAktiva
    MasterAkunY
    MasterAkunZ
    MasterDivisi

    SettingGL
    SettingCustomreportNeraca
    SettingCustomreportLabarugi
    SettingCustomreportHPP
    SettingCustomreportCashflow


    TransaksiPengajuanDana
    TransaksiPrepayment
    TransaksiPrepaymentAPP
    TransaksiKasMasuk
    TransaksiKasKeluar
    TransaksiBankMasuk
    TransaksiBankKeluar
    TransaksiCashOpname
    TransaksiLoanAdministration
    TransaksiAdministrasiGiro
    TransaksiRekonsiliasiBank

    TransaksiSaldoAwal
    TransaksiJurnalUmum
    TransaksiJurnalAdjusment
    TransaksiRevaluasiValas
    TransaksiAmortisasiPrepaidExpense
    TransaksiAsset

    TransaksiMasterBudget
    TransaksiEksportESPT
    TransaksiUpdateBuktiPotongPPH23
    TransaksiCetakBuktiPotongPPH23

		DataSaldoLR
		DataBukuBesar
    DataBukuBesar2
    DataSaldoAkun
    DataSaldoPiutang
    DataSaldoHutang
    DataStatistik
    DataPrediksiKasBank
    DataRasioKeuangan
    DataPiutangKasbon
    DataPerkembanganKas
    DataPerkembanganBank
    DataPerkembanganPiutang
    DataPerkembanganHutang
    DataPerkembanganPendapatan
    DataPerkembanganHPP
    DataPerkembanganBiaya
    ProsesTutupBuku
    DataTransaksiAktivaTetap

    '===customize
    zBuktiPemasukan
    zBuktiPengeluaran
    zJurnalMemo
    zAppPembayaran
    zDaftarGL
    zVerifikasiJurnal
    zSettingCustomreportCashflow
    zMesitechInvoice
    zMesitechMemoAR
    zMesitechBankAR

    zpjpBuktiKM
    zpjpBuktiKK
    zpjpBuktiJU
    zpjpBuktiJA
    zpjpDaftarGL
    zpjpSaldoHutang
    zpjpSaldoPiutang
    zpjpMasterTipe
    zpjpMasterProses

    zWoojinMemo
    zWoojinBrankas
  End Enum
  Private Shared Function GetMenu(ByVal menuCode As String) As menuName
    Select Case menuCode
      Case "0101.01" : Return menuName.TransaksiPengajuanDana
      Case "0101.02.01" : Return menuName.TransaksiPrepayment
      Case "0101.02.02" : Return menuName.TransaksiKasMasuk 'kas masuk
      Case "0101.02.03" : Return menuName.TransaksiKasKeluar 'kas keluar
      Case "0101.02.04" : Return menuName.TransaksiBankMasuk 'bank masuk
      Case "0101.02.05" : Return menuName.TransaksiBankKeluar 'bank keluar
      Case "0101.02.06" : Return menuName.TransaksiCashOpname
      Case "0101.02.07" : Return menuName.TransaksiLoanAdministration
      Case "0101.02.08" : Return menuName.TransaksiAdministrasiGiro
      Case "0101.02.09" : Return menuName.TransaksiRekonsiliasiBank
      Case "0101.02.99" : Return menuName.TransaksiPrepaymentAPP

      Case "0101.03.01" : Return menuName.TransaksiJurnalUmum
      Case "0101.03.02" : Return menuName.TransaksiJurnalAdjusment
      Case "0101.03.03" : Return menuName.TransaksiRevaluasiValas
      Case "0101.03.04" : Return menuName.TransaksiAmortisasiPrepaidExpense
      Case "0101.03.05" : Return menuName.TransaksiAsset
      Case "0101.03.06" : Return menuName.TransaksiSaldoAwal

      Case "0101.04.01" : Return menuName.TransaksiMasterBudget

      Case "0101.05.01" : Return menuName.TransaksiEksportESPT
      Case "0101.05.02" : Return menuName.TransaksiUpdateBuktiPotongPPH23
      Case "0101.05.03" : Return menuName.TransaksiCetakBuktiPotongPPH23

      Case "0102.01" : Return menuName.DataSaldoAkun
      Case "0102.02" : Return menuName.DataBukuBesar
      Case "0102.03" : Return menuName.DataSaldoPiutang
      Case "0102.04" : Return menuName.DataSaldoHutang
      Case "0102.05" : Return menuName.DataStatistik
      Case "0102.06" : Return menuName.DataPrediksiKasBank
      Case "0102.07" : Return menuName.DataRasioKeuangan
      Case "0102.11" : Return menuName.DataPerkembanganKas
      Case "0102.12" : Return menuName.DataPerkembanganBank
      Case "0102.13" : Return menuName.DataPerkembanganPiutang
      Case "0102.14" : Return menuName.DataPerkembanganHutang
      Case "0102.15" : Return menuName.DataPerkembanganPendapatan
      Case "0102.16" : Return menuName.DataPerkembanganHPP
      Case "0102.17" : Return menuName.DataPerkembanganBiaya
      Case "0102.18" : Return menuName.DataTransaksiAktivaTetap
      Case "0102.19" : Return menuName.DataBukuBesar2
			Case "0102.20" : Return menuName.DataSaldoLR

			Case "0103.01" : Return menuName.MasterAkun
      Case "0103.02" : Return menuName.MasterKontak
      Case "0103.03" : Return menuName.MasterKategoriKontak
      Case "0103.04" : Return menuName.MasterMatauang
      Case "0103.05" : Return menuName.MasterBank
      Case "0103.06" : Return menuName.MasterProyek
      Case "0103.07" : Return menuName.MasterAktivaKelompok
      Case "0103.08" : Return menuName.MasterAktiva
      Case "0103.09" : Return menuName.MasterProyekSub
      Case "0103.10" : Return menuName.MasterAkunZ
      Case "0103.11" : Return menuName.MasterDivisi
      Case "0103.98" : Return menuName.MasterAkunY
      Case "0103.99" : Return menuName.MasterAkunY

      Case "0105.01" : Return menuName.ProsesTutupBuku

      Case "0199.01" : Return menuName.SettingGL
      Case "0199.02.01" : Return menuName.SettingCustomreportNeraca
      Case "0199.02.02" : Return menuName.SettingCustomreportLabarugi
      Case "0199.02.03" : Return menuName.SettingCustomreportHPP
      Case "0199.02.04" : Return menuName.SettingCustomreportCashflow


        'customize mesitech
      Case "0101.93" : Return menuName.zMesitechMemoAR
      Case "0101.94" : Return menuName.zMesitechBankAR
      Case "0101.95" : Return menuName.zMesitechInvoice
      Case "0101.96" : Return menuName.zBuktiPemasukan
      Case "0101.97" : Return menuName.zBuktiPengeluaran
      Case "0101.98" : Return menuName.zJurnalMemo
      Case "0101.99" : Return menuName.zAppPembayaran

      Case "0199.02.99" : Return menuName.zSettingCustomreportCashflow

        'custom pjp
      Case "0101.86" : Return menuName.zpjpBuktiJA
      Case "0101.87" : Return menuName.zpjpBuktiJU
      Case "0101.88" : Return menuName.zpjpBuktiKK
      Case "0101.89" : Return menuName.zpjpBuktiKM
        'custom woojin
      Case "0101.79" : Return menuName.zWoojinMemo
      Case "0101.78" : Return menuName.zWoojinBrankas

      Case "0103.89" : Return menuName.zpjpMasterProses

        'customize mesitech
      Case "0102.98" : Return menuName.zVerifikasiJurnal
      Case "0102.99" : Return menuName.zDaftarGL

        'custom pjp
      Case "0102.89" : Return menuName.zpjpDaftarGL
      Case "0102.88" : Return menuName.zpjpSaldoPiutang
      Case "0102.87" : Return menuName.zpjpSaldoHutang

      Case Else : Return Nothing
    End Select
  End Function
  Shared Function GetForm(ByVal menuCode As String) As Core.Win.Forms.NuSoftForm
    Select Case GetMenu(menuCode)
      Case menuName.MasterAkun : Return New UI_Akun
      Case menuName.MasterKategoriKontak : Return New UI_KategoriKontak
      Case menuName.MasterKontak : Return New UI_Kontak
      Case menuName.MasterMatauang : Return New UI_MataUang
      Case menuName.MasterBank : Return New UI_Bank
      Case menuName.MasterProyek : Return New UI_Proyek
      Case menuName.MasterProyekSub : Return New UI_ProyekSub
      Case menuName.MasterAktivaKelompok : Return New UI_AktivaKelompok
      Case menuName.MasterAktiva : Return New UI_Aktiva
      Case menuName.MasterAkunZ : Return New UI_AkunZ
      Case menuName.MasterAkunY : Return New UI_AkunY
      Case menuName.MasterDivisi : Return New UI_Divisi

      Case menuName.SettingGL : Return New UI_SettingGL
      Case menuName.SettingCustomreportNeraca : Return New UI_SettingCRNeraca
      Case menuName.SettingCustomreportLabarugi : Return New UI_SettingCROthers(Persistent.CustomReportTipe.LabaRugi)
      Case menuName.SettingCustomreportHPP : Return New UI_SettingCROthers(Persistent.CustomReportTipe.HPP)
      Case menuName.SettingCustomreportCashflow : Return New UI_SettingCROthers(Persistent.CustomReportTipe.CashFlow)

      Case menuName.TransaksiSaldoAwal : Return New UI_SaldoAwal
      Case menuName.TransaksiPengajuanDana : Return New UI_PengajuanDana
      Case menuName.TransaksiKasMasuk : Return New UI_TransaksiGL(JenisTransaksiGL.KasMasuk)
      Case menuName.TransaksiKasKeluar : Return New UI_TransaksiGL(JenisTransaksiGL.KasKeluar)
      Case menuName.TransaksiBankMasuk : Return New UI_TransaksiGL(JenisTransaksiGL.BankMasuk)
      Case menuName.TransaksiBankKeluar : Return New UI_TransaksiGL(JenisTransaksiGL.BankKeluar)
      Case menuName.TransaksiCashOpname : Return New UI_CashOpname
      Case menuName.TransaksiLoanAdministration : Return New UI_Pinjaman
      Case menuName.TransaksiAdministrasiGiro : Return New UI_CekGiro
      Case menuName.TransaksiPrepayment : Return New UI_Prepayment
      Case menuName.TransaksiPrepaymentAPP : Return New UI_PrepaymentzApprove

      Case menuName.TransaksiJurnalUmum : Return New UI_TransaksiGL(JenisTransaksiGL.JurnalUmum)
      Case menuName.TransaksiJurnalAdjusment : Return New UI_TransaksiGL(JenisTransaksiGL.JurnalAdjusment)
      Case menuName.TransaksiAmortisasiPrepaidExpense : Return New UI_PrepaidExpense
      Case menuName.TransaksiRevaluasiValas : Return New UI_RevaluasiValas
      Case menuName.TransaksiAsset : Return New UI_AktivaTetap

      Case menuName.TransaksiMasterBudget : Return New UI_Anggaran
      Case menuName.TransaksiEksportESPT : Return New UI_EksportESPT
      Case menuName.TransaksiUpdateBuktiPotongPPH23 : Return New UI_EksportESPT
      Case menuName.TransaksiCetakBuktiPotongPPH23 : Return New UI_EksportESPT
      Case menuName.TransaksiRekonsiliasiBank : Return New UI_RekonsiliasiBank

			Case menuName.DataSaldoLR : Return New UI_SaldoLR
			Case menuName.DataSaldoAkun : Return New UI_DaftarGL
      Case menuName.DataBukuBesar2 : Return New UI_DaftarGL2
      Case menuName.DataBukuBesar : Return New UI_BukuBesar
      Case menuName.DataSaldoPiutang : Return New UI_SaldoARAPNew(Persistent.eTipeARAP.Piutang)
      Case menuName.DataSaldoHutang : Return New UI_SaldoARAPNew(Persistent.eTipeARAP.Hutang)
      Case menuName.DataStatistik : Return New UI_Statistik
      Case menuName.DataRasioKeuangan : Return New UI_RasioKeuangan
      Case menuName.ProsesTutupBuku : Return New UI_TutupBuku
      Case menuName.DataTransaksiAktivaTetap : Return New UI_AktivaTetapTransaksi

        '===customize
      Case menuName.zDaftarGL : Return New xMesitechDaftarGL
      Case menuName.zVerifikasiJurnal : Return New xMesitechVerifikasiJurnal2

      Case menuName.zBuktiPemasukan : Return New xMesitechGL(xJenisMesitechGL.BuktiKas)
      Case menuName.zBuktiPengeluaran : Return New xMesitechGL(xJenisMesitechGL.BuktiBank)
      Case menuName.zJurnalMemo : Return New xMesitechGL(xJenisMesitechGL.JurnalMemo)
      Case menuName.zAppPembayaran : Return New xMesitechGL(xJenisMesitechGL.AppPembayaran)
      Case menuName.zSettingCustomreportCashflow : Return New UI_MesitechSettingCashFlow(Persistent.CustomReportTipe.CashFlow)
      Case menuName.zMesitechInvoice : Return New UI_Invoice
      Case menuName.zMesitechMemoAR : Return New xMesitechGL(xJenisMesitechGL.JurnalMemoAR)
      Case menuName.zMesitechBankAR : Return New xMesitechGL(xJenisMesitechGL.BuktiBankAR)


      Case menuName.zpjpBuktiKM : Return New pjp_TransaksiGL(JenisTransaksiGL.KasMasuk)
      Case menuName.zpjpBuktiKK : Return New pjp_TransaksiGL(JenisTransaksiGL.KasKeluar)
      Case menuName.zpjpBuktiJU : Return New pjp_TransaksiGL(JenisTransaksiGL.JurnalUmum)
      Case menuName.zpjpBuktiJA : Return New pjp_TransaksiGL(JenisTransaksiGL.JurnalAdjusment)
      Case menuName.zpjpDaftarGL : Return New pjp_DaftarGL
      Case menuName.zpjpSaldoPiutang : Return New pjp_SaldoARAP(Persistent.eTipeARAP.Piutang)
      Case menuName.zpjpSaldoHutang : Return New pjp_SaldoARAP(Persistent.eTipeARAP.Hutang)

      Case menuName.zpjpMasterProses : Return New pjp_MasterProses

      Case menuName.zWoojinMemo : Return New zWoojin_Memo
      Case menuName.zWoojinBrankas : Return New zWoojin_Brankas


      Case Else : Return Nothing
    End Select
  End Function

  Friend Enum reportName
    BuktiKasMasuk
    BuktiKasKeluar
    BuktiBankMasuk
    BuktiBankKeluar
    BuktiJurnalUmum
    BuktiJurnalAdjustment
    BuktiPengajuanDana
    BuktiPencairanGiro
    BuktiJurnalVoucher
    BudgetRealisasi
    BuktiPrepayment
    RekapPrepayment
    VoucherApprovePrepayment

    GLBukuBesar
    GLBukuBesarValas
    GLBukuBesarBebas
    GLBukuBesarBank
    GLBukuBesarRingkas
    GLTransaksiHarian
    GLCGDaftar
    GLCGUmur
    GLHPDaftarHutang
    GLHPDaftarPiutang
    GLHPDaftarHutangPerCOA
    GLHPDaftarPiutangPerCOA
    GLTransaksiHarianProyek
    GLTransaksiHarianDivisi
    GLDaftarTransaksiKasBank

    FNNeracaSaldo
    FNNeracaLajur
    FNNeraca
    FNNeracaLampiran
    FNNeracaPerbandingan
    FNLabaRugi
    FNLabaRugiLampiran
    FNLabaRugiSummary
    FNLabaRugiTahunan
    FNPerubahanModal
    FNHPP
    FNHPPLampiran
    FNCashFlowBulanan
    FNCashFlowBulananLampiran
    FNCashFlowTriwulan
    FNCashFlowTriwulanLampiran
    FNCashFlowRincian
    FNNeracaPerLevel
    FNNeracaGlobal
    FNLabaRugiGlobal
    FNCashFlowGlobal
    FNCashFlowGlobalDetail
    FNLabaRugiTahunanx
    FNNeracaTahunan
    FNLabaRugiTahunanStandar
    FNNeracaTahunanStandar


    ProyekBukuBesar
    ProyekLabaRugiCOA
    ProyekLabaRugiCustom
    ProyekSaldo
    ProyekLabaRugiCOALevel
    ProyekLabaRugiTahunan
		ProyekLabaRugiSanding
		ProyekDaftar

		DivisiBukuBesar
    DivisiSaldo
    DivisiLabaRugiCOA
    DivisiLabaRugiCustom
    DivisiLabaRugiCOALevel
    DivisiLabaRugiTahunan

    NeracaCOA
    LabaRugiCOA
    NeracaSaldoCOA

    'AktivaTetap
    AktivaTetapBukuBesar

    'customize
    APPRekap
    APPRekapTerbit
    APPRekapBayar
    zBuktiJurnalAPP
    zBuktiJUrnalAPPDropship
    zBuktiKasMasuk
    zBuktiKasKeluar
    zBuktiBankMasuk
    zBuktiBankKeluar
    zCashFlowDetail
    zCashFlowSummary
    zCashFlowTahunan
    zCashFlowData
    zCashFlowPertanggunJawaban
    zPJPDaftarPerProses

    zMesitechPiutangUsaha


    zWoojinDailyReport
  End Enum
  Friend Shared Function GetReport(ByVal reportCode As reportName) As String
    Select Case reportCode
      Case reportName.BuktiKasMasuk : Return "10101"
      Case reportName.BuktiKasKeluar : Return "10102"
      Case reportName.BuktiBankMasuk : Return "10103"
      Case reportName.BuktiBankKeluar : Return "10104"
      Case reportName.BuktiJurnalUmum : Return "10105"
      Case reportName.BuktiJurnalAdjustment : Return "10106"
      Case reportName.BuktiPengajuanDana : Return "10107"
      Case reportName.BuktiPencairanGiro : Return "10108"
      Case reportName.BuktiJurnalVoucher : Return "10109"
      Case reportName.BuktiPrepayment : Return "10110"
      Case reportName.RekapPrepayment : Return "10111"
      Case reportName.VoucherApprovePrepayment : Return "10112"

      Case reportName.BudgetRealisasi : Return "10201"

      Case reportName.GLBukuBesar : Return "10301"
      Case reportName.GLBukuBesarValas : Return "10302"
      Case reportName.GLBukuBesarBebas : Return "10303"
      Case reportName.GLBukuBesarBank : Return "10304"
      Case reportName.GLTransaksiHarian : Return "10305"
      Case reportName.GLBukuBesarRingkas : Return "10306"
      Case reportName.GLDaftarTransaksiKasBank : Return "10308"
      Case reportName.GLCGDaftar : Return "1030601"
      Case reportName.GLCGUmur : Return "1030602"
      Case reportName.GLHPDaftarHutang : Return "1030701"
      Case reportName.GLHPDaftarPiutang : Return "1030702"
      Case reportName.GLHPDaftarHutangPerCOA : Return "1030703"
      Case reportName.GLHPDaftarPiutangPerCOA : Return "1030704"
      Case reportName.zMesitechPiutangUsaha : Return "10398"
      Case reportName.GLTransaksiHarianProyek : Return "10399"

      Case reportName.FNNeracaSaldo : Return "10401"
      Case reportName.FNNeracaLajur : Return "10402"
      Case reportName.FNNeraca : Return "10403"
      Case reportName.FNNeracaLampiran : Return "10404"
      Case reportName.FNNeracaPerbandingan : Return "10405"
      Case reportName.FNLabaRugi : Return "10406"
      Case reportName.FNLabaRugiLampiran : Return "10407"
      Case reportName.FNLabaRugiSummary : Return "10408" '==
      Case reportName.FNLabaRugiTahunan : Return "10409"
      Case reportName.FNPerubahanModal : Return "10410"
      Case reportName.FNHPP : Return "10411"
      Case reportName.FNHPPLampiran : Return "10412"
      Case reportName.FNCashFlowBulanan : Return "10413"
      Case reportName.FNCashFlowBulananLampiran : Return "10414"
      Case reportName.FNCashFlowTriwulan : Return "10415"
      Case reportName.FNCashFlowTriwulanLampiran : Return "10416"
      Case reportName.FNCashFlowRincian : Return "10417"
      Case reportName.NeracaCOA : Return "10418"
      Case reportName.LabaRugiCOA : Return "10419"
      Case reportName.NeracaSaldoCOA : Return "10420"
      Case reportName.FNNeracaPerLevel : Return "10421"
      Case reportName.FNNeracaGlobal : Return "10422"
      Case reportName.FNLabaRugiGlobal : Return "10423"
      Case reportName.FNCashFlowGlobal : Return "10424"
      Case reportName.FNCashFlowGlobalDetail : Return "10425"
      Case reportName.FNNeracaTahunan : Return "10426"
      Case reportName.FNLabaRugiTahunanx : Return "10427"
      Case reportName.FNNeracaTahunanStandar : Return "10428"
      Case reportName.FNLabaRugiTahunanStandar : Return "10429" '===


      Case reportName.zPJPDaftarPerProses : Return "10479"

      Case reportName.ProyekBukuBesar : Return "10501"
      Case reportName.ProyekLabaRugiCOA : Return "10502"
      Case reportName.ProyekLabaRugiCustom : Return "10503"
      Case reportName.ProyekSaldo : Return "10504"
      Case reportName.ProyekLabaRugiCOALevel : Return "10505"
      Case reportName.ProyekLabaRugiTahunan : Return "10506"
      Case reportName.ProyekLabaRugiSanding : Return "10507"
			Case reportName.ProyekDaftar : Return "10508"

			Case reportName.DivisiBukuBesar : Return "10601"
      Case reportName.DivisiLabaRugiCOA : Return "10602"


      Case reportName.AktivaTetapBukuBesar : Return "10701"


      Case reportName.APPRekap : Return "10901"
      Case reportName.APPRekapTerbit : Return "10902"
      Case reportName.APPRekapBayar : Return "10903"
      Case reportName.zBuktiKasMasuk : Return "10199"
      Case reportName.zBuktiKasKeluar : Return "10198"
      Case reportName.zBuktiBankMasuk : Return "10197"
      Case reportName.zBuktiBankKeluar : Return "10196"
      Case reportName.zBuktiJurnalAPP : Return "10195"
      Case reportName.zBuktiJUrnalAPPDropship : Return "10194"

      Case reportName.zCashFlowDetail : Return "10499"
      Case reportName.zCashFlowSummary : Return "10498"
      Case reportName.zCashFlowTahunan : Return "10497"
      Case reportName.zCashFlowData : Return "10496"
      Case reportName.zCashFlowPertanggunJawaban : Return "10495"

      Case reportName.zWoojinDailyReport : Return "10595"

      Case Else : Return Nothing
    End Select
  End Function
  Shared Function GetReportFilter(ByVal reportCode As String) As Core.Win.Forms.ReportFilter
    Select Case reportCode
      Case GetReport(reportName.BuktiBankKeluar) : Return New RF_BuktiHarian(Persistent.SumberDataJenis.BK, reportName.BuktiBankKeluar)
      Case GetReport(reportName.BuktiBankMasuk) : Return New RF_BuktiHarian(Persistent.SumberDataJenis.BM, reportName.BuktiBankMasuk)
      Case GetReport(reportName.BuktiKasKeluar) : Return New RF_BuktiHarian(Persistent.SumberDataJenis.KK, reportName.BuktiKasKeluar)
      Case GetReport(reportName.BuktiKasMasuk) : Return New RF_BuktiHarian(Persistent.SumberDataJenis.KM, reportName.BuktiKasMasuk)
      Case GetReport(reportName.BuktiJurnalUmum) : Return New RF_BuktiHarian(Persistent.SumberDataJenis.JU, reportName.BuktiJurnalUmum)
      Case GetReport(reportName.BuktiJurnalAdjustment) : Return New RF_BuktiHarian(Persistent.SumberDataJenis.JA, reportName.BuktiJurnalAdjustment)
      Case GetReport(reportName.BuktiJurnalVoucher) : Return New RF_BuktiHarian(Persistent.SumberDataJenis.JU, reportName.BuktiJurnalVoucher, True)
      Case GetReport(reportName.BuktiPengajuanDana) : Return New RF_BuktiHarian(Persistent.SumberDataJenis.PD, reportName.BuktiPengajuanDana)
      Case GetReport(reportName.BuktiPrepayment) : Return New RF_BuktiHarian(Persistent.SumberDataJenis.PP, reportName.BuktiPrepayment)
      Case GetReport(reportName.RekapPrepayment) : Return New RF_BuktiHarian(Persistent.SumberDataJenis.PP, reportName.BuktiPrepayment)
      Case GetReport(reportName.VoucherApprovePrepayment) : Return New RF_BuktiHarian(Persistent.SumberDataJenis.PP, reportName.BuktiPrepayment)

      Case GetReport(reportName.GLBukuBesar) : Return New RF_MesitechBukuBesar
      Case GetReport(reportName.GLBukuBesarValas) : Return New RF_BukuBesar2(RF_BukuBesar2.TipeReportBukuBesar.BukuBesarValas)
      Case GetReport(reportName.GLTransaksiHarian) : Return New RF_TransaksiJurnal
      Case GetReport(reportName.GLBukuBesarBebas) : Return New RF_BukuBesar2(RF_BukuBesar2.TipeReportBukuBesar.BukuBesar)
      Case GetReport(reportName.GLBukuBesarBank) : Return New RF_BukuBesar2(RF_BukuBesar2.TipeReportBukuBesar.BukuBesarBank)
      Case GetReport(reportName.GLHPDaftarHutang) : Return New RF_SaldoARAP(Persistent.eTipeARAP.Hutang)
      Case GetReport(reportName.GLHPDaftarPiutang) : Return New RF_SaldoARAP(Persistent.eTipeARAP.Piutang)
      Case GetReport(reportName.GLHPDaftarHutangPerCOA) : Return New RF_SaldoARAP(Persistent.eTipeARAP.HutangCOA)
      Case GetReport(reportName.GLHPDaftarPiutangPerCOA) : Return New RF_SaldoARAP(Persistent.eTipeARAP.PiutangCOA)
      Case GetReport(reportName.GLCGDaftar) : Return New RF_Giro
      Case GetReport(reportName.GLCGUmur) : Return New RF_Giro
      Case GetReport(reportName.GLTransaksiHarianProyek) : Return New RF_SaldoProyek2(reportName.GLTransaksiHarianProyek)
      Case GetReport(reportName.GLDaftarTransaksiKasBank) : Return New RF_BukuBesar2(RF_BukuBesar2.TipeReportBukuBesar.DaftarKasBank)
      Case GetReport(reportName.zPJPDaftarPerProses) : Return New pjp_FilterPerProses()

      Case GetReport(reportName.FNNeracaSaldo) : Return New RF_NeracaSaldo
      Case GetReport(reportName.FNNeraca) : Return New RF_LK(Persistent.CustomReportTipe.NeracaAktiva, False)
      Case GetReport(reportName.FNNeracaLampiran) : Return New RF_LK(Persistent.CustomReportTipe.NeracaAktiva, True)
      Case GetReport(reportName.FNLabaRugi) : Return New RF_LK(Persistent.CustomReportTipe.LabaRugi, False)
      Case GetReport(reportName.FNLabaRugiLampiran) : Return New RF_LK(Persistent.CustomReportTipe.LabaRugi, True)
      Case GetReport(reportName.FNHPP) : Return New RF_LK(Persistent.CustomReportTipe.HPP, False)
      Case GetReport(reportName.FNHPPLampiran) : Return New RF_LK(Persistent.CustomReportTipe.HPP, True)
      Case GetReport(reportName.FNCashFlowTriwulan) : Return New RF_LK(Persistent.CustomReportTipe.CashFlow, False, True)
      Case GetReport(reportName.FNCashFlowBulanan) : Return New RF_LK(Persistent.CustomReportTipe.CashFlow, False)
      Case GetReport(reportName.FNCashFlowTriwulanLampiran) : Return New RF_LK(Persistent.CustomReportTipe.CashFlow, True, True)
      Case GetReport(reportName.FNCashFlowBulananLampiran) : Return New RF_LK(Persistent.CustomReportTipe.CashFlow, True)
      Case GetReport(reportName.FNCashFlowRincian) : Return New RF_LK(Persistent.CustomReportTipe.CashFlow, True, False, True)
      Case GetReport(reportName.NeracaCOA) : Return New RF_SaldoCOA(Persistent.CustomReportTipe.NeracaCOA)
      Case GetReport(reportName.LabaRugiCOA) : Return New RF_SaldoCOA(Persistent.CustomReportTipe.LabaRugiCOA)
      Case GetReport(reportName.NeracaSaldoCOA) : Return New RF_SaldoCOA(Persistent.CustomReportTipe.NeracaSaldoCOA)
      Case GetReport(reportName.FNLabaRugiSummary) : Return New RF_SaldoCOA(Persistent.CustomReportTipe.LabaRugiCOASummary)
      Case GetReport(reportName.FNNeracaPerLevel) : Return New RF_NeracaLevel(Persistent.CustomReportTipe.NeracaCOA)
      Case GetReport(reportName.FNNeracaGlobal) : Return New RF_SaldoCOAGlobal(reportName.FNNeracaGlobal)
      Case GetReport(reportName.FNLabaRugiGlobal) : Return New RF_SaldoCOAGlobal(reportName.FNLabaRugiGlobal)
      Case GetReport(reportName.FNCashFlowGlobal) : Return New RF_CashFlowGlobal(reportName.FNCashFlowGlobal)
      Case GetReport(reportName.FNCashFlowGlobalDetail) : Return New RF_CashFlowGlobal(reportName.FNCashFlowGlobalDetail)
      Case GetReport(reportName.FNNeracaTahunan) : Return New RF_SaldoCOAGlobal(reportName.FNNeracaTahunan)
      Case GetReport(reportName.FNLabaRugiTahunanx) : Return New RF_SaldoCOAGlobal(reportName.FNLabaRugiTahunanx)
      Case GetReport(reportName.FNNeracaTahunanStandar) : Return New RF_SaldoCOAGlobal(reportName.FNNeracaTahunanStandar)
      Case GetReport(reportName.FNLabaRugiTahunanStandar) : Return New RF_SaldoCOAGlobal(reportName.FNLabaRugiTahunanStandar)


			Case GetReport(reportName.ProyekDaftar) : Return New RF_SaldoProyek2(reportName.ProyekDaftar)
			Case GetReport(reportName.ProyekBukuBesar) : Return New RF_SaldoProyek2(reportName.ProyekBukuBesar)
      Case GetReport(reportName.ProyekLabaRugiCOA) : Return New RF_SaldoProyek2(reportName.ProyekLabaRugiCOA)
      Case GetReport(reportName.ProyekLabaRugiCustom) : Return New RF_SaldoProyek2(reportName.ProyekLabaRugiCustom)
      Case GetReport(reportName.ProyekSaldo) : Return New RF_SaldoProyek2(reportName.ProyekSaldo)
      Case GetReport(reportName.ProyekLabaRugiCOALevel) : Return New RF_SaldoProyek2(reportName.ProyekLabaRugiCOALevel)
      Case GetReport(reportName.ProyekLabaRugiTahunan) : Return New RF_SaldoProyek2(reportName.ProyekLabaRugiTahunan)
			Case GetReport(reportName.ProyekLabaRugiSanding) : Return New RF_SaldoProyekSanding(reportName.ProyekLabaRugiSanding)
			Case GetReport(reportName.GLBukuBesarRingkas) : Return New RF_SaldoProyek2(reportName.ProyekBukuBesar)

      Case GetReport(reportName.zMesitechPiutangUsaha) : Return New RF_Invoice(reportName.zMesitechPiutangUsaha)


      Case GetReport(reportName.DivisiBukuBesar) : Return New RF_Divisi(reportName.DivisiBukuBesar)
      Case GetReport(reportName.DivisiLabaRugiCOA) : Return New RF_Divisi(reportName.DivisiLabaRugiCOA)

      Case GetReport(reportName.AktivaTetapBukuBesar) : Return New RF_Asset()

      Case GetReport(reportName.APPRekap) : Return New RF_MesitechTransaksi(Persistent.SumberDataJenis.PA, reportName.APPRekap)
      Case GetReport(reportName.APPRekapTerbit) : Return New RF_MesitechTransaksi(Persistent.SumberDataJenis.PA, reportName.APPRekapTerbit)
      Case GetReport(reportName.APPRekapBayar) : Return New RF_MesitechTransaksi(Persistent.SumberDataJenis.PA, reportName.APPRekapBayar)
      Case GetReport(reportName.zBuktiKasMasuk) : Return New RF_MesitechTransaksi(Persistent.SumberDataJenis.KM, reportName.zBuktiKasMasuk)
      Case GetReport(reportName.zBuktiKasKeluar) : Return New RF_MesitechTransaksi(Persistent.SumberDataJenis.KM, reportName.zBuktiKasKeluar)
      Case GetReport(reportName.zBuktiBankMasuk) : Return New RF_MesitechTransaksi(Persistent.SumberDataJenis.BM, reportName.zBuktiBankMasuk)
      Case GetReport(reportName.zBuktiBankKeluar) : Return New RF_MesitechTransaksi(Persistent.SumberDataJenis.BM, reportName.zBuktiBankKeluar)
      Case GetReport(reportName.zBuktiJurnalAPP) : Return New RF_MesitechTransaksi(Persistent.SumberDataJenis.PA, reportName.zBuktiJurnalAPP)
      Case GetReport(reportName.zBuktiJUrnalAPPDropship) : Return New RF_MesitechTransaksi(Persistent.SumberDataJenis.PA, reportName.zBuktiJurnalAPP)

      Case GetReport(reportName.zCashFlowDetail) : Return New RF_CashFlowMesitech(reportName.zCashFlowDetail)
      Case GetReport(reportName.zCashFlowSummary) : Return New RF_CashFlowMesitech(reportName.zCashFlowSummary)
      Case GetReport(reportName.zCashFlowTahunan) : Return New RF_CashFlowMesitech(reportName.zCashFlowTahunan)
      Case GetReport(reportName.zCashFlowData) : Return New RF_CashFlowMesitech(reportName.zCashFlowDetail)
      Case GetReport(reportName.zCashFlowPertanggunJawaban) : Return New RF_MesitechPertanggungJawaban()
      Case GetReport(reportName.zWoojinDailyReport) : Return New zWoojin_RFBukuBesar()
      Case Else : Return Nothing
    End Select
  End Function
End Class