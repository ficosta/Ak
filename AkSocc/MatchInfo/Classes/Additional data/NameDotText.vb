
Imports System.Data.OleDb


Public Class NameDotText
  Public ID As Integer
  Public EnglishDescription As String
  Public ArabicTopLineText As String
  Public ArabicSubLineText As String
  Public Priority As Integer

  Public Sub New()
    Init(-1)
  End Sub
  Public Sub New(Bug_ID As Integer)
    Init(Bug_ID)
  End Sub

  Public Sub Init(Bug_ID As Integer)
    ID = Bug_ID
    EnglishDescription = ""
    ArabicTopLineText = ""
    ArabicSubLineText = ""
    Priority = -1
  End Sub

  Public Overrides Function ToString() As String
    Return EnglishDescription
  End Function

  ''' <summary>
  ''' Create SQL Commands with the parameters and Values to use it to UPDATE or INSERT the database
  ''' </summary>
  ''' <returns>OleDbCommands filled</returns>
  Public Function CreateCommand() As OleDbCommand
    Dim myCmd As New OleDbCommand()
    Try
      myCmd.Parameters.AddWithValue("@ID", ID)
      myCmd.Parameters.AddWithValue("@EnglishDescription", EnglishDescription)
      myCmd.Parameters.AddWithValue("@ArabicTopLineText", ArabicTopLineText)
      myCmd.Parameters.AddWithValue("@ArabicSubLineText", ArabicSubLineText)
      myCmd.Parameters.AddWithValue("@Priority", Priority)
    Catch err As Exception
      Throw err
    End Try
    Return myCmd
  End Function
  Private Function GetFromDB(Where As String) As Boolean
    Try
      Dim myDatabase As New NameDotTexts()
      myDatabase.GetFromDB(Where)
      If myDatabase.Count = 0 Then
        Return False
      End If

      Copy(DirectCast(myDatabase(0), NameDotText))
    Catch err As Exception
      Throw err
    End Try
    Return True
  End Function

  Public Sub Copy(Source As NameDotText)
    Try
      ID = Source.ID
      EnglishDescription = Source.EnglishDescription
      ArabicTopLineText = Source.ArabicTopLineText
      ArabicSubLineText = Source.ArabicSubLineText
      Priority = Source.Priority
    Catch err As Exception
      Throw err
    End Try
  End Sub

  Public Function [Get]() As Boolean
    Return GetFromDB("WHERE ID = " + ID)
  End Function

  Public Sub Update()
    Try
      Dim ActualDb As New NameDotText(ID)
      If ActualDb.[Get]() Then
        'UPDATE
        Dim SQL As String = ""
        If ActualDb.EnglishDescription <> EnglishDescription AndAlso EnglishDescription <> "" Then
          SQL += " EnglishDescription=@EnglishDescription,"
        End If
        If ActualDb.ArabicTopLineText <> ArabicTopLineText AndAlso ArabicTopLineText <> "" Then
          SQL += " ArabicTopLineText=@ArabicTopLineText,"
        End If
        If ActualDb.ArabicSubLineText <> ArabicSubLineText AndAlso ArabicSubLineText <> "" Then
          SQL += " ArabicSubLineText=@ArabicSubLineText,"
        End If
        If ActualDb.Priority <> Priority AndAlso Priority <> -1 Then
          SQL += " Priority=@Priority,"
        End If
        If SQL <> "" Then
          Dim conn As New OleDbConnection(Config.Instance.LocalConnectionString)
          conn.Open()
          Dim myCommand As OleDbCommand = CreateCommand()
          myCommand.Connection = conn
          SQL = SQL.Substring(0, SQL.Length - 1)
          SQL = (Convert.ToString("UPDATE NamesDotText SET") & SQL) + " WHERE ID = " + ID
          myCommand.CommandText = SQL
          myCommand.ExecuteNonQuery()
          conn.Close()
        End If
      Else
        'INSERT
        Dim SQL As String = "INSERT INTO NamesDotText (EnglishDescription, ArabicTopLineText, ArabicSubLineText, Priority)"
        SQL += " VALUES (@EnglishDescription, @ArabicTopLineText, @ArabicSubLineText, @Priority)"
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
End Class


Public Class NameDotTexts
  Inherits CollectionBase
  Public Sub New()
  End Sub

  Public Sub GetFromDB(Where As String)
    Try
      List.Clear()
      Dim conn As New OleDbConnection(Config.Instance.LocalConnectionString)
      conn.Open()

      Dim SQL As [String] = "SELECT ID, EnglishDescription, ArabicTopLineText, ArabicSubLineText, Priority"
      SQL += " FROM NamesDotText "
      SQL += Where.Trim()
      Dim CmdSQL As New OleDbCommand(SQL, conn)

      CmdSQL.CommandType = System.Data.CommandType.Text
      Dim myReader As OleDbDataReader = CmdSQL.ExecuteReader()
      While myReader.Read()
        Dim NewItem As New NameDotText(myReader.GetInt32(0))
        If Not myReader.IsDBNull(1) Then
          NewItem.EnglishDescription = myReader.GetString(1)
        End If
        If Not myReader.IsDBNull(2) Then
          NewItem.ArabicTopLineText = myReader.GetString(2)
        End If
        If Not myReader.IsDBNull(3) Then
          NewItem.ArabicSubLineText = myReader.GetString(3)
        End If
        If Not myReader.IsDBNull(4) Then
          NewItem.Priority = myReader.GetInt32(4)
        End If
        List.Add(NewItem)
      End While

      conn.Close()
    Catch err As Exception
      Throw err
    End Try
  End Sub

  Default Public Property Item(Index As Integer) As NameDotText
    Get
      Return DirectCast(List(Index), NameDotText)
    End Get
    Set
      List(Index) = Value
    End Set
  End Property

  Public Function GetName(local_ID As Integer) As NameDotText
    Dim output As NameDotText = Nothing
    Try
      For Each Search As NameDotText In List
        If Search.ID = local_ID Then
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
