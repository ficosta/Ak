<Serializable()> Public Class SceneParameters
  Inherits CollectionBase

  Public Sub New()
  End Sub

  Public Function Add(sceneParameter As SceneParameter) As Integer
    Try
      If Not sceneParameter Is Nothing Then
        Dim found As Boolean
        For index As Integer = 0 To Me.List.Count - 1
          If Me.List(index).ID = sceneParameter.ID Then
            Me.List(index) = sceneParameter
            found = True
            Exit For
          End If
        Next
        If Not found Then
          Me.List.Add(sceneParameter)
        End If
      End If
    Catch ex As Exception
    End Try
    Return Me.List.Count
  End Function

  Default Public Property Item(Index As Integer) As SceneParameter
    Get
      Return DirectCast(List(Index), SceneParameter)
    End Get
    Set
      List(Index) = Value
    End Set
  End Property

  Public Function GetSceneParameter(name As String) As SceneParameter
    Dim output As SceneParameter = Nothing
    Try
      For Each SearchSceneParameter As SceneParameter In List
        If SearchSceneParameter.ID = name Or SearchSceneParameter.Name = name Then
          output = SearchSceneParameter
          Exit For
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
      For Each SearchSceneParameter As SceneParameter In List
        If SearchSceneParameter.Name = name Then
          output = True
          Exit For
        End If
      Next
    Catch err As Exception
      Throw err
    End Try
    Return (output)
  End Function

  Public Function Add(name As String, value As String, Optional type As paramType = paramType.Text) As SceneParameter
    Dim param As New SceneParameter(name, value, type)
    Try
      Dim index As Integer = -1
      For i As Integer = 0 To Me.Count - 1
        If Me.Item(i).Name = name Then
          index = i
        End If
      Next
      If index <> -1 Then
        Me.Item(index) = param
      Else
        Me.Add(param)
      End If
    Catch ex As Exception
    End Try
    Return param
  End Function
End Class
