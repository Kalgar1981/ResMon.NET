<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMain
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
        Me.lblComName = New System.Windows.Forms.Label()
        Me.bkwCPU = New System.ComponentModel.BackgroundWorker()
        Me.chtCPU1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.chtCPU2 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.chtCPU3 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.chtCPU4 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.chtCPU8 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.chtCPU7 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.chtCPU6 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.chtCPU5 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.lblCPU1Value = New System.Windows.Forms.Label()
        Me.lblCPU2Value = New System.Windows.Forms.Label()
        Me.lblCPU3Value = New System.Windows.Forms.Label()
        Me.lblCPU4Value = New System.Windows.Forms.Label()
        Me.lblCPU5Value = New System.Windows.Forms.Label()
        Me.lblCPU6Value = New System.Windows.Forms.Label()
        Me.lblCPU7Value = New System.Windows.Forms.Label()
        Me.lblCPU8Value = New System.Windows.Forms.Label()
        CType(Me.chtCPU1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chtCPU2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chtCPU3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chtCPU4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chtCPU8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chtCPU7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chtCPU6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chtCPU5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblComName
        '
        Me.lblComName.Location = New System.Drawing.Point(2, 2)
        Me.lblComName.Name = "lblComName"
        Me.lblComName.Size = New System.Drawing.Size(117, 23)
        Me.lblComName.TabIndex = 0
        Me.lblComName.Text = "Label1"
        Me.lblComName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'bkwCPU
        '
        '
        'chtCPU1
        '
        Me.chtCPU1.BackColor = System.Drawing.Color.Transparent
        Me.chtCPU1.Location = New System.Drawing.Point(2, 28)
        Me.chtCPU1.Name = "chtCPU1"
        Me.chtCPU1.Size = New System.Drawing.Size(117, 79)
        Me.chtCPU1.TabIndex = 17
        '
        'chtCPU2
        '
        Me.chtCPU2.BackColor = System.Drawing.Color.Transparent
        Me.chtCPU2.Location = New System.Drawing.Point(2, 113)
        Me.chtCPU2.Name = "chtCPU2"
        Me.chtCPU2.Size = New System.Drawing.Size(117, 79)
        Me.chtCPU2.TabIndex = 18
        '
        'chtCPU3
        '
        Me.chtCPU3.BackColor = System.Drawing.Color.Transparent
        Me.chtCPU3.Location = New System.Drawing.Point(2, 198)
        Me.chtCPU3.Name = "chtCPU3"
        Me.chtCPU3.Size = New System.Drawing.Size(117, 79)
        Me.chtCPU3.TabIndex = 19
        '
        'chtCPU4
        '
        Me.chtCPU4.BackColor = System.Drawing.Color.Transparent
        Me.chtCPU4.Location = New System.Drawing.Point(2, 283)
        Me.chtCPU4.Name = "chtCPU4"
        Me.chtCPU4.Size = New System.Drawing.Size(117, 79)
        Me.chtCPU4.TabIndex = 20
        '
        'chtCPU8
        '
        Me.chtCPU8.BackColor = System.Drawing.Color.Transparent
        Me.chtCPU8.Location = New System.Drawing.Point(2, 623)
        Me.chtCPU8.Name = "chtCPU8"
        Me.chtCPU8.Size = New System.Drawing.Size(117, 79)
        Me.chtCPU8.TabIndex = 24
        '
        'chtCPU7
        '
        Me.chtCPU7.BackColor = System.Drawing.Color.Transparent
        Me.chtCPU7.Location = New System.Drawing.Point(2, 538)
        Me.chtCPU7.Name = "chtCPU7"
        Me.chtCPU7.Size = New System.Drawing.Size(117, 79)
        Me.chtCPU7.TabIndex = 23
        '
        'chtCPU6
        '
        Me.chtCPU6.BackColor = System.Drawing.Color.Transparent
        Me.chtCPU6.Location = New System.Drawing.Point(2, 453)
        Me.chtCPU6.Name = "chtCPU6"
        Me.chtCPU6.Size = New System.Drawing.Size(117, 79)
        Me.chtCPU6.TabIndex = 22
        '
        'chtCPU5
        '
        Me.chtCPU5.BackColor = System.Drawing.Color.Transparent
        Me.chtCPU5.Location = New System.Drawing.Point(2, 368)
        Me.chtCPU5.Name = "chtCPU5"
        Me.chtCPU5.Size = New System.Drawing.Size(117, 79)
        Me.chtCPU5.TabIndex = 21
        '
        'lblCPU1Value
        '
        Me.lblCPU1Value.AutoSize = True
        Me.lblCPU1Value.BackColor = System.Drawing.Color.Transparent
        Me.lblCPU1Value.Location = New System.Drawing.Point(2, 29)
        Me.lblCPU1Value.Name = "lblCPU1Value"
        Me.lblCPU1Value.Size = New System.Drawing.Size(39, 13)
        Me.lblCPU1Value.TabIndex = 25
        Me.lblCPU1Value.Text = "Label1"
        '
        'lblCPU2Value
        '
        Me.lblCPU2Value.AutoSize = True
        Me.lblCPU2Value.BackColor = System.Drawing.Color.Transparent
        Me.lblCPU2Value.Location = New System.Drawing.Point(2, 114)
        Me.lblCPU2Value.Name = "lblCPU2Value"
        Me.lblCPU2Value.Size = New System.Drawing.Size(39, 13)
        Me.lblCPU2Value.TabIndex = 26
        Me.lblCPU2Value.Text = "Label2"
        '
        'lblCPU3Value
        '
        Me.lblCPU3Value.AutoSize = True
        Me.lblCPU3Value.BackColor = System.Drawing.Color.Transparent
        Me.lblCPU3Value.Location = New System.Drawing.Point(2, 199)
        Me.lblCPU3Value.Name = "lblCPU3Value"
        Me.lblCPU3Value.Size = New System.Drawing.Size(39, 13)
        Me.lblCPU3Value.TabIndex = 27
        Me.lblCPU3Value.Text = "Label3"
        '
        'lblCPU4Value
        '
        Me.lblCPU4Value.AutoSize = True
        Me.lblCPU4Value.BackColor = System.Drawing.Color.Transparent
        Me.lblCPU4Value.Location = New System.Drawing.Point(2, 284)
        Me.lblCPU4Value.Name = "lblCPU4Value"
        Me.lblCPU4Value.Size = New System.Drawing.Size(39, 13)
        Me.lblCPU4Value.TabIndex = 28
        Me.lblCPU4Value.Text = "Label4"
        '
        'lblCPU5Value
        '
        Me.lblCPU5Value.AutoSize = True
        Me.lblCPU5Value.BackColor = System.Drawing.Color.Transparent
        Me.lblCPU5Value.Location = New System.Drawing.Point(2, 369)
        Me.lblCPU5Value.Name = "lblCPU5Value"
        Me.lblCPU5Value.Size = New System.Drawing.Size(39, 13)
        Me.lblCPU5Value.TabIndex = 29
        Me.lblCPU5Value.Text = "Label5"
        '
        'lblCPU6Value
        '
        Me.lblCPU6Value.AutoSize = True
        Me.lblCPU6Value.BackColor = System.Drawing.Color.Transparent
        Me.lblCPU6Value.Location = New System.Drawing.Point(2, 454)
        Me.lblCPU6Value.Name = "lblCPU6Value"
        Me.lblCPU6Value.Size = New System.Drawing.Size(39, 13)
        Me.lblCPU6Value.TabIndex = 30
        Me.lblCPU6Value.Text = "Label6"
        '
        'lblCPU7Value
        '
        Me.lblCPU7Value.AutoSize = True
        Me.lblCPU7Value.BackColor = System.Drawing.Color.Transparent
        Me.lblCPU7Value.Location = New System.Drawing.Point(2, 539)
        Me.lblCPU7Value.Name = "lblCPU7Value"
        Me.lblCPU7Value.Size = New System.Drawing.Size(39, 13)
        Me.lblCPU7Value.TabIndex = 31
        Me.lblCPU7Value.Text = "Label7"
        '
        'lblCPU8Value
        '
        Me.lblCPU8Value.AutoSize = True
        Me.lblCPU8Value.BackColor = System.Drawing.Color.Transparent
        Me.lblCPU8Value.Location = New System.Drawing.Point(2, 624)
        Me.lblCPU8Value.Name = "lblCPU8Value"
        Me.lblCPU8Value.Size = New System.Drawing.Size(39, 13)
        Me.lblCPU8Value.TabIndex = 32
        Me.lblCPU8Value.Text = "Label8"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(122, 715)
        Me.ControlBox = False
        Me.Controls.Add(Me.lblCPU8Value)
        Me.Controls.Add(Me.lblCPU7Value)
        Me.Controls.Add(Me.lblCPU6Value)
        Me.Controls.Add(Me.lblCPU5Value)
        Me.Controls.Add(Me.lblCPU4Value)
        Me.Controls.Add(Me.lblCPU3Value)
        Me.Controls.Add(Me.lblCPU2Value)
        Me.Controls.Add(Me.lblCPU1Value)
        Me.Controls.Add(Me.chtCPU8)
        Me.Controls.Add(Me.chtCPU7)
        Me.Controls.Add(Me.chtCPU6)
        Me.Controls.Add(Me.chtCPU5)
        Me.Controls.Add(Me.chtCPU4)
        Me.Controls.Add(Me.chtCPU3)
        Me.Controls.Add(Me.chtCPU2)
        Me.Controls.Add(Me.chtCPU1)
        Me.Controls.Add(Me.lblComName)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MinimizeBox = False
        Me.Name = "frmMain"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        CType(Me.chtCPU1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chtCPU2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chtCPU3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chtCPU4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chtCPU8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chtCPU7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chtCPU6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chtCPU5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblComName As Label
    Friend WithEvents bkwCPU As System.ComponentModel.BackgroundWorker
    Friend WithEvents chtCPU1 As DataVisualization.Charting.Chart
    Friend WithEvents chtCPU2 As DataVisualization.Charting.Chart
    Friend WithEvents chtCPU3 As DataVisualization.Charting.Chart
    Friend WithEvents chtCPU4 As DataVisualization.Charting.Chart
    Friend WithEvents chtCPU8 As DataVisualization.Charting.Chart
    Friend WithEvents chtCPU7 As DataVisualization.Charting.Chart
    Friend WithEvents chtCPU6 As DataVisualization.Charting.Chart
    Friend WithEvents chtCPU5 As DataVisualization.Charting.Chart
    Friend WithEvents lblCPU1Value As Label
    Friend WithEvents lblCPU2Value As Label
    Friend WithEvents lblCPU3Value As Label
    Friend WithEvents lblCPU4Value As Label
    Friend WithEvents lblCPU5Value As Label
    Friend WithEvents lblCPU6Value As Label
    Friend WithEvents lblCPU7Value As Label
    Friend WithEvents lblCPU8Value As Label
End Class
