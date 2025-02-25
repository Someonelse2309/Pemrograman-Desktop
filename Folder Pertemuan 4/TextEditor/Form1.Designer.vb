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
        menuStrip1 = New MenuStrip()
        FileToolStripMenuItem = New ToolStripMenuItem()
        newToolStripMenuItem = New ToolStripMenuItem()
        openToolStripMenuItem = New ToolStripMenuItem()
        saveToolStripMenuItem = New ToolStripMenuItem()
        saveasToolStripMenuItem = New ToolStripMenuItem()
        pageSetupToolStripMenuItem = New ToolStripMenuItem()
        printToolStripMenuItem = New ToolStripMenuItem()
        closeToolStripMenuItem = New ToolStripMenuItem()
        exitToolStripMenuItem = New ToolStripMenuItem()
        EditToolStripMenuItem = New ToolStripMenuItem()
        undoToolStripMenuItem = New ToolStripMenuItem()
        cutToolStripMenuItem = New ToolStripMenuItem()
        copyToolStripMenuItem = New ToolStripMenuItem()
        pasteToolStripMenuItem = New ToolStripMenuItem()
        findToolStripMenuItem = New ToolStripMenuItem()
        findNextToolStripMenuItem = New ToolStripMenuItem()
        replaceToolStripMenuItem = New ToolStripMenuItem()
        goToToolStripMenuItem = New ToolStripMenuItem()
        selectAllToolStripMenuItem = New ToolStripMenuItem()
        insertDateTimeToolStripMenuItem = New ToolStripMenuItem()
        FormatToolStripMenuItem = New ToolStripMenuItem()
        wordWrapToolStripMenuItem = New ToolStripMenuItem()
        fontToolStripMenuItem = New ToolStripMenuItem()
        ViewToolStripMenuItem = New ToolStripMenuItem()
        statusBarToolStripMenuItem = New ToolStripMenuItem()
        AboutToolStripMenuItem = New ToolStripMenuItem()
        helpToolStripMenuItem = New ToolStripMenuItem()
        AboutNotepadKuToolStripMenuItem = New ToolStripMenuItem()
        statusStrip1 = New StatusStrip()
        toolStripStatusReady = New ToolStripStatusLabel()
        toolStripStatusLine = New ToolStripStatusLabel()
        insertStripStatus = New ToolStripStatusLabel()
        capsStripStatus = New ToolStripStatusLabel()
        numStripStatus = New ToolStripStatusLabel()
        openFileDialog1 = New OpenFileDialog()
        fontDialog1 = New FontDialog()
        printDialog1 = New PrintDialog()
        pageSetupDialog1 = New PageSetupDialog()
        saveFileDialog1 = New SaveFileDialog()
        PrintDocument1 = New Printing.PrintDocument()
        txtNotepad = New TextBox()
        menuStrip1.SuspendLayout()
        statusStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' menuStrip1
        ' 
        menuStrip1.ImageScalingSize = New Size(28, 28)
        menuStrip1.Items.AddRange(New ToolStripItem() {FileToolStripMenuItem, EditToolStripMenuItem, FormatToolStripMenuItem, ViewToolStripMenuItem, AboutToolStripMenuItem})
        menuStrip1.Location = New Point(0, 0)
        menuStrip1.Name = "menuStrip1"
        menuStrip1.Size = New Size(800, 38)
        menuStrip1.TabIndex = 0
        menuStrip1.Text = "MenuStrip1"
        ' 
        ' FileToolStripMenuItem
        ' 
        FileToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {newToolStripMenuItem, openToolStripMenuItem, saveToolStripMenuItem, saveasToolStripMenuItem, pageSetupToolStripMenuItem, printToolStripMenuItem, closeToolStripMenuItem, exitToolStripMenuItem})
        FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        FileToolStripMenuItem.Size = New Size(62, 34)
        FileToolStripMenuItem.Text = "&File"
        ' 
        ' newToolStripMenuItem
        ' 
        newToolStripMenuItem.Font = New Font("Segoe UI", 9F)
        newToolStripMenuItem.Name = "newToolStripMenuItem"
        newToolStripMenuItem.Size = New Size(235, 40)
        newToolStripMenuItem.Text = "&New"
        ' 
        ' openToolStripMenuItem
        ' 
        openToolStripMenuItem.Name = "openToolStripMenuItem"
        openToolStripMenuItem.Size = New Size(235, 40)
        openToolStripMenuItem.Text = "&Open"
        ' 
        ' saveToolStripMenuItem
        ' 
        saveToolStripMenuItem.Name = "saveToolStripMenuItem"
        saveToolStripMenuItem.Size = New Size(235, 40)
        saveToolStripMenuItem.Text = "&Save"
        ' 
        ' saveasToolStripMenuItem
        ' 
        saveasToolStripMenuItem.Name = "saveasToolStripMenuItem"
        saveasToolStripMenuItem.Size = New Size(235, 40)
        saveasToolStripMenuItem.Text = "&Save as..."
        ' 
        ' pageSetupToolStripMenuItem
        ' 
        pageSetupToolStripMenuItem.Name = "pageSetupToolStripMenuItem"
        pageSetupToolStripMenuItem.Size = New Size(235, 40)
        pageSetupToolStripMenuItem.Text = "&Page Setup"
        ' 
        ' printToolStripMenuItem
        ' 
        printToolStripMenuItem.Name = "printToolStripMenuItem"
        printToolStripMenuItem.Size = New Size(235, 40)
        printToolStripMenuItem.Text = "&Print"
        ' 
        ' closeToolStripMenuItem
        ' 
        closeToolStripMenuItem.Name = "closeToolStripMenuItem"
        closeToolStripMenuItem.Size = New Size(235, 40)
        closeToolStripMenuItem.Text = "&Close"
        ' 
        ' exitToolStripMenuItem
        ' 
        exitToolStripMenuItem.Name = "exitToolStripMenuItem"
        exitToolStripMenuItem.Size = New Size(235, 40)
        exitToolStripMenuItem.Text = "&Exit"
        ' 
        ' EditToolStripMenuItem
        ' 
        EditToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {undoToolStripMenuItem, cutToolStripMenuItem, copyToolStripMenuItem, pasteToolStripMenuItem, findToolStripMenuItem, findNextToolStripMenuItem, replaceToolStripMenuItem, goToToolStripMenuItem, selectAllToolStripMenuItem, insertDateTimeToolStripMenuItem})
        EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        EditToolStripMenuItem.Size = New Size(66, 34)
        EditToolStripMenuItem.Text = "&Edit"
        ' 
        ' undoToolStripMenuItem
        ' 
        undoToolStripMenuItem.Name = "undoToolStripMenuItem"
        undoToolStripMenuItem.Size = New Size(284, 40)
        undoToolStripMenuItem.Text = "&Undo"
        ' 
        ' cutToolStripMenuItem
        ' 
        cutToolStripMenuItem.Name = "cutToolStripMenuItem"
        cutToolStripMenuItem.Size = New Size(284, 40)
        cutToolStripMenuItem.Text = "&Cut"
        ' 
        ' copyToolStripMenuItem
        ' 
        copyToolStripMenuItem.Name = "copyToolStripMenuItem"
        copyToolStripMenuItem.Size = New Size(284, 40)
        copyToolStripMenuItem.Text = "&Copy"
        ' 
        ' pasteToolStripMenuItem
        ' 
        pasteToolStripMenuItem.Name = "pasteToolStripMenuItem"
        pasteToolStripMenuItem.Size = New Size(284, 40)
        pasteToolStripMenuItem.Text = "&Paste"
        ' 
        ' findToolStripMenuItem
        ' 
        findToolStripMenuItem.Name = "findToolStripMenuItem"
        findToolStripMenuItem.Size = New Size(284, 40)
        findToolStripMenuItem.Text = "&Find"
        ' 
        ' findNextToolStripMenuItem
        ' 
        findNextToolStripMenuItem.Name = "findNextToolStripMenuItem"
        findNextToolStripMenuItem.Size = New Size(284, 40)
        findNextToolStripMenuItem.Text = "&Find Next"
        ' 
        ' replaceToolStripMenuItem
        ' 
        replaceToolStripMenuItem.Name = "replaceToolStripMenuItem"
        replaceToolStripMenuItem.Size = New Size(284, 40)
        replaceToolStripMenuItem.Text = "&Replace"
        ' 
        ' goToToolStripMenuItem
        ' 
        goToToolStripMenuItem.Name = "goToToolStripMenuItem"
        goToToolStripMenuItem.Size = New Size(284, 40)
        goToToolStripMenuItem.Text = "&Go To"
        ' 
        ' selectAllToolStripMenuItem
        ' 
        selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem"
        selectAllToolStripMenuItem.Size = New Size(284, 40)
        selectAllToolStripMenuItem.Text = "&Select All"
        ' 
        ' insertDateTimeToolStripMenuItem
        ' 
        insertDateTimeToolStripMenuItem.Name = "insertDateTimeToolStripMenuItem"
        insertDateTimeToolStripMenuItem.Size = New Size(284, 40)
        insertDateTimeToolStripMenuItem.Text = "&Insert Date Time"
        ' 
        ' FormatToolStripMenuItem
        ' 
        FormatToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {wordWrapToolStripMenuItem, fontToolStripMenuItem})
        FormatToolStripMenuItem.Name = "FormatToolStripMenuItem"
        FormatToolStripMenuItem.Size = New Size(96, 34)
        FormatToolStripMenuItem.Text = "&Format"
        ' 
        ' wordWrapToolStripMenuItem
        ' 
        wordWrapToolStripMenuItem.Name = "wordWrapToolStripMenuItem"
        wordWrapToolStripMenuItem.Size = New Size(232, 40)
        wordWrapToolStripMenuItem.Text = "&Word wrap"
        ' 
        ' fontToolStripMenuItem
        ' 
        fontToolStripMenuItem.Name = "fontToolStripMenuItem"
        fontToolStripMenuItem.Size = New Size(232, 40)
        fontToolStripMenuItem.Text = "&Font"
        ' 
        ' ViewToolStripMenuItem
        ' 
        ViewToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {statusBarToolStripMenuItem})
        ViewToolStripMenuItem.Name = "ViewToolStripMenuItem"
        ViewToolStripMenuItem.Size = New Size(75, 34)
        ViewToolStripMenuItem.Text = "&View"
        ' 
        ' statusBarToolStripMenuItem
        ' 
        statusBarToolStripMenuItem.Name = "statusBarToolStripMenuItem"
        statusBarToolStripMenuItem.Size = New Size(223, 40)
        statusBarToolStripMenuItem.Text = "&Status Bar"
        ' 
        ' AboutToolStripMenuItem
        ' 
        AboutToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {helpToolStripMenuItem, AboutNotepadKuToolStripMenuItem})
        AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        AboutToolStripMenuItem.Size = New Size(88, 34)
        AboutToolStripMenuItem.Text = "&About"
        ' 
        ' helpToolStripMenuItem
        ' 
        helpToolStripMenuItem.Name = "helpToolStripMenuItem"
        helpToolStripMenuItem.Size = New Size(315, 40)
        helpToolStripMenuItem.Text = "&Help"
        ' 
        ' AboutNotepadKuToolStripMenuItem
        ' 
        AboutNotepadKuToolStripMenuItem.Name = "AboutNotepadKuToolStripMenuItem"
        AboutNotepadKuToolStripMenuItem.Size = New Size(315, 40)
        AboutNotepadKuToolStripMenuItem.Text = "&About NotepadKu"
        ' 
        ' statusStrip1
        ' 
        statusStrip1.ImageScalingSize = New Size(28, 28)
        statusStrip1.Items.AddRange(New ToolStripItem() {toolStripStatusReady, toolStripStatusLine, insertStripStatus, capsStripStatus, numStripStatus})
        statusStrip1.Location = New Point(0, 407)
        statusStrip1.Name = "statusStrip1"
        statusStrip1.Size = New Size(800, 43)
        statusStrip1.TabIndex = 1
        statusStrip1.Text = "StatusStrip1"
        ' 
        ' toolStripStatusReady
        ' 
        toolStripStatusReady.Name = "toolStripStatusReady"
        toolStripStatusReady.Size = New Size(74, 34)
        toolStripStatusReady.Text = "Ready."
        ' 
        ' toolStripStatusLine
        ' 
        toolStripStatusLine.BorderSides = ToolStripStatusLabelBorderSides.Left Or ToolStripStatusLabelBorderSides.Right
        toolStripStatusLine.BorderStyle = Border3DStyle.Etched
        toolStripStatusLine.Name = "toolStripStatusLine"
        toolStripStatusLine.Size = New Size(77, 34)
        toolStripStatusLine.Text = "Line: 1"
        ' 
        ' insertStripStatus
        ' 
        insertStripStatus.BorderSides = ToolStripStatusLabelBorderSides.Right
        insertStripStatus.BorderStyle = Border3DStyle.Etched
        insertStripStatus.Enabled = False
        insertStripStatus.Name = "insertStripStatus"
        insertStripStatus.Size = New Size(50, 34)
        insertStripStatus.Text = "INS"
        ' 
        ' capsStripStatus
        ' 
        capsStripStatus.BorderSides = ToolStripStatusLabelBorderSides.Right
        capsStripStatus.BorderStyle = Border3DStyle.Etched
        capsStripStatus.Enabled = False
        capsStripStatus.Name = "capsStripStatus"
        capsStripStatus.Size = New Size(67, 34)
        capsStripStatus.Text = "CAPS"
        ' 
        ' numStripStatus
        ' 
        numStripStatus.BorderSides = ToolStripStatusLabelBorderSides.Right
        numStripStatus.BorderStyle = Border3DStyle.Etched
        numStripStatus.Enabled = False
        numStripStatus.Name = "numStripStatus"
        numStripStatus.Size = New Size(66, 34)
        numStripStatus.Text = "NUM"
        ' 
        ' openFileDialog1
        ' 
        openFileDialog1.DefaultExt = "*.txt"
        openFileDialog1.FileName = "Untitled"
        openFileDialog1.Filter = "Text File | *.txt | All FIles | *.*"
        openFileDialog1.Title = "Open File Text"
        ' 
        ' printDialog1
        ' 
        printDialog1.UseEXDialog = True
        ' 
        ' pageSetupDialog1
        ' 
        pageSetupDialog1.EnableMetric = True
        ' 
        ' saveFileDialog1
        ' 
        saveFileDialog1.DefaultExt = "*.txt"
        saveFileDialog1.FileName = "Untitled.txt"
        saveFileDialog1.Filter = "Text File | *.txt | All Files | *.*"
        saveFileDialog1.Title = "Save File Text As"
        ' 
        ' PrintDocument1
        ' 
        ' 
        ' txtNotepad
        ' 
        txtNotepad.AcceptsReturn = True
        txtNotepad.AcceptsTab = True
        txtNotepad.AllowDrop = True
        txtNotepad.Dock = DockStyle.Fill
        txtNotepad.Location = New Point(0, 38)
        txtNotepad.Multiline = True
        txtNotepad.Name = "txtNotepad"
        txtNotepad.ScrollBars = ScrollBars.Both
        txtNotepad.Size = New Size(800, 369)
        txtNotepad.TabIndex = 2
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(12F, 30F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(txtNotepad)
        Controls.Add(statusStrip1)
        Controls.Add(menuStrip1)
        KeyPreview = True
        MainMenuStrip = menuStrip1
        Name = "Form1"
        Text = "NotepadKu"
        menuStrip1.ResumeLayout(False)
        menuStrip1.PerformLayout()
        statusStrip1.ResumeLayout(False)
        statusStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents menuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FormatToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ViewToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents newToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents openToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents saveToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents saveasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents pageSetupToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents printToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents closeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents exitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents undoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents cutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents copyToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents pasteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents findToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents findNextToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents replaceToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents goToToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents selectAllToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents insertDateTimeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents wordWrapToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents fontToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents statusBarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents helpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutNotepadKuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents statusStrip1 As StatusStrip
    Friend WithEvents toolStripStatusReady As ToolStripStatusLabel
    Friend WithEvents toolStripStatusLine As ToolStripStatusLabel
    Friend WithEvents insertStripStatus As ToolStripStatusLabel
    Friend WithEvents capsStripStatus As ToolStripStatusLabel
    Friend WithEvents numStripStatus As ToolStripStatusLabel
    Friend WithEvents openFileDialog1 As OpenFileDialog
    Friend WithEvents fontDialog1 As FontDialog
    Friend WithEvents printDialog1 As PrintDialog
    Friend WithEvents pageSetupDialog1 As PageSetupDialog
    Friend WithEvents saveFileDialog1 As SaveFileDialog
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents txtNotepad As TextBox

End Class
