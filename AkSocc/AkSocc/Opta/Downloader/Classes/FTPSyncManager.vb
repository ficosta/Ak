Imports System.ComponentModel
Imports System.IO
Imports System.Net
Imports AkSocc.FTPSyncManager

Public Class FTPSyncManager
#Region "Singleton"
  Private Shared ReadOnly _instance As New Lazy(Of FTPSyncManager)(Function() New FTPSyncManager(), System.Threading.LazyThreadSafetyMode.ExecutionAndPublication)

  Private Sub New()

  End Sub

  Public Shared ReadOnly Property Instance() As FTPSyncManager
    Get
      Return _instance.Value
    End Get
  End Property
#End Region


#Region "Variables and properties"
  Private WithEvents _backgroundSyncWorker As BackgroundWorker

  Public Property FTPServer As String
  Public Property FTPPath As String
  Public Property FTPUser As String
  Public Property FTPPassword As String

  Public Property LocalPath As String

  Private _enabled As Boolean = False
  Public Property Enabled As Boolean
    Get
      Return _enabled
    End Get
    Set(value As Boolean)
      _enabled = value
    End Set
  End Property
#End Region

#Region "Events and enums"
  Public Event SyncStarted()
  Public Event SyncFinished()
  Public Event AllFilesInSync()
  Public Event SyncStateChanged(syncState As CThreadState)
  Public Event RefreshCompleted(newFiles As List(Of String), newerFiles As List(Of String), unchangedFiles As List(Of String))

  Public Enum eThreadState
    Idle = 0
    NotEnabled
    CheckingFTPContents
    GettingFTPFileDetails
    ComparingLocalAndRemoteFiles
    Done
  End Enum



#End Region

#Region "Local classes"
  Public Class CThreadState
    Public threadState As eThreadState = eThreadState.Idle
    Public allRemoteFiles As New List(Of FTPFileInfo)
    Public allLocalFiles As New List(Of FTPFileInfo)
    Public NewFiles As New List(Of FTPFileInfo)
    Public ChangedFiles As New List(Of FTPFileInfo)

    Public Sub New(state As eThreadState)
      threadState = state
    End Sub
  End Class
