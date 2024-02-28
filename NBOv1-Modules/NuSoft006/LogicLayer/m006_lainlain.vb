Imports DevExpress.Xpo
Imports DevExpress.Data.Filtering
Imports NuSoft.NPO
Imports NuSoft.Utils.CustomAttribute
Namespace Persistent
  Public Enum TipeHPP
    <EnumDescription("Per Barang")> PB = 0
    <EnumDescription("Tipe Transaksi")> TT = 1
  End Enum
  Public Enum AutoSearchKontak
    <EnumDescription("Kode Kontak")> KK = 0
    <EnumDescription("Nama Kontak")> NK = 1
  End Enum
  Public Enum eLembarFP
    <EnumDescription("Lembar 1")> Lembar1
    <EnumDescription("Lembar 2")> Lembar2
    <EnumDescription("Lembar 3")> Lembar3
  End Enum
End Namespace