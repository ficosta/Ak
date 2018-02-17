Imports System.ComponentModel
Imports System.Net
Imports System.Net.Sockets

Public Class CheckSocketConnection
  Private WithEvents _backWorker As BackgroundWorker

  Public Event ConnectionCheckStateChanged(host As String, port As Integer, state As eSocketCheckState)


  Public Enum eSocketCheckState
    Idle = 0
    ResolvingAddress
    Connecting
    Connected
    Disconnected
    [Error]
  End Enum

  Public Property LastErrorCode As Integer = 0
  Public Property LasterrorDescription As String = ""
  Public Property LastSocketState As eSocketCheckState = eSocketCheckState.Idle


  Private _host As String
  Private _port As Integer

  Public Function CheckConnection(host As String, port As Integer) As Boolean
    Try
      Return True

      If _backWorker Is Nothing Then
        _backWorker = New BackgroundWorker
        _backWorker.WorkerSupportsCancellation = False
        _backWorker.WorkerReportsProgress = True
      End If
      If Not _backWorker.IsBusy Then
        _host = host
        _port = port
        _backWorker.RunWorkerAsync()
      End If
    Catch ex As Exception
      Debug.Print(ex.ToString)
      Return False
    End Try
    Return True
  End Function

  Private Sub _backWorker_DoWork(sender As Object, e As DoWorkEventArgs) Handles _backWorker.DoWork
    Try
      _backWorker.ReportProgress(eSocketCheckState.ResolvingAddress)
      Dim serverAddress As IPAddress

      serverAddress = Dns.GetHostEntry(_host).AddressList(0)
      For Each ip As IPAddress In Dns.GetHostEntry(_host).AddressList
        If ip.AddressFamily = AddressFamily.InterNetwork Then
          serverAddress = ip
          Exit For
        End If
      Next

      Dim ep As New IPEndPoint(serverAddress, _port)
      '--Create a new socket
      _backWorker.ReportProgress(eSocketCheckState.Connecting)
      Dim sck = New Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp)
      sck.Connect(ep)

      If sck.Connected Then
        _backWorker.ReportProgress(eSocketCheckState.Connected)
      Else
        _backWorker.ReportProgress(eSocketCheckState.Disconnected)
      End If
      sck.Disconnect(False)
    Catch ex As Exception
      _backWorker.ReportProgress(eSocketCheckState.Error)
      LastErrorCode = ex.HResult
      LasterrorDescription = ex.ToString
      Debug.Print(ex.ToString)
    End Try
  End Sub

  Private Sub _backWorker_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles _backWorker.RunWorkerCompleted

  End Sub

  Private Sub _backWorker_ProgressChanged(sender As Object, e As ProgressChangedEventArgs) Handles _backWorker.ProgressChanged
    Me.LastSocketState = CType(e.ProgressPercentage, eSocketCheckState)
    RaiseEvent ConnectionCheckStateChanged(_host, _port, CType(e.ProgressPercentage, eSocketCheckState))
  End Sub
End Class
