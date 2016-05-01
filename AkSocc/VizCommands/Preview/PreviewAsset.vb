Public Enum ePreviewAssetState
  Idle
  Rendering
  Done
End Enum
Public Class PreviewAsset
  Public UId As Guid = Guid.NewGuid
  Public Scene As Scene
  Public AssetSate As ePreviewAssetState = ePreviewAssetState.Idle
  Public GeneratedDate As Date
  Public ID As String = ""

  Public ReadOnly Property AssetFileName() As String
    Get
      Return Me.ID
    End Get
  End Property

  Private _assetImage As New Drawing.Bitmap(1, 1)
  Public Property AssetImage() As Drawing.Bitmap
    Get
      Return _assetImage
    End Get
    Set(ByVal value As Drawing.Bitmap)
      _assetImage = value
    End Set
  End Property

#Region "Constructors"
  Public Sub New()
    Me.ID = UId.ToString
    Me.AssetSate = ePreviewAssetState.Idle
  End Sub

  Public Sub New(ByVal id As String)
    Me.ID = id
    Me.AssetSate = ePreviewAssetState.Idle
  End Sub

  Public Sub New(ByVal scene As Scene)
    Me.ID = UId.ToString
    Me.Scene = scene
    Me.AssetSate = ePreviewAssetState.Idle
  End Sub

  Public Sub New(ByVal id As String, ByVal scene As Scene)
    Me.ID = id
    Me.Scene = scene
    Me.AssetSate = ePreviewAssetState.Idle
  End Sub
#End Region


End Class
