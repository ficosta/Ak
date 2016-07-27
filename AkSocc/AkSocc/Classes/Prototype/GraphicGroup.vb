Imports System.Reflection
Imports MatchInfo

Public MustInherit Class GraphicGroup
  Private WithEvents _match As MatchInfo.Match
  Public Property Match As MatchInfo.Match
    Get
      Return _match
    End Get
    Set(value As MatchInfo.Match)
      _match = value
    End Set
  End Property

  Private WithEvents _player As MatchInfo.Player
  Public Property Player As MatchInfo.Player
    Get
      Return _player
    End Get
    Set(value As MatchInfo.Player)
      _player = value
    End Set
  End Property

  Private WithEvents _team As MatchInfo.Team
  Public Property Team As MatchInfo.Team
    Get
      Return _team
    End Get
    Set(value As MatchInfo.Team)
      _team = value
    End Set
  End Property

  Public Property OtherMatchDays As OtherMatchDays


  Public Property Name As String = ""
  Public Property ID As Integer
  Public Shared Property Definition As String = ""

  Public Property GraphicStepTree As New GraphicSteps

  Public Property graphicStep As GraphicStep
  Public Property formerGraphicStep As GraphicStep

  Public Property KeyCombination As KeyCombination = Nothing

  Public Property Scene As New VizCommands.Scene

  Public Property AutomaticGraphic As Boolean = True

  Public Property MustHavePlayer As Boolean = False
  Public Property MustHaveTeam As Boolean = False

  Public Property MustHaveClock As Boolean = False
  Public Property CantHaveClock As Boolean = False

  Public Sub New(match As Match)
    _match = match
  End Sub

  Public Sub New(match As Match, player As Player, team As Team)
    _match = match
    _player = player
    _team = team
  End Sub


  Public MustOverride Function PrepareNextGraphicStep(Optional graphicStep As GraphicStep = Nothing) As GraphicStep

  Public MustOverride Function PrepareScene(graphicStep As GraphicStep) As VizCommands.Scene

  Public Overridable Function PostProcessingAction(frm As MetroFramework.Forms.MetroForm) As Boolean
    Try

    Catch ex As Exception

    End Try
    Return False
  End Function

  Public Overridable Function PreProcessingAction() As Boolean
    Try

    Catch ex As Exception

    End Try
    Return True
  End Function

  Public Overridable Function Send(viz As VizCommands.VizControl_new) As Boolean
    Try

    Catch ex As Exception

    End Try
    Return True
  End Function

  Public Overridable Function GetPreview(viz As VizCommands.VizControl_new, pic As PictureBox) As Boolean
    Try

    Catch ex As Exception

    End Try
    Return True
  End Function

  Public Overrides Function ToString() As String
    Return Me.Name
    Return MyBase.ToString()
  End Function

  Public Function FindDerivedTypes(assembly As Assembly, baseType As Type) As IEnumerable(Of Type)
    Return assembly.GetTypes().Where(Function(t) t <> baseType AndAlso baseType.IsAssignableFrom(t))
  End Function

  Public Shared Function GetAllSubclassesOf(baseType As Type) As List(Of Type)
    Return Assembly.GetAssembly(baseType).GetTypes().Where(Function(type) type.IsSubclassOf(baseType)).ToList()
  End Function

  Public Shared Function GetMyAllSubclassesOf() As List(Of Type)
    Return Assembly.GetAssembly(GetType(GraphicGroup)).GetTypes().Where(Function(type) type.IsSubclassOf(GetType(GraphicGroup))).ToList()
  End Function
End Class
