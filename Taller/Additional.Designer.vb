<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Additional
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Title1 As System.Windows.Forms.DataVisualization.Charting.Title = New System.Windows.Forms.DataVisualization.Charting.Title()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.velocidadInicialText = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.anguloInicialText = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.posicionYText = New System.Windows.Forms.TextBox()
        Me.posicionXText = New System.Windows.Forms.TextBox()
        Me.gravedadText = New System.Windows.Forms.TextBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.iteracionLabel = New System.Windows.Forms.Label()
        Me.intervaloLabel = New System.Windows.Forms.Label()
        Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.btnAdelante = New System.Windows.Forms.Button()
        Me.btnAtras = New System.Windows.Forms.Button()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Image = Global.Taller.My.Resources.Resources.play
        Me.Button1.Location = New System.Drawing.Point(756, 9)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(62, 62)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = " "
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(880, 329)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(20, 13)
        Me.Label1.TabIndex = 60
        Me.Label1.Text = "Vo"
        '
        'velocidadInicialText
        '
        Me.velocidadInicialText.Location = New System.Drawing.Point(928, 322)
        Me.velocidadInicialText.Name = "velocidadInicialText"
        Me.velocidadInicialText.Size = New System.Drawing.Size(100, 20)
        Me.velocidadInicialText.TabIndex = 59
        Me.velocidadInicialText.Text = "25"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(894, 254)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(102, 13)
        Me.Label7.TabIndex = 58
        Me.Label7.Text = "Introduzca los datos"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(880, 303)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(40, 13)
        Me.Label8.TabIndex = 57
        Me.Label8.Text = "Ángulo"
        '
        'anguloInicialText
        '
        Me.anguloInicialText.Location = New System.Drawing.Point(928, 296)
        Me.anguloInicialText.Name = "anguloInicialText"
        Me.anguloInicialText.Size = New System.Drawing.Size(100, 20)
        Me.anguloInicialText.TabIndex = 56
        Me.anguloInicialText.Text = "25"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(1039, 277)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(20, 13)
        Me.Label9.TabIndex = 51
        Me.Label9.Text = "Yo"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(1039, 303)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(20, 13)
        Me.Label10.TabIndex = 52
        Me.Label10.Text = "Xo"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(879, 277)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(15, 13)
        Me.Label13.TabIndex = 55
        Me.Label13.Text = "G"
        '
        'posicionYText
        '
        Me.posicionYText.Location = New System.Drawing.Point(1088, 270)
        Me.posicionYText.Name = "posicionYText"
        Me.posicionYText.Size = New System.Drawing.Size(100, 20)
        Me.posicionYText.TabIndex = 46
        Me.posicionYText.Text = "1"
        '
        'posicionXText
        '
        Me.posicionXText.Location = New System.Drawing.Point(1088, 296)
        Me.posicionXText.Name = "posicionXText"
        Me.posicionXText.Size = New System.Drawing.Size(100, 20)
        Me.posicionXText.TabIndex = 47
        Me.posicionXText.Text = "1"
        '
        'gravedadText
        '
        Me.gravedadText.Location = New System.Drawing.Point(928, 270)
        Me.gravedadText.Name = "gravedadText"
        Me.gravedadText.Size = New System.Drawing.Size(100, 20)
        Me.gravedadText.TabIndex = 50
        Me.gravedadText.Text = "10"
        '
        'Timer1
        '
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(938, 373)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(115, 13)
        Me.Label2.TabIndex = 63
        Me.Label2.Text = "Intervalo del timer (ms):"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(938, 347)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(129, 13)
        Me.Label3.TabIndex = 64
        Me.Label3.Text = "Tiempo entre iteración (s):"
        '
        'iteracionLabel
        '
        Me.iteracionLabel.AutoSize = True
        Me.iteracionLabel.Location = New System.Drawing.Point(1073, 347)
        Me.iteracionLabel.Name = "iteracionLabel"
        Me.iteracionLabel.Size = New System.Drawing.Size(48, 13)
        Me.iteracionLabel.TabIndex = 61
        Me.iteracionLabel.Text = "Iteracion"
        '
        'intervaloLabel
        '
        Me.intervaloLabel.AutoSize = True
        Me.intervaloLabel.Location = New System.Drawing.Point(1073, 373)
        Me.intervaloLabel.Name = "intervaloLabel"
        Me.intervaloLabel.Size = New System.Drawing.Size(48, 13)
        Me.intervaloLabel.TabIndex = 62
        Me.intervaloLabel.Text = "Intervalo"
        '
        'Chart1
        '
        ChartArea1.AxisX.Title = "Tiempo"
        ChartArea1.AxisY.Title = "Posición Y"
        ChartArea1.Name = "ChartArea1"
        Me.Chart1.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Legend1"
        Me.Chart1.Legends.Add(Legend1)
        Me.Chart1.Location = New System.Drawing.Point(882, 12)
        Me.Chart1.Name = "Chart1"
        Series1.ChartArea = "ChartArea1"
        Series1.Legend = "Legend1"
        Series1.Name = "Series1"
        Me.Chart1.Series.Add(Series1)
        Me.Chart1.Size = New System.Drawing.Size(300, 225)
        Me.Chart1.TabIndex = 65
        Me.Chart1.Text = "Chart1"
        Title1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Title1.Name = "Title1"
        Title1.Text = "T vs Y"
        Me.Chart1.Titles.Add(Title1)
        '
        'btnAdelante
        '
        Me.btnAdelante.Image = Global.Taller.My.Resources.Resources.Adelante
        Me.btnAdelante.Location = New System.Drawing.Point(819, 12)
        Me.btnAdelante.Name = "btnAdelante"
        Me.btnAdelante.Size = New System.Drawing.Size(57, 57)
        Me.btnAdelante.TabIndex = 66
        Me.btnAdelante.UseVisualStyleBackColor = True
        '
        'btnAtras
        '
        Me.btnAtras.Image = Global.Taller.My.Resources.Resources.atras
        Me.btnAtras.Location = New System.Drawing.Point(696, 12)
        Me.btnAtras.Name = "btnAtras"
        Me.btnAtras.Size = New System.Drawing.Size(57, 57)
        Me.btnAtras.TabIndex = 67
        Me.btnAtras.UseVisualStyleBackColor = True
        '
        'Additional
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1200, 450)
        Me.Controls.Add(Me.btnAtras)
        Me.Controls.Add(Me.btnAdelante)
        Me.Controls.Add(Me.Chart1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.iteracionLabel)
        Me.Controls.Add(Me.intervaloLabel)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.velocidadInicialText)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.anguloInicialText)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.posicionYText)
        Me.Controls.Add(Me.posicionXText)
        Me.Controls.Add(Me.gravedadText)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Additional"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form2"
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents velocidadInicialText As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents anguloInicialText As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents posicionYText As TextBox
    Friend WithEvents posicionXText As TextBox
    Friend WithEvents gravedadText As TextBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents iteracionLabel As Label
    Friend WithEvents intervaloLabel As Label
    Friend WithEvents Chart1 As DataVisualization.Charting.Chart
    Friend WithEvents btnAdelante As Button
    Friend WithEvents btnAtras As Button
End Class
