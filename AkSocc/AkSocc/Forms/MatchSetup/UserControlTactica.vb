Imports MatchInfo

Public Class UserControlTactica
  Private _size As Double = 50
  Private _benchPlayerPictureBoxes As New List(Of PictureBox)
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
      ShowTactics()

      InicialitzarVisualitzacioPlayersTeam(_team, Me.ListViewTeam)
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

  Private _color As Color = Color.AliceBlue
  Public Property Color() As Color
    Get
      Return _color
    End Get
    Set(ByVal value As Color)
      _color = value
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
          For i As Integer = 0 To _benchPlayerPictureBoxes.Count - 1
            With _benchPlayerPictureBoxes(i)
              If .Image Is Nothing Then
                .Image = New Bitmap(.Width, .Height)
              End If
              Using g As Graphics = Graphics.FromImage(.Image)
                If i + 12 >= _team.MatchPlayers.Count Then
                  DrawPlayer(g, 0, 0, b, p, "-", isLocal, .Image.Width, .Image.Size)
                Else
                  DrawPlayer(g, 0, 0, b, p, _team.MatchPlayers(i + 11).SquadNo, isLocal, .Image.Width, .Image.Size)
                End If
              End Using
            End With
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

  Private Function GetPlayerRectangleF(ByVal x As Double, ByVal y As Double, ByVal size As Single, ByVal canvasSize As System.Drawing.Size, ByVal isLocal As Boolean) As RectangleF
    Dim rect As New RectangleF(0, 0, 1, 1)
    Try
      Dim center As PointF = New PointF(x, y)
      Dim nx As Double = x
      Dim ny As Double = y
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
      Dim center As PointF = New PointF(x, y)
      Dim nx As Double = x
      Dim ny As Double = y
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
      If isLocal Then
        center = TranslateTacticPositionToImage(New PointF(pos.X, pos.Y), isLocal)
      Else
        center = TranslateTacticPositionToImage(New PointF(pos.X, pos.Y), isLocal)
      End If
      center = TranslateTacticPositionToImage(New PointF(pos.X, pos.Y), isLocal)

      rect = New RectangleF(center.X, center.Y, _size, _size)
    Catch ex As Exception
    End Try
    Return rect
  End Function

  Private _xScale As Single = 0.82
  Private _yScale As Single = 0.78

  Private Function TranslateTacticPositionToImage(ByVal p As PointF, ByVal isLocalTeam As Boolean) As PointF
    Dim center As New PointF(p.X, p.Y)
    Dim nx As Double = p.X
    Dim ny As Double = p.Y
    If isLocalTeam = False Then
      nx = -p.X
      ny = -p.Y
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
    Dim nx As Double = p.X
    Dim ny As Double = p.Y
    Try
      Dim canvasSize As Size = Me.PictureBoxCanvas.Image.Size
      center.Y = (nx - canvasSize.Width / 2 + _size / 2) / (canvasSize.Width * _xScale)
      center.X = (ny - canvasSize.Height / 2 + _size / 2) / (canvasSize.Height * _yScale)
      If isLocalTeam = False Then
        center.X = -center.X
        center.Y = -center.Y
      End If

      Debug.Print("TranslateImagePositionToTactic " & p.X & " -> " & center.Y & "    " & p.Y & " -> " & center.X)
      'center.X = center.Y
    Catch ex As Exception
    End Try
    Return center
  End Function

  Private Sub PopulateTacticWithPlayers(ByVal tactic As Tactic, ByVal team As Team)
    Try
      If tactic Is Nothing Then Exit Sub
      If team Is Nothing Then Exit Sub
      For Each pos As PosicioTactic In tactic.LlistaPosicions
        If pos.Player Is Nothing Then
          pos.Player = team.GetPlayerByPosicio(pos.Posicio)
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
    Try
      If Not SelectedPosicio Is Nothing Then
        Dim nextMousePosition As PointF
        nextMousePosition = New PointF(e.X + _deltaPosition.X, e.Y + _deltaPosition.Y) 'TranslateZoomMousePosition(e.X, e.Y)

        Dim isLocal As Boolean = _isLocalTeam
        Dim pos As PointF = TranslateImagePositionToTactic(nextMousePosition, isLocal)

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
    SelectedPosicio = Nothing
    ShowTactics()
  End Sub
