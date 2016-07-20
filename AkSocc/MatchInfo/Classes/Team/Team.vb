Imports System.Data.OleDb
Imports MatchInfo

<Serializable()> Public Class Team
  Inherits StatSubject

  Public Property MatchPlayers As New Players
  Public Property AllPlayers As New Players
  Public Property Substitutions As New Substitutions

  Public TeamID As Integer
  Public TeamAELCaption1Name As String
  Public TeamAELTinyName As String
  Public TeamTWIRelegationCode As String
  Public FudgeFactor As Integer
  Public TeamPointsDeductions As Integer
  Public TeamPreviousPositionInLeague As Integer
  Public ArabicCaption1Name As String
  Public BadgeName As String
  Public GoalKeeperJersey As String
  Public PlayerJersey As String
  Public TeamClockColour As String
  Public Tactic As New Tactic

  Public MatchGoals As New MatchGoals


  Public Event PlayerStatValueChanged(team As Team, player As Player, stat As Stat)
  Public Event GoalScored(team As Team, player As Player, own_goal As Boolean, penalty As Boolean)

#Region "Overloaded properties"
  Private _name As String = ""
  Public Overloads Property Name As String
    Get
      If Config.Instance.UseArabicNames Then
        Return Me.ArabicCaption1Name
      Else
        Return Me.TeamAELCaption1Name
      End If
    End Get
    Set(value As String)
      _name = value
    End Set
  End Property

  Private _savetoToDB As Boolean = False
  Public Overloads Property SaveToDBEnabled() As Boolean
    Get
      Return _savetoToDB
    End Get
    Set(value As Boolean)
      _savetoToDB = value
      For Each player As Player In Me.AllPlayers
        player.SaveToDB = _savetoToDB
      Next
    End Set
  End Property
#End Region

#Region "Direct access to stats"
  Public Property YellowCards As Integer
    Get
      Return Me.MatchStats.YellowCards.Value
    End Get
    Set(value As Integer)
      Me.MatchStats.YellowCards.Value = value
    End Set
  End Property

  Public Property RedCards As Integer
    Get
      Return Me.MatchStats.RedCards.Value
    End Get
    Set(value As Integer)
      Me.MatchStats.RedCards.Value = value
    End Set
  End Property

  Public Property Goals As Integer
    Get
      If Not Me.MatchGoals Is Nothing Then
        Return Me.MatchGoals.Count
      Else
        Return Me.MatchStats.GoalStat.Value
      End If
    End Get
    Set(value As Integer)
      Me.MatchStats.GoalStat.Value = value
    End Set
  End Property


#End Region

#Region "Constructors"
  Public Sub New()
    InitTeam(-1)
  End Sub
  Public Sub New(ID As Integer)
    InitTeam(ID)
  End Sub
  Public Sub New(ID As Integer, GetData As Boolean)
    TeamID = ID
    If GetData Then
      GetTeam()
    Else
      InitTeam(ID)
    End If
  End Sub

  Public Sub New(match_id As Integer, ID As Integer, GetData As Boolean)
    Try
      TeamID = ID
      Me.ID = ID
      Me.InitStats(match_id, "TeamMatchStats", "TeamID")
      GetTeam()
      If GetData Then
        If Not Me.MatchGoals Is Nothing Then Me.MatchGoals.GetMatchGoals(match_id, Me.ID)
      Else
        '  InitTeam(ID)
      End If
    Catch ex As Exception
      Debug.Print(ex.ToString)
    End Try

  End Sub

#End Region

