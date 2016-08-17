Public Class Config
#Region "Singleton"
  Private Shared _instance As Config

  ' Constructor is 'protected'
  Protected Sub New()
  End Sub

  Public Shared Function Instance() As Config
    ' Uses lazy initialization.
    ' Note: this is not thread safe.
    If _instance Is Nothing Then
      _instance = New Config()
    End If

    Return _instance
  End Function
#End Region

#Region "Properties"
  Public Property LocalConnectionString As String
  Public Property LocalODBCConnectionString As String
  Public Property OptaConnectionString As String
  Public Property LocalDataBasePath As String
  Public Property MatchDaysPath As String
  Public Property UseArabicNames As Boolean = False
  Public Property Silent As Boolean = False
  Public Property AsyncDataWrites As Boolean = False

  Private _oledbConnection As OleDb.OleDbConnection
  Public ReadOnly Property OledbConnection As OleDb.OleDbConnection
    Get
      Try
        If _oledbConnection Is Nothing Then
          _oledbConnection = New OleDb.OleDbConnection(Config.Instance.LocalConnectionString)
        End If
        If Not _oledbConnection.State = ConnectionState.Open Then
          _oledbConnection.Open()
        End If
      Catch ex As Exception
        Debug.Print(ex.ToString)
      End Try
      Return _oledbConnection
    End Get
  End Property


  Public Enum ePlayerSortType As Integer
    Position
    Name
    SquadNumber
    Stat
    OptaStat
  End Enum

  Public Property PlayerSortType As ePlayerSortType = ePlayerSortType.Position
  Public Property PlayerSortStatName As String = ""
#End Region
End Class
