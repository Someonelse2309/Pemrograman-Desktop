﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLaporan
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
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.btnLaporan = New System.Windows.Forms.Button()
        Me.btnTutup = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "ParkirApp.Report1.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(134, 42)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(1073, 506)
        Me.ReportViewer1.TabIndex = 0
        '
        'btnLaporan
        '
        Me.btnLaporan.Location = New System.Drawing.Point(134, 617)
        Me.btnLaporan.Name = "btnLaporan"
        Me.btnLaporan.Size = New System.Drawing.Size(139, 44)
        Me.btnLaporan.TabIndex = 1
        Me.btnLaporan.Text = "Laporan"
        Me.btnLaporan.UseVisualStyleBackColor = True
        '
        'btnTutup
        '
        Me.btnTutup.Location = New System.Drawing.Point(1058, 617)
        Me.btnTutup.Name = "btnTutup"
        Me.btnTutup.Size = New System.Drawing.Size(149, 44)
        Me.btnTutup.TabIndex = 2
        Me.btnTutup.Text = "Hapus"
        Me.btnTutup.UseVisualStyleBackColor = True
        '
        'frmLaporan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1341, 708)
        Me.Controls.Add(Me.btnTutup)
        Me.Controls.Add(Me.btnLaporan)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "frmLaporan"
        Me.Text = "frmLaporan"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents btnLaporan As Button
    Friend WithEvents btnTutup As Button
End Class
