
Imports System.Data.OleDb

Public Class EnglishToArabicTranslation

  Public ID As Integer
  Public EnglishWord As String
  Public ArabicWord As String

  Public Sub New()
    Init(-1)
  End Sub

  Public Sub New(FromEnglish As String)
    ID = -1
    EnglishWord = ""
    ArabicWord = ""
    Dim conn As New OleDbConnection(Config.Instance.LocalConnectionString)
    conn.Open()

    Dim SQL As [String] = "SELECT ID, EnglishWord, ArabicWord"
    SQL += " FROM Dictionary "
    SQL += "WHERE EnglishWord=@EnglishWord"
    Dim CmdSQL As New OleDbCommand(SQL, conn)
    CmdSQL.Parameters.AddWithValue("@EnglishWord", FromEnglish)
    CmdSQL.CommandType = System.Data.CommandType.Text
    Dim myReader As OleDbDataReader = CmdSQL.ExecuteReader()
    If myReader.Read() Then
      ID = myReader.GetInt32(0)
      EnglishWord = ""
      ArabicWord = ""
      If Not myReader.IsDBNull(1) Then
        EnglishWord = myReader.GetString(1)
      End If
      If Not myReader.IsDBNull(2) Then
        ArabicWord = myReader.GetString(2)
      End If
    End If
  End Sub

  Public Sub New(localID As Integer)
    Init(localID)
  End Sub

  Public Sub Init(localID As Integer)
    ID = localID
    EnglishWord = ""
    ArabicWord = ""
  End Sub

  ''' <summary>
  ''' Create SQL Commands with the parameters and Values to use it to UPDATE or INSERT the database
  ''' </summary>
  ''' <returns>OleDbCommands filled</returns>
  Public Function CreateCommand() As OleDbCommand
    Dim myCmd As New OleDbCommand()
    Try
      myCmd.Parameters.AddWithValue("@ID", ID)
      myCmd.Parameters.AddWithValue("@EnglishWord", EnglishWord)
      myCmd.Parameters.AddWithValue("@ArabicWord", ArabicWord)
    Catch err As Exception
      Throw err
    End Try
    Return myCmd
  End Function

  Private Function GetFromDB(Where As String) As Boolean
    Try
      Dim myDatabase As New EnglishToArabicTranslator(Where)
      If myDatabase.Count = 0 Then
        Return False
      End If

      Copy(DirectCast(myDatabase(0), EnglishToArabicTranslation))
    Catch err As Exception
      Throw err
    End Try
    Return True
  End Function

  Public Sub Copy(Source As EnglishToArabicTranslation)
    Try
      ID = Source.ID
      EnglishWord = Source.EnglishWord
      ArabicWord = Source.ArabicWord
    Catch err As Exception
      Throw err
    End Try
  End Sub

  Public Function [Get]() As Boolean
    Return GetFromDB("WHERE ID = " & ID)
  End Function

  Public Sub Update()
    Try
      Dim ActualDb As New EnglishToArabicTranslation(ID)
      If ActualDb.[Get]() Then
        'UPDATE
        Dim SQL As String = ""
        If ActualDb.EnglishWord <> EnglishWord AndAlso EnglishWord <> "" Then
          SQL += " EnglishWord=@EnglishWord,"
        End If
        If ActualDb.ArabicWord <> ArabicWord AndAlso ArabicWord <> "" Then
          SQL += " ArabicWord=@ArabicWord,"
        End If
        If SQL <> "" Then
          Dim conn As New OleDbConnection(Config.Instance.LocalConnectionString)
          conn.Open()
          Dim myCommand As OleDbCommand = CreateCommand()
          myCommand.Connection = conn
          SQL = SQL.Substring(0, SQL.Length - 1)
          SQL = (Convert.ToString("UPDATE Dictionary SET") & SQL) & " WHERE ID = " & ID
          myCommand.CommandText = SQL
          myCommand.ExecuteNonQuery()
          conn.Close()
        End If
      Else
        'INSERT
        Dim SQL As String = "INSERT INTO Dictionary (EnglishWord, ArabicWord)"
        SQL += " VALUES (@EnglishWord, @ArabicWord)"
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
