Imports System.ComponentModel
Imports MatchInfo

Public Class SingleStatControl
  Public Event AddEvent(sender As SingleStatControl)
  Public Event RemoveEvent(sender As SingleStatControl)


  Private WithEvents _stat As MatchInfo.Stat
  Public Property Stat As MatchInfo.Stat
    Get
      Return _stat
    End Get
    Set(value As MatchInfo.Stat)
      _stat = value
      ShowStat()
    End Set
  End Property

  Private WithEvents _statSubject As MatchInfo.StatSubject
  Public Property StatSubject As MatchInfo.StatSubject
    Get
      Return _statSubject
    End Get
    Set(value As MatchInfo.StatSubject)
      _statSubject = value
      ShowStat()
    End Set
  End Property

  Public Sub Init(stat As Stat, statSubject As StatSubject)
    Try
      _stat = stat
      _statSubject = statSubject
      Me.ShowStat()
    Catch ex As Exception

    End Try
  End Sub

  Private Sub _stat_PropertyChanged(sender As Object, e As PropertyChangedEventArgs) Handles _stat.PropertyChanged

  End Sub

  Private Sub _stat_StatValueChanged(sender As Stat) Handles _stat.StatValueChanged
    ShowStat()
  End Sub

  Private Sub ShowStat()
    If Me.InvokeRequired Then
      Me.Invoke(New MethodInvoker(AddressOf ShowStat))
    Else
      Try
        If _stat Is Nothing Then
          Me.ButtonStat.Text = "-"
        Else
          Me.ButtonStat.Text = _stat.ValueText
        End If
      Catch ex As Exception

      End Try
    End If

  End Sub

  Private Sub ButtonStat_Click(sender As Object, e As EventArgs) Handles ButtonStat.Click
    Try
      If _stat Is Nothing Then Exit Sub
      If Control.ModifierKeys = Keys.Control Then
        '_stat.Value = Math.Max(_stat.Value - 1, 0)
        RaiseEvent RemoveEvent(Me)
      Else
        '_stat.Value += 1
        RaiseEvent AddEvent(Me)
      End If

    Catch ex As Exception

    End Try
  End Sub
End Class
