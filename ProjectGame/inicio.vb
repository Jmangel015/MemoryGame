Public Class inicio
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Naruto.Show()

        Me.Hide()


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        selectLevel.Show()

        Me.Hide()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        End
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        My.Computer.Audio.Play(My.Resources.soulcalibur, AudioPlayMode.BackgroundLoop)
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click

        My.Computer.Audio.Play(My.Resources.soulcalibur, AudioPlayMode.BackgroundLoop)

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click

        My.Computer.Audio.Stop()
    End Sub
End Class