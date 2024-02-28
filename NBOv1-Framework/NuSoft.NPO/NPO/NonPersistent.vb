Namespace NuSoft.NPO.NonPersistent
  Public Class MenuPrivileges
    Property Buka As Boolean
    Property Tambah As Boolean
    Property Edit As Boolean
    Property Hapus As Boolean
    Property Eksport As Boolean
    Property Cetak As Boolean
  End Class
  Public Class ReportPrivileges
    Property Buka As Boolean
    Property Eksport As Boolean
    Property Cetak As Boolean
  End Class
  Public Class MenuInUser
    Property Menu As SSystem.Menu
    Property MenuId As Int16
    Property MenuNama As String
    Property MenuParent As SSystem.Menu
    Property Buka As Boolean
    Property Tambah As Boolean
    Property Edit As Boolean
    Property Hapus As Boolean
    Property Eksport As Boolean
    Property Cetak As Boolean
  End Class
  Public Class ReportInUser
    Property Report As SSystem.Laporan
    Property ReportId As Int16
    Property ReportNama As String
    Property ReportParent As SSystem.Laporan
    Property Buka As Boolean
    Property Eksport As Boolean
    Property Cetak As Boolean
  End Class
  Public Class RegionalInUser
    Property RegionalId As UInt16
    Property RegionalNama As String
    Property Buka As Boolean
    Property IsDefault As Boolean
  End Class
  Public Class DivisiInUser
    Property DivisiId As UInt16
    Property DivisiNama As String
    Property Buka As Boolean
  End Class
End Namespace