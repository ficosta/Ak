
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
  Public Property LoggerHost As String = ""
  Public Property LoggerPort As Integer = 6405
  Public Property OtherMatchesPath As String = ""
  Public Property PreviewLocalPath As String = ""
  Public Property PreviewRemotePath As String = ""
  Public Property ScenePath As String = ""
  Public Property ShowSettingsOnStartup As Boolean = True
  Public Property UseArabicNames As Boolean = True
  Public Property VizrtHost As String = ""
  Public Property VizrtPort As Integer = 6100
  Public Property VizrtPreviewPort As Integer = 0
  Public Property TeamImageInfoList As String = ""
  Public Property ColorsDefaultPath As String = "C:\Alamiya\Colors"
  Public Property KitsDefaultPath As String = "C:\Alamiya\kits"
  Public Property ClockStart As Boolean = False
  Public Property UseDefaultShortcuts As Boolean = True

#End Region

  Public Function LlegirConfiguracio(ByVal niNumConfig As Integer) As AppSettings
    Dim sTemp As String = ""
    Dim CMyRegConfig As New RegistryHelper(My.Application.Info.Title, "Config", niNumConfig)

    AppSettings.Instance.DataBasePath = CStr(CMyRegConfig.ReadValue("DataBasePath", AppSettings.Instance.DataBasePath, RegistryHelper.eBrancaReg.brBrancaUsuari, False))
    AppSettings.Instance.GraphicVersion = CStr(CMyRegConfig.ReadValue("GraphicVersion", AppSettings.Instance.GraphicVersion, RegistryHelper.eBrancaReg.brBrancaUsuari, False))
    AppSettings.Instance.LastCompetitionId = CInt(CMyRegConfig.ReadValue("LastCompetitionId", AppSettings.Instance.LastCompetitionId, RegistryHelper.eBrancaReg.brBrancaUsuari, False))
    AppSettings.Instance.LastMatchId = CInt(CMyRegConfig.ReadValue("LastMatchId", AppSettings.Instance.LastMatchId, RegistryHelper.eBrancaReg.brBrancaUsuari, False))
    AppSettings.Instance.LoggerHost = CStr(CMyRegConfig.ReadValue("LoggerHost", AppSettings.Instance.LoggerHost, RegistryHelper.eBrancaReg.brBrancaUsuari, False))
    AppSettings.Instance.LoggerPort = CInt(CMyRegConfig.ReadValue("LoggerPort", AppSettings.Instance.LoggerPort, RegistryHelper.eBrancaReg.brBrancaUsuari, False))
    AppSettings.Instance.OtherMatchesPath = CStr(CMyRegConfig.ReadValue("OtherMatchesPath", AppSettings.Instance.OtherMatchesPath, RegistryHelper.eBrancaReg.brBrancaUsuari, False))
    AppSettings.Instance.PreviewLocalPath = CStr(CMyRegConfig.ReadValue("PreviewLocalPath", AppSettings.Instance.PreviewLocalPath, RegistryHelper.eBrancaReg.brBrancaUsuari, False))
    AppSettings.Instance.PreviewRemotePath = CStr(CMyRegConfig.ReadValue("PreviewRemotePath", AppSettings.Instance.PreviewRemotePath, RegistryHelper.eBrancaReg.brBrancaUsuari, False))
    AppSettings.Instance.ScenePath = CStr(CMyRegConfig.ReadValue("ScenePath", AppSettings.Instance.ScenePath, RegistryHelper.eBrancaReg.brBrancaUsuari, False))
    AppSettings.Instance.ShowSettingsOnStartup = CStr(CMyRegConfig.ReadValue("ShowSettingsOnStartup", AppSettings.Instance.ShowSettingsOnStartup, RegistryHelper.eBrancaReg.brBrancaUsuari, False))
    AppSettings.Instance.UseArabicNames = CStr(CMyRegConfig.ReadValue("UseArabicNames", AppSettings.Instance.UseArabicNames, RegistryHelper.eBrancaReg.brBrancaUsuari, False))
    AppSettings.Instance.VizrtHost = CStr(CMyRegConfig.ReadValue("VizrtHost", AppSettings.Instance.VizrtHost, RegistryHelper.eBrancaReg.brBrancaUsuari, False))
    AppSettings.Instance.VizrtPort = CInt(CMyRegConfig.ReadValue("VizrtPort", AppSettings.Instance.VizrtPort, RegistryHelper.eBrancaReg.brBrancaUsuari, False))
    AppSettings.Instance.VizrtPreviewPort = CInt(CMyRegConfig.ReadValue("VizrtPreviewPort", AppSettings.Instance.VizrtPreviewPort, RegistryHelper.eBrancaReg.brBrancaUsuari, False))
    AppSettings.Instance.TeamImageInfoList = CStr(CMyRegConfig.ReadValue("TeamImageInfoList", AppSettings.Instance.TeamImageInfoList, RegistryHelper.eBrancaReg.brBrancaUsuari, False))
    AppSettings.Instance.ColorsDefaultPath = CStr(CMyRegConfig.ReadValue("ColorsDefaultPath", AppSettings.Instance.ColorsDefaultPath, RegistryHelper.eBrancaReg.brBrancaUsuari, False))
    AppSettings.Instance.KitsDefaultPath = CStr(CMyRegConfig.ReadValue("KitsDefaultPath", AppSettings.Instance.KitsDefaultPath, RegistryHelper.eBrancaReg.brBrancaUsuari, False))

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
    CMyRegConfig.WriteValue("LoggerHost", tiConfig.LoggerHost, RegistryHelper.eBrancaReg.brBrancaUsuari, Microsoft.Win32.RegistryValueKind.String, False)
    CMyRegConfig.WriteValue("LoggerPort", tiConfig.LoggerPort, RegistryHelper.eBrancaReg.brBrancaUsuari, Microsoft.Win32.RegistryValueKind.DWord, False)
    CMyRegConfig.WriteValue("OtherMatchesPath", tiConfig.OtherMatchesPath, RegistryHelper.eBrancaReg.brBrancaUsuari, Microsoft.Win32.RegistryValueKind.String, False)
    CMyRegConfig.WriteValue("PreviewLocalPath", tiConfig.PreviewLocalPath, RegistryHelper.eBrancaReg.brBrancaUsuari, Microsoft.Win32.RegistryValueKind.String, False)
    CMyRegConfig.WriteValue("PreviewRemotePath", tiConfig.PreviewRemotePath, RegistryHelper.eBrancaReg.brBrancaUsuari, Microsoft.Win32.RegistryValueKind.String, False)
    CMyRegConfig.WriteValue("ScenePath", tiConfig.ScenePath, RegistryHelper.eBrancaReg.brBrancaUsuari, Microsoft.Win32.RegistryValueKind.String, False)
    CMyRegConfig.WriteValue("ShowSettingsOnStartup", CBool(tiConfig.ShowSettingsOnStartup), RegistryHelper.eBrancaReg.brBrancaUsuari, Microsoft.Win32.RegistryValueKind.DWord, False)
    CMyRegConfig.WriteValue("UseArabicNames", CBool(tiConfig.UseArabicNames), RegistryHelper.eBrancaReg.brBrancaUsuari, Microsoft.Win32.RegistryValueKind.DWord, False)
    CMyRegConfig.WriteValue("VizrtHost", tiConfig.VizrtHost, RegistryHelper.eBrancaReg.brBrancaUsuari, Microsoft.Win32.RegistryValueKind.String, False)
    CMyRegConfig.WriteValue("VizrtPort", tiConfig.VizrtPort, RegistryHelper.eBrancaReg.brBrancaUsuari, Microsoft.Win32.RegistryValueKind.DWord, False)
    CMyRegConfig.WriteValue("VizrtPreviewPort", tiConfig.VizrtPreviewPort, RegistryHelper.eBrancaReg.brBrancaUsuari, Microsoft.Win32.RegistryValueKind.DWord, False)
    CMyRegConfig.WriteValue("TeamImageInfoList", tiConfig.TeamImageInfoList, RegistryHelper.eBrancaReg.brBrancaUsuari, Microsoft.Win32.RegistryValueKind.String, False)
    CMyRegConfig.WriteValue("ColorsDefaultPath", tiConfig.ColorsDefaultPath, RegistryHelper.eBrancaReg.brBrancaUsuari, Microsoft.Win32.RegistryValueKind.String, False)
    CMyRegConfig.WriteValue("KitsDefaultPath", tiConfig.KitsDefaultPath, RegistryHelper.eBrancaReg.brBrancaUsuari, Microsoft.Win32.RegistryValueKind.String, False)

    CMyRegConfig = Nothing
  End Sub

End Class
