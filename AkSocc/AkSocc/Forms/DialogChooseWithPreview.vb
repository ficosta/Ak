Imports System.Windows.Forms
Imports VizCommands

Public Class DialogChooseWithPreview
  Public Property GraphicGroup As GraphicGroup

  Private WithEvents _vizControl As VizCommands.VizControl

  Public WithEvents _previewControl As VizCommands.PreviewControl

  Private WithEvents _dlgPreview As New DialogPreview

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
  Public Sub New(vizControl As VizCommands.VizControl, graphic As GraphicGroup)

    ' This call is required by the designer.
    InitializeComponent()

    ' Add any initialization after the InitializeComponent() call.
    _vizControl = vizControl
    Me.GraphicGroup = graphic
    ShowNextGraphicSteps(Nothing)
  End Sub
#End Region

#Region "Graphic steps"
  Private Sub ShowNextGraphicSteps(graphicStep As GraphicStep)
    Try
      Me.GraphicGroup.graphicStep = Me.GraphicGroup.PrepareNextGraphicStep(graphicStep)

      With Me.ListViewOptions
        .Items.Clear()

        For Each gStep As GraphicStep In Me.GraphicGroup.graphicStep.GraphicSteps
          Dim lvItem As New ListViewItem()
          lvItem.Name = gStep.UID
          If gStep.IsSeparator Then
            lvItem.Text = "-----------------"
          ElseIf gStep.IsTitleOnly Then
            lvItem.Text = gStep.Name & "---"
          Else
            lvItem.Text = gStep.Name
          End If
          .Items.Add(lvItem)
        Next

      End With

    Catch ex As Exception
      WriteToErrorLog(ex)
    End Try
  End Sub


  Private Function SelectStep() As GraphicStep
    Dim gStep As GraphicStep = Nothing
    Try
      If Me.ListViewOptions.SelectedItems.Count > 0 Then
        gStep = Me.GraphicGroup.graphicStep.GraphicSteps.GetGraphicStep(Me.ListViewOptions.SelectedItems(0).Name)
        If Not Me.GraphicGroup.graphicStep Is Nothing Then Me.GraphicGroup.graphicStep.ChildGraphicStep = gStep
        If Not gStep Is Nothing Then
          If gStep.IsFinalStep Then 'no s'ha d'anar més enllà
            If Me.GraphicGroup.AutomaticGraphic Then
              'preparar l'escena

              Me.GraphicGroup.PrepareScene(gStep)
              'demanar previ
              _dlgPreview = New DialogPreview(_vizControl, Me.GraphicGroup.Scene)
              If _dlgPreview.ShowDialog(Me) = DialogResult.OK Then
                'enviar e engine
                Me.GraphicGroup.Scene.SendSceneToEngine(_vizControl)
                _vizControl.DirectorStart(Me.GraphicGroup.Scene.SceneDirector)
              End If
            Else
              'no hem de fer res més, sortim!
            End If

          Else 'hi ha més passos
            ShowNextGraphicSteps(gStep)
          End If
          If gStep.IsTransitionalStep = False Then
            'és un pas per enviar dades
            'preparar escena
            'enviar a render
            'comencem a seleccionar de zero

            Me.Text = gStep.ToString
            Me.GetPreview(Me.GraphicGroup.Scene, Me.PictureBoxPreview)
            Me.GraphicGroup.formerGraphicStep = Me.GraphicGroup.graphicStep

            Me.GraphicGroup.graphicStep = Nothing
            ShowNextGraphicSteps(Nothing)
          End If
        End If
      End If
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
      Dim pic As PictureBox = Me.PictureBoxPreview

      For Each request As PreviewRequest In _llistaPreviewRequests
        If request.ID = asset.ID Then
          pic = request.Picturebox
          Exit For
        End If
      Next

      Select Case asset.AssetSate
        Case ePreviewAssetState.Done
          pic.Image = asset.AssetImage
      End Select
    Catch ex As Exception

    End Try
  End Sub

  Private Sub ListViewOptions_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListViewOptions.SelectedIndexChanged

  End Sub
#End Region
End Class
