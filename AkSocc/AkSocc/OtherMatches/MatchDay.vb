Imports MatchInfo

<Serializable()> Public Class MatchDay
  Implements IComparable

  Public Property MatchDayID As String = Guid.NewGuid().ToString
  Public Property MatchDayName As String = "undefined"

  Public Property Name As String = "undefined"
  Public Property Index As Integer = 0

  Public Property OtherMatches As New List(Of OtherMatch)


  Public Sub New()
  End Sub

  Public Sub New(matchDay As String)
    Me.MatchDayName = matchDay
  End Sub

  Public Function Add(OtherMatch As OtherMatch) As Integer
    Try
      If Not OtherMatch Is Nothing Then
        Dim found As Boolean
        For index As Integer = 0 To Me.OtherMatches.Count - 1
          If Me.OtherMatches(index).OtherMatchID = OtherMatch.OtherMatchID Then
            Me.OtherMatches(index) = OtherMatch
            found = True
            Exit For
          End If
        Next
        If Not found Then
          Me.OtherMatches.Add(OtherMatch)
        End If
      End If
      UpdateIndexes()
    Catch ex As Exception
    End Try
    Return Me.OtherMatches.Count
  End Function

  Public Sub Remove(OtherMatch As OtherMatch)
    Try
      If Not OtherMatch Is Nothing Then
        For index As Integer = Me.OtherMatches.Count - 1 To 0 Step -1
          If Me.OtherMatches(index).OtherMatchID = OtherMatch.OtherMatchID Then
            Me.OtherMatches.RemoveAt(index)
          End If
        Next
      End If
      UpdateIndexes()
    Catch ex As Exception
    End Try
  End Sub

  Default Public Property Item(Index As Integer) As OtherMatch
    Get
      Return DirectCast(OtherMatches(Index), OtherMatch)
    End Get
    Set
      OtherMatches(Index) = Value
    End Set
  End Property

  Public Sub Sort()
    Me.OtherMatches.Sort()
  End Sub

  Public Function GetMatchDays() As List(Of MatchDay)
    Dim res As New List(Of MatchDay)
    Try
      For Each match As OtherMatch In Me.OtherMatches
        For Each matchDay As MatchDay In res

        Next
      Next
    Catch ex As Exception

    End Try
    Return res
  End Function

  Public Function GetMatch(id As String) As OtherMatch
    Dim res As OtherMatch = Nothing
    Try
      For Each match As OtherMatch In Me.OtherMatches
        If match.OtherMatchID = id Then
          res = match
        End If
      Next
    Catch ex As Exception

    End Try
    Return res
  End Function

  Public Function GetMatchByTeam(id As Integer) As OtherMatch
    Dim res As OtherMatch = Nothing
    Try
      For Each match As OtherMatch In Me.OtherMatches
        If Not match Is Nothing Then
          If match.Match.home_team_id = id Or match.Match.away_team_id = id Then
            res = match
          End If
        End If
      Next
    Catch ex As Exception

    End Try
    Return res
  End Function


  Public Function GetMatchByTeam(team As Team) As OtherMatch
    Dim res As OtherMatch = Nothing
    Try
      res = GetMatchByTeam(team)
    Catch ex As Exception

    End Try
    Return res
  End Function

  Public Function CompareTo(obj As Object) As Integer Implements IComparable.CompareTo
    Dim aux As MatchDay = CType(obj, MatchDay)
    If aux.MatchDayName > Me.MatchDayName Then
      Return 1
    ElseIf aux.MatchDayName < Me.MatchDayName Then
      Return -1
    Else
      Return 0
    End If
  End Function

  Public Sub UpdateIndexes()
    Dim orderChanged As Boolean = False
    Try
      '_pagines.Sort()
      For nIndex As Integer = 0 To Me.OtherMatches.Count - 1
        orderChanged = orderChanged Or (Me.Item(nIndex).MatchIndex <> nIndex)
        Me.Item(nIndex).MatchIndex = nIndex
        '_pagines(nIndex).ID = nIndex
      Next
    Catch ex As Exception
    End Try
  End Sub

End Class
