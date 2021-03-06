﻿Imports System.Data.OleDb
Imports System.Data.SqlClient
Imports MatchInfo

<Serializable()> Public Class Match
  Implements IComparable
  Implements ICloneable

  Private WithEvents _homeTeam As Team
  Public Property HomeTeam As Team
    Get
      Return _homeTeam
    End Get
    Set(value As Team)
      _homeTeam = value
    End Set
  End Property

  Private WithEvents _awayTeam As Team
  Public Property AwayTeam As Team
    Get
      Return _awayTeam
    End Get
    Set(value As Team)
      _awayTeam = value
    End Set
  End Property

  Public Event ScoreChanged()
  Public Event ActivePeriodStateChanged(period As Period)
  Public Event TeamStatValueChanged(team As Team, stat As Stat)
  Public Event EventCreated(myEvent As MatchEvent)
  Public Event EventRemoved(myEvent As MatchEvent)
  Public Event Substitution(team As Team, substitution As Substitution)
  Public Event MatchReset()


  Public ReadOnly Property Substitutions As Substitutions
    Get
      Dim subs As New Substitutions()
      If Not Me.HomeTeam Is Nothing AndAlso Not Me.HomeTeam.Substitutions Is Nothing Then
        For Each substitution As Substitution In Me.HomeTeam.Substitutions
          subs.Add(substitution)
        Next
      End If
      If Not Me.HomeTeam Is Nothing AndAlso Not Me.AwayTeam.Substitutions Is Nothing Then
        For Each substitution As Substitution In Me.AwayTeam.Substitutions
          subs.Add(substitution)
        Next
      End If
      Return subs
    End Get
  End Property

  Public Property HomeTeamName As String
  Public Property AwayTeamName As String

  Private _db_home_goals As Integer = 0
  Public Property db_home_goals As Integer
    Get
      Return _db_home_goals
    End Get
    Set(value As Integer)
      _db_home_goals = value
      _home_goals = value
    End Set
  End Property

  Private _home_goals As Integer = 0
  Public Property home_goals As Integer
    Get
      'If Not Me.HomeTeam Is Nothing Then _home_goals = Me.home_goals
      If Not Me.HomeTeam Is Nothing AndAlso (Not Me.HomeTeam.MatchGoals Is Nothing AndAlso Me.HomeTeam.MatchGoals.UpToDate) Then
        Return Me.HomeTeam.MatchGoals.Count
      Else
        Return _home_goals
      End If
    End Get
    Set(value As Integer)
      If home_goals <> value Then
        _home_goals = value
        If Not Me.HomeTeam Is Nothing Then Me.HomeTeam.Goals = value
        RaiseEvent ScoreChanged()
      End If
    End Set
  End Property

  Private _db_away_goals As Integer = 0
  Public Property db_away_goals As Integer
    Get
      Return _db_away_goals
    End Get
    Set(value As Integer)
      _db_away_goals = value
      _away_goals = value
    End Set
  End Property

  Private _away_goals As Integer = 0
  Public Property away_goals As Integer
    Get
      'If Not Me.AwayTeam Is Nothing Then _away_goals = Me.away_goals
      If Not Me.AwayTeam Is Nothing AndAlso (Not Me.AwayTeam.MatchGoals Is Nothing AndAlso Me.AwayTeam.MatchGoals.UpToDate) Then
        Return Me.AwayTeam.MatchGoals.Count
      Else
        Return _away_goals
      End If
    End Get
    Set(value As Integer)
      If _away_goals <> value Then
        _away_goals = value
        If Not Me.AwayTeam Is Nothing Then Me.AwayTeam.Goals = value
        RaiseEvent ScoreChanged()
      End If
    End Set
  End Property

  Private WithEvents _matchGoals As New MatchGoals()
  Public Property MatchGoals() As MatchGoals
    Get
      _matchGoals.Clear()

      For Each goal As MatchGoal In Me.HomeTeam.MatchGoals
        _matchGoals.Add(goal)
      Next
      For Each goal As MatchGoal In Me.AwayTeam.MatchGoals
        _matchGoals.Add(goal)
      Next
      Return _matchGoals
    End Get
    Set(value As MatchGoals)
      _matchGoals = value
    End Set
  End Property

  Private _lastGoal As MatchGoal = Nothing
  Public Property LastGoal() As MatchGoal
    Get
      If Not _lastGoal Is Nothing And False Then
        Return _lastGoal
      ElseIf Me.MatchGoals.Count > 0 Then
        Me.MatchGoals.Sort()
        'last goal is the one with higher MatchID, not by time
        _lastGoal = Me.MatchGoals(0)

        For Each goal As MatchGoal In Me.MatchGoals
          If goal.GoalID > _lastGoal.GoalID Then _lastGoal = goal
        Next

        Return _lastGoal
      Else
        Return Nothing
      End If
    End Get
    Set(value As MatchGoal)

    End Set
  End Property


  Private WithEvents _matchEvents As New MatchEvents()
  Public Property MatchEvents() As MatchEvents
    Get
      Return _matchEvents
    End Get
    Set(value As MatchEvents)
      _matchEvents = value
    End Set
  End Property

  Public Property LastEvent() As MatchEvent

  Public match_id As Integer
  Public competition_id As Integer
  Public match_time As Integer
  Public matchday As Integer
  Public home_team_id As Integer
  Public away_team_id As Integer
  Public [date] As DateTime
  Public venue_id As Integer
  Public attendance As Integer
  Public state As String

  Public match_date As DateTime
  Public comp_id As Integer
  Public ArabicMatchDescription As String
  Public ArabicMatchCommentators As String
  Public optaID As Integer

  Public Official1 As Official
  Public Official2 As Official
  Public Official3 As Official

  Public optaCompetitionId As Integer
  Public optaCompetitionCode As String
  Public optaSeason As String
  Public optaMatchDay As Integer
  Public optaHomeTeamID As Integer
  Public optaAwayTeamID As Integer
  Public optaHomeScore As Integer = 0
  Public optaAwayScore As Integer = 0

  Public optaChanged As Boolean = False


  Public WithEvents MatchPeriods As New Periods


  Public AA As String

  Public locked As Boolean

  Public last_update As DateTime


  Private _savetoToDBEnabled As Boolean = False
  Public Overloads Property SaveToDBEnabled() As Boolean
    Get
      Return _savetoToDBEnabled
    End Get
    Set(value As Boolean)
      _savetoToDBEnabled = value
      Me.HomeTeam.SaveToDBEnabled = value
      Me.AwayTeam.SaveToDBEnabled = value
    End Set
  End Property

  Private Sub InitMatch(ID As Integer)
    match_id = ID
    competition_id = -1
    match_time = -1
    matchday = -1
    home_team_id = -1
    away_team_id = -1
    [date] = New DateTime()
    venue_id = -1
    home_goals = -1
    away_goals = -1
    attendance = -1
    state = ""
    locked = False
    last_update = New DateTime
  End Sub

  Public ReadOnly Property match_date_string As String
    Get
      Dim format As String = "yyyy MM dd"

      Return match_date.ToString(format)
    End Get
  End Property


  Public Overrides Function ToString() As String
    Return Me.match_date_string & " " & Me.HomeTeam.TeamAELCaption1Name & " - " & Me.AwayTeam.TeamAELCaption1Name
  End Function

  Public Function Description() As String
    Return Me.match_date_string & " " & Me.HomeTeam.TeamAELCaption1Name & " - " & Me.AwayTeam.TeamAELCaption1Name & "     " & Me.HomeTeam.MatchGoals.Count & " - " & Me.AwayTeam.MatchGoals.Count
  End Function

  Public Function DescriptionByOpta() As String
    Return Me.match_date_string & " " & Me.HomeTeam.OptaName & " - " & Me.AwayTeam.OptaName & "     " & Me.optaHomeScore & " - " & Me.optaAwayScore
  End Function

  Public Sub New()
    Init(-1)
  End Sub
  Public Sub New(ID As Integer)
    Init(ID)
  End Sub

  Public Sub Init(ID As Integer)
    match_id = ID
    AA = ""
    match_date = New Date
    home_team_id = -1
    away_team_id = -1
    home_goals = -1
    away_goals = -1
    venue_id = -1
    attendance = -1
    competition_id = -1
    ArabicMatchDescription = ""
    ArabicMatchCommentators = ""
    OPTAID = -1
    HomeTeam = New Team(-1)
    AwayTeam = New Team(-1)
    MatchEvents = New MatchEvents()

    'Exit Sub
    Try
      If Config.Instance.LocalConnectionString Is Nothing Then Exit Sub
      If match_id = -1 Then Exit Sub

      Dim conn As New OleDbConnection(Config.Instance.LocalConnectionString)
      conn.Open()

      Dim SQL As [String] = "SELECT MatchId, AA, MatchDate, TeamID1, TeamID2, Score1, Score2, VenueID, Attendance, CompID, ArabicMatchDescription, ArabicMatchCommentators, OPTAID, Official1, Official2, Official3"
      SQL += " FROM Matches "
      SQL += " WHERE MatchId = " & match_id
      Dim CmdSQL As New OleDbCommand(SQL, conn)

      CmdSQL.CommandType = System.Data.CommandType.Text
      Dim myReader As OleDbDataReader = CmdSQL.ExecuteReader()
      If myReader.Read() Then
        'Dim aa As String = myReader.GetString(1)
        'If Not myReader.IsDBNull(1) Then NewItem.AA = myReader.GetString(1)
        If Not myReader.IsDBNull(2) Then Me.match_date = myReader.GetDateTime(2)
        If Not myReader.IsDBNull(3) Then
          Me.home_team_id = myReader.GetInt32(3)
          'Me.HomeTeam = New Team(Me.match_id, Me.home_team_id, True)
          Me.HomeTeam = New Team(Me.match_id, Me.home_team_id, False)

        End If
        If Not myReader.IsDBNull(4) Then
          Me.away_team_id = myReader.GetInt32(4)
          ' Me.AwayTeam = New Team(Me.match_id, Me.away_team_id, True)
          Me.AwayTeam = New Team(Me.match_id, Me.away_team_id, False)
        End If
        If Not myReader.IsDBNull(5) Then Me.home_goals = myReader.GetInt32(5)
        If Not myReader.IsDBNull(6) Then Me.away_goals = myReader.GetInt32(6)
        If Not myReader.IsDBNull(7) Then Me.venue_id = myReader.GetInt32(7)
        If Not myReader.IsDBNull(8) Then Me.attendance = myReader.GetInt32(8)

        If Not myReader.IsDBNull(9) Then Me.competition_id = myReader.GetInt32(9)
        If Not myReader.IsDBNull(10) Then Me.ArabicMatchDescription = myReader.GetString(10)
        If Not myReader.IsDBNull(11) Then Me.ArabicMatchCommentators = myReader.GetString(11)
        If Not myReader.IsDBNull(12) Then Me.optaID = myReader.GetInt32(12)

        Dim officials As New Officials
        officials.GetFromDB()
        If Not myReader.IsDBNull(13) Then Me.Official1 = officials.GetByID(myReader.GetInt32(13))
        If Not myReader.IsDBNull(14) Then Me.Official2 = officials.GetByID(myReader.GetInt32(14))
        If Not myReader.IsDBNull(15) Then Me.Official3 = officials.GetByID(myReader.GetInt32(15))

      End If
      conn.Close()

    Catch ex As Exception

    End Try
  End Sub

  ''' <summary>
  ''' Create SQL Commands with the parameters and Values to use it to UPDATE or INSERT the database
  ''' </summary>
  ''' <returns>OleDbCommands filled</returns>
  Public Function CreateCommand() As OleDbCommand
    Dim myCmd As New OleDbCommand()
    Try
      myCmd.Parameters.AddWithValue("@MatchId", match_id)
      myCmd.Parameters.AddWithValue("@AA", AA)
      myCmd.Parameters.AddWithValue("@match_date", match_date)
      myCmd.Parameters.AddWithValue("@home_team_id", home_team_id)
      myCmd.Parameters.AddWithValue("@away_team_id", away_team_id)
      myCmd.Parameters.AddWithValue("@home_goals", home_goals)
      myCmd.Parameters.AddWithValue("@away_goals", away_goals)
      myCmd.Parameters.AddWithValue("@venue_id", venue_id)
      myCmd.Parameters.AddWithValue("@Attendance", attendance)
      myCmd.Parameters.AddWithValue("@competition_id", competition_id)
      myCmd.Parameters.AddWithValue("@ArabicMatchDescription", ArabicMatchDescription)
      myCmd.Parameters.AddWithValue("@ArabicMatchCommentators", ArabicMatchCommentators)
      myCmd.Parameters.AddWithValue("@OPTAID", optaID)
      myCmd.Parameters.AddWithValue("@Official1", Official.GetID(Official1))
      myCmd.Parameters.AddWithValue("@Official2", Official.GetID(Official2))
      myCmd.Parameters.AddWithValue("@Official3", Official.GetID(Official3))

    Catch err As Exception
      Throw err
    End Try
    Return myCmd
  End Function

  Private Function GetFromDB(Where As String) As Boolean
    Try
      Dim myDatabase As New Matches()
      myDatabase.GetFromDB(Where)
      If myDatabase.Count = 0 Then
        Return False
      End If

      CopyMatch(DirectCast(myDatabase(0), Match))
    Catch err As Exception
      Throw err
    End Try
    Return True
  End Function


  Public Sub CopyMatch(Source As Match)
    Try
      match_id = Source.match_id
      AA = Source.AA
      match_date = Source.match_date
      home_team_id = Source.home_team_id
      away_team_id = Source.away_team_id
      home_goals = Source.home_goals
      away_goals = Source.away_goals
      venue_id = Source.venue_id
      attendance = Source.attendance
      competition_id = Source.competition_id
      ArabicMatchDescription = Source.ArabicMatchDescription
      ArabicMatchCommentators = Source.ArabicMatchCommentators
      optaID = Source.optaID
      HomeTeam = Source.HomeTeam
      AwayTeam = Source.AwayTeam
      Official1 = Source.Official1
      Official2 = Source.Official2
      Official3 = Source.Official3
    Catch err As Exception
      Throw err
    End Try
  End Sub

  Public Function GetMatch() As Boolean
    Return GetFromDB("WHERE MatchID = " & match_id)
  End Function

  Private _actualDB As Match = Nothing
  Public Sub Update()
    Try
      If _actualDB Is Nothing Then _actualDB = New Match(match_id)
      'Dim ActualDb As New Match(match_id)
      If _actualDB.GetMatch() Then
        'UPDATE
        Dim SQL As String = ""
        If _actualDB.AA <> AA AndAlso AA <> "" Then
          SQL &= " AA=@AA,"
        End If
        If _actualDB.match_date <> match_date AndAlso match_date.Year > 1900 Then
          SQL &= " match_date=@match_date,"
        End If
        If _actualDB.home_team_id <> home_team_id AndAlso home_team_id <> -1 Then
          SQL &= " home_team_id=@home_team_id,"
        End If
        If _actualDB.away_team_id <> away_team_id AndAlso away_team_id <> -1 Then
          SQL &= " away_team_id=@away_team_id,"
        End If
        If _actualDB.db_home_goals <> home_goals AndAlso home_goals <> -1 Then
          SQL &= " Score1=" & home_goals & ","
        End If
        If _actualDB.db_away_goals <> away_goals AndAlso away_goals <> -1 Then
          SQL &= " Score2=" & away_goals & ","
        End If
        If _actualDB.venue_id <> venue_id AndAlso venue_id <> -1 Then
          SQL &= " venue_id=@venue_id,"
        End If
        If _actualDB.attendance <> attendance AndAlso attendance <> -1 Then
          SQL &= " Attendance=@Attendance,"
        End If
        If _actualDB.competition_id <> competition_id AndAlso competition_id <> -1 Then
          SQL &= " competition_id=@competition_id,"
        End If
        If _actualDB.ArabicMatchDescription <> ArabicMatchDescription AndAlso ArabicMatchDescription <> "" Then
          SQL &= " ArabicMatchDescription=@ArabicMatchDescription,"
        End If
        If _actualDB.ArabicMatchCommentators <> ArabicMatchCommentators AndAlso ArabicMatchCommentators <> "" Then
          SQL &= " ArabicMatchCommentators=@ArabicMatchCommentators,"
        End If
        If _actualDB.optaID <> optaID AndAlso optaID <> -1 Then
          SQL &= " OPTAID=" & optaID & ","
        End If
        If Official.GetID(_actualDB.Official1) <> Official.GetID(Official1) Then
          SQL &= " Official1=" & Official.GetID(Official1) & ","
        End If
        If Official.GetID(_actualDB.Official2) <> Official.GetID(Official2) Then
          SQL &= " Official2=" & Official.GetID(Official2) & ","
        End If
        If Official.GetID(_actualDB.Official3) <> Official.GetID(Official3) Then
          SQL &= " Official3=" & Official.GetID(Official3) & ","
        End If

        If SQL <> "" Then
          Dim conn As New OleDbConnection(Config.Instance.LocalConnectionString)
          conn.Open()
          Dim myCommand As OleDbCommand = CreateCommand()
          myCommand.Connection = conn
          SQL = SQL.Substring(0, SQL.Length - 1)
          SQL = (Convert.ToString("UPDATE Matches SET") & SQL) & " WHERE MatchID = " & match_id
          myCommand.CommandText = SQL
          myCommand.ExecuteNonQuery()
          conn.Close()
        End If
      Else
        'INSERT
        Dim SQL As String = "INSERT INTO Matches (AA, match_date, home_team_id, away_team_id, home_goals, away_goals, venue_id, Attendance, competition_id, ArabicMatchDescription, ArabicMatchCommentators, OPTAID, Official1, Official2, Official3)"
        SQL &= " VALUES (@AA, @match_date, @home_team_id, @away_team_id, @home_goals, @away_goals, @venue_id, @Attendance, @competition_id, @ArabicMatchDescription, @ArabicMatchCommentators, @OPTAID, @Official1, @Official2, @Official3)"
        Dim conn As New OleDbConnection(Config.Instance.LocalConnectionString)
        conn.Open()
        Dim cmdExecute As OleDbCommand = CreateCommand()
        cmdExecute.CommandText = SQL
        cmdExecute.Connection = conn
        cmdExecute.ExecuteNonQuery()
        conn.Close()
      End If
      _actualDB = Me.Clone
    Catch err As Exception
      Throw err
    End Try
  End Sub

  Public Function CompareTo(obj As Object) As Integer Implements IComparable.CompareTo

    If Not TypeOf obj Is Match Then
      Throw New Exception("Object is not of type Match")
    End If

    Return Date.Compare(Me.match_date, obj.match_date)
  End Function


  Public Function GetPlayerById(ID As Integer) As Player
    Dim res As Player = Nothing
    Try
      If res Is Nothing Then res = Me.HomeTeam.GetPlayerById(ID)
      If res Is Nothing Then res = Me.AwayTeam.GetPlayerById(ID)
    Catch ex As Exception
    End Try
    Return res
  End Function


  Private _saving As Boolean = False
  Public Sub SaveMatch()
    If _saving Then Exit Sub
    _saving = True
    Try
      If _savetoToDBEnabled Then
        SaveMatchEventsToDB()
        _homeTeam.WriteStatsToDB()
        _awayTeam.WriteStatsToDB()
        Me.Update()
      End If
    Catch ex As Exception
    End Try
    _saving = False
  End Sub


  Public Sub SaveMatchGoalsToDB(computeGoals As Boolean)
    Try
      If computeGoals Then
        ' MatchGoals.DeleteMatchGoals(Me.match_id)
        For Each goal As MatchGoal In Me.MatchGoals
          ' goal.Update()
        Next
        For Each goal As MatchGoal In Me.HomeTeam.MatchGoals
          goal.Update()
        Next
        Me.home_goals = Me.HomeTeam.MatchGoals.Count
        Me.home_goals = Me.HomeTeam.MatchGoals.Count

        For Each goal As MatchGoal In Me.AwayTeam.MatchGoals
          goal.Update()
        Next
        Me.away_goals = Me.AwayTeam.MatchGoals.Count
        Me.away_goals = Me.HomeTeam.MatchGoals.Count

        HomeTeam.WriteStatsToDB()
        AwayTeam.WriteStatsToDB()
      End If


      Dim sql As String
      Dim cCon As New ADODB.Connection()
      cCon.Open(Config.Instance.LocalConnectionString)

      sql = "UPDATE Matches SET Score1 = " & Me.home_goals & ", Score2 = " & Me.away_goals & " WHERE MatchId = " & Me.match_id

      cCon.Execute(sql)

    Catch ex As Exception
      Debug.Print(ex.ToString)
    End Try
  End Sub


  Private Sub _team_StatValueChanged(sender As StatSubject, stat As Stat) Handles _homeTeam.StatValueChanged, _awayTeam.StatValueChanged
    'SaveMatch()
    Debug.Print(sender.ID & " " & stat.Name & " = " & stat.Value)
    RaiseEvent TeamStatValueChanged(sender, stat)
  End Sub

  Private Sub _team_PlayerStatValueChanged(team As Team, player As Player, stat As Stat) Handles _homeTeam.PlayerStatValueChanged, _awayTeam.PlayerStatValueChanged
    Try
      'SaveMatch()
      Debug.Print(team.Name & " " & stat.Name & " = " & stat.Value)
      'UpdateStatValue(stat, team)
    Catch ex As Exception

    End Try
  End Sub

  Private _updating As Boolean = False
  Private Sub UpdateStatValue(stat As Stat, team As Team)
    If _updating Then Exit Sub
    _updating = True
    Try
      'Dim value As Double = 0

      'value = Me.MatchEvents.GetEventsByTeam(team.TeamID, stat.Name).Count

      'stat.Value = value
      'team.WriteStatToDB(stat)
      'Me.Update()

    Catch ex As Exception
    End Try
    _updating = False
  End Sub


