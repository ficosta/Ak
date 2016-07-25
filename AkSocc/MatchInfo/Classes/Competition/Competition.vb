
Imports System.Data.OleDb

Public Class Competition
  Public CompID As Integer
  Public CompName As String
  Public CompNameNotes As String
  Public CompDescription As String
  Public CompAbbrevDescription As String
  Public CompSubDescription As String
  Public CompyTinyCode As String
  Public CompIsLeague As Boolean
  Public CompMaxTeams As Integer
  Public CompWinPoints As Integer
  Public CompDrawPoints As Integer
  Public CompSortOrder As String
  Public CompNumberOfSubs As Integer
  Public CompPriority As Integer
  Public CompThisSeason As Boolean
  Public CompUCLGroup As Boolean
  Public CompPromoLine As Integer
  Public CompPromoLine2 As Integer
  Public CompRelegLine As Integer
  Public CompSplitTableIntoTwo As Boolean
  Public CompRelegLine2 As Integer
  Public CompDeductionsText As String
  Public ArabicCompName As String
  Public CompLeagueBadgeName As String

  Public Sub New()
    Init(-1)
  End Sub
  Public Sub New(ID As Integer)
    Init(ID)
  End Sub

  Public Sub Init(ID As Integer)
    CompID = ID
    CompName = ""
    CompNameNotes = ""
    CompDescription = ""
    CompAbbrevDescription = ""
    CompSubDescription = ""
    CompyTinyCode = ""
    CompIsLeague = False
    CompMaxTeams = -1
    CompWinPoints = -1
    CompDrawPoints = -1
    CompSortOrder = ""
    CompNumberOfSubs = -1
    CompPriority = -1
    CompThisSeason = False
    CompUCLGroup = False
    CompPromoLine = -1
    CompPromoLine2 = -1
    CompRelegLine = -1
    CompSplitTableIntoTwo = False
    CompRelegLine2 = -1
    CompDeductionsText = ""
    ArabicCompName = ""
    CompLeagueBadgeName = ""
  End Sub

  ''' <summary>
  ''' Create SQL Commands with the parameters and Values to use it to UPDATE or INSERT the database
  ''' </summary>
  ''' <returns>OleDbCommands filled</returns>
  Public Function CreateCommand() As OleDbCommand
    Dim myCmd As New OleDbCommand()
    Try
      myCmd.Parameters.AddWithValue("@CompID", CompID)
      myCmd.Parameters.AddWithValue("@CompName", CompName)
      myCmd.Parameters.AddWithValue("@CompNameNotes", CompNameNotes)
      myCmd.Parameters.AddWithValue("@CompDescription", CompDescription)
      myCmd.Parameters.AddWithValue("@CompAbbrevDescription", CompAbbrevDescription)
      myCmd.Parameters.AddWithValue("@CompSubDescription", CompSubDescription)
      myCmd.Parameters.AddWithValue("@CompyTinyCode", CompyTinyCode)
      myCmd.Parameters.AddWithValue("@CompIsLeague", CompIsLeague)
      myCmd.Parameters.AddWithValue("@CompMaxTeams", CompMaxTeams)
      myCmd.Parameters.AddWithValue("@CompWinPoints", CompWinPoints)
      myCmd.Parameters.AddWithValue("@CompDrawPoints", CompDrawPoints)
      myCmd.Parameters.AddWithValue("@CompSortOrder", CompSortOrder)
      myCmd.Parameters.AddWithValue("@CompNumberOfSubs", CompNumberOfSubs)
      myCmd.Parameters.AddWithValue("@CompPriority", CompPriority)
      myCmd.Parameters.AddWithValue("@CompThisSeason", CompThisSeason)
      myCmd.Parameters.AddWithValue("@CompUCLGroup", CompUCLGroup)
      myCmd.Parameters.AddWithValue("@CompPromoLine", CompPromoLine)
      myCmd.Parameters.AddWithValue("@CompPromoLine2", CompPromoLine2)
      myCmd.Parameters.AddWithValue("@CompRelegLine", CompRelegLine)
      myCmd.Parameters.AddWithValue("@CompSplitTableIntoTwo", CompSplitTableIntoTwo)
      myCmd.Parameters.AddWithValue("@CompRelegLine2", CompRelegLine2)
      myCmd.Parameters.AddWithValue("@CompDeductionsText", CompDeductionsText)

      myCmd.Parameters.AddWithValue("@ArabicCompName", ArabicCompName)
    Catch err As Exception
      Throw err
    End Try
    Return myCmd
  End Function

  Private Function GetFromDB(Where As String) As Boolean
    Try
      Dim myDatabase As New Competitions()
      myDatabase.GetFromDB(Where)
      If myDatabase.Count = 0 Then
        Return False
      End If

      CopyCompetition(DirectCast(myDatabase(0), Competition))
    Catch err As Exception
      Throw err
    End Try
    Return True
  End Function

  Public Sub CopyCompetition(Source As Competition)
    Try
      CompID = Source.CompID
      CompName = Source.CompName
      CompNameNotes = Source.CompNameNotes
      CompDescription = Source.CompDescription
      CompAbbrevDescription = Source.CompAbbrevDescription
      CompSubDescription = Source.CompSubDescription
      CompyTinyCode = Source.CompyTinyCode
      CompIsLeague = Source.CompIsLeague
      CompMaxTeams = Source.CompMaxTeams
      CompWinPoints = Source.CompWinPoints
      CompDrawPoints = Source.CompDrawPoints
      CompSortOrder = Source.CompSortOrder
      CompNumberOfSubs = Source.CompNumberOfSubs
      CompPriority = Source.CompPriority
      CompThisSeason = Source.CompThisSeason
      CompUCLGroup = Source.CompUCLGroup
      CompPromoLine = Source.CompPromoLine
      CompPromoLine2 = Source.CompPromoLine2
      CompRelegLine = Source.CompRelegLine
      CompSplitTableIntoTwo = Source.CompSplitTableIntoTwo
      CompRelegLine2 = Source.CompRelegLine2
      CompDeductionsText = Source.CompDeductionsText
      ArabicCompName = Source.ArabicCompName
    Catch err As Exception
      Throw err
    End Try
  End Sub

  Public Function GetCompetition() As Boolean
    Return GetFromDB("WHERE CompID = " & CompID)
  End Function

  Public Sub Update()
    Try
      Dim ActualDb As New Competition(CompID)
      If ActualDb.GetCompetition() Then
        'UPDATE
        Dim SQL As String = ""
        If ActualDb.CompName <> CompName AndAlso CompName <> "" Then
          SQL += " CompName=@CompName,"
        End If
        If ActualDb.CompNameNotes <> CompNameNotes AndAlso CompNameNotes <> "" Then
          SQL += " CompNameNotes=@CompNameNotes,"
        End If
        If ActualDb.CompDescription <> CompDescription AndAlso CompDescription <> "" Then
          SQL += " CompDescription=@CompDescription,"
        End If
        If ActualDb.CompAbbrevDescription <> CompAbbrevDescription AndAlso CompAbbrevDescription <> "" Then
          SQL += " CompAbbrevDescription=@CompAbbrevDescription,"
        End If
        If ActualDb.CompSubDescription <> CompSubDescription AndAlso CompSubDescription <> "" Then
          SQL += " CompSubDescription=@CompSubDescription,"
        End If
        If ActualDb.CompyTinyCode <> CompyTinyCode AndAlso CompyTinyCode <> "" Then
          SQL += " CompyTinyCode=@CompyTinyCode,"
        End If
        If ActualDb.CompIsLeague <> CompIsLeague Then
          SQL += " CompIsLeague=@CompIsLeague,"
        End If
        If ActualDb.CompMaxTeams <> CompMaxTeams AndAlso CompMaxTeams <> -1 Then
          SQL += " CompMaxTeams=@CompMaxTeams,"
        End If
        If ActualDb.CompWinPoints <> CompWinPoints AndAlso CompWinPoints <> -1 Then
          SQL += " CompWinPoints=@CompWinPoints,"
        End If
        If ActualDb.CompDrawPoints <> CompDrawPoints AndAlso CompDrawPoints <> -1 Then
          SQL += " CompDrawPoints=@CompDrawPoints,"
        End If
        If ActualDb.CompSortOrder <> CompSortOrder AndAlso CompSortOrder <> "" Then
          SQL += " CompSortOrder=@CompSortOrder,"
        End If
        If ActualDb.CompNumberOfSubs <> CompNumberOfSubs AndAlso CompNumberOfSubs <> -1 Then
          SQL += " CompNumberOfSubs=@CompNumberOfSubs,"
        End If
        If ActualDb.CompPriority <> CompPriority AndAlso CompPriority <> -1 Then
          SQL += " CompPriority=@CompPriority,"
        End If
        If ActualDb.CompThisSeason <> CompThisSeason Then
          SQL += " CompThisSeason=@CompThisSeason,"
        End If
        If ActualDb.CompUCLGroup <> CompUCLGroup Then
          SQL += " CompUCLGroup=@CompUCLGroup,"
        End If
        If ActualDb.CompPromoLine <> CompPromoLine AndAlso CompPromoLine <> -1 Then
          SQL += " CompPromoLine=@CompPromoLine,"
        End If
        If ActualDb.CompPromoLine2 <> CompPromoLine2 AndAlso CompPromoLine2 <> -1 Then
          SQL += " CompPromoLine2=@CompPromoLine2,"
        End If
        If ActualDb.CompRelegLine <> CompRelegLine AndAlso CompRelegLine <> -1 Then
          SQL += " CompRelegLine=@CompRelegLine,"
        End If
        If ActualDb.CompSplitTableIntoTwo <> CompSplitTableIntoTwo Then
          SQL += " CompSplitTableIntoTwo=@CompSplitTableIntoTwo,"
        End If
        If ActualDb.CompRelegLine2 <> CompRelegLine2 AndAlso CompRelegLine2 <> -1 Then
          SQL += " CompRelegLine2=@CompRelegLine2,"
        End If
        If ActualDb.CompDeductionsText <> CompDeductionsText AndAlso CompDeductionsText <> "" Then
          SQL += " CompDeductionsText=@CompDeductionsText,"
        End If
        If ActualDb.ArabicCompName <> ArabicCompName AndAlso ArabicCompName <> "" Then
          SQL += " ArabicCompName=@ArabicCompName,"
        End If
        If SQL <> "" Then
          Dim conn As New OleDbConnection(Config.Instance.LocalConnectionString)
          conn.Open()
          Dim myCommand As OleDbCommand = CreateCommand()
          myCommand.Connection = conn
          SQL = SQL.Substring(0, SQL.Length - 1)
          SQL = (Convert.ToString("UPDATE Competitions SET") & SQL) & " WHERE CompID = " & CompID
          myCommand.CommandText = SQL
          myCommand.ExecuteNonQuery()
          conn.Close()
        End If
      Else
        'INSERT
        Dim SQL As String = "INSERT INTO Competitions (CompName, CompNameNotes, CompDescription, CompAbbrevDescription, CompSubDescription, CompyTinyCode, CompIsLeague, CompMaxTeams, CompWinPoints, CompDrawPoints, CompSortOrder, CompNumberOfSubs, CompPriority, CompThisSeason, CompUCLGroup, CompPromoLine, CompPromoLine2, CompRelegLine, CompSplitTableIntoTwo, CompRelegLine2, CompDeductionsText, ArabicCompName)"
        SQL += " VALUES (@CompName, @CompNameNotes, @CompDescription, @CompAbbrevDescription, @CompSubDescription, @CompyTinyCode, @CompIsLeague, @CompMaxTeams, @CompWinPoints, @CompDrawPoints, @CompSortOrder, @CompNumberOfSubs, @CompPriority, @CompThisSeason, @CompUCLGroup, @CompPromoLine, @CompPromoLine2, @CompRelegLine, @CompSplitTableIntoTwo, @CompRelegLine2, @CompDeductionsText, @ArabicCompName)"
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
    Return CompName
  End Function
End Class