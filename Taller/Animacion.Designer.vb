<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Animacion
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBox_Ang = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox_Yo = New System.Windows.Forms.TextBox()
        Me.TextBox_Xo = New System.Windows.Forms.TextBox()
        Me.TextBox_G = New System.Windows.Forms.TextBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.punto = New System.Windows.Forms.Label()
        Me.TextBox_Vo = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.reset = New System.Windows.Forms.Button()
        Me.Balon = New System.Windows.Forms.PictureBox()
        Me.Suelo = New System.Windows.Forms.PictureBox()
        Me.Boton_Atras = New System.Windows.Forms.Button()
        Me.Boton_Adelante = New System.Windows.Forms.Button()
        Me.Button_PyP = New System.Windows.Forms.Button()
        Me.intervaloLabel = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.iteracionLabel = New System.Windows.Forms.Label()
        CType(Me.Balon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Suelo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(71, 48)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(40, 13)
        Me.Label6.TabIndex = 30
        Me.Label6.Text = "Ángulo"
        '
        'TextBox_Ang
        '
        Me.TextBox_Ang.Location = New System.Drawing.Point(145, 44)
        Me.TextBox_Ang.Name = "TextBox_Ang"
        Me.TextBox_Ang.Size = New System.Drawing.Size(100, 20)
        Me.TextBox_Ang.TabIndex = 29
        Me.TextBox_Ang.Text = "25"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(267, 48)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(20, 13)
        Me.Label5.TabIndex = 21
        Me.Label5.Text = "Yo"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(267, 22)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(20, 13)
        Me.Label4.TabIndex = 22
        Me.Label4.Text = "Xo"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(71, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(15, 13)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "G"
        '
        'TextBox_Yo
        '
        Me.TextBox_Yo.Location = New System.Drawing.Point(308, 41)
        Me.TextBox_Yo.Name = "TextBox_Yo"
        Me.TextBox_Yo.Size = New System.Drawing.Size(100, 20)
        Me.TextBox_Yo.TabIndex = 16
        Me.TextBox_Yo.Text = "0"
        '
        'TextBox_Xo
        '
        Me.TextBox_Xo.Location = New System.Drawing.Point(308, 15)
        Me.TextBox_Xo.Name = "TextBox_Xo"
        Me.TextBox_Xo.Size = New System.Drawing.Size(100, 20)
        Me.TextBox_Xo.TabIndex = 17
        Me.TextBox_Xo.Text = "0"
        '
        'TextBox_G
        '
        Me.TextBox_G.Location = New System.Drawing.Point(146, 15)
        Me.TextBox_G.Name = "TextBox_G"
        Me.TextBox_G.Size = New System.Drawing.Size(100, 20)
        Me.TextBox_G.TabIndex = 20
        Me.TextBox_G.Text = "10"
        '
        'Timer1
        '
        '
        'punto
        '
        Me.punto.AutoSize = True
        Me.punto.Location = New System.Drawing.Point(68, 457)
        Me.punto.Name = "punto"
        Me.punto.Size = New System.Drawing.Size(29, 13)
        Me.punto.TabIndex = 34
        Me.punto.Text = "(x, y)"
        '
        'TextBox_Vo
        '
        Me.TextBox_Vo.Location = New System.Drawing.Point(145, 74)
        Me.TextBox_Vo.Name = "TextBox_Vo"
        Me.TextBox_Vo.Size = New System.Drawing.Size(100, 20)
        Me.TextBox_Vo.TabIndex = 35
        Me.TextBox_Vo.Text = "0"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(76, 81)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(20, 13)
        Me.Label7.TabIndex = 36
        Me.Label7.Text = "Vo"
        '
        'reset
        '
        Me.reset.Image = Global.Taller.My.Resources.Resources.reiniciar
        Me.reset.Location = New System.Drawing.Point(904, 12)
        Me.reset.Name = "reset"
        Me.reset.Size = New System.Drawing.Size(62, 58)
        Me.reset.TabIndex = 37
        Me.reset.UseVisualStyleBackColor = True
        '
        'Balon
        '
        Me.Balon.Image = Global.Taller.My.Resources.Resources.balon
        Me.Balon.Location = New System.Drawing.Point(1, 473)
        Me.Balon.Name = "Balon"
        Me.Balon.Size = New System.Drawing.Size(67, 65)
        Me.Balon.TabIndex = 33
        Me.Balon.TabStop = False
        '
        'Suelo
        '
        Me.Suelo.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Suelo.Location = New System.Drawing.Point(1, 538)
        Me.Suelo.Name = "Suelo"
        Me.Suelo.Size = New System.Drawing.Size(982, 22)
        Me.Suelo.TabIndex = 32
        Me.Suelo.TabStop = False
        '
        'Boton_Atras
        '
        Me.Boton_Atras.Image = Global.Taller.My.Resources.Resources.atras
        Me.Boton_Atras.Location = New System.Drawing.Point(711, 12)
        Me.Boton_Atras.Name = "Boton_Atras"
        Me.Boton_Atras.Size = New System.Drawing.Size(59, 58)
        Me.Boton_Atras.TabIndex = 28
        Me.Boton_Atras.UseVisualStyleBackColor = True
        '
        'Boton_Adelante
        '
        Me.Boton_Adelante.Image = Global.Taller.My.Resources.Resources.Adelante
        Me.Boton_Adelante.Location = New System.Drawing.Point(841, 12)
        Me.Boton_Adelante.Name = "Boton_Adelante"
        Me.Boton_Adelante.Size = New System.Drawing.Size(57, 58)
        Me.Boton_Adelante.TabIndex = 27
        Me.Boton_Adelante.UseVisualStyleBackColor = True
        '
        'Button_PyP
        '
        Me.Button_PyP.BackColor = System.Drawing.Color.Transparent
        Me.Button_PyP.Image = Global.Taller.My.Resources.Resources.play
        Me.Button_PyP.Location = New System.Drawing.Point(776, 12)
        Me.Button_PyP.Name = "Button_PyP"
        Me.Button_PyP.Size = New System.Drawing.Size(59, 58)
        Me.Button_PyP.TabIndex = 26
        Me.Button_PyP.UseVisualStyleBackColor = False
        '
        'intervaloLabel
        '
        Me.intervaloLabel.AutoSize = True
        Me.intervaloLabel.Location = New System.Drawing.Point(586, 44)
        Me.intervaloLabel.Name = "intervaloLabel"
        Me.intervaloLabel.Size = New System.Drawing.Size(48, 13)
        Me.intervaloLabel.TabIndex = 38
        Me.intervaloLabel.Text = "Intervalo"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(439, 44)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(115, 13)
        Me.Label9.TabIndex = 48
        Me.Label9.Text = "Intervalo del timer (ms):"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(439, 18)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(129, 13)
        Me.Label10.TabIndex = 49
        Me.Label10.Text = "Tiempo entre iteración (s):"
        '
        'iteracionLabel
        '
        Me.iteracionLabel.AutoSize = True
        Me.iteracionLabel.Location = New System.Drawing.Point(586, 18)
        Me.iteracionLabel.Name = "iteracionLabel"
        Me.iteracionLabel.Size = New System.Drawing.Size(48, 13)
        Me.iteracionLabel.TabIndex = 38
        Me.iteracionLabel.Text = "Iteracion"
        '
        'Animacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(984, 561)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.iteracionLabel)
        Me.Controls.Add(Me.intervaloLabel)
        Me.Controls.Add(Me.reset)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TextBox_Vo)
        Me.Controls.Add(Me.punto)
        Me.Controls.Add(Me.Balon)
        Me.Controls.Add(Me.Suelo)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TextBox_Ang)
        Me.Controls.Add(Me.Boton_Atras)
        Me.Controls.Add(Me.Boton_Adelante)
        Me.Controls.Add(Me.Button_PyP)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox_Yo)
        Me.Controls.Add(Me.TextBox_Xo)
        Me.Controls.Add(Me.TextBox_G)
        Me.Name = "Animacion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form2"
        CType(Me.Balon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Suelo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label6 As Label
    Friend WithEvents TextBox_Ang As TextBox
    Friend WithEvents Boton_Atras As Button
    Friend WithEvents Boton_Adelante As Button
    Friend WithEvents Button_PyP As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox_Yo As TextBox
    Friend WithEvents TextBox_Xo As TextBox
    Friend WithEvents TextBox_G As TextBox
    Friend WithEvents Balon As PictureBox
    Friend WithEvents Suelo As PictureBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents punto As Label
    Friend WithEvents TextBox_Vo As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents reset As Button
    Friend WithEvents intervaloLabel As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents iteracionLabel As Label
End Class
