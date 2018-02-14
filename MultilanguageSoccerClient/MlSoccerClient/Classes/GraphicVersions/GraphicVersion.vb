<Serializable()> Public Class GraphicVersion
  Public Property Path As String
  Public Property Name As String
  Public Property UID As String = Guid.NewGuid.ToString
  Public Property Path2DLogos As String
  Public Property Path3DBadges As String
  Public Property PathTShirts As String
  Public Property PathColors As String
  Public Property LocalPathTShirts As String
  Public Property LocalPathColors As String

  Public Property UseLongPreview As Boolean

  Public Sub New()

  End Sub

  Public Sub New(name As String, path As String)
    Me.Name = name
    Me.Path = path
  End Sub

  Public Sub New(name As String, path As String, path2d As String, pathTShirts As String, path3d As String, pathColors As String, localPathColors As String, localPathTShirts As String)
    Me.Name = name
    Me.Path = path
    Me.PathTShirts = pathTShirts
    Me.PathColors = pathColors
    Me.Path2DLogos = path2d
    Me.Path3DBadges = path3d
    Me.LocalPathColors = localPathColors
    Me.LocalPathTShirts = localPathTShirts
  End Sub


  Public Overrides Function ToString() As String
    Return Me.Name
  End Function
End Class
