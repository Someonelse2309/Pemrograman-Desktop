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
        lblBaris = New Label()
        lblKolom = New Label()
        lblJmlBom = New Label()
        nudBaris = New NumericUpDown()
        nudKolom = New NumericUpDown()
        nudJmlBom = New NumericUpDown()
        btnBuat = New Button()
        Panel1 = New Panel()
        CType(nudBaris, ComponentModel.ISupportInitialize).BeginInit()
        CType(nudKolom, ComponentModel.ISupportInitialize).BeginInit()
        CType(nudJmlBom, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lblBaris
        ' 
        lblBaris.AutoSize = True
        lblBaris.Location = New Point(14, 41)
        lblBaris.Name = "lblBaris"
        lblBaris.Size = New Size(57, 30)
        lblBaris.TabIndex = 0
        lblBaris.Text = "Baris"
        ' 
        ' lblKolom
        ' 
        lblKolom.AutoSize = True
        lblKolom.Location = New Point(14, 103)
        lblKolom.Name = "lblKolom"
        lblKolom.Size = New Size(71, 30)
        lblKolom.TabIndex = 1
        lblKolom.Text = "Kolom"
        ' 
        ' lblJmlBom
        ' 
        lblJmlBom.AutoSize = True
        lblJmlBom.Location = New Point(360, 41)
        lblJmlBom.Name = "lblJmlBom"
        lblJmlBom.Size = New Size(139, 30)
        lblJmlBom.TabIndex = 2
        lblJmlBom.Text = "Jumlah Bomb"
        ' 
        ' nudBaris
        ' 
        nudBaris.Location = New Point(90, 41)
        nudBaris.Name = "nudBaris"
        nudBaris.Size = New Size(158, 35)
        nudBaris.TabIndex = 3
        ' 
        ' nudKolom
        ' 
        nudKolom.Location = New Point(91, 103)
        nudKolom.Name = "nudKolom"
        nudKolom.Size = New Size(158, 35)
        nudKolom.TabIndex = 4
        ' 
        ' nudJmlBom
        ' 
        nudJmlBom.Location = New Point(505, 39)
        nudJmlBom.Name = "nudJmlBom"
        nudJmlBom.Size = New Size(158, 35)
        nudJmlBom.TabIndex = 5
        ' 
        ' btnBuat
        ' 
        btnBuat.Location = New Point(730, 38)
        btnBuat.Name = "btnBuat"
        btnBuat.Size = New Size(131, 40)
        btnBuat.TabIndex = 6
        btnBuat.Text = "Buat"
        btnBuat.UseVisualStyleBackColor = True
        ' 
        ' Panel1
        ' 
        Panel1.Location = New Point(14, 144)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(858, 531)
        Panel1.TabIndex = 7
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(12F, 30F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(884, 687)
        Controls.Add(Panel1)
        Controls.Add(btnBuat)
        Controls.Add(nudJmlBom)
        Controls.Add(nudKolom)
        Controls.Add(nudBaris)
        Controls.Add(lblJmlBom)
        Controls.Add(lblKolom)
        Controls.Add(lblBaris)
        Name = "Form1"
        Text = "MineSweeper Generator"
        CType(nudBaris, ComponentModel.ISupportInitialize).EndInit()
        CType(nudKolom, ComponentModel.ISupportInitialize).EndInit()
        CType(nudJmlBom, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblBaris As Label
    Friend WithEvents lblKolom As Label
    Friend WithEvents lblJmlBom As Label
    Friend WithEvents nudBaris As NumericUpDown
    Friend WithEvents nudKolom As NumericUpDown
    Friend WithEvents nudJmlBom As NumericUpDown
    Friend WithEvents btnBuat As Button
    Friend WithEvents Panel1 As Panel

End Class
