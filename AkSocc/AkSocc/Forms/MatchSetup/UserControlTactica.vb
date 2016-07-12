Imports MatchInfo

Public Class UserControlTactica
  Private _size As Double = 50
  Private _benchPlayerLabels As New List(Of Label)
#Region "Properties"
  Private _tactica As Tactic = Nothing
  Public Property Tactic() As Tactic
    Get
      Return _tactica
    End Get
    Set(ByVal value As Tactic)
      _tactica = value
      ShowTactics()
    End Set
  End Property

  Private _team As Team = Nothing
  Public Property Team() As Team
    Get
      Return _team
    End Get
    Set(ByVal value As Team)
      _team = value
      If _tactica Is Nothing And Not _team Is Nothing Then _tactica = _team.Tactic

      If Not _team Is Nothing Then
        _tactica = New Tactic()
        For Each player As Player In _team.MatchPlayers
          Dim pos As PosicioTactic = _tactica.GetPosicioByID(player.Formation_Pos)
          If Not pos Is Nothing Then
            pos.X = Clamp(player.Formation_X, -_scale, _scale)
            pos.Y = Clamp(player.Formation_Y, -_scale, _scale)
          End If
        Next
        InicialitzarVisualitzacioPlayersTeam()
        InicialitzarVisualitzacioAllPlayersTeam()
        ShowTactics()
      End If


    End Set
  End Property


  Public _isLocalTeam As Boolean = True
  Public Property IsLocalTeam As Boolean
    Get
      Return _isLocalTeam
    End Get
    Set(value As Boolean)
      _isLocalTeam = value
    End Set
  End Property

  Private _selectedTactica As Tactic
  Private _selectedPosicio As PosicioTactic = Nothing
  Private _lastSelectedPosicio As PosicioTactic = Nothing
  Private _lastPositionIndex As Integer = 0
  Public Property SelectedPosicio() As PosicioTactic
    Get
      Return _selectedPosicio
    End Get
    Set(ByVal value As PosicioTactic)
      If Not _selectedPosicio Is Nothing Then _lastSelectedPosicio = _selectedPosicio
      _selectedPosicio = value
      Me.MostrarPosicioSeleccionada()
    End Set
  End Property

  Private _lastMousePosition As New PointF
  Private _deltaPosition As New PointF
  Private _scale As Double = 400

  Private _color As Color = Color.AliceBlue
  Public Property Color() As Color
    Get
      Return _color
    End Get
    Set(ByVal value As Color)
      _color = value
      Me.ShowTactic(_tactica, _isLocalTeam, _color)
    End Set
  End Property

#End Region

