<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EFE
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EFE))
        Me.cbxPlatformSelect = New System.Windows.Forms.ComboBox()
        Me.lbxRomList = New System.Windows.Forms.ListBox()
        Me.btnLaunch = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PreferencesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblPlatformSelect = New System.Windows.Forms.Label()
        Me.picPlatform = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.picPlatform, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cbxPlatformSelect
        '
        Me.cbxPlatformSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxPlatformSelect.FormattingEnabled = True
        Me.cbxPlatformSelect.Items.AddRange(New Object() {"NES", "SNES", "GameBoy"})
        Me.cbxPlatformSelect.Location = New System.Drawing.Point(3, 43)
        Me.cbxPlatformSelect.Name = "cbxPlatformSelect"
        Me.cbxPlatformSelect.Size = New System.Drawing.Size(370, 21)
        Me.cbxPlatformSelect.TabIndex = 0
        Me.cbxPlatformSelect.UseWaitCursor = True
        '
        'lbxRomList
        '
        Me.lbxRomList.FormattingEnabled = True
        Me.lbxRomList.Location = New System.Drawing.Point(3, 70)
        Me.lbxRomList.Name = "lbxRomList"
        Me.lbxRomList.Size = New System.Drawing.Size(370, 212)
        Me.lbxRomList.TabIndex = 1
        Me.lbxRomList.UseWaitCursor = True
        '
        'btnLaunch
        '
        Me.btnLaunch.Location = New System.Drawing.Point(3, 289)
        Me.btnLaunch.Name = "btnLaunch"
        Me.btnLaunch.Size = New System.Drawing.Size(696, 33)
        Me.btnLaunch.TabIndex = 2
        Me.btnLaunch.Text = "Launch!"
        Me.btnLaunch.UseVisualStyleBackColor = True
        Me.btnLaunch.UseWaitCursor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.EditToolStripMenuItem, Me.AboutToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(703, 24)
        Me.MenuStrip1.TabIndex = 3
        Me.MenuStrip1.Text = "MenuStrip1"
        Me.MenuStrip1.UseWaitCursor = True
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(92, 22)
        Me.ExitToolStripMenuItem.Text = "E&xit"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PreferencesToolStripMenuItem})
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(39, 20)
        Me.EditToolStripMenuItem.Text = "&Edit"
        '
        'PreferencesToolStripMenuItem
        '
        Me.PreferencesToolStripMenuItem.Name = "PreferencesToolStripMenuItem"
        Me.PreferencesToolStripMenuItem.Size = New System.Drawing.Size(135, 22)
        Me.PreferencesToolStripMenuItem.Text = "&Preferences"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(52, 20)
        Me.AboutToolStripMenuItem.Text = "&About"
        '
        'lblPlatformSelect
        '
        Me.lblPlatformSelect.AutoSize = True
        Me.lblPlatformSelect.Location = New System.Drawing.Point(3, 27)
        Me.lblPlatformSelect.Name = "lblPlatformSelect"
        Me.lblPlatformSelect.Size = New System.Drawing.Size(90, 13)
        Me.lblPlatformSelect.TabIndex = 4
        Me.lblPlatformSelect.Text = "Select a Platform:"
        Me.lblPlatformSelect.UseWaitCursor = True
        '
        'picPlatform
        '
        Me.picPlatform.InitialImage = CType(resources.GetObject("picPlatform.InitialImage"), System.Drawing.Image)
        Me.picPlatform.Location = New System.Drawing.Point(379, 43)
        Me.picPlatform.Name = "picPlatform"
        Me.picPlatform.Size = New System.Drawing.Size(320, 240)
        Me.picPlatform.TabIndex = 5
        Me.picPlatform.TabStop = False
        Me.picPlatform.UseWaitCursor = True
        '
        'EFE
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(703, 328)
        Me.Controls.Add(Me.picPlatform)
        Me.Controls.Add(Me.lblPlatformSelect)
        Me.Controls.Add(Me.btnLaunch)
        Me.Controls.Add(Me.lbxRomList)
        Me.Controls.Add(Me.cbxPlatformSelect)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "EFE"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Emulator Front End: v0.1.1.0"
        Me.UseWaitCursor = True
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.picPlatform, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cbxPlatformSelect As System.Windows.Forms.ComboBox
    Friend WithEvents lbxRomList As System.Windows.Forms.ListBox
    Friend WithEvents btnLaunch As System.Windows.Forms.Button
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PreferencesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lblPlatformSelect As System.Windows.Forms.Label
    Friend WithEvents picPlatform As System.Windows.Forms.PictureBox

End Class
