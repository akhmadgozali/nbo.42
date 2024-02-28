Friend Class UI_SettingCRAkun
	Private xTipe As Persistent.CustomReportTipe
	Private xDataSource As DevExpress.Xpo.XPCollection(Of Persistent.Coa)
	Private xExceptCoa As List(Of Persistent.Coa)
	Private itemToEdit As Persistent.CustomReportMain

	WriteOnly Property TipeCR As Persistent.CustomReportTipe
		Set(value As Persistent.CustomReportTipe)
			xTipe = value
			Select Case xTipe
				Case Persistent.CustomReportTipe.NeracaAktiva : xDataSource = Logic.Coa.GetCoa(session, False, New persistent.CoaEnum.eKind() {persistent.CoaEnum.eKind.Kas, persistent.CoaEnum.eKind.Bank, persistent.CoaEnum.eKind.Piutang, persistent.CoaEnum.eKind.Persediaan, persistent.CoaEnum.eKind.AktivaTetap, persistent.CoaEnum.eKind.AktivaLancarLainnya, persistent.CoaEnum.eKind.AkumulasiPenyusutan})
        Case Persistent.CustomReportTipe.NeracaPassiva : xDataSource = Logic.Coa.GetCoa(session, False, New Persistent.CoaEnum.eKind() {Persistent.CoaEnum.eKind.BiayaOperasional, Persistent.CoaEnum.eKind.BiayaLainLain, Persistent.CoaEnum.eKind.HargaPokokPenjualan, Persistent.CoaEnum.eKind.HutangJangkaPendek, Persistent.CoaEnum.eKind.HutangJangkaPanjang, Persistent.CoaEnum.eKind.HutangLancarLainnya, Persistent.CoaEnum.eKind.Modal, Persistent.CoaEnum.eKind.Pendapatan, Persistent.CoaEnum.eKind.PendapatanLainLain})
        Case Persistent.CustomReportTipe.LabaRugi : xDataSource = Logic.Coa.GetCoa(session, False, New Persistent.CoaEnum.eKind() {Persistent.CoaEnum.eKind.BiayaOperasional, Persistent.CoaEnum.eKind.BiayaLainLain, Persistent.CoaEnum.eKind.HargaPokokPenjualan, Persistent.CoaEnum.eKind.Pendapatan, Persistent.CoaEnum.eKind.PendapatanLainLain})
        Case Persistent.CustomReportTipe.HPP : xDataSource = Logic.Coa.GetCoa(session, False, New Persistent.CoaEnum.eKind() {Persistent.CoaEnum.eKind.HargaPokokPenjualan})
				Case Else : xDataSource = Logic.Coa.GetCoa(session, False)
			End Select
			treeAkun.DataSource = xDataSource
		End Set
	End Property
	WriteOnly Property NotShowCoa As List(Of Persistent.Coa)
		Set(value As List(Of Persistent.Coa))
			xExceptCoa = value
		End Set
	End Property

	Sub New()
		' This call is required by the designer.
		InitializeComponent()
		' Add any initialization after the InitializeComponent() call.
		AutoCloseOnSave = True
		NoDropIdentityMap = True
	End Sub

	Overrides Sub LoadBeforeInitialize()
		itemToEdit = CType(IdToEdit, persistent.CustomReportMain)
		Me.Text = "Setting Akun - " & itemToEdit.Nama
	End Sub
	Overrides Sub InitializeData()
		If xTipe <> persistent.CustomReportTipe.CashFlow Then
			xDataSource.Filter = New DevExpress.Data.Filtering.NotOperator(New DevExpress.Data.Filtering.InOperator("This", xExceptCoa))
		Else
			xDataSource.Filter = New DevExpress.Data.Filtering.BinaryOperator("Id", -99999, DevExpress.Data.Filtering.BinaryOperatorType.NotEqual)
		End If
		'====== Check Data Yang Dipakai Item
		'Call the operation:
		Dim op As SetCheckedNodesOperation = New SetCheckedNodesOperation((From d In itemToEdit.Detail Select d.Akun).ToList)
    treeAkun.NodesIterator.DoOperation(op)
    If Tipe = InputType.Edit Then
      treeAkun.ExpandAll()
    End If
  End Sub

	Overrides Sub SimpanData()
		Dim item As persistent.CustomReportDetail
		Dim coa As persistent.Coa
		Dim op As GetCheckedNodesOperation = New GetCheckedNodesOperation()
		treeAkun.NodesIterator.DoOperation(op)

		'===== Delete collection
		For i = itemToEdit.Detail.Count - 1 To 0 Step -1
			coa = itemToEdit.Detail(i).Akun
			If Not op.CheckedNodes.Exists(Function(m) CType(m("This"), persistent.Coa) Is coa) Then
				itemToEdit.Detail(i).Delete()
			End If
		Next

		'===== Add collection
		For i = 0 To op.CheckedNodes.Count - 1
			coa = CType(op.CheckedNodes(i)("This"), persistent.Coa)
			If Not itemToEdit.Detail.ToList.Exists(Function(m) m.Akun Is coa) Then
				'===== Check is Detail
				If Logic.Coa.IsDetail(session, coa) Then
					item = New persistent.CustomReportDetail(session)
					item.Akun = coa
					item.Main = itemToEdit
					itemToEdit.Detail.Add(item)
				End If
			End If
		Next
	End Sub
	'Private Sub treeAkun_AfterCheckNode(sender As Object, e As DevExpress.XtraTreeList.NodeEventArgs) Handles treeAkun.AfterCheckNode
	'  SetCheckedChildNodes(e.Node, e.Node.CheckState)
	'  SetCheckedParentNodes(e.Node, e.Node.CheckState)
	'End Sub
	'Private Sub SetCheckedChildNodes(ByVal node As DevExpress.XtraTreeList.Nodes.TreeListNode, ByVal check As Windows.Forms.CheckState)
	'  For i As Integer = 0 To node.Nodes.Count - 1
	'    node.Nodes(i).CheckState = check
	'    SetCheckedChildNodes(node.Nodes(i), check)
	'  Next i
	'End Sub
	'Private Sub SetCheckedParentNodes(ByVal node As DevExpress.XtraTreeList.Nodes.TreeListNode, ByVal check As Windows.Forms.CheckState)
	'  If node.ParentNode IsNot Nothing Then
	'    Dim b As Boolean = False
	'    Dim state As Windows.Forms.CheckState
	'    For i As Integer = 0 To node.ParentNode.Nodes.Count - 1
	'      state = CType(node.ParentNode.Nodes(i).CheckState, Windows.Forms.CheckState)
	'      If (Not check.Equals(state)) Then
	'        b = Not b
	'        Exit For
	'      End If
	'    Next i
	'    If b Then
	'      node.ParentNode.CheckState = Windows.Forms.CheckState.Indeterminate
	'    Else
	'      node.ParentNode.CheckState = check
	'    End If
	'    SetCheckedParentNodes(node.ParentNode, check)
	'  End If
	'End Sub
