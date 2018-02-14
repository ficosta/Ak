Imports MlSoccerClient
Imports MlSoccerClient.FTPSyncManager

Public Class frmOptaFTPSync
  Private WithEvents _ftpSyncManager As FTPSyncManager = FTPSyncManager.Instance

  Private Sub frmOptaFTPSync_Shown(sender As Object, e As EventArgs) Handles Me.Shown
    FTPSyncManager.Instance.Initialize(AppSettings.Instance.OptaFTPServer, AppSettings.Instance.OptaFTPPath, AppSettings.Instance.OptaFTPUser, AppSettings.Instance.OptaFTPPassword, AppSettings.Instance.OptaDefaultFolder)
    FTPSyncManager.Instance.Enabled = True
  End Sub

  Private Sub _ftpSyncManager_SyncStateChanged(syncState As FTPSyncManager.CThreadState) Handles _ftpSyncManager.SyncStateChanged
    Try

      Dim down As New Download()
      For Each ftpFile As FTPFileInfo In syncState.NewFiles
        down = New Download()
        down.URL = ftpFile.FullPathRemote
        down.File = ftpFile.FullPathLocal
        down.User = _ftpSyncManager.FTPUser
        down.Password = _ftpSyncManager.FTPPassword
        Me.MultiFileDownloaderAll.Downloads.AddDownload(down)
      Next

      For Each ftpFile As FTPFileInfo In syncState.ChangedFiles
        down = New Download()
        down.URL = ftpFile.FullPathRemote
        down.File = ftpFile.FullPathLocal
        down.User = _ftpSyncManager.FTPUser
        down.Password = _ftpSyncManager.FTPPassword
        Me.MultiFileDownloaderAll.Downloads.AddDownload(down)
      Next
    Catch ex As Exception

    End Try
  End Sub

End Class