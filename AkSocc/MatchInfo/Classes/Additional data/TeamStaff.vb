
Imports System.Data.OleDb

Public Class TeamStaff
  Public StaffID As Integer
  Public StaffTeamID As Integer
  Public StaffFirstName As String
  Public StaffSurname As String
  Public StaffTitle As String
  Public StaffImportance As Integer
  Public ArabicStaffTitle As String
  Public ArabicName As String
  Public ArabicShortName As String

  Public ReadOnly Property StaffFullName() As String
    Get
      Return (Convert.ToString(StaffFirstName & Convert.ToString(" ")) & StaffSurname)
    End Get
  End Property

  Public Sub New()
    InitStaff(-1)
  End Sub
  Public Sub New(ID As Integer)
    InitStaff(ID)
  End Sub

  Public Sub InitStaff(ID As Integer)
    StaffID = ID
    StaffTeamID = -1
    StaffFirstName = ""
    StaffSurname = ""
    StaffTitle = ""
    StaffImportance = -1
    ArabicStaffTitle = ""
    ArabicName = ""
    ArabicShortName = ""
  End Sub

  Private Function GetFromDB(Where As String) As Boolean
    Try
      Dim myDatabase As New TeamStaffs()
      myDatabase.GetFromDB(Where)
      If myDatabase.Count = 0 Then
        Return False
      End If

      CopyStaff(DirectCast(myDatabase(0), TeamStaff))
    Catch err As Exception
      Throw err
    End Try
    Return True
  End Function

  Public Sub CopyStaff(Source As TeamStaff)
    Try
      StaffID = Source.StaffID
      StaffTeamID = Source.StaffTeamID
      StaffFirstName = Source.StaffFirstName
      StaffSurname = Source.StaffSurname
      StaffTitle = Source.StaffTitle
      StaffImportance = Source.StaffImportance
      ArabicStaffTitle = Source.ArabicStaffTitle
      ArabicName = Source.ArabicName
      ArabicShortName = Source.ArabicShortName
    Catch err As Exception
      Throw err
    End Try
  End Sub

  Public Function GetStaff() As Boolean
    Return GetFromDB("WHERE StaffID = " & StaffID)
  End Function

  Public Sub Update()
    'Try
    '  Dim ActualDb As New TeamStaff(StaffID)
    '  If ActualDb.GetStaff() Then
    '    'UPDATE
    '    Dim myCommand As New OleDbCommand()
    '    Dim SQL As String = ""
    '    If ActualDb.StaffTeamID <> StaffTeamID AndAlso StaffTeamID <> -1 Then
    '      SQL += " StaffTeamID=@StaffTeamID,"
    '      myCommand.Parameters.AddWithValue("@StaffTeamID", StaffTeamID)
    '    End If
    '    If ActualDb.StaffFirstName <> StaffFirstName AndAlso StaffFirstName <> "" Then
    '      SQL += " StaffFirstName=@StaffFirstName,"
    '      myCommand.Parameters.AddWithValue("@StaffSurname", StaffSurname)
    '    End If
    '    If ActualDb.StaffSurname <> StaffSurname AndAlso StaffSurname <> "" Then
    '      SQL += " StaffSurname=@StaffSurname,"
    '      myCommand.Parameters.AddWithValue("@StaffSurname", StaffSurname)
    '    End If
    '    If ActualDb.StaffTitle <> StaffTitle AndAlso StaffTitle <> "" Then
    '      SQL += " StaffTitle=@StaffTitle,"
    '      myCommand.Parameters.AddWithValue("@StaffTitle", StaffTitle)
    '    End If
    '    If ActualDb.StaffImportance <> StaffImportance AndAlso StaffImportance <> -1 Then
    '      SQL += " StaffImportance=" & StaffImportance.ToString() & ","
    '    End If
    '    If ActualDb.ArabicStaffTitle <> ArabicStaffTitle AndAlso ArabicStaffTitle <> "" Then
    '      SQL += " ArabicStaffTitle=@ArabicStaffTitle,"
    '      myCommand.Parameters.AddWithValue("@ArabicStaffTitle", ArabicStaffTitle)
    '    End If
    '    If ActualDb.ArabicName <> ArabicName AndAlso ArabicName <> "" Then
    '      SQL += " ArabicName=@ArabicName,"
    '      myCommand.Parameters.AddWithValue("@ArabicName", ArabicName)
    '    End If
    '    If ActualDb.ArabicShortName <> ArabicShortName AndAlso ArabicShortName <> "" Then
    '      SQL += " ArabicShortName=@ArabicShortName,"
    '      myCommand.Parameters.AddWithValue("@ArabicShortName", ArabicShortName)
    '    End If
    '    If SQL <> "" Then
    '      Dim conn As New OleDbConnection(Config.LocalDBConnectionString)
    '      conn.Open()
    '      myCommand.Connection = conn
    '      SQL = SQL.Substring(0, SQL.Length - 1)
    '      SQL = (Convert.ToString("UPDATE Staff SET") & SQL) & " WHERE StaffID = " & StaffID
    '      myCommand.CommandText = SQL
    '      myCommand.ExecuteNonQuery()
    '      conn.Close()
    '    End If
    '  Else
    '    'INSERT
    '    Dim SQL As String = "INSERT INTO Staff (StaffTeamID, StaffFirstName, StaffSurname, StaffTitle, StaffImportance, ArabicStaffTitle, ArabicName, ArabicShortName)"
    '    SQL += " VALUES (" & StaffTeamID.ToString() & ", @StaffFirstName, @StaffSurname, @StaffTitle, " & StaffImportance.ToString() & ", @ArabicStaffTitle, @ArabicName, @ArabicShortName)"
    '    Dim conn As New OleDbConnection(Config.LocalDBConnectionString)
    '    conn.Open()
    '    Dim myCmd As New OleDbCommand(SQL, conn)
    '    myCmd.Parameters.AddWithValue("@StaffFirstName", StaffFirstName)
    '    myCmd.Parameters.AddWithValue("@StaffSurname", StaffSurname)
    '    myCmd.Parameters.AddWithValue("@StaffTitle", StaffTitle)
    '    myCmd.Parameters.AddWithValue("@ArabicStaffTitle", ArabicStaffTitle)
    '    myCmd.Parameters.AddWithValue("@ArabicName", ArabicName)
    '    myCmd.Parameters.AddWithValue("@ArabicShortName", ArabicShortName)
    '    myCmd.ExecuteNonQuery()
    '    conn.Close()
    '  End If
    'Catch err As Exception
    '  Throw err
    'End Try
  End Sub
