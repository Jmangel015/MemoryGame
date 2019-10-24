Public Class Pokemon

    Dim verImagenes(40) As Integer
    Dim ImgPred As String
    Dim x, int1, int2, select1, select2 As Integer
    Dim s, cont As Integer

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Label5.Text = "00"
        Label6.Text = "00"
        ImgPred = "\Pokemon\0.jpg"

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
        PictureBox21.Image = Image.FromFile(My.Application.Info.DirectoryPath + ImgPred)
        PictureBox22.Image = Image.FromFile(My.Application.Info.DirectoryPath + ImgPred)
        PictureBox23.Image = Image.FromFile(My.Application.Info.DirectoryPath + ImgPred)
        PictureBox24.Image = Image.FromFile(My.Application.Info.DirectoryPath + ImgPred)
        PictureBox25.Image = Image.FromFile(My.Application.Info.DirectoryPath + ImgPred)
        PictureBox26.Image = Image.FromFile(My.Application.Info.DirectoryPath + ImgPred)
        PictureBox27.Image = Image.FromFile(My.Application.Info.DirectoryPath + ImgPred)
        PictureBox28.Image = Image.FromFile(My.Application.Info.DirectoryPath + ImgPred)
        PictureBox29.Image = Image.FromFile(My.Application.Info.DirectoryPath + ImgPred)
        PictureBox30.Image = Image.FromFile(My.Application.Info.DirectoryPath + ImgPred)
        PictureBox31.Image = Image.FromFile(My.Application.Info.DirectoryPath + ImgPred)
        PictureBox32.Image = Image.FromFile(My.Application.Info.DirectoryPath + ImgPred)
        PictureBox33.Image = Image.FromFile(My.Application.Info.DirectoryPath + ImgPred)
        PictureBox34.Image = Image.FromFile(My.Application.Info.DirectoryPath + ImgPred)
        PictureBox35.Image = Image.FromFile(My.Application.Info.DirectoryPath + ImgPred)
        PictureBox36.Image = Image.FromFile(My.Application.Info.DirectoryPath + ImgPred)
        PictureBox37.Image = Image.FromFile(My.Application.Info.DirectoryPath + ImgPred)
        PictureBox38.Image = Image.FromFile(My.Application.Info.DirectoryPath + ImgPred)
        PictureBox39.Image = Image.FromFile(My.Application.Info.DirectoryPath + ImgPred)
        PictureBox40.Image = Image.FromFile(My.Application.Info.DirectoryPath + ImgPred)
        My.Computer.Audio.Play(My.Resources.SonidoL3, AudioPlayMode.BackgroundLoop)
        x = 0

        cont = 0
        Random_img()
    End Sub

    Public Sub Termina_Jugada(ByVal Npb As Integer)
        ImgPred = "\Pokemon\0.jpg"
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
            Case 21 : PictureBox21.Image = Image.FromFile(My.Application.Info.DirectoryPath + ImgPred)
            Case 22 : PictureBox22.Image = Image.FromFile(My.Application.Info.DirectoryPath + ImgPred)
            Case 23 : PictureBox23.Image = Image.FromFile(My.Application.Info.DirectoryPath + ImgPred)
            Case 24 : PictureBox24.Image = Image.FromFile(My.Application.Info.DirectoryPath + ImgPred)
            Case 25 : PictureBox25.Image = Image.FromFile(My.Application.Info.DirectoryPath + ImgPred)
            Case 26 : PictureBox26.Image = Image.FromFile(My.Application.Info.DirectoryPath + ImgPred)
            Case 27 : PictureBox27.Image = Image.FromFile(My.Application.Info.DirectoryPath + ImgPred)
            Case 28 : PictureBox28.Image = Image.FromFile(My.Application.Info.DirectoryPath + ImgPred)
            Case 29 : PictureBox29.Image = Image.FromFile(My.Application.Info.DirectoryPath + ImgPred)
            Case 30 : PictureBox30.Image = Image.FromFile(My.Application.Info.DirectoryPath + ImgPred)
            Case 31 : PictureBox31.Image = Image.FromFile(My.Application.Info.DirectoryPath + ImgPred)
            Case 32 : PictureBox32.Image = Image.FromFile(My.Application.Info.DirectoryPath + ImgPred)
            Case 33 : PictureBox33.Image = Image.FromFile(My.Application.Info.DirectoryPath + ImgPred)
            Case 34 : PictureBox34.Image = Image.FromFile(My.Application.Info.DirectoryPath + ImgPred)
            Case 35 : PictureBox35.Image = Image.FromFile(My.Application.Info.DirectoryPath + ImgPred)
            Case 36 : PictureBox36.Image = Image.FromFile(My.Application.Info.DirectoryPath + ImgPred)
            Case 37 : PictureBox37.Image = Image.FromFile(My.Application.Info.DirectoryPath + ImgPred)
            Case 38 : PictureBox38.Image = Image.FromFile(My.Application.Info.DirectoryPath + ImgPred)
            Case 39 : PictureBox39.Image = Image.FromFile(My.Application.Info.DirectoryPath + ImgPred)
            Case 40 : PictureBox40.Image = Image.FromFile(My.Application.Info.DirectoryPath + ImgPred)
        End Select
    End Sub

    Public Sub Random_img()
        Dim Nr As New Random()
        Dim Va As Integer
        Dim x, y, b As Integer

        For x = 0 To 40
            verImagenes(x) = 0
        Next

        x = 0
        Do
            Do
                b = 0
                Va = Nr.Next(20) + 1
                For y = 0 To 39
                    If Va = verImagenes(y) Then

                        b += 1

                    End If
                Next

            Loop While (b >= 2)

            verImagenes(x) = Va
            x += 1

        Loop While (x <= 39)

    End Sub
    Public Sub VistaDeImagen(ByVal im As Integer)
        '1 proceso
        Select Case im
            Case 1 : ImgPred = "\Pokemon\1.jpg"
            Case 2 : ImgPred = "\Pokemon\2.jpg"
            Case 3 : ImgPred = "\Pokemon\3.jpg"
            Case 4 : ImgPred = "\Pokemon\4.jpg"
            Case 5 : ImgPred = "\Pokemon\5.jpg"
            Case 6 : ImgPred = "\Pokemon\6.jpg"
            Case 7 : ImgPred = "\Pokemon\7.png"
            Case 8 : ImgPred = "\Pokemon\8.jpg"
            Case 9 : ImgPred = "\Pokemon\9.jpg"
            Case 10 : ImgPred = "\Pokemon\10.jpg"
            Case 11 : ImgPred = "\Pokemon\11.jpg"
            Case 12 : ImgPred = "\Pokemon\12.jpg"
            Case 13 : ImgPred = "\Pokemon\13.jpg"
            Case 14 : ImgPred = "\Pokemon\14.jpg"
            Case 15 : ImgPred = "\Pokemon\15.jpg"
            Case 16 : ImgPred = "\Pokemon\16.jpg"
            Case 17 : ImgPred = "\Pokemon\17.jpg"
            Case 18 : ImgPred = "\Pokemon\18.jpg"
            Case 19 : ImgPred = "\Pokemon\19.png"
            Case 20 : ImgPred = "\Pokemon\20.png"
        End Select
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        VistaDeImagen(verImagenes(1))
        PictureBox2.Image = Image.FromFile(My.Application.Info.DirectoryPath + ImgPred)
        Jugada(verImagenes(1), 2)
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        VistaDeImagen(verImagenes(2))
        PictureBox3.Image = Image.FromFile(My.Application.Info.DirectoryPath + ImgPred)
        Jugada(verImagenes(2), 3)
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        VistaDeImagen(verImagenes(3))
        PictureBox4.Image = Image.FromFile(My.Application.Info.DirectoryPath + ImgPred)
        Jugada(verImagenes(3), 4)
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        VistaDeImagen(verImagenes(4))
        PictureBox5.Image = Image.FromFile(My.Application.Info.DirectoryPath + ImgPred)
        Jugada(verImagenes(4), 5)
    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click
        VistaDeImagen(verImagenes(5))
        PictureBox6.Image = Image.FromFile(My.Application.Info.DirectoryPath + ImgPred)
        Jugada(verImagenes(5), 6)
    End Sub

    Private Sub PictureBox7_Click(sender As Object, e As EventArgs) Handles PictureBox7.Click
        VistaDeImagen(verImagenes(6))
        PictureBox7.Image = Image.FromFile(My.Application.Info.DirectoryPath + ImgPred)
        Jugada(verImagenes(6), 7)
    End Sub

    Private Sub PictureBox8_Click(sender As Object, e As EventArgs) Handles PictureBox8.Click
        VistaDeImagen(verImagenes(7))
        PictureBox8.Image = Image.FromFile(My.Application.Info.DirectoryPath + ImgPred)
        Jugada(verImagenes(7), 8)
    End Sub

    Private Sub PictureBox9_Click(sender As Object, e As EventArgs) Handles PictureBox9.Click
        VistaDeImagen(verImagenes(8))
        PictureBox9.Image = Image.FromFile(My.Application.Info.DirectoryPath + ImgPred)
        Jugada(verImagenes(8), 9)
    End Sub

    Private Sub PictureBox10_Click(sender As Object, e As EventArgs) Handles PictureBox10.Click
        VistaDeImagen(verImagenes(9))
        PictureBox10.Image = Image.FromFile(My.Application.Info.DirectoryPath + ImgPred)
        Jugada(verImagenes(9), 10)
    End Sub

    Private Sub PictureBox11_Click(sender As Object, e As EventArgs) Handles PictureBox11.Click
        VistaDeImagen(verImagenes(10))
        PictureBox11.Image = Image.FromFile(My.Application.Info.DirectoryPath + ImgPred)
        Jugada(verImagenes(10), 11)
    End Sub

    Private Sub PictureBox12_Click(sender As Object, e As EventArgs) Handles PictureBox12.Click
        VistaDeImagen(verImagenes(11))
        PictureBox12.Image = Image.FromFile(My.Application.Info.DirectoryPath + ImgPred)
        Jugada(verImagenes(11), 12)
    End Sub

    Private Sub PictureBox13_Click(sender As Object, e As EventArgs) Handles PictureBox13.Click
        VistaDeImagen(verImagenes(12))
        PictureBox13.Image = Image.FromFile(My.Application.Info.DirectoryPath + ImgPred)
        Jugada(verImagenes(12), 13)
    End Sub

    Private Sub PictureBox14_Click(sender As Object, e As EventArgs) Handles PictureBox14.Click
        VistaDeImagen(verImagenes(13))
        PictureBox14.Image = Image.FromFile(My.Application.Info.DirectoryPath + ImgPred)
        Jugada(verImagenes(13), 14)
    End Sub

    Private Sub PictureBox15_Click(sender As Object, e As EventArgs) Handles PictureBox15.Click
        VistaDeImagen(verImagenes(14))
        PictureBox15.Image = Image.FromFile(My.Application.Info.DirectoryPath + ImgPred)
        Jugada(verImagenes(14), 15)
    End Sub

    Private Sub PictureBox16_Click(sender As Object, e As EventArgs) Handles PictureBox16.Click
        VistaDeImagen(verImagenes(15))
        PictureBox16.Image = Image.FromFile(My.Application.Info.DirectoryPath + ImgPred)
        Jugada(verImagenes(15), 16)
    End Sub

    Private Sub PictureBox17_Click(sender As Object, e As EventArgs) Handles PictureBox17.Click
        VistaDeImagen(verImagenes(16))
        PictureBox17.Image = Image.FromFile(My.Application.Info.DirectoryPath + ImgPred)
        Jugada(verImagenes(16), 17)
    End Sub

    Private Sub PictureBox18_Click(sender As Object, e As EventArgs) Handles PictureBox18.Click
        VistaDeImagen(verImagenes(17))
        PictureBox18.Image = Image.FromFile(My.Application.Info.DirectoryPath + ImgPred)
        Jugada(verImagenes(17), 18)
    End Sub

    Private Sub PictureBox19_Click(sender As Object, e As EventArgs) Handles PictureBox19.Click
        VistaDeImagen(verImagenes(18))
        PictureBox19.Image = Image.FromFile(My.Application.Info.DirectoryPath + ImgPred)
        Jugada(verImagenes(18), 19)
    End Sub

    Private Sub PictureBox20_Click(sender As Object, e As EventArgs) Handles PictureBox20.Click
        VistaDeImagen(verImagenes(19))
        PictureBox20.Image = Image.FromFile(My.Application.Info.DirectoryPath + ImgPred)
        Jugada(verImagenes(19), 20)
    End Sub

    Private Sub PictureBox30_Click(sender As Object, e As EventArgs) Handles PictureBox30.Click
        VistaDeImagen(verImagenes(29))
        PictureBox30.Image = Image.FromFile(My.Application.Info.DirectoryPath + ImgPred)
        Jugada(verImagenes(29), 30)
    End Sub

    Private Sub PictureBox21_Click(sender As Object, e As EventArgs) Handles PictureBox21.Click
        VistaDeImagen(verImagenes(20))
        PictureBox21.Image = Image.FromFile(My.Application.Info.DirectoryPath + ImgPred)
        Jugada(verImagenes(20), 21)
    End Sub

    Private Sub PictureBox22_Click(sender As Object, e As EventArgs) Handles PictureBox22.Click
        VistaDeImagen(verImagenes(21))
        PictureBox22.Image = Image.FromFile(My.Application.Info.DirectoryPath + ImgPred)
        Jugada(verImagenes(21), 22)
    End Sub

    Private Sub PictureBox23_Click(sender As Object, e As EventArgs) Handles PictureBox23.Click
        VistaDeImagen(verImagenes(22))
        PictureBox23.Image = Image.FromFile(My.Application.Info.DirectoryPath + ImgPred)
        Jugada(verImagenes(22), 23)
    End Sub

    Private Sub PictureBox24_Click(sender As Object, e As EventArgs) Handles PictureBox24.Click
        VistaDeImagen(verImagenes(23))
        PictureBox24.Image = Image.FromFile(My.Application.Info.DirectoryPath + ImgPred)
        Jugada(verImagenes(23), 24)
    End Sub

    Private Sub PictureBox25_Click(sender As Object, e As EventArgs) Handles PictureBox25.Click
        VistaDeImagen(verImagenes(24))
        PictureBox25.Image = Image.FromFile(My.Application.Info.DirectoryPath + ImgPred)
        Jugada(verImagenes(24), 25)
    End Sub

    Private Sub PictureBox26_Click(sender As Object, e As EventArgs) Handles PictureBox26.Click
        VistaDeImagen(verImagenes(25))
        PictureBox26.Image = Image.FromFile(My.Application.Info.DirectoryPath + ImgPred)
        Jugada(verImagenes(25), 26)
    End Sub

    Private Sub PictureBox27_Click(sender As Object, e As EventArgs) Handles PictureBox27.Click
        VistaDeImagen(verImagenes(26))
        PictureBox27.Image = Image.FromFile(My.Application.Info.DirectoryPath + ImgPred)
        Jugada(verImagenes(26), 27)
    End Sub

    Private Sub PictureBox28_Click(sender As Object, e As EventArgs) Handles PictureBox28.Click
        VistaDeImagen(verImagenes(27))
        PictureBox28.Image = Image.FromFile(My.Application.Info.DirectoryPath + ImgPred)
        Jugada(verImagenes(27), 28)
    End Sub

    Private Sub PictureBox29_Click(sender As Object, e As EventArgs) Handles PictureBox29.Click
        VistaDeImagen(verImagenes(28))
        PictureBox29.Image = Image.FromFile(My.Application.Info.DirectoryPath + ImgPred)
        Jugada(verImagenes(28), 29)
    End Sub

    Private Sub PictureBox31_Click(sender As Object, e As EventArgs) Handles PictureBox31.Click
        VistaDeImagen(verImagenes(30))
        PictureBox31.Image = Image.FromFile(My.Application.Info.DirectoryPath + ImgPred)
        Jugada(verImagenes(30), 31)
    End Sub

    Private Sub PictureBox32_Click(sender As Object, e As EventArgs) Handles PictureBox32.Click
        VistaDeImagen(verImagenes(31))
        PictureBox32.Image = Image.FromFile(My.Application.Info.DirectoryPath + ImgPred)
        Jugada(verImagenes(31), 32)
    End Sub

    Private Sub PictureBox33_Click(sender As Object, e As EventArgs) Handles PictureBox33.Click
        VistaDeImagen(verImagenes(32))
        PictureBox33.Image = Image.FromFile(My.Application.Info.DirectoryPath + ImgPred)
        Jugada(verImagenes(32), 33)
    End Sub

    Private Sub PictureBox34_Click(sender As Object, e As EventArgs) Handles PictureBox34.Click
        VistaDeImagen(verImagenes(33))
        PictureBox34.Image = Image.FromFile(My.Application.Info.DirectoryPath + ImgPred)
        Jugada(verImagenes(33), 34)
    End Sub

    Private Sub PictureBox35_Click(sender As Object, e As EventArgs) Handles PictureBox35.Click
        VistaDeImagen(verImagenes(34))
        PictureBox35.Image = Image.FromFile(My.Application.Info.DirectoryPath + ImgPred)
        Jugada(verImagenes(34), 35)
    End Sub

    Private Sub PictureBox36_Click(sender As Object, e As EventArgs) Handles PictureBox36.Click
        VistaDeImagen(verImagenes(35))
        PictureBox36.Image = Image.FromFile(My.Application.Info.DirectoryPath + ImgPred)
        Jugada(verImagenes(35), 36)
    End Sub

    Private Sub PictureBox37_Click(sender As Object, e As EventArgs) Handles PictureBox37.Click
        VistaDeImagen(verImagenes(36))
        PictureBox37.Image = Image.FromFile(My.Application.Info.DirectoryPath + ImgPred)
        Jugada(verImagenes(36), 37)
    End Sub

    Private Sub PictureBox38_Click(sender As Object, e As EventArgs) Handles PictureBox38.Click
        VistaDeImagen(verImagenes(37))
        PictureBox38.Image = Image.FromFile(My.Application.Info.DirectoryPath + ImgPred)
        Jugada(verImagenes(37), 38)
    End Sub

    Private Sub PictureBox39_Click(sender As Object, e As EventArgs) Handles PictureBox39.Click
        VistaDeImagen(verImagenes(38))
        PictureBox39.Image = Image.FromFile(My.Application.Info.DirectoryPath + ImgPred)
        Jugada(verImagenes(38), 39)
    End Sub

    Private Sub PictureBox40_Click(sender As Object, e As EventArgs) Handles PictureBox40.Click
        VistaDeImagen(verImagenes(39))
        PictureBox40.Image = Image.FromFile(My.Application.Info.DirectoryPath + ImgPred)
        Jugada(verImagenes(39), 40)
    End Sub

    Private Sub Pb2_Click(sender As Object, e As EventArgs) Handles pb2.Click
        My.Computer.Audio.Stop()
    End Sub

    Private Sub Pb1_Click(sender As Object, e As EventArgs) Handles pb1.Click
        My.Computer.Audio.Play(My.Resources.SonidoL3, AudioPlayMode.BackgroundLoop)
    End Sub

    Public Sub Jugada(ByVal Ni As Integer, ByVal numpic As Integer)

        x = x + 1
        If x = 1 Then
            int1 = Ni
            select1 = numpic
        End If
        If x = 2 Then
            int2 = Ni
            select2 = numpic

            If int1 = int2 Then


                cont += 1

            Else
                MsgBox("No son iguales")

                Termina_Jugada(select1)
                Termina_Jugada(select2)

            End If
            x = 0
        End If
        If cont = 20 And cont >= 20 Then

            Timer1.Stop()
            tiempo = Label5.Text + Label7.Text + Label6.Text
            WinPokemon.Show()
            Me.Hide()
            Random_img()


        End If



    End Sub



    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        VistaDeImagen(verImagenes(0))
        PictureBox1.Image = Image.FromFile(My.Application.Info.DirectoryPath + ImgPred)
        Jugada(verImagenes(0), 1)
    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Label5.Text = "00"
        Label6.Text = "00"
        ImgPred = "\Pokemon\0.jpg"

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
        PictureBox21.Image = Image.FromFile(My.Application.Info.DirectoryPath + ImgPred)
        PictureBox22.Image = Image.FromFile(My.Application.Info.DirectoryPath + ImgPred)
        PictureBox23.Image = Image.FromFile(My.Application.Info.DirectoryPath + ImgPred)
        PictureBox24.Image = Image.FromFile(My.Application.Info.DirectoryPath + ImgPred)
        PictureBox25.Image = Image.FromFile(My.Application.Info.DirectoryPath + ImgPred)
        PictureBox26.Image = Image.FromFile(My.Application.Info.DirectoryPath + ImgPred)
        PictureBox27.Image = Image.FromFile(My.Application.Info.DirectoryPath + ImgPred)
        PictureBox28.Image = Image.FromFile(My.Application.Info.DirectoryPath + ImgPred)
        PictureBox29.Image = Image.FromFile(My.Application.Info.DirectoryPath + ImgPred)
        PictureBox30.Image = Image.FromFile(My.Application.Info.DirectoryPath + ImgPred)
        PictureBox31.Image = Image.FromFile(My.Application.Info.DirectoryPath + ImgPred)
        PictureBox32.Image = Image.FromFile(My.Application.Info.DirectoryPath + ImgPred)
        PictureBox33.Image = Image.FromFile(My.Application.Info.DirectoryPath + ImgPred)
        PictureBox34.Image = Image.FromFile(My.Application.Info.DirectoryPath + ImgPred)
        PictureBox35.Image = Image.FromFile(My.Application.Info.DirectoryPath + ImgPred)
        PictureBox36.Image = Image.FromFile(My.Application.Info.DirectoryPath + ImgPred)
        PictureBox37.Image = Image.FromFile(My.Application.Info.DirectoryPath + ImgPred)
        PictureBox38.Image = Image.FromFile(My.Application.Info.DirectoryPath + ImgPred)
        PictureBox39.Image = Image.FromFile(My.Application.Info.DirectoryPath + ImgPred)
        PictureBox40.Image = Image.FromFile(My.Application.Info.DirectoryPath + ImgPred)
        My.Computer.Audio.Play(My.Resources.SonidoL3, AudioPlayMode.BackgroundLoop)
        x = 0

        cont = 0
        Random_img()

        inicio.Show()
        Me.Hide()


    End Sub

    Private Sub Pokemon_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        My.Computer.Audio.Play(My.Resources.SonidoL3, AudioPlayMode.BackgroundLoop)

        Timer1.Start()




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
        verImagenes(12) = 13
        verImagenes(13) = 14
        verImagenes(14) = 15
        verImagenes(15) = 16
        verImagenes(16) = 17
        verImagenes(17) = 18
        verImagenes(18) = 19
        verImagenes(19) = 20
        verImagenes(20) = 1
        verImagenes(21) = 2
        verImagenes(22) = 3
        verImagenes(23) = 4
        verImagenes(24) = 5
        verImagenes(25) = 6
        verImagenes(26) = 7
        verImagenes(27) = 8
        verImagenes(28) = 9
        verImagenes(29) = 10
        verImagenes(30) = 11
        verImagenes(31) = 12
        verImagenes(32) = 13
        verImagenes(33) = 14
        verImagenes(34) = 15
        verImagenes(35) = 16
        verImagenes(36) = 17
        verImagenes(37) = 18
        verImagenes(38) = 19
        verImagenes(39) = 20


        Random_img()

        s = 0
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label6.Text += 1
        If Label6.Text = "60" Then

            Label5.Text += 1
            Label6.Text = "00"
        End If
    End Sub
End Class