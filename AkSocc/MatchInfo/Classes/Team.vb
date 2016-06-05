Imports System.Data.OleDb

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
    TeamID = ID
    Me.ID = ID
    Me.InitStats(match_id, "TeamMatchStats", "TeamID")
    If GetData Then
      GetTeam()
    Else
      InitTeam(ID)
    End If
  End Sub

#End Region

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

  Private Function GetAllPlayers() As Boolean
    Try

      Dim conn As New OleDbConnection(Config.Instance.LocalConnectionString)
      conn.Open()

      Dim mySQL As [String] = "SELECT * FROM Players WHERE DomesticTeamID=" & Me.TeamID ' & Me.TeamID '   TeamID, TeamAELCaption1Name, TeamAELTinyName, TeamTWIRelegationCode, FudgeFactor, TeamPointsDeductions, TeamPreviousPositionInLeague, ArabicCaption1Name, BadgeName"

      Dim CmdSQL As New OleDbCommand(mySQL, conn)

      CmdSQL.CommandType = System.Data.CommandType.Text
      Dim myReader As OleDbDataReader = CmdSQL.ExecuteReader()
      While myReader.Read()
        Dim player As New Player(myReader.GetInt32(myReader.GetOrdinal("PlayerID")))
        'player.GetPlayer()
        Me.AllPlayers.Add(player)
      End While
      myReader.Close()
      conn.Close()
    Catch ex As Exception
    End Try
    Return True
  End Function

  Private Function GetPlayersForMatch() As Boolean
    Dim res = True
    Try
      Dim conn As New OleDbConnection(Config.Instance.LocalConnectionString)
      conn.Open()

      Dim mySQL As [String] = "SELECT * FROM PlayerStats WHERE MatchID = " & Me.Match_ID
      Dim CmdSQL As New OleDbCommand(mySQL, conn)

      CmdSQL.CommandType = System.Data.CommandType.Text
      Dim myReader As OleDbDataReader = CmdSQL.ExecuteReader()
      Me.MatchPlayers.Clear()

      While myReader.Read()
        If Me.AllPlayers.Contains(myReader.GetInt32(myReader.GetOrdinal("PlayerID"))) Then
          Me.MatchPlayers.Add(Me.AllPlayers.GetPlayer(myReader.GetInt32(myReader.GetOrdinal("PlayerID"))))
        End If
      End While
      myReader.Close()
      conn.Close()
    Catch ex As Exception

    End Try
    Return res
  End Function

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
        If player.PlayerPosition <> "" Then
          If player.PlayerPosition = CStr(position) Then res = player
         
        End If

      Next
    Catch ex As Exception
    End Try
    Return res
  End Function
End Class
