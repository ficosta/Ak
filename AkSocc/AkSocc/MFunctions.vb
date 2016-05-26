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

  Public Function FormatDate(ByVal diDate As Date) As String
    Dim sAux As String = ""
    Try
      sAux = diDate.Month & "/" & diDate.Day & "/" & diDate.Year & " " & diDate.Hour & ":" & diDate.Minute & ":" & diDate.Second & "." & diDate.Millisecond
    Catch ex As Exception
    End Try
    Return sAux
  End Function

End Module

