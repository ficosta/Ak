Public Enum SceneLayer
  Back = 0
  Middle = 1
  Front = 2
End Enum

<Serializable()> Public Class Scene
  Implements ICloneable

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

  Public Function Clone() As Object Implements ICloneable.Clone
    Throw New NotImplementedException()
  End Function


  Public Function SendSceneToEngine(ByVal CiControlVizrt As VizControl, Optional ByVal niIdioma As Integer = 0, Optional ByVal biUcaseTexts As Boolean = False, Optional ByVal biActivate As Boolean = True) As Integer
    Dim nCount As Integer = 0
    Dim sValor As String
    Dim nIdioma As Integer = niIdioma
    Dim bUcase As Boolean = biUcaseTexts

    Try
      ' CiControlVizrt.LoadScene(Me.Escena)
      If nIdioma = 0 Then
        nIdioma = CiControlVizrt.Config.Idioma
      End If
      If nIdioma = 0 Then
        nIdioma = 1
      End If
      bUcase = CiControlVizrt.Config.UcaseTexts
      If biActivate Then
        CiControlVizrt.ActivateScene("", Me.VizLayer)
        CiControlVizrt.ActivateScene(CiControlVizrt.Config.SceneBasePath & Me.SceneName, Me.VizLayer)
        Select Case Me.BackgroundImageState
          Case eBackgroundImageState.Active
            CiControlVizrt.SetSceneBackgroundImageActive(True, Me.VizLayer)
          Case eBackgroundImageState.Inactive
            CiControlVizrt.SetSceneBackgroundImageActive(False, Me.VizLayer)
          Case Else
            'do nothing
        End Select
      End If
      For Each CParam As SceneParameter In Me.SceneParameters

        sValor = CParam.Value

        Select Case CParam.Type
          Case paramType.Text
            If bUcase Then sValor = UCase(sValor)
            CiControlVizrt.SetControlObjectValue("$object", CParam.Name, sValor, Me.VizLayer)
          Case paramType.Image
            CiControlVizrt.SetControlObjectImageValue("$object", CParam.Name, sValor, Me.VizLayer)
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
End Class