#Region "General functions"
  Public Sub InitTeam(ID As Integer)
    TeamID = ID
    TeamAELCaption1Name = ""
    TeamAELTinyName = ""
    TeamTWIRelegationCode = ""
    FudgeFactor = -1
    TeamPointsDeductions = -1
    TeamPreviousPositionInLeague = -1
    ArabicCaption1Name = ""
    BadgeName = ""
    GoalKeeperJersey = ""
    PlayerJersey = ""
    TeamClockColour = ""
  End Sub

  Public Function CreateCommand() As OleDbCommand
    Dim myCmd As New OleDbCommand()
    Try
      'Add the parameters
      myCmd.Parameters.AddWithValue("@TeamAELCaption1Name", TeamAELCaption1Name)
      myCmd.Parameters.AddWithValue("@TeamAELTinyName", TeamAELTinyName)
      myCmd.Parameters.AddWithValue("@TeamTWIRelegationCode", TeamTWIRelegationCode)
      myCmd.Parameters.AddWithValue("@FudgeFactor", FudgeFactor)
      myCmd.Parameters.AddWithValue("@TeamPointsDeductions", TeamPointsDeductions)
      myCmd.Parameters.AddWithValue("@TeamPreviousPositionInLeague", TeamPreviousPositionInLeague)
      myCmd.Parameters.AddWithValue("@ArabicCaption1Name", ArabicCaption1Name)
      myCmd.Parameters.AddWithValue("@BadgeName", BadgeName)
    Catch err As Exception
      Throw err
    End Try
    Return myCmd
  End Function

  Private Function GetFromDB(Where As String) As Boolean
    Try
      Dim myDatabase As New Teams()
      myDatabase.GetFromDB(Where)
      If myDatabase.Count = 0 Then
        Return False
      End If

      CopyTeam(DirectCast(myDatabase(0), Team))
    Catch err As Exception
      Throw err
    End Try
    Return True
  End Function

  Public Sub CopyTeam(Source As Team)
    Try
      TeamID = Source.TeamID
      TeamAELCaption1Name = Source.TeamAELCaption1Name
      TeamAELTinyName = Source.TeamAELTinyName
      TeamTWIRelegationCode = Source.TeamTWIRelegationCode
      FudgeFactor = Source.FudgeFactor
      TeamPointsDeductions = Source.TeamPointsDeductions
      TeamPreviousPositionInLeague = Source.TeamPreviousPositionInLeague
      ArabicCaption1Name = Source.ArabicCaption1Name
      BadgeName = Source.BadgeName
    Catch err As Exception
      Throw err
    End Try
  End Sub

  Public Function GetTeam() As Boolean
    'GetAllPlayers()
    GetFromDB("WHERE TeamID = " & TeamID)
    Return True
  End Function

  Public Sub GetFullMatchData()
    GetAllPlayers()
    GetPlayersForMatch()
    InitStats(Match_ID, "TeamMatchStats", "teamID")
    ReadStatsFromDB()

  End Sub

  Public Function GetAllPlayers() As Boolean
    Try

      Dim conn As New OleDbConnection(Config.Instance.LocalConnectionString)
      conn.Open()

      Dim mySQL As [String] = "SELECT * FROM Players WHERE DomesticTeamID=" & Me.TeamID ' & Me.TeamID '   TeamID, TeamAELCaption1Name, TeamAELTinyName, TeamTWIRelegationCode, FudgeFactor, TeamPointsDeductions, TeamPreviousPositionInLeague, ArabicCaption1Name, BadgeName"

      Dim CmdSQL As New OleDbCommand(mySQL, conn)

      CmdSQL.CommandType = System.Data.CommandType.Text
      Dim myReader As OleDbDataReader = CmdSQL.ExecuteReader()
      While myReader.Read()

        Dim player As New Player(myReader.GetInt32(myReader.GetOrdinal("PlayerID")))
        player.ID = player.PlayerID
        player.InitStats(Me.Match_ID, "PlayerStats", "PlayerID")
        player.ReadStatsFromDB()
        AddHandler player.StatValueChanged, AddressOf player_statValueChanged
        'player.GetPlayer()

        Me.AllPlayers.Add(player)
      End While
      myReader.Close()
      conn.Close()
    Catch ex As Exception
    End Try
    Return True
  End Function

  Private Sub player_statValueChanged(sender As StatSubject, stat As Stat)
    Try
      If Me.SaveToDBEnabled Then
        ' Me.WriteStatsToDB()
      End If
    Catch ex As Exception

    End Try
  End Sub

  Public Function GetPlayersForMatch() As Boolean
    Dim res = True
    Try
      _updating = True

      Dim conn As New OleDbConnection(Config.Instance.LocalConnectionString)
      conn.Open()

      Dim mySQL As [String] = "SELECT * FROM PlayerStats WHERE MatchID = " & Me.Match_ID
      Dim CmdSQL As New OleDbCommand(mySQL, conn)

      CmdSQL.CommandType = System.Data.CommandType.Text
      Dim myReader As OleDbDataReader = CmdSQL.ExecuteReader()
      Me.MatchPlayers.Clear()

      While myReader.Read()
        If Me.AllPlayers.Contains(myReader.GetInt32(myReader.GetOrdinal("PlayerID"))) Then
          Dim player As Player = Me.AllPlayers.GetPlayer(myReader.GetInt32(myReader.GetOrdinal("PlayerID")))
          Me.MatchPlayers.Add(player)
          AddHandler player.StatValueChanged, AddressOf _player_StatValueChanged
        End If
      End While
      myReader.Close()
      conn.Close()

      Me.MatchPlayers.Sort()
      For Each stat As Stat In Me.MatchStats.StatBag
        Me.UpdateStatFromPlayers(stat.Name)
      Next

      'update tactic
      Me.Tactic = New Tactic()
      Me.Tactic.NomTactic = "Custom"
      Me.Tactic.Descripcio = Me.TeamAELCaption1Name

      For Each pos As PosicioTactic In Me.Tactic.LlistaPosicions
        Dim player As Player = Me.GetPlayerByPosicio(pos.Posicio)
        If Not player Is Nothing Then
          pos.X = player.Formation_X
          pos.Y = player.Formation_Y
          pos.Player = player
        End If
      Next
    Catch ex As Exception

    End Try
    _updating = False
    Return res
  End Function

