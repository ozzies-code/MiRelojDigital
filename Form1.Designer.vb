<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnHora = New System.Windows.Forms.Button()
        Me.btnMostrarHoraFecha = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.IndianRed
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Font = New System.Drawing.Font("Consolas", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Gold
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(535, 98)
        Me.Label1.TabIndex = 0
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnHora
        '
        Me.btnHora.BackColor = System.Drawing.Color.Firebrick
        Me.btnHora.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHora.ForeColor = System.Drawing.Color.Gold
        Me.btnHora.Location = New System.Drawing.Point(120, 120)
        Me.btnHora.Name = "btnHora"
        Me.btnHora.Size = New System.Drawing.Size(151, 65)
        Me.btnHora.TabIndex = 1
        Me.btnHora.Text = "Mostrar Hora"
        Me.btnHora.UseVisualStyleBackColor = False
        '
        'btnMostrarHoraFecha
        '
        Me.btnMostrarHoraFecha.BackColor = System.Drawing.Color.Firebrick
        Me.btnMostrarHoraFecha.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMostrarHoraFecha.ForeColor = System.Drawing.Color.Gold
        Me.btnMostrarHoraFecha.Location = New System.Drawing.Point(294, 120)
        Me.btnMostrarHoraFecha.Name = "btnMostrarHoraFecha"
        Me.btnMostrarHoraFecha.Size = New System.Drawing.Size(151, 65)
        Me.btnMostrarHoraFecha.TabIndex = 2
        Me.btnMostrarHoraFecha.Text = "Mostrar Hora y Fecha"
        Me.btnMostrarHoraFecha.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(558, 199)
        Me.Controls.Add(Me.btnMostrarHoraFecha)
        Me.Controls.Add(Me.btnHora)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Mi Reloj Digital"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label1 As Label
    Friend WithEvents btnHora As Button
    Friend WithEvents btnMostrarHoraFecha As Button
End Class
