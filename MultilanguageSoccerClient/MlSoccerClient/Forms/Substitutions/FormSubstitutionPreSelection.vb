Public Class FormSubstitutionPreSelection
  Public Enum eSubstitutionType
    Home = 0
    Away
    AlreadyCommitted
  End Enum

  Private _substitutionType As eSubstitutionType = eSubstitutionType.Home
  Public ReadOnly Property SubsitutitonType As eSubstitutionType
    Get
      Return _substitutionType
    End Get
  End Property

  Private Sub FormSubstitutionPreSelection_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    Try
      With Me.MetroGridOptions
        .Rows.Clear()
        .Rows.Add(eSubstitutionType.Home, "Local team substitution")
        .Rows.Add(eSubstitutionType.Away, "Away team substitution")
        .Rows.Add(eSubstitutionType.AlreadyCommitted, "Already committed substitution")
        .Focus()
      End With
    Catch ex As Exception

    End Try
  End Sub

  Private Sub ButtonAdvancedOK_Click(sender As Object, e As EventArgs) Handles ButtonAdvancedOK.Click
    OK()
  End Sub

  Private Sub OK()
    Try
      Dim aux As String = Me.MetroGridOptions.SelectedRows(0).Cells(ColumnType.Index).Value
      _substitutionType = CType(CInt(aux), eSubstitutionType)
    Catch ex As Exception
    End Try
    Me.DialogResult = DialogResult.OK
    Me.Close()
  End Sub

  Private Sub ButtonAdvancedCancel_Click(sender As Object, e As EventArgs) Handles ButtonAdvancedCancel.Click
    Me.DialogResult = DialogResult.Cancel
    Me.Close()
  End Sub

  Private Sub FormSubstitutionPreSelection_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
    Select Case e.KeyCode
      Case Keys.Return
        OK()
    End Select
  End Sub

  Private Sub FormSubstitutionPreSelection_Shown(sender As Object, e As EventArgs) Handles Me.Shown
    Me.KeyPreview = True
    Me.MetroGridOptions.Focus()
  End Sub
End Class