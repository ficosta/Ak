Imports System.ComponentModel
Imports AkSocc
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
        Me.UserControlChoose1.SelectFirst()
      End If
    End Set
  End Property

  Public WithEvents _vizControl As VizCommands.VizControl

  Public WithEvents _previewControl As VizCommands.PreviewControl

  Private _lastControlIndex As Integer = 0
  Private _chooseControls As New List(Of UserControlChoose)

  Private _currentScene As Scene = Nothing
  Private _formerScene As Scene = Nothing

  Private _firstControl As Boolean = True

#Region "Properties"
  Private _showPreview As Boolean = True
  Public Property ShowPreview As Boolean
    Get
      Return _showPreview
    End Get
    Set(value As Boolean)
      _showPreview = value
      Me.SplitContainerAll.Panel2Collapsed = (Not _showPreview)
    End Set
  End Property
#End Region

  Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click

    AcceptGraphic()
  End Sub

Private Sub AcceptGraphic()
    Dim gSide As GraphicStep = Me.GraphicGroup.graphicStep

    ' If MsgBox("Start graphic?", MsgBoxStyle.YesNo, gSide.ToString) = MsgBoxResult.No Then Exit Sub
    If _showPreview Then
      If frmWaitForInput.ShowWaitDialog(Me, "Start graphic?", gSide.ToString, MessageBoxButtons.OKCancel, MessageBoxIcon.Hand) = DialogResult.Cancel Then Exit Sub
    Else
      If frmWaitForInput.ShowWaitDialog(Me, "Accept data?", gSide.ToString, MessageBoxButtons.OKCancel, MessageBoxIcon.Hand) = DialogResult.Cancel Then Exit Sub
    End If

    If Not gSide Is Nothing Then
      Dim lbl As New System.Windows.Forms.Label
      Dim fWait As frmWait
      lbl.Text = "Wating for animation..."
      lbl.TextAlign = ContentAlignment.MiddleCenter
      lbl.Dock = DockStyle.Fill

      _formerScene = _currentScene
      'in case something must be done
      Me.GraphicGroup.PreProcessingAction()
      _currentScene = Me.GraphicGroup.PrepareScene(Me.GraphicGroup.graphicStep)
      If Not _currentScene Is Nothing Then
        If _formerScene Is Nothing Then
          'this is the first time we send a scene

          'send scene to render and start animation
          _currentScene.SendSceneToEngine(_vizControl)
          _currentScene.StartSceneDirectors(_vizControl, Scene.TypeOfDirectors.InDirectors)

          'wait for animation to end
          fWait = New frmWait(1000 * _currentScene.SceneDirectorsIn.MaxFrame / 40)
          fWait.ShowDialog()
        Else
          'we are changing!

          'take the graphic out, if there's a change out animation sequence
          If _currentScene.SceneDirectorsChangeOut.Count > 0 Then
            _currentScene.StartSceneDirectors(_vizControl, Scene.TypeOfDirectors.ChangeOutDirectors)
            Application.DoEvents()

            fWait = New frmWait(1000 * _currentScene.SceneDirectorsChangeOut.MaxFrame / 40)
            fWait.ShowDialog()
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

          fWait = New frmWait(50)
          fWait.ShowDialog()

          'rewind change animation to initial step
          _formerScene.RewindSceneDirectors(_vizControl, Scene.TypeOfDirectors.ChangeInDirectors)
          Application.DoEvents()

          fWait = New frmWait(50)
          fWait.ShowDialog()

          'send new parameters
          _currentScene.SendSceneToEngine(_vizControl)
          Application.DoEvents()

          fWait = New frmWait(150)
          fWait.ShowDialog()
          Application.DoEvents()

          If _currentScene.SceneDirectorsChangeIn.Count > 0 Then
            'send scene to render and start animation
            '_currentScene.SendSceneToEngine(_vizControl)
            _currentScene.StartSceneDirectors(_vizControl, Scene.TypeOfDirectors.ChangeInDirectors)
            Application.DoEvents()
            'wait for animation to end
            'tsk.ShowDialog(Me)
          End If

        End If

        If gSide.IsTransitionalStep = False Then
          'there's nothing else: we wait for the "out" confirmation and close the dialog
          frmWaitForInput.ShowWaitDialog(Me, "Waiting for your input to take out the graphic.", gSide.ToString, MessageBoxButtons.OK, MessageBoxIcon.Hand)

          _currentScene.StartSceneDirectors(_vizControl, Scene.TypeOfDirectors.OutDirectors)

          Me.GraphicGroup.PostProcessingAction(Me)
          Me.DialogResult = System.Windows.Forms.DialogResult.OK
          Me.Close()
        Else
          'frmWaitForInput.ShowWaitDialog(Me, "Waiting for your input to take out the graphic.", gSide.Name, MessageBoxButtons.OK, MessageBoxIcon.Hand)
          ' _currentScene.StartSceneDirectors(_vizControl, Scene.TypeOfDirectors.OutDirectors)
        End If
      Else
        Me.GraphicGroup.PostProcessingAction(Me)
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
      End If
    Else
      Me.GraphicGroup.PostProcessingAction(Me)
      Me.DialogResult = System.Windows.Forms.DialogResult.OK
      Me.Close()
    End If
  End Sub

  Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
    Me.Close()
  End Sub


  Private Sub FormChoose_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
    If Me.DialogResult <> DialogResult.OK Then
      CancelAction()
    End If
  End Sub

  Private Sub CancelAction()
    Try
      If Not _currentScene Is Nothing Then
        _currentScene.StartSceneDirectors(_vizControl, Scene.TypeOfDirectors.OutDirectors)
      End If
    Catch ex As Exception
      WriteToErrorLog(ex)
    End Try
    Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
    'Me.Close()
  End Sub

  Private Sub DialogChooseWithPreview_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    Try

      UpdateTableGrids()

    Catch ex As Exception

    End Try
  End Sub

