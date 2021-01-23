<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.statusStrip = New System.Windows.Forms.StatusStrip()
        Me.lblConnectionStatus = New System.Windows.Forms.ToolStripStatusLabel()
        Me.timerMain = New System.Windows.Forms.Timer(Me.components)
        Me.timerConnection = New System.Windows.Forms.Timer(Me.components)
        Me.KeyLabel = New System.Windows.Forms.Label()
        Me.statusStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'statusStrip
        '
        Me.statusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblConnectionStatus})
        Me.statusStrip.Location = New System.Drawing.Point(0, 35)
        Me.statusStrip.Name = "statusStrip"
        Me.statusStrip.Size = New System.Drawing.Size(351, 22)
        Me.statusStrip.TabIndex = 10
        Me.statusStrip.Text = "statusStrip1"
        '
        'lblConnectionStatus
        '
        Me.lblConnectionStatus.Name = "lblConnectionStatus"
        Me.lblConnectionStatus.Size = New System.Drawing.Size(104, 17)
        Me.lblConnectionStatus.Text = "Connection Status"
        '
        'timerMain
        '
        '
        'timerConnection
        '
        Me.timerConnection.Interval = 1000
        '
        'KeyLabel
        '
        Me.KeyLabel.AutoSize = True
        Me.KeyLabel.Location = New System.Drawing.Point(12, 11)
        Me.KeyLabel.Name = "KeyLabel"
        Me.KeyLabel.Size = New System.Drawing.Size(82, 13)
        Me.KeyLabel.TabIndex = 14
        Me.KeyLabel.Text = "Button Pressed:"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(351, 57)
        Me.Controls.Add(Me.KeyLabel)
        Me.Controls.Add(Me.statusStrip)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Text = "PWS530 FS2020 Adapter by Tyler T."
        Me.statusStrip.ResumeLayout(False)
        Me.statusStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents statusStrip As StatusStrip
    Private WithEvents lblConnectionStatus As ToolStripStatusLabel
    Private WithEvents timerMain As Timer
    Private WithEvents timerConnection As Timer
    Friend WithEvents KeyLabel As Label
End Class
