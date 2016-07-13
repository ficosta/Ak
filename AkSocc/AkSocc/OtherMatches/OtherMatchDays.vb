Imports System.Xml

<Serializable()> Public Class OtherMatchDays
  Inherits CollectionBase

  Public Sub New()
    Me.LoadOthers()
  End Sub

  Public Function Add(MatchDay As MatchDay) As Integer
    Try
      If Not MatchDay Is Nothing Then
        Me.List.Add(MatchDay)
      End If
    Catch ex As Exception
    End Try
    Return Me.List.Count
  End Function

  Default Public Property Item(Index As Integer) As MatchDay
    Get
      Return DirectCast(List(Index), MatchDay)
    End Get
    Set
      List(Index) = Value
    End Set
  End Property

  Public Sub Sort()
    Me.InnerList.Sort()
  End Sub

  Public Function GetMatchDays() As List(Of MatchDay)
    Dim res As New List(Of MatchDay)
    Try
      For Each match As OtherMatch In Me.InnerList
        For Each matchDay As MatchDay In res

        Next
      Next
    Catch ex As Exception

    End Try
    Return res
  End Function

  Public Function GetMatchDay(matchDay As String) As MatchDay
    Dim res As MatchDay = Nothing
    Try
      For Each match As MatchDay In Me.InnerList
        If match.MatchDayName = matchDay Or match.MatchDayID = matchDay Then
          res = match
          Exit For
        End If
      Next
    Catch ex As Exception

    End Try
    Return res
  End Function

#Region "Classification"
  Public Property Classification As Classification

  Public Sub ComputeClassification()
    Try
      Classification = New Classification(Me)
      'order by match day
      Me.Sort()

      'Get all the teams
      Dim _teams As New MatchInfo.Teams()
      For Each matchDay As MatchDay In Me.List
        For Each match As OtherMatch In matchDay.OtherMatches
          If Not match.Match Is Nothing Then
            If Not _teams.Contains(match.Match.HomeTeam) Then _teams.Add(match.Match.HomeTeam)
            If Not _teams.Contains(match.Match.AwayTeam) Then _teams.Add(match.Match.AwayTeam)
          End If
        Next
      Next

      'for each team, populate its helper class
      For Each team As MatchInfo.Team In _teams
        Dim teamForCompetition As New TeamClassificationForCompetition(team)
        For Each matchDay As MatchDay In Me.List
          Dim teamClassificationForMatchDay As New TeamClassificationForMatchDay(team, matchDay.Index, Nothing)
          For Each match As OtherMatch In matchDay.OtherMatches
            If Not match.Match Is Nothing Then
              If match.Match.HomeTeam.ID = team.ID Or match.Match.AwayTeam.ID = team.ID Then
                teamClassificationForMatchDay.Match = match
              End If
            End If
          Next
          teamForCompetition.ClassificationsForMatchDay.Add(teamClassificationForMatchDay)
        Next
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

#Region "Shared functions"

  Public Sub SaveXML()
    Try
      'Borra el Nodo y lo recrea si existe.
      Dim xmlDoc As New XmlDocument()
      Dim xmlRoot As XmlElement = xmlDoc.CreateElement("OtherMatches")
      xmlDoc.AppendChild(xmlRoot)

      For Each myMatchDay As MatchDay In Me.List
        Dim xmlHeader As XmlElement = xmlDoc.CreateElement("Header")
        xmlHeader.SetAttribute("name", myMatchDay.MatchDayName)
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
          matchID.InnerText = myOtherMatch.OtherMatchID.ToString()
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
      xmlDoc.Save(My.MySettings.Default.OtherMatchesPath)
    Catch
    End Try
  End Sub

  Public Sub LoadOthers()
    Dim xmlDoc As New XmlDocument()
    Try
      Me.InnerList.Clear()
      xmlDoc.Load(My.MySettings.Default.OtherMatchesPath)
      For Each myXmlHeaders As XmlNode In xmlDoc.SelectNodes("OtherMatches/Header")
        Dim myMatchDay As New MatchDay(ReadAttribute(myXmlHeaders, "name"))
        For Each myXmlLines As XmlNode In myXmlHeaders.SelectNodes("Line")
          Dim myOtherMatch As New OtherMatch
          myOtherMatch.MatchTitle = ReadSon(myXmlLines, "Title")
          myOtherMatch.LineType = Val(ReadSon(myXmlLines, "LineType"))
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
          myOtherMatch.LogoChannel = logoChannel
          aux = ReadSon(myXmlLines, "MatchStatus")
          myOtherMatch.MatchStatus = 0
          myMatchDay.Add(myOtherMatch)
        Next
        Me.Add(myMatchDay)
      Next
      CreateEmptyOthers()
    Catch err As Exception
      WriteToErrorLog(err)
    End Try


  End Sub



  Private Sub CreateEmptyOthers()
    Try
      Dim totallMatchDays As Integer = 26

      For i As Integer = 1 To totallMatchDays
        Dim name As String = "ROUND " + i + " FIXTURES"
        If Me.GetMatchDay(name) Is Nothing Then
          Dim myMatchDay As New MatchDay(name)
          Me.Add(myMatchDay)
        End If
      Next
    Catch err As Exception
      WriteToErrorLog(Err)
    End Try
  End Sub

  'Private Sub LoadOthers()
  '  Dim xmlDoc As New XmlDocument()
  '  Try
  '    OMSelectedHeader.Items.Clear()
  '    GlobalHeaders = New OMHeaders()
  '    xmlDoc.Load(Properties.Settings.[Default].OthersXMLPath)
  '    For Each myXmlHeaders As XmlNode In xmlDoc.SelectNodes("OtherMatches/Header")
  '      Dim myNewHeader As New OMHeader(Utils.ReadAttribute(myXmlHeaders, "name"))
  '      For Each myXmlLines As XmlNode In myXmlHeaders.SelectNodes("Line")
  '        Dim myNewLine As New OMLine()
  '        myNewLine.Title = Utils.ReadSon(myXmlLines, "Title")
  '        myNewLine.LineType = Utils.Val(Utils.ReadSon(myXmlLines, "LineType"))
  '        myNewLine.AddCrawl = (Utils.ReadSon(myXmlLines, "AddCrawl") = "True")
  '        myNewLine.AddTables = (Utils.ReadSon(myXmlLines, "AddTables") = "True")
  '        myNewLine.MatchID = Utils.Val(Utils.ReadSon(myXmlLines, "MatchID"))
  '        myNewLine.HomeGoals = Utils.Val(Utils.ReadSon(myXmlLines, "HomeGoals"))
  '        myNewLine.AwayGoals = Utils.Val(Utils.ReadSon(myXmlLines, "AwayGoals"))
  '        myNewLine.LogoChannel = Utils.ReadSon(myXmlLines, "LogoChannel")
  '        myNewLine.MatchStatus = Utils.ReadSon(myXmlLines, "MatchStatus")
  '        myNewHeader.Lines.Add(myNewLine)
  '      Next
  '      GlobalHeaders.Add(myNewHeader)
  '      OMSelectedHeader.Items.Add(myNewHeader)
  '    Next
  '    CreateEmptyOthers()
  '  Catch err As Exception
  '    MessageBox.Show("LoadOthers ERROR:" + err.Message)
  '  End Try
  'End Sub

#End Region
End Class
