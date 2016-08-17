Imports AkSocc
Imports MatchInfo
Imports MetroFramework
Imports MetroFramework.Forms
Imports VizCommands

Public Class FormChooseMulti
  Private _match As Match
  Public WithEvents _vizControl As VizCommands.VizControl
  Public WithEvents _previewControl As VizCommands.PreviewControl

  Private Property Scene As Scene
  Private _formerScene As Scene = Nothing
  Private _nextStep As Integer = 1
  Private _lastStep As Integer = 2


  Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
    AcceptGraphic()
  End Sub

  Private Sub FormChoose_Shown(sender As Object, e As EventArgs) Handles Me.Shown
    Try
      Me.Scene = InitDefaultScene(1)

      InitGrids()
    Catch ex As Exception
      WriteToErrorLog(ex)
    End Try
  End Sub



  Private Sub InitGrids()
    Try
      With Me.MetroGridStats
        .Rows.Clear()
        Dim aux() As Object

        aux = {"Shots", "Attempts On Goal"} : .Rows.Add(aux)
        aux = {"Shots_on_target", "Attempts On target"} : .Rows.Add(aux)
        aux = {"YCard", "Yellow cards"} : .Rows.Add(aux)
        aux = {"RCard", "Red cards"} : .Rows.Add(aux)
        aux = {"YCard + RCard", "Red & Yellow cards"} : .Rows.Add(aux)
        aux = {"Fouls", "Fouls committed"} : .Rows.Add(aux)
        aux = {"Corners", "Corners"} : .Rows.Add(aux)
        aux = {"Possession", "Possession"} : .Rows.Add(aux)
        aux = {"LastPossessions", "Last 5 Minutes Possession"} : .Rows.Add(aux)
      End With
    Catch ex As Exception
      WriteToErrorLog(ex)
    End Try
  End Sub


  Private Sub AcceptGraphic()
    Try

      ' If MsgBox("Start graphic?", MsgBoxStyle.YesNo, gSide.ToString) = MsgBoxResult.No Then Exit Sub
      If frmWaitForInput.ShowWaitDialog(Me, "Start graphic?", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Hand) = DialogResult.Cancel Then Exit Sub
      Dim fWait As frmWait

      Dim _currentScene As Scene = Nothing
      If _formerScene Is Nothing Then
        _currentScene = Me.PrepareScene(1)

        'this is the first time we send a scene
        'send scene to render and start animation
        _currentScene.SendSceneToEngine(_vizControl)
        _currentScene.StartSceneDirectors(_vizControl, Scene.TypeOfDirectors.InDirectors)

        'wait for animation to end
        fWait = New frmWait(1000 * _currentScene.SceneDirectorsIn.MaxFrame / 40)
        fWait.ShowDialog()
      Else
        Dim changeDirector As String = "Change_" & _lastStep & "_" & _nextStep

        _vizControl.DirectorRewind(changeDirector)
        'prepare scene for next step
        _currentScene = Me.PrepareScene(_nextStep)
        'send scene to the next change step
        _currentScene.SendSceneToEngine(_vizControl)
        'start change director
        _vizControl.DirectorStart(changeDirector)
        'wait for animation to end
        fWait = New frmWait(1000 * _currentScene.SceneDirectorsChangeIn.MaxFrame / 40)
        fWait.ShowDialog()
        'animation is done

      End If
      'prepare for next step
      _lastStep = _nextStep
      _nextStep = (_nextStep Mod 2) + 1
      _formerScene = _currentScene

    Catch ex As Exception

    End Try

  End Sub

  Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
    Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
    Me.Close()
  End Sub

  Private Sub DialogChooseWithPreview_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    Try
    Catch ex As Exception

    End Try
  End Sub

  Private Sub MetroGridOptions_SelectionChanged(sender As Object, e As EventArgs) Handles MetroGridSelected.SelectionChanged
    Try
      Me.Scene = Me.PrepareScene(1)

      If Not Me.Scene Is Nothing Then
        If _ucPreview.VizControl Is Nothing Then _ucPreview.VizControl = Me._vizControl
        _ucPreview.GetPreview(Scene)
        _ucPreview.ShowAdvancedControls = False
      End If

    Catch ex As Exception

    End Try
  End Sub

