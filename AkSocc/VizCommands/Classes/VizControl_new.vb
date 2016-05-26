Public Structure VizConfig
  Dim Host As String
  Dim Port As Integer
  Dim PreviewPort As Integer
  Dim ScenePath As String
End Structure


Public Class VizControl_new
  Public Property Config As VizConfig

#Region "Events"
  Public Event Connected()
  Public Event Disconnected()
#End Region

#Region "Constructors"
  Public Sub New()

  End Sub

  Public Sub New(host As String)

  End Sub

  Public Sub New(host As String, port As Integer)

  End Sub

  Public Sub New(host As String, port As Integer, pvwPort As Integer)

  End Sub
#End Region

#Region "Comunication functions"
  Public Sub Connect()

  End Sub

  Public Sub Disconnect()

  End Sub
#End Region

#Region "General functions"
  Public Function ActivateSceneOnLayer(scene As String, layer As VizCommands.SceneLayer) As Boolean
    Return False
  End Function

  Public Function SendParameterToScene(scene As String, treePath As String, value As String) As Boolean
    Return False
  End Function

  Public Function SendParameterToScene(scene As String, rootNode As String, name As String, value As String) As Boolean
    Return False
  End Function

  Public Function SendParameterToScene(scene As String, param As SceneParameter) As Boolean
    Return False
  End Function
#End Region
End Class
