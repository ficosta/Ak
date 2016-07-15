Imports MatchInfo
Imports MetroFramework

Public Class PlayerViewer
#Region "Definitions"
  Public Event SelectionChanged(ByRef sender As PlayerViewer, value As Boolean)
  Public Event GoalScored(ByRef sender As PlayerViewer, add As Boolean)


#End Region

#Region "Variables"
  Private _defaultFont As Font = New Font(Me.Font.Name, Font.Size, FontStyle.Regular)
  Private _selectedFont As Font = New Font(Me.Font.Name, Font.Size, FontStyle.Bold)
#End Region

#Region "Properties"
  Private WithEvents _player As Player
  Public Property Player() As Player
    Get
      Return _player
    End Get
    Set(value As Player)
      _player = value
      InitPlayer()
    End Set
  End Property

  Public Property PlayerPosition As Integer = 0

  Private _IsSelected As Boolean = False
  Public Property IsSelected As Boolean
    Get
      Return _IsSelected
    End Get
    Set(value As Boolean)
      If _IsSelected <> value Then
        _IsSelected = value
        RaiseEvent SelectionChanged(Me, _IsSelected)
      End If
      ShowSelectionState()
    End Set
  End Property

  Private _isMouseOver As Boolean = False
  Private Property IsMouseOver As Boolean
    Get
      Return _isMouseOver
    End Get
    Set(value As Boolean)
      _isMouseOver = value
      ShowSelectionState()
    End Set
  End Property
#End Region

#Region "DataBinding"
  Private Sub ReleaseDataBinding()
    Try
      Me.LabelDorsal.DataBindings.Clear()
      Me.LabelName.DataBindings.Clear()
    Catch ex As Exception
      WriteToErrorLog(ex)
    End Try
  End Sub

  Private Sub EngageDataBinding()
    Try
      If Not _player Is Nothing Then

        Me.LabelDorsal.Text = _player.SquadNo
        Me.LabelName.Text = _player.PlayerName
        AddHandler _player.StatValueChanged, AddressOf _player_StatValueChanged
        Me.UpdateStatInterface()
      End If
    Catch ex As Exception
      WriteToErrorLog(ex)
    End Try
  End Sub
#End Region


  Private Sub _player_StatValueChanged(sender As StatSubject, stat As Stat) Handles _player.StatValueChanged
    Try

      UpdateStatInterface()
    Catch ex As Exception

    End Try
  End Sub


  Private Sub InitPlayer()
    ReleaseDataBinding()
    Me.IsSelected = False
    EngageDataBinding()
    Me.UpdateStatInterface()
  End Sub


#Region "Selection"
  Private Sub ShowSelectionState()
    Try
      Dim font As Font = _defaultFont
      If _IsSelected Then
        ' Me.BackColor = Color.Red
        Me.LabelDorsal.BackColor = Color.LightSalmon
        font = _selectedFont
      Else
        'Me.BackColor = Color.White
        If _isMouseOver Then
          Me.LabelDorsal.BackColor = Color.Red
          font = _selectedFont
        Else
          Me.LabelDorsal.BackColor = Color.White
        End If
      End If
      Me.LabelName.Font = font
      Me.LabelName.Style = MetroFramework.MetroColorStyle.Green
      Me.LabelName.BackColor = Me.LabelDorsal.BackColor
      Me.BackColor = Me.LabelDorsal.BackColor
      Me.LabelName.Invalidate()
    Catch ex As Exception

    End Try
  End Sub

  Private Sub Label_Click(sender As Object, e As EventArgs) Handles LabelDorsal.Click, LabelName.Click
    Try
      Me.IsSelected = True
      Me.IsMouseOver = False
    Catch ex As Exception

    End Try
  End Sub

  Private Sub Label_MouseEnter(sender As Object, e As EventArgs) Handles LabelName.MouseEnter
    Try
      Me.IsMouseOver = True
    Catch ex As Exception

    End Try
  End Sub

  Private Sub Label_MouseLeave(sender As Object, e As EventArgs) Handles LabelName.MouseLeave
    Try
      Me.IsMouseOver = False
    Catch ex As Exception

    End Try
  End Sub

#End Region


