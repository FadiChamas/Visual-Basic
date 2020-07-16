<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSmallWords
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
        Me.lstOut = New System.Windows.Forms.ListBox()
        Me.lblEnter = New System.Windows.Forms.Label()
        Me.txtEnter = New System.Windows.Forms.TextBox()
        Me.lblFound = New System.Windows.Forms.Label()
        Me.btnFind = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lstOut
        '
        Me.lstOut.FormattingEnabled = True
        Me.lstOut.ItemHeight = 18
        Me.lstOut.Location = New System.Drawing.Point(205, 56)
        Me.lstOut.Name = "lstOut"
        Me.lstOut.Size = New System.Drawing.Size(120, 184)
        Me.lstOut.TabIndex = 0
        '
        'lblEnter
        '
        Me.lblEnter.AutoSize = True
        Me.lblEnter.Location = New System.Drawing.Point(12, 9)
        Me.lblEnter.Name = "lblEnter"
        Me.lblEnter.Size = New System.Drawing.Size(187, 18)
        Me.lblEnter.TabIndex = 1
        Me.lblEnter.Text = "Enter a 5-letter word:"
        '
        'txtEnter
        '
        Me.txtEnter.Location = New System.Drawing.Point(205, 6)
        Me.txtEnter.Name = "txtEnter"
        Me.txtEnter.Size = New System.Drawing.Size(120, 26)
        Me.txtEnter.TabIndex = 2
        '
        'lblFound
        '
        Me.lblFound.AutoSize = True
        Me.lblFound.Location = New System.Drawing.Point(12, 56)
        Me.lblFound.Name = "lblFound"
        Me.lblFound.Size = New System.Drawing.Size(117, 18)
        Me.lblFound.TabIndex = 3
        Me.lblFound.Text = "Words found:"
        '
        'btnFind
        '
        Me.btnFind.Location = New System.Drawing.Point(15, 186)
        Me.btnFind.Name = "btnFind"
        Me.btnFind.Size = New System.Drawing.Size(96, 52)
        Me.btnFind.TabIndex = 4
        Me.btnFind.Text = "Find Words"
        Me.btnFind.UseVisualStyleBackColor = True
        '
        'frmSmallWords
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Aqua
        Me.ClientSize = New System.Drawing.Size(339, 250)
        Me.Controls.Add(Me.btnFind)
        Me.Controls.Add(Me.lblFound)
        Me.Controls.Add(Me.txtEnter)
        Me.Controls.Add(Me.lblEnter)
        Me.Controls.Add(Me.lstOut)
        Me.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.Name = "frmSmallWords"
        Me.Text = "Finding 3 Letter Words"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lstOut As ListBox
    Friend WithEvents lblEnter As Label
    Friend WithEvents txtEnter As TextBox
    Friend WithEvents lblFound As Label
    Friend WithEvents btnFind As Button
End Class
