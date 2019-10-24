Public Class WinPokemon
    Private Sub WinPokemon_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        My.Computer.Audio.Stop()
        inicio.Show()
        Me.Hide()
    End Sub

    Private Sub Tiem_Click(sender As Object, e As EventArgs) Handles tiem.Click
        tiem.Text = "Tu tiempo fue: " + tiempo
    End Sub
End Class