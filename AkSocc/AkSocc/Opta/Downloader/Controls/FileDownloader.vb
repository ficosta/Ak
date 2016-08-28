Imports System.ComponentModel
Imports System.Net


Public Class FileDownloader
  Implements INotifyPropertyChanged

  Private WithEvents _client As WebClient

  Public Event FileProgressChanged(sender As FileDownloader, download As Download)
  Public Event FileDownloaded(sender As FileDownloader, download As Download)
  Public Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged
  Public ReadOnly Property Download As Download

  Private _isBusy As Boolean = False
  Public Property IsBusy As Boolean
    Get
      Return _isBusy
    End Get
    Set(value As Boolean)
      _isBusy = value
    End Set
  End Property

  Public ReadOnly Property Progress As Integer
    Get
      If _Download Is Nothing Then
        Return 0
      Else
        Return _Download.Progress
      End If
    End Get
  End Property


  Private Sub FileDownloader_Load(sender As Object, e As EventArgs) Handles MyBase.Load

  End Sub

  Public Sub StartDownload(down As Download)
    Try
      If IsBusy Then Exit Sub
      If down Is Nothing Then Exit Sub

      _Download = down

      If Not _client Is Nothing Then
        'we are not done!
      Else
        _client = New WebClient
      End If
      IsBusy = True

      _client.Credentials = New System.Net.NetworkCredential(down.User, down.Password)

      _client.DownloadFileAsync(New Uri(down.URL), down.File)
      _Download.Progress = 0
      _Download.State = Download.eDownloadState.BeginingDownload
      Me.LabelState.Text = "Start downloading"
    Catch ex As Exception
      _Download.ErrorCode = ex.HResult
      _Download.State = Download.eDownloadState.Error
    End Try
  End Sub


  Private Sub _client_DownloadProgressChanged(sender As Object, e As DownloadProgressChangedEventArgs) Handles _client.DownloadProgressChanged
    'report progress

    Dim bytesIn As Double = Double.Parse(e.BytesReceived.ToString())

    Dim totalBytes As Double = Double.Parse(e.TotalBytesToReceive.ToString())

    Dim percentage As Double = bytesIn / totalBytes * 100

    _Download.Progress = Int32.Parse(Math.Truncate(percentage).ToString())
    
    Me.LabelState.Text = System.IO.Path.GetFileName(_Download.File) ' _Download.Progress & "%"

    Me.ProgressBar1.Value = Int32.Parse(Math.Truncate(percentage).ToString())

    RaiseEvent FileProgressChanged(Me, _Download)
    RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs("Progress"))
  End Sub

  Private Sub _client_DownloadStringCompleted(sender As Object, e As DownloadStringCompletedEventArgs) Handles _client.DownloadStringCompleted
    'report complete
    IsBusy = False
    _Download.Progress = 100
    _Download.State = Download.eDownloadState.Done
    Me.LabelState.Text = System.IO.Path.GetFileName(_Download.File) ' _Download.Progress & "%"
    RaiseEvent FileDownloaded(Me, _Download)
    RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs("Progress"))
  End Sub

  Private Sub _client_DownloadFileCompleted(sender As Object, e As AsyncCompletedEventArgs) Handles _client.DownloadFileCompleted
    'report complete
    IsBusy = False
    _Download.Progress = 100
    _Download.State = Download.eDownloadState.Done
    RaiseEvent FileDownloaded(Me, _Download)
    RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs("Progress"))
    Me.LabelState.Text = System.IO.Path.GetFileName(_Download.File) ' _Download.Progress & "%"
  End Sub
End Class
