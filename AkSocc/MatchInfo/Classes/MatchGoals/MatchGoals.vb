
Imports System.Data.OleDb

Public Class MatchGoals
  Inherits CollectionBase

  Public Sub New()
  End Sub

  Public Sub GetMatchGoals(Match_ID As Integer)
    GetFromDB("WHERE MatchID=" & Match_ID.ToString())
  End Sub

  Public Sub GetMatchGoals(Match_ID As Integer, team_ID As Integer)
    GetFromDB("WHERE MatchID=" & Match_ID.ToString() & " AND TeamGoalID=" & team_ID.ToString)
  End Sub


  Public Shared Sub DeleteMatchGoals(Match_ID As Integer)
    Dim conn As New OleDbConnection(Config.Instance.LocalConnectionString)
    conn.Open()
    Dim myCmd As New OleDbCommand("DELETE FROM MatchGoals WHERE MatchID = " & Match_ID.ToString(), conn)
    myCmd.ExecuteNonQuery()
    conn.Close()
  End Sub

  Public Shared Sub DeleteMatchGoal(Goal_ID As Integer)
    Dim conn As New OleDbConnection(Config.Instance.LocalConnectionString)
    conn.Open()
    Dim myCmd As New OleDbCommand("DELETE FROM MatchGoals WHERE GoalID = " & Goal_ID.ToString(), conn)
    myCmd.ExecuteNonQuery()
    conn.Close()
  End Sub

  Public Sub Add(NewGoal As MatchGoal)
    NewGoal.Update()
    List.Add(NewGoal)
  End Sub

  Public Function RemoveGoal(id As Integer) As Boolean
    Dim res As Boolean = False
    Try
      For i As Integer = Me.InnerList.Count - 1 To 0 Step -1
        If CType(Me.InnerList(i), MatchGoal).GoalID = id Then
          Me.InnerList.RemoveAt(i)
          MatchGoals.DeleteMatchGoal(id)
          res = True
        End If
      Next
    Catch ex As Exception

    End Try
    Return res
  End Function

  Public Function RemoveGoal(DeleteGoal As MatchGoal) As Boolean
    Try
      Return RemoveGoal(DeleteGoal.GoalID)
    Catch ex As Exception
      Return False
    End Try
  End Function

  Public Sub GetFromDB(Where As String)
    Try
      List.Clear()
      Dim conn As New OleDbConnection(Config.Instance.LocalConnectionString)
      conn.Open()

      Dim SQL As [String] = "SELECT GoalID, MatchID, TeamGoalID, Minute, PlayerID, Penalty, OwnGoal"
      SQL += " FROM MatchGoals "
      SQL += Where.Trim()
      Dim CmdSQL As New OleDbCommand(SQL, conn)

      CmdSQL.CommandType = System.Data.CommandType.Text
      Dim myReader As OleDbDataReader = CmdSQL.ExecuteReader()
      While myReader.Read()
        Dim NewItem As New MatchGoal(myReader.GetInt32(0))
        If Not myReader.IsDBNull(1) Then
          NewItem.MatchID = myReader.GetInt32(1)
        End If
        If Not myReader.IsDBNull(2) Then
          NewItem.TeamGoalID = myReader.GetInt32(2)
        End If
        If Not myReader.IsDBNull(3) Then
          NewItem.Minute = myReader.GetInt32(3)
        End If
        If Not myReader.IsDBNull(4) Then
          NewItem.PlayerID = myReader.GetInt32(4)
        End If
        If Not myReader.IsDBNull(5) Then
          NewItem.Penalty = myReader.GetBoolean(5)
        End If
        If Not myReader.IsDBNull(6) Then
          NewItem.OwnGoal = myReader.GetBoolean(5)
        End If
        List.Add(NewItem)
      End While
      conn.Close()
    Catch err As Exception
      Throw err
    End Try
  End Sub

  Default Public Property Item(Index As Integer) As MatchGoal
    Get
      Return DirectCast(List(Index), MatchGoal)
    End Get
    Set
      List(Index) = Value
    End Set
  End Property

  Public Sub Sort()
    Me.InnerList.Sort()
  End Sub

  Public Function GetGoal(local_ID As Integer) As MatchGoal
    Dim output As MatchGoal = Nothing
    Try
      For Each Search As MatchGoal In List
        If Search.GoalID = local_ID Then
          output = Search
          Exit For
        End If
      Next
    Catch err As Exception
      Throw err
    End Try
    Return (output)
  End Function

  Public Function GetGoalsByPlayer(player As Player) As List(Of MatchGoal)
    Dim output As New List(Of MatchGoal)
    Try
      If Not player Is Nothing Then
        For Each Search As MatchGoal In List
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
End Class