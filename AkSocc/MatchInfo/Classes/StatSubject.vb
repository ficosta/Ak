Imports System.ComponentModel
Imports System.Data.OleDb
Imports MatchInfo

Public Class StatSubject
  Public Property ID As String
  Public Property ParentID As String

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

  Public Property TableName As String
  Public Property FieldName As String

  Public Event StatValueChanged(sender As StatSubject, stat As Stat)

  Public Sub New()

  End Sub

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
        For Each stat As Stat In Me.MatchStats.StatBag
          Try
            Dim value As Double = myReader.GetInt32(myReader.GetOrdinal(stat.Name))
            stat.Value = value

          Catch ex As Exception

          End Try
        Next
      End If
      myReader.Close()
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
        RaiseEvent StatValueChanged(Me, stat)
      End If
    Catch ex As Exception

    End Try
  End Sub

  Private Sub _matchStats_StatValueChanged(subjectStats As SubjectStats, stat As Stat) Handles _matchStats.StatValueChanged
    Try
      If Not stat Is Nothing Then
        RaiseEvent StatValueChanged(Me, stat)
      End If
    Catch ex As Exception

    End Try
  End Sub
#End Region
End Class
