
Imports System.Data.OleDb

Public Class Competitions
  Inherits CollectionBase
  Public Sub New()
  End Sub

  Public Sub GetFromDB(Where As String)
    Try
      List.Clear()
      Dim conn As New OleDbConnection(Config.Instance.LocalConnectionString)
      conn.Open()

      Dim SQL As [String] = "SELECT CompID, CompName, CompNameNotes, CompDescription, CompAbbrevDescription, CompSubDescription, CompyTinyCode, CompIsLeague, CompMaxTeams, CompWinPoints, CompDrawPoints, CompSortOrder, CompNumberOfSubs, CompPriority, CompThisSeason, CompUCLGroup, CompPromoLine, CompPromoLine2, CompRelegLine, CompSplitTableIntoTwo, CompRelegLine2, CompDeductionsText, ArabicCompName"
      SQL += " FROM Competitions "
      SQL += Where.Trim()
      Dim CmdSQL As New OleDbCommand(SQL, conn)

      CmdSQL.CommandType = System.Data.CommandType.Text
      Dim myReader As OleDbDataReader = CmdSQL.ExecuteReader()
      While myReader.Read()
        Dim NewItem As New Competition(myReader.GetInt32(0))
        If Not myReader.IsDBNull(1) Then
          NewItem.CompName = myReader.GetString(1)
        End If
        If Not myReader.IsDBNull(2) Then
          NewItem.CompNameNotes = myReader.GetString(2)
        End If
        If Not myReader.IsDBNull(3) Then
          NewItem.CompDescription = myReader.GetString(3)
        End If
        If Not myReader.IsDBNull(4) Then
          NewItem.CompAbbrevDescription = myReader.GetString(4)
        End If
        If Not myReader.IsDBNull(5) Then
          NewItem.CompSubDescription = myReader.GetString(5)
        End If
        If Not myReader.IsDBNull(6) Then
          NewItem.CompyTinyCode = myReader.GetString(6)
        End If
        If Not myReader.IsDBNull(7) Then
          NewItem.CompIsLeague = myReader.GetBoolean(7)
        End If
        If Not myReader.IsDBNull(8) Then
          NewItem.CompMaxTeams = myReader.GetInt32(8)
        End If
        If Not myReader.IsDBNull(9) Then
          NewItem.CompWinPoints = myReader.GetInt32(9)
        End If
        If Not myReader.IsDBNull(10) Then
          NewItem.CompDrawPoints = myReader.GetInt32(10)
        End If
        If Not myReader.IsDBNull(11) Then
          NewItem.CompSortOrder = myReader.GetString(11)
        End If
        If Not myReader.IsDBNull(12) Then
          NewItem.CompNumberOfSubs = myReader.GetInt32(12)
        End If
        If Not myReader.IsDBNull(13) Then
          NewItem.CompPriority = myReader.GetInt32(13)
        End If
        If Not myReader.IsDBNull(14) Then
          NewItem.CompThisSeason = myReader.GetBoolean(14)
        End If
        If Not myReader.IsDBNull(15) Then
          NewItem.CompUCLGroup = myReader.GetBoolean(15)
        End If
        If Not myReader.IsDBNull(16) Then
          NewItem.CompPromoLine = myReader.GetInt32(16)
        End If
        If Not myReader.IsDBNull(17) Then
          NewItem.CompPromoLine2 = myReader.GetInt32(17)
        End If
        If Not myReader.IsDBNull(18) Then
          NewItem.CompRelegLine = myReader.GetInt32(18)
        End If
        If Not myReader.IsDBNull(19) Then
          NewItem.CompSplitTableIntoTwo = myReader.GetBoolean(19)
        End If
        If Not myReader.IsDBNull(20) Then
          NewItem.CompRelegLine2 = myReader.GetInt32(20)
        End If
        If Not myReader.IsDBNull(21) Then
          NewItem.CompDeductionsText = myReader.GetString(21)
        End If
        If Not myReader.IsDBNull(22) Then
          NewItem.ArabicCompName = myReader.GetString(22)
        End If
        List.Add(NewItem)
      End While
      conn.Close()
    Catch err As Exception
      Throw err
    End Try
  End Sub

  Default Public Property Item(Index As Integer) As Competition
    Get
      Return DirectCast(List(Index), Competition)
    End Get
    Set
      List(Index) = Value
    End Set
  End Property

  Public Function GetCompetition(ID As Integer) As Competition
    Dim output As Competition = Nothing
    Try
      For Each Search As Competition In List
        If Search.CompID = ID Then
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

