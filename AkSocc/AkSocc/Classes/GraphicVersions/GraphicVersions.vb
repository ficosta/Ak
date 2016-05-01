<Serializable()> Public Class GraphicVersions
  Inherits CollectionBase

  Public Sub New()
    Me.Add(New GraphicVersion("Saudi league", "MBC/Football/Scenes/"))
    Me.Add(New GraphicVersion("Cup", "MBC/CUP/"))

  End Sub

  Public Function Add(graphicVersion As GraphicVersion) As Integer
    Try
      If Not graphicVersion Is Nothing Then
        Dim found As Boolean
        For index As Integer = 0 To Me.List.Count - 1
          If Me.List(index).uid = graphicVersion.UID Then
            Me.List(index) = graphicVersion
            found = True
            Exit For
          End If
        Next
        If Not found Then
          Me.List.Add(graphicVersion)
        End If
      End If
    Catch ex As Exception
    End Try
    Return Me.List.Count
  End Function

  Default Public Property Item(Index As Integer) As GraphicVersion
    Get
      Return DirectCast(List(Index), GraphicVersion)
    End Get
    Set
      List(Index) = Value
    End Set
  End Property

  Public Function GetGraphicVersion(name As String) As GraphicVersion
    Dim output As GraphicVersion = Nothing
    Try
      For Each SearchGraphicVersion As GraphicVersion In List
        If SearchGraphicVersion.UID = name Or SearchGraphicVersion.Name = name Then
          output = SearchGraphicVersion
          Exit For
        End If
      Next
    Catch err As Exception
      Throw err
    End Try
    Return (output)
  End Function

  Public Function Contains(ID As String) As Boolean
    Dim output As Boolean = False
    Try
      For Each SearchGraphicVersion As GraphicVersion In List
        If SearchGraphicVersion.UID = ID Or SearchGraphicVersion.Name = ID Then
          output = True
          Exit For
        End If
      Next
      Catch err As Exception
        Throw err
      End Try
      Return (output)
    End Function
  End Class