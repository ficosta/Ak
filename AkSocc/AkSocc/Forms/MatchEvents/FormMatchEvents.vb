Imports MatchInfo

Public Class FormMatchEvents
  Private WithEvents _match As Match
  Public Property Match As Match
    Get
      Return _match
    End Get
    Set(value As Match)
      _match = value
      ShowEvents()
    End Set
  End Property

  Private Sub ShowEvents()
    Try
      Me.MetroGridEvents.Rows.Clear()

      For Each myEvent As MatchEvent In _match.MatchEvents
        Me.AddEvent(myEvent)
      Next
    Catch ex As Exception

    End Try
  End Sub

  Private Sub FormMatchEvents_Load(sender As Object, e As EventArgs) Handles MyBase.Load

  End Sub


  Private Sub AddEvent(myEvent As MatchEvent)
    Try
      If _match Is Nothing Then Exit Sub

      Dim localTeam As Boolean = (myEvent.TeamID = _match.HomeTeam.TeamID)
      Dim playerName As String = ""
      If Not _match.GetPlayerById(myEvent.PlayerID) Is Nothing Then
        playerName = _match.GetPlayerById(myEvent.PlayerID).ToString
      End If
      If Not _match.GetPlayerById(myEvent.PlayerSecID) Is Nothing Then
        playerName = playerName & " for " & _match.GetPlayerById(myEvent.PlayerSecID).ToString
      End If
      Me.AddEvent(myEvent, localTeam, playerName)
    Catch ex As Exception

    End Try
  End Sub

  Private Sub AddEvent(myEvent As MatchEvent, LocalTeam As Boolean, EventPlayer As String)
    Try

      'Dim item As Integer = Me.MetroGridEvents.Rows.Add(myEvent.EventID.ToString)
      Dim item As Integer = 0
      Me.MetroGridEvents.Rows.Insert(0, 1)
      Me.MetroGridEvents.Rows(item).Cells(ColumnID.Index).Value = myEvent.EventID
      Dim TextToAdd As String = myEvent.EventType
      If myEvent.EventType = "RCARD" Then
        TextToAdd = "RED CARD"
      ElseIf myEvent.EventType = "YCARD" Then
        TextToAdd = "YELLOW CARD"
      ElseIf myEvent.EventType = "SHTGL" Then
        TextToAdd = "SHOT ON TARGET"
      End If
      Me.MetroGridEvents.Rows(item).Cells(ColumnType.Index).Value = TextToAdd

      Dim strText As String
      If LocalTeam Then
        strText = _match.HomeTeam.TeamAELCaption1Name ' lblHomeTeam1.Text
      Else
        strText = _match.AwayTeam.TeamAELCaption1Name 'lblAwayTeam1.Text
      End If

      If EventPlayer <> "" Then
        strText &= Convert.ToString(" player ") & EventPlayer
      End If
      Me.MetroGridEvents.Rows(item).Cells(ColumnPlayer.Index).Value = strText
      Me.MetroGridEvents.Rows(item).Cells(ColumnTime.Index).Value = myEvent.TimeSecond \ 60 & ":" & Strings.Format(myEvent.TimeSecond Mod 60)

      Me.MetroGridEvents.Rows(item).Cells(ColumnImage.Index).Value = Me.imglstEvents.Images(myEvent.EventType.ToUpper)

    Catch ex As Exception
      WriteToErrorLog(ex)
    End Try
  End Sub

  Private Sub _match_EventCreated(myEvent As MatchEvent) Handles _match.EventCreated
    Me.AddEvent(myEvent)
  End Sub

  Private Sub _match_EventRemoved(myEvent As MatchEvent) Handles _match.EventRemoved
    Me.ShowEvents()
  End Sub
End Class