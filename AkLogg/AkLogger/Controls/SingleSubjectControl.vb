Public Class SingleSubjectControl
  Public Event AddEvent(sender As SingleSubjectControl, stat As MatchInfo.Stat)
  Public Event RemoveEvent(sender As SingleSubjectControl, stat As MatchInfo.Stat)

  Private WithEvents _StatSubject As MatchInfo.StatSubject
  Public Property StatSubject As MatchInfo.StatSubject
    Get
      Return _StatSubject
    End Get
    Set(value As MatchInfo.StatSubject)
      _StatSubject = value
      ShowStatSubject()
    End Set
  End Property

  Private Sub ShowStatSubject()
    Try
      If _StatSubject Is Nothing Then
        Me.LabelSubjectName.Text = ""
        Me.SingleStatControlSaves.Stat = Nothing
        Me.SingleStatControlShots.Stat = Nothing
        Me.SingleStatControlShotsOn.Stat = Nothing
        Me.SingleStatControlFouls.Stat = Nothing
        Me.SingleStatControlYCards.Stat = Nothing
        Me.SingleStatControlRCards.Stat = Nothing
        Me.SingleStatControlAssists.Stat = Nothing
      Else
        Me.LabelSubjectName.Text = Me.StatSubject.Name
        Me.SingleStatControlSaves.Stat = Me.StatSubject.MatchStats.Saves
        Me.SingleStatControlShots.Stat = Me.StatSubject.MatchStats.Shots
        Me.SingleStatControlShotsOn.Stat = Me.StatSubject.MatchStats.ShotsOn
        Me.SingleStatControlFouls.Stat = Me.StatSubject.MatchStats.Fouls
        Me.SingleStatControlYCards.Stat = Me.StatSubject.MatchStats.YellowCards
        Me.SingleStatControlRCards.Stat = Me.StatSubject.MatchStats.RedCards
        Me.SingleStatControlAssists.Stat = Me.StatSubject.MatchStats.Assis
      End If
    Catch ex As Exception

    End Try
  End Sub

  Private Sub SingleStatControlSaves_AddEvent(sender As SingleStatControl) Handles SingleStatControlSaves.AddEvent,
       SingleStatControlShots.AddEvent,
         SingleStatControlShotsOn.AddEvent,
          SingleStatControlFouls.AddEvent,
           SingleStatControlYCards.AddEvent,
            SingleStatControlRCards.AddEvent,
            SingleStatControlAssists.AddEvent
    RaiseEvent AddEvent(Me, sender.Stat)
  End Sub

  Private Sub SingleStatControlSaves_RemoveEvent(sender As SingleStatControl) Handles SingleStatControlSaves.RemoveEvent
    RaiseEvent RemoveEvent(Me, sender.Stat)
  End Sub

#Region "Mouse over controls"
  Private Sub SingleStatControlSaves_MouseEnter(sender As Object, e As EventArgs) Handles LabelSubjectName.MouseEnter,
      SingleStatControlAssists.MouseEnter,
      SingleStatControlShots.MouseEnter,
      SingleStatControlShotsOn.MouseEnter,
      SingleStatControlFouls.MouseEnter,
      SingleStatControlYCards.MouseEnter,
      SingleStatControlRCards.MouseEnter,
      SingleStatControlSaves.MouseEnter

    UpdateInterface(True)
  End Sub

  Private Sub SingleStatControlSaves_MouseLeave(sender As Object, e As EventArgs) Handles LabelSubjectName.MouseLeave,
      SingleStatControlAssists.MouseLeave,
      SingleStatControlShots.MouseLeave,
      SingleStatControlShotsOn.MouseLeave,
      SingleStatControlFouls.MouseLeave,
      SingleStatControlYCards.MouseLeave,
      SingleStatControlRCards.MouseLeave,
      SingleStatControlSaves.MouseLeave

    UpdateInterface(False)
  End Sub

  Private Sub UpdateInterface(biMouseOver As Boolean)
    Try
      Dim color As Color = IIf(biMouseOver, Color.Red, Color.Black)
      Me.LabelSubjectName.ForeColor = color
      Me.SingleStatControlSaves.ForeColor = color
      Me.SingleStatControlAssists.ForeColor = color
      Me.SingleStatControlShots.ForeColor = color
      Me.SingleStatControlShotsOn.ForeColor = color
      Me.SingleStatControlFouls.ForeColor = color
      Me.SingleStatControlYCards.ForeColor = color
      Me.SingleStatControlRCards.ForeColor = color
    Catch ex As Exception

    End Try
  End Sub

#End Region

End Class
