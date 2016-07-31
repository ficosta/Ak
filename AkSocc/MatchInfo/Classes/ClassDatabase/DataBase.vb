Imports System.Data.OleDb

Public Class DataBase

  Public Shared Function CreateTables() As Boolean


    Try
      Dim conn As New OleDbConnection(Config.Instance.LocalConnectionString)
      conn.Open()

      Try
        Dim SQL As String = "CREATE TABLE PlayerStats (PlayerID INTEGER, MatchID INTEGER, Shots INTEGER, Shots_on_target INTEGER, Saves INTEGER, Fouls INTEGER, YCard INTEGER, RCard INTEGER, Assis INTEGER, Formation_pos INTEGER, Formation_x INTEGER, Formation_y INTEGER, Substituion INTEGER, CONSTRAINT pk_PlayerStats PRIMARY KEY (PlayerID, MatchID))"
        Dim myCommand As New OleDbCommand(SQL, conn)
        myCommand.ExecuteNonQuery()

      Catch ex As Exception
        Debug.Print(ex.ToString)
      End Try

      Try
        Dim SQL2 As String = "CREATE TABLE TeamMatchStats (TeamID INTEGER, MatchID INTEGER, Shots INTEGER, Saves INTEGER, Fouls INTEGER, YCard INTEGER, RCard INTEGER, Assis INTEGER, Shots_on_target INTEGER, corners INTEGER, offsides INTEGER, wood_hits INTEGER, PossessionMatch INTEGER, Possession1st INTEGER, Possession2nd INTEGER, PossessionLast5 INTEGER, PossessionLast10 INTEGER, PossessionOwn INTEGER, PossessionMid INTEGER, PossessionAttack INTEGER, FormID INTEGER, CONSTRAINT pk_TeamMatchStats PRIMARY KEY (TeamID, MatchID))"
        Dim myCommand2 As New OleDbCommand(SQL2, conn)
        myCommand2.ExecuteNonQuery()

      Catch ex As Exception
        Debug.Print(ex.ToString)
      End Try

      Try
        Dim SQL3 As String = "CREATE TABLE MatchEvents (EventID AUTOINCREMENT, MatchID INTEGER, TeamID INTEGER, TimeSecond INTEGER, PlayerID INTEGER, PlayerSecID INTEGER, EventType VARCHAR(30), CONSTRAINT pk_MatchEvents PRIMARY KEY (EventID))"
        Dim myCommand3 As New OleDbCommand(SQL3, conn)
        'EVENT TYPES:
        ' RCARD
        ' YCARD
        ' GOAL
        ' SUBS_IN
        ' SUBS_OUT
        ' SUBS
        ' OFFSIDE
        ' CORNER

        myCommand3.ExecuteNonQuery()
      Catch ex As Exception
        Debug.Print(ex.ToString)
      End Try

      Try
        Dim SQL4 As String = "CREATE TABLE MatchGoals (GoalID AUTOINCREMENT, MatchID INTEGER, TeamGoalID INTEGER, Minute INTEGER, PlayerID INTEGER, Penalty YESNO, OwnGoal YESNO, CONSTRAINT pk_MatchGoals PRIMARY KEY (GoalID))"
        Dim myCommand4 As New OleDbCommand(SQL4, conn)
        myCommand4.ExecuteNonQuery()

      Catch ex As Exception
        Debug.Print(ex.ToString)

      End Try

      conn.Close()
      Return True
    Catch ex As Exception
      Debug.Print(ex.ToString)
      Return False
    End Try
  End Function

  Public Shared Function TableExists(tableName As String)
    Dim res As Boolean = False
    Try

      Dim adodbConn As New ADODB.Connection()
      adodbConn.Open(Config.Instance.LocalConnectionString)
      Dim rs As New ADODB.Recordset()
      rs.Open("SELECT * FROM " & tableName, adodbConn)
      rs.Close()
      res = True
    Catch ex As Exception
      res = False
    End Try
    Return res
  End Function
End Class
