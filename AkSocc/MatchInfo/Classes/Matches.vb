

Imports System.Data.OleDb
Imports System.Data.SqlClient

Public Class Matches
  Inherits CollectionBase

  Public Shared Function GetAllMatches() As List(Of Match)
    Dim res As New List(Of Match)
    Try
      Dim conn As New OleDbConnection(Config.Instance.LocalConnectionString)
      conn.Open()

      Dim SQL As [String] = "SELECT MatchId, AA, MatchDate, TeamID1, TeamID2, Score1, Score2, VenueID, Attendance, CompID, ArabicMatchDescription, ArabicMatchCommentators, OPTAID"
      SQL += " FROM Matches "
      SQL += " ORDER BY MatchDate DESC"

      Dim CmdSQL As New OleDbCommand(SQL, conn)

      CmdSQL.CommandType = System.Data.CommandType.Text
      Dim myReader As OleDbDataReader = CmdSQL.ExecuteReader()
      While myReader.Read()
        res.Add(New Match(myReader.GetInt32(0)))
      End While
      conn.Close()
    Catch err As Exception
      'Throw err
    End Try
    Return res
  End Function

  Public Shared Function GetMatchesForCompetition(compId As Integer) As Matches
    Dim res As New Matches
    Try
      Dim conn As New OleDbConnection(Config.Instance.LocalConnectionString)
      conn.Open()

      Dim SQL As [String] = "SELECT MatchId, AA, MatchDate, TeamID1, TeamID2, Score1, Score2, VenueID, Attendance, CompID, ArabicMatchDescription, ArabicMatchCommentators, OPTAID"
      SQL += " FROM Matches "
      SQL += " WHERE CompID = " & compId
      SQL += " ORDER BY MatchDate DESC"

      Dim CmdSQL As New OleDbCommand(SQL, conn)

      CmdSQL.CommandType = System.Data.CommandType.Text
      Dim myReader As OleDbDataReader = CmdSQL.ExecuteReader()
      While myReader.Read()
        res.Add(New Match(myReader.GetInt32(0)))
      End While
      conn.Close()
    Catch err As Exception
      'Throw err
    End Try
    res.sort
    Return res
  End Function


  Public Sub GetFromDB(Where As String)
    Try
      List.Clear()
      Dim conn As New OleDbConnection(Config.Instance.LocalConnectionString)
      conn.Open()

      Dim SQL As [String] = "SELECT MatchId, AA, MatchDate, TeamID1, TeamID2, Score1, Score2, VenueID, Attendance, CompID, ArabicMatchDescription, ArabicMatchCommentators, OPTAID"
      SQL += " FROM Matches "
      SQL += Where.Trim()
      Dim CmdSQL As New OleDbCommand(SQL, conn)

      CmdSQL.CommandType = System.Data.CommandType.Text
      Dim myReader As OleDbDataReader = CmdSQL.ExecuteReader()
      While myReader.Read()
        Dim NewItem As New Match(myReader.GetInt32(0))
        'Dim aa As String = myReader.GetString(1)
        'If Not myReader.IsDBNull(1) Then NewItem.AA = myReader.GetString(1)
        If Not myReader.IsDBNull(2) Then NewItem.match_date = myReader.GetDateTime(2)
        If Not myReader.IsDBNull(3) Then
          NewItem.home_team_id = myReader.GetInt32(3)
          NewItem.HomeTeam = New Team(NewItem.match_id, NewItem.home_team_id, True)
        End If
        If Not myReader.IsDBNull(4) Then
          NewItem.away_team_id = myReader.GetInt32(4)
          NewItem.AwayTeam = New Team(NewItem.match_id, NewItem.away_team_id, True)
        End If
        If Not myReader.IsDBNull(5) Then NewItem.home_goals = myReader.GetInt32(5)
        If Not myReader.IsDBNull(6) Then NewItem.away_goals = myReader.GetInt32(6)
        If Not myReader.IsDBNull(7) Then NewItem.venue_id = myReader.GetInt32(7)
        If Not myReader.IsDBNull(8) Then NewItem.attendance = myReader.GetInt32(8)

        If Not myReader.IsDBNull(9) Then NewItem.competition_id = myReader.GetInt32(9)
        If Not myReader.IsDBNull(10) Then NewItem.ArabicMatchDescription = myReader.GetString(10)
        If Not myReader.IsDBNull(11) Then NewItem.ArabicMatchCommentators = myReader.GetString(11)
        If Not myReader.IsDBNull(12) Then NewItem.OPTAID = myReader.GetInt32(12)

        List.Add(NewItem)
      End While
      conn.Close()
    Catch err As Exception
      Throw err
    End Try
  End Sub

  Public Sub GetFromDBWithDetails(Condition As String)
    Try
      List.Clear()

      Dim conn As New SqlConnection(Config.Instance.LocalConnectionString)
      conn.Open()

      Dim SQL As [String] = "SELECT Match.match_id, Match.competition_id, Match.match_time, Match.matchday, Match.home_team, Match.away_team, Match.date,Match.venue_id, Match.home_goals, Match.away_goals, Match.attendance, Match.state, Match.locked, Match.last_update, HomeTeam.onair_name, AwayTeam.onair_name"
      SQL += " FROM Match, Team as HomeTeam, Team as AwayTeam"
      SQL += " WHERE Match.home_team = HomeTeam.team_id AND Match.away_team = AwayTeam.team_id"
      If Condition <> "" Then
        SQL += Convert.ToString("  AND ") & Condition
      End If

      Dim CmdSQL As New SqlCommand(SQL, conn)

      CmdSQL.CommandType = System.Data.CommandType.Text
      Dim myMatchReader As SqlDataReader = CmdSQL.ExecuteReader()
      While myMatchReader.Read()
        Dim NewMatch As New Match(myMatchReader.GetInt32(0))
        NewMatch.competition_id = myMatchReader.GetInt32(1)
        NewMatch.match_time = myMatchReader.GetInt32(2)
        NewMatch.matchday = myMatchReader.GetInt32(3)
        NewMatch.home_team_id = myMatchReader.GetInt32(4)
        NewMatch.away_team_id = myMatchReader.GetInt32(5)
        NewMatch.[date] = myMatchReader.GetDateTime(6)
        NewMatch.venue_id = myMatchReader.GetInt32(7)
        NewMatch.home_goals = myMatchReader.GetInt32(8)
        NewMatch.away_goals = myMatchReader.GetInt32(9)
        NewMatch.attendance = myMatchReader.GetInt32(10)
        NewMatch.state = myMatchReader.GetString(11)
        NewMatch.locked = myMatchReader.GetBoolean(12)
        NewMatch.last_update = myMatchReader.GetDateTime(13)
        NewMatch.HomeTeamName = myMatchReader.GetString(14)
        NewMatch.AwayTeamName = myMatchReader.GetString(15)
        List.Add(NewMatch)
      End While
      conn.Close()
    Catch err As Exception
      Throw err
    End Try
  End Sub

  Default Public Property Item(Index As Integer) As Match
    Get
      Return DirectCast(List(Index), Match)
    End Get
    Set
      List(Index) = Value
    End Set
  End Property

  Public Function GetMatch(ID As Integer) As Match
    Dim output As Match = Nothing
    Try
      For Each SearchMatch As Match In List
        If SearchMatch.match_id = ID Then
          output = SearchMatch
          Exit For
        End If
      Next
      Return (output)
    Catch err As Exception
      Throw err
    End Try
  End Function

  Public Function Add(match As Match) As Integer
    Return MyBase.InnerList.Add(match)
  End Function

  Public Sub Sort()
    MyBase.InnerList.Sort()
  End Sub
End Class
