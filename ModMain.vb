Module ModMain

    Public pc1 As New PerformanceCounter("Processor", "% Processor Time", "0")
    Public pc2 As New PerformanceCounter("Processor", "% Processor Time", "1")
    Public pc3 As New PerformanceCounter("Processor", "% Processor Time", "2")
    Public pc4 As New PerformanceCounter("Processor", "% Processor Time", "3")
    Public pc5 As New PerformanceCounter("Processor", "% Processor Time", "4")
    Public pc6 As New PerformanceCounter("Processor", "% Processor Time", "5")
    Public pc7 As New PerformanceCounter("Processor", "% Processor Time", "6")
    Public pc8 As New PerformanceCounter("Processor", "% Processor Time", "7")

    Public pc1Value As Integer
    Public pc2Value As Integer
    Public pc3Value As Integer
    Public pc4Value As Integer
    Public pc5Value As Integer
    Public pc6Value As Integer
    Public pc7Value As Integer
    Public pc8Value As Integer

    Public updatesPerSecond As Integer = 1

    Public cpu1Points As New List(Of DataVisualization.Charting.DataPoint)

    Public Function GetCompName() As String
        Return Environment.MachineName
    End Function

    Public Sub InitializeChart(ByRef cht As DataVisualization.Charting.Chart)

        cht.ChartAreas.Add("CPU1")
        cht.Series.Add("CPU1")
        cht.Series(0).ChartArea = cht.ChartAreas(0).Name
        cht.Series(0).ChartType = DataVisualization.Charting.SeriesChartType.Column

        cht.ChartAreas(0).BackColor = Color.FromKnownColor(KnownColor.Transparent)
        cht.ChartAreas(0).AxisX.LabelStyle.Enabled = False
        cht.ChartAreas(0).AxisX.MajorGrid.LineWidth = 0
        cht.ChartAreas(0).AxisX.MinorGrid.LineWidth = 0
        cht.ChartAreas(0).AxisX.MinorTickMark.Enabled = False
        cht.ChartAreas(0).AxisY.LabelStyle.Enabled = False
        cht.ChartAreas(0).AxisY.Minimum = 0
        cht.ChartAreas(0).AxisY.Maximum = 100

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
        Next

        cht.Series(0).Points.ResumeUpdates()
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

        pc1Value = CInt(pc1.NextValue)
        pc2Value = CInt(pc2.NextValue)
        pc3Value = CInt(pc3.NextValue)
        pc4Value = CInt(pc4.NextValue)
        pc5Value = CInt(pc5.NextValue)
        pc6Value = CInt(pc6.NextValue)
        pc7Value = CInt(pc7.NextValue)
        pc8Value = CInt(pc8.NextValue)


    End Sub


End Module
