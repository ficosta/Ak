
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
  Const Tittle As String = "Be In real Opta - Logger v 1.72.55"

#Region "Globals Variables"
  Private Shared YCard As String = String.Empty
  Private Shared RCard As String = String.Empty

  Shared HomeTeam As Team
  Shared AwayTeam As Team
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
  Private PosesionWhere As PossessionWhereTypes
  ' Actual position of the Possession
  Private PossessionHome1st As Integer, PossessionAway1st As Integer
  'Segundos de Posesion Parte 1
  Private PossessionHome2nd As Integer, PossessionAway2nd As Integer
  'Segundos de Posesion Parte 2
  Private OutOfPlay As Boolean
  'Indica si el balon está en juego
  Private PossessionIsHome As Boolean
  ' True is Home. False: Away
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
    Me.Text = Tittle
    form1 = Me
    Try
      GlobalMatch = New Match()

      HomePlayers = New Players()
      AwayPlayers = New Players()


      If AppSettings.Instance.ClockStart > 0 Then
        If MessageBox.Show("The last match the app was working was MatchID:" & AppSettings.Instance.ClockStart.ToString() + vbLf & "Do you want to reload it?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Information) = System.Windows.Forms.DialogResult.Yes Then
          'We should get the Match ID!
          GlobalMatch.match_id = 1

          'Teams & Player Names
          SetHomePlayers(GlobalProperties.Instance.HomePlayers)
          SetAwayPlayers(GlobalProperties.Instance.AwayPlayers)

          'Teams Data
          HomeTeam = New Team()
          HomeTeam.GetFromSocketFormat(GlobalProperties.Instance.HomeTeam)
          lblSavesHomeTot.Text = HomeTeam.MatchStats.Saves.ToString()
          lblShotsHomeTot.Text = HomeTeam.MatchStats.Shots.ToString()
          lblShtGlHomeTot.Text = HomeTeam.MatchStats.ShotsOn.ToString()
          lblAssisHomeTot.Text = HomeTeam.MatchStats.Assis.ToString()
          lblFoulsHomeTot.Text = HomeTeam.MatchStats.Fouls.ToString()
          lblYCardHomeTot.Text = HomeTeam.MatchStats.YellowCards.ToString()
          lblRCardHomeTot.Text = HomeTeam.MatchStats.RedCards.ToString()
          lblCornersHome.Text = HomeTeam.MatchStats.Corners.ToString()
          lblOffsidesHome.Text = HomeTeam.MatchStats.Offsides.ToString()
          lblWoodHitsHome.Text = HomeTeam.MatchStats.WoodHits.ToString()
          lblPossession1stHome.Text = HomeTeam.MatchStats.Possession1st.ToString()
          lblPossession2ndHome.Text = HomeTeam.MatchStats.Possession2nd.ToString()
          lblPossessionMatchHome.Text = HomeTeam.MatchStats.PossessionMatch.ToString()

          AwayTeam = New Team()
          AwayTeam.GetFromSocketFormat(GlobalProperties.Instance.AwayTeam)
          lblSavesAwayTot.Text = AwayTeam.MatchStats.Saves.ToString()
          lblShotsAwayTot.Text = AwayTeam.MatchStats.Shots.ToString()
          lblShtGlAwayTot.Text = AwayTeam.MatchStats.ShotsOn.ToString()
          lblAssisAwayTot.Text = AwayTeam.MatchStats.Assis.ToString()
          lblFoulsAwayTot.Text = AwayTeam.MatchStats.Fouls.ToString()
          lblYCardAwayTot.Text = AwayTeam.MatchStats.YellowCards.ToString()
          lblRCardAwayTot.Text = AwayTeam.MatchStats.RedCards.ToString()
          lblCornersAway.Text = AwayTeam.MatchStats.Corners.ToString()
          lblOffsidesAway.Text = AwayTeam.MatchStats.Offsides.ToString()
          lblWoodHitsAway.Text = AwayTeam.MatchStats.WoodHits.ToString()
          lblPossession1stAway.Text = AwayTeam.MatchStats.Possession1st.ToString()
          lblPossession2ndAway.Text = AwayTeam.MatchStats.Possession2nd.ToString()
          lblPossessionMatchAway.Text = AwayTeam.MatchStats.PossessionMatch.ToString()

          For i As Integer = 1 To 18
            Dim myHomePlayer As New Player()
            myHomePlayer.GetFromSocketFormat(GlobalProperties.Instance.Player("TeamHomePlayer" & i.ToString()).ToString())
            DirectCast(grpHomePlayers.Controls.Find("HomePlayer" & i, True)(0), Label).Tag = myHomePlayer
            ProcessPlayerLine(i, True)

            Dim myAwayPlayer As New Player()
            myAwayPlayer.GetFromSocketFormat(GlobalProperties.Instance.Player("TeamAwayPlayer" & i.ToString()).ToString())
            DirectCast(grpAwayPlayers.Controls.Find("AwayPlayer" & i, True)(0), Label).Tag = myAwayPlayer
            ProcessPlayerLine(i, False)
          Next

          'Possession Data
          Dim PossessionString As String() = GlobalProperties.Instance.Possession.Split("|"c)
          If PossessionString.Length = 10 Then
            PossessionHome1st = Utils.Val(PossessionString(0))
            PossessionAway1st = Utils.Val(PossessionString(1))
            PossessionHome2nd = Utils.Val(PossessionString(2))
            PossessionAway2nd = Utils.Val(PossessionString(3))
            txtPossessionHomeOwnT.Text = PossessionString(4)
            txtPossessionHomeMidF.Text = PossessionString(5)
            txtPossessionHomeAttk.Text = PossessionString(6)
            txtPossessionAwayOwnT.Text = PossessionString(7)
            txtPossessionAwayMidF.Text = PossessionString(8)
            txtPossessionAwayAttk.Text = PossessionString(9)
          End If

          If AppSettings.Instance.ClockStart > 0 Then
            Dim ClockInit As New DateTime(AppSettings.Instance.ClockStart)
            Dim ClockNow As TimeSpan = DateTime.Now.Subtract(ClockInit)
            If ClockNow.Hours = 0 Then
              txtClock.Text = ClockNow.Minutes.ToString() & ":" & Utils.TwoChars(ClockNow.Seconds)
            End If
          End If
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
      Log("ERROR: MainForm " & err.Message)
    End Try
  End Sub


  Private Sub Reset()
    Try
      'Clock & Possession
      tmrRefresh.Enabled = False
      tmrClock.Enabled = False
      txtClock.Text = "00:00"

      MainSec = 0
      AppSettings.Instance.ClockStart = 0
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

      'Reset Players
      For i As Integer = 1 To 18
        Dim myHomePlayer As Player = DirectCast(DirectCast(grpHomePlayers.Controls.Find("HomePlayer" & i, True)(0), Label).Tag, Player)
        If myHomePlayer Is Nothing Then
          myHomePlayer = New Player()
          DirectCast(grpHomePlayers.Controls.Find("HomePlayer" & i, True)(0), Label).Tag = myHomePlayer
        Else
          myHomePlayer.MatchStats.Saves.Value = 0
          myHomePlayer.MatchStats.Shots.Value = 0
          myHomePlayer.MatchStats.ShotsOn.Value = 0
          myHomePlayer.MatchStats.Assis.Value = 0
          myHomePlayer.MatchStats.Fouls.Value = 0
          myHomePlayer.YellowCards = 0
          myHomePlayer.RedCards = 0
        End If
        ProcessPlayerLine(i, True)

        Dim myAwayPlayer As Player = DirectCast(DirectCast(grpAwayPlayers.Controls.Find("AwayPlayer" & i, True)(0), Label).Tag, Player)
        If myAwayPlayer Is Nothing Then
          myAwayPlayer = New Player()
          DirectCast(grpAwayPlayers.Controls.Find("AwayPlayer" & i, True)(0), Label).Tag = myAwayPlayer
        Else
          myAwayPlayer.MatchStats.Saves.Value = 0
          myAwayPlayer.MatchStats.Shots.Value = 0
          myAwayPlayer.MatchStats.ShotsOn.Value = 0
          myAwayPlayer.MatchStats.Assis.Value = 0
          myAwayPlayer.MatchStats.Fouls.Value = 0
          myAwayPlayer.YellowCards = 0
          myAwayPlayer.RedCards = 0
        End If
        ProcessPlayerLine(i, False)
      Next

      'Reset Teams
      HomeTeam = New Team()
      lblSavesHomeTot.Text = HomeTeam.MatchStats.Saves.ToString()
      lblShotsHomeTot.Text = HomeTeam.MatchStats.Shots.ToString()
      lblShtGlHomeTot.Text = HomeTeam.MatchStats.ShotsOn.ToString()
      lblAssisHomeTot.Text = HomeTeam.MatchStats.Assis.ToString()
      lblFoulsHomeTot.Text = HomeTeam.MatchStats.Fouls.ToString()
      lblYCardHomeTot.Text = HomeTeam.MatchStats.YellowCards.ToString()
      lblRCardHomeTot.Text = HomeTeam.MatchStats.RedCards.ToString()
      lblCornersHome.Text = HomeTeam.MatchStats.Corners.ToString()
      lblOffsidesHome.Text = HomeTeam.MatchStats.Offsides.ToString()
      lblWoodHitsHome.Text = HomeTeam.MatchStats.WoodHits.ToString()
      lblPossession1stHome.Text = HomeTeam.MatchStats.Possession1st.ToString()
      lblPossession2ndHome.Text = HomeTeam.MatchStats.Possession2nd.ToString()
      lblPossessionMatchHome.Text = HomeTeam.MatchStats.PossessionMatch.ToString()
      lblPossessionLast10Home.Text = HomeTeam.MatchStats.PossessionLast10.ToString()
      lblPossessionLast5Home.Text = HomeTeam.MatchStats.PossessionLast5.ToString()
      lblPossessionHomeOwnF.Text = HomeTeam.MatchStats.PossessionOwn.ToString()
      lblPossessionHomeMidF.Text = HomeTeam.MatchStats.PossessionMid.ToString()
      lblPossessionHomeAttk.Text = HomeTeam.MatchStats.PossessionAttack.ToString()

      AwayTeam = New Team()
      lblSavesAwayTot.Text = AwayTeam.MatchStats.Saves.ToString()
      lblShotsAwayTot.Text = AwayTeam.MatchStats.Shots.ToString()
      lblShtGlAwayTot.Text = AwayTeam.MatchStats.ShotsOn.ToString()
      lblAssisAwayTot.Text = AwayTeam.MatchStats.Assis.ToString()
      lblFoulsAwayTot.Text = AwayTeam.MatchStats.Fouls.ToString()
      lblYCardAwayTot.Text = AwayTeam.MatchStats.YellowCards.ToString()
      lblRCardAwayTot.Text = AwayTeam.MatchStats.RedCards.ToString()
      lblCornersAway.Text = AwayTeam.MatchStats.Corners.ToString()
      lblOffsidesAway.Text = AwayTeam.MatchStats.Offsides.ToString()
      lblWoodHitsAway.Text = AwayTeam.MatchStats.WoodHits.ToString()
      lblPossession1stAway.Text = AwayTeam.MatchStats.Possession1st.ToString()
      lblPossession2ndAway.Text = AwayTeam.MatchStats.Possession2nd.ToString()
      lblPossessionMatchAway.Text = AwayTeam.MatchStats.PossessionMatch.ToString()
      lblPossessionLast10Away.Text = AwayTeam.MatchStats.PossessionLast10.ToString()
      lblPossessionLast5Away.Text = AwayTeam.MatchStats.PossessionLast5.ToString()
      lblPossessionAwayOwnF.Text = AwayTeam.MatchStats.PossessionOwn.ToString()
      lblPossessionAwayMidF.Text = AwayTeam.MatchStats.PossessionMid.ToString()
      lblPossessionAwayAttk.Text = AwayTeam.MatchStats.PossessionAttack.ToString()

      For i As Integer = lsvEvents.Items.Count - 1 To 0 Step -1
        lsvEvents.Items.RemoveAt(i)
      Next


      bControlPress = False

      PosesionWhere = PossessionWhereTypes.MidField

      LastPossession.Clear()
    Catch err As Exception
      MessageBox.Show("ERROR Reset. " & err.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.[Error])
    End Try
  End Sub

  Private Sub Log(strLogLine As String)
    If Not bClosing Then
      lsvEvents.Items.Add(grpControls.Text)
      lsvEvents.Items(lsvEvents.Items.Count - 1).SubItems.Add(strLogLine)
      lsvEvents.Items(lsvEvents.Items.Count - 1).Selected = True

      MessageBox.Show(strLogLine)
    End If
  End Sub

#Region "Clock controls"
  Private Sub StartClock_Click(sender As Object, e As EventArgs)

  End Sub

  Private Sub tmrClock_Tick(sender As Object, e As EventArgs)
    'Set the clock
    MainSec += 1
    txtClock.Text = Utils.Secs2MMSS(MainSec)

    'Set the Possession
    If OutOfPlay Then
      AddPossession(PossessionType.OutS)
    ElseIf PossessionIsHome Then
      AddPossession(PossessionType.Home)
      If PosesionWhere = PossessionWhereTypes.OwnField Then
        txtPossessionHomeOwnT.Text = (Utils.Val(txtPossessionHomeOwnT.Text) + 1).ToString()
      ElseIf PosesionWhere = PossessionWhereTypes.MidField Then
        txtPossessionHomeMidF.Text = (Utils.Val(txtPossessionHomeMidF.Text) + 1).ToString()
      ElseIf PosesionWhere = PossessionWhereTypes.Attack Then
        txtPossessionHomeAttk.Text = (Utils.Val(txtPossessionHomeAttk.Text) + 1).ToString()
      End If
      If rdb1stHalf.Checked Then
        PossessionHome1st += 1
      ElseIf rdb2ndHalf.Checked Then
        PossessionHome2nd += 1
      End If
    Else
      AddPossession(PossessionType.Away)
      If PosesionWhere = PossessionWhereTypes.OwnField Then
        txtPossessionAwayOwnT.Text = (Utils.Val(txtPossessionAwayOwnT.Text) + 1).ToString()
      ElseIf PosesionWhere = PossessionWhereTypes.MidField Then
        txtPossessionAwayMidF.Text = (Utils.Val(txtPossessionAwayMidF.Text) + 1).ToString()
      ElseIf PosesionWhere = PossessionWhereTypes.Attack Then
        txtPossessionAwayAttk.Text = (Utils.Val(txtPossessionAwayAttk.Text) + 1).ToString()
      End If
      If rdb1stHalf.Checked Then
        PossessionAway1st += 1
      ElseIf rdb2ndHalf.Checked Then
        PossessionAway2nd += 1
      End If
    End If

    'Save the Possession
    GlobalProperties.Instance.Possession = PossessionHome1st.ToString() & "|" & PossessionAway1st.ToString() & "|" & PossessionHome2nd.ToString() & "|" & PossessionAway2nd.ToString() & "|" & txtPossessionHomeOwnT.Text & "|" & txtPossessionHomeMidF.Text & "|" & txtPossessionHomeAttk.Text & "|" & txtPossessionAwayOwnT.Text & "|" & txtPossessionAwayMidF.Text & "|" & txtPossessionAwayAttk.Text
  End Sub

  Private Sub StopClock_Click(sender As Object, e As EventArgs)

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


  Private Sub rdb1stHalf_Click(sender As Object, e As EventArgs)

  End Sub

  Private Sub rdb2ndHalf_Click(sender As Object, e As EventArgs)

  End Sub

  Private Sub rdbExtra1_Click(sender As Object, e As EventArgs)

  End Sub

  Private Sub rdbExtra2_Click(sender As Object, e As EventArgs)

  End Sub



#End Region

  Private Sub CheckPosesion()
    If PossessionIsHome Then
      lblHomeTeam1.BackColor = Color.LawnGreen
      lblHomeTeam2.BackColor = Color.LawnGreen
      lblHomeTeam3.BackColor = Color.LawnGreen
      lblHomeTeam1.ForeColor = Color.Black
      lblHomeTeam2.ForeColor = Color.Black
      lblHomeTeam3.ForeColor = Color.Black
      lblAwayTeam1.BackColor = Color.Black
      lblAwayTeam2.BackColor = Color.Black
      lblAwayTeam3.BackColor = Color.Black
      lblAwayTeam1.ForeColor = Color.White
      lblAwayTeam2.ForeColor = Color.White
      lblAwayTeam3.ForeColor = Color.White
    Else
      lblHomeTeam1.BackColor = Color.Black
      lblHomeTeam2.BackColor = Color.Black
      lblHomeTeam3.BackColor = Color.Black
      lblHomeTeam1.ForeColor = Color.White
      lblHomeTeam2.ForeColor = Color.White
      lblHomeTeam3.ForeColor = Color.White

      lblAwayTeam1.BackColor = Color.LawnGreen
      lblAwayTeam2.BackColor = Color.LawnGreen
      lblAwayTeam3.BackColor = Color.LawnGreen
      lblAwayTeam1.ForeColor = Color.Black
      lblAwayTeam2.ForeColor = Color.Black
      lblAwayTeam3.ForeColor = Color.Black
    End If
  End Sub

  Private Sub lblHomeTeam_Click(sender As Object, e As EventArgs)
    PossessionIsHome = True
    CheckPosesion()
  End Sub

  Private Sub lblAwayTeam_Click(sender As Object, e As EventArgs)
    PossessionIsHome = False
    CheckPosesion()
  End Sub

  Private Sub lblOutOfPlay_Click(sender As Object, e As EventArgs)

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
      HomeTeam.MatchStats.PossessionOwn.Value = (nHome * 100) / nTotal
      AwayTeam.MatchStats.PossessionOwn.Value = 100 - HomeTeam.MatchStats.PossessionOwn.Value

      lblPossessionHomeOwnF.Text = HomeTeam.MatchStats.PossessionOwn.ToString() & "%"
      lblPossessionAwayOwnF.Text = AwayTeam.MatchStats.PossessionOwn.ToString() & "%"
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
      HomeTeam.MatchStats.PossessionMid.Value = (nHome * 100) / nTotal
      AwayTeam.MatchStats.PossessionMid.Value = 100 - HomeTeam.MatchStats.PossessionMid.Value

      lblPossessionHomeMidF.Text = HomeTeam.MatchStats.PossessionMid.ToString() & "%"
      lblPossessionAwayMidF.Text = AwayTeam.MatchStats.PossessionMid.ToString() & "%"
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
      HomeTeam.MatchStats.PossessionAttack.Value = (nHome * 100) / nTotal
      AwayTeam.MatchStats.PossessionAttack.Value = 100 - HomeTeam.MatchStats.PossessionAttack.Value

      lblPossessionHomeAttk.Text = HomeTeam.MatchStats.PossessionAttack.ToString() & "%"
      lblPossessionAwayAttk.Text = AwayTeam.MatchStats.PossessionAttack.ToString() & "%"
      nField += nHome
      nFieldTot += nTotal
    End If

    'Total
    If nField = 0 Then
      lblPossessionMatchHome.Text = "50%"
      lblPossessionMatchAway.Text = "50%"
    Else
      HomeTeam.MatchStats.PossessionMatch.Value = (nField * 100) / nFieldTot
      AwayTeam.MatchStats.PossessionMatch.Value = 100 - HomeTeam.MatchStats.PossessionMatch.Value

      lblPossessionMatchHome.Text = HomeTeam.MatchStats.PossessionMatch.ToString() & "%"
      lblPossessionMatchAway.Text = AwayTeam.MatchStats.PossessionMatch.ToString() & "%"
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
          HomeTeam.MatchStats.PossessionLast5.Value = 50

          AwayTeam.MatchStats.PossessionLast5.Value = 100 - HomeTeam.MatchStats.PossessionLast5.Value
        Else
          HomeTeam.MatchStats.PossessionLast5.Value = (nHome * 100) / nTotal
          AwayTeam.MatchStats.PossessionLast5.Value = 100 - HomeTeam.MatchStats.PossessionLast5.Value
        End If

        lblPossessionLast5Home.Text = HomeTeam.MatchStats.PossessionLast5.ToString() & "%"
        lblPossessionLast5Away.Text = AwayTeam.MatchStats.PossessionLast5.ToString() & "%"
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
        HomeTeam.MatchStats.PossessionLast5.Value = (nHome * 100) / nTotal
        AwayTeam.MatchStats.PossessionLast5.Value = 100 - HomeTeam.MatchStats.PossessionLast5.Value

        lblPossessionLast5Home.Text = HomeTeam.MatchStats.PossessionLast5.ToString() & "%"
        lblPossessionLast5Away.Text = AwayTeam.MatchStats.PossessionLast5.ToString() & "%"
      End If
      HomeTeam.MatchStats.PossessionLast10.Value = (nHome * 100) / nTotal
      AwayTeam.MatchStats.PossessionLast10.Value = 100 - HomeTeam.MatchStats.PossessionLast10.Value

      lblPossessionLast10Home.Text = HomeTeam.MatchStats.PossessionLast10.ToString() & "%"
      lblPossessionLast10Away.Text = AwayTeam.MatchStats.PossessionLast10.ToString() & "%"
    End If

    'Halfs
    nTotal = PossessionHome1st + PossessionAway1st
    If nTotal = 0 Then
      lblPossession1stHome.Text = "50%"
      lblPossession1stAway.Text = "50%"
    Else
      HomeTeam.MatchStats.Possession1st.Value = (PossessionHome1st * 100) / nTotal
      AwayTeam.MatchStats.Possession1st.Value = 100 - HomeTeam.MatchStats.Possession1st.Value

      lblPossession1stHome.Text = HomeTeam.MatchStats.Possession1st.ToString() & "%"
      lblPossession1stAway.Text = AwayTeam.MatchStats.Possession1st.ToString() & "%"
    End If

    nTotal = PossessionHome2nd + PossessionAway2nd
    If nTotal = 0 Then
      lblPossession2ndHome.Text = "50%"
      lblPossession2ndAway.Text = "50%"
    Else
      HomeTeam.MatchStats.Possession2nd.Value = (PossessionHome2nd * 100) / nTotal
      AwayTeam.MatchStats.Possession2nd.Value = 100 - HomeTeam.MatchStats.Possession2nd.Value

      lblPossession2ndHome.Text = HomeTeam.MatchStats.Possession2nd.ToString() & "%"
      lblPossession2ndAway.Text = AwayTeam.MatchStats.Possession2nd.ToString() & "%"
    End If
  End Sub

  Private Sub lblPossessionOwnT_Click(sender As Object, e As EventArgs)

  End Sub

  Private Sub lblPossessionMidF_Click(sender As Object, e As EventArgs)

  End Sub

  Private Sub lblPossessionAttk_Click(sender As Object, e As EventArgs)

  End Sub


  Private Sub lblStat_MouseDown(sender As Object, e As MouseEventArgs)

  End Sub

  Private Sub lblStat_Click(sender As Object, e As EventArgs)

  End Sub


  Private Sub AddEvent([Event] As String, LocalTeam As Boolean, EventPlayer As String)
    Dim item As ListViewItem = lsvEvents.Items.Insert(0, txtClock.Text)
    Dim TextToAdd As String = [Event].ToUpper()
    If [Event] = "RCARD" Then
      TextToAdd = "RED CARD"
    ElseIf [Event] = "YCARD" Then
      TextToAdd = "YELLOW CARD"
    ElseIf [Event] = "SHTGL" Then
      TextToAdd = "SHOT ON TARGET"
    End If

    item.SubItems.Add(TextToAdd)
    Dim strText As String
    If LocalTeam Then
      strText = lblHomeTeam1.Text
    Else
      strText = lblAwayTeam1.Text
    End If

    If EventPlayer <> "" Then
      strText += Convert.ToString(" player ") & EventPlayer
    End If
    item.SubItems.Add(strText)
    item.ImageKey = [Event]
  End Sub

  Private Sub MainForm_KeyDown(sender As Object, e As KeyEventArgs)
    bControlPress = e.Control

    'Check the shortcuts
    If tbcMain.SelectedTab.Name = tabGame.Name Then
      If chkShotcutsDefaultValues.Checked Then
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
    End If
  End Sub

  Private Sub MainForm_KeyUp(sender As Object, e As KeyEventArgs)
    bControlPress = e.Control
  End Sub

  Private Sub tmrRefresh_Tick(sender As Object, e As EventArgs)
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
    Dim values As String() = data.Split("|"c)
    Dim x As Integer = 3
    HomeTeam = New Team()
    HomeTeam.TeamID = Utils.Val(values(1).ToString())

    lblHomeTeam1.Tag = HomeTeam.TeamID
    lblHomeTeam1.Text = values(2)
    lblHomeTeam1.Tag = HomeTeam.TeamID
    lblHomeTeam1.Text = values(2)
    lblHomeTeam1.Tag = HomeTeam.TeamID
    lblHomeTeam1.Text = values(2)

    For i As Integer = 0 To 17
      HomePlayers(i) = New Player()
      HomePlayers(i).PlayerID = Utils.Val(values(x).ToString())
      HomePlayers(i).PlayerUniqueName = values(x + 1).ToString()

      Dim player As Label = DirectCast(Me.grpHomePlayers.Controls.Find("HomePlayer" & (i + 1).ToString(), True)(0), Label)
      player.Text = values(x + 1)
      Dim myPlayerStat As New Player(Utils.Val(values(x))) ', GlobalMatch.match_id)
      player.Tag = myPlayerStat
      x += 2
    Next
  End Sub

  Private Sub SetHomePlayersInvoke(data As String)
    Dim values As String() = data.Split("|"c)
    Dim x As Integer = 3
    HomeTeam = New Team()
    HomeTeam.TeamID = Utils.Val(values(1).ToString())
    Invoke(New Action(Function() InlineAssignHelper(lblHomeTeam1.Tag, HomeTeam.TeamID)))
    Invoke(New Action(Function() InlineAssignHelper(lblHomeTeam1.Text, values(2).ToString())))
    Invoke(New Action(Function() InlineAssignHelper(lblHomeTeam2.Tag, HomeTeam.TeamID)))
    Invoke(New Action(Function() InlineAssignHelper(lblHomeTeam2.Text, values(2).ToString())))
    Invoke(New Action(Function() InlineAssignHelper(lblHomeTeam3.Tag, HomeTeam.TeamID)))
    Invoke(New Action(Function() InlineAssignHelper(lblHomeTeam3.Text, values(2).ToString())))

    For i As Integer = 0 To 17
      HomePlayers(i) = New Player()
      HomePlayers(i).PlayerID = Utils.Val(values(x).ToString())
      HomePlayers(i).PlayerUniqueName = values(x + 1).ToString()

      Dim player As Label = DirectCast(Me.grpHomePlayers.Controls.Find("HomePlayer" & (i + 1).ToString(), True)(0), Label)
      Invoke(New Action(Function() InlineAssignHelper(player.Text, values(x + 1).ToString())))
      Dim myPlayerStat As New Player(Utils.Val(values(x))) ', GlobalMatch.match_id)
      Invoke(New Action(Function() InlineAssignHelper(player.Tag, myPlayerStat)))
      x += 2
    Next
  End Sub

  Private Sub SetAwayPlayers(data As String)
    Dim values As String() = data.Split("|"c)
    Dim x As Integer = 3
    AwayTeam = New Team()
    AwayTeam.TeamID = Utils.Val(values(1).ToString())
    lblAwayTeam1.Tag = AwayTeam.TeamID
    lblAwayTeam1.Text = values(2)
    lblAwayTeam2.Tag = AwayTeam.TeamID
    lblAwayTeam2.Text = values(2)
    lblAwayTeam3.Tag = AwayTeam.TeamID
    lblAwayTeam3.Text = values(2)

    For i As Integer = 0 To 17
      AwayPlayers(i) = New Player()
      AwayPlayers(i).PlayerID = Utils.Val(values(x).ToString())
      AwayPlayers(i).PlayerUniqueName = values(x + 1).ToString()
      Dim player As Label = DirectCast(Me.grpAwayPlayers.Controls.Find("AwayPlayer" & (i + 1).ToString(), True)(0), Label)
      player.Text = values(x + 1)
      Dim myPlayerStat As New Player(Utils.Val(values(x))) ', GlobalMatch.match_id)
      player.Tag = myPlayerStat
      x += 2
    Next
  End Sub

  Private Sub SetAwayPlayersInvoke(data As String)
    Dim values As String() = data.Split("|"c)
    Dim x As Integer = 3
    AwayTeam = New Team()
    AwayTeam.TeamID = Utils.Val(values(1).ToString())
    Invoke(New Action(Function() InlineAssignHelper(lblAwayTeam1.Tag, AwayTeam.TeamID)))
    Invoke(New Action(Function() InlineAssignHelper(lblAwayTeam1.Text, values(2).ToString())))
    Invoke(New Action(Function() InlineAssignHelper(lblAwayTeam2.Tag, AwayTeam.TeamID)))
    Invoke(New Action(Function() InlineAssignHelper(lblAwayTeam2.Text, values(2).ToString())))
    Invoke(New Action(Function() InlineAssignHelper(lblAwayTeam3.Tag, AwayTeam.TeamID)))
    Invoke(New Action(Function() InlineAssignHelper(lblAwayTeam3.Text, values(2).ToString())))

    For i As Integer = 0 To 17
      AwayPlayers(i) = New Player()
      AwayPlayers(i).PlayerID = Utils.Val(values(x).ToString())
      AwayPlayers(i).PlayerUniqueName = values(x + 1).ToString()
      Dim player As Label = DirectCast(Me.grpAwayPlayers.Controls.Find("AwayPlayer" & (i + 1).ToString(), True)(0), Label)
      Invoke(New Action(Function() InlineAssignHelper(player.Text, values(x + 1).ToString())))
      Dim myPlayerStat As New Player(Utils.Val(values(x))) ', GlobalMatch.match_id)
      Invoke(New Action(Function() InlineAssignHelper(player.Tag, myPlayerStat)))
      x += 2
    Next
  End Sub

  Private Sub ProcessPlayerLine(Line As Integer, Home As Boolean)
    Dim myPlayer As New Player()
    Dim HomeAway As String
    If Home Then
      myPlayer = DirectCast(DirectCast(grpHomePlayers.Controls.Find("HomePlayer" & Line, True)(0), Label).Tag, Player)
      HomeAway = "Home"
    Else
      myPlayer = DirectCast(DirectCast(grpAwayPlayers.Controls.Find("AwayPlayer" & Line, True)(0), Label).Tag, Player)
      HomeAway = "Away"
    End If
    DirectCast(grpData.Controls.Find((Convert.ToString("lblSaves") & HomeAway) + Line, True)(0), Label).Text = myPlayer.MatchStats.Saves.ToString()
    DirectCast(grpData.Controls.Find((Convert.ToString("lblShots") & HomeAway) + Line, True)(0), Label).Text = myPlayer.MatchStats.Shots.ToString()
    DirectCast(grpData.Controls.Find((Convert.ToString("lblShtGl") & HomeAway) + Line, True)(0), Label).Text = myPlayer.MatchStats.ShotsOn.ToString()
    DirectCast(grpData.Controls.Find((Convert.ToString("lblAssis") & HomeAway) + Line, True)(0), Label).Text = myPlayer.MatchStats.Assis.ToString()
    DirectCast(grpData.Controls.Find((Convert.ToString("lblFouls") & HomeAway) + Line, True)(0), Label).Text = myPlayer.MatchStats.Fouls.ToString()
    DirectCast(grpData.Controls.Find((Convert.ToString("lblYCard") & HomeAway) + Line, True)(0), Label).Text = myPlayer.YellowCards.ToString()
    DirectCast(grpData.Controls.Find((Convert.ToString("lblRCard") & HomeAway) + Line, True)(0), Label).Text = myPlayer.RedCards.ToString()
  End Sub

  Private Sub MainForm_FormClosing(sender As Object, e As FormClosingEventArgs)
    If MessageBox.Show("Are you sure you want to CLOSE the app?", Tittle, MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) = System.Windows.Forms.DialogResult.Yes Then
      'Save the data
      bClosing = True
      SocketThead.Abort()
    End If
  End Sub

#Region "Socket Jorge"
  Public Sub StartListening()
    ' Data buffer for incoming data.
    Dim bytes As Byte() = New [Byte](1023) {}

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
        MessageBox.Show("ERROR creating the socket!. Please, check the local IP:" & AppSettings.Instance.LoggerIP & ". PORT:" & AppSettings.Instance.LoggerPort.ToString() + vbLf & vbLf & vbLf + e.Message, Tittle, MessageBoxButtons.OK, MessageBoxIcon.[Error])
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
    If data.StartsWith("HOMETEAM") Then
      Send(handler, "OK")
      SetHomePlayersInvoke(data)
      GlobalProperties.Instance.HomePlayers = data
    ElseIf data.StartsWith("AWAYTEAM") Then
      Send(handler, "OK")
      SetAwayPlayersInvoke(data)
      GlobalProperties.Instance.AwayPlayers = data
    ElseIf data.StartsWith("TEAMSTATSHOME") Then
      Dim statsHome As String
      HomeTeam.MatchStats.Corners.Value = Utils.Val(lblCornersHome.Text)
      HomeTeam.MatchStats.Offsides.Value = Utils.Val(lblOffsidesHome.Text)
      HomeTeam.MatchStats.WoodHits.Value = Utils.Val(lblWoodHitsHome.Text)
      statsHome = HomeTeam.MatchStats.ToSocketFormat()

      Send(handler, statsHome)
    ElseIf data.StartsWith("TEAMSTATSAWAY") Then
      Dim statsAway As String
      AwayTeam.MatchStats.Corners.Value = Utils.Val(lblCornersAway.Text)
      AwayTeam.MatchStats.Offsides.Value = Utils.Val(lblOffsidesAway.Text)
      AwayTeam.MatchStats.WoodHits.Value = Utils.Val(lblWoodHitsAway.Text)
      statsAway = AwayTeam.MatchStats.ToSocketFormat()
      Send(handler, statsAway)
    ElseIf data.StartsWith("PLAYERSTAT") Then
      Dim player As String
      If HomePlayers.GetPlayer(Utils.Val(data.Split("|"c)(1).ToString())) IsNot Nothing Then
        player = HomePlayers.GetPlayer(Utils.Val(data.Split("|"c)(1).ToString())).ToSocketFormat()
      Else
        player = AwayPlayers.GetPlayer(Utils.Val(data.Split("|"c)(1).ToString())).ToSocketFormat()
      End If

      Send(handler, player)
    ElseIf data.StartsWith("SMALSTATS") Then
      Dim smallstats As String
      smallstats = HomeTeam.MatchStats.PossessionMatch.ToString() & "|"
      smallstats += AwayTeam.MatchStats.PossessionMatch.ToString() & "|"

      smallstats += HomeTeam.MatchStats.Fouls.ToString() & "|"
      smallstats += AwayTeam.MatchStats.Fouls.ToString() & "|"
      smallstats += HomeTeam.MatchStats.ShotsOn.ToString() & "|"
      smallstats += AwayTeam.MatchStats.ShotsOn.ToString() & "|"
      smallstats += HomeTeam.MatchStats.Corners.ToString() & "|"
      smallstats += AwayTeam.MatchStats.Corners.ToString() & "|"
      smallstats += HomeTeam.MatchStats.Offsides.ToString() & "|"
      smallstats += AwayTeam.MatchStats.Offsides.ToString() & "|"
      smallstats += HomeTeam.MatchStats.WoodHits.ToString() & "|"
      smallstats += AwayTeam.MatchStats.WoodHits.ToString() & "|"
      smallstats += HomeTeam.MatchStats.Shots.ToString() & "|"
      smallstats += AwayTeam.MatchStats.Shots.ToString() & "|"
      smallstats += HomeTeam.MatchStats.Assis.ToString() & "|"
      smallstats += AwayTeam.MatchStats.Assis.ToString()
      If Not String.IsNullOrEmpty(YCard) Then
        smallstats += YCard
      End If
      If Not String.IsNullOrEmpty(RCard) Then
        smallstats += RCard
      End If

      YCard = String.Empty
      RCard = String.Empty

      'PosesionHome|Poseeionaway|FoulsHome|FoulsAway|Shots.. corners.. offsides..woodhits
      Send(handler, smallstats)
    ElseIf data.StartsWith("SUBS") Then
      Send(handler, "OK")
      Dim homeAway As String = data.Split("|"c)(1)
      Dim idPlayerIn As Integer = Utils.Val(data.Split("|"c)(3).ToString())
      Dim idPlayerOut As Integer = Utils.Val(data.Split("|"c)(2).ToString())
      Dim labelIdPlayerIn As String
      Dim labelIdPlayerOut As String
      Dim myPlayerIn As Player
      Dim myPlayerOut As Player
      Dim myPlayer As Player
      If homeAway = "HOME" Then
        myPlayerIn = HomePlayers.GetPlayer(idPlayerIn)
        myPlayerOut = HomePlayers.GetPlayer(idPlayerOut)
        labelIdPlayerIn = findLabelPlayer(grpHomePlayers.Controls, idPlayerIn)
        labelIdPlayerOut = findLabelPlayer(grpHomePlayers.Controls, idPlayerOut)
        setPlayerText(myPlayerIn, myPlayerOut, labelIdPlayerIn, labelIdPlayerOut, "Home")

        myPlayer = myPlayerIn
        myPlayerIn.Copy(myPlayerOut)
        myPlayerOut.Copy(myPlayer)
      Else
        myPlayerIn = AwayPlayers.GetPlayer(idPlayerIn)
        myPlayerOut = AwayPlayers.GetPlayer(idPlayerOut)
        labelIdPlayerIn = findLabelPlayer(grpAwayPlayers.Controls, idPlayerIn)
        labelIdPlayerOut = findLabelPlayer(grpAwayPlayers.Controls, idPlayerOut)
        setPlayerText(myPlayerIn, myPlayerOut, labelIdPlayerIn, labelIdPlayerOut, "Away")

        myPlayer = myPlayerIn
        myPlayerIn.Copy(myPlayerOut)
        myPlayerOut.Copy(myPlayer)
      End If
    ElseIf data.StartsWith("RESET") Then
      Send(handler, "OK")
      Reset()
    Else
      Send(handler, "Empty")
    End If
  End Sub


  Private Sub setPlayerText(myPlayerIn As Player, myPlayerOut As Player, labelIdPlayerIn As String, labelIdPlayerOut As String, homeAway As String)
    If homeAway = "Home" Then
      Invoke(New Action(Function() InlineAssignHelper(DirectCast(grpHomePlayers.Controls.Find(Convert.ToString("HomePlayer") & labelIdPlayerIn, True)(0), Label).Text, myPlayerOut.PlayerName)))
      Invoke(New Action(Function() InlineAssignHelper(DirectCast(grpHomePlayers.Controls.Find(Convert.ToString("HomePlayer") & labelIdPlayerIn, True)(0), Label).Tag, myPlayerOut.PlayerID)))
      Invoke(New Action(Function() InlineAssignHelper(DirectCast(Controls.Find(Convert.ToString("lblSavesHome") & labelIdPlayerIn, True)(0), Label).Text, myPlayerOut.MatchStats.Saves.ToString())))
      Invoke(New Action(Function() InlineAssignHelper(DirectCast(Controls.Find(Convert.ToString("lblShotsHome") & labelIdPlayerIn, True)(0), Label).Text, myPlayerOut.MatchStats.Shots.ToString())))
      Invoke(New Action(Function() InlineAssignHelper(DirectCast(Controls.Find(Convert.ToString("lblShtGlHome") & labelIdPlayerIn, True)(0), Label).Text, myPlayerOut.MatchStats.ShotsOn.ToString())))
      Invoke(New Action(Function() InlineAssignHelper(DirectCast(Controls.Find(Convert.ToString("lblFoulsHome") & labelIdPlayerIn, True)(0), Label).Text, myPlayerOut.MatchStats.Fouls.ToString())))
      Invoke(New Action(Function() InlineAssignHelper(DirectCast(Controls.Find(Convert.ToString("lblYCardHome") & labelIdPlayerIn, True)(0), Label).Text, myPlayerOut.MatchStats.YellowCards.ToString())))
      Invoke(New Action(Function() InlineAssignHelper(DirectCast(Controls.Find(Convert.ToString("lblRCardHome") & labelIdPlayerIn, True)(0), Label).Text, myPlayerOut.MatchStats.RedCards.ToString())))
      Invoke(New Action(Function() InlineAssignHelper(DirectCast(Controls.Find(Convert.ToString("lblAssisHome") & labelIdPlayerIn, True)(0), Label).Text, myPlayerOut.MatchStats.Assis.ToString())))

      Invoke(New Action(Function() InlineAssignHelper(DirectCast(grpHomePlayers.Controls.Find(Convert.ToString("HomePlayer") & labelIdPlayerOut, True)(0), Label).Text, myPlayerIn.PlayerName)))
      Invoke(New Action(Function() InlineAssignHelper(DirectCast(grpHomePlayers.Controls.Find(Convert.ToString("HomePlayer") & labelIdPlayerOut, True)(0), Label).Tag, myPlayerIn.PlayerID)))
      Invoke(New Action(Function() InlineAssignHelper(DirectCast(Controls.Find(Convert.ToString("lblSavesHome") & labelIdPlayerOut, True)(0), Label).Text, myPlayerIn.MatchStats.Saves.ToString())))
      Invoke(New Action(Function() InlineAssignHelper(DirectCast(Controls.Find(Convert.ToString("lblShotsHome") & labelIdPlayerOut, True)(0), Label).Text, myPlayerIn.MatchStats.Shots.ToString())))
      Invoke(New Action(Function() InlineAssignHelper(DirectCast(Controls.Find(Convert.ToString("lblShtGlHome") & labelIdPlayerOut, True)(0), Label).Text, myPlayerIn.MatchStats.ShotsOn.ToString())))
      Invoke(New Action(Function() InlineAssignHelper(DirectCast(Controls.Find(Convert.ToString("lblFoulsHome") & labelIdPlayerOut, True)(0), Label).Text, myPlayerIn.MatchStats.Fouls.ToString())))
      Invoke(New Action(Function() InlineAssignHelper(DirectCast(Controls.Find(Convert.ToString("lblYCardHome") & labelIdPlayerOut, True)(0), Label).Text, myPlayerIn.MatchStats.YellowCards.ToString())))
      Invoke(New Action(Function() InlineAssignHelper(DirectCast(Controls.Find(Convert.ToString("lblRCardHome") & labelIdPlayerOut, True)(0), Label).Text, myPlayerIn.MatchStats.RedCards.ToString())))
      Invoke(New Action(Function() InlineAssignHelper(DirectCast(Controls.Find(Convert.ToString("lblAssisHome") & labelIdPlayerOut, True)(0), Label).Text, myPlayerIn.MatchStats.Assis.ToString())))
    Else
      Invoke(New Action(Function() InlineAssignHelper(DirectCast(grpAwayPlayers.Controls.Find(Convert.ToString("AwayPlayer") & labelIdPlayerIn, True)(0), Label).Text, myPlayerOut.PlayerName)))
      Invoke(New Action(Function() InlineAssignHelper(DirectCast(grpAwayPlayers.Controls.Find(Convert.ToString("AwayPlayer") & labelIdPlayerIn, True)(0), Label).Tag, myPlayerOut.PlayerID)))
      Invoke(New Action(Function() InlineAssignHelper(DirectCast(Controls.Find(Convert.ToString("lblSavesAway") & labelIdPlayerIn, True)(0), Label).Text, myPlayerOut.MatchStats.Saves.ToString())))
      Invoke(New Action(Function() InlineAssignHelper(DirectCast(Controls.Find(Convert.ToString("lblShotsAway") & labelIdPlayerIn, True)(0), Label).Text, myPlayerOut.MatchStats.Shots.ToString())))
      Invoke(New Action(Function() InlineAssignHelper(DirectCast(Controls.Find(Convert.ToString("lblShtGlAway") & labelIdPlayerIn, True)(0), Label).Text, myPlayerOut.MatchStats.ShotsOn.ToString())))
      Invoke(New Action(Function() InlineAssignHelper(DirectCast(Controls.Find(Convert.ToString("lblFoulsAway") & labelIdPlayerIn, True)(0), Label).Text, myPlayerOut.MatchStats.Fouls.ToString())))
      Invoke(New Action(Function() InlineAssignHelper(DirectCast(Controls.Find(Convert.ToString("lblYCardAway") & labelIdPlayerIn, True)(0), Label).Text, myPlayerOut.MatchStats.YellowCards.ToString())))
      Invoke(New Action(Function() InlineAssignHelper(DirectCast(Controls.Find(Convert.ToString("lblRCardAway") & labelIdPlayerIn, True)(0), Label).Text, myPlayerOut.MatchStats.RedCards.ToString())))
      Invoke(New Action(Function() InlineAssignHelper(DirectCast(Controls.Find(Convert.ToString("lblAssisAway") & labelIdPlayerIn, True)(0), Label).Text, myPlayerOut.MatchStats.Assis.ToString())))

      Invoke(New Action(Function() InlineAssignHelper(DirectCast(Controls.Find(Convert.ToString("AwayPlayer") & labelIdPlayerOut, True)(0), Label).Text, myPlayerIn.PlayerName)))
      Invoke(New Action(Function() InlineAssignHelper(DirectCast(Controls.Find(Convert.ToString("AwayPlayer") & labelIdPlayerOut, True)(0), Label).Tag, myPlayerIn.PlayerID)))
      Invoke(New Action(Function() InlineAssignHelper(DirectCast(Controls.Find(Convert.ToString("lblSavesAway") & labelIdPlayerOut, True)(0), Label).Text, myPlayerIn.MatchStats.Saves.ToString())))
      Invoke(New Action(Function() InlineAssignHelper(DirectCast(Controls.Find(Convert.ToString("lblShotsAway") & labelIdPlayerOut, True)(0), Label).Text, myPlayerIn.MatchStats.Shots.ToString())))
      Invoke(New Action(Function() InlineAssignHelper(DirectCast(Controls.Find(Convert.ToString("lblShtGlAway") & labelIdPlayerOut, True)(0), Label).Text, myPlayerIn.MatchStats.ShotsOn.ToString())))
      Invoke(New Action(Function() InlineAssignHelper(DirectCast(Controls.Find(Convert.ToString("lblFoulsAway") & labelIdPlayerOut, True)(0), Label).Text, myPlayerIn.MatchStats.Fouls.ToString())))
      Invoke(New Action(Function() InlineAssignHelper(DirectCast(Controls.Find(Convert.ToString("lblYCardAway") & labelIdPlayerOut, True)(0), Label).Text, myPlayerIn.MatchStats.YellowCards.ToString())))
      Invoke(New Action(Function() InlineAssignHelper(DirectCast(Controls.Find(Convert.ToString("lblRCardAway") & labelIdPlayerOut, True)(0), Label).Text, myPlayerIn.MatchStats.RedCards.ToString())))
      Invoke(New Action(Function() InlineAssignHelper(DirectCast(Controls.Find(Convert.ToString("lblAssisAway") & labelIdPlayerOut, True)(0), Label).Text, myPlayerIn.MatchStats.Assis.ToString())))
    End If
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



End Class
