

Imports System.Data.OleDb

<Serializable()> Public Class Players
  Inherits CollectionBase

  Public Sub New()
  End Sub

  Public Sub New(count As Integer)
    Me.Clear()

    For i As Integer = 1 To count
      Dim player As New Player(i)
      player.PlayerUniqueName = "Player " & i
      player.PlayerSurname = "Player " & i
      player.Formation_Pos = i
      Me.Add(player)
    Next
  End Sub

  Public Function Add(player As Player) As Integer
    Try
      If Not player Is Nothing Then
        Dim found As Boolean
        For index As Integer = 0 To Me.List.Count - 1
          If Me.List(index).PlayerID = player.PlayerID And Me.List(index).optaid = player.optaID Then
            Me.List(index) = player
            found = True
            Exit For
          End If
        Next
        If Not found Then
          Me.List.Add(player)
        End If
      End If
    Catch ex As Exception
    End Try
    Return Me.List.Count
  End Function

  Public Sub Sort()
    Me.InnerList.Sort()
  End Sub

  Default Public Property Item(Index As Integer) As Player
    Get
      Return DirectCast(List(Index), Player)
    End Get
    Set

      List(Index) = Value
    End Set
  End Property

  Public Function GetPlayer(ID As Integer) As Player
    Dim output As Player = Nothing
    Try
      For Each SearchPlayer As Player In List
        If SearchPlayer.PlayerID = ID Then
          output = SearchPlayer
          Exit For
        End If
      Next
    Catch err As Exception
      Throw err
    End Try
    Return (output)
  End Function

  Public Function GetPlayerByDorsal(ID As Integer) As Player
    Dim output As Player = Nothing
    Try
      For Each SearchPlayer As Player In List
        If SearchPlayer.SquadNo = ID Then
          output = SearchPlayer
          Exit For
        End If
      Next
    Catch err As Exception
      Throw err
    End Try
    Return (output)
  End Function

  Public Function GetPlayerByPosition(position As Integer) As Player
    Dim output As Player = Nothing
    Try
      For Each SearchPlayer As Player In List
        If SearchPlayer.Formation_Pos = position Then
          output = SearchPlayer
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
      For Each SearchPlayer As Player In List
        If SearchPlayer.PlayerID = ID Then
          output = True
          Exit For
        End If
      Next
    Catch err As Exception
      Throw err
    End Try
    Return (output)
  End Function

  Public Function ContainsByOptaID(ID As Integer) As Boolean
    Dim output As Boolean = False
    Try
      For Each SearchPlayer As Player In List
        If SearchPlayer.optaID = ID Then
          output = True
          Exit For
        End If
      Next
    Catch err As Exception
      Throw err
    End Try
    Return (output)
  End Function

  Public Function Contains(player As Player) As Boolean
    Dim output As Boolean = False
    Try
      output = Me.Contains(player.ID)
    Catch err As Exception
      Throw err
    End Try
    Return (output)
  End Function

  Public Function Remove(ID As Integer) As Boolean
    Dim output As Boolean = False
    Try
      For i As Integer = List.Count - 1 To 0 Step -1
        If List(i).PlayerID = ID Then
          List.RemoveAt(i)
          output = True
        End If
      Next
    Catch err As Exception
      Throw err
    End Try
    Return (output)
  End Function

  Public Function Remove(player As Player) As Boolean
    Dim output As Boolean = False
    Try
      output = Me.Remove(player.ID)
    Catch err As Exception
      Throw err
    End Try
    Return (output)
  End Function
End Class
