<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        lblPath = New Label()
        txtPath = New TextBox()
        FileToolStripMenuItem = New ToolStripMenuItem()
        NewToolStripMenuItem = New ToolStripMenuItem()
        GarisBatasToolStripMenuItem = New ToolStripMenuItem()
        ExitToolStripMenuItem = New ToolStripMenuItem()
        HelpToolStripMenuItem = New ToolStripMenuItem()
        HelpToolStripMenuItem1 = New ToolStripMenuItem()
        AboutToolStripMenuItem = New ToolStripMenuItem()
        MenuStrip1 = New MenuStrip()
        TimerWall = New Timer(components)
        StatusStrip1 = New StatusStrip()
        ToolStripStatusReady = New ToolStripStatusLabel()
        ToolStripStatusCurrent = New ToolStripStatusLabel()
        FolderBrowserDialog1 = New FolderBrowserDialog()
        TimerElapsed = New Timer(components)
        btnBrowse = New Button()
        lblInterval = New Label()
        clbWallpaper = New CheckedListBox()
        cbPreview = New CheckBox()
        Panel1 = New Panel()
        PictureBox1 = New PictureBox()
        cbInterval = New ComboBox()
        Label1 = New Label()
        btnRun = New Button()
        MenuStrip1.SuspendLayout()
        StatusStrip1.SuspendLayout()
        Panel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lblPath
        ' 
        lblPath.AutoSize = True
        lblPath.Location = New Point(25, 41)
        lblPath.Name = "lblPath"
        lblPath.Size = New Size(86, 20)
        lblPath.TabIndex = 2
        lblPath.Text = "Folder Path:"
        ' 
        ' txtPath
        ' 
        txtPath.Location = New Point(117, 38)
        txtPath.Name = "txtPath"
        txtPath.ReadOnly = True
        txtPath.Size = New Size(549, 27)
        txtPath.TabIndex = 3
        ' 
        ' FileToolStripMenuItem
        ' 
        FileToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {NewToolStripMenuItem, GarisBatasToolStripMenuItem, ExitToolStripMenuItem})
        FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        FileToolStripMenuItem.Size = New Size(46, 24)
        FileToolStripMenuItem.Text = "File"
        ' 
        ' NewToolStripMenuItem
        ' 
        NewToolStripMenuItem.Name = "NewToolStripMenuItem"
        NewToolStripMenuItem.Size = New Size(185, 26)
        NewToolStripMenuItem.Text = "New"
        ' 
        ' GarisBatasToolStripMenuItem
        ' 
        GarisBatasToolStripMenuItem.Name = "GarisBatasToolStripMenuItem"
        GarisBatasToolStripMenuItem.Size = New Size(185, 26)
        GarisBatasToolStripMenuItem.Text = "Garis batas (-)"
        ' 
        ' ExitToolStripMenuItem
        ' 
        ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        ExitToolStripMenuItem.Size = New Size(185, 26)
        ExitToolStripMenuItem.Text = "Exit"
        ' 
        ' HelpToolStripMenuItem
        ' 
        HelpToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {HelpToolStripMenuItem1, AboutToolStripMenuItem})
        HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        HelpToolStripMenuItem.Size = New Size(55, 24)
        HelpToolStripMenuItem.Text = "Help"
        ' 
        ' HelpToolStripMenuItem1
        ' 
        HelpToolStripMenuItem1.Name = "HelpToolStripMenuItem1"
        HelpToolStripMenuItem1.Size = New Size(133, 26)
        HelpToolStripMenuItem1.Text = "Help"
        ' 
        ' AboutToolStripMenuItem
        ' 
        AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        AboutToolStripMenuItem.Size = New Size(133, 26)
        AboutToolStripMenuItem.Text = "About"
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.ImageScalingSize = New Size(20, 20)
        MenuStrip1.Items.AddRange(New ToolStripItem() {FileToolStripMenuItem, HelpToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(800, 28)
        MenuStrip1.TabIndex = 1
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' StatusStrip1
        ' 
        StatusStrip1.ImageScalingSize = New Size(20, 20)
        StatusStrip1.Items.AddRange(New ToolStripItem() {ToolStripStatusReady, ToolStripStatusCurrent})
        StatusStrip1.Location = New Point(0, 424)
        StatusStrip1.Name = "StatusStrip1"
        StatusStrip1.Size = New Size(800, 26)
        StatusStrip1.TabIndex = 4
        StatusStrip1.Text = "StatusStrip1"
        ' 
        ' ToolStripStatusReady
        ' 
        ToolStripStatusReady.Name = "ToolStripStatusReady"
        ToolStripStatusReady.Size = New Size(50, 20)
        ToolStripStatusReady.Text = "Ready"
        ' 
        ' ToolStripStatusCurrent
        ' 
        ToolStripStatusCurrent.Name = "ToolStripStatusCurrent"
        ToolStripStatusCurrent.Size = New Size(172, 20)
        ToolStripStatusCurrent.Text = "Current Wallpaper: none."
        ' 
        ' FolderBrowserDialog1
        ' 
        ' 
        ' TimerElapsed
        ' 
        TimerElapsed.Interval = 1000
        ' 
        ' btnBrowse
        ' 
        btnBrowse.BackColor = SystemColors.ControlLight
        btnBrowse.Location = New Point(672, 41)
        btnBrowse.Name = "btnBrowse"
        btnBrowse.Size = New Size(59, 29)
        btnBrowse.TabIndex = 5
        btnBrowse.Text = "..."
        btnBrowse.UseVisualStyleBackColor = False
        ' 
        ' lblInterval
        ' 
        lblInterval.AutoSize = True
        lblInterval.Location = New Point(34, 91)
        lblInterval.Name = "lblInterval"
        lblInterval.Size = New Size(280, 20)
        lblInterval.TabIndex = 6
        lblInterval.Text = "Please select one or more pictures below"
        ' 
        ' clbWallpaper
        ' 
        clbWallpaper.FormattingEnabled = True
        clbWallpaper.Location = New Point(34, 114)
        clbWallpaper.Name = "clbWallpaper"
        clbWallpaper.Size = New Size(394, 290)
        clbWallpaper.TabIndex = 7
        ' 
        ' cbPreview
        ' 
        cbPreview.AutoSize = True
        cbPreview.Checked = True
        cbPreview.CheckState = CheckState.Checked
        cbPreview.Location = New Point(444, 104)
        cbPreview.Name = "cbPreview"
        cbPreview.Size = New Size(128, 24)
        cbPreview.TabIndex = 8
        cbPreview.Text = "Preview Image"
        cbPreview.UseVisualStyleBackColor = True
        ' 
        ' Panel1
        ' 
        Panel1.BorderStyle = BorderStyle.Fixed3D
        Panel1.Controls.Add(PictureBox1)
        Panel1.Location = New Point(444, 134)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(344, 201)
        Panel1.TabIndex = 9
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox1.Location = New Point(3, 3)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(334, 191)
        PictureBox1.TabIndex = 10
        PictureBox1.TabStop = False
        PictureBox1.Visible = False
        ' 
        ' cbInterval
        ' 
        cbInterval.FormattingEnabled = True
        cbInterval.Items.AddRange(New Object() {"10 secs", "30 secs", "1 minute"})
        cbInterval.Location = New Point(523, 341)
        cbInterval.Name = "cbInterval"
        cbInterval.Size = New Size(151, 28)
        cbInterval.TabIndex = 11
        cbInterval.Text = "Select First"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(459, 344)
        Label1.Name = "Label1"
        Label1.Size = New Size(58, 20)
        Label1.TabIndex = 12
        Label1.Text = "Interval"
        ' 
        ' btnRun
        ' 
        btnRun.Location = New Point(716, 344)
        btnRun.Name = "btnRun"
        btnRun.Size = New Size(72, 29)
        btnRun.TabIndex = 13
        btnRun.Text = "Run!"
        btnRun.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btnRun)
        Controls.Add(Label1)
        Controls.Add(cbInterval)
        Controls.Add(Panel1)
        Controls.Add(cbPreview)
        Controls.Add(clbWallpaper)
        Controls.Add(lblInterval)
        Controls.Add(btnBrowse)
        Controls.Add(StatusStrip1)
        Controls.Add(txtPath)
        Controls.Add(lblPath)
        Controls.Add(MenuStrip1)
        Name = "Form1"
        Text = "Wallpaper Changer"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        StatusStrip1.ResumeLayout(False)
        StatusStrip1.PerformLayout()
        Panel1.ResumeLayout(False)
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents lblPath As Label
    Friend WithEvents txtPath As TextBox
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NewToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GarisBatasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents TimerWall As Timer
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents ToolStripStatusReady As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusCurrent As ToolStripStatusLabel
    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
    Friend WithEvents TimerElapsed As Timer
    Friend WithEvents btnBrowse As Button
    Friend WithEvents lblInterval As Label
    Friend WithEvents clbWallpaper As CheckedListBox
    Friend WithEvents cbPreview As CheckBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents cbInterval As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnRun As Button

End Class