#Region "Functions"
  Public Sub ClearTactics()

  End Sub
  Public Sub ShowTactics()
    Try
      PopulateTacticWithPlayers(_tactica, _team)
      ' g.Clear(Color.Green)
      If Me.PictureBoxCanvas.Image Is Nothing Then
        Me.PictureBoxCanvas.Image = New Bitmap(Me.PictureBoxCanvas.Width, Me.PictureBoxCanvas.Height, Imaging.PixelFormat.Format32bppArgb)
        Me.PictureBoxCanvas.BackgroundImage = New Bitmap(Me.PictureBoxCanvas.Width, Me.PictureBoxCanvas.Height, Imaging.PixelFormat.Format32bppArgb)
        Dim bmp As New Bitmap(Me.PictureBoxCanvas.Width, Me.PictureBoxCanvas.Height, Imaging.PixelFormat.Format32bppArgb)
        Using g As Graphics = Graphics.FromImage(bmp)
          Dim srcRect As New RectangleF(0, 0, My.Resources.CAMP_PER_OPTA_OK.Width, My.Resources.CAMP_PER_OPTA_OK.Height)
          Dim dstRect As New RectangleF(0, 0, Me.PictureBoxCanvas.BackgroundImage.Width, Me.PictureBoxCanvas.BackgroundImage.Height)
          g.DrawImage(My.Resources.CAMP_PER_OPTA_OK, dstRect, srcRect, GraphicsUnit.Pixel)
        End Using
        Me.PictureBoxCanvas.BackgroundImage = bmp
        Me.PictureBoxCanvas.BackgroundImageLayout = ImageLayout.None
      End If

      Using g As Graphics = Graphics.FromImage(Me.PictureBoxCanvas.Image)
        g.Clear(Color.Transparent)
        'g.DrawImage(My.Resources.CAMP_PER_OPTA_OK, New RectangleF(0, 0, Me.PictureBoxCanvas.Image.Width, Me.PictureBoxCanvas.Image.Height))
      End Using

      'InicialitzarVisualitzacioPlayersTeam(_team, Me.ListViewTeamMatch)
      ShowTactic(_tactica, _isLocalTeam, Me.Color)

      If SelectedPosicio Is Nothing Then
      Else
        Using g As Graphics = Graphics.FromImage(Me.PictureBoxCanvas.Image)
          Dim text As String = ""
          If Not SelectedPosicio.Player Is Nothing Then text = SelectedPosicio.Player.SquadNo
          DrawPlayer(g, SelectedPosicio.X, SelectedPosicio.Y, Brushes.DarkGray, Pens.Black, text, _isLocalTeam, _size, Me.PictureBoxCanvas.Image.Size)
        End Using
      End If
      Me.PictureBoxCanvas.Invalidate()
    Catch ex As Exception

    End Try
  End Sub

  Private Sub ShowTactic(ByVal tactic As Tactic, ByVal isLocal As Boolean, ByVal color As Color)
    Try
      If tactic Is Nothing Then Exit Sub
      If _team Is Nothing Then Exit Sub
      Using b As Brush = New SolidBrush(color)
        Using p As Pen = New Pen(ControlPaint.DarkDark(color), 2)
          'draw tactic players
          Using g As Graphics = Graphics.FromImage(Me.PictureBoxCanvas.Image)
            g.SmoothingMode = Drawing2D.SmoothingMode.AntiAlias
            'If Me.BackgroundImage Is Nothing Then Me.BackgroundImage = Me.PictureBoxCanvas.Image
            'Using g As Graphics = Graphics.FromImage(Me.BackgroundImage)
            For Each pos As PosicioTactic In tactic.LlistaPosicions
              Dim text As String = ""
              If Not pos.Player Is Nothing Then text = pos.Player.SquadNo
              DrawPlayer(g, pos.X, pos.Y, b, p, text, isLocal, _size, Me.PictureBoxCanvas.Image.Size)
            Next
          End Using
          'draw bench players
          For i As Integer = 0 To _benchPlayerLabels.Count - 1
            Dim player As Player = _team.MatchPlayers.GetPlayerByPosition(12 + i)
            _benchPlayerLabels(i).BackColor = color
            If Not player Is Nothing Then
              _benchPlayerLabels(i).Text = player.SquadNo
            Else
              _benchPlayerLabels(i).Text = ""
            End If
          Next
        End Using
      End Using
    Catch ex As Exception
    End Try
  End Sub

  Private Sub DrawPlayer(ByRef g As Graphics, ByVal x As Double, ByVal y As Double, ByVal brush As Brush, ByVal text As String, ByVal isLocal As Boolean, ByVal size As Single, ByVal canvasSize As System.Drawing.Size)
    Try
      Dim rect As RectangleF = GetPlayerRectangleF(x, y, size, canvasSize, isLocal)
      Dim stringFormat As New StringFormat()
      Dim font As New Font("Tahoma", 20, FontStyle.Bold, GraphicsUnit.Pixel, 0)
      stringFormat.Alignment = StringAlignment.Center
      stringFormat.LineAlignment = StringAlignment.Center

      g.FillEllipse(brush, rect)
      g.DrawString(text, font, Brushes.White, rect, stringFormat)
    Catch ex As Exception
    End Try
  End Sub

  Private Sub DrawPlayer(ByRef g As Graphics, ByVal x As Double, ByVal y As Double, ByVal brush As Brush, pen As Pen, ByVal text As String, ByVal isLocal As Boolean, ByVal size As Single, ByVal canvasSize As System.Drawing.Size)
    Try
      Dim rect As RectangleF = GetPlayerRectangleF(x, y, size, canvasSize, isLocal)
      Dim aux As PointF = TranslateImagePositionToTactic(New PointF(rect.X, rect.Y), True)
      Dim stringFormat As New StringFormat()
      Dim font As New Font("Tahoma", 20, FontStyle.Bold, GraphicsUnit.Pixel, 0)
      stringFormat.Alignment = StringAlignment.Center
      stringFormat.LineAlignment = StringAlignment.Center

      g.FillEllipse(brush, rect)
      g.DrawEllipse(pen, rect)

      g.FillRectangle(brush, GetPlayerRectangleF(x, y, size, canvasSize, isLocal))
      g.DrawRectangle(pen, GetPlayerRectangle(x, y, size, canvasSize, isLocal))

      g.DrawString(text, font, Brushes.White, rect, stringFormat)
    Catch ex As Exception
    End Try
  End Sub


  Private Sub PopulateTacticWithPlayers(ByVal tactic As Tactic, ByVal team As Team)
    Try
      If tactic Is Nothing Then Exit Sub
      If team Is Nothing Then Exit Sub
      For Each pos As PosicioTactic In tactic.LlistaPosicions
        pos.Player = team.GetPlayerByPosicio(pos.Posicio)
        If pos.Player Is Nothing Then
          pos.Player = team.GetPlayerByPosicio(pos.Posicio)
        End If
        If Not pos.Player Is Nothing Then
          'pos.X = pos.Player.Formation_X
          'pos.Y = pos.Player.Formation_Y
        End If
        pos.Team = team
      Next
    Catch ex As Exception

    End Try
  End Sub


  Private Sub MostrarPosicioSeleccionada()
    Dim text As String = ""
    If Not _selectedPosicio Is Nothing Then
      text = "Posició " & _selectedPosicio.Posicio & "  "
      If Not _selectedPosicio.Player Is Nothing Then
        text = text & _selectedPosicio.Player.ToString
      End If
      ' UpdateContextMenu
    End If
    Me.LabelSelectedPlayer.Text = text
  End Sub

  Private Sub UpdateContextMenu()
    Try
      For Each itm As ToolStripItem In Me.ContextMenuStripPlayers.Items
        RemoveHandler itm.Click, AddressOf ContextMenuStripPlayers_Click
      Next
      Me.ContextMenuStripPlayers.Items.Clear()
      If Not _selectedPosicio Is Nothing Then
        If Not _selectedPosicio.Team Is Nothing Then
          For Each jugador As Player In _selectedPosicio.Team.AllPlayers
            Dim itm As ToolStripItem = Me.ContextMenuStripPlayers.Items.Add(jugador.ToString)
            AddHandler itm.Click, AddressOf ContextMenuStripPlayers_Click
          Next
        End If
      End If
    Catch ex As Exception

    End Try
  End Sub

