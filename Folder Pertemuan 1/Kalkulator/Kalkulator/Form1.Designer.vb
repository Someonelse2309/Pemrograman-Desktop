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
        TxtInput = New TextBox()
        cmd7 = New Button()
        cmdBackspace = New Button()
        cmd8 = New Button()
        cmd9 = New Button()
        cmd4 = New Button()
        cmd5 = New Button()
        cmd6 = New Button()
        cmd1 = New Button()
        cmd2 = New Button()
        cmd3 = New Button()
        cmdDecimal = New Button()
        cmd0 = New Button()
        cmdSign = New Button()
        cmdCE = New Button()
        cmdC = New Button()
        cmdDivision = New Button()
        cmdPowerOf = New Button()
        cmdMultiply = New Button()
        cmdSqrt = New Button()
        cmdSubstraction = New Button()
        cmdInverse = New Button()
        cmdAddition = New Button()
        cmdEqual = New Button()
        SuspendLayout()
        ' 
        ' TxtInput
        ' 
        TxtInput.Font = New Font("Segoe UI", 20F)
        TxtInput.Location = New Point(12, 12)
        TxtInput.Name = "TxtInput"
        TxtInput.ReadOnly = True
        TxtInput.Size = New Size(312, 61)
        TxtInput.TabIndex = 0
        TxtInput.Text = "0"
        TxtInput.TextAlign = HorizontalAlignment.Right
        ' 
        ' cmd7
        ' 
        cmd7.Font = New Font("Segoe UI", 18F)
        cmd7.Location = New Point(12, 153)
        cmd7.Name = "cmd7"
        cmd7.Size = New Size(53, 58)
        cmd7.TabIndex = 1
        cmd7.Text = "7"
        cmd7.UseVisualStyleBackColor = True
        ' 
        ' cmdBackspace
        ' 
        cmdBackspace.Font = New Font("Segoe UI", 12F)
        cmdBackspace.Location = New Point(12, 89)
        cmdBackspace.Name = "cmdBackspace"
        cmdBackspace.Size = New Size(171, 58)
        cmdBackspace.TabIndex = 2
        cmdBackspace.Text = "Backspace"
        cmdBackspace.UseVisualStyleBackColor = True
        ' 
        ' cmd8
        ' 
        cmd8.Font = New Font("Segoe UI", 18F)
        cmd8.Location = New Point(71, 153)
        cmd8.Name = "cmd8"
        cmd8.Size = New Size(53, 58)
        cmd8.TabIndex = 3
        cmd8.Text = "8"
        cmd8.UseVisualStyleBackColor = True
        ' 
        ' cmd9
        ' 
        cmd9.Font = New Font("Segoe UI", 18F)
        cmd9.Location = New Point(130, 153)
        cmd9.Name = "cmd9"
        cmd9.Size = New Size(53, 58)
        cmd9.TabIndex = 4
        cmd9.Text = "9"
        cmd9.UseVisualStyleBackColor = True
        ' 
        ' cmd4
        ' 
        cmd4.Font = New Font("Segoe UI", 18F)
        cmd4.Location = New Point(12, 217)
        cmd4.Name = "cmd4"
        cmd4.Size = New Size(53, 58)
        cmd4.TabIndex = 5
        cmd4.Text = "4"
        cmd4.UseVisualStyleBackColor = True
        ' 
        ' cmd5
        ' 
        cmd5.Font = New Font("Segoe UI", 18F)
        cmd5.Location = New Point(71, 217)
        cmd5.Name = "cmd5"
        cmd5.Size = New Size(53, 58)
        cmd5.TabIndex = 6
        cmd5.Text = "5"
        cmd5.UseVisualStyleBackColor = True
        ' 
        ' cmd6
        ' 
        cmd6.Font = New Font("Segoe UI", 18F)
        cmd6.Location = New Point(130, 217)
        cmd6.Name = "cmd6"
        cmd6.Size = New Size(53, 58)
        cmd6.TabIndex = 7
        cmd6.Text = "6"
        cmd6.UseVisualStyleBackColor = True
        ' 
        ' cmd1
        ' 
        cmd1.Font = New Font("Segoe UI", 18F)
        cmd1.Location = New Point(12, 281)
        cmd1.Name = "cmd1"
        cmd1.Size = New Size(53, 58)
        cmd1.TabIndex = 8
        cmd1.Text = "1"
        cmd1.UseVisualStyleBackColor = True
        ' 
        ' cmd2
        ' 
        cmd2.Font = New Font("Segoe UI", 18F)
        cmd2.Location = New Point(71, 281)
        cmd2.Name = "cmd2"
        cmd2.Size = New Size(53, 58)
        cmd2.TabIndex = 9
        cmd2.Text = "2"
        cmd2.UseVisualStyleBackColor = True
        ' 
        ' cmd3
        ' 
        cmd3.Font = New Font("Segoe UI", 18F)
        cmd3.Location = New Point(130, 281)
        cmd3.Name = "cmd3"
        cmd3.Size = New Size(53, 58)
        cmd3.TabIndex = 10
        cmd3.Text = "3"
        cmd3.UseVisualStyleBackColor = True
        ' 
        ' cmdDecimal
        ' 
        cmdDecimal.Font = New Font("Segoe UI", 18F)
        cmdDecimal.Location = New Point(130, 345)
        cmdDecimal.Name = "cmdDecimal"
        cmdDecimal.Size = New Size(53, 58)
        cmdDecimal.TabIndex = 11
        cmdDecimal.Text = "."
        cmdDecimal.UseVisualStyleBackColor = True
        ' 
        ' cmd0
        ' 
        cmd0.Font = New Font("Segoe UI", 18F)
        cmd0.Location = New Point(12, 345)
        cmd0.Name = "cmd0"
        cmd0.Size = New Size(53, 58)
        cmd0.TabIndex = 12
        cmd0.Text = "0"
        cmd0.UseVisualStyleBackColor = True
        ' 
        ' cmdSign
        ' 
        cmdSign.Font = New Font("Segoe UI", 10F)
        cmdSign.Location = New Point(71, 345)
        cmdSign.Name = "cmdSign"
        cmdSign.Size = New Size(53, 58)
        cmdSign.TabIndex = 13
        cmdSign.Text = "+/-"
        cmdSign.UseVisualStyleBackColor = True
        ' 
        ' cmdCE
        ' 
        cmdCE.Font = New Font("Segoe UI", 12F)
        cmdCE.Location = New Point(212, 89)
        cmdCE.Name = "cmdCE"
        cmdCE.Size = New Size(53, 58)
        cmdCE.TabIndex = 14
        cmdCE.Text = "CE"
        cmdCE.UseVisualStyleBackColor = True
        ' 
        ' cmdC
        ' 
        cmdC.Font = New Font("Segoe UI", 12F)
        cmdC.Location = New Point(271, 89)
        cmdC.Name = "cmdC"
        cmdC.Size = New Size(53, 58)
        cmdC.TabIndex = 15
        cmdC.Text = "C"
        cmdC.UseVisualStyleBackColor = True
        ' 
        ' cmdDivision
        ' 
        cmdDivision.Font = New Font("Segoe UI", 12F)
        cmdDivision.Location = New Point(212, 158)
        cmdDivision.Name = "cmdDivision"
        cmdDivision.Size = New Size(53, 58)
        cmdDivision.TabIndex = 16
        cmdDivision.Text = "/"
        cmdDivision.UseVisualStyleBackColor = True
        ' 
        ' cmdPowerOf
        ' 
        cmdPowerOf.Font = New Font("Segoe UI", 12F)
        cmdPowerOf.Location = New Point(271, 158)
        cmdPowerOf.Name = "cmdPowerOf"
        cmdPowerOf.Size = New Size(53, 58)
        cmdPowerOf.TabIndex = 17
        cmdPowerOf.Text = "X^"
        cmdPowerOf.UseVisualStyleBackColor = True
        ' 
        ' cmdMultiply
        ' 
        cmdMultiply.Font = New Font("Segoe UI", 12F)
        cmdMultiply.Location = New Point(212, 222)
        cmdMultiply.Name = "cmdMultiply"
        cmdMultiply.Size = New Size(53, 58)
        cmdMultiply.TabIndex = 18
        cmdMultiply.Text = "*"
        cmdMultiply.UseVisualStyleBackColor = True
        ' 
        ' cmdSqrt
        ' 
        cmdSqrt.Font = New Font("Segoe UI", 7F)
        cmdSqrt.Location = New Point(271, 222)
        cmdSqrt.Name = "cmdSqrt"
        cmdSqrt.Size = New Size(53, 58)
        cmdSqrt.TabIndex = 19
        cmdSqrt.Text = "SQRT"
        cmdSqrt.UseVisualStyleBackColor = True
        ' 
        ' cmdSubstraction
        ' 
        cmdSubstraction.Font = New Font("Segoe UI", 12F)
        cmdSubstraction.Location = New Point(212, 286)
        cmdSubstraction.Name = "cmdSubstraction"
        cmdSubstraction.Size = New Size(53, 58)
        cmdSubstraction.TabIndex = 20
        cmdSubstraction.Text = "-"
        cmdSubstraction.UseVisualStyleBackColor = True
        ' 
        ' cmdInverse
        ' 
        cmdInverse.Font = New Font("Segoe UI", 10F)
        cmdInverse.Location = New Point(271, 286)
        cmdInverse.Name = "cmdInverse"
        cmdInverse.Size = New Size(53, 58)
        cmdInverse.TabIndex = 21
        cmdInverse.Text = "1/X"
        cmdInverse.UseVisualStyleBackColor = True
        ' 
        ' cmdAddition
        ' 
        cmdAddition.Font = New Font("Segoe UI", 12F)
        cmdAddition.Location = New Point(212, 350)
        cmdAddition.Name = "cmdAddition"
        cmdAddition.Size = New Size(53, 58)
        cmdAddition.TabIndex = 22
        cmdAddition.Text = "+"
        cmdAddition.UseVisualStyleBackColor = True
        ' 
        ' cmdEqual
        ' 
        cmdEqual.Font = New Font("Segoe UI", 12F)
        cmdEqual.Location = New Point(271, 350)
        cmdEqual.Name = "cmdEqual"
        cmdEqual.Size = New Size(53, 58)
        cmdEqual.TabIndex = 23
        cmdEqual.Text = "="
        cmdEqual.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(338, 420)
        Controls.Add(cmdEqual)
        Controls.Add(cmdAddition)
        Controls.Add(cmdInverse)
        Controls.Add(cmdSubstraction)
        Controls.Add(cmdSqrt)
        Controls.Add(cmdMultiply)
        Controls.Add(cmdPowerOf)
        Controls.Add(cmdDivision)
        Controls.Add(cmdC)
        Controls.Add(cmdCE)
        Controls.Add(cmdSign)
        Controls.Add(cmd0)
        Controls.Add(cmdDecimal)
        Controls.Add(cmd3)
        Controls.Add(cmd2)
        Controls.Add(cmd1)
        Controls.Add(cmd6)
        Controls.Add(cmd5)
        Controls.Add(cmd4)
        Controls.Add(cmd9)
        Controls.Add(cmd8)
        Controls.Add(cmdBackspace)
        Controls.Add(cmd7)
        Controls.Add(TxtInput)
        Name = "Form1"
        Text = "Calculator"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents TxtInput As TextBox
    Friend WithEvents cmd7 As Button
    Friend WithEvents cmdBackspace As Button
    Friend WithEvents cmd8 As Button
    Friend WithEvents cmd9 As Button
    Friend WithEvents cmd4 As Button
    Friend WithEvents cmd5 As Button
    Friend WithEvents cmd6 As Button
    Friend WithEvents cmd1 As Button
    Friend WithEvents cmd2 As Button
    Friend WithEvents cmd3 As Button
    Friend WithEvents cmdDecimal As Button
    Friend WithEvents cmd0 As Button
    Friend WithEvents cmdSign As Button
    Friend WithEvents cmdCE As Button
    Friend WithEvents cmdC As Button
    Friend WithEvents cmdDivision As Button
    Friend WithEvents cmdPowerOf As Button
    Friend WithEvents cmdMultiply As Button
    Friend WithEvents cmdSqrt As Button
    Friend WithEvents cmdSubstraction As Button
    Friend WithEvents cmdInverse As Button
    Friend WithEvents cmdAddition As Button
    Friend WithEvents cmdEqual As Button

End Class
