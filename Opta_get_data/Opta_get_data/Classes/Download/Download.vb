Public Class Download
  Implements IComparable

  Public Property UID As String = Guid.NewGuid.ToString
  Public Property URL As String
  Public Property File As String
  Public Property ErrorCode As Integer = 0
  Public Property User As String
  Public Property Password As String
  Public Property Priority As Integer = 3
  Public Property TicksDateCreated As Long = Now.Ticks

  Public Event DownloadProgressChanged(sender As Download)
  Public Event DownloadFinished(sender As Download)

  Private _state As eDownloadState = eDownloadState.Idle
  Public Property State As eDownloadState
    Get
      Return _state
    End Get
    Set(value As eDownloadState)
      If _state <> value Then
        _state = value
        RaiseEvent DownloadProgressChanged(Me)
      End If
    End Set
  End Property

  Private _progress As Integer = 0
  Public Property Progress As Integer
    Get
      Return _Progress
    End Get
    Set(value As Integer)
      If _Progress <> value Then
        _Progress = value
        RaiseEvent DownloadProgressChanged(Me)
      End If
    End Set
  End Property


  Public Enum eDownloadState
    Idle
    BeginingDownload
    Downloading
    Done
    [Error]
  End Enum

  Public Function CompareTo(obj As Object) As Integer Implements IComparable.CompareTo
    Try
      Dim aux As Download = CType(obj, Download)
      If aux.Priority > Me.Priority Then
        Return 1
      ElseIf aux.Priority < Me.Priority Then
        Return -1
      Else
        If aux.TicksDateCreated < Me.TicksDateCreated Then
          Return 1
        ElseIf aux.TicksDateCreated > Me.TicksDateCreated Then
          Return -1
        Else
          Return 0
        End If
      End If
    Catch ex As Exception
      Return 0
    End Try
  End Function
End Class
