

Public Class Naruto
    Dim verImagenes(12) As Integer
    Dim Img As String
    Dim n, click1, click2, p1, p2 As Integer
    Dim s, cont As Integer




    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Ver_Imagen(verImagenes(0))
        PictureBox1.Image = Image.FromFile(My.Application.Info.DirectoryPath + Img)
        jugada(verImagenes(0), 1)
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Ver_Imagen(verImagenes(1))
        PictureBox2.Image = Image.FromFile(My.Application.Info.DirectoryPath + Img)
        jugada(verImagenes(1), 2)
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Ver_Imagen(verImagenes(2))
        PictureBox3.Image = Image.FromFile(My.Application.Info.DirectoryPath + Img)
        jugada(verImagenes(2), 3)
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        Ver_Imagen(verImagenes(3))
        PictureBox4.Image = Image.FromFile(My.Application.Info.DirectoryPath + Img)
        jugada(verImagenes(3), 4)
    End Sub
    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        Ver_Imagen(verImagenes(4))
        PictureBox5.Image = Image.FromFile(My.Application.Info.DirectoryPath + Img)
        jugada(verImagenes(4), 5)
    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click
        Ver_Imagen(verImagenes(5))
        PictureBox6.Image = Image.FromFile(My.Application.Info.DirectoryPath + Img)
        jugada(verImagenes(5), 6)
    End Sub

    Private Sub PictureBox12_Click(sender As Object, e As EventArgs) Handles PictureBox12.Click
        Ver_Imagen(verImagenes(11))
        PictureBox12.Image = Image.FromFile(My.Application.Info.DirectoryPath + Img)
        jugada(verImagenes(11), 12)
    End Sub

    Private Sub PictureBox11_Click(sender As Object, e As EventArgs) Handles PictureBox11.Click
        Ver_Imagen(verImagenes(10))
        PictureBox11.Image = Image.FromFile(My.Application.Info.DirectoryPath + Img)
        jugada(verImagenes(10), 11)

    End Sub

    Private Sub PictureBox10_Click(sender As Object, e As EventArgs) Handles PictureBox10.Click
        Ver_Imagen(verImagenes(9))
        PictureBox10.Image = Image.FromFile(My.Application.Info.DirectoryPath + Img)
        jugada(verImagenes(9), 10)
    End Sub

    Private Sub PictureBox9_Click(sender As Object, e As EventArgs) Handles PictureBox9.Click
        Ver_Imagen(verImagenes(8))
        PictureBox9.Image = Image.FromFile(My.Application.Info.DirectoryPath + Img)
        jugada(verImagenes(8), 9)
    End Sub

    Private Sub PictureBox8_Click(sender As Object, e As EventArgs) Handles PictureBox8.Click
        Ver_Imagen(verImagenes(7))
        PictureBox8.Image = Image.FromFile(My.Application.Info.DirectoryPath + Img)
        jugada(verImagenes(7), 8)

    End Sub

    Private Sub PictureBox7_Click(sender As Object, e As EventArgs) Handles PictureBox7.Click
        Ver_Imagen(verImagenes(6))
        PictureBox7.Image = Image.FromFile(My.Application.Info.DirectoryPath + Img)
        jugada(verImagenes(6), 7)
    End Sub


    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer1.Start()
        My.Computer.Audio.Play(My.Resources.SonidoL1, AudioPlayMode.BackgroundLoop)



        verImagenes(0) = 1
        verImagenes(1) = 2
        verImagenes(2) = 3
        verImagenes(3) = 4
        verImagenes(4) = 5
        verImagenes(5) = 6
        verImagenes(6) = 7
        verImagenes(7) = 8
        verImagenes(8) = 9
        verImagenes(9) = 10
        verImagenes(10) = 11
        verImagenes(11) = 12
        Cargar_Imagenes()
        s = 0


    End Sub
    Public Sub Ver_Imagen(ByVal im As Integer)
        '1 proceso
        Select Case im
            Case 1 : Img = "\Naruto\1.jpg"
            Case 2 : Img = "\Naruto\2.jpg"
            Case 3 : Img = "\Naruto\3.jpg"
            Case 4 : Img = "\Naruto\4.jpg"
            Case 5 : Img = "\Naruto\5.jpg"
            Case 6 : Img = "\Naruto\6.jpg"

        End Select
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        Label6.Text += 1
        If Label6.Text = "60" Then

            Label5.Text += 1
            Label6.Text = "00"
        End If

    End Sub

    Private Sub Pb1_Click(sender As Object, e As EventArgs) Handles pb1.Click
        My.Computer.Audio.Play(My.Resources.SonidoL1, AudioPlayMode.BackgroundLoop)
    End Sub

    Private Sub Pb2_Click(sender As Object, e As EventArgs) Handles pb2.Click
        My.Computer.Audio.Stop()
    End Sub

    Public Sub jugada(ByVal Ni As Integer, ByVal numpic As Integer)

        n = n + 1 'incrementar contador
        If n = 1 Then '1º imagen visible
            click1 = Ni
            p1 = numpic
        End If
        If n = 2 Then '2º imagen visible
            click2 = Ni
            p2 = numpic

            If click1 = click2 Then

                cont += 1

            Else
                MsgBox("No son iguales")
                Termina_Jugada(p1)
                Termina_Jugada(p2)
            End If
            n = 0
        End If
        If cont = 6 And cont = 6 Then
            Timer1.Stop()
            tiempo = Label5.Text + Label7.Text + Label6.Text
            WinNaruto.Show()
            Cargar_Imagenes()
            Me.Hide()


        End If



    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Label5.Text = "00"
        Label6.Text = "00"
        Img = "\Naruto\0.jpg"

        PictureBox1.Image = Image.FromFile(My.Application.Info.DirectoryPath + Img)
        PictureBox2.Image = Image.FromFile(My.Application.Info.DirectoryPath + Img)
        PictureBox3.Image = Image.FromFile(My.Application.Info.DirectoryPath + Img)
        PictureBox4.Image = Image.FromFile(My.Application.Info.DirectoryPath + Img)
        PictureBox5.Image = Image.FromFile(My.Application.Info.DirectoryPath + Img)
        PictureBox6.Image = Image.FromFile(My.Application.Info.DirectoryPath + Img)
        PictureBox7.Image = Image.FromFile(My.Application.Info.DirectoryPath + Img)
        PictureBox8.Image = Image.FromFile(My.Application.Info.DirectoryPath + Img)
        PictureBox9.Image = Image.FromFile(My.Application.Info.DirectoryPath + Img)
        PictureBox10.Image = Image.FromFile(My.Application.Info.DirectoryPath + Img)
        PictureBox11.Image = Image.FromFile(My.Application.Info.DirectoryPath + Img)
        PictureBox12.Image = Image.FromFile(My.Application.Info.DirectoryPath + Img)
        My.Computer.Audio.Play(My.Resources.SonidoL1, AudioPlayMode.BackgroundLoop)
        n = 0

        cont = 0
        Cargar_Imagenes()
    End Sub
    Public Sub Termina_Jugada(ByVal Npb As Integer)
        Img = "\Naruto\0.jpg"
        Select Case Npb
            Case 1 : PictureBox1.Image = Image.FromFile(My.Application.Info.DirectoryPath + Img)
            Case 2 : PictureBox2.Image = Image.FromFile(My.Application.Info.DirectoryPath + Img)
            Case 3 : PictureBox3.Image = Image.FromFile(My.Application.Info.DirectoryPath + Img)
            Case 4 : PictureBox4.Image = Image.FromFile(My.Application.Info.DirectoryPath + Img)
            Case 5 : PictureBox5.Image = Image.FromFile(My.Application.Info.DirectoryPath + Img)
            Case 6 : PictureBox6.Image = Image.FromFile(My.Application.Info.DirectoryPath + Img)
            Case 7 : PictureBox7.Image = Image.FromFile(My.Application.Info.DirectoryPath + Img)
            Case 8 : PictureBox8.Image = Image.FromFile(My.Application.Info.DirectoryPath + Img)
            Case 9 : PictureBox9.Image = Image.FromFile(My.Application.Info.DirectoryPath + Img)
            Case 10 : PictureBox10.Image = Image.FromFile(My.Application.Info.DirectoryPath + Img)
            Case 11 : PictureBox11.Image = Image.FromFile(My.Application.Info.DirectoryPath + Img)
            Case 12 : PictureBox12.Image = Image.FromFile(My.Application.Info.DirectoryPath + Img)
        End Select
    End Sub

    Public Sub Cargar_Imagenes()
        Dim Nr As New Random()
        Dim Va As Integer
        Dim x, y, b As Integer

        For x = 0 To 12
            verImagenes(x) = 0
        Next

        x = 0
        Do
            Do
                b = 0
                Va = Nr.Next(6) + 1
                For y = 0 To 11
                    If Va = verImagenes(y) Then

                        b += 1

                    End If
                Next

            Loop While (b >= 2) 'Puede repetirse el umero hasta 2 veces

            verImagenes(x) = Va 'Guarda numero aleatorio en el vector
            x += 1

        Loop While (x <= 11)



    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        inicio.Show()
        Me.Hide()
        Label5.Text = "00"
        Label6.Text = "00"
        Img = "\Naruto\0.jpg"

        PictureBox1.Image = Image.FromFile(My.Application.Info.DirectoryPath + Img)
        PictureBox2.Image = Image.FromFile(My.Application.Info.DirectoryPath + Img)
        PictureBox3.Image = Image.FromFile(My.Application.Info.DirectoryPath + Img)
        PictureBox4.Image = Image.FromFile(My.Application.Info.DirectoryPath + Img)
        PictureBox5.Image = Image.FromFile(My.Application.Info.DirectoryPath + Img)
        PictureBox6.Image = Image.FromFile(My.Application.Info.DirectoryPath + Img)
        PictureBox7.Image = Image.FromFile(My.Application.Info.DirectoryPath + Img)
        PictureBox8.Image = Image.FromFile(My.Application.Info.DirectoryPath + Img)
        PictureBox9.Image = Image.FromFile(My.Application.Info.DirectoryPath + Img)
        PictureBox10.Image = Image.FromFile(My.Application.Info.DirectoryPath + Img)
        PictureBox11.Image = Image.FromFile(My.Application.Info.DirectoryPath + Img)
        PictureBox12.Image = Image.FromFile(My.Application.Info.DirectoryPath + Img)
        cont = 0
        Cargar_Imagenes()
        My.Computer.Audio.Play(My.Resources.SonidoL1, AudioPlayMode.BackgroundLoop)
        n = 0
    End Sub


End Class