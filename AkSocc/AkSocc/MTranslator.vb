Module MTranslator
  Private _translator As MatchInfo.EnglishToArabicTranslation = Nothing

  Public Function Arabic(Term As String) As String
    Dim output As String = ""
    Try
      If _translator Is Nothing Then
        _translator = New MatchInfo.EnglishToArabicTranslation()
      End If

      output = _translator.ArabicWord(Term.ToUpper())
    Catch
    End Try
    If output = "" Then
      Dim sw As System.IO.StreamWriter = System.IO.File.AppendText("C:\NotInDictionary.txt")
      sw.WriteLine(Convert.ToString(DateTime.Now.ToString("HH:mm:ss") + " ") & Term)
      sw.Close()
    End If
    Return output

  End Function
End Module
