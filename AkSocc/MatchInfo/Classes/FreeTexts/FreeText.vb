Imports System.Data.OleDb

<Serializable()> Public Class FreeText
  Public Property UID As String = Guid.NewGuid().ToString
  Public Property EnglishDescription As String
  Public Property CrawlHeader As String
  Public Property CrawlText As String
  Public Property Priority As Integer
End Class

<Serializable> Public Class FreeTexts
  Public Property FreeTextList As New List(Of FreeText)

  Public Sub New()
    Me.GetFromDB("WHERE Priority > 0 ORDER BY CrawlHeader")
  End Sub

  Public Sub GetFromDB(where As String)
    Try
      Me.FreeTextList.Clear()

      Dim conn As New OleDbConnection(Config.Instance.LocalConnectionString)
      conn.Open()

      Dim SQL As [String] = "SELECT EnglishDescription, CrawlHeader, CrawlText, Priority"
      SQL += " FROM CrawlsDotText "
      SQL += where.Trim()
      Dim CmdSQL As New OleDbCommand(SQL, conn)

      CmdSQL.CommandType = System.Data.CommandType.Text
      Dim myReader As OleDbDataReader = CmdSQL.ExecuteReader()
      While myReader.Read()
        Dim NewItem As New FreeText()
        If Not myReader.IsDBNull(0) Then
          NewItem.EnglishDescription = myReader.GetString(0)
        End If
        If Not myReader.IsDBNull(1) Then
          NewItem.CrawlHeader = myReader.GetString(1)
        End If
        If Not myReader.IsDBNull(2) Then
          NewItem.CrawlText = myReader.GetString(2)
        End If
        If Not myReader.IsDBNull(3) Then
          NewItem.Priority = myReader.GetInt32(3)
        End If
        Me.FreeTextList.Add(NewItem)
      End While
      conn.Close()
    Catch err As Exception
      Throw err
    End Try
  End Sub

  Public Function GetByUID(uid As String) As FreeText
    Dim res As FreeText = Nothing
    Try
      For Each aux As FreeText In Me.FreeTextList
        If aux.UID = uid Then
          res = aux
          Exit For
        End If
      Next
    Catch ex As Exception

    End Try
    Return res
  End Function
End Class
