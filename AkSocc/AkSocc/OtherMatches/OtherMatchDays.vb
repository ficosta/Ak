<Serializable()> Public Class OtherMatchDays
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

  Public Function Add(MatchDay As MatchDay) As Integer
    Try
      If Not MatchDay Is Nothing Then
        Me.List.Add(MatchDay)
      End If
    Catch ex As Exception
    End Try
    Return Me.List.Count
  End Function

  Default Public Property Item(Index As Integer) As MatchDay
    Get
      Return DirectCast(List(Index), MatchDay)
    End Get
    Set
      List(Index) = Value
    End Set
  End Property


  Public Sub Sort()
    Me.InnerList.Sort()
  End Sub

  Public Function GetMatchDays() As List(Of MatchDay)
    Dim res As New List(Of MatchDay)
    Try
      For Each match As OtherMatch In Me.InnerList
        For Each matchDay As MatchDay In res

        Next
      Next
    Catch ex As Exception

    End Try
    Return res
  End Function

  Public Function GetMatchDay(matchDay As String) As MatchDay
    Dim res As MatchDay = Nothing
    Try
      For Each match As MatchDay In Me.InnerList
        If match.MatchDay = matchDay Or match.MatchDayID = matchDay Then
          res = match
          Exit For
        End If
      Next
    Catch ex As Exception

    End Try
    Return res
  End Function

End Class
