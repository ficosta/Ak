Imports System.Data.OleDb
Imports System.Data.SqlClient

<Serializable()> Public Class Match
  Implements IComparable

  Public Property HomeTeam As Team
  Public Property AwayTeam As Team

  Public Event ScoreChanged()
  Public Event ActivePeriodStateChanged()

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

  Private _home_goals As Integer = 0
  Public Property home_goals As Integer
    Get
      Return _home_goals
    End Get
    Set(value As Integer)
      _home_goals = value
      If Not Me.HomeTeam Is Nothing Then Me.HomeTeam.Goals = value
      RaiseEvent ScoreChanged()
    End Set
  End Property

  Private _away_goals As Integer = 0
  Public Property away_goals As Integer
    Get
      Return _away_goals
    End Get
    Set(value As Integer)
      _away_goals = value
      If Not Me.HomeTeam Is Nothing Then Me.AwayTeam.Goals = value
      RaiseEvent ScoreChanged()
    End Set
  End Property

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
  Public OPTAID As Integer

  Public MatchPeriods As New Periods


  Public AA As String

  Public locked As Boolean

  Public last_update As DateTime


  Private _savetoToDB As Boolean = False
  Public Overloads Property SaveToDB() As Boolean
    Get
      Return _savetoToDB
    End Get
    Set(value As Boolean)
      _savetoToDB = value
      Me.HomeTeam.SaveToDB = value
      Me.AwayTeam.SaveToDB = value
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

  Public Overrides Function ToString() As String
    Return Me.match_date.ToShortDateString & " " & Me.HomeTeam.ToString & " - " & Me.AwayTeam.ToString
  End Function

  Public Function Description() As String
    Return Me.HomeTeam.ToString & " - " & Me.AwayTeam.ToString
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
    'Exit Sub
    Try
      Dim conn As New OleDbConnection(Config.Instance.LocalConnectionString)
      conn.Open()

      Dim SQL As [String] = "SELECT MatchId, AA, MatchDate, TeamID1, TeamID2, Score1, Score2, VenueID, Attendance, CompID, ArabicMatchDescription, ArabicMatchCommentators, OPTAID"
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
          Me.HomeTeam = New Team(Me.match_id, Me.home_team_id, True)
        End If
        If Not myReader.IsDBNull(4) Then
          Me.away_team_id = myReader.GetInt32(4)
          Me.AwayTeam = New Team(Me.match_id, Me.away_team_id, True)
        End If
        If Not myReader.IsDBNull(5) Then Me.home_goals = myReader.GetInt32(5)
        If Not myReader.IsDBNull(6) Then Me.away_goals = myReader.GetInt32(6)
        If Not myReader.IsDBNull(7) Then Me.venue_id = myReader.GetInt32(7)
        If Not myReader.IsDBNull(8) Then Me.attendance = myReader.GetInt32(8)

        If Not myReader.IsDBNull(9) Then Me.competition_id = myReader.GetInt32(9)
        If Not myReader.IsDBNull(10) Then Me.ArabicMatchDescription = myReader.GetString(10)
        If Not myReader.IsDBNull(11) Then Me.ArabicMatchCommentators = myReader.GetString(11)
        If Not myReader.IsDBNull(12) Then Me.OPTAID = myReader.GetInt32(12)
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
      myCmd.Parameters.AddWithValue("@OPTAID", OPTAID)
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
      OPTAID = Source.OPTAID
      HomeTeam = Source.HomeTeam
      AwayTeam = Source.AwayTeam
    Catch err As Exception
      Throw err
    End Try
  End Sub

  Public Function GetMatch() As Boolean
    Return GetFromDB("WHERE MatchID = " & match_id)
  End Function

  Public Sub Update()
    Try
      Dim ActualDb As New Match(match_id)
      If ActualDb.GetMatch() Then
        'UPDATE
        Dim SQL As String = ""
        If ActualDb.AA <> AA AndAlso AA <> "" Then
          SQL += " AA=@AA,"
        End If
        If ActualDb.match_date <> match_date AndAlso match_date.Year > 1900 Then
          SQL += " match_date=@match_date,"
        End If
        If ActualDb.home_team_id <> home_team_id AndAlso home_team_id <> -1 Then
          SQL += " home_team_id=@home_team_id,"
        End If
        If ActualDb.away_team_id <> away_team_id AndAlso away_team_id <> -1 Then
          SQL += " away_team_id=@away_team_id,"
        End If
        If ActualDb.home_goals <> home_goals AndAlso home_goals <> -1 Then
          SQL += " home_goals=@home_goals,"
        End If
        If ActualDb.away_goals <> away_goals AndAlso away_goals <> -1 Then
          SQL += " away_goals=@away_goals,"
        End If
        If ActualDb.venue_id <> venue_id AndAlso venue_id <> -1 Then
          SQL += " venue_id=@venue_id,"
        End If
        If ActualDb.attendance <> attendance AndAlso attendance <> -1 Then
          SQL += " Attendance=@Attendance,"
        End If
        If ActualDb.competition_id <> competition_id AndAlso competition_id <> -1 Then
          SQL += " competition_id=@competition_id,"
        End If
        If ActualDb.ArabicMatchDescription <> ArabicMatchDescription AndAlso ArabicMatchDescription <> "" Then
          SQL += " ArabicMatchDescription=@ArabicMatchDescription,"
        End If
        If ActualDb.ArabicMatchCommentators <> ArabicMatchCommentators AndAlso ArabicMatchCommentators <> "" Then
          SQL += " ArabicMatchCommentators=@ArabicMatchCommentators,"
        End If
        If ActualDb.OPTAID <> OPTAID AndAlso OPTAID <> -1 Then
          SQL += " OPTAID=@OPTAID,"
        End If
        If SQL <> "" Then
          Dim conn As New OleDbConnection(Config.Instance.LocalConnectionString)
          conn.Open()
          Dim myCommand As OleDbCommand = CreateCommand()
          myCommand.Connection = conn
          SQL = SQL.Substring(0, SQL.Length - 1)
          SQL = (Convert.ToString("UPDATE Matches SET") & SQL) + " WHERE MatchID = " + match_id
          myCommand.CommandText = SQL
          myCommand.ExecuteNonQuery()
          conn.Close()
        End If
      Else
        'INSERT
        Dim SQL As String = "INSERT INTO Matches (AA, match_date, home_team_id, away_team_id, home_goals, away_goals, venue_id, Attendance, competition_id, ArabicMatchDescription, ArabicMatchCommentators, OPTAID)"
        SQL += " VALUES (@AA, @match_date, @home_team_id, @away_team_id, @home_goals, @away_goals, @venue_id, @Attendance, @competition_id, @ArabicMatchDescription, @ArabicMatchCommentators, @OPTAID)"
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

  Public Function CompareTo(obj As Object) As Integer Implements IComparable.CompareTo

    If Not TypeOf obj Is Match Then
      Throw New Exception("Object is not of type Match")
    End If

    Return Date.Compare(obj.match_date, Me.match_date)
  End Function
End Class