#Region "Constructor"
  Public Sub New(match As Match, ByRef vizControl As VizCommands.VizControl, ByRef previewControl As VizCommands.PreviewControl)

    ' This call is required by the designer.
    InitializeComponent()

    ' Add any initialization after the InitializeComponent() call.
    _match = match
    _vizControl = vizControl
    _previewControl = previewControl
    _ucPreview.PreviewControl = previewControl
    'ShowNextGraphicSteps()
  End Sub
#End Region

#Region "Graphic steps"
  Private Function SelectStep() As GraphicStep
    Dim gSide As GraphicStep = Nothing
    Try
    Catch ex As Exception
      WriteToErrorLog(ex)
    End Try
    Return gSide
  End Function
#End Region


  Enum eTipusLinia
    Normal = 0
    Yellow
    Red
    YellowRed
  End Enum


#Region "Scenes"
  Private Function InitDefaultScene(Optional gSide As Integer = 1) As Scene
    Dim scene As New Scene()

    scene.VizLayer = SceneLayer.Middle
    scene.SceneName = "gfx_leftframer"
    scene.SceneDirector = "DIR_MAIN$In_Out"
    scene.SceneDirectorsIn.Add("DIR_MAIN$In_Out", 0, DirectorAction.Start)
    scene.SceneDirectorsIn.Add("DIR_MAIN$In_Out", 75, DirectorAction.Dummy)
    scene.SceneDirectorsIn.Add("Change_1_2", 0, DirectorAction.Rewind)

    scene.SceneDirectorsOut.Add("DIR_MAIN$In_Out", 0, DirectorAction.ContinueNormal)

    Dim changeAnim As String = "Change_" & ((gSide) Mod 2 + 1) & "_" & ((gSide + 1) Mod 2) + 1
    changeAnim = "Change_1_2"
    'scene.SceneDirectorsChangeOut.Add(changeAnim, 0, DirectorAction.Rewind)
    'scene.SceneDirectorsChangeOut.Add(changeAnim, 50, DirectorAction.Dummy)

    scene.SceneDirectorsChangeIn.Add(changeAnim, 0, DirectorAction.Start)
    scene.SceneDirectorsChangeIn.Add(changeAnim, 50, DirectorAction.Dummy)

    scene.SceneParameters.Add("LeftFramer_Y_Position", "0")

    scene.SceneParameters.Add("LeftFramer_Title_Bar_Side_" & gSide & "_Control_OMO_GV_Choose", "0")
    scene.SceneParameters.Add("LeftFramer_Table_Vis.active", "0")
    scene.SceneParameters.Add("LeftFramer_Stats_Vis.active", "1")

    scene.SceneParameters.Add("LeftFramer_Title_Stats_Side_" & gSide & "_Text_Center", "")
    scene.SceneParameters.Add("LeftFramer_Title_Stats_Side_" & gSide & "_Text_Left", _match.AwayTeam.Name)
    scene.SceneParameters.Add("LeftFramer_Title_Stats_Side_" & gSide & "_Text_Right", _match.HomeTeam.Name)
    scene.SceneParameters.Add("LeftFramer_Title_Stats_Side_" & gSide & "_Text_Team_Left", "")
    scene.SceneParameters.Add("LeftFramer_Title_Stats_Side_" & gSide & "_Text_Team_Right", "")


    Dim prefix As String = ""
    For i As Integer = 1 To 7
      scene.SceneParameters.Add("LeftFramer_Stats_Side_" & gSide & "_Line_" & i & "_Vis.active", "0")

      prefix = "LeftFramer_Stats_Side_" & gSide & "_Subject_0" & i & "_"


      scene.SceneParameters.Add(prefix & "Left_Control_OMO_GV_Chosse", CInt(eTipusLinia.Red))
      scene.SceneParameters.Add(prefix & "Right_Control_OMO_GV_Chosse", CInt(eTipusLinia.Yellow))

      scene.SceneParameters.Add(prefix & "Left_Red_Card_Number", i)
      scene.SceneParameters.Add(prefix & "Left_Score_Text", i)
      scene.SceneParameters.Add(prefix & "Left_Yellow_Card_Number", i)
      scene.SceneParameters.Add(prefix & "Left_YellowRed_Card_Red_Number", i)
      scene.SceneParameters.Add(prefix & "Left_YellowRed_Card_Yellow_Number", i)
      scene.SceneParameters.Add(prefix & "Right_Red_Card_Number", i)
      scene.SceneParameters.Add(prefix & "Right_Score_Text", i)
      scene.SceneParameters.Add(prefix & "Right_Yellow_Card_Number", i)
      scene.SceneParameters.Add(prefix & "Right_YellowRed_Card_Red_Number", i)
      scene.SceneParameters.Add(prefix & "Right_YellowRed_Card_Yellow_Number", i)
      scene.SceneParameters.Add(prefix & "Stat_Name", "stat_name")
      scene.SceneParameters.Add(prefix & "Team_Name", "team name " & i)
    Next

    Return scene
  End Function

  Private Function PrepareScene(gSide As Integer) As Scene
    Dim scene As Scene = Me.InitDefaultScene(gSide)
    Try
      Dim prefix As String
      Dim selected As String
      Dim stat As Stat
      Dim statName As String = ""

      With Me.MetroGridSelected
        For i As Integer = 0 To .Rows.Count - 1D
          scene.SceneParameters.Add("LeftFramer_Stats_Side_" & gSide & "_Line_" & (i + 1) & "_Vis.active", "1")
          prefix = "LeftFramer_Stats_Side_" & gSide & "_Subject_0" & (i + 1) & "_"
          selected = .Rows(i).Cells(ColumnID.Index).Value
          Select Case selected
            Case "Shots"
              scene.SceneParameters.Add(prefix & "Left_Control_OMO_GV_Chosse", CInt(eTipusLinia.Normal))
              scene.SceneParameters.Add(prefix & "Right_Control_OMO_GV_Chosse", CInt(eTipusLinia.Normal))
              statName = Arabic("ATTEMPTS")
              stat = _match.HomeTeam.MatchStats.Shots
              scene.SceneParameters.Add(prefix & "Right_Score_Text", stat.ValueText)
              stat = _match.AwayTeam.MatchStats.Shots
              scene.SceneParameters.Add(prefix & "Left_Score_Text", stat.ValueText)
            Case "Shots_on_target"
              scene.SceneParameters.Add(prefix & "Left_Control_OMO_GV_Chosse", CInt(eTipusLinia.Normal))
              scene.SceneParameters.Add(prefix & "Right_Control_OMO_GV_Chosse", CInt(eTipusLinia.Normal))
              statName = Arabic("ATTEMPTS ON TARGET")
              stat = _match.HomeTeam.MatchStats.ShotsOn
              scene.SceneParameters.Add(prefix & "Right_Score_Text", stat.ValueText)
              stat = _match.AwayTeam.MatchStats.ShotsOn
              scene.SceneParameters.Add(prefix & "Left_Score_Text", stat.ValueText)
            Case "Fouls"
              scene.SceneParameters.Add(prefix & "Left_Control_OMO_GV_Chosse", CInt(eTipusLinia.Normal))
              scene.SceneParameters.Add(prefix & "Right_Control_OMO_GV_Chosse", CInt(eTipusLinia.Normal))
              statName = Arabic("FOULS CONCEDED")
              stat = _match.HomeTeam.MatchStats.Fouls
              scene.SceneParameters.Add(prefix & "Right_Score_Text", stat.ValueText)
              stat = _match.AwayTeam.MatchStats.Fouls
              scene.SceneParameters.Add(prefix & "Left_Score_Text", stat.ValueText)
            Case "Corners"
              scene.SceneParameters.Add(prefix & "Left_Control_OMO_GV_Chosse", CInt(eTipusLinia.Normal))
              scene.SceneParameters.Add(prefix & "Right_Control_OMO_GV_Chosse", CInt(eTipusLinia.Normal))
              statName = Arabic("CORNERS")
              stat = _match.HomeTeam.MatchStats.Corners
              scene.SceneParameters.Add(prefix & "Right_Score_Text", stat.ValueText)
              stat = _match.AwayTeam.MatchStats.Corners
              scene.SceneParameters.Add(prefix & "Left_Score_Text", stat.ValueText)
            Case "Possession"
              scene.SceneParameters.Add(prefix & "Left_Control_OMO_GV_Chosse", CInt(eTipusLinia.Normal))
              scene.SceneParameters.Add(prefix & "Right_Control_OMO_GV_Chosse", CInt(eTipusLinia.Normal))
              statName = Arabic("POSSESSION")
              stat = _match.HomeTeam.MatchStats.Possession
              scene.SceneParameters.Add(prefix & "Right_Score_Text", stat.ValueText)
              stat = _match.AwayTeam.MatchStats.Possession
              scene.SceneParameters.Add(prefix & "Left_Score_Text", stat.ValueText)
            Case "LastPossessions"
              scene.SceneParameters.Add(prefix & "Left_Control_OMO_GV_Chosse", CInt(eTipusLinia.Normal))
              scene.SceneParameters.Add(prefix & "Right_Control_OMO_GV_Chosse", CInt(eTipusLinia.Normal))
              statName = Arabic("POSSESSION - LAST 5")
              stat = _match.HomeTeam.MatchStats.LastPossessions
              scene.SceneParameters.Add(prefix & "Right_Score_Text", stat.ValueText)
              stat = _match.AwayTeam.MatchStats.LastPossessions
              scene.SceneParameters.Add(prefix & "Left_Score_Text", stat.ValueText)
            Case "YCard"
              scene.SceneParameters.Add(prefix & "Left_Control_OMO_GV_Chosse", CInt(eTipusLinia.Yellow))
              scene.SceneParameters.Add(prefix & "Right_Control_OMO_GV_Chosse", CInt(eTipusLinia.Yellow))
              statName = Arabic("YELLOW CARDS")
              stat = _match.HomeTeam.MatchStats.YellowCards
              scene.SceneParameters.Add(prefix & "Right_Yellow_Card_Number", stat.ValueText)
              stat = _match.AwayTeam.MatchStats.YellowCards
              scene.SceneParameters.Add(prefix & "Left_Yellow_Card_Number", stat.ValueText)
            Case "RCard"
              scene.SceneParameters.Add(prefix & "Left_Control_OMO_GV_Chosse", CInt(eTipusLinia.Red))
              scene.SceneParameters.Add(prefix & "Right_Control_OMO_GV_Chosse", CInt(eTipusLinia.Red))
              statName = Arabic("RED CARDS")
              stat = _match.HomeTeam.MatchStats.RedCards
              scene.SceneParameters.Add(prefix & "Right_Red_Card_Number", stat.ValueText)
              stat = _match.AwayTeam.MatchStats.RedCards
              scene.SceneParameters.Add(prefix & "Left_Red_Card_Number", stat.ValueText)
            Case "YCard + RCard"
              scene.SceneParameters.Add(prefix & "Left_Control_OMO_GV_Chosse", CInt(eTipusLinia.YellowRed))
              scene.SceneParameters.Add(prefix & "Right_Control_OMO_GV_Chosse", CInt(eTipusLinia.YellowRed))
              statName = Arabic("CARDS")
              stat = _match.HomeTeam.MatchStats.YellowCards
              scene.SceneParameters.Add(prefix & "Right_YellowRed_Card_Yellow_Number", stat.ValueText)
              stat = _match.AwayTeam.MatchStats.YellowCards
              scene.SceneParameters.Add(prefix & "Left_YellowRed_Card_Yellow_Number", stat.ValueText)
              stat = _match.HomeTeam.MatchStats.RedCards
              scene.SceneParameters.Add(prefix & "Right_YellowRed_Card_Red_Number", stat.ValueText)
              stat = _match.AwayTeam.MatchStats.RedCards
              scene.SceneParameters.Add(prefix & "Left_YellowRed_Card_Red_Number", stat.ValueText)
          End Select
          scene.SceneParameters.Add(prefix & "Stat_Name", statName)
          scene.SceneParameters.Add(prefix & "Team_Name", statName)
        Next
      End With

      Dim y_position As Double
      Dim min_y_position As Double = 100


      'We only send this the first time!
      If _formerScene Is Nothing Then
        y_position = 0 - min_y_position + Me.MetroGridSelected.Rows.Count * (min_y_position / 7)
        scene.SceneParameters.Add("LeftFramer_Y_Position.position", "0 " & CInt(y_position) & " 0 ")
      End If

    Catch ex As Exception

    End Try
    Return scene
  End Function
