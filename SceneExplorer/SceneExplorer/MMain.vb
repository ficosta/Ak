Imports VizCommands

Module MMain
  Private Const NOM_MODUL As String = "MMain"
  Public Structure tyConfig
    Dim ConfigVizrt As tyConfigVizrt
  End Structure
  Public gudtConfig As tyConfig

  Public frmMainForm As frmMain

  Public Sub ReadConfig()
    Dim dlg As New DialogConfig
    Try
      dlg.ShowDialog()
      If dlg.DialogResult = DialogResult.OK Then
        With gudtConfig.ConfigVizrt
          .TCPHost = dlg.sPuHost
          .TCPPort = 6100
          .UDPSendHost = dlg.sPuHost
          .UDPSendPort = 7124
          .UDPReceiveHost = dlg.sPuHost
          .UDPReceivePort = 7777
        End With
      Else
        With gudtConfig.ConfigVizrt
          .TCPHost = "127.0.0.1"
          .TCPPort = 6100
          .UDPSendHost = "127.0.0.1"
          .UDPSendPort = 7124
          .UDPReceiveHost = "127.0.0.1"
          .UDPReceivePort = 7777
        End With
      End If
    Catch ex As Exception
      'AddError(NOM_MODUL, "ReadConfig", ex.ToString)
    End Try
  End Sub

  Public Function ShowConfig(ByVal Parent As Form) As DialogResult
    Dim dConfig As New DialogConfig
    Dim eRes As DialogResult
    Try
      eRes = dConfig.ShowDialog(Parent)
      Return eRes


    Catch ex As Exception

    End Try
    Return eRes
  End Function

  Public Sub Main()
    Try
      frmMainForm = New frmMain
      Application.Run(frmMainForm)
    Catch ex As Exception
      MsgBox(ex.ToString)
    End Try
  End Sub
End Module
