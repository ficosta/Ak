Imports System.Windows.Forms
Imports VizCommands

Public Class DialogChoose
  Private _graphicGroup As GraphicGroup
  Public Property GraphicGroup As GraphicGroup
    Get
      Return _graphicGroup
    End Get
    Set(value As GraphicGroup)
      _graphicGroup = value
      If Not _graphicGroup Is Nothing Then

        ShowNextGraphicSteps()
      End If
    End Set
  End Property

  Private WithEvents _vizControl As VizCommands.VizControl

  Public WithEvents _previewControl As VizCommands.PreviewControl

  Private WithEvents _dlgPreview As New DialogPreview

  Private WithEvents _ucPreview As UCPreview

  Public Property VizControl As VizCommands.VizControl
    Get
      Return _vizControl
    End Get
    Set(value As VizCommands.VizControl)
      _vizControl = value
      _dlgPreview.VizControl = _vizControl
    End Set
  End Property

  Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
    Dim gstep As GraphicStep = SelectStep()
    If Not gstep Is Nothing AndAlso gstep.IsFinalStep Then
      Me.DialogResult = System.Windows.Forms.DialogResult.OK
      Me.Close()
    End If
  End Sub

  Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
    Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
    Me.Close()
  End Sub

  Private Sub DialogChooseWithPreview_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    Try

    Catch ex As Exception

    End Try
  End Sub

#Region "Constructor"
  Public Sub New(vizControl As VizCommands.VizControl, graphicGroup As GraphicGroup)

    ' This call is required by the designer.
    InitializeComponent()

    ' Add any initialization after the InitializeComponent() call.
    _vizControl = vizControl
    Me.GraphicGroup = graphicGroup
    'ShowNextGraphicSteps()
  End Sub
#End Region

#Region "Graphic steps"
  Private Sub ShowNextGraphicSteps()
    Try
      GraphicStepSelected(Nothing, Me.GraphicGroup.graphicStep)

    Catch ex As Exception
      WriteToErrorLog(ex)
    End Try
  End Sub

  Private Sub GraphicStepSelected(sender As UserControlChoose, gs As GraphicStep)
    Try
      Dim lastIndex As Integer = 0
      Dim lastLeft As Integer = 0
      'eliminar els següents
      If Not sender Is Nothing Then
        lastIndex = sender.Index + 1
      End If

      If Not gs Is Nothing Then Me.Text = gs.ToString


      If Me.PanelAll.Controls.Count > 0 Then
        For i As Integer = Me.PanelAll.Controls.Count - 1 To lastIndex Step -1
          Dim uc As UserControlChoose = TryCast(Me.PanelAll.Controls(i), UserControlChoose)
          If Not uc Is Nothing Then
            RemoveHandler uc.GraphicStepSelected, AddressOf Me.GraphicStepSelected
          End If
          Me.PanelAll.Controls.RemoveAt(i)
        Next

        If Me.PanelAll.Controls.Count > 0 Then
          lastLeft = Me.PanelAll.Controls(Me.PanelAll.Controls.Count - 1).Width + Me.PanelAll.Controls(Me.PanelAll.Controls.Count - 1).Left '+ Me.PanelAll.HorizontalScroll.Value
        End If
      End If

      Dim bNextStep As Boolean = False
      If gs Is Nothing Then
        bNextStep = True
      ElseIf gs.IsFinalStep = False Then
        bNextStep = True
      Else
        bNextStep = False
      End If
      If bNextStep Then
        Dim uc As UserControlChoose
        uc = New UserControlChoose
        uc.Width = (Me.PanelAll.Width) / 3
        uc.Top = 10
        uc.Height = Me.PanelAll.Height - 2 * uc.Top - 10
        uc.Left = lastLeft
        uc.Index = Me.PanelAll.Controls.Count

        uc.GraphicStep = Me.GraphicGroup.PrepareNextGraphicStep(gs)

        AddHandler uc.GraphicStepSelected, AddressOf Me.GraphicStepSelected

        Me.PanelAll.Controls.Add(uc)
        Me.PanelAll.HorizontalScroll.Value = Math.Min(uc.Left, Me.PanelAll.HorizontalScroll.Maximum)

        Me.OK_Button.Enabled = False
      Else
        Dim uc As New UCPreview

        uc.Width = 2 * (Me.PanelAll.Width) / 3
        uc.Top = 10
        uc.Height = Me.PanelAll.Height - 2 * uc.Top - 10
        uc.Left = lastLeft
        uc.VizControl = _vizControl

        uc.GetPreview(_graphicGroup.PrepareScene(gs))
        uc.ShowAdvancedControls = True
        'AddHandler uc.GraphicStepSelected, AddressOf Me.GraphicStepSelected

        Me.PanelAll.Controls.Add(uc)
        Me.PanelAll.HorizontalScroll.Value = uc.Left

        Me.OK_Button.Enabled = True
        'preview

      End If


      'ShowNextGraphicSteps()
    Catch ex As Exception

    End Try
  End Sub

  Private Function SelectStep() As GraphicStep
    Dim gStep As GraphicStep = Nothing
    Try
      'If Me.ListViewOptions.SelectedItems.Count > 0 Then
      '  gStep = Me.Graphic.graphicStep.GraphicSteps.GetGraphicStep(Me.ListViewOptions.SelectedItems(0).Name)
      '  If Not Me.Graphic.graphicStep Is Nothing Then Me.Graphic.graphicStep.ChildGraphicStep = gStep
      '  If Not gStep Is Nothing Then
      '    If gStep.IsFinalStep Then 'no s'ha d'anar més enllà
      '      If Me.Graphic.AutomaticGraphic Then
      '        'preparar l'escena

      '        Me.Graphic.PrepareScene(gStep)
      '        'demanar previ
      '        _dlgPreview = New DialogPreview(_vizControl, Me.Graphic.Scene)
      '        If _dlgPreview.ShowDialog(Me) = DialogResult.OK Then
      '          'enviar e engine
      '          Me.Graphic.Scene.SendSceneToEngine(_vizControl)
      '          _vizControl.DirectorStart(Me.Graphic.Scene.SceneDirector)
      '        End If
      '      Else
      '        'no hem de fer res més, sortim!
      '      End If

      '    Else 'hi ha més passos
      '      ShowNextGraphicSteps(gStep)
      '    End If
      '    If gStep.IsTransitionalStep = False Then
      '      'és un pas per enviar dades
      '      'preparar escena
      '      'enviar a render
      '      'comencem a seleccionar de zero

      '      Me.Text = gStep.ToString
      '      Me.GetPreview(Me.Graphic.Scene, Me.PictureBoxPreview)
      '      Me.Graphic.formerGraphicStep = Me.Graphic.graphicStep

      '      Me.Graphic.graphicStep = Nothing
      '      ShowNextGraphicSteps(Nothing)
      '    End If
      '  End If
      'End If
    Catch ex As Exception
      WriteToErrorLog(ex)
    End Try
    Return gStep
  End Function
