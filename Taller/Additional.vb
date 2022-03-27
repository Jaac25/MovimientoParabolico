Public Class Additional
    Dim g As Graphics
    Dim gr As Graphics

    Dim X0, Y0, gra, angulo, Vo, angRad As Double
    Dim t As Double = 0
    Dim x, y As Double
    Dim play As Boolean = True

    Dim adelante As Boolean = True
    Dim i As Integer = 0
    Dim iteracion As Double = Entradas.iteracionText.Text

    Private Sub Additional_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        g = Me.CreateGraphics()
        gr = Me.CreateGraphics()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If play Then
            play = False
            Button1.Image = My.Resources.Pause

            'VALORES INICIALES
            X0 = Val(posicionXText.Text)
            Y0 = Val(posicionYText.Text)
            gra = Val(gravedadText.Text)
            angulo = Val(anguloInicialText.Text)
            Vo = Val(velocidadInicialText.Text)
            angRad = angulo * Math.PI / 180

            Dim posX As Integer = x
            Dim posY As Integer = Me.Size.Height - y
            g.FillEllipse(Brushes.Red, posX, posY - 100, 20, 20)

            Chart1.Series(0).Points.Clear()

            Timer1.Enabled = True
        Else
            play = True
            Button1.Image = My.Resources.play
            Timer1.Enabled = False
        End If

    End Sub

    Private Sub btnAdelante_Click(sender As Object, e As EventArgs) Handles btnAdelante.Click
        'VALORES INICIALES
        X0 = Val(posicionXText.Text)
        Y0 = Val(posicionYText.Text)
        gra = Val(gravedadText.Text)
        angulo = Val(anguloInicialText.Text)
        Vo = Val(velocidadInicialText.Text)
        angRad = angulo * Math.PI / 180
        adelante = True

        play = False
        Button1.Image = My.Resources.Pause
        Timer1.Enabled = True
    End Sub

    Private Sub btnAtras_Click(sender As Object, e As EventArgs) Handles btnAtras.Click
        adelante = False
        play = False
        Timer1.Enabled = True
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim Vx As Double = Vo * Math.Cos(angRad)
        Dim Vy As Double = Vo * Math.Sin(angRad)
        x = X0 + Vx * t
        y = Y0 + Vy * t - 1 / 2 * gra * t ^ 2


        If adelante Then
            If y <= 0 Then
                Timer1.Enabled = False
                play = True

                Button1.Image = My.Resources.play
            Else
                Dim posX As Integer = x
                Dim posY As Integer = Me.Size.Height - y

                gr.FillRectangle(Brushes.GreenYellow, 0, Me.Size.Height - 80, Me.Size.Width, 80)
                If y >= 0 Then

                    g.FillEllipse(Brushes.Red, posX, posY - 100, 20, 20)

                    Chart1.Series(0).Points.AddXY(t, y)
                    Chart1.Series(0).ToolTip = "t: #VALX, Y: #VALY"
                    t += iteracion
                    i += 1
                Else
                    Timer1.Enabled = False
                End If
            End If
        Else
            Dim xx As Integer = x
            If xx > X0 Then
                Dim posX As Integer = x
                Dim posY As Integer = Me.Size.Height - y
                g.FillEllipse(Brushes.WhiteSmoke, posX, posY - 100, 20, 20)
                Console.WriteLine(i)
                If i >= 0 Then
                    Chart1.Series(0).Points.RemoveAt(i - 1)
                End If
                t -= iteracion
                i -= 1
            ElseIf xx = X0 Then
                'Animación
                Dim posX As Integer = x
                Dim posY As Integer = Me.Size.Height - y
                Dim newX As Integer = X0
                Dim newY As Integer = Me.Size.Height - Y0
                g.FillEllipse(Brushes.WhiteSmoke, posX, posY - 100, 20, 20)
                g.FillEllipse(Brushes.WhiteSmoke, newX, newY, 20, 20)

                t = 0
                play = True
                Button1.Image = My.Resources.play
                Timer1.Enabled = False
            Else
                play = True
                Button1.Image = My.Resources.play
                Timer1.Enabled = False
            End If
        End If
    End Sub
End Class