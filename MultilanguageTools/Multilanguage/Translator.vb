
<Serializable()> Public Class TranslateManager
  Private _name As String = ""
  Public Property Name As String
    Get
      Return _name
    End Get
    Set(value As String)
      _name = value
      SetLanguageProperties()
    End Set
  End Property

  Private _categoory As String = ""
  Public Property Category As String
    Get
      Return _categoory
    End Get
    Set(value As String)
      _categoory = value
      SetLanguageProperties()
    End Set
  End Property
  Public Property Enabled As Boolean = True

  Public Property Languages As New Dictionary(Of String, Language)

  Private Sub SetLanguageProperties()
    Try
      For Each pair As KeyValuePair(Of String, Language) In Me.Languages
        pair.Value.Name = _name
        pair.Value.Category = _categoory
      Next
    Catch ex As Exception

    End Try
  End Sub

  Public Function GetLanguage(languageID As String) As Language
    Dim language As Language = Nothing
    Try
      If Not Me.Languages.ContainsKey(languageID) Then
        language = New Language(languageID)
        Me.Languages.Add(languageID, language)
      Else
        language = Me.Languages(languageID)
      End If
    Catch ex As Exception

    End Try
    Return language
  End Function

  Public Function GetTerm(termString As String, languageID As String) As Term
    Dim res As Term = Nothing
    Try
      Dim language As Language = Me.GetLanguage(languageID)

      res = language.GetTerm(termString)

      If res Is Nothing Then
        'does it exist in any other language?
        Dim termID As Integer = -1
        For Each langPair As KeyValuePair(Of String, Language) In Me.Languages
          If langPair.Value.ContainsTerm(termString) Then
            termID = langPair.Value.GetTerm(termString).ID
            Exit For
          End If
        Next
        'get first available ID for al languages
        If termID = -1 Then
          termID = 1
          For Each langPair As KeyValuePair(Of String, Language) In Me.Languages
            termID = Math.Max(termID, langPair.Value.GetFirstAvailableID)
          Next
        End If
        'create the term in all languages if it didn't exist
        For Each langPair As KeyValuePair(Of String, Language) In Me.Languages
          If Not langPair.Value.ContainsTerm(termID) Then
            Dim aux As New Term(termID, termString)
            langPair.Value.Terms.Add(aux.ID, aux)
          End If
        Next
        res = language.GetTerm(termString)
      End If
    Catch ex As Exception
    End Try
    Return res
  End Function

#Region "Encoder / decoder"
  Public Function EncodeText(text As String, languageID As Integer) As String
    If Me.Enabled = False Then Return text
    Dim sRes As String = text
    Try
      Dim language As Language
      If Me.Languages.ContainsKey(languageID) Then
        language = Me.Languages(languageID)
        sRes = language.EncodeText(text)
      End If
    Catch ex As Exception

    End Try
    Return sRes
  End Function

  Public Function DecodeText(text As String, languageID As Integer) As String
    If Me.Enabled = False Then Return text
    Dim sRes As String = text
    Try
      Dim language As Language
      If Me.Languages.ContainsKey(languageID) Then
        language = Me.Languages(languageID)
        sRes = language.DecodeText(text)
      End If
    Catch ex As Exception

    End Try
    Return sRes
  End Function
#End Region

#Region "Save / load"
  Public Shared Function Save(file As String, translator As TranslateManager) As Boolean
    Dim res As Boolean = False
    Try
      Dim sFile As String = IIf(System.IO.Path.GetExtension(file).ToUpper = "TRANS", file, file & ".trans")
      Dim sFolder As String = System.IO.Path.Combine(System.IO.Path.GetDirectoryName(file), System.IO.Path.GetFileNameWithoutExtension(file))

      Dim data As String = Newtonsoft.Json.JsonConvert.SerializeObject(translator)
      data = Newtonsoft.Json.Linq.JValue.Parse(data).ToString(Newtonsoft.Json.Formatting.Indented)
      SaveStringToFile(sFile, data)

      System.IO.Directory.CreateDirectory(sFolder)

      For Each pair As KeyValuePair(Of String, Language) In translator.Languages
        data = Newtonsoft.Json.JsonConvert.SerializeObject(pair.Value)
        data = Newtonsoft.Json.Linq.JValue.Parse(data).ToString(Newtonsoft.Json.Formatting.Indented)
        sFile = System.IO.Path.Combine(sFolder, pair.Key & ".lang")
        SaveStringToFile(sFile, data)
      Next
    Catch ex As Exception

    End Try
    Return res
  End Function

  Public Shared Function Load(file As String) As TranslateManager
    Dim res As TranslateManager
    Try
      Dim sData As String = LoadStringFromFile(file)
      If sData <> "" Then
        res = Newtonsoft.Json.JsonConvert.DeserializeObject(Of TranslateManager)(sData)
        If res Is Nothing Then
          'single language?
          Dim lang As Language = Newtonsoft.Json.JsonConvert.DeserializeObject(Of Language)(sData)
          If Not lang Is Nothing Then
            res = New TranslateManager
            res.Name = lang.Name
            res.Category = lang.Category
            res.Languages.Add(lang.ID, lang)
          End If

        End If
      End If
    Catch ex As Exception

    End Try
    Return res
  End Function
#End Region
End Class