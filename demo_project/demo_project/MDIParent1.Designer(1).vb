<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MDIParent1
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
        Me.components = New System.ComponentModel.Container
        Me.MenuStrip = New System.Windows.Forms.MenuStrip
        Me.FORMSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.DEPARTMENTToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.STUDENTToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ADMPAYToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.REPORTToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ADMISSIONPAYMENTREPORTToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.EXITToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.StatusStrip = New System.Windows.Forms.StatusStrip
        Me.ToolStripStatusLabel = New System.Windows.Forms.ToolStripStatusLabel
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.MenuStrip.SuspendLayout()
        Me.StatusStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip
        '
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FORMSToolStripMenuItem, Me.REPORTToolStripMenuItem, Me.EXITToolStripMenuItem})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(632, 24)
        Me.MenuStrip.TabIndex = 5
        Me.MenuStrip.Text = "MenuStrip"
        '
        'FORMSToolStripMenuItem
        '
        Me.FORMSToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DEPARTMENTToolStripMenuItem, Me.STUDENTToolStripMenuItem, Me.ADMPAYToolStripMenuItem})
        Me.FORMSToolStripMenuItem.Name = "FORMSToolStripMenuItem"
        Me.FORMSToolStripMenuItem.Size = New System.Drawing.Size(58, 20)
        Me.FORMSToolStripMenuItem.Text = "FORMS"
        '
        'DEPARTMENTToolStripMenuItem
        '
        Me.DEPARTMENTToolStripMenuItem.Name = "DEPARTMENTToolStripMenuItem"
        Me.DEPARTMENTToolStripMenuItem.Size = New System.Drawing.Size(148, 22)
        Me.DEPARTMENTToolStripMenuItem.Text = "DEPARTMENT"
        '
        'STUDENTToolStripMenuItem
        '
        Me.STUDENTToolStripMenuItem.Name = "STUDENTToolStripMenuItem"
        Me.STUDENTToolStripMenuItem.Size = New System.Drawing.Size(148, 22)
        Me.STUDENTToolStripMenuItem.Text = "STUDENT"
        '
        'ADMPAYToolStripMenuItem
        '
        Me.ADMPAYToolStripMenuItem.Name = "ADMPAYToolStripMenuItem"
        Me.ADMPAYToolStripMenuItem.Size = New System.Drawing.Size(148, 22)
        Me.ADMPAYToolStripMenuItem.Text = "ADM_PAY"
        '
        'REPORTToolStripMenuItem
        '
        Me.REPORTToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ADMISSIONPAYMENTREPORTToolStripMenuItem})
        Me.REPORTToolStripMenuItem.Name = "REPORTToolStripMenuItem"
        Me.REPORTToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.REPORTToolStripMenuItem.Text = "REPORT"
        '
        'ADMISSIONPAYMENTREPORTToolStripMenuItem
        '
        Me.ADMISSIONPAYMENTREPORTToolStripMenuItem.Name = "ADMISSIONPAYMENTREPORTToolStripMenuItem"
        Me.ADMISSIONPAYMENTREPORTToolStripMenuItem.Size = New System.Drawing.Size(238, 22)
        Me.ADMISSIONPAYMENTREPORTToolStripMenuItem.Text = "ADMISSION PAYMENT REPORT"
        '
        'EXITToolStripMenuItem
        '
        Me.EXITToolStripMenuItem.Name = "EXITToolStripMenuItem"
        Me.EXITToolStripMenuItem.Size = New System.Drawing.Size(42, 20)
        Me.EXITToolStripMenuItem.Text = "EXIT"
        '
        'StatusStrip
        '
        Me.StatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel})
        Me.StatusStrip.Location = New System.Drawing.Point(0, 431)
        Me.StatusStrip.Name = "StatusStrip"
        Me.StatusStrip.Size = New System.Drawing.Size(632, 22)
        Me.StatusStrip.TabIndex = 7
        Me.StatusStrip.Text = "StatusStrip"
        '
        'ToolStripStatusLabel
        '
        Me.ToolStripStatusLabel.Name = "ToolStripStatusLabel"
        Me.ToolStripStatusLabel.Size = New System.Drawing.Size(39, 17)
        Me.ToolStripStatusLabel.Text = "Status"
        '
        'MDIParent1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(632, 453)
        Me.Controls.Add(Me.MenuStrip)
        Me.Controls.Add(Me.StatusStrip)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip
        Me.Name = "MDIParent1"
        Me.Text = "MDIParent1"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.StatusStrip.ResumeLayout(False)
        Me.StatusStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents ToolStripStatusLabel As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents StatusStrip As System.Windows.Forms.StatusStrip
    Friend WithEvents MenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents FORMSToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DEPARTMENTToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents STUDENTToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents REPORTToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EXITToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ADMPAYToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ADMISSIONPAYMENTREPORTToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
