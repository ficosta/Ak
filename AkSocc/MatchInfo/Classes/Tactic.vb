<Serializable()> Public Class PosicioTactic
  Public IDTactic As Integer
  Public X As Decimal
  Public Y As Decimal
  Public Posicio As Integer
  Public Player As Player = Nothing
  Public Team As Team = Nothing
End Class

<Serializable()> Public Class Tactic

  Public IDEsport As Integer
  Public IDTactic As Integer = 0
  Public NomTactic As String
  Public Descripcio As String
  Public LlistaPosicions As New List(Of PosicioTactic)

  Public Sub New()
    CreateEmptyTactic()
  End Sub

  Public Sub New(ByVal niIDEsport As Integer, ByVal niIDTactic As Integer)
    Me.IDEsport = niIDEsport
    Me.IDTactic = niIDTactic
    CreateEmptyTactic()
  End Sub

  Public Sub CreateEmptyTactic()
    Try
      Dim scale As Double = 200
      Me.LlistaPosicions.Clear()
      Me.Descripcio = "4-4-2"
      Me.LlistaPosicions.Add(New PosicioTactic() With {.IDTactic = Me.IDTactic, .Posicio = 1, .X = scale * 0.0, .Y = scale * -0.4})
      Me.LlistaPosicions.Add(New PosicioTactic() With {.IDTactic = Me.IDTactic, .Posicio = 2, .X = scale * -0.4, .Y = scale * -0.25})
      Me.LlistaPosicions.Add(New PosicioTactic() With {.IDTactic = Me.IDTactic, .Posicio = 3, .X = scale * -0.1, .Y = scale * -0.25})
      Me.LlistaPosicions.Add(New PosicioTactic() With {.IDTactic = Me.IDTactic, .Posicio = 4, .X = scale * 0.1, .Y = scale * -0.25})
      Me.LlistaPosicions.Add(New PosicioTactic() With {.IDTactic = Me.IDTactic, .Posicio = 5, .X = scale * 0.4, .Y = scale * -0.25})
      Me.LlistaPosicions.Add(New PosicioTactic() With {.IDTactic = Me.IDTactic, .Posicio = 6, .X = scale * -0.4, .Y = scale * 0})
      Me.LlistaPosicions.Add(New PosicioTactic() With {.IDTactic = Me.IDTactic, .Posicio = 7, .X = scale * -0.1, .Y = scale * 0})
      Me.LlistaPosicions.Add(New PosicioTactic() With {.IDTactic = Me.IDTactic, .Posicio = 8, .X = scale * +0.1, .Y = scale * 0})
      Me.LlistaPosicions.Add(New PosicioTactic() With {.IDTactic = Me.IDTactic, .Posicio = 9, .X = scale * +0.4, .Y = scale * 0})
      Me.LlistaPosicions.Add(New PosicioTactic() With {.IDTactic = Me.IDTactic, .Posicio = 10, .X = scale * -0.2, .Y = scale * 0.25})
      Me.LlistaPosicions.Add(New PosicioTactic() With {.IDTactic = Me.IDTactic, .Posicio = 11, .X = scale * +0.2, .Y = scale * 0.25})
    Catch ex As Exception

    End Try
  End Sub

  Public Function GetPosicioByID(ByVal niIDPosicio As Integer) As PosicioTactic
    Dim CPosicioTactic As PosicioTactic = Nothing
    Try
      For nIndex As Integer = 0 To Me.LlistaPosicions.Count - 1
        If Me.LlistaPosicions(nIndex).Posicio = niIDPosicio Then
          CPosicioTactic = Me.LlistaPosicions(nIndex)
        End If
      Next
    Catch ex As Exception

    End Try
    Return CPosicioTactic
  End Function

  Public Overrides Function ToString() As String
    Return Me.Descripcio
  End Function

End Class

<Serializable()> Public Class Tactiques
  Public IDEsport As Integer
  Public LlistaTactiques As New List(Of Tactic)

  Public Sub New()

  End Sub

End Class

