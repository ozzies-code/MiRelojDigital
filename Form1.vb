Public Class Form1
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick


    End Sub

    Private Sub btnHora_Click(sender As Object, e As EventArgs) Handles btnHora.Click
        Label1.Text = TimeString 'Da solo la hora
    End Sub

    Private Sub btnMostrarHoraFecha_Click(sender As Object, e As EventArgs) Handles btnMostrarHoraFecha.Click
        Label1.Text = System.DateTime.Now() 'Da la hora y la fecha
    End Sub
End Class
