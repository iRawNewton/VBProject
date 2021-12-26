<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class radio_checkbox
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
        Me.T1 = New System.Windows.Forms.TextBox
        Me.T2 = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.CK_UG = New System.Windows.Forms.CheckBox
        Me.CK_PG = New System.Windows.Forms.CheckBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.RB_MALE = New System.Windows.Forms.RadioButton
        Me.RB_FEMALE = New System.Windows.Forms.RadioButton
        Me.RB_OTHER = New System.Windows.Forms.RadioButton
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.b1 = New System.Windows.Forms.Button
        Me.T3 = New System.Windows.Forms.TextBox
        Me.GroupBox1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(21, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "EMP NO"
        '
        'T1
        '
        Me.T1.Location = New System.Drawing.Point(132, 28)
        Me.T1.Name = "T1"
        Me.T1.Size = New System.Drawing.Size(100, 20)
        Me.T1.TabIndex = 1
        '
        'T2
        '
        Me.T2.Location = New System.Drawing.Point(132, 74)
        Me.T2.Name = "T2"
        Me.T2.Size = New System.Drawing.Size(100, 20)
        Me.T2.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(21, 81)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "EMP NAME"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(24, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(88, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "QUALIFICATION"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(34, 3)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(0, 13)
        Me.Label4.TabIndex = 5
        '
        'CK_UG
        '
        Me.CK_UG.AutoSize = True
        Me.CK_UG.Location = New System.Drawing.Point(144, 12)
        Me.CK_UG.Name = "CK_UG"
        Me.CK_UG.Size = New System.Drawing.Size(42, 17)
        Me.CK_UG.TabIndex = 6
        Me.CK_UG.Text = "UG"
        Me.CK_UG.UseVisualStyleBackColor = True
        '
        'CK_PG
        '
        Me.CK_PG.AutoSize = True
        Me.CK_PG.Location = New System.Drawing.Point(211, 12)
        Me.CK_PG.Name = "CK_PG"
        Me.CK_PG.Size = New System.Drawing.Size(41, 17)
        Me.CK_PG.TabIndex = 7
        Me.CK_PG.Text = "PG"
        Me.CK_PG.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RB_OTHER)
        Me.GroupBox1.Controls.Add(Me.RB_FEMALE)
        Me.GroupBox1.Controls.Add(Me.RB_MALE)
        Me.GroupBox1.Location = New System.Drawing.Point(17, 177)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(380, 62)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GENDER"
        '
        'RB_MALE
        '
        Me.RB_MALE.AutoSize = True
        Me.RB_MALE.Location = New System.Drawing.Point(17, 22)
        Me.RB_MALE.Name = "RB_MALE"
        Me.RB_MALE.Size = New System.Drawing.Size(54, 17)
        Me.RB_MALE.TabIndex = 0
        Me.RB_MALE.TabStop = True
        Me.RB_MALE.Text = "MALE"
        Me.RB_MALE.UseVisualStyleBackColor = True
        '
        'RB_FEMALE
        '
        Me.RB_FEMALE.AutoSize = True
        Me.RB_FEMALE.Location = New System.Drawing.Point(136, 22)
        Me.RB_FEMALE.Name = "RB_FEMALE"
        Me.RB_FEMALE.Size = New System.Drawing.Size(67, 17)
        Me.RB_FEMALE.TabIndex = 1
        Me.RB_FEMALE.TabStop = True
        Me.RB_FEMALE.Text = "FEMALE"
        Me.RB_FEMALE.UseVisualStyleBackColor = True
        '
        'RB_OTHER
        '
        Me.RB_OTHER.AutoSize = True
        Me.RB_OTHER.Location = New System.Drawing.Point(263, 22)
        Me.RB_OTHER.Name = "RB_OTHER"
        Me.RB_OTHER.Size = New System.Drawing.Size(63, 17)
        Me.RB_OTHER.TabIndex = 2
        Me.RB_OTHER.TabStop = True
        Me.RB_OTHER.Text = "OTHER"
        Me.RB_OTHER.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.CK_PG)
        Me.Panel1.Controls.Add(Me.CK_UG)
        Me.Panel1.Location = New System.Drawing.Point(17, 116)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(380, 42)
        Me.Panel1.TabIndex = 9
        '
        'b1
        '
        Me.b1.Location = New System.Drawing.Point(157, 257)
        Me.b1.Name = "b1"
        Me.b1.Size = New System.Drawing.Size(75, 23)
        Me.b1.TabIndex = 10
        Me.b1.Text = "DISPLAY"
        Me.b1.UseVisualStyleBackColor = True
        '
        'T3
        '
        Me.T3.Location = New System.Drawing.Point(24, 297)
        Me.T3.Multiline = True
        Me.T3.Name = "T3"
        Me.T3.Size = New System.Drawing.Size(373, 68)
        Me.T3.TabIndex = 11
        '
        'radio_checkbox
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(409, 396)
        Me.Controls.Add(Me.T3)
        Me.Controls.Add(Me.b1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.T2)
        Me.Controls.Add(Me.T1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "radio_checkbox"
        Me.Text = "radio_checkbox"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents T1 As System.Windows.Forms.TextBox
    Friend WithEvents T2 As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents CK_UG As System.Windows.Forms.CheckBox
    Friend WithEvents CK_PG As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents RB_OTHER As System.Windows.Forms.RadioButton
    Friend WithEvents RB_FEMALE As System.Windows.Forms.RadioButton
    Friend WithEvents RB_MALE As System.Windows.Forms.RadioButton
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents b1 As System.Windows.Forms.Button
    Friend WithEvents T3 As System.Windows.Forms.TextBox
End Class
