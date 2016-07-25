Imports System.Data.OleDb

Public Class MatchEvent
  Implements IComparable

  Public Property EventID As Integer = 0
  Public Property MatchID As Integer = 0
  Public Property TeamID As Integer = 0
  Public Property PlayerID As Integer = 0
  Public Property PlayerSecID As Integer = 0
  Public Property EventType As String = ""
  Public Property TimeSecond As Integer = 0

  Public Sub New()
    EventID = -1
    MatchID = -1
    TeamID = -1
    TimeSecond = -1
    PlayerID = -1
    EventType = ""
  End Sub

  Public Sub New(id As Integer)
    EventID = id
    MatchID = -1
    TeamID = -1
    TimeSecond = -1
    PlayerID = -1
    EventType = ""
  End Sub

  Private Function [Get]() As Boolean
    Return [Get]("WHERE EventID=" & EventID.ToString())
  End Function
  Private Function [Get](Where As String) As Boolean
    Try
      Dim myDatabase As New MatchEvents()
      myDatabase.GetFromDB(Where)
      If myDatabase.Count = 0 Then
        Return False
      End If

      Copy(DirectCast(myDatabase(0), MatchEvent))
    Catch err As Exception
      Throw err
    End Try
    Return True
  End Function

  Public Sub Copy(Source As MatchEvent)
    Try
      EventID = Source.EventID
      MatchID = Source.MatchID
      TeamID = Source.TeamID
      TimeSecond = Source.TimeSecond
      PlayerID = Source.PlayerID
      EventType = Source.EventType
    Catch err As Exception
      Throw err
    End Try
  End Sub


  Public Sub Delete()
    Dim conn As New OleDbConnection(Config.Instance.LocalConnectionString)
    conn.Open()
    Dim SQL As String = "DELETE FROM MatchEvents WHERE EventID = " & EventID.ToString()
    Dim myCmd As New OleDbCommand(SQL, conn)
    myCmd.ExecuteNonQuery()
    conn.Close()
  End Sub

  Public Sub Update()
    Try

      Dim ActualDb As New MatchEvent(EventID)
      If EventID <> -1 AndAlso ActualDb.[Get]() Then
        'UPDATE
        Dim myCommand As New OleDbCommand()
        Dim SQL As String = ""
        If ActualDb.MatchID <> MatchID AndAlso MatchID <> -1 Then
          SQL += " [MatchID]=" & MatchID.ToString() & ","
        End If
        If ActualDb.TeamID <> TeamID AndAlso TeamID <> -1 Then
          SQL += " [TeamID]=" & TeamID.ToString() & ","
        End If
        If ActualDb.TimeSecond <> TimeSecond AndAlso TimeSecond <> -1 Then
          SQL += " [TimeSecond]=" & TimeSecond.ToString() & ","
        End If
        If ActualDb.PlayerID <> PlayerID AndAlso PlayerID <> -1 Then
          SQL += " [PlayerID]=" & PlayerID.ToString() & ","
        End If
        If ActualDb.EventType <> EventType Then
          SQL += " [EventType]=" & EventType.ToString() & ","
        End If
        If SQL <> "" Then
          Dim conn As New OleDbConnection(Config.Instance.LocalConnectionString)
          conn.Open()
          myCommand.Connection = conn
          SQL = SQL.Substring(0, SQL.Length - 1)
          SQL = (Convert.ToString("UPDATE MatchEvents SET") & SQL) & " WHERE EventID = " & EventID.ToString()
          myCommand.CommandText = SQL
          myCommand.ExecuteNonQuery()
          conn.Close()
        End If
      Else
        Dim SQL As String = "INSERT INTO MatchEvents ([MatchID],  [TeamID], [TimeSecond], [PlayerID], [PlayerSecID], [EventType])"
        SQL += " VALUES (" & MatchID.ToString() & ", " & TeamID.ToString() & ", " & TimeSecond.ToString() & ", " & PlayerID.ToString() & ", " & PlayerSecID.ToString() & ", '" & EventType & "')"
        Dim myCmd As New OleDbCommand(SQL, Config.Instance.OledbConnection)
        myCmd.ExecuteNonQuery()

        Dim GetID As New OleDbCommand("SELECT MAX(EventID) FROM MatchEvents", Config.Instance.OledbConnection)
        GetID.CommandType = System.Data.CommandType.Text
        Dim myReader As OleDbDataReader = GetID.ExecuteReader()
        If myReader.Read() Then
          EventID = myReader.GetInt32(0)
        End If
      End If
    Catch err As Exception
      Throw err
    End Try
  End Sub

  Public Function CompareTo(obj As Object) As Integer Implements IComparable.CompareTo
    Dim res As Integer = 0
    Try
      Dim aux As MatchEvent = CType(obj, MatchEvent)
      If aux.TimeSecond > Me.TimeSecond Then
          Return 1
        ElseIf aux.TimeSecond < Me.TimeSecond Then
          Return -1
        Else
          Return 0
        End If
      Catch ex As Exception

      End Try
      Return res
    End Function

  End Class
