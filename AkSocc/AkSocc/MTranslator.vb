Imports System.Text

Module MTranslator
  Public Function Arabic(Term As String) As String
    Dim output As String = ""
    Try
      Dim trans As New MatchInfo.EnglishToArabicTranslation(Term.ToUpper())
      If Not trans Is Nothing Then
        If My.Settings.UseArabicNames Then
          output = trans.ArabicWord
        Else
          output = Term
        End If
        trans = Nothing
        End If
    Catch
    End Try
    If output = "" Then
      Dim sw As System.IO.StreamWriter = System.IO.File.AppendText("C:\NotInDictionary.txt")
      sw.WriteLine(Convert.ToString(DateTime.Now.ToString("HH:mm:ss") + " ") & Term)
      sw.Close()
    End If
    Return output

  End Function

  Public Function VizEncoding(ArabicText As String) As String
    Dim myString As String = ArabicText
    Dim bytes As Byte() = Encoding.Unicode.GetBytes(myString)
    myString = Encoding.Unicode.GetString(bytes)
    Return (myString)
  End Function
End Module