#Region "Match goals"
  Public Sub GetMatchGoalsFromDB()
    Try
      Me.MatchGoals.GetMatchGoals(Me.match_id)
      Me.home_goals = PopulateMatchGoals(Me.HomeTeam)
      Me.away_goals = PopulateMatchGoals(Me.AwayTeam)

    Catch ex As Exception
      Debug.Print(ex.ToString)
    End Try
  End Sub

  Private Function PopulateMatchGoals(team As Team) As Integer
    Dim goals As Integer = 0
    Try
      If Not team Is Nothing Then

        team.Goals = 0
        For Each player As Player In team.AllPlayers
          player.Goals = 0
        Next
        For Each goal As MatchGoal In Me.MatchGoals
          Dim player As Player = team.AllPlayers.GetPlayer(goal.PlayerID)
          If Not player Is Nothing Then
            team.Goals += 1
            player.Goals += 1
          End If
        Next

      End If
    Catch ex As Exception
      Debug.Print(ex.ToString)
    End Try
    Return goals
  End Function


  Private Sub Team_GoalScored(team As Team, player As Player, own_goal As Boolean, penalty As Boolean) Handles _homeTeam.GoalScored, _awayTeam.GoalScored
    Try
      Dim goal As MatchGoal = CreateGoal(team, player, own_goal, penalty)
      'team.MatchGoals.Add(goal)
      'Me.MatchGoals.Add(goal)
      ' SaveMatch()

      ' Me.home_goals = PopulateMatchGoals(team)
    Catch ex As Exception

    End Try
  End Sub

  Public Function AddGoal(isHomeTeam As Boolean, player As Player, own_goal As Boolean, penalty As Boolean) As MatchGoal
    If isHomeTeam Then
      Return Me.CreateGoal(HomeTeam, player, own_goal, penalty)
    Else
      Return Me.CreateGoal(AwayTeam, player, own_goal, penalty)
    End If
    RaiseEvent ScoreChanged()
  End Function

  Public Function RemoveLastGoalByPlayer(player As Player) As MatchGoal
    Dim matchGoal As MatchGoal = Nothing
    Try
      For Each goal As MatchGoal In Me.MatchGoals
        If goal.PlayerID = player.PlayerID Then
          matchGoal = goal
          RemoveGoal(goal)
          Exit For
        End If
      Next
    Catch ex As Exception

    End Try
    Return matchGoal
  End Function

  Public Function RemoveGoal(id As Integer) As Boolean
    Dim res As Boolean = False
    Try
      Me.RemoveGoal(Me.HomeTeam, id)
      Me.RemoveGoal(Me.AwayTeam, id)
      SaveMatchGoalsToDB(True)
      res = True
    Catch ex As Exception

    End Try
    Return res
  End Function

  Public Function RemoveGoal(goal As MatchGoal) As Boolean
    Try
      Return Me.RemoveGoal(goal.GoalID)
    Catch ex As Exception
      Return False
    End Try
  End Function

  Public Function RemoveLastGoal() As MatchGoal
    If Not LastGoal Is Nothing Then
      Me.RemoveGoal(Me.LastGoal)
      LastGoal = Nothing
    End If
    RaiseEvent ScoreChanged()
    Return Me.LastGoal
  End Function

  Public Function UpdateGoal(goal As MatchGoal) As Boolean
    UpdateScorers(Me.HomeTeam)
    UpdateScorers(Me.AwayTeam)
    SaveMatchGoalsToDB(True)
    RaiseEvent ScoreChanged()
    Return True
  End Function

  Private Sub UpdateScorers(team As Team)
    Try
      For Each player As Player In team.AllPlayers
        player.Goals = team.MatchGoals.GetGoalsByPlayer(player).Count
      Next
    Catch ex As Exception

    End Try
  End Sub

  Public Function UpdateGoals() As Boolean
    SaveMatchGoalsToDB(True)
    RaiseEvent ScoreChanged()
    Return True
  End Function

  Private Function CreateGoal(team As Team, player As Player, own_goal As Boolean, penalty As Boolean) As MatchGoal
    Dim goal As New MatchGoal
    Try
      goal.MatchID = Me.match_id
      goal.OwnGoal = own_goal
      goal.Penalty = penalty
      goal.TeamGoalID = team.ID
      If Not player Is Nothing Then
        goal.PlayerID = player.ID
      Else
        goal.PlayerID = 0
      End If
      If Me.MatchPeriods.ActivePeriod Is Nothing Then
        goal.TimeSecond = 0
        goal.IsExtraTime = False
      Else
        goal.TimeSecond = Me.MatchPeriods.ActivePeriod.PlayingTime + Me.MatchPeriods.ActivePeriod.StartOffset
        goal.IsExtraTime = Me.MatchPeriods.ActivePeriod.IsPeriodDone
      End If
      team.MatchGoals.Add(goal)
      Me.MatchGoals.Add(goal)
      If Not player Is Nothing Then
        player.Goals = team.MatchGoals.GetGoalsByPlayer(player).Count
      End If
      team.Goals = team.MatchGoals.Count
      Me.LastGoal = goal
      Me.SaveMatchGoalsToDB(True)
      Me.Update()
      RaiseEvent ScoreChanged()
    Catch ex As Exception

    End Try
    Return goal
  End Function

  Private Function RemoveGoal(team As Team, goalID As Integer) As Boolean
    Dim res As Boolean = True
    Try
      Dim goal As MatchGoal = team.MatchGoals.GetGoal(goalID)
      If goal Is Nothing Then Return False

      Dim player As Player = team.GetPlayerById(goal.PlayerID)

      team.MatchGoals.RemoveGoal(goalID)

      If Not player Is Nothing Then
        player.Goals = team.MatchGoals.GetGoalsByPlayer(player).Count
      End If
      team.Goals = team.MatchGoals.Count

      If Not Me.LastGoal Is Nothing AndAlso Me.LastGoal.GoalID = goalID Then
        If Me.MatchGoals.Count > 0 Then
          Me.LastGoal = Me.MatchGoals(0)
        Else
          Me.LastGoal = Nothing
        End If
      End If

      Dim cCon As New ADODB.Connection()
      cCon.Open(Config.Instance.LocalConnectionString)

      Dim sql As String = "DELETE FROM MatchGoals WHERE MatchID = " & Me.match_id & " AND goalID = " & goalID

      cCon.Execute(sql)


    Catch ex As Exception
      res = False
    End Try
    Return res
  End Function

