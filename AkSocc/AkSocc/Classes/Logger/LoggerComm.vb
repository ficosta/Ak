Imports System.Net
Imports System.Net.Sockets
Imports System.Text

Public Class LoggerComm
#Region "Singleton"
  Private Shared ReadOnly _instance As New Lazy(Of LoggerComm)(Function() New LoggerComm(), System.Threading.LazyThreadSafetyMode.ExecutionAndPublication)

  Private Sub New()
  End Sub

  Public Shared ReadOnly Property Instance() As LoggerComm
    Get
      Return _instance.Value
    End Get
  End Property
#End Region

#Region "Sockets"

#Region "Sockets Jorge"
  Public Shared Function StartClient() As [Boolean]
    ' Data buffer for incoming data.
    Dim bytes As Byte() = New Byte(1023) {}

    ' Connect to a remote device.
    Try
      AppSettings.Instance.LoggerIP = "127.0.0.1"
      AppSettings.Instance.LoggerPort = 2525

      Dim ipAddress As System.Net.IPAddress = System.Net.IPAddress.Parse(AppSettings.Instance.LoggerIP)
      Dim remoteEP As New IPEndPoint(ipAddress, AppSettings.Instance.LoggerPort)

      Dim sender As New Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp)

      ' Connect the socket to the remote endpoint. Catch any errors.
      Try
        sender.Connect(remoteEP)

        ' Encode the data string into a byte array.
        Dim msg As Byte() = Encoding.ASCII.GetBytes("START")

        ' Send the data through the socket.
        Dim bytesSent As Integer = sender.Send(msg)

        ' Receive the response from the remote device.
        Dim bytesRec As Integer = sender.Receive(bytes)

        ' Release the socket.
        sender.Shutdown(SocketShutdown.Both)
        sender.Close()
        Return True
      Catch ane As ArgumentNullException
        MessageBox.Show("ERROR StartClient: ArgumentNullException : " + ane.ToString())
        Return False
      Catch se As SocketException
        MessageBox.Show("ERROR StartClient: SocketException : " + se.ToString())
        Return False

      Catch e As Exception
        MessageBox.Show("ERROR StartClient: Unexpected exception : " + e.ToString())
        Return False

      End Try
    Catch e As Exception
      MessageBox.Show("ERROR StartClient:" + e.ToString())
      Return False
    End Try

  End Function

  Public Shared Function SendSocket(value As String) As String
    Dim msgEcho As String = ""
    If AppSettings.Instance.UseLogger Then

      ' Data buffer for incoming data.
      Dim bytes As Byte() = New Byte(1023) {}

      ' Connect to a remote device.
      Try
        ' Establish the remote endpoint for the socket.
        ' This example uses port 11000 on the local computer.
        Dim ipAddress As System.Net.IPAddress = System.Net.IPAddress.Parse(AppSettings.Instance.LoggerIP)
        Dim remoteEP As New IPEndPoint(ipAddress, AppSettings.Instance.LoggerPort)

        ' Create a TCP/IP  socket.
        Dim sender As New Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp)

        ' Connect the socket to the remote endpoint. Catch any errors.
        Try
          sender.Connect(remoteEP)

          ' Encode the data string into a byte array.
          Dim msg As Byte() = Encoding.ASCII.GetBytes(value)

          ' Send the data through the socket.
          Dim bytesSent As Integer = sender.Send(msg)

          ' Receive the response from the remote device.
          Dim bytesRec As Integer = sender.Receive(bytes)
          msgEcho = Encoding.ASCII.GetString(bytes, 0, bytesRec)

          ' Release the socket.
          sender.Shutdown(SocketShutdown.Both)
          sender.Close()
        Catch ane As ArgumentNullException
          AppSettings.Instance.UseLogger = False
          MessageBox.Show("Connection with LOGGER lost" & vbLf & vbLf & "ArgumentNullException : " + ane.ToString())
        Catch se As SocketException
          AppSettings.Instance.UseLogger = False
          MessageBox.Show("Connection with LOGGER lost" & vbLf & vbLf & "SocketException :" + se.ToString())

        Catch e As Exception
          AppSettings.Instance.UseLogger = False
          MessageBox.Show("Connection with LOGGER lost" & vbLf & vbLf & "ERROR :" + e.ToString())

        End Try
      Catch e As Exception
        AppSettings.Instance.UseLogger = False
        MessageBox.Show("ERROR SendSocket" + e.ToString())
      End Try
    End If
    Return msgEcho
  End Function
#End Region



  Public Shared Function SendTeamsInfo(match As MatchInfo.Match) As Boolean
    Dim bOK As Boolean = False
    Try
      Dim HomeTeamInString As String = "HOMETEAM|" & match.HomeTeam.TeamID & "|" & match.HomeTeam.TeamAELCaption1Name & "|"
      Dim AwayTeamInString As String = "AWAYTEAM|" & match.AwayTeam.TeamID & "|" & match.AwayTeam.TeamAELCaption1Name & "|"
      For i As Integer = 1 To 18
        'Home
        Dim player As MatchInfo.Player
        Dim PlayerID As Integer = 0

        player = match.HomeTeam.GetPlayerByPosicio(i)
        If Not player Is Nothing Then
          HomeTeamInString &= player.PlayerID & "|"
          HomeTeamInString &= player.PlayerName & "|"
        Else
          bOK = False
        End If

        'Away
        player = match.AwayTeam.GetPlayerByPosicio(i)
        If Not player Is Nothing Then
          AwayTeamInString &= player.PlayerID & "|"
          AwayTeamInString &= player.PlayerName & "|"
        Else
          bOK = False
        End If

      Next
      'Remove last |
      HomeTeamInString = HomeTeamInString.Substring(0, HomeTeamInString.Length - 1)
      AwayTeamInString = AwayTeamInString.Substring(0, AwayTeamInString.Length - 1)
      bOK = True

      SendSocket(HomeTeamInString)
      SendSocket(AwayTeamInString)
    Catch ex As Exception
      Console.WriteLine(ex.ToString())
    End Try
    Return bOK
  End Function


  Private Sub GetTeamsStats(match As MatchInfo.Match)
    'Refresh the Match Info
    If AppSettings.Instance.UseLogger Then
      Dim StringHomeStats As String = SendSocket("TEAMSTATSHOME|NadaMas")
      match.HomeTeam.GetFromSocketFormat(StringHomeStats)
      Dim StringAwayStats As String = SendSocket("TEAMSTATSAWAY")
      match.AwayTeam.GetFromSocketFormat(StringAwayStats)
    End If
  End Sub
#End Region
End Class
