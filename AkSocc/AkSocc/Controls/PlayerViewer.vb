Imports MatchInfo

Public Class PlayerViewer
#Region "Definitions"
  Public Event SelectionChanged(ByRef sender As PlayerViewer, value As Boolean)
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
      End If
    Catch ex As Exception
      WriteToErrorLog(ex)
    End Try
  End Sub
#End Region


  Private Sub _player_StatValueChanged(sender As StatSubject, stat As Stat) Handles _player.StatValueChanged
    Me.LabelCards.Text = sender.ID
  End Sub


  Private Sub InitPlayer()
    ReleaseDataBinding()
    Me.IsSelected = False
    EngageDataBinding()
  End Sub


#Region "Selection"
  Private Sub ShowSelectionState()
    Try
      If _IsSelected Then
        ' Me.BackColor = Color.Red
        Me.LabelCards.BackColor = Color.LightSalmon
      Else
        'Me.BackColor = Color.White
        Me.LabelCards.BackColor = Color.White
      End If
      Me.LabelDorsal.BackColor = Me.LabelCards.BackColor
      Me.LabelName.BackColor = Me.LabelCards.BackColor

    Catch ex As Exception

    End Try
  End Sub

  Private Sub Label_Click(sender As Object, e As EventArgs) Handles LabelDorsal.Click, LabelName.Click, LabelCards.Click
    Try
      Me.IsSelected = True
    Catch ex As Exception

    End Try
  End Sub
#End Region

End Class
