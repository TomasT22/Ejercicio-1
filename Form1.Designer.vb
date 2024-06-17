<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.cmdEjecutar = New System.Windows.Forms.Button()
        Me.lblMayorNumero = New System.Windows.Forms.Label()
        Me.txtNumero1 = New System.Windows.Forms.TextBox()
        Me.txtNumero2 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'cmdEjecutar
        '
        Me.cmdEjecutar.Location = New System.Drawing.Point(224, 12)
        Me.cmdEjecutar.Name = "cmdEjecutar"
        Me.cmdEjecutar.Size = New System.Drawing.Size(75, 23)
        Me.cmdEjecutar.TabIndex = 0
        Me.cmdEjecutar.Text = "Ejecutar"
        Me.cmdEjecutar.UseVisualStyleBackColor = True
        '
        'lblMayorNumero
        '
        Me.lblMayorNumero.AutoSize = True
        Me.lblMayorNumero.Location = New System.Drawing.Point(12, 44)
        Me.lblMayorNumero.Name = "lblMayorNumero"
        Me.lblMayorNumero.Size = New System.Drawing.Size(39, 13)
        Me.lblMayorNumero.TabIndex = 1
        Me.lblMayorNumero.Text = "Label1"
        '
        'txtNumero1
        '
        Me.txtNumero1.Location = New System.Drawing.Point(12, 12)
        Me.txtNumero1.Name = "txtNumero1"
        Me.txtNumero1.Size = New System.Drawing.Size(100, 20)
        Me.txtNumero1.TabIndex = 3
        '
        'txtNumero2
        '
        Me.txtNumero2.Location = New System.Drawing.Point(118, 12)
        Me.txtNumero2.Name = "txtNumero2"
        Me.txtNumero2.Size = New System.Drawing.Size(100, 20)
        Me.txtNumero2.TabIndex = 4
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.txtNumero2)
        Me.Controls.Add(Me.txtNumero1)
        Me.Controls.Add(Me.lblMayorNumero)
        Me.Controls.Add(Me.cmdEjecutar)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmdEjecutar As Button
    Friend WithEvents lblMayorNumero As Label
    Friend WithEvents txtNumero1 As TextBox
    Friend WithEvents txtNumero2 As TextBox
End Class
