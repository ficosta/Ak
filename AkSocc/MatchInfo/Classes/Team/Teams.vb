
Imports System.Data.OleDb

Public Class Teams
  Inherits CollectionBase


  Public Sub New()
  End Sub

  Public Sub GetFromDB(Where As String)
    Try
      List.Clear()

      Dim conn As New OleDbConnection(Config.Instance.LocalConnectionString)
      conn.Open()

      Dim SQL As [String] = "SELECT TeamID, TeamAELCaption1Name, TeamAELTinyName, TeamTWIRelegationCode, FudgeFactor, TeamPointsDeductions, TeamPreviousPositionInLeague, ArabicCaption1Name, BadgeName"
      SQL += " FROM Teams "
      SQL += Where.Trim()
      Dim CmdSQL As New OleDbCommand(SQL, conn)

      CmdSQL.CommandType = System.Data.CommandType.Text
      Dim myReader As OleDbDataReader = CmdSQL.ExecuteReader()
      While myReader.Read()
        Dim NewItem As New Team(myReader.GetInt32(0))
        If Not myReader.IsDBNull(1) Then
          NewItem.TeamAELCaption1Name = myReader.GetString(1)
        End If
        If Not myReader.IsDBNull(2) Then
          NewItem.TeamAELTinyName = myReader.GetString(2)
        End If
        If Not myReader.IsDBNull(3) Then
          NewItem.TeamTWIRelegationCode = myReader.GetString(3)
        End If
        If Not myReader.IsDBNull(4) Then
          NewItem.FudgeFactor = myReader.GetInt32(4)
        End If
        If Not myReader.IsDBNull(5) Then
          NewItem.TeamPointsDeductions = myReader.GetInt32(5)
        End If
        If Not myReader.IsDBNull(6) Then
          NewItem.TeamPreviousPositionInLeague = myReader.GetInt32(6)
        End If
        If Not myReader.IsDBNull(7) Then
          NewItem.ArabicCaption1Name = myReader.GetString(7)
        End If
        If Not myReader.IsDBNull(8) Then
          NewItem.BadgeName = myReader.GetString(8)
        End If
        List.Add(NewItem)
      End While
      conn.Close()
    Catch err As Exception
      Throw err
    End Try
  End Sub

  Default Public Property Item(Index As Integer) As Team
    Get
      Return DirectCast(List(Index), Team)
    End Get
    Set
      List(Index) = Value
    End Set
  End Property

  Public Function GetTeam(ID As Integer) As Team
    Dim output As Team = Nothing
    Try
      For Each Search As Team In List
        If Search.TeamID = ID Then
          output = Search
          Exit For
        End If
      Next
    Catch err As Exception
      Throw err
    End Try
    Return (output)
  End Function
End Class