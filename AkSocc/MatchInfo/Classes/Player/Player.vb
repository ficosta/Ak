Imports System.Data.OleDb

<Serializable()> Public Class Player
  Inherits StatSubject
  Implements IComparable

  Public PlayerID As Integer
  Public PlayerFirstName As String
  Public PlayerSurname As String
  Public PlayerUniqueName As String
  Public TeamID As Integer
  Public SquadNo As Integer
  Public DomesticTeamID As Integer
  Public DomesticSquadNo As Integer
  Public PlayerPosition As String
  Public InternationalSquadNo As Integer
  Public InternationalTeamID As Integer
  Public InternationalPlayerUniqueName As String
  Public EnglishBiog1 As String
  Public Biog1 As String
  Public EnglishBiog2 As String
  Public Biog2 As String
  Public EnglishBiog3 As String
  Public Biog3 As String
  Public Nationality As String
  Public SeasonGoals As Integer
  Public PhotoName As String
  Public ArabicName As String
  Public VideoName As String
  Public SeasonAppearances As Integer
  Public PhotoName1 As String
  Public VideoName1 As String
  Public VideoName2 As String
  Public SeasonCleanSheets As Integer

  Public IsSubstitution As Boolean = False

  Public optaID As Integer
  Public optaName As String
  Public OptaShortName As String
  Public OptaSquadNumber As String
  Public optaPosition As Integer
  Public optaType As String
  Public optaTeamID As Integer
  Public optaMatchID As Integer

  Public optaStatValueNames As New List(Of String)
  Public optaStatValues As New List(Of String)


#Region "Variables non from the Player table"
  Private team_name As String = ""
  Public ReadOnly Property PlayerName() As String
    Get
      Return Convert.ToString(PlayerFirstName & Convert.ToString(" ")) & PlayerSurname
    End Get
  End Property

  Private _name As String = ""
  Public Overloads Property Name As String
    Get
      If Config.Instance.UseArabicNames Then
        Return Me.ArabicName
      Else
        If MyBase.Name <> "" Then
        Return MyBase.Name
      Else
        Return Me.PlayerUniqueName
        End If
      End If
    End Get
    Set(value As String)
      MyBase.Name = value
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
      Return Me.MatchStats.GoalStat.Value
    End Get
    Set(value As Integer)
      Me.MatchStats.GoalStat.Value = value
    End Set
  End Property

  Public Property Formation_Pos As Integer
    Get
      Return Me.MatchStats.Formation_Pos.Value
    End Get
    Set(value As Integer)
      Me.MatchStats.Formation_Pos.Value = value
    End Set
  End Property

  Public Property Formation_X As Double
    Get
      Return Me.MatchStats.Formation_X.Value
    End Get
    Set(value As Double)
      Me.MatchStats.Formation_X.Value = value
    End Set
  End Property

  Public Property Formation_Y As Double
    Get
      Return Me.MatchStats.Formation_Y.Value
    End Get
    Set(value As Double)
      Me.MatchStats.Formation_Y.Value = value
    End Set
  End Property



#End Region

  Public Sub New()
    InitPlayer(-1)
  End Sub

  Public Sub New(ID As Integer)
    InitPlayer(ID)
  End Sub

