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
        TxtCelcius = New TextBox()
        LblCelcius = New Label()
        BtnKonversi = New Button()
        LblReamur = New Label()
        LblFahrenheit = New Label()
        LblKelvin = New Label()
        BtnExit = New Button()
        TxtKelvin = New TextBox()
        TxtFahrenheit = New TextBox()
        TxtReamur = New TextBox()
        SuspendLayout()
        ' 
        ' TxtCelcius
        ' 
        TxtCelcius.Location = New Point(38, 57)
        TxtCelcius.Name = "TxtCelcius"
        TxtCelcius.Size = New Size(240, 31)
        TxtCelcius.TabIndex = 0
        ' 
        ' LblCelcius
        ' 
        LblCelcius.AutoSize = True
        LblCelcius.Location = New Point(38, 29)
        LblCelcius.Name = "LblCelcius"
        LblCelcius.Size = New Size(267, 25)
        LblCelcius.TabIndex = 1
        LblCelcius.Text = "Silahkan Masukan Suhu (Celcius)"
        ' 
        ' BtnKonversi
        ' 
        BtnKonversi.Location = New Point(38, 94)
        BtnKonversi.Name = "BtnKonversi"
        BtnKonversi.Size = New Size(112, 34)
        BtnKonversi.TabIndex = 2
        BtnKonversi.Text = "Konversi"
        BtnKonversi.UseVisualStyleBackColor = True
        ' 
        ' LblReamur
        ' 
        LblReamur.AutoSize = True
        LblReamur.Location = New Point(80, 160)
        LblReamur.Name = "LblReamur"
        LblReamur.Size = New Size(117, 25)
        LblReamur.TabIndex = 3
        LblReamur.Text = "Suhu Reamur"
        ' 
        ' LblFahrenheit
        ' 
        LblFahrenheit.AutoSize = True
        LblFahrenheit.Location = New Point(324, 160)
        LblFahrenheit.Name = "LblFahrenheit"
        LblFahrenheit.Size = New Size(138, 25)
        LblFahrenheit.TabIndex = 4
        LblFahrenheit.Text = "Suhu Fahrenheit"
        ' 
        ' LblKelvin
        ' 
        LblKelvin.AutoSize = True
        LblKelvin.Location = New Point(604, 160)
        LblKelvin.Name = "LblKelvin"
        LblKelvin.Size = New Size(103, 25)
        LblKelvin.TabIndex = 5
        LblKelvin.Text = "Suhu Kelvin"
        ' 
        ' BtnExit
        ' 
        BtnExit.Location = New Point(166, 94)
        BtnExit.Name = "BtnExit"
        BtnExit.Size = New Size(112, 34)
        BtnExit.TabIndex = 6
        BtnExit.Text = "Keluar"
        BtnExit.UseVisualStyleBackColor = True
        ' 
        ' TxtKelvin
        ' 
        TxtKelvin.Location = New Point(580, 188)
        TxtKelvin.Name = "TxtKelvin"
        TxtKelvin.PlaceholderText = "(Suhu Kelvin)"
        TxtKelvin.ReadOnly = True
        TxtKelvin.Size = New Size(150, 31)
        TxtKelvin.TabIndex = 7
        TxtKelvin.TextAlign = HorizontalAlignment.Center
        ' 
        ' TxtFahrenheit
        ' 
        TxtFahrenheit.Location = New Point(316, 188)
        TxtFahrenheit.Name = "TxtFahrenheit"
        TxtFahrenheit.PlaceholderText = "(Suhu Fahrenheit)"
        TxtFahrenheit.ReadOnly = True
        TxtFahrenheit.Size = New Size(150, 31)
        TxtFahrenheit.TabIndex = 8
        TxtFahrenheit.TextAlign = HorizontalAlignment.Center
        ' 
        ' TxtReamur
        ' 
        TxtReamur.Location = New Point(62, 188)
        TxtReamur.Name = "TxtReamur"
        TxtReamur.PlaceholderText = "(Suhu Reamur)"
        TxtReamur.ReadOnly = True
        TxtReamur.Size = New Size(150, 31)
        TxtReamur.TabIndex = 9
        TxtReamur.TextAlign = HorizontalAlignment.Center
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 250)
        Controls.Add(TxtReamur)
        Controls.Add(TxtFahrenheit)
        Controls.Add(TxtKelvin)
        Controls.Add(BtnExit)
        Controls.Add(LblKelvin)
        Controls.Add(LblFahrenheit)
        Controls.Add(LblReamur)
        Controls.Add(BtnKonversi)
        Controls.Add(LblCelcius)
        Controls.Add(TxtCelcius)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents TxtCelcius As TextBox
    Friend WithEvents LblCelcius As Label
    Friend WithEvents BtnKonversi As Button
    Friend WithEvents LblReamur As Label
    Friend WithEvents LblFahrenheit As Label
    Friend WithEvents LblKelvin As Label
    Friend WithEvents BtnExit As Button
    Friend WithEvents TxtKelvin As TextBox
    Friend WithEvents TxtFahrenheit As TextBox
    Friend WithEvents TxtReamur As TextBox

End Class
