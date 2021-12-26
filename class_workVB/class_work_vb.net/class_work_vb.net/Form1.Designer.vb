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
        Me.B1 = New System.Windows.Forms.Button
        Me.T1 = New System.Windows.Forms.TextBox
        Me.T2 = New System.Windows.Forms.TextBox
        Me.T3 = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'B1
        '
        Me.B1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.B1.Location = New System.Drawing.Point(62, 307)
        Me.B1.Name = "B1"
        Me.B1.Size = New System.Drawing.Size(168, 95)
        Me.B1.TabIndex = 0
        Me.B1.Text = "CALCULATE"
        Me.B1.UseVisualStyleBackColor = True
        '
        'T1
        '
        Me.T1.Location = New System.Drawing.Point(352, 28)
        Me.T1.Name = "T1"
        Me.T1.Size = New System.Drawing.Size(265, 20)
        Me.T1.TabIndex = 1
        '
        'T2
        '
        Me.T2.Location = New System.Drawing.Point(352, 77)
        Me.T2.Name = "T2"
        Me.T2.Size = New System.Drawing.Size(265, 20)
        Me.T2.TabIndex = 2
        '
        'T3
        '
        Me.T3.Location = New System.Drawing.Point(352, 142)
        Me.T3.Name = "T3"
        Me.T3.Size = New System.Drawing.Size(265, 20)
        Me.T3.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(77, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 25)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "a="
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(77, 88)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 25)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "b="
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(77, 142)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 25)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "a/b="
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(789, 507)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.T3)
        Me.Controls.Add(Me.T2)
        Me.Controls.Add(Me.T1)
        Me.Controls.Add(Me.B1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents B1 As System.Windows.Forms.Button
    Friend WithEvents T1 As System.Windows.Forms.TextBox
    Friend WithEvents T2 As System.Windows.Forms.TextBox
    Friend WithEvents T3 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label

End Class