#End Region

#Region "Preview controls"
  Private Class PreviewRequest
    Public ID As String
    Public Asset As PreviewAsset
    Public Picturebox As PictureBox

    Public Sub New()
    End Sub

    Public Sub New(ByRef asset As PreviewAsset, ByRef pic As PictureBox)
      Me.Asset = asset
      Me.Picturebox = pic
      If Not Me.Asset Is Nothing Then Me.ID = Me.Asset.ID
    End Sub
  End Class

  Private _llistaPreviewRequests As New List(Of PreviewRequest)

  Private Sub GetPreview(ByVal escena As Scene)
    _previewControl.NewAsset(escena)
  End Sub

  Private Sub GetPreview(ByVal escena As Scene, ByRef pic As PictureBox)
    _llistaPreviewRequests.Add(New PreviewRequest(_previewControl.NewAsset(escena), pic))
  End Sub


  Private Sub MetroGridStats_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles MetroGridStats.CellClick
    Try
      Dim selected As String = Me.MetroGridStats.Rows(e.RowIndex).Cells(ColumnID.Index).Value
      Dim found As Boolean = False

      For i As Integer = Me.MetroGridSelected.Rows.Count - 1 To 0 Step -1
        If Me.MetroGridSelected.Rows(i).Cells(ColumnStatsID.Index).Value = selected Then
          found = True
          Me.MetroGridSelected.Rows.RemoveAt(i)
        End If
      Next

      If found = False Then
        Dim item As Integer = Me.MetroGridSelected.Rows.Add(selected)
        Me.MetroGridSelected.Rows(item).Cells(ColumnName.Index).Value = MetroGridStats.Rows(e.RowIndex).Cells(ColumnStatsName.Index).Value
        Me.MetroGridSelected.Rows(item).Cells(ColumnMoveUp.Index).Value = "up"
        Me.MetroGridSelected.Rows(item).Cells(ColumnMoveDown.Index).Value = "down"
        Me.MetroGridSelected.Rows(item).Cells(ColumnRemove.Index).Value = "del"
      End If

      Me.Scene = Me.PrepareScene(1)

      If Not Me.Scene Is Nothing Then
        If _ucPreview.VizControl Is Nothing Then _ucPreview.VizControl = Me._vizControl
        _ucPreview.GetPreview(Scene)
        _ucPreview.ShowAdvancedControls = False
      End If

    Catch ex As Exception

    End Try
  End Sub

  Private Sub MetroGridSelected_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles MetroGridSelected.CellContentClick
    Try
      Dim selected As String = Me.MetroGridSelected.Rows(e.RowIndex).Cells(ColumnID.Index).Value

      Select Case e.ColumnIndex
        Case ColumnRemove.Index
          Me.MetroGridSelected.Rows.RemoveAt(e.RowIndex)
        Case ColumnMoveUp.Index

        Case ColumnMoveDown.Index
      End Select
      If e.ColumnIndex = ColumnRemove.Index Then
      End If

      Me.Scene = Me.PrepareScene(1)

      If Not Me.Scene Is Nothing Then
        If _ucPreview.VizControl Is Nothing Then _ucPreview.VizControl = Me._vizControl
        _ucPreview.GetPreview(Scene)
        _ucPreview.ShowAdvancedControls = False
      End If
    Catch ex As Exception
    End Try
  End Sub
#End Region
End Class