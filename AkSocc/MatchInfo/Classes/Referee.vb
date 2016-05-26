Imports System.Data.OleDb

Public Class Referee

  Public RefereeID As Integer
  Public RefereeFirstName As String
  Public RefereeSurname As String
  Public RefereeUniqueName As String

  'Variables non from the Referee table
  Public ReadOnly Property RefereeName() As String
    Get
      Return Convert.ToString(RefereeFirstName & Convert.ToString(" ")) & RefereeSurname
    End Get
  End Property

  Public Sub New()
    InitReferee(-1)
  End Sub

  Public Sub New(ID As Integer)
    InitReferee(ID)
  End Sub

#Region "Referee info"
  Private Sub InitReferee(ID As Integer)
    RefereeID = ID
    RefereeFirstName = ""
    RefereeSurname = ""
    RefereeUniqueName = ""

    Me.GetFromDB()
  End Sub

  Public Function CreateCommand() As OleDbCommand
    Dim myRefereeCmd As New OleDbCommand()
    Try
      myRefereeCmd.Parameters.AddWithValue("@RefereeFirstName", RefereeFirstName)
      myRefereeCmd.Parameters.AddWithValue("@RefereeSurname", RefereeSurname)
      myRefereeCmd.Parameters.AddWithValue("@RefereeUniqueName", RefereeUniqueName)
    Catch err As Exception
      Throw err
    End Try
    Return myRefereeCmd
  End Function

  Public Function GetFromDB() As Boolean
    Try
      Dim conn As New OleDbConnection(Config.Instance.LocalConnectionString)
      conn.Open()

      Dim SQL As [String] = "SELECT RefereeID, RefereeFirstName, RefereeSurname, RefereeUniqueName, TeamID, SquadNo, DomesticTeamID, DomesticSquadNo, RefereePosition, InternationalSquadNo, InternationalTeamID, InternationalRefereeUniqueName, EnglishBiog1, Biog1, EnglishBiog2, Biog2, EnglishBiog3, Biog3, Nationality, YellowCards, RedCards, SeasonGoals, PhotoName, ArabicName, VideoName, SeasonAppearances, PhotoName1, VideoName1, VideoName2, OptaId, SeasonCleanSheets"
      SQL += " FROM Referees "
      SQL += " WHERE RefereeID = " & Me.RefereeID
      Dim CmdSQL As New OleDbCommand(SQL, conn)

      CmdSQL.CommandType = System.Data.CommandType.Text
      Dim myRefereeReader As OleDbDataReader = CmdSQL.ExecuteReader()
      If myRefereeReader.Read() Then
        If Not myRefereeReader.IsDBNull(1) Then
          Me.RefereeFirstName = myRefereeReader.GetString(1)
        End If
        If Not myRefereeReader.IsDBNull(2) Then
          Me.RefereeSurname = myRefereeReader.GetString(2)
        End If
        If Not myRefereeReader.IsDBNull(3) Then
          Me.RefereeUniqueName = myRefereeReader.GetString(3)
        End If
      End If
      conn.Close()
    Catch err As Exception
      Throw err
    End Try
    Return True
  End Function

  Public Sub CopyReferee(SourceReferee As Referee)
    Try
      RefereeID = SourceReferee.RefereeID
      RefereeFirstName = SourceReferee.RefereeFirstName
      RefereeSurname = SourceReferee.RefereeSurname
      RefereeUniqueName = SourceReferee.RefereeUniqueName
    Catch err As Exception
      Throw err
    End Try
  End Sub

  Public Function GetReferee() As Boolean
    Return GetFromDB()
  End Function

  Public Sub UpdateReferee()
    Try
      Dim ActualDb As New Referee(RefereeID)
      If ActualDb.GetReferee() Then
        'UPDATE
        Dim SQL As String = ""
        If ActualDb.RefereeFirstName <> RefereeFirstName AndAlso RefereeFirstName <> "" Then
          SQL += " RefereeFirstName=@RefereeFirstName,"
        End If
        If ActualDb.RefereeSurname <> RefereeSurname AndAlso RefereeSurname <> "" Then
          SQL += " RefereeSurname=@RefereeSurname,"
        End If
        If ActualDb.RefereeUniqueName <> RefereeUniqueName AndAlso RefereeUniqueName <> "" Then
          SQL += " RefereeUniqueName=@RefereeUniqueName,"
        End If

        If SQL <> "" Then
          Dim myCommand As OleDbCommand = CreateCommand()
          Dim conn As New OleDbConnection(Config.Instance.LocalConnectionString)
          conn.Open()
          myCommand.Connection = conn
          SQL = SQL.Substring(0, SQL.Length - 1)
          SQL = (Convert.ToString("UPDATE Referees SET") & SQL) + " WHERE RefereeID = " + RefereeID
          '                        SQL = "UPDATE Referees SET RefereeFirstName=@RefereeFirstName, RefereeSurname=@RefereeSurname, RefereeUniqueName=@RefereeUniqueName, TeamID=@TeamID, DomesticTeamID=@DomesticTeamID, DomesticSquadNo=@DomesticSquadNo, RefereePosition=@RefereePosition, InternationalSquadNo=@InternationalSquadNo, InternationalTeamID=@InternationalTeamID, InternationalRefereeUniqueName=@InternationalRefereeUniqueName, EnglishBiog1=@EnglishBiog1, Biog1=@Biog1, EnglishBiog2=@EnglishBiog2, Biog2=@Biog2, EnglishBiog3=@EnglishBiog3, Biog3=@Biog3, Nationality=@Nationality, YellowCards=@YellowCards, RedCards=@RedCards, SeasonGoals=@SeasonGoals, PhotoName=@PhotoName, ArabicName=@ArabicName, VideoName=@VideoName, SeasonAppearances=@SeasonAppearances, PhotoName1=@PhotoName1, VideoName1=@VideoName1, VideoName2=@VideoName2, OptaId=@OptaId, SeasonCleanSheets=@SeasonCleanSheets WHERE RefereeID=" + RefereeID;

          myCommand.CommandText = SQL
          myCommand.ExecuteNonQuery()
          conn.Close()
        End If
      Else
        'INSERT
        Dim SQL As String = "INSERT INTO Referees (RefereeFirstName, RefereeSurname, RefereeUniqueName, TeamID, SquadNo, DomesticTeamID, DomesticSquadNo, RefereePosition, InternationalSquadNo, InternationalTeamID, InternationalRefereeUniqueName, EnglishBiog1, Biog1, EnglishBiog2, Biog2, EnglishBiog3, Biog3, Nationality, YellowCards, RedCards, SeasonGoals, PhotoName, ArabicName, VideoName, SeasonAppearances, PhotoName1, VideoName1, VideoName2, OptaId, SeasonCleanSheets)"
        SQL += " VALUES (@RefereeFirstName, @RefereeSurname, @RefereeUniqueName, @TeamID, @SquadNo, @DomesticTeamID, @DomesticSquadNo, @RefereePosition, @InternationalSquadNo, @InternationalTeamID, @InternationalRefereeUniqueName, @EnglishBiog1, @Biog1, @EnglishBiog2, @Biog2, @EnglishBiog3, @Biog3, @Nationality, @YellowCards, @RedCards, @SeasonGoals, @PhotoName, @ArabicName, @VideoName, @SeasonAppearances, @PhotoName1, @VideoName1, @VideoName2, @OptaId, @SeasonCleanSheets)"
        Dim conn As New OleDbConnection(Config.Instance.LocalConnectionString)
        conn.Open()
        Dim cmdReferee2 As OleDbCommand = CreateCommand()
        cmdReferee2.CommandText = SQL
        cmdReferee2.Connection = conn
        cmdReferee2.ExecuteNonQuery()
        conn.Close()
      End If
    Catch err As Exception
      Throw err
    End Try
  End Sub

#End Region

  Public Overrides Function ToString() As String
    Return RefereeName
  End Function
End Class

