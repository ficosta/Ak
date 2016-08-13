Imports System.Data.OleDb

Public Class DataBase
  Private Structure ParamDefinition
    Dim Name As String
    Dim Type As String
  End Structure

  Private Shared Sub CreateTable(sql As String)
    Try
      Dim conn As New OleDbConnection(Config.Instance.LocalConnectionString)
      conn.Open()

      Try
        Dim myCommand As New OleDbCommand(sql, conn)
        myCommand.ExecuteNonQuery()

      Catch ex As Exception

        'did it aready exist? if it did, lets check that the fields are correct!
        If ex.HResult = -2147217900 Then
          'get the table name
          Dim tableName As String = ""
          Dim aux As String = sql.Replace("CREATE TABLE", "").Trim
          tableName = aux.Substring(0, aux.IndexOf(" "))

          'get the parameters
          Dim char_init As Integer = sql.IndexOf("(") + 1
          Dim char_end As Integer = sql.LastIndexOf(")") - 1
          aux = sql.Substring(char_init, char_end - char_init)
          Dim params() As String = aux.Split(",")
          Dim paramDefinitions As New List(Of ParamDefinition)
          Dim missingParamDefinitions As New List(Of ParamDefinition)

          For Each param As String In params
            Dim paramPair() As String = param.Trim.Split(" ")
            If paramPair.Length = 2 Then
              'it's a parameter. I know, it's ugly, but it works
              Dim pd As ParamDefinition
              pd.Name = paramPair(0)
              pd.Type = paramPair(1)
              paramDefinitions.Add(pd)
            End If
          Next

          If paramDefinitions.Count > 0 Then
            Dim rs As New ADODB.Recordset()
            Dim adodbCon As New ADODB.Connection
            adodbCon.Open(Config.Instance.LocalConnectionString)
            'rs.Open("DESCRIBE " & tableName, conn)
            rs.Open("SELECT * FROM " & tableName, adodbCon)
            If Not rs.EOF Then
              For Each paramDef As ParamDefinition In paramDefinitions
                Try
                  Dim obj As Object = rs.Fields.Item(paramDef.Name)
                Catch ex1 As Exception
                  'doesnt exists!
                  missingParamDefinitions.Add(paramDef)
                End Try
              Next
            End If
            rs.Close()

            For Each paramdef In missingParamDefinitions
              Try
                adodbCon.Execute("ALTER TABLE " & tableName & " ADD " & paramdef.Name & " " & paramdef.Type)
              Catch ex2 As Exception
                MsgBox("Data base structure is not correct. Is this an old database?" & vbCrLf & "Table " & tableName & ", field missing " & paramdef.Name, MsgBoxStyle.Critical)
              End Try
            Next
            adodbCon.Close()
          End If
        End If
        Debug.Print(ex.ToString)
      End Try
      conn.Close()
    Catch ex As Exception
    End Try
  End Sub


  Private Shared Sub AddFieldToTable(tableName As String, paramName As String, paramType As String)
    Dim param As ParamDefinition
    param.Name = paramName
    param.Type = paramType
    AddFieldToTable(tableName, param)
  End Sub

  Private Shared Sub AddFieldToTable(tableName As String, param As ParamDefinition)
    Try
      Dim adodbCon As New ADODB.Connection
      adodbCon.Open(Config.Instance.LocalConnectionString)
      Try
        adodbCon.Execute("ALTER TABLE " & tableName & " ADD " & param.Name & " " & param.Type)
      Catch ex2 As Exception
        'MsgBox("Data base structure is not correct. Is this an old database?" & vbCrLf & "Table " & tableName & ", field missing " & param.Name, MsgBoxStyle.Critical)
      End Try
      adodbCon.Close()
    Catch ex As Exception

    End Try
  End Sub


  Public Shared Function CreateTables() As Boolean


    Try
      CreateTable("CREATE TABLE PlayerStats (PlayerID INTEGER, MatchID INTEGER, Shots INTEGER, Shots_on_target INTEGER, Saves INTEGER, Fouls INTEGER, YCard INTEGER, RCard INTEGER, Assis INTEGER, Formation_pos INTEGER, Formation_x INTEGER, Formation_y INTEGER, Substituion INTEGER, CONSTRAINT pk_PlayerStats PRIMARY KEY (PlayerID, MatchID))")
      CreateTable("CREATE TABLE TeamMatchStats (TeamID INTEGER, MatchID INTEGER, Shots INTEGER, Saves INTEGER, Fouls INTEGER, YCard INTEGER, RCard INTEGER, Assis INTEGER, Shots_on_target INTEGER, corners INTEGER, offsides INTEGER, wood_hits INTEGER, PossessionMatch INTEGER, Possession1st INTEGER, Possession2nd INTEGER, PossessionLast5 INTEGER, PossessionLast10 INTEGER, PossessionOwn INTEGER, PossessionMid INTEGER, PossessionAttack INTEGER, FormID INTEGER, CONSTRAINT pk_TeamMatchStats PRIMARY KEY (TeamID, MatchID))")
      CreateTable("CREATE TABLE MatchEvents (EventID AUTOINCREMENT, MatchID INTEGER, TeamID INTEGER, TimeSecond INTEGER, PlayerID INTEGER, PlayerSecID INTEGER, EventType VARCHAR(30), CONSTRAINT pk_MatchEvents PRIMARY KEY (EventID))")
      CreateTable("CREATE TABLE MatchGoals (GoalID AUTOINCREMENT, MatchID INTEGER, TeamGoalID INTEGER, Minute INTEGER, PlayerID INTEGER, Penalty YESNO, OwnGoal YESNO, CONSTRAINT pk_MatchGoals PRIMARY KEY (GoalID))")

      AddFieldToTable("Matches", "Official1", "INTEGER")
      AddFieldToTable("Matches", "Official2", "INTEGER")
      AddFieldToTable("Matches", "Official3", "INTEGER")
      AddFieldToTable("Teams", "OPTAID", "INTEGER")

      Return True
    Catch ex As Exception
      Debug.Print(ex.ToString)
      Return False
    End Try
  End Function

  Public Shared Function CreateTables_old() As Boolean


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
