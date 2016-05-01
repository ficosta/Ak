Imports System.Windows.Forms

Public Class DialogOptions
  Private _graphicVersions As New GraphicVersions

  Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
    If AcceptSettings() Then
      Me.DialogResult = System.Windows.Forms.DialogResult.OK
      Me.Close()
    Else
      MsgBox("Check that all settings are correct and try again")
    End If

  End Sub

  Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
    Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
    Me.Close()
  End Sub

  Private Sub DialogOptions_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    InitializeSettings()
  End Sub

#Region "Settings"
  Private Sub InitializeSettings()
    Try
      Me.CheckBoxShowOptionsOnStartup.Checked = My.Settings.ShowSettingsOnStartup
      Me.TextBoxVizrtHost.Text = My.Settings.VizrtHost
      Me.NumericUpDownPort.Value = My.Settings.VizrtPort
      Me.NumericUpDownPreviewPort.Value = My.Settings.VizrtPreviewPort

      Dim index As Integer = -1
      Me.ComboBoxSceneVersion.Items.Clear
      For Each version As GraphicVersion In _graphicVersions
        Me.ComboBoxSceneVersion.Items.Add(version)
        If version.Path = My.Settings.ScenePath Then
          index = Me.ComboBoxSceneVersion.Items.Count - 1
        End If
      Next

      If index > -1 Then
        Me.ComboBoxSceneVersion.Text = _graphicVersions(index).Name
      End If

    Catch ex As Exception
      WriteToErrorLog(ex)
    End Try
  End Sub

  Private Function AcceptSettings() As Boolean
    Dim res As Boolean = True
    Try
      My.Settings.ShowSettingsOnStartup = Me.CheckBoxShowOptionsOnStartup.Checked
      My.Settings.VizrtHost = Me.TextBoxVizrtHost.Text
      My.Settings.VizrtPort = Me.NumericUpDownPort.Value
      My.Settings.VizrtPreviewPort = Me.NumericUpDownPreviewPort.Value
      Dim version As GraphicVersion = CType(Me.ComboBoxSceneVersion.SelectedItem, GraphicVersion)
      If Not version Is Nothing Then
        My.Settings.ScenePath = version.Path
      End If
      My.Settings.Save()
    Catch ex As Exception
      WriteToErrorLog(ex)
    End Try
    Return res
  End Function

  Private Sub RejectSettings()
    Try

    Catch ex As Exception
      WriteToErrorLog(ex)
    End Try
  End Sub
#End Region
End Class
