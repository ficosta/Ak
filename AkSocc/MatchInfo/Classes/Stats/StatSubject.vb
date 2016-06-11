Imports System.ComponentModel
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
      _Name = value
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
      Dim conn As New OleDbConnection(Config.Instance.LocalConnectionString)
      conn.Open()

      Dim mySQL As String = "SELECT * FROM " & Me.TableName & " WHERE MatchID=" & Me.Match_ID & " AND " & Me.FieldName & "=" & Me.ID

      Dim CmdSQL As New OleDbCommand(mySQL, conn)

      CmdSQL.CommandType = System.Data.CommandType.Text
      Dim myReader As OleDbDataReader = CmdSQL.ExecuteReader()

      If myReader.Read() Then
        Dim colset As DataTable = myReader.GetSchemaTable()
        For Each stat As Stat In Me.MatchStats.StatBag
          Try
            Dim found As Boolean = False
            For i As Integer = 0 To colset.Rows.Count - 1
              If colset(i).ItemArray(0).ToString = stat.Name Then
                found = True
                Exit For
              End If
            Next
            If found AndAlso Not IsDBNull(myReader(myReader.GetOrdinal(stat.Name))) Then
              Dim value As Double = myReader.GetInt32(myReader.GetOrdinal(stat.Name))
              stat.Value = value
            End If
          Catch ex As Exception

          End Try
        Next
      Else
        Me.WriteStatsToDB()
      End If
      myReader.Close()
      conn.Close()
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
    Try
      If SaveToDB = False Then Exit Sub
      If Me.TableName = "" Then Exit Sub
      If Me.Match_ID = "-1" Then Exit Sub
      If Me.FieldName = "" Then Exit Sub
      If Me.ID = "" Then Exit Sub

      Dim conn As New OleDbConnection(Config.Instance.LocalConnectionString)
      conn.Open()

      Dim mySQL As String = "SELECT * FROM " & Me.TableName & " WHERE MatchID=" & Me.Match_ID & " AND " & Me.FieldName & "=" & Me.ID

      Dim CmdSQL As New OleDbCommand(mySQL, conn)

      CmdSQL.CommandType = System.Data.CommandType.Text
      Dim myReader As OleDbDataReader = CmdSQL.ExecuteReader()


      Dim colset As DataTable = myReader.GetSchemaTable()
      Dim found As Boolean = False
      For i As Integer = 0 To colset.Rows.Count - 1
        If colset(i).ItemArray(0).ToString = stat.Name Then
          found = True
          Exit For
        End If
      Next

      If found Then
        mySQL = "UPDATE " & Me.TableName & " SET " & stat.Name & " = " & stat.Value & " WHERE MatchID=" & Me.Match_ID & " AND " & Me.FieldName & "=" & Me.ID
        CmdSQL = New OleDbCommand(mySQL, conn)

        CmdSQL.CommandType = System.Data.CommandType.Text
        CmdSQL.ExecuteNonQuery()
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
        RaiseEvent StatValueChanged(Me, stat)
      End If
    Catch ex As Exception

    End Try
  End Sub

  Private Sub _matchStats_StatValueChanged(subjectStats As SubjectStats, stat As Stat) Handles _matchStats.StatValueChanged
    Try
      If Not stat Is Nothing Then
        ' WriteStatToDB(stat)
        RaiseEvent StatValueChanged(Me, stat)
      End If
    Catch ex As Exception

    End Try
  End Sub
#End Region
End Class
