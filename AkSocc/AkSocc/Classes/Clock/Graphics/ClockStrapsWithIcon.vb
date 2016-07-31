Imports MatchInfo
Imports VizCommands

Public Class ClockStrapsWithIcon
  Inherits GraphicGroup

  Public Sub New(match As MatchInfo.Match)
    MyBase.New(match)
  End Sub

  Public Overloads Shared ReadOnly Property Description As String
    Get
      Return Reflection.MethodBase.GetCurrentMethod().DeclaringType.Name
    End Get
  End Property

  Public Property _clockTexts As ClockDropdownTexts


  Class Step0
    Inherits GraphicStep.GraphicStepDefinition

    Public Shared ReadOnly Dummy As Step0 = New Step0("Dummy")

    Public Sub New(key As String)
      MyBase.Key = key
    End Sub

    Public Sub New(key As String, name As String)
      MyBase.Key = key
      MyBase.Name = name
    End Sub
  End Class

  Public Overrides Function PrepareNextGraphicStep(Optional graphicStep As GraphicStep = Nothing) As GraphicStep
    Dim gsList As New GraphicSteps
    Dim gs As New GraphicStep(graphicStep, Me.Name)
    If Not graphicStep Is Nothing Then
      gs = graphicStep
    End If

    Try
      gs.GraphicSteps.Clear()

      _clockTexts = New ClockDropdownTexts
      _clockTexts.GetFromDB("WHERE Priority > 0")

      If graphicStep Is Nothing Then
        For Each name As ClockDropdownText In _clockTexts
          gs.GraphicSteps.Add(New GraphicStep(gs, New Step0(name.ID, name.EnglishDescription), True, False))
        Next
      End If
    Catch ex As Exception
      WriteToErrorLog(ex)
    End Try
    Return gs
  End Function

  Public Overrides Function PrepareScene(graphicStep As GraphicStep) As Scene
    Me.Scene = ClockControl.GetClockBaseScene()
    Try
      Dim clockText As ClockDropdownText = _clockTexts.GetName(CInt(graphicStep.UID))
      Scene = PrepareClockText(1, clockText)

    Catch ex As Exception
      WriteToErrorLog(ex)
    End Try
    Return Me.Scene
  End Function


#Region "Crawl scenes"
  Private Function InitDefaultScene(Optional gSide As Integer = 1) As Scene
    Dim scene As Scene = ClockControl.GetClockBaseScene

    With scene
      .SceneDirectorsIn.Add("anim_Clock_Straps_with_Icon", 0, DirectorAction.Start)
      .SceneDirectorsIn.Add("anim_Clock_Straps_with_Icon", 10, DirectorAction.Dummy)
      .SceneDirectorsOut.Add("anim_Clock_Straps_with_Icon", 0, DirectorAction.ContinueNormal)
      .SceneDirectorsOut.Add("anim_Clock_Straps_with_Icon", 0, DirectorAction.ContinueNormal)
    End With
    Return scene
  End Function


  Public Function PrepareClockText(gSide As Integer, bugDotText As ClockDropdownText) As Scene
    Dim scene As Scene = InitDefaultScene(gSide)
    Try
      If Not bugDotText Is Nothing Then
        Select Case bugDotText.DropDownLogo
          Case "MICROPHONE"
            scene.SceneParameters.Add("Clock_Straps_with_Icon_Control_OMO_Logo_01", "1")
          Case "WHISTLE"
            scene.SceneParameters.Add("Clock_Straps_with_Icon_Control_OMO_Logo_01", "2")
          Case Else
            scene.SceneParameters.Add("Clock_Straps_with_Icon_Control_OMO_Logo_01", "0")
        End Select
        scene.SceneParameters.Add("Clock_Generic_Straps_Data_02_Text", VizEncoding(bugDotText.ArabicTopLineText))
        scene.SceneParameters.Add("Clock_Generic_Straps_Data_01_Text", VizEncoding(bugDotText.ArabicSubLineText))
        scene.SceneParameters.Add("Clock_Generic_Straps_Data_02_Control_OMO_Black_White", "0")
      End If

    Catch ex As Exception
      WriteToErrorLog(ex)
    End Try
    Return scene
  End Function

#End Region
End Class