#End Region

#Region "Pixel conversion functions"

  Private Function GetPlayerRectangleF(ByVal x As Double, ByVal y As Double, ByVal size As Single, ByVal canvasSize As System.Drawing.Size, ByVal isLocal As Boolean) As RectangleF
    Dim rect As New RectangleF(0, 0, 1, 1)
    Try
      Dim center As PointF = New PointF(x / _scale, y / _scale)
      Dim nx As Double = center.X
      Dim ny As Double = center.Y
      If isLocal = False Then
        nx = -center.X
        ny = -center.Y
      End If

      center.X = canvasSize.Width / 2 + ny * canvasSize.Width * _xScale - size / 2
      center.Y = canvasSize.Height / 2 + nx * canvasSize.Height * _yScale - size / 2

      rect = New RectangleF(center.X, center.Y, size, size)
    Catch ex As Exception
    End Try
    Return rect
  End Function


  Private Function GetPlayerRectangle(ByVal x As Double, ByVal y As Double, ByVal size As Single, ByVal canvasSize As System.Drawing.Size, ByVal isLocal As Boolean) As Rectangle
    Dim rect As New Rectangle(0, 0, 1, 1)
    Try
      Dim center As PointF = New PointF(x / _scale, y / _scale)
      Dim nx As Double = center.X
      Dim ny As Double = center.Y
      If isLocal = False Then
        nx = -center.X
        ny = -center.Y
      End If

      center.X = canvasSize.Width / 2 + ny * canvasSize.Width * _xScale - size / 2
      center.Y = canvasSize.Height / 2 + nx * canvasSize.Height * _yScale - size / 2

      rect = New Rectangle(center.X, center.Y, size, size)
    Catch ex As Exception
    End Try
    Return rect
  End Function


  Private Function GetPlayerRect(ByVal pos As PosicioTactic, ByVal isLocal As Boolean) As RectangleF
    Dim rect As New RectangleF(0, 0, 1, 1)
    Try
      Dim center As PointF
      center = TranslateTacticPositionToImage(New PointF(pos.X, pos.Y), isLocal)

      rect = New RectangleF(center.X, center.Y, _size, _size)
    Catch ex As Exception
    End Try
    Return rect
  End Function

  Private _xScale As Single = 0.82 * 2
  Private _yScale As Single = 0.78 * 2

  Private Function TranslateTacticPositionToImage(ByVal p As PointF, ByVal isLocalTeam As Boolean) As PointF
    Dim center As New PointF(p.X / _scale, p.Y / _scale)
    Dim nx As Double = center.X
    Dim ny As Double = center.Y
    If isLocalTeam = False Then
      nx = -center.X
      ny = -center.Y
    End If
    Try
      Dim canvasSize As Size = Me.PictureBoxCanvas.Image.Size

      center.X = canvasSize.Width / 2 + ny * canvasSize.Width * _xScale - _size / 2
      center.Y = canvasSize.Height / 2 + nx * canvasSize.Height * _yScale - _size / 2

    Catch ex As Exception
    End Try
    Return center
  End Function

  Private Function TranslateImagePositionToTactic(ByVal p As PointF, ByVal isLocalTeam As Boolean) As PointF
    Dim center As New PointF(p.X, p.Y)
    Dim nx As Double = center.X
    Dim ny As Double = center.Y
    Try
      Dim canvasSize As Size = Me.PictureBoxCanvas.Image.Size
      center.Y = (nx - canvasSize.Width / 2 + _size / 2) / (canvasSize.Width * _xScale)
      center.X = (ny - canvasSize.Height / 2 + _size / 2) / (canvasSize.Height * _yScale)
      If isLocalTeam = False Then
        center.X = -center.X
        center.Y = -center.Y
      End If

      center.X = _scale * center.X
      center.Y = _scale * center.Y
      'Debug.Print("TranslateImagePositionToTactic " & p.X & " -> " & center.Y & "    " & p.Y & " -> " & center.X)
      'center.X = center.Y
    Catch ex As Exception
    End Try
    Return center
  End Function
