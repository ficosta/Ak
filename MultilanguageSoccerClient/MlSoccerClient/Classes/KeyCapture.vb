Imports System.Runtime.InteropServices
Imports System.Windows.Forms
Imports MlSoccerClient

Public Class KeyCombination
  Implements IEquatable(Of KeyCombination)
  Implements IComparable

  Public Name As String

  Public KeyCode As Keys
  Public Shift As Boolean = False
  Public Control As Boolean = False
  Public Alt As Boolean = False
  Public Windows As Boolean = False

  Public Sub New()
  End Sub

  Public Sub New(ByVal siName As String, ByVal eiKeyCode As Keys)
    Me.Name = siName
    Me.KeyCode = eiKeyCode
    Me.Shift = False
    Me.Control = False
    Me.Alt = False
    Me.Windows = False
  End Sub


  Public Sub New(ByVal siName As String, ByVal eiKeyCode As Keys, ByVal biShift As Boolean, ByVal biControl As Boolean, ByVal biAlt As Boolean, ByVal biWindows As Boolean)
    Me.Name = siName
    Me.KeyCode = eiKeyCode
    Me.Shift = biShift
    Me.Control = biControl
    Me.Alt = biAlt
    Me.Windows = biWindows
  End Sub

  Public Overloads Function Equals(other As KeyCombination) As Boolean Implements IEquatable(Of KeyCombination).Equals
    If other Is Nothing OrElse Not Me.GetType() Is other.GetType() Then
      Return False
    End If

    Dim k As KeyCombination = CType(other, KeyCombination)
    Return Me.KeyCode = k.KeyCode And Me.Alt = k.Alt And Me.Control = k.Control And Me.Shift = k.Shift And Me.Windows = k.Windows
  End Function

  Public Shared Operator =(ByVal point1 As KeyCombination, ByVal point2 As KeyCombination) As Boolean
    Return point1.Equals(point2)
  End Operator

  Public Shared Operator <>(ByVal point1 As KeyCombination, ByVal point2 As KeyCombination) As Boolean
    Return Not (point1 = point2)
  End Operator

  Public Overrides Function ToString() As String
    Return Me.KeyCode.ToString & " Shift=" & Me.Shift & " Ctl=" & Me.Control & " Alt=" & Me.Alt & " Windows=" & Me.Windows & "    " & Me.Name
  End Function

  Public Function CompareTo(obj As Object) As Integer Implements IComparable.CompareTo
    Dim res As Integer = 0
    Try
      Dim aux As KeyCombination = CType(obj, KeyCombination)
      If aux.KeyCode.ToString > Me.KeyCode.ToString Then
        res = 1
      ElseIf aux.KeyCode.ToString < Me.KeyCode.ToString Then
        res = -1
      ElseIf aux.Shift.ToString > Me.Shift.ToString Then
        res = 1
      ElseIf aux.Shift.ToString < Me.shift.ToString Then
        res = -1
      ElseIf aux.Control.ToString > Me.Control.ToString Then
        res = 1
      ElseIf aux.Control.ToString < Me.Control.ToString Then
        res = -1
      ElseIf aux.Alt.ToString > Me.Alt.ToString Then
        res = 1
      ElseIf aux.Alt.ToString < Me.Alt.ToString Then
        res = -1
      ElseIf aux.windows.ToString > Me.windows.ToString Then
        res = 1
      ElseIf aux.windows.ToString < Me.windows.ToString Then
        res = -1
      Else
        res = 0
      End If
    Catch ex As Exception

    End Try
    Return res
  End Function
End Class

