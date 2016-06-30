Imports System.ComponentModel

Public Class SubjectStats
  Implements INotifyPropertyChanged
  Public Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged

  Public Event StatValueChanged(subjectStats As SubjectStats, stat As Stat)

  Private WithEvents _goals As New Stat("Goals", 0) With {.FromDataBase = False}
  Public ReadOnly Property GoalStat As Stat
    Get
      Return _goals
    End Get
  End Property
  Public Property Goals As Double
    Get
      Return _goals.Value
    End Get
    Set(value As Double)
      If _goals.Value <> value Then
        _goals.Value = value

        RaiseEvent PropertyChanged(Me,
                  New System.ComponentModel.PropertyChangedEventArgs("Goals"))
      End If
    End Set
  End Property
  Private WithEvents _ShotsOn As New Stat("Shots_on_target", 0)
  Public ReadOnly Property ShotsOn As Stat
    Get
      Return _ShotsOn
    End Get
  End Property

  Private WithEvents _Shots As New Stat("Shots", 0)
  Public ReadOnly Property Shots As Stat
    Get
      Return _Shots
    End Get
  End Property

  Private WithEvents _Corners As New Stat("Corners", 0)
  Public ReadOnly Property Corners As Stat
    Get
      Return _Corners
    End Get
  End Property

  Private WithEvents _Offsides As New Stat("Offsides", 0)
  Public ReadOnly Property Offsides As Stat
    Get
      Return _Offsides
    End Get
  End Property

  Private WithEvents _WoodHits As New Stat("WoodHits", 0)
  Public ReadOnly Property WoodHits As Stat
    Get
      Return _WoodHits
    End Get
  End Property

  Private WithEvents _yellowCards As New Stat("YCard", 0)
  Public ReadOnly Property YellowCards As Stat
    Get
      Return _yellowCards
    End Get
  End Property

  Private WithEvents _redCards As New Stat("RCard", 0)
  Public ReadOnly Property RedCards As Stat
    Get
      Return _redCards
    End Get
  End Property

  Private WithEvents _possession As New Stat("Possession", eDataType.PercentageValue)

  Public ReadOnly Property Possession As Stat
    Get
      Return _possession
    End Get
  End Property


  Private WithEvents _FoulsComitted As New Stat("FoulsComitted", 0)
  Public ReadOnly Property FoulsComitted As Stat
    Get
      Return _FoulsComitted
    End Get
  End Property

  Private WithEvents _LastPossessions As New Stat("LastPossessions", eDataType.PercentageValue)

  Public ReadOnly Property LastPossessions As Stat
    Get
      Return _LastPossessions
    End Get
  End Property


  Public Property StatBag As New List(Of Stat) From {Me.GoalStat, Me.ShotsOn, Me.Shots, Me.Corners, Me.Offsides, Me.WoodHits, Me.YellowCards, Me.RedCards, Me.Possession}

  Public Sub New()
    UpdatePropertyEvents()
  End Sub

  Public Sub UpdatePropertyEvents()
    Try
      For Each stat As Stat In Me.StatBag
        RemoveHandler stat.PropertyChanged, AddressOf _PropertyChanged
        RemoveHandler stat.StatValueChanged, AddressOf _StatValueChanged
        AddHandler stat.PropertyChanged, AddressOf _PropertyChanged
        AddHandler stat.StatValueChanged, AddressOf _StatValueChanged
      Next
    Catch ex As Exception

    End Try
  End Sub

  Private Sub _PropertyChanged(sender As Object, e As PropertyChangedEventArgs)
    RaiseEvent PropertyChanged(Me,
              New System.ComponentModel.PropertyChangedEventArgs("Value"))
    RaiseEvent StatValueChanged(Me, sender)
  End Sub

  Private Sub _StatValueChanged(sender As Stat)
    RaiseEvent StatValueChanged(Me, sender)
  End Sub
End Class
