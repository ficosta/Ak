Imports System.Windows.Forms
Imports VizCommands

Public Class UCStreamControl
  Private _accessLevel As New AccessLevel
  Public ReadOnly Property AccessLevel As AccessLevel
    Get
      SetAccess(Nothing, Nothing)
      Return _accessLevel
    End Get
  End Property

  Private Sub Reset(sender As Object, e As EventArgs)
    _accessLevel.Devices = Nothing
    _accessLevel.Level = 0
    _accessLevel.BannedDevices = Nothing
  End Sub

  Private Sub SetAccess(sender As Object, e As EventArgs)
    Dim targetted As New List(Of String)
    Dim banned As New List(Of String)
    For Each pair As KeyValuePair(Of String, deviceAccessLevel) In _devices
      If pair.Value.IsTargeted Then targetted.Add(pair.Key)
      If pair.Value.IsBanned Then banned.Add(pair.Key)
    Next

    _accessLevel.Devices = targetted.ToArray
    _accessLevel.Level = Me.NumericUpDownLevel.Value
    _accessLevel.BannedDevices = banned.ToArray
  End Sub

#Region "Devices"
  Private Class deviceAccessLevel
    Public ID As String
    Public IsTargeted = False
    Public IsBanned = False

    Public Sub New(id As String)
      Me.ID = id
    End Sub

    Public Overloads Function ToString() As String
      Return Me.ID
    End Function
  End Class
  Private _devices As New SortedDictionary(Of String, deviceAccessLevel)
  Private _selectedDevice As deviceAccessLevel = Nothing

  Private Enum eDeviceCols
    Name = 0
    IsTarget
    IsBanned
    Total
  End Enum

  Private Sub ShowDevices()
    Try
      Me.MetroGridDevices.Rows.Clear()

      For Each pair As KeyValuePair(Of String, deviceAccessLevel) In _devices
        Dim rowIndex As Integer = Me.MetroGridDevices.Rows.Add(pair.Key, pair.Value.IsTargeted, pair.Value.IsBanned)
        Me.MetroGridDevices.Rows(rowIndex).Tag = pair.Key
        'Me.MetroGridDevices.Rows(rowIndex).Cells(eDeviceCols.Name).Value = pair.Key
        'Me.MetroGridDevices.Rows(rowIndex).Cells(eDeviceCols.IsTarget).Value = pair.Value.IsTargeted
        'Me.MetroGridDevices.Rows(rowIndex).Cells(eDeviceCols.IsBanned).Value = pair.Value.IsBanned
      Next

    Catch ex As Exception

    End Try
  End Sub


  Private Sub AddDeviceToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddDeviceToolStripMenuItem.Click
    Try
      Dim sName As String = InputBox("Device external ID", "Add device", "")
      If sName = "" Then Exit Sub

      If _devices.ContainsKey(sName) Then
        MsgBox("Device " & sName & " already created")
        Exit Sub
      End If
      _devices.Add(sName, New deviceAccessLevel(sName))
      ShowDevices()
    Catch ex As Exception
    End Try
  End Sub

  Private Sub RemoveDeviceToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RemoveDeviceToolStripMenuItem.Click
    Try

      If _selectedDevice Is Nothing Then Exit Sub

      If _devices.ContainsKey(_selectedDevice.ID) Then
        _devices.Remove(_selectedDevice.ID)
      End If
      ShowDevices()
    Catch ex As Exception

    End Try
  End Sub
  Private Sub MetroGridDevices_SelectionChanged(sender As Object, e As EventArgs) Handles MetroGridDevices.SelectionChanged
    Try
      If Me.MetroGridDevices.SelectedRows.Count = 0 Then Exit Sub
      If Me.MetroGridDevices.SelectedRows(0).Tag Is Nothing Then Exit Sub

      _selectedDevice = _devices(Me.MetroGridDevices.SelectedRows(0).Tag)

    Catch ex As Exception

    End Try
  End Sub

  Private Sub MetroGridDevices_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles MetroGridDevices.CellContentClick
    Try
      Try

        If Me.MetroGridDevices.SelectedRows.Count = 0 Then Exit Sub
        If Me.MetroGridDevices.SelectedRows(0).Tag Is Nothing Then Exit Sub

        _selectedDevice = _devices(Me.MetroGridDevices.SelectedRows(0).Tag)

        If Not _selectedDevice Is Nothing Then
          Select Case e.ColumnIndex
            Case eDeviceCols.IsTarget
              _selectedDevice.IsTargeted = Not _selectedDevice.IsTargeted
              Me.MetroGridDevices.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = _selectedDevice.IsTargeted
            Case eDeviceCols.IsBanned
              _selectedDevice.IsBanned = Not _selectedDevice.IsBanned
              Me.MetroGridDevices.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = _selectedDevice.IsBanned

          End Select
        End If

      Catch ex As Exception

      End Try
    Catch ex As Exception

    End Try
  End Sub

#End Region

End Class
