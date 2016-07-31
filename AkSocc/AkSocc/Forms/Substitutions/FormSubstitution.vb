Imports MatchInfo

Public Class FormSubstitution
#Region "Variables"
  Private _initializing As Boolean
#End Region
#Region "Properties"
  Private _team As Team
  Public Property Team As Team
    Get
      Return _team
    End Get
    Set(value As Team)
      _team = value
      ShowFieldPlayers()
      ShowBenchPlayers()
      If Not _team Is Nothing Then
        Me.Text = "Substitutions " & _team.TeamAELCaption1Name
      Else
        Me.Text = "Substitutions"
      End If
    End Set
  End Property

  Private _playerIn As Player
  Public Property PlayerIn As Player
    Get
      Return _playerIn
    End Get
    Set(value As Player)
      _playerIn = value
    End Set
  End Property

  Private _playerOut As Player
  Public Property PlayerOut As Player
    Get
      Return _playerOut
    End Get
    Set(value As Player)
      _playerOut = value
    End Set
  End Property
#End Region

#Region "Show functions"
  Private Sub ShowFieldPlayers()
    Me.ShowPlayers(Me.MetroGridField, _team.MatchPlayers, _playerOut, False)
  End Sub

  Private Sub ShowBenchPlayers()
    Me.ShowPlayers(Me.MetroGridBench, _team.MatchPlayers, _playerIn, True)
  End Sub

  Private Sub ShowPlayers(grid As MetroFramework.Controls.MetroGrid, players As Players, selectedPlayer As Player, isBench As Boolean)
    Try
      _initializing = True
      grid.Rows.Clear()
      players.Sort()

      For Each player As Player In players
        Dim showPlayer As Boolean = False
        If isBench = False And player.Formation_Pos <= 11 Then
          showPlayer = True
        ElseIf isBench = True And player.Formation_Pos > 11 Then
          showPlayer = True
        End If
        If showPlayer Then
          Dim itm As Integer = grid.Rows.Add(player.PlayerID, player.SquadNo, player.PlayerName, player.Formation_Pos)
          grid.Rows(itm).Selected = False
        End If

      Next
      If selectedPlayer Is Nothing Then

      End If
    Catch ex As Exception

    End Try
    _initializing = False
  End Sub
#End Region


  Private Sub OK_Button_Click(sender As Object, e As EventArgs) Handles ButtonAdvancedOK.Click
    Try
      If _playerIn Is Nothing Then
        MsgBox("You must select a player to enter the field")
        Exit Sub
      End If
      If _playerOut Is Nothing Then
        MsgBox("You must select a player to leave the field")
        Exit Sub
      End If
      If _playerIn.Formation_Pos <= 11 Then
        MsgBox("Player coming IN is already in the field!")
        Exit Sub
      End If
      If _playerOut.Formation_Pos > 11 Then
        MsgBox("Player going OUT is already out of the field!")
        Exit Sub
      End If
      Me.DialogResult = DialogResult.OK
      Me.Close()
    Catch ex As Exception
      WriteToErrorLog(ex)
    End Try
  End Sub

  Private Sub Cancel_Button_Click(sender As Object, e As EventArgs) Handles ButtonAdvancedCancel.Click
    Try
      Me.DialogResult = DialogResult.Cancel
      Me.Close()
    Catch ex As Exception
      WriteToErrorLog(ex)
    End Try
  End Sub

  Private Sub MetroGridField_SelectionChanged(sender As Object, e As EventArgs) Handles MetroGridField.SelectionChanged
    Try
      If _initializing Then Exit Sub
      Dim id As Integer = -1
      If Me.MetroGridField.SelectedRows.Count > 0 Then
        id = CType(Me.MetroGridField.Rows(Me.MetroGridField.SelectedRows(0).Index).Cells(ColumnID.Index).Value, Integer)
        _playerOut = _team.GetPlayerById(id)
      End If
    Catch ex As Exception
      WriteToErrorLog(ex)
    End Try
  End Sub

  Private Sub MetroGridBench_SelectionChanged(sender As Object, e As EventArgs) Handles MetroGridBench.SelectionChanged
    Try
      If _initializing Then Exit Sub
      Dim id As Integer = -1
      If Me.MetroGridBench.SelectedRows.Count > 0 Then
        id = CType(Me.MetroGridBench.Rows(Me.MetroGridBench.SelectedRows(0).Index).Cells(ColumnID.Index).Value, Integer)
        _playerIn = _team.GetPlayerById(id)
      End If
    Catch ex As Exception
      WriteToErrorLog(ex)
    End Try
  End Sub

  Private Sub FormSubstitution_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    UpdateControlSize()
    Me.ShowFieldPlayers()
    Me.ShowBenchPlayers()
    Me.MetroTextBoxPlayers.Focus()
  End Sub


  Private Sub UpdateControlSize()
    Select Case Me.MetroTabControl1.SelectedIndex
      Case 0
        Me.Height = 250
        Me.MetroTextBoxPlayers.Focus()
      Case 1
        Me.Height = 500
    End Select
  End Sub

  Private Sub MetroTextBoxPlayers_TextChanged(sender As Object, e As EventArgs) Handles MetroTextBoxPlayers.TextChanged
    Try
      Dim aux As String = Me.MetroTextBoxPlayers.Text
      Dim nAux As Integer
      Dim aAux() As String = aux.Split(" ")
      If Integer.TryParse(aAux(0), nAux) Then
        _playerOut = _team.AllPlayers.GetPlayerByDorsal(nAux)
      Else
        _playerOut = Nothing
      End If
      If aAux.Length > 1 Then
        If Integer.TryParse(aAux(1), nAux) Then
          _playerIn = _team.AllPlayers.GetPlayerByDorsal(nAux)
        Else
          _playerIn = Nothing
        End If
      Else
        _playerIn = Nothing
      End If
      If Not _playerIn Is Nothing Then
        Me.MetroLabelINPlayer.Text = "IN " & _playerIn.ToString
      Else
        Me.MetroLabelINPlayer.Text = ""
      End If
      If Not _playerOut Is Nothing Then
        Me.MetroLabelOUTPlayer.Text = "OUT " & _playerOut.ToString
      Else
        Me.MetroLabelOUTPlayer.Text = ""
      End If
    Catch ex As Exception

    End Try
  End Sub

  Private Sub MetroTextBoxPlayers_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MetroTextBoxPlayers.KeyPress
    Try
      Dim aux As String = Me.MetroTextBoxPlayers.Text
    Catch ex As Exception

    End Try
  End Sub

  Private Sub MetroTabControl1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles MetroTabControl1.SelectedIndexChanged
    UpdateControlSize()
  End Sub

  Private Sub MetroButton1_Click(sender As Object, e As EventArgs)

  End Sub

  Private Sub MetroButton2_Click(sender As Object, e As EventArgs)

  End Sub

  Private Sub MetroTextBoxPlayers_Click(sender As Object, e As EventArgs) Handles MetroTextBoxPlayers.Click

  End Sub

  Private Sub FormSubstitution_Shown(sender As Object, e As EventArgs) Handles Me.Shown
    Me.MetroTextBoxPlayers.Focus()
  End Sub

  Private Sub MetroGridField_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles MetroGridField.CellContentClick

  End Sub
End Class