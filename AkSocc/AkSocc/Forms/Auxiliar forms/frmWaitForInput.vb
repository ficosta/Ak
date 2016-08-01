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
      Return Me.LabelPrompt.Text
    End Get
    Set(value As String)
      Me.LabelPrompt.Text = value
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
          Me.TableLayoutPanel3.ColumnStyles(2).Width = 0
          _dialogResults(0) = DialogResult.OK
        Case MessageBoxButtons.OKCancel
          Me.TableLayoutPanel3.ColumnStyles(2).Width = Me.TableLayoutPanel3.ColumnStyles(1).Width
          _dialogResults(0) = DialogResult.OK
          _dialogResults(1) = DialogResult.Cancel
        Case MessageBoxButtons.YesNo
          Me.TableLayoutPanel3.ColumnStyles(2).Width = Me.TableLayoutPanel3.ColumnStyles(1).Width
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
    Me.LabelPrompt.Text = prompt
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

#Region "Form drag"

  Dim drag As Boolean
  Dim mousex As Integer
  Dim mousey As Integer


  Private Sub Form1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles LabelTitle.MouseDown
    If e.Button = System.Windows.Forms.MouseButtons.Left Then
      drag = True
      mousex = System.Windows.Forms.Cursor.Position.X - Me.Left
      mousey = System.Windows.Forms.Cursor.Position.Y - Me.Top
    End If
  End Sub


  Private Sub Form1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles LabelTitle.MouseMove
    If drag Then
      Me.Top = System.Windows.Forms.Cursor.Position.Y - mousey
      Me.Left = System.Windows.Forms.Cursor.Position.X - mousex
    End If
  End Sub

  Private Sub LabelPrompt_MouseUp(sender As Object, e As MouseEventArgs) Handles LabelTitle.MouseUp
    If e.Button = System.Windows.Forms.MouseButtons.Left Then
      drag = False
    End If
  End Sub

  Public Overrides Property Text As String
    Get
      Return MyBase.Text
    End Get
    Set(value As String)
      Me.LabelTitle.Text = value
      MyBase.Text = value
    End Set
  End Property
#End Region
End Class