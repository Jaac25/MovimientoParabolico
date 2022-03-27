Public Class Animacion
    Dim X0, Y0, g, angulo, Vo, angRad As Double
    Dim t As Double = 0
    Dim x, y As Double
    Dim posY0 As Integer
    Dim i As Integer = 0
    Dim iteracion As Double = Entradas.iteracionText.Text
    Dim play As Boolean = True

    Dim adelante As Boolean = True

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        'ECUACIONES
        Dim Vx As Double = Vo * Math.Cos(angRad)
        Dim Vy As Double = Vo * Math.Sin(angRad)
        x = X0 + Vx * t
        y = Y0 + Vy * t - 1 / 2 * g * t ^ 2

        Button_PyP.Image = My.Resources.Pause

        If adelante Then
            If y <= 0 Then
                Timer1.Enabled = False
                play = True

                Button_PyP.Image = My.Resources.play
            Else
                Dim velY As Double = Vo * Math.Sin(angRad) - g * t
                If velY < 0 Then
                    velY = velY * -1
                End If

                Dim velX As Double = Vo * Math.Cos(angRad)
                Dim angR = ((velY / velX) * Math.PI) / 180
                Dim ang As Double = Math.Atan(angR) ^ -1

                'Dim ang As Double = Math.Atan(angR)

                'RESULTADOS EN TABLA GRANDE
                Datos.Tabla.Rows.Add()
                If i >= 0 Then
                    Datos.Tabla.Item(0, i).Value = t
                    Datos.Tabla.Item(1, i).Value = x
                    Datos.Tabla.Item(2, i).Value = y
                    Datos.Tabla.Item(3, i).Value = velY
                    Datos.Tabla.Item(4, i).Value = ang
                End If


                'Agregar al chart
                Graficos.DisTiem_X_chart.Series(0).Points.AddXY(t, x)
                Graficos.DisTiem_Y_chart.Series(0).Points.AddXY(t, y)
                Graficos.VelTiem_X_chart.Series(0).Points.AddXY(t, velX)
                Graficos.VelTiem_Y_chart.Series(0).Points.AddXY(t, velY)

                Graficos.DisTiem_X_chart.Series(0).ToolTip = "t: #VALX, X: #VALY"
                Graficos.DisTiem_Y_chart.Series(0).ToolTip = "t: #VALX, Y: #VALY"
                Graficos.VelTiem_X_chart.Series(0).ToolTip = "t: #VALX, V: #VALY"
                Graficos.VelTiem_Y_chart.Series(0).ToolTip = "t: #VALX, V: #VALY"

                'Animación
                punto.Text = "(" + Math.Round(x, 3).ToString + ", " + Math.Round(y, 3).ToString + ")"
                punto.Location = New Point(x + Balon.Height, posY0 - y)
                Balon.Location = New Point(x, posY0 - y - Balon.Height)

                'RESULTADOS EN TABLA PEQUEÑA
                Dim Ymax As Double = (Vo ^ 2 * (Math.Sin(angRad)) ^ 2) / (2 * g)
                Datos.DatosTabla.Rows.Add()
                Datos.DatosTabla.Item(0, 0).Value = Math.Round(t, 3)
                Datos.DatosTabla.Item(1, 0).Value = Ymax
                Datos.DatosTabla.Item(2, 0).Value = Math.Sqrt(velY ^ 2 + velX ^ 2)
                Datos.DatosTabla.Item(3, 0).Value = ang

                t += iteracion
                i += 1

                Balon.Text = "(" + x.ToString + ", " + y.ToString + ")"
            End If
        Else
            Dim xx As Integer = x
            If xx > X0 Then
                i -= 1
                If i >= 0 Then
                    Datos.Tabla.Rows.RemoveAt(i)

                    Graficos.DisTiem_X_chart.Series(0).Points.RemoveAt(i)
                    Graficos.DisTiem_Y_chart.Series(0).Points.RemoveAt(i)
                    Graficos.VelTiem_X_chart.Series(0).Points.RemoveAt(i)
                    Graficos.VelTiem_Y_chart.Series(0).Points.RemoveAt(i)
                End If

                Button_PyP.Image = My.Resources.Pause

                Datos.DatosTabla.Item(0, 0).Value = Math.Round(t, 3)

                'Animación
                punto.Text = "(" + Math.Round(x, 3).ToString + ", " + Math.Round(y, 3).ToString + ")"
                punto.Location = New Point(x + Balon.Height, posY0 - y)
                Balon.Location = New Point(x, posY0 - y - Balon.Height)

                t -= iteracion
            ElseIf xx = X0 Then
                'Animación
                punto.Text = "(" + Math.Round(x, 3).ToString + ", " + Math.Round(y, 3).ToString + ")"
                punto.Location = New Point(x + Balon.Height, posY0 - y)
                Balon.Location = New Point(x, posY0 - y - Balon.Height)

                t = 0
                play = True
                Button_PyP.Image = My.Resources.play
                Timer1.Enabled = False
            Else
                play = True
                Button_PyP.Image = My.Resources.play
                Timer1.Enabled = False
            End If

        End If
    End Sub

    Private Sub Boton_Adelante_Click(sender As Object, e As EventArgs) Handles Boton_Adelante.Click
        'VALORES INICIALES
        X0 = Val(TextBox_Xo.Text)
        Y0 = Val(TextBox_Yo.Text)
        g = Val(TextBox_G.Text)
        angulo = Val(TextBox_Ang.Text)
        Vo = Val(TextBox_Vo.Text)
        angRad = angulo * Math.PI / 180
        adelante = True

        play = False
        Button_PyP.Image = My.Resources.Pause
        Timer1.Enabled = True
    End Sub

    Private Sub Button_PyP_Click(sender As Object, e As EventArgs) Handles Button_PyP.Click
        If play Then
            play = False
            Button_PyP.Image = My.Resources.Pause

            'VALORES INICIALES
            X0 = Val(TextBox_Xo.Text)
            Y0 = Val(TextBox_Yo.Text)
            g = Val(TextBox_G.Text)
            angulo = Val(TextBox_Ang.Text)
            Vo = Val(TextBox_Vo.Text)
            angRad = angulo * Math.PI / 180

            Datos.DatosTabla.Rows.Add()

            Timer1.Enabled = True

        Else
            play = True

            Button_PyP.Image = My.Resources.play

            Timer1.Enabled = False
        End If
    End Sub

    Private Sub Boton_Atras_Click(sender As Object, e As EventArgs) Handles Boton_Atras.Click
        adelante = False
        play = False
        Timer1.Enabled = True
    End Sub

    Private Sub reset_Click(sender As Object, e As EventArgs) Handles reset.Click
        adelante = True
        play = True
        Timer1.Enabled = False
        t = 0
        i = 0

        'Animación
        posY0 = Suelo.Location.Y
        punto.Text = "(" + Math.Round(X0, 3).ToString + ", " + Math.Round(Y0, 3).ToString + ")"
        punto.Location = New Point(X0 + Balon.Height, posY0)
        Balon.Location = New Point(X0, posY0 - Balon.Height)
    End Sub

    Private Sub TextBox_Xo_TextChanged(sender As Object, e As EventArgs)
        Balon.Location = New Point(Val(TextBox_Xo.Text), Balon.Location.Y)
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        posY0 = Suelo.Location.Y
        Graficos.Show()
        Datos.Show()
    End Sub

    Private Sub TextBox_Yo_TextChanged(sender As Object, e As EventArgs)
        Balon.Location = New Point(Balon.Location.X,
                                   posY0 - Val(TextBox_Yo.Text) - Balon.Height)
    End Sub

End Class