<Serializable()> Public Class MatchDay
  Inherits CollectionBase
  Implements IComparable

  Public Property MatchDayID As String = Guid.NewGuid().ToString
  Public Property MatchDay As String

  Public Sub New()
  End Sub

  Public Sub New(matchDay As String)
    Me.MatchDay = matchDay
  End Sub

  Public Function Add(OtherMatch As OtherMatch) As Integer
    Try
      If Not OtherMatch Is Nothing Then
        Dim found As Boolean
        For index As Integer = 0 To Me.List.Count - 1
          If Me.List(index).OtherMatchID = OtherMatch.OtherMatchID Then
            Me.List(index) = OtherMatch
            found = True
            Exit For
          End If
        Next
        If Not found Then
          Me.List.Add(OtherMatch)
        End If
      End If
      UpdateIndexes()
    Catch ex As Exception
    End Try
    Return Me.List.Count
  End Function



  Public Sub Remove(OtherMatch As OtherMatch)
    Try
      If Not OtherMatch Is Nothing Then
        For index As Integer = Me.List.Count - 1 To 0 Step -1
          If Me.List(index).OtherMatchID = OtherMatch.OtherMatchID Then
            Me.List.RemoveAt(index)
          End If
        Next
      End If
      UpdateIndexes()
    Catch ex As Exception
    End Try
  End Sub


  Default Public Property Item(Index As Integer) As OtherMatch
    Get
      Return DirectCast(List(Index), OtherMatch)
    End Get
    Set
      List(Index) = Value
    End Set
  End Property


  Public Sub Sort()
    Me.InnerList.Sort()
  End Sub

  Public Function GetMatchesByMatchDay(matchDay As String) As MatchDay
    Dim res As MatchDay = Nothing
    Try
      For Each matches As MatchDay In Me.InnerList
        If matches.MatchDay = matchDay Then
          res = matches
        End If
      Next
      res.Sort()
    Catch ex As Exception

    End Try
    Return res
  End Function

  Public Function GetMatchDays() As List(Of MatchDay)
    Dim res As New List(Of MatchDay)
    Try
      For Each match As OtherMatch In Me.InnerList
        For Each matchDay As MatchDay In res

        Next
      Next
    Catch ex As Exception

    End Try
    Return res
  End Function

  Public Function CompareTo(obj As Object) As Integer Implements IComparable.CompareTo
    Dim aux As MatchDay = CType(obj, MatchDay)
    If aux.MatchDay > Me.MatchDay Then
      Return 1
    ElseIf aux.MatchDay < Me.MatchDay Then
      Return -1
    Else
      Return 0
    End If
  End Function

  Public Sub UpdateIndexes()
    Dim orderChanged As Boolean = False
    Try
      '_pagines.Sort()
      For nIndex As Integer = 0 To Me.Count - 1
        orderChanged = orderChanged Or (Me.Item(nIndex).MatchIndex <> nIndex)
        Me.Item(nIndex).MatchIndex = nIndex
        '_pagines(nIndex).ID = nIndex
      Next
    Catch ex As Exception
    End Try
  End Sub

End Class
