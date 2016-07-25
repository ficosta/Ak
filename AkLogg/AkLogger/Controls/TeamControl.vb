Imports AkLogger
Imports MatchInfo

Public Class TeamControl
  Private WithEvents _team As Team
  Public Property Team As Team
    Get
      Return _team
    End Get
    Set(value As Team)
      _team = value
      InitTeam()
    End Set
  End Property

  Private _statControls As New List(Of SingleSubjectControl)

  Public Sub New()

    ' This call is required by the designer.
    InitializeComponent()

    ' Add any initialization after the InitializeComponent() call.
    _statControls.Add(Me.SingleSubjectControlTeam)

    _statControls.Add(Me.SingleSubjectControl1)
    _statControls.Add(Me.SingleSubjectControl2)
    _statControls.Add(Me.SingleSubjectControl3)
    _statControls.Add(Me.SingleSubjectControl4)
    _statControls.Add(Me.SingleSubjectControl5)
    _statControls.Add(Me.SingleSubjectControl6)
    _statControls.Add(Me.SingleSubjectControl7)
    _statControls.Add(Me.SingleSubjectControl8)
    _statControls.Add(Me.SingleSubjectControl9)
    _statControls.Add(Me.SingleSubjectControl10)
    _statControls.Add(Me.SingleSubjectControl11)
    _statControls.Add(Me.SingleSubjectControl12)
    _statControls.Add(Me.SingleSubjectControl13)
    _statControls.Add(Me.SingleSubjectControl14)
    _statControls.Add(Me.SingleSubjectControl15)
    _statControls.Add(Me.SingleSubjectControl16)
    _statControls.Add(Me.SingleSubjectControl17)
    _statControls.Add(Me.SingleSubjectControl18)

    For Each ctl As SingleSubjectControl In _statControls
      AddHandler ctl.AddEvent, AddressOf Me.SingleSubjectControl1_AddEvent
      AddHandler ctl.RemoveEvent, AddressOf Me.SingleSubjectControl1_RemoveEvent
    Next

  End Sub


#Region "Functions"
  Private Sub InitTeam()
    If Me.InvokeRequired Then
      Me.Invoke(New MethodInvoker(AddressOf InitTeam))
    Else
      Try
        Me.SingleSubjectControlTeam.StatSubject = Me.Team
        If Not Me.Team Is Nothing Then
          For i As Integer = 1 To 18
            _statControls(i).StatSubject = Me.Team.GetPlayerByPosicio(i)
          Next
        End If
      Catch ex As Exception
      End Try
    End If
  End Sub

  Private Sub SingleSubjectControl1_AddEvent(sender As SingleSubjectControl, stat As Stat)
    'MatchHelper.Instance.Match.MatchEvents.Add(stat.Name, Me.Team.ID, sender.StatSubject.ID, 0, 0)
    Try
      Select Case sender.StatSubject.GetType().ToString
        Case "MatchInfo.Team"
          MatchHelper.Instance.Match.AddEvent(stat.Name, Me.Team.TeamID, 0, 0, 0)
        Case "MatchInfo.Player"
          Dim player As Player = CType(sender.StatSubject, Player)
          MatchHelper.Instance.Match.AddEvent(stat.Name, Me.Team.TeamID, player.PlayerID, 0, 0)
      End Select
    Catch ex As Exception

    End Try

  End Sub

  Private Sub SingleSubjectControl1_RemoveEvent(sender As SingleSubjectControl, stat As Stat)
    MatchHelper.Instance.Match.MatchEvents.RemoveEvent(stat.Name, Me.Team.ID, sender.StatSubject.ID, 0, 0)
  End Sub
#End Region


End Class
