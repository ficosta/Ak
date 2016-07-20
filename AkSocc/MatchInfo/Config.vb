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
#End Region
End Class
