

Imports System.Data.OleDb

Public Class Referees
  Inherits CollectionBase

  Public Sub New()
  End Sub

  Public Function Add(Referee As Referee) As Integer
    Try
      If Not Referee Is Nothing Then
        Dim found As Boolean
        For index As Integer = 0 To Me.List.Count - 1
          If Me.List(index).RefereeID = Referee.RefereeID Then
            Me.List(index) = Referee
            found = True
            Exit For
          End If
        Next
        If Not found Then
          Me.List.Add(Referee)
        End If
      End If
    Catch ex As Exception
    End Try
    Return Me.List.Count
  End Function

  Default Public Property Item(Index As Integer) As Referee
    Get
      Return DirectCast(List(Index), Referee)
    End Get
    Set
      List(Index) = Value
    End Set
  End Property

  Public Function GetReferee(ID As Integer) As Referee
    Dim output As Referee = Nothing
    Try
      For Each SearchReferee As Referee In List
        If SearchReferee.RefereeID = ID Then
          output = SearchReferee
          Exit For
        End If
      Next
    Catch err As Exception
      Throw err
    End Try
    Return (output)
  End Function

  Public Function Contains(ID As Integer) As Boolean
    Dim output As Boolean = False
    Try
      For Each SearchReferee As Referee In List
        If SearchReferee.RefereeID = ID Then
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
