<Serializable()> Public Class OtherMatches
  Inherits CollectionBase

  Public Sub New()
  End Sub

  Public Sub LoadFromFile(file As String)
    Try
      DesserializeObjectFromFile(file, Me.InnerList)
    Catch ex As Exception
      WriteToErrorLog(ex)
    End Try
  End Sub

  Public Sub SaveToFile(file As String)
    Try
      SerializeObjectToFile(file, Me.InnerList)
    Catch ex As Exception
      WriteToErrorLog(ex)
    End Try
  End Sub

  Public Function Add(OtherMatch As OtherMatch) As Integer
    Try
      If Not OtherMatch Is Nothing Then
        Dim found As Boolean
        For index As Integer = 0 To Me.List.Count - 1
          If Me.List(index).OtherMatchID = OtherMatch.OtherMatchID Then
            Me.List(index) = OtherMatch
            found = True
            Exit For
          End If
        Next
        If Not found Then
          Me.List.Add(OtherMatch)
        End If
      End If
    Catch ex As Exception
    End Try
    Return Me.List.Count
  End Function

  Default Public Property Item(Index As Integer) As OtherMatch
    Get
      Return DirectCast(List(Index), OtherMatch)
    End Get
    Set
      List(Index) = Value
    End Set
  End Property


  Public Sub Sort()
    Me.InnerList.Sort()
  End Sub

  Public Function GetMatchesByMatchDay(index As Integer) As OtherMatches
    Dim res As New OtherMatches
    Try
      For Each match As OtherMatch In Me.InnerList
        If match.MatchDay = index Then
          res.Add(match)
        End If
      Next
      res.Sort()
    Catch ex As Exception

    End Try
    Return res
  End Function

  Public Function GetMatchDays() As List(Of OtherMatches)
    Dim res As New List(Of OtherMatches)
    Try
      For Each match As OtherMatch In Me.InnerList
        For Each otherMatches As OtherMatches In res
          If otherMatches.
        Next
      Next
    Catch ex As Exception

    End Try
    Return res
  End Function

End Class
