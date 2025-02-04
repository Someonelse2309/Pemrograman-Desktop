Public Class Form1
    Private valHolder1 As Double
    Private valHolder2 As Double
    Private tmpValue As Double
    Private hasDecimal As Boolean
    Private inputStatus As Boolean = True
    Private clearText As Boolean
    Private calcFunc As String

    Private Sub cmd1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd1.Click
        If inputStatus = False Then
            TxtInput.Text &= cmd1.Text
        Else
            TxtInput.Text = cmd1.Text
            inputStatus = False
        End If
    End Sub

    Private Sub cmd2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd2.Click
        If inputStatus = False Then
            TxtInput.Text &= cmd2.Text
        Else
            TxtInput.Text = cmd2.Text
            inputStatus = False
        End If
    End Sub

    Private Sub cmd3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd3.Click
        If inputStatus = False Then
            TxtInput.Text &= cmd3.Text
        Else
            TxtInput.Text = cmd3.Text
            inputStatus = False
        End If
    End Sub

    Private Sub cmd4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd4.Click
        If inputStatus = False Then
            TxtInput.Text &= cmd4.Text
        Else
            TxtInput.Text = cmd4.Text
            inputStatus = False
        End If
    End Sub

    Private Sub cmd5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd5.Click
        If inputStatus = False Then
            TxtInput.Text &= cmd5.Text
        Else
            TxtInput.Text = cmd5.Text
            inputStatus = False
        End If
    End Sub

    Private Sub cmd6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd6.Click
        If inputStatus = False Then
            TxtInput.Text &= cmd6.Text
        Else
            TxtInput.Text = cmd6.Text
            inputStatus = False
        End If
    End Sub

    Private Sub cmd7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd7.Click
        If inputStatus = False Then
            TxtInput.Text &= cmd7.Text
        Else
            TxtInput.Text = cmd7.Text
            inputStatus = False
        End If
    End Sub

    Private Sub cmd8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd8.Click
        If inputStatus = False Then
            TxtInput.Text &= cmd8.Text
        Else
            TxtInput.Text = cmd8.Text
            inputStatus = False
        End If
    End Sub

    Private Sub cmd9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd9.Click
        If inputStatus = False Then
            TxtInput.Text &= cmd9.Text
        Else
            TxtInput.Text = cmd9.Text
            inputStatus = False
        End If
    End Sub

    Private Sub cmd0_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd0.Click
        If inputStatus = False Then
            TxtInput.Text &= cmd0.Text
        Else
            TxtInput.Text = cmd0.Text
            inputStatus = False
        End If
    End Sub

    Private Sub cmdDecimal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDecimal.Click
        If inputStatus Then
            If Not hasDecimal Then
                If TxtInput.Text.Length > 1 Then
                    If Not TxtInput.Text = "0" Then
                        TxtInput.Text &= cmdDecimal.Text
                        hasDecimal = True
                    End If
                Else
                    TxtInput.Text = "0."
                End If
            End If
        End If
    End Sub

    Private Sub CalculateTotals()
        valHolder2 = CType(TxtInput.Text, Double)
        Select Case calcFunc
            Case "Add"
                valHolder1 = valHolder1 + valHolder2
            Case "Subtract"
                valHolder1 = valHolder1 - valHolder2
            Case "Divide"
                valHolder1 = valHolder1 / valHolder2
            Case "Multiply"
                valHolder1 = valHolder1 * valHolder2
            Case "PowerOf"
                valHolder1 = System.Math.Pow(valHolder1, valHolder2)
        End Select
        TxtInput.Text = CType(valHolder1, String)
        inputStatus = True
    End Sub

    Private Sub cmdC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdC.Click
        TxtInput.Text = String.Empty
        valHolder1 = 0
        valHolder2 = 0
        calcFunc = String.Empty
        hasDecimal = False
    End Sub

    Private Sub cmdCE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCE.Click
        TxtInput.Text = String.Empty
        hasDecimal = False
    End Sub

    Private Sub cmdBackspace_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBackspace.Click
        Dim str As String
        Dim loc As Integer
        If TxtInput.Text.Length > 0 Then
            str = TxtInput.Text.Chars(TxtInput.Text.Length - 1)
            'Jika karakter terakhir adalah , (desimal) 
            If str = "." Then
                hasDecimal = False
            End If
            loc = TxtInput.Text.Length
            TxtInput.Text = TxtInput.Text.Remove(loc - 1, 1)
        End If
    End Sub

    Private Sub cmdAddition_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAddition.Click
        If TxtInput.Text.Length <> 0 Then
            If calcFunc = String.Empty Then
                valHolder1 = CDbl(TxtInput.Text)
                TxtInput.Text = String.Empty
            Else
                CalculateTotals()
            End If
            calcFunc = "Add"
            hasDecimal = False
        End If
    End Sub

    Private Sub cmdSubstraction_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSubstraction.Click
        If TxtInput.Text.Length <> 0 Then
            If calcFunc = String.Empty Then
                valHolder1 = CType(TxtInput.Text, Double)
                TxtInput.Text = String.Empty
            Else
                CalculateTotals()
            End If
            calcFunc = "Subtract"
            hasDecimal = False
        End If
    End Sub

    Private Sub cmdMultiply_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdMultiply.Click
        If TxtInput.Text.Length <> 0 Then
            If calcFunc = String.Empty Then
                valHolder1 = CDbl(TxtInput.Text)
                TxtInput.Text = String.Empty
            Else
                CalculateTotals()
            End If
            calcFunc = "Multiply"
            hasDecimal = False
        End If
    End Sub

    Private Sub cmdDivision_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDivision.Click
        If TxtInput.Text.Length <> 0 Then
            If calcFunc = String.Empty Then
                valHolder1 = CType(TxtInput.Text, Double)
                TxtInput.Text = String.Empty
            Else
                CalculateTotals()
            End If
            calcFunc = "Divide"
            hasDecimal = False
        End If
    End Sub

    Private Sub cmdSqrt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSqrt.Click
        If TxtInput.Text.Length <> 0 Then
            tmpValue = CType(TxtInput.Text, Double)
            tmpValue = System.Math.Sqrt(tmpValue)
            TxtInput.Text = CType(tmpValue, String)
            hasDecimal = False
        End If
    End Sub

    Private Sub cmdPowerOf_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPowerOf.Click
        If TxtInput.Text.Length <> 0 Then
            If calcFunc = String.Empty Then
                valHolder1 = CType(TxtInput.Text, Double)
                TxtInput.Text = String.Empty
            Else
                CalculateTotals()
            End If
            calcFunc = "PowerOf"
            hasDecimal = False
        End If
    End Sub

    Private Sub cmdEqual_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEqual.Click
        If TxtInput.Text.Length <> 0 AndAlso valHolder1 <> 0 Then
            CalculateTotals()
            calcFunc = ""
            hasDecimal = False
        End If
    End Sub

    Private Sub cmdSign_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSign.Click
        If inputStatus = False Then
            If TxtInput.Text.Length > 0 Then
                valHolder1 = -1 * CDbl(TxtInput.Text)
                TxtInput.Text = CStr(valHolder1)
            End If
        End If
    End Sub

    Private Sub cmdInverse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdInverse.Click
        If TxtInput.Text.Length <> 0 Then
            tmpValue = CDbl(TxtInput.Text)
            tmpValue = 1 / tmpValue
            TxtInput.Text = CStr(tmpValue)
            hasDecimal = False
        End If
    End Sub

End Class
