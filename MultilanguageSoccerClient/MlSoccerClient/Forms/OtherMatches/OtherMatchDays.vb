Imports System.Xml
Imports MatchInfo

<Serializable()> Public Class OtherMatchDays
  Inherits CollectionBase

  Public Sub New()
    Try
      Dim silent As Boolean = Config.Instance.Silent
      Config.Instance.Silent = True
      Me.LoadOthers()
      Config.Instance.Silent = silent
    Catch ex As Exception
    End Try
  End Sub

  Public Function Add(MatchDay As OtherMatchDay) As Integer
    Try
      If Not MatchDay Is Nothing Then
        Me.List.Add(MatchDay)
      End If
    Catch ex As Exception
    End Try
    Return Me.List.Count
  End Function

  Public Sub remove(MatchDay As OtherMatchDay)
    Try
      If Not MatchDay Is Nothing Then
        For i As Integer = Me.List.Count - 1 To 0 Step -1
          If MatchDay.MatchDayID = CType(Me.List(i), OtherMatchDay).MatchDayID Then
            Me.List.RemoveAt(i)
          End If
        Next
      End If
    Catch ex As Exception
    End Try
  End Sub

  Default Public Property Item(Index As Integer) As OtherMatchDay
    Get
      Return DirectCast(List(Index), OtherMatchDay)
    End Get
    Set
      List(Index) = Value
    End Set
  End Property

  Public Sub Sort()
    Me.InnerList.Sort()
  End Sub

  Public Function GetMatchDay(matchDay As String) As OtherMatchDay
    Dim res As OtherMatchDay = Nothing
    Try
      For Each match As OtherMatchDay In Me.InnerList
        If match.MatchDayName = matchDay Or match.MatchDayID = matchDay Then
          res = match
          Exit For
        End If
      Next
    Catch ex As Exception

    End Try
    Return res
  End Function

  Public ReadOnly Property AllMatches() As List(Of OtherMatch)
    Get
      Dim res As New List(Of OtherMatch)
      For Each matchDay As OtherMatchDay In Me.List
        For Each match As OtherMatch In matchDay.OtherMatches
          res.Add(match)
        Next
      Next
      res.Sort()
      Return res
    End Get
  End Property

  Public ReadOnly Property AllMatchesByTeam(team As Team) As List(Of OtherMatch)
    Get
      Return AllMatchesByTeam(team.ID)
    End Get
  End Property

  Public ReadOnly Property AllMatchesByTeam(idTeam As Integer) As List(Of OtherMatch)
    Get
      Dim res As New List(Of OtherMatch)
      For Each matchDay As OtherMatchDay In Me.List
        For Each match As OtherMatch In matchDay.OtherMatches
          If match.Match.HomeTeam.ID = idTeam Or match.Match.AwayTeam.ID = idTeam Then
            res.Add(match)
          End If
        Next
      Next
      res.Sort()
      Return res
    End Get
  End Property

