Imports System.IO
Imports System.Xml.Serialization

Module MFuncions
  Private Const NOM_MODUL As String = "MFuncions"

  Public Structure tyNameIDPair
    Dim ID As Integer
    Dim Nom As String
  End Structure

  Public Function NoNullInt(ByVal CiValor As Object) As Integer
    Dim nRes As Integer
    Try
      nRes = CInt(CiValor)
    Catch ex As Exception
      nRes = 0
    End Try
    Return nRes
  End Function

  Public Function NoNullLong(ByVal CiValor As Object) As Long
    Dim nRes As Long
    Try
      nRes = CLng(CiValor)
    Catch ex As Exception
      nRes = 0
    End Try
    Return nRes
  End Function

  Public Function NoNullBool(ByVal CiValor As Object) As Boolean
    Dim bRes As Boolean
    Try
      bRes = CBool(CiValor)
    Catch ex As Exception
      bRes = False
    End Try
    Return bRes
  End Function

  Public Function NoNullString(ByVal CiValor As Object) As String
    Dim sRes As String
    Try
      sRes = CStr(CiValor)
    Catch ex As Exception
      sRes = ""
    End Try
    Return sRes
  End Function

  Public Function NoNullDecimal(ByVal CiValor As Object) As Decimal
    Dim fRes As Decimal
    Try
      fRes = CDec(CiValor)
    Catch ex As Exception
      fRes = 0D
    End Try
    Return fRes
  End Function

  Public Function NoNullDate(ByVal CiValor As Object) As Date
    Dim dRes As Date = #1/1/1980#
    Try
      dRes = CDate(CiValor)
    Catch ex As Exception

    End Try
    Return dRes
  End Function

  Public Function SecondsToMMSS(ByVal niValue As Integer) As String
    Dim sAux As String = ""
    Try
      sAux = Format(niValue \ 60, "00") & ":"
      sAux = sAux & Format(niValue Mod 60, "00")
    Catch ex As Exception

    End Try
    Return sAux
  End Function

  Public Function SecondsToMMSS(ByVal niValue As Long) As String
    Dim sAux As String = ""
    Try
      sAux = Format(niValue \ 60, "00") & ":"
      sAux = sAux & Format(niValue Mod 60, "00")
    Catch ex As Exception
    End Try
    Return sAux
  End Function



  Public Function GetRecordsetIntValue(rs As ADODB.Recordset, field As String) As Integer
    Dim res As Integer = 0
    Try
      res = NoNullInt(rs.Fields(field).Value)
    Catch ex As Exception

    End Try
    Return res
  End Function

  Public Function GetRecordsetDecimalValue(rs As ADODB.Recordset, field As String) As Decimal
    Dim res As Integer = 0
    Try
      res = NoNullDecimal(rs.Fields(field).Value)
    Catch ex As Exception

    End Try
    Return res
  End Function

  Public Function GetRecordsetStringValue(rs As ADODB.Recordset, field As String) As String
    Dim res As Integer = 0
    Try
      res = NoNullString(rs.Fields(field).Value)
    Catch ex As Exception

    End Try
    Return res
  End Function


  Public Function GetRecordsetBooleanValue(rs As ADODB.Recordset, field As String) As Boolean
    Dim res As Integer = 0
    Try
      res = NoNullBool(rs.Fields(field).Value)
    Catch ex As Exception

    End Try
    Return res
  End Function



  Public Function FormatDate(ByVal diDate As Date) As String
    Dim sAux As String = ""
    Try
      sAux = diDate.Month & "/" & diDate.Day & "/" & diDate.Year & " " & diDate.Hour & ":" & diDate.Minute & ":" & diDate.Second & "." & diDate.Millisecond
    Catch ex As Exception
    End Try
    Return sAux
  End Function


  Public Function SerializeObjectToFile(ByVal siFile As String, ByRef CiObject As Object) As Boolean

    Dim bRes As Boolean = False
    Try
      Dim sRes As String = SerializeObjectToString(CiObject)
      If sRes <> "" Then
        Dim myFileStream As FileStream = File.Create(siFile)
        Dim bytes() As Byte
        bytes = System.Text.Encoding.UTF8.GetBytes(sRes)
        myFileStream.Write(bytes, 0, bytes.Length)
        myFileStream.Flush()
        myFileStream.Close()
      Else
        Try
          Dim xs As New XmlSerializer(CiObject.GetType)
          Using fs As New System.IO.FileStream(siFile, FileMode.OpenOrCreate, FileAccess.ReadWrite)
            xs.Serialize(fs, CiObject)
          End Using
        Catch generatedExceptionName As Exception
          Throw
        End Try
      End If
    Catch ex As Exception
      Debug.Print(ex.ToString)
    End Try
    Return bRes
  End Function

  Public Function SerializeObjectToString(ByRef CiObject As Object) As String
    Dim sRes As String = ""
    Try
      Dim sr As New IO.StringWriter()
      Dim serializer As New XmlSerializer(CiObject.GetType)
      serializer.Serialize(sr, CiObject)
      sRes = sr.ToString

    Catch ex As Exception
      Debug.Print(ex.ToString)
    End Try
    Return sRes
  End Function

  Public Function DesserializeObjectFromFile(ByVal siFile As String, ByRef CoObject As Object) As Boolean
    Dim bRes As Boolean = False
    Try
      If File.Exists(siFile) Then
        Dim myFileStream As FileStream = File.OpenRead(siFile)
        Dim bytes(myFileStream.Length - 1) As Byte
        myFileStream.Read(bytes, 0, myFileStream.Length)
        Dim sRes As String
        sRes = System.Text.Encoding.UTF8.GetString(bytes)
        DesserializeObjectFromString(sRes, CoObject)
        myFileStream.Close()
        bRes = True
      End If
    Catch ex As Exception
    End Try
    Return bRes
  End Function

  Public Function DesserializeObjectFromString(ByVal siString As String, ByRef CoObject As Object) As Boolean
    Dim bRes As Boolean = False
    Dim sRead As String = siString
    Try
      If sRead.Contains(vbNullChar) Then
        sRead = siString.Replace(vbNullChar, "")
      Else
        sRead = siString
      End If

      Dim sr As New IO.StringReader(sRead)
      Dim deserializer As New XmlSerializer(CoObject.GetType)
      CoObject = deserializer.Deserialize(sr)
      bRes = True
    Catch ex As Exception
    End Try
    Return bRes
  End Function
End Module

