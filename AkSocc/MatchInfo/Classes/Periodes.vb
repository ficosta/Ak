

Imports System.Data.OleDb

Public Class Periodes
  Inherits CollectionBase

  Public Sub New()
  End Sub

  Public Function Add(period As Period) As Integer
    Try
      If Not period Is Nothing Then
        Dim found As Boolean
        For index As Integer = 0 To Me.List.Count - 1
          If Me.List(index).PeriodID = period.periodID Then
            Me.List(index) = period
            found = True
            Exit For
          End If
        Next
        If Not found Then
          Me.List.Add(period)
        End If
      End If
    Catch ex As Exception
    End Try
    Return Me.List.Count
  End Function

  Public Property CPiPeriodeActiu As Period


  Default Public Property Item(Index As Integer) As Period
    Get
      Return DirectCast(List(Index), Period)
    End Get
    Set
      List(Index) = Value
    End Set
  End Property

  Public Function GetPeriod(ID As Integer) As Period
    Dim output As Period = Nothing
    Try
      For Each SearchPeriod As Period In List
        If SearchPeriod.PeriodID = ID Then
          output = SearchPeriod
          Exit For
        End If
      Next
    Catch err As Exception
      Throw err
    End Try
    Return (output)
  End Function

  Public Function GetPeriodByDorsal(ID As Integer) As Period
    Dim output As Period = Nothing
    Try
      For Each SearchPeriod As Period In List
        If SearchPeriod.SquadNo = ID Then
          output = SearchPeriod
          Exit For
        End If
      Next
    Catch err As Exception
      Throw err
    End Try
    Return (output)
  End Function

  Public Function GetPeriodByPosition(position As Integer) As Period
    Dim output As Period = Nothing
    Try
      For Each SearchPeriod As Period In List
        If SearchPeriod.PeriodPosition = CStr(position) Then
          output = SearchPeriod
          Exit For
        End If
      Next
      If output Is Nothing Then
        output = Me.List(position)
      End If
    Catch err As Exception
      Throw err
    End Try
    Return (output)
  End Function

  Public Function Contains(ID As Integer) As Boolean
    Dim output As Boolean = False
    Try
      For Each SearchPeriod As Period In List
        If SearchPeriod.PeriodID = ID Then
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
