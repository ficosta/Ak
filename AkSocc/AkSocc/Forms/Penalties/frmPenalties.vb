Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Threading.Tasks
Imports System.Windows.Forms

Partial Public Class frmPenalties
  Inherits System.Windows.Forms.Form
  Private _vizControl As VizCommands.VizControl
  Private HomeFirst As Boolean
  'Private Shot As Integer = 1

  Private lastShot As ShotClass

  Private Const _penaltiesPerPage As Integer = 5

  Private ReadOnly Property ShotNumber As Integer
    Get
      Dim maxValue As Integer = -1
      For Each myShot As ShotClass In _shots
        If myShot.state <> eShotState.Idle Then
          maxValue = Math.Max(myShot.index, maxValue)
        End If
      Next
      ShotNumber = _shots.Count \ 2 + 1 ' maxValue \ 2
    End Get
  End Property

  Private Property ShotsHome As Boolean
    Get
      If _shots.Count Mod 2 = 0 Then
        Return HomeFirst
      Else
        Return Not HomeFirst
      End If
    End Get
    Set(value As Boolean)

    End Set
  End Property


  Private ReadOnly Property PageAuto As Integer
    Get
      Return (ShotNumber - 1) \ _penaltiesPerPage
    End Get
  End Property

  Private _page As Integer = 0
  Private Property Page As Integer
    Get
      Return _page
    End Get
    Set(value As Integer)
      _page = value
      Me.ButtonPage0.BackColor = IIf(_page = 0, Color.LightGreen, Color.White)
      Me.ButtonPage1.BackColor = IIf(_page = 1, Color.LightGreen, Color.White)
      Me.ButtonPage2.BackColor = IIf(_page = 2, Color.LightGreen, Color.White)
      Me.ButtonPage3.BackColor = IIf(_page = 3, Color.LightGreen, Color.White)
      Me.SendPage()
    End Set
  End Property


  Private ReadOnly Property _homePenalties As List(Of ShotClass)
    Get
      Dim res As New List(Of ShotClass)
      For Each shot As ShotClass In _shots
        If shot.isHome = True Then
          res.Add(shot)
        End If
      Next
      Return res
    End Get
  End Property

  Private ReadOnly Property _awayPenalties As List(Of ShotClass)
    Get
      Dim res As New List(Of ShotClass)
      For Each shot As ShotClass In _shots
        If shot.isHome = False Then
          res.Add(shot)
        End If
      Next
      Return res
    End Get
  End Property

  Private _shots As New List(Of ShotClass)


  Private Enum eShotState
    Idle = 0
    Ok
    KO
  End Enum

  Private Class ShotClass
    Public isHome As Boolean = True
    Public index As Integer = -1
    Public state As frmPenalties.eShotState = eShotState.Idle
    Public label As Label

    Public Sub New()
    End Sub

    Public Sub New(Index As Integer, IsHome As Boolean, State As eShotState)
      Me.index = Index
      Me.isHome = IsHome
      Me.state = State
    End Sub
  End Class

  Public Property StartOnShow As Boolean = False
  Private _firstRun As Boolean = True

  Public Property Match As MatchInfo.Match

  Public Sub New(mVizrtLocal As VizCommands.VizControl, HomeTeam As String, AwayTeam As String, bHomeFirst As Boolean)
    InitializeComponent()
    _vizControl = mVizrtLocal
    HomeTeamName.Text = HomeTeam
    AwayTeamName.Text = AwayTeam
    HomeFirst = bHomeFirst
    ShotsHome = bHomeFirst
    SetTeamColors()
  End Sub

  Private Sub SetTeamColors()
    If ShotsHome Then
      HomeTeamName.BackColor = Color.Orange
      AwayTeamName.BackColor = Color.White
    Else
      HomeTeamName.BackColor = Color.White
      AwayTeamName.BackColor = Color.Orange
    End If
  End Sub

  Private Function GetShot(index As Integer, isHome As Boolean) As ShotClass
    Dim res As ShotClass = Nothing
    Try
      Dim list As List(Of ShotClass) = IIf(isHome, _homePenalties, _awayPenalties)
      res = list(index - 1)
    Catch ex As Exception

    End Try
    Return res
  End Function

  Private Sub SetShot(index As Integer, isHome As Boolean, state As eShotState)
    Try
      Dim shot As ShotClass = Me.GetShot(index, isHome)
      If shot Is Nothing Then
        shot = New ShotClass(index, isHome, state)
        _shots.Add(shot)
      Else
        shot.state = state
      End If
      UpdateLabels()
      SendPage()
    Catch ex As Exception

    End Try
  End Sub

  Private Sub btnGoal_Click(sender As Object, e As EventArgs) Handles btnGoal.Click
    Dim ShotPlace As Integer = ShotNumber

    SetShot(ShotNumber, ShotsHome, eShotState.Ok)

    'Prepare Next
    SetNext()
  End Sub

  Private Sub btnMiss_Click(sender As Object, e As EventArgs) Handles btnMiss.Click
    SetShot(ShotNumber, ShotsHome, eShotState.KO)

    'Prepare Next
    SetNext()
  End Sub

  Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
    If MessageBox.Show("Do you want to animate out?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes Then
      ' VizrtLocal.FreeCommand("MAIN_SCENE*STAGE*DIRECTOR*anim_penalties$In_Out CONTINUE", "-1")
      '_vizControl.DirectorContinue("DIR_MAIN$In_Out")
      If Me.Lower3rdPenaltiesVisible Then Me.Lower3rdPenaltiesVisible = False
      If Me.ClockPenaltiesVisible Then Me.ClockPenaltiesVisible = False
    End If
    Me.Close()
  End Sub

  Private Sub btnUndo_Click(sender As Object, e As EventArgs) Handles btnUndo.Click

    If _shots.Count > 0 Then
      _shots.RemoveAt(_shots.Count - 1)
    End If
    UpdateLabels()
    SendPage()
  End Sub

  Private Sub SetNext()
    ShotsHome = Not ShotsHome
    SetTeamColors()
    If (ShotsHome AndAlso Not HomeFirst) OrElse (Not ShotsHome AndAlso HomeFirst) Then
      ' Shot += 1
      If ShotNumber = 6 OrElse ShotNumber = 11 OrElse ShotNumber = 16 Then
        btnNext10_Click(Nothing, Nothing)
      End If
    End If
  End Sub
  Private Sub btnNext10_Click(sender As Object, e As EventArgs) Handles btnNext10.Click
    If Page <> PageAuto Then
      If MessageBox.Show("Confirm reset of caption for next 10 penalties?", "Next 10 shots", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes Then
        Page += 1
      End If
    End If
  End Sub

  Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
    If MessageBox.Show("Confirm to clear everything?", "Reset All", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes Then
      Clear()
    End If
  End Sub

  Public Sub Clear()
    _shots.Clear()
    Me.Page = 0
    UpdateLabels()
    SendPage()
  End Sub

#Region "Scenes visibility"
  Private _clockPenaltiesVisible As Boolean = False
  Private Property ClockPenaltiesVisible As Boolean
    Get
      Return _clockPenaltiesVisible
    End Get
    Set(value As Boolean)
      _clockPenaltiesVisible = value
      If value Then
        Try
          _vizControl.ActivateScene(_vizControl.Config.SceneBasePath & "gfx_Clock", VizCommands.eRendererLayers.FrontLayer)
          _vizControl.DirectorRewind("anim_Clock_Penalties", VizCommands.eRendererLayers.FrontLayer)
          _vizControl.SetControlObjectValue("$object", "Penalties_Home_Team_Name", _Match.HomeTeam.Name, VizCommands.eRendererLayers.FrontLayer)
          _vizControl.SetControlObjectValue("$object", "Penalties_Away_Team_Name", _Match.AwayTeam.Name, VizCommands.eRendererLayers.FrontLayer)
          _vizControl.SetControlObjectValue("$object", "Penalties_Home_Team_Score", HomeTeamScore.Text, VizCommands.eRendererLayers.FrontLayer)
          _vizControl.SetControlObjectValue("$object", "Penalties_Away_Team_Score", AwayTeamScore.Text, VizCommands.eRendererLayers.FrontLayer)
          SendPage(VizCommands.eRendererLayers.FrontLayer)
          _vizControl.DirectorStart("anim_Clock_Penalties", VizCommands.eRendererLayers.FrontLayer)
        Catch ex As Exception

        End Try
      Else
        Try
          '  _vizControl.ActivateScene(_vizControl.Config.SceneBasePath & "gfx_clock", VizCommands.eRendererLayers.FrontLayer)
          _vizControl.DirectorContinue("anim_Clock_Penalties", VizCommands.eRendererLayers.FrontLayer)
        Catch ex As Exception

        End Try
      End If
    End Set
  End Property

  Private _lower3rdPenaltiesVisible As Boolean = False
  Private Property Lower3rdPenaltiesVisible As Boolean
    Get
      Return _lower3rdPenaltiesVisible
    End Get
    Set(value As Boolean)
      _lower3rdPenaltiesVisible = value
      If value Then
        Try
          _vizControl.ActivateScene(_vizControl.Config.SceneBasePath & "gfx_penalties", VizCommands.eRendererLayers.MidleLayer)

          _vizControl.DirectorRewind("DIR_MAIN$In_Out", VizCommands.eRendererLayers.MidleLayer)
          _vizControl.SetControlObjectValue("$object", "Penalties_Home_Team_Name", _Match.HomeTeam.Name, VizCommands.eRendererLayers.MidleLayer)
          _vizControl.SetControlObjectValue("$object", "Penalties_Away_Team_Name", _Match.AwayTeam.Name, VizCommands.eRendererLayers.MidleLayer)
          _vizControl.SetControlObjectValue("$object", "Penalties_Home_Team_Score", HomeTeamScore.Text, VizCommands.eRendererLayers.MidleLayer)
          _vizControl.SetControlObjectValue("$object", "Penalties_Away_Team_Score", AwayTeamScore.Text, VizCommands.eRendererLayers.MidleLayer)
          SendPage(VizCommands.eRendererLayers.MidleLayer)
          _vizControl.DirectorStart("DIR_MAIN$In_Out", VizCommands.eRendererLayers.MidleLayer)
        Catch ex As Exception

        End Try
      Else
        Try
          ' _vizControl.ActivateScene(_vizControl.Config.SceneBasePath & "gfx_penalties", VizCommands.eRendererLayers.MidleLayer)
          _vizControl.DirectorContinue("DIR_MAIN", VizCommands.eRendererLayers.MidleLayer)
        Catch ex As Exception

        End Try
      End If
    End Set
  End Property


  Private Sub ButtonLower3rdShow_Click(sender As Object, e As EventArgs) Handles ButtonLower3rdShow.Click
    Me.Lower3rdPenaltiesVisible = True
  End Sub

  Private Sub ButtonLower3rdHide_Click(sender As Object, e As EventArgs) Handles ButtonLower3rdHide.Click
    Me.Lower3rdPenaltiesVisible = False
  End Sub

  Private Sub ButtonShowClock_Click(sender As Object, e As EventArgs) Handles ButtonShowClock.Click
    Me.ClockPenaltiesVisible = True
  End Sub

  Private Sub ButtonHideClock_Click(sender As Object, e As EventArgs) Handles ButtonHideClock.Click
    Me.ClockPenaltiesVisible = False
  End Sub

  Private Sub frmPenalties_Shown(sender As Object, e As EventArgs) Handles Me.Shown
    Try
      If _firstRun Then
        Clear()
        _vizControl.DirectorRewind("DIR_MAIN$In_Out")
        _vizControl.DirectorRewind("Penalties_top")
        _vizControl.DirectorRewind("Penalties_Bottom")
        _firstRun = False
        Page = 0
        UpdateLabels()
      End If

      SendPage()

      If StartOnShow Then
        ButtonLower3rdShow_Click(Nothing, Nothing)
      End If
    Catch ex As Exception

    End Try
  End Sub
#End Region

  Private Sub UpdateLabels()
    Try
      Dim ThisLabel As Label
      Dim shot As ShotClass
      Me.HomeTeamScore.Text = Me.HomeResult
      Me.AwayTeamScore.Text = Me.AwayResult
      For i As Integer = 1 To 20
        ThisLabel = DirectCast(Me.Controls.Find("HomePenal" + i.ToString(), True)(0), Label)
        shot = Me.GetShot(i, True)
        ShowShotState(shot, ThisLabel)

        ThisLabel = DirectCast(Me.Controls.Find("AwayPenal" + i.ToString(), True)(0), Label)
        shot = Me.GetShot(i, False)
        ShowShotState(shot, ThisLabel)
      Next
    Catch ex As Exception

    End Try
  End Sub

  Private Sub ShowShotState(shot As ShotClass, label As Label)
    Try

      Dim state As eShotState
      If shot Is Nothing Then
        state = eShotState.Idle
      Else
        state = shot.state
      End If
      Select Case state
        Case eShotState.Idle
          label.Text = ""
          label.BackColor = Color.White
        Case eShotState.Ok
          label.Text = "O"
          label.BackColor = Color.LightGreen
        Case eShotState.KO
          label.Text = "X"
          label.BackColor = Color.LightSalmon
      End Select

    Catch ex As Exception

    End Try
  End Sub

  Public ReadOnly Property HomeResult As Integer
    Get
      Dim res As Integer = 0
      For Each Shot As ShotClass In _homePenalties
        If Shot.state = eShotState.Ok Then res += 1
      Next
      Return res
    End Get
  End Property

  Public ReadOnly Property AwayResult As Integer
    Get
      Dim res As Integer = 0
      For Each Shot As ShotClass In _awayPenalties
        If Shot.state = eShotState.Ok Then res += 1
      Next
      Return res
    End Get
  End Property

  Private Sub SendPage()
    SendPage(VizCommands.eRendererLayers.FrontLayer)
    SendPage(VizCommands.eRendererLayers.MidleLayer)
  End Sub


  Private Sub SendPage(layer As VizCommands.eRendererLayers)
    Try
      Dim index As Integer
      Dim shot As ShotClass
      Dim value As String = "0"

      If Not _vizControl Is Nothing Then
        _vizControl.SetControlObjectValue("$object", "Penalties_Home_Team_Score", HomeResult, layer)
        _vizControl.SetControlObjectValue("$object", "Penalties_Away_Team_Score", AwayResult, layer)
        For i As Integer = 1 To _penaltiesPerPage
          index = i + (Page) * _penaltiesPerPage

          shot = Me.GetShot(index, True)
          If shot Is Nothing Then
            _vizControl.SetControlObjectValue("$object", "Penalties_Data_01_Visible_Top_" & Microsoft.VisualBasic.Strings.Format(i, "00"), "0", layer)
          Else
            Select Case shot.state
              Case eShotState.Idle
                _vizControl.SetControlObjectValue("$object", "Penalties_Data_01_Visible_Top_" & Microsoft.VisualBasic.Strings.Format(i, "00"), "0", layer)
              Case eShotState.Ok
                _vizControl.SetControlObjectValue("$object", "Penalties_Data_01_Visible_Top_" & Microsoft.VisualBasic.Strings.Format(i, "00"), "1", layer)
                _vizControl.SetControlObjectValue("$object", "Penalties_Data_01_Control_OMO_Top_" & Microsoft.VisualBasic.Strings.Format(i, "00"), "0", layer)
              Case eShotState.KO
                _vizControl.SetControlObjectValue("$object", "Penalties_Data_01_Visible_Top_" & Microsoft.VisualBasic.Strings.Format(i, "00"), "1", layer)
                _vizControl.SetControlObjectValue("$object", "Penalties_Data_01_Control_OMO_Top_" & Microsoft.VisualBasic.Strings.Format(i, "00"), "1", layer)
            End Select
          End If

          shot = Me.GetShot(index, False)
          If shot Is Nothing Then
            _vizControl.SetControlObjectValue("$object", "Penalties_Data_01_Visible_Bottom_" & Microsoft.VisualBasic.Strings.Format(i, "00"), "0", layer)
          Else
            Select Case shot.state
              Case eShotState.Idle
                _vizControl.SetControlObjectValue("$object", "Penalties_Data_01_Visible_Bottom_" & Microsoft.VisualBasic.Strings.Format(i, "00"), "0", layer)
              Case eShotState.Ok
                _vizControl.SetControlObjectValue("$object", "Penalties_Data_01_Visible_Bottom_" & Microsoft.VisualBasic.Strings.Format(i, "00"), "1", layer)
                _vizControl.SetControlObjectValue("$object", "Penalties_Data_01_Control_OMO_Bottom_" & Microsoft.VisualBasic.Strings.Format(i, "00"), "0", layer)
              Case eShotState.KO
                _vizControl.SetControlObjectValue("$object", "Penalties_Data_01_Visible_Bottom_" & Microsoft.VisualBasic.Strings.Format(i, "00"), "1", layer)
                _vizControl.SetControlObjectValue("$object", "Penalties_Data_01_Control_OMO_Bottom_" & Microsoft.VisualBasic.Strings.Format(i, "00"), "1", layer)
            End Select
          End If
        Next
      End If

    Catch ex As Exception

    End Try
  End Sub

  Private Sub ButtonPage0_Click(sender As Object, e As EventArgs) Handles ButtonPage0.Click
    Me.Page = 0
  End Sub

  Private Sub ButtonPage1_Click(sender As Object, e As EventArgs) Handles ButtonPage1.Click
    Me.Page = 1
  End Sub

  Private Sub ButtonPage2_Click(sender As Object, e As EventArgs) Handles ButtonPage2.Click
    Me.Page = 2
  End Sub

  Private Sub ButtonPage3_Click(sender As Object, e As EventArgs) Handles ButtonPage3.Click
    Me.Page = 3
  End Sub
End Class