#Region "Card controls"


  Private Sub YellowCardToolStripMenuItem_CheckedChanged(sender As Object, e As EventArgs) Handles YellowCardToolStripMenuItem.CheckedChanged
    If _updating Then Exit Sub

    If YellowCardToolStripMenuItem.Checked Then
      Me.Player.YellowCards = 1
    Else
      Me.Player.YellowCards = 0
    End If
    'UpdateStatInterface()
  End Sub

  Private Sub SecondYellowCardToolStripMenuItem_CheckedChanged(sender As Object, e As EventArgs) Handles SecondYellowCardToolStripMenuItem.CheckedChanged
    If _updating Then Exit Sub
    If SecondYellowCardToolStripMenuItem.Checked Then
      Me.Player.YellowCards = 2
    ElseIf YellowCardToolStripMenuItem.Checked Then
      Me.Player.YellowCards = 1
    Else
      Me.Player.YellowCards = 0
    End If
    UpdateStatInterface()
  End Sub

  Private Sub RedCardToolStripMenuItem_CheckedChanged(sender As Object, e As EventArgs) Handles RedCardToolStripMenuItem.CheckedChanged
    If _updating Then Exit Sub
    If RedCardToolStripMenuItem.Checked Then
      Me.Player.RedCards = 1
    Else
      Me.Player.RedCards = 0
    End If
    UpdateStatInterface()
  End Sub
#End Region

#Region "Interface functions"
  Private _updating As Boolean = False

  Public Sub UpdateStatInterface()
    If _updating Then Exit Sub
    _updating = True
    UpdateCardControls()
    UpdateStatInfoBox()
    _updating = False
  End Sub

  Private Sub UpdateCardControls()
    Try
      If Me.Player Is Nothing Then Exit Sub
      YellowCardToolStripMenuItem.Checked = Me.Player.YellowCards > 0
      SecondYellowCardToolStripMenuItem.Checked = Me.Player.YellowCards > 1
      RedCardToolStripMenuItem.Checked = Me.Player.RedCards > 0
      RemoveGoalToolStripMenuItem.Enabled = (Me.Player.Goals > 0)
    Catch ex As Exception
      WriteToErrorLog(ex)
    End Try
  End Sub

  Private Sub UpdateStatInfoBox()
    Try
      If PictureBoxInfo.Image Is Nothing Then PictureBoxInfo.Image = New Bitmap(PictureBoxInfo.ClientSize.Width, PictureBoxInfo.ClientSize.Height)
      Using g As Graphics = Graphics.FromImage(PictureBoxInfo.Image)
        g.Clear(Color.White)
        Dim rect As Rectangle
        Dim span As Integer = 3
        Dim pieceWidth As Integer = PictureBoxInfo.Width / 3
        Dim pieceHeight As Integer = PictureBoxInfo.Height
        If Not Me.Player Is Nothing Then
          'yellow card
          If Me.Player.YellowCards > 0 Then
            rect = New Rectangle(0 * pieceWidth + span, span / 2, pieceWidth - 2 * span, pieceHeight - 2 * span)
            g.FillRectangle(Brushes.Yellow, rect)
            g.DrawRectangle(Pens.DarkGoldenrod, rect)
          End If 'second yellow card
          If Me.Player.YellowCards > 1 Then
            rect = New Rectangle(1 * pieceWidth + span, span / 2, pieceWidth - 2 * span, pieceHeight - 2 * span)
            g.FillRectangle(Brushes.Yellow, rect)
            g.DrawRectangle(Pens.DarkGoldenrod, rect)
          End If
          'red card
          If Me.Player.RedCards > 0 Then
            rect = New Rectangle(0.5 * pieceWidth + span, span, pieceWidth - 2 * span, pieceHeight - span)
            g.FillRectangle(Brushes.Red, rect)
            g.DrawRectangle(Pens.DarkRed, rect)
          End If
          'goals
          If Me.Player.Goals > 0 Then
            rect = New Rectangle(2 * pieceWidth + span, span, pieceWidth - 2 * span, pieceHeight - 2 * span)
            g.FillEllipse(Brushes.LightGray, rect)
            g.DrawEllipse(Pens.Gray, rect)

            Dim stringFormat As New StringFormat()
            stringFormat.Alignment = StringAlignment.Center
            stringFormat.LineAlignment = StringAlignment.Center

            g.DrawString(Me.Player.Goals, Me.Font, Brushes.Black, rect, stringFormat)
          End If
        End If
      End Using
      Me.PictureBoxInfo.Invalidate()
    Catch ex As Exception
      WriteToErrorLog(ex)
    End Try
  End Sub

  Private Sub GoalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GoalToolStripMenuItem.Click

    If MetroMessageBox.Show(Me, "Add goal to player " & Me.Player.PlayerName & "?", "Goal", MessageBoxButtons.OKCancel, MessageBoxIcon.Hand) = DialogResult.OK Then
      RaiseEvent GoalScored(Me, True)
    End If
  End Sub

  Private Sub RemoveGoalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RemoveGoalToolStripMenuItem.Click

    If MetroMessageBox.Show(Me, "Remove goal from player " & Me.Player.PlayerName & "?", "Goal", MessageBoxButtons.OKCancel, MessageBoxIcon.Hand) = DialogResult.OK Then
      RaiseEvent GoalScored(Me, False)
    End If
  End Sub
#End Region
End Class
