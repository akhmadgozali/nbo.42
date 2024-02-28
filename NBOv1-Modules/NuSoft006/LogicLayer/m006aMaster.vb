Imports DevExpress.Xpo
Imports DevExpress.Data.Filtering
Imports NuSoft.NPO
Imports NuSoft.Utils.CustomAttribute
Namespace Persistent
  '======= ENUM
  'Public Enum eTipeFOB
  '  <EnumDescription("Origin")> Origin
  '  <EnumDescription("Destination")> Destination
  'End Enum
  'Public Enum eTipePajak
  '  <EnumDescription("Tanpa Pajak")> TanpaPajak
  '  <EnumDescription("Harga Belum Termasuk Pajak")> HargaBelumTermasuk
  '  <EnumDescription("Harga Sudah Termasuk Pajak")> HargaSudahTermasuk
  'End Enum
  'Public Enum eJenisPajak
  '  <EnumDescription("Harga Jual")> HargaJual
  '  <EnumDescription("Penggantian")> Penggantian
  '  <EnumDescription("Harga Jual Dan Penggantian")> HargaJualPenggantian
  '  <EnumDescription("Uang Muka")> UangMuka
  '  <EnumDescription("Termin")> Termin
  'End Enum
  Public Enum eTipeInvoicePenjualan
    <EnumDescription("Pakai SO")> PakaiSO
    <EnumDescription("Tanpa SO")> TanpaSO
  End Enum
End Namespace