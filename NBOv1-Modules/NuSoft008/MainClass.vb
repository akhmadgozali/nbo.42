Public Class MainClass
  Shared Function GetSmallImage() As Drawing.Image
    Return My.Resources.account_balances_16
  End Function
  Shared Function GetLargeImage() As Drawing.Image
    Return My.Resources.account_balances_24
  End Function
  Shared Function GetModuleId() As NPO.Modules.ModuleId
    Return NPO.Modules.ModuleId.MasterData
  End Function
  Private Enum menuName
    MasterAkun
    MasterKontak
    MasterKategoriKontak
    MasterMatauang
    MasterBank
    MasterProyek
    MasterProyekSub
    MasterDivisi
    MasterAktivaKelompok
    MasterAktiva
    MasterAkunZ
    MasterPajak
    MasterSatuan
    MasterTipeTransaksi
    MasterGudang
    MasterItem
    MasterBiayaLain
    MasterKategori
    MasterSubKategori
    MasterMerk
    MasterVia
    MasterTermin
  End Enum
  Private Shared Function GetMenu(ByVal menuCode As String) As menuName
    Select Case menuCode
      Case "0108.01" : Return menuName.MasterMatauang
      Case "0108.02" : Return menuName.MasterBank
      Case "0108.03" : Return menuName.MasterAkun
      Case "0108.04" : Return menuName.MasterKategoriKontak
      Case "0108.05" : Return menuName.MasterKontak
      Case "0108.06" : Return menuName.MasterAktivaKelompok
      Case "0108.07" : Return menuName.MasterAktiva
      Case "0108.08" : Return menuName.MasterDivisi
      Case "0108.09" : Return menuName.MasterProyek
      Case "0108.10" : Return menuName.MasterTipeTransaksi
      Case "0108.11" : Return menuName.MasterSatuan
      Case "0108.12" : Return menuName.MasterGudang
      Case "0108.13" : Return menuName.MasterPajak
      Case "0108.14" : Return menuName.MasterItem
      Case "0108.15" : Return menuName.MasterBiayaLain
      Case "0108.16" : Return menuName.MasterKategori
      Case "0108.17" : Return menuName.MasterSubKategori
      Case "0108.18" : Return menuName.MasterMerk
      Case "0108.19" : Return menuName.MasterTermin
      Case "0108.20" : Return menuName.MasterVia
      Case "0108.21" : Return menuName.MasterProyekSub
      Case "0108.22" : Return menuName.MasterAkunZ
      Case Else : Return Nothing
    End Select
  End Function
  Shared Function GetForm(ByVal menuCode As String) As Core.Win.Forms.NuSoftForm
    Select Case GetMenu(menuCode)
      Case menuName.MasterMatauang : Return New UI_MataUang
      Case menuName.MasterBank : Return New UI_Bank
      Case menuName.MasterAkun : Return New UI_Akun
      Case menuName.MasterKategoriKontak : Return New UI_KategoriKontak
      Case menuName.MasterKontak : Return New UI_Kontak
      Case menuName.MasterAktivaKelompok : Return New UI_AktivaKelompok
      Case menuName.MasterAktiva : Return New UI_Aktiva
      Case menuName.MasterDivisi : Return Nothing
      Case menuName.MasterProyek : Return New UI_Proyek
      Case menuName.MasterTipeTransaksi : Return New UI_TipeTransaksi
      Case menuName.MasterSatuan : Return New UI_Proyek
      Case menuName.MasterGudang : Return New UI_Gudang
      Case menuName.MasterPajak : Return New UI_Pajak
      Case menuName.MasterItem : Return New UI_Barang
      Case menuName.MasterBiayaLain : Return Nothing
      Case menuName.MasterKategori : Return New UI_Kategori
      Case menuName.MasterSubKategori : Return New UI_SubKategori
      Case menuName.MasterMerk : Return New UI_Merk
      Case menuName.MasterTermin : Return New UI_Termin
      Case menuName.MasterVia : Return New UI_Via
      Case menuName.MasterProyekSub : Return New UI_ProyekSub
      Case menuName.MasterAkunZ : Return New UI_AkunZ
      Case Else : Return Nothing
    End Select
  End Function

  Friend Enum reportName
    zReport1
  End Enum
  Friend Shared Function GetReport(ByVal reportCode As reportName) As String
    Select Case reportCode


      Case Else : Return Nothing
    End Select
  End Function
  Shared Function GetReportFilter(ByVal reportCode As String) As Core.Win.Forms.ReportFilter
    Select Case reportCode
      Case Else : Return Nothing
    End Select
  End Function

End Class