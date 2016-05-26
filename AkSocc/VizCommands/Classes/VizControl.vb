Imports System.IO.Ports
Imports System.Net.Sockets

Public Structure tyConfigVizrt
  Dim ID As Integer
  Dim TCPHost As String
  Dim TCPPort As Integer
  Dim UDPSendHost As String
  Dim UDPSendPort As Integer
  Dim UDPReceiveHost As String
  Dim UDPReceivePort As Integer
  Dim SceneBasePath As String
  Dim Idioma As Integer
  Dim UcaseTexts As Boolean
End Structure

Public Enum eSocketState
  Disconnected
  Connected
  Connecting
  ErrorState
End Enum

Public Enum eVizrtCommands
  None
  AskForVersion
  LoadScene
  UnloadScenes
  GetActiveScene
  ActivateScene
  DirectorRewindAll
  DirectorStartAll
  DirectorContinueAll
  DirectorContinueAllReverse
  DirectorRewind
  DirectorStart
  DirectorStop
  DirectorContinue
  DirectorContinueReverse
  DirectorGoTo
  DirectorGetStatus
  DirectorGetStartTime
  DirectorGetEndTime
  DirectorGetKeyframeTime
  StageGetDirectors
  StopDirector
  GetAllDirectors
  GetAllScenes
  GetLoadedScenes
  GetScenePathFromID
  GetScenesAtPath
  GetImagesAtPath
  GetFontsAtPath
  GetNodesAtPath
  GetSceneTree
  GetNodePosition
  SetNodePosition
  GetNodeRotation
  SetNodeRotation
  GetNodeScaling
  SetNodeScaling
  GetNodeText
  SetNodeText
  GetNodeImage
  SetNodeImage
  SetNodeActive
  GetNodeActive
  ShowBoundingBox
  HideBoundingBox
  SetSelectedNode
  SetControlObjectValue
  GetControlObjectFields
  GetControlobjectPrepare
  PostRenderConfigure
  PostRenderExecute
  ClockStart
  ClockStop
  ClockSet
  ClockSetDirection
  ClockSetLimit
  GetMemoryStats
  GetIcon
  ScriptInstanceInvoke
  SetCameraParameters
  SetCameraParameter
  SetCameraDeformationMode
  GetSceneBackgroundImageActive
  SetSceneBackgroundImageActive
  TakeSnapshot
End Enum

Public Enum eRendererLayers
  MidleLayer
  FrontLayer
  BackLayer
End Enum

Public Structure tyDirectorStatus
  Dim Status As String
  Dim Aux As Double
  Dim Position As Double
End Structure

Public Structure tyTreeNode
  Dim Path As String
  Dim Name As String
  Dim HasSubNodes As Boolean
End Structure

Public Class Command
  Public ID As Integer
  Public VizrtCommand As eVizrtCommands
  Public Source As String
  Public Data As String
  Public SentData As String
  Public ReceivedData As String
  Public BoolWasResponse As Boolean
  Public BoolError As Boolean
  Public Layer As eRendererLayers
  Public Host As String
  Public Icon As Boolean = False
  Public Image As System.Drawing.Bitmap = Nothing


  Public Sub New()
    Me.ID = 0
    Me.VizrtCommand = eVizrtCommands.None
    Me.BoolError = False
    Me.BoolWasResponse = False
    Me.Source = ""
    Me.Layer = eRendererLayers.MidleLayer
    Me.ReceivedData = ""
    Me.SentData = ""
    Me.Data = ""
    Me.Host = ""
  End Sub

  Public Sub New(ByVal eiVizrtCommand As eVizrtCommands)
    Me.ID = 0
    Me.VizrtCommand = eiVizrtCommand
    Me.BoolError = False
    Me.BoolWasResponse = False
    Me.Source = ""
    Me.Layer = eRendererLayers.MidleLayer
    Me.ReceivedData = ""
    Me.SentData = ""
    Me.Data = ""
    Me.Host = ""
  End Sub

  Public Sub New(ByVal eiVizrtCommand As eVizrtCommands, ByVal siSource As String)
    Me.ID = 0
    Me.VizrtCommand = eiVizrtCommand
    Me.BoolError = False
    Me.BoolWasResponse = False
    Me.Source = siSource
    Me.Layer = eRendererLayers.MidleLayer
    Me.ReceivedData = ""
    Me.SentData = ""
    Me.Data = ""
    Me.Host = ""
  End Sub

  Public Sub New(ByVal eiVizrtCommand As eVizrtCommands, ByVal siSource As String, ByVal eiLayer As eRendererLayers)
    Me.ID = 0
    Me.VizrtCommand = eiVizrtCommand
    Me.BoolError = False
    Me.BoolWasResponse = False
    Me.Source = siSource
    Me.Layer = eiLayer
    Me.ReceivedData = ""
    Me.SentData = ""
    Me.Data = ""
    Me.Host = ""
  End Sub
End Class

Public Structure tyCameraParameters
  Dim CameraIndex As Integer
  Dim FOVX, FOVY, k1, k2, lx, ly, cx, cy As Single
  Dim Nodal As String
  Dim Deformation_Mode As Integer
End Structure

Public Enum eCameraParameters As Integer
  FOVX
  FOVY
  K1
  K2
  LX
  LY
  CXC
  CYC
  NODAL
  MODE
End Enum

