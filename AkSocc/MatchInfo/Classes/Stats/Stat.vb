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

        RaiseEvent PropertyChanged(Me,
                  New System.ComponentModel.PropertyChangedEventArgs("Value"))
        'RaiseEvent PropertyChanged(Me,
        '          New System.ComponentModel.PropertyChangedEventArgs("ValueText"))
        RaiseEvent StatValueChanged(Me)
      Else
        'Debug.Print ("No change " & me.Name & " = " & me.value & " ID " )
      End If
    End Set
  End Property

  Public ReadOnly Property ValueText As String
    Get
      Return CStr(_value)
    End Get
  End Property

  Public Property FromDataBase As Boolean = True

#Region "Constructors"
  Public Sub New()

  End Sub

  Public Sub New(name As String, Optional dataType As eDataType = eDataType.IntValue)
    Me.Name = name
    Me.DataType = dataType
  End Sub

  Public Sub New(name As String, value As Integer)
    Me.Name = name
    Me.Value = value
    Me.DataType = eDataType.IntValue
  End Sub

  Public Sub New(name As String, value As Double)
    Me.Name = name
    Me.Value = value
    Me.DataType = eDataType.DoubleValue
  End Sub
#End Region
End Class
