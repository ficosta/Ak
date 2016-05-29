﻿Imports System.ComponentModel

Public Enum SceneLayer
  Middle = 0
  Back = 1
  Front = 2
End Enum

<Serializable()> Public Class Scene
  Implements ICloneable

  <NonSerialized()> Private WithEvents _backgroundWorker As BackgroundWorker


  Public Enum eBackgroundImageState
    AsInScene
    Active
    Inactive
  End Enum
  Public BackgroundImageState As eBackgroundImageState = eBackgroundImageState.Inactive

  Public Property SceneName As String
  Public Property SceneDirector As String = "DIR_MAIN"
  Public Property SceneParameters As New SceneParameters
  Public Property VizLayer As SceneLayer = SceneLayer.Middle
  Public Property PreviewJumpoTime As Integer = 0

  Public Property SceneDirectorsIn As New SceneDirectors
  Public Property SceneDirectorsOut As New SceneDirectors
  Public Property SceneDirectorsChange As New SceneDirectors
  Private _currentSceneDirectors As SceneDirectors

  Private WithEvents _vizrtControl As VizControl = Nothing

  Public Function Clone() As Object Implements ICloneable.Clone
    Throw New NotImplementedException()
  End Function


  Public Function SendSceneToEngine(ByRef CiControlVizrt As VizControl, Optional ByVal niIdioma As Integer = 0, Optional ByVal biUcaseTexts As Boolean = False, Optional ByVal biActivate As Boolean = True) As Integer
    Dim nCount As Integer = 0
    Dim sValor As String
    Dim bUcase As Boolean = biUcaseTexts

    Try
      _vizrtControl = CiControlVizrt
      ' _vizrtControl.LoadScene(Me.Escena)

      bUcase = _vizrtControl.Config.UcaseTexts
      If biActivate Then
        _vizrtControl.ActivateScene("", Me.VizLayer)
        _vizrtControl.ActivateScene(_vizrtControl.Config.SceneBasePath & Me.SceneName, Me.VizLayer)
        Select Case Me.BackgroundImageState
          Case eBackgroundImageState.Active
            _vizrtControl.SetSceneBackgroundImageActive(True, Me.VizLayer)
          Case eBackgroundImageState.Inactive
            _vizrtControl.SetSceneBackgroundImageActive(False, Me.VizLayer)
          Case Else
            'do nothing
        End Select
      End If
      For Each CParam As SceneParameter In Me.SceneParameters

        sValor = CParam.Value

        Select Case CParam.Type
          Case paramType.Text
            If bUcase Then sValor = UCase(sValor)
            _vizrtControl.SetControlObjectValue("$object", CParam.Name, sValor, Me.VizLayer)
          Case paramType.Image
            _vizrtControl.SetControlObjectImageValue("$object", CParam.Name, sValor, Me.VizLayer)
          Case paramType.Numeric
        End Select
        nCount = nCount + 1
        'If nCount Mod 100 = 0 Then
        '  System.Threading.Thread.Sleep(0)
        '  System.Windows.Forms.Application.DoEvents()
        'End If
      Next
    Catch ex As Exception

    End Try
    Return nCount
  End Function

  Public Enum TypeOfDirectors
    InDirectors
    OutDirectors
    ChangeDirectors
  End Enum

  Public Sub StartSceneDirectors(CiControlVizrt As VizControl, type As TypeOfDirectors)
    Select Case type
      Case TypeOfDirectors.InDirectors
        StartSceneDirectors(CiControlVizrt, Me.SceneDirectorsIn)
      Case TypeOfDirectors.OutDirectors
        StartSceneDirectors(CiControlVizrt, Me.SceneDirectorsOut)
      Case TypeOfDirectors.ChangeDirectors
        StartSceneDirectors(CiControlVizrt, Me.SceneDirectorsChange)

    End Select
  End Sub

  Public Sub StartSceneDirectors(CiControlVizrt As VizControl, sceneDirectors As SceneDirectors)
    Try
      _vizrtControl = CiControlVizrt
      If _backgroundWorker Is Nothing Then
        _backgroundWorker = New BackgroundWorker
        _backgroundWorker.WorkerReportsProgress = True
        _backgroundWorker.WorkerSupportsCancellation = True
      End If

      _currentSceneDirectors = sceneDirectors

      If Not _backgroundWorker.IsBusy Then
        _backgroundWorker.RunWorkerAsync()
      End If
    Catch ex As Exception

    End Try
  End Sub

  Private Sub _backgroundWorker_DoWork(sender As Object, e As DoWorkEventArgs) Handles _backgroundWorker.DoWork
    Try
      Dim frame As Integer = 0
      Dim maxFrame As Integer = Me._currentSceneDirectors.MaxFrame
      Dim stopWatch As New Stopwatch
      stopWatch.Start()
      'report first frame
      _backgroundWorker.ReportProgress(0)
      While Not frame > maxFrame And Not _backgroundWorker.CancellationPending
        Threading.Thread.Sleep(1)
        Dim nextFrame As Integer = stopWatch.ElapsedMilliseconds / 20
        If nextFrame <> frame Then
          For i As Integer = frame + 1 To nextFrame
            _backgroundWorker.ReportProgress(i)
          Next
          frame = nextFrame
        End If
      End While
    Catch ex As Exception
    End Try
  End Sub

  Private Sub _backgroundWorker_ProgressChanged(sender As Object, e As ProgressChangedEventArgs) Handles _backgroundWorker.ProgressChanged
    Debug.Print("frame " & e.ProgressPercentage)
    Try
      For Each director As SceneDirector In _currentSceneDirectors.GetSceneDirectorsByFrame(e.ProgressPercentage)
        Select Case director.Action
          Case DirectorAction.Start
            _vizrtControl.DirectorStart(director.Name, Me.VizLayer)
          Case DirectorAction.ContinueNormal
            _vizrtControl.DirectorContinue(director.Name, Me.VizLayer)
          Case DirectorAction.ContinueReverse
            _vizrtControl.DirectorContinueReverse(director.Name, Me.VizLayer)
          Case DirectorAction.Pause
            _vizrtControl.DirectorStop(director.Name, Me.VizLayer)
          Case DirectorAction.Rewind
            _vizrtControl.DirectorGoTo(director.Name, 0, Me.VizLayer)
        End Select
      Next

    Catch ex As Exception
      Debug.Print(ex.ToString)
    End Try
  End Sub

  Private Sub _backgroundWorker_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles _backgroundWorker.RunWorkerCompleted

  End Sub
End Class
