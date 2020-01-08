Module ModMain

    Public lstCharts As New List(Of DataVisualization.Charting.Chart)
    Public lstCounters As New List(Of PerformanceCounter)
    Public lstValues As New List(Of Integer)

    Public lstSentValues As New List(Of Integer)
    Public lstReceivedValues As New List(Of Integer)



    Public updatesPerSecond As Integer = 1
    Public chartHeight As Integer = 60

    Public lastLocation As Point

    Public Function GetCompName() As String
        Return Environment.MachineName
    End Function

    Public Sub InitializeChart(ByRef cht As DataVisualization.Charting.Chart, ByVal chartName As String)

        cht.Size = New Size(frmMain.Width - 4, chartHeight)
        cht.Location = New Point(2, lastLocation.Y + (cht.Size.Height + 8))

        frmMain.Height += chartHeight + 8

        cht.BackColor = Color.FromKnownColor(KnownColor.Transparent)
        cht.BorderlineColor = Color.LightGray

        cht.ChartAreas.Add(chartName)
        cht.Series.Add("Sent")
        cht.Series.Add("Received")

        cht.Series(0).ChartArea = chartName

        cht.ChartAreas(0).AlignmentOrientation = DataVisualization.Charting.AreaAlignmentOrientations.Horizontal
        cht.ChartAreas(0).Position.Width = 100
        cht.ChartAreas(0).Position.Height = 100
        cht.ChartAreas(0).BorderWidth = 0

        'Sent bytes/second
        cht.Series(0).ChartType = DataVisualization.Charting.SeriesChartType.Column
        cht.Series(0).CustomProperties = "PointWidth=1"
        cht.Series(0).CustomProperties = "DrawSideBySide=False"
        cht.Series(0).Color = Color.FromArgb(50, Color.Red)

        'Receibed bytes/second
        cht.Series(1).ChartType = DataVisualization.Charting.SeriesChartType.Column
        cht.Series(1).CustomProperties = "PointWidth=1"
        cht.Series(1).CustomProperties = "DrawSideBySide=False"
        cht.Series(1).Color = Color.FromArgb(50, Color.Blue)

        cht.ChartAreas(0).BackColor = Color.LightGray
        cht.ChartAreas(0).AxisX.LabelStyle.Enabled = False

        cht.ChartAreas(0).AxisX.IntervalAutoMode = DataVisualization.Charting.IntervalAutoMode.FixedCount
        cht.ChartAreas(0).AxisX.MajorTickMark.Enabled = False
        cht.ChartAreas(0).AxisX.MajorGrid.LineWidth = 0
        cht.ChartAreas(0).AxisX.LineWidth = 0

        cht.ChartAreas(0).AxisY.LabelStyle.Enabled = False
        cht.ChartAreas(0).AxisY.MinorGrid.LineWidth = 0
        cht.ChartAreas(0).AxisY.IntervalAutoMode = DataVisualization.Charting.IntervalAutoMode.VariableCount
        cht.ChartAreas(0).AxisY.Interval = 25

        For i = 0 To 99
            cht.Series(0).Points.AddXY(i, 0)
            cht.Series(1).Points.AddXY(i, 0)
        Next

    End Sub

    Public Sub InitializeChart(ByRef cht As DataVisualization.Charting.Chart, ByVal chartName As String, ByVal chtIndex As Integer)

        cht.Size = New Size(frmMain.Width - 4, chartHeight)
        cht.Location = New Point(2, 30 + (cht.Size.Height + 8) * chtIndex)
        lastLocation = cht.location

        frmMain.Height += chartHeight + 8

        cht.BackColor = Color.FromKnownColor(KnownColor.Transparent)
        cht.BorderlineColor = Color.LightGray

        cht.ChartAreas.Add(chartName)
        cht.Series.Add(chartName)
        cht.Series(0).ChartArea = chartName

        cht.ChartAreas(0).AlignmentOrientation = DataVisualization.Charting.AreaAlignmentOrientations.Horizontal
        cht.ChartAreas(0).Position.Width = 100
        cht.ChartAreas(0).Position.Height = 100
        cht.ChartAreas(0).BorderWidth = 0

        cht.Series(0).ChartType = DataVisualization.Charting.SeriesChartType.Column
        cht.Series(0).CustomProperties = "PointWidth=1"
        cht.ChartAreas(0).BackColor = Color.LightGray

        cht.ChartAreas(0).AxisX.LabelStyle.Enabled = False

        cht.ChartAreas(0).AxisX.IntervalAutoMode = DataVisualization.Charting.IntervalAutoMode.FixedCount
        cht.ChartAreas(0).AxisX.MajorTickMark.Enabled = False
        cht.ChartAreas(0).AxisX.MajorGrid.LineWidth = 0
        cht.ChartAreas(0).AxisX.LineWidth = 0

        cht.ChartAreas(0).AxisY.LabelStyle.Enabled = False
        cht.ChartAreas(0).AxisY.MinorGrid.LineWidth = 0
        cht.ChartAreas(0).AxisY.Minimum = 0
        cht.ChartAreas(0).AxisY.Maximum = 100
        cht.ChartAreas(0).AxisY.IntervalAutoMode = DataVisualization.Charting.IntervalAutoMode.FixedCount
        cht.ChartAreas(0).AxisY.Interval = 25

        For i = 0 To 99
            cht.Series(0).Points.AddXY(i, 0)
        Next

    End Sub

    Public Sub updatechart(ByRef cht As DataVisualization.Charting.Chart, ByVal value As Integer)

        cht.Series(0).Points.SuspendUpdates()

            cht.Series(0).Points.AddY(value)
            cht.Series(0).Points.RemoveAt(0)
            For i = 0 To cht.Series(0).Points.Count - 1
                cht.Series(0).Points(i).XValue = i
                cht.Series(0).Points(i).Color = getColor(value)
            Next

            cht.Series(0).Points.ResumeUpdates()


    End Sub

    Public Sub updateNetChart(ByRef cht As DataVisualization.Charting.Chart, ByVal sentValue As Integer, ByVal receivedValue As Integer)
        cht.Series(0).Points.SuspendUpdates()
        cht.Series(1).Points.SuspendUpdates()

        cht.Series(0).Points.AddY(sentValue)
        cht.Series(0).Points.RemoveAt(0)

        cht.Series(1).Points.AddY(receivedValue)
        cht.Series(1).Points.RemoveAt(0)

        For i = 0 To cht.Series(0).Points.Count - 1
            cht.Series(0).Points(i).XValue = i
        Next
        For i = 0 To cht.Series(1).Points.Count - 1
            cht.Series(1).Points(i).XValue = i
        Next

        cht.Series(0).Points.ResumeUpdates()
        cht.Series(1).Points.ResumeUpdates()
    End Sub


    Public Function getColor(ByVal value As Integer) As Color
        If value < 20 Then
            Return Color.Green
        ElseIf value < 60 Then
            Return Color.Yellow
        ElseIf value < 90 Then
            Return Color.Orange
        Else
            Return Color.Red
        End If
    End Function



    Public Sub UpdateCounters()

        For c = 0 To lstCounters.Count - 1
            Dim counter As PerformanceCounter = DirectCast(lstCounters(c), PerformanceCounter)
            If c < lstCounters.Count - 2 Then
                lstValues(c) = CInt(counter.NextValue)
            Else
                lstValues(c) = CInt(counter.NextValue / 1024)
            End If
        Next

    End Sub


End Module
