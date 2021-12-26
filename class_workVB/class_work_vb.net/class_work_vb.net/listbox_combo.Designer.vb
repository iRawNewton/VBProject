<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class listbox_combo
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
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.T1 = New System.Windows.Forms.TextBox
        Me.T2 = New System.Windows.Forms.TextBox
        Me.LB1 = New System.Windows.Forms.ListBox
        Me.CB1 = New System.Windows.Forms.ComboBox
        Me.CB2 = New System.Windows.Forms.ComboBox
        Me.CB3 = New System.Windows.Forms.ComboBox
        Me.B1 = New System.Windows.Forms.Button
        Me.T3 = New System.Windows.Forms.TextBox
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(28, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Roll no"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(28, 92)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(28, 130)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Course"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(28, 203)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Date of  birth"
        '
        'T1
        '
        Me.T1.Location = New System.Drawing.Point(157, 48)
        Me.T1.Name = "T1"
        Me.T1.Size = New System.Drawing.Size(100, 20)
        Me.T1.TabIndex = 4
        '
        'T2
        '
        Me.T2.Location = New System.Drawing.Point(157, 92)
        Me.T2.Name = "T2"
        Me.T2.Size = New System.Drawing.Size(100, 20)
        Me.T2.TabIndex = 5
        '
        'LB1
        '
        Me.LB1.FormattingEnabled = True
        Me.LB1.Location = New System.Drawing.Point(157, 130)
        Me.LB1.Name = "LB1"
        Me.LB1.Size = New System.Drawing.Size(120, 43)
        Me.LB1.TabIndex = 6
        '
        'CB1
        '
        Me.CB1.FormattingEnabled = True
        Me.CB1.Location = New System.Drawing.Point(157, 200)
        Me.CB1.Name = "CB1"
        Me.CB1.Size = New System.Drawing.Size(48, 21)
        Me.CB1.TabIndex = 7
        '
        'CB2
        '
        Me.CB2.FormattingEnabled = True
        Me.CB2.Location = New System.Drawing.Point(279, 200)
        Me.CB2.Name = "CB2"
        Me.CB2.Size = New System.Drawing.Size(48, 21)
        Me.CB2.TabIndex = 8
        '
        'CB3
        '
        Me.CB3.FormattingEnabled = True
        Me.CB3.Location = New System.Drawing.Point(400, 200)
        Me.CB3.Name = "CB3"
        Me.CB3.Size = New System.Drawing.Size(48, 21)
        Me.CB3.TabIndex = 9
        '
        'B1
        '
        Me.B1.Location = New System.Drawing.Point(176, 258)
        Me.B1.Name = "B1"
        Me.B1.Size = New System.Drawing.Size(182, 23)
        Me.B1.TabIndex = 10
        Me.B1.Text = "Display"
        Me.B1.UseVisualStyleBackColor = True
        '
        'T3
        '
        Me.T3.Location = New System.Drawing.Point(150, 316)
        Me.T3.Multiline = True
        Me.T3.Name = "T3"
        Me.T3.Size = New System.Drawing.Size(284, 170)
        Me.T3.TabIndex = 11
        '
        'listbox_combo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(565, 519)
        Me.Controls.Add(Me.T3)
        Me.Controls.Add(Me.B1)
        Me.Controls.Add(Me.CB3)
        Me.Controls.Add(Me.CB2)
        Me.Controls.Add(Me.CB1)
        Me.Controls.Add(Me.LB1)
        Me.Controls.Add(Me.T2)
        Me.Controls.Add(Me.T1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "listbox_combo"
        Me.Text = "listbox_combo"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents T1 As System.Windows.Forms.TextBox
    Friend WithEvents T2 As System.Windows.Forms.TextBox
    Friend WithEvents LB1 As System.Windows.Forms.ListBox
    Friend WithEvents CB1 As System.Windows.Forms.ComboBox
    Friend WithEvents CB2 As System.Windows.Forms.ComboBox
    Friend WithEvents CB3 As System.Windows.Forms.ComboBox
    Friend WithEvents B1 As System.Windows.Forms.Button
    Friend WithEvents T3 As System.Windows.Forms.TextBox
End Class
