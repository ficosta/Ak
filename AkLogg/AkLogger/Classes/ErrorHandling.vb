Public Class ErrorHandling
  Public Event ErrorLogged(ex As Exception)
  Public Sub LogError(ex As Exception)
    Debug.Print(ex.ToString)
    RaiseEvent ErrorLogged(ex)
  End Sub
End Class
