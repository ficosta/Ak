Public Class DialogConfig
  Public sPuHost As String

  Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
    Me.DialogResult = System.Windows.Forms.DialogResult.OK
    Me.sPuHost = Me.TextBoxHost.Text
    My.Settings.LastHost = Me.TextBoxHost.Text
    My.Settings.Save()
    Me.Close()
  End Sub

  Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
    Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
    Me.Close()
  End Sub

  Private Sub DialogConfig_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    Me.TextBoxHost.Text = My.Settings.LastHost
  End Sub
End Class