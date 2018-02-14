Public Class FormClockControl
  Private _updating As Boolean = False
#Region "Properties"

  Private WithEvents _clockControl As ClockControl
  Public Property ClockControl As ClockControl
    Get
      Return _clockControl
    End Get
    Set(value As ClockControl)
      _clockControl = value
      If _updating = False Then
        Me.ClockVisible = _clockControl.ClockVisible
        Me.ShowRedCards = _clockControl.ShowRedCards
        Me.ShowSponsor = _clockControl.ShowSponsor
        Me.ComboBoxSponsor.SelectedIndex = _clockControl.SponsorSelectedLogo
      End If
    End Set
  End Property

  Private _ClockVisible As Boolean = False
  Private Property ClockVisible As Boolean
    Get
      Return _ClockVisible
    End Get
    Set(value As Boolean)
      _ClockVisible = value
      If _ClockVisible Then
        Me.ButtonClockVisible.BackColor = Color.LightGreen
        Me.ButtonClockVisible.Text = "Hide clock"
      Else
        Me.ButtonClockVisible.BackColor = Color.LightSalmon
        Me.ButtonClockVisible.Text = "Show clock"
      End If
      If _updating = False Then
        If Not _clockControl Is Nothing Then
          _clockControl.ClockVisible = _ClockVisible
        End If
      End If
    End Set
  End Property


  Private _showRedCards As Boolean = False
  Private Property ShowRedCards As Boolean
    Get
      Return _showRedCards
    End Get
    Set(value As Boolean)
      _showRedCards = value

      If _showRedCards Then
        Me.ButtonShowRedCards.BackColor = Color.LightGreen
        Me.ButtonShowRedCards.Text = "Hide red cards"
      Else
        Me.ButtonShowRedCards.BackColor = Color.LightSalmon
        Me.ButtonShowRedCards.Text = "Show red cards"
      End If
      If _updating = False Then
        If Not _clockControl Is Nothing Then
          _clockControl.ShowRedCards = _showRedCards
        End If
      End If
    End Set
  End Property


  Private _showSponsor As Boolean = False
  Private Property ShowSponsor As Boolean
    Get
      Return _showSponsor
    End Get
    Set(value As Boolean)
      _showSponsor = value

      If _showSponsor Then
        Me.ButtonShowSponsor.BackColor = Color.LightGreen
        Me.ButtonShowSponsor.Text = "Hide sponsor"
      Else
        Me.ButtonShowSponsor.BackColor = Color.LightSalmon
        Me.ButtonShowSponsor.Text = "Show sponsor"
      End If
      If _updating = False Then
        If Not _clockControl Is Nothing Then
          _clockControl.SponsorSelectedLogo = Me.ComboBoxSponsor.SelectedIndex
          _clockControl.ShowSponsor = _showSponsor
        End If
      End If
    End Set
  End Property

  Private _interfaceShowPositionControls As Boolean = False
  Public Property InterfaceShowPositionControls As Boolean
    Get
      Return _interfaceShowPositionControls
    End Get
    Set(value As Boolean)
      _interfaceShowPositionControls = value
      UpdateControlSize()
    End Set
  End Property

#End Region

  Private _step As Double = 1

#Region "Clock events"

  Private Sub _clockControl_ClockStateChanged() Handles _clockControl.ClockStateChanged
    Try
      _updating = True
      Me.ClockVisible = _clockControl.ClockVisible
      Me.ShowSponsor = _clockControl.ShowSponsor
      Me.ShowRedCards = _clockControl.ShowRedCards
      _updating = False
    Catch ex As Exception

    End Try
  End Sub

  Private Sub _clockControl_Updated() Handles _clockControl.Updated

  End Sub
#End Region

