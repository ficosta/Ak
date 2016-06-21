﻿
Imports System.Data.OleDb

Public Class MatchGoal
  Public GoalID As Integer
  Public MatchID As Integer
  Public TeamGoalID As Integer
  Public Minute As Integer
  Public PlayerID As Integer
  Public Penalty As Boolean
  Public OwnGoal As Boolean

  Public Sub New()
    GoalID = -1
    MatchID = -1
    TeamGoalID = -1
    Minute = -1
    PlayerID = -1
    Penalty = False
    OwnGoal = False
  End Sub

  Public Sub New(Goal As Integer)
    GoalID = Goal
    MatchID = -1
    TeamGoalID = -1
    Minute = -1
    PlayerID = -1
    Penalty = False
    OwnGoal = False
  End Sub

  Private Function [Get]() As Boolean
    Return [Get]("WHERE GoalID=" + GoalID.ToString())
  End Function
  Private Function [Get](Where As String) As Boolean
    Try
      Dim myDatabase As New MatchGoals()
      myDatabase.GetFromDB(Where)
      If myDatabase.Count = 0 Then
        Return False
      End If

      Copy(DirectCast(myDatabase(0), MatchGoal))
    Catch err As Exception
      Throw err
    End Try
    Return True
  End Function

  Public Sub Copy(Source As MatchGoal)
    Try
      GoalID = Source.GoalID
      MatchID = Source.MatchID
      TeamGoalID = Source.TeamGoalID
      Minute = Source.Minute
      PlayerID = Source.PlayerID
      Penalty = Source.Penalty
      OwnGoal = Source.OwnGoal
    Catch err As Exception
      Throw err
    End Try
  End Sub


  Public Sub Delete()
    Dim conn As New OleDbConnection(Config.Instance.LocalConnectionString)
    conn.Open()
    Dim SQL As String = "DELETE FROM MatchGoals WHERE GoalID = " + GoalID.ToString()
    Dim myCmd As New OleDbCommand(SQL, conn)
    myCmd.ExecuteNonQuery()
    conn.Close()
  End Sub

  Public Sub Update()
    Try
      Dim ActualDb As New MatchGoal(GoalID)
      If ActualDb.[Get]() Then
        'UPDATE
        Dim myCommand As New OleDbCommand()
        Dim SQL As String = ""
        If ActualDb.MatchID <> MatchID AndAlso MatchID <> -1 Then
          SQL += " [MatchID]=" + MatchID.ToString() + ","
        End If
        If ActualDb.TeamGoalID <> TeamGoalID AndAlso TeamGoalID <> -1 Then
          SQL += " [TeamGoalID]=" + TeamGoalID.ToString() + ","
        End If
        If ActualDb.Minute <> Minute AndAlso Minute <> -1 Then
          SQL += " [Minute]=" + Minute.ToString() + ","
        End If
        If ActualDb.PlayerID <> PlayerID AndAlso PlayerID <> -1 Then
          SQL += " [PlayerID]=" + PlayerID.ToString() + ","
        End If
        If ActualDb.Penalty <> Penalty Then
          SQL += " [Penalty]=" + Penalty.ToString() + ","
        End If
        If ActualDb.OwnGoal <> OwnGoal Then
          SQL += " [OwnGoal]=" + OwnGoal.ToString() + ","
        End If
        If SQL <> "" Then
          Dim conn As New OleDbConnection(Config.Instance.LocalConnectionString)
          conn.Open()
          myCommand.Connection = conn
          SQL = SQL.Substring(0, SQL.Length - 1)
          SQL = (Convert.ToString("UPDATE MatchGoals SET") & SQL) + " WHERE GoalID = " + GoalID.ToString()
          myCommand.CommandText = SQL
          myCommand.ExecuteNonQuery()
          conn.Close()
        End If
      Else
        Dim conn As New OleDbConnection(Config.Instance.LocalConnectionString)
        conn.Open()
        Dim SQL As String = "INSERT INTO MatchGoals ([MatchID], [TeamGoalID], [Minute], [PlayerID], [Penalty], [OwnGoal])"
        SQL += " VALUES (" + MatchID.ToString() + ", " + TeamGoalID.ToString() + ", " + Minute.ToString() + ", " + PlayerID.ToString() + ", " + (If(Penalty, "1", "0")) + ", " + (If(OwnGoal, "1", "0")) + ")"
        Dim myCmd As New OleDbCommand(SQL, conn)
        myCmd.ExecuteNonQuery()

        Dim GetID As New OleDbCommand("SELECT MAX(GoalID) FROM MatchGoals", conn)
        GetID.CommandType = System.Data.CommandType.Text
        Dim myReader As OleDbDataReader = GetID.ExecuteReader()
        If myReader.Read() Then
          GoalID = myReader.GetInt32(0)
        End If
        conn.Close()
      End If
    Catch err As Exception
      Throw err
    End Try
  End Sub
End Class