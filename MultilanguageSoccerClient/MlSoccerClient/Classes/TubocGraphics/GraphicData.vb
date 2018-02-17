Namespace Tuboc
  Public Class GraphicSubject
    Public Property TeamID As Integer = 0
    Public Property PlayerID As Integer = 0
  End Class
  Public Class GraphicData
    Public Property Subjects As New List(Of MatchInfo.StatSubject)
    Public Property StatNames As New List(Of String)
  End Class
End Namespace