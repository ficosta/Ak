Imports MatchInfo

Public Class PlayerViewer
#Region "Definitions"
  Public Event SelectionChanged(ByRef sender As PlayerViewer, value As Boolean)
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
      Me.LabelCards.DataBindings.Clear()
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
      End If
    Catch ex As Exception
      WriteToErrorLog(ex)
    End Try
  End Sub
#End Region


  Private Sub _player_StatValueChanged(sender As StatSubject, stat As Stat) Handles _player.StatValueChanged
    Me.LabelCards.Text = sender.ID
    Debug.Print(Me.Player.ToString & " " & stat.Name & "=" & stat.Value)
    Me.PictureBoxInfo.Visible = (stat.Value > 0)
    UpdateCardControls()
  End Sub


  Private Sub InitPlayer()
    ReleaseDataBinding()
    Me.IsSelected = False
    EngageDataBinding()
  End Sub


#Region "Selection"
  Private Sub ShowSelectionState()
    Try
      Dim font As Font = _defaultFont
      If _IsSelected Then
        ' Me.BackColor = Color.Red
        Me.LabelCards.BackColor = Color.LightSalmon
        font = _selectedFont
      Else
        'Me.BackColor = Color.White
        If _isMouseOver Then
          Me.LabelCards.BackColor = Color.Red
          font = _selectedFont
        Else
          Me.LabelCards.BackColor = Color.White
        End If
      End If
      Me.LabelName.Font = font
      Me.LabelName.Style = MetroFramework.MetroColorStyle.Green
      Me.LabelDorsal.BackColor = Me.LabelCards.BackColor
      Me.LabelName.BackColor = Me.LabelCards.BackColor
      Me.BackColor = Me.LabelCards.BackColor
      Me.LabelName.Invalidate()
    Catch ex As Exception

    End Try
  End Sub

  Private Sub Label_Click(sender As Object, e As EventArgs) Handles LabelDorsal.Click, LabelName.Click, LabelCards.Click
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
  Private _updatingCards As Boolean = False

  Private Sub UpdateCardControls()
    _updatingCards = True
    YellowCardToolStripMenuItem.Checked = Me.Player.MatchStats.YellowCards.Value > 0
    SecondYellowCardToolStripMenuItem.Checked = Me.Player.MatchStats.YellowCards.Value > 1
    RedCardToolStripMenuItem.Checked = Me.Player.MatchStats.RedCards.Value > 0
    _updatingCards = False
  End Sub

  Private Sub YellowCardToolStripMenuItem_CheckedChanged(sender As Object, e As EventArgs) Handles YellowCardToolStripMenuItem.CheckedChanged
    If _updatingCards Then Exit Sub

    If YellowCardToolStripMenuItem.Checked Then
      Me.Player.MatchStats.YellowCards.Value = 1
    Else
      Me.Player.MatchStats.YellowCards.Value = 0
    End If
    UpdateCardControls()
  End Sub

  Private Sub SecondYellowCardToolStripMenuItem_CheckedChanged(sender As Object, e As EventArgs) Handles SecondYellowCardToolStripMenuItem.CheckedChanged
    If _updatingCards Then Exit Sub
    If SecondYellowCardToolStripMenuItem.Checked Then
      Me.Player.MatchStats.YellowCards.Value = 2
    ElseIf YellowCardToolStripMenuItem.Checked Then
      Me.Player.MatchStats.YellowCards.Value = 1
    Else
      Me.Player.MatchStats.YellowCards.Value = 0
    End If
    UpdateCardControls()
  End Sub

  Private Sub RedCardToolStripMenuItem_CheckedChanged(sender As Object, e As EventArgs) Handles RedCardToolStripMenuItem.CheckedChanged
    If _updatingCards Then Exit Sub
    If RedCardToolStripMenuItem.Checked Then
      Me.Player.MatchStats.YellowCards.Value = 1
    Else
      Me.Player.MatchStats.YellowCards.Value = 0
    End If
    UpdateCardControls()
  End Sub
#End Region
End Class
