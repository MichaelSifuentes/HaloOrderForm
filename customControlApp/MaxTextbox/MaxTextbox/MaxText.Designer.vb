<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MaxText
    Inherits System.Windows.Forms.UserControl

    'UserControl1 overrides dispose to clean up the component list.
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
        Me.txtMaxText = New System.Windows.Forms.TextBox
        Me.lbl1 = New System.Windows.Forms.Label
        Me.lbl2 = New System.Windows.Forms.Label
        Me.lbl3 = New System.Windows.Forms.Label
        Me.lbl4 = New System.Windows.Forms.Label
        Me.lbl5 = New System.Windows.Forms.Label
        Me.lbl6 = New System.Windows.Forms.Label
        Me.lblCharsLeft = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'txtMaxText
        '
        Me.txtMaxText.Location = New System.Drawing.Point(4, 4)
        Me.txtMaxText.MaxLength = 10
        Me.txtMaxText.Name = "txtMaxText"
        Me.txtMaxText.Size = New System.Drawing.Size(146, 20)
        Me.txtMaxText.TabIndex = 0
        '
        'lbl1
        '
        Me.lbl1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lbl1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl1.Location = New System.Drawing.Point(2, 27)
        Me.lbl1.Name = "lbl1"
        Me.lbl1.Size = New System.Drawing.Size(27, 9)
        Me.lbl1.TabIndex = 1
        Me.lbl1.Visible = False
        '
        'lbl2
        '
        Me.lbl2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lbl2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl2.Location = New System.Drawing.Point(27, 27)
        Me.lbl2.Name = "lbl2"
        Me.lbl2.Size = New System.Drawing.Size(27, 9)
        Me.lbl2.TabIndex = 2
        Me.lbl2.Visible = False
        '
        'lbl3
        '
        Me.lbl3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lbl3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl3.Location = New System.Drawing.Point(52, 27)
        Me.lbl3.Name = "lbl3"
        Me.lbl3.Size = New System.Drawing.Size(27, 9)
        Me.lbl3.TabIndex = 3
        Me.lbl3.Visible = False
        '
        'lbl4
        '
        Me.lbl4.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lbl4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl4.Location = New System.Drawing.Point(77, 27)
        Me.lbl4.Name = "lbl4"
        Me.lbl4.Size = New System.Drawing.Size(27, 9)
        Me.lbl4.TabIndex = 4
        Me.lbl4.Visible = False
        '
        'lbl5
        '
        Me.lbl5.BackColor = System.Drawing.Color.Red
        Me.lbl5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl5.Location = New System.Drawing.Point(102, 27)
        Me.lbl5.Name = "lbl5"
        Me.lbl5.Size = New System.Drawing.Size(27, 9)
        Me.lbl5.TabIndex = 5
        Me.lbl5.Visible = False
        '
        'lbl6
        '
        Me.lbl6.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lbl6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl6.Location = New System.Drawing.Point(125, 27)
        Me.lbl6.Name = "lbl6"
        Me.lbl6.Size = New System.Drawing.Size(27, 9)
        Me.lbl6.TabIndex = 6
        Me.lbl6.Visible = False
        '
        'lblCharsLeft
        '
        Me.lblCharsLeft.Location = New System.Drawing.Point(152, 4)
        Me.lblCharsLeft.Name = "lblCharsLeft"
        Me.lblCharsLeft.Size = New System.Drawing.Size(15, 19)
        Me.lblCharsLeft.TabIndex = 7
        '
        'UserControl1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.lblCharsLeft)
        Me.Controls.Add(Me.lbl6)
        Me.Controls.Add(Me.lbl5)
        Me.Controls.Add(Me.lbl4)
        Me.Controls.Add(Me.lbl3)
        Me.Controls.Add(Me.lbl2)
        Me.Controls.Add(Me.lbl1)
        Me.Controls.Add(Me.txtMaxText)
        Me.Name = "UserControl1"
        Me.Size = New System.Drawing.Size(171, 41)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtMaxText As System.Windows.Forms.TextBox
    Friend WithEvents lbl1 As System.Windows.Forms.Label
    Friend WithEvents lbl2 As System.Windows.Forms.Label
    Friend WithEvents lbl3 As System.Windows.Forms.Label
    Friend WithEvents lbl4 As System.Windows.Forms.Label
    Friend WithEvents lbl5 As System.Windows.Forms.Label
    Friend WithEvents lbl6 As System.Windows.Forms.Label
    Friend WithEvents lblCharsLeft As System.Windows.Forms.Label

End Class
