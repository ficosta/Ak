<Serializable()> Public Class Language
  Public ID As String = ""
  Public Property Terms As New Dictionary(Of Integer, Term)

  Public Property Name As String = ""
  Public Property Category As String = ""

  Public Sub New()
  End Sub

  Public Sub New(languageID As String)
    Me.ID = languageID
  End Sub

#Region "Term functions"
  Public Function GetTerm(termString As String) As Term
    Dim res As Term = Nothing
    Try
      For Each pair As KeyValuePair(Of Integer, Term) In Me.Terms
        If pair.Value.Term = termString Then
          res = pair.Value
          Exit For
        End If
      Next
    Catch ex As Exception
    End Try
    Return res
  End Function

  Public Function GetTerm(id As Integer) As Term
    Dim res As Term = Nothing
    Try
      For Each pair As KeyValuePair(Of Integer, Term) In Me.Terms
        If pair.Value.ID = id Then
          res = pair.Value
          Exit For
        End If
      Next
    Catch ex As Exception
    End Try
    Return res
  End Function

  Public Function ContainsTerm(termString As String) As Boolean
    Return (Not Me.GetTerm(termString) Is Nothing)
  End Function

  Public Function ContainsTerm(id As Integer) As Boolean
    Return (Not Me.GetTerm(id) Is Nothing)
  End Function

  Public Function GetFirstAvailableID() As Integer
    Dim res As Integer = 0
    Try
      For Each pair As KeyValuePair(Of Integer, Term) In Me.Terms
        res = Math.Max(res, pair.Key)
      Next
    Catch ex As Exception

    End Try
    Return res + 1
  End Function
#End Region

#Region "Encode/decode"

  Public Function EncodeText(text As String) As String
    Dim sRes As String = ""
    Try
      'fuerza bruta
      For Each pair As KeyValuePair(Of Integer, Term) In Me.Terms
        Dim sID As String = "<%" & pair.Value.ID & "%>"
        sRes = sRes.Replace(pair.Value.Translation, sID)
      Next
    Catch ex As Exception
    End Try
    Return sRes
  End Function

  Public Function DecodeText(text As String) As String
    Dim sRes As String = ""
    Try
      'fuerza bruta
      For Each pair As KeyValuePair(Of Integer, Term) In Me.Terms
        Dim sID As String = "<%" & pair.Value.ID & "%>"
        sRes = sRes.Replace(sID, pair.Value.Translation)
      Next
    Catch ex As Exception
    End Try
    Return sRes
  End Function
#End Region
End Class
