Imports System.Windows.Forms

Public Class DialogOptions
  Private _graphicVersions As GraphicVersions = GraphicVersions.Instance

  Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
    If AcceptSettings() Then
      Me.DialogResult = System.Windows.Forms.DialogResult.OK
      Me.Close()
    Else
      MetroFramework.MetroMessageBox.Show(Me, "Check that all settings are correct and try again", "Options")
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
      Me.MetroTextBoxDataBase.Text = My.Settings.DataBasePath
      Me.MetroTextBoxOtherMatchesFilePath.Text = My.Settings.OtherMatchesPath
      Me.CheckBoxShowOptionsOnStartup.Checked = My.Settings.ShowSettingsOnStartup
      Me.MetroCheckBoxUseArabicNames.Checked = My.Settings.UseArabicNames
      Me.TextBoxVizrtHost.Text = My.Settings.VizrtHost
      Me.NumericUpDownPort.Value = My.Settings.VizrtPort
      Me.NumericUpDownPreviewPort.Value = My.Settings.VizrtPreviewPort

      Me.MetroTextBoxLocalPreviewPath.Text = My.Settings.PreviewLocalPath
      Me.MetroTextBoxRemotePreviewPath.Text = My.Settings.PreviewRemotePath

      Dim index As Integer = -1
      Me.ComboBoxSceneVersion.Items.Clear()

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
      If Not System.IO.File.Exists(Me.MetroTextBoxDataBase.Text) Then
        If MetroFramework.MetroMessageBox.Show(Me, "Data base file " & Me.MetroTextBoxDataBase.Text & " doesn't exist. Continue anyway?", "Data base file", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.No Then
          Return False
        End If
      End If

        My.Settings.DataBasePath = Me.MetroTextBoxDataBase.Text
      My.Settings.OtherMatchesPath = Me.MetroTextBoxOtherMatchesFilePath.Text
      My.Settings.ShowSettingsOnStartup = Me.CheckBoxShowOptionsOnStartup.Checked
      My.Settings.UseArabicNames = Me.MetroCheckBoxUseArabicNames.Checked
      My.Settings.VizrtHost = Me.TextBoxVizrtHost.Text
      My.Settings.VizrtPort = Me.NumericUpDownPort.Value
      My.Settings.VizrtPreviewPort = Me.NumericUpDownPreviewPort.Value
      My.Settings.PreviewLocalPath = Me.MetroTextBoxLocalPreviewPath.Text
      My.Settings.PreviewRemotePath = Me.MetroTextBoxRemotePreviewPath.Text

      Dim version As GraphicVersion = CType(Me.ComboBoxSceneVersion.SelectedItem, GraphicVersion)
      GraphicVersions.Instance.SelectedGraphicVersion = version
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

  Private Sub MetroButtonDataBase_Click(sender As Object, e As EventArgs) Handles MetroButtonDataBase.Click
    Try
      Me.OpenFileDialogDataBase.FileName = Me.MetroTextBoxDataBase.Text
      If Me.OpenFileDialogDataBase.ShowDialog(Me) Then
        Me.MetroTextBoxDataBase.Text = Me.OpenFileDialogDataBase.FileName
      End If
    Catch ex As Exception
      WriteToErrorLog(ex)
    End Try
  End Sub

  Private Sub MetroButtonOtherMatchesPath_Click(sender As Object, e As EventArgs) Handles MetroButtonOtherMatchesPath.Click
    Try
      Me.OpenFileDialogXML.FileName = Me.MetroTextBoxOtherMatchesFilePath.Text
      If Me.OpenFileDialogXML.ShowDialog(Me) Then
        Me.MetroTextBoxOtherMatchesFilePath.Text = Me.OpenFileDialogXML.FileName
      End If
    Catch ex As Exception
      WriteToErrorLog(ex)
    End Try
  End Sub
#End Region
End Class
