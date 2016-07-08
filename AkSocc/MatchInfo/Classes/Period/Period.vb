
Public Enum eTipusUpdatePeriodes
  Database
  Clock
End Enum



<Serializable()> Public Class Period
  'Inherits COptaData
  Public Const DEFAULT_TIME As Date = #1/1/2000#

  Public Event ActiveStateChanged(sender As Period)
  Public Event SelectedStateChanged(sender As Period)


  Public Enum eModeTiming
    Normal
    Fraccionat
  End Enum

  Public periodID As Integer

  Public IDPartit As Integer = 0
  Public Part As Integer = 0
  Public HoraInici As Date
  Private dPiLastUpdate As Date
  Private nPiTempsJoc As Long = 0
  Public ManualOffset As Long = 0
  Public ExtraTime As Integer = 0
  Public Assistencia As Integer = 0
  Public Temperatura As Integer = 0
  Private bPiActiva As Boolean = False
  Public ModeTiming As eModeTiming = eModeTiming.Normal
  Public Nom As String
  Public NomCurt As String
  Public TotalTime As Long = 2 * 60
  Public StartOffset As Long = 0
  Public AutoSave As Boolean = True

  Public IsProrroga As Boolean = False

  Public SquadNo As Integer = 0
  Public PeriodPosition As Integer = 0

  Private _isSelected As Boolean = False
  Public Property IsSelected As Boolean
    Get
      Return _isSelected
    End Get
    Set(value As Boolean)
      _isSelected = value
      RaiseEvent SelectedStateChanged(Me)
    End Set
  End Property

  Public ReadOnly Property IsPeriodDone As Boolean
    Get
      Return Me.PlayingTime >= Me.TotalTime
    End Get
  End Property



  Public ReadOnly Property PlayingTime() As Long
    Get
      Return nPiTempsJoc
    End Get
  End Property

  Public Property Activa() As Boolean
    Get
      Return bPiActiva
    End Get
    Set(ByVal value As Boolean)
      Try
        If value Then
          'El possem en marxa???
          If bPiActiva = False Then
            'Sembla que si!
            Me.HoraInici = Now
            dPiLastUpdate = Now
            bPiActiva = True
          End If
        Else
          'L'aturem??
          If bPiActiva = True Then
            'Sembla que si! fem-ho!
            ManualOffset = nPiTempsJoc
            bPiActiva = False
          End If
        End If
      Catch ex As Exception

      End Try
      'Update del temps, porsiaca
      Me.UpdateTempsJocClock()
      'Desar porsiaca
      If Me.AutoSave Then
        Me.SavePart()
      End If
      RaiseEvent ActiveStateChanged(Me)
    End Set
  End Property


  Public Sub New()
  End Sub

  Public Sub New(ByVal niIDPartit As Integer, ByVal niPart As Integer, Optional ByVal biIniciar As Boolean = False, Optional ByVal biAutoSave As Boolean = False)
    If biIniciar Then
      Me.HoraInici = Now
    End If
    Me.IDPartit = niIDPartit
    Me.Part = niPart
    Me.Nom = niPart & "a part"
    Me.NomCurt = niPart & "P"
    Me.AutoSave = biAutoSave
  End Sub

  Public Sub New(ByVal niIDPartit As Integer, ByVal niPart As Integer, ByVal siNom As String, Optional ByVal biIniciar As Boolean = False, Optional ByVal biAutoSave As Boolean = False)
    If biIniciar Then
      Me.HoraInici = Now
    End If
    Me.IDPartit = niIDPartit
    Me.Part = niPart
    Me.Nom = siNom
    Me.NomCurt = niPart & "P"
    Me.AutoSave = biAutoSave
  End Sub


  Public Function UpdateTempsJoc(ByVal eiTipusUpdate As eTipusUpdatePeriodes) As Long
    Dim nRes As Long
    Select Case eiTipusUpdate
      Case eTipusUpdatePeriodes.Clock
        nRes = UpdateTempsJocClock()
      Case eTipusUpdatePeriodes.Database
        nRes = UpdateTempsJocDatabase()
    End Select
    Return nRes
  End Function

  Public Function UpdateTempsJocDatabase() As Long
    'Dim sql As String
    'Dim rs As New adodb.recordset
    'Try
    '  'como decía john secada, nada que hacerrrr
    '  If Me.HoraInici = DEFAULT_TIME Then Exit Function

    '  If Me.dPiLastUpdate = DEFAULT_TIME Then Exit Function
    '  Dim nOld As Long

    '  sql = "SELECT * FROM PartitPeriodes WHERE IDPartit=" & Me.IDPartit & " AND Part=" & Me.Part

    '  rs.Open(sql, CPuGlobals.CPuConnection)

    '  If Not rs.EOF Then
    '    nOld = nPiTempsJoc
    '    Me.nPiTempsJoc = NoNullLong(rs.Fields("TempsJoc").Value)
    '    Me.nPuOffsetTempsJoc = NoNullLong(rs.Fields("Offset").Value)
    '    If Me.AutoSave Then
    '      If nOld <> nPiTempsJoc Then Me.SavePart()
    '    End If
    '    Return Me.nPiTempsJoc
    '  Else
    '    'a l'estil antic, que té problemes si els rellotges es dessincronitzen
    '    Return UpdateTempsJocClock()
    '  End If
    'Catch ex As Exception
    '  CPuGlobals.LogError(Err.Source, ex.ToString, Err.Number)
    'End Try
    Return 0
  End Function


  Public Function UpdateTempsJocClock() As Long
    Try
      'como decía john secada, nada que hacerrrr
      If Me.HoraInici = DEFAULT_TIME Then Return 0
      If Me.dPiLastUpdate = DEFAULT_TIME Then Return 0
      Dim nOld As Long

      nOld = nPiTempsJoc

      If Me.bPiActiva Then
        If Me.ModeTiming = eModeTiming.Fraccionat Then
          nPiTempsJoc = nPiTempsJoc + DateDiff(DateInterval.Second, Me.dPiLastUpdate, Now) + ManualOffset
          Me.dPiLastUpdate = Now
        Else
          nPiTempsJoc = DateDiff(DateInterval.Second, Me.HoraInici, Now) + ManualOffset
        End If
      End If
      If Me.AutoSave Then
        If nOld <> nPiTempsJoc Then Me.SavePart()
      End If

    Catch ex As Exception
    End Try
    Return nPiTempsJoc
  End Function

  Public Function UpdateTempsJocManual(ByVal niTempsJoc As Long) As Long
    Try
      'como decía john secada, nada que hacerrrr
      If Me.HoraInici = DEFAULT_TIME Then Return 0
      If Me.dPiLastUpdate = DEFAULT_TIME Then Return 0
      Dim nOld As Long

      nOld = nPiTempsJoc

      If Me.ModeTiming = eModeTiming.Fraccionat Then
        nPiTempsJoc = niTempsJoc ' nPiTempsJoc + DateDiff(DateInterval.Second, Me.dPiLastUpdate, Now) + nPuOffsetTempsJoc
        Me.dPiLastUpdate = Now
      Else
        nPiTempsJoc = niTempsJoc
        ManualOffset = 0
        Me.HoraInici = DateAdd(DateInterval.Second, -(niTempsJoc), Now)
        Me.dPiLastUpdate = Now
      End If
      If Me.AutoSave Then
        If nOld <> nPiTempsJoc Then Me.SavePart()
      End If
    Catch ex As Exception
    End Try
    Return nPiTempsJoc
  End Function

  Public Function UpdateValorsPeriode(ByVal niAfegit As Integer, ByVal diHoraInici As Date, ByVal niTemperatura As Integer, ByVal biActiva As Boolean, ByVal niOffset As Integer, ByVal niTempsTotal As Integer) As Boolean
    Dim bChange As Boolean = False
    Try
      'ha canviat algo?
      bChange = bChange Or (Me.ExtraTime <> niAfegit)
      bChange = bChange Or (Me.HoraInici <> diHoraInici)
      bChange = bChange Or (Me.Temperatura <> niTemperatura)
      bChange = bChange Or (Me.Activa <> biActiva)
      bChange = bChange Or (Me.ManualOffset <> niOffset)
      bChange = bChange Or (Me.TotalTime <> niTempsTotal)

      'si ha canviat algo, que es vegi
      If bChange Then
        Me.ExtraTime = niAfegit
        Me.HoraInici = diHoraInici
        Me.Temperatura = niTemperatura
        Me.Activa = biActiva
        Me.ManualOffset = niOffset
        Me.TotalTime = niTempsTotal
      End If
    Catch ex As Exception

    End Try
    Return bChange
  End Function

  Public Sub Reset()
    Try
      'como decía john secada, nada que hacerrrr
      Me.bPiActiva = False
      Me.dPiLastUpdate = DEFAULT_TIME
      Me.HoraInici = DEFAULT_TIME
      Me.nPiTempsJoc = 0
      Me.ManualOffset = 0
      Me.SavePart()
    Catch ex As Exception
    End Try
  End Sub

  Public Function SavePart() As Boolean
    'Dim sql As String
    'Dim rs As New ADODB.Recordset
    'Try
    '  'Existeix ja??
    '  sql = "SELECT * FROM PartitPeriodes WHERE IDPartit=" & Me.IDPartit & " AND Part=" & Me.Part
    '  rs.Open(sql, CPuGlobals.CPuConnection)
    '  If rs.EOF Then
    '    'S'ha de crear!
    '    sql = "INSERT INTO PartitPeriodes (IDPartit, Part, TempsJoc, HoraInici, Afegit, Assistencia, Temperatura, LastUpdate, Nom, Activa, Offset, IsProrroga, TempsTotal) VALUES ("
    '    sql = sql & Me.IDPartit & ", " & Me.Part & ", " & Me.TempsJoc & ",'" & FormatDate(Me.HoraInici) & "', " & Me.Afegit & ", " & Me.Assistencia & ", " & Me.Temperatura & ", '" & FormatDate(Me.dPiLastUpdate) & "', '" & Me.Nom & "', " & IIf(Me.Activa, "1", "0") & ", " & Me.nPuOffsetTempsJoc & ", " & IIf(Me.IsProrroga, "1", "0") & ", " & Me.TempsTotal & ")"
    '    CPuGlobals.CPuConnection.Execute(sql)
    '  Else
    '    'S'ha d'updatejar!
    '    sql = "UPDATE PartitPeriodes SET TempsJoc=" & Me.TempsJoc & ", "
    '    sql = sql & " HoraInici='" & FormatDate(Me.HoraInici) & "', "
    '    sql = sql & " Afegit=" & Me.Afegit & ", "
    '    sql = sql & " Assistencia=" & Me.Assistencia & ", "
    '    sql = sql & " Temperatura=" & Me.Temperatura & ", "
    '    sql = sql & " LastUpdate='" & FormatDate(Me.dPiLastUpdate) & "', "
    '    sql = sql & " Nom='" & Me.Nom & "', "
    '    sql = sql & " Activa=" & IIf(Me.Activa, "1", "0") & ", "
    '    sql = sql & " IsProrroga=" & IIf(Me.IsProrroga, "1", "0") & ", "
    '    sql = sql & " Offset=" & Me.nPuOffsetTempsJoc & " "
    '    sql = sql & " WHERE IDPartit=" & Me.IDPartit & " AND Part=" & Me.Part

    '    CPuGlobals.CPuConnection.Execute(sql)
    '  End If
    '  rs.Close()
    'Catch ex As Exception
    '  CPuGlobals.LogError(Err.Source, ex.ToString, Err.Number)
    'End Try
    Return False
  End Function

  Public Function LoadPart() As Boolean
    'Dim sql As String
    'Dim rs As New ADODB.Recordset
    'Static bWorking As Boolean = False
    'Try
    '  If bWorking Then Exit Function
    '  bWorking = True
    '  sql = "SELECT * FROM PartitPeriodes WHERE IDPartit=" & Me.IDPartit & " AND Part=" & Me.Part
    '  Debug.Print("LoadPart " & Me.IDPartit)
    '  rs.Open(sql, CPuGlobals.CPuConnection)
    '  If Not rs.EOF Then
    '    With Me
    '      .HoraInici = NoNullDate(rs.Fields("HoraInici").Value)
    '      .dPiLastUpdate = NoNullDate(rs.Fields("LastUpdate").Value)
    '      .Nom = NoNullString(rs.Fields("Nom").Value)
    '      .nPiTempsJoc = NoNullLong(rs.Fields("TempsJoc").Value)
    '      .Temperatura = NoNullInt(rs.Fields("Temperatura").Value)
    '      .Afegit = NoNullInt(rs.Fields("Afegit").Value)
    '      .Assistencia = NoNullInt(rs.Fields("Assistencia").Value)
    '      .bPiActiva = NoNullBool(rs.Fields("Activa").Value)
    '      .IsProrroga = NoNullBool(rs.Fields("IsProrroga").Value)
    '      .nPuOffsetTempsJoc = NoNullInt(rs.Fields("Offset").Value)
    '      .TempsTotal = NoNullInt(rs.Fields("TempsTotal").Value)
    '    End With
    '  End If
    '  rs.Close()
    'Catch ex As Exception
    '  CPuGlobals.LogError(Err.Source, ex.ToString, Err.Number)
    'End Try
    'bWorking = False
    Return False
  End Function


End Class