#End Region


#Region "Preview controls"
  Private Class PreviewRequest
    Public ID As String
    Public Asset As PreviewAsset
    Public Picturebox As PictureBox

    Public Sub New()
    End Sub

    Public Sub New(ByRef asset As PreviewAsset, ByRef pic As PictureBox)
      Me.Asset = asset
      Me.Picturebox = pic
      If Not Me.Asset Is Nothing Then Me.ID = Me.Asset.ID
    End Sub
  End Class

  Private _llistaPreviewRequests As New List(Of PreviewRequest)

  Private Sub GetPreview(ByVal escena As Scene)
    _previewControl.NewAsset(escena)
  End Sub

  Private Sub GetPreview(ByVal escena As Scene, ByRef pic As PictureBox)
    _llistaPreviewRequests.Add(New PreviewRequest(_previewControl.NewAsset(escena), pic))
  End Sub

  Private Sub _previewControl_ActiveAssetChanged(ByVal asset As VizCommands.PreviewAsset, ByVal former_asset As VizCommands.PreviewAsset) Handles _previewControl.ActiveAssetChanged
    Try
    Catch ex As Exception
    End Try
  End Sub

  Private Sub _previewControl_AssetAdded(ByVal asset As VizCommands.PreviewAsset) Handles _previewControl.AssetAdded
    Try
    Catch ex As Exception
    End Try
  End Sub

  Private Sub _previewControl_AssetStateChanged(ByVal asset As VizCommands.PreviewAsset) Handles _previewControl.AssetStateChanged
    Try
      'Dim pic As PictureBox = Me.PictureBoxPreview

      'For Each request As PreviewRequest In _llistaPreviewRequests
      '  If request.ID = asset.ID Then
      '    pic = request.Picturebox
      '    Exit For
      '  End If
      'Next

      'Select Case asset.AssetSate
      '  Case ePreviewAssetState.Done
      '    pic.Image = asset.AssetImage
      'End Select
    Catch ex As Exception

    End Try
  End Sub

  Private Sub PanelAll_Paint(sender As Object, e As PaintEventArgs) Handles PanelAll.Paint

  End Sub
#End Region
End Class
