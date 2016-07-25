Imports System.ComponentModel
Imports System.Data.Odbc
Imports System.Data.OleDb
Imports MatchInfo

Public Class StatSubject
  Public Property ID As String = "-1"
  Public Property ParentID As String = "-1"

  Private WithEvents _matchStats As New SubjectStats
  Public Property MatchStats As SubjectStats
    Get
      Return _matchStats
    End Get
    Set(value As SubjectStats)
      _matchStats = value
    End Set
  End Property

  Private WithEvents _seasonStats As New SubjectStats
  Public Property SeasonStats As SubjectStats
    Get
      Return _seasonStats
    End Get
    Set(value As SubjectStats)
      _seasonStats = value
    End Set
  End Property

  Private _name As String = ""
  Public Property Name As String
    Get
      Return _name
    End Get
    Set(value As String)
      _name = value
    End Set
  End Property

  Public Property Match_ID As Integer = -1

  Public Property TableName As String = ""
  Public Property FieldName As String = ""

  Public Event StatValueChanged(sender As StatSubject, stat As Stat)

  Public Sub New()
    Try

    Catch ex As Exception

    End Try
  End Sub

  Public Property SaveToDB() As Boolean = False

#Region "Stats"
  Public ReadOnly Property SQL As String
    Get
      Dim res As [String] = "SELECT PlayerID, MatchID, Shots, Shots_on_Target, Fouls, Saves, YCard, RCard, Assis, Formation_pos, Formation_x, Formation_y, Substituion"
      res += " FROM " & Me.TableName
      res += " WHERE " & Me.FieldName & " = " & Me.ID & " AND MatchID = " & Me.Match_ID

      Return res
    End Get
  End Property

  Public Sub InitStats(match_id As Integer, table_name As String, field As String)
    Try
      Me.Match_ID = match_id
      Me.TableName = table_name
      Me.FieldName = field
    Catch ex As Exception
      Throw (ex)
    End Try
  End Sub



  Public Sub ReadStatsFromDB()
    Try

      Dim mySQL As String = "SELECT * FROM " & Me.TableName & " WHERE MatchID=" & Me.Match_ID & " AND " & Me.FieldName & "=" & Me.ID
      ' mySQL = "SELECT * FROM " & Me.TableName & ""

      Dim cConn As New ADODB.Connection()
      cConn.Open(Config.Instance.LocalConnectionString)

      Dim rs As New ADODB.Recordset

      rs.Open(mySQL, cConn)

      If Not rs.EOF Then
        Me.MatchStats.Assis.Value = GetRecordsetIntValue(rs, "Assis")
        Me.MatchStats.Saves.Value = GetRecordsetIntValue(rs, "Saves")
        Me.MatchStats.Fouls.Value = GetRecordsetIntValue(rs, "Fouls")
        Me.MatchStats.RedCards.Value = GetRecordsetIntValue(rs, "RCard")
        Me.MatchStats.ShotsOn.Value = GetRecordsetIntValue(rs, "Shots_on_Target")
        Me.MatchStats.YellowCards.Value = GetRecordsetIntValue(rs, "YCard")
        Me.MatchStats.Formation_Pos.Value = GetRecordsetIntValue(rs, "Formation_pos")
        Me.MatchStats.Formation_X.Value = GetRecordsetDecimalValue(rs, "Formation_X")
        Me.MatchStats.Formation_Y.Value = GetRecordsetDecimalValue(rs, "Formation_Y")


      End If
      rs.Close()
      cConn.Close()


    Catch ex As Exception
      Throw ex
    End Try
  End Sub


  Public Sub WriteStatsToDB()
    Try
      If SaveToDB = False Then Exit Sub

      For Each stat As Stat In Me.MatchStats.StatBag
        Me.WriteStatToDB(stat)
      Next

    Catch ex As Exception
      Throw ex
    End Try
  End Sub

  Public Sub WriteStatToDB(stat As Stat)
    If SaveToDB = False Then Exit Sub
    If Config.Instance.AsyncDataWrites Then
      'Dim t As Threading.Thread = New Threading.Thread(Sub() WriteStatToDB_Sync(stat))
      't.Start()
      AsyncStatWriter.Instance.AddStatToQue(Me, stat)
    Else
      WriteStatToDB_Sync(stat)
    End If
  End Sub

  Public Sub WriteStatToDB_Sync(stat As Stat)
    Try
      If Me.TableName = "" Then Exit Sub
      If Me.Match_ID = "-1" Then Exit Sub
      If Me.FieldName = "" Then Exit Sub
      If Me.ID = "" Then Exit Sub


      Dim conn As New ADODB.Connection()
      conn.Open(Config.Instance.LocalConnectionString)

      Dim mySQL As String = "SELECT * FROM " & Me.TableName & " WHERE MatchID=" & Me.Match_ID & " AND " & Me.FieldName & "=" & Me.ID

      Dim rs As New ADODB.Recordset

      rs.Open(mySQL, conn, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
      Dim found As Boolean = Not rs.EOF
      If Not rs.EOF Then
        rs.Fields(stat.Name).Value = stat.Value
        rs.Update()
        rs.Close()
      Else
        Dim insertSQL As String = "INSERT INTO " & Me.TableName & " (MatchID, " & Me.FieldName & ") VALUES (" & Me.Match_ID & ", " & Me.ID & ")"
        conn.Execute(insertSQL)
        rs.Close()
        rs.Open(mySQL, conn, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
        rs.Fields(stat.Name).Value = stat.Value
        rs.Update()
        rs.Close()
      End If
      conn.Close()

    Catch ex As Exception
      Debug.Print(ex.ToString)
      'Throw ex
    End Try
  End Sub

  Public Sub ResetDB()
    Try

      Dim conn As New OleDbConnection(Config.Instance.LocalConnectionString)
      conn.Open()
      Dim mySQL As String = "UPDATE PlayerStats SET Shots=0, Shots_on_Target=0,Fouls=0, Saves=0, Substituion=0, YCard=0, RCard=0, Assis=0 WHERE MatchID = " & Me.Match_ID

      Dim CmdSQL As New OleDbCommand(mySQL, conn)

      CmdSQL.CommandType = System.Data.CommandType.Text

      CmdSQL.ExecuteNonQuery()

      conn.Close()

    Catch ex As Exception
      Throw ex
    End Try
  End Sub

  Private Sub Update()

  End Sub

  Private Sub _matchStats_PropertyChanged(sender As Object, e As PropertyChangedEventArgs) Handles _matchStats.PropertyChanged
    Try
      Dim stat As Stat = TryCast(sender, Stat)
      If Not stat Is Nothing Then
        ' WriteStatToDB(stat)
        Debug.Print("_matchStats_PropertyChanged id " & Me.ID & " " & Me.ParentID & " " & Me.Name & " name " & e.PropertyName)
        RaiseEvent StatValueChanged(Me, stat)
      End If
    Catch ex As Exception

    End Try
  End Sub

  Private Sub _matchStats_StatValueChanged(subjectStats As SubjectStats, stat As Stat) Handles _matchStats.StatValueChanged
    Try
      If Me.Match_ID <= 0 Then Exit Sub
      

      If Not stat Is Nothing Then
        WriteStatToDB(stat)
        Debug.Print("_matchStats_StatValueChanged id " & Me.ID & " " & Me.ParentID & " " & Me.Name & " stat " & stat.Name & " = " & stat.Value)
        RaiseEvent StatValueChanged(Me, stat)
      End If
    Catch ex As Exception

    End Try
  End Sub


  Public Function GetMatchStatByName(name As String) As Stat
    Dim res As Stat = Nothing
    Try
      For Each aux As Stat In Me.MatchStats.StatBag
        If aux.Name = name Then
          res = aux
          Exit For
        End If
      Next
    Catch ex As Exception
    End Try
    Return res
  End Function

  Public Function GetSeasonStatByName(name As String) As Stat
    Dim res As Stat = Nothing
    Try
      For Each aux As Stat In Me.SeasonStats.StatBag
        If aux.Name = name Then
          res = aux
          Exit For
        End If
      Next
    Catch ex As Exception
    End Try
    Return res
  End Function

#End Region

#Region "For comunication"


  Public Function ToSocketFormat() As String
    Dim output As String = ""

    output = Me.MatchStats.Fouls.ToString() & "|"
    output &= Me.MatchStats.Corners.ToString() & "|"
    output &= Me.MatchStats.Assis.ToString() & "|"
    output &= Me.MatchStats.Offsides.ToString() & "|"
    output &= Me.MatchStats.Possession1st.ToString() & "|"
    output &= Me.MatchStats.Possession2nd.ToString() & "|"
    output &= Me.MatchStats.PossessionAttack.ToString() & "|"
    output &= Me.MatchStats.PossessionLast10.ToString() & "|"
    output &= Me.MatchStats.PossessionLast5.ToString() & "|"
    output &= Me.MatchStats.PossessionMatch.ToString() & "|"
    output &= Me.MatchStats.PossessionMid.ToString() & "|"
    output &= Me.MatchStats.PossessionOwn.ToString() & "|"
    output &= Me.MatchStats.RedCards.ToString() & "|"
    output &= Me.MatchStats.Saves.ToString() & "|"
    output &= Me.MatchStats.Shots.ToString() & "|"
    output &= Me.MatchStats.ShotsOn.ToString() & "|"
    output &= Me.MatchStats.WoodHits.ToString() & "|"
    output &= Me.MatchStats.YellowCards.ToString()
    Return output
  End Function

  Public Sub GetFromSocketFormat(AllData As String)
    Dim Elements As String() = AllData.Split("|"c)
    If Elements.Length = 18 Then

      Me.MatchStats.Fouls.Value = NoNullDecimal(Elements(0))
      Me.MatchStats.Corners.Value = NoNullDecimal(Elements(1))
      Me.MatchStats.Assis.Value = NoNullDecimal(Elements(2))
      Me.MatchStats.Offsides.Value = NoNullDecimal(Elements(3))
      Me.MatchStats.Possession1st.Value = NoNullDecimal(Elements(4))
      Me.MatchStats.Possession2nd.Value = NoNullDecimal(Elements(5))
      Me.MatchStats.PossessionAttack.Value = NoNullDecimal(Elements(6))
      Me.MatchStats.PossessionLast10.Value = NoNullDecimal(Elements(7))
      Me.MatchStats.PossessionLast5.Value = NoNullDecimal(Elements(8))
      Me.MatchStats.PossessionMatch.Value = NoNullDecimal(Elements(9))
      Me.MatchStats.PossessionMid.Value = NoNullDecimal(Elements(10))
      Me.MatchStats.PossessionOwn.Value = NoNullDecimal(Elements(11))
      ' RCard.Value = NoNullDecimal(Elements[12]); nope
      Me.MatchStats.Saves.Value = NoNullDecimal(Elements(13))
      Me.MatchStats.Shots.Value = NoNullDecimal(Elements(14))
      Me.MatchStats.ShotsOn.Value = NoNullDecimal(Elements(15))
      ' YCard.Value = NoNullDecimal(Elements[17]); nope
      Me.MatchStats.WoodHits.Value = NoNullDecimal(Elements(16))
    ElseIf Elements.Length = 10 Then
      'PlayerName = Elements(0)
      'PlayerID = Utils.Val(Elements(1))
      'MatchID = Utils.Val(Elements(2))
      Me.MatchStats.Shots.Value = NoNullDecimal(Elements(3))
      Me.MatchStats.Saves.Value = NoNullDecimal(Elements(4))
      Me.MatchStats.ShotsOn.Value = NoNullDecimal(Elements(5))
      Me.MatchStats.Fouls.Value = NoNullDecimal(Elements(6))
      ' Yellow Cards will not be managed by Logger
      '                YCard = NoNullDecimal(Elements[7]);
      '                RCard = NoNullDecimal(Elements[8]); 

      Me.MatchStats.Assis.Value = NoNullDecimal(Elements(9))
    End If
  End Sub

#End Region
End Class
