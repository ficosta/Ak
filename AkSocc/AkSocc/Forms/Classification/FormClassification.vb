Imports MatchInfo

Public Class FormClassification
  Private _classification As Classification

  Public Property CompetitionID As Integer = 0

  Private _updating As Boolean = False

  Public Sub New(_match As Match)

    ' This call is required by the designer.
    InitializeComponent()

    ' Add any initialization after the InitializeComponent() call.
    Try
      InitClassification(_match.competition_id)
    Catch ex As Exception
    End Try
  End Sub

  Public Sub New(compId As Integer)

    ' This call is required by the designer.
    InitializeComponent()

    ' Add any initialization after the InitializeComponent() call.
    InitClassification(compId)
  End Sub

  Private Sub InitClassification(compId As Integer)
    Try
      _updating = True
      CompetitionID = compId
      Dim _matches As New Matches()
      _matches = Matches.GetMatchesForCompetition(CompetitionID)
      _classification = New Classification(_matches)
      Me.ComboBoxMatchDays.Items.Clear()
      For Each matchDayClass As ClassificationForMatchDay In _classification.ClassificationForMatchDays
        Me.ComboBoxMatchDays.Items.Add(matchDayClass)
      Next
    Catch ex As Exception

    End Try
    _updating = False
  End Sub

  Private Sub FormClassification_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    Try
      Me.ShowClassification(_classification.LastAvailableClassificationForMatchDay)
    Catch ex As Exception

    End Try
  End Sub

  Private Sub ComboBoxMatchDays_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxMatchDays.SelectedIndexChanged
    Try
      If _updating Then Exit Sub
      Me.ShowClassification(Me.ComboBoxMatchDays.SelectedItem)
    Catch ex As Exception

    End Try
  End Sub

  Private Sub ShowClassification(matchDayClass As ClassificationForMatchDay)
    Try
      With MetroGridClassification
        .Rows.Clear()
        .Rows.Add(matchDayClass.TeamClassificationList.Count)
        Dim index As Integer = 0
        For Each team As TeamClassificationForMatchDay In matchDayClass.TeamClassificationList
          .Rows(index).Cells(ColumnPosition.Index).Value = team.Position
          .Rows(index).Cells(ColumnName.Index).Value = team.Team.Name
          .Rows(index).Cells(ColumnPoints.Index).Value = team.Points
          .Rows(index).Cells(ColumnGoalAverage.Index).Value = team.GoalAverage
          .Rows(index).Cells(ColumnGoalsReceived.Index).Value = team.GoalsAgainst
          .Rows(index).Cells(ColumnGoalsScored.Index).Value = team.GoalsFor
          .Rows(index).Cells(ColumnPlayed.Index).Value = team.MatchesPlayed
          .Rows(index).Cells(ColumnWon.Index).Value = team.MatchesWon
          .Rows(index).Cells(ColumnLost.Index).Value = team.MatchesLost
          .Rows(index).Cells(ColumnDraw.Index).Value = team.MatchesDrawn
          '.Rows(index).Cells(ColumnWon.Index).Value = team.Position


          index += 1
        Next
      End With

    Catch ex As Exception

    End Try
  End Sub
End Class