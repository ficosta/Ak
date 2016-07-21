Imports System.ComponentModel


Public Class AsyncStatWriter
#Region "Singleton"
  Private Shared ReadOnly _instance As New Lazy(Of AsyncStatWriter)(Function() New AsyncStatWriter(), System.Threading.LazyThreadSafetyMode.ExecutionAndPublication)

  Public Shared ReadOnly Property Instance() As AsyncStatWriter
    Get
      Return _instance.Value
    End Get
  End Property
#End Region

  Private WithEvents _backgroundWorker As BackgroundWorker

  Public Event DataUpdated(dataToUpdate As Integer, lastUpdatedData As StatToUpdate)

  Public Structure StatToUpdate
    Dim stat As Stat
    Dim subject As StatSubject
  End Structure

  Private _statsToUpdate As New List(Of StatToUpdate)

  Private Sub New()
    Try
      _backgroundWorker = New BackgroundWorker
      _backgroundWorker.WorkerReportsProgress = True
      _backgroundWorker.WorkerSupportsCancellation = True
    Catch ex As Exception
    End Try
  End Sub

  Public Function AddStatToQue(statSubject As StatSubject, stat As Stat) As Integer
    Dim res As Integer = -1
    Dim statToUpdate As StatToUpdate
    Try
      statToUpdate.stat = stat
      statToUpdate.subject = statSubject
      _statsToUpdate.Add(statToUpdate)

      If _backgroundWorker.IsBusy = False Then
        _backgroundWorker.RunWorkerAsync()
      End If

      res = _statsToUpdate.Count
    Catch ex As Exception
    End Try
    Return res
  End Function

  Private Sub _backgroundWorker_DoWork(sender As Object, e As DoWorkEventArgs) Handles _backgroundWorker.DoWork
    Try
      While _statsToUpdate.Count > 0
        _statsToUpdate(0).subject.WriteStatToDB_Sync(_statsToUpdate(0).stat)
        _backgroundWorker.ReportProgress(_statsToUpdate.Count, _statsToUpdate(0))
        _statsToUpdate.RemoveAt(0)
      End While
    Catch ex As Exception

    End Try
  End Sub

  Private Sub _backgroundWorker_ProgressChanged(sender As Object, e As ProgressChangedEventArgs) Handles _backgroundWorker.ProgressChanged
    Try
      RaiseEvent DataUpdated(e.ProgressPercentage, CType(e.UserState, StatToUpdate))
    Catch ex As Exception

    End Try
  End Sub

  Private Sub _backgroundWorker_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles _backgroundWorker.RunWorkerCompleted
    RaiseEvent DataUpdated(0, Nothing)
  End Sub
End Class
