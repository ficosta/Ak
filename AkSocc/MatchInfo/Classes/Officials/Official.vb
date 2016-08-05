Imports System.Data.OleDb

Public Class Official

  Public OfficialID As Integer
  Public OfficialFirstName As String
  Public OfficialSurname As String
  Public OfficialArabicName As String

  'Variables non from the Official table
  Public ReadOnly Property OfficialName() As String
    Get
      Return Convert.ToString(OfficialFirstName & Convert.ToString(" ")) & OfficialSurname
    End Get
  End Property

  Public Sub New()
    InitOfficial(-1)
  End Sub

  Public Sub New(ID As Integer)
    InitOfficial(ID)
  End Sub

  Public Shared Function GetID(official As Official) As Integer
    Dim aux As Integer
    Try
      If (official Is Nothing) Then
        aux = 0
      Else
        aux = official.OfficialID
      End If
    Catch ex As Exception
    End Try
    Return aux
  End Function

#Region "Official info"
  Private Sub InitOfficial(ID As Integer)
    OfficialID = ID
    OfficialFirstName = ""
    OfficialSurname = ""
    OfficialArabicName = ""
    If ID <> -1 Then Me.GetFromDB()
  End Sub

  Public Function CreateCommand() As OleDbCommand
    Dim myOfficialCmd As New OleDbCommand()
    Try
      myOfficialCmd.Parameters.AddWithValue("@OfficialFirstName", OfficialFirstName)
      myOfficialCmd.Parameters.AddWithValue("@OfficialSurname", OfficialSurname)
      myOfficialCmd.Parameters.AddWithValue("@OfficialArabicName", OfficialArabicName)
    Catch err As Exception
      Throw err
    End Try
    Return myOfficialCmd
  End Function

  Public Function GetFromDB() As Boolean
    Try
      Dim conn As New OleDbConnection(Config.Instance.LocalConnectionString)
      conn.Open()

      Dim SQL As [String] = "SELECT OfficialFirstName, OfficialSurname, OfficialArabicName, OfficialID"
      SQL += " FROM Officials "
      SQL += " WHERE OfficialArabicName = '" & Me.OfficialArabicName & "'"
      Dim CmdSQL As New OleDbCommand(SQL, conn)

      CmdSQL.CommandType = System.Data.CommandType.Text
      Dim myOfficialReader As OleDbDataReader = CmdSQL.ExecuteReader()
      If myOfficialReader.Read() Then
        If Not myOfficialReader.IsDBNull(0) Then
          Me.OfficialFirstName = myOfficialReader.GetString(0)
        End If
        If Not myOfficialReader.IsDBNull(1) Then
          Me.OfficialSurname = myOfficialReader.GetString(1)
        End If
        If Not myOfficialReader.IsDBNull(2) Then
          Me.OfficialArabicName = myOfficialReader.GetString(2)
        End If
        If Not myOfficialReader.IsDBNull(3) Then
          Me.OfficialID = myOfficialReader.GetInt32(3)
        End If
      End If
      conn.Close()
    Catch err As Exception
      Throw err
    End Try
    Return True
  End Function

#End Region

  Public Overrides Function ToString() As String
    Return OfficialName
  End Function
End Class

