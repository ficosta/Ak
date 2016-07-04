Imports System.ComponentModel
Imports System.Drawing
Imports System.IO

Public Class PreviewControl
  Private _llistaAssets As New List(Of PreviewAsset)
  Private _pendingAssets As New List(Of PreviewAsset)
  Private _processedAssets As New List(Of PreviewAsset)
  Private _finishedAssets As New List(Of PreviewAsset)
  Private _activeAsset As PreviewAsset = Nothing
  Private _localBasePath As String = "\\vaio\Shared\Snapshots"
  Private _remoteBasePath As String = "\\vaio\Shared\Snapshots"
  Private _tConfig As tyConfigVizrt

  Public Event AssetAdded(ByVal asset As PreviewAsset)
  Public Event ActiveAssetChanged(ByVal asset As PreviewAsset, ByVal former_asset As PreviewAsset)
  Public Event AssetStateChanged(ByVal asset As PreviewAsset)

#Region "Properties"
  Public Property LocalBasePath() As String
    Get
      Return _localBasePath
    End Get
    Set(ByVal value As String)
      _localBasePath = value
    End Set
  End Property

  Public Property RemoteBasePath() As String
    Get
      Return _remoteBasePath
    End Get
    Set(ByVal value As String)
      _remoteBasePath = value
    End Set
  End Property
#End Region

#Region "Constructors"
  Public Sub New(ByVal tConfig As tyConfigVizrt)
    _tConfig = tConfig
    Me.InitBackgroundWorker()
  End Sub

  Public Sub New(ByVal tConfig As tyConfigVizrt, ByVal localBasePath As String, remoteBasePath As String)
    _tConfig = tConfig
    _localBasePath = localBasePath
    _remoteBasePath = remoteBasePath
    Me.InitBackgroundWorker()
  End Sub
#End Region

#Region "Asset functions"
  Public Function NewAsset(ByVal scene As Scene) As PreviewAsset
    Dim res As PreviewAsset = Nothing
    Try
      res = New PreviewAsset()
      res = Me.NewAsset("", scene)
    Catch ex As Exception
      Throw ex
    End Try
    Return res
  End Function

  Public Function NewAsset(ByVal id As String, ByVal scene As Scene) As PreviewAsset
    Dim res As PreviewAsset = Nothing
    Dim assetId As String = id

    Try
      If assetId = "" Then assetId = Guid.NewGuid().ToString
      res = GetAsset(assetId)
      If res Is Nothing Then
        'add new
        res = New PreviewAsset(assetId, scene)
        _llistaAssets.Add(res)
        _pendingAssets.Add(res)
      Else
        'reuse existing asset
        res.Scene = scene
        res.AssetSate = ePreviewAssetState.Idle
        If _pendingAssets.Contains(res) Then
          _pendingAssets.Remove(res)
        End If
        _pendingAssets.Add(res)
        _processedAssets.Remove(res)
        _finishedAssets.Remove(res)
      End If
      'per si està aturat
      InitBackgroundWorker()
    Catch ex As Exception
      Throw ex
    End Try
    Return res
  End Function

  Public Function GetAsset(ByVal id As String) As PreviewAsset
    Dim res As PreviewAsset = Nothing
    Try
      For Each aux As PreviewAsset In _llistaAssets
        If aux.ID = id Then
          res = aux
          Exit For
        End If
      Next
    Catch ex As Exception
      Throw ex
    End Try
    Return res
  End Function

  Private Sub SelectActiveAsset(ByVal asset As PreviewAsset)
    Try
      Me.ActiveAsset = asset
    Catch ex As Exception
      Throw ex
    End Try
  End Sub

  Private Sub SelectActiveAsset(ByVal id As String)
    Try
      Me.ActiveAsset = Me.GetAsset(id)
    Catch ex As Exception
      Throw ex
    End Try
  End Sub

  Private Property ActiveAsset() As PreviewAsset
    Get
      Return _activeAsset
    End Get
    Set(ByVal value As PreviewAsset)
      Dim former As PreviewAsset = _activeAsset
      _activeAsset = value
      RaiseEvent ActiveAssetChanged(_activeAsset, former)
    End Set
  End Property
#End Region

