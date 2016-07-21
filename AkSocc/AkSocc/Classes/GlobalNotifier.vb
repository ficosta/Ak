Public Class GlobalNotifier
#Region "Singleton"
  Private Shared ReadOnly _instance As New Lazy(Of GlobalNotifier)(Function() New GlobalNotifier(), System.Threading.LazyThreadSafetyMode.ExecutionAndPublication)

  Private Sub New()

  End Sub

  Public Shared ReadOnly Property Instance() As GlobalNotifier
    Get
      Return _instance.Value
    End Get
  End Property
#End Region

  Public Enum eMessageType
    AppError
    Warning
    Info
  End Enum

  Public Structure tyMessage
    Dim time As Date
    Dim type As eMessageType
    Dim text As String
  End Structure

  Private _messageList As New List(Of String)
  Public Event NewMessage(msg As tyMessage)

  Public Sub AddInfoMessage(text As String)
    Dim aux As tyMessage
    aux.time = Now
    aux.text = text
    aux.type = eMessageType.Info
    RaiseEvent NewMessage(aux)
  End Sub

  Public Sub AddWarningMessage(text As String)
    Dim aux As tyMessage
    aux.time = Now
    aux.text = text
    aux.type = eMessageType.Warning
    RaiseEvent NewMessage(aux)
  End Sub

  Public Sub AddErrorMessage(text As String)
    Dim aux As tyMessage
    aux.time = Now
    aux.text = text
    aux.type = eMessageType.AppError
    RaiseEvent NewMessage(aux)
  End Sub

End Class
