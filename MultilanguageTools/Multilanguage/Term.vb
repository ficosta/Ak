Public Class Term
  Public Property Term As String = ""
  Public Property ID As Integer = 0
  Public Property Translation As String

  Public Sub New()
  End Sub

  Public Sub New(id As Integer)
    Me.Term = id
    Me.ID = id
    Me.Translation = ""
  End Sub

  Public Sub New(id As Integer, term As String)
    Me.Term = term
    Me.ID = id
    Me.Translation = ""
  End Sub

  Public Sub New(id As Integer, term As String, translation As String)
    Me.Term = term
    Me.ID = id
    Me.Translation = translation
  End Sub
End Class
