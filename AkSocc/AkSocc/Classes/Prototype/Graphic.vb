Public MustInherit Class Graphic
  Private WithEvents _match As MatchInfo.Match

  Public Property Name As String
  Public Property ID As String = Guid.NewGuid().ToString

  Public Property Scene As VizCommands.Scene

  Public Enum SceneType
    Normal
    ChangeOut
    ChangeIn
  End Enum

  Private _changeStep As Integer = 1
  Public Property ChangeStep As Integer
    Get
      Return _changeStep
    End Get
    Set(value As Integer)
      _changeStep = value
      For Each param As VizCommands.SceneParameter In Me.Scene.SceneParameters
        param.Name = param.Name.Replace("Side_1", "Side_%step%")
        param.Name = param.Name.Replace("Side_2", "Side_%step%")

        param.Name = param.Name.Replace("Side_%step%", "Size_" & _changeStep)
      Next
    End Set
  End Property
  Public MustOverride Function PrepareScene(gs As GraphicStep, sceneType As SceneType) As VizCommands.Scene

  Public Sub New()

  End Sub

  Public Sub New(match As MatchInfo.Match)
    _match = match
  End Sub
End Class