#Region "Queu control"
  Private WithEvents _backgroundWorker As New BackgroundWorker

  Private Sub InitBackgroundWorker()
    If Not _backgroundWorker.IsBusy Then
      _backgroundWorker.WorkerReportsProgress = True
      _backgroundWorker.WorkerSupportsCancellation = True
      _backgroundWorker.RunWorkerAsync()
    End If
  End Sub

  Private Sub FinishBackgroundWorker()
    If Not _backgroundWorker Is Nothing Then
      _backgroundWorker.CancelAsync()
    End If
  End Sub

  Private Enum eWorkState
    AssetSelected
    AssetStateChanged
  End Enum
  Private Structure WorkState
    Dim state As eWorkState
    Dim asset As PreviewAsset
  End Structure

  Private Sub _backgroundWorker_DoWork(ByVal sender As Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles _backgroundWorker.DoWork
    Try
      Dim controlVizrt As New VizControl()

      controlVizrt.InitializeSockets(_tConfig)

      While Not _backgroundWorker.CancellationPending
        If _pendingAssets.Count > 0 Then
          Dim asset As PreviewAsset = _pendingAssets(0)
          Dim filePath As String = System.IO.Path.Combine(_remoteBasePath, asset.AssetFileName & ".png")

          _backgroundWorker.ReportProgress(0, New WorkState() With {.state = eWorkState.AssetSelected, .asset = asset})
          If asset.Scene Is Nothing Then
            'nothing to do here!
          Else
            Debug.Print(asset.Scene.SceneName)
            'send scene to preview server
            asset.Scene.SendSceneToEngine(controlVizrt)
            asset.Scene.JumpToEndFrame(controlVizrt, asset.Scene.SceneDirectorsIn)
            
            asset.AssetSate = ePreviewAssetState.Rendering
            _backgroundWorker.ReportProgress(0, New WorkState() With {.state = eWorkState.AssetStateChanged, .asset = asset})

            'request image to be created
            controlVizrt.TakeSnapshot(filePath, False)
            _processedAssets.Add(asset)
          End If
          'we must wait for the snapshot to be taken, but we can continue working meanwhile
          _pendingAssets.RemoveAt(0)
        End If
        Threading.Thread.Sleep(300)

        If _processedAssets.Count > 0 Then
          For index As Integer = _processedAssets.Count - 1 To 0 Step -1
            Dim asset As PreviewAsset = _processedAssets(index)
            Dim filePath As String = System.IO.Path.Combine(_localBasePath, asset.AssetFileName & ".png")
            If System.IO.File.Exists(filePath) Then
              Try
                'clone created image and move to finished list
                'Dim bmp As New Drawing.Bitmap(filePath)
                'asset.AssetImage = bmp.Clone
                'bmp.Dispose()
                Using fs As New FileStream(filePath, FileMode.Open, FileAccess.Read)
                  Dim bmp As Bitmap = Image.FromStream(fs)
                  Dim newBmp As New Bitmap(bmp.Width, bmp.Height)
                  Using g As Graphics = Graphics.FromImage(newBmp)
                    g.DrawImageUnscaled(bmp, New Point(0, 0))
                  End Using
                  asset.AssetImage = newBmp.Clone
                  bmp.Dispose()
                End Using

                System.IO.File.Delete(filePath)
                asset.AssetSate = ePreviewAssetState.Done
                _backgroundWorker.ReportProgress(0, New WorkState() With {.state = eWorkState.AssetStateChanged, .asset = asset})
                _finishedAssets.Add(asset)
                _processedAssets.RemoveAt(index)
              Catch ex As Exception
              End Try
            End If
          Next

        End If
        Threading.Thread.Sleep(20)
      End While
      Debug.Print("Preview control thread finished")
    Catch ex As Exception
      Throw ex
    End Try
  End Sub

  Private Sub _backgroundWorker_ProgressChanged(ByVal sender As Object, ByVal e As System.ComponentModel.ProgressChangedEventArgs) Handles _backgroundWorker.ProgressChanged
    Try
      Dim workState As WorkState = CType(e.UserState, WorkState)
      Select Case workState.state
        Case eWorkState.AssetSelected
          Me.ActiveAsset = workState.asset
        Case eWorkState.AssetStateChanged
          RaiseEvent AssetStateChanged(workState.asset)

      End Select
    Catch ex As Exception

    End Try
  End Sub

  Private Sub _backgroundWorker_RunWorkerCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles _backgroundWorker.RunWorkerCompleted

  End Sub
#End Region


  Protected Overrides Sub Finalize()
    MyBase.Finalize()
    Try
      _backgroundWorker.CancelAsync()
      _backgroundWorker.Dispose()

    Catch ex As Exception

    End Try

  End Sub
End Class
