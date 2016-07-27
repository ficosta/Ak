Imports System.ComponentModel

Public Enum eDataType
  IntValue
  DoubleValue
  PercentageValue
  CompositeValue
End Enum

Public Class Stat
  Implements System.ComponentModel.INotifyPropertyChanged
  Public Property DataType As eDataType = eDataType.IntValue
  Public Property Enabled As Boolean = True
  Public Property Name As String = ""
  Public Property StatTitle As String = ""
  Public Property UID As String = Guid.NewGuid().ToString
  Public Property EventBased As Boolean = True

  Public Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged
  Public Event StatValueChanged(sender As Stat)

  Private _value As Double = 0

  Public Property Value As Double
    Get
      Return _value
    End Get
    Set(value As Double)
      If _value <> value Then
        _value = value

        If Config.Instance.Silent = False Then RaiseEvent PropertyChanged(Me, New System.ComponentModel.PropertyChangedEventArgs("Value"))
        'RaiseEvent PropertyChanged(Me,
        '          New System.ComponentModel.PropertyChangedEventArgs("ValueText"))
        If Config.Instance.Silent = False Then RaiseEvent StatValueChanged(Me)
      Else
          'Debug.Print ("No change " & me.Name & " = " & me.value & " ID " )
        End If
    End Set
  End Property

  Public ReadOnly Property ValueText As String
    Get
      Select Case Me.DataType
        Case eDataType.CompositeValue
          Return CStr(_value)
        Case eDataType.DoubleValue
          Return CStr(_value)
        Case eDataType.IntValue
          Return CStr(_value)
        Case eDataType.PercentageValue
          Return CStr(_value) & "%"
        Case Else
          Return CStr(_value)
      End Select
    End Get
  End Property

  Public Property FromDataBase As Boolean = True

  Public Overrides Function ToString() As String
    Return Me.ValueText
  End Function

#Region "Constructors"
  Public Sub New()

  End Sub

  Public Sub New(name As String)
    Me.Name = name
    ' Me.DataType = DataType
    Me.EventBased = EventBased
  End Sub

  Public Sub New(name As String, eventBased As Boolean, value As Integer, Optional type As eDataType = eDataType.IntValue)
    Me.Name = name
    Me.Value = value
    Me.DataType = type
    Me.EventBased = eventBased
    Me.StatTitle = name
  End Sub

  Public Sub New(name As String, eventBased As Boolean, value As Integer, statTitle As String, Optional type As eDataType = eDataType.IntValue)
    Me.Name = name
    Me.Value = value
    Me.DataType = type
    Me.EventBased = eventBased
    Me.StatTitle = statTitle
  End Sub
#End Region
End Class
