Public Class RecordTotalTrans
    Dim _jumlah As Double
    Dim _keterangan As String
    Public Sub New(ByVal keterangan As String, ByVal Jumlah As Double)
        Me._keterangan = keterangan
        Me._jumlah = Jumlah
    End Sub
    Public Property keterangan() As String
        Get
            Return _keterangan
        End Get
        Set(ByVal Value As String)
            _keterangan = Value
        End Set
    End Property
    Public Property Jumlah() As Double
        Get
            Return _jumlah
        End Get
        Set(ByVal Value As Double)
            _jumlah = Value
        End Set
    End Property
End Class