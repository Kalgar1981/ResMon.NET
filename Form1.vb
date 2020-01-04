Imports System.ComponentModel

Public Class frmMain
    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles Me.Load
        lblComName.Text = GetCompName()
        InitializeCharts()

        bkwCPU.RunWorkerAsync()

    End Sub

    Private Sub InitializeCharts()

        InitializeChart(chtCPU1)
        InitializeChart(chtCPU2)
        InitializeChart(chtCPU3)
        InitializeChart(chtCPU4)
        InitializeChart(chtCPU5)
        InitializeChart(chtCPU6)
        InitializeChart(chtCPU7)
        InitializeChart(chtCPU8)


    End Sub



    Private Sub UpdateLabels()
        If chtCPU1.InvokeRequired Then
            chtCPU1.Invoke(Sub() UpdateLabels())
        Else
            SuspendLayout()

            updatechart(chtCPU1, pc1Value)
            updatechart(chtCPU2, pc2Value)
            updatechart(chtCPU3, pc3Value)
            updatechart(chtCPU4, pc4Value)
            updatechart(chtCPU5, pc5Value)
            updatechart(chtCPU6, pc6Value)
            updatechart(chtCPU7, pc7Value)
            updatechart(chtCPU8, pc8Value)



            lblCPU1Value.Text = pc1Value.ToString & "%"
            lblCPU2Value.Text = pc2Value.ToString & "%"
            lblCPU3Value.Text = pc3Value.ToString & "%"
            lblCPU4Value.Text = pc4Value.ToString & "%"
            lblCPU5Value.Text = pc5Value.ToString & "%"
            lblCPU6Value.Text = pc6Value.ToString & "%"
            lblCPU7Value.Text = pc7Value.ToString & "%"
            lblCPU8Value.Text = pc8Value.ToString & "%"

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


End Class