End Class


Public Class TeamStaffs
  Inherits CollectionBase
  Public Sub New()
  End Sub

  Public Sub GetStaffs(ID As Integer)
    GetFromDB("WHERE StaffID=" & ID.ToString())
  End Sub


  ''' <summary>
  ''' Get the data from the Database
  ''' </summary>
  ''' <param name="Where">WHERE sentence (including WHERE)</param>
  Public Sub GetFromDB(Where As String)
    Try
      List.Clear()
      Dim conn As New OleDbConnection(Config.Instance.LocalConnectionString)
      conn.Open()

      Dim SQL As [String] = "SELECT StaffID, StaffTeamID, StaffFirstName, StaffSurname, StaffTitle, StaffImportance, ArabicStaffTitle, ArabicName, ArabicShortName"
      SQL += " FROM Staff "
      SQL += Where.Trim()
      Dim CmdSQL As New OleDbCommand(SQL, conn)

      CmdSQL.CommandType = System.Data.CommandType.Text
      Dim myReader As OleDbDataReader = CmdSQL.ExecuteReader()
      While myReader.Read()
        Dim NewItem As New TeamStaff(myReader.GetInt32(0))
        If Not myReader.IsDBNull(1) Then
          NewItem.StaffTeamID = myReader.GetInt32(1)
        End If
        If Not myReader.IsDBNull(2) Then
          NewItem.StaffFirstName = myReader.GetString(2)
        End If
        If Not myReader.IsDBNull(3) Then
          NewItem.StaffSurname = myReader.GetString(3)
        End If
        If Not myReader.IsDBNull(4) Then
          NewItem.StaffTitle = myReader.GetString(4)
        End If
        If Not myReader.IsDBNull(5) Then
          NewItem.StaffImportance = myReader.GetInt32(5)
        End If
        If Not myReader.IsDBNull(6) Then
          NewItem.ArabicStaffTitle = myReader.GetString(6)
        End If
        If Not myReader.IsDBNull(7) Then
          NewItem.ArabicName = myReader.GetString(7)
        End If
        If Not myReader.IsDBNull(8) Then
          NewItem.ArabicShortName = myReader.GetString(8)
        End If
        List.Add(NewItem)
      End While
      conn.Close()
    Catch err As Exception
      Throw err
    End Try
  End Sub

  Default Public Property Item(Index As Integer) As TeamStaff
    Get
      Return DirectCast(List(Index), TeamStaff)
    End Get
    Set
      List(Index) = Value
    End Set
  End Property

  Public Function GetStaff(ID As Integer) As TeamStaff
    Dim output As TeamStaff = Nothing
    Try
      For Each Search As TeamStaff In List
        If Search.StaffID = ID Then
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
