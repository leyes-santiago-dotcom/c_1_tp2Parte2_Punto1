<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        cmdEjecutar = New Button()
        lblMenor = New Label()
        lblMayor = New Label()
        lblSuma = New Label()
        SuspendLayout()
        ' 
        ' cmdEjecutar
        ' 
        cmdEjecutar.Location = New Point(12, 123)
        cmdEjecutar.Name = "cmdEjecutar"
        cmdEjecutar.Size = New Size(94, 29)
        cmdEjecutar.TabIndex = 0
        cmdEjecutar.Text = "Ejecucion"
        cmdEjecutar.UseVisualStyleBackColor = True
        ' 
        ' lblMenor
        ' 
        lblMenor.AutoSize = True
        lblMenor.Location = New Point(12, 17)
        lblMenor.Name = "lblMenor"
        lblMenor.Size = New Size(134, 20)
        lblMenor.TabIndex = 1
        lblMenor.Text = "Muestra del Menor"
        ' 
        ' lblMayor
        ' 
        lblMayor.AutoSize = True
        lblMayor.Location = New Point(13, 46)
        lblMayor.Name = "lblMayor"
        lblMayor.Size = New Size(133, 20)
        lblMayor.TabIndex = 2
        lblMayor.Text = "Muestra del Mayor"
        ' 
        ' lblSuma
        ' 
        lblSuma.AutoSize = True
        lblSuma.Location = New Point(12, 75)
        lblSuma.Name = "lblSuma"
        lblSuma.Size = New Size(46, 20)
        lblSuma.TabIndex = 3
        lblSuma.Text = "Suma"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(379, 210)
        Controls.Add(lblSuma)
        Controls.Add(lblMayor)
        Controls.Add(lblMenor)
        Controls.Add(cmdEjecutar)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents cmdEjecutar As Button
    Friend WithEvents lblMenor As Label
    Friend WithEvents lblMayor As Label
    Friend WithEvents lblSuma As Label

End Class
