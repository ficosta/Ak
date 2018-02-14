Imports System.Text
Imports MultilanguageTools

Module MTranslator
  Public TranslatorFilePath As String = "C:\Tuboc\Translations.trans"
  Public translator As TranslateManager

  Public Function Translate(Term As String) As String
    Dim output As String = ""
    Try
      If AppSettings.Instance.UseMultiLanguageOutput = True Then
        If translator Is Nothing Then
          Dim aux As Object = New TranslateManager
          translator = TranslateManager.Load(TranslatorFilePath)
          If translator Is Nothing Then
            translator = New TranslateManager()
          End If
        End If
        Dim myTerm As Term = translator.GetTerm(Term, "EN")
        output = "<%" & myTerm.ID & "%>"
      Else
        Dim trans As New MatchInfo.EnglishToArabicTranslation(Term.ToUpper())
        If Not trans Is Nothing Then
          If AppSettings.Instance.UseArabicNames Then
            output = trans.ArabicWord
          Else
            output = Term
          End If
          trans = Nothing
        End If
      End If
    Catch ex As Exception

    End Try
    If output = "" Then
      Dim sw As System.IO.StreamWriter = System.IO.File.AppendText("C:\Tuboc\NotInDictionary.txt")
      sw.WriteLine(Convert.ToString(DateTime.Now.ToString("HH:mm:ss") & " ") & Term)
      sw.Close()
    End If

    TranslateManager.Save(TranslatorFilePath, translator)

    'SerializeObjectToFile(TranslatorFilePath, Translator, eSerializationType.json)
    Return output
  End Function

  Public Function NumberToWord(myNumber As Integer) As String
    Dim words As String = ""
    If myNumber > 0 Then
      Dim unitsMap() As String = {"ZERO", "ONE", "TWO", "THREE", "FOUR", "FIVE",
      "SIX", "SEVEN", "EIGHT", "NINE", "TEN", "ELEVEN",
      "TWELVE", "THIRTEEN", "FOURTEEN", "FIFTEEN", "SIXTEEN", "SEVENTEEN",
      "EIGHTEEN", "NINETEEN"}
      Dim tensMap() As String = {"ZERO", "TEN", "TWENTY", "THIRTY", "FORTY", "FIFTY",
      "SIXTY", "SEVENTY", "EIGHTY", "NINETY"}

      If myNumber < 20 Then
        words &= unitsMap(myNumber)
      Else
        words &= tensMap(myNumber / 10)
        If (myNumber Mod 10) > 0 Then
          words &= " " & unitsMap(myNumber Mod 10)
        End If
      End If
    End If

    Return words
  End Function

  Public Function VizEncoding(ArabicText As String) As String
    Dim myString As String = ArabicText
    Dim bytes As Byte() = Encoding.Unicode.GetBytes(myString)
    myString = Encoding.Unicode.GetString(bytes)
    Return (myString)
  End Function
End Module
