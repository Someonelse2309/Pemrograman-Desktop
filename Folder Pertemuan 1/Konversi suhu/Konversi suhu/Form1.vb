Public Class Form1

    Private Sub BtnKonversi_Click(sender As Object, e As EventArgs) Handles BtnKonversi.Click
        Dim celcius, reamur, fahrenheit, kelvin As Double
        celcius = Val(TxtCelcius.Text)
        fahrenheit = 9 / 5 * celcius + 32
        reamur = 4 / 5 * celcius
        kelvin = celcius + 273
        TxtFahrenheit.Text = fahrenheit
        TxtKelvin.Text = kelvin
        TxtReamur.Text = reamur
    End Sub
End Class
