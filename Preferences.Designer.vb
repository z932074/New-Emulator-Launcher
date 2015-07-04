<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Preferences
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.grpNes = New System.Windows.Forms.GroupBox()
        Me.btnNesRomPath = New System.Windows.Forms.Button()
        Me.txtNesRomPath = New System.Windows.Forms.TextBox()
        Me.btnNesEmulatorPath = New System.Windows.Forms.Button()
        Me.txtNesEmulatorPath = New System.Windows.Forms.TextBox()
        Me.btnPrefsOK = New System.Windows.Forms.Button()
        Me.btnPrefsCancel = New System.Windows.Forms.Button()
        Me.browseFolders = New System.Windows.Forms.FolderBrowserDialog()
        Me.chooseEmu = New System.Windows.Forms.OpenFileDialog()
        Me.grpSnes = New System.Windows.Forms.GroupBox()
        Me.btnSnesRomPath = New System.Windows.Forms.Button()
        Me.txtSnesRomPath = New System.Windows.Forms.TextBox()
        Me.btnSnesEmulatorPath = New System.Windows.Forms.Button()
        Me.txtSnesEmulatorPath = New System.Windows.Forms.TextBox()
        Me.grpGameBoy = New System.Windows.Forms.GroupBox()
        Me.btnGbRomPath = New System.Windows.Forms.Button()
        Me.txtGbRomPath = New System.Windows.Forms.TextBox()
        Me.btnGbEmulatorPath = New System.Windows.Forms.Button()
        Me.txtGbEmulatorPath = New System.Windows.Forms.TextBox()
        Me.grpNes.SuspendLayout()
        Me.grpSnes.SuspendLayout()
        Me.grpGameBoy.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpNes
        '
        Me.grpNes.Controls.Add(Me.btnNesRomPath)
        Me.grpNes.Controls.Add(Me.txtNesRomPath)
        Me.grpNes.Controls.Add(Me.btnNesEmulatorPath)
        Me.grpNes.Controls.Add(Me.txtNesEmulatorPath)
        Me.grpNes.Location = New System.Drawing.Point(7, 12)
        Me.grpNes.Name = "grpNes"
        Me.grpNes.Size = New System.Drawing.Size(393, 77)
        Me.grpNes.TabIndex = 0
        Me.grpNes.TabStop = False
        Me.grpNes.Text = "Nintendo Entertainment System:"
        '
        'btnNesRomPath
        '
        Me.btnNesRomPath.Location = New System.Drawing.Point(318, 45)
        Me.btnNesRomPath.Name = "btnNesRomPath"
        Me.btnNesRomPath.Size = New System.Drawing.Size(70, 20)
        Me.btnNesRomPath.TabIndex = 3
        Me.btnNesRomPath.Text = "Browse..."
        Me.btnNesRomPath.UseVisualStyleBackColor = True
        '
        'txtNesRomPath
        '
        Me.txtNesRomPath.Location = New System.Drawing.Point(6, 45)
        Me.txtNesRomPath.Name = "txtNesRomPath"
        Me.txtNesRomPath.Size = New System.Drawing.Size(306, 20)
        Me.txtNesRomPath.TabIndex = 2
        Me.txtNesRomPath.Text = "Please choose your NES ROMS Path"
        '
        'btnNesEmulatorPath
        '
        Me.btnNesEmulatorPath.Location = New System.Drawing.Point(318, 19)
        Me.btnNesEmulatorPath.Name = "btnNesEmulatorPath"
        Me.btnNesEmulatorPath.Size = New System.Drawing.Size(70, 20)
        Me.btnNesEmulatorPath.TabIndex = 1
        Me.btnNesEmulatorPath.Text = "Browse..."
        Me.btnNesEmulatorPath.UseVisualStyleBackColor = True
        '
        'txtNesEmulatorPath
        '
        Me.txtNesEmulatorPath.Location = New System.Drawing.Point(6, 19)
        Me.txtNesEmulatorPath.Name = "txtNesEmulatorPath"
        Me.txtNesEmulatorPath.Size = New System.Drawing.Size(306, 20)
        Me.txtNesEmulatorPath.TabIndex = 0
        Me.txtNesEmulatorPath.Text = "Please choose your NES Emulator"
        '
        'btnPrefsOK
        '
        Me.btnPrefsOK.Location = New System.Drawing.Point(116, 261)
        Me.btnPrefsOK.Name = "btnPrefsOK"
        Me.btnPrefsOK.Size = New System.Drawing.Size(75, 23)
        Me.btnPrefsOK.TabIndex = 1
        Me.btnPrefsOK.Text = "Save"
        Me.btnPrefsOK.UseVisualStyleBackColor = True
        '
        'btnPrefsCancel
        '
        Me.btnPrefsCancel.Location = New System.Drawing.Point(215, 261)
        Me.btnPrefsCancel.Name = "btnPrefsCancel"
        Me.btnPrefsCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnPrefsCancel.TabIndex = 2
        Me.btnPrefsCancel.Text = "Cancel"
        Me.btnPrefsCancel.UseVisualStyleBackColor = True
        '
        'chooseEmu
        '
        Me.chooseEmu.FileName = "OpenFileDialog1"
        '
        'grpSnes
        '
        Me.grpSnes.Controls.Add(Me.btnSnesRomPath)
        Me.grpSnes.Controls.Add(Me.txtSnesRomPath)
        Me.grpSnes.Controls.Add(Me.btnSnesEmulatorPath)
        Me.grpSnes.Controls.Add(Me.txtSnesEmulatorPath)
        Me.grpSnes.Location = New System.Drawing.Point(7, 95)
        Me.grpSnes.Name = "grpSnes"
        Me.grpSnes.Size = New System.Drawing.Size(393, 77)
        Me.grpSnes.TabIndex = 3
        Me.grpSnes.TabStop = False
        Me.grpSnes.Text = "Super Nintendo Entertainment System:"
        '
        'btnSnesRomPath
        '
        Me.btnSnesRomPath.Location = New System.Drawing.Point(318, 45)
        Me.btnSnesRomPath.Name = "btnSnesRomPath"
        Me.btnSnesRomPath.Size = New System.Drawing.Size(70, 20)
        Me.btnSnesRomPath.TabIndex = 3
        Me.btnSnesRomPath.Text = "Browse..."
        Me.btnSnesRomPath.UseVisualStyleBackColor = True
        '
        'txtSnesRomPath
        '
        Me.txtSnesRomPath.Location = New System.Drawing.Point(6, 45)
        Me.txtSnesRomPath.Name = "txtSnesRomPath"
        Me.txtSnesRomPath.Size = New System.Drawing.Size(306, 20)
        Me.txtSnesRomPath.TabIndex = 2
        Me.txtSnesRomPath.Text = "Please choose your SNES ROMS Path"
        '
        'btnSnesEmulatorPath
        '
        Me.btnSnesEmulatorPath.Location = New System.Drawing.Point(318, 19)
        Me.btnSnesEmulatorPath.Name = "btnSnesEmulatorPath"
        Me.btnSnesEmulatorPath.Size = New System.Drawing.Size(70, 20)
        Me.btnSnesEmulatorPath.TabIndex = 1
        Me.btnSnesEmulatorPath.Text = "Browse..."
        Me.btnSnesEmulatorPath.UseVisualStyleBackColor = True
        '
        'txtSnesEmulatorPath
        '
        Me.txtSnesEmulatorPath.Location = New System.Drawing.Point(6, 19)
        Me.txtSnesEmulatorPath.Name = "txtSnesEmulatorPath"
        Me.txtSnesEmulatorPath.Size = New System.Drawing.Size(306, 20)
        Me.txtSnesEmulatorPath.TabIndex = 0
        Me.txtSnesEmulatorPath.Text = "Please choose your SNES Emulator"
        '
        'grpGameBoy
        '
        Me.grpGameBoy.Controls.Add(Me.btnGbRomPath)
        Me.grpGameBoy.Controls.Add(Me.txtGbRomPath)
        Me.grpGameBoy.Controls.Add(Me.btnGbEmulatorPath)
        Me.grpGameBoy.Controls.Add(Me.txtGbEmulatorPath)
        Me.grpGameBoy.Location = New System.Drawing.Point(7, 178)
        Me.grpGameBoy.Name = "grpGameBoy"
        Me.grpGameBoy.Size = New System.Drawing.Size(393, 77)
        Me.grpGameBoy.TabIndex = 4
        Me.grpGameBoy.TabStop = False
        Me.grpGameBoy.Text = "GameBoy Systems"
        '
        'btnGbRomPath
        '
        Me.btnGbRomPath.Location = New System.Drawing.Point(318, 45)
        Me.btnGbRomPath.Name = "btnGbRomPath"
        Me.btnGbRomPath.Size = New System.Drawing.Size(70, 20)
        Me.btnGbRomPath.TabIndex = 3
        Me.btnGbRomPath.Text = "Browse..."
        Me.btnGbRomPath.UseVisualStyleBackColor = True
        '
        'txtGbRomPath
        '
        Me.txtGbRomPath.Location = New System.Drawing.Point(6, 45)
        Me.txtGbRomPath.Name = "txtGbRomPath"
        Me.txtGbRomPath.Size = New System.Drawing.Size(306, 20)
        Me.txtGbRomPath.TabIndex = 2
        Me.txtGbRomPath.Text = "Please choose your GameBoy ROMS Path"
        '
        'btnGbEmulatorPath
        '
        Me.btnGbEmulatorPath.Location = New System.Drawing.Point(318, 19)
        Me.btnGbEmulatorPath.Name = "btnGbEmulatorPath"
        Me.btnGbEmulatorPath.Size = New System.Drawing.Size(70, 20)
        Me.btnGbEmulatorPath.TabIndex = 1
        Me.btnGbEmulatorPath.Text = "Browse..."
        Me.btnGbEmulatorPath.UseVisualStyleBackColor = True
        '
        'txtGbEmulatorPath
        '
        Me.txtGbEmulatorPath.Location = New System.Drawing.Point(6, 19)
        Me.txtGbEmulatorPath.Name = "txtGbEmulatorPath"
        Me.txtGbEmulatorPath.Size = New System.Drawing.Size(306, 20)
        Me.txtGbEmulatorPath.TabIndex = 0
        Me.txtGbEmulatorPath.Text = "Please choose your GameBoy Emulator"
        '
        'Preferences
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(407, 303)
        Me.Controls.Add(Me.grpGameBoy)
        Me.Controls.Add(Me.grpSnes)
        Me.Controls.Add(Me.btnPrefsCancel)
        Me.Controls.Add(Me.btnPrefsOK)
        Me.Controls.Add(Me.grpNes)
        Me.Name = "Preferences"
        Me.Text = "Preferences"
        Me.grpNes.ResumeLayout(False)
        Me.grpNes.PerformLayout()
        Me.grpSnes.ResumeLayout(False)
        Me.grpSnes.PerformLayout()
        Me.grpGameBoy.ResumeLayout(False)
        Me.grpGameBoy.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grpNes As System.Windows.Forms.GroupBox
    Friend WithEvents btnNesEmulatorPath As System.Windows.Forms.Button
    Friend WithEvents txtNesEmulatorPath As System.Windows.Forms.TextBox
    Friend WithEvents btnNesRomPath As System.Windows.Forms.Button
    Friend WithEvents txtNesRomPath As System.Windows.Forms.TextBox
    Friend WithEvents btnPrefsOK As System.Windows.Forms.Button
    Friend WithEvents btnPrefsCancel As System.Windows.Forms.Button
    Friend WithEvents browseFolders As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents chooseEmu As System.Windows.Forms.OpenFileDialog
    Friend WithEvents grpSnes As System.Windows.Forms.GroupBox
    Friend WithEvents btnSnesRomPath As System.Windows.Forms.Button
    Friend WithEvents txtSnesRomPath As System.Windows.Forms.TextBox
    Friend WithEvents btnSnesEmulatorPath As System.Windows.Forms.Button
    Friend WithEvents txtSnesEmulatorPath As System.Windows.Forms.TextBox
    Friend WithEvents grpGameBoy As System.Windows.Forms.GroupBox
    Friend WithEvents btnGbRomPath As System.Windows.Forms.Button
    Friend WithEvents txtGbRomPath As System.Windows.Forms.TextBox
    Friend WithEvents btnGbEmulatorPath As System.Windows.Forms.Button
    Friend WithEvents txtGbEmulatorPath As System.Windows.Forms.TextBox
End Class
