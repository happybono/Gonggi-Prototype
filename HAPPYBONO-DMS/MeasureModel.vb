Imports LiveCharts
Imports LiveCharts.Configurations
Imports LiveCharts.WinForms
Imports LiveCharts.Wpf

Public Class MeasureModel

    Public Property DateTime As System.DateTime
    Public Property Value As Double

    Public Property ChartValues As ChartValues(Of MeasureModel)

    Public Sub ConstantChanges()
        Dim mapper = Mappers.Xy(Of MeasureModel)().X(Function(model) model.DateTime.Ticks).Y(Function(model) model.Value)
        Charting.[For](Of MeasureModel)(mapper)
        ChartValues = New ChartValues(Of MeasureModel)()
        MainForm.chartPM.Series = New SeriesCollection From {
            New LineSeries With {
                .Values = ChartValues,
                .PointGeometrySize = 18,
                .StrokeThickness = 4
            }
        }
        MainForm.chartPM.AxisX.Add(New Axis With {
            .LabelFormatter = Function(value) New System.DateTime(CLng(value)).ToString("mm:ss"),
            .Separator = New Separator With {
                .[Step] = TimeSpan.FromSeconds(1).Ticks
            }
        })
        SetAxisLimits(System.DateTime.Now)
    End Sub

    Private Sub SetAxisLimits(ByVal now As System.DateTime)
        MainForm.chartPM.AxisX(0).MaxValue = now.Ticks + TimeSpan.FromSeconds(1).Ticks
        MainForm.chartPM.AxisX(0).MinValue = now.Ticks - TimeSpan.FromSeconds(8).Ticks
    End Sub
End Class
