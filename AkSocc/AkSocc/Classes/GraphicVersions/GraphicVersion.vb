<Serializable()> Public Class GraphicVersion
  Public Property Path As String
  Public Property Name As String
  Public Property UID As String = Guid.NewGuid.ToString

  Public Sub New()

  End Sub

  Public Sub New(name As String, path As String)
    Me.Name = name
    Me.Path = path
  End Sub

  Public Overrides Function ToString() As String
    Return Me.Name
  End Function
End Class