#End Region

#Region "Match events"
  Public Sub GetMatchEventsFromDB()
    Try
      Me.MatchEvents.GetFromDB(Me.match_id)

      For Each player As Player In Me.HomeTeam.AllPlayers
        For Each stat As Stat In player.MatchStats.StatBag
          Me.UpdateStatForPlayerFromEvents(stat, player)
        Next
      Next
      For Each stat As Stat In Me.HomeTeam.MatchStats.StatBag
        Me.UpdateStatFromEvents(Me.HomeTeam, stat)
      Next

      For Each player As Player In Me.AwayTeam.AllPlayers
        For Each stat As Stat In player.MatchStats.StatBag
          Me.UpdateStatForPlayerFromEvents(stat, player)
        Next
      Next
      For Each stat As Stat In Me.AwayTeam.MatchStats.StatBag
        Me.UpdateStatFromEvents(Me.AwayTeam, stat)
      Next


    Catch ex As Exception
      Debug.Print(ex.ToString)
    End Try
  End Sub

  Public Function AddSubstitution(teamId As Integer, playerInId As Integer, playerOutId As Integer) As Substitution

  End Function


  Public Function AddEvent(type As String, teamID As Integer, playerID As Integer) As MatchEvent
    Dim time As Integer = 0
    If Not Me.MatchPeriods.ActivePeriod Is Nothing Then
      time = Me.MatchPeriods.ActivePeriod.PlayingTime + Me.MatchPeriods.ActivePeriod.StartOffset
    End If
    Return Me.CreateEvent(type, teamID, playerID, time, 0)
  End Function

  Public Function AddEvent(type As String, teamID As Integer, playerID As Integer, time As Integer, playerSecId As Integer) As MatchEvent
    Return Me.CreateEvent(type, teamID, playerID, time, playerSecId)
  End Function

  Public Sub UpdateStatFromEvents(team As Team, stat As Stat)
    If stat.EventBased Then
      Dim allEvents As New List(Of MatchEvent)
      allEvents = Me.MatchEvents.GetEventsByTeam(team.TeamID, stat.Name)
      stat.Value = allEvents.Count
    End If
  End Sub

  Public Sub UpdateStatForPlayerFromEvents(stat As Stat, player As Player)
    If stat.EventBased Then
      Dim allEvents As New List(Of MatchEvent)
      allEvents = Me.MatchEvents.GetEventsByPlayer(player, stat)
      stat.Value = allEvents.Count
    End If
  End Sub

  Public Sub UpdateStatForPlayerFromEvents(statName As String, teamID As Integer, playerID As Integer)
    Dim allEvents As List(Of MatchEvent)
    Dim player As Player = Me.GetPlayerById(playerID)
    Dim team As Team = IIf(teamID = Me.HomeTeam.TeamID, Me.HomeTeam, Me.AwayTeam)

    If Not player Is Nothing Then
      Dim stat As Stat = player.GetMatchStatByName(statName)
      If Not stat Is Nothing AndAlso stat.EventBased Then
        allEvents = Me.MatchEvents.GetEventsByPlayer(playerID, statName)
        stat.Value = allEvents.Count
      End If
    End If

    If Not team Is Nothing Then
      Dim stat As Stat = team.GetMatchStatByName(statName)
      If Not stat Is Nothing AndAlso stat.EventBased Then
        allEvents = Me.MatchEvents.GetEventsByTeam(teamID, statName)
        stat.Value = allEvents.Count
      End If
    End If
  End Sub


  Public Sub UpdateStatForPlayerFromEvents(statName As String, player As Player)
    Try
      Me.UpdateStatForPlayerFromEvents(statName, player.TeamID, player.PlayerID)
    Catch ex As Exception

    End Try
  End Sub


  Public Function RemoveLastEventByPlayer(player As Player) As MatchEvent
    Dim matchEvent As MatchEvent = Nothing
    Try
      For Each myEvent As MatchEvent In Me.MatchEvents
        If myEvent.PlayerID = player.PlayerID Then
          matchEvent = myEvent
          RemoveEvent(myEvent)
          Exit For
        End If
      Next
    Catch ex As Exception

    End Try
    Return matchEvent
  End Function


  Public Function RemoveEvent(myEvent As MatchEvent) As Boolean
    Try
      Return Me.RemoveEvent(myEvent.EventID)
    Catch ex As Exception
      Return False
    End Try
  End Function


  Public Function RemoveEvent(type As String, teamID As Integer, playerID As Integer, timeSeconds As Integer, Optional playerSecID As Integer = -1) As MatchEvent
    Dim matchEvent As MatchEvent = Nothing
    Try
      For i As Integer = Me.MatchEvents.Count - 1 To 0 Step -1
        Dim myEvent As MatchEvent = Me.MatchEvents(i)
        If myEvent.EventType = type And myEvent.TeamID = teamID And myEvent.PlayerID = playerID And myEvent.TimeSecond = timeSeconds And myEvent.PlayerSecID = playerSecID Then
          matchEvent = myEvent
          RemoveEvent(myEvent)
        End If
      Next
    Catch ex As Exception

    End Try
    Return matchEvent
  End Function


  Public Function RemoveLastEvent() As MatchEvent
    If Not LastEvent Is Nothing Then
      Me.RemoveEvent(Me.LastEvent)
      LastEvent = Nothing
    End If
    RaiseEvent ScoreChanged()
    Return Me.LastEvent
  End Function

  Public Function UpdateEvent(myEvent As MatchEvent) As Boolean
    SaveMatchEventsToDB()
    RaiseEvent ScoreChanged()
    Return True
  End Function

  Public Function UpdateEvents() As Boolean
    SaveMatchEventsToDB()
    RaiseEvent ScoreChanged()
    Return True
  End Function


  Public Function CreateEvent(type As String, teamID As Integer, playerID As Integer, timeSeconds As Integer, Optional playerSecID As Integer = -1) As MatchEvent
    Dim res As MatchEvent = Nothing
    Try
      Dim time As Integer = timeSeconds
      If time = 0 Then
        If Not Me.MatchPeriods.ActivePeriod Is Nothing Then
          time = Me.MatchPeriods.TempsJocWithOffset
        End If

      End If
      res = Me.MatchEvents.Add(Me.match_id, type, teamID, playerID, time, playerSecID)
      Me.UpdateStatForPlayerFromEvents(type, teamID, playerID)
      RaiseEvent EventCreated(res)
    Catch ex As Exception

    End Try
    Return res
  End Function

  Public Sub SaveMatchEventsToDB()
    Try
      '  '      MatchEvents.DeleteMatchEvents(Me.match_id)
      For Each myEvent As MatchEvent In Me.MatchEvents
        myEvent.Update()
      Next

      HomeTeam.WriteStatsToDB()
      AwayTeam.WriteStatsToDB()

    Catch ex As Exception
      Debug.Print(ex.ToString)
    End Try
  End Sub


  Private Function RemoveEvent(eventID As Integer) As Boolean
    Dim res As Boolean = True
    Try
      For i As Integer = Me.MatchEvents.Count - 1 To 0 Step -1
        Dim myEvent As MatchEvent = Me.MatchEvents(i)
        If myEvent.EventID = eventID Then
          Me.MatchEvents.RemoveAt(i)
          myEvent.Delete()
          RaiseEvent EventRemoved(myEvent)
        End If
      Next

      If Not Me.LastEvent Is Nothing AndAlso Me.LastEvent.EventID = eventID Then
        If Me.MatchEvents.Count > 0 Then
          Me.LastEvent = Me.MatchEvents(0)
        Else
          Me.LastEvent = Nothing
        End If
      End If
      RaiseEvent ScoreChanged()
    Catch ex As Exception
      res = False
    End Try
    Return res
  End Function
