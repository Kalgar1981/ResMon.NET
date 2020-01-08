Imports System.ComponentModel

Public Class frmMain

    Private loading As Boolean = False
    Private isDown As Boolean = False
    Private lastLocation As Point

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles Me.Load
        loading = True
        Height = 40
        lblComName.Text = GetCompName()
        InitializeCharts()

        bkwCPU.RunWorkerAsync()
        loading = False
    End Sub

    Private Sub InitializeCharts()
        Dim perfCat As PerformanceCounterCategory = New PerformanceCounterCategory("Network Interface")
        Dim instance As String = perfCat.GetInstanceNames()(0)

        Dim coreCount As Integer = Environment.ProcessorCount

        For c = 0 To coreCount - 1
            lstCounters.Add(New PerformanceCounter("Processor", "% Processor Time", c.ToString))
            Dim cht As New DataVisualization.Charting.Chart
            cht.Name = c.ToString
            InitializeChart(cht, "CPU" & c.ToString, c)
            lstCharts.Add(cht)
            lstValues.Add(0)

            Controls.Add(lstCharts(c))

        Next

        Dim chtNet As New DataVisualization.Charting.Chart
        chtNet.Name = "Net"
        InitializeChart(chtNet, "NET")
        lstCharts.Add(chtNet)

        lstValues.Add(0)
        lstValues.Add(0)

        lstCounters.Add(New PerformanceCounter("Network Interface", "Bytes Sent/sec", instance))
        lstCounters.Add(New PerformanceCounter("Network Interface", "Bytes Received/sec", instance))

        Controls.Add(chtNet)

    End Sub


    Private Sub UpdateLabels()
        If lblComName.InvokeRequired Then
            lblComName.Invoke(Sub() UpdateLabels())
        Else
            SuspendLayout()

            For c = 0 To lstCharts.Count - 3
                updatechart(lstCharts(c), lstValues(c))
            Next

            updateNetChart(lstCharts.Last, lstValues(lstValues.Count - 2), lstValues(lstValues.Count - 1))
            ResumeLayout()
        End If

    End Sub

    Private Sub bkwCPU_DoWork(sender As Object, e As DoWorkEventArgs) Handles bkwCPU.DoWork
        While True
            UpdateCounters()
            UpdateLabels()
            Threading.Thread.Sleep(CInt(1000 / updatesPerSecond))
        End While

    End Sub

    Private Sub frmMain_SizeChanged(sender As Object, e As EventArgs) Handles Me.SizeChanged
        If loading Then Exit Sub
        For c = 0 To lstCharts.Count - 1
            lstCharts(c).Size = New Size(Width - 4, chartHeight)
            lstCharts(c).Location = New Point(2, 30 + (lstCharts(c).Size.Height + 4) * c)
        Next
    End Sub

    Private Sub MDown(sender As Object, e As MouseEventArgs) Handles lblComName.MouseDown
        isDown = True
        lastLocation = e.Location
    End Sub

    Private Sub MUp(sender As Object, e As MouseEventArgs) Handles lblComName.MouseUp
        isDown = False
    End Sub

    Private Sub MMove(sender As Object, e As MouseEventArgs) Handles lblComName.MouseMove
        If isDown Then
            Location = New Point((Location.X - lastLocation.X) + e.X, (Location.Y - lastLocation.Y) + e.Y)
            Update()
        End If
    End Sub
End Class