#End Region

  Public Sub New()

    ' This call is required by the Windows Form Designer.
    InitializeComponent()

    ' Add any initialization after the InitializeComponent() call.
    Me.DoubleBuffered = True

    _benchPlayerPictureBoxes.Add(Me.PictureBox1)
    _benchPlayerPictureBoxes.Add(Me.PictureBox2)
    _benchPlayerPictureBoxes.Add(Me.PictureBox3)
    _benchPlayerPictureBoxes.Add(Me.PictureBox4)
    _benchPlayerPictureBoxes.Add(Me.PictureBox5)
    _benchPlayerPictureBoxes.Add(Me.PictureBox6)
    _benchPlayerPictureBoxes.Add(Me.PictureBox7)
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
        ShowTactics()
      End If

    Catch ex As Exception

    End Try
  End Sub


#Region "Listview Players i Teams"
  Private Sub InicialitzarVisualitzacioPlayersTeam(ByVal CiTeam As Team, ByVal CiListView As ListView)
    Dim sSelected As String = ""
    Dim CItem As ListViewItem = Nothing
    Try
      With CiListView
        If .SelectedItems.Count > 0 Then
          sSelected = .SelectedItems(0).Name
        End If
        .Items.Clear()

        If CiTeam Is Nothing Then Exit Sub

        .Columns(1).Text = CiTeam.ToString

        Dim CPlayer As Player

        Dim sText As String = ""
        Dim x As Integer = 0
        Dim y As Integer = 0
        Dim sNom As String = ""
        Dim bEntrenador As Boolean = False
        Dim bAltres As Boolean

        For index As Integer = 0 To CiTeam.MatchPlayers.Count - 1
          CPlayer = CiTeam.MatchPlayers(index)
          If CPlayer.PlayerPosition <> "" Then
            bAltres = CPlayer.PlayerPosition > 101
          Else
            CPlayer.PlayerPosition = CStr(index + 1)
          End If
          CItem = .Items.Add(CPlayer.DomesticSquadNo)
          CItem.Name = CStr(CPlayer.PlayerID)
          CItem.SubItems.Add(CPlayer.PlayerName)
          If CPlayer.PlayerPosition <> "" AndAlso (CPlayer.PlayerPosition <= 11 Or CPlayer.SquadNo = 0) Then
            CItem.ForeColor = Color.Black
          Else
            CItem.ForeColor = Color.DarkGray
          End If
        Next
      End With
    Catch ex As Exception
      WriteToErrorLog(ex)
    End Try
  End Sub

  Private Sub ListViewTeamLocal_ItemSelectionChanged(ByVal sender As Object, ByVal e As System.Windows.Forms.ListViewItemSelectionChangedEventArgs) Handles ListViewTeam.ItemSelectionChanged
    If Not _team Is Nothing Then
      ListViewTeam_ItemSelectionChanged(_team, Me.ListViewTeam, e)
    End If
  End Sub

  Private Sub ListViewTeam_ItemSelectionChanged(ByVal team As Team, ByVal sender As ListView, ByVal e As System.Windows.Forms.ListViewItemSelectionChangedEventArgs)
    If team Is Nothing Then Exit Sub
    Static busy As Boolean = False
    If busy Then Exit Sub
    busy = True

    Try
      'If e.Item.Name.ToUpper = "EQUIP" Then
      '  CSubject.CPuTeam = team
      '  CSubject.IDTeam = team.ID
      'Else
      '  Dim CPlayer As Player

      '  CPlayer = team.GetPlayerByID(CInt(e.Item.Name))

      '  If Not CPlayer Is Nothing Then
      '    CSubject.IDTeam = CPlayer.IDTeam
      '    CSubject.IDPlayer = CPlayer.IDPlayer
      '    CSubject.CPuTeam = team
      '    CSubject.CPuPlayer = CPlayer
      '  End If
      'End If
      sender.SelectedIndices.Clear()
    Catch ex As Exception
      WriteToErrorLog(ex)
    End Try
    busy = False
  End Sub

  Private Sub UpdateListViewsTeamsIPlayers()
    Try
      UpdateListViewTeam(_team, Me.ListViewTeam)
    Catch ex As Exception
    End Try
  End Sub

  Private Sub UpdateListViewTeam(ByVal team As Team, ByVal listView As ListView)
    Try
      Dim colorOn As Color = Color.LightGreen
      Dim colorOff As Color = Color.Wheat

      For Each item As ListViewItem In listView.Items
        Dim isSelected As Boolean

        'If item.Name.ToUpper = "EQUIP" Then
        '  isSelected = Not (Me.CPuGraficEstadistic.GetSubject(team.IDTeam, 0) Is Nothing)
        'Else
        '  isSelected = Not (Me.CPuGraficEstadistic.GetSubject(team.IDTeam, CInt(item.Name)) Is Nothing)
        'End If

        Dim color As Color = CType(IIf(isSelected, colorOn, colorOff), Color)

        If item.Index Mod 2 = 0 Then color = ControlPaint.LightLight(color)



        item.BackColor = color
      Next
    Catch ex As Exception
    End Try
  End Sub


  Private Sub ListViewTactiques_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles ListViewTeam.DragDrop
    Dim lvw As ListView = CType(sender, ListView)
    'Return if the items are not selected in the ListView control.
    If lvw.SelectedItems.Count = 0 Then Return
    'Returns the location of the mouse pointer in the ListView control.
    Dim p As Point = lvw.PointToClient(New Point(e.X, e.Y))
    'Obtain the item that is located at the specified location of the mouse pointer.
    Dim dragToItem As ListViewItem = lvw.GetItemAt(p.X, p.Y)
    If dragToItem Is Nothing Then Return
    'Obtain the index of the item at the mouse pointer.
    Dim dragIndex As Integer = dragToItem.Index
    Dim i As Integer
    Dim sel(lvw.SelectedItems.Count) As ListViewItem
    For i = 0 To lvw.SelectedItems.Count - 1
      sel(i) = lvw.SelectedItems.Item(i)
    Next
    For i = 0 To lvw.SelectedItems.Count - 1
      'Obtain the ListViewItem to be dragged to the target location.
      Dim dragItem As ListViewItem = sel(i)
      Dim itemIndex As Integer = dragIndex
      If itemIndex = dragItem.Index Then Return
      If dragItem.Index < itemIndex Then
        itemIndex = itemIndex + 1
      Else
        itemIndex = dragIndex + i
      End If
      'Insert the item in the specified location.
      Dim insertitem As ListViewItem = CType(dragItem.Clone, ListViewItem)
      insertitem.Name = dragItem.Name
      lvw.Items.Insert(itemIndex, insertitem)
      'Removes the item from the initial location while 
      'the item is moved to the new location.
      lvw.Items.Remove(dragItem)
    Next
  End Sub

  Private Sub ListViewTactiques_DragEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles ListViewTeam.DragEnter

    Dim i As Integer
    For i = 0 To e.Data.GetFormats().Length - 1
      If e.Data.GetFormats()(i).Equals("System.Windows.Forms.ListView+SelectedListViewItemCollection") Then
        'The data from the drag source is moved to the target.
        e.Effect = DragDropEffects.Move
      End If
    Next
  End Sub

