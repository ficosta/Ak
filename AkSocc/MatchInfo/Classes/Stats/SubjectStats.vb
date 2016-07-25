﻿Imports System.ComponentModel

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

        If Config.Instance.Silent = False Then RaiseEvent PropertyChanged(Me, New System.ComponentModel.PropertyChangedEventArgs("Goals"))
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

  Private WithEvents _possession1st As New Stat("Possession1st", eDataType.PercentageValue)
  Public ReadOnly Property Possession1st As Stat
    Get
      Return _possession1st
    End Get
  End Property

  Private WithEvents _possession2nd As New Stat("Possession2nd", eDataType.PercentageValue)
  Public ReadOnly Property Possession2nd As Stat
    Get
      Return _possession2nd
    End Get
  End Property

  Private WithEvents _possessionAttack As New Stat("PossessionAttack", eDataType.PercentageValue)
  Public ReadOnly Property PossessionAttack As Stat
    Get
      Return _possessionAttack
    End Get
  End Property

  Private WithEvents _possessionMid As New Stat("PossessionMid", eDataType.PercentageValue)
  Public ReadOnly Property PossessionMid As Stat
    Get
      Return _possessionMid
    End Get
  End Property

  Private WithEvents _possessionOwn As New Stat("PossessionOwn", eDataType.PercentageValue)
  Public ReadOnly Property PossessionOwn As Stat
    Get
      Return _possessionOwn
    End Get
  End Property

  Private WithEvents _possessionMatch As New Stat("PossessionMatch", eDataType.PercentageValue)
  Public ReadOnly Property PossessionMatch As Stat
    Get
      Return _possessionMatch
    End Get
  End Property

  Private WithEvents _possessionLast5 As New Stat("PossessionLast5", eDataType.PercentageValue)
  Public ReadOnly Property PossessionLast5 As Stat
    Get
      Return _possessionLast5
    End Get
  End Property

  Private WithEvents _possessionLast10 As New Stat("PossessionLast10", eDataType.PercentageValue)
  Public ReadOnly Property PossessionLast10 As Stat
    Get
      Return _possessionLast10
    End Get
  End Property


  Private WithEvents _fouls As New Stat("Fouls", 0)
  Public ReadOnly Property Fouls As Stat
    Get
      Return _fouls
    End Get
  End Property

  Private WithEvents _saves As New Stat("Saves", 0)
  Public ReadOnly Property Saves As Stat
    Get
      Return _saves
    End Get
  End Property

  Private WithEvents _assis As New Stat("Assis", 0)
  Public ReadOnly Property Assis As Stat
    Get
      Return _assis
    End Get
  End Property

  Private WithEvents _LastPossessions As New Stat("LastPossessions", eDataType.PercentageValue)

  Public ReadOnly Property LastPossessions As Stat
    Get
      Return _LastPossessions
    End Get
  End Property

  Private WithEvents _Formation_pos As New Stat("Formation_pos", 0)
  Public ReadOnly Property Formation_Pos As Stat
    Get
      Return _Formation_pos
    End Get
  End Property

  Private WithEvents _Formation_X As New Stat("Formation_x", 0)
  Public ReadOnly Property Formation_X As Stat
    Get
      Return _Formation_X
    End Get
  End Property

  Private WithEvents _Formation_Y As New Stat("Formation_y", 0)
  Public ReadOnly Property Formation_Y As Stat
    Get
      Return _Formation_Y
    End Get
  End Property


  Public Property StatBag As New List(Of Stat) From {Me.GoalStat, Me.ShotsOn, Me.Shots, Me.Corners, Me.Offsides, Me.WoodHits, Me.YellowCards, Me.RedCards, Me.Possession, Me.Formation_Pos, Me.Formation_X, Me.Formation_Y, Me.Saves, Me.Fouls, Me.Assis}

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
    If Config.Instance.Silent = False Then RaiseEvent PropertyChanged(Me, New System.ComponentModel.PropertyChangedEventArgs("Value"))
    If Config.Instance.Silent = False Then RaiseEvent StatValueChanged(Me, sender)
  End Sub

  Private Sub _StatValueChanged(sender As Stat)
    If Config.Instance.Silent = False Then RaiseEvent StatValueChanged(Me, sender)
  End Sub

#Region "Socket helpers"
  Public Function ToSocketFormat() As String
    Dim res As String = ""
    Return res
  End Function
#End Region
End Class
