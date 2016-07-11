Imports System.ComponentModel
Imports MatchInfo

<Serializable()> Public Class OtherMatch
  Implements IComparable
  Implements INotifyPropertyChanged

  Public Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged

  Public Enum eOtherMatchLineType
    Blank = 0
    Result
    Title
  End Enum

  Public Enum otherMatchStatus
    Idle
    HalfTime
    FullTime
    LatestResult
  End Enum

  Public Property OtherMatchID As String = Guid.NewGuid().ToString

  Public Property MatchTitle As String
  Public Property MatchDay As Integer
  Public Property MatchDate As Date

  Private _matchIndex As Integer = 0
  Public Property MatchIndex As Integer
    Get
      Return _matchIndex
    End Get
    Set(value As Integer)
      _matchIndex = value
      RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs("MatchIndex"))
    End Set
  End Property

  Private _logoChannel As Integer = 0
  Public Property LogoChannel As Integer
    Get
      Return _logoChannel
    End Get
    Set(value As Integer)
      _logoChannel = value
      RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs("LogoChannel"))
    End Set
  End Property

  Private _matchStatus As otherMatchStatus = otherMatchStatus.Idle
  Public Property MatchStatus As otherMatchStatus
    Get
      Return _matchStatus
    End Get
    Set(value As otherMatchStatus)
      _matchStatus = value
      RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs("MatchStatus"))
    End Set
  End Property

  Private _lineType As eOtherMatchLineType = otherMatchStatus.Idle
  Public Property LineType As eOtherMatchLineType
    Get
      Return _lineType
    End Get
    Set(value As eOtherMatchLineType)
      _lineType = value
      RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs("LineType"))
    End Set
  End Property

  Private _homeScore As String = ""
  Public Property HomeScore As String
    Get
      Return _homeScore
    End Get
    Set(value As String)
      _homeScore = value
      RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs("HomeScore"))
    End Set
  End Property

  Private _awayScore As String = ""
  Public Property AwayScore As String
    Get
      Return _awayScore
    End Get
    Set(value As String)
      _awayScore = value
      RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs("AwayScore"))
    End Set
  End Property

  Private _match As Match
  Public Property Match As Match
    Get
      Return _match
    End Get
    Set(value As Match)
      _match = value
      RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs("Match"))
    End Set
  End Property

  Private _isTable As Boolean = False
  Public Property IsTable As Boolean
    Get
      Return _isTable
    End Get
    Set(value As Boolean)
      _isTable = value
      RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs("IsTable"))
    End Set
  End Property

  Private _isCrawl As Boolean = False
  Public Property IsCrawl As Boolean
    Get
      Return _isCrawl
    End Get
    Set(value As Boolean)
      _isCrawl = value
      RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs("IsCrawl"))
    End Set
  End Property

  Public Sub New()
  End Sub



  Public Overrides Function ToString() As String
    Dim res As String = ""

    Select Case Me.LineType
      Case eOtherMatchLineType.Blank
        res = "Blank line"
      Case eOtherMatchLineType.Title
        res = "Title: " & Me.MatchTitle
      Case eOtherMatchLineType.Result
        If Not _match Is Nothing Then
          res = _match.ToString
        Else
          res = MyBase.ToString
        End If
    End Select

    Return res

  End Function

  Public Function CompareTo(obj As Object) As Integer Implements IComparable.CompareTo
    Dim aux As OtherMatch = CType(obj, OtherMatch)
    If aux.MatchDay > Me.MatchDay Then
      Return 1
    ElseIf aux.MatchDay < Me.MatchDay Then
      Return -1
    ElseIf aux.MatchIndex > Me.MatchIndex Then
      Return 1
    ElseIf aux.MatchIndex < Me.MatchIndex Then
      Return -1
    Else
      Return 0
    End If
  End Function
End Class