Public Class KeyCapture
  Implements IMessageFilter

  Const WM_KEYDOWN As Integer = &H100
  Const WM_KEYUP As Integer = &H101
  Const WM_SYSKEYDOWN As Integer = &H104
  Const WM_SYSKEYUP As Integer = &H105

  Public LlistaCombinations As New List(Of KeyCombination)

  Public Event Keycaptured()
  Public Event KeyCombinationCaptured(ByVal CKeyCombination As KeyCombination)
  Public Event UndefinedKeyCombinationCaptured(ByVal CKeyCombination As KeyCombination)

  Public Shift As Boolean = False
  Public Control As Boolean = False
  Public Alt As Boolean = False
  Public Windows As Boolean = False

  Public ParentHandle As IntPtr = 0

  Private _enabled As Boolean = True
  Public Property Enabled() As Boolean
    Get
      Return _enabled
    End Get
    Set(ByVal value As Boolean)
      If _enabled <> value Then
        _enabled = value
        If _enabled Then
          Application.AddMessageFilter(Me)
        Else
          Application.RemoveMessageFilter(Me)
        End If
      End If
    End Set
  End Property


  Public Declare Function GetActiveWindow Lib "user32" Alias "GetActiveWindow" () As IntPtr
  Public Declare Function GetWindowText Lib "user32" Alias "GetWindowTextA" (ByVal hwnd As IntPtr, ByVal lpString As System.Text.StringBuilder, ByVal cch As Integer) As Integer

  Private Function GetMyWindowText(handle As IntPtr) As String
    ' Create a buffer of 256 characters
    Dim Caption As New System.Text.StringBuilder(256)
    GetWindowText(handle, Caption, Caption.Capacity)
    Return Caption.ToString
  End Function


  Public Sub New()
    Application.AddMessageFilter(Me)

    'Mode chyron
    'Me.LlistaCombinations.Add(New KeyCombination("Read", Keys.Return))
    'Me.LlistaCombinations.Add(New KeyCombination("Read", Keys.F4))
    'Me.LlistaCombinations.Add(New KeyCombination("Read next", Keys.Add))
    'Me.LlistaCombinations.Add(New KeyCombination("Take", Keys.F5))
    'Me.LlistaCombinations.Add(New KeyCombination("Continue", Keys.F8))
    'Me.LlistaCombinations.Add(New KeyCombination("TakeOut", Keys.F6))
    'Me.LlistaCombinations.Add(New KeyCombination("Record", Keys.Subtract))
    'Me.LlistaCombinations.Add(New KeyCombination("Read+Take", Keys.Return, False, True, False, False))

    'Me.LlistaCombinations.Add(New KeyCombination("0", Keys.NumPad0))
    'Me.LlistaCombinations.Add(New KeyCombination("1", Keys.NumPad1))
    'Me.LlistaCombinations.Add(New KeyCombination("2", Keys.NumPad2))
    'Me.LlistaCombinations.Add(New KeyCombination("3", Keys.NumPad3))
    'Me.LlistaCombinations.Add(New KeyCombination("4", Keys.NumPad4))
    'Me.LlistaCombinations.Add(New KeyCombination("5", Keys.NumPad5))
    'Me.LlistaCombinations.Add(New KeyCombination("6", Keys.NumPad6))
    'Me.LlistaCombinations.Add(New KeyCombination("7", Keys.NumPad7))
    'Me.LlistaCombinations.Add(New KeyCombination("8", Keys.NumPad8))
    'Me.LlistaCombinations.Add(New KeyCombination("9", Keys.NumPad9))


  End Sub

  Public Function PreFilterMessage(ByRef m As System.Windows.Forms.Message) As Boolean Implements System.Windows.Forms.IMessageFilter.PreFilterMessage
    If Not _enabled Then Return False

    If m.Msg <> WM_KEYDOWN And m.Msg <> WM_KEYUP And m.Msg <> WM_SYSKEYDOWN And m.Msg <> WM_SYSKEYUP Then Return False

    'Debug.Print("======== PreFilterMessage =========")
    'Debug.Print("Active window [" & GetActiveWindow().ToInt32.ToString & "] = " & GetMyWindowText(GetActiveWindow))
    'Debug.Print("Active window [" & ParentHandle.ToInt32.ToString & "] = " & GetMyWindowText(ParentHandle))

    If Me.ParentHandle.ToInt32 <> 0 And Me.ParentHandle <> GetActiveWindow Then Return False

    Select Case m.Msg
      Case WM_KEYDOWN, WM_SYSKEYDOWN
        ' Debug.Print(m.LParam.ToString & " " & m.WParam.ToString)
        Select Case m.WParam.ToInt32
          Case Keys.Shift, Keys.ShiftKey
            Me.Shift = True
            Return True
          Case Keys.Alt, Keys.Menu, Keys.RMenu
            Me.Alt = True
            Return True
          Case Keys.Control, Keys.ControlKey
            Me.Control = True
            Return True
          Case 22740993
            Me.Windows = True
            Return True
          Case Else
            Return CheckAndFireCombination(New KeyCombination("", CType(m.WParam.ToInt32, Keys), Me.Shift, Me.Control, Me.Alt, Me.Windows))
        End Select

      Case WM_KEYUP, WM_SYSKEYUP
        ' Debug.Print(m.LParam.ToString & " " & m.WParam.ToString)
        Select Case m.WParam.ToInt32
          Case Keys.Shift, Keys.ShiftKey
            Me.Shift = False
            Return True
          Case Keys.Alt, Keys.Menu, Keys.RMenu
            Me.Alt = False
            Return True
          Case Keys.Control, Keys.ControlKey
            Me.Control = False
            Return True
          Case 22740993
            Me.Windows = False
            Return True
        End Select
    End Select
    Return False
  End Function

  Private Function CheckAndFireCombination(ByVal CKeyCombination As KeyCombination) As Boolean
    Dim bRes As Boolean = False
    Try
      For Each CAux As KeyCombination In Me.LlistaCombinations
        If CAux.Equals(CKeyCombination) Then
          bRes = True
          RaiseEvent KeyCombinationCaptured(CAux)
        End If
      Next
      If bRes = False Then
        RaiseEvent UndefinedKeyCombinationCaptured(CKeyCombination)
      End If
    Catch ex As Exception
    End Try
    Return bRes
  End Function
End Class
