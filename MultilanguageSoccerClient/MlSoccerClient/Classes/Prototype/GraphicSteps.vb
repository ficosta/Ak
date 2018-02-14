

Imports System.Data.OleDb

Public Class GraphicSteps
  Inherits CollectionBase

  Public Sub New()
  End Sub

  Public Function Add(graphicStep As GraphicStep) As Integer
    Try
      If Not graphicStep Is Nothing Then
        Dim found As Boolean
        For index As Integer = 0 To Me.List.Count - 1
          If Me.List(index).uid = graphicStep.UID Then
            Me.List(index) = graphicStep
            found = True
            Exit For
          End If
        Next
        If Not found Then
          Me.List.Add(graphicStep)
        End If
      End If
    Catch ex As Exception
    End Try
    Return Me.List.Count
  End Function

  Default Public Property Item(Index As Integer) As GraphicStep
    Get
      Return DirectCast(List(Index), GraphicStep)
    End Get
    Set
      List(Index) = Value
    End Set
  End Property

  Public Function GetGraphicStep(name As String) As GraphicStep
    Dim output As GraphicStep = Nothing
    Try
      For Each SearchGraphicStep As GraphicStep In List
        If SearchGraphicStep.UID = name Or SearchGraphicStep.Name = name Then
          output = SearchGraphicStep
          Exit For
        End If
      Next
    Catch err As Exception
      Throw err
    End Try
    Return (output)
  End Function

  Public Function Contains(ID As String) As Boolean
    Dim output As Boolean = False
    Try
      For Each SearchGraphicStep As GraphicStep In List
        If SearchGraphicStep.UID = ID Or SearchGraphicStep.Name = ID Then
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
