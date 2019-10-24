Public Class selectLevel
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Naruto.Show()
        Me.Hide()


    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        End
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        inicio.Show()

        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dragonball.Show()

        Me.Hide()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Pokemon.Show()

        Me.Hide()
    End Sub

    Private Sub SelectLevel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        My.Computer.Audio.Play(My.Resources.soulcalibur, AudioPlayMode.BackgroundLoop)
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs)


    End Sub

    Private Sub Pb1_Click(sender As Object, e As EventArgs) Handles pb1.Click
        My.Computer.Audio.Play(My.Resources.soulcalibur, AudioPlayMode.BackgroundLoop)
    End Sub

    Private Sub Pb2_Click(sender As Object, e As EventArgs) Handles pb2.Click
        My.Computer.Audio.Stop()
    End Sub
End Class