
Imports System.Collections
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports System.IO
Imports System.Xml.Serialization


<Serializable>
Public Class Opta_Term_Stat
  Public OPTAName As String
  Public AppName As String
  Public ShowInFullFrames As Boolean
  Public ShowInLower As Boolean
End Class

Public Class Opta_Term_Stats
  Inherits CollectionBase
  Private filePath As String

  Public Sub New()
  End Sub

  Public Sub New(xmlSource As [String])
    Me.LoadFromFile(xmlSource)
  End Sub

  ''' <summary>
  ''' Save collection to default file
  ''' </summary>
  ''' <returns>Match class</returns>
  Public Function SaveToFile() As Boolean
    Return SaveToFile(Me.filePath)
  End Function

  ''' <summary>
  ''' Save collection to file
  ''' </summary>
  ''' <param name="xmlPath">Path to save items</param>
  ''' <returns>Match class</returns>
  Public Function SaveToFile(xmlPath As [String]) As Boolean
    Dim bRes As [Boolean] = False
    Try
      Dim sRes As [String]
      Dim sr As New StringWriter()
      Dim serializer As New XmlSerializer(Me.[GetType]())
      serializer.Serialize(sr, Me)
      sRes = sr.ToString()
      bRes = True

      Dim myFileStream As FileStream = File.Create(xmlPath)
      Dim bytes As Byte() = Nothing
      bytes = System.Text.Encoding.UTF8.GetBytes(sRes)
      myFileStream.Write(bytes, 0, bytes.Length)
      myFileStream.Flush()
      myFileStream.Close()
    Catch e As Exception
      Console.WriteLine("{0} Exception caught.", e)
    End Try
    Return bRes
  End Function

  ''' <summary>
  ''' Load collection from file
  ''' </summary>
  ''' <param name="xmlPath">Path to save items</param>
  ''' <returns>Match class</returns>
  Public Function LoadFromFile(xmlPath As [String]) As Boolean
    Dim bRes As [Boolean] = False
    Try
      filePath = xmlPath
      Dim myFileStream As FileStream = File.OpenRead(xmlPath)
      Dim bytes As Byte() = New Byte(myFileStream.Length - 1) {}
      myFileStream.Read(bytes, CInt(0), CInt(myFileStream.Length))
      Dim sRes As String = Nothing
      sRes = System.Text.Encoding.UTF8.GetString(bytes)
      myFileStream.Close()

      Dim sr As New StringReader(sRes)
      Dim deserializer As New XmlSerializer(Me.[GetType]())
      Dim aux As Opta_Term_Stats = DirectCast(deserializer.Deserialize(sr), Opta_Term_Stats)

      Me.Clear()
      For Each opta_term As Opta_Term_Stat In aux
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
  Default Public Property Item(Index As Integer) As Opta_Term_Stat
    Get
      Return DirectCast(List(Index), Opta_Term_Stat)
    End Get
    Set
      List(Index) = Value
    End Set
  End Property

  ''' <summary>
  ''' Add an item
  ''' </summary>
  ''' <param name="item">Opta_Term_Stat item</param>
  ''' <returns>Match class</returns>
  Public Sub Add(item As Opta_Term_Stat)
    Me.List.Add(item)
  End Sub

  ''' <summary>
  ''' Gets an item by its opta_name
  ''' </summary>
  ''' <param name="optaName">Name of the stat</param>
  ''' <returns>Match class</returns>
  Public Function GetStatByOptaName(optaName As String) As Opta_Term_Stat
    Dim output As Opta_Term_Stat = Nothing

    Try
      For Each Search As Opta_Term_Stat In List
        If Search.OPTAName = optaName Then
          output = Search
          Exit For
        End If
      Next
    Catch err As Exception
      Throw err
    End Try
    Return (output)
  End Function
End Class
