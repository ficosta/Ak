Public Class frmWait
  Private _stopWatch As New Stopwatch
  Private _cancelRequest As Boolean = False

  Private _timeToCount As Double
  Public Property TimeToCount As Double
    Get
      Return _timeToCount
    End Get
    Set(value As Double)
      _timeToCount = value
      _stopWatch.Restart()
      Me.TimerCountDown.Enabled = True
    End Set
  End Property

  Public Sub New(time As Double)

    ' This call is required by the designer.
    InitializeComponent()

    ' Add any initialization after the InitializeComponent() call.
    Me.TimeToCount = time
  End Sub

  Private Sub frmWait_Load(sender As Object, e As EventArgs) Handles MyBase.Load

  End Sub

  Private Sub TimerCountDown_Tick(sender As Object, e As EventArgs) Handles TimerCountDown.Tick
    Try
      If _stopWatch.ElapsedMilliseconds > _timeToCount Then
        Me.DialogResult = DialogResult.OK
        Me.Close()
      ElseIf _cancelRequest Then
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
      End If
    Catch ex As Exception

    End Try
  End Sub
End Class