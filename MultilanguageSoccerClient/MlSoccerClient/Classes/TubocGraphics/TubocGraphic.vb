Namespace Tuboc
  Public MustInherit Class Graphic
    Public Property Name As String
    Public Property Scene As New VizCommands.Scene

    Public Sub New()

    End Sub

    Public MustOverride Sub PrepareGraphic(match As MatchInfo.Match, graphicData As Tuboc.GraphicData)

    Public MustOverride Function ICanDothis(graphicData As Tuboc.GraphicData) As Boolean
  End Class
End Namespace