

Imports System.Data.OleDb

Public Class Substitutions
  Inherits CollectionBase

  Public Sub New()
  End Sub

  Public Function Add(subst As Substitution) As Integer
    Try
      If Not subst Is Nothing Then
        Me.List.Add(subst)
      End If
    Catch ex As Exception
    End Try
    Return Me.List.Count
  End Function

  Public Function Add(team As Team, playerIn As Player, playerOut As Player, Optional part As Integer = 1, Optional timeInSeconds As Integer = 0) As Integer
    Try
      Dim subst = New Substitution() With {.Team = team, .TeamID = team.ID, .PlayerIn = playerIn, .PlayerOut = playerOut, .part = part, .timeInSeconds = timeInSeconds}
      If Not subst Is Nothing Then
        Dim aux As String = subst.PlayerIn.PlayerPosition
        subst.PlayerIn.PlayerPosition = subst.PlayerOut.PlayerPosition
        subst.PlayerOut.PlayerPosition = aux
        Me.List.Add(subst)
      End If
    Catch ex As Exception
    End Try
    Return Me.List.Count
  End Function

  Default Public Property Item(Index As Integer) As Substitution
    Get
      Return DirectCast(List(Index), Substitution)
    End Get
    Set
      List(Index) = Value
    End Set
  End Property

  Public Function GetSubstitutionByPlayerIn(ID As Integer) As Substitution
    Dim output As Substitution = Nothing
    Try
      For Each SearchSubstitution As Substitution In List
        If SearchSubstitution.PlayerIn.PlayerID = ID Then
          output = SearchSubstitution
          Exit For
        End If
      Next

    Catch err As Exception
      Throw err
    End Try
    Return (output)
  End Function

  Public Function GetSubstitutionByPlayerIn(player As Player) As Substitution
    Dim output As Substitution = Nothing
    Try
      For Each SearchSubstitution As Substitution In List
        If SearchSubstitution.PlayerIn.PlayerID = player.ID Then
          output = SearchSubstitution
          Exit For
        End If
      Next
    Catch err As Exception
      Throw err
    End Try
    Return (output)
  End Function

  Public Function GetSubstitutionByPlayerOut(ID As Integer) As Substitution
    Dim output As Substitution = Nothing
    Try
      For Each SearchSubstitution As Substitution In List
        If SearchSubstitution.PlayerOut.PlayerID = ID Then
          output = SearchSubstitution
          Exit For
        End If
      Next
    Catch err As Exception
      Throw err
    End Try
    Return (output)
  End Function

  Public Function GetSubstitutionByPlayerOut(player As Player) As Substitution
    Dim output As Substitution = Nothing
    Try
      For Each SearchSubstitution As Substitution In List
        If SearchSubstitution.PlayerOut.PlayerID = player.ID Then
          output = SearchSubstitution
          Exit For
        End If
      Next
    Catch err As Exception
      Throw err
    End Try
    Return (output)
  End Function

  Public Sub Sort()
    Me.InnerList.Sort()
  End Sub
End Class
