Imports MatchInfo

Public Class ClassificationForMatchDay
  Implements IComparable

  Public Property MatchDay As Integer
  Public Property TeamClassificationList As New List(Of TeamClassificationForMatchDay)

  Public Sub New(matchDay As Integer)
    Try
      Me.MatchDay = matchDay

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
      ' Me.TeamClassificationList.Add(New TeamClassificationForMatchDay() With {.Team = team, .OtherMatchDay = Me.OtherMatchDay})
    Next

    Return True
  End Function

  Public Function CompareTo(obj As Object) As Integer Implements IComparable.CompareTo
    Dim aux As ClassificationForMatchDay = CType(obj, ClassificationForMatchDay)
    Dim res As Integer = 0
    Try
      If aux.MatchDay > Me.MatchDay Then
        res = 1
      ElseIf aux.MatchDay < Me.MatchDay Then
        res = -1
      Else
        res = 0
      End If
    Catch ex As Exception
    End Try
    Return res
  End Function



  Public Function HasResults() As Boolean
    Dim res As Boolean = False

    If TeamClassificationList.Count > 0 Then
      For Each teamClass As TeamClassificationForMatchDay In TeamClassificationList
        If Not teamClass Is Nothing AndAlso Not teamClass.Match Is Nothing Then
          If teamClass.Match.home_goals >= 0 Then
            res = True
            Exit For
          End If
        End If
      Next
    End If

    Return res
  End Function

  Public Function getTeamClassificationForMatchDay(teamID As Integer) As TeamClassificationForMatchDay
    Dim res As TeamClassificationForMatchDay = Nothing
    Try
      For Each team As TeamClassificationForMatchDay In Me.TeamClassificationList
        If team.Team.TeamID = teamID Then
          res = team
          Exit For
        End If
      Next
    Catch ex As Exception

    End Try
    Return res
  End Function

  Public Overrides Function ToString() As String
    Return "Match day " & Me.MatchDay
  End Function

End Class
