Public Class COptaLink
  Public Enum eTipusLink
    Team
    Player
    Referee
  End Enum

  Public Tipus As eTipusLink = eTipusLink.Player
  Public optaID As String = ""
  Public optaNom As String = ""
  Public optaExtra As String = ""
  Public ID As Integer = 0
  Public Nom As String = ""

  Private _linked As Boolean = False
  Public ReadOnly Property Linked()
    Get
      Return _linked
    End Get
  End Property



  Public Sub New(ByVal optaID As String, ByVal optaNom As String, ByVal optaExtra As String, ByVal tipus As eTipusLink)
    Try
      Me.optaID = optaID
      Me.optaNom = optaNom
      Me.optaExtra = optaExtra
      Me.Tipus = tipus
    Catch ex As Exception

    End Try
  End Sub

  Public ReadOnly Property TableName() As String
    Get
      Select Case Tipus
        Case eTipusLink.Referee
          Return "Arbitres"
        Case eTipusLink.Team
          Return "Equips"
        Case eTipusLink.Player
          Return "Jugadors"
        Case Else
          Return ""
      End Select
    End Get
  End Property

  Public ReadOnly Property IDFieldName() As String
    Get
      Select Case Tipus
        Case eTipusLink.Referee
          Return "IDArbitre"
        Case eTipusLink.Team
          Return "IDEquip"
        Case eTipusLink.Player
          Return "IDJugador"
        Case Else
          Return ""
      End Select
    End Get
  End Property
End Class
