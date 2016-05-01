Public Enum paramType
  Text = 0
  Image = 1
  Numeric = 2
End Enum

<Serializable()> Public Class SceneParameter
  Public Property ID As String = Guid.NewGuid().ToString
  Public Name As String
  Public Value As String
  Public Property Type As paramType = paramType.Text

  Public Sub New()

  End Sub

  Public Sub New(name As String, value As String)
    Me.Name = name
    Me.Value = value
  End Sub

  Public Sub New(name As String, value As String, type As paramType)
    Me.Name = name
    Me.Value = value
    Me.Type = type
  End Sub
End Class