#Region "Buttons"

  Private Sub ButtonClockVisible_Click(sender As Object, e As EventArgs) Handles ButtonClockVisible.Click
    Me.ClockVisible = Not Me.ClockVisible
  End Sub

  Private Sub ButtonShowRedCards_Click(sender As Object, e As EventArgs) Handles ButtonShowRedCards.Click
    Me.ShowRedCards = Not Me.ShowRedCards
  End Sub

  Private Sub ButtonClockPosition_Click(sender As Object, e As EventArgs) Handles ButtonClockPosition.Click
    Me.InterfaceShowPositionControls = Not Me.InterfaceShowPositionControls
  End Sub

  Private Sub ButtonShowSponsor_Click(sender As Object, e As EventArgs) Handles ButtonShowSponsor.Click
    Me.ShowSponsor = Not Me.ShowSponsor
  End Sub


  Private Sub ButtonLeft_Click(sender As Object, e As EventArgs) Handles ButtonLeft.Click
    _clockControl.UpdatePosition(AppSettings.Instance.ClockPosition_X - _step, AppSettings.Instance.ClockPosition_Y)
  End Sub

  Private Sub ButtonUp_Click(sender As Object, e As EventArgs) Handles ButtonUp.Click
    _clockControl.UpdatePosition(AppSettings.Instance.ClockPosition_X, AppSettings.Instance.ClockPosition_Y + _step)
  End Sub

  Private Sub ButtonRight_Click(sender As Object, e As EventArgs) Handles ButtonRight.Click
    _clockControl.UpdatePosition(AppSettings.Instance.ClockPosition_X + _step, AppSettings.Instance.ClockPosition_Y)

  End Sub

  Private Sub ButtonBottom_Click(sender As Object, e As EventArgs) Handles ButtonBottom.Click
    _clockControl.UpdatePosition(AppSettings.Instance.ClockPosition_X, AppSettings.Instance.ClockPosition_Y - _step)

  End Sub

#End Region

#Region "Size controls"
  Private Sub LabelScorePosition_Click(sender As Object, e As EventArgs)

  End Sub

  Private Sub UpdateControlSize()
    Dim pnt As Point
    pnt = Me.ButtonClockPosition.PointToScreen(New Point(0, 0))
    pnt = Me.PointToClient(pnt)
    Dim myHeight As Double = pnt.Y + Me.ButtonClockPosition.Height + 5

    If _interfaceShowPositionControls Then
      Me.Height = myHeight + 140
    Else
      Me.Height = myHeight
    End If

  End Sub
#End Region

#Region "Form drag"

  Dim drag As Boolean
  Dim mousex As Integer
  Dim mousey As Integer

  Public Sub New()

    ' This call is required by the designer.
    InitializeComponent()

    ' Add any initialization after the InitializeComponent() call.
    With Me.ComboBoxSponsor
      .Items.Clear()
      For i As Integer = 1 To 10
        .Items.Add("Logo " & i)
      Next
    End With
  End Sub

  Private Sub Form1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles LabelTitle.MouseDown
    If e.Button = System.Windows.Forms.MouseButtons.Left Then
      drag = True
      mousex = System.Windows.Forms.Cursor.Position.X - Me.Left
      mousey = System.Windows.Forms.Cursor.Position.Y - Me.Top
    End If
  End Sub


  Private Sub Form1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles LabelTitle.MouseMove
    If drag Then
      Me.Top = System.Windows.Forms.Cursor.Position.Y - mousey
      Me.Left = System.Windows.Forms.Cursor.Position.X - mousex
    End If
  End Sub

  Private Sub LabelPrompt_MouseUp(sender As Object, e As MouseEventArgs) Handles LabelTitle.MouseUp
    If e.Button = System.Windows.Forms.MouseButtons.Left Then
      drag = False
    End If
  End Sub

  Public Overrides Property Text As String
    Get
      Return MyBase.Text
    End Get
    Set(value As String)
      Me.LabelTitle.Text = value
      MyBase.Text = value
    End Set
  End Property

  Private Sub ComboBoxSponsor_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxSponsor.SelectedIndexChanged
    If Not _clockControl Is Nothing Then
      _clockControl.SponsorSelectedLogo = Me.ComboBoxSponsor.SelectedIndex
    End If
  End Sub

  Private Sub LabelClose_Click(sender As Object, e As EventArgs) Handles LabelClose.Click
    Me.Close()
  End Sub



#End Region
End Class