Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Threading.Tasks
Imports System.Windows.Forms

Partial Public Class frmPenalties
  Inherits System.Windows.Forms.Form
  Private _vizControl As VizCommands.VizControl
  Private ShotsHome As Boolean
  Private HomeFirst As Boolean
  Private Shot As Integer = 1

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

  Private Sub SetShot(LabelName As String, Value As String)
    Dim ThisLabel As Label = DirectCast(Me.Controls.Find(LabelName, True)(0), Label)
    ThisLabel.Text = Value
    If Value = "X" Then
      ThisLabel.BackColor = Color.Red
    ElseIf Value = "O" Then
      ThisLabel.BackColor = Color.Green
    ElseIf Value = "" Then
      ThisLabel.BackColor = Color.White
    End If
  End Sub

  Private Sub btnGoal_Click(sender As Object, e As EventArgs) Handles btnGoal.Click
    Dim strLabel As String
    Dim ShotPlace As Integer = Shot
    While ShotPlace > 5
      ShotPlace -= 5
    End While
    If ShotsHome Then
      strLabel = "Home"
      HomeTeamScore.Text = (NoNullInt(HomeTeamScore.Text) + 1).ToString()
      _vizControl.SetControlObjectValue("$object", "Penalties_Home_Team_Score", HomeTeamScore.Text)
      _vizControl.SetControlObjectValue("$object", "Penalties_Data_01_Control_OMO_Top_0" & ShotPlace.ToString, "0")
      _vizControl.DirectorContinue("Penalties_top")
      'VizrtLocal.FreeCommand("MAIN_SCENE*TREE*$object$gfx_penalties$Top$Change$Data$Team_A$Penalties$Score$txt_Score*GEOM*TEXT_FROM_GUI SET " + HomeTeamScore.Text, "-1")
      'VizrtLocal.FreeCommand("MAIN_SCENE*TREE*$object$gfx_penalties$Top$Change$Data$Team_A$Penalties$" + ShotPlace.ToString() + "$GV_choose*FUNCTION*Omo*vis_con SET 0", "-1")
      'VizrtLocal.FreeCommand("MAIN_SCENE*STAGE*DIRECTOR*anim_penalties$Penalties_top CONTINUE", "-1")
    Else
      strLabel = "Away"
      AwayTeamScore.Text = (NoNullInt(AwayTeamScore.Text) + 1).ToString()
      _vizControl.SetControlObjectValue("$object", "Penalties_Away_Team_Score", AwayTeamScore.Text)
      _vizControl.SetControlObjectValue("$object", "Penalties_Data_01_Control_OMO_Bottom_0" & ShotPlace.ToString, "0")
      _vizControl.DirectorContinue("Penalties_Bottom")
      'VizrtLocal.FreeCommand("MAIN_SCENE*TREE*$object$gfx_penalties$Bottom$Change$Data$Team_A$Penalties$Score$txt_Score*GEOM*TEXT_FROM_GUI SET " + AwayTeamScore.Text, "-1")
      'VizrtLocal.FreeCommand("MAIN_SCENE*TREE*$object$gfx_penalties$Bottom$Change$Data$Team_A$Penalties$" + ShotPlace.ToString() + "$GV_choose*FUNCTION*Omo*vis_con SET 0", "-1")
      'VizrtLocal.FreeCommand("MAIN_SCENE*STAGE*DIRECTOR*anim_penalties$Penalties_Bottom CONTINUE", "-1")
    End If
    strLabel += "Penal" + Shot.ToString()
    SetShot(strLabel, "O")

    'Prepare Next
    SetNext()
  End Sub

  Private Sub btnMiss_Click(sender As Object, e As EventArgs) Handles btnMiss.Click
    Dim strLabel As String
    Dim ShotPlace As Integer = Shot
    While ShotPlace > 5
      ShotPlace -= 5
    End While
    If ShotsHome Then
      strLabel = "Home"
      _vizControl.SetControlObjectValue("$object", "Penalties_Home_Team_Score", HomeTeamScore.Text)
      _vizControl.SetControlObjectValue("$object", "Penalties_Data_01_Control_OMO_Top_0" & ShotPlace.ToString, "1")
      _vizControl.DirectorContinue("Penalties_top")
      'VizrtLocal.FreeCommand("MAIN_SCENE*TREE*$object$gfx_penalties$Top$Change$Data$Team_A$Penalties$" + ShotPlace.ToString() + "$GV_choose*FUNCTION*Omo*vis_con SET 1", "-1")
      'VizrtLocal.FreeCommand("MAIN_SCENE*STAGE*DIRECTOR*anim_penalties$Penalties_top CONTINUE", "-1")
    Else
      strLabel = "Away"
      _vizControl.SetControlObjectValue("$object", "Penalties_Home_Team_Score", AwayTeamScore.Text)
      _vizControl.SetControlObjectValue("$object", "Penalties_Data_01_Control_OMO_Bottom_0" & ShotPlace.ToString, "1")
      _vizControl.DirectorContinue("Penalties_Bottom")
      'VizrtLocal.FreeCommand("MAIN_SCENE*TREE*$object$gfx_penalties$Bottom$Change$Data$Team_A$Penalties$" + ShotPlace.ToString() + "$GV_choose*FUNCTION*Omo*vis_con SET 1", "-1")
      'VizrtLocal.FreeCommand("MAIN_SCENE*STAGE*DIRECTOR*anim_penalties$Penalties_Bottom CONTINUE", "-1")
    End If
    strLabel += "Penal" + Shot.ToString()
    SetShot(strLabel, "X")

    'Prepare Next
    SetNext()
  End Sub

  Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
    If MessageBox.Show("Do you want to animate out?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes Then
      ' VizrtLocal.FreeCommand("MAIN_SCENE*STAGE*DIRECTOR*anim_penalties$In_Out CONTINUE", "-1")
      _vizControl.DirectorContinue("DIR_MAIN$In_Out")
    End If
    Me.Close()
  End Sub

  Private Sub btnUndo_Click(sender As Object, e As EventArgs) Handles btnUndo.Click
    'Prepare Previous
    ShotsHome = Not ShotsHome

    If (Not ShotsHome AndAlso HomeFirst) OrElse (ShotsHome AndAlso Not HomeFirst) Then
      Shot -= 1
    End If

    If Shot <= 0 Then
      Shot = 1
      ShotsHome = HomeFirst
      SetTeamColors()
      Return
    End If

    SetTeamColors()

    Dim strLabel As String
    If ShotsHome Then
      strLabel = "Home"
    Else
      strLabel = "Away"
    End If
    strLabel += "Penal" + Shot.ToString()


    Dim ThisLabel As Label = DirectCast(Me.Controls.Find(strLabel, True)(0), Label)
    If ShotsHome Then
      If ThisLabel.Text = "O" Then
        HomeTeamScore.Text = (NoNullInt(HomeTeamScore.Text) - 1).ToString()
        _vizControl.SetControlObjectValue("$object", "Penalties_Home_Team_Score", HomeTeamScore.Text)
        ' VizrtLocal.FreeCommand("MAIN_SCENE*TREE*$object$gfx_penalties$Top$Change$Data$Team_A$Penalties$Score$txt_Score*GEOM*TEXT_FROM_GUI SET " + HomeTeamScore.Text, "-1")
      End If
      _vizControl.DirectorContinueReverse("Penalties_top")
      ' VizrtLocal.FreeCommand("MAIN_SCENE*STAGE*DIRECTOR*anim_penalties$Penalties_top CONTINUE REVERSE", "-1")
    Else
      If ThisLabel.Text = "O" Then
        AwayTeamScore.Text = (NoNullInt(AwayTeamScore.Text) - 1).ToString()
        _vizControl.SetControlObjectValue("$object", "Penalties_Away_Team_Score", AwayTeamScore.Text)
        ' VizrtLocal.FreeCommand("MAIN_SCENE*TREE*$object$gfx_penalties$Bottom$Change$Data$Team_A$Penalties$Score$txt_Score*GEOM*TEXT_FROM_GUI SET " + AwayTeamScore.Text, "-1")
      End If
      _vizControl.DirectorContinueReverse("Penalties_Bottom")
      '  VizrtLocal.FreeCommand("MAIN_SCENE*STAGE*DIRECTOR*anim_penalties$Penalties_Bottom CONTINUE REVERSE", "-1")
    End If
    SetShot(strLabel, "")
  End Sub

  Private Sub SetNext()
    ShotsHome = Not ShotsHome
    SetTeamColors()
    If (ShotsHome AndAlso HomeFirst) OrElse (Not ShotsHome AndAlso Not HomeFirst) Then
      Shot += 1
      If Shot = 6 OrElse Shot = 11 OrElse Shot = 16 Then
        btnNext10_Click(Nothing, Nothing)
      End If
    End If
  End Sub
  Private Sub btnNext10_Click(sender As Object, e As EventArgs) Handles btnNext10.Click
    If MessageBox.Show("Confirm reset of caption for next 10 penalties?", "Next 10 shots", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes Then
      'Clear the Penalties
      _vizControl.DirectorRewind("Penalties_top")
      _vizControl.DirectorRewind("Penalties_Bottom")
      'VizrtLocal.FreeCommand("MAIN_SCENE*STAGE*DIRECTOR*anim_penalties$Penalties_Bottom SHOW 0.0", "-1")
      'VizrtLocal.FreeCommand("MAIN_SCENE*STAGE*DIRECTOR*anim_penalties$Penalties_top SHOW 0.0", "-1")
    End If
  End Sub

  Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
    If MessageBox.Show("Confirm to clear everything?", "Reset All", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes Then
      Shot = 1
      ShotsHome = HomeFirst
      SetTeamColors()
      HomeTeamScore.Text = "0"
      AwayTeamScore.Text = "0"
      _vizControl.SetControlObjectValue("$object", "Penalties_Home_Team_Score", HomeTeamScore.Text)
      _vizControl.SetControlObjectValue("$object", "Penalties_Away_Team_Score", AwayTeamScore.Text)
      'VizrtLocal.FreeCommand("MAIN_SCENE*TREE*$object$gfx_penalties$Top$Change$Data$Team_A$Penalties$Score$txt_Score*GEOM*TEXT_FROM_GUI SET 0", "-1")
      'VizrtLocal.FreeCommand("MAIN_SCENE*TREE*$object$gfx_penalties$Bottom$Change$Data$Team_A$Penalties$Score$txt_Score*GEOM*TEXT_FROM_GUI SET 0", "-1")
      _vizControl.DirectorRewind("Penalties_top")
      _vizControl.DirectorRewind("Penalties_Bottom")
      'VizrtLocal.FreeCommand("MAIN_SCENE*STAGE*DIRECTOR*anim_penalties$Penalties_Bottom SHOW 0.0", "-1")
      'VizrtLocal.FreeCommand("MAIN_SCENE*STAGE*DIRECTOR*anim_penalties$Penalties_top SHOW 0.0", "-1")
      For i As Integer = 1 To 20
        Dim ThisLabel As Label = DirectCast(Me.Controls.Find("HomePenal" + i.ToString(), True)(0), Label)
        ThisLabel.Text = ""
        ThisLabel.BackColor = Color.White

        ThisLabel = DirectCast(Me.Controls.Find("AwayPenal" + i.ToString(), True)(0), Label)
        ThisLabel.Text = ""
        ThisLabel.BackColor = Color.White
      Next
    End If
  End Sub
End Class