Imports MetroFramework
Imports MetroFramework.Forms
Imports VizCommands

Public Class FormChoose
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

  Public WithEvents _vizControl As VizCommands.VizControl

  Public WithEvents _previewControl As VizCommands.PreviewControl

  Private WithEvents _dlgPreview As New DialogPreview

  Private _currentScene As Scene = Nothing
  Private _formerScene As Scene = Nothing

  Private _firstControl As Boolean = True

  Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
    Dim gstep As GraphicStep = Me.GraphicGroup.graphicStep


    If Not gstep Is Nothing Then
      Dim lbl As New MetroFramework.Controls.MetroLabel
      lbl.Text = "Wating for animation..."
      lbl.FontSize = MetroFramework.MetroLabelSize.Tall
      lbl.FontWeight = MetroFramework.MetroLabelWeight.Bold
      lbl.TextAlign = ContentAlignment.MiddleCenter
      lbl.Dock = DockStyle.Fill

      _formerScene = _currentScene
      _currentScene = Me.GraphicGroup.PrepareScene(Me.GraphicGroup.graphicStep)

      If Not _currentScene Is Nothing Then
        If _formerScene Is Nothing Then
          'this is the first time we send a scene

          'send scene to render and start animation
          _currentScene.SendSceneToEngine(_vizControl)
          _currentScene.StartSceneDirectors(_vizControl, Scene.TypeOfDirectors.InDirectors)

          'wait for animation to end
          Dim frm As New frmWait(1000 * _currentScene.SceneDirectorsChangeIn.MaxFrame / 40)
          frm.ShowDialog()

        Else
          'we are changing!

          'take the graphic out, if there's a change out animation sequence
          If _currentScene.SceneDirectorsChangeOut.Count > 0 Then
            _currentScene.StartSceneDirectors(_vizControl, Scene.TypeOfDirectors.ChangeOutDirectors)
            Application.DoEvents()

            Dim frm As New frmWait(1000 * _currentScene.SceneDirectorsChangeOut.MaxFrame / 40)
            frm.ShowDialog()
          End If

          'Send parameter on side 1 to side 2
          For Each param As SceneParameter In _formerScene.SceneParameters
            param.Name = param.Name.Replace("Side_2", "Side_1")
          Next
          For Each param As SceneParameter In _currentScene.SceneParameters
            param.Name = param.Name.Replace("Side_1", "Side_2")
          Next
          _formerScene.SendSceneToEngine(_vizControl)
          Application.DoEvents()

          'rewind change animation to initial step
          _formerScene.RewindSceneDirectors(_vizControl, Scene.TypeOfDirectors.ChangeInDirectors)
          Application.DoEvents()

          'send new parameters
          _currentScene.SendSceneToEngine(_vizControl)
          Application.DoEvents()

          If _currentScene.SceneDirectorsChangeIn.Count > 0 Then
            'send scene to render and start animation
            _currentScene.SendSceneToEngine(_vizControl)
            _currentScene.StartSceneDirectors(_vizControl, Scene.TypeOfDirectors.ChangeInDirectors)
            Application.DoEvents()
            'wait for animation to end
            'tsk.ShowDialog(Me)
          End If

        End If

        If gstep.IsTransitionalStep = False Then
          'there's nothing else: we wait for the "out" confirmation and close the dialog
          MetroMessageBox.Show(Me, "Waiting for your input to take out the graphic.", gstep.Name, MessageBoxButtons.OK, MessageBoxIcon.Hand)

          _currentScene.StartSceneDirectors(_vizControl, Scene.TypeOfDirectors.OutDirectors)
          Me.DialogResult = System.Windows.Forms.DialogResult.OK
          Me.Close()
        Else
          'MetroMessageBox.Show(Me, "Waiting for your input to take out the graphic.", gstep.Name, MessageBoxButtons.OK, MessageBoxIcon.Hand)
          ' _currentScene.StartSceneDirectors(_vizControl, Scene.TypeOfDirectors.OutDirectors)
        End If
      Else
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
      End If
    Else
      Me.DialogResult = System.Windows.Forms.DialogResult.OK
      Me.Close()
    End If
  End Sub

  Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
    Try
      If Not _currentScene Is Nothing Then
        _currentScene.StartSceneDirectors(_vizControl, Scene.TypeOfDirectors.OutDirectors)
      End If
    Catch ex As Exception
      WriteToErrorLog(ex)
    End Try
    Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
    Me.Close()
  End Sub

  Private Sub DialogChooseWithPreview_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    Try

    Catch ex As Exception

    End Try
  End Sub