#End Region

#Region "Players drag-drop"

  Private Sub PictureBoxCanvas_DragEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles PictureBoxCanvas.DragEnter
    Dim i As Integer
    For i = 0 To e.Data.GetFormats().Length - 1
      If e.Data.GetFormats()(i).Equals("System.Windows.Forms.ListView+SelectedListViewItemCollection") Then
        'The data from the drag source is moved to the target.
        e.Effect = DragDropEffects.Move
      End If
    Next
  End Sub

  Private _dragPlayer As Player
  Private _dragTeam As Team
  Private _dragPlayerIsLocal As Boolean = False

  Private Sub ListViewTactiques_ItemDrag(ByVal sender As Object, ByVal e As System.Windows.Forms.ItemDragEventArgs) Handles ListViewTeam.ItemDrag
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
      If e.Data.GetFormats()(i).Equals("System.Windows.Forms.ListView+SelectedListViewItemCollection") Then
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
              _lastSelectedPosicio = pos
              _dragPlayer.PlayerPosition = _lastSelectedPosicio.Posicio
              _lastSelectedPosicio.Player = _dragPlayer

              ShowTactics()
            End If
          End If
        End If

      End If
    Next
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

        e.Effect = DragDropEffects.None
        If rect.Contains(p) Then
          Dim pos As PosicioTactic = Me.HitTest(e.X - p0.X, e.Y - p0.Y)
          If Not pos Is Nothing Then
            e.Effect = DragDropEffects.Move
          End If
        End If

      End If
    Next
  End Sub

  Private Sub UserControlTactica_DragLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.DragLeave

  End Sub

  Private Sub UserControlTactica_DragOver(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles Me.DragOver
    Dim i As Integer
    For i = 0 To e.Data.GetFormats().Length - 1
      If e.Data.GetFormats()(i).Equals("System.Windows.Forms.ListView+SelectedListViewItemCollection") Then
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
              e.Effect = DragDropEffects.Move
            End If
          End If
        End If


      End If
    Next
  End Sub

End Class
