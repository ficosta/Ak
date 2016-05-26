Imports AkSocc
Imports MatchInfo

Public Class TeamViewer
  Private _team As Team

  Public Event SelectedPlayerChanged(sender As TeamViewer, player As Player)

#Region "properties"

  Public Property Team As Team
    Get
      Return _team
    End Get
    Set(value As Team)
      _team = value
      InitTeam()
    End Set
  End Property

  Private WithEvents _selectedPlayer As Player
  Public Property SelectedPlayer As Player
    Get
      Return _selectedPlayer
    End Get
    Set(value As Player)
      _selectedPlayer = value
      ShowSelectedPlayer()
      RaiseEvent SelectedPlayerChanged(Me, _selectedPlayer)
    End Set
  End Property

#End Region

  Public Sub New()

    ' This call is required by the designer.
    InitializeComponent()

    ' Add any initialization after the InitializeComponent() call.
    InitPlayerViewerEvents()
  End Sub

  Private Sub InitTeam()
    Try
      If Not _team Is Nothing Then
        For index As Integer = 1 To 18
          Dim ctl As PlayerViewer = Me.GetControlForPlayerPosition(index)
          Dim player As Player = _team.MatchPlayers.GetPlayerByPosition(index)
          If Not ctl Is Nothing Then
            ctl.Player = player
          End If
        Next
      End If
    Catch ex As Exception
      WriteToErrorLog(ex)
    End Try
  End Sub

  Public Function GetControlForPlayerPosition(playerPosition As Integer) As PlayerViewer
    Dim res As PlayerViewer = Nothing
    For Each ctl As Control In Me.TableLayoutPanel1.Controls
      Dim pvCtl As PlayerViewer = TryCast(ctl, PlayerViewer)

      If Not pvCtl Is Nothing AndAlso pvCtl.PlayerPosition = playerPosition Then
        res = pvCtl
        Exit For
      End If
    Next
    Return res
  End Function

#Region "PlayerViewer events"
  Private Sub InitPlayerViewerEvents()
    Try
      For Each ctl As Control In Me.TableLayoutPanel1.Controls
        Try
          Dim pvCtl As PlayerViewer = TryCast(ctl, PlayerViewer)
          If Not pvCtl Is Nothing Then
            AddHandler pvCtl.SelectionChanged, AddressOf Me.PlayerViewer_SelectionChanged
          End If
        Catch ex As Exception

        End Try
      Next
    Catch ex As Exception

    End Try
  End Sub

  Private Sub PlayerViewer_SelectionChanged(ByRef sender As PlayerViewer, value As Boolean)
    Try
      If value Then
        Me.SelectedPlayer = sender.Player
        ShowSelectedPlayer()

      End If
    Catch ex As Exception

    End Try
  End Sub

  Private Sub ShowSelectedPlayer()
    Static updating As Boolean = False
    If updating Then Exit Sub
    updating = True

    For Each ctl As Control In Me.TableLayoutPanel1.Controls
      Dim pvCtl As PlayerViewer = TryCast(ctl, PlayerViewer)
      If Not pvCtl Is Nothing Then
        If Not _selectedPlayer Is Nothing And Not pvCtl.Player Is Nothing Then
          If pvCtl.Player.PlayerID = _selectedPlayer.PlayerID Then
            'pvCtl.IsSelected = True
          Else
            pvCtl.IsSelected = False
          End If
        Else
          pvCtl.IsSelected = False
        End If
      End If
    Next
    updating = False
  End Sub


#End Region
End Class
