Imports MatchInfo
Imports MetroFramework.Controls

Public Class frmOptaPlayerLink
  Private _optaTeam As Team
  Public Property OptaTeam As Team
    Get
      Return _optaTeam
    End Get
    Set(value As Team)
      _optaTeam = value

      Dim teams As New Teams
      teams.GetFromDB("WHERE OptaID = " & _optaTeam.OptaID)
      If teams.Count > 0 Then
        _localTeam = teams(0)
        _localTeam.GetAllPlayers()
      End If
    End Set
  End Property

  Private _allPlayers As Players = Nothing

  Private _localTeam As Team
  Public Property LocalTeam As Team
    Get
      Return _localTeam
    End Get
    Set(value As Team)
      _localTeam = value
    End Set
  End Property

  Private Sub ShowPlayers()
    Try
      Me.Text = "Link opta players for " & Me._localTeam.TeamAELCaption1Name
      If _allPlayers Is Nothing Then
        _allPlayers = New Players
        _allPlayers.GetAllPlayers()
      End If
      ShowPlayers(Me.MetroGridOpta, Me._optaTeam.AllPlayers, True)
      ShowPlayers(Me.MetroGridLocal, Me._localTeam.AllPlayers, False)
      UpdateLinkControls()
    Catch ex As Exception

    End Try
  End Sub

  Private Sub ShowPlayers(grid As MetroGrid, myPlayers As Players, isOpta As Boolean)
    Try
      Dim showPlayers As New List(Of Player)

      With grid

        For Each player As Player In myPlayers
          If isOpta Then
            If player.optaID > 0 Then showPlayers.Add(player)
          Else
            If player.PlayerID > 0 Then showPlayers.Add(player)
          End If
        Next

        .Visible = False
        .Rows.Clear()
        .Rows.Add(showPlayers.Count)

        Dim row As Integer = 0
        For Each player As Player In showPlayers
          .Rows(row).Cells(ColumnTeamID.Index).Value = player.PlayerID
          .Rows(row).Cells(ColumnTeamOptaName.Index).Value = player.optaName
          .Rows(row).Cells(ColumnTeamName.Index).Value = player.PlayerName
          .Rows(row).Cells(ColumnTeamOptaID.Index).Value = player.optaID
          .Rows(row).Cells(ColumnTeamNumber.Index).Value = player.DomesticSquadNo
          .Rows(row).Cells(ColumnTeamOptaNumber.Index).Value = player.OptaSquadNumber
          row += 1
        Next
        .Visible = True
      End With
    Catch ex As Exception
    End Try
  End Sub



#Region "Link / unlink"
  Private _selectedOptaPlayer As Player = Nothing
  Private _selectedLocalPlayer As Player = Nothing

  Private Sub UpdateLinkControls()
    Try
      If Not _selectedLocalPlayer Is Nothing And Not _selectedOptaPlayer Is Nothing Then
        If _selectedLocalPlayer.optaID <> _selectedOptaPlayer.optaID Then
          Me.ButtonLink.Text = "Link"
        Else
          Me.ButtonLink.Text = "Break Link"
        End If
        Me.ButtonLink.Enabled = True
      Else
        Me.ButtonLink.Text = "-"
        Me.ButtonLink.Enabled = False
      End If
    Catch ex As Exception

    End Try

  End Sub

  Private Sub MetroGridOpta_SelectionChanged(sender As Object, e As EventArgs) Handles MetroGridOpta.SelectionChanged
    Try
      If Me.MetroGridOpta.SelectedRows.Count = 0 Then
        _selectedOptaPlayer = Nothing
      Else
        Dim optaID As Integer = Me.MetroGridOpta.SelectedRows(0).Cells(ColumnTeamOptaID.Index).Value
        _selectedOptaPlayer = _optaTeam.GetPlayerByOptaId(optaID)
      End If

      Dim row As Integer = -1
      With Me.MetroGridLocal
        For i As Integer = 0 To .Rows.Count - 1
          If .Rows(i).Cells(ColumnTeamOptaID.Index).Value = _selectedOptaPlayer.optaID Then
            row = i
            Exit For
          End If
        Next
        For i As Integer = 0 To .Rows.Count - 1
          .Rows(i).Selected = False
        Next

        If row <> -1 Then
          .Rows(row).Selected = True
          EnsureRowIsVisible(MetroGridLocal, row)
        End If
      End With

      Me.UpdateLinkControls()
    Catch ex As Exception
    End Try
  End Sub

  Private Sub MetroGridLocal_SelectionChanged(sender As Object, e As EventArgs) Handles MetroGridLocal.SelectionChanged
    Try
      If Me.MetroGridLocal.SelectedRows.Count = 0 Then
        _selectedLocalPlayer = Nothing
      Else
        Dim playerID As Integer = Me.MetroGridLocal.SelectedRows(0).Cells(ColumnTeamID.Index).Value
        _selectedLocalPlayer = _localTeam.GetPlayerById(playerID)
      End If
      Me.UpdateLinkControls()
    Catch ex As Exception
    End Try
  End Sub

  Private Sub ButtonLink_Click(sender As Object, e As EventArgs) Handles ButtonLink.Click
    Try
      If _selectedLocalPlayer Is Nothing Or _selectedOptaPlayer Is Nothing Then
        Exit Sub
      ElseIf _selectedLocalPlayer.optaID <> _selectedOptaPlayer.optaID Then
        For Each player As Player In _localTeam.AllPlayers
          If player.optaID = _selectedOptaPlayer.optaID Then
            player.optaID = -1
            player.UpdatePlayer()
          End If
        Next
        _selectedLocalPlayer.optaID = _selectedOptaPlayer.optaID
        _selectedLocalPlayer.optaName = _selectedOptaPlayer.optaName
        _selectedLocalPlayer.OptaSquadNumber = _selectedOptaPlayer.OptaSquadNumber

        _selectedOptaPlayer.PlayerFirstName = _selectedLocalPlayer.PlayerFirstName
        _selectedOptaPlayer.PlayerSurname = _selectedLocalPlayer.PlayerSurname
        _selectedOptaPlayer.SquadNo = _selectedLocalPlayer.SquadNo



        _selectedLocalPlayer.UpdatePlayer()
        _selectedOptaPlayer.PlayerID = _selectedLocalPlayer.PlayerID
      Else
        _selectedLocalPlayer.optaID = 0
        _selectedOptaPlayer.PlayerID = 0
        _selectedLocalPlayer.UpdatePlayer()
      End If
      Me.ShowPlayers()
    Catch ex As Exception

    End Try
  End Sub

  Private Sub frmOptaPlayerLink_Shown(sender As Object, e As EventArgs) Handles Me.Shown
    Me.ShowPlayers()
  End Sub

  Private Sub MetroGridOpta_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles MetroGridOpta.CellContentClick

  End Sub

  Private Sub frmOptaPlayerLink_Load(sender As Object, e As EventArgs) Handles MyBase.Load

  End Sub

#End Region
End Class