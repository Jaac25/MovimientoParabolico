<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Graficos
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
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Title1 As System.Windows.Forms.DataVisualization.Charting.Title = New System.Windows.Forms.DataVisualization.Charting.Title()
        Dim ChartArea2 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend2 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series2 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Title2 As System.Windows.Forms.DataVisualization.Charting.Title = New System.Windows.Forms.DataVisualization.Charting.Title()
        Dim ChartArea3 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend3 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series3 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Title3 As System.Windows.Forms.DataVisualization.Charting.Title = New System.Windows.Forms.DataVisualization.Charting.Title()
        Dim ChartArea4 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend4 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series4 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Title4 As System.Windows.Forms.DataVisualization.Charting.Title = New System.Windows.Forms.DataVisualization.Charting.Title()
        Me.DisTiem_X_chart = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.DisTiem_Y_chart = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.VelTiem_X_chart = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.VelTiem_Y_chart = New System.Windows.Forms.DataVisualization.Charting.Chart()
        CType(Me.DisTiem_X_chart, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DisTiem_Y_chart, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VelTiem_X_chart, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VelTiem_Y_chart, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DisTiem_X_chart
        '
        ChartArea1.AxisX.Title = "Tiempo"
        ChartArea1.AxisY.Title = "Posición X"
        ChartArea1.Name = "ChartArea1"
        Me.DisTiem_X_chart.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Legend1"
        Me.DisTiem_X_chart.Legends.Add(Legend1)
        Me.DisTiem_X_chart.Location = New System.Drawing.Point(12, 12)
        Me.DisTiem_X_chart.Name = "DisTiem_X_chart"
        Me.DisTiem_X_chart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Fire
        Series1.ChartArea = "ChartArea1"
        Series1.Legend = "Legend1"
        Series1.Name = "Series1"
        Me.DisTiem_X_chart.Series.Add(Series1)
        Me.DisTiem_X_chart.Size = New System.Drawing.Size(416, 300)
        Me.DisTiem_X_chart.TabIndex = 0
        Me.DisTiem_X_chart.Text = "Chart1"
        Title1.Alignment = System.Drawing.ContentAlignment.TopCenter
        Title1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold)
        Title1.Name = "Distancia vs Tiempo  X"
        Title1.Text = "Posición vs Tiempo X"
        Me.DisTiem_X_chart.Titles.Add(Title1)
        '
        'DisTiem_Y_chart
        '
        ChartArea2.AxisX.Title = "Tiempo"
        ChartArea2.AxisY.Title = "Posición Y"
        ChartArea2.Name = "ChartArea1"
        Me.DisTiem_Y_chart.ChartAreas.Add(ChartArea2)
        Legend2.Name = "Legend1"
        Me.DisTiem_Y_chart.Legends.Add(Legend2)
        Me.DisTiem_Y_chart.Location = New System.Drawing.Point(455, 12)
        Me.DisTiem_Y_chart.Name = "DisTiem_Y_chart"
        Me.DisTiem_Y_chart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel
        Series2.ChartArea = "ChartArea1"
        Series2.Legend = "Legend1"
        Series2.Name = "Series1"
        Me.DisTiem_Y_chart.Series.Add(Series2)
        Me.DisTiem_Y_chart.Size = New System.Drawing.Size(416, 300)
        Me.DisTiem_Y_chart.TabIndex = 0
        Me.DisTiem_Y_chart.Text = "Chart1"
        Title2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold)
        Title2.Name = "Title1"
        Title2.Text = "Posición vs Tiempo Y"
        Me.DisTiem_Y_chart.Titles.Add(Title2)
        '
        'VelTiem_X_chart
        '
        ChartArea3.AxisX.Title = "Tiempo"
        ChartArea3.AxisY.Title = "Velocidad"
        ChartArea3.Name = "ChartArea1"
        Me.VelTiem_X_chart.ChartAreas.Add(ChartArea3)
        Legend3.Name = "Legend1"
        Me.VelTiem_X_chart.Legends.Add(Legend3)
        Me.VelTiem_X_chart.Location = New System.Drawing.Point(12, 330)
        Me.VelTiem_X_chart.Name = "VelTiem_X_chart"
        Series3.ChartArea = "ChartArea1"
        Series3.Legend = "Legend1"
        Series3.Name = "Series1"
        Me.VelTiem_X_chart.Series.Add(Series3)
        Me.VelTiem_X_chart.Size = New System.Drawing.Size(416, 300)
        Me.VelTiem_X_chart.TabIndex = 0
        Me.VelTiem_X_chart.Text = "Chart1"
        Title3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold)
        Title3.Name = "Title1"
        Title3.Text = "Velocidad vs Tiempo X"
        Me.VelTiem_X_chart.Titles.Add(Title3)
        '
        'VelTiem_Y_chart
        '
        ChartArea4.AxisX.Title = "Tiempo"
        ChartArea4.AxisY.Title = "Velocidad"
        ChartArea4.Name = "ChartArea1"
        Me.VelTiem_Y_chart.ChartAreas.Add(ChartArea4)
        Legend4.Name = "Legend1"
        Me.VelTiem_Y_chart.Legends.Add(Legend4)
        Me.VelTiem_Y_chart.Location = New System.Drawing.Point(455, 330)
        Me.VelTiem_Y_chart.Name = "VelTiem_Y_chart"
        Me.VelTiem_Y_chart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright
        Series4.ChartArea = "ChartArea1"
        Series4.Legend = "Legend1"
        Series4.Name = "Series1"
        Me.VelTiem_Y_chart.Series.Add(Series4)
        Me.VelTiem_Y_chart.Size = New System.Drawing.Size(416, 300)
        Me.VelTiem_Y_chart.TabIndex = 1
        Me.VelTiem_Y_chart.Text = "Chart1"
        Title4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold)
        Title4.Name = "Title1"
        Title4.Text = "Velocidad vs Tiempo Y"
        Me.VelTiem_Y_chart.Titles.Add(Title4)
        '
        'Graficos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(883, 703)
        Me.Controls.Add(Me.VelTiem_Y_chart)
        Me.Controls.Add(Me.VelTiem_X_chart)
        Me.Controls.Add(Me.DisTiem_Y_chart)
        Me.Controls.Add(Me.DisTiem_X_chart)
        Me.Name = "Graficos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Form2"
        CType(Me.DisTiem_X_chart, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DisTiem_Y_chart, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VelTiem_X_chart, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VelTiem_Y_chart, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DisTiem_X_chart As DataVisualization.Charting.Chart
    Friend WithEvents DisTiem_Y_chart As DataVisualization.Charting.Chart
    Friend WithEvents VelTiem_X_chart As DataVisualization.Charting.Chart
    Friend WithEvents VelTiem_Y_chart As DataVisualization.Charting.Chart
End Class