#End Region

#Region "Mouse control"
  Private Function HitTest(ByVal x As Single, ByVal y As Single) As PosicioTactic
    Dim pos As PosicioTactic = Nothing
    Try
      If Not _tactica Is Nothing Then
        For Each aux As PosicioTactic In _tactica.LlistaPosicions
          Dim rect As RectangleF = Me.GetPlayerRect(aux, True)
          If rect.Contains(x, y) Then
            pos = aux
            _isLocalTeam = True
            Debug.Print("HitTest " & CStr(x) & " x " & CStr(y))
          End If

        Next
      End If
    Catch ex As Exception
    End Try
    Return pos
  End Function

  Private Function HitTest(ByVal p As PointF) As PosicioTactic
    Return HitTest(p.X, p.Y)
  End Function

  Private Sub PictureBoxCanvas_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBoxCanvas.MouseDown
    Try
      _lastMousePosition = New PointF(e.X, e.Y) ' TranslateZoomMousePosition(e.X, e.Y)
      SelectedPosicio = Me.HitTest(_lastMousePosition)
      If Not SelectedPosicio Is Nothing Then
        Debug.Print("selected posició " & SelectedPosicio.Posicio)
        Dim isLocal As Boolean = SelectedPosicio.Team.ID = _team.ID
        Dim center As PointF = TranslateTacticPositionToImage(New PointF(SelectedPosicio.X, SelectedPosicio.Y), isLocal)
        _deltaPosition.X = center.X - _lastMousePosition.X
        _deltaPosition.Y = center.Y - _lastMousePosition.Y
      End If
      UpdateContextMenu()
    Catch ex As Exception
    End Try
  End Sub

  Private Sub PictureBoxCanvas_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBoxCanvas.MouseMove
    Dim nextMousePosition As PointF
    nextMousePosition = New PointF(e.X + _deltaPosition.X, e.Y + _deltaPosition.Y) 'TranslateZoomMousePosition(e.X, e.Y)

    Dim isLocal As Boolean = _isLocalTeam

    Dim pos As PointF = TranslateImagePositionToTactic(nextMousePosition, isLocal)

    Debug.Print(Now.ToString() & " PictureBoxCanvas_MouseMove " & pos.ToString)

    Try
      If Not SelectedPosicio Is Nothing Then

        If _isLocalTeam Then
          SelectedPosicio.Y = pos.Y
          SelectedPosicio.X = pos.X
        Else
          SelectedPosicio.Y = pos.Y
          SelectedPosicio.X = pos.X
        End If
        ShowTactics()
      End If
    Catch ex As Exception

    End Try
  End Sub

  Private Sub PictureBoxCanvas_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBoxCanvas.MouseUp
    If Not SelectedPosicio Is Nothing Then
      If Not SelectedPosicio.Player Is Nothing Then
        SelectedPosicio.Player.Formation_X = SelectedPosicio.X * 200
        SelectedPosicio.Player.Formation_Y = SelectedPosicio.Y * 200
      End If
    End If
    SelectedPosicio = Nothing
    ShowTactics()
    Me.UpdateListViewsTeamsIPlayers()
  End Sub
