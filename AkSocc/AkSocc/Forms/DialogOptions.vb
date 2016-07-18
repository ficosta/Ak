﻿Imports System.Windows.Forms

Public Class DialogOptions
  Private _graphicVersions As GraphicVersions = GraphicVersions.Instance

  Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
    If AcceptSettings() Then
      Me.DialogResult = System.Windows.Forms.DialogResult.OK
      Me.Close()
    Else
      frmWaitForInput.ShowWaitDialog(Me, "Check that all settings are correct and try again", "Options", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
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
      Me.MetroTextBoxDataBase.Text = AppSettings.Instance.DataBasePath
      Me.MetroTextBoxOtherMatchesFilePath.Text = AppSettings.Instance.OtherMatchesPath
      Me.CheckBoxShowOptionsOnStartup.Checked = AppSettings.Instance.ShowSettingsOnStartup
      Me.MetroCheckBoxUseArabicNames.Checked = AppSettings.Instance.UseArabicNames
      Me.TextBoxVizrtHost.Text = AppSettings.Instance.VizrtHost
      Me.NumericUpDownPort.Value = AppSettings.Instance.VizrtPort
      Me.NumericUpDownPreviewPort.Value = AppSettings.Instance.VizrtPreviewPort

      Me.MetroTextBoxLocalPreviewPath.Text = AppSettings.Instance.PreviewLocalPath
      Me.MetroTextBoxRemotePreviewPath.Text = AppSettings.Instance.PreviewRemotePath

      Dim index As Integer = -1
      Me.ComboBoxSceneVersion.Items.Clear()

      For Each version As GraphicVersion In _graphicVersions
        Me.ComboBoxSceneVersion.Items.Add(version)
        If version.Path = AppSettings.Instance.ScenePath Then
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
        If frmWaitForInput.ShowWaitDialog(Me, "Data base file " & Me.MetroTextBoxDataBase.Text & " doesn't exist. Continue anyway?", "Data base file", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.No Then
          Return False
        End If
      End If

        AppSettings.Instance.DataBasePath = Me.MetroTextBoxDataBase.Text
      AppSettings.Instance.OtherMatchesPath = Me.MetroTextBoxOtherMatchesFilePath.Text
      AppSettings.Instance.ShowSettingsOnStartup = Me.CheckBoxShowOptionsOnStartup.Checked
      AppSettings.Instance.UseArabicNames = Me.MetroCheckBoxUseArabicNames.Checked
      AppSettings.Instance.VizrtHost = Me.TextBoxVizrtHost.Text
      AppSettings.Instance.VizrtPort = Me.NumericUpDownPort.Value
      AppSettings.Instance.VizrtPreviewPort = Me.NumericUpDownPreviewPort.Value
      AppSettings.Instance.PreviewLocalPath = Me.MetroTextBoxLocalPreviewPath.Text
      AppSettings.Instance.PreviewRemotePath = Me.MetroTextBoxRemotePreviewPath.Text

      Dim version As GraphicVersion = CType(Me.ComboBoxSceneVersion.SelectedItem, GraphicVersion)
      GraphicVersions.Instance.SelectedGraphicVersion = version
      If Not version Is Nothing Then
        AppSettings.Instance.ScenePath = version.Path
      End If
      AppSettings.Instance.Save()
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
