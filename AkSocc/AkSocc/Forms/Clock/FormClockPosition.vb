Public Class FormClockPosition

  Private _clockControl As ClockControl
  Public Property ClockControl As ClockControl
    Get
      Return _clockControl
    End Get
    Set(value As ClockControl)
      _clockControl = value
      Me.ShowRedCards = _clockControl.ShowRedCards
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
        Me.ButtonShowRedCards.BackColor = Color.LightSalmon
        Me.ButtonShowRedCards.Text = "Hide red cards"
      Else
        Me.ButtonShowRedCards.BackColor = Color.LightGreen
        Me.ButtonShowRedCards.Text = "Show red cards"
      End If
      If Not _clockControl Is Nothing Then
        _clockControl.ShowRedCards = _showRedCards
      End If
    End Set
  End Property

  Private _step As Double = 1

  Private Sub FormClockPosition_Load(sender As Object, e As EventArgs) Handles MyBase.Load

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

  Private Sub ButtonShowRedCards_Click(sender As Object, e As EventArgs) Handles ButtonShowRedCards.Click
    Me.ShowRedCards = Not Me.ShowRedCards
  End Sub
End Class