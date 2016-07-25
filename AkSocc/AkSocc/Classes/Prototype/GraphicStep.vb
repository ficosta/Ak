Imports AkSocc

Public Class GraphicStep
  Public Property UID As String = Guid.NewGuid().ToString
  Public Property Name As String

  Public Property IsTitleOnly As Boolean = False
  Public Property IsSeparator As Boolean = False

  Public Property IsFinalStep As Boolean = False
  Public Property IsTransitionalStep As Boolean = False

  'Public Property Depth As Integer = 0
  Public ReadOnly Property Depth As Integer
    Get
      Dim aux As GraphicStep = Me.RootGraphicStep.ChildGraphicStep
      Dim res As Integer = 0

      While Not aux Is Nothing
        aux = aux.ChildGraphicStep
        res += 1
      End While
      Return res
    End Get
  End Property

  Public Property GraphicSteps As New GraphicSteps
  Public Property ParentGraphicStep As GraphicStep = Nothing

  Public ReadOnly Property RootGraphicStep As GraphicStep
    Get
      Dim res As GraphicStep = Me
      While Not res.ParentGraphicStep Is Nothing
        res = res.ParentGraphicStep
      End While
      Return res
    End Get
  End Property

  Private _childGraphicStep As GraphicStep = Nothing
  Public Property ChildGraphicStep As GraphicStep
    Get
      Return _childGraphicStep
    End Get
    Set(value As GraphicStep)
      _childGraphicStep = value
    End Set
  End Property

  Public Property SceneParameters As VizCommands.SceneParameters


  Class GraphicStepDefinition
    Public Key As String

    Private _name As String = ""
    Public Property Name As String
      Get
        If _name = "" Then
          Return Key
        Else
          Return _name
        End If
      End Get
      Set(value As String)
        _name = value
      End Set
    End Property

    Public Sub New()

    End Sub

    Public Sub New(key As String)
      Me.Key = key
    End Sub

    Public Sub New(key As String, name As String)
      Me.Key = key
      Me.Name = name
    End Sub

    Public Overrides Function ToString() As String
      Return Me.Name
    End Function

    Public Shared Narrowing Operator CType(ByVal b As String) As GraphicStepDefinition
      Return New GraphicStepDefinition(b)
    End Operator

    Public Shared Widening Operator CType(ByVal d As GraphicStepDefinition) As String
      Return d.ToString
    End Operator
  End Class


  Public Sub New(parentGraphicStep As GraphicStep, name As String)
    Me.New(parentGraphicStep, name, "", False, True, False, False)
  End Sub

  Public Sub New(parentGraphicStep As GraphicStep, stepDefinition As GraphicStepDefinition)
    Me.New(parentGraphicStep, stepDefinition.ToString, "", False, True, False, False)
  End Sub

  Public Sub New(parentGraphicStep As GraphicStep, name As String, id As String)
    Me.New(parentGraphicStep, name, id, False, True, False, False)
  End Sub

  Public Sub New(parentGraphicStep As GraphicStep, name As String, id As String, isFinal As Boolean, isTransitionalStep As Boolean)
    Me.New(parentGraphicStep, name, id, isFinal, isTransitionalStep, False, False)
  End Sub

  Public Sub New(parentGraphicStep As GraphicStep, name As String, isFinal As Boolean, isTransitionalStep As Boolean)
    Me.New(parentGraphicStep, name, "", isFinal, isTransitionalStep, False, False)
  End Sub

  Public Sub New(parentGraphicStep As GraphicStep, stepDefinition As GraphicStepDefinition, isFinal As Boolean, isTransitionalStep As Boolean)
    Me.New(parentGraphicStep, stepDefinition.Name, stepDefinition.Key, isFinal, isTransitionalStep, False, False)
  End Sub

  Public Sub New(parentGraphicStep As GraphicStep, name As String, ID As String, isFinal As Boolean, isTransitionalStep As Boolean, isTitle As Boolean, isSeparator As Boolean)
    Me.Name = name
    Me.ParentGraphicStep = parentGraphicStep
    Me.UID = IIf(ID = "", Guid.NewGuid().ToString, ID)
    Me.IsFinalStep = isFinal
    Me.IsTitleOnly = isTitle
    Me.IsSeparator = isSeparator
    Me.IsTransitionalStep = isTransitionalStep
  End Sub

  Public Sub New(parentGraphicStep As GraphicStep, stepDefinition As GraphicStepDefinition, ID As String, isFinal As Boolean, isTransitionalStep As Boolean, isTitle As Boolean, isSeparator As Boolean)
    Me.Name = stepDefinition.Key
    Me.ParentGraphicStep = parentGraphicStep
    Me.UID = IIf(ID = "", Guid.NewGuid().ToString, ID)
    Me.IsFinalStep = isFinal
    Me.IsTitleOnly = isTitle
    Me.IsSeparator = isSeparator
    Me.IsTransitionalStep = isTransitionalStep
  End Sub

  Public Overrides Function ToString() As String
    Dim sRes As String = ""
    If Not Me.ParentGraphicStep Is Nothing Then sRes = Me.ParentGraphicStep.ToString & " : "
    sRes = sRes & Me.Name & " "
    'sRes = sRes & "[f=" & Me.IsFinalStep & "-t=" & Me.IsTransitionalStep & "]"
    Return sRes
  End Function
End Class