#End Region

  Public Sub New()

    ' This call is required by the Windows Form Designer.
    InitializeComponent()

    ' Add any initialization after the InitializeComponent() call.
    Me.DoubleBuffered = True
    _benchPlayerLabels.Add(Me.Label1)
    _benchPlayerLabels.Add(Me.Label2)
    _benchPlayerLabels.Add(Me.Label3)
    _benchPlayerLabels.Add(Me.Label4)
    _benchPlayerLabels.Add(Me.Label5)
    _benchPlayerLabels.Add(Me.Label6)
    _benchPlayerLabels.Add(Me.Label7)

  End Sub

  Private Sub ContextMenuStripPlayers_Click(ByVal sender As Object, ByVal e As System.EventArgs)
    Try
      If _lastSelectedPosicio Is Nothing Then Exit Sub

      Dim team As Team = Me.Team
      Dim player As Player = Nothing
      For Each aux As Player In team.AllPlayers
        If aux.ToString = sender.text Then
          player = aux
          Exit For
        End If
      Next
      If Not player Is Nothing Then
        player.PlayerPosition = _lastSelectedPosicio.Posicio
        _lastSelectedPosicio.Player = player
        _lastPositionIndex = _lastSelectedPosicio.Posicio
        ShowTactics()
      End If

    Catch ex As Exception

    End Try
  End Sub


#Region "Listview Players i Teams"

  Private Sub InicialitzarVisualitzacioAllPlayersTeam()
    Dim sSelected As String = ""
    Dim CRow As DataGridViewRow = Nothing
    Try
      With MetroGridTeamAll
        .Rows.Clear()

        Dim CPlayer As Player

        Dim sText As String = ""
        Dim x As Integer = 0
        Dim y As Integer = 0
        Dim sNom As String = ""
        Dim bEntrenador As Boolean = False

        For index As Integer = 0 To _team.AllPlayers.Count - 1
          CPlayer = _team.AllPlayers(index)

          .Rows.Add("empty")
          CRow = .Rows(.Rows.Count - 1)

          CRow.Cells(ColumnAllID.Index).Value = CPlayer.PlayerID
          CRow.Cells(ColumnAllName.Index).Value = CPlayer.PlayerName
          CRow.Cells(ColumnAllNumber.Index).Value = CPlayer.SquadNo
        Next
      End With
    Catch ex As Exception
      WriteToErrorLog(ex)
    End Try
  End Sub

  Private Sub InicialitzarVisualitzacioPlayersTeam()
    Dim sSelected As String = ""
    Dim CRow As DataGridViewRow = Nothing
    Try
      With MetroGridPlayers
        .Rows.Clear()

        Dim CPlayer As Player

        Dim sText As String = ""
        Dim x As Integer = 0
        Dim y As Integer = 0
        Dim sNom As String = ""
        Dim bEntrenador As Boolean = False


        For index As Integer = 0 To _team.MatchPlayers.Count - 1
          CPlayer = _team.MatchPlayers(index)
          While .Rows.Count <= CPlayer.Formation_Pos
            .Rows.Add("")
          End While
        Next

        For index As Integer = 0 To _team.MatchPlayers.Count - 1
          CPlayer = _team.MatchPlayers(index)
          If CPlayer.Formation_Pos > 0 Then
            CRow = .Rows(CPlayer.Formation_Pos - 1)
            CRow.Cells(ColumnPlayersID.Index).Value = CPlayer.PlayerID
            CRow.Cells(ColumnPlayersName.Index).Value = CPlayer.PlayerName
            CRow.Cells(ColumnPlayersNumber.Index).Value = CPlayer.SquadNo
            CRow.Cells(ColumnPlayersFormationPos.Index).Value = CPlayer.Formation_Pos
            CRow.Cells(ColumnPlayerFormationX.Index).Value = CPlayer.Formation_X
            CRow.Cells(ColumnPlayerFormationY.Index).Value = CPlayer.Formation_Y
            If CRow.Index < 11 Then
              CRow.DefaultCellStyle.ForeColor = Color.Black
            Else
              CRow.DefaultCellStyle.ForeColor = Color.Gray
            End If
          End If
        Next
      End With
    Catch ex As Exception
      WriteToErrorLog(ex)
    End Try
  End Sub


  Private Sub UpdateListViewsTeamsIPlayers()
    Try
      UpdateListViewTeam()
    Catch ex As Exception
    End Try
  End Sub

  Private Sub UpdateListViewTeam()
    Try
      Dim colorOn As Color = Color.LightGreen
      Dim colorOff As Color = Color.Wheat

      InicialitzarVisualitzacioPlayersTeam()

      With Me.MetroGridTeamAll
        For Each row As DataGridViewRow In .Rows
          Dim player As Player = _team.AllPlayers.GetPlayerByDorsal(row.Cells(ColumnAllNumber.Index).Value)
          If Not player Is Nothing Then
            If player.Formation_Pos > 0 Then
              row.DefaultCellStyle.ForeColor = Color.LightGray
            Else
              row.DefaultCellStyle.ForeColor = Color.Black
            End If
          End If
        Next
      End With

    Catch ex As Exception
    End Try
  End Sub
