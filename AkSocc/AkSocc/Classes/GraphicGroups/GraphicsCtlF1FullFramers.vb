Imports AkSocc
Imports VizCommands

Public Class GraphicGroupCtlF1FullFramers
  Inherits GraphicGroup

  Public Sub New(_match As MatchInfo.Match)
    MyBase.New(_match)

    MyBase.Name = "GraphicsCtlF1FullFramers"
    MyBase.ID = 1
  End Sub


  Public Overrides Function PrepareNextGraphicStep(Optional graphicStep As GraphicStep = Nothing) As GraphicStep
    Dim gsList As New GraphicSteps
    Dim gs As GraphicStep = graphicStep
    If gs Is Nothing Then gs = New GraphicStep(graphicStep, Me.Name)
    Me.GraphicStepTree.Add(graphicStep)
    Try
      If graphicStep Is Nothing Then
        gs.GraphicSteps.Add(New GraphicStep(gs, "League table (start with top)", "LT_TW"))
        gs.GraphicSteps.Add(New GraphicStep(gs, "League table (start with bottom)", "LT_SB"))
        gs.GraphicSteps.Add(New GraphicStep(gs, "Other match scores", "OM"))
        gs.GraphicSteps.Add(New GraphicStep(gs, "Full frame Stats", "FF", True, True))
        gs.GraphicSteps.Add(New GraphicStep(gs, "League comparison", "LC", True, True))
      Else
        Select Case graphicStep.Depth
          Case 0
            Select Case graphicStep.Name
              Case "League table (start with top)"
                gs.GraphicSteps.Add(New GraphicStep(gs, "With up/down arrows", "ArrowsOn", True, True) With {.Depth = 1})
                gs.GraphicSteps.Add(New GraphicStep(gs, "NO arrows", "ArrowsOff", True, True) With {.Depth = 1})
              Case "League table (start with bottom)"
                gs.GraphicSteps.Add(New GraphicStep(gs, "With up/down arrows", "ArrowsOn", True, True) With {.Depth = 1})
                gs.GraphicSteps.Add(New GraphicStep(gs, "NO arrows", "ArrowsOff", True, True) With {.Depth = 1})
              Case "Other match scores"
                'fet matchdays
                gs.GraphicSteps.Add(New GraphicStep(gs, "Last", "Last", True, True) With {.Depth = 1})
              Case "Full frame Stats"
                'populate with fullframe stats
              Case "League comparison"
                'populate with league comparisson
            End Select
          Case 1
            'graphic is ready

        End Select
      End If
    Catch ex As Exception
      WriteToErrorLog(ex)
    End Try
    Return gs
  End Function

  Public Overrides Function PrepareScene(graphicStep As GraphicStep) As Scene
    Try

    Catch ex As Exception
      WriteToErrorLog(ex)
    End Try
  End Function
End Class
