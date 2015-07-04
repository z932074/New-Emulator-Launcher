Imports System.IO
Imports System.Configuration
Imports System.Collections.Specialized


Public Class EFE



    Private Sub cbxPlatformSelect_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxPlatformSelect.SelectedIndexChanged
        Try
            Select Case cbxPlatformSelect.SelectedItem
                Case "NES"
                    lbxRomList.Items.Clear()
                    Dim filInfo As FileInfo
                    For Each fil As String In Directory.GetFiles(My.Settings.NES_ROM)
                        filInfo = New FileInfo(fil)
                        lbxRomList.Items.Add(filInfo.Name)
                    Next

                    picPlatform.Image = My.Resources.NES1
                Case "SNES"
                    lbxRomList.Items.Clear()
                    Dim filInfo As FileInfo
                    For Each fil As String In Directory.GetFiles(My.Settings.SNES_ROM)
                        filInfo = New FileInfo(fil)
                        lbxRomList.Items.Add(filInfo.Name)
                    Next
                    picPlatform.Image = My.Resources.SNES
                Case "GameBoy"
                    lbxRomList.Items.Clear()
                    Dim filInfo As FileInfo
                    For Each fil As String In Directory.GetFiles(My.Settings.GB_ROM)
                        filInfo = New FileInfo(fil)
                        lbxRomList.Items.Add(filInfo.Name)
                    Next
                    picPlatform.Image = My.Resources.GBA
            End Select
        Catch ex As Exception
            MsgBox("We were unable to load your game library. Please check your preferences.")
        End Try
        
    End Sub

    Private Sub lbxRomList_DoubleClick(sender As Object, e As EventArgs) Handles lbxRomList.DoubleClick
        launchGame()
    End Sub


    Sub launchGame()
        Try
            Select Case cbxPlatformSelect.SelectedItem
                Case "NES"
                    Dim selectedGame As String = """" + My.Settings.NES_ROM + "\" + lbxRomList.SelectedItem + """"
                    System.Diagnostics.Process.Start(My.Settings.NES_EMU, selectedGame)
                Case "SNES"
                    Dim selectedGame As String = """" + My.Settings.SNES_ROM + "\" + lbxRomList.SelectedItem + """"
                    System.Diagnostics.Process.Start(My.Settings.SNES_EMU, selectedGame)
                Case "GameBoy"
                    Dim selectedGame As String = """" + My.Settings.GB_ROM + "\" + lbxRomList.SelectedItem + """"
                    System.Diagnostics.Process.Start(My.Settings.GB_EMU, selectedGame)
            End Select
        Catch ex As Exception
            MsgBox("We were unable to launch your game. Are you sure you've set the correct paths in Edit > Preferences?")
        End Try

    End Sub

    Private Sub picPlatform_Click(sender As Object, e As EventArgs) Handles picPlatform.Click
        Select Case cbxPlatformSelect.SelectedItem
            Case "NES"
                System.Diagnostics.Process.Start("https://en.wikipedia.org/wiki/Nintendo_Entertainment_System")
            Case "SNES"
                System.Diagnostics.Process.Start("https://en.wikipedia.org/wiki/Super_Nintendo_Entertainment_System")
            Case "GameBoy"
                System.Diagnostics.Process.Start("https://en.wikipedia.org/wiki/Game_Boy")
        End Select
    End Sub

    Private Sub PreferencesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PreferencesToolStripMenuItem.Click
        Dim prefs As New Preferences
        prefs.Show()
    End Sub

    Private Sub EFE_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MsgBox("PLEASE NOTE THAT THIS SOFTWARE IS CURRENTLY IN AN ALPHA FRIENDS AND FAMILY STATE. BUGS CAN BE REPORTED TO KGHDAN@GMAIL.COM. THANKS FOR TESTING!")
        picPlatform.Image = My.Resources.DEF
        If My.Settings.FIRST_RUN = "YES" Then
            MsgBox("Please perform first-time setup.")
            Dim prefs As New Preferences
            prefs.ShowDialog()
        End If
    End Sub

    Private Sub btnLaunch_Click(sender As Object, e As EventArgs) Handles btnLaunch.Click
        If lbxRomList.SelectedItem = "" Then
            MsgBox("Please select an entry above to continue.")
        Else
            launchGame()
        End If
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        Dim about As New frmAbout
        about.ShowDialog()
    End Sub
End Class