#Region "Player info"
  Private Sub InitPlayer(ID As Integer)
    PlayerID = ID
    PlayerFirstName = ""
    PlayerSurname = ""
    PlayerUniqueName = ""
    TeamID = -1
    SquadNo = -1
    DomesticTeamID = -1
    DomesticSquadNo = -1
    PlayerPosition = ""
    InternationalSquadNo = -1
    InternationalTeamID = -1
    InternationalPlayerUniqueName = ""
    EnglishBiog1 = ""
    Biog1 = ""
    EnglishBiog2 = ""
    Biog2 = ""
    EnglishBiog3 = ""
    Biog3 = ""
    Nationality = ""
    YellowCards = -1
    RedCards = -1
    SeasonGoals = -1
    PhotoName = ""
    ArabicName = ""
    VideoName = ""
    SeasonAppearances = -1
    PhotoName1 = ""
    VideoName1 = ""
    VideoName2 = ""
    OptaId = -1
    SeasonCleanSheets = -1

    Formation_Pos = -10
    Formation_X = 0
    Formation_Y = 0

    If ID <> -1 Then Me.GetFromDB()
  End Sub

  Public Function CreateCommand() As OleDbCommand
    Dim myPlayerCmd As New OleDbCommand()
    Try
      myPlayerCmd.Parameters.AddWithValue("@PlayerFirstName", PlayerFirstName)
      myPlayerCmd.Parameters.AddWithValue("@PlayerSurname", PlayerSurname)
      myPlayerCmd.Parameters.AddWithValue("@PlayerUniqueName", PlayerUniqueName)
      myPlayerCmd.Parameters.AddWithValue("@TeamID", TeamID)
      myPlayerCmd.Parameters.AddWithValue("@SquadNo", SquadNo)
      myPlayerCmd.Parameters.AddWithValue("@DomesticTeamID", DomesticTeamID)
      myPlayerCmd.Parameters.AddWithValue("@DomesticSquadNo", DomesticSquadNo)
      myPlayerCmd.Parameters.AddWithValue("@PlayerPosition", PlayerPosition)
      myPlayerCmd.Parameters.AddWithValue("@InternationalSquadNo", InternationalSquadNo)
      myPlayerCmd.Parameters.AddWithValue("@InternationalTeamID", InternationalTeamID)
      myPlayerCmd.Parameters.AddWithValue("@InternationalPlayerUniqueName", InternationalPlayerUniqueName)
      myPlayerCmd.Parameters.AddWithValue("@EnglishBiog1", EnglishBiog1)
      myPlayerCmd.Parameters.AddWithValue("@Biog1", Biog1)
      myPlayerCmd.Parameters.AddWithValue("@EnglishBiog2", EnglishBiog2)
      myPlayerCmd.Parameters.AddWithValue("@Biog2", Biog2)
      myPlayerCmd.Parameters.AddWithValue("@EnglishBiog3", EnglishBiog3)
      myPlayerCmd.Parameters.AddWithValue("@Biog3", Biog3)
      myPlayerCmd.Parameters.AddWithValue("@Nationality", Nationality)
      myPlayerCmd.Parameters.AddWithValue("@YellowCards", YellowCards)
      myPlayerCmd.Parameters.AddWithValue("@RedCards", RedCards)
      myPlayerCmd.Parameters.AddWithValue("@SeasonGoals", SeasonGoals)
      myPlayerCmd.Parameters.AddWithValue("@PhotoName", PhotoName)
      myPlayerCmd.Parameters.AddWithValue("@ArabicName", ArabicName)
      myPlayerCmd.Parameters.AddWithValue("@VideoName", VideoName)
      myPlayerCmd.Parameters.AddWithValue("@SeasonAppearances", SeasonAppearances)
      myPlayerCmd.Parameters.AddWithValue("@PhotoName1", PhotoName1)
      myPlayerCmd.Parameters.AddWithValue("@VideoName1", VideoName1)
      myPlayerCmd.Parameters.AddWithValue("@VideoName2", VideoName2)
      myPlayerCmd.Parameters.AddWithValue("@OptaId", OptaId)
      myPlayerCmd.Parameters.AddWithValue("@SeasonCleanSheets", SeasonCleanSheets)
    Catch err As Exception
      Throw err
    End Try
    Return myPlayerCmd
  End Function

  Public Function GetFromDB() As Boolean
    Try
      Dim conn As New OleDbConnection(Config.Instance.LocalConnectionString)
      conn.Open()

      Dim SQL As [String] = "SELECT PlayerID, PlayerFirstName, PlayerSurname, PlayerUniqueName, TeamID, SquadNo, DomesticTeamID, DomesticSquadNo, PlayerPosition, InternationalSquadNo, InternationalTeamID, InternationalPlayerUniqueName, EnglishBiog1, Biog1, EnglishBiog2, Biog2, EnglishBiog3, Biog3, Nationality, YellowCards, RedCards, SeasonGoals, PhotoName, ArabicName, VideoName, SeasonAppearances, PhotoName1, VideoName1, VideoName2, OptaId, SeasonCleanSheets"
      SQL += " FROM Players "
      SQL += " WHERE PlayerID = " & Me.PlayerID
      Dim CmdSQL As New OleDbCommand(SQL, conn)

      CmdSQL.CommandType = System.Data.CommandType.Text
      Dim myPlayerReader As OleDbDataReader = CmdSQL.ExecuteReader()
      If myPlayerReader.Read() Then
        If Not myPlayerReader.IsDBNull(1) Then
          Me.PlayerFirstName = myPlayerReader.GetString(1)
        End If
        If Not myPlayerReader.IsDBNull(2) Then
          Me.PlayerSurname = myPlayerReader.GetString(2)
        End If
        CType(Me, StatSubject).Name = Me.PlayerFirstName & " " & Me.PlayerSurname
        If Not myPlayerReader.IsDBNull(3) Then
          Me.PlayerUniqueName = myPlayerReader.GetString(3)
          CType(Me, StatSubject).Name = Me.PlayerUniqueName
        End If
        If Not myPlayerReader.IsDBNull(6) Then
          Me.TeamID = myPlayerReader.GetInt32(6)
        End If
        ' EL QUE VALE ES EL DOMESTIC!!! = myPlayerReader.GetInt32(4);
        If Not myPlayerReader.IsDBNull(7) Then
          Me.SquadNo = myPlayerReader.GetInt32(7)
        End If
        ' Y EL DomesticSquadNo
        If Not myPlayerReader.IsDBNull(6) Then
          Me.DomesticTeamID = myPlayerReader.GetInt32(6)
        End If
        If Not myPlayerReader.IsDBNull(7) Then
          Me.DomesticSquadNo = myPlayerReader.GetInt32(7)
        End If
        If Not myPlayerReader.IsDBNull(8) Then
          Me.PlayerPosition = myPlayerReader.GetString(8)
        End If
        If Not myPlayerReader.IsDBNull(9) Then
          Me.InternationalSquadNo = myPlayerReader.GetInt32(9)
        End If
        If Not myPlayerReader.IsDBNull(10) Then
          Me.InternationalTeamID = myPlayerReader.GetInt32(10)
        End If
        If Not myPlayerReader.IsDBNull(11) Then
          Me.InternationalPlayerUniqueName = myPlayerReader.GetString(11)
        End If
        If Not myPlayerReader.IsDBNull(12) Then
          Me.EnglishBiog1 = myPlayerReader.GetString(12)
        End If
        If Not myPlayerReader.IsDBNull(13) Then
          Me.Biog1 = myPlayerReader.GetString(13)
        End If
        If Not myPlayerReader.IsDBNull(14) Then
          Me.EnglishBiog2 = myPlayerReader.GetString(14)
        End If
        If Not myPlayerReader.IsDBNull(15) Then
          Me.Biog2 = myPlayerReader.GetString(15)
        End If
        If Not myPlayerReader.IsDBNull(16) Then
          Me.EnglishBiog3 = myPlayerReader.GetString(16)
        End If
        If Not myPlayerReader.IsDBNull(17) Then
          Me.Biog3 = myPlayerReader.GetString(17)
        End If
        If Not myPlayerReader.IsDBNull(18) Then
          Me.Nationality = myPlayerReader.GetString(18)
        End If
        If Not myPlayerReader.IsDBNull(19) Then
          Me.YellowCards = myPlayerReader.GetInt32(19)
        End If
        If Not myPlayerReader.IsDBNull(20) Then
          Me.RedCards = myPlayerReader.GetInt32(20)
        End If
        If Not myPlayerReader.IsDBNull(21) Then
          Me.SeasonGoals = myPlayerReader.GetInt32(21)
        End If
        If Not myPlayerReader.IsDBNull(22) Then
          Me.PhotoName = myPlayerReader.GetString(22)
        End If
        If Not myPlayerReader.IsDBNull(23) Then
          Me.ArabicName = myPlayerReader.GetString(23)
        End If
        If Not myPlayerReader.IsDBNull(24) Then
          Me.VideoName = myPlayerReader.GetString(24)
        End If
        If Not myPlayerReader.IsDBNull(25) Then
          Me.SeasonAppearances = myPlayerReader.GetInt32(25)
        End If
        If Not myPlayerReader.IsDBNull(26) Then
          Me.PhotoName1 = myPlayerReader.GetString(26)
        End If
        If Not myPlayerReader.IsDBNull(27) Then
          Me.VideoName1 = myPlayerReader.GetString(27)
        End If
        If Not myPlayerReader.IsDBNull(28) Then
          Me.VideoName2 = myPlayerReader.GetString(28)
        End If
        If Not myPlayerReader.IsDBNull(29) Then
          Me.OptaId = myPlayerReader.GetInt32(29)
        End If
        If Not myPlayerReader.IsDBNull(30) Then
          Me.SeasonCleanSheets = myPlayerReader.GetInt32(30)
        End If
      End If

      conn.Close()

    Catch err As Exception
      Throw err
    End Try
    Return True
  End Function

  Public Sub CopyPlayer(SourcePlayer As Player)
    Try
      PlayerID = SourcePlayer.PlayerID
      PlayerFirstName = SourcePlayer.PlayerFirstName
      PlayerSurname = SourcePlayer.PlayerSurname
      PlayerUniqueName = SourcePlayer.PlayerUniqueName
      TeamID = SourcePlayer.TeamID
      SquadNo = SourcePlayer.SquadNo
      DomesticTeamID = SourcePlayer.DomesticTeamID
      DomesticSquadNo = SourcePlayer.DomesticSquadNo
      PlayerPosition = SourcePlayer.PlayerPosition
      InternationalSquadNo = SourcePlayer.InternationalSquadNo
      InternationalTeamID = SourcePlayer.InternationalTeamID
      InternationalPlayerUniqueName = SourcePlayer.InternationalPlayerUniqueName
      EnglishBiog1 = SourcePlayer.EnglishBiog1
      Biog1 = SourcePlayer.Biog1
      EnglishBiog2 = SourcePlayer.EnglishBiog2
      Biog2 = SourcePlayer.Biog2
      EnglishBiog3 = SourcePlayer.EnglishBiog3
      Biog3 = SourcePlayer.Biog3
      Nationality = SourcePlayer.Nationality
      YellowCards = SourcePlayer.YellowCards
      RedCards = SourcePlayer.RedCards
      SeasonGoals = SourcePlayer.SeasonGoals
      PhotoName = SourcePlayer.PhotoName
      ArabicName = SourcePlayer.ArabicName
      VideoName = SourcePlayer.VideoName
      SeasonAppearances = SourcePlayer.SeasonAppearances
      PhotoName1 = SourcePlayer.PhotoName1
      VideoName1 = SourcePlayer.VideoName1
      VideoName2 = SourcePlayer.VideoName2
      OptaId = SourcePlayer.OptaId
      SeasonCleanSheets = SourcePlayer.SeasonCleanSheets
    Catch err As Exception
      Throw err
    End Try
  End Sub

  Public Function GetPlayer() As Boolean
    Return GetFromDB()
  End Function

  Public Sub UpdatePlayer()
    Try
      Dim ActualDb As New Player(PlayerID)
      If ActualDb.GetPlayer() Then
        'UPDATE
        Dim SQL As String = ""
        If ActualDb.PlayerFirstName <> PlayerFirstName AndAlso PlayerFirstName <> "" Then
          SQL += " PlayerFirstName=@PlayerFirstName,"
        End If
        If ActualDb.PlayerSurname <> PlayerSurname AndAlso PlayerSurname <> "" Then
          SQL += " PlayerSurname=@PlayerSurname,"
        End If
        If ActualDb.PlayerUniqueName <> PlayerUniqueName AndAlso PlayerUniqueName <> "" Then
          SQL += " PlayerUniqueName=@PlayerUniqueName,"
        End If
        If ActualDb.TeamID <> TeamID AndAlso TeamID <> -1 Then
          SQL += " TeamID=@TeamID,"
        End If
        If ActualDb.DomesticTeamID <> DomesticTeamID AndAlso DomesticTeamID <> -1 Then
          SQL += " DomesticTeamID=@DomesticTeamID,"
        End If
        If ActualDb.DomesticSquadNo <> DomesticSquadNo AndAlso DomesticSquadNo <> -1 Then
          SQL += " DomesticSquadNo=@DomesticSquadNo,"
        End If
        If ActualDb.PlayerPosition <> PlayerPosition AndAlso PlayerPosition <> "" Then
          SQL += " PlayerPosition=@PlayerPosition,"
        End If
        If ActualDb.InternationalSquadNo <> InternationalSquadNo AndAlso InternationalSquadNo <> -1 Then
          SQL += " InternationalSquadNo=@InternationalSquadNo,"
        End If
        If ActualDb.InternationalTeamID <> InternationalTeamID AndAlso InternationalTeamID <> -1 Then
          SQL += " InternationalTeamID=@InternationalTeamID,"
        End If
        If ActualDb.InternationalPlayerUniqueName <> InternationalPlayerUniqueName AndAlso InternationalPlayerUniqueName <> "" Then
          SQL += " InternationalPlayerUniqueName=@InternationalPlayerUniqueName,"
        End If
        If ActualDb.EnglishBiog1 <> EnglishBiog1 AndAlso EnglishBiog1 <> "" Then
          SQL += " EnglishBiog1=@EnglishBiog1,"
        End If
        If ActualDb.Biog1 <> Biog1 AndAlso Biog1 <> "" Then
          SQL += " Biog1=@Biog1,"
        End If
        If ActualDb.EnglishBiog2 <> EnglishBiog2 AndAlso EnglishBiog2 <> "" Then
          SQL += " EnglishBiog2=@EnglishBiog2,"
        End If
        If ActualDb.Biog2 <> Biog2 AndAlso Biog2 <> "" Then
          SQL += " Biog2=@Biog2,"
        End If
        If ActualDb.EnglishBiog3 <> EnglishBiog3 AndAlso EnglishBiog3 <> "" Then
          SQL += " EnglishBiog3=@EnglishBiog3,"
        End If
        If ActualDb.Biog3 <> Biog3 AndAlso Biog3 <> "" Then
          SQL += " Biog3=@Biog3,"
        End If
        If ActualDb.Nationality <> Nationality AndAlso Nationality <> "" Then
          SQL += " Nationality=@Nationality,"
        End If
        If ActualDb.YellowCards <> YellowCards AndAlso YellowCards <> -1 Then
          SQL += " YellowCards=" & YellowCards.ToString() & ","
        End If
        If ActualDb.RedCards <> RedCards AndAlso RedCards <> -1 Then
          SQL += " RedCards=" & RedCards.ToString() & ","
        End If
        If ActualDb.SeasonGoals <> SeasonGoals AndAlso SeasonGoals <> -1 Then
          SQL += " SeasonGoals=" & SeasonGoals.ToString() & ","
        End If
        If ActualDb.PhotoName <> PhotoName AndAlso PhotoName <> "" Then
          SQL += " PhotoName=@PhotoName,"
        End If
        If ActualDb.ArabicName <> ArabicName AndAlso ArabicName <> "" Then
          SQL += " ArabicName=@ArabicName,"
        End If
        If ActualDb.VideoName <> VideoName AndAlso VideoName <> "" Then
          SQL += " VideoName=@VideoName,"
        End If
        If ActualDb.SeasonAppearances <> SeasonAppearances AndAlso SeasonAppearances <> -1 Then
          SQL += " SeasonAppearances=@SeasonAppearances,"
        End If
        If ActualDb.PhotoName1 <> PhotoName1 AndAlso PhotoName1 <> "" Then
          SQL += " PhotoName1=@PhotoName1,"
        End If
        If ActualDb.VideoName1 <> VideoName1 AndAlso VideoName1 <> "" Then
          SQL += " VideoName1=@VideoName1,"
        End If
        If ActualDb.VideoName2 <> VideoName2 AndAlso VideoName2 <> "" Then
          SQL += " VideoName2=@VideoName2,"
        End If
        If ActualDb.OptaId <> OptaId AndAlso OptaId <> -1 Then
          SQL += " OptaId=" & optaID & ","
        End If
        If ActualDb.SeasonCleanSheets <> SeasonCleanSheets AndAlso SeasonCleanSheets <> -1 Then
          SQL += " SeasonCleanSheets=@SeasonCleanSheets,"
        End If

        If SQL <> "" Then
          Dim myCommand As OleDbCommand = CreateCommand()
          Dim conn As New OleDbConnection(Config.Instance.LocalConnectionString)
          conn.Open()
          myCommand.Connection = conn
          SQL = SQL.Substring(0, SQL.Length - 1)
          SQL = (Convert.ToString("UPDATE Players SET") & SQL) & " WHERE PlayerID = " & PlayerID
          '                        SQL = "UPDATE Players SET PlayerFirstName=@PlayerFirstName, PlayerSurname=@PlayerSurname, PlayerUniqueName=@PlayerUniqueName, TeamID=@TeamID, DomesticTeamID=@DomesticTeamID, DomesticSquadNo=@DomesticSquadNo, PlayerPosition=@PlayerPosition, InternationalSquadNo=@InternationalSquadNo, InternationalTeamID=@InternationalTeamID, InternationalPlayerUniqueName=@InternationalPlayerUniqueName, EnglishBiog1=@EnglishBiog1, Biog1=@Biog1, EnglishBiog2=@EnglishBiog2, Biog2=@Biog2, EnglishBiog3=@EnglishBiog3, Biog3=@Biog3, Nationality=@Nationality, YellowCards=@YellowCards, RedCards=@RedCards, SeasonGoals=@SeasonGoals, PhotoName=@PhotoName, ArabicName=@ArabicName, VideoName=@VideoName, SeasonAppearances=@SeasonAppearances, PhotoName1=@PhotoName1, VideoName1=@VideoName1, VideoName2=@VideoName2, OptaId=@OptaId, SeasonCleanSheets=@SeasonCleanSheets WHERE PlayerID=" & PlayerID;

          myCommand.CommandText = SQL
          myCommand.ExecuteNonQuery()
          conn.Close()
        End If
      Else
        'INSERT
        Dim SQL As String = "INSERT INTO Players (PlayerFirstName, PlayerSurname, PlayerUniqueName, TeamID, SquadNo, DomesticTeamID, DomesticSquadNo, PlayerPosition, InternationalSquadNo, InternationalTeamID, InternationalPlayerUniqueName, EnglishBiog1, Biog1, EnglishBiog2, Biog2, EnglishBiog3, Biog3, Nationality, YellowCards, RedCards, SeasonGoals, PhotoName, ArabicName, VideoName, SeasonAppearances, PhotoName1, VideoName1, VideoName2, OptaId, SeasonCleanSheets)"
        SQL += " VALUES (@PlayerFirstName, @PlayerSurname, @PlayerUniqueName, @TeamID, @SquadNo, @DomesticTeamID, @DomesticSquadNo, @PlayerPosition, @InternationalSquadNo, @InternationalTeamID, @InternationalPlayerUniqueName, @EnglishBiog1, @Biog1, @EnglishBiog2, @Biog2, @EnglishBiog3, @Biog3, @Nationality, @YellowCards, @RedCards, @SeasonGoals, @PhotoName, @ArabicName, @VideoName, @SeasonAppearances, @PhotoName1, @VideoName1, @VideoName2, @OptaId, @SeasonCleanSheets)"
        Dim conn As New OleDbConnection(Config.Instance.LocalConnectionString)
        conn.Open()
        Dim cmdPlayer2 As OleDbCommand = CreateCommand()
        cmdPlayer2.CommandText = SQL
        cmdPlayer2.Connection = conn
        cmdPlayer2.ExecuteNonQuery()
        conn.Close()
      End If
    Catch err As Exception
      Throw err
    End Try
  End Sub

