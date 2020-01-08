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
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(120, 60)
        Me.ControlBox = False
        Me.Controls.Add(Me.lblComName)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MinimizeBox = False
        Me.Name = "frmMain"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lblComName As Label
    Friend WithEvents bkwCPU As System.ComponentModel.BackgroundWorker
End Class
