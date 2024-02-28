Imports DevExpress.Xpo
Imports NuSoft.NPO

Namespace Persistent
	<Persistent("m05resetkurs")> Friend Class Fusoh_ResetKurs
		Inherits NPOBase

		Public Sub New(session As UnitOfWork)
			MyBase.New(session)
		End Sub
		Public Sub New(session As UnitOfWork, classInfo As Metadata.XPClassInfo)
			MyBase.New(session, classInfo)
		End Sub

		Private _id As Integer
		Private _tahun As Integer
		Private _bulan As Integer
		Private _mataUang As NuSoft001.Persistent.MataUang
		Private _kurs As Double
		Private _keterangan As String

		<Key> Property Id As Integer
			Get
				Return _id
			End Get
			Set(value As Integer)
				SetPropertyValue(Of Integer)(NameOf(Id), _id, value)
			End Set
		End Property
		Property Tahun As Integer
			Get
				Return _tahun
			End Get
			Set(value As Integer)
				SetPropertyValue(Of Integer)(NameOf(Tahun), _tahun, value)
			End Set
		End Property
		Property Bulan As Integer
			Get
				Return _bulan
			End Get
			Set(value As Integer)
				SetPropertyValue(Of Integer)(NameOf(Bulan), _bulan, value)
			End Set
		End Property
		Property MataUang As NuSoft001.Persistent.MataUang
			Get
				Return _mataUang
			End Get
			Set(value As NuSoft001.Persistent.MataUang)
				SetPropertyValue(Of NuSoft001.Persistent.MataUang)(NameOf(MataUang), _mataUang, value)
			End Set
		End Property
		Property Kurs As Double
			Get
				Return _kurs
			End Get
			Set(value As Double)
				SetPropertyValue(Of Double)(NameOf(Kurs), _kurs, value)
			End Set
		End Property
		Property Keterangan As String
			Get
				Return _keterangan
			End Get
			Set(value As String)
				SetPropertyValue(Of String)(NameOf(Keterangan), _keterangan, value)
			End Set
		End Property

		<PersistentAlias("Concat(" & NameOf(Tahun) & ",'-'," & NameOf(Bulan) & ",'-01')")> ReadOnly Property Periode As DateTime
			Get
				Return Convert.ToDateTime(EvaluateAlias(NameOf(Periode)))
			End Get
		End Property
	End Class
End Namespace