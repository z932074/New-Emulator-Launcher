Imports System
Imports System.IO
Imports System.Text
Imports System.Configuration
Imports System.Collections.Specialized

Public Class Preferences

    Private Sub txtNesEmulatorPath_Click(sender As Object, e As EventArgs) Handles txtNesEmulatorPath.Click
        If txtNesEmulatorPath.Text = "Please choose your NES Emulator" Then
            txtNesEmulatorPath.Clear()
        End If

    End Sub

    Private Sub btnNesEmulatorPath_Click(sender As Object, e As EventArgs) Handles btnNesEmulatorPath.Click
        If chooseEmu.ShowDialog() = DialogResult.OK Then
            txtNesEmulatorPath.Text = chooseEmu.FileName
        Else
            txtNesEmulatorPath.Text = "Please choose your NES Emulator"
        End If
    End Sub

    Private Sub btnNesRomPath_Click(sender As Object, e As EventArgs) Handles btnNesRomPath.Click
        If browseFolders.ShowDialog() = Windows.Forms.DialogResult.OK Then
            txtNesRomPath.Text = browseFolders.SelectedPath
        Else
            txtNesRomPath.Text = "Please choose your NES ROMS Path"
        End If
    End Sub

    Private Sub txtNesRomPath_Click(sender As Object, e As EventArgs) Handles txtNesRomPath.Click
        If txtNesRomPath.Text = "Please choose your NES ROMS Path" Then
            txtNesRomPath.Clear()
        End If
    End Sub

    Private Sub btnPrefsOK_Click(sender As Object, e As EventArgs) Handles btnPrefsOK.Click
        My.Settings.NES_EMU = txtNesEmulatorPath.Text
        My.Settings.NES_ROM = txtNesRomPath.Text
        My.Settings.SNES_EMU = txtSnesEmulatorPath.Text
        My.Settings.SNES_ROM = txtSnesRomPath.Text
        My.Settings.GB_EMU = txtGbEmulatorPath.Text
        My.Settings.GB_ROM = txtGbRomPath.Text
        My.Settings.FIRST_RUN = "NO"
        Me.Close()
    End Sub

    Private Sub btnPrefsCancel_Click(sender As Object, e As EventArgs) Handles btnPrefsCancel.Click
        Me.Close()
    End Sub

    Private Sub btnSnesEmulatorPath_Click(sender As Object, e As EventArgs) Handles btnSnesEmulatorPath.Click
        If chooseEmu.ShowDialog() = DialogResult.OK Then
            txtSnesEmulatorPath.Text = chooseEmu.FileName
        Else
            txtSnesEmulatorPath.Text = "Please choose your SNES Emulator"
        End If
    End Sub

    Private Sub btnSnesRomPath_Click(sender As Object, e As EventArgs) Handles btnSnesRomPath.Click
        If browseFolders.ShowDialog() = Windows.Forms.DialogResult.OK Then
            txtSnesRomPath.Text = browseFolders.SelectedPath
        Else
            txtSnesRomPath.Text = "Please choose your SNES ROMS Path"
        End If
    End Sub

    Private Sub btnGbEmulatorPath_Click(sender As Object, e As EventArgs) Handles btnGbEmulatorPath.Click
        If chooseEmu.ShowDialog() = DialogResult.OK Then
            txtGbEmulatorPath.Text = chooseEmu.FileName
        Else
            txtGbEmulatorPath.Text = "Please choose your GameBoy Emulator"
        End If
    End Sub

    Private Sub btnGbRomPath_Click(sender As Object, e As EventArgs) Handles btnGbRomPath.Click
        If browseFolders.ShowDialog() = Windows.Forms.DialogResult.OK Then
            txtGbRomPath.Text = browseFolders.SelectedPath
        Else
            txtGbRomPath.Text = "Please choose your GameBoy ROMS Path"
        End If
    End Sub

    Private Sub txtSnesEmulatorPath_TextChanged(sender As Object, e As EventArgs) Handles txtSnesEmulatorPath.TextChanged
        If txtSnesEmulatorPath.Text = "Please choose your SNES Emulator." Then
            txtSnesEmulatorPath.Clear()
        End If
    End Sub

    Private Sub txtSnesRomPath_TextChanged(sender As Object, e As EventArgs) Handles txtSnesRomPath.TextChanged
        If txtSnesRomPath.Text = "Please choose your SNES Emulator." Then
            txtSnesRomPath.Clear()
        End If
    End Sub

    Private Sub txtGbEmulatorPath_TextChanged(sender As Object, e As EventArgs) Handles txtGbEmulatorPath.TextChanged
        If txtGbEmulatorPath.Text = "Please choose your GameBoy Emulator." Then
            txtGbEmulatorPath.Clear()
        End If
    End Sub

    Private Sub txtGbRomPath_TextChanged(sender As Object, e As EventArgs) Handles txtGbRomPath.TextChanged
        If txtGbRomPath.Text = "Please choose your SNES Emulator." Then
            txtGbRomPath.Clear()
        End If
    End Sub

    Private Sub Preferences_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtNesEmulatorPath.Text = My.Settings.NES_EMU
        txtNesRomPath.Text = My.Settings.NES_ROM
        txtSnesEmulatorPath.Text = My.Settings.SNES_EMU
        txtSnesRomPath.Text = My.Settings.SNES_ROM
        txtGbEmulatorPath.Text = My.Settings.GB_EMU
        txtGbRomPath.Text = My.Settings.GB_ROM
    End Sub
End Class