End Class

'The operation class that set checked nodes
Friend Class SetCheckedNodesOperation
	Inherits DevExpress.XtraTreeList.Nodes.Operations.TreeListOperation

	Private xData As List(Of persistent.Coa)
	Public Sub New()
		MyBase.New()
	End Sub
	Public Sub New(data As List(Of persistent.Coa))
    MyBase.New()
    xData = data
  End Sub
  Public Overrides Sub Execute(ByVal node As DevExpress.XtraTreeList.Nodes.TreeListNode)
    'MsgBox(xData.ToString & " == " & xData.Count & "/" & node("This").ToString)
    If xData.Exists(Function(m) m Is node("This")) Then
      node.Checked = True
    End If
  End Sub
End Class

'The operation class that collects checked nodes
Friend Class GetCheckedNodesOperation
  Inherits DevExpress.XtraTreeList.Nodes.Operations.TreeListOperation
  Public CheckedNodes As List(Of DevExpress.XtraTreeList.Nodes.TreeListNode) = New List(Of DevExpress.XtraTreeList.Nodes.TreeListNode)()
  Public Sub New()
    MyBase.New()
  End Sub
  Public Overrides Sub Execute(ByVal node As DevExpress.XtraTreeList.Nodes.TreeListNode)
    If node.CheckState = Windows.Forms.CheckState.Checked Then
      CheckedNodes.Add(node)
    End If
  End Sub
End Class