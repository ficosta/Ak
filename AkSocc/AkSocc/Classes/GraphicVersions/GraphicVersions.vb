<Serializable()> Public Class GraphicVersions
  Inherits CollectionBase

#Region "Singleton"
  Private Shared ReadOnly _instance As New Lazy(Of GraphicVersions)(Function() New GraphicVersions(), System.Threading.LazyThreadSafetyMode.ExecutionAndPublication)

  Private Sub New()
    Dim graphVersion As GraphicVersion
    '    graphVersion = New GraphicVersion("Saudi league", "BeInReal/MBC/Football/Scenes/", "CHANNELS/MBC_SPORTS/Badges/512/", "CHANNELS/MBC_SPORTS/CLUPS_LOGOS/Jerseys/Pics/", "CHANNELS/MBC_SPORTS/Badges/3D/", "CHANNELS/MBC_SPORTS/CLUPS_LOGOS/Colors/", "", "")
    'graphVersion = New GraphicVersion("Saudi league", "BeInReal/MBC/Football/Scenes/", "CHANNELS/MBC_SPORTS/Badges/512/", "CHANNELS/MBC_SPORTS/CLUPS_LOGOS/Jerseys/Pics/", "CHANNELS/MBC_SPORTS/Badges/3D/", "CHANNELS/MBC_SPORTS/CLUPS_LOGOS/Colors/", "", "")
    graphVersion = New GraphicVersion("Saudi league", "CHANNELS/MBC_SPORTS/2016/LEAGUE/Scenes/", "CHANNELS/MBC_SPORTS/Badges/512/", "CHANNELS/MBC_SPORTS/CLUPS_LOGOS/Jerseys/Pics/", "CHANNELS/MBC_SPORTS/Badges/3D/", "CHANNELS/MBC_SPORTS/CLUPS_LOGOS/Colors/", "", "")

    graphVersion.UseLongPreview = False
    Me.Add(graphVersion)

    graphVersion.UseLongPreview = True
    '    graphVersion = New GraphicVersion("Cup", "CHANNELS/MBC_SPORTS/2016/CPC_2016/Ingame_Alkamel/", "CHANNELS/MBC_SPORTS/Badges/512/", "CHANNELS/MBC_SPORTS/CLUPS_LOGOS/Jerseys/Pics/", "CHANNELS/MBC_SPORTS/Badges/3D/", "CHANNELS/MBC_SPORTS/CLUPS_LOGOS/Colors/", "", "")
    graphVersion = New GraphicVersion("Cup", "CHANNELS/MBC_SPORTS/2016/CPC_2016/Scenes/", "CHANNELS/MBC_SPORTS/Badges/512/", "CHANNELS/MBC_SPORTS/CLUPS_LOGOS/Jerseys/Pics/", "CHANNELS/MBC_SPORTS/Badges/3D/", "CHANNELS/MBC_SPORTS/CLUPS_LOGOS/Colors/", "", "")

    Me.Add(graphVersion)

  End Sub

  Public Shared ReadOnly Property Instance() As GraphicVersions
    Get

      Return _instance.Value
    End Get
  End Property
#End Region


  Private _selectedGraphicVersion As GraphicVersion = Nothing
  Public Property SelectedGraphicVersion As GraphicVersion
    Get
      If _selectedGraphicVersion Is Nothing And Me.List.Count > 0 Then
        _selectedGraphicVersion = Me.InnerList(0)
      End If
      Return _selectedGraphicVersion
    End Get
    Set(value As GraphicVersion)
      _selectedGraphicVersion = value
    End Set
  End Property


  Public Function Add(graphicVersion As GraphicVersion) As Integer
    Try
      If Not graphicVersion Is Nothing Then
        Dim found As Boolean
        For index As Integer = 0 To Me.List.Count - 1
          If Me.List(index).uid = graphicVersion.UID Then
            Me.List(index) = graphicVersion
            found = True
            Exit For
          End If
        Next
        If Not found Then
          Me.List.Add(graphicVersion)
        End If
      End If
    Catch ex As Exception
    End Try
    Return Me.List.Count
  End Function

  Default Public Property Item(Index As Integer) As GraphicVersion
    Get
      Return DirectCast(List(Index), GraphicVersion)
    End Get
    Set
      List(Index) = Value
    End Set
  End Property

  Public Function GetGraphicVersion(name As String) As GraphicVersion
    Dim output As GraphicVersion = Nothing
    Try
      For Each SearchGraphicVersion As GraphicVersion In List
        If SearchGraphicVersion.UID = name Or SearchGraphicVersion.Name = name Then
          output = SearchGraphicVersion
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
      For Each SearchGraphicVersion As GraphicVersion In List
        If SearchGraphicVersion.UID = ID Or SearchGraphicVersion.Name = ID Then
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