#End Region

#Region "Player stats"
  Public Function optaGetValue(valueName As String) As String
    Dim res As String = "0"
    Try
      For i As Integer = 0 To Me.optaStatValueNames.Count - 1
        If optaStatValueNames(i) = valueName Then
          res = optaStatValues(i)
        End If
      Next
    Catch ex As Exception
    End Try
    Return res
  End Function
#End Region

  Public Overrides Function ToString() As String
    If SquadNo <> "-1" And PlayerName <> "" Then
      Return Convert.ToString(SquadNo.ToString() & " ") & PlayerName
    Else

      Return Convert.ToString(OptaSquadNumber.ToString() & " ") & optaName & " (opta)"

    End If
  End Function

  Public Function CompareTo(obj As Object) As Integer Implements IComparable.CompareTo
    Dim res As Integer = 0
    Try
      Dim aux As Player = CType(obj, Player)
      If aux.Formation_Pos < Me.Formation_Pos Then
        res = 1
      ElseIf aux.Formation_Pos > Me.Formation_Pos Then
        res = -1
      End If

    Catch ex As Exception

    End Try
    Return res
  End Function

  Public Sub Copy(source As Player)
    Try
      Me.ArabicName = source.ArabicName


    Catch ex As Exception

    End Try

  End Sub
End Class