#End Region

  Public Function Clone() As Object Implements ICloneable.Clone
    Dim res As New Match()
    Try
      res.AA = Me.AA
      res.ArabicMatchCommentators = Me.ArabicMatchCommentators
      res.ArabicMatchDescription = Me.ArabicMatchDescription
      res.attendance = Me.attendance
      res.away_team_id = Me.away_team_id
      res.away_goals = Me.away_goals
      res.competition_id = Me.competition_id
      res.date = Me.date
      res.home_goals = Me.home_goals
      res.home_team_id = Me.home_team_id
      res.last_update = Me.last_update
      res.matchday = Me.matchday
      res.match_date = Me.match_date
      res.match_id = Me.match_id
      res.match_time = Me.match_time
      res.optaID = Me.optaID
      res.state = Me.state
      res.venue_id = Me.venue_id

      res.Official1 = Me.Official1
      res.Official2 = Me.Official2
      res.Official3 = Me.Official3

      res.AwayTeam = Me.AwayTeam
      res.HomeTeam = Me.HomeTeam

      res.MatchEvents = Me.MatchEvents
      res.MatchPeriods = Me.MatchPeriods


    Catch ex As Exception
    End Try
    Return res
  End Function

  Private Sub MatchPeriods_ActivePeriodStateChanged(period As Period) Handles MatchPeriods.ActivePeriodStateChanged
    Try
      RaiseEvent ActivePeriodStateChanged(period)
      If Config.Instance.WasMatchSaved = False And period.Activa Then
        Config.Instance.WasMatchSaved = True
        Me.SaveMatchGoalsToDB(True)
        Me.Update()
      End If
    Catch ex As Exception

    End Try

  End Sub

  Public Sub Reset()
    Try
      _matchEvents.Reset(Me.match_id)
      _matchGoals.Reset(Me.match_id)
      Me.MatchPeriods.Reset()

      Me.HomeTeam.MatchGoals.Reset(Me.match_id)
      For Each player As Player In Me.HomeTeam.MatchPlayers
        For Each stat As Stat In player.MatchStats.StatBag
          If stat.EventBased Then
            stat.Value = 0
          End If
        Next
      Next

      Me.AwayTeam.MatchGoals.Reset(Me.match_id)
      For Each player As Player In Me.AwayTeam.MatchPlayers
        For Each stat As Stat In player.MatchStats.StatBag
          If stat.EventBased Then
            stat.Value = 0
          End If
        Next
      Next

      Me._home_goals = -1
      Me._away_goals = -1

      RaiseEvent MatchReset()
      RaiseEvent ScoreChanged()
    Catch ex As Exception
      Debug.Print(ex.ToString)
    End Try
  End Sub

  Private Sub _awayTeam_Substitution(sender As Team, subs As Substitution) Handles _awayTeam.SubstitutionAdded
    RaiseEvent Substitution(Me.HomeTeam, subs)
    Me.AddEvent("substitution", Me.AwayTeam.TeamID, subs.PlayerIn.PlayerID, subs.timeInSeconds, subs.PlayerOut.PlayerID)
  End Sub

  Private Sub _homeTeam_Substitution(sender As Team, subs As Substitution) Handles _homeTeam.SubstitutionAdded
    RaiseEvent Substitution(Me.AwayTeam, subs)
    Me.AddEvent("substitution", Me.AwayTeam.TeamID, subs.PlayerIn.PlayerID, subs.timeInSeconds, subs.PlayerOut.PlayerID)
  End Sub

  Private Sub _awayTeam_SubstitutionRemoved(sender As Team, subs As Substitution) Handles _awayTeam.SubstitutionRemoved
    Me.RemoveEvent("substitution", Me.AwayTeam.TeamID, subs.PlayerIn.PlayerID, subs.timeInSeconds, subs.PlayerOut.PlayerID)
  End Sub

  Private Sub _homeTeam_SubstitutionRemoved(sender As Team, subs As Substitution) Handles _homeTeam.SubstitutionRemoved
    Me.RemoveEvent("substitution", Me.AwayTeam.TeamID, subs.PlayerIn.PlayerID, subs.timeInSeconds, subs.PlayerOut.PlayerID)
  End Sub
End Class

