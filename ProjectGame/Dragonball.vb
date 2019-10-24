Public Class Dragonball

    Dim VerImagen(20) As Integer
    Dim ImgPred As String
    Dim N, I1, I2, p1, p2 As Integer 'variables para almacenar
    Dim s, cont As Integer

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Label5.Text = "00"
        Label6.Text = "00"
        ImgPred = "\DragonBall\0.jpg"

        PictureBox1.Image = Image.FromFile(My.Application.Info.DirectoryPath + ImgPred)
        PictureBox2.Image = Image.FromFile(My.Application.Info.DirectoryPath + ImgPred)
        PictureBox3.Image = Image.FromFile(My.Application.Info.DirectoryPath + ImgPred)
        PictureBox4.Image = Image.FromFile(My.Application.Info.DirectoryPath + ImgPred)
        PictureBox5.Image = Image.FromFile(My.Application.Info.DirectoryPath + ImgPred)
        PictureBox6.Image = Image.FromFile(My.Application.Info.DirectoryPath + ImgPred)
        PictureBox7.Image = Image.FromFile(My.Application.Info.DirectoryPath + ImgPred)
        PictureBox8.Image = Image.FromFile(My.Application.Info.DirectoryPath + ImgPred)
        PictureBox9.Image = Image.FromFile(My.Application.Info.DirectoryPath + ImgPred)
        PictureBox10.Image = Image.FromFile(My.Application.Info.DirectoryPath + ImgPred)
        PictureBox11.Image = Image.FromFile(My.Application.Info.DirectoryPath + ImgPred)
        PictureBox12.Image = Image.FromFile(My.Application.Info.DirectoryPath + ImgPred)
        PictureBox13.Image = Image.FromFile(My.Application.Info.DirectoryPath + ImgPred)
        PictureBox14.Image = Image.FromFile(My.Application.Info.DirectoryPath + ImgPred)
        PictureBox15.Image = Image.FromFile(My.Application.Info.DirectoryPath + ImgPred)
        PictureBox16.Image = Image.FromFile(My.Application.Info.DirectoryPath + ImgPred)
        PictureBox17.Image = Image.FromFile(My.Application.Info.DirectoryPath + ImgPred)
        PictureBox18.Image = Image.FromFile(My.Application.Info.DirectoryPath + ImgPred)
        PictureBox19.Image = Image.FromFile(My.Application.Info.DirectoryPath + ImgPred)
        PictureBox20.Image = Image.FromFile(My.Application.Info.DirectoryPath + ImgPred)
        My.Computer.Audio.Play(My.Resources.SonidoL2, AudioPlayMode.BackgroundLoop)
        N = 0

        cont = 0
        Cargar_Imagenes()
    End Sub

    Public Sub Termina_Jugada(ByVal Npb As Integer)
        ImgPred = "\DragonBall\0.jpg"
        Select Case Npb
            Case 1 : PictureBox1.Image = Image.FromFile(My.Application.Info.DirectoryPath + ImgPred)
            Case 2 : PictureBox2.Image = Image.FromFile(My.Application.Info.DirectoryPath + ImgPred)
            Case 3 : PictureBox3.Image = Image.FromFile(My.Application.Info.DirectoryPath + ImgPred)
            Case 4 : PictureBox4.Image = Image.FromFile(My.Application.Info.DirectoryPath + ImgPred)
            Case 5 : PictureBox5.Image = Image.FromFile(My.Application.Info.DirectoryPath + ImgPred)
            Case 6 : PictureBox6.Image = Image.FromFile(My.Application.Info.DirectoryPath + ImgPred)
            Case 7 : PictureBox7.Image = Image.FromFile(My.Application.Info.DirectoryPath + ImgPred)
            Case 8 : PictureBox8.Image = Image.FromFile(My.Application.Info.DirectoryPath + ImgPred)
            Case 9 : PictureBox9.Image = Image.FromFile(My.Application.Info.DirectoryPath + ImgPred)
            Case 10 : PictureBox10.Image = Image.FromFile(My.Application.Info.DirectoryPath + ImgPred)
            Case 11 : PictureBox11.Image = Image.FromFile(My.Application.Info.DirectoryPath + ImgPred)
            Case 12 : PictureBox12.Image = Image.FromFile(My.Application.Info.DirectoryPath + ImgPred)
            Case 13 : PictureBox13.Image = Image.FromFile(My.Application.Info.DirectoryPath + ImgPred)
            Case 14 : PictureBox14.Image = Image.FromFile(My.Application.Info.DirectoryPath + ImgPred)

            Case 15 : PictureBox15.Image = Image.FromFile(My.Application.Info.DirectoryPath + ImgPred)
            Case 16 : PictureBox16.Image = Image.FromFile(My.Application.Info.DirectoryPath + ImgPred)
            Case 17 : PictureBox17.Image = Image.FromFile(My.Application.Info.DirectoryPath + ImgPred)
            Case 18 : PictureBox18.Image = Image.FromFile(My.Application.Info.DirectoryPath + ImgPred)
            Case 19 : PictureBox19.Image = Image.FromFile(My.Application.Info.DirectoryPath + ImgPred)
            Case 20 : PictureBox20.Image = Image.FromFile(My.Application.Info.DirectoryPath + ImgPred)
        End Select
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Label5.Text = "00"
        Label6.Text = "00"
        Cargar_Imagenes()
        inicio.Show()
        Me.Hide()

        ImgPred = "\DragonBall\0.jpg"

        PictureBox1.Image = Image.FromFile(My.Application.Info.DirectoryPath + ImgPred)
        PictureBox2.Image = Image.FromFile(My.Application.Info.DirectoryPath + ImgPred)
        PictureBox3.Image = Image.FromFile(My.Application.Info.DirectoryPath + ImgPred)
        PictureBox4.Image = Image.FromFile(My.Application.Info.DirectoryPath + ImgPred)
        PictureBox5.Image = Image.FromFile(My.Application.Info.DirectoryPath + ImgPred)
        PictureBox6.Image = Image.FromFile(My.Application.Info.DirectoryPath + ImgPred)
        PictureBox7.Image = Image.FromFile(My.Application.Info.DirectoryPath + ImgPred)
        PictureBox8.Image = Image.FromFile(My.Application.Info.DirectoryPath + ImgPred)
        PictureBox9.Image = Image.FromFile(My.Application.Info.DirectoryPath + ImgPred)
        PictureBox10.Image = Image.FromFile(My.Application.Info.DirectoryPath + ImgPred)
        PictureBox11.Image = Image.FromFile(My.Application.Info.DirectoryPath + ImgPred)
        PictureBox12.Image = Image.FromFile(My.Application.Info.DirectoryPath + ImgPred)
        PictureBox13.Image = Image.FromFile(My.Application.Info.DirectoryPath + ImgPred)
        PictureBox14.Image = Image.FromFile(My.Application.Info.DirectoryPath + ImgPred)
        PictureBox15.Image = Image.FromFile(My.Application.Info.DirectoryPath + ImgPred)
        PictureBox16.Image = Image.FromFile(My.Application.Info.DirectoryPath + ImgPred)
        PictureBox17.Image = Image.FromFile(My.Application.Info.DirectoryPath + ImgPred)
        PictureBox18.Image = Image.FromFile(My.Application.Info.DirectoryPath + ImgPred)
        PictureBox19.Image = Image.FromFile(My.Application.Info.DirectoryPath + ImgPred)
        PictureBox20.Image = Image.FromFile(My.Application.Info.DirectoryPath + ImgPred)
        My.Computer.Audio.Play(My.Resources.SonidoL2, AudioPlayMode.BackgroundLoop)
        cont = 0
        Cargar_Imagenes()

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Ver_Imagen(VerImagen(0))
        PictureBox1.Image = Image.FromFile(My.Application.Info.DirectoryPath + ImgPred)
        jugada(VerImagen(0), 1)
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Ver_Imagen(VerImagen(1))
        PictureBox2.Image = Image.FromFile(My.Application.Info.DirectoryPath + ImgPred)
        jugada(VerImagen(1), 2)
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Ver_Imagen(VerImagen(2))
        PictureBox3.Image = Image.FromFile(My.Application.Info.DirectoryPath + ImgPred)
        jugada(VerImagen(2), 3)
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        Ver_Imagen(VerImagen(3))
        PictureBox4.Image = Image.FromFile(My.Application.Info.DirectoryPath + ImgPred)
        jugada(VerImagen(3), 4)
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        Ver_Imagen(VerImagen(4))
        PictureBox5.Image = Image.FromFile(My.Application.Info.DirectoryPath + ImgPred)
        jugada(VerImagen(4), 5)
    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click
        Ver_Imagen(VerImagen(5))
        PictureBox6.Image = Image.FromFile(My.Application.Info.DirectoryPath + ImgPred)
        jugada(VerImagen(5), 6)
    End Sub

    Private Sub PictureBox7_Click(sender As Object, e As EventArgs) Handles PictureBox7.Click
        Ver_Imagen(VerImagen(6))
        PictureBox7.Image = Image.FromFile(My.Application.Info.DirectoryPath + ImgPred)
        jugada(VerImagen(6), 7)
    End Sub

    Private Sub PictureBox8_Click(sender As Object, e As EventArgs) Handles PictureBox8.Click
        Ver_Imagen(VerImagen(7))
        PictureBox8.Image = Image.FromFile(My.Application.Info.DirectoryPath + ImgPred)
        jugada(VerImagen(7), 8)
    End Sub

    Private Sub PictureBox9_Click(sender As Object, e As EventArgs) Handles PictureBox9.Click
        Ver_Imagen(VerImagen(8))
        PictureBox9.Image = Image.FromFile(My.Application.Info.DirectoryPath + ImgPred)
        jugada(VerImagen(8), 9)
    End Sub

    Private Sub PictureBox10_Click(sender As Object, e As EventArgs) Handles PictureBox10.Click
        Ver_Imagen(VerImagen(9))
        PictureBox10.Image = Image.FromFile(My.Application.Info.DirectoryPath + ImgPred)
        jugada(VerImagen(9), 10)
    End Sub

    Private Sub PictureBox20_Click(sender As Object, e As EventArgs) Handles PictureBox20.Click
        Ver_Imagen(VerImagen(19))
        PictureBox20.Image = Image.FromFile(My.Application.Info.DirectoryPath + ImgPred)
        jugada(VerImagen(19), 20)
    End Sub

    Private Sub PictureBox11_Click(sender As Object, e As EventArgs) Handles PictureBox11.Click
        Ver_Imagen(VerImagen(10))
        PictureBox11.Image = Image.FromFile(My.Application.Info.DirectoryPath + ImgPred)
        jugada(VerImagen(10), 11)
    End Sub

    Private Sub PictureBox12_Click(sender As Object, e As EventArgs) Handles PictureBox12.Click
        Ver_Imagen(VerImagen(11))
        PictureBox12.Image = Image.FromFile(My.Application.Info.DirectoryPath + ImgPred)
        jugada(VerImagen(11), 12)
    End Sub

    Private Sub PictureBox13_Click(sender As Object, e As EventArgs) Handles PictureBox13.Click
        Ver_Imagen(VerImagen(12))
        PictureBox13.Image = Image.FromFile(My.Application.Info.DirectoryPath + ImgPred)
        jugada(VerImagen(12), 13)
    End Sub

    Private Sub PictureBox14_Click(sender As Object, e As EventArgs) Handles PictureBox14.Click
        Ver_Imagen(VerImagen(13))
        PictureBox14.Image = Image.FromFile(My.Application.Info.DirectoryPath + ImgPred)
        jugada(VerImagen(13), 14)
    End Sub

    Private Sub PictureBox15_Click(sender As Object, e As EventArgs) Handles PictureBox15.Click
        Ver_Imagen(VerImagen(14))
        PictureBox15.Image = Image.FromFile(My.Application.Info.DirectoryPath + ImgPred)
        jugada(VerImagen(14), 15)
    End Sub

    Private Sub PictureBox16_Click(sender As Object, e As EventArgs) Handles PictureBox16.Click
        Ver_Imagen(VerImagen(15))
        PictureBox16.Image = Image.FromFile(My.Application.Info.DirectoryPath + ImgPred)
        jugada(VerImagen(15), 16)
    End Sub

    Private Sub PictureBox17_Click(sender As Object, e As EventArgs) Handles PictureBox17.Click
        Ver_Imagen(VerImagen(16))
        PictureBox17.Image = Image.FromFile(My.Application.Info.DirectoryPath + ImgPred)
        jugada(VerImagen(16), 17)
    End Sub

    Private Sub PictureBox18_Click(sender As Object, e As EventArgs) Handles PictureBox18.Click
        Ver_Imagen(VerImagen(17))
        PictureBox18.Image = Image.FromFile(My.Application.Info.DirectoryPath + ImgPred)
        jugada(VerImagen(17), 18)
    End Sub

    Private Sub PictureBox19_Click(sender As Object, e As EventArgs) Handles PictureBox19.Click
        Ver_Imagen(VerImagen(18))
        PictureBox19.Image = Image.FromFile(My.Application.Info.DirectoryPath + ImgPred)
        jugada(VerImagen(18), 19)
    End Sub

    Private Sub Pb1_Click(sender As Object, e As EventArgs) Handles pb1.Click
        My.Computer.Audio.Play(My.Resources.SonidoL2, AudioPlayMode.BackgroundLoop)
    End Sub

    Private Sub Pb2_Click(sender As Object, e As EventArgs) Handles pb2.Click
        My.Computer.Audio.Stop()
    End Sub

    Public Sub Cargar_Imagenes()  'Generar nùmeros aleatorios 
        Dim Nr As New Random()
        Dim Va As Integer
        Dim x, y, b As Integer

        For x = 0 To 20 ' Borrar datos de las imagenes
            VerImagen(x) = 0
        Next

        x = 0
        Do
            'Llenar los 12 datos en el vector con valores aleatorios del  1 al 6
            Do
                b = 0
                Va = Nr.Next(10) + 1 'Genera numero aleatorio
                For y = 0 To 19 'Buscar el numero en el vector
                    If Va = VerImagen(y) Then 'El valor generado es igual al del vector 

                        b += 1 ' Incrementa el contador 

                    End If
                Next

            Loop While (b >= 2) 'Puede repetirse el umero hasta 2 veces

            VerImagen(x) = Va 'Guarda numero aleatorio en el vector
            x += 1

        Loop While (x <= 19)



    End Sub

    Private Sub Dragonball_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        My.Computer.Audio.Play(My.Resources.SonidoL2, AudioPlayMode.BackgroundLoop)

        Timer1.Start()




        VerImagen(0) = 1
        VerImagen(1) = 2
        VerImagen(2) = 3
        VerImagen(3) = 4
        VerImagen(4) = 5
        VerImagen(5) = 6
        VerImagen(6) = 7
        VerImagen(7) = 8
        VerImagen(8) = 9
        VerImagen(9) = 10
        VerImagen(10) = 1
        VerImagen(11) = 2
        VerImagen(12) = 3
        VerImagen(13) = 4
        VerImagen(14) = 5
        VerImagen(15) = 6
        VerImagen(16) = 7
        VerImagen(17) = 8
        VerImagen(18) = 9
        VerImagen(19) = 10

        Cargar_Imagenes()

        s = 0
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label6.Text += 1
        If Label6.Text = "60" Then

            Label5.Text += 1
            Label6.Text = "00"
        End If

    End Sub

    Public Sub Ver_Imagen(ByVal im As Integer)
        '1 proceso
        Select Case im
            Case 1 : ImgPred = "\DragonBall\1.jpg"
            Case 2 : ImgPred = "\DragonBall\2.png"
            Case 3 : ImgPred = "\DragonBall\3.jpg"
            Case 4 : ImgPred = "\DragonBall\4.jpg"
            Case 5 : ImgPred = "\DragonBall\5.jpg"
            Case 6 : ImgPred = "\DragonBall\6.jpg"
            Case 7 : ImgPred = "\DragonBall\7.png"
            Case 8 : ImgPred = "\DragonBall\8.jpg"
            Case 9 : ImgPred = "\DragonBall\9.jpg"
            Case 10 : ImgPred = "\DragonBall\10.jpg"
        End Select
    End Sub
    Public Sub jugada(ByVal Ni As Integer, ByVal numpic As Integer)

        N = N + 1 'incrementar contador
        If N = 1 Then '1º imagen visible
            I1 = Ni
            p1 = numpic
        End If
        If N = 2 Then '2º imagen visible
            I2 = Ni
            p2 = numpic

            If I1 = I2 Then

                cont += 1

            Else
                MsgBox("Imagen incorrecta")

                Termina_Jugada(p1)
                Termina_Jugada(p2)

            End If
            N = 0
        End If
        If cont = 10 And cont = 10 Then
            Timer1.Stop()
            tiempo = Label5.Text + Label7.Text + Label6.Text
            WinDragonball.Show()
            Cargar_Imagenes()
            Me.Hide()

        End If



    End Sub
End Class