#Region "Classification"
  Public Property Classification As Classification
  Public Property Competition As Competition

  Public Sub ComputeClassification()
    Try
      Dim _matches As New Matches
      _matches = Matches.GetMatchesForCompetition(Competition.CompID)
      _matches.Sort()

      Classification = New Classification(_matches)

      'order by match day
      Me.Sort()

      'Get all the teams
      Dim _teams As New MatchInfo.Teams()
      For Each match As Match In _matches
        If Not _teams.Contains(match.HomeTeam) Then _teams.Add(match.HomeTeam)
        If Not _teams.Contains(match.AwayTeam) Then _teams.Add(match.AwayTeam)
      Next

      For Each matchDay As OtherMatchDay In Me.List
        For Each match As OtherMatch In matchDay.OtherMatches
          If Not match.Match Is Nothing Then
            If Not _teams.Contains(match.Match.HomeTeam) Then _teams.Add(match.Match.HomeTeam)
            If Not _teams.Contains(match.Match.AwayTeam) Then _teams.Add(match.Match.AwayTeam)
          End If
        Next
      Next

      'for each team, populate its helper class
      Dim matchDayIndex As Integer = 1
      For Each team As MatchInfo.Team In _teams
        Dim teamForCompetition As New TeamClassificationForCompetition(team)
        _matches.Sort()
        Dim teamMatches As List(Of Match) = _matches.GetMatchesForTeam(team.ID)
        'For Each matchDay As OtherMatchDay In Me.List
        '  Dim teamClassificationForMatchDay As New TeamClassificationForMatchDay(team, matchDay.Index, Nothing)
        '  For Each match As OtherMatch In matchDay.OtherMatches
        '    If Not match.Match Is Nothing Then
        '      If match.Match.HomeTeam.ID = team.ID Or match.Match.AwayTeam.ID = team.ID Then
        '        teamClassificationForMatchDay.Match = match
        '      End If
        '    End If
        '  Next
        '  teamForCompetition.ClassificationsForMatchDay.Add(teamClassificationForMatchDay)
        'Next
        Classification.TeamClassificationsForCompetition.Add(teamForCompetition)
      Next

      'for each helper class, calculate
      For Each teamForCompetition As TeamClassificationForCompetition In Classification.TeamClassificationsForCompetition
        teamForCompetition.UpdateClassifications()
      Next

    Catch ex As Exception
      WriteToErrorLog(ex)
    End Try
  End Sub

#End Region