Public Class VizControl
  Private WithEvents CPiSocketTCP As SocketClient
  Private WithEvents CPiSocketUDPSend As Socket
  Private WithEvents CPiSocketUDPReceive As Socket

  Private LlistaComandes As New List(Of Command)
  Private LlistaComandesSenseResposta As New List(Of Command)
  Private LlistaDataArrivalTCP As New List(Of String)

  Public Config As tyConfigVizrt

  Public Event TCPSocketConnected()
  Public Event TCPSocketDisconnected()
  Public Event UDPSendSocketConnected()
  Public Event UDPSendSocketDisconnected()
  Public Event UDPReceiveSocketConnected()
  Public Event UDPReceiveSocketDisconnected()
  Public Event RawDataSent(ByVal sData As String)
  Public Event RawDataArrival(ByVal sData As String)
  Public Event CommandSent(ByVal CCommand As Command)
  Public Event CommandResponse(ByVal CCommand As Command)
  Public Event DataArrival(ByVal nIndex As Integer, ByVal sData As String, ByVal bError As Boolean)

  Public Event DataArrivalSceneAnimations(ByVal ListAnimations As List(Of String))
  Public Event DataArrivalNodePosition(ByVal Node As String, ByVal X As Single, ByVal Y As Single, ByVal Z As Single)
  Public Event DataArrivalNodeRotation(ByVal Node As String, ByVal X As Single, ByVal Y As Single, ByVal Z As Single)
  Public Event DataArrivalNodeScaling(ByVal Node As String, ByVal X As Single, ByVal Y As Single, ByVal Z As Single)
  Public Event DataArrivalNodeText(ByVal Node As String, ByVal Text As String)
  Public Event DataArrivalGetActiveScene(ByVal sScene As String)
  Public Event DataArrivalDirectorGetStatus(ByVal sStatus As String, ByVal diPosition As Double, ByVal diAux As Double)
  Public Event DataArrivalDirectorGetStartTime(ByVal sDirector As String, ByVal diPosition As Double, ByVal diAux As Double)
  Public Event DataArrivalDirectorGetEndTime(ByVal sDirector As String, ByVal diPosition As Double, ByVal diAux As Double)
  Public Event DataArrivalDirectorKeyFrameTime(ByVal sDirector As String, ByVal keyFrame As String, ByVal diPosition As Double)
  Public Event DataArrivalStageGetDirectors(ByVal Llista As List(Of String))
  Public Event DataArrivalGetMemoryStats(ByVal dTotal As Double, ByVal dPixel As Double, ByVal dAllocated As Double, ByVal dSize As Double)
  Public Event DataArrivalGetScenePathFromID(ByVal sID As String, ByVal sPath As String)
  Public Event DataArrivalGetFontsAtPath(ByVal sPath As String, ByVal Llista As List(Of String))
  Public Event DataArrivalGetImagesAtPath(ByVal sPath As String, ByVal Llista As List(Of String))
  Public Event DataArrivalGetNodesAtPath(ByVal sPath As String, ByVal Llista As List(Of tyTreeNode))
  Public Event DataArrivalGetScenesAtPath(ByVal sPath As String, ByVal Llista As List(Of String))
  Public Event DataArrivalGetIcon(ByVal sSource As String, ByVal Image As System.Drawing.Bitmap)
  Public Event DataArrivalGetSceneBackgroundImageActive(ByVal bActive As Boolean)

  'Extended version
  Public Event TCPSocketConnected_Ex(ByVal sender As Object)
  Public Event DataArrivalGetActiveScene_Ex(ByVal sender As Object, ByVal sScene As String)
  Public Event DataArrivalGetLoadedScenes_Ex(ByVal sender As Object, ByVal asScenes() As String)
  Public Event DataArrivalGetScenePathFromID_Ex(ByVal sender As Object, ByVal sID As String, ByVal sPath As String)

  'Camera controls
  Public CameraParameters As List(Of tyCameraParameters)
  Public Event DataArrivalGetCameraParameters(ByVal CameraParameters As tyCameraParameters)


  'socket states
  Private ePiSocketStateTCP As eSocketState
  Private ePiSocketStateUDPSend As eSocketState
  Private ePiSocketStateUDPReceive As eSocketState

  'work variables
  Private nPiLastCommand As Integer

  Private bPiExit As Boolean
  Private bPiLooping As Boolean = False
  Private bPiExpectingIcon As Boolean = False

  Public AskForResponse As Boolean = True

  Public ReadOnly Property SocketStateTCP() As eSocketState
    Get
      Return ePiSocketStateTCP
    End Get
  End Property
  Public ReadOnly Property SocketStateUDPSend() As eSocketState
    Get
      Return ePiSocketStateUDPSend
    End Get
  End Property
  Public ReadOnly Property SocketStateUDPReceive() As eSocketState
    Get
      Return ePiSocketStateUDPReceive
    End Get
  End Property

  Public Sub InitializeSockets(ByVal tiConfig As tyConfigVizrt)
    Try
      Debug.Print(Me.ToString)

      Me.Config = tiConfig
      InitializeSockets()

    Catch ex As Exception
      'AddError(Me.ToString, "InitializeSockets", ex.ToString)
    End Try
  End Sub

  Public Sub InitializeSockets()
    Dim ip As System.Net.IPAddress
    Dim ipAddresses() As System.Net.IPAddress
    Dim endpoint As System.Net.IPEndPoint
    Try
      Debug.Print(Me.ToString)

      With Config

        'socket nou
        Dim CInfo As New System.Net.Sockets.SocketInformation()
        CPiSocketTCP = New SocketClient()
        ePiSocketStateTCP = eSocketState.Connecting
        CPiSocketTCP.Connect(.TCPHost, .TCPPort)
        CPiSocketTCP.LineMode = False
        CPiSocketTCP.NoDelay = True

        ipAddresses = System.Net.Dns.GetHostAddresses(.UDPSendHost)
        If ipAddresses.Length > 0 Then
          ip = ipAddresses(0)
          endpoint = New System.Net.IPEndPoint(ip, .UDPSendPort)
          CPiSocketUDPSend = New Socket(endpoint.AddressFamily, SocketType.Dgram, ProtocolType.Udp)
          CPiSocketUDPSend.Connect(.UDPSendHost, .UDPSendPort)
        End If

        ipAddresses = System.Net.Dns.GetHostAddresses(.UDPSendHost)
        If ipAddresses.Length > 0 Then
          ip = ipAddresses(0)
          endpoint = New System.Net.IPEndPoint(ip, .UDPReceivePort)
          CPiSocketUDPReceive = New Socket(endpoint.AddressFamily, SocketType.Dgram, ProtocolType.Udp)
          CPiSocketUDPReceive.Connect(.UDPReceiveHost, .UDPReceivePort)
        End If
      End With

    Catch ex As Exception
      'AddError(ex.Source, ex.ToString)
    End Try
  End Sub

  Public Sub CloseSockets()
    Try
      If Not CPiSocketTCP Is Nothing Then CPiSocketTCP.Close()
      If Not CPiSocketUDPSend Is Nothing Then CPiSocketUDPSend.Close()
      If Not CPiSocketUDPReceive Is Nothing Then CPiSocketUDPReceive.Close()

    Catch ex As Exception
      'AddError(ex.Source, ex.ToString)
    End Try
  End Sub

  Public Function ActivateScene(ByVal siFullPath As String, Optional ByVal eiLayer As eRendererLayers = eRendererLayers.MidleLayer) As Integer
    Dim sRenderer As String = ""
    Try
      Dim CCommand As New Command(eVizrtCommands.ActivateScene, siFullPath, eiLayer)
      Select Case eiLayer
        Case eRendererLayers.BackLayer
          sRenderer = "RENDERER*BACK_LAYER"
        Case eRendererLayers.FrontLayer
          sRenderer = "RENDERER*FRONT_LAYER"
        Case eRendererLayers.MidleLayer
          sRenderer = "RENDERER"
      End Select
      If siFullPath <> "" Then
        CCommand.SentData = sRenderer & " SET_OBJECT SCENE*" & siFullPath
      Else
        CCommand.SentData = sRenderer & " SET_OBJECT"
      End If
      If siFullPath.Length > 0 Then
        Me.ActivateScene("", eiLayer)
      End If
      LlistaComandes.Add(CCommand)
      'desactivem lo que hi hagi per seguretat...
      CCommand.ID = SendTCPCommand(CCommand)
      'Me.GetLoadedScenes()
      Return CCommand.ID
    Catch ex As Exception
      'AddError(ex.Source, ex.ToString)
    End Try
  End Function


  Public Function UnloadScenes() As Integer
    Dim sRenderer As String = ""
    Try
      Dim CCommand As New Command(eVizrtCommands.UnloadScenes)

      Me.ActivateScene("", eRendererLayers.BackLayer)
      Me.ActivateScene("", eRendererLayers.FrontLayer)
      Me.ActivateScene("", eRendererLayers.MidleLayer)


      CCommand.SentData = "FONT CLEANUP"
      LlistaComandes.Add(CCommand)
      CCommand.ID = SendTCPCommand(CCommand)

      CCommand = New Command(eVizrtCommands.UnloadScenes)
      CCommand.SentData = "IMAGE CLEANUP"
      LlistaComandes.Add(CCommand)
      CCommand.ID = SendTCPCommand(CCommand)

      CCommand = New Command(eVizrtCommands.UnloadScenes)
      CCommand.SentData = "SCENE CLEANUP"
      LlistaComandes.Add(CCommand)
      CCommand.ID = SendTCPCommand(CCommand)
    Catch ex As Exception
      'AddError(ex.Source, ex.ToString)
    End Try
  End Function

  Public Function LoadScene(ByVal siFullPath As String) As Integer
    Try
      Dim CCommand As New Command(eVizrtCommands.LoadScene, siFullPath)
      CCommand.SentData = "SCENE*" & CCommand.Source & " LOAD"
      'CCommand.SentData = "RENDERER SET_OBJECT SCENE*" & CCommand.Source
      LlistaComandes.Add(CCommand)
      CCommand.ID = SendTCPCommand(CCommand)
      Return CCommand.ID
    Catch ex As Exception
      'AddError(ex.Source, ex.ToString)
    End Try
  End Function

  Public Function GetSceneTree(Optional ByVal eiLayer As eRendererLayers = eRendererLayers.MidleLayer) As Integer
    Try
      Dim CCommand As New Command(eVizrtCommands.GetSceneTree)
      CCommand.Layer = eiLayer
      Dim sRenderer As String = ""
      Select Case eiLayer
        Case eRendererLayers.BackLayer
          sRenderer = "RENDERER*BACK_LAYER"
        Case eRendererLayers.FrontLayer
          sRenderer = "RENDERER*FRONT_LAYER"
        Case eRendererLayers.MidleLayer
          sRenderer = "RENDERER"
      End Select
      CCommand.SentData = sRenderer & "*TREE GET"
      CCommand.ID = SendTCPCommand(CCommand, -1)
      LlistaComandes.Add(CCommand)
    Catch ex As Exception
      'AddError(ex.Source, ex.ToString)
    End Try
  End Function

  Public Function GetSceneIcon(ByVal siScene As String, ByVal niWidth As Integer, ByVal niHeight As Integer) As Integer
    Try
      Dim CCommand As New Command(eVizrtCommands.GetIcon, siScene)
      CCommand.SentData = "peak_get_icon SCENE*" & siScene & " " & niWidth & " " & niHeight
      CCommand.Icon = True
      CCommand.Image = New System.Drawing.Bitmap(niWidth, niHeight)
      CCommand.ID = SendTCPCommand(CCommand, -1)
      LlistaComandes.Add(CCommand)
    Catch ex As Exception
      'AddError(ex.Source, ex.ToString)
    End Try
  End Function

  Public Function GetImageIcon(ByVal siScene As String, ByVal niWidth As Integer, ByVal niHeight As Integer) As Integer
    Try
      Dim CCommand As New Command(eVizrtCommands.GetIcon, siScene)
      'super mega lleig! esborro les que esperen resposta!
      Me.LlistaComandesSenseResposta.Clear()
      CCommand.SentData = "peak_get_icon IMAGE*" & siScene & " " & niWidth & " " & niHeight
      CCommand.Icon = True
      CCommand.Image = New System.Drawing.Bitmap(niWidth, niHeight)
      CCommand.ID = SendTCPCommand(CCommand, -1)
      LlistaComandes.Add(CCommand)
    Catch ex As Exception
      'AddError(ex.Source, ex.ToString)
    End Try
  End Function

  Public Function DirectorRewindAll(Optional ByVal eiLayer As eRendererLayers = eRendererLayers.MidleLayer) As Integer
    Dim sRenderer As String = ""
    Try
      Dim CCommand As New Command(eVizrtCommands.DirectorRewindAll, "", eiLayer)
      Select Case eiLayer
        Case eRendererLayers.BackLayer
          sRenderer = "RENDERER*BACK_LAYER"
        Case eRendererLayers.FrontLayer
          sRenderer = "RENDERER*FRONT_LAYER"
        Case eRendererLayers.MidleLayer
          sRenderer = "RENDERER"
      End Select
      CCommand.SentData = sRenderer & "*STAGE SHOW BEGIN "
      LlistaComandes.Add(CCommand)
      CCommand.ID = SendTCPCommand(CCommand)
    Catch ex As Exception
      'AddError(ex.Source, ex.ToString)
    End Try
  End Function

  Public Function DirectorRewind(ByVal siDirector As String, Optional ByVal eiLayer As eRendererLayers = eRendererLayers.MidleLayer) As Integer
    Dim sRenderer As String = ""
    Try
      Dim CCommand As New Command(eVizrtCommands.DirectorRewind, "", eiLayer)
      CCommand.Data = siDirector
      Select Case eiLayer
        Case eRendererLayers.BackLayer
          sRenderer = "RENDERER*BACK_LAYER"
        Case eRendererLayers.FrontLayer
          sRenderer = "RENDERER*FRONT_LAYER"
        Case eRendererLayers.MidleLayer
          sRenderer = "RENDERER"
      End Select
      CCommand.SentData = sRenderer & "*STAGE*DIRECTOR*" & CCommand.Data & " SHOW BEGIN "
      LlistaComandes.Add(CCommand)
      CCommand.ID = SendTCPCommand(CCommand)
    Catch ex As Exception
      'AddError(ex.Source, ex.ToString)
    End Try
  End Function

  Public Function DirectorGotoAll(ByVal niFrame As Integer, Optional ByVal eiLayer As eRendererLayers = eRendererLayers.MidleLayer) As Integer
    Dim sRenderer As String = ""
    Try
      Dim CCommand As New Command(eVizrtCommands.DirectorRewindAll, "", eiLayer)
      Select Case eiLayer
        Case eRendererLayers.BackLayer
          sRenderer = "RENDERER*BACK_LAYER"
        Case eRendererLayers.FrontLayer
          sRenderer = "RENDERER*FRONT_LAYER"
        Case eRendererLayers.MidleLayer
          sRenderer = "RENDERER"
      End Select
      CCommand.SentData = sRenderer & "*STAGE SHOW " & CStr(niFrame) & " "
      LlistaComandes.Add(CCommand)
      CCommand.ID = SendTCPCommand(CCommand)
    Catch ex As Exception
      'AddError(ex.Source, ex.ToString)
    End Try
  End Function

  Public Function DirectorGoTo(ByVal siDirector As String, ByVal niFrame As Integer, Optional ByVal eiLayer As eRendererLayers = eRendererLayers.MidleLayer) As Integer
    Dim sRenderer As String = ""
    Try
      Dim CCommand As New Command(eVizrtCommands.DirectorGoTo, "", eiLayer)
      CCommand.Data = siDirector
      Select Case eiLayer
        Case eRendererLayers.BackLayer
          sRenderer = "RENDERER*BACK_LAYER"
        Case eRendererLayers.FrontLayer
          sRenderer = "RENDERER*FRONT_LAYER"
        Case eRendererLayers.MidleLayer
          sRenderer = "RENDERER"
      End Select
      CCommand.SentData = sRenderer & "*STAGE*DIRECTOR*" & CCommand.Data & " SHOW F" & CStr(niFrame) & " "
      LlistaComandes.Add(CCommand)
      CCommand.ID = SendTCPCommand(CCommand)
    Catch ex As Exception
      'AddError(ex.Source, ex.ToString)
    End Try
  End Function

  Public Function DirectorStartAll(Optional ByVal eiLayer As eRendererLayers = eRendererLayers.MidleLayer) As Integer
    Dim sRenderer As String = ""
    Try
      Dim CCommand As New Command(eVizrtCommands.DirectorStartAll, "", eiLayer)
      Select Case eiLayer
        Case eRendererLayers.BackLayer
          sRenderer = "RENDERER*BACK_LAYER"
        Case eRendererLayers.FrontLayer
          sRenderer = "RENDERER*FRONT_LAYER"
        Case eRendererLayers.MidleLayer
          sRenderer = "RENDERER"
      End Select
      CCommand.SentData = sRenderer & "*STAGE START 0.0"
      LlistaComandes.Add(CCommand)
      CCommand.ID = SendTCPCommand(CCommand)
    Catch ex As Exception
      'AddError(ex.Source, ex.ToString)
    End Try
  End Function

  Public Function DirectorStart(ByVal siDirector As String, Optional ByVal eiLayer As eRendererLayers = eRendererLayers.MidleLayer) As Integer
    Dim sRenderer As String = ""
    Try
      Dim CCommand As New Command(eVizrtCommands.DirectorStart, "", eiLayer)
      CCommand.Data = siDirector
      Select Case eiLayer
        Case eRendererLayers.BackLayer
          sRenderer = "RENDERER*BACK_LAYER"
        Case eRendererLayers.FrontLayer
          sRenderer = "RENDERER*FRONT_LAYER"
        Case eRendererLayers.MidleLayer
          sRenderer = "RENDERER"
      End Select
      CCommand.SentData = sRenderer & "*STAGE*DIRECTOR*" & CCommand.Data & " START 0.0 "
      LlistaComandes.Add(CCommand)
      CCommand.ID = SendTCPCommand(CCommand)
    Catch ex As Exception
      'AddError(ex.Source, ex.ToString)
    End Try
  End Function

  Public Function DirectorStop(ByVal siDirector As String, Optional ByVal eiLayer As eRendererLayers = eRendererLayers.MidleLayer) As Integer
    Dim sRenderer As String = ""
    Try
      Dim CCommand As New Command(eVizrtCommands.DirectorStop, "", eiLayer)
      CCommand.Data = siDirector
      Select Case eiLayer
        Case eRendererLayers.BackLayer
          sRenderer = "RENDERER*BACK_LAYER"
        Case eRendererLayers.FrontLayer
          sRenderer = "RENDERER*FRONT_LAYER"
        Case eRendererLayers.MidleLayer
          sRenderer = "RENDERER"
      End Select
      CCommand.SentData = sRenderer & "*STAGE*DIRECTOR*" & CCommand.Data & " STOP "
      LlistaComandes.Add(CCommand)
      CCommand.ID = SendTCPCommand(CCommand)
    Catch ex As Exception
      'AddError(ex.Source, ex.ToString)
    End Try
  End Function

  Public Function DirectorContinueAll(Optional ByVal eiLayer As eRendererLayers = eRendererLayers.MidleLayer) As Integer
    Dim sRenderer As String = ""
    Try
      Dim CCommand As New Command(eVizrtCommands.DirectorContinueAll, "", eiLayer)
      Select Case eiLayer
        Case eRendererLayers.BackLayer
          sRenderer = "RENDERER*BACK_LAYER"
        Case eRendererLayers.FrontLayer
          sRenderer = "RENDERER*FRONT_LAYER"
        Case eRendererLayers.MidleLayer
          sRenderer = "RENDERER"
      End Select
      CCommand.SentData = sRenderer & "*STAGE CONTINUE"
      LlistaComandes.Add(CCommand)
      CCommand.ID = SendTCPCommand(CCommand)
    Catch ex As Exception
      'AddError(ex.Source, ex.ToString)
    End Try
  End Function

  Public Function DirectorContinue(ByVal siDirector As String, Optional ByVal eiLayer As eRendererLayers = eRendererLayers.MidleLayer) As Integer
    Dim sRenderer As String = ""
    Try
      Dim CCommand As New Command(eVizrtCommands.DirectorContinue, "", eiLayer)
      CCommand.Data = siDirector
      Select Case eiLayer
        Case eRendererLayers.BackLayer
          sRenderer = "RENDERER*BACK_LAYER"
        Case eRendererLayers.FrontLayer
          sRenderer = "RENDERER*FRONT_LAYER"
        Case eRendererLayers.MidleLayer
          sRenderer = "RENDERER"
      End Select
      CCommand.SentData = sRenderer & "*STAGE*DIRECTOR*" & CCommand.Data & " CONTINUE 0"
      LlistaComandes.Add(CCommand)
      CCommand.ID = SendTCPCommand(CCommand)
    Catch ex As Exception
      'AddError(ex.Source, ex.ToString)
    End Try
  End Function

  Public Function DirectorContinueAllReverse(Optional ByVal eiLayer As eRendererLayers = eRendererLayers.MidleLayer) As Integer
    Dim sRenderer As String = ""
    Try
      Dim CCommand As New Command(eVizrtCommands.DirectorContinueAllReverse, "", eiLayer)
      Select Case eiLayer
        Case eRendererLayers.BackLayer
          sRenderer = "RENDERER*BACK_LAYER"
        Case eRendererLayers.FrontLayer
          sRenderer = "RENDERER*FRONT_LAYER"
        Case eRendererLayers.MidleLayer
          sRenderer = "RENDERER"
      End Select
      CCommand.SentData = sRenderer & "*STAGE CONTINUE REVERSE"
      LlistaComandes.Add(CCommand)
      CCommand.ID = SendTCPCommand(CCommand)
    Catch ex As Exception
      'AddError(ex.Source, ex.ToString)
    End Try
  End Function

  Public Function DirectorGetStatus(ByVal siDirector As String, Optional ByVal eiLayer As eRendererLayers = eRendererLayers.MidleLayer) As Integer
    Dim sRenderer As String = ""
    Try
      Dim CCommand As New Command(eVizrtCommands.DirectorGetStatus, "", eiLayer)
      CCommand.Data = siDirector
      Select Case eiLayer
        Case eRendererLayers.BackLayer
          sRenderer = "RENDERER*BACK_LAYER"
        Case eRendererLayers.FrontLayer
          sRenderer = "RENDERER*FRONT_LAYER"
        Case eRendererLayers.MidleLayer
          sRenderer = "RENDERER"
      End Select
      CCommand.SentData = sRenderer & "*STAGE*DIRECTOR*" & CCommand.Data & " GET_STATUS"
      LlistaComandes.Add(CCommand)
      CCommand.ID = SendTCPCommand(CCommand)
    Catch ex As Exception
      'AddError(ex.Source, ex.ToString)
    End Try
  End Function

  Public Function DirectorGetStartTime(ByVal siDirector As String, Optional ByVal eiLayer As eRendererLayers = eRendererLayers.MidleLayer) As Integer
    Dim sRenderer As String = ""
    Try
      Dim CCommand As New Command(eVizrtCommands.DirectorGetStartTime, "", eiLayer)
      CCommand.Data = siDirector
      Select Case eiLayer
        Case eRendererLayers.BackLayer
          sRenderer = "RENDERER*BACK_LAYER"
        Case eRendererLayers.FrontLayer
          sRenderer = "RENDERER*FRONT_LAYER"
        Case eRendererLayers.MidleLayer
          sRenderer = "RENDERER"
      End Select
      CCommand.SentData = sRenderer & "*STAGE*DIRECTOR*" & CCommand.Data & "START_TIME GET"
      LlistaComandes.Add(CCommand)
      CCommand.ID = SendTCPCommand(CCommand)
    Catch ex As Exception
      'AddError(ex.Source, ex.ToString)
    End Try
  End Function

  Public Function DirectorGetKeyframeTime(ByVal siDirector As String, ByVal siKeyFrame As String, Optional ByVal eiLayer As eRendererLayers = eRendererLayers.MidleLayer) As Integer
    Dim sRenderer As String = ""
    Try
      Dim CCommand As New Command(eVizrtCommands.DirectorGetKeyframeTime, "", eiLayer)
      CCommand.Data = siDirector & "*" & siKeyFrame
      Select Case eiLayer
        Case eRendererLayers.BackLayer
          sRenderer = "RENDERER*BACK_LAYER"
        Case eRendererLayers.FrontLayer
          sRenderer = "RENDERER*FRONT_LAYER"
        Case eRendererLayers.MidleLayer
          sRenderer = "RENDERER"
      End Select
      CCommand.SentData = sRenderer & "*STAGE*DIRECTOR*" & siDirector & "*KEY*$" & siKeyFrame & "START_TIME GET"
      LlistaComandes.Add(CCommand)
      CCommand.ID = SendTCPCommand(CCommand)
    Catch ex As Exception
      'AddError(ex.Source, ex.ToString)
    End Try
  End Function

  Public Function DirectorGetEndTime(ByVal siDirector As String, Optional ByVal eiLayer As eRendererLayers = eRendererLayers.MidleLayer) As Integer
    Dim sRenderer As String = ""
    Try
      Dim CCommand As New Command(eVizrtCommands.DirectorGetEndTime, "", eiLayer)
      CCommand.Data = siDirector
      Select Case eiLayer
        Case eRendererLayers.BackLayer
          sRenderer = "RENDERER*BACK_LAYER"
        Case eRendererLayers.FrontLayer
          sRenderer = "RENDERER*FRONT_LAYER"
        Case eRendererLayers.MidleLayer
          sRenderer = "RENDERER"
      End Select
      CCommand.SentData = sRenderer & "*STAGE*DIRECTOR*" & CCommand.Data & "*END_TIME GET"
      LlistaComandes.Add(CCommand)
      CCommand.ID = SendTCPCommand(CCommand)
    Catch ex As Exception
      'AddError(ex.Source, ex.ToString)
    End Try
  End Function

  Public Function StageGetDirectors(Optional ByVal eiLayer As eRendererLayers = eRendererLayers.MidleLayer) As Integer
    Dim sRenderer As String = ""
    Try
      Dim CCommand As New Command(eVizrtCommands.StageGetDirectors, "", eiLayer)
      CCommand.Data = ""
      Select Case eiLayer
        Case eRendererLayers.BackLayer
          sRenderer = "RENDERER*BACK_LAYER"
        Case eRendererLayers.FrontLayer
          sRenderer = "RENDERER*FRONT_LAYER"
        Case eRendererLayers.MidleLayer
          sRenderer = "RENDERER"
      End Select
      CCommand.SentData = sRenderer & "*STAGE*ANIMATION GET_DIRECTOR_DATA"
      LlistaComandes.Add(CCommand)
      CCommand.ID = SendTCPCommand(CCommand)
    Catch ex As Exception
      'AddError(ex.Source, ex.ToString)
    End Try
  End Function

  Public Function DirectorContinueReverse(ByVal siDirector As String, Optional ByVal eiLayer As eRendererLayers = eRendererLayers.MidleLayer) As Integer
    Dim sRenderer As String = ""
    Try
      Dim CCommand As New Command(eVizrtCommands.DirectorContinueReverse, "", eiLayer)
      CCommand.Data = siDirector
      Select Case eiLayer
        Case eRendererLayers.BackLayer
          sRenderer = "RENDERER*BACK_LAYER"
        Case eRendererLayers.FrontLayer
          sRenderer = "RENDERER*FRONT_LAYER"
        Case eRendererLayers.MidleLayer
          sRenderer = "RENDERER"
      End Select
      CCommand.SentData = sRenderer & "*STAGE*DIRECTOR*" & CCommand.Data & " CONTINUE REVERSE"
      LlistaComandes.Add(CCommand)
      CCommand.ID = SendTCPCommand(CCommand)
    Catch ex As Exception
      'AddError(ex.Source, ex.ToString)
    End Try
  End Function


  Public Function GetSceneDirectors(Optional ByVal eiLayer As eRendererLayers = eRendererLayers.MidleLayer) As Integer
    Try
      Dim CCommand As New Command(eVizrtCommands.GetAllDirectors)
      CCommand.Layer = eiLayer
      Dim sRenderer As String = ""
      Select Case eiLayer
        Case eRendererLayers.BackLayer
          sRenderer = "RENDERER*BACK_LAYER"
        Case eRendererLayers.FrontLayer
          sRenderer = "RENDERER*FRONT_LAYER"
        Case eRendererLayers.MidleLayer
          sRenderer = "RENDERER"
      End Select
      CCommand.SentData = sRenderer & "*STAGE*DIRECTOR GET"
      CCommand.ID = SendTCPCommand(CCommand, -1)
      LlistaComandes.Add(CCommand)
    Catch ex As Exception
      'AddError(ex.Source, ex.ToString)
    End Try
  End Function


  Public Function SetSceneBackgroundImageActive(ByVal biActive As Boolean, Optional ByVal eiLayer As eRendererLayers = eRendererLayers.MidleLayer) As Integer
    Dim CCommand As New Command(eVizrtCommands.GetAllDirectors)
    CCommand.Layer = eiLayer
    Dim sRenderer As String = ""
    Try
      Select Case eiLayer
        Case eRendererLayers.BackLayer
          sRenderer = "RENDERER*BACK_LAYER"
        Case eRendererLayers.FrontLayer
          sRenderer = "RENDERER*FRONT_LAYER"
        Case eRendererLayers.MidleLayer
          sRenderer = "RENDERER"
      End Select
      CCommand.SentData = sRenderer & "*BACKGROUND*IMAGE*ACTIVE SET " & IIf(biActive, "1", "0")
      CCommand.ID = SendTCPCommand(CCommand, -1)
      LlistaComandes.Add(CCommand)
    Catch ex As Exception
      'AddError(ex.Source, ex.ToString)
    End Try
  End Function

  Public Function GetSceneBackgroundImageActive(Optional ByVal eiLayer As eRendererLayers = eRendererLayers.MidleLayer) As Integer
    Dim CCommand As New Command(eVizrtCommands.GetAllDirectors)
    CCommand.Layer = eiLayer
    Dim sRenderer As String = ""
    Try
      Select Case eiLayer
        Case eRendererLayers.BackLayer
          sRenderer = "RENDERER*BACK_LAYER"
        Case eRendererLayers.FrontLayer
          sRenderer = "RENDERER*FRONT_LAYER"
        Case eRendererLayers.MidleLayer
          sRenderer = "RENDERER"
      End Select
      CCommand.SentData = sRenderer & "*BACKGROUND*IMAGE*ACTIVE GET"
      CCommand.ID = SendTCPCommand(CCommand, -1)
      LlistaComandes.Add(CCommand)
    Catch ex As Exception
      'AddError(ex.Source, ex.ToString)
    End Try
  End Function

  Public Function SetNodeText(ByVal siNodePath As String, ByVal siText As String, Optional ByVal eiLayer As eRendererLayers = eRendererLayers.MidleLayer) As Integer
    Dim sRenderer As String = ""
    Try
      Dim CCommand As New Command(eVizrtCommands.SetNodeText, siNodePath, eiLayer)
      Select Case eiLayer
        Case eRendererLayers.BackLayer
          sRenderer = "RENDERER*BACK_LAYER"
        Case eRendererLayers.FrontLayer
          sRenderer = "RENDERER*FRONT_LAYER"
        Case eRendererLayers.MidleLayer
          sRenderer = "RENDERER"
      End Select
      CCommand.Data = siText
      CCommand.SentData = sRenderer & "*TREE*" & CCommand.Source & "*GEOM*TEXT SET " & CCommand.Data
      LlistaComandes.Add(CCommand)
      CCommand.ID = SendTCPCommand(CCommand)
    Catch ex As Exception
      'AddError(ex.Source, ex.ToString)
    End Try
  End Function

  Public Function SetNodeImage(ByVal siNodePath As String, ByVal siImage As String, Optional ByVal eiLayer As eRendererLayers = eRendererLayers.MidleLayer) As Integer
    Dim sRenderer As String = ""
    Try
      Dim CCommand As New Command(eVizrtCommands.SetNodeImage, siNodePath, eiLayer)
      Select Case eiLayer
        Case eRendererLayers.BackLayer
          sRenderer = "RENDERER*BACK_LAYER"
        Case eRendererLayers.FrontLayer
          sRenderer = "RENDERER*FRONT_LAYER"
        Case eRendererLayers.MidleLayer
          sRenderer = "RENDERER"
      End Select
      CCommand.Data = siImage
      CCommand.SentData = sRenderer & "*TREE*" & CCommand.Source & "*IMAGE SET IMAGE*" & CCommand.Data
      LlistaComandes.Add(CCommand)
      CCommand.ID = SendTCPCommand(CCommand)
    Catch ex As Exception
      'AddError(ex.Source, ex.ToString)
    End Try
  End Function


  Public Function ScriptInstanceInvoke(ByVal siNodePath As String, ByVal siButtonName As String, Optional ByVal eiLayer As eRendererLayers = eRendererLayers.MidleLayer) As Integer
    Dim sRenderer As String = ""
    Try
      Dim CCommand As New Command(eVizrtCommands.ScriptInstanceInvoke, siNodePath, eiLayer)
      Select Case eiLayer
        Case eRendererLayers.BackLayer
          sRenderer = "RENDERER*BACK_LAYER"
        Case eRendererLayers.FrontLayer
          sRenderer = "RENDERER*FRONT_LAYER"
        Case eRendererLayers.MidleLayer
          sRenderer = "RENDERER"
      End Select
      CCommand.Data = siButtonName
      CCommand.SentData = sRenderer & "*TREE*" & CCommand.Source & "*SCRIPT*INSTANCE*" & CCommand.Data & " INVOKE"
      LlistaComandes.Add(CCommand)
      CCommand.ID = SendTCPCommand(CCommand)
    Catch ex As Exception
      'AddError(ex.Source, ex.ToString)
    End Try
  End Function

  Public Function SetControlObjectValue(ByVal siNodePath As String, ByVal siField As String, ByVal siValue As String, Optional ByVal eiLayer As eRendererLayers = eRendererLayers.MidleLayer) As Integer
    Dim sRenderer As String = ""
    Try
      Dim CCommand As New Command(eVizrtCommands.SetControlObjectValue, siNodePath & "@" & siField & "=" & siValue, eiLayer)
      Select Case eiLayer
        Case eRendererLayers.BackLayer
          sRenderer = "RENDERER*BACK_LAYER"
        Case eRendererLayers.FrontLayer
          sRenderer = "RENDERER*FRONT_LAYER"
        Case eRendererLayers.MidleLayer
          sRenderer = "RENDERER"
      End Select
      CCommand.Data = siField
      CCommand.SentData = sRenderer & "*TREE*" & siNodePath & "*FUNCTION*ControlObject*in SET ON " & siField & " SET " & siValue
      'Debug.Print(CCommand.SentData)
      LlistaComandes.Add(CCommand)
      CCommand.ID = SendTCPCommand(CCommand)
    Catch ex As Exception
      'AddError(ex.Source, ex.ToString)
    End Try
  End Function

  Public Function SetControlObjectImageValue(ByVal siNodePath As String, ByVal siField As String, ByVal siValue As String, Optional ByVal eiLayer As eRendererLayers = eRendererLayers.MidleLayer) As Integer
    Dim sRenderer As String = ""
    Try
      Dim CCommand As New Command(eVizrtCommands.SetControlObjectValue, siNodePath, eiLayer)
      Select Case eiLayer
        Case eRendererLayers.BackLayer
          sRenderer = "RENDERER*BACK_LAYER"
        Case eRendererLayers.FrontLayer
          sRenderer = "RENDERER*FRONT_LAYER"
        Case eRendererLayers.MidleLayer
          sRenderer = "RENDERER"
      End Select
      CCommand.Data = siField
      If siValue <> "" Then
        CCommand.SentData = sRenderer & "*TREE*" & CCommand.Source & "*FUNCTION*ControlObject*in SET ON " & CCommand.Data & " SET IMAGE*" & siValue
      Else
        CCommand.SentData = sRenderer & "*TREE*" & CCommand.Source & "*FUNCTION*ControlObject*in SET ON " & CCommand.Data & " SET  "
      End If

      LlistaComandes.Add(CCommand)
      CCommand.ID = SendTCPCommand(CCommand)
    Catch ex As Exception
      'AddError(ex.Source, ex.ToString)
    End Try
  End Function

  Public Function GetControlObjectFields(ByVal siNodePath As String, Optional ByVal eiLayer As eRendererLayers = eRendererLayers.MidleLayer) As Integer
    Dim sRenderer As String = ""
    Try
      Dim CCommand As New Command(eVizrtCommands.GetControlObjectFields, siNodePath, eiLayer)
      Dim CCommandAux As New Command(eVizrtCommands.GetControlobjectPrepare, siNodePath, eiLayer)
      Select Case eiLayer
        Case eRendererLayers.BackLayer
          sRenderer = "RENDERER*BACK_LAYER"
        Case eRendererLayers.FrontLayer
          sRenderer = "RENDERER*FRONT_LAYER"
        Case eRendererLayers.MidleLayer
          sRenderer = "RENDERER"
      End Select

      CCommandAux.SentData = sRenderer & "*TREE*" & siNodePath & "*FUNCTION*ControlObject*in SET LIST"
      LlistaComandes.Add(CCommandAux)
      CCommandAux.ID = SendTCPCommand(CCommandAux, -1)
      CCommand.SentData = sRenderer & "*TREE*" & siNodePath & "*FUNCTION*ControlObject*result GET"
      LlistaComandes.Add(CCommand)
      CCommand.ID = SendTCPCommand(CCommand, -1)
    Catch ex As Exception
      'AddError(ex.Source, ex.ToString)
    End Try
  End Function

  Public Function SetNodeActive(ByVal siNodePath As String, ByVal siText As String, Optional ByVal eiLayer As eRendererLayers = eRendererLayers.MidleLayer) As Integer
    Dim sRenderer As String = ""
    Try
      Dim CCommand As New Command(eVizrtCommands.SetNodeActive, siNodePath, eiLayer)
      Select Case eiLayer
        Case eRendererLayers.BackLayer
          sRenderer = "RENDERER*BACK_LAYER"
        Case eRendererLayers.FrontLayer
          sRenderer = "RENDERER*FRONT_LAYER"
        Case eRendererLayers.MidleLayer
          sRenderer = "RENDERER"
      End Select
      CCommand.Data = siText
      CCommand.SentData = sRenderer & "*TREE*" & CCommand.Source & "*GEOM*ACTIVE SET " & CCommand.Data
      LlistaComandes.Add(CCommand)
      CCommand.ID = SendTCPCommand(CCommand)
    Catch ex As Exception
      'AddError(ex.Source, ex.ToString)
    End Try
  End Function

  Public Function SetNodePosition(ByVal siNodePath As String, ByVal X As Decimal, ByVal Y As Decimal, ByVal Z As Decimal, Optional ByVal eiLayer As eRendererLayers = eRendererLayers.MidleLayer) As Integer
    Dim sRenderer As String = ""
    Try
      Dim CCommand As New Command(eVizrtCommands.SetNodePosition, siNodePath, eiLayer)
      Select Case eiLayer
        Case eRendererLayers.BackLayer
          sRenderer = "RENDERER*BACK_LAYER"
        Case eRendererLayers.FrontLayer
          sRenderer = "RENDERER*FRONT_LAYER"
        Case eRendererLayers.MidleLayer
          sRenderer = "RENDERER"
      End Select
      CCommand.Data = DecimalToString(X) & " " & DecimalToString(Y) & " " & DecimalToString(Z)
      CCommand.SentData = sRenderer & "*TREE*" & CCommand.Source & "*TRANSFORMATION*POSITION SET " & CCommand.Data
      LlistaComandes.Add(CCommand)
      CCommand.ID = SendTCPCommand(CCommand, 0)
    Catch ex As Exception
      'AddError(ex.Source, ex.ToString)
    End Try
  End Function

  Public Function SetNodeRotation(ByVal siNodePath As String, ByVal X As Decimal, ByVal Y As Decimal, ByVal Z As Decimal, Optional ByVal eiLayer As eRendererLayers = eRendererLayers.MidleLayer) As Integer
    Dim sRenderer As String = ""
    Try
      Dim CCommand As New Command(eVizrtCommands.SetNodeRotation, siNodePath, eiLayer)
      Select Case eiLayer
        Case eRendererLayers.BackLayer
          sRenderer = "RENDERER*BACK_LAYER"
        Case eRendererLayers.FrontLayer
          sRenderer = "RENDERER*FRONT_LAYER"
        Case eRendererLayers.MidleLayer
          sRenderer = "RENDERER"
      End Select
      CCommand.Data = DecimalToString(X) & " " & DecimalToString(Y) & " " & DecimalToString(Z)
      CCommand.SentData = sRenderer & "*TREE*" & CCommand.Source & "*TRANSFORMATION*ROTATION SET " & CCommand.Data
      LlistaComandes.Add(CCommand)
      CCommand.ID = SendTCPCommand(CCommand, 0)
    Catch ex As Exception
      'AddError(ex.Source, ex.ToString)
    End Try
  End Function

  Public Function SetNodeScaling(ByVal siNodePath As String, ByVal X As Decimal, ByVal Y As Decimal, ByVal Z As Decimal, Optional ByVal eiLayer As eRendererLayers = eRendererLayers.MidleLayer) As Integer
    Dim sRenderer As String = ""
    Try
      Dim CCommand As New Command(eVizrtCommands.SetNodeScaling, siNodePath, eiLayer)
      Select Case eiLayer
        Case eRendererLayers.BackLayer
          sRenderer = "RENDERER*BACK_LAYER"
        Case eRendererLayers.FrontLayer
          sRenderer = "RENDERER*FRONT_LAYER"
        Case eRendererLayers.MidleLayer
          sRenderer = "RENDERER"
      End Select
      CCommand.Data = DecimalToString(X) & " " & DecimalToString(Y) & " " & DecimalToString(Z)
      CCommand.SentData = sRenderer & "*TREE*" & CCommand.Source & "*TRANSFORMATION*SCALING SET " & CCommand.Data
      LlistaComandes.Add(CCommand)
      CCommand.ID = SendTCPCommand(CCommand, 0)
    Catch ex As Exception
      'AddError(ex.Source, ex.ToString)
    End Try
  End Function

  Public Sub GetActiveScene(Optional ByVal eiLayer As eRendererLayers = eRendererLayers.MidleLayer)
    Dim sRenderer As String = ""
    Try
      Dim CCommand As New Command(eVizrtCommands.GetActiveScene, "", eiLayer)
      Select Case eiLayer
        Case eRendererLayers.BackLayer
          sRenderer = "RENDERER*BACK_LAYER"
        Case eRendererLayers.FrontLayer
          sRenderer = "RENDERER*FRONT_LAYER"
        Case eRendererLayers.MidleLayer
          sRenderer = "RENDERER"
      End Select
      CCommand.SentData = sRenderer & " GET_OBJECT"
      LlistaComandes.Add(CCommand)
      CCommand.ID = SendTCPCommand(CCommand, -1)
    Catch ex As Exception
      'AddError(ex.Source, ex.ToString)
    End Try
  End Sub

  Public Sub GetLoadedScenes()
    Dim sRenderer As String = ""
    Try
      Dim CCommand As New Command(eVizrtCommands.GetLoadedScenes, "")

      CCommand.SentData = "SCENE INFO"
      LlistaComandes.Add(CCommand)
      CCommand.ID = SendTCPCommand(CCommand, -1)
    Catch ex As Exception
      'AddError(ex.Source, ex.ToString)
    End Try
  End Sub

  Public Sub GetScenePathFromID(ByVal siId As String)
    Dim sRenderer As String = ""
    Try
      Dim CCommand As New Command(eVizrtCommands.GetScenePathFromID, siId)

      CCommand.SentData = siId & "*LOCATION_PATH GET"
      LlistaComandes.Add(CCommand)
      CCommand.ID = SendTCPCommand(CCommand, -1)
    Catch ex As Exception
      'AddError(ex.Source, ex.ToString)
    End Try
  End Sub

  Public Sub GetScenesAtPath(ByVal siPath As String)
    Try
      Dim CCommand As New Command(eVizrtCommands.GetScenesAtPath, siPath)

      If siPath = "" Then
        CCommand.SentData = "SCENE GET_DETAIL"
      Else
        CCommand.SentData = "SCENE*" & siPath & " GET_DETAIL"
      End If
      LlistaComandes.Add(CCommand)
      CCommand.ID = SendTCPCommand(CCommand, -1)
    Catch ex As Exception
      'AddError(ex.Source, ex.ToString)
    End Try
  End Sub

  Public Sub GetImagesAtPath(ByVal siPath As String)
    Try
      Dim CCommand As New Command(eVizrtCommands.GetImagesAtPath, siPath)

      If siPath = "" Then
        CCommand.SentData = "IMAGE GET"
      Else
        CCommand.SentData = "IMAGE*" & siPath & " GET"
      End If
      LlistaComandes.Add(CCommand)
      CCommand.ID = SendTCPCommand(CCommand, -1)
    Catch ex As Exception
      'AddError(ex.Source, ex.ToString)
    End Try
  End Sub

  Public Sub GetNodesAtPath(ByVal siPath As String)
    Try
      Dim CCommand As New Command(eVizrtCommands.GetNodesAtPath, siPath)

      If siPath = "" Then
        CCommand.SentData = "SCENE GET_GROUPS_DETAIL"
      Else
        CCommand.SentData = "SCENE*" & siPath & " GET_GROUPS_DETAIL"
      End If
      LlistaComandes.Add(CCommand)
      CCommand.ID = SendTCPCommand(CCommand, -1)
    Catch ex As Exception
      'AddError(ex.Source, ex.ToString)
    End Try
  End Sub

  Public Sub PostRenderStartRender(ByVal siOutputFile As String, ByVal liDuration As Long, ByVal niCodec As Integer)
    Try
      Dim CCommand As Command

      'Iniciar
      CCommand = New Command(eVizrtCommands.PostRenderConfigure)
      CCommand.SentData = "RENDERER*POST_MODE SET 1"
      LlistaComandes.Add(CCommand)
      CCommand.ID = SendTCPCommand(CCommand)

      CCommand = New Command(eVizrtCommands.PostRenderConfigure)
      CCommand.SentData = "MAIN ON_AIR ON"
      LlistaComandes.Add(CCommand)
      CCommand.ID = SendTCPCommand(CCommand)

      CCommand = New Command(eVizrtCommands.PostRenderConfigure)
      CCommand.SentData = "RENDER_TO_DISK*PLUGIN SET BUILT_IN*RENDER_TO_DISK*VideoRenderer"
      LlistaComandes.Add(CCommand)
      CCommand.ID = SendTCPCommand(CCommand)

      'especificar l'arxiu
      CCommand = New Command(eVizrtCommands.PostRenderConfigure)
      CCommand.SentData = "RENDER_TO_DISK*CLIP_NAME SET """ & siOutputFile & """"
      LlistaComandes.Add(CCommand)
      CCommand.ID = SendTCPCommand(CCommand)

      'especificar la durada
      CCommand = New Command(eVizrtCommands.PostRenderConfigure)
      CCommand.SentData = "RENDER_TO_DISK*DURATION SET " & liDuration.ToString
      LlistaComandes.Add(CCommand)
      CCommand.ID = SendTCPCommand(CCommand)

      ''especificar els fields per second
      'CCommand = New Command(eVizrtCommands.PostRenderConfigure)
      'CCommand.SentData = "RENDER_TO_DISK*PLUGIN_INSTANCE*FPS SET 50.0"
      'LlistaComandes.Add(CCommand)
      'CCommand.ID = SendTCPCommand(CCommand)

      'especificar el codec
      CCommand = New Command(eVizrtCommands.PostRenderConfigure)
      CCommand.SentData = "RENDER_TO_DISK*PLUGIN_INSTANCE*CodecList SET " & niCodec.ToString
      LlistaComandes.Add(CCommand)
      CCommand.ID = SendTCPCommand(CCommand)

      'Iniciar
      CCommand = New Command(eVizrtCommands.PostRenderExecute)
      CCommand.SentData = "RENDER_TO_DISK RECORD"
      LlistaComandes.Add(CCommand)
      CCommand.ID = SendTCPCommand(CCommand)
    Catch ex As Exception

    End Try
  End Sub

  Public Function ClockStart(ByVal niClockIndex As Integer) As Integer
    Dim sRenderer As String = ""
    Try
      Dim CCommand As New Command(eVizrtCommands.ClockStart)

      CCommand.SentData = "CLOCK" & niClockIndex & " START"
      LlistaComandes.Add(CCommand)
      CCommand.ID = SendTCPCommand(CCommand)
    Catch ex As Exception
      'AddError(ex.Source, ex.ToString)
    End Try
  End Function

  Public Function ClockStop(ByVal niClockIndex As Integer) As Integer
    Dim sRenderer As String = ""
    Try
      Dim CCommand As New Command(eVizrtCommands.ClockStop)

      CCommand.SentData = "CLOCK" & niClockIndex & " STOP"
      LlistaComandes.Add(CCommand)
      CCommand.ID = SendTCPCommand(CCommand)
    Catch ex As Exception
      'AddError(ex.Source, ex.ToString)
    End Try
  End Function


  Public Function ClockSet(ByVal niClockIndex As Integer, ByVal niSeconds As Integer) As Integer
    Dim sRenderer As String = ""
    Try
      Dim CCommand As New Command(eVizrtCommands.ClockSet, CStr(niSeconds))

      CCommand.SentData = "CLOCK" & niClockIndex & "*TIME SET " & CStr(niSeconds)
      CCommand.SentData = "CLOCK" & niClockIndex & "*TIME SET " & CStr(niSeconds) & "."
      LlistaComandes.Add(CCommand)
      CCommand.ID = SendTCPCommand(CCommand)
    Catch ex As Exception
      'AddError(ex.Source, ex.ToString)
    End Try
  End Function


  Public Function ClockSetDirection(ByVal niClockIndex As Integer, ByVal niDirection As Integer) As Integer
    Dim sRenderer As String = ""
    Try
      Dim CCommand As New Command(eVizrtCommands.ClockSetDirection, CStr(niDirection))

      If niDirection > 0 Then
        CCommand.SentData = "CLOCK" & niClockIndex & "*DIRECTION SET UP"
      Else
        CCommand.SentData = "CLOCK" & niClockIndex & "*DIRECTION SET DOWN"
      End If

      LlistaComandes.Add(CCommand)
      CCommand.ID = SendTCPCommand(CCommand)
    Catch ex As Exception
      'AddError(ex.Source, ex.ToString)
    End Try
  End Function


  Public Function ClockSetLimit(ByVal niClockIndex As Integer, ByVal niLimit As Integer) As Integer
    Dim sRenderer As String = ""
    Try
      Dim CCommand As New Command(eVizrtCommands.ClockSetLimit, CStr(niLimit))

      CCommand.SentData = "CLOCK" & niClockIndex & "*LIMIT SET " & CStr(niLimit) & "."
      LlistaComandes.Add(CCommand)
      CCommand.ID = SendTCPCommand(CCommand)
    Catch ex As Exception
      'AddError(ex.Source, ex.ToString)
    End Try
  End Function

  Public Function TakeSnapshot(ByVal siPath As String, ByVal biAlpha As Boolean) As Integer
    Dim sRenderer As String = ""
    Try
      Dim CCommand As New Command(eVizrtCommands.TakeSnapshot, siPath)

      CCommand.SentData = "RENDERER SNAPSHOT " & siPath & " " & IIf(biAlpha, "RGBA", "RGB")
      LlistaComandes.Add(CCommand)
      CCommand.ID = SendTCPCommand(CCommand)
      Return CCommand.ID
    Catch ex As Exception
      'AddError(ex.Source, ex.ToString)
    End Try
  End Function


  Public Function GetMemoryStats() As Integer
    Dim sRenderer As String = ""
    Try
      Dim CCommand As New Command(eVizrtCommands.GetMemoryStats)

      CCommand.SentData = "TEXTURE*MEMORY GET"
      LlistaComandes.Add(CCommand)
      CCommand.ID = SendTCPCommand(CCommand, -1)
    Catch ex As Exception
      'AddError(ex.Source, ex.ToString)
    End Try
  End Function

  Public Function SendCameraParameters(ByVal tiCamera As tyCameraParameters) As Integer()
    Dim anCommands(10) As Integer
    Try
      With tiCamera
        anCommands(0) = Me.SendCameraParameter(.CameraIndex, .FOVX, eCameraParameters.FOVX)
        anCommands(1) = Me.SendCameraParameter(.CameraIndex, .FOVY, eCameraParameters.FOVY)
        anCommands(2) = Me.SendCameraParameter(.CameraIndex, .cx, eCameraParameters.CXC)
        anCommands(3) = Me.SendCameraParameter(.CameraIndex, .cy, eCameraParameters.CYC)
        anCommands(4) = Me.SendCameraParameter(.CameraIndex, .k1, eCameraParameters.K1)
        anCommands(5) = Me.SendCameraParameter(.CameraIndex, .k2, eCameraParameters.K2)
        anCommands(6) = Me.SendCameraParameter(.CameraIndex, .lx, eCameraParameters.LX)
        anCommands(7) = Me.SendCameraParameter(.CameraIndex, .ly, eCameraParameters.LY)
        anCommands(8) = Me.SendCameraParameter(.CameraIndex, .Deformation_Mode, eCameraParameters.MODE)
        anCommands(9) = Me.SendCameraParameter(.CameraIndex, .Nodal, eCameraParameters.NODAL)
      End With

    Catch ex As Exception
      'AddError(ex.Source, ex.ToString)
    End Try
    Return anCommands
  End Function

  Public Function SendCameraParameter(ByVal niCameraNumber As Integer, ByVal siValue As String, ByVal eiParameter As eCameraParameters) As Integer
    Try
      Dim CCommand As New Command(eVizrtCommands.SetCameraParameter, niCameraNumber & ". " & eiParameter.ToString)

      CCommand.SentData = "GLOBAL*CAMERA*" & niCameraNumber & "*DEFORMATION_" & eiParameter.ToString & " SET " + siValue

      LlistaComandes.Add(CCommand)
      CCommand.ID = SendTCPCommand(CCommand, -1)
    Catch ex As Exception
      'AddError(ex.Source, ex.ToString)
    End Try
  End Function

  Private Function DecimalToString(ByVal dDada As Decimal) As String
    Dim sData As String
    Try
      sData = Format(dDada, "0.000")
      sData = sData.Replace(",", ".")
      Return sData
    Catch ex As Exception
      Return "0"
    End Try
  End Function

  Public Sub SendCommand(ByVal eiCommand As eVizrtCommands, Optional ByVal siSource As String = "", Optional ByVal siParam As String = "", Optional ByVal eiLayer As eRendererLayers = eRendererLayers.MidleLayer)
    Try
      Dim CCommand As New Command(eiCommand, siSource, eiLayer)
      CCommand.Data = siParam
      SendCommand(CCommand)
    Catch ex As Exception
      'AddError(ex.Source, ex.ToString)
    End Try
  End Sub

  Public Sub SendCommand(ByVal CiCommand As Command)
    Try
      Dim sRenderer As String = ""
      Select Case CiCommand.Layer
        Case eRendererLayers.BackLayer
          sRenderer = "RENDERER*BACK_LAYER"
        Case eRendererLayers.FrontLayer
          sRenderer = "RENDERER*FRONT_LAYER"
        Case eRendererLayers.MidleLayer
          sRenderer = "RENDERER"
      End Select

      Select Case CiCommand.VizrtCommand
        Case eVizrtCommands.AskForVersion
          CiCommand.ID = SendTCPCommand("MAIN VERSION")
        Case eVizrtCommands.GetSceneTree
          CiCommand.ID = SendTCPCommand(sRenderer & "*TREE GET")
        Case eVizrtCommands.GetNodePosition
          CiCommand.ID = SendTCPCommand(sRenderer & "*TREE*" & CiCommand.Source & "*TRANSFORMATION*POSITION GET")
        Case eVizrtCommands.GetNodeRotation
          CiCommand.ID = SendTCPCommand(sRenderer & "*TREE*" & CiCommand.Source & "*TRANSFORMATION*ROTATION GET")
        Case eVizrtCommands.GetNodeScaling
          CiCommand.ID = SendTCPCommand(sRenderer & "*TREE*" & CiCommand.Source & "*TRANSFORMATION*SCALING GET")
        Case eVizrtCommands.GetNodeText
          CiCommand.ID = SendTCPCommand(sRenderer & "*TREE*" & CiCommand.Source & "*GEOM*TEXT GET")
      End Select
      If CiCommand.ID > 0 Then
        'no afegir una comanda que no podré rastrejar
        LlistaComandesSenseResposta.Add(CiCommand)
        LlistaComandes.Add(CiCommand)
      End If
    Catch ex As Exception
      'AddError(ex.Source, ex.ToString)
    End Try
  End Sub

  Public Function SendTCPCommand(ByVal siCommand As String, Optional ByVal niIndex As Integer = -1) As Integer
    Return SendSocketCommand(Me.CPiSocketTCP, siCommand, niIndex)
  End Function

  Public Function SendTCPCommand(ByRef CiCommand As Command, Optional ByVal niindex As Integer = 0) As Integer
    Dim nRes As Integer = 0
    Dim nIndex As Integer
    Try
      CiCommand.Host = Me.Config.TCPHost

      Select Case niindex
        Case 0
          'fem el que digui la configuració
          If Me.AskForResponse Then
            nIndex = -1
          Else
            nIndex = 0
          End If
        Case Else
          nIndex = niindex
      End Select

      Dim lTicks As Long = Now.Ticks

      nRes = SendSocketCommand(Me.CPiSocketTCP, CiCommand.SentData, nIndex)

      'lTicks = Now.Ticks - lTicks : Debug.Print("SendSocketCommand " & CiCommand.SentData & " " & CInt(lTicks / TimeSpan.TicksPerMillisecond)) : lTicks = Now.Ticks

      CiCommand.ID = nRes
      If nRes > 0 Then
        'no afegir una comanda que no podré rastrejar
        LlistaComandesSenseResposta.Add(CiCommand)
      End If

      RaiseEvent CommandSent(CiCommand)

      Return nRes
    Catch ex As Exception
      'AddError(ex.Source, ex.ToString)
      Return 0

    End Try
  End Function

  'enviar i rebre de manera síncrona!
  Public Function SendTCPCommandSync(ByRef CiCommand As Command, Optional ByVal niindex As Integer = -1) As Integer
    Try
      CiCommand.Host = Me.Config.TCPHost

      Return SendSocketCommand(Me.CPiSocketTCP, CiCommand.SentData, niindex)

      RaiseEvent CommandSent(CiCommand)


    Catch ex As Exception
      'AddError(ex.Source, ex.ToString)
      Return 0

    End Try
  End Function

  Public Function SendDataPoolValue(ByVal siParamName As String, ByVal Value As String) As Integer
    Try
      Dim sCommand As String
      sCommand = siParamName & "=" & Value & ";"
      Debug.Print(sCommand)
      Return SendSocketCommand(Me.CPiSocketUDPSend, sCommand)
    Catch ex As Exception
      'AddError(ex.Source, ex.ToString)
      Return 0
    End Try
  End Function
  Public Function SendDataPoolValue(ByVal siParamName As String, ByVal Value As Integer) As Integer
    Try
      Dim sCommand As String
      sCommand = siParamName & "=" & CStr(Value)
      Return SendSocketCommand(Me.CPiSocketUDPSend, sCommand)
    Catch ex As Exception
      'AddError(ex.Source, ex.ToString)
      Return 0
    End Try
  End Function
  Public Function SendDataPoolValue(ByVal siParamName As String, ByVal Value As Decimal) As Integer
    Try
      Dim sCommand As String
      sCommand = siParamName & "=" & DecimalToString(Value)
      Return SendSocketCommand(Me.CPiSocketUDPSend, sCommand)
    Catch ex As Exception
      'AddError(ex.Source, ex.ToString)
      Return 0
    End Try
  End Function
  Public Function SendDataPoolBatch(ByVal siBatch As String) As Integer
    Try
      Return SendSocketCommand(Me.CPiSocketUDPSend, siBatch)
    Catch ex As Exception
      'AddError(ex.Source, ex.ToString)
      Return 0
    End Try
  End Function

  Public Function SendUDPCommand(ByVal siCommand As String, Optional ByVal niIndex As Integer = -1) As Integer
    Return SendSocketCommand(Me.CPiSocketUDPSend, siCommand, niIndex)
  End Function


  Private Function SendSocketCommand(ByVal CiSocket As SocketClient, ByVal siCommand As String, Optional ByVal niIndex As Integer = 0) As Integer
    Dim sAux As String
    Dim lTicks As Long = Now.Ticks
    Try
      If niIndex <> 0 Then
        nPiLastCommand = nPiLastCommand + 1
        sAux = CStr(nPiLastCommand) & " " & siCommand & vbNullChar
      Else
        sAux = "-1 " & siCommand & vbNullChar
      End If

      'sAux = CStr(nPiLastCommand) & " " & siCommand & vbNullChar
      CiSocket.Send(sAux)

      'lTicks = Now.Ticks - lTicks : Debug.Print("CiSocket.Send " & siCommand & " " & CInt(lTicks / TimeSpan.TicksPerMillisecond)) : lTicks = Now.Ticks
      RaiseEvent RawDataSent(sAux)
      Return nPiLastCommand

    Catch ex As Exception
      'AddError(Me.ToString, "SendSocketCommand", ex.ToString)
      Return 0
    End Try
  End Function

  Private Function SendSocketCommand(ByVal CiSocket As System.Net.Sockets.Socket, ByVal siCommand As String, Optional ByVal niIndex As Integer = 0) As Integer
    Dim sAux As String
    Try
      Dim lTicks As Long = Now.Ticks
      If niIndex <> 0 Then
        nPiLastCommand = nPiLastCommand + 1
        sAux = CStr(nPiLastCommand) & " " & siCommand & vbNullChar
      Else
        sAux = "-1 " & siCommand & vbNullChar
      End If

      Dim bytesSend() As Byte = System.Text.Encoding.UTF8.GetBytes(sAux)
      'CiSocket.Send(CObj(sAux))

      'lTicks = Now.Ticks - lTicks : Debug.Print("prepare bytes " & siCommand & " " & CInt(lTicks / TimeSpan.TicksPerMillisecond)) : lTicks = Now.Ticks
      If Not CiSocket Is Nothing Then
        CiSocket.Send(bytesSend)
        'lTicks = Now.Ticks - lTicks : Debug.Print("send bytes " & bytesSend.Length & " " & CInt(lTicks / TimeSpan.TicksPerMillisecond)) : lTicks = Now.Ticks
        RaiseEvent RawDataSent(sAux)
        Return nPiLastCommand
      End If

    Catch ex As Exception
      'AddError(Me.ToString, "SendSocketCommand", ex.ToString)
      Return 0
    End Try
  End Function

  Public Sub New()
    Try
      'Me.TimerDataArrival = New Timer
      'Me.TimerDataArrival.Interval = 5
      'Me.TimerDataArrival.Enabled = True

    Catch ex As Exception
      'AddError(Me.ToString, "New", ex.ToString)
    End Try
  End Sub

  Private Sub Process()
    Try
      If Me.LlistaDataArrivalTCP.Count > 0 Then
        RaiseEvent RawDataArrival(Me.LlistaDataArrivalTCP(0))
        InterpretarComanda(0)
        Me.LlistaDataArrivalTCP.RemoveAt(0)
      End If
    Catch ex As Exception
      'AddError(ex.Source, ex.ToString)
    End Try
  End Sub

  Private Sub InterpretarComanda(ByVal niID As Integer)
    Dim sData As String
    Dim CCommand As New Command
    Dim tAux As Command
    Dim nAux As Integer = 0

    Dim sAux() As String
    Try
      sData = ""
      For i As Integer = 0 To Me.LlistaDataArrivalTCP.Count - 1
        sData = Me.LlistaDataArrivalTCP.Item(i)
        sAux = sData.Split(CChar(" "))
        'Debug.Print(sData)

        If sAux.Length > 0 Then
          If sAux.Length = 2 AndAlso sAux(1) = "" Then
            'això és un ack! quasi que passem
          End If
          If sAux(0) <> "-1" Then
            For nIndex As Integer = 0 To Me.LlistaComandesSenseResposta.Count - 1
              tAux = Me.LlistaComandesSenseResposta(0)
              If CStr(tAux.ID) = sAux(0) Then
                Me.LlistaComandesSenseResposta.RemoveAt(0)
                Exit For
              Else
                Me.LlistaComandesSenseResposta.RemoveAt(0)
              End If
            Next
            For nAux = Me.LlistaComandes.Count - 1 To 0 Step -1
              tAux = Me.LlistaComandes(nAux)
              If tAux Is Nothing Then
                Me.LlistaComandes.RemoveAt(nAux)
              ElseIf CStr(tAux.ID) = sAux(0) Then
                CCommand = tAux
                CCommand.ReceivedData = CCommand.ReceivedData & sData.Substring(InStr(sData, " "))
                CCommand.ReceivedData = CCommand.ReceivedData.Replace(vbNullChar, "").Trim
                CCommand.Host = Me.Config.TCPHost
                If sAux.Length > 1 Then
                  CCommand.BoolError = (sAux(1) = "ERROR")
                Else
                  CCommand.BoolError = False
                End If
                CCommand.BoolWasResponse = True
              End If
            Next
          End If
        End If
        If CCommand.BoolError = False Then
          Select Case CCommand.VizrtCommand
            Case eVizrtCommands.GetNodePosition
              Dim X, Y, Z As Decimal
              sAux = CCommand.ReceivedData.Split(CChar(" "))
              X = CDec(Replace(sAux(0), ".", ","))
              Y = CDec(Replace(sAux(1), ".", ","))
              Z = CDec(Replace(sAux(2), ".", ","))
              RaiseEvent DataArrivalNodePosition(CCommand.Source, X, Y, Z)
            Case eVizrtCommands.GetNodeRotation
              Dim X, Y, Z As Decimal
              sAux = CCommand.ReceivedData.Split(CChar(" "))
              X = CDec(Replace(sAux(0), ".", ","))
              Y = CDec(Replace(sAux(1), ".", ","))
              Z = CDec(Replace(sAux(2), ".", ","))
              RaiseEvent DataArrivalNodeRotation(CCommand.Source, X, Y, Z)
            Case eVizrtCommands.GetNodeScaling
              Dim X, Y, Z As Decimal
              sAux = CCommand.ReceivedData.Split(CChar(" "))
              X = CDec(Replace(sAux(0), ".", ","))
              Y = CDec(Replace(sAux(1), ".", ","))
              Z = CDec(Replace(sAux(2), ".", ","))
              RaiseEvent DataArrivalNodeScaling(CCommand.Source, X, Y, Z)
            Case eVizrtCommands.GetNodeText
              Dim sText As String
              sAux = CCommand.ReceivedData.Split(CChar(" "))
              sText = CCommand.ReceivedData
              sText = sText.Replace(vbCrLf, "")
              sText = sText.Replace(vbCr, "")
              sText = sText.Replace(vbLf, "")
              sText.Trim()
              RaiseEvent DataArrivalNodeText(CCommand.Source, sText)
            Case eVizrtCommands.GetAllDirectors
              Dim vAux() As String
              Dim sText As String
              Dim Llista As New List(Of String)
              vAux = CCommand.ReceivedData.Split(CChar(" "))

              For j As Integer = 0 To vAux.Length - 1
                sText = vAux(j)
                Llista.Add(sText)
              Next
              RaiseEvent DataArrivalSceneAnimations(Llista)
            Case eVizrtCommands.GetControlobjectPrepare
            Case eVizrtCommands.GetActiveScene
              'Ja demanem quin caraju d'escena és aquesta!
              Me.GetScenePathFromID(CCommand.ReceivedData)
              RaiseEvent DataArrivalGetActiveScene(CCommand.ReceivedData)
              RaiseEvent DataArrivalGetActiveScene_Ex(Me, CCommand.ReceivedData)
            Case eVizrtCommands.LoadScene
              RaiseEvent DataArrivalGetActiveScene(CCommand.Source)
              RaiseEvent DataArrivalGetActiveScene_Ex(Me, CCommand.Source)
            Case eVizrtCommands.GetLoadedScenes
              Dim Llista() As String
              Dim nIndex As Integer
              Dim sAux2() As String


              sAux = CCommand.ReceivedData.Split("#")
              ReDim Llista((sAux.Length - 1) / 2 - 1)
              For nIndex = 1 To sAux.Length - 1 Step 2
                'El primer número és l'ID de l'escena
                sAux2 = sAux(nIndex).Split(",")
                Llista((nIndex - 1) / 2) = "#" & sAux2(0)
                'Ja demanem quin caraju d'escena és aquesta!
                Me.GetScenePathFromID(Llista((nIndex - 1) / 2))
              Next
              RaiseEvent DataArrivalGetLoadedScenes_Ex(Me, Llista)
            Case eVizrtCommands.GetScenePathFromID
              Dim sPath As String
              sPath = CCommand.ReceivedData.Replace("SCENE*", "")
              RaiseEvent DataArrivalGetScenePathFromID(CCommand.Source, sPath)
              RaiseEvent DataArrivalGetScenePathFromID_Ex(Me, CCommand.Source, sPath)
            Case eVizrtCommands.DirectorGetStatus
              sAux = CCommand.ReceivedData.Split(" ")
              If sAux.Length = 3 Then
                RaiseEvent DataArrivalDirectorGetStatus(sAux(0), CDbl(sAux(2).Replace(".", ",")), CDbl(sAux(1).Replace(".", ",")))
              ElseIf sAux.Length = 6 Then
                RaiseEvent DataArrivalDirectorGetStatus(sAux(0), CDbl(sAux(5).Replace(".", ",")), CDbl(sAux(1).Replace(".", ",")))
              Else
                RaiseEvent DataArrivalDirectorGetStatus("", "", "")
              End If
            Case eVizrtCommands.DirectorGetStartTime
              sAux = CCommand.ReceivedData.Split(" ")
              If sAux.Length = 3 Then
                RaiseEvent DataArrivalDirectorGetStatus(sAux(0), CDbl(sAux(2).Replace(".", ",")), CDbl(sAux(1).Replace(".", ",")))
              ElseIf sAux.Length = 6 Then
                RaiseEvent DataArrivalDirectorGetStatus(sAux(0), CDbl(sAux(5).Replace(".", ",")), CDbl(sAux(1).Replace(".", ",")))
              Else
                RaiseEvent DataArrivalDirectorGetStatus("", "", "")
              End If
            Case eVizrtCommands.DirectorGetEndTime
              sAux = CCommand.ReceivedData.Split(" ")
              Dim fAux = CSng(CCommand.ReceivedData.Replace(".", ",")) * 50

              RaiseEvent DataArrivalDirectorGetEndTime(CCommand.Source, fAux, 0)
            Case eVizrtCommands.DirectorGetKeyframeTime
              sAux = CCommand.ReceivedData.Split(" ")
              Dim fAux = CSng(CCommand.ReceivedData.Replace(".", ",")) * 50

              RaiseEvent DataArrivalDirectorKeyFrameTime(CCommand.Source, "", fAux)

            Case eVizrtCommands.StageGetDirectors
              Dim Llista As New List(Of String)
              Dim asAux() As String = CCommand.ReceivedData.Split("{")
              Dim asAux2() As String
              For nIndex As Integer = 0 To asAux.Length Mod 5
                asAux2 = asAux(5 * nIndex + 1).Split(" ")
                Llista.Add(asAux2(4))
              Next
              RaiseEvent DataArrivalStageGetDirectors(Llista)
            Case eVizrtCommands.GetMemoryStats

              sAux = CCommand.ReceivedData.Split(" ")
              Dim adData(4) As Double
              For nIndex As Integer = 1 To sAux.Length - 1 Step 2
                Select Case sAux(nIndex)
                  Case "TOTAL"
                    adData(0) = Math.Abs(CDbl(sAux(nIndex + 1)))
                  Case "PIXEL"
                    adData(1) = Math.Abs(CDbl(sAux(nIndex + 1)))
                  Case "ALLOCATED"
                    adData(2) = Math.Abs(CDbl(sAux(nIndex + 1)))
                  Case "SIZE"
                    adData(3) = Math.Abs(CDbl(sAux(nIndex + 1)))
                End Select
              Next
              RaiseEvent DataArrivalGetMemoryStats(adData(0), adData(1), adData(2), adData(3))
            Case eVizrtCommands.GetFontsAtPath
              Dim Llista As New List(Of String)
              RaiseEvent DataArrivalGetFontsAtPath(CCommand.Source, Llista)
            Case eVizrtCommands.GetImagesAtPath
              Dim Llista As New List(Of String)
              Dim asAux() As String = CCommand.ReceivedData.Split("*")
              For nIndex As Integer = 0 To asAux.Length - 1
                asAux(nIndex) = asAux(nIndex).Trim
                If asAux(nIndex) <> "" And asAux(nIndex) <> "IMAGE" Then
                  If asAux(nIndex).EndsWith("IMAGE") Then
                    asAux(nIndex) = asAux(nIndex).Substring(0, asAux(nIndex).Length - 6)
                  End If
                  Llista.Add(asAux(nIndex).Trim)
                End If

              Next
              RaiseEvent DataArrivalGetImagesAtPath(CCommand.Source, Llista)
            Case eVizrtCommands.GetNodesAtPath
              Dim Llista As New List(Of tyTreeNode)
              Dim asAux() As String = CCommand.ReceivedData.Split("}")
              Dim sNom As String = ""
              Dim tAuxNode As tyTreeNode
              For nIndex As Integer = 0 To asAux.Length - 1
                tAuxNode = New tyTreeNode

                sNom = asAux(nIndex).Replace("SCENE*", "").Replace("{", "").Trim
                tAuxNode.HasSubNodes = sNom.EndsWith(" 1")
                sNom = sNom.Replace(" 1", "")
                sNom = sNom.Replace(" 0", "")
                If sNom.Contains("/") Then
                  tAuxNode.Name = sNom.Substring(sNom.LastIndexOf("/") + 1)
                Else
                  tAuxNode.Name = sNom
                End If
                tAuxNode.Path = sNom.Trim
                If tAuxNode.Path <> "" Then
                  Llista.Add(tAuxNode)
                End If
              Next
              RaiseEvent DataArrivalGetNodesAtPath(CCommand.Source, Llista)
            Case eVizrtCommands.GetScenesAtPath
              Dim Llista As New List(Of String)
              Dim asAux() As String = CCommand.ReceivedData.Split("}")
              For nIndex As Integer = 0 To asAux.Length / 4 - 1
                Llista.Add(asAux(4 * nIndex).Replace("SCENE*", "").Replace("{", "").Trim)
              Next
              RaiseEvent DataArrivalGetScenesAtPath(CCommand.Source, Llista)
            Case eVizrtCommands.GetIcon
              Dim CImage As System.Drawing.Bitmap = New System.Drawing.Bitmap(16, 16)
              RaiseEvent DataArrivalGetIcon(CCommand.Source, CImage)
            Case eVizrtCommands.GetSceneBackgroundImageActive
              Dim bAux As Boolean = False
              RaiseEvent DataArrivalGetSceneBackgroundImageActive(bAux)
            Case Else

          End Select
          If CCommand.ID > 0 Then
            RaiseEvent CommandResponse(CCommand)
            Me.LlistaComandes.Remove(CCommand)
          End If
        Else
          Select Case CCommand.VizrtCommand
            Case eVizrtCommands.GetNodeText
              RaiseEvent DataArrivalNodeText(CCommand.Source, "")
            Case Else
              RaiseEvent CommandResponse(CCommand)
              Me.LlistaComandes.Remove(CCommand)
          End Select
        End If
      Next
    Catch ex As Exception
      'AddError(ex.Source, ex.ToString)
    End Try
  End Sub

  Protected Overrides Sub Finalize()
    bPiExit = True
    MyBase.Finalize()
  End Sub

  Private Sub CPiSocketTCP_Connected(ByVal connected As Boolean) Handles CPiSocketTCP.Connected
    Try
      If connected Then
        ePiSocketStateTCP = eSocketState.Connected
        RaiseEvent TCPSocketConnected()
        RaiseEvent TCPSocketConnected_Ex(Me)
      End If
    Catch ex As Exception
      'AddError(ex.Source, ex.ToString)
    End Try
  End Sub

  Private Sub CPiSocketTCP_Exception(ByVal ex As System.Exception) Handles CPiSocketTCP.Exception
    MsgBox(ex.ToString)
    If Not CPiSocketTCP.IsConnected() Then
      ePiSocketStateTCP = eSocketState.Disconnected
      RaiseEvent TCPSocketDisconnected()
    End If
  End Sub

  Private Sub CPiSocketTCP_Receive(ByVal receiveData As String) Handles CPiSocketTCP.Receive
    Dim sData As String = ""
    Dim obj As Object = Nothing
    Static bWorking As Boolean = False
    Dim vData() As String = {""}
    Try
      If bWorking Then Exit Sub
      Exit Sub
      bWorking = True

      sData = receiveData
      vData = sData.Split(CChar(vbNullChar))
      sData = Replace(sData, vbNullChar, "")
      If vData.Length > 1 Then
        For i As Integer = 0 To vData.Length - 2
          sData = vData(i)
          If LlistaDataArrivalTCP.Count > 0 Then
            'Hi havia el final d'una comanda anterior pendent!
            sData = LlistaDataArrivalTCP.Item(0) & sData
            LlistaDataArrivalTCP.RemoveAt(0)
          End If
          'Debug.Print(sData)
          If sData <> "" Then
            RaiseEvent RawDataArrival(sData)
            LlistaDataArrivalTCP.Add(sData)
            InterpretarComanda(0)
            LlistaDataArrivalTCP.RemoveAt(0)
          End If
        Next
      Else
        'No hi ha vbnullchar--> la comanda encara no s'ha acabat!
        sData = vData(0)
        'Debug.Print(sData)
        If LlistaDataArrivalTCP.Count > 0 Then
          'Hi havia el final d'una comanda anterior pendent!
          sData = LlistaDataArrivalTCP.Item(0) & sData
          LlistaDataArrivalTCP.RemoveAt(0)
        End If
        LlistaDataArrivalTCP.Add(sData)
      End If

      bWorking = False
    Catch ex As Exception
      'AddError(Me.ToString, "CPiSocketTCP_DataArrival", ex.ToString)
      bWorking = False
    End Try
  End Sub

  Private Sub CPiSocketTCP_ReceiveWithBytes(ByVal receiveData As String, ByVal receiveBytes() As Byte) Handles CPiSocketTCP.ReceiveWithBytes
    Dim sData As String
    Dim obj As Object = Nothing
    Dim bytes() As Byte
    Static bWorking As Boolean = False
    Dim vData() As String
    Static totalBytes() As Byte
    Dim nCorrection As Integer = 0
    Try
      If bWorking Then Exit Sub
      bWorking = True
      'Debug.Print(CStr(CPiSocketTCP2.BytesReceived))
      'CPiSocketTCP2.GetData(obj)
      bytes = receiveBytes
      sData = ""

      'If bytes.Length < 8192 Then
      If totalBytes Is Nothing Then
        totalBytes = bytes
      Else
        ReDim Preserve totalBytes(totalBytes.Length + bytes.Length - 1)
        For nIndex As Integer = 0 To bytes.Length - 1
          totalBytes(nIndex + totalBytes.Length - bytes.Length) = bytes(nIndex)
        Next
      End If

      While Me.LlistaComandesSenseResposta.Count > 0 AndAlso Me.LlistaComandesSenseResposta(0) Is Nothing
        Me.LlistaComandesSenseResposta.RemoveAt(0)
      End While


      If Me.LlistaComandesSenseResposta.Count > 0 AndAlso Me.LlistaComandesSenseResposta(0).Icon = True Then
        'si esperàbem una icona...
        Dim c As System.Drawing.Color
        Dim nAux As Integer
        Dim CCommand As Command
        CCommand = Me.LlistaComandesSenseResposta(0)
        If CCommand.Image.Height * CCommand.Image.Width * 3 + 4 <= totalBytes.Length Then
          nCorrection = totalBytes.Length - CCommand.Image.Height * CCommand.Image.Width * 3 + 4
          Me.LlistaComandesSenseResposta.RemoveAt(0)
          sData = System.Text.Encoding.UTF8.GetChars(totalBytes, totalBytes.Length - nCorrection, nCorrection - 1)
          With CCommand
            For i As Integer = 0 To .Image.Height - 1
              For j As Integer = 0 To .Image.Width - 1

                'c = System.Drawing.Color.FromArgb(totalBytes(.Image.Width * i * 3 + j * 3 + 4), totalBytes(.Image.Width * i * 3 + j * 3 + 4 + 1), totalBytes(.Image.Width * i * 3 + j * 3 + 4 + 2))
                nAux = 4 + (.Image.Width * i + j) * 3
                If nAux < totalBytes.Length Then
                  'franges!!
                  If i < 20 Then
                    c = System.Drawing.Color.FromArgb(totalBytes(nAux), totalBytes(nAux), totalBytes(nAux))
                  ElseIf i < 30 Then
                    c = System.Drawing.Color.FromArgb(totalBytes(nAux), totalBytes(nAux), totalBytes(nAux))
                  ElseIf i < 60 Then
                    c = System.Drawing.Color.FromArgb(totalBytes(nAux), totalBytes(nAux), totalBytes(nAux))
                  Else
                    c = System.Drawing.Color.FromArgb(totalBytes(nAux), totalBytes(nAux), totalBytes(nAux))
                  End If
                  c = System.Drawing.Color.FromArgb(totalBytes(nAux), totalBytes(nAux + 1), totalBytes(nAux + 2))
                  'nRes = CInt((CInt(totalBytes(nAux)) + CInt(totalBytes(nAux + 1)) + CInt(totalBytes(nAux + 2))) / 3)
                  'c = System.Drawing.Color.FromArgb(nRes, nRes, nRes)
                  'c = System.Drawing.Color.FromArgb(totalBytes(nAux), 0, 0)

                  .Image.SetPixel(j, i, c)
                Else
                  c = System.Drawing.Color.FromArgb(Now().Millisecond Mod 255, 255, 0)
                  .Image.SetPixel(j, i, c)
                  Debug.Print(nAux)
                End If
              Next
            Next
            totalBytes = Nothing

            .BoolError = False
            .BoolWasResponse = True
            RaiseEvent CommandResponse(CCommand)
            Me.LlistaComandes.Remove(CCommand)
            RaiseEvent DataArrivalGetIcon(.Source, .Image)
          End With
        End If

      Else
        'si lo que esperem no és una comanda binària, separar i fer cosses...
        sData = System.Text.Encoding.UTF8.GetChars(totalBytes)
        totalBytes = Nothing
        vData = sData.Split(CChar(vbNullChar))
        sData = Replace(sData, vbNullChar, "")
        If vData.Length > 1 Then
          For i As Integer = 0 To vData.Length - 2
            sData = vData(i)
            If LlistaDataArrivalTCP.Count > 0 Then
              'Hi havia el final d'una comanda anterior pendent!
              sData = LlistaDataArrivalTCP.Item(0) & sData
              LlistaDataArrivalTCP.RemoveAt(0)
            End If
            'Debug.Print(sData)
            RaiseEvent RawDataArrival(sData)
            LlistaDataArrivalTCP.Add(sData)
            InterpretarComanda(0)
            LlistaDataArrivalTCP.RemoveAt(0)
          Next
        Else
          'No hi ha vbnullchar--> la comanda encara no s'ha acabat!
          sData = vData(0)
          'Debug.Print(sData)
          If LlistaDataArrivalTCP.Count > 0 Then
            'Hi havia el final d'una comanda anterior pendent!
            sData = LlistaDataArrivalTCP.Item(0) & sData
            LlistaDataArrivalTCP.RemoveAt(0)
          End If
          LlistaDataArrivalTCP.Add(sData)
        End If
      End If
      'Else
      ''encara queda comanda per arribar!
      'If totalBytes Is Nothing Then
      '  totalBytes = bytes
      'Else
      '  ReDim Preserve totalBytes(totalBytes.Length + bytes.Length - 1)
      '  For nIndex As Integer = 0 To bytes.Length - 1
      '    totalBytes(nIndex + totalBytes.Length - bytes.Length) = bytes(nIndex)
      '  Next
      'End If

      'End If

      bWorking = False
    Catch ex As Exception
      totalBytes = Nothing
      'AddError(Me.ToString, "CPiSocketTCP_DataArrival", ex.ToString)
      bWorking = False
    End Try
  End Sub
End Class
