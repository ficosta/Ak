
Public Class Downloads
  Public DownloadList As New List(Of Download)

  Public Event DownloadAdded(sender As Download)
  Public Event DownloadProgressChanged(sender As Download)
  Public Event DownloadFinished(sender As Download)


  Public Function GetNextDownload() As Download
    Dim res As Download = Nothing
    Try
      DownloadList.Sort()
      For Each down As Download In Me.DownloadList
        If down.State = Download.eDownloadState.Idle Then
          res = down
          Exit For
        End If
      Next
    Catch ex As Exception

    End Try
    Return res
  End Function

#Region "Adding downloads"
  Public Function AddDownload(url As String, file As String) As Download
    Dim down As Download = Nothing
    Try
      down = New Download
      down.URL = url
      down.File = file
      Return Me.AddDownload(down)
    Catch ex As Exception
    End Try
    Return down
  End Function

  Public Function AddDownload(down As Download) As Download
    Try
      'don't add if there's one like this pending
      If Me.GetDownloads(down.URL, down.File, down.State, down.Priority).Count = 0 Then
        Me.DownloadList.Add(down)
        Me.DownloadList.Sort()

        AddHandler down.DownloadFinished, AddressOf Me.Handler_DownloadFinished
        AddHandler down.DownloadProgressChanged, AddressOf Me.Handler_DownloadProgressChanged

        RaiseEvent DownloadAdded(down)


      End If
    Catch ex As Exception

    End Try
    Return down
  End Function
#End Region

#Region "Events and handlers"
  Private Sub Handler_DownloadAdded(sender As Download)

  End Sub
  Private Sub Handler_DownloadProgressChanged(sender As Download)

  End Sub
  Private Sub Handler_DownloadFinished(sender As Download)

  End Sub


#End Region

#Region "Getting downloads"
  Public Function GetDownloadByUID(uid As String) As Download
    Dim res As Download = Nothing
    Try
      For Each down As Download In Me.DownloadList
        If down.UID = uid Then
          res = down
        End If
      Next
    Catch ex As Exception

    End Try
    Return res
  End Function


  Public Function GetDownloads(url As String, file As String, state As Download.eDownloadState, priority As Integer) As List(Of Download)
    Dim res As New List(Of Download)
    Try
      For Each down As Download In Me.DownloadList
        If down.URL = url And down.File = file And down.State = state And down.Priority = priority Then
          res.Add(down)
        End If
      Next
    Catch ex As Exception

    End Try
    Return res
  End Function


  Public Function GetDownloads(url As String, file As String, state As Download.eDownloadState) As List(Of Download)
    Dim res As New List(Of Download)
    Try
      For Each down As Download In Me.DownloadList
        If down.URL = url And down.File = file And down.State = state Then
          res.Add(down)
        End If
      Next
    Catch ex As Exception

    End Try
    Return res
  End Function

  Public Function GetDownloads(url As String, file As String) As List(Of Download)
    Dim res As New List(Of Download)
    Try
      For Each down As Download In Me.DownloadList
        If down.URL = url And down.File = file Then
          res.Add(down)
        End If
      Next
    Catch ex As Exception

    End Try
    Return res
  End Function

  Public Function GetDownloadsByURL(url As String) As List(Of Download)
    Dim res As New List(Of Download)
    Try
      For Each down As Download In Me.DownloadList
        If down.URL = url Then
          res.Add(down)
        End If
      Next
    Catch ex As Exception

    End Try
    Return res
  End Function

  Public Function GetDownloadsByFile(file As String) As List(Of Download)
    Dim res As New List(Of Download)
    Try
      For Each down As Download In Me.DownloadList
        If down.File = file Then
          res.Add(down)
        End If
      Next
    Catch ex As Exception

    End Try
    Return res
  End Function
#End Region
End Class
