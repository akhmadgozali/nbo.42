Imports DevExpress.Xpo
Imports DevExpress.Data.Filtering
Imports NuSoft.NPO
Imports NuSoft.NPO.NAttribute
Imports NuSoft.NUI.Win.Forms.Modules.NuSoftModSys
Imports NuSoft.Utils.CustomAttribute
Namespace Logic
	Friend Class NumberConst
		Public Const FormatSumber As String = "[S]"
		'Public Const FormatAkun As String = "[A]"
		Public Const FormatRegional As String = "[R]"
	End Class
	Friend Class NumberClass
		Inherits Core.Modules.NumberBase
		Sub New(session As UnitOfWork)
			MyBase.New(session)
		End Sub
		Public Overrides Function RegisterFormat() As List(Of Core.Modules.NumberFormat)
			Dim result As New List(Of Core.Modules.NumberFormat)
			result.Add(AddRegister("[S]", 2, "Kode", "Id"))
			'result.Add(AddRegister("[A]", 2, "Format", "Id"))
			result.Add(AddRegister("[R]", 3, "Kode", "Id"))
			Return result
		End Function
		Public Overrides Function SequenceFormat() As String
			Return "[X{0}]"
		End Function
	End Class
End Namespace
Namespace Persistent
	Enum SumberDataJenis
    <EnumDescription("Penerimaan Barang")> GR = 22

    <EnumDescription("Permintaan Stock")> PB = 12
		<EnumDescription("MutasiStock")> ST = 13
		<EnumDescription("Penyesuaian Stock")> PS = 14
		<EnumDescription("Produksi")> AM = 15
		<EnumDescription("Stock Opname")> OS = 16
		<EnumDescription("Saldo Awal Stock")> BS = 17
		<EnumDescription("Pemakaian Stock")> CS = 36

		<EnumDescription("OrderProduksi")> OP = 103
		<EnumDescription("BackToMaterial")> BM = 106
    <EnumDescription("Transfer Stock")> TS = 107
		<EnumDescription("Penyesuaian RM")> PR = 109
		<EnumDescription("Surat Jalan")> FD = 105
		<EnumDescription("Surat Jalan")> SJ = 108
		<EnumDescription("Cutting WIP")> CW = 121
	End Enum
	Friend Class SumberDataCollection
		Inherits NPO.Modules.ModSys.SumberDataCollection(Of SumberDataJenis)
		Sub New(session As UnitOfWork)
			MyBase.New(session)
		End Sub
		Public Overrides Function ModuleId() As NPO.Modules.ModuleId
			Return NPO.Modules.ModuleId.Inventory
		End Function
	End Class
	<NonPersistent()> Public MustInherit Class TransactionMain
		Inherits Core.Modules.TransactionBase
		Public Sub New(ByVal session As DevExpress.Xpo.UnitOfWork)
			MyBase.New(session)
		End Sub
		Public Sub New(ByVal session As DevExpress.Xpo.UnitOfWork, ByVal classInfo As DevExpress.Xpo.Metadata.XPClassInfo)
			MyBase.New(session, classInfo)
		End Sub
		Public Sub New(ByVal session As DevExpress.Xpo.UnitOfWork, Nomor As Core.Modules.NumberBase)
			MyBase.New(session, Nomor)
		End Sub
		Private _usrc As NPO.Modules.ModSys.SumberData
		Private _ureg As NPO.Modules.ModSys.Regional
		<Persistent("u_source"), NCriteria(Logic.NumberConst.FormatSumber)>
		Property Sumber As NPO.Modules.ModSys.SumberData
			Get
				Return _usrc
			End Get
			Set(value As NPO.Modules.ModSys.SumberData)
				SetPropertyValue(Of NPO.Modules.ModSys.SumberData)("Sumber", _usrc, value)
			End Set
		End Property
		<Persistent("u_regional"), NCriteria(Logic.NumberConst.FormatRegional)>
		Property Regional As NPO.Modules.ModSys.Regional
			Get
				Return _ureg
			End Get
			Set(value As NPO.Modules.ModSys.Regional)
				SetPropertyValue(Of NPO.Modules.ModSys.Regional)("Regional", _ureg, value)
			End Set
		End Property
		Protected Friend changes As New List(Of DatabaseLogDetailChange)()
		Protected Overrides Sub OnChanged(ByVal propertyName As String, ByVal oldValue As Object, ByVal newValue As Object)
			MyBase.OnChanged(propertyName, oldValue, newValue)
			Dim change As New DatabaseLogDetailChange() With {.PropertyName = propertyName}
			If oldValue Is Nothing Then
				change.PrevValue = "<NULL>"
			Else
				change.PrevValue = oldValue.ToString()
			End If
			If newValue Is Nothing Then
				change.Value = "<NULL>"
			Else
				change.Value = newValue.ToString()
			End If
			changes.Add(change)
		End Sub
		Protected Overrides Sub OnSaving()
			If Not Number Is Nothing Then
				'If CheckKode() Then
				'	Kode = Number.GetNewNumber.Kode
				'End If
				If Not Number.FormatNomor.Contains(Logic.NumberConst.FormatSumber) Then
					_usrc = Nothing
				End If
				If Not Number.FormatNomor.Contains(Logic.NumberConst.FormatRegional) Then
					_ureg = Nothing
				End If
			End If
			MyBase.OnSaving()
		End Sub
		Private Function CheckKode() As Boolean
			'======= Jika Edit ==================
			If Not Session.IsNewObject(Me) Then
				Dim detail As New List(Of DatabaseLogDetailChange)
				Dim anyChanges As Boolean = False

				detail = changes.FindAll(Function(m) m.PropertyName = "Kode")
				If detail.Count > 0 Then
					'Throw New Exception(detail(0).PrevValue & "<>" & detail(detail.Count - 1).Value)
					If detail(0).PrevValue <> detail(detail.Count - 1).Value Then
						anyChanges = True
					End If
				End If

				If Not anyChanges Then
					Return False
				End If
			End If
			Return Not Session.FindObject(ClassInfo, New BinaryOperator("Kode", GetMemberValue("Kode"), BinaryOperatorType.Equal)) Is Nothing
		End Function
	End Class
	Public Structure DatabaseLogDetailChange
		Public PropertyName As String
		Public PrevValue As String
		Public Value As String
	End Structure
End Namespace