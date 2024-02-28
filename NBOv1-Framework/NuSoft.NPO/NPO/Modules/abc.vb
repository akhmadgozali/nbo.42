Imports DevExpress.Xpo

Namespace NuSoft.NPO.Modules.abc
	<Persistent("abcperiod")> Public Class Periode
		Inherits NPOBase

		Public Sub New()

		End Sub
		Public Sub New(ByVal session As Session)
			MyBase.New(session)
		End Sub
		Public Sub New(ByVal session As Session, ByVal classInfo As DevExpress.Xpo.Metadata.XPClassInfo)
			MyBase.New(session, classInfo)
		End Sub

		Private _id As Int32
		Private _Tahun As Int32
		Private _Bulan As Int32
		Private _Kunci As Boolean

		<Persistent("p_id"), Key(True)> Property Id As Int32
			Get
				Return _id
			End Get
			Set(value As Int32)
				SetPropertyValue(Of Int32)("Id", _id, value)
			End Set
		End Property
		<Persistent("u_year")> Property Tahun As Int32
			Get
				Return _Tahun
			End Get
			Set(value As Int32)
				SetPropertyValue(Of Int32)("Tahun", _Tahun, value)
			End Set
		End Property
		<Persistent("u_month")> Property Bulan As Int32
			Get
				Return _Bulan
			End Get
			Set(value As Int32)
				SetPropertyValue(Of Int32)("Bulan", _Bulan, value)
			End Set
		End Property
		<Persistent("d_lock")> Property Kunci As Boolean
			Get
				Return _Kunci
			End Get
			Set(value As Boolean)
				SetPropertyValue(Of Boolean)("Kunci", _Kunci, value)
			End Set
		End Property

		<PersistentAlias("MonthName(_Bulan)")> _
		ReadOnly Property NamaBulan As String
			Get
				MonthName(2)
				Return EvaluateAlias("NamaBulan").ToString
			End Get
		End Property

		Shared Function CheckLockedPeriod(session As Session, tanggal As Date) As Boolean
			Dim a As Periode = session.FindObject(Of Periode)(DevExpress.Data.Filtering.CriteriaOperator.Parse(String.Format("Tahun={0} and Bulan={1}", tanggal.Year, tanggal.Month)))

			Return Not a Is Nothing AndAlso a.Kunci = True
		End Function
	End Class
End Namespace