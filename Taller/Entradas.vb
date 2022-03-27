Public Class Entradas
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim gravedad As Double = gravedadText.Text
        Dim angulo As Double = anguloInicialText.Text
        Dim x As Double = posicionXText.Text
        Dim y As Double = posicionYText.Text
        Dim Vo As Double = velocidadInicialText.Text
        Dim intervalo As Double = intervaloText.Text
        Dim iteracion As Double = iteracionText.Text

        If gravedad > 0 Then
            If angulo >= 0 Then
                If angulo <= 90 Then
                    If x >= 0 Then
                        If y >= 0 Then
                            If Vo > 0 Then
                                If iteracion > 0 Then
                                    If intervalo > 0 Then
                                        Animacion.Show()
                                        Animacion.TextBox_G.Text = gravedad.ToString
                                        Animacion.TextBox_Ang.Text = angulo.ToString
                                        Animacion.TextBox_Xo.Text = x.ToString
                                        Animacion.TextBox_Yo.Text = y.ToString
                                        Animacion.TextBox_Vo.Text = Vo.ToString
                                        Animacion.intervaloLabel.Text = intervalo.ToString
                                        Animacion.iteracionLabel.Text = iteracion.ToString
                                        Animacion.Timer1.Interval = intervalo
                                    Else
                                        MsgBox("El tiempo para cada intervalo del Timer debe ser mayor a 0 milisegundos")
                                    End If
                                Else
                                    MsgBox("El tiempo para cada iteración debe ser mayor a 0 segundos")
                                End If
                            Else
                                MsgBox("La velocidad incial debe ser mayor a 0")
                            End If
                        Else
                            MsgBox("La posición incial en y debe ser igual o mayor a 0")
                        End If
                    Else
                        MsgBox("La posición incial en x debe ser igual o mayor a 0")
                    End If
                Else
                    MsgBox("El ángulo debe ser menor o igual a 90")
                End If
            Else
                MsgBox("El ángulo debe ser mayor o igual 0")
            End If
        Else
            MsgBox("La gravedad debe ser mayor a 0")
        End If
    End Sub

    Private Sub adicional_Click(sender As Object, e As EventArgs) Handles adicional.Click
        Dim gravedad As Double = gravedadText.Text
        Dim angulo As Double = anguloInicialText.Text
        Dim x As Double = posicionXText.Text
        Dim y As Double = posicionYText.Text
        Dim Vo As Double = velocidadInicialText.Text
        Dim intervalo As Double = intervaloText.Text
        Dim iteracion As Double = iteracionText.Text

        If gravedad > 0 Then
            If angulo >= 0 Then
                If angulo <= 90 Then
                    If x >= 0 Then
                        If y >= 0 Then
                            If Vo > 0 Then
                                If iteracion > 0 Then
                                    If intervalo > 0 Then
                                        Additional.Show()
                                        Additional.gravedadText.Text = gravedad.ToString
                                        Additional.anguloInicialText.Text = angulo.ToString
                                        Additional.posicionXText.Text = x.ToString
                                        Additional.posicionYText.Text = y.ToString
                                        Additional.velocidadInicialText.Text = Vo.ToString
                                        Additional.intervaloLabel.Text = intervalo.ToString
                                        Additional.iteracionLabel.Text = iteracion.ToString
                                        Additional.Timer1.Interval = intervalo
                                    Else
                                        MsgBox("El tiempo para cada intervalo del Timer debe ser mayor a 0 milisegundos")
                                    End If
                                Else
                                    MsgBox("El tiempo para cada iteración debe ser mayor a 0 segundos")
                                End If
                            Else
                                MsgBox("La velocidad incial debe ser mayor a 0")
                            End If
                        Else
                            MsgBox("La posición incial en y debe ser igual o mayor a 0")
                        End If
                    Else
                        MsgBox("La posición incial en x debe ser igual o mayor a 0")
                    End If
                Else
                    MsgBox("El ángulo debe ser menor o igual a 90")
                End If
            Else
                MsgBox("El ángulo debe ser mayor o igual 0")
            End If
        Else
            MsgBox("La gravedad debe ser mayor a 0")
        End If
    End Sub
End Class