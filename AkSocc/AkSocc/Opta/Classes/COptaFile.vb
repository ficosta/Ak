Imports System.Xml
Imports System.IO
Imports System.Text

Public Class COptaFile
#Region "Properties"
  Private _path As String = ""
  Public Property Path() As String
    Get
      Return _path
    End Get
    Set(ByVal value As String)
      _path = value
    End Set
  End Property

  Private _lastUpdateTime As New Date
  Public Overridable Property LastUpdateTime() As Date
    Get
      Return _lastUpdateTime
    End Get
    Set(ByVal value As Date)
      _lastUpdateTime = value
    End Set
  End Property

  Private _timeStamp As String = ""
  Public Property TimeStamp() As String
    Get
      Return _timeStamp
    End Get
    Set(ByVal value As String)
      _timeStamp = value
    End Set
  End Property


  Friend _xmlDocument As XmlDocument = New XmlDocument()
  Public Property xmlDocument() As XmlDocument
    Get
      Return _xmlDocument
    End Get
    Set(ByVal value As XmlDocument)
      _xmlDocument = value
    End Set
  End Property

  Public Overridable ReadOnly Property IsUpdated() As Boolean
    Get
      Dim res As Boolean = True
      If System.IO.File.Exists(_path) Then
        If System.IO.File.GetLastWriteTime(_path) <> _lastUpdateTime Then
          '_lastUpdateTime = System.IO.File.GetLastWriteTime(_path)
          res = False
        End If
      End If
      Return res
    End Get
  End Property


  Private _llistaOptaLinks As New List(Of COptaLink)
  Public Property LlistaOptaLinks() As List(Of COptaLink)
    Get
      Return _llistaOptaLinks
    End Get
    Set(ByVal value As List(Of COptaLink))
      _llistaOptaLinks = value
    End Set
  End Property

  Public Sub AddOptaLink(ByVal optaLink As COptaLink)
    Try
      Dim found As Boolean = False
      For Each aux As COptaLink In _llistaOptaLinks
        If aux.optaID = optaLink.ID Then
          found = True
        End If
      Next
      If Not found Then
        _llistaOptaLinks.Add(optaLink)
      End If
    Catch ex As Exception
    End Try
  End Sub

  Public Function TimeStampToDate(ByVal timeStamp As String) As Date
    Try
      Dim year As String = timeStamp.Substring(0, 4)
      Dim month As String = timeStamp.Substring(4, 2)
      Dim day As String = timeStamp.Substring(6, 2)
      Dim hour As String = timeStamp.Substring(9, 2)
      Dim minute As String = timeStamp.Substring(11, 2)
      Dim dt As New Date(CInt(year), CInt(month), CInt(day), CInt(hour), CInt(minute), 0)
      Return dt
    Catch ex As Exception
      Return New Date()
    End Try
  End Function
#End Region

#Region "Constructors"
  Public Sub New()

  End Sub

  Public Sub New(ByVal path As String)
    _path = path
  End Sub
#End Region

#Region "Functions"
  Public Overridable Function InitializeData() As Boolean
  End Function

  Public Overridable Function Update() As Boolean
  End Function

  Public Overridable Sub FixOptaLinks(ByVal otpaF9Helper As COptaF9Helper)
    Try

    Catch ex As Exception

    End Try
  End Sub

  Public Function FixID(ByVal id As String) As String
    Dim res As String = id
    Try
      res = res.Replace("f", "")
      res = res.Replace("p", "")
      res = res.Replace("t", "")
      res = res.Replace("o", "")
      res = res.Replace("c", "")
      res = res.Replace("man", "")
    Catch ex As Exception

    End Try
    Return res
  End Function

#End Region


End Class
