Imports System.Xml
Imports System.IO
Imports System.Text
Imports MatchInfo

Public Class COptaF9Helper
  Inherits COptaFile

#Region "Variables"
  Private _benchPlayer As Integer = 0
#End Region

#Region "Properties"

  Private _match As MatchInfo.Match
  Public Property Match() As MatchInfo.Match
    Get
      Return _match
    End Get
    Set(ByVal value As MatchInfo.Match)
      _match = value
    End Set
  End Property
#End Region

#Region "Constructors"
  Public Sub New()

  End Sub

  Public Sub New(ByVal path As String, ByRef partit As MatchInfo.Match)
    Me.Path = path
    _match = partit

    Me.IniciarEstadistiques()
  End Sub
#End Region

#Region "Functions"

  Public Function PreviewMatchInfo(ByVal readPlayers As Boolean) As Boolean
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
      If attr Is Nothing Then Return False

      Dim teamIndex As Integer = 0
      For Each nodeSoccerFeed As XmlNode In nodeRoot.ChildNodes
        Select Case nodeSoccerFeed.Name
          Case "SoccerDocument"
            attr = nodeSoccerFeed.Attributes.GetNamedItem("uID")
            Me.Match.OPTAID = Me.FixID(attr.Value)
            For Each nodeSoccerDocument As XmlNode In nodeSoccerFeed.ChildNodes
              Select Case nodeSoccerDocument.Name
                Case "Competition"
                  Me.ReadCompetition(nodeSoccerDocument)
                Case "MatchData"
                  Me.ReadMatchData(nodeSoccerDocument, readPlayers)
                Case "Team"
                  Me.ReadTeam(nodeSoccerDocument, (teamIndex = 0), readPlayers)
                  teamIndex += 1
                Case "Venue"
                  Me.ReadVenue(nodeSoccerDocument)
              End Select
            Next
        End Select
      Next
      res = True
    Catch ex As Exception
    End Try
    Return res
  End Function

  Public Overrides Function InitializeData() As Boolean
    Dim res As Boolean = False
    Try
      _xmlDocument.Load(Me.Path)
      Me.LastUpdateTime = System.IO.File.GetLastWriteTime(Me.Path)

      Me.LlistaOptaLinks.Clear()

      Dim nodeRoot As XmlNode
      nodeRoot = _xmlDocument.DocumentElement

      Dim attr As XmlAttribute = nodeRoot.Attributes.GetNamedItem("TimeStamp")
      Dim timeStamp As String = attr.Value

      'Me.TimeStamp = timeStamp
      Dim teamIndex As Integer = 0
      For Each nodeSoccerFeed As XmlNode In nodeRoot.ChildNodes
        Select Case nodeSoccerFeed.Name
          Case "SoccerDocument"
            attr = nodeSoccerFeed.Attributes.GetNamedItem("uID")
            Me.Match.OPTAID = Me.FixID(attr.Value)
            For Each nodeSoccerDocument As XmlNode In nodeSoccerFeed.ChildNodes
              Select Case nodeSoccerDocument.Name
                Case "Competition"
                  Me.ReadCompetition(nodeSoccerDocument)
                Case "MatchData"
                  Me.ReadMatchData(nodeSoccerDocument, True)
                Case "Team"
                  Me.ReadTeam(nodeSoccerDocument, (teamIndex = 0), True)
                  teamIndex += 1
                Case "Venue"
                  Me.ReadVenue(nodeSoccerDocument)
              End Select
            Next
        End Select
      Next
      Me.FixOptaLinks(Me)
      Me.IniciarValorsEstadistics()
      Me.UpdateValors()
      res = True
    Catch ex As Exception
    End Try
    Return res
  End Function

  Public Overrides Function Update() As Boolean
    Return Me.UpdateValors
  End Function

  Public Function UpdateValors() As Boolean
    Dim res As Boolean = False
    Try
      _xmlDocument.Load(Me.Path)
      Me.LastUpdateTime = System.IO.File.GetLastWriteTime(Me.Path)

      Dim nodeRoot As XmlNode
      nodeRoot = _xmlDocument.DocumentElement

      Dim attr As XmlAttribute = nodeRoot.Attributes.GetNamedItem("TimeStamp")
      If attr Is Nothing Then Return False
      Dim attimeStamp As String = attr.Value

      'If timeStamp <> Me.TimeStamp Then
      Me.TimeStamp = TimeStamp
      Dim teamIndex As Integer = 0
      For Each nodeSoccerFeed As XmlNode In nodeRoot.ChildNodes
        Select Case nodeSoccerFeed.Name
          Case "SoccerDocument"
            attr = nodeSoccerFeed.Attributes.GetNamedItem("uID")
            Me.Match.OPTAID = Me.FixID(attr.Value)
            For Each nodeSoccerDocument As XmlNode In nodeSoccerFeed.ChildNodes
              Select Case nodeSoccerDocument.Name
                Case "Competition"
                  'Me.ReadCompetition(nodeSoccerDocument)
                Case "MatchData"
                  Me.UpdateMatchData(nodeSoccerDocument)
                Case "Team"
                  'Me.ReadTeam(nodeSoccerDocument, (teamIndex = 0))
                  teamIndex += 1
                Case "Venue"
                  'Me.ReadVenue(nodeSoccerDocument)
              End Select
            Next
        End Select
      Next
      'End If
    Catch ex As Exception
    End Try
    Return res
  End Function

  Private Sub IniciarEstadistiques()
    Try
    Catch ex As Exception

    End Try
  End Sub

  Private Sub IniciarValorsEstadistics()
    Try

    Catch ex As Exception

    End Try
  End Sub

  Private Sub ReadCompetition(ByRef nodeCompetition As XmlNode)
    Try
      If Me.Match.optaCompetitionId <> 0 Then Exit Sub

      Dim attr As XmlAttribute = nodeCompetition.Attributes.GetNamedItem("uID")

      'no l'hem trobat

      Me.Match.optaCompetitionId = Me.FixID(attr.Value)
      For Each node As XmlNode In nodeCompetition
        Select Case node.Name
          Case "Country"
          Case "Name"
          Case "Stat"
            attr = node.Attributes.GetNamedItem("Type")
            Select Case attr.Value
              Case "season_id"
                Me.Match.optaSeason = NoNullString(node.InnerText)
              Case "season_name"
              Case "symid"
              Case "matchday"
                Me.Match.optaMatchDay = NoNullInt(node.InnerText)
            End Select
        End Select
      Next
    Catch ex As Exception

    End Try
  End Sub

  Private Sub ReadMatchData(ByRef nodeMatchData As XmlNode, ByVal readPlayers As Boolean)
    Try
      Dim attr As XmlAttribute
      For Each node As XmlNode In nodeMatchData
        Select Case node.Name
          Case "MatchInfo"
            attr = node.Attributes.GetNamedItem("TimeStamp")
            For Each nodeMatchInfo As XmlNode In node.ChildNodes
              Select Case nodeMatchInfo.Name
                Case "Date"
                  Me.Match.date = TimeStampToDate(nodeMatchInfo.InnerText)
              End Select
            Next
          Case "MatchOfficial"
          Case "AssistantOfficials"
          Case "Stat"
            attr = node.Attributes.GetNamedItem("Type")
            Select Case attr.Value
              Case "match_time"
              Case "first_half_start"
              Case "first_half_time"
              Case "first_half_stop"
              Case "second_half_start"
              Case "second_half_time"
              Case "second_half_stop"
            End Select
          Case "TeamData"
            Dim isLocal As Boolean = False
            Dim Team As Team = Nothing
            Dim loadPlayers As Boolean = False

            attr = node.Attributes.GetNamedItem("Side")
            isLocal = (attr.Value = "Home")
            attr = node.Attributes.GetNamedItem("TeamRef")

            If isLocal Then
              If Me.Match.optaHomeTeamID = 0 Then
                Me.Match.HomeTeam = New Team(NoNullString(Me.FixID(attr.Value)))
                Me.Match.optaHomeTeamID = Me.Match.HomeTeam.OptaID
                loadPlayers = True
              End If
              Team = Me.Match.HomeTeam
            Else
              If Me.Match.optaAwayTeamID = 0 Then
                Me.Match.AwayTeam = New Team(NoNullString(Me.FixID(attr.Value)))
                Me.Match.optaAwayTeamID = Me.Match.AwayTeam.OptaID
                loadPlayers = True
              End If
              Team = Me.Match.AwayTeam
            End If
            For Each nodeTeamData As XmlNode In node
              If readPlayers Then
                Select Case nodeTeamData.Name
                  Case "Booking" 'Targeta
                  Case "Goal"
                  Case "PlayerLineUp"
                    If loadPlayers Then
                      For Each nodePlayerLineUp As XmlNode In nodeTeamData.ChildNodes
                        Me.ReadPlayer(nodePlayerLineUp, Team)
                      Next
                    Else
                      For Each nodePlayerLineUp As XmlNode In nodeTeamData.ChildNodes
                        Me.ReadPlayer(nodePlayerLineUp, Team)
                      Next
                    End If
                  Case "Stat"
                    attr = nodeTeamData.Attributes.GetNamedItem("Type")
                    If Not attr Is Nothing Then
                      Team.optaStatValueNames.Add(attr.Value)
                      Team.optaStatValues.Add(nodeTeamData.InnerText)
                    End If
                End Select
              End If
            Next
            For Each nodePlayer As XmlNode In node.ChildNodes

            Next


        End Select
      Next
    Catch ex As Exception

    End Try
  End Sub

  Private Sub UpdateMatchData(ByRef nodeMatchData As XmlNode)
    Try
      Dim attr As XmlAttribute
      For Each node As XmlNode In nodeMatchData
        Select Case node.Name
          Case "MatchInfo"
          Case "MatchOfficial"
          Case "AssistantOfficials"
          Case "Stat"
            attr = node.Attributes.GetNamedItem("Type")
            Select Case attr.Value
              Case "match_time"
              Case "first_half_start"
              Case "first_half_time"
              Case "first_half_stop"
              Case "second_half_start"
              Case "second_half_time"
              Case "second_half_stop"
            End Select
          Case "TeamData"
            Dim isLocal As Boolean = False
            Dim Team As Team = Nothing
            Dim loadPlayers As Boolean = False

            attr = node.Attributes.GetNamedItem("Side")
            isLocal = (attr.Value = "Home")
            attr = node.Attributes.GetNamedItem("TeamRef")

            If isLocal Then
              If Me.Match.optaHomeTeamID = 0 Then
                Me.Match.HomeTeam = New Team(NoNullString(Me.FixID(attr.Value)))
                Me.Match.optaHomeTeamID = Me.Match.HomeTeam.OptaID
                loadPlayers = True
              End If
              Team = Me.Match.HomeTeam
            Else
              If Me.Match.optaAwayTeamID = 0 Then
                Me.Match.AwayTeam = New Team(NoNullString(Me.FixID(attr.Value)))
                Me.Match.optaAwayTeamID = Me.Match.AwayTeam.OptaID
                loadPlayers = True
              End If
              Team = Me.Match.AwayTeam
            End If
            For Each nodeTeamData As XmlNode In node
              Select Case nodeTeamData.Name
                Case "Booking" 'Targeta
                Case "Goal"
                Case "PlayerLineUp"
                  _benchPlayer = 12
                  For Each nodePlayerLineUp As XmlNode In nodeTeamData.ChildNodes
                    Me.UpdatePlayerData(nodePlayerLineUp, Team)
                  Next
              End Select
            Next

            Me.UpdateTeamData(node, Team)


        End Select
      Next
    Catch ex As Exception

    End Try
  End Sub

  Private Sub ReadTeam(ByRef nodeTeam As XmlNode, ByVal isLocal As Boolean, ByVal readPlayers As Boolean)
    Try

      Dim attr As XmlAttribute = nodeTeam.Attributes.GetNamedItem("uID")
      Dim Team As Team
      Dim name As String = ""
      Dim index As Integer = 1

      If isLocal Then
        Team = _match.HomeTeam
      Else
        Team = _match.AwayTeam
      End If
      Team.OptaID = Me.FixID(attr.Value)

      For Each node As XmlNode In nodeTeam
        Select Case node.Name
          Case "Country"
          Case "Name"
            name = node.InnerText
            Team.OptaName = name

            Me.AddOptaLink(New COptaLink(Team.OptaID, name, "", COptaLink.eTipusLink.Team))
          Case "Player", "TeamOfficial"
            If readPlayers Then
              Dim first As String = ""
              Dim last As String = ""
              Dim known As String = ""
              Dim type As String = ""
              Dim optaID As String = ""
              Dim position As Integer = Team.MatchPlayers.Count
              Dim isEntrenador As Boolean = Not (node.Name = "Player")

              attr = node.Attributes.GetNamedItem("uID")
              optaID = Me.FixID(attr.Value)


              Dim CPlayer As Player = Team.GetPlayerByOptaId(optaID)
              Dim importaData As Boolean = True


              If importaData Then
                If CPlayer Is Nothing Then
                  CPlayer = New Player()
                  CPlayer.optaID = optaID
                  CPlayer.ID = optaID
                  CPlayer.PlayerID = optaID
                End If

                CPlayer.optaPosition = Team.MatchPlayers.Count + 1
                CPlayer.optaTeamID = Team.TeamID
                CPlayer.optaMatchID = Me.Match.optaID
                CPlayer.optaID = optaID
                For Each nodePlayer As XmlNode In node.ChildNodes
                  Select Case nodePlayer.Name
                    Case "PersonName"
                      For Each nodePersonName As XmlNode In nodePlayer
                        Select Case nodePersonName.Name
                          Case "First"
                            first = nodePersonName.InnerText
                          Case "Last"
                            last = nodePersonName.InnerText
                          Case "Known"
                            known = nodePersonName.InnerText
                        End Select
                      Next
                  End Select
                Next
                name = IIf(known <> "", known, first & " " & last)
                CPlayer.optaName = first & " " & last
                CPlayer.OptaShortName = name
              End If
              Me.AddOptaLink(New COptaLink(optaID, name, NoNullString(CPlayer.OptaSquadNumber), COptaLink.eTipusLink.Player))

              If isEntrenador Then
                attr = node.Attributes.GetNamedItem("Type")
                type = attr.Value
                position = 101
                If Not Team.TeamStaff.Contains(CPlayer) Then Team.TeamStaff.Add(CPlayer)
                Team.Manager = CPlayer
              Else
                attr = node.Attributes.GetNamedItem("Position")
                type = attr.Value
                position = index
                If Not Team.MatchPlayers.Contains(CPlayer) Then Team.MatchPlayers.Add(CPlayer)
              End If
              CPlayer.optaPosition = position

              CPlayer.optaType = type

              index += 1
            End If
        End Select
      Next

      If isLocal Then
        Me.Match.HomeTeam = Team
        Me.Match.optaHomeTeamID = Team.OptaID
      Else
        Me.Match.AwayTeam = Team
        Me.Match.optaAwayTeamID = Team.OptaID
      End If

    Catch ex As Exception
      Debug.Print(ex.ToString)
    End Try
  End Sub

  Private Sub ReadVenue(ByRef nodeVenue As XmlNode)
    Try

    Catch ex As Exception

    End Try
  End Sub

  Private Sub LoadPlayer(ByRef nodePlayer As XmlNode, ByRef Team As Team)
    Try
      Dim attr As XmlAttribute = nodePlayer.Attributes.GetNamedItem("PlayerRef")
      Dim CPlayer As Player = New Player(Me.FixID(attr.Value))

    Catch ex As Exception

    End Try
  End Sub

  Private Sub ReadPlayer(ByRef nodePlayer As XmlNode, ByRef Team As Team)
    Try
      Dim attr As XmlAttribute = nodePlayer.Attributes.GetNamedItem("PlayerRef")
      Dim CPlayer As Player = Team.GetPlayerByOptaId(Me.FixID(attr.Value))

      If CPlayer Is Nothing Then

        CPlayer = New Player
        CPlayer.optaID = Me.FixID(attr.Value)
        attr = nodePlayer.Attributes.GetNamedItem("ShirtNumber")
        If Not attr Is Nothing Then
          CPlayer.OptaSquadNumber = attr.Value
        End If
        attr = nodePlayer.Attributes.GetNamedItem("Position")
        If Not attr Is Nothing Then
          Dim type As String = ""
          If attr.Value = "Substitute" Then
            attr = nodePlayer.Attributes.GetNamedItem("SubPosition")
            If Not attr Is Nothing Then type = attr.Value
          Else
            type = attr.Value
          End If
          CPlayer.optaType = type
        End If
        For Each node As XmlNode In nodePlayer
          If node.Name = "Stat" Then
            attr = node.Attributes.GetNamedItem("Type")
            If Not attr Is Nothing Then
              CPlayer.optastatValueNames.Add(attr.Value)
              CPlayer.optastatValues.Add(node.InnerText)
            End If

          End If
        Next

        CPlayer.optaPosition = Team.MatchPlayers.Count + 1
      End If

      If Not Team.MatchPlayers.ContainsByOptaID(CPlayer.optaID) Then Team.MatchPlayers.Add(CPlayer)
      If Not Team.AllPlayers.ContainsByOptaID(CPlayer.optaID) Then Team.AllPlayers.Add(CPlayer)

    Catch ex As Exception

    End Try
  End Sub

  Private Sub UpdateTeamData(ByRef nodeTeamData As XmlNode, ByRef Team As Team)
    Try
      Dim attr As XmlAttribute = nodeTeamData.Attributes.GetNamedItem("PlayerRef")

      For Each node As XmlNode In nodeTeamData
        Select Case node.Name
          Case "Stat"
            attr = node.Attributes.GetNamedItem("Type")
            If attr.Value = "formation_place" Then

            Else
            End If
        End Select
      Next

    Catch ex As Exception

    End Try
  End Sub

  Private Sub UpdatePlayerData(ByRef nodePlayer As XmlNode, ByRef Team As Team)
    Try
      Dim attr As XmlAttribute = nodePlayer.Attributes.GetNamedItem("PlayerRef")
      Dim CPlayer As Player = Team.GetPlayerById(Me.FixID(attr.Value))

      If Not CPlayer Is Nothing AndAlso CPlayer.OptaId <> 0 Then


        For Each node As XmlNode In nodePlayer
          Select Case node.Name
            Case "Stat"
              attr = node.Attributes.GetNamedItem("Type")
              If attr.Value = "formation_place" Then
                If node.InnerText <> "0" Then
                  CPlayer.optaPosition = CInt(node.InnerText)
                Else
                  CPlayer.optaPosition = _benchPlayer
                  _benchPlayer += 1
                End If

              Else

              End If
          End Select
        Next
      End If

    Catch ex As Exception

    End Try
  End Sub
#End Region


End Class
