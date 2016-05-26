<Serializable()> Public Class SceneDirectors
  Inherits CollectionBase

  Public Sub New()
  End Sub

  Public Function Add(sceneDirector As SceneDirector) As Integer
    Try
      If Not sceneDirector Is Nothing Then
        Dim found As Boolean
        For index As Integer = 0 To Me.List.Count - 1
          If Me.List(index).ID = sceneDirector.ID Then
            Me.List(index) = sceneDirector
            found = True
            Exit For
          End If
        Next
        If Not found Then
          Me.List.Add(sceneDirector)
        End If
      End If
    Catch ex As Exception
    End Try
    Return Me.List.Count
  End Function

  Default Public Property Item(Index As Integer) As SceneDirector
    Get
      Return DirectCast(List(Index), SceneDirector)
    End Get
    Set
      List(Index) = Value
    End Set
  End Property

  Public Function GetSceneDirector(name As String) As SceneDirector
    Dim output As SceneDirector = Nothing
    Try
      For Each SearchSceneDirector As SceneDirector In List
        If SearchSceneDirector.ID = name Or SearchSceneDirector.Name = name Then
          output = SearchSceneDirector
          Exit For
        End If
      Next
    Catch err As Exception
      Throw err
    End Try
    Return (output)
  End Function

  Public Function GetSceneDirectorsByFrame(frame As Integer) As SceneDirectors
    Dim output As New SceneDirectors
    Try
      For Each SearchSceneDirector As SceneDirector In List
        If SearchSceneDirector.Frame = frame Then
          output.Add(SearchSceneDirector)
        End If
      Next
    Catch err As Exception
      Throw err
    End Try
    Return (output)
  End Function

  Public Function Contains(name As String) As Boolean
    Dim output As Boolean = False
    Try
      For Each SearchSceneDirector As SceneDirector In List
        If SearchSceneDirector.Name = name Then
          output = True
          Exit For
        End If
      Next
    Catch err As Exception
      Throw err
    End Try
    Return (output)
  End Function

  Public Function Add(name As String, frame As Integer, Optional type As DirectorAction = DirectorAction.Start) As SceneDirector
    Dim director As New SceneDirector(name, frame, type)
    Try
      Dim index As Integer = -1
      For i As Integer = 0 To Me.Count - 1
        If Me.Item(i).Name = name Then
          index = i
        End If
      Next
      If index <> -1 Then
        Me.Item(index) = director
      Else
        Me.Add(director)
      End If
    Catch ex As Exception
    End Try
    Return director
  End Function

  Public ReadOnly Property MaxFrame As Integer
    Get
      Dim res As Integer = 0
      If Me.InnerList.Count = 0 Then
        res = 0
      Else
        res = 0
        For Each director As SceneDirector In Me.InnerList
          res = Math.Max(res, director.Frame)
        Next
      End If
      Return res
    End Get
  End Property
End Class
