Public Class WinDragonball
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        inicio.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Pokemon.Show()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        End
    End Sub

    Private Sub WinDragonball_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tiem.Text = "Tu tiempo fue: " + tiempo
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Tiem_Click(sender As Object, e As EventArgs) Handles tiem.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class