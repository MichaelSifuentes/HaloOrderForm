<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.MaxText1 = New MaxTextbox.MaxText()
        Me.lblMaxText = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'MaxText1
        '
        Me.MaxText1.Location = New System.Drawing.Point(89, 178)
        Me.MaxText1.Name = "MaxText1"
        Me.MaxText1.Size = New System.Drawing.Size(171, 41)
        Me.MaxText1.TabIndex = 0
        '
        'lblMaxText
        '
        Me.lblMaxText.AutoSize = True
        Me.lblMaxText.Location = New System.Drawing.Point(26, 184)
        Me.lblMaxText.Name = "lblMaxText"
        Me.lblMaxText.Size = New System.Drawing.Size(66, 13)
        Me.lblMaxText.TabIndex = 1
        Me.lblMaxText.Text = "Enter Name:"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(26, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(220, 127)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = resources.GetString("Label1.Text")
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblMaxText)
        Me.Controls.Add(Me.MaxText1)
        Me.Name = "frmMain"
        Me.Text = "Main Form"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MaxText1 As MaxTextbox.MaxText
    Friend WithEvents lblMaxText As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label

End Class