#Region "Load/Save functions"

  Public Sub SaveXML()
    Try
      'Borra el Nodo y lo recrea si existe.
      Dim xmlDoc As New XmlDocument()
      Dim xmlRoot As XmlElement = xmlDoc.CreateElement("OtherMatches")
      xmlDoc.AppendChild(xmlRoot)

      For Each myMatchDay As OtherMatchDay In Me.List
        Dim xmlHeader As XmlElement = xmlDoc.CreateElement("Header")
        xmlHeader.SetAttribute("name", myMatchDay.MatchDayName)
        xmlHeader.SetAttribute("competitionID", myMatchDay.CompetitionID)

        For Each myOtherMatch As OtherMatch In myMatchDay.OtherMatches
          Dim xmlLine As XmlElement = xmlDoc.CreateElement("Line")
          Dim xmlLineTitle As XmlElement = xmlDoc.CreateElement("Title")
          xmlLineTitle.InnerText = myOtherMatch.MatchTitle
          xmlLine.AppendChild(xmlLineTitle)

          Dim lineType As XmlElement = xmlDoc.CreateElement("LineType")
          lineType.InnerText = myOtherMatch.LineType.ToString()
          xmlLine.AppendChild(lineType)

          Dim addCrawl As XmlElement = xmlDoc.CreateElement("AddCrawl")
          addCrawl.InnerText = myOtherMatch.IsCrawl.ToString()
          xmlLine.AppendChild(addCrawl)

          Dim addTables As XmlElement = xmlDoc.CreateElement("AddTables")
          addTables.InnerText = myOtherMatch.IsTable.ToString()
          xmlLine.AppendChild(addTables)

          Dim matchID As XmlElement = xmlDoc.CreateElement("MatchID")
          If myOtherMatch.Match Is Nothing Then
            matchID.InnerText = "0"
          Else
            matchID.InnerText = myOtherMatch.Match.match_id
          End If
          xmlLine.AppendChild(matchID)

          Dim homeGoals As XmlElement = xmlDoc.CreateElement("HomeGoals")
          homeGoals.InnerText = myOtherMatch.HomeScore.ToString()
          xmlLine.AppendChild(homeGoals)

          Dim awayGoals As XmlElement = xmlDoc.CreateElement("AwayGoals")
          awayGoals.InnerText = myOtherMatch.AwayScore.ToString()
          xmlLine.AppendChild(awayGoals)

          Dim logoChannel As XmlElement = xmlDoc.CreateElement("LogoChannel")
          logoChannel.InnerText = myOtherMatch.LogoChannel
          xmlLine.AppendChild(logoChannel)

          Dim matchStatus As XmlElement = xmlDoc.CreateElement("MatchStatus")
          matchStatus.InnerText = myOtherMatch.MatchStatus
          xmlLine.AppendChild(matchStatus)

          xmlHeader.AppendChild(xmlLine)
        Next
        xmlRoot.AppendChild(xmlHeader)
      Next

      xmlDoc.Save(AppSettings.Instance.OtherMatchesPath)
    Catch
    End Try
  End Sub

  Public Sub LoadOthers()
    Dim xmlDoc As New XmlDocument()
    Try
      Me.InnerList.Clear()
      xmlDoc.Load(AppSettings.Instance.OtherMatchesPath)
      For Each myXmlHeaders As XmlNode In xmlDoc.SelectNodes("OtherMatches/Header")
        Dim myMatchDay As New OtherMatchDay(ReadAttribute(myXmlHeaders, "name"))
        myMatchDay.CompetitionID = NoNullInt(ReadAttribute(myXmlHeaders, "competitionID"))
        If myMatchDay.CompetitionID < 1 Then myMatchDay.CompetitionID = 298
        For Each myXmlLines As XmlNode In myXmlHeaders.SelectNodes("Line")
          Dim myOtherMatch As New OtherMatch
          myOtherMatch.MatchTitle = ReadSon(myXmlLines, "Title")
          Select Case ReadSon(myXmlLines, "LineType")
            Case OtherMatch.eOtherMatchLineType.Result.ToString
              myOtherMatch.LineType = OtherMatch.eOtherMatchLineType.Result
            Case OtherMatch.eOtherMatchLineType.Title.ToString
              myOtherMatch.LineType = OtherMatch.eOtherMatchLineType.Title
            Case Else
              myOtherMatch.LineType = OtherMatch.eOtherMatchLineType.Blank
          End Select
          myOtherMatch.IsCrawl = (ReadSon(myXmlLines, "AddCrawl") = "True")
          myOtherMatch.IsTable = (ReadSon(myXmlLines, "AddTables") = "True")
          myOtherMatch.OtherMatchID = Val(ReadSon(myXmlLines, "MatchID"))
          If myOtherMatch.OtherMatchID <> 0 Then
            myOtherMatch.Match = New MatchInfo.Match(myOtherMatch.OtherMatchID)
          End If
          myOtherMatch.HomeScore = Val(ReadSon(myXmlLines, "HomeGoals"))
          myOtherMatch.AwayScore = Val(ReadSon(myXmlLines, "AwayGoals"))

          Dim aux As String = ReadSon(myXmlLines, "LogoChannel")
          Dim logoChannel As Integer = 0
          Integer.TryParse(aux, logoChannel)
          myOtherMatch.LogoChannel = logoChannel

          aux = ReadSon(myXmlLines, "MatchStatus")
          Dim nStatus As Integer = 0
          Integer.TryParse(aux, nStatus)
          myOtherMatch.MatchStatus = nStatus
          myMatchDay.Add(myOtherMatch)
        Next
        Me.Add(myMatchDay)
      Next
    Catch err As Exception
      WriteToErrorLog(err)
    End Try
    CreateEmptyOthers()


  End Sub

  Private Sub CreateEmptyOthers()
    Try
      Dim totallMatchDays As Integer = 26

      For i As Integer = 1 To totallMatchDays
        Dim name As String = "ROUND " & i & " FIXTURES"
        If Me.GetMatchDay(name) Is Nothing Then
          Dim myMatchDay As New OtherMatchDay(name)
          Me.Add(myMatchDay)
        End If
      Next
    Catch err As Exception
      WriteToErrorLog(err)
    End Try
  End Sub

  Public Sub SaveResultsToDataBase()
    Try
      For Each match As OtherMatch In Me.AllMatches
        If Not match.Match Is Nothing Then
          match.Match.home_goals = match.HomeScore
          match.Match.away_goals = match.AwayScore
          match.Match.SaveMatchGoalsToDB(False)
        End If
      Next
    Catch ex As Exception

    End Try
  End Sub

#End Region
End Class
