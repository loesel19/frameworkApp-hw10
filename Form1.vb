Public Class Form1
    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        txtMsg.Text = "VB Programming Rocks!"
        UserControl11.StartColor = Color.SteelBlue
    End Sub

    Private Sub btnEnd_Click(sender As Object, e As EventArgs) Handles btnEnd.Click
        UserControl11.EndColor = Color.DarkOliveGreen
    End Sub

    Private Sub btnGradient_Click(sender As Object, e As EventArgs) Handles btnGradient.Click
        UserControl11.GradientMode = Drawing.Drawing2D.LinearGradientMode.Vertical
    End Sub
End Class
