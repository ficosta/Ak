Imports MatchInfo

Public Class ClassificationForMatchDay
  Implements IComparable

  Public Property MatchDay As MatchDay
  Public Property TeamClassificationList As New List(Of TeamClassificationForMatchDay)

  Public Sub New(matchDay As MatchDay, teams As List(Of Team))
    Try
      Me.MatchDay = matchDay
      For Each team As Team In teams
        Me.TeamClassificationList.Add(New TeamClassificationForMatchDay(team, matchDay.Index, matchDay.GetMatchByTeam(team)))
      Next
    Catch ex As Exception

    End Try

  End Sub

  Public Function UpdateClassification() As Boolean
    Try
      If Me.TeamClassificationList.Count = 0 Then Me.PopulateTeamsFromMatchDay()



      Me.TeamClassificationList.Sort()

    Catch ex As Exception

    End Try
    Return True
  End Function

  Private Sub PopulateTeamsFromMatchDay()

  End Sub

  Public Function UpdateClassification(teams As List(Of Team)) As Boolean
    Me.TeamClassificationList.Clear()

    For Each team In teams
      ' Me.TeamClassificationList.Add(New TeamClassificationForMatchDay() With {.Team = team, .MatchDay = Me.MatchDay})
    Next

    Return True
  End Function

  Public Function CompareTo(obj As Object) As Integer Implements IComparable.CompareTo
    Dim aux As ClassificationForMatchDay = CType(obj, ClassificationForMatchDay)
    Dim res As Integer = 0
    Try
      If aux.MatchDay.Index > Me.MatchDay.Index Then
        res = 1
      ElseIf aux.MatchDay.Index < Me.MatchDay.Index Then
        res = -1
      Else
        res = 0
      End If
    Catch ex As Exception
    End Try
    Return res
  End Function
End Class