#Region "Update stat from players"
  Private _updating As Boolean = False
  Private Sub _player_StatValueChanged(sender As StatSubject, stat As Stat)
    Try
      If _updating = True Then Exit Sub

      UpdateStatFromPlayers(stat.Name)
    Catch ex As Exception

    End Try
  End Sub

  Public Function UpdateStatFromPlayers(statName As String) As Stat
    Dim destStat As Stat = Nothing
    Try
      Dim value As Double = 0
      destStat = Me.GetMatchStatByName(statName)
      If Not destStat Is Nothing Then
        For Each player As Player In Me.MatchPlayers
          Dim aux As Stat = player.GetMatchStatByName(statName)
          If Not aux Is Nothing Then
            value += aux.Value
            If aux.Value <> 0 Then
              Debug.Print(player.ToString & " " & aux.Value)
            End If
          End If
        Next
        destStat.Value = value
        Me.Update()
      End If
    Catch ex As Exception
    End Try
    Return destStat
  End Function
#End Region

  Public Sub Update()
    Try
      Dim ActualDb As New Team(TeamID)
      If ActualDb.GetTeam() Then
        'UPDATE
        Dim SQL As String = ""
        If ActualDb.TeamAELCaption1Name <> TeamAELCaption1Name AndAlso TeamAELCaption1Name <> "" Then
          SQL += " TeamAELCaption1Name=@TeamAELCaption1Name, "
        End If
        If ActualDb.TeamAELTinyName <> TeamAELTinyName AndAlso TeamAELTinyName <> "" Then
          SQL += " TeamAELTinyName=@TeamAELTinyName, "
        End If
        If ActualDb.TeamTWIRelegationCode <> TeamTWIRelegationCode AndAlso TeamTWIRelegationCode <> "" Then
          SQL += " TeamTWIRelegationCode=@TeamTWIRelegationCode, "
        End If
        If ActualDb.FudgeFactor <> FudgeFactor AndAlso FudgeFactor <> -1 Then
          SQL += " FudgeFactor=@FudgeFactor, "
        End If
        If ActualDb.TeamPointsDeductions <> TeamPointsDeductions AndAlso TeamPointsDeductions <> -1 Then
          SQL += " TeamPointsDeductions=@TeamPointsDeductions, "
        End If
        If ActualDb.TeamPreviousPositionInLeague <> TeamPreviousPositionInLeague AndAlso TeamPreviousPositionInLeague <> -1 Then
          SQL += " TeamPreviousPositionInLeague=@TeamPreviousPositionInLeague, "
        End If
        If ActualDb.ArabicCaption1Name <> ArabicCaption1Name AndAlso ArabicCaption1Name <> "" Then
          SQL += " ArabicCaption1Name=@ArabicCaption1Name, "
        End If
        If ActualDb.BadgeName <> BadgeName AndAlso BadgeName <> "" Then
          SQL += " BadgeName=@BadgeName, "
        End If
        If SQL <> "" Then
          Dim conn As New OleDbConnection(Config.Instance.LocalConnectionString)
          conn.Open()
          Dim myCommand As OleDbCommand = CreateCommand()
          myCommand.Connection = conn
          SQL = SQL.Substring(0, SQL.Length - 1)
          SQL = (Convert.ToString("UPDATE Teams Set") & SQL) + " WHERE TeamID = " + TeamID
          myCommand.CommandText = SQL
          myCommand.ExecuteNonQuery()
          conn.Close()
        End If
      Else
        'INSERT
        Dim SQL As String = "INSERT INTO Teams (TeamAELCaption1Name, TeamAELTinyName, TeamTWIRelegationCode, FudgeFactor, TeamPointsDeductions, TeamPreviousPositionInLeague, ArabicCaption1Name, BadgeName)"
        SQL += " VALUES (@TeamAELCaption1Name, @TeamAELTinyName, @TeamTWIRelegationCode, @FudgeFactor, @TeamPointsDeductions, @TeamPreviousPositionInLeague, @ArabicCaption1Name, @BadgeName)"
        Dim conn As New OleDbConnection(Config.Instance.LocalConnectionString)
        conn.Open()
        Dim cmdExecute As OleDbCommand = CreateCommand()
        cmdExecute.CommandText = SQL
        cmdExecute.Connection = conn
        cmdExecute.ExecuteNonQuery()
        conn.Close()
      End If
    Catch err As Exception
      Throw err
    End Try
  End Sub

  Public Overrides Function ToString() As String
    Return TeamAELCaption1Name
  End Function

  Public Function GetPlayerById(ID As Integer) As Player
    Dim res As Player = Nothing
    Try

      For Each player As Player In Me.AllPlayers
        If player.ID = ID Then res = player
        If player.PlayerID = ID Then res = player
      Next
    Catch ex As Exception
    End Try
    Return res
  End Function

  Public Function GetPlayerByPosicio(position As Integer) As Player
    Dim res As Player = Nothing
    Try

      For Each player As Player In Me.AllPlayers
        If player.MatchStats.Formation_Pos.Value = position Then res = player
      Next
    Catch ex As Exception
    End Try
    Return res
  End Function

  Public Sub GetDataFromDB()
    Try
      Me.ReadStatsFromDB()
      Me.MatchGoals.GetMatchGoals(Me.Match_ID, Me.ID)
      For Each player As Player In Me.AllPlayers
     '   player.ReadStatsFromDB()
        player.Goals = Me.MatchGoals.GetGoalsByPlayer(player).Count
      Next
      Me.Goals = Me.MatchGoals.Count
    Catch ex As Exception

    End Try
  End Sub
#End Region

#Region "Stat functions and events"
  Private Sub Team_StatValueChanged(sender As StatSubject, stat As Stat) Handles Me.StatValueChanged
    Try
      RaiseEvent PlayerStatValueChanged(Me, Nothing, stat)
    Catch ex As Exception

    End Try
  End Sub

  Public Sub AddGoal(player As Player, own_goal As Boolean, penalty As Boolean)
       RaiseEvent GoalScored(Me, player, own_goal, penalty)
  End Sub

  Public Sub UpdateGoal(goalID As Integer, player As Player, own_goal As Boolean, penalty As Boolean)

  End Sub
#End Region

End Class
