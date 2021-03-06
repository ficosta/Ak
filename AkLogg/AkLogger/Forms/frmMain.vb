﻿
Imports System.Collections
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports System.Configuration
Imports System.Net
Imports System.Net.Sockets
Imports System.Threading
Imports AkLogger
Imports MatchInfo

Partial Public Class frmMain
  Inherits Form
  Private SocketThead As System.Threading.Thread

#Region "Globals Variables"
  Private Shared YCard As String = String.Empty
  Private Shared RCard As String = String.Empty

  Private WithEvents _match As Match = MatchHelper.Instance.Match

  Private WithEvents _matchHomeTeam As Team
  Private WithEvents _matchAwayTeam As Team

  'Local team Stast
  Shared HomePlayers As Players, AwayPlayers As Players
  'Local players data order by position
  Private Enum PossessionType
    OutS
    Home
    Away
  End Enum
  Private Enum PossessionWhereTypes
    OwnField
    MidField
    Attack
  End Enum

  Private MainSec As Integer
  ' Seconds Total in the App
  Private GlobalMatch As Match
  ' Match
  Private _possessionWhere As PossessionWhereTypes = PossessionWhereTypes.MidField
  Private Property PossessionWhere As PossessionWhereTypes
    Get
      Return _possessionWhere
    End Get
    Set(value As PossessionWhereTypes)
      _possessionWhere = value
      UpdatePossessionWhereLabels()
    End Set
  End Property
  ' Actual position of the Possession
  Private PossessionHome1st As Integer, PossessionAway1st As Integer
  'Segundos de Posesion Parte 1
  Private PossessionHome2nd As Integer, PossessionAway2nd As Integer
  'Segundos de Posesion Parte 2

  'Indica si el balon está en juego
  Private _outOfPlay As Boolean = False
  Private Property OutOfPlay As Boolean
    Get
      Return _outOfPlay
    End Get
    Set(value As Boolean)
      _outOfPlay = value
      UpdatePossessionLabels()
    End Set
  End Property

  ' True is Home. False: Away
  Private _possessionIsHome As Boolean = True
  Private Property PossessionIsHome As Boolean
    Get
      Return _possessionIsHome
    End Get
    Set(value As Boolean)
      _possessionIsHome = value
      UpdatePossessionLabels()
    End Set
  End Property


  Private bClosing As Boolean = False

  Private bControlPress As Boolean
  ' Indicate if the Control is pressed
  Private LastPossession As New ArrayList()

  ''' <summary>
  ''' Indicate if the type of drag element 
  ''' </summary>
#End Region

  Private Shared socWorker As New System.Collections.ArrayList()
  'Socket del Cliente que se ha conectado
  Private Delegate Sub SetTextCallback(Visible As Boolean)
  Public Shared allDone As New ManualResetEvent(False)

  Private form1 As frmMain

  Public Class StateObject
    ' Client  socket.
    Public workSocket As Socket = Nothing
    ' Size of receive buffer.
    Public Const BufferSize As Integer = 1024
    ' Receive buffer.
    Public buffer As Byte() = New Byte(BufferSize - 1) {}
    ' Received data string.
    Public sb As New StringBuilder()
  End Class

  Public Sub New()
    InitializeComponent()
    Me.Text = My.Application.Info.AssemblyName & " " & My.Application.Info.Version.ToString
    form1 = Me

  End Sub


  Private Sub Reset()
    'If Me.InvokeRequired Then
    '  Me.Invoke(New MethodInvoker(AddressOf Reset))
    'Else

    Try
      'Clock & Possession
      tmrRefresh.Enabled = False
      tmrClock.Enabled = False
      txtClock.Text = "00:00"

      MainSec = 0
      AppSettings.Instance.LastMatchId = 0
      AppSettings.Instance.Save()

      OutOfPlay = True
      PossessionHome1st = 0
      PossessionAway1st = 0
      PossessionHome2nd = 0
      PossessionAway2nd = 0
      txtPossessionHomeOwnT.Text = "0"
      txtPossessionHomeMidF.Text = "0"
      txtPossessionHomeAttk.Text = "0"
      txtPossessionAwayOwnT.Text = "0"
      txtPossessionAwayMidF.Text = "0"
      txtPossessionAwayAttk.Text = "0"

      _match = New Match
      MatchHelper.Instance.Match = _match

      _match.HomeTeam = New Team
      _match.HomeTeam.TeamAELCaption1Name = "Home team"
      _match.HomeTeam.MatchPlayers = New Players(19)
      Me.TeamControlHome.Team = _match.HomeTeam
      _matchHomeTeam = _match.HomeTeam

      _match.AwayTeam = New Team
      _match.AwayTeam.TeamAELCaption1Name = "Away team"
      _match.AwayTeam.MatchPlayers = New Players(19)
      _matchAwayTeam = _match.AwayTeam
      Me.TeamControlAway.Team = _match.AwayTeam


      ''Reset Players
      'For i As Integer = 1 To 18
      '  Dim myHomePlayer As Player = DirectCast(DirectCast(grpHomePlayers.Controls.Find("HomePlayer" & i, True)(0), Label).Tag, Player)
      '  If myHomePlayer Is Nothing Then
      '    myHomePlayer = New Player()
      '    DirectCast(grpHomePlayers.Controls.Find("HomePlayer" & i, True)(0), Label).Tag = myHomePlayer
      '  Else
      '    myHomePlayer.MatchStats.Saves.Value = 0
      '    myHomePlayer.MatchStats.Shots.Value = 0
      '    myHomePlayer.MatchStats.ShotsOn.Value = 0
      '    myHomePlayer.MatchStats.Assis.Value = 0
      '    myHomePlayer.MatchStats.Fouls.Value = 0
      '    myHomePlayer.YellowCards = 0
      '    myHomePlayer.RedCards = 0
      '  End If
      '  ProcessPlayerLine(i, True)

      '  Dim myAwayPlayer As Player = DirectCast(DirectCast(grpAwayPlayers.Controls.Find("AwayPlayer" & i, True)(0), Label).Tag, Player)
      '  If myAwayPlayer Is Nothing Then
      '    myAwayPlayer = New Player()
      '    DirectCast(grpAwayPlayers.Controls.Find("AwayPlayer" & i, True)(0), Label).Tag = myAwayPlayer
      '  Else
      '    myAwayPlayer.MatchStats.Saves.Value = 0
      '    myAwayPlayer.MatchStats.Shots.Value = 0
      '    myAwayPlayer.MatchStats.ShotsOn.Value = 0
      '    myAwayPlayer.MatchStats.Assis.Value = 0
      '    myAwayPlayer.MatchStats.Fouls.Value = 0
      '    myAwayPlayer.YellowCards = 0
      '    myAwayPlayer.RedCards = 0
      '  End If
      '  ProcessPlayerLine(i, False)
      'Next

      ''Reset Teams
      'HomeTeam = New Team()
      'lblSavesHomeTot.Text = HomeTeam.MatchStats.Saves.ToString()
      'lblShotsHomeTot.Text = HomeTeam.MatchStats.Shots.ToString()
      'lblShtGlHomeTot.Text = HomeTeam.MatchStats.ShotsOn.ToString()
      'lblAssisHomeTot.Text = HomeTeam.MatchStats.Assis.ToString()
      'lblFoulsHomeTot.Text = HomeTeam.MatchStats.Fouls.ToString()
      'lblYCardHomeTot.Text = HomeTeam.MatchStats.YellowCards.ToString()
      'lblRCardHomeTot.Text = HomeTeam.MatchStats.RedCards.ToString()
      'lblCornersHome.Text = HomeTeam.MatchStats.Corners.ToString()
      'lblOffsidesHome.Text = HomeTeam.MatchStats.Offsides.ToString()
      'lblWoodHitsHome.Text = HomeTeam.MatchStats.WoodHits.ToString()
      'lblPossession1stHome.Text = HomeTeam.MatchStats.Possession1st.ToString()
      'lblPossession2ndHome.Text = HomeTeam.MatchStats.Possession2nd.ToString()
      'lblPossessionMatchHome.Text = HomeTeam.MatchStats.PossessionMatch.ToString()
      'lblPossessionLast10Home.Text = HomeTeam.MatchStats.PossessionLast10.ToString()
      'lblPossessionLast5Home.Text = HomeTeam.MatchStats.PossessionLast5.ToString()
      'lblPossessionHomeOwnF.Text = HomeTeam.MatchStats.PossessionOwn.ToString()
      'lblPossessionHomeMidF.Text = HomeTeam.MatchStats.PossessionMid.ToString()
      'lblPossessionHomeAttk.Text = HomeTeam.MatchStats.PossessionAttack.ToString()

      'AwayTeam = New Team()
      'lblSavesAwayTot.Text = AwayTeam.MatchStats.Saves.ToString()
      'lblShotsAwayTot.Text = AwayTeam.MatchStats.Shots.ToString()
      'lblShtGlAwayTot.Text = AwayTeam.MatchStats.ShotsOn.ToString()
      'lblAssisAwayTot.Text = AwayTeam.MatchStats.Assis.ToString()
      'lblFoulsAwayTot.Text = AwayTeam.MatchStats.Fouls.ToString()
      'lblYCardAwayTot.Text = AwayTeam.MatchStats.YellowCards.ToString()
      'lblRCardAwayTot.Text = AwayTeam.MatchStats.RedCards.ToString()
      'lblCornersAway.Text = AwayTeam.MatchStats.Corners.ToString()
      'lblOffsidesAway.Text = AwayTeam.MatchStats.Offsides.ToString()
      'lblWoodHitsAway.Text = AwayTeam.MatchStats.WoodHits.ToString()
      'lblPossession1stAway.Text = AwayTeam.MatchStats.Possession1st.ToString()
      'lblPossession2ndAway.Text = AwayTeam.MatchStats.Possession2nd.ToString()
      'lblPossessionMatchAway.Text = AwayTeam.MatchStats.PossessionMatch.ToString()
      'lblPossessionLast10Away.Text = AwayTeam.MatchStats.PossessionLast10.ToString()
      'lblPossessionLast5Away.Text = AwayTeam.MatchStats.PossessionLast5.ToString()
      'lblPossessionAwayOwnF.Text = AwayTeam.MatchStats.PossessionOwn.ToString()
      'lblPossessionAwayMidF.Text = AwayTeam.MatchStats.PossessionMid.ToString()
      'lblPossessionAwayAttk.Text = AwayTeam.MatchStats.PossessionAttack.ToString()

      'For i As Integer = lsvEvents.Items.Count - 1 To 0 Step -1
      '  lsvEvents.Items.RemoveAt(i)
      'Next


      bControlPress = False

      PossessionWhere = PossessionWhereTypes.MidField

      LastPossession.Clear()
    Catch err As Exception
      MessageBox.Show("ERROR Reset. " & err.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.[Error])
    End Try
    'End If
  End Sub

  Private Sub UpdatePossessionLabels()
    'TODO GELO
    Dim coloBackOn As Color = Color.DarkGreen
    Dim coloFrontOn As Color = Color.White

    If (_outOfPlay) Then
      lblOutOfPlay.BackColor = Color.LawnGreen
      lblOutOfPlay.ForeColor = Color.Black
      coloBackOn = Color.DarkGreen
      coloFrontOn = Color.White
    Else
      lblOutOfPlay.BackColor = Color.Black
      lblOutOfPlay.ForeColor = Color.White
      coloBackOn = Color.LawnGreen
      coloFrontOn = Color.Black
    End If

    If PossessionIsHome Then
      'lblHomeTeam1.BackColor = colorOn
      lblHomeTeam2.BackColor = coloBackOn
      lblHomeTeam3.BackColor = coloBackOn
      'lblHomeTeam1.ForeColor = coloFrontOn
      lblHomeTeam2.ForeColor = coloFrontOn
      lblHomeTeam3.ForeColor = coloFrontOn
      'lblAwayTeam1.BackColor = Color.Black
      lblAwayTeam2.BackColor = Color.Black
      lblAwayTeam3.BackColor = Color.Black
      'lblAwayTeam1.ForeColor = Color.White
      lblAwayTeam2.ForeColor = Color.White
      lblAwayTeam3.ForeColor = Color.White
    Else
      'lblHomeTeam1.BackColor = Color.Black
      lblHomeTeam2.BackColor = Color.Black
      lblHomeTeam3.BackColor = Color.Black
      'lblHomeTeam1.ForeColor = Color.White
      lblHomeTeam2.ForeColor = Color.White
      lblHomeTeam3.ForeColor = Color.White

      'lblAwayTeam1.BackColor = colorOn
      lblAwayTeam2.BackColor = coloBackOn
      lblAwayTeam3.BackColor = coloBackOn
      'lblAwayTeam1.ForeColor = coloFrontOn
      lblAwayTeam2.ForeColor = coloFrontOn
      lblAwayTeam3.ForeColor = coloFrontOn
    End If
  End Sub

  Private Sub lblHomeTeam_Click(sender As Object, e As EventArgs)
    PossessionIsHome = True
    UpdatePossessionLabels()
  End Sub

  Private Sub lblAwayTeam_Click(sender As Object, e As EventArgs)
    PossessionIsHome = False
    UpdatePossessionLabels()
  End Sub

  Private Sub AddPossession(Value As PossessionType)
    If LastPossession.Count >= 600 Then
      LastPossession.RemoveAt(0)
    End If
    LastPossession.Add(Value)
  End Sub

  Private Sub ShowPossessions()
    Dim nTotal As Integer, nHome As Integer, nAway As Integer, nField As Integer = 0, nFieldTot As Integer = 0

    'Own Field
    nHome = Utils.Val(txtPossessionHomeOwnT.Text)
    nAway = Utils.Val(txtPossessionAwayOwnT.Text)
    nTotal = nHome + nAway
    If nTotal = 0 Then
      lblPossessionHomeOwnF.Text = "50%"
      lblPossessionAwayOwnF.Text = "50%"
    Else
      _match.HomeTeam.MatchStats.PossessionOwn.Value = CInt((nHome * 100) / nTotal)
      _match.AwayTeam.MatchStats.PossessionOwn.Value = 100 - _match.HomeTeam.MatchStats.PossessionOwn.Value

      lblPossessionHomeOwnF.Text = _match.HomeTeam.MatchStats.PossessionOwn.ToString() & "%"
      lblPossessionAwayOwnF.Text = _match.AwayTeam.MatchStats.PossessionOwn.ToString() & "%"
      nField = nHome
      nFieldTot = nTotal
    End If

    ' Mid Field
    nHome = Utils.Val(txtPossessionHomeMidF.Text)
    nAway = Utils.Val(txtPossessionAwayMidF.Text)
    nTotal = nHome + nAway
    If nTotal = 0 Then
      lblPossessionHomeMidF.Text = "50%"
      lblPossessionAwayMidF.Text = "50%"
    Else
      _match.HomeTeam.MatchStats.PossessionMid.Value = CInt((nHome * 100) / nTotal)
      _match.AwayTeam.MatchStats.PossessionMid.Value = 100 - _match.HomeTeam.MatchStats.PossessionMid.Value

      lblPossessionHomeMidF.Text = _match.HomeTeam.MatchStats.PossessionMid.ToString() & "%"
      lblPossessionAwayMidF.Text = _match.AwayTeam.MatchStats.PossessionMid.ToString() & "%"
      nField += nHome
      nFieldTot += nTotal
    End If

    ' Attack
    nHome = Utils.Val(txtPossessionHomeAttk.Text)
    nAway = Utils.Val(txtPossessionAwayAttk.Text)
    nTotal = nHome + nAway
    If nTotal = 0 Then
      lblPossessionHomeAttk.Text = "50%"
      lblPossessionAwayAttk.Text = "50%"
    Else
      _match.HomeTeam.MatchStats.PossessionAttack.Value = CInt((nHome * 100) / nTotal)
      _match.AwayTeam.MatchStats.PossessionAttack.Value = 100 - _match.HomeTeam.MatchStats.PossessionAttack.Value

      lblPossessionHomeAttk.Text = _match.HomeTeam.MatchStats.PossessionAttack.ToString() & "%"
      lblPossessionAwayAttk.Text = _match.AwayTeam.MatchStats.PossessionAttack.ToString() & "%"
      nField += nHome
      nFieldTot += nTotal
    End If

    'Total
    If nField = 0 Then
      lblPossessionMatchHome.Text = "50%"
      lblPossessionMatchAway.Text = "50%"
    Else
      _match.HomeTeam.MatchStats.PossessionMatch.Value = CInt((nField * 100) / nFieldTot)
      _match.AwayTeam.MatchStats.PossessionMatch.Value = 100 - _match.HomeTeam.MatchStats.PossessionMatch.Value

      lblPossessionMatchHome.Text = _match.HomeTeam.MatchStats.PossessionMatch.ToString() & "%"
      lblPossessionMatchAway.Text = _match.AwayTeam.MatchStats.PossessionMatch.ToString() & "%"
    End If

    'Last 5 minutes
    Dim n5Minutes As Integer = 0
    nTotal = 0
    nHome = 0
    nAway = 0
    For Each Value As PossessionType In LastPossession
      If Value <> PossessionType.OutS Then
        nTotal += 1
        If Value = PossessionType.Home Then
          nHome += 1
        Else
          nAway += 1
        End If
      End If
      n5Minutes += 1
      If n5Minutes = 300 Then
        ' Last 5 Minutes
        If nTotal = 0 Then
          _match.HomeTeam.MatchStats.PossessionLast5.Value = 50

          _match.AwayTeam.MatchStats.PossessionLast5.Value = 100 - _match.HomeTeam.MatchStats.PossessionLast5.Value
        Else
          _match.HomeTeam.MatchStats.PossessionLast5.Value = CInt((nHome * 100) / nTotal)
          _match.AwayTeam.MatchStats.PossessionLast5.Value = 100 - _match.HomeTeam.MatchStats.PossessionLast5.Value
        End If

        lblPossessionLast5Home.Text = _match.HomeTeam.MatchStats.PossessionLast5.ToString() & "%"
        lblPossessionLast5Away.Text = _match.AwayTeam.MatchStats.PossessionLast5.ToString() & "%"
      End If
    Next


    ' Last 10 minutes
    If nTotal = 0 Then
      lblPossessionLast5Home.Text = "50%"
      lblPossessionLast5Away.Text = "50%"
      lblPossessionLast10Home.Text = "50%"
      lblPossessionLast10Away.Text = "50%"
    Else
      If n5Minutes < 300 Then
        _match.HomeTeam.MatchStats.PossessionLast5.Value = CInt((nHome * 100) / nTotal)
        _match.AwayTeam.MatchStats.PossessionLast5.Value = 100 - _match.HomeTeam.MatchStats.PossessionLast5.Value

        lblPossessionLast5Home.Text = _match.HomeTeam.MatchStats.PossessionLast5.ToString() & "%"
        lblPossessionLast5Away.Text = _match.AwayTeam.MatchStats.PossessionLast5.ToString() & "%"
      End If
      _match.HomeTeam.MatchStats.PossessionLast10.Value = CInt((nHome * 100) / nTotal)
      _match.AwayTeam.MatchStats.PossessionLast10.Value = 100 - _match.HomeTeam.MatchStats.PossessionLast10.Value

      lblPossessionLast10Home.Text = _match.HomeTeam.MatchStats.PossessionLast10.ToString() & "%"
      lblPossessionLast10Away.Text = _match.AwayTeam.MatchStats.PossessionLast10.ToString() & "%"
    End If

    'Halfs
    nTotal = PossessionHome1st + PossessionAway1st
    If nTotal = 0 Then
      lblPossession1stHome.Text = "50%"
      lblPossession1stAway.Text = "50%"
    Else
      _match.HomeTeam.MatchStats.Possession1st.Value = CInt((PossessionHome1st * 100) / nTotal)
      _match.AwayTeam.MatchStats.Possession1st.Value = 100 - _match.HomeTeam.MatchStats.Possession1st.Value

      lblPossession1stHome.Text = _match.HomeTeam.MatchStats.Possession1st.ToString() & "%"
      lblPossession1stAway.Text = _match.AwayTeam.MatchStats.Possession1st.ToString() & "%"
    End If

    nTotal = PossessionHome2nd + PossessionAway2nd
    If nTotal = 0 Then
      lblPossession2ndHome.Text = "50%"
      lblPossession2ndAway.Text = "50%"
    Else
      _match.HomeTeam.MatchStats.Possession2nd.Value = CInt((PossessionHome2nd * 100) / nTotal)
      _match.AwayTeam.MatchStats.Possession2nd.Value = 100 - _match.HomeTeam.MatchStats.Possession2nd.Value

      lblPossession2ndHome.Text = _match.HomeTeam.MatchStats.Possession2nd.ToString() & "%"
      lblPossession2ndAway.Text = _match.AwayTeam.MatchStats.Possession2nd.ToString() & "%"
    End If
  End Sub

  Private Sub ShowEvents()
    Try
      Me.MetroGridEvents.Rows.Clear()

      For Each myEvent As MatchEvent In _match.MatchEvents
        Me.AddEvent(myEvent)
      Next
    Catch ex As Exception

    End Try
  End Sub


  Private Sub AddEvent(myEvent As MatchEvent)
    Try
      If _match Is Nothing Then Exit Sub

      Dim localTeam As Boolean = (myEvent.TeamID = _match.HomeTeam.TeamID)
      Dim playerName As String = ""
      If Not _match.GetPlayerById(myEvent.PlayerID) Is Nothing Then
        playerName = _match.GetPlayerById(myEvent.PlayerID).ToString
      End If
      If Not _match.GetPlayerById(myEvent.PlayerSecID) Is Nothing Then
        playerName = playerName & " for " & _match.GetPlayerById(myEvent.PlayerSecID).ToString
      End If
      Me.AddEvent(myEvent, localTeam, playerName)
    Catch ex As Exception

    End Try
  End Sub

  Private Sub AddEvent(myEvent As MatchEvent, LocalTeam As Boolean, EventPlayer As String)
    Try

      'Dim item As Integer = Me.MetroGridEvents.Rows.Add(myEvent.EventID.ToString)
      Dim item As Integer = 0
      Me.MetroGridEvents.Rows.Insert(0, 1)
      Me.MetroGridEvents.Rows(item).Cells(ColumnID.Index).Value = myEvent.EventID
      Dim TextToAdd As String = myEvent.EventType
      If myEvent.EventType = "RCARD" Then
        TextToAdd = "RED CARD"
      ElseIf myEvent.EventType = "YCARD" Then
        TextToAdd = "YELLOW CARD"
      ElseIf myEvent.EventType = "SHTGL" Then
        TextToAdd = "SHOT ON TARGET"
      End If
      Me.MetroGridEvents.Rows(item).Cells(ColumnType.Index).Value = TextToAdd

      Dim strText As String
      If LocalTeam Then
        strText = _match.HomeTeam.Name ' lblHomeTeam1.Text
      Else
        strText = _match.AwayTeam.Name 'lblAwayTeam1.Text
      End If

      If EventPlayer <> "" Then
        strText &= Convert.ToString(" player ") & EventPlayer
      End If
      Me.MetroGridEvents.Rows(item).Cells(ColumnPlayer.Index).Value = strText
      Me.MetroGridEvents.Rows(item).Cells(ColumnTime.Index).Value = myEvent.TimeSecond \ 60 & ":" & Strings.Format(myEvent.TimeSecond Mod 60, "00")

      Me.MetroGridEvents.Rows(item).Cells(ColumnImage.Index).Value = Me.imglstEvents.Images(myEvent.EventType.ToUpper)

    Catch ex As Exception
      WriteToErrorLog(ex)
    End Try
  End Sub

  Private Sub MainForm_KeyDown(sender As Object, e As KeyEventArgs)
    bControlPress = e.Control

    'Check the shortcuts
    If AppSettings.Instance.UseDefaultShortcuts Then
      If e.KeyCode = Keys.Q Then
        If OutOfPlay Then
          lblOutOfPlay_Click(Nothing, Nothing)
        End If
        lblHomeTeam_Click(Nothing, Nothing)
        lblPossessionOwnT_Click(Nothing, Nothing)
      End If
      If e.KeyCode = Keys.W Then
        If OutOfPlay Then
          lblOutOfPlay_Click(Nothing, Nothing)
        End If
        lblHomeTeam_Click(Nothing, Nothing)
        lblPossessionMidF_Click(Nothing, Nothing)
      End If
      If e.KeyCode = Keys.E Then
        If OutOfPlay Then
          lblOutOfPlay_Click(Nothing, Nothing)
        End If
        lblHomeTeam_Click(Nothing, Nothing)
        lblPossessionAttk_Click(Nothing, Nothing)
      End If
      If e.KeyCode = Keys.A Then
        If OutOfPlay Then
          lblOutOfPlay_Click(Nothing, Nothing)
        End If
        lblAwayTeam_Click(Nothing, Nothing)
        lblPossessionOwnT_Click(Nothing, Nothing)
      End If
      If e.KeyCode = Keys.S Then
        If OutOfPlay Then
          lblOutOfPlay_Click(Nothing, Nothing)
        End If
        lblAwayTeam_Click(Nothing, Nothing)
        lblPossessionMidF_Click(Nothing, Nothing)
      End If
      If e.KeyCode = Keys.D Then
        If OutOfPlay Then
          lblOutOfPlay_Click(Nothing, Nothing)
        End If
        lblAwayTeam_Click(Nothing, Nothing)
        lblPossessionAttk_Click(Nothing, Nothing)
      End If
      If e.KeyCode = Keys.Z Then
        If Not OutOfPlay Then
          lblOutOfPlay_Click(Nothing, Nothing)
        End If
      End If
    Else
      Try
      Catch err As Exception
        MessageBox.Show("Err:" & err.Message)
      End Try
    End If
  End Sub

  Private Sub MainForm_KeyUp(sender As Object, e As KeyEventArgs)
    bControlPress = e.Control
  End Sub

  Private Sub tmrRefresh_Tick(sender As Object, e As EventArgs) Handles tmrRefresh.Tick
    ShowPossessions()
  End Sub

  Private Sub txtGetKey_Key(sender As Object, e As KeyEventArgs)

  End Sub

  Private Sub btnClockReset_Click(sender As Object, e As EventArgs)

  End Sub

  Private Sub btnSaveConfig_Click(sender As Object, e As EventArgs)

  End Sub

  Private Sub lblCornersHome_Click(sender As Object, e As EventArgs)

  End Sub

  Private Sub lblOffsidesHome_Click(sender As Object, e As EventArgs)

  End Sub

  Private Sub lblWoodHitsHome_Click(sender As Object, e As EventArgs)

  End Sub

  Private Sub lblCornersAway_Click(sender As Object, e As EventArgs)

  End Sub

  Private Sub lblOffsidesAway_Click(sender As Object, e As EventArgs)

  End Sub

  Private Sub lblWoodHitsAway_Click(sender As Object, e As EventArgs)

  End Sub


  Private Sub SetHomePlayers(data As String)
    'Dim values As String() = data.Split("|"c)
    'Dim x As Integer = 3
    'HomeTeam = New Team()
    'HomeTeam.TeamID = Utils.Val(values(1).ToString())

    'lblHomeTeam1.Tag = HomeTeam.TeamID
    'lblHomeTeam1.Text = values(2)
    'lblHomeTeam1.Tag = HomeTeam.TeamID
    'lblHomeTeam1.Text = values(2)
    'lblHomeTeam1.Tag = HomeTeam.TeamID
    'lblHomeTeam1.Text = values(2)

    'For i As Integer = 0 To 17
    '  HomePlayers(i) = New Player()
    '  HomePlayers(i).PlayerID = Utils.Val(values(x).ToString())
    '  HomePlayers(i).PlayerUniqueName = values(x + 1).ToString()

    '  Dim player As Label = DirectCast(Me.grpHomePlayers.Controls.Find("HomePlayer" & (i + 1).ToString(), True)(0), Label)
    '  player.Text = values(x + 1)
    '  Dim myPlayerStat As New Player(Utils.Val(values(x))) ', GlobalMatch.match_id)
    '  player.Tag = myPlayerStat
    '  x += 2
    'Next
  End Sub

  Private Delegate Sub SetMatchInvoker(ByVal text As String)
  Private Sub SetMatchInvoke(data As String)
    If Me.InvokeRequired Then
      Me.Invoke(New SetMatchInvoker(AddressOf SetMatchInvoke), data)
    Else
      Dim values As String() = data.Split("|"c)
      Dim x As Integer = 1

      _match.match_id = Utils.Val(values(x).ToString())
      Me.LoadMatchFromDB(Utils.Val(values(x)))
      AppSettings.Instance.LastMatchId = _match.match_id
      AppSettings.Instance.Save()
    End If

  End Sub

  Private Delegate Sub SetHomePlayersInvoker(ByVal text As String)

  Private Sub SetHomePlayersInvoke(data As String)
    If Me.InvokeRequired Then
      'Me.GetType().GetMethod("SetHomePlayersInvoke").Invoke(Me, New String() {data})
      Me.Invoke(New SetHomePlayersInvoker(AddressOf SetHomePlayersInvoke), data)
    Else
      Dim x As Integer = 3
      Try
        Dim values As String() = data.Split("|"c)
        If _match.HomeTeam.TeamID <= 0 Then
          _match.HomeTeam = New Team()
          _match.HomeTeam.Match_ID = _match.match_id
          _match.HomeTeam.TeamID = Utils.Val(values(1).ToString())
          _match.HomeTeam.Name = values(2).ToString()
        End If

        If _match.HomeTeam.MatchPlayers.Count = 0 Then
          'match home playeres were empty! populate them!!
          _match.HomeTeam.MatchPlayers = New Players(19)
          _match.HomeTeam.CreateEmptyPlayers(19)

          x = 3
          For i As Integer = 0 To 17
            Dim player As Player = _match.HomeTeam.GetPlayerByPosicio(i + 1)
            If Not player Is Nothing And x < values.Length Then

              player.PlayerID = Utils.Val(values(x).ToString())
              player.Name = values(x + 1).ToString()
              player.PlayerUniqueName = values(x + 1).ToString()
              player.PlayerFirstName = values(x + 1).ToString()
              player.Match_ID = _match.match_id
            End If
            x += 2
          Next
        Else
          'we already had players... what shall we do?

        End If

        Me.TeamControlHome.Team = _match.HomeTeam

        Me.SingleStatControlHomeCorners.Init(_match.HomeTeam.MatchStats.Corners, _match.HomeTeam)
        Me.SingleStatControlHomeOffsides.Init(_match.HomeTeam.MatchStats.Offsides, _match.HomeTeam)
        Me.SingleStatControlHomeWood.Init(_match.HomeTeam.MatchStats.WoodHits, _match.HomeTeam)

        Me.lblHomeTeam2.Text = _match.HomeTeam.Name
        Me.lblHomeTeam3.Text = _match.HomeTeam.Name

      Catch ex As Exception

      End Try

    End If

  End Sub

  Private Delegate Sub SetAwayPlayersInvoker(ByVal text As String)
  Public Sub SetAwayPlayersInvoke(data As String)
    If Me.InvokeRequired Then

      'Me.GetType().GetMethod("SetAwayPlayersInvoke").Invoke(Me, New String() {data})
      Me.Invoke(New SetAwayPlayersInvoker(AddressOf SetAwayPlayersInvoke), data)
    Else
      Try
        Dim values As String() = data.Split("|"c)
        Dim x As Integer = 3

        If _match.AwayTeam.TeamID <= 0 Then
          _match.AwayTeam = New Team()
          _match.AwayTeam.Match_ID = _match.match_id
          _match.AwayTeam.TeamID = Utils.Val(values(1).ToString())
          _match.AwayTeam.Name = values(2).ToString()
        End If

        If _match.AwayTeam.MatchPlayers.Count = 0 Then

          _match.AwayTeam.MatchPlayers = New Players(19)
          _match.AwayTeam.CreateEmptyPlayers(19)

          x = 3
          For i As Integer = 0 To 17
            Dim player As Player = _match.AwayTeam.GetPlayerByPosicio(i + 1)
            If Not player Is Nothing And x < values.Length Then
              player.PlayerID = Utils.Val(values(x).ToString())
              player.Name = values(x + 1).ToString()
              player.PlayerUniqueName = values(x + 1).ToString()
              player.PlayerFirstName = values(x + 1).ToString()
              player.Match_ID = _match.match_id
            End If
            x += 2
          Next
          Me.TeamControlAway.Team = _match.AwayTeam
        Else

        End If


        Me.SingleStatControlAwayCorners.Init(_match.AwayTeam.MatchStats.Corners, _match.AwayTeam)
        Me.SingleStatControlAwayOffsides.Init(_match.AwayTeam.MatchStats.Offsides, _match.AwayTeam)
        Me.SingleStatControlAwayWood.Init(_match.AwayTeam.MatchStats.WoodHits, _match.AwayTeam)


        Me.lblAwayTeam2.Text = _match.AwayTeam.Name
        Me.lblAwayTeam3.Text = _match.AwayTeam.Name

      Catch ex As Exception

      End Try
    End If
  End Sub

  Private Sub ProcessPlayerLine(Line As Integer, Home As Boolean)
    'Dim myPlayer As New Player()
    'Dim HomeAway As String
    'If Home Then
    '  myPlayer = DirectCast(DirectCast(grpHomePlayers.Controls.Find("HomePlayer" & Line, True)(0), Label).Tag, Player)
    '  HomeAway = "Home"
    'Else
    '  myPlayer = DirectCast(DirectCast(grpAwayPlayers.Controls.Find("AwayPlayer" & Line, True)(0), Label).Tag, Player)
    '  HomeAway = "Away"
    'End If
    'DirectCast(grpData.Controls.Find((Convert.ToString("lblSaves") & HomeAway) & Line, True)(0), Label).Text = myPlayer.MatchStats.Saves.ToString()
    'DirectCast(grpData.Controls.Find((Convert.ToString("lblShots") & HomeAway) & Line, True)(0), Label).Text = myPlayer.MatchStats.Shots.ToString()
    'DirectCast(grpData.Controls.Find((Convert.ToString("lblShtGl") & HomeAway) & Line, True)(0), Label).Text = myPlayer.MatchStats.ShotsOn.ToString()
    'DirectCast(grpData.Controls.Find((Convert.ToString("lblAssis") & HomeAway) & Line, True)(0), Label).Text = myPlayer.MatchStats.Assis.ToString()
    'DirectCast(grpData.Controls.Find((Convert.ToString("lblFouls") & HomeAway) & Line, True)(0), Label).Text = myPlayer.MatchStats.Fouls.ToString()
    'DirectCast(grpData.Controls.Find((Convert.ToString("lblYCard") & HomeAway) & Line, True)(0), Label).Text = myPlayer.YellowCards.ToString()
    'DirectCast(grpData.Controls.Find((Convert.ToString("lblRCard") & HomeAway) & Line, True)(0), Label).Text = myPlayer.RedCards.ToString()
  End Sub

  Private Sub MainForm_FormClosing(sender As Object, e As FormClosingEventArgs)
    If MessageBox.Show("Are you sure you want to CLOSE the app?", My.Application.Info.AssemblyName, MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) = System.Windows.Forms.DialogResult.Yes Then
      'Save the data
      bClosing = True
      Try

        SocketThead.Abort()
      Catch ex As Exception
        MsgBox(ex.ToString)
      End Try
    End If
  End Sub

#Region "Socket Jorge"
  Public Sub StartListening()
    ' Data buffer for incoming data.
    Dim bytes As Byte() = New [Byte](1023) {}

    AppSettings.Instance.LoggerIP = "127.0.0.1"
    AppSettings.Instance.LoggerPort = 2525

    ' Establish the local endpoint for the socket.
    Dim IP As String = AppSettings.Instance.LoggerIP
    Dim ipAddress As System.Net.IPAddress = System.Net.IPAddress.Parse(IP)
    Dim localEndPoint As New IPEndPoint(ipAddress, AppSettings.Instance.LoggerPort)

    ' Create a TCP/IP socket.
    Dim listener As New Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp)

    ' Bind the socket to the local endpoint and listen for incoming connections.
    Try
      listener.Bind(localEndPoint)
      listener.Listen(100)

      While True
        ' Set the event to nonsignaled state.
        allDone.Reset()

        ' Start an asynchronous socket to listen for connections.
        listener.BeginAccept(New AsyncCallback(AddressOf AcceptCallback), listener)

        ' Wait until a connection is made before continuing.
        allDone.WaitOne()
      End While
    Catch e As Exception
      If Not bClosing Then
        WriteToErrorLog(e)
        'MessageBox.Show("ERROR creating the socket!. Please, check the local IP:" & AppSettings.Instance.LoggerIP & ". PORT:" & AppSettings.Instance.LoggerPort.ToString() & vbLf & vbLf & vbLf & e.Message, My.Application.Info.AssemblyName, MessageBoxButtons.OK, MessageBoxIcon.[Error])
      End If
    End Try
  End Sub

  Public Sub AcceptCallback(ar As IAsyncResult)
    ' Signal the main thread to continue.
    allDone.[Set]()

    ' Get the socket that handles the client request.
    Dim listener As Socket = DirectCast(ar.AsyncState, Socket)
    Dim handler As Socket = listener.EndAccept(ar)

    ' Create the state object.
    Dim state As New StateObject()
    state.workSocket = handler
    handler.BeginReceive(state.buffer, 0, StateObject.BufferSize, 0, New AsyncCallback(AddressOf ReadCallback), state)
  End Sub

  Public Sub ReadCallback(ar As IAsyncResult)
    Dim content As [String] = [String].Empty

    ' Retrieve the state object and the handler socket
    ' from the asynchronous state object.
    Dim state As StateObject = DirectCast(ar.AsyncState, StateObject)
    Dim handler As Socket = state.workSocket

    ' Read data from the client socket. 
    Dim bytesRead As Integer = handler.EndReceive(ar)

    If bytesRead > 0 Then
      ' There  might be more data, so store the data received so far.
      state.sb.Append(Encoding.ASCII.GetString(state.buffer, 0, bytesRead))

      ' Check for end-of-file tag. If it is not there, read 
      ' more data.
      content = state.sb.ToString()

      If content.Equals("START") Then
        Send(handler, "STARTED")
      ElseIf content.Contains("|") Then
        treatArray(handler, content)
      Else
        Send(handler, "Empty")
      End If
    End If
  End Sub

  Private Sub treatArray(handler As Socket, data As String)
    Try
      If data.StartsWith("MATCH") Then
        Send(handler, "OK")
        SetMatchInvoke(data)
        GlobalProperties.Instance.HomePlayers = data
      ElseIf data.StartsWith("HOMETEAM") Then
        Send(handler, "OK")
        SetHomePlayersInvoke(data)
        GlobalProperties.Instance.HomePlayers = data
      ElseIf data.StartsWith("AWAYTEAM") Then
        Send(handler, "OK")
        SetAwayPlayersInvoke(data)
        GlobalProperties.Instance.AwayPlayers = data
      ElseIf data.StartsWith("TEAMSTATSHOME") Then
        Dim statsHome As String
        statsHome = _match.HomeTeam.MatchStats.ToSocketFormat()
        Send(handler, statsHome)
      ElseIf data.StartsWith("TEAMSTATSAWAY") Then
        Dim statsAway As String
        statsAway = _match.AwayTeam.MatchStats.ToSocketFormat()
        Send(handler, statsAway)
      ElseIf data.StartsWith("PLAYERSTAT") Then
        Dim playerID As String = (data.Split("|"c)(1))
        Dim player As Player = _match.GetPlayerById(Utils.Val(playerID))
        Dim playerString As String = ""
        If Not player Is Nothing Then
          playerString = player.ToSocketFormat
        End If
        'If HomePlayers.GetPlayer(Utils.Val(data.Split("|"c)(1).ToString())) IsNot Nothing Then
        '  player = HomePlayers.GetPlayer(Utils.Val(data.Split("|"c)(1).ToString())).ToSocketFormat()
        'Else
        '  player = AwayPlayers.GetPlayer(Utils.Val(data.Split("|"c)(1).ToString())).ToSocketFormat()
        'End If
        Send(handler, playerString)
      ElseIf data.StartsWith("SMALSTATS") Then
        Dim smallstats As String
        smallstats = _match.HomeTeam.MatchStats.PossessionMatch.ToString() & "|"
        smallstats &= _match.AwayTeam.MatchStats.PossessionMatch.ToString() & "|"

        smallstats &= _match.HomeTeam.MatchStats.Fouls.ToString() & "|"
        smallstats &= _match.AwayTeam.MatchStats.Fouls.ToString() & "|"
        smallstats &= _match.HomeTeam.MatchStats.ShotsOn.ToString() & "|"
        smallstats &= _match.AwayTeam.MatchStats.ShotsOn.ToString() & "|"
        smallstats &= _match.HomeTeam.MatchStats.Corners.ToString() & "|"
        smallstats &= _match.AwayTeam.MatchStats.Corners.ToString() & "|"
        smallstats &= _match.HomeTeam.MatchStats.Offsides.ToString() & "|"
        smallstats &= _match.AwayTeam.MatchStats.Offsides.ToString() & "|"
        smallstats &= _match.HomeTeam.MatchStats.WoodHits.ToString() & "|"
        smallstats &= _match.AwayTeam.MatchStats.WoodHits.ToString() & "|"
        smallstats &= _match.HomeTeam.MatchStats.Shots.ToString() & "|"
        smallstats &= _match.AwayTeam.MatchStats.Shots.ToString() & "|"
        smallstats &= _match.HomeTeam.MatchStats.Assis.ToString() & "|"
        smallstats &= _match.AwayTeam.MatchStats.Assis.ToString()
        If Not String.IsNullOrEmpty(YCard) Then
          smallstats &= YCard
        End If
        If Not String.IsNullOrEmpty(RCard) Then
          smallstats &= RCard
        End If

        YCard = String.Empty
        RCard = String.Empty

        'PosesionHome|Poseeionaway|FoulsHome|FoulsAway|Shots.. corners.. offsides..woodhits
        Send(handler, smallstats)
      ElseIf data.StartsWith("SUBS") Then
        Send(handler, "OK")
        'TODO GELO
        'Dim homeAway As String = data.Split("|"c)(1)
        'Dim idPlayerIn As Integer = Utils.Val(data.Split("|"c)(3).ToString())
        'Dim idPlayerOut As Integer = Utils.Val(data.Split("|"c)(2).ToString())
        'Dim labelIdPlayerIn As String
        'Dim labelIdPlayerOut As String
        'Dim myPlayerIn As Player
        'Dim myPlayerOut As Player
        'Dim myPlayer As Player
        'If homeAway = "HOME" Then
        '  myPlayerIn = HomePlayers.GetPlayer(idPlayerIn)
        '  myPlayerOut = HomePlayers.GetPlayer(idPlayerOut)
        '  labelIdPlayerIn = findLabelPlayer(grpHomePlayers.Controls, idPlayerIn)
        '  labelIdPlayerOut = findLabelPlayer(grpHomePlayers.Controls, idPlayerOut)
        '  setPlayerText(myPlayerIn, myPlayerOut, labelIdPlayerIn, labelIdPlayerOut, "Home")

        '  myPlayer = myPlayerIn
        '  myPlayerIn.Copy(myPlayerOut)
        '  myPlayerOut.Copy(myPlayer)
        'Else
        '  myPlayerIn = AwayPlayers.GetPlayer(idPlayerIn)
        '  myPlayerOut = AwayPlayers.GetPlayer(idPlayerOut)
        '  labelIdPlayerIn = findLabelPlayer(grpAwayPlayers.Controls, idPlayerIn)
        '  labelIdPlayerOut = findLabelPlayer(grpAwayPlayers.Controls, idPlayerOut)
        '  setPlayerText(myPlayerIn, myPlayerOut, labelIdPlayerIn, labelIdPlayerOut, "Away")

        '  myPlayer = myPlayerIn
        '  myPlayerIn.Copy(myPlayerOut)
        '  myPlayerOut.Copy(myPlayer)
        'End If
      ElseIf data.StartsWith("RESET") Then
        Send(handler, "OK")
        Reset()
      Else
        Send(handler, "Empty")
      End If

    Catch ex As Exception
      Debug.Print(ex.ToString)
    End Try

  End Sub


  Private Sub setPlayerText(myPlayerIn As Player, myPlayerOut As Player, labelIdPlayerIn As String, labelIdPlayerOut As String, homeAway As String)
    'TODO GELO
    'If homeAway = "Home" Then
    '  Invoke(New Action(Function() InlineAssignHelper(DirectCast(grpHomePlayers.Controls.Find(Convert.ToString("HomePlayer") & labelIdPlayerIn, True)(0), Label).Text, myPlayerOut.PlayerName)))
    '  Invoke(New Action(Function() InlineAssignHelper(DirectCast(grpHomePlayers.Controls.Find(Convert.ToString("HomePlayer") & labelIdPlayerIn, True)(0), Label).Tag, myPlayerOut.PlayerID)))
    '  Invoke(New Action(Function() InlineAssignHelper(DirectCast(Controls.Find(Convert.ToString("lblSavesHome") & labelIdPlayerIn, True)(0), Label).Text, myPlayerOut.MatchStats.Saves.ToString())))
    '  Invoke(New Action(Function() InlineAssignHelper(DirectCast(Controls.Find(Convert.ToString("lblShotsHome") & labelIdPlayerIn, True)(0), Label).Text, myPlayerOut.MatchStats.Shots.ToString())))
    '  Invoke(New Action(Function() InlineAssignHelper(DirectCast(Controls.Find(Convert.ToString("lblShtGlHome") & labelIdPlayerIn, True)(0), Label).Text, myPlayerOut.MatchStats.ShotsOn.ToString())))
    '  Invoke(New Action(Function() InlineAssignHelper(DirectCast(Controls.Find(Convert.ToString("lblFoulsHome") & labelIdPlayerIn, True)(0), Label).Text, myPlayerOut.MatchStats.Fouls.ToString())))
    '  Invoke(New Action(Function() InlineAssignHelper(DirectCast(Controls.Find(Convert.ToString("lblYCardHome") & labelIdPlayerIn, True)(0), Label).Text, myPlayerOut.MatchStats.YellowCards.ToString())))
    '  Invoke(New Action(Function() InlineAssignHelper(DirectCast(Controls.Find(Convert.ToString("lblRCardHome") & labelIdPlayerIn, True)(0), Label).Text, myPlayerOut.MatchStats.RedCards.ToString())))
    '  Invoke(New Action(Function() InlineAssignHelper(DirectCast(Controls.Find(Convert.ToString("lblAssisHome") & labelIdPlayerIn, True)(0), Label).Text, myPlayerOut.MatchStats.Assis.ToString())))

    '  Invoke(New Action(Function() InlineAssignHelper(DirectCast(grpHomePlayers.Controls.Find(Convert.ToString("HomePlayer") & labelIdPlayerOut, True)(0), Label).Text, myPlayerIn.PlayerName)))
    '  Invoke(New Action(Function() InlineAssignHelper(DirectCast(grpHomePlayers.Controls.Find(Convert.ToString("HomePlayer") & labelIdPlayerOut, True)(0), Label).Tag, myPlayerIn.PlayerID)))
    '  Invoke(New Action(Function() InlineAssignHelper(DirectCast(Controls.Find(Convert.ToString("lblSavesHome") & labelIdPlayerOut, True)(0), Label).Text, myPlayerIn.MatchStats.Saves.ToString())))
    '  Invoke(New Action(Function() InlineAssignHelper(DirectCast(Controls.Find(Convert.ToString("lblShotsHome") & labelIdPlayerOut, True)(0), Label).Text, myPlayerIn.MatchStats.Shots.ToString())))
    '  Invoke(New Action(Function() InlineAssignHelper(DirectCast(Controls.Find(Convert.ToString("lblShtGlHome") & labelIdPlayerOut, True)(0), Label).Text, myPlayerIn.MatchStats.ShotsOn.ToString())))
    '  Invoke(New Action(Function() InlineAssignHelper(DirectCast(Controls.Find(Convert.ToString("lblFoulsHome") & labelIdPlayerOut, True)(0), Label).Text, myPlayerIn.MatchStats.Fouls.ToString())))
    '  Invoke(New Action(Function() InlineAssignHelper(DirectCast(Controls.Find(Convert.ToString("lblYCardHome") & labelIdPlayerOut, True)(0), Label).Text, myPlayerIn.MatchStats.YellowCards.ToString())))
    '  Invoke(New Action(Function() InlineAssignHelper(DirectCast(Controls.Find(Convert.ToString("lblRCardHome") & labelIdPlayerOut, True)(0), Label).Text, myPlayerIn.MatchStats.RedCards.ToString())))
    '  Invoke(New Action(Function() InlineAssignHelper(DirectCast(Controls.Find(Convert.ToString("lblAssisHome") & labelIdPlayerOut, True)(0), Label).Text, myPlayerIn.MatchStats.Assis.ToString())))
    'Else
    '  Invoke(New Action(Function() InlineAssignHelper(DirectCast(grpAwayPlayers.Controls.Find(Convert.ToString("AwayPlayer") & labelIdPlayerIn, True)(0), Label).Text, myPlayerOut.PlayerName)))
    '  Invoke(New Action(Function() InlineAssignHelper(DirectCast(grpAwayPlayers.Controls.Find(Convert.ToString("AwayPlayer") & labelIdPlayerIn, True)(0), Label).Tag, myPlayerOut.PlayerID)))
    '  Invoke(New Action(Function() InlineAssignHelper(DirectCast(Controls.Find(Convert.ToString("lblSavesAway") & labelIdPlayerIn, True)(0), Label).Text, myPlayerOut.MatchStats.Saves.ToString())))
    '  Invoke(New Action(Function() InlineAssignHelper(DirectCast(Controls.Find(Convert.ToString("lblShotsAway") & labelIdPlayerIn, True)(0), Label).Text, myPlayerOut.MatchStats.Shots.ToString())))
    '  Invoke(New Action(Function() InlineAssignHelper(DirectCast(Controls.Find(Convert.ToString("lblShtGlAway") & labelIdPlayerIn, True)(0), Label).Text, myPlayerOut.MatchStats.ShotsOn.ToString())))
    '  Invoke(New Action(Function() InlineAssignHelper(DirectCast(Controls.Find(Convert.ToString("lblFoulsAway") & labelIdPlayerIn, True)(0), Label).Text, myPlayerOut.MatchStats.Fouls.ToString())))
    '  Invoke(New Action(Function() InlineAssignHelper(DirectCast(Controls.Find(Convert.ToString("lblYCardAway") & labelIdPlayerIn, True)(0), Label).Text, myPlayerOut.MatchStats.YellowCards.ToString())))
    '  Invoke(New Action(Function() InlineAssignHelper(DirectCast(Controls.Find(Convert.ToString("lblRCardAway") & labelIdPlayerIn, True)(0), Label).Text, myPlayerOut.MatchStats.RedCards.ToString())))
    '  Invoke(New Action(Function() InlineAssignHelper(DirectCast(Controls.Find(Convert.ToString("lblAssisAway") & labelIdPlayerIn, True)(0), Label).Text, myPlayerOut.MatchStats.Assis.ToString())))

    '  Invoke(New Action(Function() InlineAssignHelper(DirectCast(Controls.Find(Convert.ToString("AwayPlayer") & labelIdPlayerOut, True)(0), Label).Text, myPlayerIn.PlayerName)))
    '  Invoke(New Action(Function() InlineAssignHelper(DirectCast(Controls.Find(Convert.ToString("AwayPlayer") & labelIdPlayerOut, True)(0), Label).Tag, myPlayerIn.PlayerID)))
    '  Invoke(New Action(Function() InlineAssignHelper(DirectCast(Controls.Find(Convert.ToString("lblSavesAway") & labelIdPlayerOut, True)(0), Label).Text, myPlayerIn.MatchStats.Saves.ToString())))
    '  Invoke(New Action(Function() InlineAssignHelper(DirectCast(Controls.Find(Convert.ToString("lblShotsAway") & labelIdPlayerOut, True)(0), Label).Text, myPlayerIn.MatchStats.Shots.ToString())))
    '  Invoke(New Action(Function() InlineAssignHelper(DirectCast(Controls.Find(Convert.ToString("lblShtGlAway") & labelIdPlayerOut, True)(0), Label).Text, myPlayerIn.MatchStats.ShotsOn.ToString())))
    '  Invoke(New Action(Function() InlineAssignHelper(DirectCast(Controls.Find(Convert.ToString("lblFoulsAway") & labelIdPlayerOut, True)(0), Label).Text, myPlayerIn.MatchStats.Fouls.ToString())))
    '  Invoke(New Action(Function() InlineAssignHelper(DirectCast(Controls.Find(Convert.ToString("lblYCardAway") & labelIdPlayerOut, True)(0), Label).Text, myPlayerIn.MatchStats.YellowCards.ToString())))
    '  Invoke(New Action(Function() InlineAssignHelper(DirectCast(Controls.Find(Convert.ToString("lblRCardAway") & labelIdPlayerOut, True)(0), Label).Text, myPlayerIn.MatchStats.RedCards.ToString())))
    '  Invoke(New Action(Function() InlineAssignHelper(DirectCast(Controls.Find(Convert.ToString("lblAssisAway") & labelIdPlayerOut, True)(0), Label).Text, myPlayerIn.MatchStats.Assis.ToString())))
    'End If
  End Sub

  Private Function findLabelPlayer(controls As Control.ControlCollection, idPlayer As Integer) As String
    For Each ctrl As Control In controls
      If ctrl.Tag.Equals(idPlayer) OrElse DirectCast(ctrl.Tag, Player).PlayerID = idPlayer Then
        If ctrl.Name.Length = 12 Then

          Return ctrl.Name.Substring(ctrl.Name.Length - 2).ToString()
        Else
          Return ctrl.Name(ctrl.Name.Length - 1).ToString()
        End If
      End If
    Next
    Return "0"
  End Function

  Private Sub Send(handler As Socket, data As [String])
    ' Convert the string data to byte data using ASCII encoding.
    Dim byteData As Byte() = Encoding.ASCII.GetBytes(data)

    ' Begin sending the data to the remote device.
    handler.BeginSend(byteData, 0, byteData.Length, 0, New AsyncCallback(AddressOf SendCallback), handler)

    ' lblSocket.Text = "SEND: " & data;
  End Sub

  Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    PrepareEvents()
  End Sub

  Private Sub PrepareEvents()
    Try
      Try
        Dim ctl() As Control
        For i As Integer = 1 To 18
          'TODO GELO
          'ctl = grpData.Controls.Find("lblAssisHome" & i, True) : AddHandler ctl(0).Click, AddressOf Me.lblStat_Click
          'ctl = grpData.Controls.Find("lblAssisAway" & i, True) : AddHandler ctl(0).Click, AddressOf Me.lblStat_Click
          'ctl = grpData.Controls.Find("lblShotsHome" & i, True) : AddHandler ctl(0).Click, AddressOf Me.lblStat_Click
          'ctl = grpData.Controls.Find("lblShotsAway" & i, True) : AddHandler ctl(0).Click, AddressOf Me.lblStat_Click
        Next
      Catch ex As Exception

      End Try
    Catch ex As Exception

    End Try
  End Sub

  Private Sub SendCallback(ar As IAsyncResult)
    Try
      ' Retrieve the socket from the state object.
      Dim handler As Socket = DirectCast(ar.AsyncState, Socket)

      ' Complete sending the data to the remote device.
      Dim bytesSent As Integer = handler.EndSend(ar)

      handler.Shutdown(SocketShutdown.Both)

      handler.Close()
      ' ERROR 
    Catch e As Exception
    End Try
  End Sub

#End Region

  Private Sub btnOverwriteClock_Click(sender As Object, e As EventArgs)

  End Sub
  Private Shared Function InlineAssignHelper(Of T)(ByRef target As T, value As T) As T
    target = value
    Return value
  End Function

  Private Sub frmMain_Shown(sender As Object, e As EventArgs) Handles Me.Shown
    Try
      Me.LabelAppVersion.Text = "v " & My.Application.Info.Version.Major & "." & My.Application.Info.Version.Minor & "." & My.Application.Info.Version.Build & "   "

      ShowOptions(Me)

      GlobalMatch = MatchHelper.Instance.Match

      HomePlayers = New Players()
      AwayPlayers = New Players()


      If AppSettings.Instance.LastMatchId > 0 Then
        'TODO GELO
        If MessageBox.Show("The last match the app was working was MatchID:" & AppSettings.Instance.LastMatchId.ToString() & vbLf & "Do you want to reload it?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Information) = System.Windows.Forms.DialogResult.Yes Then
          LoadMatchFromDB(AppSettings.Instance.LastMatchId)
        End If
      Else
        'Init the values
        HomePlayers = New Players(19)
        AwayPlayers = New Players(19)

        Reset()
      End If

      'Start Socket Server
      SocketThead = New Thread(New ThreadStart(AddressOf StartListening))


      SocketThead.Start()
    Catch err As Exception
      'Log("ERROR: MainForm " & err.Message)
    End Try
  End Sub

  Private Sub LoadMatchFromDB(match_id As Integer)
    Try
      _match = New Match
      MatchHelper.Instance.Match = _match
      _match.match_id = match_id
      _match.GetMatch()
      _match.HomeTeam.GetFullMatchData()
      _match.AwayTeam.GetFullMatchData()

      _match.GetMatchEventsFromDB()
      _match.GetMatchGoalsFromDB()

      Me.TeamControlHome.Team = _match.HomeTeam
      Me._matchHomeTeam = _match.HomeTeam
      Me.TeamControlAway.Team = _match.AwayTeam
      Me._matchAwayTeam = _match.AwayTeam

      Me.SingleStatControlHomeCorners.Init(_match.HomeTeam.MatchStats.Corners, _match.HomeTeam)
      Me.SingleStatControlHomeOffsides.Init(_match.HomeTeam.MatchStats.Offsides, _match.HomeTeam)
      Me.SingleStatControlHomeWood.Init(_match.HomeTeam.MatchStats.WoodHits, _match.HomeTeam)

      Me.lblHomeTeam2.Text = _match.HomeTeam.Name
      Me.lblHomeTeam3.Text = _match.HomeTeam.Name

      Me.SingleStatControlAwayCorners.Init(_match.AwayTeam.MatchStats.Corners, _match.AwayTeam)
      Me.SingleStatControlAwayOffsides.Init(_match.AwayTeam.MatchStats.Offsides, _match.AwayTeam)
      Me.SingleStatControlAwayWood.Init(_match.AwayTeam.MatchStats.WoodHits, _match.AwayTeam)

      Me.lblAwayTeam2.Text = _match.AwayTeam.Name
      Me.lblAwayTeam3.Text = _match.AwayTeam.Name

      Me.ShowEvents()




      '  'We should get the Match ID!
      '  GlobalMatch.match_id = 1

      '  'Teams & Player Names
      '  SetHomePlayers(GlobalProperties.Instance.HomePlayers)
      '  SetAwayPlayers(GlobalProperties.Instance.AwayPlayers)

      '  'Teams Data
      '  HomeTeam = New Team()
      '  HomeTeam.GetFromSocketFormat(GlobalProperties.Instance.HomeTeam)
      '  lblSavesHomeTot.Text = HomeTeam.MatchStats.Saves.ToString()
      '  lblShotsHomeTot.Text = HomeTeam.MatchStats.Shots.ToString()
      '  lblShtGlHomeTot.Text = HomeTeam.MatchStats.ShotsOn.ToString()
      '  lblAssisHomeTot.Text = HomeTeam.MatchStats.Assis.ToString()
      '  lblFoulsHomeTot.Text = HomeTeam.MatchStats.Fouls.ToString()
      '  lblYCardHomeTot.Text = HomeTeam.MatchStats.YellowCards.ToString()
      '  lblRCardHomeTot.Text = HomeTeam.MatchStats.RedCards.ToString()
      '  lblCornersHome.Text = HomeTeam.MatchStats.Corners.ToString()
      '  lblOffsidesHome.Text = HomeTeam.MatchStats.Offsides.ToString()
      '  lblWoodHitsHome.Text = HomeTeam.MatchStats.WoodHits.ToString()
      '  lblPossession1stHome.Text = HomeTeam.MatchStats.Possession1st.ToString()
      '  lblPossession2ndHome.Text = HomeTeam.MatchStats.Possession2nd.ToString()
      '  lblPossessionMatchHome.Text = HomeTeam.MatchStats.PossessionMatch.ToString()

      '  AwayTeam = New Team()
      '  AwayTeam.GetFromSocketFormat(GlobalProperties.Instance.AwayTeam)
      '  lblSavesAwayTot.Text = AwayTeam.MatchStats.Saves.ToString()
      '  lblShotsAwayTot.Text = AwayTeam.MatchStats.Shots.ToString()
      '  lblShtGlAwayTot.Text = AwayTeam.MatchStats.ShotsOn.ToString()
      '  lblAssisAwayTot.Text = AwayTeam.MatchStats.Assis.ToString()
      '  lblFoulsAwayTot.Text = AwayTeam.MatchStats.Fouls.ToString()
      '  lblYCardAwayTot.Text = AwayTeam.MatchStats.YellowCards.ToString()
      '  lblRCardAwayTot.Text = AwayTeam.MatchStats.RedCards.ToString()
      '  lblCornersAway.Text = AwayTeam.MatchStats.Corners.ToString()
      '  lblOffsidesAway.Text = AwayTeam.MatchStats.Offsides.ToString()
      '  lblWoodHitsAway.Text = AwayTeam.MatchStats.WoodHits.ToString()
      '  lblPossession1stAway.Text = AwayTeam.MatchStats.Possession1st.ToString()
      '  lblPossession2ndAway.Text = AwayTeam.MatchStats.Possession2nd.ToString()
      '  lblPossessionMatchAway.Text = AwayTeam.MatchStats.PossessionMatch.ToString()

      '  For i As Integer = 1 To 18
      '    Dim myHomePlayer As New Player()
      '    myHomePlayer.GetFromSocketFormat(GlobalProperties.Instance.Player("TeamHomePlayer" & i.ToString()).ToString())
      '    DirectCast(grpHomePlayers.Controls.Find("HomePlayer" & i, True)(0), Label).Tag = myHomePlayer
      '    ProcessPlayerLine(i, True)

      '    Dim myAwayPlayer As New Player()
      '    myAwayPlayer.GetFromSocketFormat(GlobalProperties.Instance.Player("TeamAwayPlayer" & i.ToString()).ToString())
      '    DirectCast(grpAwayPlayers.Controls.Find("AwayPlayer" & i, True)(0), Label).Tag = myAwayPlayer
      '    ProcessPlayerLine(i, False)
      '  Next

      '  'Possession Data
      '  Dim PossessionString As String() = GlobalProperties.Instance.Possession.Split("|"c)
      '  If PossessionString.Length = 10 Then
      '    PossessionHome1st = Utils.Val(PossessionString(0))
      '    PossessionAway1st = Utils.Val(PossessionString(1))
      '    PossessionHome2nd = Utils.Val(PossessionString(2))
      '    PossessionAway2nd = Utils.Val(PossessionString(3))
      '    txtPossessionHomeOwnT.Text = PossessionString(4)
      '    txtPossessionHomeMidF.Text = PossessionString(5)
      '    txtPossessionHomeAttk.Text = PossessionString(6)
      '    txtPossessionAwayOwnT.Text = PossessionString(7)
      '    txtPossessionAwayMidF.Text = PossessionString(8)
      '    txtPossessionAwayAttk.Text = PossessionString(9)
      '  End If

      '  If AppSettings.Instance.LastMatchId > 0 Then
      '    Dim ClockInit As New DateTime(AppSettings.Instance.LastMatchId)
      '    Dim ClockNow As TimeSpan = DateTime.Now.Subtract(ClockInit)
      '    If ClockNow.Hours = 0 Then
      '      txtClock.Text = ClockNow.Minutes.ToString() & ":" & Utils.TwoChars(ClockNow.Seconds)
      '    End If
      '  End If
    Catch ex As Exception
      WriteToErrorLog(ex)
    End Try
  End Sub


#Region "Team stat events"
  Private Sub SingleStatControlHome_AddEvent(sender As SingleStatControl) Handles SingleStatControlHomeCorners.AddEvent, SingleStatControlHomeOffsides.AddEvent, SingleStatControlHomeWood.AddEvent
    Try
      _match.AddEvent(sender.Stat.Name, _match.HomeTeam.TeamID, 0, 0, 0)
    Catch ex As Exception
    End Try
  End Sub

  Private Sub SingleStatControlHomeCorners_Load(sender As Object, e As EventArgs)

  End Sub

  Private Sub SingleStatControlHomeCorners_RemoveEvent(sender As SingleStatControl) Handles SingleStatControlHomeCorners.RemoveEvent
    Try
      '  _match.RemoveEvent(sender.Stat.Name, _match.HomeTeam.TeamID, 0, 0, 0)
    Catch ex As Exception
    End Try
  End Sub

  Private Sub SingleStatControlAway_AddEvent(sender As SingleStatControl) Handles SingleStatControlAwayCorners.AddEvent, SingleStatControlAwayOffsides.AddEvent, SingleStatControlAwayWood.AddEvent
    Try
      _match.AddEvent(sender.Stat.Name, _match.AwayTeam.TeamID, 0, 0, 0)
    Catch ex As Exception
    End Try
  End Sub

  Private Sub SingleStatControlAwayCorners_RemoveEvent(sender As SingleStatControl) Handles SingleStatControlAwayCorners.RemoveEvent
    Try
      '  _match.RemoveEvent(sender.Stat.Name, _match.AwayTeam.TeamID, 0, 0, 0)
    Catch ex As Exception
    End Try
  End Sub


#End Region

#Region "Possession"

  Private Sub lblHomeTeam_MouseClick(sender As Object, e As MouseEventArgs) Handles lblHomeTeam2.Click, lblHomeTeam3.Click
    OutOfPlay = False
    PossessionIsHome = True
    UpdatePossessionLabels()
  End Sub

  Private Sub lblAwayTeam_MouseClick(sender As Object, e As MouseEventArgs) Handles lblAwayTeam2.Click, lblAwayTeam3.Click
    OutOfPlay = False
    PossessionIsHome = False
    UpdatePossessionLabels()
  End Sub


  Private Sub lblOutOfPlay_Click(sender As Object, e As EventArgs) Handles lblOutOfPlay.Click
    OutOfPlay = Not OutOfPlay

  End Sub

#End Region

#Region "Clock control"
  Private _selectedIndex As Integer

  Private Sub StartClock_Click(sender As Object, e As EventArgs) Handles StartClock.Click
    Try

      tmrClock.Enabled = False
      tmrRefresh.Enabled = False

      Dim timeToStart As Integer = 0
      If rdb1stHalf.Checked Then
        timeToStart = 0 * 60
        _selectedIndex = 0
      End If
      If rdb2ndHalf.Checked Then
        timeToStart = 45 * 60
        _selectedIndex = 1
      End If
      If rdbExtra1.Checked Then
        timeToStart = 90 * 60
        _selectedIndex = 2
      End If
      If rdbExtra2.Checked Then
        timeToStart = 105 * 60
        _selectedIndex = 3
      End If

      OutOfPlay = True

      MainSec = timeToStart

      txtClock.Text = Utils.Secs2MMSS(MainSec)

      tmrClock.Interval = 1000
      AppSettings.Instance.ClockStart = DateTime.Now.Ticks
      tmrClock.Enabled = True
      tmrRefresh.Enabled = True


      _match.MatchPeriods.StartPeriod(_match.MatchPeriods(_selectedIndex), 0)
    Catch ex As Exception
      WriteToErrorLog(ex)
    End Try

  End Sub


  Private Sub StopClock_Click(sender As Object, e As EventArgs) Handles StopClock.Click
    tmrClock.Enabled = False
    tmrRefresh.Enabled = False
    txtClock.Text = Utils.Secs2MMSS(MainSec)
  End Sub


  Private Sub tmrClock_Tick(sender As Object, e As EventArgs) Handles tmrClock.Tick
    'Set the clock
    MainSec += 1
    txtClock.Text = Utils.Secs2MMSS(MainSec)

    'Set the Possession
    If OutOfPlay Then
      AddPossession(PossessionType.OutS)
    ElseIf PossessionIsHome Then
      AddPossession(PossessionType.Home)
      If PossessionWhere = PossessionWhereTypes.OwnField Then
        txtPossessionHomeOwnT.Text = (Utils.Val(txtPossessionHomeOwnT.Text) + 1).ToString()
      ElseIf PossessionWhere = PossessionWhereTypes.MidField Then
        txtPossessionHomeMidF.Text = (Utils.Val(txtPossessionHomeMidF.Text) + 1).ToString()
      ElseIf PossessionWhere = PossessionWhereTypes.Attack Then
        txtPossessionHomeAttk.Text = (Utils.Val(txtPossessionHomeAttk.Text) + 1).ToString()
      End If
      If rdb1stHalf.Checked Then
        PossessionHome1st += 1
      ElseIf rdb2ndHalf.Checked Then
        PossessionHome2nd += 1
      End If
    Else
      AddPossession(PossessionType.Away)
      If PossessionWhere = PossessionWhereTypes.OwnField Then
        txtPossessionAwayOwnT.Text = (Utils.Val(txtPossessionAwayOwnT.Text) + 1).ToString()
      ElseIf PossessionWhere = PossessionWhereTypes.MidField Then
        txtPossessionAwayMidF.Text = (Utils.Val(txtPossessionAwayMidF.Text) + 1).ToString()
      ElseIf PossessionWhere = PossessionWhereTypes.Attack Then
        txtPossessionAwayAttk.Text = (Utils.Val(txtPossessionAwayAttk.Text) + 1).ToString()
      End If
      If rdb1stHalf.Checked Then
        PossessionAway1st += 1
      ElseIf rdb2ndHalf.Checked Then
        PossessionAway2nd += 1
      End If
    End If
    UpdateClock()
    'Save the Possession
    GlobalProperties.Instance.Possession = PossessionHome1st.ToString() & "|" & PossessionAway1st.ToString() & "|" & PossessionHome2nd.ToString() & "|" & PossessionAway2nd.ToString() & "|" & txtPossessionHomeOwnT.Text & "|" & txtPossessionHomeMidF.Text & "|" & txtPossessionHomeAttk.Text & "|" & txtPossessionAwayOwnT.Text & "|" & txtPossessionAwayMidF.Text & "|" & txtPossessionAwayAttk.Text
  End Sub

  Private Sub UpdateClock()
    Try
      Dim labelColor As Color = Color.White
      Dim colorOn As Color = Color.LightGreen
      Dim colorOff As Color = Color.LightSalmon

      If _match Is Nothing Then Exit Sub
      If _match.MatchPeriods.ActivePeriod Is Nothing Then
        Me.MetroLabelPeriodTime.Text = "00:00"
        Me.MetroLabelPeriodName.Text = ""
        labelColor = colorOff
      Else
        Me.MetroLabelPeriodTime.Text = _match.MatchPeriods.TempsJocWithOffsetString
        Me.MetroLabelPeriodName.Text = _match.MatchPeriods.Nom

        Dim XX As New MetroFramework.Components.MetroStyleManager()

        If _match.MatchPeriods.ActivePeriod.PlayingTime > _match.MatchPeriods.ActivePeriod.TotalTime Then
          labelColor = colorOn
          XX.Theme = MetroFramework.MetroThemeStyle.Dark
          Me.MetroLabelPeriodTime.BackColor = Color.Red
          Me.MetroLabelPeriodTime.Invalidate()
        Else
          labelColor = colorOff
          XX.Theme = MetroFramework.MetroThemeStyle.Light

          Me.MetroLabelPeriodTime.BackColor = Color.Blue
        End If
      End If
      Me.MetroLabelPeriodTime.BackColor = labelColor
    Catch ex As Exception
      WriteToErrorLog(ex)
    End Try
  End Sub

  Private Sub SetSelectedPeriod(period As Integer)

    Dim timeToStart As Integer = 0
    Select Case period
      Case 0
        timeToStart = 0 * 60
        Exit Select
      Case 1
        timeToStart = 45 * 60
        Exit Select
      Case 2
        timeToStart = 90 * 60
        Exit Select
      Case 3
        timeToStart = 105 * 60
        Exit Select
    End Select
    rdb1stHalf.Checked = (period = 0)
    rdb2ndHalf.Checked = (period = 1)
    rdbExtra1.Checked = (period = 2)
    rdbExtra2.Checked = (period = 3)

    MainSec = timeToStart

    txtClock.Text = Utils.Secs2MMSS(MainSec)

  End Sub

  Private Sub lblHomeTeam_MouseClick(sender As Object, e As EventArgs) Handles lblHomeTeam3.Click, lblHomeTeam2.Click

  End Sub

  Private Sub UpdatePossessionWhereLabels()
    Try
      Dim colorOn As Color = Color.LawnGreen
      Dim colorOff As Color = Color.Gray

      lblPossessionOwnT.BackColor = IIf(PossessionWhere = PossessionWhereTypes.OwnField, colorOn, colorOff)
      lblPossessionAttk.BackColor = IIf(PossessionWhere = PossessionWhereTypes.Attack, colorOn, colorOff)
      lblPossessionMidF.BackColor = IIf(PossessionWhere = PossessionWhereTypes.MidField, colorOn, colorOff)
    Catch ex As Exception
      WriteToErrorLog(ex)
    End Try
  End Sub

  Private Sub lblPossessionOwnT_Click(sender As Object, e As EventArgs) Handles lblPossessionOwnT.Click
    PossessionWhere = PossessionWhereTypes.OwnField
  End Sub

  Private Sub lblPossessionMidF_Click(sender As Object, e As EventArgs) Handles lblPossessionMidF.Click
    PossessionWhere = PossessionWhereTypes.MidField
  End Sub

  Private Sub lblPossessionAttk_Click(sender As Object, e As EventArgs) Handles lblPossessionAttk.Click
    PossessionWhere = PossessionWhereTypes.Attack
  End Sub

  Private Sub btnClockReset_Click_1(sender As Object, e As EventArgs) Handles btnClockReset.Click
    Try
      If _match Is Nothing Then Exit Sub
      If _match.match_id = -1 Then Exit Sub

      If frmWaitForInput.ShowWaitDialog(Me, "Reset Match data?", _match.ToString, MessageBoxButtons.OKCancel, MessageBoxIcon.Hand) = DialogResult.Cancel Then Exit Sub

      _match.Reset()
      LoadMatchFromDB(_match.match_id)
    Catch ex As Exception

    End Try
  End Sub



#End Region

#Region "Events"

  Private Sub _match_EventCreated(myEvent As MatchEvent) Handles _match.EventCreated
    Try
      Me.AddEvent(myEvent)

    Catch ex As Exception

    End Try
  End Sub

  Private Sub _match_EventRemoved(myEvent As MatchEvent) Handles _match.EventRemoved

  End Sub

  Private Sub ToolStripButtonSettings_Click(sender As Object, e As EventArgs) Handles ToolStripButtonSettings.Click

    ShowOptions(Me)

  End Sub

  Private Sub btnOverwriteClock_Click_1(sender As Object, e As EventArgs) Handles btnOverwriteClock.Click

  End Sub

  Private Sub frmMain_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
    Try
      Me.SocketThead.Abort()
    Catch ex As Exception

    End Try
  End Sub

  Private Sub _matchAwayTeam_StatValueChanged(sender As StatSubject, stat As Stat) Handles _matchAwayTeam.StatValueChanged

  End Sub

  Private Sub _matchHomeTeam_StatValueChanged(sender As StatSubject, stat As Stat) Handles _matchHomeTeam.StatValueChanged

  End Sub

  Private Sub rdb1stHalf_Click(sender As Object, e As EventArgs) Handles rdb1stHalf.Click
    _selectedIndex = 0
    UpdateRadioButtons()
  End Sub

  Private Sub rdb2ndHalf_Click(sender As Object, e As EventArgs) Handles rdb2ndHalf.Click
    _selectedIndex = 1
    UpdateRadioButtons()
  End Sub

  Private Sub rdbExtra1_Click(sender As Object, e As EventArgs) Handles rdbExtra1.Click
    _selectedIndex = 2
    UpdateRadioButtons()
  End Sub

  Private Sub rdbExtra2_Click(sender As Object, e As EventArgs) Handles rdbExtra2.Click
    _selectedIndex = 3
    UpdateRadioButtons()
  End Sub

  Private Sub UpdateRadioButtons()
    Try
      rdb1stHalf.Checked = (_selectedIndex = 0)
      rdb2ndHalf.Checked = (_selectedIndex = 1)
      rdbExtra1.Checked = (_selectedIndex = 2)
      rdbExtra2.Checked = (_selectedIndex = 3)
    Catch ex As Exception

    End Try
  End Sub

#End Region
End Class
