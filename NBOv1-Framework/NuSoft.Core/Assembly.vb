Namespace NuSoft.Core.Win
  Friend Class Assembly
    Private Shared loadedAssembly As New List(Of assemblyLoad)

    Shared Function InvokeMemberClass(ByVal fileName As String, ByVal className As String, ByVal methodName As String, ByVal args() As Object) As Object
      Dim xType As Type
      Dim z As Reflection.AssemblyProductAttribute
      Dim assembly As Reflection.Assembly = loadedAssembly.Find(Function(m) m.FileName = fileName).Assembly
      If assembly Is Nothing Then
        assembly = Reflection.Assembly.LoadFrom(fileName)
        loadedAssembly.Add(New assemblyLoad() With {.FileName = fileName, .Assembly = assembly})
      End If

      z = CType(assembly.GetCustomAttributes(GetType(Reflection.AssemblyProductAttribute), False)(0), Reflection.AssemblyProductAttribute)
      xType = assembly.GetType(String.Format("{0}.{1}", z.Product, className))
      Dim ClassObj As Object = Activator.CreateInstance(xType)
      Return xType.InvokeMember(methodName, Reflection.BindingFlags.Default Or Reflection.BindingFlags.InvokeMethod, Nothing, ClassObj, args)
    End Function

    Structure assemblyLoad
      Property FileName As String
      Property Assembly As Reflection.Assembly
    End Structure
  End Class
End Namespace