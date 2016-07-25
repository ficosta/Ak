
Imports System.Data.OleDb

Public Class MatchEvents
  Inherits CollectionBase

  Public Event EventAdded(sender As MatchEvents, [event] As MatchEvent)
  Public Event EventRemoved(sender As MatchEvents, [event] As MatchEvent)

  Public Property UpToDate As Boolean = False

  Public Sub New()
    UpToDate = False
  End Sub

  Public Sub GetMatchEvents(Match_ID As Integer)
    GetFromDB("WHERE MatchID=" & Match_ID.ToString())
  End Sub

  Public Sub GetMatchEvents(Match_ID As Integer, team_ID As Integer)
    GetFromDB("WHERE MatchID=" & Match_ID.ToString() & " AND EventID=" & team_ID.ToString)
  End Sub


  Public Shared Sub DeleteMatchEvents(Match_ID As Integer)
    Dim conn As New OleDbConnection(Config.Instance.LocalConnectionString)
    conn.Open()
    Dim myCmd As New OleDbCommand("DELETE FROM MatchEvents WHERE MatchID = " & Match_ID.ToString(), conn)
    myCmd.ExecuteNonQuery()
    conn.Close()
  End Sub

  Public Shared Sub DeleteMatchEvent(Event_ID As Integer)
    Dim conn As New OleDbConnection(Config.Instance.LocalConnectionString)
    conn.Open()
    Dim myCmd As New OleDbCommand("DELETE FROM MatchEvents WHERE EventID = " & Event_ID.ToString(), conn)
    myCmd.ExecuteNonQuery()
    conn.Close()
  End Sub

  Public Function Add(match_id As Integer, type As String, teamID As Integer, playerID As Integer, timeSeconds As Integer, Optional playerSecID As Integer = -1) As MatchEvent
    Dim myEvent As New MatchEvent()
    Try
      myEvent.MatchID = match_id
      myEvent.EventType = type
      myEvent.TeamID = teamID
      myEvent.PlayerID = playerID
      myEvent.TimeSecond = timeSeconds
      myEvent.PlayerSecID = playerSecID
      Me.Add(myEvent)

    Catch ex As Exception
      Debug.Print(ex.ToString)
    End Try
    Return myEvent
  End Function

  Public Sub RemoveEvent(match_id As Integer, type As String, teamID As Integer, playerID As Integer, Optional timeSeconds As Integer = -1, Optional playerSecID As Integer = -1)
    For i As Integer = Me.Count - 1 To 0 Step -1
      Dim myEvent As MatchEvent = Me.Item(i)
      If myEvent.MatchID = match_id And myEvent.EventType = type And
            myEvent.TeamID = teamID And
            myEvent.PlayerID = playerID And
            (myEvent.TimeSecond = timeSeconds Or timeSeconds = -1) And
            (myEvent.PlayerSecID = playerSecID Or timeSeconds = -1) Then
        Me.RemoveAt(i)
      End If
    Next
  End Sub

  Public Sub Add(NewEvent As MatchEvent)
    NewEvent.Update()
    List.Add(NewEvent)
    RaiseEvent EventAdded(Me, NewEvent)
  End Sub


  Public Function RemoveEvent(id As Integer) As Boolean
    Dim res As Boolean = False
    Try
      For i As Integer = Me.InnerList.Count - 1 To 0 Step -1
        Dim myEvent As MatchEvent = CType(Me.InnerList(i), MatchEvent)
        If myEvent.EventID = id Then
          Me.InnerList.RemoveAt(i)
          MatchEvents.DeleteMatchEvent(id)
          RaiseEvent EventRemoved(Me, myEvent)
          res = True
        End If
      Next
    Catch ex As Exception

    End Try
    Return res
  End Function

  Public Function RemoveEvent(DeleteEvent As MatchEvent) As Boolean
    Try
      Return RemoveEvent(DeleteEvent.EventID)
    Catch ex As Exception
      Return False
    End Try
  End Function


  Public Sub GetFromDB(match_id As Integer)
    Me.GetFromDB("WHERE MatchID = " & match_id)
  End Sub

  Public Sub GetFromDB(Where As String)
    Try
      List.Clear()

      'Dim conn As New OleDbConnection(Config.Instance.LocalConnectionString)
      'conn.Open()

      Dim SQL As [String] = "SELECT EventID, MatchID, EventID, TimeSecond, PlayerID, EventType, PlayerSecID"
      SQL += " FROM MatchEvents "
      SQL += Where.Trim()
      Dim CmdSQL As New OleDbCommand(SQL, Config.Instance.OledbConnection)

      CmdSQL.CommandType = System.Data.CommandType.Text
      Dim myReader As OleDbDataReader = CmdSQL.ExecuteReader()
      While myReader.Read()
        Dim NewItem As New MatchEvent(myReader.GetInt32(0))
        If Not myReader.IsDBNull(1) Then
          NewItem.MatchID = myReader.GetInt32(1)
        End If
        If Not myReader.IsDBNull(2) Then
          NewItem.EventID = myReader.GetInt32(2)
        End If
        If Not myReader.IsDBNull(3) Then
          NewItem.TimeSecond = myReader.GetInt32(3)
        End If
        If Not myReader.IsDBNull(4) Then
          NewItem.PlayerID = myReader.GetInt32(4)
        End If
        If Not myReader.IsDBNull(5) Then
          NewItem.EventType = myReader.GetString(5)
        End If
        If Not myReader.IsDBNull(6) Then
          NewItem.PlayerSecID = myReader.GetInt32(6)
        End If
        List.Add(NewItem)
      End While
      'conn.Close()
      UpToDate = True
    Catch err As Exception
      Throw err
    End Try
  End Sub

  Default Public Property Item(Index As Integer) As MatchEvent
    Get
      Return DirectCast(List(Index), MatchEvent)
    End Get
    Set
      List(Index) = Value
    End Set
  End Property

  Public Sub Sort()
    Me.InnerList.Sort()
  End Sub

  Public Function GetEvent(eventID As Integer) As MatchEvent
    Dim output As MatchEvent = Nothing
    Try
      For Each Search As MatchEvent In List
        If Search.EventID = eventID Then
          output = Search
          Exit For
        End If
      Next
    Catch err As Exception
      Throw err
    End Try
    Return (output)
  End Function

  Public Function GetEventsByTeam(team As Team) As List(Of MatchEvent)
    Dim output As New List(Of MatchEvent)
    Try
      If Not team Is Nothing Then
        For Each Search As MatchEvent In List
          If Search.TeamID = team.ID Then
            output.Add(Search)
          End If
        Next
      End If
    Catch err As Exception
      Throw err
    End Try
    Return (output)
  End Function

  Public Function GetEventsByPlayer(player As Player) As List(Of MatchEvent)
    Dim output As New List(Of MatchEvent)
    Try
      If Not player Is Nothing Then
        For Each Search As MatchEvent In List
          If Search.PlayerID = player.ID Then
            output.Add(Search)
          End If
        Next
      End If
    Catch err As Exception
      Throw err
    End Try
    Return (output)
  End Function

  Public Function GetEventsByPlayer(player As Player, stat As Stat) As List(Of MatchEvent)
    Dim output As New List(Of MatchEvent)
    Try
      If Not player Is Nothing Then
        output = GetEventsByPlayer(player.ID, stat.Name)
      End If
    Catch err As Exception
      Throw err
    End Try
    Return (output)
  End Function

  Public Function GetEventsByPlayer(playerId As Integer, statName As String) As List(Of MatchEvent)
    Dim output As New List(Of MatchEvent)
    Try
      For Each Search As MatchEvent In List
        If Search.PlayerID = playerId And Search.EventType = statName Then
          output.Add(Search)
        End If
      Next
    Catch err As Exception
      Throw err
    End Try
    Return (output)
  End Function

  Public Function GetEventsByTeam(teamId As Integer, statName As String) As List(Of MatchEvent)
    Dim output As New List(Of MatchEvent)
    Try
      For Each Search As MatchEvent In List
        If Search.TeamID = teamId And Search.EventType = statName Then
          output.Add(Search)
        End If
      Next
    Catch err As Exception
      Throw err
    End Try
    Return (output)
  End Function
End Class