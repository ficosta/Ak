Public Class Translator
  Inherits CollectionBase

  Public Property Passthrough As Boolean = True

  Public Sub New()
  End Sub

  Public Function GetTranslation(english As String) As String

  End Function

  Public Function Add(translation As Translation) As Integer
    Try
      If Not translation Is Nothing Then
        Dim found As Boolean
        For index As Integer = 0 To Me.List.Count - 1
          If Me.List(index).English = translation.English Then
            Me.List(index) = translation
            found = True
            Exit For
          End If
        Next
        If Not found Then
          Me.List.Add(translation)
        End If
      End If
    Catch ex As Exception
    End Try
    Return Me.List.Count
  End Function

  Public Function Add(english As String, arabic As String) As Integer
    Return Me.Add(New Translation(english, arabic))
  End Function

  Default Public Property Item(Index As Integer) As Translation
    Get
      Return DirectCast(List(Index), Translation)
    End Get
    Set
      List(Index) = Value
    End Set
  End Property

End Class
