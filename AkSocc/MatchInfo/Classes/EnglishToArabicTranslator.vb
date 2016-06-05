Imports System.Data.OleDb

Public Class EnglishToArabicTranslator
  Inherits CollectionBase
#Region "Singleton"
  Private Shared ReadOnly _instance As New Lazy(Of EnglishToArabicTranslator)(Function() New EnglishToArabicTranslator(), System.Threading.LazyThreadSafetyMode.ExecutionAndPublication)

  Private Sub New()
    Me.GetFromDB("")
  End Sub

  Public Shared ReadOnly Property Instance() As EnglishToArabicTranslator
    Get
      Return _instance.Value
    End Get
  End Property
#End Region

  Public Sub New(where As String)
    Me.GetFromDB(where)
  End Sub

  Public Sub GetFromDB(Where As String)
    Try
      List.Clear()
      Dim conn As New OleDbConnection(Config.Instance.LocalConnectionString)
      conn.Open()

      Dim SQL As [String] = "SELECT ID, EnglishWord, ArabicWord"
      SQL += " FROM Dictionary "
      SQL += Where.Trim()
      Dim CmdSQL As New OleDbCommand(SQL, conn)

      CmdSQL.CommandType = System.Data.CommandType.Text
      Dim myReader As OleDbDataReader = CmdSQL.ExecuteReader()
      While myReader.Read()
        Dim NewItem As New EnglishToArabicTranslation(myReader.GetInt32(0))
        If Not myReader.IsDBNull(1) Then
          NewItem.EnglishWord = myReader.GetString(1)
        End If
        If Not myReader.IsDBNull(2) Then
          NewItem.ArabicWord = myReader.GetString(2)
        End If
        List.Add(NewItem)
      End While
      conn.Close()
    Catch err As Exception
      Throw err
    End Try
  End Sub

  Default Public Property Item(Index As Integer) As EnglishToArabicTranslation
    Get
      Return DirectCast(List(Index), EnglishToArabicTranslation)
    End Get
    Set
      List(Index) = Value
    End Set
  End Property

  Public Function ToArabic(English As String) As String
    Dim output As String = ""
    Dim found As Boolean = False
    Try
      For Each Search As EnglishToArabicTranslation In List
        If Search.EnglishWord.ToUpper() = English.ToUpper() Then
          output = Search.ArabicWord
          found = True
          Exit For
        End If
      Next
      If found = False Then
        If output = "" Then
          Dim sw As System.IO.StreamWriter = System.IO.File.AppendText("C:\NotInDictionary.txt")
          sw.WriteLine(Convert.ToString(DateTime.Now.ToString("HH:mm:ss") + " ") & English)
          sw.Close()
        End If
      End If
    Catch err As Exception
      Throw err
    End Try
    Return (output)
  End Function

End Class

