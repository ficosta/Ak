Imports VizCommands

Public Class ClockGenericStraps
  Private WithEvents _clockControl As ClockControl = ClockControl.Instance

  Public Scene As Scene

  Public SceneAnimation As String = "anim_Clock_Generic_Straps"


  Public Sub ShowStraps(strap1 As String, strap2 As String)
    Try
      Me.Scene = New Scene
      With Me.Scene
        .SceneName = _clockControl.Scene.SceneName
        .VizLayer = _clockControl.Scene.VizLayer

        .SceneParameters.Add("Clock_Generic_Straps_Data_01_Text", strap1)
        .SceneParameters.Add("Clock_Generic_Straps_Data_02_Text", strap2)
      End With

      Me.Scene.SendSceneToEngine(_clockControl.VizControl)
      _clockControl.VizControl.DirectorStart(SceneAnimation, Me.Scene.VizLayer)

    Catch ex As Exception
      WriteToErrorLog(ex)
    End Try
  End Sub

  Public Sub HideSubstitution()
    _clockControl.VizControl.DirectorContinue(SceneAnimation, Me.Scene.VizLayer)
  End Sub
End Class
