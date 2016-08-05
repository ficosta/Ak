Imports Opta_get_data

Public Class MultiFileDownloader
#Region "Properties"
  Public Property DownloadEnabled As Boolean

  Private WithEvents _downloads As New Downloads
  Public ReadOnly Property Downloads As Downloads
    Get
      Return _downloads
    End Get
  End Property

  Public Property HideFinishedDownloads As Boolean = False

  Public Enum eLayoutType
    OnlyHeader
    OnlyInfo
    Both
  End Enum

  Private _layoutType As eLayoutType = eLayoutType.Both
  Public Property LayoutType As eLayoutType
    Get
      Return _layoutType
    End Get
    Set(value As eLayoutType)
      _layoutType = value
      Select Case _layoutType
        Case eLayoutType.OnlyHeader
          Me.TableLayoutPanelAll.RowStyles(0).Height = 100
          Me.TableLayoutPanelAll.RowStyles(0).SizeType = SizeType.Percent
          Me.TableLayoutPanelAll.RowStyles(1).Height = 0
          Me.TableLayoutPanelAll.RowStyles(1).SizeType = SizeType.Absolute
        Case eLayoutType.OnlyInfo
          Me.TableLayoutPanelAll.RowStyles(0).Height = 0
          Me.TableLayoutPanelAll.RowStyles(0).SizeType = SizeType.Absolute
          Me.TableLayoutPanelAll.RowStyles(1).Height = 100
          Me.TableLayoutPanelAll.RowStyles(1).SizeType = SizeType.Percent
        Case eLayoutType.Both
          Me.TableLayoutPanelAll.RowStyles(0).Height = 30
          Me.TableLayoutPanelAll.RowStyles(0).SizeType = SizeType.Absolute
          Me.TableLayoutPanelAll.RowStyles(1).Height = 100
          Me.TableLayoutPanelAll.RowStyles(1).SizeType = SizeType.Percent
      End Select
    End Set
  End Property

#End Region


  Public Sub New()

    ' This call is required by the designer.
    InitializeComponent()

    ' Add any initialization after the InitializeComponent() call.
    InitDownloaders()
  End Sub


#Region "Interface functions"
  Public Sub UpdateDownloadInterface()
    Try
      For Each down As Download In _downloads.DownloadList
        Dim itm As Integer = Me.GetRowForItem(down)
        If itm = -1 Then
          itm = Me.MetroGridDownlodas.Rows.Add(down.UID)
        End If
        With Me.MetroGridDownlodas.Rows(itm)
          .Cells(ColumnDownloadsID.Index).Value = down.UID
          .Cells(ColumnDownloadsLocalFile.Index).Value = down.File
          .Cells(ColumnDownloadsProgress.Index).Value = IIf(down.Progress > 0, down.Progress & "%", "")
          .Cells(ColumnDownloadsState.Index).Value = down.State.ToString
          .Cells(ColumnDownloadsURL.Index).Value = down.URL
          If down.ErrorCode = 0 Then
            .Cells(ColumnDownloadsProgress.Index).Value = IIf(down.Progress > 0, down.Progress & "%", "")
          Else
            .Cells(ColumnDownloadsProgress.Index).Value = "H" & Hex(down.ErrorCode)
          End If

          .Visible = IIf(HideFinishedDownloads And down.State = Download.eDownloadState.Done, False, True)
        End With
      Next
    Catch ex As Exception
    End Try
  End Sub


  Private Function GetRowForItem(down As Download) As Integer
    Dim res As Integer = -1
    Try
      If down Is Nothing Then
        res = -1
      Else
        res = GetRowForItem(down.UID)
      End If
    Catch ex As Exception
    End Try
    Return res
  End Function

  Private Function GetRowForItem(uid As String) As Integer
    Dim res As Integer = -1
    Try
      For row As Integer = 0 To Me.MetroGridDownlodas.Rows.Count - 1
        If Me.MetroGridDownlodas.Rows(row).Cells(ColumnDownloadsID.Index).Value = uid Then
          res = row
          Exit For
        End If
      Next
    Catch ex As Exception
    End Try
    Return res
  End Function

  Private Sub _downloads_DownloadAdded(sender As Download) Handles _downloads.DownloadAdded
    Me.UpdateDownloadInterface()
    Me.DownloadNext()
  End Sub

  Private Sub _downloads_DownloadFinished(sender As Download) Handles _downloads.DownloadFinished
    Me.UpdateDownloadInterface()
    Me.DownloadNext()
  End Sub

  Private Sub _downloads_DownloadProgressChanged(sender As Download) Handles _downloads.DownloadProgressChanged
    Me.UpdateDownloadInterface()
    Me.DownloadNext()
  End Sub
#End Region

#Region "Downloader control"
  Private _fileDownloaders As New List(Of FileDownloader)
  Private _progressBars As New List(Of ProgressBar)

  Private Sub InitDownloaders()
    Try
      _fileDownloaders.Add(Me.FileDownloader1)
      _fileDownloaders.Add(Me.FileDownloader2)
      _fileDownloaders.Add(Me.FileDownloader3)

      _progressBars.Add(Me.ProgressBar1)
      _progressBars.Add(Me.ProgressBar2)
      _progressBars.Add(Me.ProgressBar3)

      For i As Integer = 0 To _fileDownloaders.Count - 1
        Dim down As FileDownloader = _fileDownloaders(i)
        AddHandler down.FileDownloaded, AddressOf FileDownloader_FileDownloaded
        AddHandler down.FileProgressChanged, AddressOf FileDownloader_FileProgressChanged

        If i < _progressBars.Count Then
          _progressBars(i).DataBindings.Add("Value", down, "Progress")
        End If
      Next
    Catch ex As Exception
    End Try
  End Sub


  Private Sub FileDownloader_FileProgressChanged(sender As FileDownloader, download As Download) Handles FileDownloader1.FileProgressChanged
    Try
      Me.UpdateDownloadInterface()
    Catch ex As Exception
    End Try
  End Sub

  Private Sub FileDownloader_FileDownloaded(sender As FileDownloader, download As Download) Handles FileDownloader1.FileDownloaded
    Try
      sender.StartDownload(Me.Downloads.GetNextDownload)
      Me.UpdateDownloadInterface()
      Me.DownloadNext()
    Catch ex As Exception
    End Try
  End Sub

  Private Sub DownloadNext()
    Try
      For Each fd As FileDownloader In _fileDownloaders
        If fd.IsBusy = False Then
          fd.StartDownload(Me.Downloads.GetNextDownload)
        End If
      Next
    Catch ex As Exception

    End Try
  End Sub
#End Region
End Class
