Imports MatchInfo

Public Class FormPeriodControl

  Private WithEvents _match As MatchInfo.Match
  Public Property Match As MatchInfo.Match
    Get
      Return _match
    End Get
    Set(value As MatchInfo.Match)
      _match = value
      InitPeriod(_match, 1)
    End Set
  End Property

  Public Sub InitPeriod(match As MatchInfo.Match, part As Integer)
    Try
      _match = match
      Me.UcPeriod1.InitPeriod(_match, 1)
      Me.UcPeriod2.InitPeriod(_match, 2)
      Me.UcPeriod3.InitPeriod(_match, 3)
      Me.UcPeriod4.InitPeriod(_match, 4)
    Catch ex As Exception

    End Try
  End Sub

  Private Sub FormPeriodControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load

  End Sub

  Private Sub MetroButtonOverwriteClock_Click(sender As Object, e As EventArgs) Handles MetroButtonOverwriteClock.Click
    Dim dlg As New FormOvewriteClock()
    Try
      If _match Is Nothing Then Exit Sub
      If _match.MatchPeriods.ActivePeriod Is Nothing Then Exit Sub
      dlg.Minutes = _match.MatchPeriods.ActivePeriod.PlayingTime \ 60
      dlg.Seconds = _match.MatchPeriods.ActivePeriod.PlayingTime Mod 60
      If dlg.ShowDialog(Me) Then
        Dim newTime As Integer = dlg.Minutes * 60 + dlg.Seconds

        _match.MatchPeriods.setPlayingTime(newTime)

      End If
    Catch ex As Exception
      WriteToErrorLog(ex)
    End Try
  End Sub
End Class