#Region "Constructor"
  Public Sub New(ByRef vizControl As VizCommands.VizControl, ByRef previewControl As VizCommands.PreviewControl, ByRef graphicGroup As GraphicGroup)

    ' This call is required by the designer.
    InitializeComponent()

    ' Add any initialization after the InitializeComponent() call.
    _vizControl = vizControl
    _previewControl = previewControl
    _ucPreview.PreviewControl = previewControl
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

      If Not gs Is Nothing Then
        Me.Text = gs.ToString
      End If
      Me.GraphicGroup.graphicStep = gs

      Dim bNextStep As Boolean = False
      If gs Is Nothing Then
        bNextStep = True
      ElseIf gs.IsFinalStep = False Then
        bNextStep = True
      Else
        bNextStep = False
      End If


      If Me.TableLayoutPanelAll.Controls.Count > 0 Then
        For i As Integer = Me.TableLayoutPanelAll.Controls.Count - 1 To lastIndex Step -1
          Dim uc As UserControlChoose = TryCast(Me.TableLayoutPanelAll.Controls(i), UserControlChoose)
          Me.TableLayoutPanelAll.ColumnCount = i
          If Me.TableLayoutPanelAll.ColumnStyles.Count > i Then Me.TableLayoutPanelAll.ColumnStyles.RemoveAt(i)
          If Not uc Is Nothing Then
            RemoveHandler uc.GraphicStepSelected, AddressOf Me.GraphicStepSelected
          End If
          Me.TableLayoutPanelAll.Controls.RemoveAt(i)
        Next

        If Me.TableLayoutPanelAll.Controls.Count > 0 Then
          lastLeft = Me.TableLayoutPanelAll.Controls(Me.TableLayoutPanelAll.Controls.Count - 1).Width + Me.TableLayoutPanelAll.Controls(Me.TableLayoutPanelAll.Controls.Count - 1).Left '+ Me.TableLayoutPanelAll.HorizontalScroll.Value
        End If
      End If

      If bNextStep Then

        If _firstControl = False Then
          Me.TableLayoutPanelAll.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50))
          Me.TableLayoutPanelAll.ColumnCount += 1
        End If

        Dim uc As UserControlChoose
        uc = New UserControlChoose
        uc.Width = (Me.TableLayoutPanelAll.Width) / 4
        uc.Top = 10
        uc.Height = Me.TableLayoutPanelAll.Height - 2 * uc.Top - 10
        uc.Left = 0 ' lastLeft
        uc.Index = Me.TableLayoutPanelAll.Controls.Count

        Me.TableLayoutPanelAll.Controls.Add(uc, Me.TableLayoutPanelAll.ColumnCount - 1, 0)

        uc.Dock = DockStyle.Fill

        uc.GraphicStep = Me.GraphicGroup.PrepareNextGraphicStep(gs)

        AddHandler uc.GraphicStepSelected, AddressOf Me.GraphicStepSelected

        Me.TableLayoutPanelAll.HorizontalScroll.Value = Math.Min(uc.Left, Me.TableLayoutPanelAll.HorizontalScroll.Maximum)

        Me.OK_Button.Enabled = False
      Else
        Dim scene As Scene = _graphicGroup.PrepareScene(gs)

        If Not scene Is Nothing Then

          'If _firstControl = False Then
          '  Me.TableLayoutPanelAll.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50))
          '  Me.TableLayoutPanelAll.ColumnCount += 1
          'End If
          If _ucPreview.VizControl Is Nothing Then _ucPreview.PreviewControl = _previewControl
          _ucPreview.GetPreview(_graphicGroup.PrepareScene(gs))
            _ucPreview.ShowAdvancedControls = True
            _ucPreview.Title = gs.ToString
          End If

          Me.OK_Button.Enabled = True
        'preview

      End If


      'ShowNextGraphicSteps()
    Catch ex As Exception

    End Try
    _firstControl = False
  End Sub

  Private Function SelectStep() As GraphicStep
    Dim gStep As GraphicStep = Nothing
    Try
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

  Private Sub _previewControl_ActiveAssetChanged(ByVal asset As VizCommands.PreviewAsset, ByVal former_asset As VizCommands.PreviewAsset)
    Try
    Catch ex As Exception
    End Try
  End Sub

  Private Sub _previewControl_AssetAdded(ByVal asset As VizCommands.PreviewAsset)
    Try
    Catch ex As Exception
    End Try
  End Sub

  Private Sub _previewControl_AssetStateChanged(ByVal asset As VizCommands.PreviewAsset)
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

#End Region
End Class