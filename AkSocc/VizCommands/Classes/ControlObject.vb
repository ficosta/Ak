
Public Enum eControlObjectType
  ControlText
  ControlNum
  ControlHideOnEmpty
End Enum

Public Enum eControlObjectDataType
  richtext
  float
  input
  image
End Enum

Public Enum eControlObjectIndex
  Field = 0
  Location = 1
  DataType = 2
  MinValue = 3
  MaxValue = 4
  MaxCharacters = 5
  Description = 6
  Attributes = 7
End Enum

Public Class ControlObjectTree
  Dim LlistaNodes As New List(Of ControlObjectNode)

  Public Sub New()

  End Sub

  Public Sub New(ByVal siInputString As String)
    Try
      IniciarLlista(siInputString)
    Catch ex As Exception
      'AddError(ex.Source, ex.ToString)
    End Try
  End Sub

  Public Sub IniciarLlista(ByVal siInputString As String)
    Dim vAux() As String
    Dim CControlObject As ControlObjectNode
    Try
      vAux = siInputString.Split(CChar(vbLf))
      For i As Integer = 0 To vAux.Length - 1
        CControlObject = New ControlObjectNode(vAux(i))
        LlistaNodes.Add(CControlObject)
      Next

    Catch ex As Exception
      'AddError(ex.Source, ex.ToString)
    End Try
  End Sub

  Public Function GetControlObjectByField(ByVal siField As String) As List(Of ControlObjectNode)
    Dim Llista As New List(Of ControlObjectNode)
    Try
      For Each CObject As ControlObjectNode In Me.LlistaNodes
        If CObject.Field = siField Then
          Llista.Add(CObject)
        End If
      Next
      Return Llista
    Catch ex As Exception
      'AddError(ex.Source, ex.ToString)
      Return Llista
    End Try
  End Function

  Public Function GetControlObjectByNode(ByVal niNodeID As Integer) As List(Of ControlObjectNode)
    Dim Llista As New List(Of ControlObjectNode)
    Try
      For Each CObject As ControlObjectNode In Me.LlistaNodes
        If CObject.NodeID = niNodeID Then
          Llista.Add(CObject)
        End If
      Next
      Return Llista
    Catch ex As Exception
      'AddError(ex.Source, ex.ToString)
      Return Llista
    End Try
  End Function

  Public ReadOnly Property NodeCount() As Integer
    Get
      Return Me.LlistaNodes.Count
    End Get
  End Property

  Public ReadOnly Property Node(ByVal Index As Integer) As ControlObjectNode
    Get
      Try
        Return Me.LlistaNodes.Item(Index)
      Catch ex As Exception
        Return Nothing
      End Try
    End Get
  End Property
End Class

Public Class ControlObjectNode
  Public Field As String
  Public Description As String
  Public ControlType As eControlObjectType
  Public DataType As eControlObjectDataType
  Public Node As String
  Public NodeID As Integer
  Public Attributes As String


  Public Sub New()

  End Sub

  Public Sub New(ByVal siInputString As String)
    IniciarControlObject(siInputString)
  End Sub

  Public Sub IniciarControlObject(ByVal siInputString As String)

    Dim vAux() As String
    Dim sAux As String
    Try
      vAux = siInputString.Split(CChar(":"))
      For i As Integer = 0 To vAux.Length - 1
        Me.Field = vAux(eControlObjectIndex.Field)
        sAux = vAux(eControlObjectIndex.Location)
        Me.Node = sAux.Substring(0, InStr(sAux, "*") - 1)
        Me.NodeID = CInt(sAux.Substring(1, InStr(sAux, "*") - 2))
        sAux = sAux.Substring(InStr(sAux, "*"))
        Select Case sAux
          Case "FUNCTION*ControlHideOnEmpty*input"
            Me.ControlType = eControlObjectType.ControlHideOnEmpty
          Case "FUNCTION*ControlText*input"
            Me.ControlType = eControlObjectType.ControlText
          Case "FUNCTION*ControlParameter*input"
            Me.ControlType = eControlObjectType.ControlText
          Case "FUNCTION*ControlImage*input"
            Me.ControlType = eControlObjectType.ControlText
          Case "FUNCTION*ControlNum*input:float"
            Me.ControlType = eControlObjectType.ControlNum
        End Select
        Select Case vAux(eControlObjectIndex.DataType)
          Case eControlObjectDataType.richtext.ToString
            Me.DataType = eControlObjectDataType.richtext
          Case eControlObjectDataType.input.ToString
            Me.DataType = eControlObjectDataType.input
          Case eControlObjectDataType.float.ToString
            Me.DataType = eControlObjectDataType.float
          Case eControlObjectDataType.image.ToString
            Me.DataType = eControlObjectDataType.image
        End Select

        If vAux.Length > eControlObjectIndex.Description Then Me.Description = vAux(eControlObjectIndex.Description)
        If vAux.Length > eControlObjectIndex.Attributes Then Me.Attributes = vAux(eControlObjectIndex.Attributes)
      Next
    Catch ex As Exception
      'AddError(ex.Source, ex.Message)
    End Try
  End Sub
End Class