Public Class Substitution
  Implements IComparable

  Public Property TeamID As Integer
  Public Property Team As Team

  Public Property PlayerIn As Player
  Public Property PlayerOut As Player

  Public Property timeInSeconds As Integer
  Public Property part As Integer

  Public Function CompareTo(obj As Object) As Integer Implements IComparable.CompareTo
    Dim res As Integer = -1
    Try
      Dim aux As Substitution = CType(obj, Substitution)
      If aux.part > Me.part Then
        res = 1
      ElseIf aux.part = Me.part Then
        If aux.timeInSeconds > Me.timeInSeconds Then
          res = 1
        ElseIf aux.timeInSeconds = Me.timeInSeconds Then
          res = 0
        End If
      End If
    Catch ex As Exception
    End Try
    Return res
  End Function

  Public Overrides Function ToString() As String
    If PlayerOut Is Nothing Or PlayerIn Is Nothing Then
      Return MyBase.ToString()
    Else
      Return "[OUT]" & PlayerOUT.ToString & " --> [IN]" & PlayerIN.ToString
    End If
  End Function
End Class