#End Region

  Public Sub Initialize(ftpServer As String, ftpPath As String, ftpuser As String, ftpassword As String, localPath As String)
    Try
      Me.FTPServer = ftpServer
      Me.FTPPath = ftpPath
      Me.FTPUser = ftpuser
      Me.FTPPassword = ftpassword

      Me.LocalPath = localPath

      If _backgroundSyncWorker Is Nothing Then
        _backgroundSyncWorker = New BackgroundWorker
        _backgroundSyncWorker.WorkerReportsProgress = True
        _backgroundSyncWorker.WorkerSupportsCancellation = True
      End If
      If Not _backgroundSyncWorker.IsBusy Then
        _backgroundSyncWorker.RunWorkerAsync()
      End If
    Catch ex As Exception
      WriteToErrorLog(ex)
    End Try
  End Sub

  Private Sub _backgroundSyncWorker_Disposed(sender As Object, e As EventArgs) Handles _backgroundSyncWorker.Disposed

  End Sub

  Private Sub _backgroundSyncWorker_DoWork(sender As Object, e As DoWorkEventArgs) Handles _backgroundSyncWorker.DoWork
    Try
      While Not _backgroundSyncWorker.CancellationPending
        If Not _enabled Then
          'doing nothing, just chillin'
        Else
          Dim threadState As New CThreadState(eThreadState.CheckingFTPContents)

          'connect to ftp
          'check ftp path contents
          _backgroundSyncWorker.ReportProgress(threadState.threadState, threadState)

          threadState = New CThreadState(eThreadState.ComparingLocalAndRemoteFiles)
          Dim filesInFTP As List(Of FTPFileInfo) = GetFTPDirectoryDetails(Me.FTPServer)
          'for each file, compare to local folder
          For Each fileInFTP As FTPFileInfo In filesInFTP
            If Not fileInFTP.fileName Is Nothing Then
              Dim localFilePath As String = System.IO.Path.Combine(Me.LocalPath, fileInFTP.fileName)
              If File.Exists(localFilePath) = False Then
                'doesn't exist
                threadState.NewFiles.Add(fileInFTP)
              Else
                Dim localFileInfo As New FTPFileInfo(localFilePath, True)
                If localFileInfo.size <> fileInFTP.size Then
                  threadState.ChangedFiles.Add(fileInFTP)
                End If
              End If
            End If
          Next
          _backgroundSyncWorker.ReportProgress(threadState.threadState, threadState)
        End If
        Threading.Thread.Sleep(10000)
      End While
    Catch ex As Exception
      WriteToErrorLog(ex)
    End Try
  End Sub

  <Serializable()> Public Class FTPFileInfo
    Public permissions As String
    Public number As Integer
    Public owner As String
    Public group As String
    Public size As Integer
    Public modificationDate As Date
    Public fileName As String
    Public isLocal As Boolean = False

    Public ReadOnly Property FullPathLocal As String
      Get
        Return System.IO.Path.Combine(FTPSyncManager.Instance.LocalPath, Me.fileName)
      End Get
    End Property

    Public ReadOnly Property FullPathRemote As String
      Get
        Return System.IO.Path.Combine(FTPSyncManager.Instance.FTPServer, Me.fileName).Replace("\", "/")
      End Get
    End Property

    Public Sub New(text As String, local As Boolean)
      Try
        Me.isLocal = local
        If isLocal = False Then
          'ftp file
          Dim aAux() As String = text.Split(" ")

          If aAux.Length > 9 Then
            permissions = GetNextValueIndex(aAux)
            number = NoNullInt(GetNextValueIndex(aAux))
            owner = GetNextValueIndex(aAux)
            group = GetNextValueIndex(aAux)
            size = NoNullInt(GetNextValueIndex(aAux))
            Dim dateAux As String = GetNextValueIndex(aAux) & " " & GetNextValueIndex(aAux) & " " & Now.Year & " " & GetNextValueIndex(aAux)
            Dim myDate As Date
            Date.TryParse(dateAux, myDate)
            Me.modificationDate = myDate
            Dim name As String = GetNextValueIndex(aAux)
            For i As Integer = _lastValueIndex + 1 To aAux.Length - 1
              name = name & " " & aAux(i)
            Next
            fileName = name
          End If
        Else
          'local file
          Dim myFileInfo As New FileInfo(text)
          permissions = "local permissions"
          number = 1
          owner = "who knows"
          group = "who knows"
          size = myFileInfo.Length
          modificationDate = myFileInfo.LastWriteTime
          fileName = System.IO.Path.GetFileName(text)
        End If
      Catch ex As Exception

      End Try
    End Sub


    Private _lastValueIndex As Integer = -1

    Private Function GetNextValueIndex(aValues() As String) As String
      Dim res As String = ""
      Try
        For i As Integer = _lastValueIndex + 1 To aValues.Count - 1
          _lastValueIndex = i
          If aValues(i) <> "" Then
            res = aValues(i)
            Exit For
          End If
        Next
      Catch ex As Exception

      End Try
      Return res
    End Function
  End Class

  Public Function GetFTPDirectoryDetails(uri As String) As List(Of FTPFileInfo)
    Dim res As New List(Of FTPFileInfo)
    Try
      ' Get the object used to communicate with the server.
      Dim aux As New Uri(uri)
      Dim request As FtpWebRequest = DirectCast(WebRequest.Create(uri), FtpWebRequest)
      request.Method = WebRequestMethods.Ftp.ListDirectoryDetails

      ' This example assumes the FTP site uses anonymous logon.
      request.Credentials = New NetworkCredential(FTPUser, FTPPassword)

      Dim response As FtpWebResponse = DirectCast(request.GetResponse(), FtpWebResponse)

      Dim responseStream As Stream = response.GetResponseStream()
      Dim reader As New StreamReader(responseStream)

      Dim myRes As String = reader.ReadToEnd()
      myRes = myRes.Replace("""", "")
      myRes = myRes.Replace("&", "")
      myRes = myRes.Replace(vbCrLf, "~")

      Dim aAux() As String = myRes.Split("~")
      For i As Integer = 0 To aAux.Length - 1
        Dim fileInfo As New FTPFileInfo(aAux(i), False)
        If fileInfo.number = 1 Then
          res.Add(fileInfo)
        End If
      Next

      reader.Close()
      response.Close()
    Catch ex As Exception
      WriteToErrorLog(ex)
    End Try
    Return res
  End Function

  Public Function GetFileCreationDate(ByVal file As String) As DateTime
    Dim dte As DateTime
    Try
      Dim ftp As Net.FtpWebRequest = Net.FtpWebRequest.Create(file)
      ftp.Credentials = New System.Net.NetworkCredential(FTPUser, FTPPassword)
      ftp.Method = Net.WebRequestMethods.Ftp.GetDateTimestamp
      Using response = CType(ftp.GetResponse(), Net.FtpWebResponse)
        dte = response.LastModified
      End Using
    Catch ex As Exception
      WriteToErrorLog(ex)
    End Try
    Return dte
  End Function

  Private Sub _backgroundSyncWorker_ProgressChanged(sender As Object, e As ProgressChangedEventArgs) Handles _backgroundSyncWorker.ProgressChanged
    Try
      RaiseEvent SyncStateChanged(CType(e.UserState, CThreadState))
    Catch ex As Exception

    End Try
  End Sub

  Private Sub _backgroundSyncWorker_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles _backgroundSyncWorker.RunWorkerCompleted

  End Sub
End Class
