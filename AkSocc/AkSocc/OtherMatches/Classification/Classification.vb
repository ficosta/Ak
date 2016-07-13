Imports MatchInfo

Public Class Classification
  Public Property OtherMatchDays As OtherMatchDays
  Public Property ClassificationForMatchDays As New List(Of ClassificationForMatchDay)
  Public Property TeamClassificationsForCompetition As New List(Of TeamClassificationForCompetition)

  Private _teams As New List(Of Team)

  Public Sub New(otherMatchDays As OtherMatchDays)
    Me.OtherMatchDays = otherMatchDays
    InitializeCollections()
  End Sub

#Region "Functions"
  Public Sub InitializeCollections()
    Try
      OtherMatchDays.Sort()
      _teams.Clear()
      For Each matchDay As MatchDay In _OtherMatchDays
        For Each match As OtherMatch In matchDay.OtherMatches
          If Not match Is Nothing Then
            If Not _teams.Contains(match.Match.HomeTeam) Then _teams.Add(match.Match.HomeTeam)
            If Not _teams.Contains(match.Match.AwayTeam) Then _teams.Add(match.Match.AwayTeam)
          End If
        Next
      Next

      Me.CalculateClassification()



    Catch ex As Exception

    End Try
  End Sub

  Public Sub CalculateClassification()
    Try
      For iMatchDay As Integer = 0 To _OtherMatchDays.Count - 1
        For iTeam As Integer = 0 To _teams.Count - 1
          Dim tcfc As TeamClassificationForCompetition = Me.TeamClassificationsForCompetition(iMatchDay)
          'Dim tcfmd As TeamClassificationForMatchDay = Me.TeamClassificationsForCompetition(iMatchDay)

        Next
      Next
    Catch ex As Exception

    End Try
  End Sub
#End Region
End Class
