Public MustInherit Class Graphic
  Private WithEvents _match As MatchInfo.Match

  Public Property Name As String
  Public Property ID As String = Guid.NewGuid().ToString

  Public Property Scene As VizCommands.Scene

  Public Enum SceneType
    Normal
    ChangeOut
    ChangeInt
  End Enum

  Public MustOverride Function PrepareScene(gs As GraphicStep, sceneType As SceneType) As VizCommands.Scene

  Public Sub New()

  End Sub

  Public Sub New(match As MatchInfo.Match)
    _match = match
  End Sub
End Class
