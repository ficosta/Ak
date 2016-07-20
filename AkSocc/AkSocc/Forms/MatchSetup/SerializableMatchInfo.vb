
Imports System.Collections
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports System.IO
Imports System.Xml.Serialization

Namespace SerializableMatchInfo
  <Serializable>
  Public Class MatchInfo
    Public MatchID As Integer
    Public HomeTeamInfo As TeamImageInfo
    Public AwayTeamInfo As TeamImageInfo
    Public referee1 As String
    Public referee2 As String
    Public referee3 As String
  End Class

  <Serializable>
  Public Class TeamImageInfo
    Public TeamID As Integer
    Public ColorImagePath As String
    Public JerseyImagePath As String
    Public JerseyGKImagePath As String

    Public Sub New()
    End Sub

    Public Sub New(id As Integer)
      Me.TeamID = id
    End Sub

  End Class

  Public Class TeamImageInfos
    Inherits CollectionBase
    Public Sub New()
    End Sub

    Public Sub New(source As [String])
      Me.DesserializeFromString(source)
    End Sub

    ''' <summary>
    ''' Serialize collection to string
    ''' </summary>
    ''' <returns>Match class</returns>
    Public Function SerializeToString() As String
      Dim sRes As String = ""
      Try
        Dim sr As New StringWriter()
        Dim serializer As New XmlSerializer(Me.[GetType]())
        serializer.Serialize(sr, Me)
        sRes = sr.ToString()
      Catch e As Exception
        Console.WriteLine("{0} Exception caught.", e)
      End Try
      Return sRes
    End Function

    ''' <summary>
    ''' Desserialize collection from string
    ''' </summary>
    ''' <param name="serialized">String containing the seriaized collection</param>
    ''' <returns>Match class</returns>
    Public Function DesserializeFromString(serialized As [String]) As Boolean
      Dim bRes As [Boolean] = False
      Try
        Dim sr As New StringReader(serialized)
        Dim deserializer As New XmlSerializer(Me.[GetType]())
        Dim aux As TeamImageInfos = DirectCast(deserializer.Deserialize(sr), TeamImageInfos)

        Me.Clear()
        For Each opta_term As TeamImageInfo In aux
          Me.Add(opta_term)
        Next
        bRes = True

      Catch
      End Try
      Return bRes
    End Function

    ''' <summary>
    ''' Access items
    ''' </summary>
    ''' <param name="Index">Numeric item</param>
    ''' <returns>Match class</returns>
    Default Public Property Item(Index As Integer) As TeamImageInfo
      Get
        Return DirectCast(List(Index), TeamImageInfo)
      End Get
      Set
        List(Index) = Value
      End Set
    End Property

    ''' <summary>
    ''' Add an item
    ''' </summary>
    ''' <param name="item">TeamImageInfo item</param>
    ''' <returns>Match class</returns>
    Public Sub Add(item As TeamImageInfo)
      Me.List.Add(item)
    End Sub

    ''' <summary>
    ''' Gets an item by its id
    ''' </summary>
    ''' <param name="id">Team ID</param>
    ''' <returns>Match class</returns>
    Public Function GetByID(id As Integer) As TeamImageInfo
      Dim output As TeamImageInfo = Nothing

      Try
        For Each Search As TeamImageInfo In List
          If Search.TeamID = id Then
            output = Search
            Exit For
          End If
        Next
        If output Is Nothing Then
          output = New TeamImageInfo(id)
          Me.Add(output)
        End If
      Catch err As Exception
        Throw err
      End Try
      Return (output)
    End Function


    ''' <summary>
    ''' Sets the main color for a team
    ''' </summary>
    ''' <param name="id">Team id</param>
    ''' <param name="color">Path of the color to apply</param>
    ''' <returns>Match class</returns>
    Public Function SetTeamColor(id As Integer, color As String) As TeamImageInfo
      Dim output As TeamImageInfo = Nothing

      Try
        output = Me.GetByID(id)
        If output IsNot Nothing Then
          output.ColorImagePath = color

          AppSettings.Instance.TeamImageInfoList = Me.SerializeToString()
          AppSettings.Instance.Save()
        End If
      Catch err As Exception
        Throw err
      End Try
      Return (output)
    End Function

    ''' <summary>
    ''' Gets the main color for a team
    ''' </summary>
    ''' <param name="id">Team id</param>
    ''' <returns>Match class</returns>
    Public Function GetTeamColor(id As Integer) As String
      Dim output As String = ""

      Try
        For Each Search As TeamImageInfo In List
          If Search.TeamID = id Then
            output = Search.ColorImagePath
            Exit For
          End If
        Next
      Catch err As Exception
        Throw err
      End Try
      Return (output)
    End Function

    Public Function SetTeamJersey(id As Integer, color As String) As TeamImageInfo
      Dim output As TeamImageInfo = Nothing

      Try
        output = Me.GetByID(id)
        If output IsNot Nothing Then
          output.JerseyImagePath = color
          AppSettings.Instance.TeamImageInfoList = Me.SerializeToString()
          AppSettings.Instance.Save()
        End If
      Catch err As Exception
        Throw err
      End Try
      Return (output)
    End Function

    Public Function GetTeamJersey(id As Integer) As String
      Dim output As String = ""

      Try
        For Each Search As TeamImageInfo In List
          If Search.TeamID = id Then
            output = Search.JerseyImagePath
            Exit For
          End If
        Next
      Catch err As Exception
        Throw err
      End Try
      Return (output)
    End Function

    Public Function SetTeamJerseyGK(id As Integer, color As String) As TeamImageInfo
      Dim output As TeamImageInfo = Nothing

      Try
        output = Me.GetByID(id)
        If output IsNot Nothing Then
          output.JerseyGKImagePath = color
          AppSettings.Instance.TeamImageInfoList = Me.SerializeToString()
          AppSettings.Instance.Save()
        End If
      Catch err As Exception
        Throw err
      End Try
      Return (output)
    End Function

    Public Function GetTeamJerseyGK(id As Integer) As String
      Dim output As String = ""

      Try
        For Each Search As TeamImageInfo In List
          If Search.TeamID = id Then
            output = Search.JerseyGKImagePath
            Exit For
          End If
        Next
      Catch err As Exception
        Throw err
      End Try
      Return (output)
    End Function
  End Class
End Namespace