#End Region

#Region "Players drag-drop"

  Private _dragPlayer As Player
  Private _dragTeam As Team
  Private _dragPlayerIsLocal As Boolean = False

  Private Sub ListViewTactiques_ItemDrag(ByVal sender As Object, ByVal e As System.Windows.Forms.ItemDragEventArgs)
    Dim lvw As ListView = CType(sender, ListView)
    Try
      Dim jugador As Player = Nothing
      _dragPlayerIsLocal = True
      _dragTeam = _team
      _dragPlayer = _dragTeam.GetPlayerById(CInt(e.Item.name))
      If Not _dragPlayer Is Nothing Then
        Me.ToolTipDrag.Show(_dragPlayer.ToString, Me.PictureBoxCanvas)
        lvw.DoDragDrop(lvw.SelectedItems, DragDropEffects.Move)
      End If
      Me.ToolTipDrag.RemoveAll()
    Catch ex As Exception
    End Try
  End Sub
#End Region

  Private Sub UserControlTactica_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles Me.DragDrop
    Dim i As Integer
    For i = 0 To e.Data.GetFormats().Length - 1
      If e.Data.GetFormats()(i).Equals("MatchInfo.Player") Then
        'The data from the drag source is moved to the target.
        Dim p As Point = Me.PointToClient(New Point(e.X, e.Y))
        Dim p0 As Point = Me.PointToClient(New Point(0, 0)) - Me.PictureBoxCanvas.PointToClient(New Point(0, 0))
        Dim p1 As Point = (p0 + New Point(Me.PictureBoxCanvas.Width, Me.PictureBoxCanvas.Height))

        Dim rect As New Rectangle(p0.X, p0.Y, Me.PictureBoxCanvas.Width, Me.PictureBoxCanvas.Height)

        e.Effect = DragDropEffects.None
        If rect.Contains(p) Then
          Dim pos As PosicioTactic = Me.HitTest(p.X - p0.X, p.Y - p0.Y)
          If Not pos Is Nothing Then
            If pos.Team.ID = _dragTeam.ID Then
              pos.Player = _dragPlayer
              For Each player As Player In _team.MatchPlayers
                If player.Formation_Pos = pos.Posicio Then
                  player.Formation_Pos = 0
                  If Me.Team.MatchPlayers.Contains(player) Then Me.Team.MatchPlayers.Remove(player)
                End If
              Next
              If Not Me.Team.MatchPlayers.Contains(_dragPlayer) Then Me.Team.MatchPlayers.Add(_dragPlayer)
              pos.Player.Formation_Pos = pos.Posicio
              _lastPositionIndex = pos.Posicio
              ShowTactics()
                Me.UpdateListViewsTeamsIPlayers()
              End If
            End If
        Else
          'any of the substs?
          For Each lbl As Label In _benchPlayerLabels
            p0 = Me.PointToClient(New Point(0, 0)) - lbl.PointToClient(New Point(0, 0))
            p1 = (p0 + New Point(lbl.Width, lbl.Height))
            rect = New Rectangle(p0.X, p0.Y, lbl.Width, lbl.Height)
            If rect.Contains(p) Then
              Dim posIndex As Integer = 11 + CInt(lbl.Name.Replace("Label", ""))

              For Each player As Player In _team.MatchPlayers
                If player.Formation_Pos = posIndex Then
                  player.Formation_Pos = 0
                  If Me.Team.MatchPlayers.Contains(player) Then Me.Team.MatchPlayers.Remove(player)
                End If
              Next
              If Not Me.Team.MatchPlayers.Contains(_dragPlayer) Then Me.Team.MatchPlayers.Add(_dragPlayer)

              _dragPlayer.Formation_Pos = posIndex
              _lastPositionIndex = posIndex
              ShowTactics()
              Me.UpdateListViewsTeamsIPlayers()
              Exit For
            End If
          Next
        End If

      End If
    Next
  End Sub

  Private Sub PictureBox_DragDrop(sender As Object, e As DragEventArgs)
    Dim i As Integer
    Try
      Dim pic As PictureBox = CType(sender, PictureBox)
      Dim posIndex As Integer = 11 + CInt(pic.Name.Replace("PictureBox", ""))
      For i = 0 To e.Data.GetFormats().Length - 1
        If e.Data.GetFormats()(i).Equals("MatchInfo.Player") Then
          For Each player As Player In _team.MatchPlayers
            If player.Formation_Pos = posIndex Then
              If Not _lastSelectedPosicio Is Nothing Then
                player.Formation_Pos = _lastSelectedPosicio.Posicio
              Else
                player.Formation_Pos = 0
              End If

            End If
          Next
          _lastSelectedPosicio = Nothing
          _dragPlayer.Formation_Pos = posIndex
          _lastSelectedPosicio.Player = _dragPlayer
          ShowTactics()
          Me.UpdateListViewsTeamsIPlayers()

        End If
      Next
    Catch ex As Exception
    End Try

  End Sub

  Private Sub UserControlTactica_DragEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles Me.DragEnter
    Dim i As Integer
    For i = 0 To e.Data.GetFormats().Length - 1
      If e.Data.GetFormats()(i).Equals("System.Windows.Forms.ListView+SelectedListViewItemCollection") Then
        'The data from the drag source is moved to the target.

        Dim p As Point = Me.PointToClient(New Point(e.X, e.Y))
        Dim p0 As Point = Me.PointToClient(New Point(0, 0)) - Me.PictureBoxCanvas.PointToClient(New Point(0, 0))
        Dim p1 As Point = (p0 + New Point(Me.PictureBoxCanvas.Width, Me.PictureBoxCanvas.Height))

        Dim rect As New Rectangle(p0.X, p0.Y, Me.PictureBoxCanvas.Width, Me.PictureBoxCanvas.Height)

        e.Effect = DragDropEffects.Link
        If rect.Contains(p) Then
          Dim pos As PosicioTactic = Me.HitTest(e.X - p0.X, e.Y - p0.Y)
          If Not pos Is Nothing Then
            e.Effect = DragDropEffects.Move
          End If
        End If

      End If
    Next
  End Sub


  Private Sub PictureBox1_DragOver(sender As Object, e As DragEventArgs)
    Try
      Dim i As Integer
      For i = 0 To e.Data.GetFormats().Length - 1
        If e.Data.GetFormats()(i).Equals("MatchInfo.Player") Then
          e.Effect = DragDropEffects.Move
        End If
      Next
    Catch ex As Exception

    End Try
  End Sub

  Private Sub UserControlTactica_DragLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.DragLeave

  End Sub

  Private Sub UserControlTactica_DragOver(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles Me.DragOver
    Dim i As Integer
    For i = 0 To e.Data.GetFormats().Length - 1
      If e.Data.GetFormats()(i).Equals("MatchInfo.Player") Then

        'The data from the drag source is moved to the target.
        Dim p As Point = Me.PointToClient(New Point(e.X, e.Y))
        Dim p0 As Point = Me.PointToClient(New Point(0, 0)) - Me.PictureBoxCanvas.PointToClient(New Point(0, 0))
        Dim p1 As Point = (p0 + New Point(Me.PictureBoxCanvas.Width, Me.PictureBoxCanvas.Height))
        Dim rect As New Rectangle(p0.X, p0.Y, Me.PictureBoxCanvas.Width, Me.PictureBoxCanvas.Height)

        e.Effect = DragDropEffects.None

        If rect.Contains(p) Then
          Dim pos As PosicioTactic = Me.HitTest(p.X - p0.X, p.Y - p0.Y)
          If Not pos Is Nothing Then
            e.Effect = DragDropEffects.Move
          End If
        Else
          'any of the substs?
          For Each lbl As Label In _benchPlayerLabels
            p0 = Me.PointToClient(New Point(0, 0)) - lbl.PointToClient(New Point(0, 0))
            p1 = (p0 + New Point(lbl.Width, lbl.Height))
            rect = New Rectangle(p0.X, p0.Y, lbl.Width, lbl.Height)
            If rect.Contains(p) Then
              e.Effect = DragDropEffects.Move
              Exit For
            End If
          Next
        End If
      End If
    Next
  End Sub

  Public Sub Save()
    Try
      For Each pos As PosicioTactic In Me.Tactic.LlistaPosicions
        pos.Player.Formation_X = pos.X
        pos.Player.Formation_Y = pos.Y

        pos.Player.SaveToDB = True
        pos.Player.WriteStatToDB(pos.Player.MatchStats.Formation_X)
        pos.Player.WriteStatToDB(pos.Player.MatchStats.Formation_Y)
        pos.Player.ReadStatsFromDB()
        pos.Player.SaveToDB = False

      Next
      For Each player As Player In _team.MatchPlayers
        player.SaveToDB = True
        player.WriteStatToDB(player.MatchStats.Formation_Pos)
        player.SaveToDB = False
      Next

    Catch ex As Exception

    End Try
  End Sub

  Private Sub ListViewTeamMatch_SelectedIndexChanged(sender As Object, e As EventArgs)

  End Sub

  Private Sub MetroGridTeamAll_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles MetroGridTeamAll.CellContentClick

  End Sub

  Private Sub MetroGridTeamAll_CellMouseDown(sender As Object, e As DataGridViewCellMouseEventArgs) Handles MetroGridTeamAll.CellMouseDown
    Try
      Try
        Dim jugador As Player = Nothing
        _dragPlayerIsLocal = True
        _dragTeam = _team
        _dragPlayer = _dragTeam.GetPlayerById(CInt(MetroGridTeamAll.Rows(e.RowIndex).Cells(ColumnAllID.Index).Value))
        If Not _dragPlayer Is Nothing Then
          Me.ToolTipDrag.Show(_dragPlayer.ToString, Me.PictureBoxCanvas)
          'lvw.DoDragDrop(lvw.SelectedItems, DragDropEffects.Move)
          MetroGridTeamAll.DoDragDrop(_dragPlayer, DragDropEffects.Move)

        End If
        Me.ToolTipDrag.RemoveAll()
      Catch ex As Exception
      End Try
    Catch ex As Exception

    End Try

  End Sub

  Private Sub ButtonRandom_Click(sender As Object, e As EventArgs) Handles ButtonRandom.Click
    Try
      For posIndex As Integer = 1 To Math.Min(Me.Team.AllPlayers.Count, 18)
        Dim selectedPlayer As Player = Me.Team.AllPlayers(posIndex - 1)
        For i As Integer = _team.MatchPlayers.Count - 1 To 0 Step -1
          Dim player As Player = _team.MatchPlayers(i)
          If player.Formation_Pos = posIndex Then
            player.Formation_Pos = 0
            If Me.Team.MatchPlayers.Contains(player) Then Me.Team.MatchPlayers.RemoveAt(i)
          End If
        Next
        If Not Me.Team.MatchPlayers.Contains(selectedPlayer) Then Me.Team.MatchPlayers.Add(selectedPlayer)

        selectedPlayer.Formation_Pos = posIndex
        _lastPositionIndex = posIndex
      Next
      _tactica.CreateEmptyTactic()
      ShowTactics()
    Catch ex As Exception
      Debug.Print(ex.ToString)
    End Try
  End Sub
End Class
