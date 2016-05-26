Public Enum DirectorAction
  Start
  ContinueNormal
  ContinueReverse
  Rewind
  Pause
  JumpTo
End Enum
Public Class SceneDirector
  Public Property ID As String = Guid.NewGuid().ToString
  Public Property Name As String = "DIR_MAIN"
  Public Property Frame As Integer = 0
  Public Property Action As DirectorAction = DirectorAction.Start
  Public Property JumpToFrame As Integer = 0

  Public Sub New()
  End Sub

  Public Sub New(name As String, frame As Integer, action As DirectorAction)
    Me.Name = name
    Me.Frame = frame
    Me.Action = action
  End Sub

  Public Sub New(name As String, frame As Integer, action As DirectorAction, jumpto As Integer)
    Me.Name = name
    Me.Frame = frame
    Me.Action = action
    Me.JumpToFrame = jumpto
  End Sub
End Class
