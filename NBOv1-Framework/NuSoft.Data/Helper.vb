Imports System.Configuration

Namespace NuSoft.Data
  Public Class Helper
    Shared Function GetKey() As String
      Return My.Resources.VariableKey
    End Function
    Shared Function GetServer(crypto As Utils.Cryptograph.DES) As String
      Try
        If ConfigurationManager.AppSettings.Count = 0 Then
          '==== Load Default Setting
          Dim encryptDES As New Utils.Cryptograph.DES() With {.Key = Data.Helper.GetKey}

          Dim b As New Data.Win.Configuration.SystemConfiguration.Setting() _
            With {.DatabaseServer = "7KtzvvmnGaYCOTKOpMEyIA==", _
                  .DatabasePrefiks = "WnWHBjEZEFw=",
                  .SyncAuto = "2tW+2ar8APg=",
                  .SyncInterval = "F8nlm7CnivQ=",
                  .MultipleInstance = "2tW+2ar8APg="
                  }

          Data.Win.Configuration.SystemConfiguration.Save(b)
        End If

        Return crypto.Decrypt(ConfigurationManager.AppSettings("S"))
      Catch ex As Exception
        Return crypto.Decrypt("7KtzvvmnGaYCOTKOpMEyIA==")
      End Try
    End Function
    Shared Function GetPrefiks(crypto As Utils.Cryptograph.DES) As String
      Try
        Return crypto.Decrypt(ConfigurationManager.AppSettings("P"))
      Catch ex As Exception
        Return crypto.Decrypt("WnWHBjEZEFw=")
      End Try
    End Function
    Shared Function GetSyncAuto(crypto As Utils.Cryptograph.DES) As String
      Try
        Return crypto.Decrypt(ConfigurationManager.AppSettings("A"))
      Catch ex As Exception
        Return crypto.Decrypt("2tW+2ar8APg=")
      End Try
    End Function
    Shared Function GetSyncInterval(crypto As Utils.Cryptograph.DES) As String
      Try
        Return crypto.Decrypt(ConfigurationManager.AppSettings("I"))
      Catch ex As Exception
        Return crypto.Decrypt("F8nlm7CnivQ=")
      End Try
    End Function
    Shared Function GetMultipleInstance(crypto As Utils.Cryptograph.DES) As String
      Try
        Return crypto.Decrypt(ConfigurationManager.AppSettings("M"))
      Catch ex As Exception
        Return crypto.Decrypt("2tW+2ar8APg=")
      End Try
    End Function

    Shared Function GetUpdateServer(crypto As Utils.Cryptograph.DES) As String
      Try
        Dim x = ConfigurationManager.AppSettings("X1")
        If Not String.IsNullOrEmpty(x) Then
          Return crypto.Decrypt(x)
        Else
          Return ""
        End If
      Catch ex As Exception
        Return ""
      End Try
    End Function
    Shared Function GetUpdatePort(crypto As Utils.Cryptograph.DES) As String
      Try
        Dim x = ConfigurationManager.AppSettings("X2")
        If Not String.IsNullOrEmpty(x) Then
          Return crypto.Decrypt(x)
        Else
          Return ""
        End If
      Catch ex As Exception
        Return ""
      End Try
    End Function
    Shared Function GetUpdateUser(crypto As Utils.Cryptograph.DES) As String
      Try
        Dim x = ConfigurationManager.AppSettings("X3")
        If Not String.IsNullOrEmpty(x) Then
          Return crypto.Decrypt(x)
        Else
          Return ""
        End If
      Catch ex As Exception
        Return ""
      End Try
    End Function
    Shared Function GetUpdatePassword(crypto As Utils.Cryptograph.DES) As String
      Try
        Dim x = ConfigurationManager.AppSettings("X4")
        If Not String.IsNullOrEmpty(x) Then
          Return crypto.Decrypt(x)
        Else
          Return ""
        End If
      Catch ex As Exception
        Return ""
      End Try
    End Function
    Shared Function GetUpdateFileException(crypto As Utils.Cryptograph.DES) As String
      Try
        Dim x = ConfigurationManager.AppSettings("X5")
        If Not String.IsNullOrEmpty(x) Then
          Return crypto.Decrypt(x)
        Else
          Return ""
        End If
      Catch ex As Exception
        Return ""
      End Try
    End Function
    Shared Function GetUpdateFolderException(crypto As Utils.Cryptograph.DES) As String
      Try
        Dim x = ConfigurationManager.AppSettings("X6")
        If Not String.IsNullOrEmpty(x) Then
          Return crypto.Decrypt(x)
        Else
          Return ""
        End If
      Catch ex As Exception
        Return ""
      End Try
    End Function

    Shared Function IsWeb() As Boolean
      Return ConfigurationManager.AppSettings("PlatForm") = "Web"
    End Function

    Shared Function ExecuteScalar(ByVal cmd As MySql.Data.MySqlClient.MySqlCommand, ByVal cmdText As String, ByVal ParamArray param() As MySql.Data.MySqlClient.MySqlParameter) As Object
      cmd.CommandText = cmdText
      cmd.Parameters.Clear()
      For i = param.GetLowerBound(0) To param.GetUpperBound(0)
        cmd.Parameters.Add(param(i))
      Next
      Return (cmd.ExecuteScalar)
    End Function

    Shared Function ExecuteDataset(ByVal cmd As MySql.Data.MySqlClient.MySqlCommand, ByVal sqlText As String) As DataSet
      Return ExecuteDataset(cmd.Connection, sqlText)
    End Function
    Shared Function ExecuteDataset(ByVal con As MySql.Data.MySqlClient.MySqlConnection, ByVal sqlText As String) As DataSet
      If con Is Nothing Then
        Throw New Utils.Exception("Tidak ada koneksi pada command", -99, "Set koneksi terlebih dahulu", "ExecuteDataset")
      End If

      Using adap As New MySql.Data.MySqlClient.MySqlDataAdapter(sqlText, con)
        Dim result As New DataSet()
        adap.Fill(result)
        Return result
      End Using
    End Function
    Shared Function ExecuteDataset(ByVal cmd As MySql.Data.MySqlClient.MySqlCommand, ByVal sqlText As String, ByVal ParamArray param() As MySql.Data.MySqlClient.MySqlParameter) As DataSet
      If cmd.Connection Is Nothing Then
        Throw New Utils.Exception("Tidak ada koneksi pada command", -99, "Set koneksi terlebih dahulu", "ExecuteDataset")
      End If

      Using result As New DataSet()
        cmd.CommandText = sqlText
        cmd.Parameters.Clear()
        For i = param.GetLowerBound(0) To param.GetUpperBound(0)
          cmd.Parameters.Add(param(i))
        Next
        result.Load(cmd.ExecuteReader, LoadOption.OverwriteChanges, "")
        Return result
      End Using
    End Function

    Shared Function GetTimeStamp(ByVal session As DevExpress.Xpo.Session) As DateTime
      Return CType(session.ExecuteScalar("select now()"), DateTime)
    End Function
    Shared Function GetMD5(ByVal session As DevExpress.Xpo.Session, stringToEncrypt As String) As String
      Dim parameterName As String() = New String() {"@pass"}
      Dim values As String() = New String() {stringToEncrypt}
      Return CType(session.ExecuteScalar("select convert(md5(@pass) using utf8)", parameterName, values), String)
    End Function
    Shared Function GetSHA2(ByVal session As DevExpress.Xpo.Session, stringToEncrypt As String) As String
      Dim parameterName As String() = New String() {"@pass"}
      Dim values As String() = New String() {stringToEncrypt}
      Return CType(session.ExecuteScalar("select convert(sha2(@pass,512) using utf8)", parameterName, values), String)
    End Function
    Shared Function GetUUIDShort(ByVal session As DevExpress.Xpo.Session) As UInt64
      Return CType(session.ExecuteScalar("select uuid_short()"), UInt64)
    End Function

    Shared Function GetGapsNumber(sesi As DevExpress.Xpo.Session, classInfo As DevExpress.Xpo.Metadata.XPClassInfo, propertyName As String, Optional propertyCriteria As String = "", Optional valueCriteria As String = "") As Integer
      Dim sql As String = "SELECT A.{1} + 1 " & _
                          "FROM {0} AS A " & _
                          "WHERE NOT EXISTS (" & _
                                            "SELECT B.{1} FROM {0} AS B " & _
                                            "WHERE A.{1} + 1 = B.{1} {2}) {3} " & _
                          "LIMIT 1;"
      '"GROUP BY A.{1} limit 1;"

      Dim fieldName As String
      Dim fieldCriteria() As String
      Dim criteriaValue() As String
      Dim criteriaSQLB As String = ""
      Dim criteriaSQLA As String = ""

      fieldName = CType(classInfo.Members.Single(Function(m) m.Name = propertyName).GetAttributeInfo(GetType(DevExpress.Xpo.PersistentAttribute)), DevExpress.Xpo.PersistentAttribute).MapTo
      If propertyCriteria <> "" Then
        fieldCriteria = propertyCriteria.Split(";"c)
        criteriaValue = valueCriteria.Split(";"c)
        For i = fieldCriteria.GetLowerBound(0) To fieldCriteria.GetUpperBound(0)
          Dim a As String = fieldCriteria(i)
          criteriaSQLA &= " AND A." & CType(classInfo.Members.Single(Function(m) m.Name = a).GetAttributeInfo(GetType(DevExpress.Xpo.PersistentAttribute)), DevExpress.Xpo.PersistentAttribute).MapTo & criteriaValue(i)
          criteriaSQLB &= " AND B." & CType(classInfo.Members.Single(Function(m) m.Name = a).GetAttributeInfo(GetType(DevExpress.Xpo.PersistentAttribute)), DevExpress.Xpo.PersistentAttribute).MapTo & criteriaValue(i)
        Next
      End If

      Dim cmd As String = String.Format(sql, classInfo.TableName, fieldName, criteriaSQLB, criteriaSQLA)
      'InputBox("", "", cmd)
      Dim selectedData As DevExpress.Xpo.DB.SelectedData = sesi.ExecuteQuery(cmd)
      If selectedData.ResultSet(0).Rows.GetUpperBound(0) >= 0 Then
        Return CInt(selectedData.ResultSet(0).Rows(0).Values(0))
      Else
        Return 1
      End If
    End Function
    Shared Function GetNextNumber(sesi As DevExpress.Xpo.UnitOfWork, classInfo As DevExpress.Xpo.Metadata.XPClassInfo, propertyName As String, Optional propertyCriteria As String = "", Optional valueCriteria As String = "") As Integer
      Dim sql As String = "SELECT {1} + 1 " & _
                          "FROM {0} " & _
                          "WHERE NOT {1} IS NULL {2} " & _
                          "ORDER BY {1} DESC LIMIT 1;"

      Dim fieldName As String
      Dim fieldCriteria() As String
      Dim criteriaValue() As String
      Dim criteriaSQLA As String = ""

      fieldName = CType(classInfo.Members.Single(Function(m) m.Name = propertyName).GetAttributeInfo(GetType(DevExpress.Xpo.PersistentAttribute)), DevExpress.Xpo.PersistentAttribute).MapTo
      If propertyCriteria <> "" Then
        fieldCriteria = propertyCriteria.Split(";"c)
        criteriaValue = valueCriteria.Split(";"c)
        For i = fieldCriteria.GetLowerBound(0) To fieldCriteria.GetUpperBound(0)
          Dim a As String = fieldCriteria(i)
          criteriaSQLA &= " AND " & CType(classInfo.Members.Single(Function(m) m.Name = a).GetAttributeInfo(GetType(DevExpress.Xpo.PersistentAttribute)), DevExpress.Xpo.PersistentAttribute).MapTo & criteriaValue(i)
        Next
      End If

      Dim cmd As String = String.Format(sql, classInfo.TableName, fieldName, criteriaSQLA)
      Dim selectedData As DevExpress.Xpo.DB.SelectedData = sesi.ExecuteQuery(cmd)
      If selectedData.ResultSet(0).Rows.GetUpperBound(0) >= 0 Then
        Return CInt(selectedData.ResultSet(0).Rows(0).Values(0))
      Else
        Return 1
      End If
    End Function
  End Class
End Namespace