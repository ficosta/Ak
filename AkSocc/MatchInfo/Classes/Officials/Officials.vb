

Imports System.Data.OleDb

Public Class Officials
  Inherits CollectionBase

  Public Sub New()
    GetFromDB()
  End Sub

  Public Function Add(Official As Official) As Integer
    Try
      If Not Official Is Nothing Then
        Dim found As Boolean
        For index As Integer = 0 To Me.List.Count - 1
          If Me.List(index).OfficialID = Official.OfficialID Then
            Me.List(index) = Official
            found = True
            Exit For
          End If
        Next
        If Not found Then
          Me.List.Add(Official)
        End If
      End If
    Catch ex As Exception
    End Try
    Return Me.List.Count
  End Function

  Default Public Property Item(Index As Integer) As Official
    Get
      Return DirectCast(List(Index), Official)
    End Get
    Set
      List(Index) = Value
    End Set
  End Property

  Public Function GetFromDB() As Boolean
    Try
      Dim conn As New OleDbConnection(Config.Instance.LocalConnectionString)
      conn.Open()

      Dim mySQL As String = "SELECT OfficialFirstName, OfficialSurname, OfficialArabicName, OfficialID FROM Officials ORDER BY OfficialSurname"

      Dim CmdSQL As New OleDbCommand(mySQL, conn)

      CmdSQL.CommandType = System.Data.CommandType.Text
      Dim myReader As OleDbDataReader = CmdSQL.ExecuteReader()
      While myReader.Read()
        Dim official As New Official()
        official.OfficialFirstName = myReader.GetString(0)
        official.OfficialSurname = myReader.GetString(1)
        official.OfficialArabicName = myReader.GetString(2)
        official.OfficialID = myReader.GetInt32(3)
        'player.GetPlayer()
        Me.InnerList.Add(official)
      End While
      myReader.Close()
      conn.Close()

    Catch ex As Exception

    End Try
    Return True
  End Function


  Public Function GetByName(name As String) As Official
    Dim output As Official = Nothing
    Try
      For Each Search As Official In List
        If Search.ToString = name Then
          output = Search
          Exit For
        End If
      Next
    Catch err As Exception
      Throw err
    End Try
    Return (output)
  End Function

  Public Function GetByID(id As Integer) As Official
    Dim output As Official = Nothing
    Try
      For Each Search As Official In List
        If Search.OfficialID = id Then
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
