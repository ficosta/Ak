Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports System.Windows.Forms
Imports System.Data.SqlClient


Public Class frmOptaStats

  Public OptaStatsTeam As Opta_Term_Stats, OptaStatsPlayer As Opta_Term_Stats

  Private Enum eStat
    opta_name = 0
    app_name = 1
    show_in_full_frame = 2
    show_in_lower_3rd
  End Enum

  Public Sub New()
    InitializeComponent()
  End Sub

  Private Sub frmOptaStats_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    Me.OptaStatsTeam = AppSettings.Instance.OptaStatsTeam
    Me.OptaStatsPlayer = AppSettings.Instance.OptaStatsPlayer
    '            this.ReadFromDataBase();
    Me.FillData(Me.MetroGridTeamStats, OptaStatsTeam)
    Me.FillData(Me.MetroGridPlayerStats, OptaStatsPlayer)

  End Sub

  Private Sub FillData(grid As MetroFramework.Controls.MetroGrid, stats As Opta_Term_Stats)
    If grid.Rows.Count > stats.Count Then
      grid.Rows.Clear()
    End If

    If grid.Rows.Count < stats.Count Then
      grid.Rows.Add(stats.Count - grid.Rows.Count)
    End If

    For i As Integer = 0 To stats.Count - 1
      Dim stat As Opta_Term_Stat = stats(i)
      grid.Rows(i).Cells(ColumnOptaName.Index).Value = stat.OPTAName
      grid.Rows(i).Cells(ColumnOptaAppName.Index).Value = stat.AppName
      grid.Rows(i).Cells(ColumnOptaShowInFullFrame.Index).Value = stat.ShowInFullFrames
      grid.Rows(i).Cells(ColumnOptaShowInLower3rd.Index).Value = stat.ShowInLower
    Next
  End Sub

  Private Sub UpdateCollection(grid As DataGridView, stats As Opta_Term_Stats)
    stats.Clear()
    Try
      For Each row As DataGridViewRow In grid.Rows
        Dim stat As New Opta_Term_Stat()
        stat.OPTAName = DirectCast(row.Cells(ColumnOptaName.Index).Value, [String])
        stat.AppName = DirectCast(row.Cells(ColumnOptaAppName.Index).Value, [String])
        stat.ShowInFullFrames = CBool(row.Cells(ColumnOptaShowInFullFrame.Index).Value)
        stat.ShowInLower = CBool(row.Cells(ColumnOptaShowInLower3rd.Index).Value)
        stats.Add(stat)
      Next

    Catch
    End Try

  End Sub

  Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles OK_Button.Click
    Accept()
  End Sub


  Private Sub Accept()
    Me.DialogResult = System.Windows.Forms.DialogResult.OK
    Me.UpdateCollection(Me.MetroGridTeamStats, Me.OptaStatsTeam)
    Me.OptaStatsTeam.SaveToFile()
    Me.UpdateCollection(Me.MetroGridPlayerStats, Me.OptaStatsPlayer)
    Me.OptaStatsPlayer.SaveToFile()
    Me.Close()
  End Sub

  Private Sub Cancel_Button_Click(sender As Object, e As EventArgs) Handles Cancel_Button.Click
    Me.Close()
  End Sub

  Private Sub ReadFromDataBase()
    Try
      Dim conn As New SqlConnection(MatchInfo.Config.Instance.LocalConnectionString)
      conn.Open()

      Dim sql As [String] = "SELECT [stat_type] FROM Player_Match_Stats group by [stat_type] order by stat_type Asc"
      Dim CmdSQL As New SqlCommand(sql, conn)

      CmdSQL.CommandType = System.Data.CommandType.Text
      Dim myDBReader As SqlDataReader = CmdSQL.ExecuteReader()
      While myDBReader.Read()
        Dim stat As New Opta_Term_Stat()
        stat.OPTAName = myDBReader.GetString(0)
        If Me.OptaStatsPlayer.GetStatByOptaName(stat.OPTAName) Is Nothing Then
          Me.OptaStatsPlayer.Add(stat)
        End If
      End While

      sql = "SELECT [stat_type] FROM Team_Match_Stats group by [stat_type] order by stat_type Asc"
      CmdSQL = New SqlCommand(sql, conn)

      CmdSQL.CommandType = System.Data.CommandType.Text
      myDBReader = CmdSQL.ExecuteReader()
      While myDBReader.Read()
        Dim stat As New Opta_Term_Stat()
        stat.OPTAName = myDBReader.GetString(0)
        If Me.OptaStatsTeam.GetStatByOptaName(stat.OPTAName) Is Nothing Then
          Me.OptaStatsTeam.Add(stat)
        End If
      End While
      conn.Close()
    Catch ex As Exception
      Throw ex
    End Try
  End Sub

End Class