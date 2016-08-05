Imports System.Xml
Imports System.IO
Imports System.Text
Imports MatchInfo

Public Class COptaF1Helper
  Inherits COptaFile

#Region "Variables"
#End Region

#Region "Properties"
  Public Property Matches As New Matches
  Public Property Teams As New Teams
#End Region

#Region "Constructors"
  Public Sub New()

  End Sub

  Public Sub New(ByVal path As String, ByRef matches As MatchInfo.Matches)
    Me.Path = path
    _Matches = matches
  End Sub
#End Region

#Region "Functions"
  Public Overrides Function Update() As Boolean
    Dim res As Boolean = False
    Try
      _xmlDocument.Load(Me.Path)
      Me.LastUpdateTime = System.IO.File.GetLastWriteTime(Me.Path)

      Dim nodeRoot As XmlNode
      nodeRoot = _xmlDocument.DocumentElement
      If nodeRoot.Name <> "SoccerFeed" Then Return False

      Dim timeStamp As String = ""
      Dim attr As XmlAttribute = nodeRoot.Attributes.GetNamedItem("TimeStamp")
      If Not attr Is Nothing Then timeStamp = attr.Value

      For Each node As XmlNode In nodeRoot.ChildNodes
        Select Case node.Name
          Case "SoccerDocument"
            ReadMatches(node)
            ReadTeams(node)
        End Select
      Next

      res = True
    Catch ex As Exception
    End Try
    Return res
  End Function
#End Region

#Region "Read Matches"
  Private Sub ReadMatches(ByRef nodeRoot As XmlNode)
    Try
      For Each nodeMatch As XmlNode In nodeRoot.ChildNodes
        Select Case nodeMatch.Name
          Case "MatchData"
            ReadMatch(nodeMatch)
        End Select
      Next
    Catch ex As Exception
      Debug.Print(ex.ToString)
    End Try
  End Sub

  Private Sub ReadMatch(ByRef nodeMatch As XmlNode)
    Try
      Dim attr As XmlAttribute = nodeMatch.Attributes.GetNamedItem("uID")
      Dim optaID As Integer = Me.FixID(attr.Value)
      Dim match As Match = Me.Matches.GetMatchByOptaID(optaID)

      If match Is Nothing Then
        match = New Match()
        match.OptaID = optaID
        Me.Matches.Add(match)
      End If

      For Each node As XmlNode In nodeMatch
        Select Case node.Name
          Case "MatchInfo"
            attr = node.Attributes.GetNamedItem("Period")
            match.state = attr.Value
          Case "Stat"

          Case "TeamData"
            attr = node.Attributes.GetNamedItem("Side")
            Dim isHome As Boolean = (attr.Value = "Home")
            attr = node.Attributes.GetNamedItem("TeamRef")
            Dim teamID As Integer = Me.FixID(attr.Value)
            attr = node.Attributes.GetNamedItem("Score")
            Dim score As Integer = 0
            If Not attr Is Nothing Then score = attr.Value

            If isHome Then
              match.optaHomeTeamID = teamID
              match.HomeTeam = Me.Teams.GetTeamByOptaID(teamID)
              match.HomeTeam.Goals = score
              match.optaHomeScore = score
            Else
              match.optaAwayTeamID = teamID
              match.AwayTeam = Me.Teams.GetTeamByOptaID(teamID)
              match.AwayTeam.Goals = score
              match.optaAwayScore = score
            End If
        End Select
      Next
    Catch ex As Exception
      Debug.Print(ex.ToString)
    End Try
  End Sub
#End Region

#Region "Get Match info"
  Public Sub GetMatchInfo(nodeMatch As XmlNode, match As Match)
    Try
      Dim attr As XmlAttribute = nodeMatch.Attributes.GetNamedItem("competition_code")
      match.optaCompetitionCode = attr.Value

      attr = nodeMatch.Attributes.GetNamedItem("competition_id")
      match.optaCompetitionId = attr.Value

      attr = nodeMatch.Attributes.GetNamedItem("season_id")
      match.optaSeason = attr.Value
    Catch ex As Exception
      Debug.Print(ex.ToString)
    End Try
  End Sub
#End Region

#Region "Read Teams"
  Private Sub ReadTeams(ByRef nodeRoot As XmlNode)
    Try
      For Each nodeTeam As XmlNode In nodeRoot.ChildNodes
        Select Case nodeTeam.Name
          Case "Team"
            ReadTeam(nodeTeam)
        End Select
      Next
    Catch ex As Exception
      Debug.Print(ex.ToString)
    End Try
  End Sub

  Private Sub ReadTeam(ByRef nodeTeam As XmlNode)
    Try

      Dim attr As XmlAttribute = nodeTeam.Attributes.GetNamedItem("uID")
      Dim optaID As Integer = Me.FixID(attr.Value)
      Dim team As Team = Me.Teams.GetTeamByOptaID(optaID)

      If team Is Nothing Then
        team = New Team()
        team.OptaID = optaID
        Me.Teams.Add(team)
      End If

      For Each node As XmlNode In nodeTeam
        Select Case node.Name
          Case "Name"
            team.OptaName = node.InnerText
            Me.AddOptaLink(New COptaLink(team.OptaID, team.OptaName, "", COptaLink.eTipusLink.Team))
        End Select
      Next
    Catch ex As Exception
      Debug.Print(ex.ToString)
    End Try
  End Sub
#End Region
End Class
