Public Class frmDownloader
  Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
    Me.MultiFileDownloader1.DownloadEnabled = False
    Me.MultiFileDownloader1.Downloads.AddDownload("ftp://ftp.alkamelsystems.com/srml-202-2016-results.xml", System.IO.Path.GetTempFileName)
    Me.MultiFileDownloader1.Downloads.AddDownload("http://ovh.net/files/10Mb.dat", System.IO.Path.GetTempFileName)
    Me.MultiFileDownloader1.Downloads.AddDownload("http://ovh.net/files/100Mb.dat", System.IO.Path.GetTempFileName)
    Me.MultiFileDownloader1.Downloads.AddDownload("http://ovh.net/files/10Mb.dat", System.IO.Path.GetTempFileName)
    Me.MultiFileDownloader1.Downloads.AddDownload("http://ovh.net/files/100Mb.dat", System.IO.Path.GetTempFileName)
    Me.MultiFileDownloader1.Downloads.AddDownload("http://ovh.net/files/100Mb.dat", System.IO.Path.GetTempFileName)

  End Sub

  Private Sub TableLayoutPanel1_Paint(sender As Object, e As PaintEventArgs) Handles TableLayoutPanel1.Paint

  End Sub
End Class