Imports System.IO
Imports System.Xml.Serialization

Module MFuncions
  Private Const NOM_MODUL As String = "MFuncions"

  Public Structure tyNameIDPair
    Dim ID As Integer
    Dim Nom As String
  End Structure

  Public Function Clamp(value As Double, min As Double, max As Double) As Double
    Dim res As Double = min
    Try
      res = Math.Max(Math.Min(min, max), value)
      res = Math.Min(Math.Max(min, max), res)
    Catch ex As Exception

    End Try
    Return res
  End Function

  Public Function FormatRunningTime(seconds As Integer) As String
    Dim res As String = seconds
    Try
      res = CStr(seconds \ 60) & ":" & Strings.Format(seconds Mod 60, "00")
    Catch ex As Exception

    End Try
    Return res
  End Function

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
    Dim sRes As String = ""
    Try
      If Not CiValor Is Nothing Then
        sRes = CStr(CiValor)
      End If
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

#Region "XML"

  Public Function ReadAttribute(Node As System.Xml.XmlNode, Son As String, Attribute As String) As String
    Dim strReturn As String
    Try
      strReturn = Node.SelectSingleNode(Son).Attributes(Attribute).InnerText
    Catch
      strReturn = ""
    End Try
    Return strReturn
  End Function

  Public Function ReadAttribute(Node As System.Xml.XmlNode, Son As String, GrandSon As String, Attribute As String) As String
    Dim strReturn As String
    Try
      strReturn = Node.SelectSingleNode(Son).SelectSingleNode(GrandSon).Attributes(Attribute).InnerText
    Catch
      strReturn = ""
    End Try
    Return strReturn
  End Function

  Public Function ReadSon(Node As System.Xml.XmlNode, Son As String) As String
    Dim strReturn As String
    Try
      strReturn = Node.SelectSingleNode(Son).InnerText
    Catch
      strReturn = ""
    End Try
    Return strReturn
  End Function

  Public Function ReadSon(Node As System.Xml.XmlNode, Son As String, GrandSon As String) As String
    Dim strReturn As String
    Try
      strReturn = Node.SelectSingleNode(Son).SelectSingleNode(GrandSon).InnerText
    Catch
      strReturn = ""
    End Try
    Return strReturn
  End Function

  Public Function ReadAttribute(Node As System.Xml.XmlNode, Attribute As String) As String
    Dim strReturn As String
    Try
      strReturn = Node.Attributes(Attribute).InnerText
    Catch
      strReturn = ""
    End Try
    Return strReturn
  End Function

#End Region

#Region "Metro grid"

  Public Sub EnsureRowIsVisible(grid As MetroFramework.Controls.MetroGrid, row As Integer)
    Try
      With grid
        Dim topRow As Integer = .FirstDisplayedCell.RowIndex
        Dim bottomRow As Integer = topRow + .DisplayedRowCount(False)
        If row < topRow Or row > bottomRow Then
          'we are out
          Dim cell As DataGridViewCell = grid.Rows(row).Cells(0)
          .FirstDisplayedCell = cell
        End If
      End With
    Catch ex As Exception

    End Try
  End Sub
#End Region
End Module

