Imports System.Xml
Imports System.IO
Imports System.Text
Imports MatchInfo

Public Class COptaF26Helper
  Inherits COptaFile

#Region "Variables"
  Private WithEvents _fileWatcher As FileSystemWatcher
#End Region

#Region "Properties"
  Public Property Matches As New Matches
  Public Property Teams As New Teams
#End Region

#Region "Constructors"

  Public Sub New(ByVal path As String, ByRef matches As MatchInfo.Matches)
    Me.Path = path
    _Matches = matches
    Me.InitFilewatcher()
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

      If nodeRoot.Name <> "feed" Then Return False
      Dim attr As XmlAttribute = nodeRoot.Attributes.GetNamedItem("TimeStamp")

      For Each node As XmlNode In nodeRoot.ChildNodes
        Select Case node.Name
          Case "content.item"
            For Each contentNode As XmlNode In node.ChildNodes
              If contentNode.Name = "content.body" Then
                For Each nodeResults As XmlNode In contentNode.ChildNodes
                  If nodeResults.Name = "results" Then
                    attr = nodeResults.Attributes.GetNamedItem("latest")
                    If attr.Value = "TRUE" Then
                      ReadMatches(nodeResults)
                    End If
                  End If
                Next
              End If
            Next

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
          Case "result"
            ReadMatch(nodeMatch)
        End Select
      Next
    Catch ex As Exception
      Debug.Print(ex.ToString)
    End Try
  End Sub

  Private Sub ReadMatch(ByRef nodeMatch As XmlNode)
    Try
      Dim attr As XmlAttribute = nodeMatch.Attributes.GetNamedItem("game-id")
      Dim optaID As Integer = Me.FixID(attr.Value)

      If Me.Matches Is Nothing Then
        Me.Matches = New Matches
        ' Me.Matches.GetFromDB("")
      End If

      If Me.Teams Is Nothing Then
        Me.Teams = New Teams
      End If
      If Me.Teams.Count = 0 Then
        Me.Teams.GetFromDB("")
      End If

      Dim match As Match = Me.Matches.GetMatchByOptaID(optaID)

      If match Is Nothing Then
        match = New Match()
        match.optaID = optaID
        Me.Matches.Add(match)
      End If

      For Each node As XmlNode In nodeMatch
        Select Case node.Name
          Case "MatchInfo"
            attr = node.Attributes.GetNamedItem("Period")
            match.state = attr.Value
            attr = node.Attributes.GetNamedItem("OtherMatchDay")
            match.matchday = NoNullInt(attr.Value)
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
          Case "home-team"
            Dim teamID As Integer = 0
            Dim score As Integer = 0

            For Each auxNode As XmlNode In node.ChildNodes
              Select Case auxNode.Name
                Case "team-id"
                  teamID = NoNullInt(auxNode.InnerText)
                Case "score"
                  score = NoNullInt(auxNode.InnerText)
              End Select
            Next

            match.optaHomeTeamID = teamID
            match.HomeTeam = Me.Teams.GetTeamByOptaID(teamID)
            match.HomeTeam.Goals = score
            match.optaHomeScore = score

          Case "away-team"
            Dim teamID As Integer = 0
            Dim score As Integer = 0

            For Each auxNode As XmlNode In node.ChildNodes
              Select Case auxNode.Name
                Case "team-id"
                  teamID = NoNullInt(auxNode.InnerText)
                Case "score"
                  score = NoNullInt(auxNode.InnerText)
              End Select
            Next

            match.optaAwayTeamID = teamID
            match.AwayTeam = Me.Teams.GetTeamByOptaID(teamID)
            match.AwayTeam.Goals = score
            match.optaAwayScore = score

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
      Me.Teams.GetFromDB("")
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


#Region "File watcher"
  Private Sub InitFilewatcher()
    Try
      _fileWatcher = New FileSystemWatcher
      _fileWatcher.Path = AppSettings.Instance.OptaDefaultFolder
      ' Watch for changes in LastAccess and LastWrite times, and
      ' the renaming of files or directories. 
      _fileWatcher.NotifyFilter = (NotifyFilters.LastAccess Or NotifyFilters.LastWrite Or NotifyFilters.FileName Or NotifyFilters.DirectoryName)
      ' Only watch text files.
      _fileWatcher.Filter = System.IO.Path.GetFileName("football_results.202*.xml")
      _fileWatcher.EnableRaisingEvents = True
    Catch ex As Exception

    End Try
  End Sub

  Private Sub _fileWatcher_Changed(sender As Object, e As FileSystemEventArgs) Handles _fileWatcher.Changed
    Me.Path = System.IO.Path.Combine(AppSettings.Instance.OptaDefaultFolder, e.Name)
    Me.Update()
  End Sub

  Private Sub _fileWatcher_Created(sender As Object, e As FileSystemEventArgs) Handles _fileWatcher.Created
    Me.Path = System.IO.Path.Combine(AppSettings.Instance.OptaDefaultFolder, e.Name)
    Me.Update()
  End Sub

  Private Sub _fileWatcher_Renamed(sender As Object, e As RenamedEventArgs) Handles _fileWatcher.Renamed
    Me.Path = System.IO.Path.Combine(AppSettings.Instance.OptaDefaultFolder, e.Name)
    Me.Update()
  End Sub

#End Region
End Class