#Region "Constructor"
  Public Sub New(ByRef vizControl As VizCommands.VizControl, ByRef previewControl As VizCommands.PreviewControl, ByRef graphicGroup As GraphicGroup)

    ' This call is required by the designer.
    InitializeComponent()

    ' Add any initialization after the InitializeComponent() call.
    _chooseControls.Add(Me.UserControlChoose1)
    _chooseControls.Add(Me.UserControlChoose2)
    _chooseControls.Add(Me.UserControlChoose3)
    _chooseControls.Add(Me.UserControlChoose4)

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
      Me.UserControlChoose1.SelectFirst(True)

    Catch ex As Exception
      WriteToErrorLog(ex)
    End Try
  End Sub

  Private _selecting As Boolean = False
  Private Sub GraphicStepSelected(sender As UserControlChoose, gs As GraphicStep) Handles UserControlChoose1.GraphicStepSelected, UserControlChoose2.GraphicStepSelected, UserControlChoose3.GraphicStepSelected, UserControlChoose4.GraphicStepSelected
    If _selecting Then Exit Sub
    _selecting = True
    Try
      _lastControlIndex = 0
      Dim lastLeft As Integer = 0
      Dim isFirstControl As Boolean = _firstControl
      _firstControl = False
      'eliminar els següents

      Me.GraphicGroup.graphicStep = gs


      Dim bNextStep As Boolean = False
      If gs Is Nothing Then
        bNextStep = True
      Else
        gs.ChildGraphicStep = Nothing
        If gs.IsFinalStep = False Then
          bNextStep = True
        Else
          bNextStep = False
        End If
      End If
      If bNextStep Then
        Me.OK_Button.Enabled = False
        If Not sender Is Nothing Then _lastControlIndex = sender.Index + 1


        Dim uc As UserControlChoose = CType(_chooseControls(_lastControlIndex), UserControlChoose)
        uc.GraphicStep = Me.GraphicGroup.PrepareNextGraphicStep(gs)
        If uc.GraphicStep.GraphicSteps.Count = 1 Or isFirstControl Then
          uc.SelectFirst(True)
          If uc.GraphicStep.ChildGraphicStep.IsFinalStep Then
            Me.GraphicGroup.graphicStep = uc.GraphicStep
            gs = uc.GraphicStep.ChildGraphicStep
            Dim scene As Scene = _graphicGroup.PrepareScene(gs)

            If Not scene Is Nothing Then
              If _ucPreview.VizControl Is Nothing Then _ucPreview.VizControl = Me._vizControl
              _ucPreview.GetPreview(scene)
              _ucPreview.ShowAdvancedControls = False
              _ucPreview.Title = gs.ToString
            End If
            Me.OK_Button.Enabled = True

          End If
        Else
          'uc.SelectFirst(True)
        End If

      Else
        If Not sender Is Nothing Then _lastControlIndex = sender.Index

        Dim scene As Scene = _graphicGroup.PrepareScene(gs)

        If Not scene Is Nothing Then
          If _ucPreview.VizControl Is Nothing Then _ucPreview.VizControl = Me._vizControl
          _ucPreview.GetPreview(scene)
          _ucPreview.ShowAdvancedControls = False
          _ucPreview.Title = gs.ToString
        End If
        Me.OK_Button.Enabled = True
        'preview
      End If
      If Not gs Is Nothing Then
        MetroLabelTitle.Text = gs.ToString
      Else
        MetroLabelTitle.Text = ""
      End If
      'ShowNextGraphicSteps()
    Catch ex As Exception

    End Try
    UpdateTableGrids()
    _firstControl = False
    _selecting = False
  End Sub


  Private Sub GraphicStepSelected_old(sender As UserControlChoose, gs As GraphicStep)
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
            RemoveHandler uc.JumpToNext, AddressOf Me.JumpToNextGraphicSetp
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
        AddHandler uc.JumpToNext, AddressOf Me.JumpToNextGraphicSetp

        Me.TableLayoutPanelAll.HorizontalScroll.Value = Math.Min(uc.Left, Me.TableLayoutPanelAll.HorizontalScroll.Maximum)

        Me.OK_Button.Enabled = False
      Else
        Dim scene As Scene = _graphicGroup.PrepareScene(gs)

        If Not scene Is Nothing Then

          'If _firstControl = False Then
          '  Me.TableLayoutPanelAll.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50))
          '  Me.TableLayoutPanelAll.ColumnCount += 1
          'End If
          If _ucPreview.VizControl Is Nothing Then _ucPreview.VizControl = Me._vizControl
          _ucPreview.GetPreview(_graphicGroup.PrepareScene(gs))
          _ucPreview.ShowAdvancedControls = False
          _ucPreview.Title = gs.ToString
        End If

        Me.OK_Button.Enabled = True
        'preview

      End If


      'ShowNextGraphicSteps()
    Catch ex As Exception

    End Try
    UpdateTableGrids()
    _firstControl = False
  End Sub

  Private Sub UpdateTableGrids()
    Try
      Dim controlCount As Integer = _lastControlIndex + 1
      For i As Integer = 0 To controlCount - 1
        Me.TableLayoutPanelAll.ColumnStyles(i).Width = 50
      Next
      For i As Integer = controlCount To Me.TableLayoutPanelAll.ColumnStyles.Count - 1
        Me.TableLayoutPanelAll.ColumnStyles(i).Width = 0
      Next
    Catch ex As Exception
    End Try
  End Sub

  Private Sub JumpToNextGraphicSetp(sender As UserControlChoose) Handles UserControlChoose1.JumpToNext, UserControlChoose2.JumpToNext, UserControlChoose3.JumpToNext, UserControlChoose4.JumpToNext
    Try

      If Not sender.GraphicStep.ChildGraphicStep Is Nothing AndAlso sender.GraphicStep.ChildGraphicStep.IsFinalStep = True Then
        AcceptGraphic()
      ElseIf sender.GraphicStep.ChildGraphicStep Is Nothing Then
        sender.SelectFirst(True)
        'sender.GraphicStep.ChildGraphicStep = sender.GraphicStep.GraphicSteps(0)
        Dim nextIndex As Integer = sender.Index + 1

        If nextIndex < Me.TableLayoutPanelAll.Controls.Count Then
          Dim uc As UserControlChoose = _chooseControls(nextIndex)
          _chooseControls(nextIndex).Select()
          uc.Focus()
          uc.SelectFirst()
        End If
      Else


        Dim nextIndex As Integer = sender.Index + 1

        If nextIndex < Me.TableLayoutPanelAll.Controls.Count Then
          Dim uc As UserControlChoose = _chooseControls(nextIndex)
          _chooseControls(nextIndex).Select()
          uc.Focus()
          uc.SelectFirst()
        End If
      End If

    Catch ex As Exception
    End Try
  End Sub

  Private Sub JumpToPreivousGraphicSetp(sender As UserControlChoose) Handles UserControlChoose1.JumpToPrevious, UserControlChoose2.JumpToPrevious, UserControlChoose3.JumpToPrevious, UserControlChoose4.JumpToPrevious
    Try
      Dim nextIndex As Integer = sender.Index - 1
      If nextIndex >= 0 Then
        Dim uc As UserControlChoose = _chooseControls(nextIndex)
        _chooseControls(nextIndex).Select()
        uc.Focus()
      End If
    Catch ex As Exception
    End Try
  End Sub

  Private Function SelectStep() As GraphicStep
    Dim gSide As GraphicStep = Nothing
    Try
    Catch ex As Exception
      WriteToErrorLog(ex)
    End Try
    Return gSide
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

  Private Sub FormChoose_Shown(sender As Object, e As EventArgs) Handles Me.Shown
    Try
      Me.UserControlChoose1.SelectFirst()
    Catch ex As Exception
      WriteToErrorLog(ex)
    End Try
  End Sub

  Private Sub UserControlChoose3_Load(sender As Object, e As EventArgs) Handles UserControlChoose3.Load

  End Sub

  Private Sub FormChoose_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
    Try
      Select Case e.KeyCode
        Case Keys.Escape
      End Select
    Catch ex As Exception

    End Try
  End Sub

#End Region
End Class