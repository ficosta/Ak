
Public NotInheritable Class AppSettings
#Region "Singleton"
  Private Shared ReadOnly _instance As New Lazy(Of AppSettings)(Function() New AppSettings(), System.Threading.LazyThreadSafetyMode.ExecutionAndPublication)

  Private Sub New()

  End Sub

  Public Shared ReadOnly Property Instance() As AppSettings
    Get
      Return _instance.Value
    End Get
  End Property
#End Region

#Region "Properties"
  Public Property DataBasePath As String = ""
  Public Property GraphicVersion As String = ""
  Public Property LastCompetitionId As Integer = 0
  Public Property LastMatchId As Integer = 0
  Public Property LoggerIP As String = ""
  Public Property LoggerPort As Integer = 6405
  Public Property OtherMatchesPath As String = ""
  Public Property PreviewLocalPath As String = ""
  Public Property PreviewRemotePath As String = ""
  Public Property ScenePath As String = ""
  Public Property ShowSettingsOnStartup As Boolean = True
  Public Property UseArabicNames As Boolean = True
  Public Property UseMultiLanguageOutput As Boolean = True
  Public Property VizrtHost As String = ""
  Public Property VizrtPort As Integer = 6100
  Public Property VizrtPreviewPort As Integer = 0
  Public Property TeamImageInfoList As String = ""
  Public Property ColorsDefaultPath As String = "C:\Alamiya\Colors"
  Public Property KitsDefaultPath As String = "C:\Alamiya\kits"

  Public Property ClockPosition_X As Double = 0
  Public Property ClockPosition_Y As Double = 0

  Public Property UseLogger As Boolean = False

  Public Property UseOptaData As Boolean = False

  Public Property OptaStatsTeamsDefinitionPath As String = "C:\teamOptaStats.xml"
  Public Property OptaStatsPlayersDefinitionPath As String = "C:\playerOptaStats.xml"

  Public Property OptaDefaultFolder As String = "C:\Alamiya\OPTA"
  Public Property OptaDefaultHistoryFolder As String = "C:\Alamiya\OPTA\History"

  Public Property OptaFTPServer As String = "ftp.alkamelsystems.com"
  Public Property OptaFTPPath As String = ""
  Public Property OptaFTPPort As Integer = 21
  Public Property OptaFTPUser As String = "see4836"
  Public Property OptaFTPPassword As String = "kG4MUqLhEDVh"

  Public Property OptaCompetitionID As Integer = 202
  Public Property OptaSeasonID As Integer = 2016
  Public Property OptaUpdateScores As Boolean = True

  Public Property OptaStatsTeam As New Opta_Term_Stats(OptaStatsTeamsDefinitionPath)
  Public Property OptaStatsPlayer As New Opta_Term_Stats(OptaStatsPlayersDefinitionPath)

  'Behavious
  Public Property Behaviour_OpenPlayerDescriptionOnSelection As Boolean = True



