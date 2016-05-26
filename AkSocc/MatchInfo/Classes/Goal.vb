
Public Class Goal
  Public Enum GoalType
    Goal
    Penalty
    Own
  End Enum

  Public Property IDGoal As Integer


  Public Property IDTeam As Integer
  Public Property IDPlayer As Integer

  Public Property Team As Team
  Public Property Player As Player

  Public Property Part As Integer
  Public Property TimeInSeconds As Integer
End Class
