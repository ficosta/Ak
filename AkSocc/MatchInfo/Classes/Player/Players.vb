

Imports System.Data.OleDb

<Serializable()> Public Class Players
  Inherits CollectionBase

  Public Sub New()
  End Sub

  Public Sub New(count As Integer)
    Me.Clear()

    For i As Integer = 1 To count
      Dim player As New Player(i)
      player.PlayerUniqueName = "Player " & i
      player.PlayerSurname = "Player " & i
      player.Formation_Pos = i
      Me.Add(player)
    Next
  End Sub

  Public Function Add(player As Player) As Integer
    Try
      If Not player Is Nothing Then
        Dim found As Boolean
        For index As Integer = 0 To Me.List.Count - 1
          If Me.List(index).PlayerID = player.PlayerID And Me.List(index).optaid = player.optaID Then
            Me.List(index) = player
            found = True
            Exit For
          End If
        Next
        If Not found Then
          Me.List.Add(player)
        End If
      End If
    Catch ex As Exception
    End Try
    Return Me.List.Count
  End Function


  Public Function GetPlayerId(ID As Integer) As Player
    Dim res As Player = Nothing
    Try

      For Each player As Player In Me.List
        If player.ID = ID Then res = player
      Next
    Catch ex As Exception
    End Try
    Return res
  End Function

  Public Function GetPlayerByOptaId(ID As Integer) As Player
    Dim res As Player = Nothing
    Try

      For Each player As Player In Me.List
        If player.optaID = ID Then res = player
      Next
    Catch ex As Exception
    End Try
    Return res
  End Function


  Public Function GetAllPlayers() As Boolean
    Try
      Dim conn As New OleDbConnection(Config.Instance.LocalConnectionString)
      conn.Open()

      Dim SQL As [String] = "SELECT PlayerID, PlayerFirstName, PlayerSurname, PlayerUniqueName, TeamID, SquadNo, DomesticTeamID, DomesticSquadNo, PlayerPosition, InternationalSquadNo, InternationalTeamID, InternationalPlayerUniqueName, EnglishBiog1, Biog1, EnglishBiog2, Biog2, EnglishBiog3, Biog3, Nationality, YellowCards, RedCards, SeasonGoals, PhotoName, ArabicName, VideoName, SeasonAppearances, PhotoName1, VideoName1, VideoName2, OptaId, SeasonCleanSheets"
      SQL += " FROM Players "
      Dim CmdSQL As New OleDbCommand(SQL, conn)

      CmdSQL.CommandType = System.Data.CommandType.Text
      Dim myPlayerReader As OleDbDataReader = CmdSQL.ExecuteReader()

      Me.List.Clear()

      While myPlayerReader.Read()
        Dim player As New Player()

        If Not myPlayerReader.IsDBNull(0) Then
          player.PlayerID = myPlayerReader.GetInt32(0)
        End If

        If Not myPlayerReader.IsDBNull(1) Then
          player.PlayerFirstName = myPlayerReader.GetString(1)
        End If
        If Not myPlayerReader.IsDBNull(2) Then
          player.PlayerSurname = myPlayerReader.GetString(2)
        End If
        CType(player, StatSubject).Name = player.PlayerFirstName & " " & player.PlayerSurname
        If Not myPlayerReader.IsDBNull(3) Then
          player.PlayerUniqueName = myPlayerReader.GetString(3)
          CType(player, StatSubject).Name = player.PlayerUniqueName
        End If
        If Not myPlayerReader.IsDBNull(6) Then
          player.TeamID = myPlayerReader.GetInt32(6)
        End If
        ' EL QUE VALE ES EL DOMESTIC!!! = myPlayerReader.GetInt32(4);
        If Not myPlayerReader.IsDBNull(7) Then
          player.SquadNo = myPlayerReader.GetInt32(7)
        End If
        ' Y EL DomesticSquadNo
        If Not myPlayerReader.IsDBNull(6) Then
          player.DomesticTeamID = myPlayerReader.GetInt32(6)
        End If
        If Not myPlayerReader.IsDBNull(7) Then
          player.DomesticSquadNo = myPlayerReader.GetInt32(7)
        End If
        If Not myPlayerReader.IsDBNull(8) Then
          player.PlayerPosition = myPlayerReader.GetString(8)
        End If
        If Not myPlayerReader.IsDBNull(9) Then
          player.InternationalSquadNo = myPlayerReader.GetInt32(9)
        End If
        If Not myPlayerReader.IsDBNull(10) Then
          player.InternationalTeamID = myPlayerReader.GetInt32(10)
        End If
        If Not myPlayerReader.IsDBNull(11) Then
          player.InternationalPlayerUniqueName = myPlayerReader.GetString(11)
        End If
        If Not myPlayerReader.IsDBNull(12) Then
          player.EnglishBiog1 = myPlayerReader.GetString(12)
        End If
        If Not myPlayerReader.IsDBNull(13) Then
          player.Biog1 = myPlayerReader.GetString(13)
        End If
        If Not myPlayerReader.IsDBNull(14) Then
          player.EnglishBiog2 = myPlayerReader.GetString(14)
        End If
        If Not myPlayerReader.IsDBNull(15) Then
          player.Biog2 = myPlayerReader.GetString(15)
        End If
        If Not myPlayerReader.IsDBNull(16) Then
          player.EnglishBiog3 = myPlayerReader.GetString(16)
        End If
        If Not myPlayerReader.IsDBNull(17) Then
          player.Biog3 = myPlayerReader.GetString(17)
        End If
        If Not myPlayerReader.IsDBNull(18) Then
          player.Nationality = myPlayerReader.GetString(18)
        End If
        If Not myPlayerReader.IsDBNull(19) Then
          player.YellowCards = myPlayerReader.GetInt32(19)
        End If
        If Not myPlayerReader.IsDBNull(20) Then
          player.RedCards = myPlayerReader.GetInt32(20)
        End If
        If Not myPlayerReader.IsDBNull(21) Then
          player.SeasonGoals = myPlayerReader.GetInt32(21)
        End If
        If Not myPlayerReader.IsDBNull(22) Then
          player.PhotoName = myPlayerReader.GetString(22)
        End If
        If Not myPlayerReader.IsDBNull(23) Then
          player.ArabicName = myPlayerReader.GetString(23)
        End If
        If Not myPlayerReader.IsDBNull(24) Then
          player.VideoName = myPlayerReader.GetString(24)
        End If
        If Not myPlayerReader.IsDBNull(25) Then
          player.SeasonAppearances = myPlayerReader.GetInt32(25)
        End If
        If Not myPlayerReader.IsDBNull(26) Then
          player.PhotoName1 = myPlayerReader.GetString(26)
        End If
        If Not myPlayerReader.IsDBNull(27) Then
          player.VideoName1 = myPlayerReader.GetString(27)
        End If
        If Not myPlayerReader.IsDBNull(28) Then
          player.VideoName2 = myPlayerReader.GetString(28)
        End If
        If Not myPlayerReader.IsDBNull(29) Then
          player.optaID = myPlayerReader.GetInt32(29)
        End If
        If Not myPlayerReader.IsDBNull(30) Then
          player.SeasonCleanSheets = myPlayerReader.GetInt32(30)
        End If

        Me.List.Add(player)
      End While

      conn.Close()

    Catch err As Exception
      Throw err
    End Try
    Return True
  End Function



  Public Sub Sort()
    Me.InnerList.Sort()
  End Sub

  Default Public Property Item(Index As Integer) As Player
    Get
      Return DirectCast(List(Index), Player)
    End Get
    Set

      List(Index) = Value
    End Set
  End Property

  Public Function GetPlayer(ID As Integer) As Player
    Dim output As Player = Nothing
    Try
      For Each SearchPlayer As Player In List
        If SearchPlayer.PlayerID = ID Then
          output = SearchPlayer
          Exit For
        End If
      Next
    Catch err As Exception
      Throw err
    End Try
    Return (output)
  End Function

  Public Function GetPlayerByDorsal(ID As Integer) As Player
    Dim output As Player = Nothing
    Try
      For Each SearchPlayer As Player In List
        If SearchPlayer.SquadNo = ID Then
          output = SearchPlayer
          Exit For
        End If
      Next
    Catch err As Exception
      Throw err
    End Try
    Return (output)
  End Function

  Public Function GetPlayerByPosition(position As Integer) As Player
    Dim output As Player = Nothing
    Try
      For Each SearchPlayer As Player In List
        If SearchPlayer.Formation_Pos = position Then
          output = SearchPlayer
          Exit For
        End If
      Next
    Catch err As Exception
      Throw err
    End Try
    Return (output)
  End Function

  Public Function Contains(ID As Integer) As Boolean
    Dim output As Boolean = False
    Try
      For Each SearchPlayer As Player In List
        If SearchPlayer.PlayerID = ID Then
          output = True
          Exit For
        End If
      Next
    Catch err As Exception
      Throw err
    End Try
    Return (output)
  End Function

  Public Function ContainsByOptaID(ID As Integer) As Boolean
    Dim output As Boolean = False
    Try
      For Each SearchPlayer As Player In List
        If SearchPlayer.optaID = ID Then
          output = True
          Exit For
        End If
      Next
    Catch err As Exception
      Throw err
    End Try
    Return (output)
  End Function

  Public Function Contains(player As Player) As Boolean
    Dim output As Boolean = False
    Try
      output = Me.Contains(player.ID)
    Catch err As Exception
      Throw err
    End Try
    Return (output)
  End Function

  Public Function Remove(ID As Integer) As Boolean
    Dim output As Boolean = False
    Try
      For i As Integer = List.Count - 1 To 0 Step -1
        If List(i).PlayerID = ID Then
          List.RemoveAt(i)
          output = True
        End If
      Next
    Catch err As Exception
      Throw err
    End Try
    Return (output)
  End Function

  Public Function Remove(player As Player) As Boolean
    Dim output As Boolean = False
    Try
      output = Me.Remove(player.ID)
    Catch err As Exception
      Throw err
    End Try
    Return (output)
  End Function
End Class
