Imports MatchInfo

Public MustInherit Class GraphicGroup
  Private WithEvents _match As MatchInfo.Match
  Public Property Match As MatchInfo.Match
    Get
      Return _match
    End Get
    Set(value As MatchInfo.Match)
      _match = value
    End Set
  End Property

  Public Property Name As String
  Public Property ID As Integer

  Public Property GraphicStepTree As New GraphicSteps

  Public Property graphicStep As GraphicStep
  Public Property formerGraphicStep As GraphicStep

  Public Property KeyCombination As KeyCombination = Nothing

  Public Property Scene As New VizCommands.Scene

  Public Property AutomaticGraphic As Boolean = True

  Public Sub New(match As Match)
    _match = match
  End Sub

  Public MustOverride Function PrepareNextGraphicStep(Optional graphicStep As GraphicStep = Nothing) As GraphicStep

  Public MustOverride Function PrepareScene(graphicStep As GraphicStep) As VizCommands.Scene

  Public Overridable Function PostProcessingAction() As Boolean
    Try

    Catch ex As Exception

    End Try
    Return False
  End Function

  Public Overridable Function PreProcessingAction() As Boolean
    Try

    Catch ex As Exception

    End Try
    Return True
  End Function

  Public Overridable Function Send(viz As VizCommands.VizControl_new) As Boolean
    Try

    Catch ex As Exception

    End Try
    Return True
  End Function

  Public Overridable Function GetPreview(viz As VizCommands.VizControl_new, pic As PictureBox) As Boolean
    Try

    Catch ex As Exception

    End Try
    Return True
  End Function

  Public Overrides Function ToString() As String
    Return Me.Name
    Return MyBase.ToString()
  End Function

End Class
