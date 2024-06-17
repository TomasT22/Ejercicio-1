Public Class Form1
    Private Sub cmdEjecutar_Click(sender As Object, e As EventArgs) Handles cmdEjecutar.Click
        Dim numero1, numero2 As Integer
        numero1 = txtNumero1.Text
        numero2 = txtNumero2.Text
        If numero2 < numero1 Then
            lblMayorNumero.Text = "El mayor es: " & numero1
        Else
            lblMayorNumero.Text = "El mayor es: " & numero2
        End If
    End Sub
End Class
