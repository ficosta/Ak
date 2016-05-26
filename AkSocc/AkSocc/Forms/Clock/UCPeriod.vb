Imports MatchInfo

Public Class UCPeriod
  Private WithEvents _period As MatchInfo.Period
  Public Property Period As MatchInfo.Period
    Get
      Return _period
    End Get
    Set(value As MatchInfo.Period)
      _period = value
    End Set
  End Property

  Private WithEvents _match As MatchInfo.Match
  Public Property Match As MatchInfo.Match
    Get
      Return _match
    End Get
    Set(value As MatchInfo.Match)
      _match = value
    End Set
  End Property

  Public Sub InitPeriod(match As MatchInfo.Match, part As Integer)
    Try
      Me.Match = match
      Me.Period = Me.Match.MatchPeriods.GetPeriodByPart(part)
      Me.MetroTilePeriodName.Text = Me.Period.Nom
      UpdateInterface()
    Catch ex As Exception

    End Try
  End Sub

  Private Sub MetroButtonStart_Click(sender As Object, e As EventArgs) Handles MetroButtonStart.Click
    If Not _period Is Nothing Then
      _match.MatchPeriods.StartPeriod(Me.Period, 0)
    End If
  End Sub

  Private Sub MetroButtonEndPeriod_Click(sender As Object, e As EventArgs) Handles MetroButtonEndPeriod.Click
    If Not _period Is Nothing Then
      _match.MatchPeriods.EndPeriod(Me.Period)
    End If
  End Sub

  Private Sub _period_ActiveStateChanged(sender As Period) Handles _period.ActiveStateChanged
    UpdateInterface()
  End Sub

  Private Sub _period_SelectedStateChanged(sender As Period) Handles _period.SelectedStateChanged
    UpdateInterface()
  End Sub

  Private Sub UpdateInterface()
    Try
      If _period Is Nothing Then
        Me.MetroTilePeriodName.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Light
        Me.MetroTilePeriodName.Style = MetroFramework.MetroColorStyle.Black
        Me.BackColor = Color.White
      Else
        If _period.IsSelected Then
          Me.MetroTilePeriodName.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold
          Me.MetroTilePeriodName.Style = MetroFramework.MetroColorStyle.Default
          Me.BackColor = Color.LightGray
        Else
          Me.MetroTilePeriodName.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Light
          Me.MetroTilePeriodName.Style = MetroFramework.MetroColorStyle.Black
          Me.BackColor = Color.White
        End If

      End If

    Catch ex As Exception

    End Try

  End Sub

End Class
