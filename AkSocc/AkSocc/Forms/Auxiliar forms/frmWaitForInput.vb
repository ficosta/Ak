Public Class frmWaitForInput
  Public Property Title As String
    Get
      Return Me.Text
    End Get
    Set(value As String)
      Me.Text = value
    End Set
  End Property

  Public Property Prompt As String
    Get
      Return Me.MetroLabelPrompt.Text
    End Get
    Set(value As String)
      Me.MetroLabelPrompt.Text = value
    End Set
  End Property

  Private _buttons As MessageBoxButtons = MessageBoxButtons.OKCancel
  Public Property Buttons As MessageBoxButtons
    Get
      Return _buttons
    End Get
    Set(value As MessageBoxButtons)
      _buttons = value
      InitButtons()
    End Set
  End Property

  Private _dialogResults() As DialogResult = {DialogResult.OK, DialogResult.Cancel}

  Private Sub InitButtons()
    Try
      Select Case _buttons

        Case MessageBoxButtons.OK
          Me.TableLayoutPanel1.ColumnStyles(2).Width = 0
          _dialogResults(0) = DialogResult.OK
        Case MessageBoxButtons.OKCancel
          Me.TableLayoutPanel1.ColumnStyles(2).Width = Me.TableLayoutPanel1.ColumnStyles(1).Width
          _dialogResults(0) = DialogResult.OK
          _dialogResults(1) = DialogResult.Cancel
        Case MessageBoxButtons.YesNo
          Me.TableLayoutPanel1.ColumnStyles(2).Width = Me.TableLayoutPanel1.ColumnStyles(1).Width
          _dialogResults(0) = DialogResult.Yes
          _dialogResults(1) = DialogResult.No
      End Select
    Catch ex As Exception

    End Try
  End Sub


  Public Sub New()

    ' This call is required by the designer.
    InitializeComponent()

    ' Add any initialization after the InitializeComponent() call.

  End Sub

  Public Sub New(prompt As String, title As String, buttons As MessageBoxButtons, icon As MessageBoxIcon)

    ' This call is required by the designer.
    InitializeComponent()

    Me.Text = title
    Me.MetroLabelPrompt.Text = prompt
    Me.Buttons = buttons

  End Sub



  Private Sub frmWait_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    InitButtons()
  End Sub


  Private Sub MetroButtonOK_Click(sender As Object, e As EventArgs)
    Me.DialogResult = _dialogResults(0)
    Me.Close()
  End Sub

  Private Sub MetroButtonCancel_Click(sender As Object, e As EventArgs)
    Me.DialogResult = _dialogResults(1)
    Me.Close()
  End Sub

#Region "Shared functions"

  Public Shared Function ShowWaitDialog(parent As Form, text As String) As DialogResult
    Return frmWaitForInput.ShowWaitDialog(parent, text, My.Application.Info.AssemblyName, MessageBoxButtons.OKCancel, MessageBoxIcon.None)
  End Function

  Public Shared Function ShowWaitDialog(parent As Form, text As String, title As String) As DialogResult
    Return frmWaitForInput.ShowWaitDialog(parent, text, title, MessageBoxButtons.OKCancel, MessageBoxIcon.None)
  End Function

  Public Shared Function ShowWaitDialog(parent As Form, text As String, title As String, buttons As MessageBoxButtons) As DialogResult
    Return frmWaitForInput.ShowWaitDialog(parent, text, title, buttons, MessageBoxIcon.None)
  End Function

  Public Shared Function ShowWaitDialog(parent As Form, text As String, title As String, buttons As MessageBoxButtons, icon As MessageBoxIcon) As DialogResult
    Dim res As DialogResult = DialogResult.Cancel
    Try
      Dim frm As New frmWaitForInput(text, title, buttons, icon)

      res = frm.ShowDialog()
    Catch ex As Exception

    End Try
    Return res
  End Function

  Private Sub ButtonAccept_Click(sender As Object, e As EventArgs) Handles MetroButtonOK.Click
    Me.DialogResult = _dialogResults(0)
    Me.Close()
  End Sub

  Private Sub ButtonCancel_Click(sender As Object, e As EventArgs) Handles ButtonCancel.Click
    Me.DialogResult = _dialogResults(1)
    Me.Close()
  End Sub
#End Region
End Class