#End Region

  Public Function LlegirConfiguracio(ByVal niNumConfig As Integer) As AppSettings
    Dim sTemp As String = ""
    Dim CMyRegConfig As New RegistryHelper(My.Application.Info.Title, "Config", niNumConfig)
    
    AppSettings.Instance.DataBasePath = CStr(CMyRegConfig.ReadValue("DataBasePath", AppSettings.Instance.DataBasePath, RegistryHelper.eBrancaReg.brBrancaUsuari, False))
    AppSettings.Instance.GraphicVersion = CStr(CMyRegConfig.ReadValue("GraphicVersion", AppSettings.Instance.GraphicVersion, RegistryHelper.eBrancaReg.brBrancaUsuari, False))
    AppSettings.Instance.LastCompetitionId = CInt(CMyRegConfig.ReadValue("LastCompetitionId", AppSettings.Instance.LastCompetitionId, RegistryHelper.eBrancaReg.brBrancaUsuari, False))
    AppSettings.Instance.LastMatchId = CInt(CMyRegConfig.ReadValue("LastMatchId", AppSettings.Instance.LastMatchId, RegistryHelper.eBrancaReg.brBrancaUsuari, False))
    AppSettings.Instance.LoggerIP = CStr(CMyRegConfig.ReadValue("LoggerHost", AppSettings.Instance.LoggerIP, RegistryHelper.eBrancaReg.brBrancaUsuari, False))
    AppSettings.Instance.LoggerPort = CInt(CMyRegConfig.ReadValue("LoggerPort", AppSettings.Instance.LoggerPort, RegistryHelper.eBrancaReg.brBrancaUsuari, False))
    AppSettings.Instance.OtherMatchesPath = CStr(CMyRegConfig.ReadValue("OtherMatchesPath", AppSettings.Instance.OtherMatchesPath, RegistryHelper.eBrancaReg.brBrancaUsuari, False))
    AppSettings.Instance.PreviewLocalPath = CStr(CMyRegConfig.ReadValue("PreviewLocalPath", AppSettings.Instance.PreviewLocalPath, RegistryHelper.eBrancaReg.brBrancaUsuari, False))
    AppSettings.Instance.PreviewRemotePath = CStr(CMyRegConfig.ReadValue("PreviewRemotePath", AppSettings.Instance.PreviewRemotePath, RegistryHelper.eBrancaReg.brBrancaUsuari, False))
    AppSettings.Instance.ScenePath = CStr(CMyRegConfig.ReadValue("ScenePath", AppSettings.Instance.ScenePath, RegistryHelper.eBrancaReg.brBrancaUsuari, False))
    AppSettings.Instance.ShowSettingsOnStartup = CStr(CMyRegConfig.ReadValue("ShowSettingsOnStartup", AppSettings.Instance.ShowSettingsOnStartup, RegistryHelper.eBrancaReg.brBrancaUsuari, False))
    AppSettings.Instance.UseArabicNames = CBool(CMyRegConfig.ReadValue("UseArabicNames", AppSettings.Instance.UseArabicNames, RegistryHelper.eBrancaReg.brBrancaUsuari, False))
    AppSettings.Instance.UseMultiLanguageOutput = CBool(CMyRegConfig.ReadValue("UseMultiLanguageOutput", AppSettings.Instance.UseMultiLanguageOutput, RegistryHelper.eBrancaReg.brBrancaUsuari, False))
    AppSettings.Instance.VizrtHost = CStr(CMyRegConfig.ReadValue("VizrtHost", AppSettings.Instance.VizrtHost, RegistryHelper.eBrancaReg.brBrancaUsuari, False))
    AppSettings.Instance.VizrtPort = CInt(CMyRegConfig.ReadValue("VizrtPort", AppSettings.Instance.VizrtPort, RegistryHelper.eBrancaReg.brBrancaUsuari, False))
    AppSettings.Instance.VizrtPreviewPort = CInt(CMyRegConfig.ReadValue("VizrtPreviewPort", AppSettings.Instance.VizrtPreviewPort, RegistryHelper.eBrancaReg.brBrancaUsuari, False))
    AppSettings.Instance.TeamImageInfoList = CStr(CMyRegConfig.ReadValue("TeamImageInfoList", AppSettings.Instance.TeamImageInfoList, RegistryHelper.eBrancaReg.brBrancaUsuari, False))
    AppSettings.Instance.ColorsDefaultPath = CStr(CMyRegConfig.ReadValue("ColorsDefaultPath", AppSettings.Instance.ColorsDefaultPath, RegistryHelper.eBrancaReg.brBrancaUsuari, False))
    AppSettings.Instance.KitsDefaultPath = CStr(CMyRegConfig.ReadValue("KitsDefaultPath", AppSettings.Instance.KitsDefaultPath, RegistryHelper.eBrancaReg.brBrancaUsuari, False))

    AppSettings.Instance.ClockPosition_X = CDbl(CMyRegConfig.ReadValue("ClockPosition_X", AppSettings.Instance.ClockPosition_X, RegistryHelper.eBrancaReg.brBrancaUsuari, False))
    AppSettings.Instance.ClockPosition_Y = CDbl(CMyRegConfig.ReadValue("ClockPosition_y", AppSettings.Instance.ClockPosition_Y, RegistryHelper.eBrancaReg.brBrancaUsuari, False))


    AppSettings.Instance.OptaStatsPlayersDefinitionPath = CStr(CMyRegConfig.ReadValue("OptaStatsPlayersDefinitionPath", AppSettings.Instance.OptaStatsPlayersDefinitionPath, RegistryHelper.eBrancaReg.brBrancaUsuari, False))
    AppSettings.Instance.OptaStatsTeamsDefinitionPath = CStr(CMyRegConfig.ReadValue("OptaStatsTeamsDefinitionPath", AppSettings.Instance.OptaStatsTeamsDefinitionPath, RegistryHelper.eBrancaReg.brBrancaUsuari, False))

    AppSettings.Instance.OptaFTPServer = CStr(CMyRegConfig.ReadValue("OptaFTPServer", AppSettings.Instance.OptaFTPServer, RegistryHelper.eBrancaReg.brBrancaUsuari, False))
    AppSettings.Instance.OptaFTPUser = CStr(CMyRegConfig.ReadValue("OptaFTPUser", AppSettings.Instance.OptaFTPUser, RegistryHelper.eBrancaReg.brBrancaUsuari, False))
    AppSettings.Instance.OptaFTPPassword = CStr(CMyRegConfig.ReadValue("OptaFTPPassword", AppSettings.Instance.OptaFTPPassword, RegistryHelper.eBrancaReg.brBrancaUsuari, False))
    AppSettings.Instance.OptaFTPPort = CInt(CMyRegConfig.ReadValue("OptaFTPPort", AppSettings.Instance.OptaFTPPort, RegistryHelper.eBrancaReg.brBrancaUsuari, False))
    AppSettings.Instance.OptaDefaultFolder = CStr(CMyRegConfig.ReadValue("OptaDefaultFolder", AppSettings.Instance.OptaDefaultFolder, RegistryHelper.eBrancaReg.brBrancaUsuari, False))
    AppSettings.Instance.OptaDefaultHistoryFolder = CStr(CMyRegConfig.ReadValue("OptaDefaultHistoryFolder", AppSettings.Instance.OptaDefaultHistoryFolder, RegistryHelper.eBrancaReg.brBrancaUsuari, False))
    AppSettings.Instance.OptaCompetitionID = CStr(CMyRegConfig.ReadValue("OptaCompetitionID", AppSettings.Instance.OptaCompetitionID, RegistryHelper.eBrancaReg.brBrancaUsuari, False))
    AppSettings.Instance.OptaSeasonID = CStr(CMyRegConfig.ReadValue("OptaSeasonID", AppSettings.Instance.OptaSeasonID, RegistryHelper.eBrancaReg.brBrancaUsuari, False))

    Return AppSettings.Instance
  End Function

  Public Sub Save()
    Try
      Me.DesarConfiguracio(0, Me)
    Catch ex As Exception
      WriteToErrorLog(ex)
    End Try
  End Sub

  Public Sub DesarConfiguracio(ByVal niNumConfig As Integer, ByVal tiConfig As AppSettings)
    Dim CMyRegConfig As New RegistryHelper(My.Application.Info.Title, "Config", niNumConfig)

    CMyRegConfig.WriteValue("DataBasePath", tiConfig.DataBasePath, RegistryHelper.eBrancaReg.brBrancaUsuari, Microsoft.Win32.RegistryValueKind.String, False)
    CMyRegConfig.WriteValue("GraphicVersion", tiConfig.GraphicVersion, RegistryHelper.eBrancaReg.brBrancaUsuari, Microsoft.Win32.RegistryValueKind.String, False)
    CMyRegConfig.WriteValue("LastCompetitionId", tiConfig.LastCompetitionId, RegistryHelper.eBrancaReg.brBrancaUsuari, Microsoft.Win32.RegistryValueKind.DWord, False)
    CMyRegConfig.WriteValue("LastMatchId", tiConfig.LastMatchId, RegistryHelper.eBrancaReg.brBrancaUsuari, Microsoft.Win32.RegistryValueKind.DWord, False)
    CMyRegConfig.WriteValue("LoggerHost", tiConfig.LoggerIP, RegistryHelper.eBrancaReg.brBrancaUsuari, Microsoft.Win32.RegistryValueKind.String, False)
    CMyRegConfig.WriteValue("LoggerPort", tiConfig.LoggerPort, RegistryHelper.eBrancaReg.brBrancaUsuari, Microsoft.Win32.RegistryValueKind.DWord, False)
    CMyRegConfig.WriteValue("OtherMatchesPath", tiConfig.OtherMatchesPath, RegistryHelper.eBrancaReg.brBrancaUsuari, Microsoft.Win32.RegistryValueKind.String, False)
    CMyRegConfig.WriteValue("PreviewLocalPath", tiConfig.PreviewLocalPath, RegistryHelper.eBrancaReg.brBrancaUsuari, Microsoft.Win32.RegistryValueKind.String, False)
    CMyRegConfig.WriteValue("PreviewRemotePath", tiConfig.PreviewRemotePath, RegistryHelper.eBrancaReg.brBrancaUsuari, Microsoft.Win32.RegistryValueKind.String, False)
    CMyRegConfig.WriteValue("ScenePath", tiConfig.ScenePath, RegistryHelper.eBrancaReg.brBrancaUsuari, Microsoft.Win32.RegistryValueKind.String, False)
    CMyRegConfig.WriteValue("ShowSettingsOnStartup", CBool(tiConfig.ShowSettingsOnStartup), RegistryHelper.eBrancaReg.brBrancaUsuari, Microsoft.Win32.RegistryValueKind.DWord, False)
    CMyRegConfig.WriteValue("UseArabicNames", CBool(tiConfig.UseArabicNames), RegistryHelper.eBrancaReg.brBrancaUsuari, Microsoft.Win32.RegistryValueKind.DWord, False)
    CMyRegConfig.WriteValue("UseMultiLanguageOutput", CBool(tiConfig.UseMultiLanguageOutput), RegistryHelper.eBrancaReg.brBrancaUsuari, Microsoft.Win32.RegistryValueKind.DWord, False)
    CMyRegConfig.WriteValue("VizrtHost", tiConfig.VizrtHost, RegistryHelper.eBrancaReg.brBrancaUsuari, Microsoft.Win32.RegistryValueKind.String, False)
    CMyRegConfig.WriteValue("VizrtPort", tiConfig.VizrtPort, RegistryHelper.eBrancaReg.brBrancaUsuari, Microsoft.Win32.RegistryValueKind.DWord, False)
    CMyRegConfig.WriteValue("VizrtPreviewPort", tiConfig.VizrtPreviewPort, RegistryHelper.eBrancaReg.brBrancaUsuari, Microsoft.Win32.RegistryValueKind.DWord, False)
    CMyRegConfig.WriteValue("TeamImageInfoList", tiConfig.TeamImageInfoList, RegistryHelper.eBrancaReg.brBrancaUsuari, Microsoft.Win32.RegistryValueKind.String, False)
    CMyRegConfig.WriteValue("ColorsDefaultPath", tiConfig.ColorsDefaultPath, RegistryHelper.eBrancaReg.brBrancaUsuari, Microsoft.Win32.RegistryValueKind.String, False)
    CMyRegConfig.WriteValue("KitsDefaultPath", tiConfig.KitsDefaultPath, RegistryHelper.eBrancaReg.brBrancaUsuari, Microsoft.Win32.RegistryValueKind.String, False)

    CMyRegConfig.WriteValue("ClockPosition_X", tiConfig.ClockPosition_X, RegistryHelper.eBrancaReg.brBrancaUsuari, Microsoft.Win32.RegistryValueKind.DWord, False)
    CMyRegConfig.WriteValue("ClockPosition_y", tiConfig.ClockPosition_Y, RegistryHelper.eBrancaReg.brBrancaUsuari, Microsoft.Win32.RegistryValueKind.DWord, False)

    CMyRegConfig.WriteValue("OptaStatsPlayersDefinitionPath", tiConfig.OptaStatsPlayersDefinitionPath, RegistryHelper.eBrancaReg.brBrancaUsuari, Microsoft.Win32.RegistryValueKind.String, False)
    CMyRegConfig.WriteValue("OptaStatsTeamsDefinitionPath", tiConfig.OptaStatsTeamsDefinitionPath, RegistryHelper.eBrancaReg.brBrancaUsuari, Microsoft.Win32.RegistryValueKind.String, False)


    CMyRegConfig.WriteValue("OptaFTPServer", tiConfig.OptaFTPServer, RegistryHelper.eBrancaReg.brBrancaUsuari, Microsoft.Win32.RegistryValueKind.String, False)
    CMyRegConfig.WriteValue("OptaFTPUser", tiConfig.OptaFTPUser, RegistryHelper.eBrancaReg.brBrancaUsuari, Microsoft.Win32.RegistryValueKind.String, False)
    CMyRegConfig.WriteValue("OptaFTPPassword", tiConfig.OptaFTPPassword, RegistryHelper.eBrancaReg.brBrancaUsuari, Microsoft.Win32.RegistryValueKind.String, False)
    CMyRegConfig.WriteValue("OptaFTPPort", tiConfig.OptaFTPPort, RegistryHelper.eBrancaReg.brBrancaUsuari, Microsoft.Win32.RegistryValueKind.DWord, False)
    CMyRegConfig.WriteValue("OptaDefaultFolder", tiConfig.OptaDefaultFolder, RegistryHelper.eBrancaReg.brBrancaUsuari, Microsoft.Win32.RegistryValueKind.String, False)
    CMyRegConfig.WriteValue("OptaDefaultHistoryFolder", tiConfig.OptaDefaultHistoryFolder, RegistryHelper.eBrancaReg.brBrancaUsuari, Microsoft.Win32.RegistryValueKind.String, False)
    CMyRegConfig.WriteValue("OptaCompetitionID", tiConfig.OptaCompetitionID, RegistryHelper.eBrancaReg.brBrancaUsuari, Microsoft.Win32.RegistryValueKind.String, False)
    CMyRegConfig.WriteValue("OptaSeasonID", tiConfig.OptaSeasonID, RegistryHelper.eBrancaReg.brBrancaUsuari, Microsoft.Win32.RegistryValueKind.String, False)
    CMyRegConfig = Nothing
  End Sub

End Class
