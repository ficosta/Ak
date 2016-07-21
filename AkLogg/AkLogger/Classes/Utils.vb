
Imports System.Text

Public Enum Cards
    None
    Yellow
    DoubleY
    Red
  End Enum

  Public Class Utils
    ''' <summary>
    ''' Convert a String number to int
    ''' </summary>
    ''' <param name="Number">String number</param>
    ''' <returns>int Number. -1 if the number cannot be converted</returns>
    Public Shared Function Val(Number As String) As Integer
      Dim myNumber As Integer
      Try
        myNumber = Integer.Parse(Number)
      Catch
        myNumber = -1
      End Try

      Return myNumber
    End Function



    ''' <summary>
    ''' Get the attribute from the Son's node
    ''' </summary>
    ''' <param name="Node">Full node</param>
    ''' <param name="Son">Name of the Son Node</param>
    ''' <param name="Attribute">Attribute to get its value</param>
    ''' <returns></returns>
    Public Shared Function ReadAttribute(Node As System.Xml.XmlNode, Son As String, Attribute As String) As String
      Dim strReturn As String
      Try
        strReturn = Node.SelectSingleNode(Son).Attributes(Attribute).InnerText
      Catch
        strReturn = ""
      End Try
      Return strReturn
    End Function

    Public Shared Function ReadAttribute(Node As System.Xml.XmlNode, Son As String, GrandSon As String, Attribute As String) As String
      Dim strReturn As String
      Try
        strReturn = Node.SelectSingleNode(Son).SelectSingleNode(GrandSon).Attributes(Attribute).InnerText
      Catch
        strReturn = ""
      End Try
      Return strReturn
    End Function

    Public Shared Function ReadSon(Node As System.Xml.XmlNode, Son As String) As String
      Dim strReturn As String
      Try
        strReturn = Node.SelectSingleNode(Son).InnerText
      Catch
        strReturn = ""
      End Try
      Return strReturn
    End Function

    Public Shared Function ReadSon(Node As System.Xml.XmlNode, Son As String, GrandSon As String) As String
      Dim strReturn As String
      Try
        strReturn = Node.SelectSingleNode(Son).SelectSingleNode(GrandSon).InnerText
      Catch
        strReturn = ""
      End Try
      Return strReturn
    End Function

    Public Shared Function ReadAttribute(Node As System.Xml.XmlNode, Attribute As String) As String
      Dim strReturn As String
      Try
        strReturn = Node.Attributes(Attribute).InnerText
      Catch
        strReturn = ""
      End Try
      Return strReturn
    End Function
    ''' <summary>
    ''' Convert String Datetime toa Datetime variable
    ''' </summary>
    ''' <param name="DateString">Date form the xml with the format YYYY-MM-DD, YYYYMMDDTHHMMSS or YYYY-MM-DD HH:MM:SS</param>
    ''' <returns>Datetime variable of the value</returns>
    Public Shared Function String2Date(DateString As String) As DateTime
      Try
        Dim Year As Integer, Month As Integer, Day As Integer, Hour As Integer, Minute As Integer, Second As Integer
        Year = 1900
        Month = 1
        Day = 1
        Hour = 0
        Minute = 0
        Second = 0
        If DateString.Length = 10 OrElse DateString.Length = 19 Then
          Year = Val(DateString.Substring(0, 4))
          Month = Val(DateString.Substring(5, 2))
          Day = Val(DateString.Substring(8, 2))
          If DateString.Length = 19 Then
            Hour = Val(DateString.Substring(11, 2))
            Minute = Val(DateString.Substring(14, 2))
            Second = Val(DateString.Substring(17, 2))
          End If
        ElseIf DateString.Length = 15 OrElse DateString.Length = 20 Then
          'ISO format 20140908T184412
          Year = Val(DateString.Substring(0, 4))
          Month = Val(DateString.Substring(4, 2))
          Day = Val(DateString.Substring(6, 2))
          Hour = Val(DateString.Substring(9, 2))
          Minute = Val(DateString.Substring(11, 2))
          Second = Val(DateString.Substring(13, 2))
          If DateString.Length = 20 Then
            Hour += Val(DateString.Substring(16, 2))
            Minute += Val(DateString.Substring(18, 2))
          End If
        End If
        If Year > 1900 Then
          Return New DateTime(Year, Month, Day, Hour, Minute, Second)
        Else
          Return New DateTime(1900, 1, 1, 0, 0, 0)
        End If
      Catch err As Exception
        Throw err
      End Try
    End Function

    Public Shared Function StartDateTime() As DateTime
      Return New DateTime(1900, 1, 1)
    End Function

    Public Shared Function ShowDateTime(ToShow As DateTime) As String
      Return ToShow.ToString("dd/MM/yyyy hh:mm:ss")
    End Function

    Public Shared Function TwoChars(Valor As Integer) As String
      Dim output As String
      If Valor < 10 Then
        output = "0" + Valor.ToString()
      Else
        output = Valor.ToString()
      End If
      Return output
    End Function

    Public Shared Function Secs2MMSS(Secs As Integer) As String
      Dim Mins As Integer = Secs / 60
      Secs = Secs - (Mins * 60)
      Return Convert.ToString(TwoChars(Mins) & Convert.ToString(":")) & TwoChars(Secs)
    End Function

    Public Shared Function MMSS2Secs(TC As String) As Integer
      Dim Secs As Integer = 0
      If TC.Length = 5 Then
        Dim Mins As Integer = Val(TC.Substring(0, 2))
        Secs = Val(TC.Substring(3, 2)) + (Mins * 60)


      ElseIf TC.Length = 6 Then
        Dim Mins As Integer = Val(TC.Substring(0, 3))
        Secs = Val(TC.Substring(4, 2)) + (Mins * 60)


      End If
      Return Secs
    End Function
  End Class